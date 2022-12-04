using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_CINE_FINAL.Dominio
{
    public class Comprobante
    {
        
        public int Id_forma_pago { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_promo { get; set; }
        public List<Detalle> LisDetalles { get; set; }

        public Comprobante()
        {

        }
        public Comprobante(int id_f_p, string cliente, DateTime fecha, int id_promo, List<Detalle> Ldetalle)
        {
            Id_forma_pago = id_f_p;
            Cliente = cliente;
            Fecha = fecha;
            Id_promo = id_promo;
            LisDetalles = Ldetalle;
        }
        public void AgregarDetalle(Detalle detalle)
        {
            LisDetalles.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            LisDetalles.RemoveAt(indice);
        }
    }
}
