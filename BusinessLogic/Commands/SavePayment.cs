using System;
using System.Collections.Generic;
using System.Text;
using Presentation.View;
using Presentation;
using Data;
using Data.Entities;

namespace BusinessLogic.Commands
{
    class SavePayment
    {
        public void Execute()
        {
            //throw new NotImplementedException();
            InputData data = new SavePaymentView().RequestData();
            Payment entity= new Payment();
            entity.ID=int.Parse(data.fields["CodigoSocio"]);
            //ver deuda
            //entity.Monto=int.Parse(data.fields["Monto"]);
            new PaymentRepository().Save(entity);    
            ConsumptionRepository.SetConsumptionByMember(entity.ID,entity);

        }
    }

}