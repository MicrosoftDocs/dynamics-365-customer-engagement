---
title: Create or Update Relationship (ARM)
description: Creates a new or updates an existing relationship.
keywords: Customer Insights; ARM API; relationship; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/08/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9c86c28-da82-42e6-86d4-fc18f392050
---

Create or Update Relationship (ARM)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Relationship](../types/relationship.md) in the specified Customer Insights Hub.  
  
## Request  
 The request is constructed as follows:  
  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/relationships/<relationshipName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|relationshipName|Yes|The name of the relationship to create or update|  
| | | |
 

### Request Body  
The body must supply the required properties of the [Relationship](../types/relationship.md) type, for example:
  
```{json}  
{
    "cardinality": "OneToOne",
    "displayName": {
    "en-us": "Relationship DisplayName"
    },
    "description": {
    	"en-us": "Relationship Description"
    },
    "fields": [<customProperties>],
    "profileType": "CurrentProfile",
    "relatedProfileType": "AssociatedProfile"
}
```

<br>

## Response  
 The response includes an HTTP status code and a standard set of response headers. Upon success, the body will contain information about the newly created relationship in the following form:

```{json}
{ 
    "id": <relationshipUrl>, 
    "name": <relationshipName>, 
    "type": "Microsoft.CustomerInsights/hubs/relationships",
    "properties": { <relationshipProperties> }
}
```

### Status Code  
  
-  200 (OK) - the update request completed successfully.
-  202 (Accepted) - the request was accepted and is pending.
-  400 (Bad Request) - Validation fails or invalid JSON.
  
