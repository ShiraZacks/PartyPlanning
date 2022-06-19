using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PartyPlan.Models;
using PartyPlan.Services;

namespace PartyPlan.Pages
{
    public class PartyModel : PageModel
    {
        [BindProperty]
        public Party NewParty { get; set; } = new();
        public List<Party> parties = new();
        public void OnGet() 
        {
            parties = PartyService.GetAll();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            PartyService.Add(NewParty);
            return RedirectToAction("Get");
        }
        public IActionResult OnPostDelete(int id)
        {
            PartyService.Delete(id);
            return RedirectToAction("Get");
        }   
        public string GlutenFreeText(Party party)
        {
            if (party.IsGlutenFree)
                return "Gluten Free";
            return "Not Gluten Free";
        }
    }
}