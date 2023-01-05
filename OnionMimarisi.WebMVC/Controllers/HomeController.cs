using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using OnionMimarisi.Application.Features.Commands.CategoryFeature.CreateCategory;
using OnionMimarisi.Application.Features.Commands.OrderFeature.ReadXMLFileToCustomerOrder;
using OnionMimarisi.Application.Features.Commands.OrderFeature.RemoveById;
using OnionMimarisi.Application.Features.Commands.OrderFeature.UpdateOrder;
using OnionMimarisi.Application.Features.Commands.ProductFeature.CreateProduct;
using OnionMimarisi.Application.Features.Commands.UserFeature.CreateUser;
using OnionMimarisi.Application.Features.Queries.OrderFeature.GetAllOrder;
using OnionMimarisi.Application.Features.Queries.OrderFeature.GetById;
using OnionMimarisi.Application.Features.Queries.ProductFeature.GetAllProduct;
using OnionMimarisi.Domain.Dtos;
using OnionMimarisi.Domain.Entities;
using OnionMimarisi.WebMVC.Models;
using System.Diagnostics;
using System.Globalization;

namespace OnionMimarisi.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            GetAllOrderQueryRequest request = new();
            var result = await _mediator.Send(request);
            return View(result.Orders.ToList());
        }

        public async Task<IActionResult> GetByOrderId(int id)
        {
            GetByOrderIdQueryRequest request = new();
            request.Id = id;
            var result = await _mediator.Send(request);
            return View(result.Order);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommandRequest request)
        {
            await _mediator.Send(request);
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public async Task<IActionResult> RemoveOrderById(int id)
        {
            RemoveByIdCommandRequest request = new();
            request.Id = id;
            await _mediator.Send(request);
            return RedirectToAction("Index", "Home");
        }
      

        [HttpPost]
        public async Task<IActionResult> FileSave(ReadXMLCommandRequest request)
        {
            if(request.File == null) return RedirectToAction("Index", "Home");

            await _mediator.Send(request);

            return RedirectToAction("Index", "Home");
        }


    }
}