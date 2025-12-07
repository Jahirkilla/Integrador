using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaClinico.Models.Clinica;

namespace SistemaClinico.Services
{
    public class TipoEmpleadoService
    {
        private readonly HttpClient _http;
        private readonly string baseUrl = "api/tipoempleado";

        public TipoEmpleadoService(HttpClient http)
        {
            _http = http;
        }

        // Obtener Lista de tipo de empleados
        public async Task<List<TipoEmpleado>> GetTipoEmpleados()
        {
            return await _http.GetFromJsonAsync<List<TipoEmpleado>>(baseUrl);
        }

        // Agregar un nuevo tipo de empleado
        public async Task<bool> AddTipoEmpleado(TipoEmpleado tipoEmpleado)
        {
            var response = await _http.PostAsJsonAsync(baseUrl, tipoEmpleado);
            return response.IsSuccessStatusCode;
        }

        // Actualizar un tipo de empleado
        public async Task<bool> UpdateTipoEmpleado(int id, TipoEmpleado tipoEmpleado)
        {
            var response = await _http.PutAsJsonAsync($"{baseUrl}/{id}", tipoEmpleado);
            return response.IsSuccessStatusCode;
        }

        // Eliminar un tipo de empleado
        public async Task<bool> DeleteTipoEmpleado(int id)
        {
            var response = await _http.DeleteAsync($"{baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}