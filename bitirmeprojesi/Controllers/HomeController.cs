using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bitirmeprojesi.Models;
using System.Web.Helpers;

namespace bitirmeprojesi.Controllers
{
    public class HomeController : Controller
    {

        bitirme_projesiEntities0 db = new bitirme_projesiEntities0();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult insaatHesaplamaGiris()
        {
            ViewBag.Message = "ada parsel.";

            return View();
        }
        [HttpGet]
        public ActionResult Eimar(FormCollection form)
        {

            mahalleler model = new mahalleler();

            var veriler = db.mahalleler.ToList();
            return View(veriler);
        }
        [HttpPost]
        public ActionResult Eimar(string ilce, string mahalle, int ada_no, int parsel_no)
        {

            var bilgiler = db.ozgurluk.FirstOrDefault(x => x.ada_no == ada_no && x.parsel_no == parsel_no);

            if (bilgiler != null)
            {
                return View("eimar", "Result", bilgiler);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Contact(FormCollection form)
        {
            contact model = new contact();
            model.name = form["yourName"].Trim();
            model.email = form["email"].Trim();
            model.subject = form["subject"].Trim();
            model.message = form["message"].Trim();
            model.created_at = DateTime.Now;
            db.contact.Add(model);
            db.SaveChanges();
            if (model.id != null)
            {
                ViewBag.Uyari = "Mesajınız başarıyla gönderildi.";

            }
            else
            {
                ViewBag.Uyari = "Hata oluştu. Tekrar deneyiniz.";
            }
            return View();
        }

        [HttpGet]
        public ActionResult insaatHesaplamaGiris(FormCollection form)
        {

            mahalleler model = new mahalleler();

            var veriler = db.mahalleler.ToList();
            return View(veriler);
        }

        [HttpPost]
        public ActionResult insaatHesaplamaGiris(int ada_no, int parsel_no)
        {

            var bilgilerInsaat = db.ozgurluk.FirstOrDefault(x => x.ada_no == ada_no && x.parsel_no == parsel_no);

            if (bilgilerInsaat != null)
            {
                return View("insaatHesaplamaSonuc", "Result", bilgilerInsaat);
            }
            else
            {
                return View();
            }
        }

    }
}