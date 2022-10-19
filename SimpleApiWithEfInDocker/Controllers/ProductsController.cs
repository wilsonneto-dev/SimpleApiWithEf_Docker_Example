using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SimpleApiWithEfInDocker.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private AppContextDb _db;

    public ProductsController(AppContextDb db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _db.Products.ToListAsync());

    [HttpPost]
    public async Task<IActionResult> Post(Product product)
    {
        await _db.Products.AddAsync(product);
        await _db.SaveChangesAsync();
        return Created(String.Empty, product);
    }
}
