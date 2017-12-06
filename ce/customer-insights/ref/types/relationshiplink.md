---
title: RelationshipLink Type Definition
description: A RelationshipLink defines an association between an Interaction and a Profile.
keywords: Customer Insights; type; relationship link
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/24/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2d28b8d4-c768-49b2-9602-8fab0133efb2
---

RelationshipLink Type Definition
==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A Relationship Link represents an explicit connection between a [Relationship](./relationship.md) and an [Interaction](./interaction.md) type. A relationship can be created or updated by the data that originates in an interaction and flows through a relationship link.

Relationship link types can be programmatically managed through either the 
[ARM Type Modeling APIs](../arm/typemodeling.md) or the [Hub Type Modeling APIs](../hub/typemodeling.md). 

## Properties

Property names appended with asterisks* are required.

### RelationshipLinkDefinition properties:
|**Property**|**JSON type**|**Description**|  
| ---------- | ----------- | ------------- |   
|displayName|Dictionary\<string,string\>|The localized display name|
|description|Dictionary\<string,string\>|The localized description|
|interactionType*|string|Interaction entity type associated with the link|
|linkName*|string|Name of the link (readonly)|
|mappings|RelationshipLinkFieldMapping[ ] |Associations between Interaction and Relationship properties (see below)|
|profilePropertyReferences*|ParticipantPropertyReference[ ]|Property references for the Profile of the Relationship  (see below)|
|provisioningState|string| ["Provisioning" \| "Succeeded" \| "Expiring" \| "Deleting" \| "HumanIntervention" \| "Failed" ] |
|relatedProfilePropertyReferences*|ParticipantPropertyReference[ ] |Property references for the Related Profile of the Relationship (see below)|
|relationshipName*|string|Relationship associated with the link|
|relationshipGuidId|string (GUID)|Relationship guid id (readonly)|
|tenantId|string|Hub name|
| | | |

<br>

### RelationshipLinkFieldMapping properties
|**Property**|**JSON type**|**Description**|  
| ---------- | ----------- | ------------- |   
|interactionFieldName*|string|Property name in the Interaction type|
|linkType|string|[ "UpdateAlways" \| "CopyIfNull" ]|
|relationshipFieldName*|string|Name of the Relationship metadata|
| | | |

<br>

### ParticipantPropertyReference properties
|**Property**|**JSON type**|**Description**|  
| ---------- | ----------- | ------------- |   
|interactionPropertyName*|string|Interaction property that maps to the Profile property|
|profilePropertyName*|string|Profile property that maps to the Interaction property|
| | | |


## JSON example

~~~{json}
{
    "description": {
    	"en-us": "Link Description"
    },
    "displayName": {
    	"en-us": "Link DisplayName"
    },
    "interactionType": "testInteraction4332",
    "linkName": "testlink002",
    "profilePropertyReferences": [{
        "interactionPropertyName": "profile1",
        "profilePropertyName": "ProfileId"
    }],
    "provisioningState": "Provisioning",
    "relatedProfilePropertyReferences": [{
        "interactionPropertyName": "profile1",
        "profilePropertyName": "ProfileId"
    }],
    "relationshipName": "testProfile2326994",
    "tenantId": "sdktesthub"
}
~~~





