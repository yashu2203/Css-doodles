using Autocomplete.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Autocomplete.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SearchController : ApiController
    {
        List<SearchResult> Results = new List<SearchResult>();


        public HttpResponseMessage Get(string searchString)
        {
            RetrieveResults(searchString);

            return Request.CreateResponse(HttpStatusCode.OK, Results);

        }

        private void RetrieveResults(string sLookUpString)
        {
            //Simulating a DB Fetch
            Thread.Sleep(300);

            //Adding Fetched Items to the list
            for (int i = 0; i < 50; i++)
            {
                Results.Add(new SearchResult { ID = Guid.NewGuid(), Result = "Result " + i });
            }


        }
    }
}
