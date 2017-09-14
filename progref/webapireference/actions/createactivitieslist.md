---
title: "CreateActivitiesList Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: c19b8aca-f005-4b06-8fe9-7e52f3b28ebd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CreateActivitiesList Action
[!INCLUDE[./descriptions/createactivitieslist.md](./descriptions/createactivitieslist.md)]

The CreateActivitiesList action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ListId|Edm.Guid|false|true|ID of the list. |
|FriendlyName|Edm.String|false|false|A display name for the campaign.|
|Activity|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The activity to be distributed.|
|TemplateId|Edm.Guid|false|true|ID of the email template. |
|Propagate|Edm.Boolean|false|true|Indicates whether the activity is both created and executed. |
|OwnershipOptions|[PropagationOwnershipOptions EnumType](../enumtypes/PropagationOwnershipOptions.md)|false|true|Propogation ownership options. |
|Owner|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|Owner for the activity. |
|sendEmail|Edm.Boolean|false|true|Indicates whether to send an email about the new activity. |
|PostWorkflowEvent|Edm.Boolean|false|true|Indicates whether an asynchronous job is used to distribute an activity, such as an email, fax, or letter, to the members of a list. |
|QueueId|Edm.Guid|true|true|ID of the queue to which the created activities are added. |

## Return Type
The CreateActivitiesList action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[CreateActivitiesListResponse ComplexType](../complextypes/CreateActivitiesListResponse.md)|false|Contains the response from the CreateActivitiesList action.|

## Entities
Use the CreateActivitiesList action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[list Entitytype](../entitytypes/list.md)|[!INCLUDE[../entitytypes/descriptions/list.md](../entitytypes/descriptions/list.md)]|

[!INCLUDE[./remarks/createactivitieslist.md](./remarks/createactivitieslist.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />