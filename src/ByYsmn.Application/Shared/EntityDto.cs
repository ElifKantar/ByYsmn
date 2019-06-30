using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ByYsmn.Application.CompanyServices.Dtos
{
    public class EntityDto
    {
        [DisplayName("Oluşturan")]
        public Guid? CreatorUserId { get; set; }

        [DisplayName("Düzenleyen")]
        public Guid? ModifierUserId { get; set; }

        [DisplayName("Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public DateTime? ModifiedDate { get; set; }

    }

    public class EntityPlainDto
    {
        [DisplayName("Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public DateTime? ModifiedDate { get; set; }
    }
}
