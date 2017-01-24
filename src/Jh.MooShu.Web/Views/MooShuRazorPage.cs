using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Jh.MooShu.Web.Views
{
    public abstract class MooShuRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MooShuRazorPage()
        {
            LocalizationSourceName = MooShuConsts.LocalizationSourceName;
        }
    }
}
