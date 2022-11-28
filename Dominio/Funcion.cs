﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_CINE_FINAL.Dominio
{
    public class Funcion
    {
        public int Id { get; set; }
        public int Id_peli_idio { get; set; }
        public Pelicula Pelicula { get; set; }
        public Sala Sala { get; set; }
        public DateTime Fecha { get; set; }
        public Horario Horario { get; set; }
        public Idioma idioma { get; set; } //nuevo DUDOSO

        //public string Mostrar()
        //{
        //    return Pelicula.Nombre + " - " + idioma.Nombre + " - " + Horario.Hora + " - " + Sala.Tipo;
        //}
        

    }
}
