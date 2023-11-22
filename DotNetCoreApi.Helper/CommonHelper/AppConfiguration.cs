namespace DotNetCoreApi.Helper.CommonHelper
{
    public class AppConfiguration
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string DefaultConnectionString { get; set; }
    }
}