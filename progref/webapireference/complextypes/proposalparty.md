---
title: "ProposalParty ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c9741e17-d888-484a-b918-50ff3b0fa2be
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ProposalParty ComplexType
[!INCLUDE[./descriptions/proposalparty.md](./descriptions/proposalparty.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ResourceId|Edm.Guid|true|true|The ID of the resource that is represented by this party.| 
|ResourceSpecId|Edm.Guid|true|true|The ID of the resource specification that is represented by this party. | 
|DisplayName|Edm.String|true|false|The display name for the party. | 
|EntityName|Edm.String|true|false|The logical name of the type of entity that is represented by this party. | 
|EffortRequired|Edm.Double|true|true|The percentage of time that is required to perform the service. | 

## Used by
The following use the ProposalParty ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[AppointmentProposal ComplexType](../complextypes/appointmentproposal.md)|Property|[!INCLUDE[../complextypes/descriptions/appointmentproposal.md](../complextypes/descriptions/appointmentproposal.md)]|

[!INCLUDE[./remarks/proposalparty.md](./remarks/proposalparty.md)]

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