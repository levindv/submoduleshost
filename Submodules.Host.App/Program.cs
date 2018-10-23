using Submodules.First.Logic;
using Submodules.Second.Logic;
using System;

namespace Submodules.Host.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new FirstLogic();
            var second = new SecondLogic();

            var fresult = first.ExecuteAndGetStatus(new First.Contracts.FirstContract()); // was fixed contract default value
            var sresult = second.ExecuteAndGetPunctuation(new Second.Contracts.SecondContract());

            Console.WriteLine(Environment.NewLine + "Should be '" + fresult + sresult + "'");
            Console.ReadLine();
        }
    }
}