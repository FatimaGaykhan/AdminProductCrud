using System;
using Fiorella.ViewModels.Expert;

namespace Fiorella.Services.Interfaces
{
	public interface IExpertService
	{
		Task<IEnumerable<ExpertVM>> GetAllAsync();
	}
}

