---
title: "CreateWorkflowFromTemplate Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1bf121f9-afd0-44c4-92c3-ad73f1e21a61
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CreateWorkflowFromTemplate Action
[!INCLUDE[./descriptions/createworkflowfromtemplate.md](./descriptions/createworkflowfromtemplate.md)]

The CreateWorkflowFromTemplate action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|WorkflowName|Edm.String|false|false|The name of the new workflow. Required. |
|WorkflowTemplateId|Edm.Guid|false|true|TODO: Add description for CreateWorkflowFromTemplate WorkflowTemplateId parameter.|

## Return Type
The CreateWorkflowFromTemplate action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[workflow EntityType](../entitytypes/workflow.md)|false|The new workflow|

## Entities
Use the CreateWorkflowFromTemplate action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[workflow Entitytype](../entitytypes/workflow.md)|[!INCLUDE[../entitytypes/descriptions/workflow.md](../entitytypes/descriptions/workflow.md)]|

[!INCLUDE[./remarks/createworkflowfromtemplate.md](./remarks/createworkflowfromtemplate.md)]

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