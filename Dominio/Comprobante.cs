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
        public int Id_cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<Detalle> LisDetalles { get; set; }
        
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
