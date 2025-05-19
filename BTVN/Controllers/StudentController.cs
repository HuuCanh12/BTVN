using Microsoft.AspNetCore.Mvc;
using BTVN.Models;
using System.Linq;

namespace BTVN.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentService.AddStudent(student);
                TempData["ChuyenNganh"] = student.ChuyenNganh;
                TempData["MSSV"] = student.MSSV;
                return RedirectToAction("ShowKQ", student);
            }
            return View(student);
        }

        public IActionResult ShowKQ(Student student)
        {
            string chuyenNganh = TempData["ChuyenNganh"]?.ToString() ?? student.ChuyenNganh;
            int count = StudentService.CountBySpecialization(chuyenNganh);
            ViewBag.CountSameSpecialization = count;
            ViewBag.CurrentSpecialization = chuyenNganh;
            ViewBag.AllStudents = StudentService.GetAllStudents()
                .Where(s => s.ChuyenNganh == chuyenNganh)
                .Select(s => $"{s.MSSV} - {s.HoTen}")
                .ToList();
            return View(student);
        }
    }
}