using AutoMapper;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities.Clinic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace UI.Web.Pages.Dashboard
{
    public class CreateModel : PageModel
    {
        public class InputModel
        {
            [Required]
            [Display(Name ="FirstName",Prompt ="First Name")]
            public required string FirstName { get; set; }

            [Required]
            [Display(Name = "LastName", Prompt ="Last Name")]
            public required string LastName { get; set; }

            [Required]
            [Display(Name = "Id", Prompt = "Id")]
            public required int Id { get; set; }

            [Required]
            [Display(Name = "DateOfBirth",Prompt ="DateOfBirth")]
            public DateTime DateOfBirth { get; set; }


            [Required]
            [Display(Name = "PhoneNumber",Prompt ="PhoneNumber")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Email", Prompt = "Email")]
            public string Email { get; set; }

            [Display(Name = "Date", Prompt = "Date")]
            public DateTime Date { get; set; }


            [Display(Name = "Address",Prompt ="Address")]
            public string Address { get; set; }


            [Display(Name = "Choose your dentist", Prompt = "Choose your dentist")]
            public string DentistName { get; set; }

        }
        [BindProperty]
        public InputModel? Input { get; set; }
        public SelectList? Dentists { get; set; }
        private readonly IClinicService service;

        public CreateModel(IClinicService service,IMapper mapper)
        {
            this.service = service;
            Dentists = new SelectList(service.GetDentistsAsync().Result, "Id", "Name");
        }

        public async Task OnGetAsync()
        {
            var dentists = await service.GetDentistsAsync();
            Dentists = new SelectList(dentists, "Id", "Name");
        }

        public async Task OnPostAsync()
        {
            await service.CreatePatientAsync(new Patient
            {
                FirstName = Input.FirstName,
                LastName = Input.LastName,
                Id = Input.Id,
                DateOfBirth = Input.DateOfBirth,
                PhoneNumber = Input.PhoneNumber,
                Email = Input.Email,
                Date = Input.Date,
                Address = Input.Address,
                DentistName = Input.DentistName,
            });
            RedirectToPage("index");
        }
    }
}
