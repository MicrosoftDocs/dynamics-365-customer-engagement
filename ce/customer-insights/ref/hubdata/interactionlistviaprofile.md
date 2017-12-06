---
title: List Interactions associated with a Profile Type (Hub Data)
description: Lists all Interaction instances that form an association with the specified Profile type.
keywords: Customer Insights; Hub Data API; Interaction instance; list 
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/14/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 6ccb25f4-1078-4980-96d6-7b8aec0f0210
---

List Interactions associated with a Profile Type (Hub Data)
=======================================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists all [Interaction](../types/interaction.md) instances that form an association to or from the specified [Profile](../types/profile.md) type. 


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<hub-endpoint>/data/Contacts('<contactid>')/Interactions?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.|
|contactId|Yes|The ID of the custom entity type|

Complex filter expressions can be applied to this operation as demonstrated in the following request.

```{http}  
GET <hub-endpoint>/data/Contacts('contactId')/Interactions?api-version=2017-04-26&$filter=Timestamp gt 
      cast('2013-06-26T03:30:00.000Z', Edm.DateTimeOffset) and 
      Timestamp lt cast('2014-06-26T03:30:00.000Z', Edm.DateTimeOffset)
```    

#### Predictive Matching

Profile-to-interaction matching enables the retrieval of matched interactions through the use of the **includePredictiveMatchResults** flag.  Furthermore, results can be narrowed only to predictive matched interactions through the use of the appropriate filter, for example:

&emsp; `GET <hub-endpoint>/data/contacts('<contactId>')/interactions?includePredictiveMatchResults=true&$filter='type=conflation'&api-version=2017-04-26`


<br/>

## Response  
 The response includes an HTTP status code, a response body and a set of response headers.  

Results are returned as a set of pages. The existence of the server-side paging token ([OData $skiptoken](https://msdn.microsoft.com/en-us/library/dd942121.aspx)) enables the 
retrieval of the next page of results. The results are ordered by modification timestamp, with the most recently changed entities appearing first.  


### Response Body  

A collection of custom [Interaction](../types/interaction.md) instances. 


### Status Code  
  
-   200 (OK) - the request succeeded.  
  
