---
title: "Use change tracking to synchronize data with external systems (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The change tracking feature in Dynamics 365 Customer Engagement provides a way to keep the data synchronized in a performant way by detecting what data has changed since the data was initially extracted or last synchronized"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8a927ac0-29c3-4222-8137-36549a0dc660
caps.latest.revision: 21
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Use change tracking to synchronize data with external systems

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The change tracking feature in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement provides a way to keep the data synchronized in a performant way by detecting what data has changed since the data was initially extracted or last synchronized. Previously, without this new feature, it was difficult to build a reliable and efficient mechanism to determine what records had changed in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. This topic discusses how to retrieve changes for an entity.  
  
<a name="BKMK_enable"></a>   
## Enable change tracking for an entity  

 Before retrieving the changes for an entity, make sure that the change tracking feature is enabled for that entity. This feature can be enabled by using the customization user interface (UI) or programmatically by setting the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.ChangeTrackingEnabled> property to `True`. Annotation `Org.OData.Capabilities.V1.ChangeTracking ` gets added to entity sets that have change tracking enabled. To see annotations in entity metadata, do 

 ```http 
 GET [Organization URI]/api/data/v9.0/$metadata?annotations=true
 ```
 Read more about metadata annotations on [Metadata annotations](webapi/web-api-types-operations.md#bkmk_metannot).
 
 For more information about using the customization user interface (UI), see [Enable change tracking to control data synchronization](https://technet.microsoft.com/library/3fa9c316-9dc9-4b28-9abf-43a3fce5b01d.aspx).  
  
<a name="BKMK_webapi"></a>   
## Retrieve changes for an entity using the Web API  
Changes made in entities can be tracked using Web API requests by adding `odata.track-changes` as a preference header. Preference header `odata.track-changes` is used to request that a *delta link* be returned which can subsequently be used to retrieve entity changes.

Delta links are opaque, service-generated links that the client uses to retrieve subsequent changes to a result. They are based on a defining query that describes the set of results for which changes are being tracked; for example, the request that generated the results containing the delta link. The delta link encodes the collection of entities for which changes are being tracked, along with a starting point from which to track changes. Read more about delta links here [Oasis OData Version 4.0 - Delta Links](http://docs.oasis-open.org/odata/odata/v4.0/cs01/part1-protocol/odata-v4.0-cs01-part1-protocol.html#_Toc365046305)

<a name="BKMK_webapiexample"></a>   
## Retrieve changes in entities using Web API example

This example shows how to retrieve changes made in accounts data using the Web API.

Request
```http
GET [Organization URI]/org1/api/data/v9.0/accounts?$select=name,accountnumber,telephone1,fax HTTP/1.1
Prefer: odata.track-changes
Cache-Control: no-cache
OData-Version: 4.0
Content-Type: application/json
```
Response
```json
{
  "@odata.context":"[Organization URI]/api/data/v9.0/$metadata#accounts(name,accountnumber,telephone1,fax)",
"@odata.deltaLink": "[Organization URI]/api/data/v9.0/accounts?$select=name,accountnumber,telephone1,fax&$deltatoken=919042%2108%2f22%2f2017%2008%3a10%3a44",
"value":[
           {
              "@odata.etag":"W/\"915244\"",
              "name":"Monte Orton",
              "accountnumber":null,
              "telephone1":"555000",
              "fax":"10101",
              "accountid":"60c4e274-0d87-e711-80e5-00155db19e6d"
           }
       ]
}
```
The delta link returned from the above example can be used to fetch changes in entities. In this example a new account was created and an existing account deleted. The delta link returned from the previous request fetches these changes, as shown in the example below.

Request
```http
GET [Organization URI]/api/data/v9.0/accounts?$select=name,accountnumber,telephone1,fax&$deltatoken=919042%2108%2f22%2f2017%2008%3a10%3a44
```
Response
```json
{
          "@odata.context":"[Organization URI]/data/v9.0/$metadata#accounts(name,telephone1,fax)/$delta",
          "@odata.deltaLink":"[Organization URI]/api/data/v9.0/accounts?$select=name,telephone1,fax&$deltatoken=919058%2108%2f22%2f2017%2008%3a21%3a20",
"value":
    [
        {
            "@odata.etag":"W/\"915244\"",
            "name":"Monte Orton",
            "telephone1":"555000",
            "fax":"10101",
            "accountid":"60c4e274-0d87-e711-80e5-00155db19e6d"
        },
        {
            "@odata.context":"[Organization URI]/api/data/v9.0/$metadata#accounts/$deletedEntity",
            "id":"2e451703-c686-e711-80e5-00155db19e6d",
            "reason":"deleted"
        }
    ]
}
```
The response for the delta link returned in the initial change tracking request contains another delta link. This delta link helps in retrieving all the subsequent changes in entities. An empty JSON response is returned if no entity changes have occurred after the initial change tracking request was called.

<a name="bkmk_count"></a>
## Retrieve count of the changes made in entities using Web API
`$count` can be added to the delta link returned from the initial change tracking request, as shown in the example below to get the number of changes made.

Request
```http
GET [Organization URI]/api/data/v9.0/accounts/$count?$deltatoken=919042%2108%2f22%2f2017%2008%3a10%3a44
```

<a name="bkmk_unsupported"></a>
## Query options not supported in Change Tracking Web API request
System query options `$filter`, `$orderby` and `$top` are not supported when using `odata.track-changes` as header in Web API request. An error message saying "The `$filter`/ `$orderby`/ `$top` query parameter isn't supported when Change Tracking is enabled." gets returned when using these query options in the Web API request.

<a name="BKMK_retrieve"></a>   
## Retrieve changes for an entity using the Organization Service
 When change tracking is enabled for an entity, you can use the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest> message to retrieve the changes for that entity. The first time this message is used it returns all records for the entity and that data can be used to populate the external storage. The message also returns a version number that will be sent back with the next use of the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest> message so that only data for those changes that occurred since that version will be returned.  
  
 You should be aware of the following constraints when retrieving changes for an entity:  
  
- Only one entity will be tracked in retrieve changes. If retrieve changes is executed with no version / or token, the server will treat it as the system minimum version, returning all of the records as new. Deleted objects won’t be returned.  
  
- Changes will be returned if the last token is within a default value of 90 days. If it is more than 90 days, the system will return all the records.  
  
- If a client has a set of changes for an entity, say version 1, a record is created and deleted prior to the next query for changes, they will get the deleted item even if they didn’t have the item to begin with.  
  
- Records are retrieved in the order determined by server side logic. Usually, the end user will always get all new or updated records first (sorted by version number) followed by deleted records.  If there are 3000 records created or updated and 2000 records deleted, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] returns a collection of 5000 records, which have the first 3000 entries comprised of new or updated records and the last 2000 entries for deleted records.  
  
- If the new or updated item collection is greater than 5000, the user can page through the collection.  
  
<a name="BKMK_SampleCode"></a>   
## Sample code  
 The following code snippet shows how the `RetrieveEntityChangesRequest` message is used to retrieve the changes for an entity. For the complete sample, see [Synchronize data with external systems using change tracking](http://go.microsoft.com/fwlink/p/?LinkId=533957).  
  
 [!code-csharp[ChangeTrackingSample#ChangeTrackingSample1](../snippets/csharp/CRMV8/changetrackingsample/cs/changetrackingsample1.cs#changetrackingsample1)]  
  
### See also  
 [Define alternate keys for an entity](define-alternate-keys-entity.md)   
 [Using alternate keys](use-alternate-key-create-record.md)   
 [Update Dynamics 365 with external data using Upsert](use-upsert-insert-update-record.md)
