---
title: "SetFeatureStatus Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: d4057bd0-1f9c-474a-aecf-023f3880ccfd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SetFeatureStatus Action
[!INCLUDE[./descriptions/setfeaturestatus.md](./descriptions/setfeaturestatus.md)]

The SetFeatureStatus action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|FeatureType|Edm.Int32|false|true|internal|
|Status|Edm.Boolean|false|true|internal|
|ConfigData|Edm.String|true|false|internal|
|IsSolutionUninstall|Edm.Boolean|true|true|internal|





[!INCLUDE[./remarks/setfeaturestatus.md](./remarks/setfeaturestatus.md)]

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