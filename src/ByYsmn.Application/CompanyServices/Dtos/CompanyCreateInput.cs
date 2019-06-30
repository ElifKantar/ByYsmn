using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ByYsmn.Application.CompanyServices.Dtos
{
    public class CompanyCreateInput : EntityDto
    {
        [Required]
        [DisplayName("Firma Adı")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Telefon")]
        public string Tel { get; set; }

        [Required]
        [DisplayName("Adres")]
        public string Address { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Web Sitesi")]
        public string WebSiteUrl { get; set; }
    }
}
