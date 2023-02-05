using ETicaretShooping.CQRS.Commands.ProductCommands;
using ETicaretShooping.CQRS.Handlers.ProductHandlers;
using ETicaretShooping.CQRS.Queries.ProductQueries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CQRSProductController : Controller
    {
        private readonly GetAllProductQueryHandler _getAllProductQueryHandler;
        private readonly GetByIdProductQueryHandler _getByIdProductQueryHandler;
        private readonly CreateProductCommandHanler _createProductCommandHanler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;



        public CQRSProductController(GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler, CreateProductCommandHanler createProductCommandHanler, UpdateProductCommandHandler updateProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler )
        {
            _getAllProductQueryHandler = getAllProductQueryHandler;
            _getByIdProductQueryHandler = getByIdProductQueryHandler;
            _createProductCommandHanler = createProductCommandHanler;
            _updateProductCommandHandler = updateProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;


        }

        public IActionResult Index()
        {
            var values = _getAllProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetByIdProduct(int id)
        {
            var values = _getByIdProductQueryHandler.Handle(new GetByIdProductQuery(id));
            return View(values);
        }


        [HttpPost]
        public IActionResult GetByIdProduct(ProductUpdateCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductCreateCommand command)
        {
            _createProductCommandHanler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            _deleteProductCommandHandler.Handle(new ProductDeleteCommand(id));
            return RedirectToAction("Index");
        }
    }
}
