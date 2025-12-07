using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
	public class CitaService
	{
		private readonly HttpClient _http;
		private readonly string baseUrl = "http://localhost:5008/api/citas";

		public CitaService(HttpClient http)
		{
			_http = http;
		}

		// Obtener lista de citas
		public async Task<List<Cita>> GetCitas()
		{
			return await _http.GetFromJsonAsync<List<Cita>>(baseUrl);
		}

		// Agregar una nueva cita
		public async Task<bool> AddCita(Cita cita)
		{
			var response = await _http.PostAsJsonAsync(baseUrl, cita);
			return response.IsSuccessStatusCode;
		}

		// Actualizar una cita
		public async Task<bool> UpdateCita(int id, Cita cita)
		{
			var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", cita);
			return response.IsSuccessStatusCode;
		}

		// Eliminar una cita
		public async Task<bool> DeleteCita(int id)
		{
			var response = await _http.DeleteAsync($"{baseUrl}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}