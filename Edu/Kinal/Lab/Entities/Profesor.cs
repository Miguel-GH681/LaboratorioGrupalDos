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

        public bool eliminarAsignatura(string asignatura)
        {
            if(this.Asignaturas.Contains(asignatura)){
                this.Asignaturas.Remove(asignatura);
                Console.WriteLine($"Se ha eliminado la asignatura de {this.Nombres} {this.Apellidos}");
                return true;
            } else{
                Console.WriteLine("No existe la asignatura que deseas eliminar");
                return false;
            }
        }

        public void listarMisDatos(string identificador)
        {
            if(identificador == this.CUI){
                Console.WriteLine($"UUID: {this.UUID} - Apellidos: {this.Apellidos} - Nombres: {this.Nombres} - Cargo: {this.Cargo}");
            }
        }

        public override void tomarAsistencia()
        {
            Console.WriteLine($"Asistencia con CUI {this.CUI}");
        }
    }
}