using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Web.Pages.Dashboard
{
    public class IndexModel : PageModel
    {
        private readonly IClinicService service;

        public IndexModel(IClinicService service)
        {
            this.service = service;
        }

        public IEnumerable<PatientListItem> Patients { get; private set; }  

        public async Task OnGetAsync()
        {
            Patients = await service.GetPatientsAsync();
        }
    }
}
