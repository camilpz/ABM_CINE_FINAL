using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_CINE_FINAL.Dominio
{
    public class Butaca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
		public string Fila { get; set; }
		public int Numero { get; set; }
		public string Estado { get; set; }

		public Butaca(int id_butaca = 0, string fila = "", int numero = 0, string estado = "")
		{
			Id = id_butaca;
			Fila = fila;
			Numero = numero;
			Estado = estado;
		}
	}
}
