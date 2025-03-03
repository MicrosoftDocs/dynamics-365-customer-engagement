---
title: "Filter (msdyn_wallsavedqueryusersettings) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Filter (msdyn_wallsavedqueryusersettings) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Filter (msdyn_wallsavedqueryusersettings) table/entity reference (Microsoft Dynamics 365)

Contains user personalization information regarding which of the administrator’s selected views to display on a user’s personal wall.

## Messages

The following table lists the messages for the Filter (msdyn_wallsavedqueryusersettings) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_wallsavedqueryusersettingses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_wallsavedqueryusersettingses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Filter (msdyn_wallsavedqueryusersettings) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Filter** |
| **DisplayCollectionName** | **Filters** |
| **SchemaName** | `msdyn_wallsavedqueryusersettings` |
| **CollectionSchemaName** | `msdyn_wallsavedqueryusersettingses` |
| **EntitySetName** | `msdyn_wallsavedqueryusersettingses`|
| **LogicalName** | `msdyn_wallsavedqueryusersettings` |
| **LogicalCollectionName** | `msdyn_wallsavedqueryusersettingses` |
| **PrimaryIdAttribute** | `msdyn_wallsavedqueryusersettingsid` |
| **PrimaryNameAttribute** |`msdyn_entityname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_data](#BKMK_msdyn_data)
- [msdyn_default](#BKMK_msdyn_default)
- [msdyn_entitydisplayname](#BKMK_msdyn_entitydisplayname)
- [msdyn_entityname](#BKMK_msdyn_entityname)
- [msdyn_includewallinresponse](#BKMK_msdyn_includewallinresponse)
- [msdyn_isfollowing](#BKMK_msdyn_isfollowing)
- [msdyn_IsVirtual](#BKMK_msdyn_IsVirtual)
- [msdyn_isvisible](#BKMK_msdyn_isvisible)
- [msdyn_isvisiblebit](#BKMK_msdyn_isvisiblebit)
- [msdyn_otc](#BKMK_msdyn_otc)
- [msdyn_savedqueryname](#BKMK_msdyn_savedqueryname)
- [msdyn_sortorder](#BKMK_msdyn_sortorder)
- [msdyn_type](#BKMK_msdyn_type)
- [msdyn_userid](#BKMK_msdyn_userid)
- [msdyn_wallsavedqueryid](#BKMK_msdyn_wallsavedqueryid)
- [msdyn_wallsavedqueryusersettingsId](#BKMK_msdyn_wallsavedqueryusersettingsId)
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

### <a name="BKMK_msdyn_data"></a> msdyn_data

|Property|Value|
|---|---|
|Description|**XML blob that stores personalization data for the user.**|
|DisplayName|**Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_data`|
|RequiredLevel|Recommended|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_default"></a> msdyn_default

|Property|Value|
|---|---|
|Description|**Indicates that view is selected by default if value is greater than 0. Also contains information which specific filter is applied.**|
|DisplayName|**Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_default`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_entitydisplayname"></a> msdyn_entitydisplayname

|Property|Value|
|---|---|
|Description|**Display name of the entity to which the corresponding views belong.**|
|DisplayName|**Entity Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitydisplayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_entityname"></a> msdyn_entityname

|Property|Value|
|---|---|
|Description|**Name of the entity to which the corresponding views belong.**|
|DisplayName|**Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_includewallinresponse"></a> msdyn_includewallinresponse

|Property|Value|
|---|---|
|Description|**Indicates that wall should be included in response to avoid roundtrips to server**|
|DisplayName|**Include Wall in response**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_includewallinresponse`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_wallsavedqueryusersettings_msdyn_includewallinresponse`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isfollowing"></a> msdyn_isfollowing

|Property|Value|
|---|---|
|Description|**Indicates that corresponding view is following view**|
|DisplayName|**Is Following**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isfollowing`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_wallsavedqueryusersettings_msdyn_isfollowing`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsVirtual"></a> msdyn_IsVirtual

|Property|Value|
|---|---|
|Description|**Indicates that the record is virtual**|
|DisplayName|**Is Virtual**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isvirtual`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_wallsavedqueryusersettings_msdyn_isvirtual`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isvisible"></a> msdyn_isvisible

|Property|Value|
|---|---|
|Description|**Information that indicates whether the corresponding view should be displayed on the personal wall for this user.**|
|DisplayName|**Display on the wall**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isvisible`|
|RequiredLevel|Recommended|
|Type|Boolean|
|GlobalChoiceName|`msdyn_wallsavedqueryusersettings_msdyn_isvisible`|
|DefaultValue|True|
|True Label|Shown|
|False Label|Hidden|

### <a name="BKMK_msdyn_isvisiblebit"></a> msdyn_isvisiblebit

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Visible bit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isvisiblebit`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_otc"></a> msdyn_otc

|Property|Value|
|---|---|
|Description|**Virtual column which contains entity type code for the entities returned by corresponding savedquery**|
|DisplayName|**Entity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_otc`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_savedqueryname"></a> msdyn_savedqueryname

|Property|Value|
|---|---|
|Description|**Name of the corresponding view.**|
|DisplayName|**View Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_savedqueryname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_sortorder"></a> msdyn_sortorder

