---
title: "RetrieveAvailableLanguagesResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 993b4605-baf6-4e62-bbbf-01f883714e52
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveAvailableLanguagesResponse ComplexType
[!INCLUDE[./descriptions/retrieveavailablelanguagesresponse.md](./descriptions/retrieveavailablelanguagesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|LocaleIds|Collection(Edm.Int32)||true| An array of locale ID values representing the language packs that are installed on the server. | 

## Used by
The following use the RetrieveAvailableLanguagesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveAvailableLanguages Function](../functions/retrieveavailablelanguages.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrieveavailablelanguages.md](../functions/descriptions/retrieveavailablelanguages.md)]|

[!INCLUDE[./remarks/retrieveavailablelanguagesresponse.md](./remarks/retrieveavailablelanguagesresponse.md)]

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