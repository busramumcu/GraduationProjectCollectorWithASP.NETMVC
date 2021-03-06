﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Projesi.Models;

namespace Web_Projesi.Controllers
{
    public class LoggedDanismanController : Controller
    {
        [Authorize(Roles = "Danisman")]
        // GET: LoggedDanisman
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Danisman")]
        public ActionResult BilgileriniDuzenle()
        {
            using (TezProjectEntities db = new TezProjectEntities())
            {
                ViewBag.Message = TempData["Message"];
                DanismanModel omodel = new DanismanModel();
                string username = User.Identity.Name;
                omodel.kdanisman = db.Kullanicis.Where(x => x.Kullanici_Adi.Equals(username)).FirstOrDefault();
                omodel.danisman = db.Ogretim_Uyesi.Where(x => x.Kullanici_Id.Equals(omodel.kdanisman.Kullanici_Id)).FirstOrDefault();
                return View(omodel);
            }
        }


        [HttpPost]
        public ActionResult BilgileriGuncelle(string Unvan, string Ad, string Soyad, string Sifre, string Email)
        {
            using (TezProjectEntities db = new TezProjectEntities())
            {
                string username = User.Identity.Name;
                Kullanici kullanici = db.Kullanicis.Where(x => x.Kullanici_Adi.Equals(username)).FirstOrDefault();
                Ogretim_Uyesi danisman = db.Ogretim_Uyesi.Where(x => x.Kullanici_Id.Equals(kullanici.Kullanici_Id)).FirstOrDefault();
                danisman.Unvan = Unvan;
                kullanici.Ad = Ad;
                kullanici.Soyad = Soyad;
                kullanici.Sifre = Sifre;
                kullanici.Email = Email;
                db.SaveChanges();
                TempData["Message"] = "Güncelleme İşlemi Başarılı";
                return RedirectToAction("BilgileriniDuzenle");
            }
        }
        [Authorize(Roles = "Danisman")]
        // GET: LoggedDanisman
        public ActionResult GorevBilgisiListele()
        {
            using (TezProjectEntities db = new TezProjectEntities())
            {
               var model = db.Gorevs.ToList();
                return View(model);
            }
        }
        [Authorize(Roles = "Danisman")]
        public ActionResult GorevAyrinti(int gorev_Id)
        {
            using (TezProjectEntities db = new TezProjectEntities())
            {
                GorevAyrintiModel gayrinti = new GorevAyrintiModel();
                // O görev için Dosya yükleyen Öğrencileri listele. Öğrenciye tıklayinca yuklediği dosyayı indirme sayfası açılsın
               List<Dosya>  dosyalar = db.Dosyas.Where(x => x.Gorev_Id == gorev_Id).ToList();
                int currentDanisman_Id = db.Kullanicis.Where(x => x.Kullanici_Adi == User.Identity.Name).FirstOrDefault().Kullanici_Id;

                foreach (Dosya dosya in dosyalar)
                {
                    Kullanici kullanici = db.Kullanicis.Where(x => x.Kullanici_Id == dosya.Kullanici_Id).FirstOrDefault();
                    Tez tez = db.Tezs.Where(x => x.Ogrenci_Id == kullanici.Kullanici_Id && x.Danisman_Id == currentDanisman_Id).FirstOrDefault();
                        if (tez != null)
                        {
                            gayrinti.dosyaYukleyenKullanicilar.Add(kullanici);
                        }

                }

                gayrinti.Gorev_Id = gorev_Id;
                return View(gayrinti);
            }
        }

        [Authorize(Roles = "Danisman")]
        public ActionResult DosyaIndır(int kullanici_Id,int gorev_Id)
        {
            using (TezProjectEntities db = new TezProjectEntities())
            {

                Dosya dosya =  db.Dosyas.Where(x => x.Gorev_Id == gorev_Id && x.Kullanici_Id == kullanici_Id).FirstOrDefault();
                //return File("~/Content/MyFile.pdf", "application/pdf", "MyRenamedFile.pdf");
                return File(dosya.Yukleme_Yeri,dosya.Dosya_Uzantisi,dosya.Dosya_Adi);

            }
        }
    }
}