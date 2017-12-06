---
title: Get a Segment Type (ARM)
description: Gets the specified segment entity type.
keywords: Customer Insights; ARM API; segment; get
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/18/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43a8-b5f6-b8c27bee1231
---

Get a Segment Type (ARM)
========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Gets the specified [Segment](../types/segment.md) type definition. 


## Request 
The request is constructed as follows:

|**HTTP Verb**|**Request URI**|
|-------------|---------------|
|GET|`<https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/segments/<segmentName>?api-version=2017-04-26&&locale=<locale-code>`|
| | |

### URI Parameters

|**URI Parameter**|**Required**|**Description**|
| --------------- | ---------- | ------------- |
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|segmentName|Yes|The name of the Segment definition to retrieve|
|locale-code|No|The localization code to apply to any returned properties. If no locale code is specified, then 'en-us' is used as default.|
| | | |

## Response
 The response includes a standard HTTP status code, a set of standard response headers, and a response body.

### Response Body

Upon success, contains context information and the requested [Segment](../types/segment.md) type definition, for example:  

```{json}
{ 
   "id":"/subscriptions/TESTID/resourceGroups/TESTRG/providers/Microsoft.CustomerInsights/hubs/TESTHUB/segments/TestSegment"    
   "name":"TESTHUB/TestSegment", 
   "type":"Microsoft.CustomerInsights/hubs/segments", 
   "properties":  
   { 
         "segmentDefinition":{ 
            "filterQuery":"Query", 
            "memberIds":[ "1", "2", "3" ], 
            "description":"Description", 
            "targetProfileTypeName":"Customer", 
            "tags": [] 
         }, 
         "segmentState":{ "segmentSize":0 }, 
         "name":"TestSegmentName", 
         "segmentType":"Static", 
         "changed":"2017-03-07T08:55:15.9314075Z", 
         "created":"2017-03-06T08:55:15.9314075Z", 
         "provisioningState":"Failed" 
    } 
} 
```

### Status Code 
  
* 200 (OK) - Segment was returned successfully.
* 403 (Forbidden) - Operation was blocked, usually because the Segmentation feature flag is disabled.
* 404 (Not Found) - Specified segment name was not found.
