---
title: "ManagedPropertyMetadata EntityType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 153567bd-06bf-4a83-9516-dc2b48c35a2c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ManagedPropertyMetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/managedpropertymetadata.md](./descriptions/managedpropertymetadata.md)]</td></tr>
<tr><td><b>Base Type:</b></td><td>[MetadataBase EntityType](metadatabase.md)</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]ManagedPropertyDefinitions</td></tr>
<tr><td><b>Primary Key:</b></td><td>MetadataId</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET,PUT,DELETE</td></tr>
</table>
 
 The ManagedPropertyMetadata EntityType:
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Is not explicitly used by any operations but may be referenced using [MetadataBase EntityType](metadatabase.md).

## Properties
Properties represent fields of data stored in the entity.


|Name|Type|Description|  
|----|----|-------|  
|Description|[Label ComplexType](../complextypes/Label.md)|For internal use only.|
|DisplayName|[Label ComplexType](../complextypes/Label.md)|For internal use only.|
|EnablesAttributeName|Edm.String|For internal use only.|
|EnablesEntityName|Edm.String|For internal use only.|
|ErrorCode|Edm.Int32|For internal use only.|
|EvaluationPriority|[ManagedPropertyEvaluationPriority EnumType](../enumtypes/ManagedPropertyEvaluationPriority.md)|For internal use only.|
|HasChanged|Edm.Boolean|Indicates whether the item of metadata has changed.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|IntroducedVersion|Edm.String|For internal use only.|
|IsGlobalForOperation|Edm.Boolean|For internal use only.|
|IsPrivate|Edm.Boolean|For internal use only.|
|LogicalName|Edm.String|For internal use only.|
|ManagedPropertyType|[ManagedPropertyType EnumType](../enumtypes/ManagedPropertyType.md)|For internal use only.|
|MetadataId|Edm.Guid|A unique identifier for the metadata item.<br />Inherited from [MetadataBase EntityType](metadatabase.md).|
|Operation|[ManagedPropertyOperation EnumType](../enumtypes/ManagedPropertyOperation.md)|For internal use only.|

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