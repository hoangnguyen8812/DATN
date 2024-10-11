using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BotDetect.Web.Mvc;

namespace BaiTapLon.Models
{
    public class RegisterModel
    {
        
        [Display(Name = "Tên đăng nhập")]
        [Required]
        public string UserName { set; get; }

        [Required]
        [Display(Name = "Mật khẩu")]
        public string PassWord { set; get; }

        [Required]
        [Display(Name = "Xác nhận mật khẩu")]
        public string ConfirmPass { set; get; }

        [Display(Name = "Họ tên")]
        [Required]
        public string Name { set; get; }

        [Display(Name = "Địa chỉ")]
        [Required]
        public string Address { set; get; }

        [Display(Name = "Số điện thoại")]
        [Required]
        public string Phone { set; get; }

        [Required]
        public string Email { set; get; }


        [Display(Name = "Chức danh")]
        public long IDQuyen { set; get; }

    }
}