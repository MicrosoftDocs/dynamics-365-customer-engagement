---
title: Create or Update Relationship Link (ARM)
description: Creates a new or updates an existing relationship link.
keywords: Customer Insights; ARM API; relationship link; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/09/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-bc18f393140
---

Create or Update Relationship Link (ARM)
=======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [RelationshipLink](../types/relationshiplink.md) in the specified Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationshipLinks/<relationshipLinkName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|relationshipLinkName|Yes|The name of the relationship link to create or update|  
| | | |


### Request Body  
The body must supply the required properties of the [RelationshipLink](../types/relationshiplink.md) type, for example:
  
```{json}  
{
    "description": {
    	"en-us": "Link Description"
    },
    "displayName": {
    	"en-us": "Link DisplayName"
    },
    "interactionType": "testInteraction4332",
    "linkName": "testlink002",
    "profilePropertyReferences": [{
        "interactionPropertyName": "profile1",
        "profilePropertyName": "ProfileId"
    }],
    "provisioningState": "Provisioning",
    "relatedProfilePropertyReferences": [{
        "interactionPropertyName": "profile1",
        "profilePropertyName": "ProfileId"
    }],
    "relationshipName": "testProfile2326994",
    "tenantId": "sdktesthub"
}
```

<br>

## Response  
 The response includes an HTTP status code and a standard set of response headers. Upon success, the body will contain information about the newly created relationship in the following form:

```{json}
{ 
    "id": <relationshipUrl>, 
    "name": <relationshipName>, 
    "type": "Microsoft.CustomerInsights/hubs/relationshipLinks",
    "properties": { <relationshipLinkProperties> }
}
```

### Status Code  
  
-  200 (OK) - the update request completed successfully.
-  202 (Accepted) - the request was accepted and is pending.
-  400 (Bad Request) - Validation fails or invalid JSON.
  
