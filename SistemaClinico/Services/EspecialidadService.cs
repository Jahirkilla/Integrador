using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
	public class EspecialidadService
	{
		private readonly HttpClient _http;
		private readonly string baseUrl = "http://localhost:5002/api/especialidades";

		public EspecialidadService(HttpClient http)
		{
			_http = http;
		}

		// Obtener Lista de especialidades
		public async Task<List<Especialidad>> GetEspecialidads()
		{
			return await _http.GetFromJsonAsync<List<Especialidad>>(baseUrl);
		}

		// Agregar un nuevo especialidad
		public async Task<bool> AddEspecialidad(Especialidad especialidad)
		{
			var response = await _http.PostAsJsonAsync(baseUrl, especialidad);
			return response.IsSuccessStatusCode;
		}

		// Actualizar una especialidad
		public async Task<bool> UpdateEspecialidad(int id, Especialidad especialidad)
		{
			var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", especialidad);
			return response.IsSuccessStatusCode;
		}

		// Eliminar una especialidad
		public async Task<bool> DeleteEspecialidad(int id)
		{
			var response = await _http.DeleteAsync($"{baseUrl}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}