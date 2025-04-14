---
title: "Sequence (msdyn_sequence) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sequence (msdyn_sequence) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sequence (msdyn_sequence) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Sequence (msdyn_sequence) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_sequences(*msdyn_sequenceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_sequences<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_sequences(*msdyn_sequenceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_sequences(*msdyn_sequenceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_sequences<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_sequences(*msdyn_sequenceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_sequences(*msdyn_sequenceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_sequences(*msdyn_sequenceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sequence (msdyn_sequence) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sequence** |
| **DisplayCollectionName** | **Sequences** |
| **SchemaName** | `msdyn_sequence` |
| **CollectionSchemaName** | `msdyn_sequences` |
| **EntitySetName** | `msdyn_sequences`|
| **LogicalName** | `msdyn_sequence` |
| **LogicalCollectionName** | `msdyn_sequences` |
| **PrimaryIdAttribute** | `msdyn_sequenceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_AnalyticsAvailable](#BKMK_msdyn_AnalyticsAvailable)
- [msdyn_analyticsversion](#BKMK_msdyn_analyticsversion)
- [msdyn_assignsequencecondition](#BKMK_msdyn_assignsequencecondition)
- [msdyn_assignsequencefieldname](#BKMK_msdyn_assignsequencefieldname)
- [msdyn_assignsequencetype](#BKMK_msdyn_assignsequencetype)
- [msdyn_cjodefinition](#BKMK_msdyn_cjodefinition)
- [msdyn_cjodefinitionstate](#BKMK_msdyn_cjodefinitionstate)
- [msdyn_definition](#BKMK_msdyn_definition)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_iswaittimecomputationenabledatsequencelevel](#BKMK_msdyn_iswaittimecomputationenabledatsequencelevel)
- [msdyn_maxstepcount](#BKMK_msdyn_maxstepcount)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_orchestratorversion](#BKMK_msdyn_orchestratorversion)
- [msdyn_ParentSequence](#BKMK_msdyn_ParentSequence)
- [msdyn_regardingentitydisplayname](#BKMK_msdyn_regardingentitydisplayname)
- [msdyn_regardingEntityName](#BKMK_msdyn_regardingEntityName)
- [msdyn_SequenceExitCriterion](#BKMK_msdyn_SequenceExitCriterion)
- [msdyn_sequenceId](#BKMK_msdyn_sequenceId)
- [msdyn_SequenceStats180d](#BKMK_msdyn_SequenceStats180d)
- [msdyn_SequenceStats1y](#BKMK_msdyn_SequenceStats1y)
- [msdyn_SequenceStats2y](#BKMK_msdyn_SequenceStats2y)
- [msdyn_SequenceStats30d](#BKMK_msdyn_SequenceStats30d)
- [msdyn_SequenceStats90d](#BKMK_msdyn_SequenceStats90d)
- [msdyn_template](#BKMK_msdyn_template)
- [msdyn_totaltasks](#BKMK_msdyn_totaltasks)
- [msdyn_Type](#BKMK_msdyn_Type)
- [msdyn_Version](#BKMK_msdyn_Version)
- [msdyn_VersionDescription](#BKMK_msdyn_VersionDescription)
- [msdyn_workflowid](#BKMK_msdyn_workflowid)
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

### <a name="BKMK_msdyn_AnalyticsAvailable"></a> msdyn_AnalyticsAvailable

|Property|Value|
|---|---|
|Description||
|DisplayName|**AnalyticsAvailable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_analyticsavailable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_sequence_msdyn_analyticsavailable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_analyticsversion"></a> msdyn_analyticsversion

|Property|Value|
|---|---|
|Description|**Information about analytics version of the sequence**|
|DisplayName|**Analytics Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_analyticsversion`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_assignsequencecondition"></a> msdyn_assignsequencecondition

|Property|Value|
|---|---|
|Description||
|DisplayName|**Assign Sequence Condition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignsequencecondition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_assignsequencefieldname"></a> msdyn_assignsequencefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Assign Sequence Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignsequencefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_assignsequencetype"></a> msdyn_assignsequencetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Assign Sequence Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignsequencetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_assignsequencetype_options`|

#### msdyn_assignsequencetype Choices/Options

|Value|Label|
|---|---|
|0|**RecordOwner**|
|1|**RecordField**|
|2|**OwnerTeam**|
|3|**AccessTeam**|
|4|**CurrentUser**|

### <a name="BKMK_msdyn_cjodefinition"></a> msdyn_cjodefinition

|Property|Value|
|---|---|
|Description||
|DisplayName|**CJO Definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cjodefinition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_cjodefinitionstate"></a> msdyn_cjodefinitionstate

|Property|Value|
|---|---|
|Description|**Depicts whether CJO definition is updated or not**|
|DisplayName|**CJO definition state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cjodefinitionstate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_cjodefinitionstate_optionset`|
|DefaultValue|False|
|True Label|Updated|
|False Label|Not Updated|

