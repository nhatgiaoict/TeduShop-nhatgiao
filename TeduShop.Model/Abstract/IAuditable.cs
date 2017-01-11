using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        string MetaKeyword { set; get; }

        string MetaDescription { set; get; }

        DateTime? CreatedDate { set; get; }

        string Createdby { set; get; }

        DateTime? UpdateDate { set; get; }

        string UpdateBy { set; get; }

        bool Status { set; get; }
    }
}