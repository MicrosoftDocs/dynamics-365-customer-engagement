---
title: "PropagateByExpression Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 6b23d472-d5e0-415b-847f-fc8b629864f7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# PropagateByExpression Action
[!INCLUDE[./descriptions/propagatebyexpression.md](./descriptions/propagatebyexpression.md)]

The PropagateByExpression action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|QueryExpression|[QueryBase ComplexType](../complextypes/QueryBase.md)|true|true|The query criteria to select accounts, contacts, or leads for which activities are created. |
|FriendlyName|Edm.String|false|false|The user-identifiable name for the campaign. |
|ExecuteImmediately|Edm.Boolean|false|true|Indicates whether the activity is both created and executed. |
|Activity|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The activity to be distributed |
|TemplateId|Edm.Guid|false|true|The ID of the email template.|
|OwnershipOptions|[PropagationOwnershipOptions EnumType](../enumtypes/PropagationOwnershipOptions.md)|false|true|The ownership options for propagation. |
|PostWorkflowEvent|Edm.Boolean|false|true|Indicates whether an asynchronous job is used to distribute an activity, such as an email, fax, or letter, to the members of a list.|
|Owner|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The owner for the activity.|
|SendEmail|Edm.Boolean|false|true|Indicates whether to send an email about the new activity. |
|QueueId|Edm.Guid|true|true|The ID of the queue to which the created activities are added. |

## Return Type
The PropagateByExpression action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[PropagateByExpressionResponse ComplexType](../complextypes/PropagateByExpressionResponse.md)|false|Contains the response from the PropagateByExpression Action|

## Entities
Use the PropagateByExpression action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[email Entitytype](../entitytypes/email.md)|[!INCLUDE[../entitytypes/descriptions/email.md](../entitytypes/descriptions/email.md)]|

[!INCLUDE[./remarks/propagatebyexpression.md](./remarks/propagatebyexpression.md)]

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