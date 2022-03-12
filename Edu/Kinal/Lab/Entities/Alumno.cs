using LabDos.Edu.Kinal.Lab.Interfaces;

namespace LabDos.Edu.Kinal.Lab.Entities{
    public class Alumno : Persona, IOperaciones
    {
        public Alumno(){
        }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
        : base(uuid, apellidos, nombres, email){
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }

        public string Carne { get; set;}
        public int NumeroCreditos {get; set;}

        public bool eliminarAsignatura(string asignatura)
        {
            if(this.Asignaturas.Contains(asignatura)){
                this.Asignaturas.Remove(asignatura);
                Console.WriteLine($"Se ha eliminado la asignatura de {this.Nombres} {this.Apellidos}");
                Console.WriteLine($"Ha perdido los créditos {this.NumeroCreditos}");
                return true;
            } else{
                Console.WriteLine("No existe la asignatura que deseas eliminar");
                return false;
            }
        }

        public void listarMisDatos(string identificador)
        {
            if(identificador == this.Carne){
                Console.WriteLine($"UUID: {this.UUID} - Apellidos: {this.Apellidos} - Nombres: {this.Nombres} - No.Créditos: {this.NumeroCreditos}");
            }
        }

        public override void tomarAsistencia()
        {
            Console.WriteLine($"Asistencia con carné {this.Carne}");
        }
    }
}