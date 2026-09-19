---
title: "Criteria Simulation (msdyn_evaluationsimulationrun) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Criteria Simulation (msdyn_evaluationsimulationrun) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Criteria Simulation (msdyn_evaluationsimulationrun) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Criteria Simulation (msdyn_evaluationsimulationrun) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_evaluationsimulationruns(*msdyn_evaluationsimulationrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_evaluationsimulationruns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_evaluationsimulationruns(*msdyn_evaluationsimulationrunid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_evaluationsimulationruns(*msdyn_evaluationsimulationrunid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_evaluationsimulationruns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_evaluationsimulationruns(*msdyn_evaluationsimulationrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_evaluationsimulationruns(*msdyn_evaluationsimulationrunid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_evaluationsimulationruns(*msdyn_evaluationsimulationrunid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Criteria Simulation (msdyn_evaluationsimulationrun) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Criteria Simulation** |
| **DisplayCollectionName** | **Criteria Simulations** |
| **SchemaName** | `msdyn_evaluationsimulationrun` |
| **CollectionSchemaName** | `msdyn_evaluationsimulationruns` |
| **EntitySetName** | `msdyn_evaluationsimulationruns`|
| **LogicalName** | `msdyn_evaluationsimulationrun` |
| **LogicalCollectionName** | `msdyn_evaluationsimulationruns` |
| **PrimaryIdAttribute** | `msdyn_evaluationsimulationrunid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_errordetails](#BKMK_msdyn_errordetails)
- [msdyn_evaluationcriteriaparentversion](#BKMK_msdyn_evaluationcriteriaparentversion)
- [msdyn_evaluationcriteriaversion](#BKMK_msdyn_evaluationcriteriaversion)
- [msdyn_evaluationcriteriaversionid](#BKMK_msdyn_evaluationcriteriaversionid)
- [msdyn_evaluationsimulationrunId](#BKMK_msdyn_evaluationsimulationrunId)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_RecordType](#BKMK_msdyn_RecordType)
- [msdyn_regardingobjectid](#BKMK_msdyn_regardingobjectid)
- [msdyn_regardingobjectidIdType](#BKMK_msdyn_regardingobjectidIdType)
- [msdyn_simulationrunid](#BKMK_msdyn_simulationrunid)
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

### <a name="BKMK_msdyn_errordetails"></a> msdyn_errordetails

|Property|Value|
|---|---|
|Description|**Error details for criteria simulation failure**|
|DisplayName|**Error Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errordetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_evaluationcriteriaparentversion"></a> msdyn_evaluationcriteriaparentversion

|Property|Value|
|---|---|
|Description|**The parent evaluation criteria version used at the time of Simulation Run.**|
|DisplayName|**Evaluation Criteria Parent Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationcriteriaparentversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_evaluationcriteriaversion"></a> msdyn_evaluationcriteriaversion

|Property|Value|
|---|---|
|Description|**The version of the Evaluation Criteria that was used at the time of Simulation Run**|
|DisplayName|**Evaluation Criteria Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationcriteriaversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_evaluationcriteriaversionid"></a> msdyn_evaluationcriteriaversionid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Evaluation Criteria Version Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationcriteriaversionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_evaluationcriteriaversion|

### <a name="BKMK_msdyn_evaluationsimulationrunId"></a> msdyn_evaluationsimulationrunId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Evaluation Simulation Run**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationsimulationrunid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_RecordType"></a> msdyn_RecordType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_evaluationrecordtype`|

#### msdyn_RecordType Choices/Options

|Value|Label|
|---|---|
|0|**Case**|
|1|**Conversation**|
|2|**Email**|
|3|**User**|

### <a name="BKMK_msdyn_regardingobjectid"></a> msdyn_regardingobjectid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Related record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_evaluationcriteria|

