---
title: "PropagationOwnershipOptions EnumType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 86b7247c-f0d5-439d-97af-1f9065908795
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# PropagationOwnershipOptions EnumType
[!INCLUDE[./descriptions/propagationownershipoptions.md](./descriptions/propagationownershipoptions.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|None|0|There is no change in ownership for the created activities. | 
|Caller|1|All created activities are assigned to the caller of the API.  | 
|ListMemberOwner|2|Created activities are assigned to respective owners of target members. | 

## Used by
The following use the PropagationOwnershipOptions enum type.
|Name|How used|Description|
|---|---|---|
|[CreateActivitiesList Action](../actions/createactivitieslist.md)|Parameter|[!INCLUDE[../actions/descriptions/createactivitieslist.md](../actions/descriptions/createactivitieslist.md)]|
|[DistributeCampaignActivity Action](../actions/distributecampaignactivity.md)|Parameter|[!INCLUDE[../actions/descriptions/distributecampaignactivity.md](../actions/descriptions/distributecampaignactivity.md)]|
|[PropagateByExpression Action](../actions/propagatebyexpression.md)|Parameter|[!INCLUDE[../actions/descriptions/propagatebyexpression.md](../actions/descriptions/propagatebyexpression.md)]|

[!INCLUDE[./remarks/propagationownershipoptions.md](./remarks/propagationownershipoptions.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)   
 [Web API EntityType Reference](../entitytypereference.md)   
 [Web API Action Reference](../actionreference.md)   
 [Web API Function Reference](../functionreference.md)   
 [Web API Query Function Reference](../queryfunctionreference.md)   
 [Web API EnumType Reference](../enumtypereference.md)   
 [Web API ComplexType Reference](../complextypereference.md)   
 [Web API Metadata EntityType Reference](../entitytypereference.md)   
 [Web API Solutions Reference](../solutionreference.md)