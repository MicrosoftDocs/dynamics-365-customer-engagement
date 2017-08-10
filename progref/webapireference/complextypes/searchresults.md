---
title: "SearchResults ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a5bcc62f-8711-438a-8f47-fadb5d48adfb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SearchResults ComplexType
[!INCLUDE[./descriptions/searchresults.md](./descriptions/searchresults.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Proposals|Collection([AppointmentProposal ComplexType](../complextypes/AppointmentProposal.md))||true| The set of proposed appointments that meet the appointment request criteria. | 
|TraceInfo|[TraceInfo ComplexType](../complextypes/TraceInfo.md)|true|true| Information regarding the results of the search. | 

## Used by
The following use the SearchResults ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[SearchResponse ComplexType](../complextypes/searchresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/searchresponse.md](../complextypes/descriptions/searchresponse.md)]|

[!INCLUDE[./remarks/searchresults.md](./remarks/searchresults.md)]

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