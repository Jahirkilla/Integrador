using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
	public class DiaSemanaService
	{
		private readonly HttpClient _http;
		private readonly string baseUrl = "http://localhost:5005/api/dia";

		public DiaSemanaService(HttpClient http)
		{
			_http = http;
		}

		// Obtener Lista de días de la semana
		public async Task<List<DiaSemana>> GetDiaSemanas()
		{
			return await _http.GetFromJsonAsync<List<DiaSemana>>(baseUrl);
		}

		// Agregar un nuevo día de la semana
		public async Task<bool> AddDiaSemana(DiaSemana diaSemana)
		{
			var response = await _http.PostAsJsonAsync(baseUrl, diaSemana);
			return response.IsSuccessStatusCode;
		}

		// Actualizar un día de la semana
		public async Task<bool> UpdateDiaSemana(int id, DiaSemana diaSemana)
		{
			var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", diaSemana);
			return response.IsSuccessStatusCode;
		}

		// Eliminar un día de la semana
		public async Task<bool> DeleteDiaSemana(int id)
		{
			var response = await _http.DeleteAsync($"{baseUrl}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}