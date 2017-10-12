---
title: Interaction Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: An Interaction is an immutable representation of an event or activity of relevance to a business, and is usually associated with a Profile.
keywords: Customer Insights; type; interaction
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/14/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: bf68c9e6-c6b8-4f02-9849-54421312ca7d
---

Interaction Type Definition
===========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

An Interaction is a representation of an event or activity of relevance to a business, and is usually associated between two Profiles. An interaction can consist of multiple measures, dimensions and participants at a specific point-in-time. (It is semantically close to an action performed or participated by a profile as described in http://schema.org/Action.) For example, data that is ingested into a [Profile](./profile.md) from an external data source must first be represented as an Interaction. In the current version of Customer Insights, Interactions can only be added or updated, but not deleted. An Interaction can also be linked to secondary participants through the **ParticipantProfiles** collection. Interactions are immutable once created because they represent a single event. However, if the **isActivity** property is set to true upon creation, then the type represents a ongoing business activity that can be modified over time. For more information, see [Working with Data in Customer Insights](../../dev/workingwithdata.md). 


## Properties

### InteractionTypeDefintion properties:

|**Property**|**JSON type**|**Description**|  
| --------------- | ---------- | ------------- |
|idPropertyNames*|string[ ]|Fields which uniquely identify an Interaction instance|
|apiEntitySetName|string|Unique collection name for the interaction type, commonly formed by taking the plural of the Interaction name. <br> For a hub, the *ApiEntitySetName* should be different for each type (across Profile and Interaction types).|
|SchemaItemTypeLink|string|URL-encoded schema.org item type link for the associated type|
|tenantId|string|Name of the owning hub (readonly)|
|entityType|string|Type of the entity, e.g. "Interaction"|
|typeName|string|Name of the specific type|
|provisioningState|string|Hub provisioning state: ["Provisioning" \| "Succeeded" \| "Expiring" \| "Deleting" \| "HumanIntervention" \| "Failed" ]|
|timestampPropertyName|string|Name of the field that contains the creation or last modified datetime. If this value is not specified, the system generated time is used.|
|isActivity|boolean|True if type represents a mutable business activity; otherwise false if a mutable interaction (the default)|
|defaultDataSource|[DataSource](./datasource.md)|Data Source to be assigned to an interaction instance when the interaction is being ingested|
|smallImage|string|Relative path of the 'small' size image associated with the type. Actual image must be uploaded using Image Management APIs.|
|mediumImage|string|Relative path of the 'medium' size image associated with the Profile type. Actual image must be uploaded using Image Management APIs.|
|largeImage|string|Relative path of the 'large' size image associated with the Profile type. Actual image must be uploaded using Image Management APIs.|
|displayName|Dictionary\<string, string\>|Localized display names for the type|
|description|Dictionary\<string, string\>|Localized descriptions for the type|
|localizedAttributes|Dictionary\<string, Dictionary\<string, string\>\>|Any custom localized attributes for the type|
|attributes|Dictionary\<string, string[]\>|Any custom attributes for the type|
|fields|List [Field](./field.md)|The custom Properties (Fields) of this type|
|primaryParticipantProfile&shy;PropertyName|string|The direct performer or driver of the interaction. The value should be the name of one of the participants. This is helps build up the semantic intelligence around the interaction.|
|participantProfiles|Participant[ ]|List of participating profiles for the interaction (see below)|
| | | |

### Participant properties:
|**Property**|**JSON type**|**Description**|  
| --------------- | ---------- | ------------- |
|profileTypeName*|string|Profile type name|
|participantPropertyReference*|ParticipantPropertyReference[ ]|Property references (see below)|
|participantName*|string|Participant's name|
|displayName|Dictionary\<string,string\>|The localized display name|
|description|Dictionary\<string,string\>|The localized description|
|role|string|Role that participant playing in the interaction|
| | | |

### ParticipantPropertyReference properties:
|**Property**|**JSON type**|**Description**|  
| --------------- | ---------- | ------------- |
|interactionPropertyName*|string|Interaction property that maps to profile property|
|profilePropertyName|string|Profile property that maps to interaction property|
| | | |

## JSON Example for Interaction Type  

~~~{json}
 {
     "IdPropertyNames":["TestInteractionType6358"],
     "ApiEntitySetName":"Test6358Opened",
     "TimestampPropertyName":"TimeOpened",
     "entityType": "Interaction",
     "typeName": "TestInteractionType6358"
     "provisioningState": "Provisioning",
     "tenantId": "azsdktesthub",
     "PrimaryParticipantProfilePropertyName":"Receiver",
     "SmallImage":"myimages/image1.jpeg",
     "MediumImage":"myimages/image2.jpeg",
     "isActivity": "false",
     "ParticipantProfiles":[{
         "ProfileTypeName":"Contact", 
         "ParticipantPropertyReferences":[{
             "InteractionPropertyName":"Receiver",
             "ProfilePropertyName":"ContactId"
         }],
         "Name":"ProfileTestId",
         "DisplayName":null,
         "Description":null,"Role":null
     }],
     "fields": [{
        "fieldName": "TestInteractionType6358",
        "fieldType": "Edm.String",
        "isArray": false,
        "isEnum": false,
        "isFlagEnum": false,
        "isImage": false,
        "isLocalizedString": false,
        "isName": false,
        "isRequired": true,
        "propertyId": "id1"
    },
    {
        "fieldName": "profile1",
        "fieldType": "Edm.String",
        "isArray": false,
        "isEnum": false,
        "isFlagEnum": false,
        "isImage": false,
        "isLocalizedString": false,
        "isName": false,
        "isRequired": true,
        "propertyId": "id1"
    }]
}
~~~
