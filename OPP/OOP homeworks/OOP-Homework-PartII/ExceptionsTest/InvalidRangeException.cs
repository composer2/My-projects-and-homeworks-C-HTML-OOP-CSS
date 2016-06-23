namespace ExceptionsTest
{
    using System;

    internal class InvalidRangeException<T> : ApplicationException
    {
        public T StartPoint { get; private set; }
        public T EndPoint { get; private set; }


        public InvalidRangeException(string message, T startPoint, T endPoint, Exception exception)
            :base(message, exception)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public InvalidRangeException(string msg, T startPoint, T endPoint)
            :this(msg, startPoint, endPoint, null)
        { }
    }
}
