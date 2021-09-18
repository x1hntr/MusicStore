﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Negocio
{
    public class ArtistaCPN
    {
        
        private ArtistaDAL art = new ArtistaDAL();
        public DataTable MostrarArtista()
        {
            DataTable tabla = new DataTable();
            tabla = art.mostrarArtista();
            return tabla;
        }

        public void insertarArtista(string nombre, string nacionalidad)
        {
            art.insertarArtista( nombre, nacionalidad);

        }
        public void editarArtista(int id, string nombre, string nacionalidad)
        {
            art.editarArtista(id,  nombre,  nacionalidad);
           
        }
        public void eliminarArtista(int id)
        {
            art.eliminarArtista(id);
        }
    }
}