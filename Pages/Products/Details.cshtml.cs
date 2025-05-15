using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleWebApp.Data;
using SimpleWebApp.Models;

namespace SimpleWebApp.Pages.Products;

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;
    public DetailsModel(AppDbContext context) => _context = context;

    public Product Product { get; set; } = new();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Product = await _context.Products.FindAsync(id);
        return Product == null ? NotFound() : Page();
    }
}
