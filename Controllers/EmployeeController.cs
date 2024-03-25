using DemoApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp1.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> Employees { get; set; }
         static  EmployeeController()
        {
            Employees = new List<Employee>() {
            new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "Tina",
                Gender = "Female",
                Designation = "associate Trainee",
                Salary = 45000
            },
            new Employee()
            {
                EmployeeId = 2,
                EmployeeName = "Uma",
                Gender = "Female",
                Designation = "Trainer",
                Salary = 48000
            },
            new Employee()
            {
                EmployeeId = 3,
                EmployeeName = "Isha",
                Gender = "Female",
                Designation = "software engineer",
                Salary = 54000
            },
        };

        }
        public IActionResult Index()
        {
            return View(Employees);
        }
        public IActionResult Details(int id)
        {
            Employee employee =null;
                employee=Employees.FirstOrDefault(emp => emp.EmployeeId == id);

            return View(employee);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            Employees.Add(employee);
            return  RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employee =Employees.FirstOrDefault(employee => employee.EmployeeId == id);

            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            foreach (var emp in Employees)
            {
                if(emp.EmployeeId==employee.EmployeeId)
                {
                    emp.EmployeeName=employee.EmployeeName;
                    emp.Designation=employee.Designation;
                    emp.Salary=employee.Salary;
                    emp.Gender=employee.Gender;
                }
            }
           
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            Employee employee = Employees.FirstOrDefault(employee => employee.EmployeeId == id);
            if (employee != null)
                return View(employee);
            else
                return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Employee employee = Employees.FirstOrDefault(employee => employee.EmployeeId == id);
            Employees.Remove(employee);
            return RedirectToAction("Index");
        }
        //public IActionResult Details()
        //{
        //    Employee employee = new Employee()
        //    {
        //        EmployeeId = 1,
        //        EmployeeName = "Tina",
        //        Gender = "Female",
        //        Designation = "associate Trainee",
        //        Salary = 45000
        //    };
        //    return View(employee);
        //}
    }
}
