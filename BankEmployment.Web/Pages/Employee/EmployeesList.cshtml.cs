using BankEmployment.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankEmployment.Web.Pages.Employee
{
    public class EmployeesListModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;
        public EmployeesListModel(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }
        public string Message { get; set; }
        [BindProperty] public List<Domain.Entities.Employee> Employees { get; set; }
        public async Task OnGet(string message)
        {
            Employees = await _employeeRepository.GetAll();
            Message=message;
        }
        public async Task<IActionResult> OnPost()
        {
            Employees = await _employeeRepository.GetAll();
            try
            {
                var result=_employeeRepository.Delete(Employees[0]);
                if (result) await _unitOfWork.Commit();
                Employees = await _employeeRepository.GetAll();
                return RedirectToPage("EmployeesList", new { message = "an employee deleted." });
            }
            catch (Exception e)
            {
                return RedirectToPage("../index", new { message = "You have no employees." });
            }
        }
    }
}
