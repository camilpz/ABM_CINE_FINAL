using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABM_CINE_FINAL.Datos;
using ABM_CINE_FINAL.Dominio;

namespace ABM_CINE_FINAL.Servicios
{
	internal class Servicios
	{
		//HelperDAO hel = new HelperDAO();

		public DataTable ObtenerTablasAux(int nroTabla)
		{
			return HelperDAO.ObtenerInstancia().ObtenerTablasAux(nroTabla);
		}
		public bool AltaPelicula(Pelicula pelicula)
		{
			return HelperDAO.ObtenerInstancia().AltaPelicula(pelicula);
		}
	}
}
