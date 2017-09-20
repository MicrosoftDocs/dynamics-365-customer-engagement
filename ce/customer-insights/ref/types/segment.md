---
title: Segment Type Definition
description: A Segment defines a group of profiles with similar properties.
keywords: Customer Insights; type; segment
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/01/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2d28b8d4-c768-49b2-9602-8f5b6133efa3
---

lSegment Type Definition
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A segment describes a set of related Profiles. Customer Insights supports three types of segments: static and dynamic. A static segment contains specified profiles, commonly added manually by users. A dynamic segment is defined by a _segmentation clause_, which is a query statement that describes the desired membership. For more information, see [Segmentation Management APIs (Hub)](..\hub\segmngnt.md).

## Properties

### Segment properties

|**Property**|**JSON Type**|**Description**|
| ---------- | ----------- | ------------- |
| name | string | Unique name of the segment |
| segmentType | string | Type of segment: ["Static" \| "Dynamic"] |
| changed | DateTime | Last time the static list membership or definition of the dynamic segment was modified |
| created | DateTime | Initial creation date |
| provisioningState | string  | Current provisioning status: ["Provisioning" \| "Provisioned" \| "Failed" \| "Deleting"] |
| segmentDefinition | SegmentDefinition | Definition of the segment's membership (see below) |
| segmentState | SegmentState | Current membership evaluation state (see below) |
| | | |

<!-- What are all the allowed values for the enumerations segmentType, provisioningState, etc.  Also, what does the segmentDefinition look like for a static or compound segment? -->  

### SegmentDefinition properties

|**Property**|**JSON Type**|**Description**|
| ---------- | ----------- | ------------- |
| query | string | Query used to define dynamic membership; see [Segmentation Query Language](../segquerylang.md) (dynamic segments only) |
| segmentRefreshRateIntervalMinutes | integer | Number of minutes between re-evaluations of query (dynamic segments only) |
| activationStatus | string | **Active** if segment evaluation is activated, otherwise **Disabled**  (dynamic segments only) |
| memberIds | array | List of member profiles, by profile ID (static segments only) |
| filterQuery | string | Query used to limit member profiles before listing them in memberIds (static segments only) |
| description | string  | Optional description of segment or its membership |
| targetProfileTypeName | string  | Name of the profile type the query evaluates to |
| tags | array | List of user-defined segment tags |
| | | |

### SegmentState properties

|**Property**|**JSON Type**|**Description**|
| ---------- | ----------- | ------------- |
| segmentSize | integer | Number of members (from the last evaluation) |
| evaluationDuration | TimeOffset | Time required for the last evaluation processing (dynamic segments only) |
| segmentEvaluationState | string | Evaluation processing state: ["Success" \| "PendingEvaluation" \| "Failure"] \(dynamic segments only) |
| lastEvaluationTime | dateTime | Date and time of last successful evaluation (dynamic segments only) |
| evaluationErrorMessage | string | Errors message returned when evaluation fails (dynamic segments only) |
| consecutiveFailCounter | integer | Number for consecutive segment evaluation failures (dynamic segments only) |
| | | |

## JSON Example
The following is an example of a dynamic segment type definition.

```{json}
{ 
   "name":"TestSalesSegment2",
   "segmentType":"Dynamic",
   "changed":"2017-03-08T08:55:15.9314075Z",
   "created":"2017-03-07T08:55:15.9314075Z",
   "provisioningState":"Provisioned",
   "segmentDefinition":{
      "query":"PROFILE(Salesperson).FILTER(FirstName!='Sally')",
      "segmentRefreshRateIntervalMinutes":120,
      "isActive":true,
      "description":"Test sales profile segment #2",
      "targetProfileTypeName":"Salesperson",
      "tags":[]
   },
   "segmentState":{ 
      "evaluationDuration":"00:00:35", 
      "segmentEvaluationState":"Success", 
      "segmentSize":7 
   }
}
```
