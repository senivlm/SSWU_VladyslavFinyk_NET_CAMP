using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal static class Validator
    {
        public static (string message, bool validationResult) ValidateWaterConsumption(float consumptionLevel, float waterTowerMaxCapacity)
        {
            if (consumptionLevel < 0)
            {
                return ("Consumption level must be greater than 0!", false);
            }
            // The first validation that came to mind. it must be changed,
            // or perhaps called in the class that will connect the user and the tower
            if (consumptionLevel < waterTowerMaxCapacity)
            {
                return ($"Consumption level must lower than water tower capacity! It is {waterTowerMaxCapacity}", false);
            }
            return ("All right", true);
        }

        public static (string message, bool validationResult) ValidateWaterTowerMaxCapacity(float maxCapacity)
        {
            return ($"Max capacity must be greater than 0 and lower than {float.MaxValue}", maxCapacity > 0 && maxCapacity < float.MaxValue);
        }
        public static (string message, bool validationResult) ValidateWaterTowerMinCapacity(float minCapacity, float maxCapacity)
        {
            return ($"Min capacity must be greater than 0 and lower than {maxCapacity}", minCapacity > 0 && minCapacity < maxCapacity);
        }
        public static (string message, bool validationResult) ValidateWaterTowerCurrentCapacity(float currentCapacity, float maxCapacity)
        {
            return ($"Current capacity must be greater than 0 and lower than {maxCapacity}", currentCapacity > 0 && currentCapacity < maxCapacity);
        }

        // TODO add validations of user input (like in Homework 1)
    }
}
