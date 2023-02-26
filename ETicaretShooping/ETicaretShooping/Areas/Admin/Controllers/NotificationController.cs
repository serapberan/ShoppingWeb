using AutoMapper;
using Business.Abstract;
using DTO.DTOs.NotificationDTOs;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class NotificationController : Controller
    {
        private readonly INotificationsService _notificationsService;
        private readonly IMapper _mapper;

        public NotificationController(INotificationsService notificationsService, IMapper mapper)
        {
            _notificationsService = notificationsService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<NotificationListDto>>(_notificationsService.TList());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNotification()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNotification(NotificationAddDto n)
        {
            if (ModelState.IsValid)
            {
                _notificationsService.TAdd(new Notifications()
                {
                    Content = n.Content,
                    Title = n.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index");
            }
            return View(n);
           
        }

        public IActionResult DeleteNotification(int id)
        {
            var values = _notificationsService.TGetById(id);
            _notificationsService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateNotification(int id)
        {
            var values = _mapper.Map<NotificationUpdateDto>(_notificationsService.TGetById(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateNotification(NotificationUpdateDto n)
        {
            if (ModelState.IsValid)
            {
                _notificationsService.TUpdate(new Notifications
                {
                    NotificationsId = n.NotificationsId ,
                    Title = n.Title,
                    Content = n.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(n);
        }
    }
}
