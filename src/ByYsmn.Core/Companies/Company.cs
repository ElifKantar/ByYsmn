using ByYsmn.Core.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace ByYsmn.Core.Companies
{
    public class Company : Entity<Guid>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Tel { get; set; }
        [Required]
        public string Address { get; set; }
        public string WebSiteUrl { get; set; }
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