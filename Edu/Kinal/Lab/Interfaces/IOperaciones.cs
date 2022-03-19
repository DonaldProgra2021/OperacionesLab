using OperacionesLab.Edu.Kinal.Lab.Entities;

namespace OperacionesLab.Edu.Kinal.Lab.Interfaces
{
    public interface IOperaciones
    {
        public void ListarMisDatos(string identificador);

        public bool EliminarAsignatura(string identificador);
    }
}   