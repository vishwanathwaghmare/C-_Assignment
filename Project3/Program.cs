namespace Project2

{
    internal class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            bool isprime = true;

            for(int i = 2; i <=num/2; i++)
            { 
                if(num%i == 0)
                { 
                    isprime = false;
                    break;
                
                }

            }
            if(isprime==false) 
            
            {
                Console.WriteLine("number is not prime");
            }
            else
            {
                Console.WriteLine("Number is prime");
            }
        }

    }
}