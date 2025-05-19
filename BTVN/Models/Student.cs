using System.ComponentModel.DataAnnotations;

namespace BTVN.Models
{
    public class Student
    {
        [Required(ErrorMessage = "MSSV là bắt buộc")]
        [Display(Name = "Mã số sinh viên")]
        public string MSSV { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc")]
        [Display(Name = "Họ tên sinh viên")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Điểm TB là bắt buộc")]
        [Range(0, 10, ErrorMessage = "Điểm TB phải từ 0 đến 10")]
        [Display(Name = "Điểm trung bình")]
        public double DiemTB { get; set; }

        [Required(ErrorMessage = "Chuyên ngành là bắt buộc")]
        [Display(Name = "Chuyên ngành")]
        public string ChuyenNganh { get; set; }
    }
}