### <a name="BKMK_msdyn_definition"></a> msdyn_definition

|Property|Value|
|---|---|
|Description||
|DisplayName|**Definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_definition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_iswaittimecomputationenabledatsequencelevel"></a> msdyn_iswaittimecomputationenabledatsequencelevel

|Property|Value|
|---|---|
|Description|**Indicates whether wait time computation setting is enabled for the sequence to honor seller availability based on bussiness days.**|
|DisplayName|**Wait time computation setting for the sequence.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iswaittimecomputationenabledatsequencelevel`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_sequence_msdyn_iswaittimecomputationenabledatsequencelevel`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_maxstepcount"></a> msdyn_maxstepcount

|Property|Value|
|---|---|
|Description|**The max step count for the sequence.**|
|DisplayName|**Max. Steps**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_maxstepcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|400|
|MinValue|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_msdyn_orchestratorversion"></a> msdyn_orchestratorversion

|Property|Value|
|---|---|
|Description|**Select version of sequence orchestrator**|
|DisplayName|**Sequence orchestrator version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_orchestratorversion`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_orchestratorversion_options`|

#### msdyn_orchestratorversion Choices/Options

|Value|Label|
|---|---|
|1|**V1**|
|2|**V2**|

### <a name="BKMK_msdyn_ParentSequence"></a> msdyn_ParentSequence

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Parent Sequence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentsequence`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_sequence|

### <a name="BKMK_msdyn_regardingentitydisplayname"></a> msdyn_regardingentitydisplayname

|Property|Value|
|---|---|
|Description|**The display name information about record to which this sequence could be associated**|
|DisplayName|**Record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentitydisplayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_regardingEntityName"></a> msdyn_regardingEntityName

|Property|Value|
|---|---|
|Description|**The logical name of regarding entity**|
|DisplayName|**Regarding Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentityname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SequenceExitCriterion"></a> msdyn_SequenceExitCriterion

|Property|Value|
|---|---|
|Description|**Information about various exit criterion for a sequence**|
|DisplayName|**Sequence Exit Criterion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequenceexitcriterion`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_sequenceId"></a> msdyn_sequenceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sequence**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_sequenceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SequenceStats180d"></a> msdyn_SequenceStats180d

|Property|Value|
|---|---|
|Description|**Sequence Stats 180d**|
|DisplayName|**Sequence Stats 180d**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_SequenceStats180d`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SequenceStats1y"></a> msdyn_SequenceStats1y

|Property|Value|
|---|---|
|Description|**Sequence Stats 1y**|
|DisplayName|**Sequence Stats 1y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_SequenceStats1y`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SequenceStats2y"></a> msdyn_SequenceStats2y

|Property|Value|
|---|---|
|Description|**Sequence Stats 2y**|
|DisplayName|**Sequence Stats 2y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_SequenceStats2y`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SequenceStats30d"></a> msdyn_SequenceStats30d

|Property|Value|
|---|---|
|Description|**Sequence Stats 30d**|
|DisplayName|**Sequence Stats 30d**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_SequenceStats30d`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SequenceStats90d"></a> msdyn_SequenceStats90d

|Property|Value|
|---|---|
|Description|**Sequence Stats 90d**|
|DisplayName|**Sequence Stats 90d**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_SequenceStats90d`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_template"></a> msdyn_template

|Property|Value|
|---|---|
|Description|**Sequence template id**|
|DisplayName|**Sequence template id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_template`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_totaltasks"></a> msdyn_totaltasks

|Property|Value|
|---|---|
|Description|**Total task count of sequence record**|
|DisplayName|**Steps**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totaltasks`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|40|
|MinValue|0|

### <a name="BKMK_msdyn_Type"></a> msdyn_Type

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sequence_type_options`|

#### msdyn_Type Choices/Options

|Value|Label|
|---|---|
|0|**Definition**|
|1|**Activation**|

### <a name="BKMK_msdyn_Version"></a> msdyn_Version

