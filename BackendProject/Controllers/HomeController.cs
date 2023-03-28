﻿
using BackendProject.DAL;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BackendProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            HomeVM  homeVM= new HomeVM();
           homeVM.Sliders =_appDbContext.Sliders.ToList();
            return View(homeVM);
        }

      
    }
}