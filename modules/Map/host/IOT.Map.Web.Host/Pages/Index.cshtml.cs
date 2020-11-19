using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace IOT.Map.Pages
{
    public class IndexModel : MapPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}