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
            LocalMemoryDB.MembersContext.Add(new Member() { ID = id, FirstName = firstName, SecondName = secondName });
        }
    }
}
