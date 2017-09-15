---
title: Create or Update Data Connector (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Creates a new or updates an existing Data Connector.
keywords: Customer Insights; ARM API; Data Connector; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920004
---

Create or Update Data Connector (ARM)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Data Connector](../types/connector.md) used by a Customer Insights Hub.  

## Request  
 The request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/connectors/<connectorName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|connectorName|Yes|The name of the data connector to create or update|  
| | | |
 

### Request Body  
A JSON object describing a [Connector](../types/connector.md), for example:  
  
```{json}  
{
    "connectorType": "AzureBlob",
    "displayName": "testConnector",
    "description": "Test connector",
    "connectorProperties": {
        "connectionKeyVaultUrl": {
            "organizationId": "Contoso",
            "organizationUrl": "https://www.contoso.com/"
        }
    }
}

```  
  
## Response  
 The response includes an HTTP status code and a standard set of response headers. Upon success, the body will contain information about the newly created connector in the following form:

```{json}
{ 
    "id": <connectorUrl>, 
    "name": <connectorName>, 
    "type": "Microsoft.CustomerInsights/hubs/connectors", 
    "properties": { <connectorProperties> }
}
```

### Status Code  
  
- 200 (OK) - if the update request completed successfully.  
- 201 (Created) - if the create request completed successfully.  
- 401 (Unauthorized) - if the sender does not have write access to this resource. 

