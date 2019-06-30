using System;
using System.Collections.Generic;
using System.Text;

namespace ByYsmn.Application.CompanyServices.Dtos
{
    public class CompanyUpdateInput : CompanyCreateInput
    {
        public Guid Id { get; set; }
    }
}
