using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
	public class MedicoService
	{
		private readonly HttpClient _http;
		private readonly string baseUrl = "http://localhost:5003/api/medico";

		public MedicoService(HttpClient http)
		{
			_http = http;
		}

		// Obtener Lista de médicos
		public async Task<List<Medico>> GetMedicos()
		{
			return await _http.GetFromJsonAsync<List<Medico>>(baseUrl);
		}

		// Agregar un nuevo médico
		public async Task<bool> AddMedico(Medico medico)
		{
			var response = await _http.PostAsJsonAsync(baseUrl, medico);
			return response.IsSuccessStatusCode;
		}

		// Actualizar un médico
		public async Task<bool> UpdateMedico(int id, Medico medico)
		{
			var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", medico);
			return response.IsSuccessStatusCode;
		}

		// Eliminar un médico
		public async Task<bool> DeleteMedico(int id)
		{
			var response = await _http.DeleteAsync($"{baseUrl}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}