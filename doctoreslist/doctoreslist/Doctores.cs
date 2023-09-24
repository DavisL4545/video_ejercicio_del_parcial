using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctoreslist
{
    //clase hospital contiene todo los campos
    public class Doctores
    {
        public int Id { get; set; }

        public string DoctoresName { get; set; }

        public string numerotelefono { get; set; }

        public string Email { get; set; }

        // pero con el director del hospital es diferente 
        //lo definimos como si fuese un tipo de dato 
        //todos son de tipo string pero la del director sera de tipo director

        // Lo que haremos es relacionarlo el hospitar con el director para 
        //que tenga disonible todos los datos

        public Director Director { get; set; }

        public override string ToString()
        {
            return $"ID:{Id}, Doctores: {DoctoresName}, Director: {Director.Name}, " +
                $"numero de telefono: {numerotelefono}, email: {Email}";
        }

    }
}
