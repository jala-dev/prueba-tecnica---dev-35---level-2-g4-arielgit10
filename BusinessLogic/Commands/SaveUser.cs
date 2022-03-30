using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using Data.DB;


namespace BusinessLogic.Commands
{
    class SaveUser
    {
        public void Execute()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Ingrese id del Socio: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese primer nombre del Socio: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ingrese apellido del Socio: ");
            string secondName = Console.ReadLine();

            if(validateId(id) && validateName(firstName)){
                LocalMemoryDB.MembersContext.Add(new Member() { ID = id, FirstName = firstName, SecondName = secondName });
            }
            else{
                Console.WriteLine("Datos erróneos.\nEl código del socio debe ser un número positivo y estar entre 5000 and 5999.\nEl nombre del socio debe tener un máximo de 4 carácteres.\nVuelva a intentarlo.");
            }

         
        }


        private bool validateId(int id){
            return (id>=0)&&(id>=5000)&&(id<6000);
        }
        private bool validateName(string id){
            return id.Length>3;
        }

    }
}
