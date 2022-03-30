using Data.DB;
using Data.Entities;
using System.Collections.Generic;

namespace Data
{
    public class PaymentRepository
    {
         public void Save(Payment entity)
        {
            LocalMemoryDB.PaymentContext.Add(entity);
        }

        public List<Payment> GetPaymentByMember(Payment entity)
        {
            List<Payment> result = new List<Payment>();
            foreach(Payment item in LocalMemoryDB.PaymentContext)
            {
                if(item.ID == entity.ID)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}