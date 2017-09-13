---
title: "CascadeConfiguration ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 970becb8-0f4d-4b7a-922e-cf73d4166b0b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CascadeConfiguration ComplexType
[!INCLUDE[./descriptions/cascadeconfiguration.md](./descriptions/cascadeconfiguration.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Assign|[CascadeType EnumType](../enumtypes/CascadeType.md)|true|true|The referenced entity record owner is changed. | 
|Delete|[CascadeType EnumType](../enumtypes/CascadeType.md)|true|true|The referenced entity record is deleted.| 
|Merge|[CascadeType EnumType](../enumtypes/CascadeType.md)|true|true|The record is merged with another record.| 
|Reparent|[CascadeType EnumType](../enumtypes/CascadeType.md)|true|true|The referencing attribute in a parental relationship changes | 
|Share|[CascadeType EnumType](../enumtypes/CascadeType.md)|true|true|The referenced entity record is shared with another user. | 
|Unshare|[CascadeType EnumType](../enumtypes/CascadeType.md)|true|true|Sharing is removed for the referenced entity record. | 
|RollupView|[CascadeType EnumType](../enumtypes/CascadeType.md)|true|true|Indicates that the associated activities of the related entity should be included in Activity Associated View for the primary entity.| 

## Used by
The following use the CascadeConfiguration ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[OneToManyRelationshipMetadata EntityType](../metadataentitytypes/onetomanyrelationshipmetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/onetomanyrelationshipmetadata.md](../metadataentitytypes/descriptions/onetomanyrelationshipmetadata.md)]|
|[ComplexOneToManyRelationshipMetadata ComplexType](../complextypes/complexonetomanyrelationshipmetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexonetomanyrelationshipmetadata.md](../complextypes/descriptions/complexonetomanyrelationshipmetadata.md)]|

[!INCLUDE[./remarks/cascadeconfiguration.md](./remarks/cascadeconfiguration.md)]

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