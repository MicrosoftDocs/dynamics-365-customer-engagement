---
title: "getEntityMetadata (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 89123cde-7c66-4c7d-94e4-e287285019f8
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getEntityMetadata

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getEntityMetadata-description.md](./includes/getEntityMetadata-description.md)] 

## Syntax

`Xrm.Utility.getEntityMetadata(entityName,attributes).then(successCallback, errorCallback)`

## Parameters

|Name |Type |Required |Description |
|---|---|---|---|
|entityName|String|Yes|The logical name of the entity.|
|attributes|array of strings|No|The attributes to get metadata for.|

## Returns

**Type**: Object

**Description**: An object containing the entity metadata information with the following attributes.

<table>
<tr>
<th>ActivityTypeMask</th>
<th>Number</th>
<th>Description</th>
</tr>
<tr>
<td><code>AutoRouteToOwnerQueue</code></td>
<td>Boolean</td>
<td>Indicates whether to automatically move records to the owner’s default queue when a record of this type is created or assigned. </td>
</tr>

<tr>
<td><code>CanEnableSyncToExternalSearchIndex</code></td>
<td>Boolean</td>
<td>For internal use only.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>String</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>Description</code></td>
<td>String</td>
<td>Description for the entity.</td>
</tr>
<tr>
<td><code>DisplayCollectionName</code></td>
<td>String</td>
<td>Plural display name for the entity.</td>
</tr>
<tr>
<td><code>DisplayName</code></td>
<td>String</td>
<td>Display name for the entity.</td>
</tr>
<tr>
<td><code>EnforceStateTransitions</code></td>
<td>Boolean</td>
<td>Indicates whether the entity will enforce custom state transitions.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td><code>CanTriggerWorkflow</code></td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>


</table>

### Related topics

[Xrm.Utility](../xrm-utility.md)

