using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoinv.Shared.Entities
{
    public class Proyectoinvestigacion
    {
        public int Id { get; set; }
        public string Name { get; set; } = null; 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string NameLider { get; set; }   
        public string Descripcion { get; set; } 
        public string Area { get; set; }
    }
}
