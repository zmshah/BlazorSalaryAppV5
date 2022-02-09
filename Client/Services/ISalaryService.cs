using BlazorSalaryAppV5.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSalaryAppV5.Client.Services
{
    public interface ISalaryService
    {
        Task<IEnumerable<SalaryData>> Search(Nullable<int> ID, string Department, string College, string Division, string JobTitle);
        Task<IEnumerable<SalaryData>> GetSalaries();
        Task<SalaryData> GetSalary(int ID);
        Task<SalaryData> GetSalariesByDepartment(string Department);
        Task<SalaryData> GetSalariesByCollege(string College);
        Task<SalaryData> GetSalariesByDivision(string Division);
        Task<SalaryData> GetSalariesByJobTitle(string JobTitle);
        Task<SalaryData> AddSalary(SalaryData salary);
        Task<SalaryData> UpdateSalary(SalaryData salary);
        Task DeleteSalary(int ID);
    }
}
