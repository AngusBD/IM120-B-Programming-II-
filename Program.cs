namespace _20230217 {
    internal class Program {
        static void Main(string[] args) {
            UserId();
            stringFormat();
        }
        static void UserId(){
            string userId;
            Console.Write("Please enter your account: ");
            userId = Console.ReadLine();
            Console.WriteLine("Your account is : {0}",userId);
            Console.Write("Press Enter to exit.");
            Console.Read();
        }
        static void stringFormat() {
            Console.Write("Please enter your tuition: ");
            int tuition;
            tuition = int.Parse(Console.ReadLine());
            Console.WriteLine("Your tuition is : " + tuition.ToString("#,#.00"));
            Console.Write("Press Enter to exit.");
            Console.Read();
        }
    }
}