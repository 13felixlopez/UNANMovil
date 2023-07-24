using System.Data;
using UNANMovil.Conexion;

namespace UNANMovil.Modelo
{
    public class NprofesBase
    {
        DProfesor objd = new DProfesor();
        public DataTable Nprofes(MProfes parametros)
        {
            return objd.D_Usuarios(parametros);
        }
    }
}