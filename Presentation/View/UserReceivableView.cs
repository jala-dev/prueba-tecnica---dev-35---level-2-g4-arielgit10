using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class UserReceivableView
    {
        public InputData RequestData()
        {
            return this.GetData();
        }

        private InputData GetData()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
          //  input.fields.Add("NombreSocio", Console.ReadLine());
            return input;
        }

        public void ShowResult(int id, string name,double total,int value)
        {            
            Console.WriteLine("R. El consumo del socio {0}, correspondiente a {1}, es de {2} cubos. La deuda actual es de {3} Bs.",id,name,value,total);
            Console.WriteLine("======================================");
        }
    }
}
