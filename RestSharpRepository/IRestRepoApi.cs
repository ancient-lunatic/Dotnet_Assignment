using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TypeaheadLocation
{
   public interface IRestRepoApi
    {
        string partner_id { get; set; }
        string AddPartnerIdInObject();
        void RestRequestGet(string resource);
        T FetchgetRequest<T>();
        void Addquerryparams(string key, string value);
        void RestRequestPost(string resource);
        void RestRequestPut(string resource);
        void RestRequestDelete(string resource);
        void AddPartnerId();
        void AddParams(string key, string value);
        void AddobjectBody<T>(T body);
        T FetchPost<T>();
     
        T FetchDelete<T>();
    }
}
