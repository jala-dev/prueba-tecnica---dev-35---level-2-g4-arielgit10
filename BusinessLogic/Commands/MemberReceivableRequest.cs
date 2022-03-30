using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;
using System.Collections.Generic;

namespace BusinessLogic.Commands
{
    public class MemberReceivableRequest: IWaterCommand
    {
        double WaterPrice = 8.5;
        public void Execute()
        {
            UserReceivableView view = new UserReceivableView();
            InputData data = view.RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);
          //  entity.FirstName= data.fields["CodigoSocio"]);
            
            List<Consumption> memberConsumptions = new ConsumptionRepository().GetConsumptionByMember(entity);

            Member memberName = new MemberRepository().GetMember(entity.ID);


            double total = this.CalculateTotalReceivable(memberConsumptions);
            int value = this.CalculateValueReceivable(memberConsumptions);


            //view.ShowResult(total);  
            view.ShowResult(entity.ID,memberName.FirstName,total,value);          
        }

        private double CalculateTotalReceivable(List<Consumption> memberConsumptions)
        {
            double total = 0;
            foreach(Consumption item in memberConsumptions)
            {
                if(!item.Paid){
                    total += item.Value * WaterPrice;
                }
            }
            return total;
        }

         private int CalculateValueReceivable(List<Consumption> memberConsumptions)
        {
            int value = 0;
            foreach(Consumption item in memberConsumptions)
            {
                value += item.Value;
            }
            return value;
        }

    }
}
