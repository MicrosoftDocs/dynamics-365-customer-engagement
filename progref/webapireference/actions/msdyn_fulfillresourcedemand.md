---
title: "msdyn_FulfillResourceDemand Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: bbcdb93f-8f83-4c7f-aaff-9b7b6d45439a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_FulfillResourceDemand Action
[!INCLUDE[./descriptions/msdyn_fulfillresourcedemand.md](./descriptions/msdyn_fulfillresourcedemand.md)]

The msdyn_FulfillResourceDemand action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|FulfillmentContext|Edm.String|false|false|TODO: Add description for msdyn_FulfillResourceDemand FulfillmentContext parameter.|
|FulfillmentType|Edm.Int32|false|true|TODO: Add description for msdyn_FulfillResourceDemand FulfillmentType parameter.|
|ProjectReference|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|TODO: Add description for msdyn_FulfillResourceDemand ProjectReference parameter.|
|RequirementEntity|[msdyn_resourcerequirement EntityType](../entitytypes/msdyn_resourcerequirement.md)|true|true|TODO: Add description for msdyn_FulfillResourceDemand RequirementEntity parameter.|
|Timeframe|Edm.Int32|false|true|TODO: Add description for msdyn_FulfillResourceDemand Timeframe parameter.|
|AvailabilityViewType|Edm.Int32|false|true|TODO: Add description for msdyn_FulfillResourceDemand AvailabilityViewType parameter.|

## Return Type
The msdyn_FulfillResourceDemand action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_FulfillResourceDemandResponse ComplexType](../complextypes/msdyn_FulfillResourceDemandResponse.md)|false|TODO: Add description for msdyn_FulfillResourceDemand return type.|



[!INCLUDE[./remarks/msdyn_fulfillresourcedemand.md](./remarks/msdyn_fulfillresourcedemand.md)]

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