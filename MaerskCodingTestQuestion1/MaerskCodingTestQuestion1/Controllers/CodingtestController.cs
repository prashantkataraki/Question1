using System.Collections.Generic;
using MaerskCodingTestQuestion1.Question1;
using MaerskCodingTestQuestion1.Services;
using Microsoft.AspNetCore.Mvc;

namespace MaerskCodingTestQuestion1.Controller
{
    [Route("api/test")]
    [ApiController]
    public class CodingtestController : ControllerBase
    {
        private readonly IProcessOrderService _processOrderService;
        public CodingtestController(IProcessOrderService processOrderService)
        {
            _processOrderService = processOrderService;
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult<string> Add(ProductViewModel product)
        {
            return _processOrderService.Add(product);
        }

        [HttpPost]
        [Route("Edit")]
        public ActionResult<string> Edit(ProductViewModel product)
        {
            return _processOrderService.Edit(product);
        }

        [HttpGet]
        [Route("Get")]
        public ActionResult<List<ProductViewModel>> GetProducts()
        {
            return _processOrderService.GetAllProducts();
        }

        [HttpGet]
        [Route("Calc")]
        public ActionResult<string> Calculatte()
        {
            return _processOrderService.Calculatte();
        }
    }
}
