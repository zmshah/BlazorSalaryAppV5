using BlazorSalaryAppV5.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorSalaryAppV5.Client.Services
{
    //Wrapper class
    public class SalaryService : ISalaryService
    {
        private readonly HttpClient httpClient;

        public SalaryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<SalaryData>> GetSalaries()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<SalaryData>>("/api/salary");
        }
        public Task<SalaryData> AddSalary(SalaryData salary)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSalary(int ID)
        {
            throw new NotImplementedException();
        }

        

        public Task<SalaryData> GetSalariesByCollege(string College)
        {
            throw new NotImplementedException();
        }

        public Task<SalaryData> GetSalariesByDepartment(string Department)
        {
            throw new NotImplementedException();
        }

        public Task<SalaryData> GetSalariesByDivision(string Division)
        {
            throw new NotImplementedException();
        }

        public Task<SalaryData> GetSalariesByJobTitle(string JobTitle)
        {
            throw new NotImplementedException();
        }

        public Task<SalaryData> GetSalary(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SalaryData>> Search(int? ID, string Department, string College, string Division, string JobTitle)
        {
            throw new NotImplementedException();
        }

        public Task<SalaryData> UpdateSalary(SalaryData salary)
        {
            throw new NotImplementedException();
        }
    }
}
