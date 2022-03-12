using LabDos.Edu.Kinal.Lab.Entities;

public class Program{

    private static List<Persona> listaGeneral = new List<Persona>();
    private static List<Persona> registros = new List<Persona>();

    public static void Main(string[] args){

        Guid MyUUID = Guid.NewGuid();

        Persona test = new Alumno();

        Persona alumnoUno = new Alumno(Guid.NewGuid().ToString(), "Gonzalez Hic", "Alvaro Miguel", "miguelgh681@gmail.com", "20180036", 51);
        Persona alumnoDos = new Alumno(Guid.NewGuid().ToString(), "Carvajal Vargas", "Adriana Carolina", "carvajala@gmail.com", "20180017", 15);
        Persona alumnoTres = new Alumno(Guid.NewGuid().ToString(), "Ospina Pinzón", "Camilo Alberto", "camiloa@gmail.com", "20180115", 87);
        Persona alumnoCuatro = new Alumno(Guid.NewGuid().ToString(), "Torres Delgado", "Angelica María", "angelicat@gmail.com", "20180602", 12);
        Persona alumnoCinco = new Alumno(Guid.NewGuid().ToString(), "Santos Muñoz", "Natalia Meli", "santosn@gmail.com", "20180055", 45);

        Persona profesorUno = new Profesor(Guid.NewGuid().ToString(), "Ramírez", "Ernesto", "ernesto@kalum.edu", "1254454714444", "profesor");
        Persona profesorDos = new Profesor(Guid.NewGuid().ToString(), "González", "Fátima", "fatima@kalum.edu", "4785201414541", "auxiliar");
        Persona profesorTres = new Profesor(Guid.NewGuid().ToString(), "Gómez", "Gabriela", "gabriela@kalum.edu", "7894441101021", "profesor");
        Persona profesorCuatro = new Profesor(Guid.NewGuid().ToString(), "López", "David", "david@kalum.edu", "1245789865321", "auxiliar");
        Persona profesorCinco = new Profesor(Guid.NewGuid().ToString(), "Hic", "Alvaro", "alvaro@kalum.edu", "1478523698745", "director");

        operarRegistro(alumnoUno);
        operarRegistro(alumnoDos);   
        operarRegistro(alumnoTres);   
        operarRegistro(alumnoCuatro);   
        operarRegistro(alumnoCinco);   
        operarRegistro(profesorUno);
        operarRegistro(profesorDos);
        operarRegistro(profesorTres);
        operarRegistro(profesorCuatro);
        operarRegistro(profesorCinco);

        registrarAsistencia(alumnoUno);
        registrarAsistencia(alumnoDos);
        registrarAsistencia(alumnoTres);
        registrarAsistencia(alumnoCuatro);
        registrarAsistencia(profesorDos);
        registrarAsistencia(profesorCuatro);
        registrarAsistencia(profesorCinco);

        ((Alumno)alumnoCuatro).eliminarAsignatura("matemática");
        verMisDatos(profesorDos);
        verMisDatos(alumnoCuatro);
    }

    static void operarRegistro(Persona elemento){
        registros.Add(elemento);
    }

    static void registrarAsistencia(Persona elemento){
        listaGeneral.Add(elemento);
        if(elemento is Alumno){
            ((Alumno)elemento).tomarAsistencia();
        } else{
            ((Profesor)elemento).tomarAsistencia();
        }
    }

    static void verMisDatos(Persona elemento){
        if(elemento is Alumno){
            ((Alumno)elemento).listarMisDatos(((Alumno)elemento).Carne);
        } else if(elemento is Profesor){
            ((Profesor)elemento).listarMisDatos(((Profesor)elemento).CUI);
        }
    }
}