---
title: "CopyCampaign Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 92bb782e-2c9d-4356-afbe-f0b2d0d50efb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CopyCampaign Action
[!INCLUDE[./descriptions/copycampaign.md](./descriptions/copycampaign.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[campaign Entitytype](../entitytypes/campaign.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SaveAsTemplate|Edm.Boolean|false|true|Indicates whether to save the campaign as a template. |

## Return Type
The CopyCampaign action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[campaign EntityType](../entitytypes/campaign.md)|false|Contains the response from the CopyCampaign action.|



[!INCLUDE[./remarks/copycampaign.md](./remarks/copycampaign.md)]

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