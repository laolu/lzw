using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Mvc.JQuery.Datatables;

namespace Platform.Account.Dtos
{
    #region 用户列表
    public class UserDto 
    {
        [Required]
        [StringLength(50)]
        [DataTables(DisplayName = "用户名", MRenderFunction = "encloseInEmTag")]
        public string LoginName { get; set; }

        [StringLength(50)]
        [DataTables(DisplayName = "工号")]
        public string WorkID { get; set; }

        [StringLength(50)]
        [DataTables(DisplayName = "姓名")]
        public string RealName { get; set; }

        [StringLength(50)]
        [DataTables(DisplayName = "邮箱")]
        public string Email { get; set; }

        [StringLength(50)]
        [DataTables(DisplayName = "手机")]
        public string Mobile { get; set; }
        [DataTables(DisplayName = "用户类型")]
        public int? UserType { get; set; }
    }
    #endregion

    #region 登陆视图
    public class UserLoginDto
    {
        [Required]
        [DisplayName("账户")]
        public string LoginName { get; set; }

        [Required]
        [DisplayName("密码")]
        public string Password { get; set; }

        [Required]
        [DisplayName("验证码")]
        public string VerifyCode { get; set; }
    }
    #endregion

    public class UserPwdModifyDto
    {
        [Required]
        [Display(Name = "账户")]
        public string LoginName { get; set; }

        [Required]
        [Display(Name ="老密码")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }

        [Required]
        [Display(Name = "确认密码")]
        public string VerifyCode { get; set; }
    }
	
    
}