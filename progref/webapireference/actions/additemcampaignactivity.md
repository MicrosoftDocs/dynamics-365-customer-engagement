---
title: "AddItemCampaignActivity Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 46977068-c7ea-426a-9ece-37c4fae2b1ab
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddItemCampaignActivity Action
[!INCLUDE[./descriptions/additemcampaignactivity.md](./descriptions/additemcampaignactivity.md)]

The AddItemCampaignActivity action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|CampaignActivity|[campaignactivity EntityType](../entitytypes/campaignactivity.md)|false|true|The campaign activity to add the item to. |
|Item|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The item to be added to the campaign activity. |

## Return Type
The AddItemCampaignActivity action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[AddItemCampaignActivityResponse ComplexType](../complextypes/AddItemCampaignActivityResponse.md)|false|Contains the response from AddItemCampaignActivity action. |

## Entities
Use the AddItemCampaignActivity action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[campaign Entitytype](../entitytypes/campaign.md)|[!INCLUDE[../entitytypes/descriptions/campaign.md](../entitytypes/descriptions/campaign.md)]|
|[campaignactivity Entitytype](../entitytypes/campaignactivity.md)|[!INCLUDE[../entitytypes/descriptions/campaignactivity.md](../entitytypes/descriptions/campaignactivity.md)]|

[!INCLUDE[./remarks/additemcampaignactivity.md](./remarks/additemcampaignactivity.md)]

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