---
title: "RetrieveLicenseInfoResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c112bc8f-75a1-483d-9135-81bdb5fc1a12
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveLicenseInfoResponse ComplexType
[!INCLUDE[./descriptions/retrievelicenseinforesponse.md](./descriptions/retrievelicenseinforesponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AvailableCount|Edm.Int32|true|true|The number of unused licenses. | 
|GrantedLicenseCount|Edm.Int32|true|true|The number of licenses that have been granted to users.| 

## Used by
The following use the RetrieveLicenseInfoResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveLicenseInfo Function](../functions/retrievelicenseinfo.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrievelicenseinfo.md](../functions/descriptions/retrievelicenseinfo.md)]|

[!INCLUDE[./remarks/retrievelicenseinforesponse.md](./remarks/retrievelicenseinforesponse.md)]

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