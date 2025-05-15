using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleWebApp.Data;
using SimpleWebApp.Models;

namespace SimpleWebApp.Pages.Products;

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;
    public CreateModel(AppDbContext context) => _context = context;

    [BindProperty]
    public Product Product { get; set; } = new();

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        _context.Products.Add(Product);
        await _context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}
