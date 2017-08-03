---
title: "CreateCustomerRelationships Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 66a433f7-8df2-48a6-8eb6-4ed2dcac568a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CreateCustomerRelationships Action
[!INCLUDE[./descriptions/createcustomerrelationships.md](./descriptions/createcustomerrelationships.md)]

The CreateCustomerRelationships action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Lookup|[ComplexLookupAttributeMetadata ComplexType](../complextypes/ComplexLookupAttributeMetadata.md)|true|true|The metadata for the lookup field used to store the ID of the related record. |
|OneToManyRelationships|Collection([ComplexOneToManyRelationshipMetadata ComplexType](../complextypes/ComplexOneToManyRelationshipMetadata.md))||true|The metadata array for the one-to-many relationships to the Account and Contact entity. |
|SolutionUniqueName|Edm.String|true|false|The name of the unmanaged solution to which you want to add this customer lookup attribute to.|

## Return Type
The CreateCustomerRelationships action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[CreateCustomerRelationshipsResponse ComplexType](../complextypes/CreateCustomerRelationshipsResponse.md)|false|Contains the response from the CreateCustomerRelationships Action|



[!INCLUDE[./remarks/createcustomerrelationships.md](./remarks/createcustomerrelationships.md)]

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