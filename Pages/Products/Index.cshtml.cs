using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Data;
using SimpleWebApp.Models;

namespace SimpleWebApp.Pages.Products;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    public IndexModel(AppDbContext context) => _context = context;

    public IList<Product> Products { get; set; } = [];

    public async Task OnGetAsync()
    {
        Products = await _context.Products.ToListAsync();
    }
}
