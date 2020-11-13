using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelAssignment.Models;

namespace ViewModelAssignment.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information
        public ActionResult Index()
        {
            var Student = new List<Student>()
            {
                new Student {StudentID = 100, StudentName = "Mary", StudentAge = 20},
                new Student {StudentID = 101, StudentName = "Ken", StudentAge = 19},
                new Student {StudentID = 102, StudentName = "Jane", StudentAge = 18},
                new Student {StudentID = 103, StudentName = "Bob", StudentAge = 20},
            };

            var School = new List<School>()
            {
                new School {SchoolName = "Claim", SchoolCity = "STL", SchoolSize = 15},
                new School {SchoolName = "Claim", SchoolCity = "TX", SchoolSize = 25},
                new School {SchoolName = "Claim", SchoolCity = "KC", SchoolSize = 10},
                new School {SchoolName = "Claim", SchoolCity = "NYC", SchoolSize = 30},
            };

            var InformationViewModel = new InformationViewModel
            {
                Schools = School,
                Students = Student
            };

            return View(InformationViewModel);
        }
    }
}