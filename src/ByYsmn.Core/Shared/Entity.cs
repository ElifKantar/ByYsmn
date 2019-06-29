using ByYsmn.Core.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByYsmn.Core.Shared
{
    public class Entity<T>
    {
        public T Id { get; set; }

        [ForeignKey("CreatorUserId")]
        public virtual ApplicationUser CreatorUser { get; set; }

        [Required]
        public Guid CreatorUserId { get; set; }

        public string ModifierUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }

    public class EntityPlain<T>
    {
        public T Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
