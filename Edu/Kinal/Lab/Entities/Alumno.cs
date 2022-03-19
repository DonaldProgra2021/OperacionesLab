using OperacionesLab.Edu.Kinal.Lab.Interfaces;

namespace OperacionesLab.Edu.Kinal.Lab.Entities;

    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public Alumno() : base()
        {

        }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
        :base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando Asistencia de {this.Apellidos} {this.Nombres}");
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.Uuid} {this.Apellidos} {this.Nombres} {this.NumeroCreditos}");
        }

        public bool EliminarAsignatura(string identificador)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.Apellidos} {this.Nombres}, Perdera la cantidad de creditos de {this.NumeroCreditos}");
        return true;
        }
    }
