---
title: "Field Service Demo Data Job (msdyn_fieldservicedemodatajob) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Field Service Demo Data Job (msdyn_fieldservicedemodatajob) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Field Service Demo Data Job (msdyn_fieldservicedemodatajob) table/entity reference



## Messages

The following table lists the messages for the Field Service Demo Data Job (msdyn_fieldservicedemodatajob) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_fieldservicedemodatajobs(*msdyn_fieldservicedemodatajobid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_fieldservicedemodatajobs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_fieldservicedemodatajobs(*msdyn_fieldservicedemodatajobid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_fieldservicedemodatajobs(*msdyn_fieldservicedemodatajobid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_fieldservicedemodatajobs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_fieldservicedemodatajobs(*msdyn_fieldservicedemodatajobid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_fieldservicedemodatajobs(*msdyn_fieldservicedemodatajobid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_fieldservicedemodatajobs(*msdyn_fieldservicedemodatajobid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Field Service Demo Data Job (msdyn_fieldservicedemodatajob) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Field Service Demo Data Job (msdyn_fieldservicedemodatajob) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Field Service Demo Data Job** |
| **DisplayCollectionName** | **Field Service Demo Data Jobs** |
| **SchemaName** | `msdyn_fieldservicedemodatajob` |
| **CollectionSchemaName** | `msdyn_fieldservicedemodatajobs` |
| **EntitySetName** | `msdyn_fieldservicedemodatajobs`|
| **LogicalName** | `msdyn_fieldservicedemodatajob` |
| **LogicalCollectionName** | `msdyn_fieldservicedemodatajobs` |
| **PrimaryIdAttribute** | `msdyn_fieldservicedemodatajobid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_countofremainingrecords](#BKMK_msdyn_countofremainingrecords)
- [msdyn_customentitynumber](#BKMK_msdyn_customentitynumber)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_dynamicsdataoptions](#BKMK_msdyn_dynamicsdataoptions)
- [msdyn_entitytype](#BKMK_msdyn_entitytype)
- [msdyn_errormessage](#BKMK_msdyn_errormessage)
- [msdyn_fieldservicedemodatajobId](#BKMK_msdyn_fieldservicedemodatajobId)
- [msdyn_flowstatus](#BKMK_msdyn_flowstatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_sourceoftrigger](#BKMK_msdyn_sourceoftrigger)
- [msdyn_statusofoperation](#BKMK_msdyn_statusofoperation)
- [msdyn_triggercount](#BKMK_msdyn_triggercount)
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

### <a name="BKMK_msdyn_countofremainingrecords"></a> msdyn_countofremainingrecords

|Property|Value|
|---|---|
|Description||
|DisplayName|**Count Of Remaining Records**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_countofremainingrecords`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_customentitynumber"></a> msdyn_customentitynumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom Entity Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customentitynumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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

### <a name="BKMK_msdyn_dynamicsdataoptions"></a> msdyn_dynamicsdataoptions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Dynamics Data Options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dynamicsdataoptions`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_fieldservicedemodatajob_msdyn_dynamicsdataoptions`|

#### msdyn_dynamicsdataoptions Choices/Options

|Value|Label|
|---|---|
|700610000|**Create**|
|700610001|**Delete**|

### <a name="BKMK_msdyn_entitytype"></a> msdyn_entitytype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitytype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_fieldservicedemodatajob_msdyn_entitytype`|

#### msdyn_entitytype Choices/Options

|Value|Label|
|---|---|
|700610000|**Work Order**|
|700610001|**Bookable Resource Booking**|
|700610002|**IoT Alerts**|

### <a name="BKMK_msdyn_errormessage"></a> msdyn_errormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errormessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20000|

### <a name="BKMK_msdyn_fieldservicedemodatajobId"></a> msdyn_fieldservicedemodatajobId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Field Service Demo Data Job**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldservicedemodatajobid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_flowstatus"></a> msdyn_flowstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Flow status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_flowstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_fieldservicedemodatajob_msdyn_flowstatus`|

#### msdyn_flowstatus Choices/Options

|Value|Label|
|---|---|
|700610000|**Started**|
|700610001|**In Progress**|
|700610002|**Failed**|
|700610003|**Completed**|

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
|MaxLength|100|

### <a name="BKMK_msdyn_sourceoftrigger"></a> msdyn_sourceoftrigger

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source of trigger**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceoftrigger`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_fieldservicedemodatajob_msdyn_sourceoftrigger`|

#### msdyn_sourceoftrigger Choices/Options

|Value|Label|
|---|---|
|700610000|**Landing page load**|
|700610001|**Take a tour**|

### <a name="BKMK_msdyn_statusofoperation"></a> msdyn_statusofoperation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Status of Operation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statusofoperation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|700610002|
|GlobalChoiceName|`msdyn_fieldservicedemodatajob_msdyn_statusofoperation`|

#### msdyn_statusofoperation Choices/Options

|Value|Label|
|---|---|
|700610000|**InProgress**|
|700610001|**Failed**|
|700610002|**Not Started**|
|700610003|**Completed**|

### <a name="BKMK_msdyn_triggercount"></a> msdyn_triggercount

|Property|Value|
|---|---|
|Description||
|DisplayName|**TriggerCount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_triggercount`|
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
|Description|**Status of the Field Service Demo Data Job**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_fieldservicedemodatajob_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Field Service Demo Data Job**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_fieldservicedemodatajob_statuscode`|

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

- [business_unit_msdyn_fieldservicedemodatajob](#BKMK_business_unit_msdyn_fieldservicedemodatajob)
- [lk_msdyn_fieldservicedemodatajob_createdby](#BKMK_lk_msdyn_fieldservicedemodatajob_createdby)
- [lk_msdyn_fieldservicedemodatajob_createdonbehalfby](#BKMK_lk_msdyn_fieldservicedemodatajob_createdonbehalfby)
- [lk_msdyn_fieldservicedemodatajob_modifiedby](#BKMK_lk_msdyn_fieldservicedemodatajob_modifiedby)
- [lk_msdyn_fieldservicedemodatajob_modifiedonbehalfby](#BKMK_lk_msdyn_fieldservicedemodatajob_modifiedonbehalfby)
- [owner_msdyn_fieldservicedemodatajob](#BKMK_owner_msdyn_fieldservicedemodatajob)
- [team_msdyn_fieldservicedemodatajob](#BKMK_team_msdyn_fieldservicedemodatajob)
- [user_msdyn_fieldservicedemodatajob](#BKMK_user_msdyn_fieldservicedemodatajob)

### <a name="BKMK_business_unit_msdyn_fieldservicedemodatajob"></a> business_unit_msdyn_fieldservicedemodatajob

One-To-Many Relationship: [businessunit business_unit_msdyn_fieldservicedemodatajob](businessunit.md#BKMK_business_unit_msdyn_fieldservicedemodatajob)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicedemodatajob_createdby"></a> lk_msdyn_fieldservicedemodatajob_createdby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicedemodatajob_createdby](systemuser.md#BKMK_lk_msdyn_fieldservicedemodatajob_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicedemodatajob_createdonbehalfby"></a> lk_msdyn_fieldservicedemodatajob_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicedemodatajob_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicedemodatajob_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicedemodatajob_modifiedby"></a> lk_msdyn_fieldservicedemodatajob_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicedemodatajob_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldservicedemodatajob_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicedemodatajob_modifiedonbehalfby"></a> lk_msdyn_fieldservicedemodatajob_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicedemodatajob_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicedemodatajob_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_fieldservicedemodatajob"></a> owner_msdyn_fieldservicedemodatajob

One-To-Many Relationship: [owner owner_msdyn_fieldservicedemodatajob](owner.md#BKMK_owner_msdyn_fieldservicedemodatajob)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_fieldservicedemodatajob"></a> team_msdyn_fieldservicedemodatajob

One-To-Many Relationship: [team team_msdyn_fieldservicedemodatajob](team.md#BKMK_team_msdyn_fieldservicedemodatajob)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_fieldservicedemodatajob"></a> user_msdyn_fieldservicedemodatajob

One-To-Many Relationship: [systemuser user_msdyn_fieldservicedemodatajob](systemuser.md#BKMK_user_msdyn_fieldservicedemodatajob)

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

- [msdyn_fieldservicedemodatajob_AsyncOperations](#BKMK_msdyn_fieldservicedemodatajob_AsyncOperations)
- [msdyn_fieldservicedemodatajob_BulkDeleteFailures](#BKMK_msdyn_fieldservicedemodatajob_BulkDeleteFailures)
- [msdyn_fieldservicedemodatajob_DuplicateBaseRecord](#BKMK_msdyn_fieldservicedemodatajob_DuplicateBaseRecord)
- [msdyn_fieldservicedemodatajob_DuplicateMatchingRecord](#BKMK_msdyn_fieldservicedemodatajob_DuplicateMatchingRecord)
- [msdyn_fieldservicedemodatajob_MailboxTrackingFolders](#BKMK_msdyn_fieldservicedemodatajob_MailboxTrackingFolders)
- [msdyn_fieldservicedemodatajob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicedemodatajob_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicedemodatajob_ProcessSession](#BKMK_msdyn_fieldservicedemodatajob_ProcessSession)
- [msdyn_fieldservicedemodatajob_SyncErrors](#BKMK_msdyn_fieldservicedemodatajob_SyncErrors)

### <a name="BKMK_msdyn_fieldservicedemodatajob_AsyncOperations"></a> msdyn_fieldservicedemodatajob_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_fieldservicedemodatajob_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldservicedemodatajob_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicedemodatajob_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicedemodatajob_BulkDeleteFailures"></a> msdyn_fieldservicedemodatajob_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_fieldservicedemodatajob_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldservicedemodatajob_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicedemodatajob_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicedemodatajob_DuplicateBaseRecord"></a> msdyn_fieldservicedemodatajob_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_fieldservicedemodatajob_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_fieldservicedemodatajob_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicedemodatajob_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicedemodatajob_DuplicateMatchingRecord"></a> msdyn_fieldservicedemodatajob_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_fieldservicedemodatajob_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_fieldservicedemodatajob_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicedemodatajob_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicedemodatajob_MailboxTrackingFolders"></a> msdyn_fieldservicedemodatajob_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_fieldservicedemodatajob_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldservicedemodatajob_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicedemodatajob_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicedemodatajob_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicedemodatajob_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_fieldservicedemodatajob_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldservicedemodatajob_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicedemodatajob_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicedemodatajob_ProcessSession"></a> msdyn_fieldservicedemodatajob_ProcessSession

Many-To-One Relationship: [processsession msdyn_fieldservicedemodatajob_ProcessSession](processsession.md#BKMK_msdyn_fieldservicedemodatajob_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicedemodatajob_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicedemodatajob_SyncErrors"></a> msdyn_fieldservicedemodatajob_SyncErrors

Many-To-One Relationship: [syncerror msdyn_fieldservicedemodatajob_SyncErrors](syncerror.md#BKMK_msdyn_fieldservicedemodatajob_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicedemodatajob_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

