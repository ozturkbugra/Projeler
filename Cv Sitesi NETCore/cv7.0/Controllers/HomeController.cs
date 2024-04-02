using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using cv7._0.Models;

namespace cv7._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly CvDBContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(CvDBContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            _dbContext = dbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CV cv, IFormFile resume, string[] ehliyet, IFormFile profileImage)
        {

            if (resume != null && resume.Length > 0)
            {
                // Yüklenecek dosyanın ismini al
                var fileName = Path.GetFileName(resume.FileName);
                // Dosyanın yükleneceği yol (wwwroot içindeki css klasörüne yükleniyor)
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "css", fileName);

                // Dosyayı sunucuya kaydet
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    resume.CopyTo(stream);
                }

                // Dosya yolu modeldeki ResumePath alanına atanıyor
                cv.ResumePath = "/css/" + fileName;
            }

            if (profileImage != null && profileImage.Length > 0)
            {
                // Yüklenecek dosyanın ismini al
                var fileName = Path.GetFileName(profileImage.FileName);
                // Dosyanın yükleneceği yol (wwwroot içindeki images klasörüne yükleniyor)
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "css", fileName);

                // Dosyayı sunucuya kaydet
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    profileImage.CopyTo(stream);
                }

                // Dosya yolu modeldeki ProfileImagePath alanına atanıyor
                cv.ProfileImagePath = "/css/" + fileName;
            }

            // Seçilen ehliyetleri bir dize olarak birleştir
            if (ehliyet != null && ehliyet.Length > 0)
                {
                    cv.Licenses = string.Join(", ", ehliyet);
                }

                _dbContext.CVs.Add(cv);
                _dbContext.SaveChanges();

            return View();
            

            
        }

        public IActionResult Applicants()
        {
            var applicants = _dbContext.CVs.ToList();
            return View(applicants);
        }

        public IActionResult ApplicantDetail(int id)
        {
            var applicant = _dbContext.CVs.FirstOrDefault(cv => cv.Id == id);
            if (applicant == null)
            {
                return NotFound();
            }
            return View(applicant);
        }
    }
}
