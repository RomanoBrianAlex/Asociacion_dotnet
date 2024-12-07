using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Asociacion
{
    class Auto
    {
        // 1 - Venimos de la Clase Program.
        //Crearemos el Constructor y realizar la instancia
        public Auto()
        {
            //Realizamos la Instancia.
            Chasis = new Chasis();
        }
        //2 - Vamos a la Clase Program.
        //Propiedad con Asociación por Composición.
        public Chasis Chasis { get; set; }
        //--------------------------------------------------------
        //Propiedad con Asociación por Atribución.
        public Motor Motor { get; set; }
        //--------------------------------------------------------
        //Propiedades comunes.
        public string Color { get; set; }
        public int Modelo { get; set; }
        public int anio { get; set; }

    }//fin.
}
