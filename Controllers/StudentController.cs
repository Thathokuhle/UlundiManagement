using AutoMapper;
using Ganss.Xss;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlundiManagement.Business.Student;
using UlundiManagement.Data;
using UlundiManagement.Repository.IRepositories;
using UlundiManagement.Repository.Repositories;
using UlundiManagement.ViewModels.Student;

namespace UlundiManagement.Controllers
{
    public class StudentController : Controller
    {

        public ActionResult Index(string searchName)
        {
            searchName = new HtmlSanitizer().Sanitize(searchName);
            var students = new StudentBusiness().AllStudent(searchName);
            return View(students);
        }
    }
}
