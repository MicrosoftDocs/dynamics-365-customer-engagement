---
title: "Label ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c5082cb7-4598-4d72-8b0c-e871b21324e8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Label ComplexType
[!INCLUDE[./descriptions/label.md](./descriptions/label.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|LocalizedLabels|Collection([LocalizedLabel ComplexType](../complextypes/LocalizedLabel.md))||true|The collection of localized labels.| 
|UserLocalizedLabel|[LocalizedLabel ComplexType](../complextypes/LocalizedLabel.md)|true|true|The label for the language of the current user. | 

## Used by
The following use the Label ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[InsertOptionValue Action](../actions/insertoptionvalue.md)|Parameter|[!INCLUDE[../actions/descriptions/insertoptionvalue.md](../actions/descriptions/insertoptionvalue.md)]|
|[InsertStatusValue Action](../actions/insertstatusvalue.md)|Parameter|[!INCLUDE[../actions/descriptions/insertstatusvalue.md](../actions/descriptions/insertstatusvalue.md)]|
|[UpdateOptionValue Action](../actions/updateoptionvalue.md)|Parameter|[!INCLUDE[../actions/descriptions/updateoptionvalue.md](../actions/descriptions/updateoptionvalue.md)]|
|[UpdateStateValue Action](../actions/updatestatevalue.md)|Parameter|[!INCLUDE[../actions/descriptions/updatestatevalue.md](../actions/descriptions/updatestatevalue.md)]|
|[RetrieveLocLabelsResponse ComplexType](../complextypes/retrieveloclabelsresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveloclabelsresponse.md](../complextypes/descriptions/retrieveloclabelsresponse.md)]|
|[AttributeMetadata EntityType](../metadataentitytypes/attributemetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/attributemetadata.md](../metadataentitytypes/descriptions/attributemetadata.md)]|
|[EntityMetadata EntityType](../metadataentitytypes/entitymetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/entitymetadata.md](../metadataentitytypes/descriptions/entitymetadata.md)]|
|[EntityKeyMetadata EntityType](../metadataentitytypes/entitykeymetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/entitykeymetadata.md](../metadataentitytypes/descriptions/entitykeymetadata.md)]|
|[OptionSetMetadataBase EntityType](../metadataentitytypes/optionsetmetadatabase.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/optionsetmetadatabase.md](../metadataentitytypes/descriptions/optionsetmetadatabase.md)]|
|[ManagedPropertyMetadata EntityType](../metadataentitytypes/managedpropertymetadata.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/managedpropertymetadata.md](../metadataentitytypes/descriptions/managedpropertymetadata.md)]|
|[AssociatedMenuConfiguration ComplexType](../complextypes/associatedmenuconfiguration.md)|Property|[!INCLUDE[../complextypes/descriptions/associatedmenuconfiguration.md](../complextypes/descriptions/associatedmenuconfiguration.md)]|
|[ComplexAttributeMetadata ComplexType](../complextypes/complexattributemetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexattributemetadata.md](../complextypes/descriptions/complexattributemetadata.md)]|
|[ComplexEntityMetadata ComplexType](../complextypes/complexentitymetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexentitymetadata.md](../complextypes/descriptions/complexentitymetadata.md)]|
|[OptionMetadata ComplexType](../complextypes/optionmetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/optionmetadata.md](../complextypes/descriptions/optionmetadata.md)]|
|[ComplexEntityKeyMetadata ComplexType](../complextypes/complexentitykeymetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexentitykeymetadata.md](../complextypes/descriptions/complexentitykeymetadata.md)]|

[!INCLUDE[./remarks/label.md](./remarks/label.md)]

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