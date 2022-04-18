using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using CloudCustomers.Data.Config;
using CloudCustomers.Data.Models;
using Microsoft.Extensions.Options;

namespace CloudCustomers.Services.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly UsersApiOptions _apiOptions;

        public UserService(HttpClient httpClient,IOptions<UsersApiOptions> apiConfig)
        {
            _httpClient = httpClient;
            _apiOptions = apiConfig.Value;
        }   
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var response = await _httpClient.GetAsync(_apiOptions.EndPoint);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return new List<User>();
            }

            var responseContent = response.Content;
            var allUsers = await responseContent.ReadFromJsonAsync<List<User>>();
            return allUsers!.ToList();
        }

        public Task<User>? GetUserById(int id)
        {
            return id == 1 ? new Task<User>(() => new User { Id = 1,  name = "John Doe", Email = "" }) : null;
        }
    }
}
