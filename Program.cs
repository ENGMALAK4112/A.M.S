using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace كود_حساب_العمر
{

    class Program
    {
        static void Main(string[] args)
        {
            DateTime MyAge;
            Console.Write("Write Your Birth Day: ");
            MyAge = Convert.ToDateTime(Console.ReadLine());
            int year = Convert.ToInt32(DateTime.Now.Subtract(MyAge).TotalDays) / 360;
            Console.WriteLine("your Age is: " + year + "Years");
            Console.ReadKey();
           // Activity workflow1 = new Workflow1();
            //WorkflowInvoker.Invoke(workflow1);
        }
    }
}
