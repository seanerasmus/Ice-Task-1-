namespace IndexExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("EMPO111", "Director" , "Bob" , "Tim" , 8000);
            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);

            Console.WriteLine("Employee Number: " + emp["empNumber"]);
            Console.WriteLine("Employee Title:" + emp["jobTitle"]);
            Console.WriteLine("Employee Number: " + emp["nmae"]);
            Console.WriteLine("Employee Title:" + emp["surname"]);
            Console.WriteLine("Employee Number: " + emp["salary"]);
           



        }
    }
}
