using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionMimarisi.Application.Features.Commands.CategoryFeature.CreateCategory;
using OnionMimarisi.Application.Features.Commands.ProductFeature.CreateProduct;
using OnionMimarisi.Application.Features.Commands.UserFeature.CreateUser;
using OnionMimarisi.Application.Features.Queries.ProductFeature.GetAllProduct;
using OnionMimarisi.Domain.Entities;
using OnionMimarisi.WebMVC.Models;
using System.Diagnostics;

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
            CreateCategoryCommandRequest categoryrequest = new();
            categoryrequest.Name = "sebze";

            CreateCategoryCommandResponse response = await _mediator.Send(categoryrequest);
            if (!response.Success) ViewBag.Hata = response.Message;

            //CreateProductCommandRequest request = new();
            //request.Name = "Deneme";
            //request.CategoryId = "16390ba5-0490-43b2-ad0f-7a4bbbf2749d";

            //await _mediator.Send(request);

            //GetAllProductQueryRequest getAllRequest = new();
            //GetAllProductQueryResponse products = await _mediator.Send(getAllRequest);

            //var result = products.Products.ToList();
            return View();
        }
       
    }
}