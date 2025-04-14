---
title: "Training data import configuration (msdyn_ocsitdimportconfig) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Training data import configuration (msdyn_ocsitdimportconfig) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Training data import configuration (msdyn_ocsitdimportconfig) table/entity reference (Microsoft Dynamics 365)

Indicates the training data import configuration

## Messages

The following table lists the messages for the Training data import configuration (msdyn_ocsitdimportconfig) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocsitdimportconfigs(*msdyn_ocsitdimportconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocsitdimportconfigs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocsitdimportconfigs(*msdyn_ocsitdimportconfigid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocsitdimportconfigs(*msdyn_ocsitdimportconfigid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocsitdimportconfigs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocsitdimportconfigs(*msdyn_ocsitdimportconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocsitdimportconfigs(*msdyn_ocsitdimportconfigid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocsitdimportconfigs(*msdyn_ocsitdimportconfigid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Training data import configuration (msdyn_ocsitdimportconfig) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Training data import configuration** |
| **DisplayCollectionName** | **Training data import configurations** |
| **SchemaName** | `msdyn_ocsitdimportconfig` |
| **CollectionSchemaName** | `msdyn_ocsitdimportconfigs` |
| **EntitySetName** | `msdyn_ocsitdimportconfigs`|
| **LogicalName** | `msdyn_ocsitdimportconfig` |
| **LogicalCollectionName** | `msdyn_ocsitdimportconfigs` |
| **PrimaryIdAttribute** | `msdyn_ocsitdimportconfigid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_cdsdataloadconfig](#BKMK_msdyn_cdsdataloadconfig)
- [msdyn_importconfigtype](#BKMK_msdyn_importconfigtype)
- [msdyn_loadstatus](#BKMK_msdyn_loadstatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocsitdimportconfigId](#BKMK_msdyn_ocsitdimportconfigId)
- [msdyn_ocskillidentmlmodelid](#BKMK_msdyn_ocskillidentmlmodelid)
- [msdyn_recordsimported](#BKMK_msdyn_recordsimported)
- [msdyn_recordsskipped](#BKMK_msdyn_recordsskipped)
- [msdyn_totalrecordstoimport](#BKMK_msdyn_totalrecordstoimport)
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

### <a name="BKMK_msdyn_cdsdataloadconfig"></a> msdyn_cdsdataloadconfig

|Property|Value|
|---|---|
|Description|**Data loading config**|
|DisplayName|**Data loading config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cdsdataloadconfig`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyn_importconfigtype"></a> msdyn_importconfigtype

|Property|Value|
|---|---|
|Description|**Data loading config type**|
|DisplayName|**Data loading config type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_importconfigtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_importconfigtype`|

#### msdyn_importconfigtype Choices/Options

|Value|Label|
|---|---|
|617690000|**Conversation**|

### <a name="BKMK_msdyn_loadstatus"></a> msdyn_loadstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Load status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_loadstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocsitdimportconfig_loadstatus`|

#### msdyn_loadstatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Triggering load**|
|192350001|**Loading training data**|
|192350002|**Load completed**|
|192350003|**Load failed**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the data loading config.**|
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
|MaxLength|100|

### <a name="BKMK_msdyn_ocsitdimportconfigId"></a> msdyn_ocsitdimportconfigId

|Property|Value|
|---|---|
|Description|**Unique identifier for data loading config**|
|DisplayName|**Data loading config id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocsitdimportconfigid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdyn_recordsimported"></a> msdyn_recordsimported

|Property|Value|
|---|---|
|Description|**No of records imported at given point of time from this import config**|
|DisplayName|**Records processed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordsimported`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_recordsskipped"></a> msdyn_recordsskipped

|Property|Value|
|---|---|
|Description|**No of records skipped because of no or bad training data**|
|DisplayName|**Records skipped**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordsskipped`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_totalrecordstoimport"></a> msdyn_totalrecordstoimport

|Property|Value|
|---|---|
|Description|**Total no of records imported from this import config**|
|DisplayName|**Total records to import**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalrecordstoimport`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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
|Description|**Status of the ocsitdimportconfig**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsitdimportconfig_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the ocsitdimportconfig**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocsitdimportconfig_statuscode`|

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
|DisplayName|**Created on**|
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

- [business_unit_msdyn_ocsitdimportconfig](#BKMK_business_unit_msdyn_ocsitdimportconfig)
- [lk_msdyn_ocsitdimportconfig_createdby](#BKMK_lk_msdyn_ocsitdimportconfig_createdby)
- [lk_msdyn_ocsitdimportconfig_createdonbehalfby](#BKMK_lk_msdyn_ocsitdimportconfig_createdonbehalfby)
- [lk_msdyn_ocsitdimportconfig_modifiedby](#BKMK_lk_msdyn_ocsitdimportconfig_modifiedby)
- [lk_msdyn_ocsitdimportconfig_modifiedonbehalfby](#BKMK_lk_msdyn_ocsitdimportconfig_modifiedonbehalfby)
- [msdyn_ocsitdimportconfig_ocskillidentmlmo](#BKMK_msdyn_ocsitdimportconfig_ocskillidentmlmo)
- [owner_msdyn_ocsitdimportconfig](#BKMK_owner_msdyn_ocsitdimportconfig)
- [team_msdyn_ocsitdimportconfig](#BKMK_team_msdyn_ocsitdimportconfig)
- [user_msdyn_ocsitdimportconfig](#BKMK_user_msdyn_ocsitdimportconfig)

### <a name="BKMK_business_unit_msdyn_ocsitdimportconfig"></a> business_unit_msdyn_ocsitdimportconfig

One-To-Many Relationship: [businessunit business_unit_msdyn_ocsitdimportconfig](businessunit.md#BKMK_business_unit_msdyn_ocsitdimportconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsitdimportconfig_createdby"></a> lk_msdyn_ocsitdimportconfig_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocsitdimportconfig_createdby](systemuser.md#BKMK_lk_msdyn_ocsitdimportconfig_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsitdimportconfig_createdonbehalfby"></a> lk_msdyn_ocsitdimportconfig_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsitdimportconfig_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsitdimportconfig_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsitdimportconfig_modifiedby"></a> lk_msdyn_ocsitdimportconfig_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocsitdimportconfig_modifiedby](systemuser.md#BKMK_lk_msdyn_ocsitdimportconfig_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocsitdimportconfig_modifiedonbehalfby"></a> lk_msdyn_ocsitdimportconfig_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocsitdimportconfig_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocsitdimportconfig_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsitdimportconfig_ocskillidentmlmo"></a> msdyn_ocsitdimportconfig_ocskillidentmlmo

One-To-Many Relationship: [msdyn_ocskillidentmlmodel msdyn_ocsitdimportconfig_ocskillidentmlmo](msdyn_ocskillidentmlmodel.md#BKMK_msdyn_ocsitdimportconfig_ocskillidentmlmo)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocskillidentmlmodel`|
|ReferencedAttribute|`msdyn_ocskillidentmlmodelid`|
|ReferencingAttribute|`msdyn_ocskillidentmlmodelid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocskillidentmlmodelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_ocsitdimportconfig"></a> owner_msdyn_ocsitdimportconfig

One-To-Many Relationship: [owner owner_msdyn_ocsitdimportconfig](owner.md#BKMK_owner_msdyn_ocsitdimportconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocsitdimportconfig"></a> team_msdyn_ocsitdimportconfig

One-To-Many Relationship: [team team_msdyn_ocsitdimportconfig](team.md#BKMK_team_msdyn_ocsitdimportconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocsitdimportconfig"></a> user_msdyn_ocsitdimportconfig

One-To-Many Relationship: [systemuser user_msdyn_ocsitdimportconfig](systemuser.md#BKMK_user_msdyn_ocsitdimportconfig)

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

- [msdyn_ocsitdimportconfig_AsyncOperations](#BKMK_msdyn_ocsitdimportconfig_AsyncOperations)
- [msdyn_ocsitdimportconfig_BulkDeleteFailures](#BKMK_msdyn_ocsitdimportconfig_BulkDeleteFailures)
- [msdyn_ocsitdimportconfig_DuplicateBaseRecord](#BKMK_msdyn_ocsitdimportconfig_DuplicateBaseRecord)
- [msdyn_ocsitdimportconfig_DuplicateMatchingRecord](#BKMK_msdyn_ocsitdimportconfig_DuplicateMatchingRecord)
- [msdyn_ocsitdimportconfig_MailboxTrackingFolders](#BKMK_msdyn_ocsitdimportconfig_MailboxTrackingFolders)
- [msdyn_ocsitdimportconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocsitdimportconfig_PrincipalObjectAttributeAccesses)
- [msdyn_ocsitdimportconfig_ProcessSession](#BKMK_msdyn_ocsitdimportconfig_ProcessSession)
- [msdyn_ocsitdimportconfig_SyncErrors](#BKMK_msdyn_ocsitdimportconfig_SyncErrors)
- [msdyn_ocsitrainingdata_ocsitdimportconfig](#BKMK_msdyn_ocsitrainingdata_ocsitdimportconfig)

### <a name="BKMK_msdyn_ocsitdimportconfig_AsyncOperations"></a> msdyn_ocsitdimportconfig_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocsitdimportconfig_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocsitdimportconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdimportconfig_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitdimportconfig_BulkDeleteFailures"></a> msdyn_ocsitdimportconfig_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocsitdimportconfig_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocsitdimportconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdimportconfig_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitdimportconfig_DuplicateBaseRecord"></a> msdyn_ocsitdimportconfig_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsitdimportconfig_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocsitdimportconfig_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdimportconfig_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitdimportconfig_DuplicateMatchingRecord"></a> msdyn_ocsitdimportconfig_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocsitdimportconfig_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocsitdimportconfig_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdimportconfig_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitdimportconfig_MailboxTrackingFolders"></a> msdyn_ocsitdimportconfig_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocsitdimportconfig_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocsitdimportconfig_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdimportconfig_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitdimportconfig_PrincipalObjectAttributeAccesses"></a> msdyn_ocsitdimportconfig_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocsitdimportconfig_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocsitdimportconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdimportconfig_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitdimportconfig_ProcessSession"></a> msdyn_ocsitdimportconfig_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocsitdimportconfig_ProcessSession](processsession.md#BKMK_msdyn_ocsitdimportconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdimportconfig_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitdimportconfig_SyncErrors"></a> msdyn_ocsitdimportconfig_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocsitdimportconfig_SyncErrors](syncerror.md#BKMK_msdyn_ocsitdimportconfig_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitdimportconfig_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsitrainingdata_ocsitdimportconfig"></a> msdyn_ocsitrainingdata_ocsitdimportconfig

Many-To-One Relationship: [msdyn_ocsitrainingdata msdyn_ocsitrainingdata_ocsitdimportconfig](msdyn_ocsitrainingdata.md#BKMK_msdyn_ocsitrainingdata_ocsitdimportconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitrainingdata`|
|ReferencingAttribute|`msdyn_ocsitdimportconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsitrainingdata_ocsitdimportconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

