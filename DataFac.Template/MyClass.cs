using System;

namespace DataFac.Template;

/// <summary>
/// My greeter class.
/// </summary>
public sealed class MyClass1 : IDisposable
{
    private readonly string _myName;

    /// <summary>
    /// Creates an instance of MyClass1 with the specified name.
    /// </summary>
    /// <param name="myName"></param>
    public MyClass1(string myName)
    {
        _myName = myName;
    }

    #region IDisposable implentation
    private volatile bool _disposed;
    /// <summary>
    /// Disposes this instance.
    /// </summary>
    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;
    }
    #endregion

    /// <summary>
    /// Gets a greeting message for the specified name.
    /// </summary>
    /// <param name="yourName">The name to greet.</param>
    /// <returns>A greeting message.</returns>
    public string GetGreeting(string yourName) => $"Hello {yourName}, my name is {_myName}.";

}
