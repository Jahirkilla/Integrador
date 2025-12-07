using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
	public class EmpleadoService
	{
		private readonly HttpClient _http;
		private readonly string baseUrl = "http://localhost:5001/api/empleado";

		public EmpleadoService(HttpClient http)
		{
			_http = http;
		}

		// Obtener Lista de empleados
		public async Task<List<Empleado>> GetEmpleados()
		{
			return await _http.GetFromJsonAsync<List<Empleado>>(baseUrl);
		}

		// Agregar un nuevo empleado
		public async Task<bool> AddEmpleado(Empleado empleado)
		{
			var response = await _http.PostAsJsonAsync(baseUrl, empleado);
			return response.IsSuccessStatusCode;
		}

		// Actualizar un empleado
		public async Task<bool> UpdateEmpleado(int id, Empleado empleado)
		{
			var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", empleado);
			return response.IsSuccessStatusCode;
		}

		// Eliminar un empleado
		public async Task<bool> DeleteEmpleado(int id)
		{
			var response = await _http.DeleteAsync($"{baseUrl}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}