---
title: "msdyn_ParentIoTAlerts Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 9f3b8a0b-8a3c-43c6-b390-cb42da046cda
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_ParentIoTAlerts Action
[!INCLUDE[./descriptions/msdyn_parentiotalerts.md](./descriptions/msdyn_parentiotalerts.md)]

The msdyn_ParentIoTAlerts action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[msdyn_iotalert Entitytype](../entitytypes/msdyn_iotalert.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|TimespanSeconds|Edm.Int32|false|true|Determines the time window to consider when parenting (or suppressing) an alert. from 60 to 180 seconds.|





[!INCLUDE[./remarks/msdyn_parentiotalerts.md](./remarks/msdyn_parentiotalerts.md)]

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