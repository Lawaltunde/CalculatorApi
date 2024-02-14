using StringLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{

    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        
        //[Route("{num1}/{num2}")]

        //Referencing add method from library class
        public  String Add(decimal num1, decimal num2) => MathematicalOperation.Add(num1, num2);

        //Referencing add method from library class
        public  String Subtract(decimal num1, decimal num2) => MathematicalOperation.Subtract(num1, num2);

        //Referencing add method from library class
        public  String Divide(decimal num1, decimal num2) => MathematicalOperation.Divide(num1, num2);

        //Referencing add method from library class
        public  String Multiply(decimal num1, decimal num2) => MathematicalOperation.Multiply(num1, num2);

        //Referencing add method from library class
        public  String Modulo(decimal num1, decimal num2) => MathematicalOperation.Modulo(num1, num2);



        /*public decimal answer =0.0M;
        //addition

        public  String Add(decimal num1, decimal num2){
            return (answer = num1 + num2).ToString();
        }
        //subtraction
        public  String Subtract(decimal num1, decimal num2){
            return (answer = num1 - num2).ToString();
        }

        //multiplication
         public  String Multiply(decimal num1, decimal num2){
            return (answer = num1 * num2).ToString();
        }
        
        //division
         public  String Divide(decimal num1, decimal num2){
            if(!num2.Equals(0)){
                return (answer = num1 / num2).ToString();
            }
            else
                return "Infinity: Denominator cannot be zero!!!";
        }

        //modulus
         public String Modulo(decimal num1, decimal num2){
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
         }*/
       
    }
}
