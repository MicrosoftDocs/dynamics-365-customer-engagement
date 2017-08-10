---
title: "DistributeCampaignActivity Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: c0e8269e-36f5-4587-89e0-ec949a87aa26
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# DistributeCampaignActivity Action
[!INCLUDE[./descriptions/distributecampaignactivity.md](./descriptions/distributecampaignactivity.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[campaignactivity Entitytype](../entitytypes/campaignactivity.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Propagate|Edm.Boolean|false|true|Indicates whether the activity is both created and executed.  |
|Activity|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|The activity to be distributed. |
|Template|[template EntityType](../entitytypes/template.md)|false|true|The email template. |
|OwnershipOptions|[PropagationOwnershipOptions EnumType](../enumtypes/PropagationOwnershipOptions.md)|false|true|The ownership options for the activity. |
|Owner|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The owner for the newly created activity. |
|SendEmail|Edm.Boolean|false|true|Indicates whether to send an email about the new activity. |
|Queue|[queue EntityType](../entitytypes/queue.md)|true|true|The queue to which the created activity is added.|
|PostWorkflowEvent|Edm.Boolean|false|true|Indicates whether an asynchronous job is used to distribute activities, such as an email, fax, or letter, to the members of a list.|

## Return Type
The DistributeCampaignActivity action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[bulkoperation EntityType](../entitytypes/bulkoperation.md)|false|Contains the response from the DistributeCampaignActivity Action.|



[!INCLUDE[./remarks/distributecampaignactivity.md](./remarks/distributecampaignactivity.md)]

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