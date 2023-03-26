using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_task_1
{
    public static class Validator
    {
        public static (string message, bool validationResult) ValidateSequenceSizeInput(int userInput){
            return ("Number must be greater than 0!", userInput > 0);
        }
    }
}