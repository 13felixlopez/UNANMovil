using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UNANMovil.Conexion;

namespace UNANMovil.Modelo
{
    public class Nprofes
    {
        DProfesor objd = new DProfesor();
        public DataTable Nprofe(MProfes parametros)
        {
            return objd.D_Usuarios(parametros);
        }
    }
}
