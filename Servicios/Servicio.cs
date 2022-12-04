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
	internal class Servicio
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
		public DataTable FiltrarComprobanteDni(int dni)
		{
			return HelperDAO.ObtenerInstancia().FiltrarComprobanteDni(dni);
		}
		public bool BajaComprobante(int nro_comprobante)
		{
			return HelperDAO.ObtenerInstancia().BajaComprobante(nro_comprobante);
		}
		public DataTable ObtenerFuncionesEditar()
		{
			return HelperDAO.ObtenerInstancia().ObtenerFuncionesEditar();
		}
		public bool EditarFuncion(Funcion funcion)
		{
			return HelperDAO.ObtenerInstancia().EditarFuncion(funcion);
		}
		public DataTable ObtenerFuncionesPeliculas()
		{
			return HelperDAO.ObtenerInstancia().ObtenerFuncionesPeliculas();
		}
		public DataTable ObtenerFuncionesIdiomas(int id_pelicula)
		{
			return HelperDAO.ObtenerInstancia().ObtenerFuncionesIdiomas(id_pelicula);
		}
		public DataTable ObtenerFuncionesSalas(int id_pelicula, int id_idioma)
		{
			return HelperDAO.ObtenerInstancia().ObtenerFuncionesSalas(id_pelicula, id_idioma);
		}
		public DataTable ObtenerFuncionesFecha(int id_pelicula, int id_idioma, int id_sala)
		{
			return HelperDAO.ObtenerInstancia().ObtenerFuncionesFecha(id_pelicula, id_idioma, id_sala);
		}
		public DataTable ObtenerFuncionesHorario(int id_pelicula, int id_idioma, int id_sala, DateTime fecha)
		{
			return HelperDAO.ObtenerInstancia().ObtenerFuncionesHorario(id_pelicula, id_idioma, id_sala, fecha);
		}
		public int ObtenerFuncionID(int id_pelicula, int id_idioma, int id_sala, int id_horario, DateTime fecha)
		{
			return HelperDAO.ObtenerInstancia().ObtenerFuncionID(id_pelicula, id_idioma, id_sala, id_horario, fecha);

		}
		public DataTable ObtenerAsientosOcupadosFuncion(int id_funcion)
		{
			return HelperDAO.ObtenerInstancia().ObtenerAsientosOcupadosFuncion(id_funcion);
		}
	}
}
