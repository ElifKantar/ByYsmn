using ByYsmn.Application.CompanyServices.Dtos;
using ByYsmn.Application.Shared;
using ByYsmn.Core.Companies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ByYsmn.Application.CompanyServices
{
    public interface ICompanyService: IBaseService<Guid, CompanyCreateInput, CompanyUpdateInput, Company>
    {
       // Task /* return list type */ GetAll();

       // Task /* return item type */ Get( /*EntityInput*/ );

       // Task /* return just created item */ Create( /*createInput*/ );

       // Task /* return modified item */ Update( /*updateInput*/ );

       // Task /* success or not success */ Delete( /*EntityInput*/ );


    }
}
