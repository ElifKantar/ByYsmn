using ByYsmn.Core.Shared;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ByYsmn.Core.Companies
{
    public class Company : Entity<Guid>
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
        [DisplayName("Web")]
        public string WebSiteUrl { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }

        public static Company Create(string name, string tel, string address, string webSiteUrl, string email, Guid? creatorUserId)
        {
            return new Company
            {
                Name = name,
                Tel = tel,
                Address = address,
                WebSiteUrl = webSiteUrl,
                Email = email,
                CreatorUserId = creatorUserId,
                CreatedDate = DateTime.Now
            };
        }
        public static Company Update(Company oldCompany, string name, string tel, string address, string webSiteUrl, string email, Guid? modifiedUserId)
        {
            return new Company
            {
                Id = oldCompany.Id,
                CreatedDate = oldCompany.CreatedDate,
                CreatorUserId = oldCompany.CreatorUserId,
                Name = name,
                Tel = tel,
                Address = address,
                WebSiteUrl = webSiteUrl,
                Email = email,
                ModifierUserId = modifiedUserId,
                ModifiedDate = DateTime.Now
            };
        }
    }
}