using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Asociacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hola Mundo!
            Console.WriteLine("Hola Mundo!");
            //----------------------------------
            /*
             * Hoy se verá "Asociación", algunas veces es confundido por "Composición", pero es un tipo de Asociación, de hecho hay 2 tipos de Asociación: Composición y la Agregación.
             * ¿Qué es la Asociación? La "Asociación", es un tipo de relación entre Clases, anteriormente se vió que la Herencia era un tipo de relación entre Clase, bueno algo así.
             * Básicamente, que en una Clase Auto (imaginemos que en este caso será Clase Auto), en unas de sus Propiedades/Atributos tendrá como tipo de dato de una Clase creada por nosotros, no será un string o int.
             
             * Por ejemplo: Tenemos la Clase "Persona" y la Clase "Direccion", la Clase Dirección tiene de calle, localidad, pais y provicia. Después está la Clase Persona en vez de tener todos esos datos para tener la dirección, va a tener un Atributo de tipo Dirección. Este ejemplo, explicaría que sería la Asociación del tipo "Composición".
             
             * Veamos otro ejemplo que es sobre la Clase Auto, que tenemos la Clase Auto y tiene de propiedades: Color, Modelo y Anio. Y queremos agregar la Propiedad "Motor", pero en sí un motor es como un Objeto, no es solo una pieza sola, entonces, creamos una Clase "Motor" y ponemos las Propiedades correspondientes. Luego, lo que nos quedaría hacer dentro de la Clase Auto, es crear una Propiedad de tipo "Motor" llamada Motor, permitiendo tener a la mano (digamos) las Propiedades del Motor, pero solo quedaría hacer instancia ese mismo Objeto para poder tener acceso.
             
             * Lo que nos quedaría y tener que hacer antes de hacerlo todo, es pensar que tipo de Asociación es lo que acabamos de hacer.
             * Los 2 tipos de Asociación, son casi iguales, pero su diferencia es lo que ese Objeto Motor, que nivel de cercanía tiene con un auto real (como para saber si es o no), si un auto común debe nacer (digamos mecánicamente) con un motor o se lo pueden agregarlo después y cambiarlo también. Como vemos que no es necesario que un auto nazca con un motor, entonces este tipo de Asociación es de tipo "Agregación".
             * En cambio, la Asociación de tipo composición Composición, sería necesario que el Objeto nazca con ese Objeto.
             * Bueno, ahora tenemos una Asociación de tipo Agregación y nosotros queremos agregar ese Motor en Auto, ¿Cómo hago? Lo que se debería ahcer primero es crear el Objeto Auto en la Clase Program (Clase Principal), luego crear la instacia a la Propiedad Motor de tipo "Motor":
             */

            Auto auto1 = new Auto();
            auto1.anio = 2000;
            auto1.Color = "Rojo";
            auto1.Modelo = 1;
            //Y para poder agregar datos en Motor, debemos instanciar a la Clase Motor.
            auto1.Motor = new Motor();
            auto1.Motor.Marca = "DOZ";

            //Ahora queda en crear una Asociación de tipo Composición:
            /*Comenzaremos con ver que tiene que nacer si o si un auto común, Max eligió el chasis, lo cuál, crearemos una Clase llamada Chasis.
             * Lo que sigue después de crear una Clase llamada Chasis, es ponerle los Atributos o Propiedades, luego pensar si el chasis si o si debe nacer con el auto, la respuesta es si, porque no se puede tener un auto sin chasis, sino no podría tener ninguna cosas de que lo conforman un auto. Vayamos a hacer eso:
             */

            // auto1.Chasis.Color = "Rojo"; //en este paso tendría que dar error
            // auto1.Chasis.Material = "Fibra de Carbono"; //en este paso tendría que dar error

            /*
             * Pero como se ve nos da error, lo que pasa es que falta realizar la "Instancia" a la Clase que es "Chasis", pero este tipo de Asociación no se la puede hacer acá mismo, entonces lo que se debe hacer es un "Constructor" (lo recuerdas? Sino a repasar... :) ), lo que se puede hacer en el Constructor es realizar la Instancia en el Constructor, lo que cumpliría el tipo de Asocicación por Composición y sin necesidad de hacer la Instacia cada vez al crear un Objeto, es más buena dirí personalmente, pero no es tan común ver el tipo de Asociación por Atribución.
             * 1 - Ahora, debemos ir a la Clase Auto.
             * 2 - Venimo de la Clase Auto.
             * Ahora miremos como cambia del error al código.
             */
            auto1.Chasis.Color = "Rojo";
            auto1.Chasis.Material = "Fibra de Carbono";

            Console.WriteLine($"Auto 1\nAño: {auto1.anio}\nColor: {auto1.Color}\nModelo: {auto1.Modelo}\nMarca del motor: {auto1.Motor.Marca}\nColor del chasis: {auto1.Chasis.Color}\nMaterial del chasis: {auto1.Chasis.Material}");

            //fin.
            Console.ReadKey(true);
        }
    }
}
