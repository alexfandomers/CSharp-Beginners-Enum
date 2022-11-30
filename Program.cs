namespace EnumBeginners
{
    public enum ShippingMethod
    {
        RegularMail = 1,
        RegisterAirMail = 2,
        Express = 3
    }
     public class Program
    {
        static void Main(string[] args)
        {  
               //get numeric value of the enum
               var method = ShippingMethod.Express;
               Console.WriteLine((int)method);  

               //identify shipping method by number
               var methodId = 2;
               Console.WriteLine((ShippingMethod)methodId); 

               //convert enum to a string
               Console.WriteLine(method.ToString());   

                //convert string to Enum
               //var methodName = "Express";
               //var ShippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);  
               //Console.WriteLine(ShippingMethod);       
        }
    }
}