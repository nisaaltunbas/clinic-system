using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly IClinicService service;

        public IndexModel(ILogger<IndexModel> logger, IClinicService service)
        {
            this.logger = logger;
            this.service = service;
        }

        public IEnumerable<PatientListItem> Patients { get; set; } = new HashSet<PatientListItem>();

        
 
        public async Task OnGetAsync()
        {
            Patients = await service.GetPatientsAsync();
        }
    }
}
