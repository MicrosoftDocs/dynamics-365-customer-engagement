---
title: "Decision rule set (msdyn_decisionruleset) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Decision rule set (msdyn_decisionruleset) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Decision rule set (msdyn_decisionruleset) table/entity reference (Microsoft Dynamics 365)

Contains list of rules to define demand and assignment behavior

## Messages

The following table lists the messages for the Decision rule set (msdyn_decisionruleset) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_decisionrulesets(*msdyn_decisionrulesetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_decisionrulesets<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_decisionrulesets(*msdyn_decisionrulesetid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_decisionrulesets(*msdyn_decisionrulesetid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_decisionrulesets<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_decisionrulesets(*msdyn_decisionrulesetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_decisionrulesets(*msdyn_decisionrulesetid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_decisionrulesets(*msdyn_decisionrulesetid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Decision rule set (msdyn_decisionruleset) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Decision rule set** |
| **DisplayCollectionName** | **Decision rule sets** |
| **SchemaName** | `msdyn_decisionruleset` |
| **CollectionSchemaName** | `msdyn_decisionrulesets` |
| **EntitySetName** | `msdyn_decisionrulesets`|
| **LogicalName** | `msdyn_decisionruleset` |
| **LogicalCollectionName** | `msdyn_decisionrulesets` |
| **PrimaryIdAttribute** | `msdyn_decisionrulesetid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_aibmodelid](#BKMK_msdyn_aibmodelid)
- [msdyn_authoringmode](#BKMK_msdyn_authoringmode)
- [msdyn_dataversecomponenttype](#BKMK_msdyn_dataversecomponenttype)
- [msdyn_decisionrulesetId](#BKMK_msdyn_decisionrulesetId)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_fetchxml](#BKMK_msdyn_fetchxml)
- [msdyn_inputcontractid](#BKMK_msdyn_inputcontractid)
- [msdyn_isinputcollection](#BKMK_msdyn_isinputcollection)
- [msdyn_mlmodeltype](#BKMK_msdyn_mlmodeltype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_outputcontractid](#BKMK_msdyn_outputcontractid)
- [msdyn_persistoutputdata](#BKMK_msdyn_persistoutputdata)
- [msdyn_refreshinputdata](#BKMK_msdyn_refreshinputdata)
- [msdyn_rulesetdefinition](#BKMK_msdyn_rulesetdefinition)
- [msdyn_rulesettype](#BKMK_msdyn_rulesettype)
- [msdyn_UniqueName](#BKMK_msdyn_UniqueName)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_aibmodelid"></a> msdyn_aibmodelid

|Property|Value|
|---|---|
|Description|**AI builder model for the ruleset**|
|DisplayName|**AI builder model**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aibmodelid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_aimodel|

### <a name="BKMK_msdyn_authoringmode"></a> msdyn_authoringmode

|Property|Value|
|---|---|
|Description|**Defines the authoring mode for the rule set**|
|DisplayName|**Authoring mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_authoringmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_rulesetauthoringmode`|

#### msdyn_authoringmode Choices/Options

|Value|Label|
|---|---|
|192350000|**Decision list**|

### <a name="BKMK_msdyn_dataversecomponenttype"></a> msdyn_dataversecomponenttype

|Property|Value|
|---|---|
|Description|**Defines the type for the dataverse component being used**|
|DisplayName|**Dataverse component type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dataversecomponenttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_dataversecomponenttype`|

#### msdyn_dataversecomponenttype Choices/Options

|Value|Label|
|---|---|
|0|**Unkown**|
|192350000|**Custom API**|

### <a name="BKMK_msdyn_decisionrulesetId"></a> msdyn_decisionrulesetId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Decision rule set**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_decisionrulesetid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description of the rule set record**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|500|

### <a name="BKMK_msdyn_fetchxml"></a> msdyn_fetchxml

|Property|Value|
|---|---|
|Description|**FetchXML for ruleset**|
|DisplayName|**FetchXML for ruleset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fetchxml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_inputcontractid"></a> msdyn_inputcontractid

|Property|Value|
|---|---|
|Description|**Input contract for the ruleset**|
|DisplayName|**Input contract**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inputcontractid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_decisioncontract|

### <a name="BKMK_msdyn_isinputcollection"></a> msdyn_isinputcollection

|Property|Value|
|---|---|
|Description|**Represent collection of similar type**|
|DisplayName|**Is input collection**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isinputcollection`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_decisionruleset_msdyn_isinputcollection`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_mlmodeltype"></a> msdyn_mlmodeltype

|Property|Value|
|---|---|
|Description|**Defines the type for ML model**|
|DisplayName|**ML model type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mlmodeltype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_mlmodeltype`|

#### msdyn_mlmodeltype Choices/Options

|Value|Label|
|---|---|
|192350000|**Skill based**|
|192350001|**Sentiment based**|
|192350002|**Effort based**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Name of the rule set record**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|200|

### <a name="BKMK_msdyn_outputcontractid"></a> msdyn_outputcontractid

|Property|Value|
|---|---|
|Description|**Output contract for the ruleset**|
|DisplayName|**Output contract**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outputcontractid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_decisioncontract|

### <a name="BKMK_msdyn_persistoutputdata"></a> msdyn_persistoutputdata

|Property|Value|
|---|---|
|Description|**Indicates whether to persist output data after rule evaluation**|
|DisplayName|**Persist Output Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_persistoutputdata`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_decisionruleset_msdyn_persistoutputdata`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_refreshinputdata"></a> msdyn_refreshinputdata

|Property|Value|
|---|---|
|Description|**Indicates whether to refresh input data before rule evaluation**|
|DisplayName|**Refresh Input Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_refreshinputdata`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_decisionruleset_msdyn_refreshinputdata`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_rulesetdefinition"></a> msdyn_rulesetdefinition

|Property|Value|
|---|---|
|Description|**Defines type of the rule set**|
|DisplayName|**Rule set definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rulesetdefinition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_rulesettype"></a> msdyn_rulesettype

|Property|Value|
|---|---|
|Description|**Defines type of the rule set**|
|DisplayName|**Rule set type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rulesettype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_decisionrulesettype`|

#### msdyn_rulesettype Choices/Options

|Value|Label|
|---|---|
|192350000|**Declarative**|
|192350001|**ML model based**|
|192350002|**Dataverse Components**|
|192350003|**Intelligent Conversation Distribution**|

### <a name="BKMK_msdyn_UniqueName"></a> msdyn_UniqueName

|Property|Value|
|---|---|
|Description|**Unique name for the ruleset record**|
|DisplayName|**Unique name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_uniquename`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Decision rule set**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_decisionruleset_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Decision rule set**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_decisionruleset_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyn_decisionruleset](#BKMK_business_unit_msdyn_decisionruleset)
- [lk_msdyn_decisionruleset_createdby](#BKMK_lk_msdyn_decisionruleset_createdby)
- [lk_msdyn_decisionruleset_createdonbehalfby](#BKMK_lk_msdyn_decisionruleset_createdonbehalfby)
- [lk_msdyn_decisionruleset_modifiedby](#BKMK_lk_msdyn_decisionruleset_modifiedby)
- [lk_msdyn_decisionruleset_modifiedonbehalfby](#BKMK_lk_msdyn_decisionruleset_modifiedonbehalfby)
- [msdyn_aimodel_msdyn_decisionruleset_aibmodelid](#BKMK_msdyn_aimodel_msdyn_decisionruleset_aibmodelid)
- [msdyn_decisioncontract_msdyn_decisionruleset_inputcontractId](#BKMK_msdyn_decisioncontract_msdyn_decisionruleset_inputcontractId)
- [msdyn_decisioncontract_msdyn_decisionruleset_outputcontractid](#BKMK_msdyn_decisioncontract_msdyn_decisionruleset_outputcontractid)
- [owner_msdyn_decisionruleset](#BKMK_owner_msdyn_decisionruleset)
- [team_msdyn_decisionruleset](#BKMK_team_msdyn_decisionruleset)
- [user_msdyn_decisionruleset](#BKMK_user_msdyn_decisionruleset)

### <a name="BKMK_business_unit_msdyn_decisionruleset"></a> business_unit_msdyn_decisionruleset

One-To-Many Relationship: [businessunit business_unit_msdyn_decisionruleset](businessunit.md#BKMK_business_unit_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_decisionruleset_createdby"></a> lk_msdyn_decisionruleset_createdby

One-To-Many Relationship: [systemuser lk_msdyn_decisionruleset_createdby](systemuser.md#BKMK_lk_msdyn_decisionruleset_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_decisionruleset_createdonbehalfby"></a> lk_msdyn_decisionruleset_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_decisionruleset_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_decisionruleset_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_decisionruleset_modifiedby"></a> lk_msdyn_decisionruleset_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_decisionruleset_modifiedby](systemuser.md#BKMK_lk_msdyn_decisionruleset_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_decisionruleset_modifiedonbehalfby"></a> lk_msdyn_decisionruleset_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_decisionruleset_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_decisionruleset_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_aimodel_msdyn_decisionruleset_aibmodelid"></a> msdyn_aimodel_msdyn_decisionruleset_aibmodelid

One-To-Many Relationship: [msdyn_aimodel msdyn_aimodel_msdyn_decisionruleset_aibmodelid](msdyn_aimodel.md#BKMK_msdyn_aimodel_msdyn_decisionruleset_aibmodelid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_aimodel`|
|ReferencedAttribute|`msdyn_aimodelid`|
|ReferencingAttribute|`msdyn_aibmodelid`|
|ReferencingEntityNavigationPropertyName|`msdyn_aibmodelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_decisioncontract_msdyn_decisionruleset_inputcontractId"></a> msdyn_decisioncontract_msdyn_decisionruleset_inputcontractId

One-To-Many Relationship: [msdyn_decisioncontract msdyn_decisioncontract_msdyn_decisionruleset_inputcontractId](msdyn_decisioncontract.md#BKMK_msdyn_decisioncontract_msdyn_decisionruleset_inputcontractId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_decisioncontract`|
|ReferencedAttribute|`msdyn_decisioncontractid`|
|ReferencingAttribute|`msdyn_inputcontractid`|
|ReferencingEntityNavigationPropertyName|`msdyn_inputcontractid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_decisioncontract_msdyn_decisionruleset_outputcontractid"></a> msdyn_decisioncontract_msdyn_decisionruleset_outputcontractid

One-To-Many Relationship: [msdyn_decisioncontract msdyn_decisioncontract_msdyn_decisionruleset_outputcontractid](msdyn_decisioncontract.md#BKMK_msdyn_decisioncontract_msdyn_decisionruleset_outputcontractid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_decisioncontract`|
|ReferencedAttribute|`msdyn_decisioncontractid`|
|ReferencingAttribute|`msdyn_outputcontractid`|
|ReferencingEntityNavigationPropertyName|`msdyn_outputcontractid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_decisionruleset"></a> owner_msdyn_decisionruleset

One-To-Many Relationship: [owner owner_msdyn_decisionruleset](owner.md#BKMK_owner_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_decisionruleset"></a> team_msdyn_decisionruleset

One-To-Many Relationship: [team team_msdyn_decisionruleset](team.md#BKMK_team_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_decisionruleset"></a> user_msdyn_decisionruleset

One-To-Many Relationship: [systemuser user_msdyn_decisionruleset](systemuser.md#BKMK_user_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_decisionruleset_AsyncOperations](#BKMK_msdyn_decisionruleset_AsyncOperations)
- [msdyn_decisionruleset_BulkDeleteFailures](#BKMK_msdyn_decisionruleset_BulkDeleteFailures)
- [msdyn_decisionruleset_DuplicateBaseRecord](#BKMK_msdyn_decisionruleset_DuplicateBaseRecord)
- [msdyn_decisionruleset_DuplicateMatchingRecord](#BKMK_msdyn_decisionruleset_DuplicateMatchingRecord)
- [msdyn_decisionruleset_MailboxTrackingFolders](#BKMK_msdyn_decisionruleset_MailboxTrackingFolders)
- [msdyn_decisionruleset_msdyn_assignmentconfigurationstep_rulesetid](#BKMK_msdyn_decisionruleset_msdyn_assignmentconfigurationstep_rulesetid)
- [msdyn_decisionruleset_msdyn_routingconfigurationstep_rulesetid](#BKMK_msdyn_decisionruleset_msdyn_routingconfigurationstep_rulesetid)
- [msdyn_decisionruleset_PrincipalObjectAttributeAccesses](#BKMK_msdyn_decisionruleset_PrincipalObjectAttributeAccesses)
- [msdyn_decisionruleset_ProcessSession](#BKMK_msdyn_decisionruleset_ProcessSession)
- [msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid](#BKMK_msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid)
- [msdyn_decisionruleset_SyncErrors](#BKMK_msdyn_decisionruleset_SyncErrors)
- [msdyn_msdyn_decisionruleset_msdyn_masterentityroutingconfiguration_rulesetid](#BKMK_msdyn_msdyn_decisionruleset_msdyn_masterentityroutingconfiguration_rulesetid)
- [msdyn_msdyn_decisionruleset_msdyn_swarmtemplate_skillattachmentrulesetid](#BKMK_msdyn_msdyn_decisionruleset_msdyn_swarmtemplate_skillattachmentrulesetid)
- [msdyn_msdyn_decisionruleset_msdyn_unifiedroutingdiagnostic_decisionrulesetid](#BKMK_msdyn_msdyn_decisionruleset_msdyn_unifiedroutingdiagnostic_decisionrulesetid)
- [msdyn_queue_decisionrulesetId](#BKMK_msdyn_queue_decisionrulesetId)
- [msdyn_templateruleset_draftruleset_msdyn_decisionruleset](#BKMK_msdyn_templateruleset_draftruleset_msdyn_decisionruleset)
- [msdyn_templateruleset_publishedruleset_msdyn_decisionruleset](#BKMK_msdyn_templateruleset_publishedruleset_msdyn_decisionruleset)

### <a name="BKMK_msdyn_decisionruleset_AsyncOperations"></a> msdyn_decisionruleset_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_decisionruleset_AsyncOperations](asyncoperation.md#BKMK_msdyn_decisionruleset_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_BulkDeleteFailures"></a> msdyn_decisionruleset_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_decisionruleset_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_decisionruleset_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_DuplicateBaseRecord"></a> msdyn_decisionruleset_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_decisionruleset_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_decisionruleset_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_DuplicateMatchingRecord"></a> msdyn_decisionruleset_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_decisionruleset_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_decisionruleset_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_MailboxTrackingFolders"></a> msdyn_decisionruleset_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_decisionruleset_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_decisionruleset_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_msdyn_assignmentconfigurationstep_rulesetid"></a> msdyn_decisionruleset_msdyn_assignmentconfigurationstep_rulesetid

Many-To-One Relationship: [msdyn_assignmentconfigurationstep msdyn_decisionruleset_msdyn_assignmentconfigurationstep_rulesetid](msdyn_assignmentconfigurationstep.md#BKMK_msdyn_decisionruleset_msdyn_assignmentconfigurationstep_rulesetid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentconfigurationstep`|
|ReferencingAttribute|`msdyn_rulesetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_msdyn_assignmentconfigurationstep_rulesetid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_msdyn_routingconfigurationstep_rulesetid"></a> msdyn_decisionruleset_msdyn_routingconfigurationstep_rulesetid

Many-To-One Relationship: [msdyn_routingconfigurationstep msdyn_decisionruleset_msdyn_routingconfigurationstep_rulesetid](msdyn_routingconfigurationstep.md#BKMK_msdyn_decisionruleset_msdyn_routingconfigurationstep_rulesetid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingconfigurationstep`|
|ReferencingAttribute|`msdyn_rulesetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_msdyn_routingconfigurationstep_rulesetid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_PrincipalObjectAttributeAccesses"></a> msdyn_decisionruleset_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_decisionruleset_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_decisionruleset_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_ProcessSession"></a> msdyn_decisionruleset_ProcessSession

Many-To-One Relationship: [processsession msdyn_decisionruleset_ProcessSession](processsession.md#BKMK_msdyn_decisionruleset_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid"></a> msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid

Many-To-One Relationship: [queue msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid](queue.md#BKMK_msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid)

|Property|Value|
|---|---|
|ReferencingEntity|`queue`|
|ReferencingAttribute|`msdyn_inqueueoverflowrulesetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_queue_msdyn_inqueueoverflowrulesetid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_decisionruleset_SyncErrors"></a> msdyn_decisionruleset_SyncErrors

Many-To-One Relationship: [syncerror msdyn_decisionruleset_SyncErrors](syncerror.md#BKMK_msdyn_decisionruleset_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_decisionruleset_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_decisionruleset_msdyn_masterentityroutingconfiguration_rulesetid"></a> msdyn_msdyn_decisionruleset_msdyn_masterentityroutingconfiguration_rulesetid

Many-To-One Relationship: [msdyn_masterentityroutingconfiguration msdyn_msdyn_decisionruleset_msdyn_masterentityroutingconfiguration_rulesetid](msdyn_masterentityroutingconfiguration.md#BKMK_msdyn_msdyn_decisionruleset_msdyn_masterentityroutingconfiguration_rulesetid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_masterentityroutingconfiguration`|
|ReferencingAttribute|`msdyn_rulesetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_decisionruleset_msdyn_masterentityroutingconfiguration_rulesetid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_decisionruleset_msdyn_swarmtemplate_skillattachmentrulesetid"></a> msdyn_msdyn_decisionruleset_msdyn_swarmtemplate_skillattachmentrulesetid

Many-To-One Relationship: [msdyn_swarmtemplate msdyn_msdyn_decisionruleset_msdyn_swarmtemplate_skillattachmentrulesetid](msdyn_swarmtemplate.md#BKMK_msdyn_msdyn_decisionruleset_msdyn_swarmtemplate_skillattachmentrulesetid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmtemplate`|
|ReferencingAttribute|`msdyn_skillattachmentrulesetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_decisionruleset_msdyn_swarmtemplate_skillattachmentrulesetid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_decisionruleset_msdyn_unifiedroutingdiagnostic_decisionrulesetid"></a> msdyn_msdyn_decisionruleset_msdyn_unifiedroutingdiagnostic_decisionrulesetid

Many-To-One Relationship: [msdyn_unifiedroutingdiagnostic msdyn_msdyn_decisionruleset_msdyn_unifiedroutingdiagnostic_decisionrulesetid](msdyn_unifiedroutingdiagnostic.md#BKMK_msdyn_msdyn_decisionruleset_msdyn_unifiedroutingdiagnostic_decisionrulesetid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingdiagnostic`|
|ReferencingAttribute|`msdyn_decisionrulesetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_decisionruleset_msdyn_unifiedroutingdiagnostic_decisionrulesetid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_queue_decisionrulesetId"></a> msdyn_queue_decisionrulesetId

Many-To-One Relationship: [queue msdyn_queue_decisionrulesetId](queue.md#BKMK_msdyn_queue_decisionrulesetId)

|Property|Value|
|---|---|
|ReferencingEntity|`queue`|
|ReferencingAttribute|`msdyn_prequeueoverflowrulesetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_queue_decisionrulesetId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templateruleset_draftruleset_msdyn_decisionruleset"></a> msdyn_templateruleset_draftruleset_msdyn_decisionruleset

Many-To-One Relationship: [msdyn_templateruleset msdyn_templateruleset_draftruleset_msdyn_decisionruleset](msdyn_templateruleset.md#BKMK_msdyn_templateruleset_draftruleset_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateruleset`|
|ReferencingAttribute|`msdyn_draftruleset`|
|ReferencedEntityNavigationPropertyName|`msdyn_templateruleset_draftruleset_msdyn_decisionruleset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templateruleset_publishedruleset_msdyn_decisionruleset"></a> msdyn_templateruleset_publishedruleset_msdyn_decisionruleset

Many-To-One Relationship: [msdyn_templateruleset msdyn_templateruleset_publishedruleset_msdyn_decisionruleset](msdyn_templateruleset.md#BKMK_msdyn_templateruleset_publishedruleset_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateruleset`|
|ReferencingAttribute|`msdyn_publishedruleset`|
|ReferencedEntityNavigationPropertyName|`msdyn_templateruleset_publishedruleset_msdyn_decisionruleset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

