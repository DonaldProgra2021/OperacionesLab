using OperacionesLab.Edu.Kinal.Lab.Interfaces;

namespace OperacionesLab.Edu.Kinal.Lab.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public override void TomarAsistencia()
        {

        }

        public void ListarMisDatos(Alumno identificador)
        {
            throw new NotImplementedException();
        }

        public void ListarMisDatos(Profesor identificador)
        {
            throw new NotImplementedException();
        }

        public void EliminarAsignatura(Alumno identificador)
        {
            throw new NotImplementedException();
        }

        public void EliminarAsignatura(Profesor identificador)
        {
            throw new NotImplementedException();
        }

        public Alumno() : base()
        {

        }

        public Alumno(string uuid, apellidos, nombres, email)
        :base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }


        
    }
}