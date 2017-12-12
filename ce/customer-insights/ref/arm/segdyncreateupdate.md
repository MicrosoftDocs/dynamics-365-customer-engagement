---
title: Create or Update a Dynamic Segment Type (ARM)
description: Creates or updates a dynamic segment type.
keywords: Customer Insights; ARM API; dynamic segment; create; update
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/03/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac718-9758-43e8-b5f7-b8c27b544233
---

Create or Update a Dynamic Segment Type (ARM)
===========================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Creates a new or updates an existing dynamic [Segment](../types/segment.md) type. 

## Request 
 The request is constructed as follows: 
  
|**HTTP Verb**|**Request URI**| 
|-------------|---------------| 
|PUT|`<https://management.azure.com/subscriptions/<subId>/resourceGroups/<rgName>/providers/Microsoft.CustomerInsights/hubs/<hubName>/segments/dynamic/<segmentName>?api-version=2017-04-26`|
| | | 
  
### URI Parameters 
  
|**URI Parameter**|**Required**|**Description**| 
| --------------- | ---------- | ------------- | 
|subId|Yes|The Azure subscription ID|
|rgName|Yes|The resource group name|  
|hubName|Yes|Name of your Customer Insights Hub|
|segmentName|Yes|The name of the dynamic segment type to create or update|  
| | | |

### Request Body
The request body may only contain the following subset of [Segment](../types/segment.md) properties that can be directly modified. 
  
  |**Property**|**JSON Type**|**Description**|
| ---------- | ----------- | ------------- |
| description | string | Description of segment or its membership |
| targetProfileTypeName | string | Name of the profile type the query evaluates to |
| query | string | Query used to define dynamic membership; see [Segmentation Query Language](../segquerylang.md) |
| segmentRefreshRateIntervalMinutes | integer | Number of minutes between re-evaluations of query |
| activationStatus | string | **Active** if segment evaluation is activated, otherwise **Disabled** |
| tags | array | List of user-defined segment tags |
| | | |

#### Example

```{json}  
{ 
   "description":"Test salesperson segment",
   "targetProfileTypeName":"Salesperson",
   "query":"PROFILE(Salesperson).FILTER(FirstName=='Bob')",
   "segmentRefreshRateIntervalMinutes":30,
   "activationStatus":"Active",
   "tags":["summerCampaign", "dynamic"]
}
```  

## Response  
 The response includes an HTTP status code and a standard set of response headers. If successful (202), the body will contain a [Segment](../types/segment.md) definition for the newly created or modified segment, for example:

 ```{json}  
{
   "id":"/subscriptions/TESTID/resourceGroups/TESTRG/providers/Microsoft.CustomerInsights/hubs/TESTHUB/segments/TestSegment"
   "name":"TESTHUB/TestSegment", 
   "type":"Microsoft.CustomerInsights/hubs/segments", 
   "properties":
    {  
       "name":"SalesTestSegment2", 
       "segmentDefinition":{  
          "filterQuery":""PROFILE(Salesperson).FILTER(FirstName=='Bob')", 
          "description":"Test salesperson segment", 
          "targetProfileTypeName":"Salesperson", 
          "tags":  ["summerCampaign", "dynamic"] 
       }, 
       "segmentState":{ "evaluationDuration":"00:00:00", "segmentEvaluationState":"PendingEvaluation", "segmentSize":0 }, 
       "segmentType":"Dynamic", 
       "changed":"2017-03-09T09:09:37.8718171+00:00", 
       "created":"2017-03-08T09:09:37.8718171+00:00", 
       "provisioningState":"Provisioning" 
    }
}
```

### Status Code  

* 200 (OK) - Request completed successfully.
* 202 (Accepted) - Request is being processed.
* 400 (Bad request) - Request contains invalid property names or values.
* 409 (Conflict) - Segment is in an intermediate provisioning state
