---
title: "Reuse Entity Search definition in your custom code for Unified Service Desk | MicrosoftDocs"
description: "Replacement parameters can be used throughout the application to pull data from data elements (called data parameters) captured during the execution of the application that augment and include the Unified Service Desk context."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Reuse Entity Search definition in your custom code

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

Entity search in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is exposed as a service for developers so that they can programmatically use an existing entity search definition in their custom code to search Microsoft Dataverse data. Entity searches in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] use FetchXML to query Dataverse web services to return data. For information about defining entity searches, see [Search data using entity searches in Unified Service Desk](../unified-service-desk/search-data-entity-searches.md).  
  
 When you set up an entity search, you can choose whether to return an entire search result set or page the FetchXML results for large datasets by using a paging cookie for faster performance. For more information about using paging cookie with FetchXML, see [Page large result sets with FetchXML](/previous-versions/dynamicscrm-2016/developers-guide/gg309717(v=crm.8)).  
  
 Since you use an entity search name in your code to return data and not its FetchXML definition, updating the underlying FetchXML query definition of the entity search in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] without changing the entity search name ensures that you won’t have to update your custom control code, recompile, and redistribute it on the client computers.  
  
 Use the new [EntitySearchRequest](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchrequest) message to construct a request, and then pass the request as parameter to the [EntitySearchService](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchservice).[EntitySearchResponse})](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchservice.getentitysearchresults(microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchrequest,system.action{microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchresponse})) method to get the response ([EntitySearchResponse](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchresponse)).  
  
<a name="Request"></a>   
## Create an EntitySearchRequest object  
 The [EntitySearchRequest](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchrequest) message is overloaded, and you must use any of the following three constructors to create a request object depending how you want the records to be returned. Creating a request object without using one of these three constructors is not supported. Before using an entity search name in the request object, ensure that the entity search is already defined in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] on your Dataverse instance.  
  
-   Create a request object using just the entity search name. Use this constructor to return all the records as a result of the entity search.  
  
    ```csharp  
    EntitySearchRequest mySearchRequest = new EntitySearchRequest(string entitySearchName);  
    ```  
  
-   Create a request object using the entity search name and the maximum count of the records to be returned. Use this constructor to limit the number of records returned as a result of the entity search.  
  
    ```csharp  
    EntitySearchRequest mySearchRequest = new EntitySearchRequest(string entitySearchName, int maxCount);  
    ```  
  
    > [!TIP]
    >  Specify 0 for the `maxCount` parameter to return all the records.  
  
-   Create a request object using the entity search name, page count, page number, and paging cookie. Use this constructor to return large datasets in pages for faster performance.  
  
     The `pageCount` parameter defines the number of records to return per page. The `pageNumber` parameter defines the page number of the result set to return the data. For example, if your query returns 500 records, you can specify `pageCount` as **50** to return 50 records in a page, which implies that you’ll have 10 pages of data (50 records * 10 pages = 500). Now, if you want to return records 100-150, specify the `pageNumber` value as 3. You must specify `pageCookie` as `empty` to retrieve the first page of the result set.  
  
    ```csharp  
    EntitySearchRequest mySearchRequest = new EntitySearchRequest(string entitySearchName, int pageCount, int pageNumber, string pageCookie);  
    ```  
  
    > [!NOTE]
    >  When you execute the request object using this constructor to retrieve results in pages, the [EntitySearchResponse](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchresponse).[HasMoreRecords](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchresponse.hasmorerecords) property of the response object indicates if there are more records (value=1). Also, the value of the [EntitySearchResponse](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchresponse).[PageCookie](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchresponse.pagecookie) property is set to the paging cookie returned from current results.  
  
<a name="Execute"></a>   
## Execute the request object  
 Use the [EntitySearchService](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchservice).[EntitySearchResponse})](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchservice.getentitysearchresults(microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchrequest,system.action{microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchresponse})) method to execute the request object created as described in the previous section. This method executes the [EntitySearchRequest](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchrequest) object, and returns a [EntitySearchResponse](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.entitysearch.entitysearchresponse) object with the entity search results.  
  
 The following code sample demonstrates how you can reuse an existing entity search to retrieve results in pages.  
  
```csharp  
// Define parameters for the entity search request object.  
string entitySearchName = "Sample Entity Search"; // Name of the entity search record defined in Unified Service Desk  
int pageCount = 10; // Retrieve 10 records per page.  
int pageNumber = 0;  
string pageCookie = String.Empty; // Retrieve the first page of the result set.  
  
var entityService = AifServiceContainer.Instance.GetService<IEntitySearchService>();  
  
// Create a request object.  
EntitySearchRequest entitySearchRequest = new EntitySearchRequest(searchName, pageCount, pageNumber, pageCookie);  
  
bool hasMoreRecords = true;  
  
while (hasMoreRecords)  
{  
   entityService.GetEntitySearchResults(entitySearchRequest, (entitySearchResponse) =>  
   {  
      foreach (Entity e in entitySearchResponse.Entities)  
      {  
         Console.WriteLine("Entity with id:\"{0}\" retrieved", e.Id);  
      }  
      if (entitySearchResponse.HasMoreRecords)  
      {  
         pageNumber++;  
         pageCookie = entitySearchResponse.PageCookie;  
         entitySearchRequest = new EntitySearchRequest(searchName, pageCount, pageNumber, pageCookie);  
      }  
      else  
      {  
         hasMoreRecords = false;  
      }  
   });  
}  
```  
  
### See also  
 [Search data using entity searches in Unified Service Desk](../unified-service-desk/search-data-entity-searches.md)   
 [DoSearch](../unified-service-desk/global-manager-hosted-control.md#DoSearch)


[!INCLUDE[footer-include](../includes/footer-banner.md)]