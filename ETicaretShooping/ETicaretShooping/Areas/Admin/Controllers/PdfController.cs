using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ETicaretShooping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfController : Controller
    {
        IOrderService _orderService;
        IPdfService _pdfService;
        public PdfController(IOrderService orderService, IPdfService pdfService)
        {
            _orderService = orderService;
            _pdfService = pdfService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BillsList()
        {
            //List<Order> orderBillsViewModels = new List<Order>();
            //using (var db = new Context())
            //{
            ////    orderBillsViewModels = db.Orders.Select(x => new Order
            ////    {
            ////        OrderNo = x.OrderNo,
            ////        Date = x.Date,
            ////        ProductPrice = x.ProductPrice,
            ////        Quantity = x.Quantity,
            ////        AppUserId = x.AppUserId,
            ////        Address = x.Address,
            ////        City = x.City

            ////    }).ToList();

            ////    var Total = db.Orders.Sum(x => x.ProductPrice * x.Quantity);
            ////    Total = Math.Round(Total);
            ////    ViewBag.Total = "Toplam Tutar =" + Total + " TL";
            ////}
            //return orderBillsViewModels;

            var values = _orderService.TList();
         
            return View(values);

        }

        //public IActionResult StaticPdfReport()
        //{
        //    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
        //    var stream = new FileStream(path, FileMode.Create);

        //    Document document = new Document(PageSize.A4);
        //    PdfWriter.GetInstance(document, stream);

        //    document.Open();

        //    PdfPTable pdfPTable = new PdfPTable(9);

        //    pdfPTable.AddCell("Sipariş No");
        //    pdfPTable.AddCell("Tarih");
        //    pdfPTable.AddCell("Ürün");
        //    pdfPTable.AddCell("Fiyat");
        //    pdfPTable.AddCell("Adet");
        //    pdfPTable.AddCell("Müşteri Adı");
        //    pdfPTable.AddCell("Adres");
        //    pdfPTable.AddCell("Şehir");
        //    pdfPTable.AddCell("Toplam Tutar");

           
        //        foreach (var item in BillsList())
        //        {
        //            pdfPTable.AddCell(new ("OrderNo"));
        //            pdfPTable.AddCell("Tarih");
        //            pdfPTable.AddCell("Ürün");
        //            pdfPTable.AddCell("Fiyat");
        //            pdfPTable.AddCell("Adet");
        //            pdfPTable.AddCell("Müşteri Adı");
        //            pdfPTable.AddCell("Adres");
        //            pdfPTable.AddCell("Şehir");
        //            pdfPTable.AddCell("Toplam Tutar");
        //        }
         
        //    pdfPTable.AddCell("Misafir Adı");
        //    pdfPTable.AddCell("Misafir Soyadı");
        //    pdfPTable.AddCell("Misafir TC");

        //    pdfPTable.AddCell("Eylül");
        //    pdfPTable.AddCell("Yücedağ");
        //    pdfPTable.AddCell("11111111110");

        //    pdfPTable.AddCell("Kemal");
        //    pdfPTable.AddCell("Yıldırım");
        //    pdfPTable.AddCell("22222222222");

        //    pdfPTable.AddCell("Mehmet");
        //    pdfPTable.AddCell("Yücedağ");
        //    pdfPTable.AddCell("44444444445");


        //    document.Add(paragraph);
        //    document.Close();
        //    return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        //}
    }
}
