using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_CINE_FINAL.Dominio
{
    public class Detalle
    {
        public Funcion Funcion { get; set; }
        public int Id_Promo { get; set; }
        public Sala Sala { get; set; }

        //public void AgregarReserva(Sala sala)
        //{
        //    LisSalas.Add(sala);
        //}
        //public void QuitarReserva(int indice)
        //{
        //    LisSalas.RemoveAt(indice);
        //}
        public double CalcularTotal()
        {
            double total = Sala.Precio * Sala.LisButacas.Count;
            return total;
        }
        
    }
}
