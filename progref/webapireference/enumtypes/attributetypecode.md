---
title: "AttributeTypeCode EnumType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f37d21e3-e1f0-4e42-8dc9-397f235a8be0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AttributeTypeCode EnumType
[!INCLUDE[./descriptions/attributetypecode.md](./descriptions/attributetypecode.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|Boolean|0|A Boolean attribute.  | 
|Customer|1|An attribute that represents a customer.| 
|DateTime|2|A date/time attribute. | 
|Decimal|3|A decimal attribute.  | 
|Double|4|A double attribute.  | 
|Integer|5|An integer attribute. | 
|Lookup|6|A lookup attribute.  | 
|Memo|7|A memo attribute.| 
|Money|8|A money attribute. | 
|Owner|9|An owner attribute.| 
|PartyList|10|A partylist attribute.| 
|Picklist|11|A picklist attribute.| 
|State|12|A state attribute.| 
|Status|13|A status attribute.| 
|String|14|A string attribute.| 
|Uniqueidentifier|15|An attribute that is an ID.| 
|CalendarRules|16|An attribute that contains calendar rules. | 
|Virtual|17|An attribute that is created by the system at run time. | 
|BigInt|18|A big integer attribute. | 
|ManagedProperty|19|A managed property attribute. | 
|EntityName|20|An entity name attribute.  | 

## Used by
The following use the AttributeTypeCode enum type.
|Name|How used|Description|
|---|---|---|
|[AttributeMetadata EntityType](../metadataentitytypes/attributemetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/attributemetadata.md](../metadataentitytypes/descriptions/attributemetadata.md)]|
|[ManagedPropertyAttributeMetadata EntityType](../metadataentitytypes/managedpropertyattributemetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/managedpropertyattributemetadata.md](../metadataentitytypes/descriptions/managedpropertyattributemetadata.md)]|
|[ComplexAttributeMetadata ComplexType](../complextypes/complexattributemetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexattributemetadata.md](../complextypes/descriptions/complexattributemetadata.md)]|

[!INCLUDE[./remarks/attributetypecode.md](./remarks/attributetypecode.md)]

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