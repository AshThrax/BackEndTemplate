namespace templateapi.ExtensionMethods;
public static class JwToken
{
    /// <summary>
    /// add dependency injection Jwttoken Service
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection JwToken(this IServiceCollection services)
    {
        return services;
    }
}