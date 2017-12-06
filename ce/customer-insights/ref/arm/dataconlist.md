---
title: List Data Connectors for a Hub (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Lists the Data Connector type definitions for a Hub.
keywords: Customer Insights; ARM API; Data Connectors; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/16/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f3920008
---

List Data Connectors for a Hub (ARM)
=================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Data Connector](../types/connector.md) type definitions for the specified Hub.

## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/connectors?api-version=2017-04-26`|

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of data connector information, including [Connector](../types/connector.md) type definitions, in the following form:

```{json}  
{
   'value':'[
            {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/connectors/<connectorName>'
     'name':'<hubName>/<connectorName>,
     'type':'Microsoft.CustomerInsights/hubs/connectors',
     'properties' : <Connector-Definition>
            },
            {
     'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/connectors/<connectorName>'
     'name':'<hubName>/<connectorName>,
     'type':'Microsoft.CustomerInsights/hubs/connectors',
     'properties' : <Connector-Definition>
            }
            ]',
   'nextLink':'NextLink'
  }
```  

### Status Code  

- 200 (OK) - the policy was retrieved successfully.  
- 401 (Access denied) - not authorized to read resource.
