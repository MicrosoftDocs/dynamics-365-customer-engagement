---
title: List Hubs (ARM) (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: Lists the hubs in a subscription or resource group.
keywords: Customer Insights; ARM API; Hub; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/02/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: acb6ba5b-6a6b-4aaf-861a-1682364b2786
---

List Hubs (ARM)
================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists the [Hub](../types/hub.md) instances in an Azure [subscription](https://docs.microsoft.com/rest/api/resources/subscriptions) or [resource group](https://docs.microsoft.com/rest/api/resources/resourcegroups).


## Request  
 Hubs can be listed either by the specified Azure subscription or resource group.
 

### List hub instances in a subscription

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/providers/Microsoft.CustomerInsights/hubs?api-version=2017-04-26&locale=<locale-code>`|
| | |

#### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

<br>

### List hub instances in a resource group

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs?api-version=2017-04-26&locale=<locale-code>`|
| | |

#### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|Subscription ID|
|rgName|Yes|Azure region name|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |


## Response  
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  

An array of [Hub](../types/hub.md) instances.

