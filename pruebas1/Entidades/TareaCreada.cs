using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas1.Entidades
{
    public class TareaCreada
    {
        public string Tipo { get; set; } = "";
        public string Titulo { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public List<string> Subtareas { get; set; } = new();

        // Campos extra para EVENTO (estático/local por ahora)
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public TimeOnly? HoraInicio { get; set; }
        public TimeOnly? HoraFin { get; set; }
        public string Ubicacion { get; set; } = "";
        public string Participantes { get; set; } = "";
    }
    public class SubtaskModel
    {
        public string Title { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public TimeOnly? HoraInicio { get; set; }
        public TimeOnly? HoraFin { get; set; }
        public string Ubicacion { get; set; }
        public string Participantes { get; set; }
        public List<SubtaskModel> Subtasks { get; set; }
    }
    public class OrdenTrabajoModel
    {
        public string NumeroOrden { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaProgramada { get; set; }
        public string Autor { get; set; }
        public string Cliente { get; set; }
        public string Objetivo { get; set; }
        public string OtrosObjetivos { get; set; }
        public OrdenStatus Status { get; set; } = OrdenStatus.Normal;
        public List<TareaOrdenModel> Tareas { get; set; } = new();
    }

    public class TareaOrdenModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Avance { get; set; } // %
    }

    public enum OrdenStatus
    {
        Normal,
        ProximaVencer,
        Vencida
    }

}
