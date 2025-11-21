using pruebas1.Entidades;
using System.Net.Http.Json;

namespace pruebas1.Servicios
{
    public class AgendaService
    {
        private readonly HttpClient httpClient;

        public AgendaService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        // 📌 Crear tarea
        public async Task<bool> CrearTareaApi(TareaCreada tarea)
        {
            var dto = new
            {
                idAgenda = 3,
                titulo = tarea.Titulo,
                descripcion = tarea.Descripcion,
                fechaInicio = tarea.FechaInicio,
                fechaFin = tarea.FechaFin,
                esRecurrente = false,
                reglaRecurrencia = "",
                todoElDia = true,
                idPrioridad = 1,

                subTareas = tarea.Subtareas.Select((s, i) => new
                {
                    id = 0,
                    titulo = s,
                    completada = false,
                    fechaCompletada = (DateTime?)null,
                    orden = i
                }).ToList()
            };

            var response = await httpClient.PostAsJsonAsync("tareas/crear", dto);
            return response.IsSuccessStatusCode;
        }

        // 📌 Crear evento
        public async Task<bool> CrearEventoApi(TareaCreada evento)
        {
            var dto = new
            {
                id = 0,
                idAgenda = 3,
                titulo = evento.Titulo,
                descripcion = evento.Descripcion,
                fechaInicio = evento.FechaInicio,
                fechaFin = evento.FechaFin,
                completada = false,
                fechaCompletada = (DateTime?)null,
                todoElDia = true,
                idPrioridad = 1,
                prioridad = "Media",
                idSala = 0,
                ubicacion = evento.Ubicacion ?? "",
                participantes = new[]
                {
                    new {
                        id = 0,
                        idEmpleado = 0,
                        nombreEmpleado = evento.Participantes
                    }
                }
            };

            var response = await httpClient.PostAsJsonAsync("eventos", dto);
            return response.IsSuccessStatusCode;
        }
    }
}
