using BankEmployment.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankEmployment.Web.Pages.Employee
{
    public class AddModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;
        public AddModel(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }
        public string Message { get; set; }
        [BindProperty]
        public Domain.Entities.Employee Employee { get; set; }
        public void OnGet()
        {
            
        }
        public async Task<ActionResult> OnPost()
        {
            var result= await _employeeRepository.Add(Employee);
            if (result) result =await _unitOfWork.Commit();
            Message = result == true ? "1 Record add and Saved." : "Error!";
            return Page();
        }
    }
}
