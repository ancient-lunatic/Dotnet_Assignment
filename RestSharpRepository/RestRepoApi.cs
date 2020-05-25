using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;


namespace TypeaheadLocation
{
    public class RestRepo : IRestRepoApi
    {
        private string PartnerId;
        public string partner_id
        {
            get =>  "9383" ;
            set { PartnerId = value; }
        } 

        private readonly RestClient _client ;
        private RestRequest _request;

        public RestRepo()
        {
          _client  = new RestClient("https://sprint-api.newhomesource.com");
        }
        public void RestRequestGet(string resource)
        {
            _request = new RestRequest(resource, Method.GET);
           
        }
        public void RestRequestPost(string resource)
        {
            _request = new RestRequest(resource, Method.POST);
        }
        public void RestRequestPut(string resource)
        {
            _request = new RestRequest(resource, Method.PUT);
        }
        public void RestRequestDelete(string resource)
        {
            _request = new RestRequest(resource, Method.DELETE);
        }
        public void AddPartnerId()
        {
            _request.AddParameter("partnerid", PartnerId, ParameterType.QueryString);
        }
        public void AddobjectBody<T>(T body)
        {
            _request.AddJsonBody(body);
        }

        public T FetchgetRequest<T>()
        {
            IRestResponse<T> response = _client.Get<T>(_request);

            var res=   JsonConvert.DeserializeObject<T>(response.Content);
            return res;
        }
        public void Addquerryparams(string key , string value)
        {
            _request.AddParameter(key,value, ParameterType.QueryString);
        }
        public void AddParams(string key, string value)
        {
            _request.AddParameter(key, value, ParameterType.UrlSegment);
        }
        public  T FetchPost<T>()
        {
            var result =  _client.Execute(_request);
            return JsonConvert.DeserializeObject<T>(result.Content);
        }
       
        public T FetchDelete<T>()
        {
            var result = _client.Execute(_request);
            return JsonConvert.DeserializeObject<T>(result.Content);
        }

        public string AddPartnerIdInObject()
        {
           return PartnerId;
        }
    }
}
