---
title: "CreateCustomerRelationshipsResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 43b48759-8612-41ab-ad6e-88eefb0666cd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CreateCustomerRelationshipsResponse ComplexType
[!INCLUDE[./descriptions/createcustomerrelationshipsresponse.md](./descriptions/createcustomerrelationshipsresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|RelationshipIds|Collection(Edm.Guid)||true|An array of relationship IDs created for the attribute to Account and Contact entities.| 
|AttributeId|Edm.Guid|true|true|The MetadataId of the LookupAttributeMetadata that is created.| 

## Used by
The following use the CreateCustomerRelationshipsResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[CreateCustomerRelationships Action](../actions/createcustomerrelationships.md)|ReturnType|[!INCLUDE[../actions/descriptions/createcustomerrelationships.md](../actions/descriptions/createcustomerrelationships.md)]|

[!INCLUDE[./remarks/createcustomerrelationshipsresponse.md](./remarks/createcustomerrelationshipsresponse.md)]

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