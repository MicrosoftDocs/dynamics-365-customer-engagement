---
title: "LinkedIn Lead Gen Form (msdyncrm_linkedinform) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the LinkedIn Lead Gen Form (msdyncrm_linkedinform) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# LinkedIn Lead Gen Form (msdyncrm_linkedinform) table/entity reference

Form shown to prospects on LinkedIn

## Messages

The following table lists the messages for the LinkedIn Lead Gen Form (msdyncrm_linkedinform) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_linkedinforms(*msdyncrm_linkedinformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_linkedinforms<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_linkedinforms(*msdyncrm_linkedinformid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_linkedinforms(*msdyncrm_linkedinformid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_linkedinforms<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_linkedinforms(*msdyncrm_linkedinformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_linkedinforms(*msdyncrm_linkedinformid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_linkedinforms(*msdyncrm_linkedinformid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the LinkedIn Lead Gen Form (msdyncrm_linkedinform) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the LinkedIn Lead Gen Form (msdyncrm_linkedinform) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **LinkedIn Lead Gen Form** |
| **DisplayCollectionName** | **LinkedIn Lead Gen Forms** |
| **SchemaName** | `msdyncrm_linkedinform` |
| **CollectionSchemaName** | `msdyncrm_linkedinforms` |
| **EntitySetName** | `msdyncrm_linkedinforms`|
| **LogicalName** | `msdyncrm_linkedinform` |
| **LogicalCollectionName** | `msdyncrm_linkedinforms` |
| **PrimaryIdAttribute** | `msdyncrm_linkedinformid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_Description](#BKMK_msdyncrm_Description)
- [msdyncrm_Headline](#BKMK_msdyncrm_Headline)
- [msdyncrm_LandingpageURL](#BKMK_msdyncrm_LandingpageURL)
- [msdyncrm_lastsyncdate](#BKMK_msdyncrm_lastsyncdate)
- [msdyncrm_linkedinformId](#BKMK_msdyncrm_linkedinformId)
- [msdyncrm_LinkedInID](#BKMK_msdyncrm_LinkedInID)
- [msdyncrm_LinkedInParentAccount](#BKMK_msdyncrm_LinkedInParentAccount)
- [msdyncrm_LocaleCountry](#BKMK_msdyncrm_LocaleCountry)
- [msdyncrm_LocaleLanguage](#BKMK_msdyncrm_LocaleLanguage)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_PrivacyPolicyURL](#BKMK_msdyncrm_PrivacyPolicyURL)
- [msdyncrm_syncstatus](#BKMK_msdyncrm_syncstatus)
- [msdyncrm_Thankyoumessage](#BKMK_msdyncrm_Thankyoumessage)
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

### <a name="BKMK_msdyncrm_Description"></a> msdyncrm_Description

|Property|Value|
|---|---|
|Description|**Description of the LinkedIn form**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_Headline"></a> msdyncrm_Headline

|Property|Value|
|---|---|
|Description|**Headline displayed to leads on LinkedIn**|
|DisplayName|**LinkedIn form headline**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_headline`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_LandingpageURL"></a> msdyncrm_LandingpageURL

|Property|Value|
|---|---|
|Description|**Landing page URL used on the LinkedIn form**|
|DisplayName|**Landing page URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_landingpageurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_lastsyncdate"></a> msdyncrm_lastsyncdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Sync Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastsyncdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_linkedinformId"></a> msdyncrm_linkedinformId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**LinkedIn Lead Gen**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinformid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_LinkedInID"></a> msdyncrm_LinkedInID

|Property|Value|
|---|---|
|Description|**Unique identifier of the LinkedIn form**|
|DisplayName|**LinkedIn ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_LinkedInParentAccount"></a> msdyncrm_LinkedInParentAccount

|Property|Value|
|---|---|
|Description|**LinkedIn account record to which this form belongs to**|
|DisplayName|**LinkedIn Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinparentaccount`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_linkedinaccount|

### <a name="BKMK_msdyncrm_LocaleCountry"></a> msdyncrm_LocaleCountry

|Property|Value|
|---|---|
|Description|**Locale country information for the LinkedIn form**|
|DisplayName|**Locale country**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_localecountry`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_LocaleLanguage"></a> msdyncrm_LocaleLanguage

|Property|Value|
|---|---|
|Description|**Locale language information for the LinkedIn form**|
|DisplayName|**Locale language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_localelanguage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**LinkedIn form name**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyncrm_PrivacyPolicyURL"></a> msdyncrm_PrivacyPolicyURL

|Property|Value|
|---|---|
|Description|**Privacy policy URL displayed on the LinkedIn form**|
|DisplayName|**Privacy policy URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_privacypolicyurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_syncstatus"></a> msdyncrm_syncstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sync status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_syncstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_linkedinform_msdyncrm_syncstatus`|

#### msdyncrm_syncstatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Pending Synchronization**|
|192350001|**Active**|
|192350002|**No Form Submissions**|
|192350003|**Forbidden**|

### <a name="BKMK_msdyncrm_Thankyoumessage"></a> msdyncrm_Thankyoumessage

|Property|Value|
|---|---|
|Description|**Thank you message to leads who submit a form on LinkedIn**|
|DisplayName|**Thank you message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_thankyoumessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
|Description|**Status of the LinkedIn Form**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedinform_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the LinkedIn Form**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedinform_statuscode`|

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
- [msdyncrm_totalsubmissions](#BKMK_msdyncrm_totalsubmissions)
- [msdyncrm_totalsubmissions_Date](#BKMK_msdyncrm_totalsubmissions_Date)
- [msdyncrm_totalsubmissions_State](#BKMK_msdyncrm_totalsubmissions_State)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this.**|
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
|Description|**Indicates the person who created this for another person**|
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
|Description|**Indicates the person who modified this**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_totalsubmissions"></a> msdyncrm_totalsubmissions

|Property|Value|
|---|---|
|Description|**Total number of submissions received on this form**|
|DisplayName|**Total submissions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_totalsubmissions`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_totalsubmissions_Date"></a> msdyncrm_totalsubmissions_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Total submissions.**|
|DisplayName|**Total submissions (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_totalsubmissions_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_totalsubmissions_State"></a> msdyncrm_totalsubmissions_State

|Property|Value|
|---|---|
|Description|**State of rollup field Total submissions.**|
|DisplayName|**Total submissions (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_totalsubmissions_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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
|Description|**Indicates the business unit that owns this**|
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
|Description|**Indicates which team owns this**|
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
|Description|**Indicates the person who owns this**|
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

- [business_unit_msdyncrm_linkedinform](#BKMK_business_unit_msdyncrm_linkedinform)
- [lk_msdyncrm_linkedinform_createdby](#BKMK_lk_msdyncrm_linkedinform_createdby)
- [lk_msdyncrm_linkedinform_createdonbehalfby](#BKMK_lk_msdyncrm_linkedinform_createdonbehalfby)
- [lk_msdyncrm_linkedinform_modifiedby](#BKMK_lk_msdyncrm_linkedinform_modifiedby)
- [lk_msdyncrm_linkedinform_modifiedonbehalfby](#BKMK_lk_msdyncrm_linkedinform_modifiedonbehalfby)
- [msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount](#BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount)
- [owner_msdyncrm_linkedinform](#BKMK_owner_msdyncrm_linkedinform)
- [team_msdyncrm_linkedinform](#BKMK_team_msdyncrm_linkedinform)
- [user_msdyncrm_linkedinform](#BKMK_user_msdyncrm_linkedinform)

### <a name="BKMK_business_unit_msdyncrm_linkedinform"></a> business_unit_msdyncrm_linkedinform

One-To-Many Relationship: [businessunit business_unit_msdyncrm_linkedinform](businessunit.md#BKMK_business_unit_msdyncrm_linkedinform)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinform_createdby"></a> lk_msdyncrm_linkedinform_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinform_createdby](systemuser.md#BKMK_lk_msdyncrm_linkedinform_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinform_createdonbehalfby"></a> lk_msdyncrm_linkedinform_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinform_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedinform_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinform_modifiedby"></a> lk_msdyncrm_linkedinform_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinform_modifiedby](systemuser.md#BKMK_lk_msdyncrm_linkedinform_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinform_modifiedonbehalfby"></a> lk_msdyncrm_linkedinform_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinform_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedinform_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount"></a> msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`msdyncrm_linkedinparentaccount`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_LinkedInParentAccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_linkedinform"></a> owner_msdyncrm_linkedinform

One-To-Many Relationship: [owner owner_msdyncrm_linkedinform](owner.md#BKMK_owner_msdyncrm_linkedinform)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_linkedinform"></a> team_msdyncrm_linkedinform

One-To-Many Relationship: [team team_msdyncrm_linkedinform](team.md#BKMK_team_msdyncrm_linkedinform)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_linkedinform"></a> user_msdyncrm_linkedinform

One-To-Many Relationship: [systemuser user_msdyncrm_linkedinform](systemuser.md#BKMK_user_msdyncrm_linkedinform)

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

- [msdyncrm_linkedinform_ActivityPointers](#BKMK_msdyncrm_linkedinform_ActivityPointers)
- [msdyncrm_linkedinform_adx_alertsubscriptions](#BKMK_msdyncrm_linkedinform_adx_alertsubscriptions)
- [msdyncrm_linkedinform_adx_inviteredemptions](#BKMK_msdyncrm_linkedinform_adx_inviteredemptions)
- [msdyncrm_linkedinform_adx_portalcomments](#BKMK_msdyncrm_linkedinform_adx_portalcomments)
- [msdyncrm_linkedinform_Annotations](#BKMK_msdyncrm_linkedinform_Annotations)
- [msdyncrm_linkedinform_Appointments](#BKMK_msdyncrm_linkedinform_Appointments)
- [msdyncrm_linkedinform_AsyncOperations](#BKMK_msdyncrm_linkedinform_AsyncOperations)
- [msdyncrm_linkedinform_BulkDeleteFailures](#BKMK_msdyncrm_linkedinform_BulkDeleteFailures)
- [msdyncrm_linkedinform_chats](#BKMK_msdyncrm_linkedinform_chats)
- [msdyncrm_linkedinform_connections1](#BKMK_msdyncrm_linkedinform_connections1)
- [msdyncrm_linkedinform_connections2](#BKMK_msdyncrm_linkedinform_connections2)
- [msdyncrm_linkedinform_DuplicateBaseRecord](#BKMK_msdyncrm_linkedinform_DuplicateBaseRecord)
- [msdyncrm_linkedinform_DuplicateMatchingRecord](#BKMK_msdyncrm_linkedinform_DuplicateMatchingRecord)
- [msdyncrm_linkedinform_Emails](#BKMK_msdyncrm_linkedinform_Emails)
- [msdyncrm_linkedinform_Faxes](#BKMK_msdyncrm_linkedinform_Faxes)
- [msdyncrm_linkedinform_Feedback](#BKMK_msdyncrm_linkedinform_Feedback)
- [msdyncrm_linkedinform_Letters](#BKMK_msdyncrm_linkedinform_Letters)
- [msdyncrm_linkedinform_li_inmails](#BKMK_msdyncrm_linkedinform_li_inmails)
- [msdyncrm_linkedinform_li_messages](#BKMK_msdyncrm_linkedinform_li_messages)
- [msdyncrm_linkedinform_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinform_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinform_MailboxTrackingFolders](#BKMK_msdyncrm_linkedinform_MailboxTrackingFolders)
- [msdyncrm_linkedinform_msdyn_bookingalerts](#BKMK_msdyncrm_linkedinform_msdyn_bookingalerts)
- [msdyncrm_linkedinform_msdyn_copilottranscripts](#BKMK_msdyncrm_linkedinform_msdyn_copilottranscripts)
- [msdyncrm_linkedinform_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinform_msdyn_ocliveworkitems)
- [msdyncrm_linkedinform_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinform_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinform_msdyn_ocsessions](#BKMK_msdyncrm_linkedinform_msdyn_ocsessions)
- [msdyncrm_linkedinform_msdyn_ocvoicemails](#BKMK_msdyncrm_linkedinform_msdyn_ocvoicemails)
- [msdyncrm_linkedinform_msfp_alerts](#BKMK_msdyncrm_linkedinform_msfp_alerts)
- [msdyncrm_linkedinform_msfp_surveyinvites](#BKMK_msdyncrm_linkedinform_msfp_surveyinvites)
- [msdyncrm_linkedinform_msfp_surveyresponses](#BKMK_msdyncrm_linkedinform_msfp_surveyresponses)
- [msdyncrm_linkedinform_PhoneCalls](#BKMK_msdyncrm_linkedinform_PhoneCalls)
- [msdyncrm_linkedinform_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_linkedinform_PrincipalObjectAttributeAccesses)
- [msdyncrm_linkedinform_ProcessSession](#BKMK_msdyncrm_linkedinform_ProcessSession)
- [msdyncrm_linkedinform_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinform_RecurringAppointmentMasters)
- [msdyncrm_linkedinform_ServiceAppointments](#BKMK_msdyncrm_linkedinform_ServiceAppointments)
- [msdyncrm_linkedinform_SocialActivities](#BKMK_msdyncrm_linkedinform_SocialActivities)
- [msdyncrm_linkedinform_SyncErrors](#BKMK_msdyncrm_linkedinform_SyncErrors)
- [msdyncrm_linkedinform_Tasks](#BKMK_msdyncrm_linkedinform_Tasks)
- [msdyncrm_msdyncrm_linkedinform_lead_sourceform](#BKMK_msdyncrm_msdyncrm_linkedinform_lead_sourceform)
- [msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm](#BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm)
- [msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID](#BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID)

### <a name="BKMK_msdyncrm_linkedinform_ActivityPointers"></a> msdyncrm_linkedinform_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_linkedinform_ActivityPointers](activitypointer.md#BKMK_msdyncrm_linkedinform_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_adx_alertsubscriptions"></a> msdyncrm_linkedinform_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_linkedinform_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_linkedinform_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_adx_inviteredemptions"></a> msdyncrm_linkedinform_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_linkedinform_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_linkedinform_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_adx_portalcomments"></a> msdyncrm_linkedinform_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_linkedinform_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_linkedinform_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_Annotations"></a> msdyncrm_linkedinform_Annotations

Many-To-One Relationship: [annotation msdyncrm_linkedinform_Annotations](annotation.md#BKMK_msdyncrm_linkedinform_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_Appointments"></a> msdyncrm_linkedinform_Appointments

Many-To-One Relationship: [appointment msdyncrm_linkedinform_Appointments](appointment.md#BKMK_msdyncrm_linkedinform_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_AsyncOperations"></a> msdyncrm_linkedinform_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_linkedinform_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_linkedinform_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_BulkDeleteFailures"></a> msdyncrm_linkedinform_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_linkedinform_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_linkedinform_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_chats"></a> msdyncrm_linkedinform_chats

Many-To-One Relationship: [chat msdyncrm_linkedinform_chats](chat.md#BKMK_msdyncrm_linkedinform_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_connections1"></a> msdyncrm_linkedinform_connections1

Many-To-One Relationship: [connection msdyncrm_linkedinform_connections1](connection.md#BKMK_msdyncrm_linkedinform_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_connections2"></a> msdyncrm_linkedinform_connections2

Many-To-One Relationship: [connection msdyncrm_linkedinform_connections2](connection.md#BKMK_msdyncrm_linkedinform_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_DuplicateBaseRecord"></a> msdyncrm_linkedinform_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedinform_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_linkedinform_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_DuplicateMatchingRecord"></a> msdyncrm_linkedinform_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedinform_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_linkedinform_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_Emails"></a> msdyncrm_linkedinform_Emails

Many-To-One Relationship: [email msdyncrm_linkedinform_Emails](email.md#BKMK_msdyncrm_linkedinform_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_Faxes"></a> msdyncrm_linkedinform_Faxes

Many-To-One Relationship: [fax msdyncrm_linkedinform_Faxes](fax.md#BKMK_msdyncrm_linkedinform_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_Feedback"></a> msdyncrm_linkedinform_Feedback

Many-To-One Relationship: [feedback msdyncrm_linkedinform_Feedback](feedback.md#BKMK_msdyncrm_linkedinform_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_Letters"></a> msdyncrm_linkedinform_Letters

Many-To-One Relationship: [letter msdyncrm_linkedinform_Letters](letter.md#BKMK_msdyncrm_linkedinform_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_li_inmails"></a> msdyncrm_linkedinform_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_linkedinform_li_inmails](li_inmail.md#BKMK_msdyncrm_linkedinform_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_li_messages"></a> msdyncrm_linkedinform_li_messages

Many-To-One Relationship: [li_message msdyncrm_linkedinform_li_messages](li_message.md#BKMK_msdyncrm_linkedinform_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinform_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_linkedinform_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_linkedinform_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_MailboxTrackingFolders"></a> msdyncrm_linkedinform_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_linkedinform_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_linkedinform_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_bookingalerts"></a> msdyncrm_linkedinform_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_linkedinform_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_linkedinform_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_copilottranscripts"></a> msdyncrm_linkedinform_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_linkedinform_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_linkedinform_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_ocliveworkitems"></a> msdyncrm_linkedinform_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_linkedinform_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_linkedinform_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinform_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_linkedinform_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_linkedinform_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_ocsessions"></a> msdyncrm_linkedinform_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_linkedinform_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_linkedinform_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msdyn_ocvoicemails"></a> msdyncrm_linkedinform_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_linkedinform_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_linkedinform_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msfp_alerts"></a> msdyncrm_linkedinform_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_linkedinform_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_linkedinform_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msfp_surveyinvites"></a> msdyncrm_linkedinform_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_linkedinform_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_linkedinform_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_msfp_surveyresponses"></a> msdyncrm_linkedinform_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_linkedinform_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_linkedinform_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_PhoneCalls"></a> msdyncrm_linkedinform_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_linkedinform_PhoneCalls](phonecall.md#BKMK_msdyncrm_linkedinform_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_PrincipalObjectAttributeAccesses"></a> msdyncrm_linkedinform_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_linkedinform_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_linkedinform_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_ProcessSession"></a> msdyncrm_linkedinform_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_linkedinform_ProcessSession](processsession.md#BKMK_msdyncrm_linkedinform_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_RecurringAppointmentMasters"></a> msdyncrm_linkedinform_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_linkedinform_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_linkedinform_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_ServiceAppointments"></a> msdyncrm_linkedinform_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_linkedinform_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_linkedinform_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_SocialActivities"></a> msdyncrm_linkedinform_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_linkedinform_SocialActivities](socialactivity.md#BKMK_msdyncrm_linkedinform_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_SyncErrors"></a> msdyncrm_linkedinform_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_linkedinform_SyncErrors](syncerror.md#BKMK_msdyncrm_linkedinform_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinform_Tasks"></a> msdyncrm_linkedinform_Tasks

Many-To-One Relationship: [task msdyncrm_linkedinform_Tasks](task.md#BKMK_msdyncrm_linkedinform_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinform_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinform_lead_sourceform"></a> msdyncrm_msdyncrm_linkedinform_lead_sourceform

Many-To-One Relationship: [lead msdyncrm_msdyncrm_linkedinform_lead_sourceform](lead.md#BKMK_msdyncrm_msdyncrm_linkedinform_lead_sourceform)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdyncrm_sourceform`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedinform_lead_sourceform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm"></a> msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm

Many-To-One Relationship: [msdyncrm_linkedinformquestion msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformquestion`|
|ReferencingAttribute|`msdyncrm_linkedinform`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformquestion_LinkedinForm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID"></a> msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID

Many-To-One Relationship: [msdyncrm_linkedinformsubmission msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformsubmission`|
|ReferencingAttribute|`msdyncrm_linkedinformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

