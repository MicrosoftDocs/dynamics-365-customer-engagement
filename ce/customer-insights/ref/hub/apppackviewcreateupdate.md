---
title: Create or Update App View (Hub)
description: Creates a new or updates an existing Application View.
keywords: Customer Insights; Hub API; View; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 77986c28-da82-42e6-86d4-fcc8f3920011
---

Create or Update App View (Hub)
===============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]


Creates a new or updates an existing App [View](../types/view.md) type for a Customer Insights Hub.  


## Request  
 The request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/views/<viewName>?api-version=2017-04-26&userId=<userId>`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|hub-endpoint|Yes|The base URL for your Customer Insights Hub|
|viewName|Yes|Name of the app view to be created or updated|
|userId|No|The ID of the user utilizing the view|
| | | |
 

### Request Body  
A JSON object describing a App View in the form:  
  
```{json}  
{
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/views/<viewName>',
     'name':'<hubName>/<viewName>,
     'type':'Microsoft.CustomerInsights/hubs/views',
     'properties' : <View-Definition>
}

```  
Where the *properties* property contains a [View](../types/view.md) definition that optionally repeats the view name. 

  
## Response  
 The response includes an HTTP status code and a standard set of response headers.  
  
### Status Code  
  
-   200 (OK) - the update request completed successfully.  
  
-   201 (Created) - the create request completed successfully.  

-   400 (BadRequest) - paramter or view definition is invalid JSON.

-   401 (Unauthorized) - the sender does not have write access to this resource. 

-  500 (InternalServerError) - Error encountered writing to metadata database.

