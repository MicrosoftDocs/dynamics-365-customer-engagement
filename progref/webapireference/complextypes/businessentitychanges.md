---
title: "BusinessEntityChanges ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ca225128-4a92-4086-bb8d-b7053923914f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# BusinessEntityChanges ComplexType
[!INCLUDE[./descriptions/businessentitychanges.md](./descriptions/businessentitychanges.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|MoreRecords|Edm.Boolean|true|true|Indicates whether there are more records in the business entity changes collection.| 
|PagingCookie|Edm.String|true|false|The paging cookie.| 
|DataToken|Edm.String|true|false|The data token.| 
|Changes|Collection([IChangedItem ComplexType](../complextypes/IChangedItem.md))||true|The business entity changes collection.| 

## Used by
The following use the BusinessEntityChanges ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveEntityChangesResponse ComplexType](../complextypes/retrieveentitychangesresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveentitychangesresponse.md](../complextypes/descriptions/retrieveentitychangesresponse.md)]|

[!INCLUDE[./remarks/businessentitychanges.md](./remarks/businessentitychanges.md)]

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