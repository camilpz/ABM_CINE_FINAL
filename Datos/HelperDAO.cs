using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ABM_CINE_FINAL.Dominio;
using System.CodeDom;

namespace ABM_CINE_FINAL.Datos
{
    internal class HelperDAO
    {
        private static HelperDAO instancia;
        private SqlCommand comando = new SqlCommand();
        private SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DJNNQHT\SQLEXPRESS;Initial Catalog=CINE_FINAL;Integrated Security=True");

        public static HelperDAO ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }
        public void Conectar(string NomSP)
        {
            cnn.Open();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NomSP;
        }
        public bool Login(Cliente cliente)
        {
            bool resultado = false;
            Conectar("SP_Login");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@dni", cliente.Dni);
            comando.Parameters.AddWithValue("@password", cliente.Password);

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@verificar";
            parametro.Direction = ParameterDirection.Output;
            parametro.DbType = DbType.Int32;
            comando.ExecuteReader();
            cnn.Close();
            int res = (int)parametro.Value;

            if(res == 1)
            {
                resultado = true;
            }
            return resultado;
        }
        public bool AltaComprobante(Comprobante comprobante)
        {
            bool exito = false;
            SqlTransaction t = null;
            try
            {
                Conectar("SP_Alta_Comprobante");
                t = cnn.BeginTransaction();
                comando.Transaction = t;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@forma_pago", comprobante.Id_forma_pago);
                comando.Parameters.AddWithValue("@id_cliente", comprobante.Cliente); //VER DE CAMBIARLO SOLO POR EL NOMBRE
                comando.Parameters.AddWithValue("@fecha", comprobante.Fecha);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nro_comprobante";
                param.DbType = DbType.Int32;
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);
                comando.ExecuteNonQuery();

                int nro_comprobante = (int)param.Value;

                foreach (Detalle det in comprobante.LisDetalles)
                {
                    SqlCommand comanddo2 = new SqlCommand();
                    comanddo2.Connection = cnn;
                    comanddo2.CommandType = CommandType.StoredProcedure;
                    comanddo2.CommandText = "SP_Alta_Detalle";
                    comanddo2.Transaction = t;
                    comanddo2.Parameters.Clear();
                    comanddo2.Parameters.AddWithValue("@nro_comprobante", nro_comprobante);
                    comanddo2.Parameters.AddWithValue("@precio", det.Funcion.Sala.Precio);
                    if (comprobante.Id_promo.Equals(0))
                    {
						comanddo2.Parameters.AddWithValue("@id_promo", null);
					}
                    else
                    {
						comanddo2.Parameters.AddWithValue("@id_promo", comprobante.Id_promo);
					}
                    comanddo2.ExecuteNonQuery();
                    foreach (Butaca b in det.Funcion.Sala.LisButacas)
                    {
                        SqlCommand comando3 = new SqlCommand();
						comando3.Connection = cnn;
						comando3.CommandType = CommandType.StoredProcedure;
						comando3.CommandText = "SP_Baja_Butaca";
						comando3.Transaction = t;
                        comando3.Parameters.Clear();
                        comando3.Parameters.AddWithValue("@id_funcion", det.Funcion.Id);
                        comando3.Parameters.AddWithValue("@id_butaca", b.Id);
                        comando3.ExecuteNonQuery();
					}
				}
                t.Commit();
                cnn.Close();
                exito = true;

            }
            catch (Exception)
            {
                t.Rollback();
                cnn.Close();
            }
            return exito;
        }
        public bool AltaPelicula(Pelicula pelicula)
        {
            bool exito = false;
            SqlTransaction t = null;
            try
            {
                Conectar("SP_Alta_Pelicula");
                t = cnn.BeginTransaction();
                comando.Transaction = t;
				comando.Parameters.Clear();
				comando.Parameters.AddWithValue("@nombre", pelicula.Nombre);
                comando.Parameters.AddWithValue("@id_clasificacion", pelicula.Clasificacion.Id);
                comando.Parameters.AddWithValue("@duracion", pelicula.Duracion);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id_peli";
                param.Direction = ParameterDirection.Output;
                param.DbType = DbType.Int32;
                comando.Parameters.Add(param);
                comando.ExecuteNonQuery();

                int id_pelicula = (int)param.Value;
                foreach (Genero genero in pelicula.LisGeneros)
                {
                    SqlCommand comando2 = new SqlCommand();
                    comando2.Connection = cnn;
                    comando2.CommandType = CommandType.StoredProcedure;
                    comando2.CommandText = "SP_Alta_Pelicula_Genero";
                    comando2.Transaction = t;
					
					comando2.Parameters.AddWithValue("@id_peli", id_pelicula);
                    comando2.Parameters.AddWithValue("@id_gen", genero.Id);
                    comando2.ExecuteNonQuery();
                }
                foreach (Idioma idioma in pelicula.LisIdiomas)
                {
                    SqlCommand comando3 = new SqlCommand();
                    comando3.Connection = cnn;
                    comando3.CommandType = CommandType.StoredProcedure;
                    comando3.CommandText = "SP_Alta_Pelicula_Idioma";
                    comando3.Transaction = t;
					
					comando3.Parameters.AddWithValue("@id_peli", id_pelicula);
                    comando3.Parameters.AddWithValue("@id_idio", idioma.Id);
                    comando3.ExecuteNonQuery();
                }
                t.Commit();
                cnn.Close();
                exito = true;
            }
            catch (Exception)
            {
                t.Rollback();
                cnn.Close();
            }
            return exito;
        }
        public bool AltaFuncion(Funcion funcion)
        {
            bool exito = false;
            Conectar("SP_Alta_Funcion");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@id_peli_idioma", funcion.Id_peli_idio);
            comando.Parameters.AddWithValue("@nro_sala", funcion.Sala.Id);
            comando.Parameters.AddWithValue("@fecha", funcion.Fecha);
            comando.Parameters.AddWithValue("@id_horario", funcion.Horario.Id);
            if(comando.ExecuteNonQuery() > 0)
            {
                exito = true;
            }
            cnn.Close();
            return exito;
        }
        public bool BajaComprobante(int nro_comprobante)
        {
            bool exito = false;
            Conectar("SP_Baja_Comprobante");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nro_comprobante", nro_comprobante);
            if (comando.ExecuteNonQuery()>0)
            {
                exito = true;
            }
            cnn.Close();
            return exito;
        }
        public bool CambiarEstadoFuncion(int id_funcion, int eleccion) //1- desactivar, 2 -activar
        {
            bool exito = false;
            Conectar("SP_Editar_Estado_Funcion");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@id_funcion", id_funcion);
            comando.Parameters.AddWithValue("@cambio", eleccion);
            if (comando.ExecuteNonQuery() > 0)
            {
                exito = true;
            }
            cnn.Close();
            return exito;
        }
        public bool CambiarEstadoPelicula(int id_pelicula, int eleccion) //1- desactivar, 2 -activar
        {
            bool exito = false;
            Conectar("SP_Editar_Estado_Pelicula");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@id_pelicula", id_pelicula);
            comando.Parameters.AddWithValue("@cambio", eleccion);
            if (comando.ExecuteNonQuery() > 0)
            {
                exito = true;
            }
            cnn.Close();
            return exito;
        }
        public bool EditarFuncion(Funcion funcion)
        {
            bool exito = false;
            Conectar("SP_Editar_Funcion");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id_funcion", funcion.Id);
            comando.Parameters.AddWithValue("@nro_sala", funcion.Sala.Id);
            comando.Parameters.AddWithValue("@fecha", funcion.Fecha);
            comando.Parameters.AddWithValue("@id_horario", funcion.Horario.Id);
            if(comando.ExecuteNonQuery()> 0)
            {
                exito= true;
            }
            cnn.Close();
            return exito;
		}
		public int ObtenerIDPXI(int id_pelicula, int id_idioma)
        {
            Conectar("SP_Obtener_ID_PXI");
            comando.Parameters.Clear();
            SqlParameter param = new SqlParameter();
            comando.Parameters.AddWithValue("@id_pelicula", id_pelicula);
            comando.Parameters.AddWithValue("@id_idioma", id_idioma);
            param.ParameterName = "@id_pxi";
            param.DbType = DbType.Int32;
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            cnn.Close();
            int id_pxi = (int)param.Value;
            return id_pxi;
        }

        public DataTable ObtenerFuncionesPeliculas()
        {
			DataTable table = new DataTable();
			Conectar("SP_Reservas_Peliculas");
            comando.Parameters.Clear();
			table.Load(comando.ExecuteReader());
			cnn.Close();
			return table;
		}
        public DataTable ObtenerFuncionesIdiomas(int id_pelicula)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Reservas_Idiomas");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id_peli", id_pelicula);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ObtenerFuncionesSalas(int id_pelicula, int id_idioma)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Reservas_Salas");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id_peli", id_pelicula);
            comando.Parameters.AddWithValue("@id_idioma", id_idioma);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ObtenerFuncionesFecha(int id_pelicula, int id_idioma, int id_sala)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Reservas_Fecha");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id_sala", id_sala);
			comando.Parameters.AddWithValue("@id_peli", id_pelicula);
			comando.Parameters.AddWithValue("@id_idioma", id_idioma);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
		}
        public DataTable ObtenerFuncionesHorario(int id_pelicula, int id_idioma, int id_sala, DateTime fecha)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Reservas_Horario");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id_sala",id_sala);
			comando.Parameters.AddWithValue("@id_peli",id_pelicula);
			comando.Parameters.AddWithValue("@id_idioma",id_idioma);
			comando.Parameters.AddWithValue("@fecha",fecha);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
		}
        public int ObtenerFuncionID(int id_pelicula, int id_idioma, int id_sala, int id_horario, DateTime fecha)
        {
            Conectar("SP_Obtener_Id_Funcion");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id_sala", id_sala);
			comando.Parameters.AddWithValue("@id_peli",id_pelicula);
			comando.Parameters.AddWithValue("@id_idioma", id_idioma);
			comando.Parameters.AddWithValue("@fecha", fecha);
			comando.Parameters.AddWithValue("@id_horario", id_horario);
            
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id_funcion";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;

            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();

            int id = (int)param.Value;
            cnn.Close();
            return id;
        }
        public DataTable ObtenerAsientosOcupadosFuncion(int id_funcion)
        {
            DataTable table= new DataTable();
            Conectar("SP_Funciones_Butacas_Ocupadas");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id_funcion", id_funcion);
            table.Load(comando.ExecuteReader());
            cnn.Close();
            return table;
        }
        public DataTable ObtenerFuncionesEditar()               //ARREGLAR (TIRA ERROR RARO)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Vis_Funciones");
            comando.Parameters.Clear();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable FiltrarComprobanteDni(int dni)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Filtrar_Comprobante_Dni");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@dni", dni);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public int ObtenerUltimoComprobante()
        {
            Conectar("SP_Obtener_Ultimo_Comprobante");
            comando.Parameters.Clear();
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ultimo";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            
			int ultimo = (int)param.Value;
			cnn.Close();
			return ultimo;
		}
        public DataTable ObtenerTablasAux(int nro)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Consultar_Tablas_Auxiliares");
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@tabla", nro);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ObtenerPeliculasActivas()
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Obtener_Peliculas_Activas");
            comando.Parameters.Clear();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ObtenerIdiomasPeliculas(int id_pelicula) //para una pelicula determinada
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Obtener_Idiomas_Peliculas");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@id_peli", id_pelicula);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ObtenerSalasDesocupadas(DateTime fecha) //para una fecha determinada
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Obtener_Salas_Desocupadas");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@fecha", fecha);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ObtenerHorariosDisponibles(int nro_sala)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Horarios_Disponibles");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@nro_sala", nro_sala);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ObtenerFunciones(int eleccion)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Obtener_Funciones");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@estado", eleccion);
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ObtenerPeliculasNombreEstado(string pelicula, int estado)
        {
            DataTable tabla = new DataTable();
            Conectar("SP_Filtrar_Pelicula_Nombre_Estado");
			comando.Parameters.Clear();
			comando.Parameters.AddWithValue("@nombre", pelicula);
            comando.Parameters.AddWithValue("@eleccion", estado);           //1-inactiva 2-activa 3-todas
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
    }
}
