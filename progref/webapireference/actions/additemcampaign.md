---
title: "AddItemCampaign Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 47b95389-dbca-453b-9b96-1441c0fc579b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddItemCampaign Action
[!INCLUDE[./descriptions/additemcampaign.md](./descriptions/additemcampaign.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[campaign Entitytype](../entitytypes/campaign.md)|entity|
|[list Entitytype](../entitytypes/list.md)|entity|
|[product Entitytype](../entitytypes/product.md)|entity|
|[salesliterature Entitytype](../entitytypes/salesliterature.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Campaign|[campaign EntityType](../entitytypes/campaign.md)|false|true|The campaign to add the item to.|

## Return Type
The AddItemCampaign action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[campaignitem EntityType](../entitytypes/campaignitem.md)|false| Contains the response from AddItemCampaignRequest action.|

## Entities
Use the AddItemCampaign action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[campaignactivity Entitytype](../entitytypes/campaignactivity.md)|[!INCLUDE[../entitytypes/descriptions/campaignactivity.md](../entitytypes/descriptions/campaignactivity.md)]|

[!INCLUDE[./remarks/additemcampaign.md](./remarks/additemcampaign.md)]

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