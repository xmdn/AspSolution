namespace CustomClient.Models;

public class ItemResult
{
    public bool Success { get; set; }
    public string Message { get; set; }

    public ItemResult(bool success, string message = null)
    {
        Success = success;
        Message = message;
    }

    // Factory methods
    public static ItemResult SuccessResult(string message = null) => new ItemResult(true, message);
    public static ItemResult FailureResult(string message) => new ItemResult(false, message);
}

public class ItemResult<T> : ItemResult
{
    public T Data { get; set; }

    public ItemResult(bool success, string message = null, T data = default) : base(success, message)
    {
        Data = data;
    }

    // Factory methods
    public static ItemResult<T> SuccessResult(T data, string message = null) => new ItemResult<T>(true, message, data);
    public static ItemResult<T> FailureResult(string message) => new ItemResult<T>(false, message);
}