---
title: Create or Update Data Connector (Hub)
description: Creates a new or updates an existing Data Connector.
keywords: Customer Insights; Hub API; Data Connector; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920005
---

Create or Update Data Connector (Hub)
====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [Connector](../types/connector.md) used by a Customer Insights Hub.  

## Request  
 The create/update Connector request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/connectors/<connectorName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub.| 
|connectorName|Yes|The name of the connector to create or update.|  
| | | |
 

### Request Body  
A JSON object describing the Connector metadata, in the form:  
  
```{json}  
{
     "ConnectorName":"<Connector Name>",
     "ConnectorType":"<Connector Type, i.e. AzureBlob, Crm,  etc.>",
     "DisplayName":"Connector DisplayName",
     "Description":"Connector Description",
     "ConnectorProperties": "<Connector-specific properties>"
}
```  
Where [ConnectorProperties](../types/connector.md) is JSON metadata object specific to the connector type.  For example, the ConnectorProperties for a Azure Blob 
Connector would have the form:
```{json}  
{
    "connectionKeyVaultUrl": <Keyvault-secret-URL-for-blob-connection-string>
}
```  

<br/>

## Response  
 The response includes an HTTP status code and a standard set of response headers.  
  
### Status Code  
  
-   200 (OK) - if the update request completed successfully.  
  
-   201 (Created) - if the create request completed successfully.  
  
-   401 (Unauthorized) - if the sender does not have write access to this resource. 


