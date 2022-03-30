﻿using Data.DB;
using Data.Entities;
using System.Collections.Generic;
using System;

namespace Data
{
    public class ConsumptionRepository
    {
        public void Save(Consumption entity)
        {
            LocalMemoryDB.ConsumptionsContext.Add(entity);
        }

        public List<Consumption> GetConsumptionByMember(Member entity)
        {
            List<Consumption> result = new List<Consumption>();
            foreach(Consumption item in LocalMemoryDB.ConsumptionsContext)
            {
                if(item.MemberID == entity.ID)
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public static void SetConsumptionByMember(int entity,Payment payEntity)
        {
            foreach(Consumption item in LocalMemoryDB.ConsumptionsContext)
            {
                if(item.MemberID == entity)
                {
                    item.Paid=true;
                }
            }
        }

    }
}
