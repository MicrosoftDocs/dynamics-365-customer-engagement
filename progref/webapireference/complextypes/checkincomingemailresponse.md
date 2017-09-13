---
title: "CheckIncomingEmailResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c94b04d7-3303-4c0e-b58a-13dab57e8244
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CheckIncomingEmailResponse ComplexType
[!INCLUDE[./descriptions/checkincomingemailresponse.md](./descriptions/checkincomingemailresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ShouldDeliver|Edm.Boolean|true|true|Whether the message should be delivered to Microsoft Dynamics 365.| 
|ReasonCode|Edm.Int32|true|true|The reason for the result in the ShouldDeliver property.| 

## Used by
The following use the CheckIncomingEmailResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[CheckIncomingEmail Function](../functions/checkincomingemail.md)|ReturnType|[!INCLUDE[../functions/descriptions/checkincomingemail.md](../functions/descriptions/checkincomingemail.md)]|

[!INCLUDE[./remarks/checkincomingemailresponse.md](./remarks/checkincomingemailresponse.md)]

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