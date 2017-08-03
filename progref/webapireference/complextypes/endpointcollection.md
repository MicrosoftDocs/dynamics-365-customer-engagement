---
title: "EndpointCollection ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e6234400-9b66-4a0c-aea5-37da048dfaf1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# EndpointCollection ComplexType
[!INCLUDE[./descriptions/endpointcollection.md](./descriptions/endpointcollection.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Count|Edm.Int32|true|true|The number of elements in the collection.  | 
|IsReadOnly|Edm.Boolean|true|true|Whether the DataCollection is read-only | 
|Keys|Collection([EndpointType EnumType](../enumtypes/EndpointType.md))|false|true|Collection containing the keys in the DataCollection. | 
|Values|Collection(Edm.String)|false|false|Collection containing the values in the DataCollection. | 

## Used by
The following use the EndpointCollection ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[OrganizationDetail ComplexType](../complextypes/organizationdetail.md)|Property|[!INCLUDE[../complextypes/descriptions/organizationdetail.md](../complextypes/descriptions/organizationdetail.md)]|

[!INCLUDE[./remarks/endpointcollection.md](./remarks/endpointcollection.md)]

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