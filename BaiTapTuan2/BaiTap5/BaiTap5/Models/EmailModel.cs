using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BaiTap5.Models
{
    public class EmailModel
    {
        [DisplayName("Gửi từ Email")]
        public String From { get; set; }

        [DisplayName("Mật khẩu")]
        public String Password { get; set; }

        [DisplayName("Gửi đến Email")]
        public String To { get; set; }

        [DisplayName("Tiêu đề")]
        public String Subject { get; set; }

        [DisplayName("Nội dung")]
        public String Body { get; set; }
    }
}