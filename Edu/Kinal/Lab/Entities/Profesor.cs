using OperacionesLab.Edu.Kinal.Lab.Interfaces;

namespace OperacionesLab.Edu.Kinal.Lab.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string Cui { get; set; }
        public string Cargo { get; set; }
       
        public Profesor() : base()
        {

        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
        :base(uuid, apellidos, nombres, email)
        {
            this.Cui = cui;
            this.Cargo = cargo;
        }

        override 
        public string ToString()
        {
            return "";
        }

        public override void TomarAsistencia()
        {
            throw new NotImplementedException();
        }

        public void ListarMisDatos(string identificador)
        {
            throw new NotImplementedException();
        }

        public bool EliminarAsignatura(string asignatura)
        {
            throw new NotImplementedException();
        }
    }
}