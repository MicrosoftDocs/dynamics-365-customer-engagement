---
title: Relationship Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: A Relationship defines an association between two Profiles.
keywords: Customer Insights; type; relationship
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/22/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2d28b8d4-c768-49b2-9602-8fab0133efb2
---

Relationship Type Definition
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A Relationship represents an explicit, contextually relevant connection between two different profile types. For example, a new customer might be assigned to a specific salesperson. A profile may have any number of associated relationships. Relationships always have a direction, although a relationship can always be navigated forward (from source to target) or backward (from target to source). A model may or may not contain a mirror relationship that explicitly denotes the reverse connection. For example, SalespersonCustomer and CustomerSalesperson relationships would mirror each other.

In the current release of Customer Insights, Relationships cannot be deleted, rather only created or updated. Relationships can be programmatically managed through either the [ARM Type Modeling APIs](../arm/typemodeling.md) or the [Hub Type Modeling APIs](../hub/typemodeling.md).

## Properties

<!-- Keys for a Relationship enable the lookup of a specific profile instance. Keys can consist of a single property, or a tuple 
of properties. The key value(s) have to be unique for each profile instance of that type. The primary key for every type is a system generated property called *relationshipGuidId*.  -->


### RelationshipDefinition properties:
|**Property**|**JSON type**|**Description**|  
| ---------- | ----------- | ------------- |   
|cardinality | string | Relationship cardinality: ["OneToOne" \| "ManyToOne" \| "ManyToMany "] |
|displayName|Dictionary\<string,string\>|The localized display name|
|description|Dictionary\<string,string\>|The localized description|
|expiryDateTimeUtc | string (date-time) | Expiry date time in UTC |
|fields|[Field](./field.md) [ ]|The custom Properties (Fields) of this type | 
|lookupMappings | RelationshipTypeMapping[ ] | Optional property to map fields in a profile to their strong ids in a related profile (see below) |
|profileType | string | Type of the current profile |
|provisioningState | string | ["Provisioning" \| "Succeeded" \| "Expiring" \| "Deleting" \| "HumanIntervention" \| "Failed" ] |
|relationshipName | string  | Name of the relationship (readonly) |
|relatedProfileType | string | Type of the referenced (target) profile |
|relationshipGuidId | string (GUID) | The relationship guid id (readonly) |
|tenantId | string | The hub name |
| | | |

<br>

### RelationshipTypeMapping properties
|**Property**|**JSON type**|**Description**|  
| ---------- | ----------- | ------------- |   
| fieldMappings | Array RelationshipTypeFieldMapping (see below) | Maps a profile property with the StrongId of related profile. This is an array to support StrongIds that are composite key as well. |
| | | |

<br>

### RelationshipTypeFieldMapping properties
|**Property**|**JSON type**|**Description**|  
| ---------- | ----------- | ------------- |   
| profileFieldName | string | Identifies the field name in profile. |
| relatedProfileKeyProperty | string | Identifies the key property (from StrongId) of the related profile |
| | | |


## JSON example

~~~{json}
{
    "relationshipName" : "Device_User_OwnedBy"
    "ProfileType" : "Device"
    "RelatedProfileType" : "User"
    "Cardinality" : "ManyToOne"
    "LookupMappings" : [
        "FieldMappings" : [
            {
                "ProfileFieldName" : "OwnerId"
                "RelatedProfileKeyProperty" : "UserId"
            }
        ]
    ]
}
~~~
