// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using DataExportSales.Models;
using Newtonsoft.Json.Linq;

namespace DataExportSales.Models
{
    public static partial class EntityResponseCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<EntityResponse> DeserializeJson(JToken inputObject)
        {
            IList<EntityResponse> deserializedObject = new List<EntityResponse>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                EntityResponse entityResponse = new EntityResponse();
                entityResponse.DeserializeJson(iListValue);
                deserializedObject.Add(entityResponse);
            }
            return deserializedObject;
        }
    }
}