|Property|Value|
|---|---|
|Description|**Version of the sequence**|
|DisplayName|**Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_version`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|500|
|MinValue|1|

### <a name="BKMK_msdyn_VersionDescription"></a> msdyn_VersionDescription

|Property|Value|
|---|---|
|Description|**Information about this version of the sequence**|
|DisplayName|**Version Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_versiondescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_workflowid"></a> msdyn_workflowid

|Property|Value|
|---|---|
|Description|**Workflow identifier**|
|DisplayName|**Workflow Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_workflowid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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
|Description|**Status of the Sequence**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sequence_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Inactive**<br />DefaultStatus: 1<br />InvariantName: `Inactive`|
|1|Label: **Active**<br />DefaultStatus: 2<br />InvariantName: `Active`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sequence**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sequence_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Inactive**<br />State:0<br />TransitionData: None|
|2|Label: **Active**<br />State:1<br />TransitionData: None|
|3|Label: **Revision**<br />State:1<br />TransitionData: None|

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
- [msdyn_SequenceRecords](#BKMK_msdyn_SequenceRecords)
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
|DisplayName|**Created by**|
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
|DisplayName|**Created**|
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
|DisplayName|**Modified by**|
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
|DisplayName|**Last modified**|
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

### <a name="BKMK_msdyn_SequenceRecords"></a> msdyn_SequenceRecords

|Property|Value|
|---|---|
|Description||
|DisplayName|**SequenceRecords**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencerecords`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

