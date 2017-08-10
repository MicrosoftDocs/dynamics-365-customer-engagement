---
title: "RetrieveDeprovisionedLanguagesResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 38496ef4-bb1e-4299-acd3-100ac82feb8c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveDeprovisionedLanguagesResponse ComplexType
[!INCLUDE[./descriptions/retrievedeprovisionedlanguagesresponse.md](./descriptions/retrievedeprovisionedlanguagesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|RetrieveDeprovisionedLanguages|Collection(Edm.Int32)||true| An array of locale ID values representing disabled language packs that are installed on the server.| 

## Used by
The following use the RetrieveDeprovisionedLanguagesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveDeprovisionedLanguages Function](../functions/retrievedeprovisionedlanguages.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrievedeprovisionedlanguages.md](../functions/descriptions/retrievedeprovisionedlanguages.md)]|

[!INCLUDE[./remarks/retrievedeprovisionedlanguagesresponse.md](./remarks/retrievedeprovisionedlanguagesresponse.md)]

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