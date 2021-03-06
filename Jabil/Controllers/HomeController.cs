﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jabil.Models;
using Jabil.ViewModels;

namespace Jabil.Controllers
{
	public class HomeController : Controller
	{
		private JabilModel _db;
		public HomeController()
		{
			_db = new JabilModel();
		}

		public ActionResult Index()
		{
			IEnumerable<MainReport> data = (from part in _db.PartNumbers
							   join customer in _db.Customers on part.FKCustomer equals customer.PKCustomers 
							   into cp from partcustomer in cp.DefaultIfEmpty()
							   join building in _db.Buildings on partcustomer.FKBuilding equals building.PKBuilding 
							   into bg from buildingGroup in bg.DefaultIfEmpty()
							   select new MainReport{
								   NumberPart = part.PartNumber1,
								   Availability = part.Available,
								   Customer = partcustomer.Customer1 != null ? partcustomer.Prefix +" "+ partcustomer.Customer1 : string.Empty,
								   Building = buildingGroup.Building1 != null ? buildingGroup.Building1 : string.Empty
							   });

			ViewBag.buildings = _db.Buildings.Count();
			ViewBag.customers = _db.Customers.Count();
			ViewBag.parts = _db.PartNumbers.Count();
			return View(data);
		}

		public ActionResult About()
		{
			ViewBag.Message = "This application is just a test.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Eng. Luis Raúl Espinoza Barboza.";

			return View();
		}
	}
}