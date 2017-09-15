---
title: List Data Connector Mappings for a Hub (ARM)
description: Lists the Data Connector type definitions for a Hub.
keywords: Customer Insights; ARM API; Data Connector Mappings; list
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/16/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920028
---

List Data Connector Mappings for a Hub (ARM)
===========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Data Connector Mappings](../types/connectormapping.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/connectors/<connectorName>/mappings?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|connectorName|Yes|Name of the data connector to retrieve the mappings for|


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of data connector mapping information that includes [ConnectorMapping](../types/connectormapping.md) type definitions, in the following form:

```{json}  
{
   'value':[
    {
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/connectors/<connectorName>/mappings/<mappingsName>'
        'name':'<hubName>/<connectorName>/<mappingsName>,
        'type':'Microsoft.CustomerInsights/hubs/connectors/mappings',
        'properties' : ConnectorMappingDefinition
    },
    {
        'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/connectors/<connectorName>/mappings/<mappingsName>'
        'name':'<hubName>/<connectorName>/<mappingsName>,
        'type':'Microsoft.CustomerInsights/hubs/connectors/mappings',
        'properties' : <ConnectorMapping-Definition>
    } ],
   'nextLink':'NextLink'
  }
```  

