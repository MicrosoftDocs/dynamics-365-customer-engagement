---
title: "Training record (msdyn_ocsitrainingdata) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Training record (msdyn_ocsitrainingdata) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Training record (msdyn_ocsitrainingdata) table/entity reference (Microsoft Dynamics 365)

Indicates individual training record to be used for model training

## Messages

The following table lists the messages for the Training record (msdyn_ocsitrainingdata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocsitrainingdatas(*msdyn_ocsitrainingdataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocsitrainingdatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocsitrainingdatas(*msdyn_ocsitrainingdataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocsitrainingdatas(*msdyn_ocsitrainingdataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocsitrainingdatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocsitrainingdatas(*msdyn_ocsitrainingdataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocsitrainingdatas(*msdyn_ocsitrainingdataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocsitrainingdatas(*msdyn_ocsitrainingdataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Training record (msdyn_ocsitrainingdata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Training record** |
| **DisplayCollectionName** | **Training records** |
| **SchemaName** | `msdyn_ocsitrainingdata` |
| **CollectionSchemaName** | `msdyn_ocsitrainingdatas` |
| **EntitySetName** | `msdyn_ocsitrainingdatas`|
| **LogicalName** | `msdyn_ocsitrainingdata` |
| **LogicalCollectionName** | `msdyn_ocsitrainingdatas` |
| **PrimaryIdAttribute** | `msdyn_ocsitrainingdataid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_approvedby](#BKMK_msdyn_approvedby)
- [msdyn_approvedon](#BKMK_msdyn_approvedon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocsitdimportconfigid](#BKMK_msdyn_ocsitdimportconfigid)
- [msdyn_ocsitrainingdataId](#BKMK_msdyn_ocsitrainingdataId)
- [msdyn_ocsitrainingdatastatus](#BKMK_msdyn_ocsitrainingdatastatus)
- [msdyn_ocskillidentmlmodelid](#BKMK_msdyn_ocskillidentmlmodelid)
- [msdyn_phrase](#BKMK_msdyn_phrase)
- [msdyn_skillidscsv](#BKMK_msdyn_skillidscsv)
- [msdyn_skillscsv](#BKMK_msdyn_skillscsv)
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
|DisplayName|**Import sequence version number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_approvedby"></a> msdyn_approvedby

|Property|Value|
|---|---|
|Description|**Approved by**|
|DisplayName|**Approved by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_approvedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_approvedon"></a> msdyn_approvedon

|Property|Value|
|---|---|
|Description|**Approved on**|
|DisplayName|**Approved on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_approvedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the training record.**|
|DisplayName|**Training record name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ocsitdimportconfigid"></a> msdyn_ocsitdimportconfigid

|Property|Value|
|---|---|
|Description|**Data loading config**|
|DisplayName|**Data loading config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocsitdimportconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsitdimportconfig|

### <a name="BKMK_msdyn_ocsitrainingdataId"></a> msdyn_ocsitrainingdataId

|Property|Value|
|---|---|
|Description|**Unique identifier for training record**|
|DisplayName|**Training record id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocsitrainingdataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocsitrainingdatastatus"></a> msdyn_ocsitrainingdatastatus

|Property|Value|
|---|---|
|Description|**Approval status**|
|DisplayName|**Approval status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocsitrainingdatastatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|326340001|
|GlobalChoiceName|`msdyn_ocsitrainingdatastatus`|

#### msdyn_ocsitrainingdatastatus Choices/Options

|Value|Label|
|---|---|
|326340000|**Approved**|
|326340001|**Pending**|
|326340002|**Needs further investigation**|

### <a name="BKMK_msdyn_ocskillidentmlmodelid"></a> msdyn_ocskillidentmlmodelid

|Property|Value|
|---|---|
|Description|**Skill finder model**|
|DisplayName|**Skill finder model**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocskillidentmlmodelid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocskillidentmlmodel|

### <a name="BKMK_msdyn_phrase"></a> msdyn_phrase

|Property|Value|
|---|---|
|Description|**Input data**|
|DisplayName|**Input data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phrase`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyn_skillidscsv"></a> msdyn_skillidscsv

|Property|Value|
|---|---|
|Description|**List of skill IDs**|
|DisplayName|**Skill IDs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_skillidscsv`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_skillscsv"></a> msdyn_skillscsv

|Property|Value|
|---|---|
|Description|**Tags**|
|DisplayName|**Tags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_skillscsv`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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
|Description|**Status of the ocsitrainingdata**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsitrainingdata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ocsitrainingdata**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsitrainingdata_statuscode`|

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

- [business_unit_msdyn_ocsitrainingdata](#BKMK_business_unit_msdyn_ocsitrainingdata)
- [lk_msdyn_ocsitrainingdata_createdby](#BKMK_lk_msdyn_ocsitrainingdata_createdby)
- [lk_msdyn_ocsitrainingdata_createdonbehalfby](#BKMK_lk_msdyn_ocsitrainingdata_createdonbehalfby)
- [lk_msdyn_ocsitrainingdata_modifiedby](#BKMK_lk_msdyn_ocsitrainingdata_modifiedby)
- [lk_msdyn_ocsitrainingdata_modifiedonbehalfby](#BKMK_lk_msdyn_ocsitrainingdata_modifiedonbehalfby)
- [msdyn_ocsitrainingdata_ocsitdimportconfig](#BKMK_msdyn_ocsitrainingdata_ocsitdimportconfig)
- [msdyn_ocsitrainingdata_ocskillidentmlmode](#BKMK_msdyn_ocsitrainingdata_ocskillidentmlmode)
- [msdyn_systemuser_msdyn_ocsitrainingdata_approvedby](#BKMK_msdyn_systemuser_msdyn_ocsitrainingdata_approvedby)
- [owner_msdyn_ocsitrainingdata](#BKMK_owner_msdyn_ocsitrainingdata)
- [team_msdyn_ocsitrainingdata](#BKMK_team_msdyn_ocsitrainingdata)
- [user_msdyn_ocsitrainingdata](#BKMK_user_msdyn_ocsitrainingdata)

### <a name="BKMK_business_unit_msdyn_ocsitrainingdata"></a> business_unit_msdyn_ocsitrainingdata

One-To-Many Relationship: [businessunit business_unit_msdyn_ocsitrainingdata](businessunit.md#BKMK_business_unit_msdyn_ocsitrainingdata)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsitrainingdata_createdby"></a> lk_msdyn_ocsitrainingdata_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocsitrainingdata_createdby](systemuser.md#BKMK_lk_msdyn_ocsitrainingdata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsitrainingdata_createdonbehalfby"></a> lk_msdyn_ocsitrainingdata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsitrainingdata_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsitrainingdata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsitrainingdata_modifiedby"></a> lk_msdyn_ocsitrainingdata_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocsitrainingdata_modifiedby](systemuser.md#BKMK_lk_msdyn_ocsitrainingdata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsitrainingdata_modifiedonbehalfby"></a> lk_msdyn_ocsitrainingdata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsitrainingdata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsitrainingdata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsitrainingdata_ocsitdimportconfig"></a> msdyn_ocsitrainingdata_ocsitdimportconfig

One-To-Many Relationship: [msdyn_ocsitdimportconfig msdyn_ocsitrainingdata_ocsitdimportconfig](msdyn_ocsitdimportconfig.md#BKMK_msdyn_ocsitrainingdata_ocsitdimportconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsitdimportconfig`|
|ReferencedAttribute|`msdyn_ocsitdimportconfigid`|
|ReferencingAttribute|`msdyn_ocsitdimportconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocsitdimportconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsitrainingdata_ocskillidentmlmode"></a> msdyn_ocsitrainingdata_ocskillidentmlmode

One-To-Many Relationship: [msdyn_ocskillidentmlmodel msdyn_ocsitrainingdata_ocskillidentmlmode](msdyn_ocskillidentmlmodel.md#BKMK_msdyn_ocsitrainingdata_ocskillidentmlmode)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocskillidentmlmodel`|
|ReferencedAttribute|`msdyn_ocskillidentmlmodelid`|
|ReferencingAttribute|`msdyn_ocskillidentmlmodelid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocskillidentmlmodelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_ocsitrainingdata_approvedby"></a> msdyn_systemuser_msdyn_ocsitrainingdata_approvedby

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_ocsitrainingdata_approvedby](systemuser.md#BKMK_msdyn_systemuser_msdyn_ocsitrainingdata_approvedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_approvedby`|
|ReferencingEntityNavigationPropertyName|`msdyn_approvedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocsitrainingdata"></a> owner_msdyn_ocsitrainingdata

One-To-Many Relationship: [owner owner_msdyn_ocsitrainingdata](owner.md#BKMK_owner_msdyn_ocsitrainingdata)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocsitrainingdata"></a> team_msdyn_ocsitrainingdata

One-To-Many Relationship: [team team_msdyn_ocsitrainingdata](team.md#BKMK_team_msdyn_ocsitrainingdata)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocsitrainingdata"></a> user_msdyn_ocsitrainingdata

One-To-Many Relationship: [systemuser user_msdyn_ocsitrainingdata](systemuser.md#BKMK_user_msdyn_ocsitrainingdata)

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

- [msdyn_ocsitdskill_ocsitrainingdataid](#BKMK_msdyn_ocsitdskill_ocsitrainingdataid)
- [msdyn_ocsitrainingdata_AsyncOperations](#BKMK_msdyn_ocsitrainingdata_AsyncOperations)
- [msdyn_ocsitrainingdata_BulkDeleteFailures](#BKMK_msdyn_ocsitrainingdata_BulkDeleteFailures)
- [msdyn_ocsitrainingdata_DuplicateBaseRecord](#BKMK_msdyn_ocsitrainingdata_DuplicateBaseRecord)
- [msdyn_ocsitrainingdata_DuplicateMatchingRecord](#BKMK_msdyn_ocsitrainingdata_DuplicateMatchingRecord)
- [msdyn_ocsitrainingdata_MailboxTrackingFolders](#BKMK_msdyn_ocsitrainingdata_MailboxTrackingFolders)
- [msdyn_ocsitrainingdata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocsitrainingdata_PrincipalObjectAttributeAccesses)
- [msdyn_ocsitrainingdata_ProcessSession](#BKMK_msdyn_ocsitrainingdata_ProcessSession)
- [msdyn_ocsitrainingdata_SyncErrors](#BKMK_msdyn_ocsitrainingdata_SyncErrors)

### <a name="BKMK_msdyn_ocsitdskill_ocsitrainingdataid"></a> msdyn_ocsitdskill_ocsitrainingdataid

Many-To-One Relationship: [msdyn_ocsitdskill msdyn_ocsitdskill_ocsitrainingdataid](msdyn_ocsitdskill.md#BKMK_msdyn_ocsitdskill_ocsitrainingdataid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitdskill`|
|ReferencingAttribute|`msdyn_ocsitrainingdataid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdskill_ocsitrainingdataid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_AsyncOperations"></a> msdyn_ocsitrainingdata_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocsitrainingdata_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocsitrainingdata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_BulkDeleteFailures"></a> msdyn_ocsitrainingdata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocsitrainingdata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocsitrainingdata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_DuplicateBaseRecord"></a> msdyn_ocsitrainingdata_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsitrainingdata_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocsitrainingdata_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_DuplicateMatchingRecord"></a> msdyn_ocsitrainingdata_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsitrainingdata_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocsitrainingdata_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_MailboxTrackingFolders"></a> msdyn_ocsitrainingdata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocsitrainingdata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocsitrainingdata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_PrincipalObjectAttributeAccesses"></a> msdyn_ocsitrainingdata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocsitrainingdata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocsitrainingdata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_ProcessSession"></a> msdyn_ocsitrainingdata_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocsitrainingdata_ProcessSession](processsession.md#BKMK_msdyn_ocsitrainingdata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_SyncErrors"></a> msdyn_ocsitrainingdata_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocsitrainingdata_SyncErrors](syncerror.md#BKMK_msdyn_ocsitrainingdata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

