namespace PageBuilderRCL.Data.Exceptions;

[Serializable]
public sealed class DbContextCannotInstantiatedException : Exception
{
    public DbContextCannotInstantiatedException(string dbContextName) : base($"{dbContextName} cannot instantiated")
    {
    }
}
