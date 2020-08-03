using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DapperDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DapperDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IConfiguration _config;

        internal string DbConnectionString => _config.GetConnectionString("DBModel");
        internal IDbConnection DbConnection => new SqlConnection(DbConnectionString);
        public EmployeeController(ILogger<EmployeeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();


        }

        public ActionResult GetEmployee(int id)
        {
            Employee emp = DbConnection.QueryFirstOrDefault<Employee>("EmployeeGet ", new { EmployeeId = id }, commandType: CommandType.StoredProcedure);

            return View(emp);
        }

        public ActionResult Update(Employee empModel)
        {
            DbConnection.Execute("EmployeeUpdate",
             new
             {
                 FirstName = empModel.FirstName,
                 LastName = empModel.LastName,
                 DepartmentId = empModel.DepartmentId,
                 Address1 = empModel.Address1,
                 Address2 = empModel.Address2,
                 City = empModel.City,
                 State = empModel.State,
                 Country = empModel.Country,
                 PostalCode = empModel.PostalCode,
                 Email = empModel.Email,
                 ConfirmEmail = empModel.ConfirmEmail,
                 DOB = empModel.DOB,
                 Salary = empModel.Salary,
                 IsPermanent = empModel.IsPermanent,
                 Gender = empModel.Gender,
                 EmployeeId = empModel.EmployeeId
             }, commandType: CommandType.StoredProcedure);

            return View();
        }

        public ActionResult EmployeeSummary()
        {
            IList<EmployeeSummary> empSummary = DbConnection.Query<EmployeeSummary, Department, EmployeeSummary>("[GetEmployeesSummary]",
                (emp, dept) => { emp.Department = dept; return emp; },
                splitOn: "EmployeeId,DepartmentId").ToList();

            return View(empSummary);
        }
    }
}
