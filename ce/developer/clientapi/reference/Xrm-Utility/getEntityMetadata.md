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
<th>Attribute Name</th>
<th>Number</th>
<th>Description</th>
</tr>
<tr>
<td>ActivityTypeMask</td>
<td>Number</td>
<td>Whether a custom activity should appear in the activity menus in the Web application.</td>
</tr>
<tr>
<td>AutoRouteToOwnerQueue</td>
<td>Boolean</td>
<td>Indicates whether to automatically move records to the owner’s default queue when a record of this type is created or assigned. </td>
</tr>

<tr>
<td>CanEnableSyncToExternalSearchIndex</td>
<td>Boolean</td>
<td>For internal use only.</td>
</tr>
<tr>
<td>CanTriggerWorkflow</td>
<td>Boolean</td>
<td>Indicates whether the entity can trigger a workflow process.</td>
</tr>
<tr>
<td>Description</td>
<td>String</td>
<td>Description for the entity.</td>
</tr>
<tr>
<td>DisplayCollectionName</td>
<td>String</td>
<td>Plural display name for the entity.</td>
</tr>
<tr>
<td>DisplayName</td>
<td>String</td>
<td>Display name for the entity.</td>
</tr>
<tr>
<td>EnforceStateTransitions</td>
<td>Boolean</td>
<td>Indicates whether the entity will enforce custom state transitions.</td>
</tr>
<tr>
<td>EntityColor</td>
<td>String</td>
<td>The hexadecimal code to represent the color to be used for this entity in the application.</td>
</tr>
<tr>
<td>EntitySetName</td>
<td>String</td>
<td>The name of the Web API entity set for this entity.</td>
</tr>
<tr>
<td>HasActivities</td>
<td>Boolean</td>
<td>Indicates whether activities are associated with this entity.</td>
</tr>
<tr>
<td>IsActivity</td>
<td>Boolean</td>
<td>Indicates whether the entity is an activity.</td>
</tr>
<tr>
<td>IsActivityParty</td>
<td>Boolean</td>
<td>Indicates whether the email messages can be sent to an email address stored in a record of this type.</td>
</tr>
<tr>
<td>IsBusinessProcessEnabled</td>
<td>Boolean</td>
<td>Indicates whether the entity is enabled for business process flows.</td>
</tr>
<tr>
<td>IsBPFEntity</td>
<td>Boolean</td>
<td>Indicates whether the entity is a business process flow entity.</td>
</tr>
<tr>
<td>IsChildEntity</td>
<td>Boolean</td>
<td>Indicates whether the entity is a child entity.</td>
</tr>
<tr>
<td>IsConnectionsEnabled</td>
<td>Boolean</td>
<td>Indicates whether connections are enabled for this entity.</td>
</tr>
<tr>
<td>IsCustomEntity</td>
<td>Boolean</td>
<td>Indicates whether the entity is a custom entity.</td>
</tr>
<tr>
<td>IsCustomizable</td>
<td>Boolean</td>
<td>Indicates whether the entity is customizable.</td>
</tr>
<tr>
<td>IsDocumentManagementEnabled</td>
<td>Boolean</td>
<td>Indicates whether document management is enabled.</td>
</tr>
<tr>
<td>IsDocumentRecommendationsEnabled</td>
<td>Boolean</td>
<td>Indicates whether the documemt recommendations is enabled.</td>
</tr>
<tr>
<td>IsDuplicateDetectionEnabled</td>
<td>Boolean</td>
<td>Indicates whether duplicate detection is enabled.</td>
</tr>
<tr>
<td>IsEnabledForCharts</td>
<td>Boolean</td>
<td>Indicates whether charts are enabled.</td>
</tr>
<tr>
<td>IsImportable</td>
<td>Boolean</td>
<td>Indicates whether the entity can be imported using the Import Wizard.</td>
</tr>
<tr>
<td>IsInteractionCentricEnabled</td>
<td>Boolean</td>
<td>Indicates the entity is enabled for interactive experience.</td>
</tr>
<tr>
<td>IsKnowledgeManagementEnabled</td>
<td>Boolean</td>
<td>Indicates whether knowledge management is enabled for the entity.</td>
</tr>


</table>

### Related topics

[Xrm.Utility](../xrm-utility.md)

