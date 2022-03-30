using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;
using System;

namespace BusinessLogic.Commands
{
    public class SaveConsumption: IWaterCommand
    {
        public void Execute()
        {
            InputData data = new SaveConsumptionView().RequestData();
            Consumption entity = new Consumption();
            entity.MemberID = int.Parse(data.fields["CodigoSocio"]);
            int value =entity.Value = int.Parse(data.fields["Consumo"]);
            if(validateConsumption(value)){
                new ConsumptionRepository().Save(entity);
            }
            else{
                Console.WriteLine("No puede ingresar valores negativos.");
            }
        }

        private bool validateConsumption(int value){
            return value>0;
        }
    }
}
