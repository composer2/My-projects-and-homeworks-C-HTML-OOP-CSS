namespace OOP_Principles_Part_2
{
    using System;

    internal class InvalidCalculationException : ApplicationException
    {
        public InvalidCalculationException(string message) 
            : base(message) { }

        public InvalidCalculationException(string message, Exception innerEx)
            : base(message, innerEx) { }
    }
}
