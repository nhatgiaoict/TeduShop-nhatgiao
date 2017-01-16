using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Infrastructure.Core;

namespace TeduShop.Web.Api
{
    [RoutePrefix("api/newscategory")]
    public class NewsCategoryController : ApiControllerBase
    {
        INewsCategoryService _newsCategoryService;
        public NewsCategoryController(IErrorService errorService, INewsCategoryService newsCategoryService):
            base(errorService)
        {
            this._newsCategoryService = newsCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                
                    var ListCategory = _newsCategoryService.GetAll();

                   HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, ListCategory);

              
                return response;

                //HttpResponseMessage response = null;
                //if (ModelState.IsValid)
                //{
                //    var ListCategory = _newsCategoryService.GetAll();

                //    response = request.CreateResponse(HttpStatusCode.OK, ListCategory);
                //}
                //else
                //{
                //    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                //}
                //return response;
            });
        }

        public HttpResponseMessage Post(HttpRequestMessage request, NewsCategory newsCategory)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var category = _newsCategoryService.Add(newsCategory);
                    _newsCategoryService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.Created, category);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }

        public HttpResponseMessage Put(HttpRequestMessage request, NewsCategory newsCategory)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    _newsCategoryService.Update(newsCategory);
                    _newsCategoryService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    _newsCategoryService.Delete(id);
                    _newsCategoryService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }
    }

}