using OperacionesLab.Edu.Kinal.Lab.Entities;
using OperacionesLab.Edu.Kinal.Lab.Interfaces;

public class Program
{

    private static List<Persona> listaGeneral = new List<Persona>();
    public static void Main(string[] args)
    {
        Alumno alumno1 = new Alumno("A200","Fernandez Lopez","Jorge Rafael","jfernandez@gmail.com","2021-450",5);
        Profesor profesor1 = new Profesor("P500","Juanes Rodriguez","Carlos Rafael","cjuanes@gmail.com","16597848232","Auxiliar");

        VerMisDatos(alumno1);
        VerMisDatos(profesor1);

        OperarRegistro(alumno1);
        OperarRegistro(profesor1);

        RegistrarAsistencia(alumno1);
        RegistrarAsistencia(profesor1);

        QuitarAsignatura(alumno1,"Calculo");
        QuitarAsignatura(profesor1,"Historia");
         
    }

        public static void VerMisDatos(Persona elemento)
        {
            if(elemento is Alumno)
            {
                Alumno auxiliarAlumno = (Alumno)elemento;
                auxiliarAlumno.ListarMisDatos(auxiliarAlumno.Carne);
            }else if(elemento is Profesor)
            {
                Profesor auxiliarProfesor = (Profesor)elemento;
                auxiliarProfesor.ListarMisDatos(auxiliarProfesor.Cui);
            }  
        }

        public static void RegistrarAsistencia(Persona elemento)
        {
            foreach(Persona registro in listaGeneral)
        {
            if(registro.Uuid == elemento.Uuid)
            {
                elemento.TomarAsistencia();                
            }
            }
        }
         public static void QuitarAsignatura(Persona elemento, string asignatura)
        {
            ((IOperaciones)elemento).EliminarAsignatura(asignatura);
        }        
         public static void OperarRegistro(Persona elemento)
        {
             listaGeneral.Add(elemento);
        }
}