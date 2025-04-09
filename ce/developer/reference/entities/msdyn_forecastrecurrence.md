---
title: "Forecast recurrence (msdyn_forecastrecurrence) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast recurrence (msdyn_forecastrecurrence) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast recurrence (msdyn_forecastrecurrence) table/entity reference (Microsoft Dynamics 365)

Stores recalculation information for each recurrence of the forecast hierarchy. For internal use.

## Messages

The following table lists the messages for the Forecast recurrence (msdyn_forecastrecurrence) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_forecastrecurrences<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_forecastrecurrences<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_forecastrecurrences(*msdyn_forecastrecurrenceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast recurrence (msdyn_forecastrecurrence) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast recurrence** |
| **DisplayCollectionName** | **Forecast recurrences** |
| **SchemaName** | `msdyn_forecastrecurrence` |
| **CollectionSchemaName** | `msdyn_forecastrecurrences` |
| **EntitySetName** | `msdyn_forecastrecurrences`|
| **LogicalName** | `msdyn_forecastrecurrence` |
| **LogicalCollectionName** | `msdyn_forecastrecurrences` |
| **PrimaryIdAttribute** | `msdyn_forecastrecurrenceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actualparticipatingrecordsfetchxml](#BKMK_msdyn_actualparticipatingrecordsfetchxml)
- [msdyn_failureinfo](#BKMK_msdyn_failureinfo)
- [msdyn_forecastdefinitionid](#BKMK_msdyn_forecastdefinitionid)
- [msdyn_forecastrecurrenceId](#BKMK_msdyn_forecastrecurrenceId)
- [msdyn_inprogressparticipatingrecordsfetchxml](#BKMK_msdyn_inprogressparticipatingrecordsfetchxml)
- [msdyn_ishierarchylocked](#BKMK_msdyn_ishierarchylocked)
- [msdyn_lastrecalculatedon](#BKMK_msdyn_lastrecalculatedon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_recalculatestatuschangedon](#BKMK_msdyn_recalculatestatuschangedon)
- [msdyn_recalculationstarttime](#BKMK_msdyn_recalculationstarttime)
- [msdyn_recalculationstatus](#BKMK_msdyn_recalculationstatus)
- [msdyn_recalculationstatusdescription](#BKMK_msdyn_recalculationstatusdescription)
- [msdyn_recurrenceindex](#BKMK_msdyn_recurrenceindex)
- [msdyn_validfrom](#BKMK_msdyn_validfrom)
- [msdyn_validto](#BKMK_msdyn_validto)
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

### <a name="BKMK_msdyn_actualparticipatingrecordsfetchxml"></a> msdyn_actualparticipatingrecordsfetchxml

|Property|Value|
|---|---|
|Description|**Stores the FetchXML for participating records for closed opportunities. For internal use.**|
|DisplayName|**Closed participating opportunities FetchXML**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_actualparticipatingrecordsfetchxml`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_failureinfo"></a> msdyn_failureinfo

|Property|Value|
|---|---|
|Description|**Stores information about why the recalculation of forecast hierarchy failed.**|
|DisplayName|**Failure info**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_failureinfo`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_forecastdefinitionid"></a> msdyn_forecastdefinitionid

|Property|Value|
|---|---|
|Description|**Unique identifier for the forecast definition that is associated with the forecast recurrence.**|
|DisplayName|**Forecast definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastdefinitionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_forecastdefinition|

### <a name="BKMK_msdyn_forecastrecurrenceId"></a> msdyn_forecastrecurrenceId

|Property|Value|
|---|---|
|Description|**Unique identifier for the forecast recurrence.**|
|DisplayName|**Forecast recurrence**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastrecurrenceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_inprogressparticipatingrecordsfetchxml"></a> msdyn_inprogressparticipatingrecordsfetchxml

|Property|Value|
|---|---|
|Description|**Stores the FetchXML for participating records for inprogress opportunities. For internal use.**|
|DisplayName|**Inprogress participating opportunities FetchXML**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_inprogressparticipatingrecordsfetchxml`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_ishierarchylocked"></a> msdyn_ishierarchylocked

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**IsHierarchyLocked**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ishierarchylocked`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_forecastrecurrence_msdyn_ishierarchylocked`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_lastrecalculatedon"></a> msdyn_lastrecalculatedon

|Property|Value|
|---|---|
|Description|**The date and time when the forecast hierarchy was successfully recalculated.**|
|DisplayName|**Last recalculated on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastrecalculatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Shows the name of the forecast recurrence.**|
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

### <a name="BKMK_msdyn_recalculatestatuschangedon"></a> msdyn_recalculatestatuschangedon

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**RecalculateStatusChangedOn**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recalculatestatuschangedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_recalculationstarttime"></a> msdyn_recalculationstarttime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**HierarchyLastLockedOn**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recalculationstarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_recalculationstatus"></a> msdyn_recalculationstatus

|Property|Value|
|---|---|
|Description|**Shows the recalculation status for the forecast recurrence hierarchy.**|
|DisplayName|**Recalculation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recalculationstatus`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|1|

### <a name="BKMK_msdyn_recalculationstatusdescription"></a> msdyn_recalculationstatusdescription

|Property|Value|
|---|---|
|Description|**Stores the description for the recalculation status of forecast hierarchy.**|
|DisplayName|**Recalculation status description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recalculationstatusdescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_recurrenceindex"></a> msdyn_recurrenceindex

|Property|Value|
|---|---|
|Description|**Stores the recurrence index that is associated with the forecast recurrence hierarchy.**|
|DisplayName|**Recurrence index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrenceindex`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|99|
|MinValue|1|

### <a name="BKMK_msdyn_validfrom"></a> msdyn_validfrom

|Property|Value|
|---|---|
|Description|**Shows the date from which the forecast is applicable. The date and time are displayed in the time zone selected in Dynamics 365 Customer Engagement apps options.**|
|DisplayName|**Valid from**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validfrom`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_validto"></a> msdyn_validto

|Property|Value|
|---|---|
|Description|**Shows the date till which the forecast is applicable. The date and time are displayed in the time zone selected in Dynamics 365 Customer Engagement apps options.**|
|DisplayName|**Valid to**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validto`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|Description|**Status of the Forecast Recurrence**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastrecurrence_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Forecast Recurrence**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastrecurrence_statuscode`|

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

- [business_unit_msdyn_forecastrecurrence](#BKMK_business_unit_msdyn_forecastrecurrence)
- [lk_msdyn_forecastrecurrence_createdby](#BKMK_lk_msdyn_forecastrecurrence_createdby)
- [lk_msdyn_forecastrecurrence_createdonbehalfby](#BKMK_lk_msdyn_forecastrecurrence_createdonbehalfby)
- [lk_msdyn_forecastrecurrence_modifiedby](#BKMK_lk_msdyn_forecastrecurrence_modifiedby)
- [lk_msdyn_forecastrecurrence_modifiedonbehalfby](#BKMK_lk_msdyn_forecastrecurrence_modifiedonbehalfby)
- [msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence](#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence)
- [owner_msdyn_forecastrecurrence](#BKMK_owner_msdyn_forecastrecurrence)
- [team_msdyn_forecastrecurrence](#BKMK_team_msdyn_forecastrecurrence)
- [user_msdyn_forecastrecurrence](#BKMK_user_msdyn_forecastrecurrence)

### <a name="BKMK_business_unit_msdyn_forecastrecurrence"></a> business_unit_msdyn_forecastrecurrence

One-To-Many Relationship: [businessunit business_unit_msdyn_forecastrecurrence](businessunit.md#BKMK_business_unit_msdyn_forecastrecurrence)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastrecurrence_createdby"></a> lk_msdyn_forecastrecurrence_createdby

One-To-Many Relationship: [systemuser lk_msdyn_forecastrecurrence_createdby](systemuser.md#BKMK_lk_msdyn_forecastrecurrence_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastrecurrence_createdonbehalfby"></a> lk_msdyn_forecastrecurrence_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastrecurrence_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastrecurrence_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastrecurrence_modifiedby"></a> lk_msdyn_forecastrecurrence_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_forecastrecurrence_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastrecurrence_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastrecurrence_modifiedonbehalfby"></a> lk_msdyn_forecastrecurrence_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastrecurrence_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastrecurrence_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence"></a> msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence

One-To-Many Relationship: [msdyn_forecastdefinition msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence](msdyn_forecastdefinition.md#BKMK_msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastdefinition`|
|ReferencedAttribute|`msdyn_forecastdefinitionid`|
|ReferencingAttribute|`msdyn_forecastdefinitionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ForecastDefinitionId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_forecastrecurrence"></a> owner_msdyn_forecastrecurrence

One-To-Many Relationship: [owner owner_msdyn_forecastrecurrence](owner.md#BKMK_owner_msdyn_forecastrecurrence)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_forecastrecurrence"></a> team_msdyn_forecastrecurrence

One-To-Many Relationship: [team team_msdyn_forecastrecurrence](team.md#BKMK_team_msdyn_forecastrecurrence)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_forecastrecurrence"></a> user_msdyn_forecastrecurrence

One-To-Many Relationship: [systemuser user_msdyn_forecastrecurrence](systemuser.md#BKMK_user_msdyn_forecastrecurrence)

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

- [msdyn_forecastrecurrence_AsyncOperations](#BKMK_msdyn_forecastrecurrence_AsyncOperations)
- [msdyn_forecastrecurrence_BulkDeleteFailures](#BKMK_msdyn_forecastrecurrence_BulkDeleteFailures)
- [msdyn_forecastrecurrence_DuplicateBaseRecord](#BKMK_msdyn_forecastrecurrence_DuplicateBaseRecord)
- [msdyn_forecastrecurrence_DuplicateMatchingRecord](#BKMK_msdyn_forecastrecurrence_DuplicateMatchingRecord)
- [msdyn_forecastrecurrence_MailboxTrackingFolders](#BKMK_msdyn_forecastrecurrence_MailboxTrackingFolders)
- [msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses](#BKMK_msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses)
- [msdyn_forecastrecurrence_ProcessSession](#BKMK_msdyn_forecastrecurrence_ProcessSession)
- [msdyn_forecastrecurrence_SyncErrors](#BKMK_msdyn_forecastrecurrence_SyncErrors)
- [msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance](#BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance)

### <a name="BKMK_msdyn_forecastrecurrence_AsyncOperations"></a> msdyn_forecastrecurrence_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_forecastrecurrence_AsyncOperations](asyncoperation.md#BKMK_msdyn_forecastrecurrence_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastrecurrence_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastrecurrence_BulkDeleteFailures"></a> msdyn_forecastrecurrence_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_forecastrecurrence_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_forecastrecurrence_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastrecurrence_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastrecurrence_DuplicateBaseRecord"></a> msdyn_forecastrecurrence_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastrecurrence_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_forecastrecurrence_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastrecurrence_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastrecurrence_DuplicateMatchingRecord"></a> msdyn_forecastrecurrence_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastrecurrence_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_forecastrecurrence_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastrecurrence_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastrecurrence_MailboxTrackingFolders"></a> msdyn_forecastrecurrence_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_forecastrecurrence_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_forecastrecurrence_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastrecurrence_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses"></a> msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastrecurrence_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastrecurrence_ProcessSession"></a> msdyn_forecastrecurrence_ProcessSession

Many-To-One Relationship: [processsession msdyn_forecastrecurrence_ProcessSession](processsession.md#BKMK_msdyn_forecastrecurrence_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastrecurrence_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastrecurrence_SyncErrors"></a> msdyn_forecastrecurrence_SyncErrors

Many-To-One Relationship: [syncerror msdyn_forecastrecurrence_SyncErrors](syncerror.md#BKMK_msdyn_forecastrecurrence_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastrecurrence_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance"></a> msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance

Many-To-One Relationship: [msdyn_forecastinstance msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinstance`|
|ReferencingAttribute|`msdyn_forecastrecurrenceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastrecurrence_msdyn_forecastinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

