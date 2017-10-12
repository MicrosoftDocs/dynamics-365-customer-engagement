---
title: API Requests and Responses (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: 
keywords: Customer Insights; request; response; locales; reserved words; error code; version; OData
author: Milar1
ms.author: v-larmic
manager: jdaly
ms.date: 07/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 4ec09442-5d10-4ed7-b367-32543271683c
---

API Requests and Responses
==========================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

All of the Customer Insights APIs conform to [REST](https://en.wikipedia.org/wiki/Representational_state_transfer) conventions. Each entity type, such as a Customer Insights [Hub](./types/hub.md) is a resource exposed as a REST endpoint.  Each endpoint exposes a set of CRUD operations, often a subset of the standard CRUD operations listed in the following table. The "Idemp?" column indicates whether the operation is idempotent, i.e. whether making multiple identical requests yields the same result. 

|**Operation**|**HTTP Verb**|**Type/Idem?**|**Description**|
| ----------- | ---------- | -------------- | ------------- |
| Get (Retrieve)| GET | Read/True |Returns the single, specified instance|
| List | GET | Read/True | Returns all the instances of the specified entity type|
| Create/Update (Upsert) | PUT | Write/True | Creates a new or updates an existing instance|
| Generate/Modify | POST | Write/False | Generate information or run a command|
| Update | PATCH | Write/False | [Partially] updates an existing instance|
| Delete | DELETE | Write/True |Deletes an existing instance |
||||

Because Customer Insight is an Azure-based REST service, its [Azure Resource Manager (ARM) APIs](./armapiref.md) follow the common requirements and conventions documented in the topic [Azure REST API Reference](https://docs.microsoft.com/rest/api/). Note that some types constrain the possible operations; for example in the current release, [Interaction](./types/interaction.md) and [Profile](./types/profile.md) instances cannot be deleted, images can only be uploaded, and so on.

The general form of the request depends upon the API group being used, either [Azure Resource Manager (ARM) APIs](./armapiref.md) or [Customer Insights Hub APIs](./hubapiref.md). Although the base portion differs between these two APIs, there is a much commonality in the exposed resources and their respective operations. For a comparison of these APIs, see the [API Quick Reference](./apiquickref.md). 

## API Versioning
The query string `api-version` specifies the desired version of the Customer Insights API to be invoked. The recognized dates correspond to releases as follows:

|**Version**|**Description**|  
| --------------- | ---------- | 
| "2016-01-01" | Initial pre-release |
| "2017-04-26" | Second pre-release |
| | | 

With each major release of Customer Insights, the corresponding API version will change to reflect its version.  This online reference documentation only covers the most recent version. 


## Returned Collections

List operations, for example [List Hubs (ARM)](./arm/hublist.md), typically return linked collections of the form:

```{json}
{
    "value": [<array-of-entity-instances>]
    "nextLink": "<string-URL>" 
}
```

Where the optional **nextLink** property points to the next "page" of results. (This property will be missing if there are no additional results.) Returning "chunked" results is a compromise between returning a single value at a time and returning a potentially large resultset. By default, a maximum of 30 instances are returned by each response, although this can be limited through the use of OData **$top** query parameter, for example:

 &emsp; `https://<hub-endpoint>/data/relationships?$top=6`


## OData APIs and Metadata Requests
All of the [Customer Insights Hub APIs](./hubapiref.md) conform to the [OData](http://www.odata.org/) standard.  One result of this adherence is that each solution exposes its metadata endpoint, which is accessed by a request of the form:

&emsp; `GET <hub-endpoint>/data/$metadata`

For example: 

&emsp; `https://dcisdktest.api.azurecustomerinsights.com/data/$metadata`


## Return Codes

As expected for a REST service, the Customer Insights APIs return standard [HTTP status codes](https://msdn.microsoft.com/library/windows/desktop/aa384325.aspx). The documentation for each operation only lists the most common or informative ones.


## Reserved Words

For each of the management APIs, there is a number of reserved keywords that are disallowed when specifying the names of various custom entities and their properties.  However it is recommended that the following reserved words not be used for any purpose other than their intended keyword usage.

|   |   |   |   |   |
| --- | --- | --- | --- | --- |
|Active|AgentProfileId|CalculationTime|CountValue|InteractionId|
|Key|KPITime|LastModified|LastModifiedUtcDateTimeTicks|MaxValue|
|MinValue|ProfileId|reserved_system_time|SumValue|UtcDateTime|
|Value|   |   |   |   |
|   |   |   |   |   |

It is also recommended that you do _not_ use standard type names, for example "KPI", as variable names.


<!-- TODO: Do all the OData entities/APIs support standard OData operations (filtering, grouping, sorting, etc.)?  If so this should be a separate topic in/under this one, and remove the special operations like "Get Filtered Profile Instances (Hub)" -->
