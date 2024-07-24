---
title: "Form Submission (msdynmkt_marketingformsubmission) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Form Submission (msdynmkt_marketingformsubmission) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Form Submission (msdynmkt_marketingformsubmission) table/entity reference



## Messages

The following table lists the messages for the Form Submission (msdynmkt_marketingformsubmission) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_marketingformsubmissions(*msdynmkt_marketingformsubmissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_marketingformsubmissions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_marketingformsubmissions(*msdynmkt_marketingformsubmissionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdynmkt_formsubmission_confirmed`<br />Event: False |**msdynmkt_formsubmission_confirmed action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msdynmkt_formsubmission_enrich`<br />Event: False |**msdynmkt_formsubmission_enrich action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msdynmkt_formsubmission_triggerprocessing`<br />Event: False |**msdynmkt_formsubmission_triggerprocessing action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_marketingformsubmissions(*msdynmkt_marketingformsubmissionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_marketingformsubmissions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_marketingformsubmissions(*msdynmkt_marketingformsubmissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_marketingformsubmissions(*msdynmkt_marketingformsubmissionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_marketingformsubmissions(*msdynmkt_marketingformsubmissionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Form Submission (msdynmkt_marketingformsubmission) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Form Submission (msdynmkt_marketingformsubmission) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Form Submission** |
| **DisplayCollectionName** | **Form Submissions** |
| **SchemaName** | `msdynmkt_marketingformsubmission` |
| **CollectionSchemaName** | `msdynmkt_marketingformsubmissions` |
| **EntitySetName** | `msdynmkt_marketingformsubmissions`|
| **LogicalName** | `msdynmkt_marketingformsubmission` |
| **LogicalCollectionName** | `msdynmkt_marketingformsubmissions` |
| **PrimaryIdAttribute** | `msdynmkt_marketingformsubmissionid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_compliancesettings4id](#BKMK_msdynmkt_compliancesettings4id)
- [msdynmkt_contactableemail](#BKMK_msdynmkt_contactableemail)
- [msdynmkt_createdentity](#BKMK_msdynmkt_createdentity)
- [msdynmkt_customerjourneyid](#BKMK_msdynmkt_customerjourneyid)
- [msdynmkt_emailid](#BKMK_msdynmkt_emailid)
- [msdynmkt_eventregistration](#BKMK_msdynmkt_eventregistration)
- [msdynmkt_failuredescription](#BKMK_msdynmkt_failuredescription)
- [msdynmkt_linkedsubmissionid](#BKMK_msdynmkt_linkedsubmissionid)
- [msdynmkt_marketingformid](#BKMK_msdynmkt_marketingformid)
- [msdynmkt_marketingformsubmissionId](#BKMK_msdynmkt_marketingformsubmissionId)
- [msdynmkt_marketingformsubmissiontype](#BKMK_msdynmkt_marketingformsubmissiontype)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_pageurl](#BKMK_msdynmkt_pageurl)
- [msdynmkt_trackingid](#BKMK_msdynmkt_trackingid)
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

### <a name="BKMK_msdynmkt_compliancesettings4id"></a> msdynmkt_compliancesettings4id

|Property|Value|
|---|---|
|Description|**Unique identifier for Compliance profile associated with Form Submission.**|
|DisplayName|**Compliance profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_compliancesettings4id`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_compliancesettings4|

### <a name="BKMK_msdynmkt_contactableemail"></a> msdynmkt_contactableemail

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactableemail`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_createdentity"></a> msdynmkt_createdentity

|Property|Value|
|---|---|
|Description|**Affected Record Link associated with Form Submission.**|
|DisplayName|**Linked Record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_createdentity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_createdentitylink|

### <a name="BKMK_msdynmkt_customerjourneyid"></a> msdynmkt_customerjourneyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source customer journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_customerjourneyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_journey|

### <a name="BKMK_msdynmkt_emailid"></a> msdynmkt_emailid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_email|

### <a name="BKMK_msdynmkt_eventregistration"></a> msdynmkt_eventregistration

|Property|Value|
|---|---|
|Description|**Event Registration associated with Form Submission.**|
|DisplayName|**Event Registration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventregistration`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_eventregistration|

### <a name="BKMK_msdynmkt_failuredescription"></a> msdynmkt_failuredescription

|Property|Value|
|---|---|
|Description|**Failure Description**|
|DisplayName|**Failure Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_failuredescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdynmkt_linkedsubmissionid"></a> msdynmkt_linkedsubmissionid

|Property|Value|
|---|---|
|Description|**Linked Submission Id**|
|DisplayName|**Linked Submission Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_linkedsubmissionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_marketingformid"></a> msdynmkt_marketingformid

|Property|Value|
|---|---|
|Description|**Form associated with Form Submission.**|
|DisplayName|**Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingformid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_marketingform|

### <a name="BKMK_msdynmkt_marketingformsubmissionId"></a> msdynmkt_marketingformsubmissionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Form Submission ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingformsubmissionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_marketingformsubmissiontype"></a> msdynmkt_marketingformsubmissiontype

|Property|Value|
|---|---|
|Description|**Marketing form submission type**|
|DisplayName|**Submission Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingformsubmissiontype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_marketingformsubmissiontype`|

#### msdynmkt_marketingformsubmissiontype Choices/Options

|Value|Label|
|---|---|
|624650000|**Form Embed**|
|624650001|**Form Capture**|
|624650002|**Form Standalone**|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the Form Submission.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_pageurl"></a> msdynmkt_pageurl

|Property|Value|
|---|---|
|Description|**The URL of the page where the form is hosted**|
|DisplayName|**Page URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_pageurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdynmkt_trackingid"></a> msdynmkt_trackingid

|Property|Value|
|---|---|
|Description|**Tracking Id**|
|DisplayName|**Linked Submission Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_trackingid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Form Submission**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_marketingformsubmission_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 575440000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Form Submission**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_marketingformsubmission_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|575440000|Label: **Pending**<br />State:0<br />TransitionData: None|
|575440001|Label: **Failure**<br />State:0<br />TransitionData: None|
|575440002|Label: **Success**<br />State:0<br />TransitionData: None|
|575440003|Label: **Finished**<br />State:0<br />TransitionData: None|
|575440004|Label: **Confirmation Pending**<br />State:0<br />TransitionData: None|
|575440005|Label: **Failure after Confirmation**<br />State:0<br />TransitionData: None|
|575440006|Label: **Warning**<br />State:0<br />TransitionData: None|

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
- [msdynmkt_submittedvalues](#BKMK_msdynmkt_submittedvalues)
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

### <a name="BKMK_msdynmkt_submittedvalues"></a> msdynmkt_submittedvalues

|Property|Value|
|---|---|
|Description|**Submitted Values**|
|DisplayName|**Submitted Values**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_submittedvalues`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

- [business_unit_msdynmkt_marketingformsubmission](#BKMK_business_unit_msdynmkt_marketingformsubmission)
- [lk_msdynmkt_marketingformsubmission_createdby](#BKMK_lk_msdynmkt_marketingformsubmission_createdby)
- [lk_msdynmkt_marketingformsubmission_createdonbehalfby](#BKMK_lk_msdynmkt_marketingformsubmission_createdonbehalfby)
- [lk_msdynmkt_marketingformsubmission_modifiedby](#BKMK_lk_msdynmkt_marketingformsubmission_modifiedby)
- [lk_msdynmkt_marketingformsubmission_modifiedonbehalfby](#BKMK_lk_msdynmkt_marketingformsubmission_modifiedonbehalfby)
- [msdynmkt_compliancesettings4_formsubmission](#BKMK_msdynmkt_compliancesettings4_formsubmission)
- [msdynmkt_marketingformsubmission_createdentity](#BKMK_msdynmkt_marketingformsubmission_createdentity)
- [msdynmkt_marketingformsubmission_customerjourneyid](#BKMK_msdynmkt_marketingformsubmission_customerjourneyid)
- [msdynmkt_marketingformsubmission_emailid](#BKMK_msdynmkt_marketingformsubmission_emailid)
- [msdynmkt_marketingformsubmission_eventregistration](#BKMK_msdynmkt_marketingformsubmission_eventregistration)
- [msdynmkt_marketingformsubmission_marketingform](#BKMK_msdynmkt_marketingformsubmission_marketingform)
- [owner_msdynmkt_marketingformsubmission](#BKMK_owner_msdynmkt_marketingformsubmission)
- [team_msdynmkt_marketingformsubmission](#BKMK_team_msdynmkt_marketingformsubmission)
- [user_msdynmkt_marketingformsubmission](#BKMK_user_msdynmkt_marketingformsubmission)

### <a name="BKMK_business_unit_msdynmkt_marketingformsubmission"></a> business_unit_msdynmkt_marketingformsubmission

One-To-Many Relationship: [businessunit business_unit_msdynmkt_marketingformsubmission](businessunit.md#BKMK_business_unit_msdynmkt_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingformsubmission_createdby"></a> lk_msdynmkt_marketingformsubmission_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingformsubmission_createdby](systemuser.md#BKMK_lk_msdynmkt_marketingformsubmission_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingformsubmission_createdonbehalfby"></a> lk_msdynmkt_marketingformsubmission_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingformsubmission_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_marketingformsubmission_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingformsubmission_modifiedby"></a> lk_msdynmkt_marketingformsubmission_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingformsubmission_modifiedby](systemuser.md#BKMK_lk_msdynmkt_marketingformsubmission_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingformsubmission_modifiedonbehalfby"></a> lk_msdynmkt_marketingformsubmission_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingformsubmission_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_marketingformsubmission_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_compliancesettings4_formsubmission"></a> msdynmkt_compliancesettings4_formsubmission

One-To-Many Relationship: [msdynmkt_compliancesettings4 msdynmkt_compliancesettings4_formsubmission](msdynmkt_compliancesettings4.md#BKMK_msdynmkt_compliancesettings4_formsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_compliancesettings4`|
|ReferencedAttribute|`msdynmkt_compliancesettings4id`|
|ReferencingAttribute|`msdynmkt_compliancesettings4id`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_compliancesettings4id`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_marketingformsubmission_createdentity"></a> msdynmkt_marketingformsubmission_createdentity

One-To-Many Relationship: [msdynmkt_createdentitylink msdynmkt_marketingformsubmission_createdentity](msdynmkt_createdentitylink.md#BKMK_msdynmkt_marketingformsubmission_createdentity)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_createdentitylink`|
|ReferencedAttribute|`msdynmkt_createdentitylinkid`|
|ReferencingAttribute|`msdynmkt_createdentity`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_createdentity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdynmkt_marketingformsubmission_customerjourneyid"></a> msdynmkt_marketingformsubmission_customerjourneyid

One-To-Many Relationship: [msdynmkt_journey msdynmkt_marketingformsubmission_customerjourneyid](msdynmkt_journey.md#BKMK_msdynmkt_marketingformsubmission_customerjourneyid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_journey`|
|ReferencedAttribute|`msdynmkt_journeyid`|
|ReferencingAttribute|`msdynmkt_customerjourneyid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_customerjourneyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_marketingformsubmission_emailid"></a> msdynmkt_marketingformsubmission_emailid

One-To-Many Relationship: [msdynmkt_email msdynmkt_marketingformsubmission_emailid](msdynmkt_email.md#BKMK_msdynmkt_marketingformsubmission_emailid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_email`|
|ReferencedAttribute|`msdynmkt_emailid`|
|ReferencingAttribute|`msdynmkt_emailid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_emailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_marketingformsubmission_eventregistration"></a> msdynmkt_marketingformsubmission_eventregistration

One-To-Many Relationship: [msevtmgt_eventregistration msdynmkt_marketingformsubmission_eventregistration](msevtmgt_eventregistration.md#BKMK_msdynmkt_marketingformsubmission_eventregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`msdynmkt_eventregistration`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_eventregistration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdynmkt_marketingformsubmission_marketingform"></a> msdynmkt_marketingformsubmission_marketingform

One-To-Many Relationship: [msdynmkt_marketingform msdynmkt_marketingformsubmission_marketingform](msdynmkt_marketingform.md#BKMK_msdynmkt_marketingformsubmission_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_marketingform`|
|ReferencedAttribute|`msdynmkt_marketingformid`|
|ReferencingAttribute|`msdynmkt_marketingformid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_marketingformid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_marketingformsubmission"></a> owner_msdynmkt_marketingformsubmission

One-To-Many Relationship: [owner owner_msdynmkt_marketingformsubmission](owner.md#BKMK_owner_msdynmkt_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_marketingformsubmission"></a> team_msdynmkt_marketingformsubmission

One-To-Many Relationship: [team team_msdynmkt_marketingformsubmission](team.md#BKMK_team_msdynmkt_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_marketingformsubmission"></a> user_msdynmkt_marketingformsubmission

One-To-Many Relationship: [systemuser user_msdynmkt_marketingformsubmission](systemuser.md#BKMK_user_msdynmkt_marketingformsubmission)

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

- [msdynmkt_marketingformsubmission_AsyncOperations](#BKMK_msdynmkt_marketingformsubmission_AsyncOperations)
- [msdynmkt_marketingformsubmission_BulkDeleteFailures](#BKMK_msdynmkt_marketingformsubmission_BulkDeleteFailures)
- [msdynmkt_marketingformsubmission_DuplicateBaseRecord](#BKMK_msdynmkt_marketingformsubmission_DuplicateBaseRecord)
- [msdynmkt_marketingformsubmission_DuplicateMatchingRecord](#BKMK_msdynmkt_marketingformsubmission_DuplicateMatchingRecord)
- [msdynmkt_marketingformsubmission_field](#BKMK_msdynmkt_marketingformsubmission_field)
- [msdynmkt_marketingformsubmission_MailboxTrackingFolders](#BKMK_msdynmkt_marketingformsubmission_MailboxTrackingFolders)
- [msdynmkt_marketingformsubmission_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_marketingformsubmission_PrincipalObjectAttributeAccesses)
- [msdynmkt_marketingformsubmission_ProcessSession](#BKMK_msdynmkt_marketingformsubmission_ProcessSession)
- [msdynmkt_marketingformsubmission_SyncErrors](#BKMK_msdynmkt_marketingformsubmission_SyncErrors)

### <a name="BKMK_msdynmkt_marketingformsubmission_AsyncOperations"></a> msdynmkt_marketingformsubmission_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_marketingformsubmission_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_marketingformsubmission_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_BulkDeleteFailures"></a> msdynmkt_marketingformsubmission_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_marketingformsubmission_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_marketingformsubmission_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_DuplicateBaseRecord"></a> msdynmkt_marketingformsubmission_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_marketingformsubmission_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_marketingformsubmission_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_DuplicateMatchingRecord"></a> msdynmkt_marketingformsubmission_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_marketingformsubmission_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_marketingformsubmission_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_field"></a> msdynmkt_marketingformsubmission_field

Many-To-One Relationship: [msdynmkt_marketingfieldsubmission msdynmkt_marketingformsubmission_field](msdynmkt_marketingfieldsubmission.md#BKMK_msdynmkt_marketingformsubmission_field)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingfieldsubmission`|
|ReferencingAttribute|`msdynmkt_marketingformsubmissionid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_field`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_MailboxTrackingFolders"></a> msdynmkt_marketingformsubmission_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_marketingformsubmission_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_marketingformsubmission_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_PrincipalObjectAttributeAccesses"></a> msdynmkt_marketingformsubmission_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_marketingformsubmission_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_marketingformsubmission_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_ProcessSession"></a> msdynmkt_marketingformsubmission_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_marketingformsubmission_ProcessSession](processsession.md#BKMK_msdynmkt_marketingformsubmission_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_SyncErrors"></a> msdynmkt_marketingformsubmission_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_marketingformsubmission_SyncErrors](syncerror.md#BKMK_msdynmkt_marketingformsubmission_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

