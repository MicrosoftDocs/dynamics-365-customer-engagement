---
title: Create or Update a Static Segment Type (ARM)
description: Creates or updates a static segment entity type.
keywords: Customer Insights; ARM API; static segment; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/03/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27b544232
---

Create or Update a Static Segment Type (ARM)
===========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing static [Segment](../types/segment.md) type. 
  
## Request 
 The request is constructed as follows: 
  
|**HTTP Verb**|**Request URI**| 
|-------------|---------------| 
|PUT|`<https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/segments/static/<segmentName>?api-version=2017-04-26`|
| | | 
  
### URI Parameters 
  
|**URI Parameter**|**Required**|**Description**| 
| --------------- | ---------- | ------------- | 
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|segmentName|Yes|The name of the static segment type to create or update|  
| | | |

### Request Body  
The request body may only contain the following subset of [Segment](../types/segment.md) properties that can be directly modified. 
  
  |**Property**|**JSON Type**|**Description**|
| ---------- | ----------- | ------------- |
| description | string | Description of segment or its membership |
| targetProfileTypeName | string | Name of the profile type the query evaluates to |
| filterQuery | string | Query used to initially define static membership; see [Segmentation Query Language](../segquerylang.md) |
| memberIds | array | List of profiles, by ID, to include as members  |
| tags | array | List of user-defined segment tags (user-defined) | 
| | | |

#### Example

```{json}  
{ 
   "description":"Test salesperson segment",
   "targetProfileTypeName":"Salesperson",
   "filterQuery":"PROFILE(Salesperson).FILTER(FirstName=='Bob')",
   "memberIds":["1","2","3"],
   "tags":["summerCampaign", "static"]
}
```  

## Response  
 The response includes an HTTP status code and a standard set of response headers. If successful, the body will contain a [Segment](../types/segment.md) definition for the newly created or modified segment, for example:

```{json}  
{
   "id":"/subscriptions/TESTID/resourceGroups/TESTRG/providers/Microsoft.CustomerInsights/hubs/TESTHUB/segments/TestSegment"
   "name":"TESTHUB/TestSegment", 
   "type":"Microsoft.CustomerInsights/hubs/segments", 
   "properties":
   {
       "name":"SalesTestSegment1", 
       "segmentDefinition":{  
          "filterQuery":""PROFILE(Salesperson).FILTER(FirstName=='Bob')", 
          "memberIds":[ "1", "2", "3" ], 
          "description":"Test salesperson segment", 
          "targetProfileTypeName":"Salesperson", 
          "tags":  ["summerCampaign", "static"] 
       }, 
       "segmentState":{ "segmentSize":2 }, 
       "segmentType":"Static", 
       "changed":"2017-03-09T09:09:37.8718171+00:00", 
       "created":"2017-03-08T09:09:37.8718171+00:00", 
       "provisioningState":"Provisioning"
    }
} 
```

### Status Code  
  
* 200 (OK) - Request completed successfully 
* 202 (Accepted) - Request accepted and is being processed 
* 400 (Bad request) - Request contains invalid property names or values
* 403 (Forbidden) - Requester does not have permission to perform this operation
* 409 (Conflict) - Segment is in an intermediate provisioning state
