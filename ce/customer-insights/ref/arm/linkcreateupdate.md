---
title: Create or Update Link (ARM)
description: Creates a new or updates an existing SAS Policy.
keywords: Customer Insights; ARM API; Link; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/08/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: a1986c28-da82-42e6-86d4-fcc8f3920002
---

Create or Update Link (ARM)
============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Link](../types/link.md) in a Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/links/<linkName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|linkName|Yes|The name of the link to create or update.|  
| | | |
 

### Request Body  
A JSON object describing a [Link](../types/link.md), for example:   
  
```{json}  
{
    "linkName": "linkTest4806",
    "sourceInteractionType": "testInteraction1949",
    "targetProfileType": "testProfile1446",
    "displayName": {
        "en-us": "Link DisplayName"
    },
    "description": {
        "en-us": "Link Description"
    },
    "mappings": [{
        "interactionTypePropertyName": "testInteraction1949",
        "profileTypePropertyName": "testProfile1446",
        "isProfileTypeId": true,
        "linkType": "UpdateAlways"
    }],
    "participantPropertyReferences": [{
        "interactionPropertyName": "testInteraction1949",
        "profilePropertyName": "ProfileId"
    }]
}
```


## Response  
 The response includes an HTTP status code and a standard set of response headers. Upon success, the body will contain information about the newly created link in the following form:

```{json}
{ 
    "id": <linkUrl>, 
    "name": <linkName>, 
    "type": "Microsoft.CustomerInsights/hubs/links", 
    "properties": { <linkProperties> }
}
```
  
### Status Code  
  
* 200 (OK) - the update request completed successfully. The *provisioningState* property in the response body is set to 'Succeeded' when the link provisioning finishes.
* 201 (Created) - if the create request completed successfully.  
* 400 (Bad Request) – link definition validation failed.
