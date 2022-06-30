using BankEmployment.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankEmployment.Web.Pages.Employee
{
    public class EditModel : PageModel
    {
        private readonly  IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EditModel(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        [BindProperty] public Domain.Entities.Employee? Employee { get; set; }

        public async Task OnGet()
        {
                List<Domain.Entities.Employee> employees = await _employeeRepository.GetAll();
                if (employees.Count>0)
                {
                    int FirstIdOfEmployees = employees[0].id;
                    Employee = await _employeeRepository.GetById(FirstIdOfEmployees);
                }
        }

        public async Task<IActionResult> OnPost(string FirstNameBox)
        {

            List<Domain.Entities.Employee> employees = await _employeeRepository.GetAll();
            if (employees.Count>0)
            {
                int FirstIdOfEmployees = employees[0].id;
                Employee = await _employeeRepository.GetById(FirstIdOfEmployees);
                Employee.FirstName = FirstNameBox;
                _employeeRepository.Update(Employee);
                var result = await _unitOfWork.Commit();
                if (result) return RedirectToPage("EmployeesList" , new  {message="an employee edited."});
            }
            return RedirectToPage("../index", new { message = "Table is empty." });
        }
    }
}
