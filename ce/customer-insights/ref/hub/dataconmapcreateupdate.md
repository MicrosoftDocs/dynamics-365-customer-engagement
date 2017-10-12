---
title: Create or Update Data Connector Mapping (Hub)
description: Creates a new or updates an existing Data Connector.
keywords: Customer Insights; Hub API; Data Connector; create; update
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 11/01/2016
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920011
---

Create or Update Data Connector Mapping (Hub)
==========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing [ConnectorMapping](../types/connectormapping.md).  

## Request  
 The request is constructed as follows:  
  
|**HTTP Verb**|**Request URI**|  
|-------------|---------------|  
|PUT|`<hub-endpoint>/manage/connectors/<connectorName>/mappings/<mappingName>?api-version=2017-04-26`|  
  
### URI Parameters  
  
|**URI Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|Hub-endpoint|Yes|The base URL for your Customer Insights Hub| 
|mappingName|Yes|The name of the connector mapping to create or update|  
| | | |
 

### Request Body  
A [ConnectorMapping](../types/connectormapping.md) type definition.

<br/>

## Response  
 The response includes an HTTP status code and a standard set of response headers.  
  
### Status Code  
  
-   200 (OK) - the update request completed successfully. 
  
-   201 (Created) - the create request completed successfully. 
  
-   401 (Unauthorized) - the sender does not have write access to this resource. 

-   409 (Conflict) - the same connector mapping is in provisioning. 


