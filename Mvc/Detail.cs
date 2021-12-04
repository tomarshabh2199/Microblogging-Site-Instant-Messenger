//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Detail
    {
        
        public int Id { get; set; }

        [StringLength(10)]
        public string Firstname { get; set; }


        [StringLength(10)]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        //[Remote("IsEmailExist", "Detail", AdditionalFields = "Id",
        //        ErrorMessage = "Email ID already exists")]
        public string Email { get; set; }

        [Required]
        [MaxLength(10),MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MaxLength(10)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [StringLength(8)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please select file.")]
        //[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files allowed.")]
        public string Image { get; set; }
    }
}
