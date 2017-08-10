---
title: "ImportFieldTranslation Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: dcc3cf8b-067e-4d7b-bb63-1f21bb07ed41
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ImportFieldTranslation Action
[!INCLUDE[./descriptions/importfieldtranslation.md](./descriptions/importfieldtranslation.md)]

The ImportFieldTranslation action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|TranslationFile|Edm.Binary|false|true|The compressed translations file.|

## Return Type
The ImportFieldTranslation action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[importjob EntityType](../entitytypes/importjob.md)|false|The import job that will be created to perform this import.|



[!INCLUDE[./remarks/importfieldtranslation.md](./remarks/importfieldtranslation.md)]

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