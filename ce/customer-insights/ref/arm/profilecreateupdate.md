---
title: Create or Update Profile Type (ARM)
description: Creates a new or updates an existing Profile.
keywords: Customer Insights; ARM API; Profile; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/08/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920014
---

Create or Update Profile Type (ARM)
===================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Either creates a new [Profile](../types/profile.md) type or updates the type if it already exists. 

## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/profiles/<profileName>?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|profileName|Yes|name of the profile to update/create|
| | | |


### Request Body  
 A JSON object describing a [Profile](../types/profile.md) type, for example:

```{json}
{
    "schemaItemTypeLink": "SchemaItemTypeLink",
    "smallImage": "\\\\Images\\\\smallImage.jpg",
    "largeImage": "\\\\Images\\\\LargeImage.jpg",
    "strongIds": [{
        "keyPropertyNames": ["Id",
        "SavingAccountBalance"],
        "strongIdName": "Id"
    },
    {
        "keyPropertyNames": ["ProfileId",
        "LastName"],
        "strongIdName": "ProfileId"
    }],
    "apiEntitySetName": "TestProfileType396",
    "fields": [{
        "fieldName": "Id",
        "fieldType": "Edm.String",
        "isArray": false,
        "isRequired": true
    },
    {
        "fieldName": "ProfileId",
        "fieldType": "Edm.String",
        "isArray": false,
        "isRequired": true
    },
    {
        "fieldName": "LastName",
        "fieldType": "Edm.String",
        "isArray": false,
        "isRequired": true
    },
    {
        "fieldName": "TestProfileType396",
        "fieldType": "Edm.String",
        "isArray": false,
        "isRequired": true
    },
    {
        "fieldName": "SavingAccountBalance",
        "fieldType": "Edm.Int32",
        "isArray": false,
        "isRequired": true
    }]
}
```

## Response  
 The response includes an HTTP status code and a set of response headers. Upon success, the body will contain information about the newly created profile in the following form:

```{json}
{ 
    "id": <profileUrl>, 
    "name": <profileName>, 
    "type": "Microsoft.CustomerInsights/hubs/profiles", 
    "properties": { <profileProperties> }
}
```

### Status Code  
  
* 200 (OK) - the update request completed successfully.  
* 202 (Accepted) - the create request was accepted.  

Type provisioning is typically a long running operation. The initial request will come back with HTTP Accepted (202) with a location header to GET the 
status of the operation. The properties in the response body will have a field called *provisioningState*. Eventually performing a GET for the profile will 
return a response where *provisioningState* is set to Succeeded, indicating success. 


