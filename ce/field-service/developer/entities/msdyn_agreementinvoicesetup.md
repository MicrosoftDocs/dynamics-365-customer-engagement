---
title: "Agreement Invoice Setup (msdyn_agreementinvoicesetup) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Agreement Invoice Setup (msdyn_agreementinvoicesetup) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Agreement Invoice Setup (msdyn_agreementinvoicesetup) table/entity reference

Specify the invoices for this agreement.

## Messages

The following table lists the messages for the Agreement Invoice Setup (msdyn_agreementinvoicesetup) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_agreementinvoicesetups(*msdyn_agreementinvoicesetupid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_agreementinvoicesetups<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agreementinvoicesetups(*msdyn_agreementinvoicesetupid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_agreementinvoicesetups(*msdyn_agreementinvoicesetupid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agreementinvoicesetups<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_agreementinvoicesetups(*msdyn_agreementinvoicesetupid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_agreementinvoicesetups(*msdyn_agreementinvoicesetupid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_agreementinvoicesetups(*msdyn_agreementinvoicesetupid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Agreement Invoice Setup (msdyn_agreementinvoicesetup) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agreement Invoice Setup (msdyn_agreementinvoicesetup) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agreement Invoice Setup** |
| **DisplayCollectionName** | **Agreement Invoice Setups** |
| **SchemaName** | `msdyn_agreementinvoicesetup` |
| **CollectionSchemaName** | `msdyn_agreementinvoicesetups` |
| **EntitySetName** | `msdyn_agreementinvoicesetups`|
| **LogicalName** | `msdyn_agreementinvoicesetup` |
| **LogicalCollectionName** | `msdyn_agreementinvoicesetups` |
| **PrimaryIdAttribute** | `msdyn_agreementinvoicesetupid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_agreementinvoicesetupId](#BKMK_msdyn_agreementinvoicesetupId)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PostponeGenerationUntil](#BKMK_msdyn_PostponeGenerationUntil)
- [msdyn_ProcessStartedOn](#BKMK_msdyn_ProcessStartedOn)
- [msdyn_RecurrenceSettings](#BKMK_msdyn_RecurrenceSettings)
- [msdyn_Revision](#BKMK_msdyn_Revision)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

|Property|Value|
|---|---|
|Description|**Agreement this Invoice Setup relates to**|
|DisplayName|**Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreement`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_agreement|

### <a name="BKMK_msdyn_agreementinvoicesetupId"></a> msdyn_agreementinvoicesetupId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Agreement Invoice Setup**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementinvoicesetupid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**Type a description of this invoice setup.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
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

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
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

### <a name="BKMK_msdyn_PostponeGenerationUntil"></a> msdyn_PostponeGenerationUntil

|Property|Value|
|---|---|
|Description|**Intended for internal use. Manipulating values in this field is not supported and can lead to unexpected system behavior.**|
|DisplayName|**Postpone Generation Until**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postponegenerationuntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ProcessStartedOn"></a> msdyn_ProcessStartedOn

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Process Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processstartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_RecurrenceSettings"></a> msdyn_RecurrenceSettings

|Property|Value|
|---|---|
|Description|**Stores the invoice recurrence settings.**|
|DisplayName|**Recurrence Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencesettings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_Revision"></a> msdyn_Revision

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Revision**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_revision`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the ID of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the ID of the stage where the entity is located.**|
|DisplayName|**Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Agreement Invoice Setup**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agreementinvoicesetup_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Agreement Invoice Setup**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agreementinvoicesetup_statuscode`|

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

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.**|
|DisplayName|**Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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

- [business_unit_msdyn_agreementinvoicesetup](#BKMK_business_unit_msdyn_agreementinvoicesetup)
- [lk_msdyn_agreementinvoicesetup_createdby](#BKMK_lk_msdyn_agreementinvoicesetup_createdby)
- [lk_msdyn_agreementinvoicesetup_createdonbehalfby](#BKMK_lk_msdyn_agreementinvoicesetup_createdonbehalfby)
- [lk_msdyn_agreementinvoicesetup_modifiedby](#BKMK_lk_msdyn_agreementinvoicesetup_modifiedby)
- [lk_msdyn_agreementinvoicesetup_modifiedonbehalfby](#BKMK_lk_msdyn_agreementinvoicesetup_modifiedonbehalfby)
- [msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement)
- [owner_msdyn_agreementinvoicesetup](#BKMK_owner_msdyn_agreementinvoicesetup)
- [processstage_msdyn_agreementinvoicesetup](#BKMK_processstage_msdyn_agreementinvoicesetup)
- [team_msdyn_agreementinvoicesetup](#BKMK_team_msdyn_agreementinvoicesetup)
- [user_msdyn_agreementinvoicesetup](#BKMK_user_msdyn_agreementinvoicesetup)

### <a name="BKMK_business_unit_msdyn_agreementinvoicesetup"></a> business_unit_msdyn_agreementinvoicesetup

One-To-Many Relationship: [businessunit business_unit_msdyn_agreementinvoicesetup](businessunit.md#BKMK_business_unit_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementinvoicesetup_createdby"></a> lk_msdyn_agreementinvoicesetup_createdby

One-To-Many Relationship: [systemuser lk_msdyn_agreementinvoicesetup_createdby](systemuser.md#BKMK_lk_msdyn_agreementinvoicesetup_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementinvoicesetup_createdonbehalfby"></a> lk_msdyn_agreementinvoicesetup_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agreementinvoicesetup_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementinvoicesetup_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementinvoicesetup_modifiedby"></a> lk_msdyn_agreementinvoicesetup_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_agreementinvoicesetup_modifiedby](systemuser.md#BKMK_lk_msdyn_agreementinvoicesetup_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementinvoicesetup_modifiedonbehalfby"></a> lk_msdyn_agreementinvoicesetup_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agreementinvoicesetup_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementinvoicesetup_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement

One-To-Many Relationship: [msdyn_agreement msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_agreementinvoicesetup"></a> owner_msdyn_agreementinvoicesetup

One-To-Many Relationship: [owner owner_msdyn_agreementinvoicesetup](owner.md#BKMK_owner_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_msdyn_agreementinvoicesetup"></a> processstage_msdyn_agreementinvoicesetup

One-To-Many Relationship: [processstage processstage_msdyn_agreementinvoicesetup](processstage.md#BKMK_processstage_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_agreementinvoicesetup"></a> team_msdyn_agreementinvoicesetup

One-To-Many Relationship: [team team_msdyn_agreementinvoicesetup](team.md#BKMK_team_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_agreementinvoicesetup"></a> user_msdyn_agreementinvoicesetup

One-To-Many Relationship: [systemuser user_msdyn_agreementinvoicesetup](systemuser.md#BKMK_user_msdyn_agreementinvoicesetup)

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

- [bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [msdyn_agreementinvoicesetup_ActivityPointers](#BKMK_msdyn_agreementinvoicesetup_ActivityPointers)
- [msdyn_agreementinvoicesetup_adx_inviteredemptions](#BKMK_msdyn_agreementinvoicesetup_adx_inviteredemptions)
- [msdyn_agreementinvoicesetup_adx_portalcomments](#BKMK_msdyn_agreementinvoicesetup_adx_portalcomments)
- [msdyn_agreementinvoicesetup_Annotations](#BKMK_msdyn_agreementinvoicesetup_Annotations)
- [msdyn_agreementinvoicesetup_Appointments](#BKMK_msdyn_agreementinvoicesetup_Appointments)
- [msdyn_agreementinvoicesetup_AsyncOperations](#BKMK_msdyn_agreementinvoicesetup_AsyncOperations)
- [msdyn_agreementinvoicesetup_BulkDeleteFailures](#BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures)
- [msdyn_agreementinvoicesetup_chats](#BKMK_msdyn_agreementinvoicesetup_chats)
- [msdyn_agreementinvoicesetup_connections1](#BKMK_msdyn_agreementinvoicesetup_connections1)
- [msdyn_agreementinvoicesetup_connections2](#BKMK_msdyn_agreementinvoicesetup_connections2)
- [msdyn_agreementinvoicesetup_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord)
- [msdyn_agreementinvoicesetup_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord)
- [msdyn_agreementinvoicesetup_Emails](#BKMK_msdyn_agreementinvoicesetup_Emails)
- [msdyn_agreementinvoicesetup_Faxes](#BKMK_msdyn_agreementinvoicesetup_Faxes)
- [msdyn_agreementinvoicesetup_Letters](#BKMK_msdyn_agreementinvoicesetup_Letters)
- [msdyn_agreementinvoicesetup_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders)
- [msdyn_agreementinvoicesetup_msdyn_bookingalerts](#BKMK_msdyn_agreementinvoicesetup_msdyn_bookingalerts)
- [msdyn_agreementinvoicesetup_msdyn_copilottranscripts](#BKMK_msdyn_agreementinvoicesetup_msdyn_copilottranscripts)
- [msdyn_agreementinvoicesetup_msdyn_ocliveworkitems](#BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems)
- [msdyn_agreementinvoicesetup_msdyn_ocsessions](#BKMK_msdyn_agreementinvoicesetup_msdyn_ocsessions)
- [msdyn_agreementinvoicesetup_msfp_alerts](#BKMK_msdyn_agreementinvoicesetup_msfp_alerts)
- [msdyn_agreementinvoicesetup_msfp_surveyinvites](#BKMK_msdyn_agreementinvoicesetup_msfp_surveyinvites)
- [msdyn_agreementinvoicesetup_msfp_surveyresponses](#BKMK_msdyn_agreementinvoicesetup_msfp_surveyresponses)
- [msdyn_agreementinvoicesetup_PhoneCalls](#BKMK_msdyn_agreementinvoicesetup_PhoneCalls)
- [msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoicesetup_ProcessSession](#BKMK_msdyn_agreementinvoicesetup_ProcessSession)
- [msdyn_agreementinvoicesetup_QueueItems](#BKMK_msdyn_agreementinvoicesetup_QueueItems)
- [msdyn_agreementinvoicesetup_RecurringAppointmentMasters](#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters)
- [msdyn_agreementinvoicesetup_ServiceAppointments](#BKMK_msdyn_agreementinvoicesetup_ServiceAppointments)
- [msdyn_agreementinvoicesetup_SharePointDocumentLocations](#BKMK_msdyn_agreementinvoicesetup_SharePointDocumentLocations)
- [msdyn_agreementinvoicesetup_SocialActivities](#BKMK_msdyn_agreementinvoicesetup_SocialActivities)
- [msdyn_agreementinvoicesetup_SyncErrors](#BKMK_msdyn_agreementinvoicesetup_SyncErrors)
- [msdyn_agreementinvoicesetup_Tasks](#BKMK_msdyn_agreementinvoicesetup_Tasks)
- [msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup](#BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup)
- [msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup](#BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup)

### <a name="BKMK_bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

Many-To-One Relationship: [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|ReferencingAttribute|`bpf_msdyn_agreementinvoicesetupid`|
|ReferencedEntityNavigationPropertyName|`bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: msdyn_agreementinvoicesetup<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_ActivityPointers"></a> msdyn_agreementinvoicesetup_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_agreementinvoicesetup_ActivityPointers](activitypointer.md#BKMK_msdyn_agreementinvoicesetup_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_adx_inviteredemptions"></a> msdyn_agreementinvoicesetup_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_agreementinvoicesetup_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_agreementinvoicesetup_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_adx_portalcomments"></a> msdyn_agreementinvoicesetup_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_agreementinvoicesetup_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_agreementinvoicesetup_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Annotations"></a> msdyn_agreementinvoicesetup_Annotations

Many-To-One Relationship: [annotation msdyn_agreementinvoicesetup_Annotations](annotation.md#BKMK_msdyn_agreementinvoicesetup_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Appointments"></a> msdyn_agreementinvoicesetup_Appointments

Many-To-One Relationship: [appointment msdyn_agreementinvoicesetup_Appointments](appointment.md#BKMK_msdyn_agreementinvoicesetup_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_AsyncOperations"></a> msdyn_agreementinvoicesetup_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_agreementinvoicesetup_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreementinvoicesetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures"></a> msdyn_agreementinvoicesetup_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_agreementinvoicesetup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_chats"></a> msdyn_agreementinvoicesetup_chats

Many-To-One Relationship: [chat msdyn_agreementinvoicesetup_chats](chat.md#BKMK_msdyn_agreementinvoicesetup_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_connections1"></a> msdyn_agreementinvoicesetup_connections1

Many-To-One Relationship: [connection msdyn_agreementinvoicesetup_connections1](connection.md#BKMK_msdyn_agreementinvoicesetup_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_connections2"></a> msdyn_agreementinvoicesetup_connections2

Many-To-One Relationship: [connection msdyn_agreementinvoicesetup_connections2](connection.md#BKMK_msdyn_agreementinvoicesetup_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord"></a> msdyn_agreementinvoicesetup_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_agreementinvoicesetup_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord"></a> msdyn_agreementinvoicesetup_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_agreementinvoicesetup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Emails"></a> msdyn_agreementinvoicesetup_Emails

Many-To-One Relationship: [email msdyn_agreementinvoicesetup_Emails](email.md#BKMK_msdyn_agreementinvoicesetup_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Faxes"></a> msdyn_agreementinvoicesetup_Faxes

Many-To-One Relationship: [fax msdyn_agreementinvoicesetup_Faxes](fax.md#BKMK_msdyn_agreementinvoicesetup_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Letters"></a> msdyn_agreementinvoicesetup_Letters

Many-To-One Relationship: [letter msdyn_agreementinvoicesetup_Letters](letter.md#BKMK_msdyn_agreementinvoicesetup_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders"></a> msdyn_agreementinvoicesetup_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_agreementinvoicesetup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_bookingalerts"></a> msdyn_agreementinvoicesetup_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_agreementinvoicesetup_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreementinvoicesetup_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_copilottranscripts"></a> msdyn_agreementinvoicesetup_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_agreementinvoicesetup_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_agreementinvoicesetup_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems"></a> msdyn_agreementinvoicesetup_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_agreementinvoicesetup_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_agreementinvoicesetup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msdyn_ocsessions"></a> msdyn_agreementinvoicesetup_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_agreementinvoicesetup_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_agreementinvoicesetup_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msfp_alerts"></a> msdyn_agreementinvoicesetup_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_agreementinvoicesetup_msfp_alerts](msfp_alert.md#BKMK_msdyn_agreementinvoicesetup_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msfp_surveyinvites"></a> msdyn_agreementinvoicesetup_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_agreementinvoicesetup_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_agreementinvoicesetup_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_msfp_surveyresponses"></a> msdyn_agreementinvoicesetup_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_agreementinvoicesetup_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_agreementinvoicesetup_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_PhoneCalls"></a> msdyn_agreementinvoicesetup_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_agreementinvoicesetup_PhoneCalls](phonecall.md#BKMK_msdyn_agreementinvoicesetup_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_ProcessSession"></a> msdyn_agreementinvoicesetup_ProcessSession

Many-To-One Relationship: [processsession msdyn_agreementinvoicesetup_ProcessSession](processsession.md#BKMK_msdyn_agreementinvoicesetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_QueueItems"></a> msdyn_agreementinvoicesetup_QueueItems

Many-To-One Relationship: [queueitem msdyn_agreementinvoicesetup_QueueItems](queueitem.md#BKMK_msdyn_agreementinvoicesetup_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters"></a> msdyn_agreementinvoicesetup_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_agreementinvoicesetup_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreementinvoicesetup_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_ServiceAppointments"></a> msdyn_agreementinvoicesetup_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_agreementinvoicesetup_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreementinvoicesetup_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_SharePointDocumentLocations"></a> msdyn_agreementinvoicesetup_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_agreementinvoicesetup_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_agreementinvoicesetup_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_SocialActivities"></a> msdyn_agreementinvoicesetup_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_agreementinvoicesetup_SocialActivities](socialactivity.md#BKMK_msdyn_agreementinvoicesetup_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_SyncErrors"></a> msdyn_agreementinvoicesetup_SyncErrors

Many-To-One Relationship: [syncerror msdyn_agreementinvoicesetup_SyncErrors](syncerror.md#BKMK_msdyn_agreementinvoicesetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementinvoicesetup_Tasks"></a> msdyn_agreementinvoicesetup_Tasks

Many-To-One Relationship: [task msdyn_agreementinvoicesetup_Tasks](task.md#BKMK_msdyn_agreementinvoicesetup_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementinvoicesetup_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup"></a> msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup

Many-To-One Relationship: [msdyn_agreementinvoicedate msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup](msdyn_agreementinvoicedate.md#BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicedate`|
|ReferencingAttribute|`msdyn_invoicesetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoicedate_InvoiceSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Invoice Dates<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup"></a> msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup

Many-To-One Relationship: [msdyn_agreementinvoiceproduct msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`msdyn_agreementinvoicesetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreementinvoicesetup_msdyn_agreementinvoiceproduct_AgreementInvoiceSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Invoice Products<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

