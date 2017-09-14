---
title: "ImportTranslation Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 7d76745e-07c3-4e29-bcb1-08cb7e17ff33
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ImportTranslation Action
[!INCLUDE[./descriptions/importtranslation.md](./descriptions/importtranslation.md)]

The ImportTranslation action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|TranslationFile|Edm.Binary|false|true|The compressed translations file.  |
|ImportJobId|Edm.Guid|false|true|ID of the import job that will be created to perform the import.|





[!INCLUDE[./remarks/importtranslation.md](./remarks/importtranslation.md)]

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