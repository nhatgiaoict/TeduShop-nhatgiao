using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateNewsCategory(this NewsCategory newsCategory, NewsCategoryViewModel newsCategoryVm)
        {
            newsCategory.ID = newsCategoryVm.ID;
            newsCategory.Title = newsCategoryVm.Title;
            newsCategory.ShortLink = newsCategoryVm.ShortLink;
            newsCategory.ParentID = newsCategoryVm.ParentID;
            newsCategory.Idx = newsCategoryVm.Idx;
            newsCategory.Fimages = newsCategoryVm.Fimages;
            newsCategory.Summary = newsCategoryVm.Summary;
            newsCategory.HomeFlag = newsCategoryVm.HomeFlag;
            newsCategory.MetaKeyword = newsCategoryVm.MetaKeyword;
            newsCategory.MetaDescription = newsCategoryVm.MetaDescription;
            newsCategory.CreatedDate = newsCategoryVm.CreatedDate;
            newsCategory.Createdby = newsCategoryVm.Createdby;
            newsCategory.UpdateDate = newsCategoryVm.UpdateDate;
            newsCategory.UpdateBy = newsCategoryVm.UpdateBy;
            newsCategory.Status = newsCategoryVm.Status;
        }

        public static void UpdateNews(this News news, NewsViewModel newsVm)
        {
            news.ID = newsVm.ID;
            news.Title = newsVm.Title;
            news.ShortLink = newsVm.ShortLink;
            news.CategoryID = newsVm.CategoryID;
            news.Fimages = newsVm.Fimages;
            news.Summary = newsVm.Summary;
            news.Content = newsVm.Content;
            news.HomeFlag = newsVm.HomeFlag;
            news.HotFlag = newsVm.HotFlag;
            news.ViewCount = newsVm.ViewCount;
            news.MetaKeyword = newsVm.MetaKeyword;
            news.MetaDescription = newsVm.MetaDescription;
            news.CreatedDate = newsVm.CreatedDate;
            news.Createdby = newsVm.Createdby;
            news.UpdateDate = newsVm.UpdateDate;
            news.UpdateBy = newsVm.UpdateBy;
            news.Status = newsVm.Status;
        }
    }
}