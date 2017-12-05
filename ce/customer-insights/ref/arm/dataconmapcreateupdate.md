---
title: Create or Update Data Connector Mapping (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Creates a new or updates an existing Connector Mapping.
keywords: Customer Insights; ARM API; ConnectorMapping; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/08/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920010
---

Create or Update Data Connector Mapping (ARM)
============================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Connector Mapping](../types/connectormapping.md).  

## Request  
 The request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/connectors/<connectorName>/mappings/<mappingName>?api-version=2017-04-26`|  
| | |
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|mappingName|Yes|The name of the connector mapping to create or update|  
| | | |


### Request Body  
A JSON object describing a [ConnectorMapping](../types/connectormapping.md) mapping, for example:  
  
```{json}  
  {
    "entityType": "Interaction",
    "entityTypeName": "TestInteractionType2967",
    "displayName": "testMapping12491",
    "description": "Test mapping",
    "mappingProperties": {
        "folderPath": "https://www.contoso.com/files",
        "fileFilter": "unknown",
        "hasHeader": false,
        "errorManagement": {
            "errorManagementType": "StopImport",
            "errorLimit": 10
        },
        "format": {
            "formatType": "TextFormat",
            "columnDelimiter": "|"
        },
        "availability": {
            "frequency": "Hour",
            "interval": 5
        },
        "structure": [{
            "propertyName": "prop1",
            "columnName": "col1",
            "isEncrypted": false
        },
        {
            "propertyName": "prop2",
            "columnName": "col2",
            "isEncrypted": true
        }],
        "completeOperation": {
        "completionOperationType": "DeleteFile",
        "destinationFolder": "Path1"
        }  
    }
}
```  

## Response  
 The response includes an HTTP status code and a standard set of response headers. Upon success, the body will contain information about the newly created mapping in the following form:

```{json}
{ 
    "id": <mappingUrl>, 
    "name": <mappingName>, 
    "type": "Microsoft.CustomerInsights/hubs/mappings", 
    "properties": { <mappingProperties> }
}
```
 
  
### Status Code  
  
- 200 (OK) - the update request completed successfully.  
- 201 (Created) - the create request completed successfully.  
- 401 (Unauthorized) - the sender does not have write access to this resource. 

