---
title: "AttributeMapping ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7e1397e7-f461-4cad-b68a-204754cedf4c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AttributeMapping ComplexType
[!INCLUDE[./descriptions/attributemapping.md](./descriptions/attributemapping.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AttributeMappingId|Edm.Guid|true|true|For internal use only.| 
|MappingName|Edm.String|true|false|For internal use only.| 
|AttributeCrmName|Edm.String|true|false|For internal use only.| 
|AttributeExchangeName|Edm.String|true|false|For internal use only.| 
|SyncDirection|Edm.Int32|true|true|For internal use only.| 
|DefaultSyncDirection|Edm.Int32|true|true|For internal use only.| 
|AllowedSyncDirection|Edm.Int32|true|true|For internal use only.| 
|IsComputed|Edm.Boolean|true|true|For internal use only. | 
|EntityTypeCode|Edm.Int32|true|true|For internal use only.| 
|ComputedProperties|Collection(Edm.String)||false|For internal use only.| 
|AttributeCrmDisplayName|Edm.String|true|false|For internal use only.| 
|AttributeExchangeDisplayName|Edm.String|true|false|For internal use only.| 

## Used by
The following use the AttributeMapping ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrievePrincipalSyncAttributeMappingsResponse ComplexType](../complextypes/retrieveprincipalsyncattributemappingsresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveprincipalsyncattributemappingsresponse.md](../complextypes/descriptions/retrieveprincipalsyncattributemappingsresponse.md)]|

[!INCLUDE[./remarks/attributemapping.md](./remarks/attributemapping.md)]

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