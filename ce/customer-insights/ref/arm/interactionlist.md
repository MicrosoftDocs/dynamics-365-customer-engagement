---
title: List Hub Interaction Types (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Lists the Interaction type definitions for a Hub.
keywords: Customer Insights; ARM API; Interaction; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-42e6-86d4-fcc8f392000e
---

List Hub Interaction Types (ARM)
==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Interaction](../types/interaction.md) type definitions for the specified Hub.

## Request  
 The Interactions request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/interactions?api-version=2017-04-26&locale=<locale-code>`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|hubName|Yes|Name of your Customer Insights Hub|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

A collection of [Interaction](../types/interaction.md) type definitions.

```{json}  
{
   'value':'[
   {
       'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/interactions/<interactionName>'
       'name':'<hubName>/<interactionName>,
       'type':'Microsoft.CustomerInsights/hubs/interactions',
       'properties' : <InteractionType>
    },
    {
       'id':'/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/interactions/<interactionName>'
       'name':'<hubName>/<interactionName>,
       'type':'Microsoft.CustomerInsights/hubs/interactions',
       'properties' : <InteractionType>
    } ]',
   'nextLink':'<nextLinkUrl>'
}

```  
