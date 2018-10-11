using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            pila.Push("Carlos");
            pila.Push("Francisco");
            pila.Push("Luis");
            pila.Push(123);
            
            Console.WriteLine("---------GetEnumerator------------");
            var enumerador = pila.GetEnumerator();//GetEnumerator permite usar enumeradores para recorrer la pila.
            while (enumerador.MoveNext())//desplaza el enumerador a la siguiente posicion de la coleccion
            {
                var item = enumerador.Current;
                Console.WriteLine(item);
            }
            Console.WriteLine("-------- La pila Normal --------");// Muestro la pila.
            foreach (var valor in pila)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("---------Cambio a ToArray------------");
            Stack pila2 = new Stack(pila.ToArray());//Copia la pila a una matriz nueva
            foreach (var valor in pila2)//Impresion del la matriz
            {
                Console.WriteLine(valor);
            }
            // Revisa si la pila contiene la cadena"
            Console.WriteLine("---------- Metodo Contains -------------");
            bool contiene = pila.Contains("Francisco");//variable bool y verificaion si la pila contiene a francisco
            Console.WriteLine(contiene);
            if (contiene==true)//Si contiene es verdadero
            {
                Console.WriteLine("La pila si contiene a Francisco");
            }
            else//Si no
            {
                Console.WriteLine("La pila no contiene a Francisco");
            }
            Console.WriteLine("------------GetType------------");
            Console.WriteLine("El tipo de dato de 123 es: {0}",pila.Pop().GetType());//Nos dice el tipo de la instancia actual
            Console.WriteLine("-----Se utilizo Pop para sacar 123 de la lista---------");
            Console.WriteLine("---------Uso de To String------------");
            Console.WriteLine(pila.Contains(123).ToString());//Convierte el valor de la instancia a Verdadero o Falso 
            Console.ReadKey(true);
        }        
    }
}
