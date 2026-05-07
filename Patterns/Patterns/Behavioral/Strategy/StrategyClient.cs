namespace Patterns.Behavioral.Strategy
{
    public sealed class StrategyClient
    {
        public static void DoJobUsingSomeStrategy(IStrategy strategy, string parameter)
        {
            strategy.DoSomeImportantJob(parameter);
        }
    }
}
