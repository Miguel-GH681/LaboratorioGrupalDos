namespace LabDos.Edu.Kinal.Lab.Entities
{
    public abstract class Persona{
        public Persona(){
        }

        public Persona(string uuid, string apellidos, string nombre, string email){
            this.UUID = uuid;
            this.Apellidos = apellidos;
            this.Nombres = nombre;
            this.Email = email;
        }

        public string UUID { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public List<string> Asignaturas = new List<string>() {"matemática", "idiomas", "contabilidad", "sociología"};
        public abstract void tomarAsistencia();
    }
}