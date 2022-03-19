using LabDos.Edu.Kinal.Lab.Interfaces;

namespace LabDos.Edu.Kinal.Lab.Entities{
    public class Profesor : Persona, IOperaciones{

        public Profesor()
        : base(){
        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
        : base(uuid, apellidos, nombres, email){
            this.CUI = cui;
            this.Cargo = cargo;
        }

        public string CUI {get; set; }
        public string Cargo {get; set; }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura {this.Nombres} {this.Apellidos}");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.UUID} {this.Apellidos} {this.Nombres} {this.Cargo}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando Asistencia de {this.Apellidos} {this.Nombres}");
        }
    }
}