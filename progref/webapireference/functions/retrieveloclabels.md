---
title: "RetrieveLocLabels Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e5d6d06d-f872-4551-98cd-519393af4fe5
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveLocLabels Function
[!INCLUDE[./descriptions/retrieveloclabels.md](./descriptions/retrieveloclabels.md)]

The RetrieveLocLabels function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityMoniker|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|Specifies the entity.|
|AttributeName|Edm.String|false|false|The name of the attribute for which to retrieve the localized labels.|
|IncludeUnpublished|Edm.Boolean|false|true|Whether to include unpublished labels. |

## Return Type
The RetrieveLocLabels function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RetrieveLocLabelsResponse ComplexType](../complextypes/RetrieveLocLabelsResponse.md)|false|Contains the results from the RetrieveLocLabels function.|



[!INCLUDE[./remarks/retrieveloclabels.md](./remarks/retrieveloclabels.md)]

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