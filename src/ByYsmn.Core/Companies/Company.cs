using ByYsmn.Core.Shared;
using System;

namespace ByYsmn.Core.Companies
{
    public class Company : Entity<Guid>
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string WebSiteUrl { get; set; }

    }
}
