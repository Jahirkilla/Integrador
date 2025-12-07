using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
	public class HoraService
	{
		private readonly HttpClient _http;
		private readonly string baseUrl = "http://localhost:5006/api/horas";

		public HoraService(HttpClient http)
		{
			_http = http;
		}

		// Obtener Lista de horas
		public async Task<List<Hora>> GetHoras()
		{
			return await _http.GetFromJsonAsync<List<Hora>>(baseUrl);
		}

		// Agregar una nueva hora
		public async Task<bool> AddHora(Hora hora)
		{
			var response = await _http.PostAsJsonAsync(baseUrl, hora);
			return response.IsSuccessStatusCode;
		}

		// Actualizar una hora
		public async Task<bool> UpdateHora(int id, Hora hora)
		{
			var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", hora);
			return response.IsSuccessStatusCode;
		}

		// Eliminar una hora
		public async Task<bool> DeleteHora(int id)
		{
			var response = await _http.DeleteAsync($"{baseUrl}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}