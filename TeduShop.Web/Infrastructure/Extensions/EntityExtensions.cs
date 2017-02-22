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

        public static void UpdateProductCategory(this ProductCategory productCategories, ProductCategoryViewModel productCategoriesVm)
        {
            productCategories.ID = productCategoriesVm.ID;
            productCategories.Title = productCategoriesVm.Title;
            productCategories.ShortLink = productCategoriesVm.ShortLink;
            productCategories.ParentID = productCategoriesVm.ParentID;
            productCategories.Idx = productCategoriesVm.Idx;
            productCategories.Fimages = productCategoriesVm.Fimages;
            productCategories.Summary = productCategoriesVm.Summary;
            productCategories.HomeFlag = productCategoriesVm.HomeFlag;
            productCategories.MetaKeyword = productCategoriesVm.MetaKeyword;
            productCategories.MetaDescription = productCategoriesVm.MetaDescription;
            productCategories.CreatedDate = productCategoriesVm.CreatedDate;
            productCategories.Createdby = productCategoriesVm.Createdby;
            productCategories.UpdateDate = productCategoriesVm.UpdateDate;
            productCategories.UpdateBy = productCategoriesVm.UpdateBy;
            productCategories.Status = productCategoriesVm.Status;
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

        public static void UpdateProduct(this Product product, ProductViewModel productVm)
        {
            product.ID = productVm.ID;
            product.Title = productVm.Title;
            product.ShortLink = productVm.ShortLink;
            product.CategoryID = productVm.CategoryID;
            product.Fimages = productVm.Fimages;
            product.MoreImages = productVm.MoreImages;
            product.Price = productVm.Price;
            product.PromotionPrice = productVm.PromotionPrice;
            product.Warranty = productVm.Warranty;
            product.Summary = productVm.Summary;
            product.Content = productVm.Content;
            product.HomeFlag = productVm.HomeFlag;
            product.HotFlag = productVm.HotFlag;
            product.MetaKeyword = productVm.MetaKeyword;
            product.MetaDescription = productVm.MetaDescription;
            product.CreatedDate = productVm.CreatedDate;
            product.Createdby = productVm.Createdby;
            product.UpdateDate = productVm.UpdateDate;
            product.UpdateBy = productVm.UpdateBy;
            product.Status = productVm.Status;
            product.Tags = productVm.Tags;
        }
    }
}