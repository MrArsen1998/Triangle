namespace Extensions;

public static class TaskExtensions
{
    public static async void SafeFireAndForget(this Task task, Action<Exception> onException = null, bool continueOnCapturedContext = true)
    {
        try
        {
            await task.ConfigureAwait(continueOnCapturedContext);
        }
        catch (Exception ex) when (onException != null)
        {
            onException(ex);
        }
    }
}