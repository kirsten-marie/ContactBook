namespace ContactBook.Data;

public static class DbExtensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<ContactBookContext>();
        context.Database.EnsureCreated();
        DbInitializer.Initalize(context);
    }
}