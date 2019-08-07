using MVCGridPaging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Office.Interop.Excel;

namespace MVCGridPaging.Controllers
{
    public class EmplyeePageController : Controller
    {
        // GET: EmplyeePage
        public ActionResult Index()
        {
            //PagingEntities paging = new PagingEntities();

            //var emp = paging.Employees.Select(x => new GridData {Name=x.EmpName,Department=x.Department,JoiningDate=x.JoiningDate  } );
            //return View(emp);
            return View();
        }

        public ActionResult GridDataViewer()
        {
            PagingEntities paging = new PagingEntities();

            var emp = paging.Employees.Select(x => new GridData { EmpID=x.EmpID, Name = x.EmpName, Department = x.Department, JoiningDate = x.JoiningDate }).ToList();
            return View(emp);
        }

        public ActionResult AddtoExcel(int id)
        {
            PagingEntities paging = new PagingEntities();

            var empl = paging.Employees.SingleOrDefault(emp => emp.EmpID == id);

            using (SaveFileDialog sfd = new SaveFileDialoge())
                        {

            }
                return View("GridDataViewer", empl);
        }


    }
}