using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Infrastructure.Core;
using TeduShop.Web.Models;
using TeduShop.Web.Infrastructure.Extensions;

namespace TeduShop.Web.Api
{
    [RoutePrefix("api/newscategory")]
    [Authorize]
    public class NewsCategoryController : ApiControllerBase
    {
        private INewsCategoryService _newsCategoryService;

        public NewsCategoryController(IErrorService errorService, INewsCategoryService newsCategoryService) :
            base(errorService)
        {
            this._newsCategoryService = newsCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _newsCategoryService.GetAll();
                var lisNewsCategoryVm = Mapper.Map<List<NewsCategoryViewModel>>(listCategory);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, lisNewsCategoryVm);

                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, NewsCategoryViewModel newsCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    NewsCategory sNewsCategory = new NewsCategory();
                    sNewsCategory.UpdateNewsCategory(newsCategoryVm);
                    var category = _newsCategoryService.Add(sNewsCategory);
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

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, NewsCategoryViewModel newsCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var newsCategoryDb = _newsCategoryService.GetById(newsCategoryVm.ID);
                    newsCategoryDb.UpdateNewsCategory(newsCategoryVm);
                    _newsCategoryService.Update(newsCategoryDb);
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