|Property|Value|
|---|---|
|Description|**Sort order to be used when displaying the filter on the user’s personal wall.**|
|DisplayName|**Sort Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sortorder`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description|**Reserved to support different view types. Currently not used.**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_userid"></a> msdyn_userid

|Property|Value|
|---|---|
|Description|**Unique identifier for User associated with Wall View User Setting.**|
|DisplayName|**User Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_userid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_wallsavedqueryid"></a> msdyn_wallsavedqueryid

|Property|Value|
|---|---|
|Description|**Unique identifier for Wall View associated with Wall View User Setting.**|
|DisplayName|**Wall View Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wallsavedqueryid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_wallsavedquery|

### <a name="BKMK_msdyn_wallsavedqueryusersettingsId"></a> msdyn_wallsavedqueryusersettingsId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Filter**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_wallsavedqueryusersettingsid`|
|RequiredLevel|SystemRequired|
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
|Description|**Status of the Wall View User Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_wallsavedqueryusersettings_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Wall View User Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_wallsavedqueryusersettings_statuscode`|

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

- [business_unit_msdyn_wallsavedqueryusersettings](#BKMK_business_unit_msdyn_wallsavedqueryusersettings)
- [lk_msdyn_wallsavedqueryusersettings_createdby](#BKMK_lk_msdyn_wallsavedqueryusersettings_createdby)
- [lk_msdyn_wallsavedqueryusersettings_createdonbehalfby](#BKMK_lk_msdyn_wallsavedqueryusersettings_createdonbehalfby)
- [lk_msdyn_wallsavedqueryusersettings_modifiedby](#BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedby)
- [lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby](#BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby)
- [msdyn_systemuser_wallsavedqueryusersettings_userid](#BKMK_msdyn_systemuser_wallsavedqueryusersettings_userid)
- [msdyn_wallsavedquery_wallsavedqueryusersettings](#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings)
- [owner_msdyn_wallsavedqueryusersettings](#BKMK_owner_msdyn_wallsavedqueryusersettings)
- [team_msdyn_wallsavedqueryusersettings](#BKMK_team_msdyn_wallsavedqueryusersettings)
- [user_msdyn_wallsavedqueryusersettings](#BKMK_user_msdyn_wallsavedqueryusersettings)

### <a name="BKMK_business_unit_msdyn_wallsavedqueryusersettings"></a> business_unit_msdyn_wallsavedqueryusersettings

One-To-Many Relationship: [businessunit business_unit_msdyn_wallsavedqueryusersettings](businessunit.md#BKMK_business_unit_msdyn_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wallsavedqueryusersettings_createdby"></a> lk_msdyn_wallsavedqueryusersettings_createdby

One-To-Many Relationship: [systemuser lk_msdyn_wallsavedqueryusersettings_createdby](systemuser.md#BKMK_lk_msdyn_wallsavedqueryusersettings_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wallsavedqueryusersettings_createdonbehalfby"></a> lk_msdyn_wallsavedqueryusersettings_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_wallsavedqueryusersettings_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedqueryusersettings_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedby"></a> lk_msdyn_wallsavedqueryusersettings_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_wallsavedqueryusersettings_modifiedby](systemuser.md#BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby"></a> lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_wallsavedqueryusersettings_userid"></a> msdyn_systemuser_wallsavedqueryusersettings_userid

One-To-Many Relationship: [systemuser msdyn_systemuser_wallsavedqueryusersettings_userid](systemuser.md#BKMK_msdyn_systemuser_wallsavedqueryusersettings_userid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_userid`|
|ReferencingEntityNavigationPropertyName|`msdyn_userid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings"></a> msdyn_wallsavedquery_wallsavedqueryusersettings

One-To-Many Relationship: [msdyn_wallsavedquery msdyn_wallsavedquery_wallsavedqueryusersettings](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_wallsavedquery`|
|ReferencedAttribute|`msdyn_wallsavedqueryid`|
|ReferencingAttribute|`msdyn_wallsavedqueryid`|
|ReferencingEntityNavigationPropertyName|`msdyn_wallsavedqueryid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_wallsavedqueryusersettings"></a> owner_msdyn_wallsavedqueryusersettings

One-To-Many Relationship: [owner owner_msdyn_wallsavedqueryusersettings](owner.md#BKMK_owner_msdyn_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_wallsavedqueryusersettings"></a> team_msdyn_wallsavedqueryusersettings

One-To-Many Relationship: [team team_msdyn_wallsavedqueryusersettings](team.md#BKMK_team_msdyn_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_wallsavedqueryusersettings"></a> user_msdyn_wallsavedqueryusersettings

One-To-Many Relationship: [systemuser user_msdyn_wallsavedqueryusersettings](systemuser.md#BKMK_user_msdyn_wallsavedqueryusersettings)

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

- [msdyn_wallsavedqueryusersettings_AsyncOperations](#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations)
- [msdyn_wallsavedqueryusersettings_BulkDeleteFailures](#BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures)
- [msdyn_wallsavedqueryusersettings_MailboxTrackingFolders](#BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders)
- [msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses)
- [msdyn_wallsavedqueryusersettings_ProcessSession](#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession)
- [msdyn_wallsavedqueryusersettings_SyncErrors](#BKMK_msdyn_wallsavedqueryusersettings_SyncErrors)

### <a name="BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations"></a> msdyn_wallsavedqueryusersettings_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_wallsavedqueryusersettings_AsyncOperations](asyncoperation.md#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedqueryusersettings_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures"></a> msdyn_wallsavedqueryusersettings_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_wallsavedqueryusersettings_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedqueryusersettings_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders"></a> msdyn_wallsavedqueryusersettings_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_wallsavedqueryusersettings_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedqueryusersettings_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedqueryusersettings_ProcessSession"></a> msdyn_wallsavedqueryusersettings_ProcessSession

Many-To-One Relationship: [processsession msdyn_wallsavedqueryusersettings_ProcessSession](processsession.md#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedqueryusersettings_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_wallsavedqueryusersettings_SyncErrors"></a> msdyn_wallsavedqueryusersettings_SyncErrors

Many-To-One Relationship: [syncerror msdyn_wallsavedqueryusersettings_SyncErrors](syncerror.md#BKMK_msdyn_wallsavedqueryusersettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_wallsavedqueryusersettings_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

