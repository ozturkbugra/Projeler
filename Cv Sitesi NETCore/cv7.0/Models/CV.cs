using System.ComponentModel.DataAnnotations;

namespace cv7._0.Models
{
    public class CV
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Skills { get; set; }
        public string Licenses { get; set; }
        public bool TermsAccepted { get; set; }
        public string ResumePath { get; set; }
        public string ProfileImagePath { get; set; } // Profil resminin dosya yolu


    }
}
