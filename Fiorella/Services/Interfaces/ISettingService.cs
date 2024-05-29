using System;
namespace Fiorella.Services.Interfaces
{
	public interface ISettingService
	{
		Task<Dictionary<string, string>> GetAllAsync();
	}
}

