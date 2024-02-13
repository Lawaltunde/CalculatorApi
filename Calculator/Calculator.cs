using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public static class Calculator : ControllerBase
    {
        //[Route("{num1}/{num2}")]

        public static decimal answer =0;
        //addition

        public static String Add(decimal num1, decimal num2){
            return (answer = num1 + num2).ToString();
        }
        //subtraction
        public static String Subtract(decimal num1, decimal num2){
            return (answer = num1 - num2).ToString();
        }

        //multiplication
         public static String Multiply(decimal num1, decimal num2){
            return (answer = num1 * num2).ToString();
        }
        
        //division
         public static String Divide(decimal num1, decimal num2){
            if(!num2.Equals(0)){
                return (answer = num1 / num2).ToString();
            }
            else
                return "Infinity: Denominator cannot be zero!!!";
        }

        //modulus
         public static String Modulo(decimal num1, decimal num2){
            if(num1.Equals(0))
                return (answer = 0).ToString();
            else 
                if(num2.Equals(0)){
                    return num1.ToString();
            }

            else
                if(num1 < num2)
                    return num1.ToString();
            else{
                    int div = (int)(num1/num2);
                    return (answer = (num1 - (div *num2))).ToString();
                }
         }
       
    }
}
