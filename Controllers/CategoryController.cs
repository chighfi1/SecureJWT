using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecureJWT.EntityClasses;
using SecureJWT.Models;
using System.Linq;

namespace SecureJWT.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CategoryController : AppControllerBase {
    public CategoryController(ILogger<ProductController> logger, PtcDbContext context) {
      _logger = logger;
      _DbContext = context;
    }

    private readonly PtcDbContext _DbContext;
    private readonly ILogger<ProductController> _logger;

    [HttpGet]
    public IActionResult Get() {
      IActionResult ret = null;
      List<Category> list = new List<Category>();

      try {
        if (_DbContext.Categories.Count() > 0) {
          list = _DbContext.Categories.OrderBy(p => p.CategoryName).ToList();
          ret = StatusCode(StatusCodes.Status200OK, list);
        } else {
          ret = StatusCode(
            StatusCodes.Status404NotFound,
              "No Categories exist in the system.");
        }
      } catch (Exception ex) {
        ret = HandleException(ex,
            "Exception trying to get all categories");
      }

      return ret;
    }
  }
}
