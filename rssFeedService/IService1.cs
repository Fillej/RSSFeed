using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RSSFeedService 
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Lägger till RSS i listan
        [OperationContract]
        [WebInvoke(UriTemplate = "addRSS/{CustomerID}/{URL}",
                Method = "GET",
                ResponseFormat = WebMessageFormat.Json)]
        string AddRss(string CustomerID, string URL);

        // Tar bort RSS från listan
        [OperationContract]
        [WebInvoke(UriTemplate = "delRSS/{CustomerID}/{URL}",
                Method = "GET",
                ResponseFormat = WebMessageFormat.Json)]
        string delRss(string CustomerID, string URL);


        // Läser in nya feeds
        [OperationContract]
        [WebInvoke(UriTemplate = "Refresh/{CustomerID}",
                Method = "GET",
                ResponseFormat = WebMessageFormat.Json)]
        string refresh(string CustomerID);

        // Skapar en "God" tag
        [OperationContract]
        [WebInvoke(UriTemplate = "addTag/{CustomerID}/{tag}/Keep",
                Method = "GET",
                ResponseFormat = WebMessageFormat.Json)]
        string addTagToKeep(string CustomerID, string tag);


        // Skapa en "Skräp" Tag
        [OperationContract]
        [WebInvoke(UriTemplate = "addTag/{CustomerID}/{tag}/Kill",
                Method = "GET",
                ResponseFormat = WebMessageFormat.Json)]
        string addTagToKill(string CustomerID, string tag);

        // Ta bort en ”god” tag
        [OperationContract]
        [WebInvoke(UriTemplate = "delTag/{CustomerID}/{tag}/Keep",
        Method = "GET",
        ResponseFormat = WebMessageFormat.Json)]
        string delTagFromKeep(string CustomerID, string tag);

        // Tar bort en ”skräp” tag
        [OperationContract]
        [WebInvoke(UriTemplate = "delTag/{CustomerID}/{tag}/Kill",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json)]
        string delTagFromKill(string CustomerID, string tag);

        // Visa lista på ”goda” taggar
        [OperationContract]
        [WebInvoke(UriTemplate = "Tags/{CustomerID}/Keep",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json)]
        string showtagsFromKeep(string CustomerID);

        // Visa lista på ”skräp” taggar
        [OperationContract]
        [WebInvoke(UriTemplate = "Tags/{CustomerID}/Kill",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json)]
        string showTagsFromKill(string CustomerID);

        //Hämtar senaste listan sen senaste Refresh
        [OperationContract]
        [WebInvoke(UriTemplate = "News/{CustomerID}",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json)]
        string newsFromGood(string CustomerID);

        // Hämtar senaste skräplistan sen senaste Refresh/
        [OperationContract]
        [WebInvoke(UriTemplate = "News/{CustomerID}/trash",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json)]
        string newsFromTrash(string CustomerID);

        //Hämtar senaste listan av poster som inte matchat sen senaste Refresh
        [OperationContract]
        [WebInvoke(UriTemplate = "News/{CustomerID}/other",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json)]
        string newsFromOther(string CustomerID);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
