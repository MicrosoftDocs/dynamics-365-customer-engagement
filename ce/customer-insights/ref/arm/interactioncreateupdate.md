---
title: Create or Update Interaction Type (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Creates or updates an Interaction type.
keywords: Customer Insights; ARM API; Interaction; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/08/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f392000a
---

Create or Update Interaction Type (ARM)
======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Either creates a new Interaction type or updates the type if it already exists. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/interactions/<interactionName>?api-version=2017-04-26`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|interactionName|Yes|Name of the Interaction to update/create|
| | | |


### Request Body  
 A JSON object describing a [Interaction](../types/interaction.md) type, for example:

```{json}
{
    "idPropertyNames": ["TestInteractionType6358"],
    "primaryParticipantProfilePropertyName": "profile1",
    "apiEntitySetName": "TestInteractionType6358",
    "fields": [{
        "fieldName": "TestInteractionType6358",
        "fieldType": "Edm.String",
        "isArray": false,
        "isRequired": true
    },
    {
        "fieldName": "profile1",
        "fieldType": "Edm.String"
    }],
    "smallImage": "\\\\Images\\\\smallImage",
    "largeImage": "\\\\Images\\\\LargeImage"
}
```

## Response  
 The response includes an HTTP status code and a set of response headers. Upon success, the body will contain information about the newly created interaction in the following form:

```{json}
{ 
    "id": <interactionUrl>, 
    "name": <interactionName>, 
    "type": "Microsoft.CustomerInsights/hubs/interactions", 
    "properties": { <interactionProperties> }
}
```

### Status Code  

* 200 (OK) - if the update request completed successfully.  
* 202 (Accepted) - if the request was accepted.  

Type provisioning is typically a long running operation. The initial request will come back with HTTP Accepted (202) with a location header to GET the 
status of the operation. The properties in the response body will have a field called *provisioningState*. Eventually performing a GET for the profile will 
return a response where *provisioningState* is set to Succeeded, indicating success. 

