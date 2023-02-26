using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.Areas.Admin.Models;
using ETicaretShooping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETicaretShooping.Controllers
{

    [AllowAnonymous]
   
    public class CartController : Controller
    {
        private readonly Context _context;
        private readonly ICartService _cartService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<AppUser> _userManager;
        public CartController(Context context, ICartService cartService, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _cartService = cartService;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }


        }
    }