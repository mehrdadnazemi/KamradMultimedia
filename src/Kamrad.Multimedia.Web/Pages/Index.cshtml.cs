using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Kamrad.Multimedia.Web.Pages
{
    public class IndexModel : MultimediaPageModel
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