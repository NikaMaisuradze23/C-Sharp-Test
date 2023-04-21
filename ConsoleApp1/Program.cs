internal class Program
{
    private static void Main(string[] args)
    {

        string my_username, my_password, username, password;
        int count;
        my_username = "nika";
        my_password = "123";
        
        count = 0;


        while (true)
        {
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            password = Console.ReadLine();


            if (username == my_username && password == my_password)
            {
                Console.WriteLine("warmateba");
                break;
            }
            else
            {
                count++;
            }

            if (count == 4)
            {
                throw new Exception("SHECDOMA");
            }
            
        }     

    }
}