---
title: Link Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Typically used to establish an association between an Interaction and a Profile or Interaction and another Interaction which is marked as an Activity.
keywords: Customer Insights; type; Link
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/06/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 7c20a1f1-e582-4a3c-8463-e605101d33f7
---

Link Type Definition
======================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A Link is typically used to establish an association between an [Interaction](./interaction.md) and a [Profile](./profile.md) or Interaction and another Interaction which is marked as an Activity. Links enable 
continuous profiling based upon real-world interactions, for example, of customers based upon their purchase patterns. Links also extend 
[KPIs](./kpi.md) in that when a KPI is created for an Interaction, an automatic association is created to linked Profiles. Links can also be 
used to initialize or update Profiles.


## Properties
Property names appended with asterisks* are required.

### LinkDefinition properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|tenantId|string|Name of the owning hub (readonly)|
|linkName*|string|Name of the Link (readonly)|
|sourceEntityType*|string|Entity type representing the source of the link, currently only "Interaction" is supported.|
|sourceEntityTypeName*|string|Name of the associated entity type, representing the source of the link.|
|targetEntityType*|string|Entity type representing the target of the link: [Interaction \| Profile]|
|targetEntityTypeName*|string|Name of the associated entity type, representing the target of the link|
|displayName|dictionary<string,string>|Localized display names for the link|
|description|string|Localized description of the link|
|provisioningState|string|["Provisioning" \| "Succeeded" \| "Expiring" \| "Deleting" \| "HumanIntervention" \| "Failed" ]|
|referenceOnly|boolean|True if is reference-only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update [profiles](./profile.md).|
|operationType|string|Determines whether the link is supposed to create or delete instances if NOT reference-only: ["Upsert" \| "Delete"] |
|mappings|TypePropertiesMapping[]|Concrete links mapping metadata (see below)|
|participantPropertyReferences*|ParticipantPropertyReference[ ]|Concrete links participating property metadata (see below)|
| | | |

### TypePropertiesMapping properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|sourcePropertyName*|string|Property name in the source|
|targetPropertyName*|string|Matching property name in the target|
|linkType|string|Link behavior type ["UpdateAlways" \| "CopyIfNull"]|
| | | |

### ParticipantPropertyReference properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|sourcePropertyName*|string|Name of the source property (that maps to the target property)|
|targetPropertyName*|string|Name of the target property|
| | | |


## JSON example
```{json}
{ 
    "tenantId":"sdkTestHub",
    "linkName":"TestLink4806", 
    "provisioningState": "Provisioning",
    "sourceEntityType": "Interaction",
    "sourceEntityTypeName": "testInteraction1949"
    "targetEntityType": "Profile",  
    "targetEntityTypeName": "testProfile1446",
    "operationType": "Upsert",
    "description": {
        "en-us": "Test Link Description"
    },
    "displayName": {
        "en-us": "Test Link DisplayName"
    },
    "mappings": [{
        "sourcePropertyName": "testInteraction1949",
        "targetPropertyName": "testProfile1446",
        "linkType": "UpdateAlways"
    }],
    "participantPropertyReferences": [{
        "sourcePropertyName": "testInteraction1949",
        "targetPropertyName": "ProfileId"
    }],
}

```
