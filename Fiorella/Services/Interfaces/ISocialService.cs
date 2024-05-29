using System;
using Fiorella.Models;

namespace Fiorella.Services.Interfaces
{
	public interface ISocialService
	{
		Task<IEnumerable<Social>> GetAllAsync();
	}
}

