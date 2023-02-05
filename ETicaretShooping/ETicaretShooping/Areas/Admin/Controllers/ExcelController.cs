using Business.Abstract;
using ClosedXML.Excel;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExcelController : Controller
    {
        IOrderService _orderService;
        IExcelService _excelService;
        public ExcelController(IOrderService orderService, IExcelService excelService)
        {
            _orderService = orderService;
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<Order> BillsList()
        {
            List<Order> orderBillsViewModels = new List<Order>();
            using (var db = new Context())
            {
                orderBillsViewModels = db.Orders.Select(x => new Order
                {
                    OrderNo = x.OrderNo,
                    Date = x.Date,
                    ProductPrice = x.ProductPrice,
                    Quantity = x.Quantity,
                    AppUserId = x.AppUserId,
                    Address = x.Address,
                    City = x.City

                }).ToList();

                var Total = db.Orders.Sum(x => x.ProductPrice * x.Quantity);
                Total = Math.Round(Total);
                ViewBag.Total = "Toplam Tutar =" + Total + " TL";
            }
            return orderBillsViewModels;
        }

        //public IActionResult StaticExcelReport()
        //{
        //    return File(_excelService.ExcelList(BillsList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
        //    //application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
        //}

        public IActionResult BillsExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Fatura");

                workSheet.Cell(1, 1).Value = "Sipariş No";
                workSheet.Cell(1, 2).Value = "Tarih";
                workSheet.Cell(1, 3).Value = "Ürün";
                workSheet.Cell(1, 4).Value = "Fiyat";
                workSheet.Cell(1, 5).Value = "Adet";
                workSheet.Cell(1, 6).Value = "Müşteri Adı";
                workSheet.Cell(1, 7).Value = "Adres";
                workSheet.Cell(1, 8).Value = "Şehir";
                workSheet.Cell(1, 9).Value = "Toplam Tutar";

                int rowCount = 2;  //2 satıra geç 
                foreach (var item in BillsList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.OrderNo;
                    workSheet.Cell(rowCount, 2).Value = item.Date;
                    workSheet.Cell(rowCount, 3).Value = item.ProductId;
                    workSheet.Cell(rowCount, 4).Value = item.ProductPrice;
                    workSheet.Cell(rowCount, 5).Value = item.Quantity;
                    workSheet.Cell(rowCount, 6).Value = item.AppUserId;
                    workSheet.Cell(rowCount, 7).Value = item.Address;
                    workSheet.Cell(rowCount, 8).Value = item.City;
                    workSheet.Cell(rowCount, 9).Value = ViewBag.Total;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Fatura.xlsx");
                }
            }

        }

      

    }
}
