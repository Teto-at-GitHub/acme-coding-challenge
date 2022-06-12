using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Acme.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
   private readonly ILogger<ProductController> _logger;

   public ProductController(ILogger<ProductController> logger)
   {
      _logger = logger;
   }

}
