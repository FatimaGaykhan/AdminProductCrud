using System;
using Fiorella.Models;

namespace Fiorella.Services.Interfaces
{
	public interface ISliderService
	{
		Task<IEnumerable<Slider>> GetAllAsync();
		Task<SliderInfo> GetSliderInfoAsync();
	}
}

