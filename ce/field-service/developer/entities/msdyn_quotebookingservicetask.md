---
title: "Quote Booking Service Task (msdyn_quotebookingservicetask) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Quote Booking Service Task (msdyn_quotebookingservicetask) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Quote Booking Service Task (msdyn_quotebookingservicetask) table/entity reference (Microsoft Dynamics 365 Field Service)



## Messages

The following table lists the messages for the Quote Booking Service Task (msdyn_quotebookingservicetask) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_quotebookingservicetasks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_quotebookingservicetasks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_quotebookingservicetasks(*msdyn_quotebookingservicetaskid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Quote Booking Service Task (msdyn_quotebookingservicetask) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Quote Booking Service Task (msdyn_quotebookingservicetask) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Quote Booking Service Task** |
| **DisplayCollectionName** | **Quote Booking Service Tasks** |
| **SchemaName** | `msdyn_quotebookingservicetask` |
| **CollectionSchemaName** | `msdyn_quotebookingservicetasks` |
| **EntitySetName** | `msdyn_quotebookingservicetasks`|
| **LogicalName** | `msdyn_quotebookingservicetask` |
| **LogicalCollectionName** | `msdyn_quotebookingservicetasks` |
| **PrimaryIdAttribute** | `msdyn_quotebookingservicetaskid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customerasset](#BKMK_msdyn_customerasset)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_estimatedduration](#BKMK_msdyn_estimatedduration)
- [msdyn_internalflags](#BKMK_msdyn_internalflags)
- [msdyn_iscopied](#BKMK_msdyn_iscopied)
- [msdyn_lineorder](#BKMK_msdyn_lineorder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_quote](#BKMK_msdyn_quote)
- [msdyn_quotebookingincident](#BKMK_msdyn_quotebookingincident)
- [msdyn_quotebookingservicetaskId](#BKMK_msdyn_quotebookingservicetaskId)
- [msdyn_QuoteBookingSetup](#BKMK_msdyn_QuoteBookingSetup)
- [msdyn_TaskType](#BKMK_msdyn_TaskType)
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

### <a name="BKMK_msdyn_customerasset"></a> msdyn_customerasset

|Property|Value|
|---|---|
|Description|**Unique identifier for Customer Asset associated with Quote Booking Service Task.**|
|DisplayName|**Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Type a description of this quote booking service task.**|
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

### <a name="BKMK_msdyn_estimatedduration"></a> msdyn_estimatedduration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Estimated Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_internalflags"></a> msdyn_internalflags

|Property|Value|
|---|---|
|Description|**Internal use only**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_iscopied"></a> msdyn_iscopied

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Copied**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscopied`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_quotebookingservicetask_msdyn_iscopied`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_lineorder"></a> msdyn_lineorder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Line Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lineorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_quote"></a> msdyn_quote

|Property|Value|
|---|---|
|Description|**Unique identifier for Quote associated with Quote Booking Service Task.**|
|DisplayName|**Quote**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quote`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|quote|

### <a name="BKMK_msdyn_quotebookingincident"></a> msdyn_quotebookingincident

|Property|Value|
|---|---|
|Description|**Shows the quote booking incident associated with the quote booking service task.**|
|DisplayName|**Quote Booking Incident**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingincident`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_quotebookingincident|

### <a name="BKMK_msdyn_quotebookingservicetaskId"></a> msdyn_quotebookingservicetaskId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Quote Booking Service Task**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingservicetaskid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_QuoteBookingSetup"></a> msdyn_QuoteBookingSetup

|Property|Value|
|---|---|
|Description|**Unique identifier for Quote Booking Setup associated with Quote Booking Service Task.**|
|DisplayName|**Quote Booking Setup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingsetup`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_quotebookingsetup|

### <a name="BKMK_msdyn_TaskType"></a> msdyn_TaskType

|Property|Value|
|---|---|
|Description|**Unique identifier for Service Task Type associated with Quote Booking Service Task.**|
|DisplayName|**Task Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tasktype`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_servicetasktype|

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
|Description|**Status of the Quote Booking Service Task**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_quotebookingservicetask_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Quote Booking Service Task**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_quotebookingservicetask_statuscode`|

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

- [business_unit_msdyn_quotebookingservicetask](#BKMK_business_unit_msdyn_quotebookingservicetask)
- [lk_msdyn_quotebookingservicetask_createdby](#BKMK_lk_msdyn_quotebookingservicetask_createdby)
- [lk_msdyn_quotebookingservicetask_createdonbehalfby](#BKMK_lk_msdyn_quotebookingservicetask_createdonbehalfby)
- [lk_msdyn_quotebookingservicetask_modifiedby](#BKMK_lk_msdyn_quotebookingservicetask_modifiedby)
- [lk_msdyn_quotebookingservicetask_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingservicetask_modifiedonbehalfby)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup)
- [msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType](#BKMK_msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType)
- [msdyn_quote_msdyn_quotebookingservicetask_Quote](#BKMK_msdyn_quote_msdyn_quotebookingservicetask_Quote)
- [owner_msdyn_quotebookingservicetask](#BKMK_owner_msdyn_quotebookingservicetask)
- [team_msdyn_quotebookingservicetask](#BKMK_team_msdyn_quotebookingservicetask)
- [user_msdyn_quotebookingservicetask](#BKMK_user_msdyn_quotebookingservicetask)

### <a name="BKMK_business_unit_msdyn_quotebookingservicetask"></a> business_unit_msdyn_quotebookingservicetask

One-To-Many Relationship: [businessunit business_unit_msdyn_quotebookingservicetask](businessunit.md#BKMK_business_unit_msdyn_quotebookingservicetask)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingservicetask_createdby"></a> lk_msdyn_quotebookingservicetask_createdby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingservicetask_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingservicetask_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingservicetask_createdonbehalfby"></a> lk_msdyn_quotebookingservicetask_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingservicetask_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingservicetask_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingservicetask_modifiedby"></a> lk_msdyn_quotebookingservicetask_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingservicetask_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingservicetask_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingservicetask_modifiedonbehalfby"></a> lk_msdyn_quotebookingservicetask_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingservicetask_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingservicetask_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident

One-To-Many Relationship: [msdyn_quotebookingincident msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingincident`|
|ReferencedAttribute|`msdyn_quotebookingincidentid`|
|ReferencingAttribute|`msdyn_quotebookingincident`|
|ReferencingEntityNavigationPropertyName|`msdyn_quotebookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](msdyn_quotebookingsetup.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`msdyn_quotebookingsetup`|
|ReferencingEntityNavigationPropertyName|`msdyn_QuoteBookingSetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType"></a> msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType

One-To-Many Relationship: [msdyn_servicetasktype msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType](msdyn_servicetasktype.md#BKMK_msdyn_msdyn_servicetasktype_msdyn_quotebookingservicetask_TaskType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`msdyn_tasktype`|
|ReferencingEntityNavigationPropertyName|`msdyn_TaskType`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quote_msdyn_quotebookingservicetask_Quote"></a> msdyn_quote_msdyn_quotebookingservicetask_Quote

One-To-Many Relationship: [quote msdyn_quote_msdyn_quotebookingservicetask_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingservicetask_Quote)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`msdyn_quote`|
|ReferencingEntityNavigationPropertyName|`msdyn_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_quotebookingservicetask"></a> owner_msdyn_quotebookingservicetask

One-To-Many Relationship: [owner owner_msdyn_quotebookingservicetask](owner.md#BKMK_owner_msdyn_quotebookingservicetask)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_quotebookingservicetask"></a> team_msdyn_quotebookingservicetask

One-To-Many Relationship: [team team_msdyn_quotebookingservicetask](team.md#BKMK_team_msdyn_quotebookingservicetask)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_quotebookingservicetask"></a> user_msdyn_quotebookingservicetask

One-To-Many Relationship: [systemuser user_msdyn_quotebookingservicetask](systemuser.md#BKMK_user_msdyn_quotebookingservicetask)

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

- [msdyn_quotebookingservicetask_ActivityPointers](#BKMK_msdyn_quotebookingservicetask_ActivityPointers)
- [msdyn_quotebookingservicetask_adx_inviteredemptions](#BKMK_msdyn_quotebookingservicetask_adx_inviteredemptions)
- [msdyn_quotebookingservicetask_adx_portalcomments](#BKMK_msdyn_quotebookingservicetask_adx_portalcomments)
- [msdyn_quotebookingservicetask_Annotations](#BKMK_msdyn_quotebookingservicetask_Annotations)
- [msdyn_quotebookingservicetask_Appointments](#BKMK_msdyn_quotebookingservicetask_Appointments)
- [msdyn_quotebookingservicetask_AsyncOperations](#BKMK_msdyn_quotebookingservicetask_AsyncOperations)
- [msdyn_quotebookingservicetask_BulkDeleteFailures](#BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures)
- [msdyn_quotebookingservicetask_chats](#BKMK_msdyn_quotebookingservicetask_chats)
- [msdyn_quotebookingservicetask_connections1](#BKMK_msdyn_quotebookingservicetask_connections1)
- [msdyn_quotebookingservicetask_connections2](#BKMK_msdyn_quotebookingservicetask_connections2)
- [msdyn_quotebookingservicetask_DuplicateBaseRecord](#BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord)
- [msdyn_quotebookingservicetask_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord)
- [msdyn_quotebookingservicetask_Emails](#BKMK_msdyn_quotebookingservicetask_Emails)
- [msdyn_quotebookingservicetask_Faxes](#BKMK_msdyn_quotebookingservicetask_Faxes)
- [msdyn_quotebookingservicetask_Letters](#BKMK_msdyn_quotebookingservicetask_Letters)
- [msdyn_quotebookingservicetask_MailboxTrackingFolders](#BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders)
- [msdyn_quotebookingservicetask_msdyn_bookingalerts](#BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts)
- [msdyn_quotebookingservicetask_msdyn_copilottranscripts](#BKMK_msdyn_quotebookingservicetask_msdyn_copilottranscripts)
- [msdyn_quotebookingservicetask_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems)
- [msdyn_quotebookingservicetask_msdyn_ocsessions](#BKMK_msdyn_quotebookingservicetask_msdyn_ocsessions)
- [msdyn_quotebookingservicetask_msfp_alerts](#BKMK_msdyn_quotebookingservicetask_msfp_alerts)
- [msdyn_quotebookingservicetask_msfp_surveyinvites](#BKMK_msdyn_quotebookingservicetask_msfp_surveyinvites)
- [msdyn_quotebookingservicetask_msfp_surveyresponses](#BKMK_msdyn_quotebookingservicetask_msfp_surveyresponses)
- [msdyn_quotebookingservicetask_PhoneCalls](#BKMK_msdyn_quotebookingservicetask_PhoneCalls)
- [msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingservicetask_ProcessSession](#BKMK_msdyn_quotebookingservicetask_ProcessSession)
- [msdyn_quotebookingservicetask_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters)
- [msdyn_quotebookingservicetask_ServiceAppointments](#BKMK_msdyn_quotebookingservicetask_ServiceAppointments)
- [msdyn_quotebookingservicetask_SocialActivities](#BKMK_msdyn_quotebookingservicetask_SocialActivities)
- [msdyn_quotebookingservicetask_SyncErrors](#BKMK_msdyn_quotebookingservicetask_SyncErrors)
- [msdyn_quotebookingservicetask_Tasks](#BKMK_msdyn_quotebookingservicetask_Tasks)

### <a name="BKMK_msdyn_quotebookingservicetask_ActivityPointers"></a> msdyn_quotebookingservicetask_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_quotebookingservicetask_ActivityPointers](activitypointer.md#BKMK_msdyn_quotebookingservicetask_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_adx_inviteredemptions"></a> msdyn_quotebookingservicetask_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_quotebookingservicetask_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_quotebookingservicetask_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_adx_portalcomments"></a> msdyn_quotebookingservicetask_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_quotebookingservicetask_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_quotebookingservicetask_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_Annotations"></a> msdyn_quotebookingservicetask_Annotations

Many-To-One Relationship: [annotation msdyn_quotebookingservicetask_Annotations](annotation.md#BKMK_msdyn_quotebookingservicetask_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_Appointments"></a> msdyn_quotebookingservicetask_Appointments

Many-To-One Relationship: [appointment msdyn_quotebookingservicetask_Appointments](appointment.md#BKMK_msdyn_quotebookingservicetask_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_AsyncOperations"></a> msdyn_quotebookingservicetask_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_quotebookingservicetask_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingservicetask_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures"></a> msdyn_quotebookingservicetask_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_quotebookingservicetask_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_chats"></a> msdyn_quotebookingservicetask_chats

Many-To-One Relationship: [chat msdyn_quotebookingservicetask_chats](chat.md#BKMK_msdyn_quotebookingservicetask_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_connections1"></a> msdyn_quotebookingservicetask_connections1

Many-To-One Relationship: [connection msdyn_quotebookingservicetask_connections1](connection.md#BKMK_msdyn_quotebookingservicetask_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_connections2"></a> msdyn_quotebookingservicetask_connections2

Many-To-One Relationship: [connection msdyn_quotebookingservicetask_connections2](connection.md#BKMK_msdyn_quotebookingservicetask_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord"></a> msdyn_quotebookingservicetask_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_quotebookingservicetask_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord"></a> msdyn_quotebookingservicetask_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_quotebookingservicetask_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_Emails"></a> msdyn_quotebookingservicetask_Emails

Many-To-One Relationship: [email msdyn_quotebookingservicetask_Emails](email.md#BKMK_msdyn_quotebookingservicetask_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_Faxes"></a> msdyn_quotebookingservicetask_Faxes

Many-To-One Relationship: [fax msdyn_quotebookingservicetask_Faxes](fax.md#BKMK_msdyn_quotebookingservicetask_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_Letters"></a> msdyn_quotebookingservicetask_Letters

Many-To-One Relationship: [letter msdyn_quotebookingservicetask_Letters](letter.md#BKMK_msdyn_quotebookingservicetask_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders"></a> msdyn_quotebookingservicetask_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_quotebookingservicetask_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts"></a> msdyn_quotebookingservicetask_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_quotebookingservicetask_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_quotebookingservicetask_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_copilottranscripts"></a> msdyn_quotebookingservicetask_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_quotebookingservicetask_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_quotebookingservicetask_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems"></a> msdyn_quotebookingservicetask_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_quotebookingservicetask_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_quotebookingservicetask_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_msdyn_ocsessions"></a> msdyn_quotebookingservicetask_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_quotebookingservicetask_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_quotebookingservicetask_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_msfp_alerts"></a> msdyn_quotebookingservicetask_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_quotebookingservicetask_msfp_alerts](msfp_alert.md#BKMK_msdyn_quotebookingservicetask_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_msfp_surveyinvites"></a> msdyn_quotebookingservicetask_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_quotebookingservicetask_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_quotebookingservicetask_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_msfp_surveyresponses"></a> msdyn_quotebookingservicetask_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_quotebookingservicetask_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_quotebookingservicetask_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_PhoneCalls"></a> msdyn_quotebookingservicetask_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_quotebookingservicetask_PhoneCalls](phonecall.md#BKMK_msdyn_quotebookingservicetask_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_ProcessSession"></a> msdyn_quotebookingservicetask_ProcessSession

Many-To-One Relationship: [processsession msdyn_quotebookingservicetask_ProcessSession](processsession.md#BKMK_msdyn_quotebookingservicetask_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters"></a> msdyn_quotebookingservicetask_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_quotebookingservicetask_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_quotebookingservicetask_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_ServiceAppointments"></a> msdyn_quotebookingservicetask_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_quotebookingservicetask_ServiceAppointments](serviceappointment.md#BKMK_msdyn_quotebookingservicetask_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_SocialActivities"></a> msdyn_quotebookingservicetask_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_quotebookingservicetask_SocialActivities](socialactivity.md#BKMK_msdyn_quotebookingservicetask_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_SyncErrors"></a> msdyn_quotebookingservicetask_SyncErrors

Many-To-One Relationship: [syncerror msdyn_quotebookingservicetask_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingservicetask_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingservicetask_Tasks"></a> msdyn_quotebookingservicetask_Tasks

Many-To-One Relationship: [task msdyn_quotebookingservicetask_Tasks](task.md#BKMK_msdyn_quotebookingservicetask_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingservicetask_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

