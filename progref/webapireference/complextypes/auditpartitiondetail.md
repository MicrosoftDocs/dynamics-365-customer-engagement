---
title: "AuditPartitionDetail ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 102ce880-a824-4183-92c7-38b4744db18e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AuditPartitionDetail ComplexType
[!INCLUDE[./descriptions/auditpartitiondetail.md](./descriptions/auditpartitiondetail.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|PartitionNumber|Edm.Int32|true|true| The sequence (serial) number of the partition. | 
|StartDate|Edm.DateTimeOffset|true|true| The creation date and time of the first audit record in the partition. | 
|EndDate|Edm.DateTimeOffset|true|true|The end date and time for the last audit record in the partition. | 
|Size|Edm.Int64|true|true|The size, in bytes, of the partition.| 

## Used by
The following use the AuditPartitionDetail ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveAuditPartitionListResponse ComplexType](../complextypes/retrieveauditpartitionlistresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveauditpartitionlistresponse.md](../complextypes/descriptions/retrieveauditpartitionlistresponse.md)]|

[!INCLUDE[./remarks/auditpartitiondetail.md](./remarks/auditpartitiondetail.md)]

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