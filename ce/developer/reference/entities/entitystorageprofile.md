---
title: "Entity Storage Profile (entitystorageprofile) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Entity Storage Profile (entitystorageprofile) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Entity Storage Profile (entitystorageprofile) table/entity reference (Microsoft Dynamics 365)

Precomputed entity-level storage metrics and cascade fan-out averages for the Storage Advisor.

## Messages

The following table lists the messages for the Entity Storage Profile (entitystorageprofile) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /entitystorageprofiles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /entitystorageprofiles(*entitystorageprofileid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Retrieve`<br />Event: True |`GET` /entitystorageprofiles(*entitystorageprofileid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /entitystorageprofiles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /entitystorageprofiles(*entitystorageprofileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /entitystorageprofiles(*entitystorageprofileid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /entitystorageprofiles(*entitystorageprofileid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Entity Storage Profile (entitystorageprofile) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Entity Storage Profile** |
| **DisplayCollectionName** | **Entity Storage Profiles** |
| **SchemaName** | `entitystorageprofile` |
| **CollectionSchemaName** | `entitystorageprofiles` |
| **EntitySetName** | `entitystorageprofiles`|
| **LogicalName** | `entitystorageprofile` |
| **LogicalCollectionName** | `entitystorageprofiles` |
| **PrimaryIdAttribute** | `entitystorageprofileid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActionId](#BKMK_ActionId)
- [ActionType](#BKMK_ActionType)
- [AvgCascadeRecordCount](#BKMK_AvgCascadeRecordCount)
- [AvgCascadeSizeBytes](#BKMK_AvgCascadeSizeBytes)
- [AvgRecordSizeBytes](#BKMK_AvgRecordSizeBytes)
- [CascadeEntityBreakdown](#BKMK_CascadeEntityBreakdown)
- [EntityId](#BKMK_EntityId)
- [EntityLogicalName](#BKMK_EntityLogicalName)
- [EntityObjectTypeCode](#BKMK_EntityObjectTypeCode)
- [entitystorageprofileId](#BKMK_entitystorageprofileId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsLiked](#BKMK_IsLiked)
- [LastEvaluatedOn](#BKMK_LastEvaluatedOn)
- [LogicalCollectionName](#BKMK_LogicalCollectionName)
- [MatchingRecordCount](#BKMK_MatchingRecordCount)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [PolicyCriterionId](#BKMK_PolicyCriterionId)
- [SampleSize](#BKMK_SampleSize)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalDataSizeBytes](#BKMK_TotalDataSizeBytes)
- [TotalIndexSizeBytes](#BKMK_TotalIndexSizeBytes)
- [TotalRecordCount](#BKMK_TotalRecordCount)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ActionId"></a> ActionId

|Property|Value|
|---|---|
|Description|**Identifier of the action (e.g. bulk delete job or retention policy) associated with this recommendation.**|
|DisplayName|**Action Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ActionType"></a> ActionType

|Property|Value|
|---|---|
|Description|**Type of action taken on this recommendation (Delete or Retain).**|
|DisplayName|**Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`entitystorageprofile_actiontype`|

#### ActionType Choices/Options

|Value|Label|
|---|---|
|0|**Delete**|
|1|**Retain**|

### <a name="BKMK_AvgCascadeRecordCount"></a> AvgCascadeRecordCount

|Property|Value|
|---|---|
|Description|**Average number of cascade-related records per parent record.**|
|DisplayName|**Avg Cascade Record Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`avgcascaderecordcount`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_AvgCascadeSizeBytes"></a> AvgCascadeSizeBytes

|Property|Value|
|---|---|
|Description|**Average total bytes freed per parent delete including cascade.**|
|DisplayName|**Avg Cascade Size (Bytes)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`avgcascadesizebytes`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_AvgRecordSizeBytes"></a> AvgRecordSizeBytes

|Property|Value|
|---|---|
|Description|**Average bytes per row including data and index overhead.**|
|DisplayName|**Average Record Size (Bytes)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`avgrecordsizebytes`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_CascadeEntityBreakdown"></a> CascadeEntityBreakdown

|Property|Value|
|---|---|
|Description|**JSON breakdown of per-child-entity cascade averages.**|
|DisplayName|**Cascade Entity Breakdown**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`cascadeentitybreakdown`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_EntityId"></a> EntityId

|Property|Value|
|---|---|
|Description|**MetadataId of the entity being profiled.**|
|DisplayName|**Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`entityid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_EntityLogicalName"></a> EntityLogicalName

|Property|Value|
|---|---|
|Description|**Logical name of the entity (e.g. account, contact).**|
|DisplayName|**Entity Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`entitylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_EntityObjectTypeCode"></a> EntityObjectTypeCode

|Property|Value|
|---|---|
|Description|**Object type code of the entity.**|
|DisplayName|**Entity Object Type Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`entityobjecttypecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_entitystorageprofileId"></a> entitystorageprofileId

|Property|Value|
|---|---|
|Description|**Unique identifier for the entity storage profile record.**|
|DisplayName|**Entity Storage Profile**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entitystorageprofileid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_IsLiked"></a> IsLiked

|Property|Value|
|---|---|
|Description|**Whether the user has marked this recommendation as useful.**|
|DisplayName|**Is Liked**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isliked`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`_entitystorageprofile_isliked`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_LastEvaluatedOn"></a> LastEvaluatedOn

|Property|Value|
|---|---|
|Description|**Timestamp of last profile computation.**|
|DisplayName|**Last Evaluated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastevaluatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_LogicalCollectionName"></a> LogicalCollectionName

|Property|Value|
|---|---|
|Description|**Logical collection name of the entity (e.g. accounts, contacts).**|
|DisplayName|**Logical Collection Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`logicalcollectionname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_MatchingRecordCount"></a> MatchingRecordCount

|Property|Value|
|---|---|
|Description|**Number of rows matching this profile's policy criterion at the last evaluation.**|
|DisplayName|**Matching Record Count**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`matchingrecordcount`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Display name for the storage profile record.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|None|
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

### <a name="BKMK_PolicyCriterionId"></a> PolicyCriterionId

|Property|Value|
|---|---|
|Description|**Reference to the policy criterion this profile row was computed for.**|
|DisplayName|**Policy Criterion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`policycriterionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|policycriterion|

### <a name="BKMK_SampleSize"></a> SampleSize

|Property|Value|
|---|---|
|Description|**Number of records sampled for cascade estimation.**|
|DisplayName|**Sample Size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`samplesize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the entity storage profile.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`entitystorageprofile_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the entity storage profile.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`entitystorageprofile_statuscode`|

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

### <a name="BKMK_TotalDataSizeBytes"></a> TotalDataSizeBytes

|Property|Value|
|---|---|
|Description|**Total data pages size in bytes.**|
|DisplayName|**Total Data Size (Bytes)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`totaldatasizebytes`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_TotalIndexSizeBytes"></a> TotalIndexSizeBytes

|Property|Value|
|---|---|
|Description|**Total index size in bytes.**|
|DisplayName|**Total Index Size (Bytes)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`totalindexsizebytes`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_TotalRecordCount"></a> TotalRecordCount

|Property|Value|
|---|---|
|Description|**Total number of rows in the entity table.**|
|DisplayName|**Total Record Count**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`totalrecordcount`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_entitystorageprofile_createdby](#BKMK_lk_entitystorageprofile_createdby)
- [lk_entitystorageprofile_createdonbehalfby](#BKMK_lk_entitystorageprofile_createdonbehalfby)
- [lk_entitystorageprofile_modifiedby](#BKMK_lk_entitystorageprofile_modifiedby)
- [lk_entitystorageprofile_modifiedonbehalfby](#BKMK_lk_entitystorageprofile_modifiedonbehalfby)
- [organization_entitystorageprofile](#BKMK_organization_entitystorageprofile)
- [policycriterion_entitystorageprofile_PolicyCriterionId](#BKMK_policycriterion_entitystorageprofile_PolicyCriterionId)

### <a name="BKMK_lk_entitystorageprofile_createdby"></a> lk_entitystorageprofile_createdby

One-To-Many Relationship: [systemuser lk_entitystorageprofile_createdby](systemuser.md#BKMK_lk_entitystorageprofile_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitystorageprofile_createdonbehalfby"></a> lk_entitystorageprofile_createdonbehalfby

One-To-Many Relationship: [systemuser lk_entitystorageprofile_createdonbehalfby](systemuser.md#BKMK_lk_entitystorageprofile_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitystorageprofile_modifiedby"></a> lk_entitystorageprofile_modifiedby

One-To-Many Relationship: [systemuser lk_entitystorageprofile_modifiedby](systemuser.md#BKMK_lk_entitystorageprofile_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitystorageprofile_modifiedonbehalfby"></a> lk_entitystorageprofile_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_entitystorageprofile_modifiedonbehalfby](systemuser.md#BKMK_lk_entitystorageprofile_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_entitystorageprofile"></a> organization_entitystorageprofile

One-To-Many Relationship: [organization organization_entitystorageprofile](organization.md#BKMK_organization_entitystorageprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_policycriterion_entitystorageprofile_PolicyCriterionId"></a> policycriterion_entitystorageprofile_PolicyCriterionId

One-To-Many Relationship: [policycriterion policycriterion_entitystorageprofile_PolicyCriterionId](policycriterion.md#BKMK_policycriterion_entitystorageprofile_PolicyCriterionId)

|Property|Value|
|---|---|
|ReferencedEntity|`policycriterion`|
|ReferencedAttribute|`policycriterionid`|
|ReferencingAttribute|`policycriterionid`|
|ReferencingEntityNavigationPropertyName|`PolicyCriterionId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [entitystorageprofile_AsyncOperations](#BKMK_entitystorageprofile_AsyncOperations)
- [entitystorageprofile_BulkDeleteFailures](#BKMK_entitystorageprofile_BulkDeleteFailures)
- [entitystorageprofile_MailboxTrackingFolders](#BKMK_entitystorageprofile_MailboxTrackingFolders)
- [entitystorageprofile_PrincipalObjectAttributeAccesses](#BKMK_entitystorageprofile_PrincipalObjectAttributeAccesses)
- [entitystorageprofile_ProcessSession](#BKMK_entitystorageprofile_ProcessSession)
- [entitystorageprofile_SyncErrors](#BKMK_entitystorageprofile_SyncErrors)

### <a name="BKMK_entitystorageprofile_AsyncOperations"></a> entitystorageprofile_AsyncOperations

Many-To-One Relationship: [asyncoperation entitystorageprofile_AsyncOperations](asyncoperation.md#BKMK_entitystorageprofile_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitystorageprofile_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitystorageprofile_BulkDeleteFailures"></a> entitystorageprofile_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure entitystorageprofile_BulkDeleteFailures](bulkdeletefailure.md#BKMK_entitystorageprofile_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitystorageprofile_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitystorageprofile_MailboxTrackingFolders"></a> entitystorageprofile_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder entitystorageprofile_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_entitystorageprofile_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitystorageprofile_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitystorageprofile_PrincipalObjectAttributeAccesses"></a> entitystorageprofile_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess entitystorageprofile_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_entitystorageprofile_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`entitystorageprofile_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitystorageprofile_ProcessSession"></a> entitystorageprofile_ProcessSession

Many-To-One Relationship: [processsession entitystorageprofile_ProcessSession](processsession.md#BKMK_entitystorageprofile_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitystorageprofile_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitystorageprofile_SyncErrors"></a> entitystorageprofile_SyncErrors

Many-To-One Relationship: [syncerror entitystorageprofile_SyncErrors](syncerror.md#BKMK_entitystorageprofile_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitystorageprofile_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

