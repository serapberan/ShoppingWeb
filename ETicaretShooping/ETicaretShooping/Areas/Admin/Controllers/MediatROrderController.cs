using ETicaretShooping.CQRS.Queries.OrderQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MediatROrderController : Controller
    {
        private readonly IMediator _mediator;

        public MediatROrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllOrderQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetOrder(int id)
        {
            var values = await _mediator.Send(new GetByIdOrderQuery(id));
            return View(values);
        }
    }
}
