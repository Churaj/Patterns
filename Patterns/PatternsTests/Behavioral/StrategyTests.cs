using Patterns.Behavioral.Strategy;

namespace PatternsTests.Behavioral
{
    /// <summary>
    /// Contains unit tests for verifying the behavior of strategy implementations used by the StrategyClient.
    /// </summary>
    /// <remarks>These tests ensure that different strategy classes produce the expected output when executed
    /// through the StrategyClient. The tests redirect console output to validate the results. Intended for use with
    /// automated test runners such as xUnit.</remarks>
    public class StrategyTests
    {
        private readonly StringWriter _consoleOutput;

        public StrategyTests()
        {
            _consoleOutput = new StringWriter();
            Console.SetOut(_consoleOutput);
        }

        [Fact]
        public void StrategyOne_ShouldPerformJobCorrectly()
        {
            // Arrange
            var strategy = new StrategyOne();
            var parameter = "test1";

            // Act
            StrategyClient.DoJobUsingSomeStrategy(strategy, parameter);

            // Assert
            var output = _consoleOutput.ToString().Trim();
            Assert.Equal($"doing some job as strategy1 and parameter {parameter}", output);
        }

        [Fact]
        public void StrategyTwo_ShouldPerformJobCorrectly()
        {
            // Arrange
            var strategy = new StrategyTwo();
            var parameter = "test2";

            // Act
            StrategyClient.DoJobUsingSomeStrategy(strategy, parameter);

            // Assert
            var output = _consoleOutput.ToString().Trim();
            Assert.Equal($"doing some job as strategy 2 and more text and value {parameter}", output);
        }
    }
}