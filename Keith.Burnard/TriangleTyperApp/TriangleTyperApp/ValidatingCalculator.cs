namespace TriangleTyperApp
{
    public class ValidatingCalculator
    {
        private readonly TriangleTypeCalculator _calculator;
        private readonly InputValidator _validator;

        public ValidatingCalculator() : this(new InputValidator(), new TriangleTypeCalculator())
        {
        }

        // Things to google: "dependency injection", "constructor-based dependency injection",
        // "mock objects and dependency injection", "unit testing with mock objects", "C# mocking frameworks",
        // "C# dependency injection frameworks", "NUnit mocks" (especially "NUnit mocks")
        // Constructor for dependency injection for tests.
        public ValidatingCalculator(InputValidator validator, TriangleTypeCalculator calculator)
        {
            _validator = validator;
            _calculator = calculator;
        }

        public string GetValidatedTriangleType(string sideA, string sideB, string sideC)
        {
            string message = _validator.TestInputValues(sideA, sideB, sideC);

            if (message == "Good")
            {
                message = _calculator.GetTriangleType(sideA, sideB, sideC);
            }
            return message;
        }
    }
}