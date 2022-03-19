using LabDos.Edu.Kinal.Lab.Interfaces;

namespace LabDos.Edu.Kinal.Lab.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public Alumno() : base()
        {
        }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
        : base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }

        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.Apellidos} {this.Nombres}, perderá la cantidad de créditos de {this.NumeroCreditos}");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.UUID} {this.Apellidos} {this.Nombres} {this.NumeroCreditos}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando Asistencia de {this.Apellidos} {this.Nombres}");
        }
    }
}