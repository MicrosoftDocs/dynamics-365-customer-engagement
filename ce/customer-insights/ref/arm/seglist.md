---
title: List Segment Types (ARM)
description: Lists all the segment entity types.
keywords: Customer Insights; ARM API; segment; list
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 07/05/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43a8-b5f6-b8c27bee1233
---

List Segment Types (ARM)
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Lists all the static and dynamic [Segment](../types/segment.md) types for a hub. 


## Request  
 The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/segments?api-version=2017-04-26&locale=<locale-code>`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

Optionally, pagination is supported by the **top** and **skip** query parameters, for example: 

&emsp;	`GET  . . .<hubName>/segments?$top=2&$skip=10`

## Response  
The response includes a standard HTTP status code, a set of standard response headers, and a response body.

#### Response Body  
Upon success, a collection of [Segment](../types/segment.md) type definitions, for example:

```{json}  
{ 
   "value":[ 
      { 
         "segmentDefinition":{ 
            "query":"PROFILE(contact).FILTER(FirstName!='Sally')", 
            "segmentRefreshRateIntervalMinutes":3, 
            "activationStatus":"Active", 
            "description":"Test Descrtion", 
            "targetProfileTypeName":"contact", 
            "tags": [] 
         }, 
         "segmentState":{ "evaluationDuration":"00:00:35", "segmentEvaluationState":"Success", "segmentSize":7 }, 
         "name":"TestSegmentName", 
         "segmentType":"Dynamic", 
         "changed":"2017-03-08T08:55:15.9314075Z", 
         "created":"2017-03-07T08:55:15.9314075Z", 
         "provisioningState":"Provisioned" 
      }, 
      { 
         "segmentDefinition":{ 
            "filterQuery":"Query", 
            "memberIds":[ "1", "2", "3" ], 
            "description":"Description", 
            "targetProfileTypeName":"Customer", 
            "tags": [] 
         }, 
         "segmentState":{ "segmentSize":0 }, 
         "name":"TestSegmentName2", 
         "segmentType":"Static", 
         "changed":"2017-03-07T08:55:15.9314075Z", 
         "created":"2017-03-06T08:55:15.9314075Z", 
         "provisioningState":"Failed" 
      } 
   ] 
   "nextLink":"<nextPageURL>", 
}  
```

### Status Code 
  
* 200 (OK) - Segment was returned successfully.
* 403 (Forbidden) - Operation was blocked, often because the Segmentation feature flag is disabled.
