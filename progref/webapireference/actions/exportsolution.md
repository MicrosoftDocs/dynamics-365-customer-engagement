---
title: "ExportSolution Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 50811842-4659-4d11-aca6-ddfb5f0a4dfc
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ExportSolution Action
[!INCLUDE[./descriptions/exportsolution.md](./descriptions/exportsolution.md)]

The ExportSolution action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SolutionName|Edm.String|false|false|The unique name of the solution. |
|Managed|Edm.Boolean|false|true|Indicates whether the solution should be exported as a managed solution. |
|TargetVersion|Edm.String|true|false|The version that the exported solution will support.  |
|ExportAutoNumberingSettings|Edm.Boolean|true|true|Indicates whether auto numbering settings should be included in the solution being exported.|
|ExportCalendarSettings|Edm.Boolean|true|true|Indicates whether calendar settings should be included in the solution being exported |
|ExportCustomizationSettings|Edm.Boolean|true|true| Indicates whether customization settings should be included in the solution being exported.  |
|ExportEmailTrackingSettings|Edm.Boolean|true|true|Indicates whether email tracking settings should be included in the solution being exported.  |
|ExportGeneralSettings|Edm.Boolean|true|true|Indicates whether general settings should be included in the solution being exported.|
|ExportMarketingSettings|Edm.Boolean|true|true|Indicates whether marketing settings should be included in the solution being exported. |
|ExportOutlookSynchronizationSettings|Edm.Boolean|true|true|Indicates whether outlook synchronization settings should be included in the solution being exported. |
|ExportRelationshipRoles|Edm.Boolean|true|true|Indicates whether relationship role settings should be included in the solution being exported. |
|ExportIsvConfig|Edm.Boolean|true|true|Indicates whether ISV.Config settings should be included in the solution being exported. |
|ExportSales|Edm.Boolean|true|true|Indicates whether sales settings should be included in the solution being exported.|
|ExportExternalApplications|Edm.Boolean|true|true|TODO: ExportSolution Action ExportExternalApplications Parameter Description |

## Return Type
The ExportSolution action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[ExportSolutionResponse ComplexType](../complextypes/ExportSolutionResponse.md)|false|Contains the response from the ExportSolution Action.|



[!INCLUDE[./remarks/exportsolution.md](./remarks/exportsolution.md)]

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