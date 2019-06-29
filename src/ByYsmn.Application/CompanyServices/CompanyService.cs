using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ByYsmn.Application.CompanyServices.Dtos;
using ByYsmn.Application.Shared;
using ByYsmn.Core.Companies;

namespace ByYsmn.Application.CompanyServices
{
    public class CompanyService : ICompanyService
    {
        public Task<Company> Create(CompanyCreateInput input)
        {
            throw new NotImplementedException();
        }

        public Task<Company> Delete(EntityInput<Guid> input)
        {
            throw new NotImplementedException();
        }

        public Task<Company> Get(EntityInput<Guid> input)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllByKeyword(string input)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Company> Update(CompanyUpdateInput input)
        {
            throw new NotImplementedException();
        }
    }
}
