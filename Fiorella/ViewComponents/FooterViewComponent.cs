using System;
using Fiorella.Models;
using Fiorella.Services;
using Fiorella.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.ViewComponents
{
	public class FooterViewComponent:ViewComponent
	{
		private readonly ISocialService _socialService;
		private readonly ISettingService _settingService;

		public FooterViewComponent(ISocialService socialService,
                                   ISettingService settingService)
		{
			_socialService = socialService;
			_settingService = settingService;
		}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerDatas = new FooterVMVC
            {
                SettingDatas = await _settingService.GetAllAsync(),
                SocialMedias = await _socialService.GetAllAsync()
            };

            return await Task.FromResult(View(footerDatas));
        }
    }

	public class FooterVMVC
	{
		public IDictionary<string,string>  SettingDatas{ get; set; }

		public IEnumerable<Social> SocialMedias{ get; set; }
		

	}
}

