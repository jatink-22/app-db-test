using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using System.Threading.Tasks;

namespace MyWebApp.Pages
{
    public class TestConnectionModel : PageModel
    {
        private readonly AppDbContext _context;

        public TestConnectionModel(AppDbContext context)
        {
            _context = context;
        }

        public bool IsConnected { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                // Test the connection by querying the database
                IsConnected = await _context.Database.CanConnectAsync();
            }
            catch
            {
                IsConnected = false;
            }
        }
    }
}