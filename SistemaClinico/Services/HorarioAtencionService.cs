using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
	public class HorarioAtencionService
	{
		private readonly HttpClient _http;
		private readonly string baseUrl = "http://localhost:5007/api/horarioatencion";

		public HorarioAtencionService(HttpClient http)
		{
			_http = http;
		}

		// Obtener lista de horario de atencion
		public async Task<List<HorarioAtencion>> GetHorarioAtencions()
		{
			return await _http.GetFromJsonAsync<List<HorarioAtencion>>(baseUrl);
		}

		// Agregar un nuevo horario de atencion
		public async Task<bool> AddHorarioAtencion(HorarioAtencion horarioAtencion)
		{
			var response = await _http.PostAsJsonAsync(baseUrl, horarioAtencion);
			return response.IsSuccessStatusCode;
		}

		// Actualizar un horario de atencion
		public async Task<bool> UpdateHorarioAtencion(int id,HorarioAtencion horarioAtencion)
		{
			var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", horarioAtencion);
			return response.IsSuccessStatusCode;
		}

		// Eliminar un horario de atencion
		public async Task<bool> DeleteHorarioAtencion(int id)
		{
			var response = await _http.DeleteAsync($"{baseUrl}/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}