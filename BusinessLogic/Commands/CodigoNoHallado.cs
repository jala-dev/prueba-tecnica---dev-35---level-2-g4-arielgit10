using System;

namespace BusinessLogic.Commands
{
    public class CodigoNoHallado:Exception
    {

        public CodigoNoHallado(){

        }
        public void printMessage(){
            Console.WriteLine("El codigo ingresado no existe en el sistema.");

        }
    }
}