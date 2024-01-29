using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        //addition
        public decimal Add(decimal num1, decimal num2){
            return num1 + num2;
        }
        //subtraction
        public decimal Subtract(decimal num1, decimal num2){
            return num1 - num2;
        }

        //multiplication
         public decimal Multiply(decimal num1, decimal num2){
            return num1 * num2;
        }
        
        //division
         public decimal Divide(decimal num1, decimal num2){
            if(num2 != 0){
                return num1 / num2;
            }
            else
                return 0;
        }

        //modulus
         public decimal Modulo(decimal num1, decimal num2){
            if(num1 == 0)
                return num2;
            else 
                if(num2 == 0){
                    return num1;
            }
            else{
                decimal div = 0;
                div = (int)num1/num2;
                return (int)(num1 - div);
            }
         }
       
    }
}
