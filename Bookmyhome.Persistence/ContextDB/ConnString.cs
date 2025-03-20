using Microsoft.Extensions.Configuration;

namespace Bookmyhome.Persistence.ContextDB
{
	public static class ConnString
	{
		private static IConfiguration _configuration;
		public static void Initialize(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		public static string GetConnString()
		{
			return	_configuration.GetConnectionString("DefaultConnection");
		}
	}
}