### <a name="BKMK_msdyn_regardingobjectidIdType"></a> msdyn_regardingobjectidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_simulationrunid"></a> msdyn_simulationrunid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Simulation Run Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationrunid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_aisimulationrun|

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
|Description|**Status of the Evaluation Simulation Run**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationsimulationrun_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Not Started**<br />DefaultStatus: 1<br />InvariantName: `Not Started`|
|1|Label: **In Progress**<br />DefaultStatus: 2<br />InvariantName: `In Progress`|
|2|Label: **Completed**<br />DefaultStatus: 3<br />InvariantName: `Completed`|
|3|Label: **Failed**<br />DefaultStatus: 4<br />InvariantName: `Failed`|
|4|Label: **Partially Failed**<br />DefaultStatus: 5<br />InvariantName: `Partially Failed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Evaluation Simulation Run**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_evaluationsimulationrun_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Not Started**<br />State:0<br />TransitionData: None|
|2|Label: **In Progress**<br />State:1<br />TransitionData: None|
|3|Label: **Completed**<br />State:2<br />TransitionData: None|
|4|Label: **Failed**<br />State:3<br />TransitionData: None|
|5|Label: **Partially Failed**<br />State:4<br />TransitionData: None|

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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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

- [business_unit_msdyn_evaluationsimulationrun](#BKMK_business_unit_msdyn_evaluationsimulationrun)
- [lk_msdyn_evaluationsimulationrun_createdby](#BKMK_lk_msdyn_evaluationsimulationrun_createdby)
- [lk_msdyn_evaluationsimulationrun_createdonbehalfby](#BKMK_lk_msdyn_evaluationsimulationrun_createdonbehalfby)
- [lk_msdyn_evaluationsimulationrun_modifiedby](#BKMK_lk_msdyn_evaluationsimulationrun_modifiedby)
- [lk_msdyn_evaluationsimulationrun_modifiedonbehalfby](#BKMK_lk_msdyn_evaluationsimulationrun_modifiedonbehalfby)
- [msdyn_evaluationsimulationrun_msdyn_evaluationcriteria_msdyn_regardingobjectId](#BKMK_msdyn_evaluationsimulationrun_msdyn_evaluationcriteria_msdyn_regardingobjectId)
- [msdyn_evaluationsimulationrun_msdyn_evaluationcriteriaversionid_msdyn_evaluationcriteriaversion](#BKMK_msdyn_evaluationsimulationrun_msdyn_evaluationcriteriaversionid_msdyn_evaluationcriteriaversion)
- [msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun](#BKMK_msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun)
- [owner_msdyn_evaluationsimulationrun](#BKMK_owner_msdyn_evaluationsimulationrun)
- [team_msdyn_evaluationsimulationrun](#BKMK_team_msdyn_evaluationsimulationrun)
- [user_msdyn_evaluationsimulationrun](#BKMK_user_msdyn_evaluationsimulationrun)

### <a name="BKMK_business_unit_msdyn_evaluationsimulationrun"></a> business_unit_msdyn_evaluationsimulationrun

One-To-Many Relationship: [businessunit business_unit_msdyn_evaluationsimulationrun](businessunit.md#BKMK_business_unit_msdyn_evaluationsimulationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationsimulationrun_createdby"></a> lk_msdyn_evaluationsimulationrun_createdby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationsimulationrun_createdby](systemuser.md#BKMK_lk_msdyn_evaluationsimulationrun_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationsimulationrun_createdonbehalfby"></a> lk_msdyn_evaluationsimulationrun_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationsimulationrun_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationsimulationrun_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationsimulationrun_modifiedby"></a> lk_msdyn_evaluationsimulationrun_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationsimulationrun_modifiedby](systemuser.md#BKMK_lk_msdyn_evaluationsimulationrun_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_evaluationsimulationrun_modifiedonbehalfby"></a> lk_msdyn_evaluationsimulationrun_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_evaluationsimulationrun_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_evaluationsimulationrun_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationsimulationrun_msdyn_evaluationcriteria_msdyn_regardingobjectId"></a> msdyn_evaluationsimulationrun_msdyn_evaluationcriteria_msdyn_regardingobjectId

One-To-Many Relationship: [msdyn_evaluationcriteria msdyn_evaluationsimulationrun_msdyn_evaluationcriteria_msdyn_regardingobjectId](msdyn_evaluationcriteria.md#BKMK_msdyn_evaluationsimulationrun_msdyn_evaluationcriteria_msdyn_regardingobjectId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationcriteria`|
|ReferencedAttribute|`msdyn_evaluationcriteriaid`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_regardingobjectid_msdyn_evaluationcriteria`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_evaluationsimulationrun_msdyn_evaluationcriteriaversionid_msdyn_evaluationcriteriaversion"></a> msdyn_evaluationsimulationrun_msdyn_evaluationcriteriaversionid_msdyn_evaluationcriteriaversion

One-To-Many Relationship: [msdyn_evaluationcriteriaversion msdyn_evaluationsimulationrun_msdyn_evaluationcriteriaversionid_msdyn_evaluationcriteriaversion](msdyn_evaluationcriteriaversion.md#BKMK_msdyn_evaluationsimulationrun_msdyn_evaluationcriteriaversionid_msdyn_evaluationcriteriaversion)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_evaluationcriteriaversion`|
|ReferencedAttribute|`msdyn_evaluationcriteriaversionid`|
|ReferencingAttribute|`msdyn_evaluationcriteriaversionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_evaluationcriteriaversionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun"></a> msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun

One-To-Many Relationship: [msdyn_aisimulationrun msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun](msdyn_aisimulationrun.md#BKMK_msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_aisimulationrun`|
|ReferencedAttribute|`msdyn_aisimulationrunid`|
|ReferencingAttribute|`msdyn_simulationrunid`|
|ReferencingEntityNavigationPropertyName|`msdyn_simulationrunid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_evaluationsimulationrun"></a> owner_msdyn_evaluationsimulationrun

One-To-Many Relationship: [owner owner_msdyn_evaluationsimulationrun](owner.md#BKMK_owner_msdyn_evaluationsimulationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_evaluationsimulationrun"></a> team_msdyn_evaluationsimulationrun

One-To-Many Relationship: [team team_msdyn_evaluationsimulationrun](team.md#BKMK_team_msdyn_evaluationsimulationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_evaluationsimulationrun"></a> user_msdyn_evaluationsimulationrun

One-To-Many Relationship: [systemuser user_msdyn_evaluationsimulationrun](systemuser.md#BKMK_user_msdyn_evaluationsimulationrun)

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

- [msdyn_evaluationsimulationrun_AsyncOperations](#BKMK_msdyn_evaluationsimulationrun_AsyncOperations)
- [msdyn_evaluationsimulationrun_BulkDeleteFailures](#BKMK_msdyn_evaluationsimulationrun_BulkDeleteFailures)
- [msdyn_evaluationsimulationrun_DuplicateBaseRecord](#BKMK_msdyn_evaluationsimulationrun_DuplicateBaseRecord)
- [msdyn_evaluationsimulationrun_DuplicateMatchingRecord](#BKMK_msdyn_evaluationsimulationrun_DuplicateMatchingRecord)
- [msdyn_evaluationsimulationrun_MailboxTrackingFolders](#BKMK_msdyn_evaluationsimulationrun_MailboxTrackingFolders)
- [msdyn_evaluationsimulationrun_PrincipalObjectAttributeAccesses](#BKMK_msdyn_evaluationsimulationrun_PrincipalObjectAttributeAccesses)
- [msdyn_evaluationsimulationrun_ProcessSession](#BKMK_msdyn_evaluationsimulationrun_ProcessSession)
- [msdyn_evaluationsimulationrun_SyncErrors](#BKMK_msdyn_evaluationsimulationrun_SyncErrors)

### <a name="BKMK_msdyn_evaluationsimulationrun_AsyncOperations"></a> msdyn_evaluationsimulationrun_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_evaluationsimulationrun_AsyncOperations](asyncoperation.md#BKMK_msdyn_evaluationsimulationrun_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationsimulationrun_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationsimulationrun_BulkDeleteFailures"></a> msdyn_evaluationsimulationrun_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_evaluationsimulationrun_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_evaluationsimulationrun_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationsimulationrun_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationsimulationrun_DuplicateBaseRecord"></a> msdyn_evaluationsimulationrun_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_evaluationsimulationrun_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_evaluationsimulationrun_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationsimulationrun_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationsimulationrun_DuplicateMatchingRecord"></a> msdyn_evaluationsimulationrun_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_evaluationsimulationrun_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_evaluationsimulationrun_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationsimulationrun_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationsimulationrun_MailboxTrackingFolders"></a> msdyn_evaluationsimulationrun_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_evaluationsimulationrun_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_evaluationsimulationrun_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationsimulationrun_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationsimulationrun_PrincipalObjectAttributeAccesses"></a> msdyn_evaluationsimulationrun_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_evaluationsimulationrun_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_evaluationsimulationrun_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationsimulationrun_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationsimulationrun_ProcessSession"></a> msdyn_evaluationsimulationrun_ProcessSession

Many-To-One Relationship: [processsession msdyn_evaluationsimulationrun_ProcessSession](processsession.md#BKMK_msdyn_evaluationsimulationrun_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationsimulationrun_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationsimulationrun_SyncErrors"></a> msdyn_evaluationsimulationrun_SyncErrors

Many-To-One Relationship: [syncerror msdyn_evaluationsimulationrun_SyncErrors](syncerror.md#BKMK_msdyn_evaluationsimulationrun_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_evaluationsimulationrun_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

