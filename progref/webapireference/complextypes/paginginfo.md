---
title: "PagingInfo ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 36db5e90-14e7-460b-a2f2-e01854643ef6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# PagingInfo ComplexType
[!INCLUDE[./descriptions/paginginfo.md](./descriptions/paginginfo.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|PageNumber|Edm.Int32|true|true| The number of pages returned from the query. | 
|Count|Edm.Int32|true|true|The number of entity instances returned per page. | 
|ReturnTotalRecordCount|Edm.Boolean|true|true|The total number of records should be returned from the query.| 
|PagingCookie|Edm.String|true|false|The info used to page large result sets.| 

## Used by
The following use the PagingInfo ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    


[!INCLUDE[./remarks/paginginfo.md](./remarks/paginginfo.md)]

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