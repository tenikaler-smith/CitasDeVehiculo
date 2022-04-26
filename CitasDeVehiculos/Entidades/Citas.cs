using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasDeVehiculos.Entidades
{
    public class Citas
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public List<Estado> Estado { get; set; }
        public DateTime FechaYHora { get; set; }
    }
}
