using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasDeVehiculos.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int CitasId { get; set; }
        public Citas Citas { get; set; }
    }
}
