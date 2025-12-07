using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
	public class PacienteService
	{
		private readonly HttpClient _http;
		private readonly string baseUrl = "http://localhost:5004/api/pacientes";

		public PacienteService(HttpClient http)
		{
			_http = http;
		}

		// Obtener lista de pacientes
		public async Task<List<Paciente>> GetPacientes()
		{
			return await _http.GetFromJsonAsync<List<Paciente>>(baseUrl);
		}

		// Agregar un nuevo pacientes
		public async Task<bool> AddPaciente(Paciente paciente)
		{
			var response = await _http.PostAsJsonAsync(baseUrl, paciente);
			return response.IsSuccessStatusCode;
		}

		// Actualizar un paciente
		public async Task<bool> UpdatePaciente(int id, Paciente paciente)
		{
			var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", paciente);
			return response.IsSuccessStatusCode;
		}

		// Eliminar un paciente
		public async Task<bool> DeletePaciente(int id)
		{
			var response = await _http.DeleteAsync($"{baseUrl}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}