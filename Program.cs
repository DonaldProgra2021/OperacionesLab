using OperacionesLab.Edu.Kinal.Lab.Entities;

public class Program
{

    private List<Persona> listaGeneral = new List<Persona>();
    public static void Main(string[] args)
    {
        Alumno alumno1 = new Alumno("A200","Fernandez Lopez","Jorge Rafael","jfernandez@gmail.com","2021-450",5);
        Profesor profesor1 = new Profesor("P500","Juanes Rodriguez","Carlos Rafael","cjuanes@gmail.com","16597848232","Auxiliar");

     

        listaGeneral.Add(alumno1);
        listaGeneral.Add(profesor1);

        VerMisDatos(listaGeneral);

         
    }

         static void OperarRegistro(Persona elemento)
        {
            

        }

         static void RegistrarAsistencia(Persona elemento)
        {

        }
        static void VerMisDatos(Persona elemento)
        {
            
        }

         public void QuitarAsignatura(Persona elemento)
        {
            
        }


}