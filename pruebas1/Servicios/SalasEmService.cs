using System.Net.Http.Json;
using pruebas1.Entidades;

namespace pruebas1.Servicios
{
    public class SalasEmService
    {
        private readonly HttpClient httpClient;

        public SalasEmService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<SalasEm>> GetSalas()
        {
            var salas = await httpClient.GetFromJsonAsync<List<SalasEm>>("salas");
            return salas ?? new List<SalasEm>();
        }
    }
}
