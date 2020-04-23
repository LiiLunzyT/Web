using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTap5.Models
{
    public class EmpModel
    {
        [DisplayName("Mã nhân viên")]
        public String EmpID { get; set; }

        [DisplayName("Tên nhân viên")]
        public String EmpName { get; set; }

        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime EmpDoB { get; set; }

        [DisplayName("Email")]
        public String EmpEmail { get; set; }

        [DisplayName("Mật khẩu")]
        public String EmpPassword { get; set; }

        [DisplayName("Đơn vị")]
        public String EmpDepartment { get; set; }

        [DisplayName("Ảnh đại diện")]
        public String EmpAvatar { get; set; }
    }
}