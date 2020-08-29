using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class MiClase
    {
        //Miembros de la clase: atributos y métodos

        //(*)atributos
        //propiedades
        //constructor
        //(*)métodos
        //sobrecargas

        //estaticos y NO estáticos


        #region No estáticos
        
        public float reales;


        #endregion

        #region Estáticos
        private static string cadena;
        public static int entero;


        public static void MetodoUno()
        {
            string algo = "hola";
            //implementacion
            algo = "hola";
            
            Console.WriteLine(algo);



        }

        public static int MetodoDos(string param)
        {
            //return entero;
            return MiClase.entero;
            
        }



        #endregion


    }
}
