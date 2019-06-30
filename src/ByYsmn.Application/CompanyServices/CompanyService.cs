using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ByYsmn.Application.CompanyServices.Dtos;
using ByYsmn.Application.Shared;
using ByYsmn.Core.Companies;
using ByYsmn.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;

namespace ByYsmn.Application.CompanyServices
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _context;
        public CompanyService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Company> Get(EntityInput<Guid> input)
        {
            return await _context.Companies.FindAsync(input.Id);
        }

        public async Task<List<Company>> GetAll()
        {
            return await _context.Companies.ToListAsync();
        }

        public Task<List<Company>> GetAllByKeyword(string input)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Company> Create(CompanyCreateInput input)
        {
            var company = Company.Create(input.Name, input.Tel, input.Address, input.WebSiteUrl, input.Email, input.CreatorUserId);
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return company;
        }

        public async Task<Company> Update(CompanyUpdateInput input)
        {
            var oldCompany = await Get(new EntityInput<Guid> { Id = input.Id });
            var updateCompany = Company.Update(oldCompany, input.Name, input.Tel, input.Address, input.WebSiteUrl, input.Email, input.ModifierUserId);
            _context.Companies.Update(updateCompany);
            await _context.SaveChangesAsync();
            return updateCompany;
        }

        public Task<bool> Delete(EntityInput<Guid> input)
        {
            throw new NotImplementedException();
        }



    }
}
