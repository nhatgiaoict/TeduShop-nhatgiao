namespace TeduShop.Web.Models
{
    public class NewsTagViewModel
    {
        public int NewID { set; get; }

        public string TagsID { set; get; }

        public virtual NewsViewModel News { set; get; }

        public virtual TagViewModel Tags { set; get; }
    }
}