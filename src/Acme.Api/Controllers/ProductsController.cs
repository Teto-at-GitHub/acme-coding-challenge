using Acme.Api.Dtos;
using Acme.Domain.AggregatesModel.ProductAggregate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Acme.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
   private readonly ILogger<ProductsController> _logger;

   private readonly IProductRepository _productRepository;

   public ProductsController(ILogger<ProductsController> logger, IProductRepository productRepository)
   {
      _logger = logger;
      _productRepository = productRepository;
   }

   [HttpPost]
   public async Task<ActionResult> CreateProductAsync(ProductDtoIn productDtoIn)
   {
      // TODO
      // check if the given warehouse reference points to an existing one

      var product = new Product(
         productDtoIn.Name,
         productDtoIn.Description,
         productDtoIn.DangerLevel,
         productDtoIn.Price,
         0
      );

      _productRepository.Add(product);

      await _productRepository.UnitOfWork.SaveEntitiesAsync();

      return NoContent();
   }
}
