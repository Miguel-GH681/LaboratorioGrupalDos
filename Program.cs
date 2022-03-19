using LabDos.Edu.Kinal.Lab.Entities;
using LabDos.Edu.Kinal.Lab.Interfaces;

public class Program{

    private static List<Persona> ListaGeneral = new List<Persona>();

    public static void Main(string[] args){

        Alumno alumnoUno = new Alumno("2022001", "Gonzalez Hic", "Alvaro Miguel", "miguelgh681@gmail.com", "20180036", 51);
        Alumno alumnoDos = new Alumno("2022002", "Carvajal Vargas", "Adriana Carolina", "carvajala@gmail.com", "20180017", 15);
        Alumno alumnoTres = new Alumno("2022003", "Ospina Pinzón", "Camilo Alberto", "camiloa@gmail.com", "20180115", 87);

        Profesor profesorUno = new Profesor("2022011", "Ramírez", "Ernesto", "ernesto@kalum.edu", "1254454714444", "Profesor");
        Profesor profesorDos = new Profesor("2022022", "González", "Fátima", "fatima@kalum.edu", "4785201414541", "Auxiliar");
        Profesor profesorTres = new Profesor("2022033", "Gómez", "Gabriela", "gabriela@kalum.edu", "7894441101021", "Profesor");


        OperarRegistro(alumnoUno);
        OperarRegistro(alumnoDos);   
        OperarRegistro(alumnoTres);  
        OperarRegistro(profesorUno);
        OperarRegistro(profesorDos);
        OperarRegistro(profesorTres);

        RegistrarAsistencia(alumnoUno);
        RegistrarAsistencia(alumnoDos);
        RegistrarAsistencia(alumnoTres);
        RegistrarAsistencia(profesorDos);

        VerMisDatos(alumnoDos);
        VerMisDatos(profesorTres);

        QuitarAsignatura(alumnoTres, "Ciencias Naturales");
        QuitarAsignatura(alumnoDos, "Matemática");
        QuitarAsignatura(profesorUno, "Contabilidad");
    }

    static void OperarRegistro(Persona elemento){
        ListaGeneral.Add(elemento);
    }

    static void RegistrarAsistencia(Persona elemento){
        foreach(Persona registro in ListaGeneral){
            if(registro.UUID == elemento.UUID){
                elemento.TomarAsistencia();
            }
        }
    }

    static void VerMisDatos(Persona elemento){
        if(elemento is Alumno){
            Alumno auxiliar = (Alumno)elemento;
            auxiliar.ListarMisDatos(auxiliar.Carne);
        } else if(elemento is Profesor){
            Profesor auxiliar = (Profesor)elemento;
            auxiliar.ListarMisDatos(auxiliar.CUI);
        }
    }

    static void QuitarAsignatura(Persona elemento, string asignatura){
        ((IOperaciones)elemento).EliminarAsignatura(asignatura);
    }
}