- [business_unit_msdyn_sequence](#BKMK_business_unit_msdyn_sequence)
- [lk_msdyn_sequence_createdby](#BKMK_lk_msdyn_sequence_createdby)
- [lk_msdyn_sequence_createdonbehalfby](#BKMK_lk_msdyn_sequence_createdonbehalfby)
- [lk_msdyn_sequence_modifiedby](#BKMK_lk_msdyn_sequence_modifiedby)
- [lk_msdyn_sequence_modifiedonbehalfby](#BKMK_lk_msdyn_sequence_modifiedonbehalfby)
- [msdyn_sequence_parentsequence](#BKMK_msdyn_sequence_parentsequence-many-to-one)
- [owner_msdyn_sequence](#BKMK_owner_msdyn_sequence)
- [team_msdyn_sequence](#BKMK_team_msdyn_sequence)
- [user_msdyn_sequence](#BKMK_user_msdyn_sequence)

### <a name="BKMK_business_unit_msdyn_sequence"></a> business_unit_msdyn_sequence

One-To-Many Relationship: [businessunit business_unit_msdyn_sequence](businessunit.md#BKMK_business_unit_msdyn_sequence)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequence_createdby"></a> lk_msdyn_sequence_createdby

One-To-Many Relationship: [systemuser lk_msdyn_sequence_createdby](systemuser.md#BKMK_lk_msdyn_sequence_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequence_createdonbehalfby"></a> lk_msdyn_sequence_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sequence_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_sequence_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequence_modifiedby"></a> lk_msdyn_sequence_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_sequence_modifiedby](systemuser.md#BKMK_lk_msdyn_sequence_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sequence_modifiedonbehalfby"></a> lk_msdyn_sequence_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sequence_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_sequence_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequence_parentsequence-many-to-one"></a> msdyn_sequence_parentsequence

One-To-Many Relationship: [msdyn_sequence msdyn_sequence_parentsequence](#BKMK_msdyn_sequence_parentsequence-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequence`|
|ReferencedAttribute|`msdyn_sequenceid`|
|ReferencingAttribute|`msdyn_parentsequence`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentSequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_sequence"></a> owner_msdyn_sequence

One-To-Many Relationship: [owner owner_msdyn_sequence](owner.md#BKMK_owner_msdyn_sequence)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_sequence"></a> team_msdyn_sequence

One-To-Many Relationship: [team team_msdyn_sequence](team.md#BKMK_team_msdyn_sequence)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_sequence"></a> user_msdyn_sequence

One-To-Many Relationship: [systemuser user_msdyn_sequence](systemuser.md#BKMK_user_msdyn_sequence)

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

- [msdyn_msdyn_sequence_msdyn_segment_Sequence](#BKMK_msdyn_msdyn_sequence_msdyn_segment_Sequence)
- [msdyn_sequence_appliedsequenceinstance](#BKMK_msdyn_sequence_appliedsequenceinstance)
- [msdyn_sequence_AsyncOperations](#BKMK_msdyn_sequence_AsyncOperations)
- [msdyn_sequence_BulkDeleteFailures](#BKMK_msdyn_sequence_BulkDeleteFailures)
- [msdyn_sequence_connections1](#BKMK_msdyn_sequence_connections1)
- [msdyn_sequence_connections2](#BKMK_msdyn_sequence_connections2)
- [msdyn_sequence_DuplicateBaseRecord](#BKMK_msdyn_sequence_DuplicateBaseRecord)
- [msdyn_sequence_DuplicateMatchingRecord](#BKMK_msdyn_sequence_DuplicateMatchingRecord)
- [msdyn_sequence_MailboxTrackingFolders](#BKMK_msdyn_sequence_MailboxTrackingFolders)
- [msdyn_sequence_parentsequence](#BKMK_msdyn_sequence_parentsequence-one-to-many)
- [msdyn_sequence_PrincipalObjectAttributeAccesses](#BKMK_msdyn_sequence_PrincipalObjectAttributeAccesses)
- [msdyn_sequence_ProcessSession](#BKMK_msdyn_sequence_ProcessSession)
- [msdyn_sequence_sequencestat](#BKMK_msdyn_sequence_sequencestat)
- [msdyn_sequence_SyncErrors](#BKMK_msdyn_sequence_SyncErrors)
- [msdyn_sequenceparent](#BKMK_msdyn_sequenceparent)

### <a name="BKMK_msdyn_msdyn_sequence_msdyn_segment_Sequence"></a> msdyn_msdyn_sequence_msdyn_segment_Sequence

Many-To-One Relationship: [msdyn_segment msdyn_msdyn_sequence_msdyn_segment_Sequence](msdyn_segment.md#BKMK_msdyn_msdyn_sequence_msdyn_segment_Sequence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_segment`|
|ReferencingAttribute|`msdyn_sequence`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_sequence_msdyn_segment_Sequence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_appliedsequenceinstance"></a> msdyn_sequence_appliedsequenceinstance

Many-To-One Relationship: [msdyn_sequencetarget msdyn_sequence_appliedsequenceinstance](msdyn_sequencetarget.md#BKMK_msdyn_sequence_appliedsequenceinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`msdyn_appliedsequenceinstance`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_appliedsequenceinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_AsyncOperations"></a> msdyn_sequence_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_sequence_AsyncOperations](asyncoperation.md#BKMK_msdyn_sequence_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_BulkDeleteFailures"></a> msdyn_sequence_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_sequence_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_sequence_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_connections1"></a> msdyn_sequence_connections1

Many-To-One Relationship: [connection msdyn_sequence_connections1](connection.md#BKMK_msdyn_sequence_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_connections2"></a> msdyn_sequence_connections2

Many-To-One Relationship: [connection msdyn_sequence_connections2](connection.md#BKMK_msdyn_sequence_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_DuplicateBaseRecord"></a> msdyn_sequence_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_sequence_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_sequence_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_DuplicateMatchingRecord"></a> msdyn_sequence_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_sequence_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_sequence_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_MailboxTrackingFolders"></a> msdyn_sequence_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_sequence_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_sequence_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_parentsequence-one-to-many"></a> msdyn_sequence_parentsequence

Many-To-One Relationship: [msdyn_sequence msdyn_sequence_parentsequence](#BKMK_msdyn_sequence_parentsequence-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequence`|
|ReferencingAttribute|`msdyn_parentsequence`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_parentsequence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_PrincipalObjectAttributeAccesses"></a> msdyn_sequence_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_sequence_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_sequence_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_ProcessSession"></a> msdyn_sequence_ProcessSession

Many-To-One Relationship: [processsession msdyn_sequence_ProcessSession](processsession.md#BKMK_msdyn_sequence_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_sequencestat"></a> msdyn_sequence_sequencestat

Many-To-One Relationship: [msdyn_sequencestat msdyn_sequence_sequencestat](msdyn_sequencestat.md#BKMK_msdyn_sequence_sequencestat)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencestat`|
|ReferencingAttribute|`msdyn_sequence`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_sequencestat`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequence_SyncErrors"></a> msdyn_sequence_SyncErrors

Many-To-One Relationship: [syncerror msdyn_sequence_SyncErrors](syncerror.md#BKMK_msdyn_sequence_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequence_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequenceparent"></a> msdyn_sequenceparent

Many-To-One Relationship: [msdyn_sequencetarget msdyn_sequenceparent](msdyn_sequencetarget.md#BKMK_msdyn_sequenceparent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`msdyn_parentsequence`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequenceparent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_salestag_msdyn_sequence"></a> msdyn_salestag_msdyn_sequence

See [msdyn_salestag msdyn_salestag_msdyn_sequence Many-To-Many Relationship](msdyn_salestag.md#BKMK_msdyn_salestag_msdyn_sequence)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_salestag_msdyn_sequence`|
|IsCustomizable|True|
|SchemaName|`msdyn_salestag_msdyn_sequence`|
|IntersectAttribute|`msdyn_sequenceid`|
|NavigationPropertyName|`msdyn_salestag_msdyn_sequence`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

