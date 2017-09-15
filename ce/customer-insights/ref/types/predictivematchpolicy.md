---
title: Predictive Match Policy Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: A Predictive Match Policy defines the criteria used to find matching profiles or interactions.
keywords: Customer Insights; type; predictive match policy
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/13/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 5c6ac718-9758-43e8-b5f7-08c21bbb1000
---

Predictive Match Policy Type Definition
======================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A Predictive Match Policy is applied to certain hub data retrieval operations to obtain a list of potentially matching entities, of either [Profiles](./profile.md) or [Interactions](./interaction.md). For more information about predictive matching, including the REST operations that enable the creation and management of policies, see [Predictive Matching Policy APIs (Hub)](../hub/predmatchpolmngnt.md).  Customer Insights supports two types of predictive matching (also called _conflation_): Profile-to-Profile and Profile-to-Interaction. Therefore, the primary type is assumed to be "Profile"; the alternate type is either "Profile" or "Interaction", respectively. 

## Properties

Property names appended with asterisks* are required.

### PredictiveMatchPolicy properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|predictiveMatchPolicyName*|string|Match name|
|displayName|map<string, string>|Localized display name|
|description|map<string, string>|Localized description|
|primaryTypeName*|string|Entity type of the primary entity to be matched|
|alternateType*|string| ["Profile" \| "Interaction"]|
|alternateTypeName*|string| |
|matchThreshold*|integer|Matching threshold, from 80 to 100 inclusive, in increments of 1|
|topMatchResultsCount*|integer|Number of matches above the threshold that we should be saved|
|alternateTypeResolutionId|string|Identifier of the list of property names that can be used as an identity for the predictive matched interactions|
|isRecurring|boolean|True if the match should be run on a periodic basis; false if match should only be run once.|
|lastMatchTime|datetime|Last time the match was run (readonly)|
|relationshipName|string|Name of the relationship created for storing profile-to-profile match results (readonly)|
|matchPropertyMappings*|MatchPropertyMappings[ ]|Primary-to-alternate property mappings, including hints. (see below)|
| | | |


### MatchPropertyMappings properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|primaryTypePropertyNames*|string[ ]| |
|alternateTypePropertyNames*|string[ ]| |
|matchHint|string| |
| | | |

The following properties can be updated after creation: **matchThreshold**, **topMatchResultsCount** and **isRecurring**. 


## JSON example

```{json}
}
    "PredictiveMatchPolicyName": "socialactivity_customer_email_name",
    "PrimaryTypeName": "Customer",
    "AlternateType":"Interaction",
    "AlternateTypeName": "SocialActivity",
    "DisplayName": {
        "en-us": "Predictive match policy for Social-Activity interaction and customer (on name and address properties)"
    },
    "Description": {
        "en-us": "Predictive match policy for social-activity interaction and customer (on name and address properties)"
    },
    "MatchPropertyMappings": [
    {
        "MatchHint": "Email",
        "PrimaryTypePropertyNames": [
            "Email"
        ],
        "AlternateTypePropertyNames": [
            "UserName"
        ]
    },
    {
        "MatchHint": "Name",
        "PrimaryTypePropertyNames": [
            "Name"
        ],
        "AlternateTypePropertyNames": [
            "FirstName",
            "LastName"
        ]
    }
]
```
