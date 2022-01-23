using System.Runtime.Serialization;

[Serializable]
internal class StrategyNullException : Exception
{
    public StrategyNullException()
    {
    }

    public StrategyNullException(string? message) : base(message)
    {
    }

    public StrategyNullException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected StrategyNullException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}