using demo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace demo.Pages
{
    public class ContrattiModel : PageModel
    {
        [BindProperty]
        public List<Contratto> contrattos { get; set; }
        public ContrattiModel()
        {

            contrattos = new List<Contratto> { };



        }

  List<Contratto> contrattoList = new List<Contratto>
        {
        };
      


        public void OnGet()
        {
        }
    }
}
