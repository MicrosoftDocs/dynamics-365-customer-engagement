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
<td>Whether a custom activity should appear in the activity menus in the Web application. 0 indicates that the custom activity doesn't appear; 1 indicates that it does appear.</td>
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
<tr>
<td>IsMailMergeEnabled</td>
<td>Boolean</td>
<td>Indicates whether mail merge is enabled for this entity.</td>
</tr>
<tr>
<td>IsManaged</td>
<td>Boolean</td>
<td>Indicates whether the entity is part of a managed solution.</td>
</tr>
<tr>
<td>IsOneNoteIntegrationEnabled</td>
<td>Boolean</td>
<td>Indicates whether OneNote integration is enabled for the entity.</td>
</tr>
<tr>
<td>IsOptimisticConcurrencyEnabled</td>
<td>Boolean</td>
<td>Indicates whether optimistic concurrency is enabled for the entity.</td>
</tr>
<tr>
<td>IsQuickCreateEnabled</td>
<td>Boolean</td>
<td>Indicates whether the entity is enabled for quick create forms.</td>
</tr>
<tr>
<td>IsStateModelAware</td>
<td>Boolean</td>
<td>Indicates whether the entity supports setting custom state transitions.</td>
</tr>
<tr>
<td>IsValidForAdvancedFind</td>
<td>Boolean</td>
<td>Indicates whether the entity is will be shown in Advanced Find.</td>
</tr>
<tr>
<td>IsVisibleInMobileClient</td>
<td>Boolean</td>
<td>Indicates whether Microsoft Dynamics 365 for tablets users can see data for this entity.</td>
</tr>
<tr>
<td>IsEnabledInUnifiedInterface</td>
<td>Boolean</td>
<td>Indicates whether the entity is enabled for Unified Interface.</td>
</tr>
<tr>
<td>LogicalCollectionName</td>
<td>String</td>
<td>The logical collection name.</td>
</tr>
<tr>
<td>LogicalName</td>
<td>String</td>
<td>The logical name for the entity.</td>
</tr>
<tr>
<td>ObjectTypeCode</td>
<td>Number</td>
<td>The entity type code.</td>
</tr>
<tr>
<td>OwnershipType</td>
<td>String</td>
<td>The ownership type for the entity: "UserOwned" or "OrganizationOwned".</td>
</tr>
<tr>
<td>PrimaryIdAttribute</td>
<td>String</td>
<td>The name of the attribute that is the primary id for the entity.</td>
</tr>
<tr>
<td>PrimaryImageAttribute</td>
<td>String</td>
<td>The name of the primary image attribute for an entity.</td>
</tr>
<tr>
<td>PrimaryNameAttribute</td>
<td>String</td>
<td>The name of the primary attribute for an entity.</td>
</tr>
<tr>
<td>Privileges</td>
<td>Array of objects</td>
<td>The privilege metadata for the entity where each object contains the following attributes to define the security privilege for access to an entity
:
<ul></td>
</tr>
<tr>
<td>Attributes</td>
<td>Collection of attribute metadata objects</td>
<td>The security privilege metadata for the entity that defines the access to an entity.</td>
</tr>


</table>

### Related topics

[Xrm.Utility](../xrm-utility.md)

