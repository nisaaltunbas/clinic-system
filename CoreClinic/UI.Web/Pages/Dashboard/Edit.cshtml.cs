using Core.Abstracts.IServices;
using Core.Concretes.Entities.Clinic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Pages.Dashboard
{
    public class EditModel : PageModel
    {
        public class InputModel
        {
            [Required]
            [Display(Name = "FirstName", Prompt = "First Name")]
            public required string FirstName { get; set; }

            [Required]
            [Display(Name = "LastName", Prompt = "Last Name")]
            public required string LastName { get; set; }

            [Required]
            [Display(Name = "Id", Prompt = "Id")]
            public required int Id { get; set; }

            [Required]
            [Display(Name = "DateOfBirth", Prompt = "DateOfBirth")]
            public DateTime DateOfBirth { get; set; }


            [Required]
            [Display(Name = "PhoneNumber", Prompt = "PhoneNumber")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Email", Prompt = "Email")]
            public string Email { get; set; }

            [Display(Name = "Date", Prompt = "Date")]
            public DateTime Date { get; set; }


            [Display(Name = "Address", Prompt = "Address")]
            public string Address { get; set; }


            [Required]
            [Display(Name = "Choose your dentist", Prompt = "Choose your dentist")]
            public string DentistName{ get; set; }

        }
        [BindProperty]
        public InputModel? Input { get; set; }
        public SelectList? Dentists { get; set; }
        private readonly IClinicService service;

        public EditModel(IClinicService service)
        {
            this.service = service;
        }

        
        public async Task OnGetAsync(int id)
        {
            var patient = await service.GetPatientAsync(id);
            Input = new InputModel
            {
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                Id = patient.Id,
                DateOfBirth = patient.DateOfBirth,
                PhoneNumber = patient.PhoneNumber,
                Email = patient.Email,
                Date = patient.Date,
                Address = patient.Address,
                DentistName = patient.DentistName,

            };
            Dentists = new SelectList(await service.GetDentistsAsync(), "Id", "Name",patient.DentistName);
        }
    }
}
