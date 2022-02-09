using BlazorSalaryAppV5.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSalaryAppV5.Server.Models
{
    public class SalaryRepository : ISalaryRepository
    {
        private readonly AppDbContext appDbContext;
        public SalaryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //Get all salaries
        public async Task<IEnumerable<SalaryData>> GetSalaries()
        {
            return await appDbContext.Salaries.ToListAsync();
        }

        //Get salary by id
        public async Task<SalaryData> GetSalary(int ID)
        {
            return await appDbContext.Salaries.FirstOrDefaultAsync(e => e.ID == ID);
        }

        public async Task<SalaryData> AddSalary(SalaryData salary)
        {
            var result = await appDbContext.Salaries.AddAsync(salary);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteSalary(int ID)
        {
            var result = await appDbContext.Salaries.FirstOrDefaultAsync(e => e.ID == ID);

            if (result != null)
            {
                appDbContext.Salaries.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        

        public async Task<SalaryData> GetSalariesByCollege(string College)
        {
            return await appDbContext.Salaries.FirstOrDefaultAsync(e => e.College == College);
        }

        public async Task<SalaryData> GetSalariesByDepartment(string Department)
        {
            return await appDbContext.Salaries.FirstOrDefaultAsync(e => e.Department == Department);
        }

        public async Task<SalaryData> GetSalariesByDivision(string Division)
        {
            return await appDbContext.Salaries.FirstOrDefaultAsync(e => e.Division == Division);
        }

        public async Task<SalaryData> GetSalariesByJobTitle(string JobTitle)
        {
            return await appDbContext.Salaries.FirstOrDefaultAsync(e => e.JobTitle == JobTitle);
        }

        public async Task<IEnumerable<SalaryData>> Search(Nullable<int> ID, string Department, string College, string Division, string JobTitle)
        //public async Task<IEnumerable<SalaryData>> Search(string Department, string College, string Division, string JobTitle)
        {
            IQueryable<SalaryData> query = appDbContext.Salaries;

            //if (!string.IsNullOrEmpty(ID))
            if (ID != null)
            {
                //query = query.Where(e => e.ID.Contains(ID));
                query = query.Where(e => e.ID == ID);
            }

            if (!string.IsNullOrEmpty(Department))
            {
                query = query.Where(e => e.Department.Contains(Department));
            }

            if (!string.IsNullOrEmpty(College))
            {
                query = query.Where(e => e.College.Contains(College));
            }

            if (!string.IsNullOrEmpty(Division))
            {
                query = query.Where(e => e.Division.Contains(Division));
            }

            if (!string.IsNullOrEmpty(JobTitle))
            {
                query = query.Where(e => e.JobTitle.Contains(JobTitle));
            }

            return await query.ToListAsync();
        }

        public async Task<SalaryData> UpdateSalary(SalaryData salary)
        {
            var result = await appDbContext.Salaries.FirstOrDefaultAsync(e => e.ID == salary.ID);

            if (result != null)
            {
                //result.ID = salary.ID;
                result.Department = salary.Department;
                result.College = salary.College;
                result.Division = salary.Division;
                result.JobTitle = salary.JobTitle;
                result.PayYearly = salary.PayYearly;
                result.PayYTD = salary.PayYTD;
                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
