using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Persona persona = new Persona(5, "Silvia", "Aloha");

                PersonaDAO personaDAO = new PersonaDAO();

                personaDAO.GuardarPersona(persona);  

                //personaDAO.ModificarPersona(persona);

                //personaDAO.EliminarPersona(persona);

                List<Persona> listPersona = personaDAO.LeerPersonas();

                Console.WriteLine("Leer Personas");
               
                foreach(Persona p in listPersona)
                {
                    Console.WriteLine($"ID: {p.ID}, Nombre: {p.Nombre}, Apellido: {p.Apellido}");
                }

                Persona persona2 = personaDAO.LeerPersonasID(2);

                Console.WriteLine();

                Console.WriteLine("Persona x ID");

                if(persona2 != null)
                {
                    Console.WriteLine($"ID: {persona2.ID}, Nombre: {persona2.Nombre}, Apellido: {persona2.Apellido}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
