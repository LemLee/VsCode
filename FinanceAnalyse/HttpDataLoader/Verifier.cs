namespace HttpDataLoader;

/// <summary>
/// Makes init verifications.
/// </summary>
public static class Verifier
{
    /// <summary>
    /// Check for null value.
    /// </summary>
    /// <param name="obj">object to check.</param>
    /// <param name="parameterName">name of parameter.</param>
    public static void IsNotNull(object obj, string parameterName)
    {
        if (obj == null)
        {
            throw new ArgumentNullException($"The {parameterName} should not be null");
        }
    }
}