// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using DataExportSales.Models;
using Newtonsoft.Json.Linq;

namespace DataExportSales.Models
{
    public static partial class RelationshipResponseCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<RelationshipResponse> DeserializeJson(JToken inputObject)
        {
            IList<RelationshipResponse> deserializedObject = new List<RelationshipResponse>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                RelationshipResponse relationshipResponse = new RelationshipResponse();
                relationshipResponse.DeserializeJson(iListValue);
                deserializedObject.Add(relationshipResponse);
            }
            return deserializedObject;
        }
    }
}
