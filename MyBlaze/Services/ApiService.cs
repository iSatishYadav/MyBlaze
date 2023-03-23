using MyBlaze.Models;
using System.Net.Http.Json;

namespace MyBlaze.Services
{
	public class ApiService
	{
		private static HttpClient _httpClient = new HttpClient();
		private readonly string _baseUrl;

		public ApiService(string baseUrl)
		{
			_baseUrl = baseUrl;
			_httpClient.BaseAddress = new Uri(_baseUrl);
		}
		public async Task<List<Employee>> GetApiData()
		{
			var response = await _httpClient.GetAsync("api/Employees");
			var content = await response.Content.ReadFromJsonAsync<Result<List<Employee>>>();
			return content.Content;
		}
	}
}
