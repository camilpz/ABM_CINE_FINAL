using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_CINE_FINAL.Dominio
{
    public class Cliente
    {
        //public int Id { get; set; }
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Password { get; set; }
        //public int Puntos { get; set; }
        public Cliente(int dni, string pass)
        {
            Dni = dni;
            Password = pass;
        }
    }
}
