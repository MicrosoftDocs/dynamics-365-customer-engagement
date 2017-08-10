---
title: "ImportSolution Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: fcae8173-c927-45a0-9787-e52f0751028c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ImportSolution Action
[!INCLUDE[./descriptions/importsolution.md](./descriptions/importsolution.md)]

The ImportSolution action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OverwriteUnmanagedCustomizations|Edm.Boolean|false|true|Indicates whether any unmanaged customizations that have been applied over existing managed solution components should be overwritten |
|PublishWorkflows|Edm.Boolean|false|true|Indicates whether any processes (workflows) included in the solution should be activated after they are imported.|
|CustomizationFile|Edm.Binary|false|true|The compressed solutions file to import. |
|ImportJobId|Edm.Guid|false|true|The ID of the import job that will be created to perform the import.  |
|ConvertToManaged|Edm.Boolean|true|true|Converts any matching unmanaged customizations into your managed solution.  |
|SkipProductUpdateDependencies|Edm.Boolean|true|true|Indicates whether enforcement of dependencies related to product updates should be skipped.|
|HoldingSolution|Edm.Boolean|true|true|TODO: ImportSolution Action HoldingSolution Parameter Description |





[!INCLUDE[./remarks/importsolution.md](./remarks/importsolution.md)]

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