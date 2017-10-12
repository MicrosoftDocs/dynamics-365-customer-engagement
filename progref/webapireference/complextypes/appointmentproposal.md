---
title: "AppointmentProposal ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 726b51f1-6f43-4540-a034-8cd00eca85f6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AppointmentProposal ComplexType
[!INCLUDE[./descriptions/appointmentproposal.md](./descriptions/appointmentproposal.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Start|Edm.DateTimeOffset|true|true|The proposed appointment start date and time | 
|End|Edm.DateTimeOffset|true|true|The proposed appointment end date and time. | 
|SiteId|Edm.Guid|true|true|The ID of the site for the proposed appointment.| 
|SiteName|Edm.String|true|false|The name of the site for the proposed appointment. | 
|ProposalParties|Collection([ProposalParty ComplexType](../complextypes/ProposalParty.md))||true|An array of parties needed for the proposed appointment.| 

## Used by
The following use the AppointmentProposal ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[SearchResults ComplexType](../complextypes/searchresults.md)|Property|[!INCLUDE[../complextypes/descriptions/searchresults.md](../complextypes/descriptions/searchresults.md)]|

[!INCLUDE[./remarks/appointmentproposal.md](./remarks/appointmentproposal.md)]

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