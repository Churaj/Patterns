using System;

namespace Patterns.Behavioral.Strategy
{
    public class StrategyOne : IStrategy
    {
        public void DoSomeImportantJob(string parameter)
        {
            Console.WriteLine($"doing some job as strategy1 and parameter {parameter}");
        }
    }
}
