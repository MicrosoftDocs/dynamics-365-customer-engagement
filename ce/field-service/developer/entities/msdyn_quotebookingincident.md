---
title: "Quote Booking Incident (msdyn_quotebookingincident) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Quote Booking Incident (msdyn_quotebookingincident) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Quote Booking Incident (msdyn_quotebookingincident) table/entity reference

Stores the Incidents associated with Quote and Quote Booking Setup

## Messages

The following table lists the messages for the Quote Booking Incident (msdyn_quotebookingincident) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_quotebookingincidents<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_FieldServiceQuoteBookingIncidentCopyAction`<br />Event: False |**msdyn_FieldServiceQuoteBookingIncidentCopyAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_quotebookingincidents<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_quotebookingincidents(*msdyn_quotebookingincidentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Quote Booking Incident (msdyn_quotebookingincident) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Quote Booking Incident (msdyn_quotebookingincident) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Quote Booking Incident** |
| **DisplayCollectionName** | **Quote Booking Incidents** |
| **SchemaName** | `msdyn_quotebookingincident` |
| **CollectionSchemaName** | `msdyn_quotebookingincidents` |
| **EntitySetName** | `msdyn_quotebookingincidents`|
| **LogicalName** | `msdyn_quotebookingincident` |
| **LogicalCollectionName** | `msdyn_quotebookingincidents` |
| **PrimaryIdAttribute** | `msdyn_quotebookingincidentid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customerasset](#BKMK_msdyn_customerasset)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_estimatedduration](#BKMK_msdyn_estimatedduration)
- [msdyn_incidentitemscopied](#BKMK_msdyn_incidentitemscopied)
- [msdyn_incidenttype](#BKMK_msdyn_incidenttype)
- [msdyn_internalflags](#BKMK_msdyn_internalflags)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Quote](#BKMK_msdyn_Quote)
- [msdyn_quotebookingincidentId](#BKMK_msdyn_quotebookingincidentId)
- [msdyn_quotebookingsetup](#BKMK_msdyn_quotebookingsetup)
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
|Description|**Customer Asset related to this incident reported**|
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
|Description|**Enter the description of the incident**|
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
|MaxLength|8000|

### <a name="BKMK_msdyn_estimatedduration"></a> msdyn_estimatedduration

|Property|Value|
|---|---|
|Description|**Shows the time estimated to resolve this incident.**|
|DisplayName|**Estimated Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_incidentitemscopied"></a> msdyn_incidentitemscopied

|Property|Value|
|---|---|
|Description|**If "yes", copied  service task, products, and services that are associated with the incident to quote booking setup**|
|DisplayName|**Incident Items Copied**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidentitemscopied`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_quotebookingincident_msdyn_incidentitemscopied`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_incidenttype"></a> msdyn_incidenttype

|Property|Value|
|---|---|
|Description|**Shows the incident type associated with the quote booking incident.**|
|DisplayName|**Incident Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttype`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_incidenttype|

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

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Displays name of the quote booking incident**|
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

### <a name="BKMK_msdyn_Quote"></a> msdyn_Quote

|Property|Value|
|---|---|
|Description|**Shows the quote associated with the agreement booking incident.**|
|DisplayName|**Quote**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quote`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|quote|

### <a name="BKMK_msdyn_quotebookingincidentId"></a> msdyn_quotebookingincidentId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Quote Booking Incident**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingincidentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_quotebookingsetup"></a> msdyn_quotebookingsetup

|Property|Value|
|---|---|
|Description|**Shows the quote booking setup associated with the quote booking incident.**|
|DisplayName|**Quote Booking Setup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingsetup`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_quotebookingsetup|

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
|Description|**Status of the Quote Booking Incident**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_quotebookingincident_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Quote Booking Incident**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_quotebookingincident_statuscode`|

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

- [business_unit_msdyn_quotebookingincident](#BKMK_business_unit_msdyn_quotebookingincident)
- [lk_msdyn_quotebookingincident_createdby](#BKMK_lk_msdyn_quotebookingincident_createdby)
- [lk_msdyn_quotebookingincident_createdonbehalfby](#BKMK_lk_msdyn_quotebookingincident_createdonbehalfby)
- [lk_msdyn_quotebookingincident_modifiedby](#BKMK_lk_msdyn_quotebookingincident_modifiedby)
- [lk_msdyn_quotebookingincident_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingincident_modifiedonbehalfby)
- [msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset)
- [msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup)
- [msdyn_quote_msdyn_quotebookingincident_Quote](#BKMK_msdyn_quote_msdyn_quotebookingincident_Quote)
- [owner_msdyn_quotebookingincident](#BKMK_owner_msdyn_quotebookingincident)
- [team_msdyn_quotebookingincident](#BKMK_team_msdyn_quotebookingincident)
- [user_msdyn_quotebookingincident](#BKMK_user_msdyn_quotebookingincident)

### <a name="BKMK_business_unit_msdyn_quotebookingincident"></a> business_unit_msdyn_quotebookingincident

One-To-Many Relationship: [businessunit business_unit_msdyn_quotebookingincident](businessunit.md#BKMK_business_unit_msdyn_quotebookingincident)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingincident_createdby"></a> lk_msdyn_quotebookingincident_createdby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingincident_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingincident_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingincident_createdonbehalfby"></a> lk_msdyn_quotebookingincident_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingincident_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingincident_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingincident_modifiedby"></a> lk_msdyn_quotebookingincident_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingincident_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingincident_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingincident_modifiedonbehalfby"></a> lk_msdyn_quotebookingincident_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingincident_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingincident_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType

One-To-Many Relationship: [msdyn_incidenttype msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencingEntityNavigationPropertyName|`msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup

One-To-Many Relationship: [msdyn_quotebookingsetup msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](msdyn_quotebookingsetup.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_quotebookingsetup`|
|ReferencedAttribute|`msdyn_quotebookingsetupid`|
|ReferencingAttribute|`msdyn_quotebookingsetup`|
|ReferencingEntityNavigationPropertyName|`msdyn_quotebookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quote_msdyn_quotebookingincident_Quote"></a> msdyn_quote_msdyn_quotebookingincident_Quote

One-To-Many Relationship: [quote msdyn_quote_msdyn_quotebookingincident_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingincident_Quote)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`msdyn_quote`|
|ReferencingEntityNavigationPropertyName|`msdyn_Quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_quotebookingincident"></a> owner_msdyn_quotebookingincident

One-To-Many Relationship: [owner owner_msdyn_quotebookingincident](owner.md#BKMK_owner_msdyn_quotebookingincident)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_quotebookingincident"></a> team_msdyn_quotebookingincident

One-To-Many Relationship: [team team_msdyn_quotebookingincident](team.md#BKMK_team_msdyn_quotebookingincident)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_quotebookingincident"></a> user_msdyn_quotebookingincident

One-To-Many Relationship: [systemuser user_msdyn_quotebookingincident](systemuser.md#BKMK_user_msdyn_quotebookingincident)

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

- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident)
- [msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident](#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident)
- [msdyn_quotebookingincident_ActivityPointers](#BKMK_msdyn_quotebookingincident_ActivityPointers)
- [msdyn_quotebookingincident_adx_inviteredemptions](#BKMK_msdyn_quotebookingincident_adx_inviteredemptions)
- [msdyn_quotebookingincident_adx_portalcomments](#BKMK_msdyn_quotebookingincident_adx_portalcomments)
- [msdyn_quotebookingincident_Annotations](#BKMK_msdyn_quotebookingincident_Annotations)
- [msdyn_quotebookingincident_Appointments](#BKMK_msdyn_quotebookingincident_Appointments)
- [msdyn_quotebookingincident_AsyncOperations](#BKMK_msdyn_quotebookingincident_AsyncOperations)
- [msdyn_quotebookingincident_BulkDeleteFailures](#BKMK_msdyn_quotebookingincident_BulkDeleteFailures)
- [msdyn_quotebookingincident_chats](#BKMK_msdyn_quotebookingincident_chats)
- [msdyn_quotebookingincident_connections1](#BKMK_msdyn_quotebookingincident_connections1)
- [msdyn_quotebookingincident_connections2](#BKMK_msdyn_quotebookingincident_connections2)
- [msdyn_quotebookingincident_DuplicateBaseRecord](#BKMK_msdyn_quotebookingincident_DuplicateBaseRecord)
- [msdyn_quotebookingincident_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord)
- [msdyn_quotebookingincident_Emails](#BKMK_msdyn_quotebookingincident_Emails)
- [msdyn_quotebookingincident_Faxes](#BKMK_msdyn_quotebookingincident_Faxes)
- [msdyn_quotebookingincident_Letters](#BKMK_msdyn_quotebookingincident_Letters)
- [msdyn_quotebookingincident_MailboxTrackingFolders](#BKMK_msdyn_quotebookingincident_MailboxTrackingFolders)
- [msdyn_quotebookingincident_msdyn_bookingalerts](#BKMK_msdyn_quotebookingincident_msdyn_bookingalerts)
- [msdyn_quotebookingincident_msdyn_copilottranscripts](#BKMK_msdyn_quotebookingincident_msdyn_copilottranscripts)
- [msdyn_quotebookingincident_msdyn_ocliveworkitems](#BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems)
- [msdyn_quotebookingincident_msdyn_ocsessions](#BKMK_msdyn_quotebookingincident_msdyn_ocsessions)
- [msdyn_quotebookingincident_msfp_alerts](#BKMK_msdyn_quotebookingincident_msfp_alerts)
- [msdyn_quotebookingincident_msfp_surveyinvites](#BKMK_msdyn_quotebookingincident_msfp_surveyinvites)
- [msdyn_quotebookingincident_msfp_surveyresponses](#BKMK_msdyn_quotebookingincident_msfp_surveyresponses)
- [msdyn_quotebookingincident_PhoneCalls](#BKMK_msdyn_quotebookingincident_PhoneCalls)
- [msdyn_quotebookingincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingincident_ProcessSession](#BKMK_msdyn_quotebookingincident_ProcessSession)
- [msdyn_quotebookingincident_RecurringAppointmentMasters](#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters)
- [msdyn_quotebookingincident_ServiceAppointments](#BKMK_msdyn_quotebookingincident_ServiceAppointments)
- [msdyn_quotebookingincident_SocialActivities](#BKMK_msdyn_quotebookingincident_SocialActivities)
- [msdyn_quotebookingincident_SyncErrors](#BKMK_msdyn_quotebookingincident_SyncErrors)
- [msdyn_quotebookingincident_Tasks](#BKMK_msdyn_quotebookingincident_Tasks)

### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident

Many-To-One Relationship: [msdyn_quotebookingproduct msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident](msdyn_quotebookingproduct.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`msdyn_quotebookingincident`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_quotebookingincident_msdyn_quotebookingproduct_QuoteBookingIncident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident

Many-To-One Relationship: [msdyn_quotebookingservice msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident](msdyn_quotebookingservice.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`msdyn_quotebookingincident`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_quotebookingincident_msdyn_quotebookingservice_QuoteBookingIncident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident"></a> msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident

Many-To-One Relationship: [msdyn_quotebookingservicetask msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident](msdyn_quotebookingservicetask.md#BKMK_msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservicetask`|
|ReferencingAttribute|`msdyn_quotebookingincident`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_quotebookingincident_msdyn_quotebookingservicetask_QuoteBookingIncident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_ActivityPointers"></a> msdyn_quotebookingincident_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_quotebookingincident_ActivityPointers](activitypointer.md#BKMK_msdyn_quotebookingincident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_adx_inviteredemptions"></a> msdyn_quotebookingincident_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_quotebookingincident_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_quotebookingincident_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_adx_portalcomments"></a> msdyn_quotebookingincident_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_quotebookingincident_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_quotebookingincident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_Annotations"></a> msdyn_quotebookingincident_Annotations

Many-To-One Relationship: [annotation msdyn_quotebookingincident_Annotations](annotation.md#BKMK_msdyn_quotebookingincident_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_Appointments"></a> msdyn_quotebookingincident_Appointments

Many-To-One Relationship: [appointment msdyn_quotebookingincident_Appointments](appointment.md#BKMK_msdyn_quotebookingincident_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_AsyncOperations"></a> msdyn_quotebookingincident_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_quotebookingincident_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingincident_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_BulkDeleteFailures"></a> msdyn_quotebookingincident_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_quotebookingincident_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingincident_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_chats"></a> msdyn_quotebookingincident_chats

Many-To-One Relationship: [chat msdyn_quotebookingincident_chats](chat.md#BKMK_msdyn_quotebookingincident_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_connections1"></a> msdyn_quotebookingincident_connections1

Many-To-One Relationship: [connection msdyn_quotebookingincident_connections1](connection.md#BKMK_msdyn_quotebookingincident_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_connections2"></a> msdyn_quotebookingincident_connections2

Many-To-One Relationship: [connection msdyn_quotebookingincident_connections2](connection.md#BKMK_msdyn_quotebookingincident_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_DuplicateBaseRecord"></a> msdyn_quotebookingincident_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_quotebookingincident_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingincident_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord"></a> msdyn_quotebookingincident_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_quotebookingincident_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_Emails"></a> msdyn_quotebookingincident_Emails

Many-To-One Relationship: [email msdyn_quotebookingincident_Emails](email.md#BKMK_msdyn_quotebookingincident_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_Faxes"></a> msdyn_quotebookingincident_Faxes

Many-To-One Relationship: [fax msdyn_quotebookingincident_Faxes](fax.md#BKMK_msdyn_quotebookingincident_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_Letters"></a> msdyn_quotebookingincident_Letters

Many-To-One Relationship: [letter msdyn_quotebookingincident_Letters](letter.md#BKMK_msdyn_quotebookingincident_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_MailboxTrackingFolders"></a> msdyn_quotebookingincident_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_quotebookingincident_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingincident_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_msdyn_bookingalerts"></a> msdyn_quotebookingincident_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_quotebookingincident_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_quotebookingincident_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_msdyn_copilottranscripts"></a> msdyn_quotebookingincident_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_quotebookingincident_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_quotebookingincident_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems"></a> msdyn_quotebookingincident_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_quotebookingincident_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_quotebookingincident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_msdyn_ocsessions"></a> msdyn_quotebookingincident_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_quotebookingincident_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_quotebookingincident_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_msfp_alerts"></a> msdyn_quotebookingincident_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_quotebookingincident_msfp_alerts](msfp_alert.md#BKMK_msdyn_quotebookingincident_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_msfp_surveyinvites"></a> msdyn_quotebookingincident_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_quotebookingincident_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_quotebookingincident_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_msfp_surveyresponses"></a> msdyn_quotebookingincident_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_quotebookingincident_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_quotebookingincident_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_PhoneCalls"></a> msdyn_quotebookingincident_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_quotebookingincident_PhoneCalls](phonecall.md#BKMK_msdyn_quotebookingincident_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingincident_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_quotebookingincident_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_ProcessSession"></a> msdyn_quotebookingincident_ProcessSession

Many-To-One Relationship: [processsession msdyn_quotebookingincident_ProcessSession](processsession.md#BKMK_msdyn_quotebookingincident_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters"></a> msdyn_quotebookingincident_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_quotebookingincident_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_quotebookingincident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_ServiceAppointments"></a> msdyn_quotebookingincident_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_quotebookingincident_ServiceAppointments](serviceappointment.md#BKMK_msdyn_quotebookingincident_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_SocialActivities"></a> msdyn_quotebookingincident_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_quotebookingincident_SocialActivities](socialactivity.md#BKMK_msdyn_quotebookingincident_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_SyncErrors"></a> msdyn_quotebookingincident_SyncErrors

Many-To-One Relationship: [syncerror msdyn_quotebookingincident_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingincident_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingincident_Tasks"></a> msdyn_quotebookingincident_Tasks

Many-To-One Relationship: [task msdyn_quotebookingincident_Tasks](task.md#BKMK_msdyn_quotebookingincident_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingincident_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

