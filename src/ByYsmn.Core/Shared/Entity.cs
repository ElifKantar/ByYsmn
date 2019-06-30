using ByYsmn.Core.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByYsmn.Core.Shared
{
    public class Entity<T>
    {
        public T Id { get; set; }
        /*!!!*/
        [ForeignKey("CreatorUserId")]
        /*!!!*/
        public virtual ApplicationUser CreatorUser { get; set; }
        /*!!!*/
        [DisplayName("Oluşturan")]
        public virtual Guid? CreatorUserId { get; set; }

        [ForeignKey("ModifierUserId")]
        public virtual ApplicationUser ModifierUser { get; set; }
        [DisplayName("Düzenleyen")]
        public virtual Guid? ModifierUserId { get; set; }

        [DisplayName("Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; }
        [DisplayName("Düzenleme Tarihi")]
        public DateTime? ModifiedDate { get; set; }
    }
}
