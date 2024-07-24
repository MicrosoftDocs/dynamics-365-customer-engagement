---
title: "LinkedIn Campaign (msdyncrm_linkedincampaign) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the LinkedIn Campaign (msdyncrm_linkedincampaign) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# LinkedIn Campaign (msdyncrm_linkedincampaign) table/entity reference

Campaign used to capture submissions from prospects.

## Messages

The following table lists the messages for the LinkedIn Campaign (msdyncrm_linkedincampaign) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_linkedincampaigns(*msdyncrm_linkedincampaignid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_linkedincampaigns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_linkedincampaigns(*msdyncrm_linkedincampaignid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_linkedincampaigns(*msdyncrm_linkedincampaignid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_linkedincampaigns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_linkedincampaigns(*msdyncrm_linkedincampaignid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_linkedincampaigns(*msdyncrm_linkedincampaignid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_linkedincampaigns(*msdyncrm_linkedincampaignid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the LinkedIn Campaign (msdyncrm_linkedincampaign) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the LinkedIn Campaign (msdyncrm_linkedincampaign) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **LinkedIn Campaign** |
| **DisplayCollectionName** | **LinkedIn Campaigns** |
| **SchemaName** | `msdyncrm_linkedincampaign` |
| **CollectionSchemaName** | `msdyncrm_linkedincampaigns` |
| **EntitySetName** | `msdyncrm_linkedincampaigns`|
| **LogicalName** | `msdyncrm_linkedincampaign` |
| **LogicalCollectionName** | `msdyncrm_linkedincampaigns` |
| **PrimaryIdAttribute** | `msdyncrm_linkedincampaignid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_CampaignType](#BKMK_msdyncrm_CampaignType)
- [msdyncrm_EndDate](#BKMK_msdyncrm_EndDate)
- [msdyncrm_LinkedInAccount](#BKMK_msdyncrm_LinkedInAccount)
- [msdyncrm_linkedincampaignId](#BKMK_msdyncrm_linkedincampaignId)
- [msdyncrm_linkedinid](#BKMK_msdyncrm_linkedinid)
- [msdyncrm_LinkedInStatus](#BKMK_msdyncrm_LinkedInStatus)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_StartDate](#BKMK_msdyncrm_StartDate)
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
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_CampaignType"></a> msdyncrm_CampaignType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Campaign Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_campaigntype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_linkedincampaign_msdyncrm_campaigntype`|

#### msdyncrm_CampaignType Choices/Options

|Value|Label|
|---|---|
|192350000|**Text Advertisement**|
|192350001|**LinkedIn Sponsored Content**|
|192350002|**LinkedIn Sponsored InMail**|
|192350003|**LinkedIn Dynamic Ad**|

### <a name="BKMK_msdyncrm_EndDate"></a> msdyncrm_EndDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Proposed End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_enddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_LinkedInAccount"></a> msdyncrm_LinkedInAccount

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinaccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_linkedinaccount|

### <a name="BKMK_msdyncrm_linkedincampaignId"></a> msdyncrm_linkedincampaignId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**LinkedIn Campaign**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedincampaignid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_linkedinid"></a> msdyncrm_linkedinid

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyncrm_LinkedInStatus"></a> msdyncrm_LinkedInStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_linkedincampaign_msdyncrm_linkedinstatus`|

#### msdyncrm_LinkedInStatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Active**|
|192350001|**Paused**|
|192350002|**Archived**|
|192350003|**Completed**|
|192350004|**Canceled**|
|192350005|**Draft**|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the campaign.**|
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

### <a name="BKMK_msdyncrm_StartDate"></a> msdyncrm_StartDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Proposed Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_startdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
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
|Description|**Status of the LinkedIn Campaign**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedincampaign_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the LinkedIn Campaign**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedincampaign_statuscode`|

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
- [msdyncrm_totalleads](#BKMK_msdyncrm_totalleads)
- [msdyncrm_totalleads_Date](#BKMK_msdyncrm_totalleads_Date)
- [msdyncrm_totalleads_State](#BKMK_msdyncrm_totalleads_State)
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
|Description|**Unique identifier of the user who created the record**|
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
|Description|**Date and time when the record was created**|
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
|Description|**Unique identifier of the delegate user who created the record**|
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
|Description|**Unique identifier of the user who modified the record**|
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
|Description|**Date and time when the record was modified**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_totalleads"></a> msdyncrm_totalleads

|Property|Value|
|---|---|
|Description|**Total number of leads for this linkiedin campaign**|
|DisplayName|**Total leads**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_totalleads`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_totalleads_Date"></a> msdyncrm_totalleads_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Total leads.**|
|DisplayName|**Total leads (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_totalleads_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_totalleads_State"></a> msdyncrm_totalleads_State

|Property|Value|
|---|---|
|Description|**State of rollup field Total leads.**|
|DisplayName|**Total leads (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_totalleads_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_totalsubmissions"></a> msdyncrm_totalsubmissions

|Property|Value|
|---|---|
|Description|**Total number of submissions received on this linkiedin campaign**|
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

- [business_unit_msdyncrm_linkedincampaign](#BKMK_business_unit_msdyncrm_linkedincampaign)
- [lk_msdyncrm_linkedincampaign_createdby](#BKMK_lk_msdyncrm_linkedincampaign_createdby)
- [lk_msdyncrm_linkedincampaign_createdonbehalfby](#BKMK_lk_msdyncrm_linkedincampaign_createdonbehalfby)
- [lk_msdyncrm_linkedincampaign_modifiedby](#BKMK_lk_msdyncrm_linkedincampaign_modifiedby)
- [lk_msdyncrm_linkedincampaign_modifiedonbehalfby](#BKMK_lk_msdyncrm_linkedincampaign_modifiedonbehalfby)
- [msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount](#BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount)
- [owner_msdyncrm_linkedincampaign](#BKMK_owner_msdyncrm_linkedincampaign)
- [team_msdyncrm_linkedincampaign](#BKMK_team_msdyncrm_linkedincampaign)
- [user_msdyncrm_linkedincampaign](#BKMK_user_msdyncrm_linkedincampaign)

### <a name="BKMK_business_unit_msdyncrm_linkedincampaign"></a> business_unit_msdyncrm_linkedincampaign

One-To-Many Relationship: [businessunit business_unit_msdyncrm_linkedincampaign](businessunit.md#BKMK_business_unit_msdyncrm_linkedincampaign)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedincampaign_createdby"></a> lk_msdyncrm_linkedincampaign_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedincampaign_createdby](systemuser.md#BKMK_lk_msdyncrm_linkedincampaign_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedincampaign_createdonbehalfby"></a> lk_msdyncrm_linkedincampaign_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedincampaign_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedincampaign_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedincampaign_modifiedby"></a> lk_msdyncrm_linkedincampaign_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedincampaign_modifiedby](systemuser.md#BKMK_lk_msdyncrm_linkedincampaign_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedincampaign_modifiedonbehalfby"></a> lk_msdyncrm_linkedincampaign_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedincampaign_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedincampaign_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount"></a> msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`msdyncrm_linkedinaccount`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_LinkedInAccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_linkedincampaign"></a> owner_msdyncrm_linkedincampaign

One-To-Many Relationship: [owner owner_msdyncrm_linkedincampaign](owner.md#BKMK_owner_msdyncrm_linkedincampaign)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_linkedincampaign"></a> team_msdyncrm_linkedincampaign

One-To-Many Relationship: [team team_msdyncrm_linkedincampaign](team.md#BKMK_team_msdyncrm_linkedincampaign)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_linkedincampaign"></a> user_msdyncrm_linkedincampaign

One-To-Many Relationship: [systemuser user_msdyncrm_linkedincampaign](systemuser.md#BKMK_user_msdyncrm_linkedincampaign)

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

- [msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign](#BKMK_msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign)
- [msdyncrm_linkedincampaign_AsyncOperations](#BKMK_msdyncrm_linkedincampaign_AsyncOperations)
- [msdyncrm_linkedincampaign_BulkDeleteFailures](#BKMK_msdyncrm_linkedincampaign_BulkDeleteFailures)
- [msdyncrm_linkedincampaign_DuplicateBaseRecord](#BKMK_msdyncrm_linkedincampaign_DuplicateBaseRecord)
- [msdyncrm_linkedincampaign_DuplicateMatchingRecord](#BKMK_msdyncrm_linkedincampaign_DuplicateMatchingRecord)
- [msdyncrm_linkedincampaign_MailboxTrackingFolders](#BKMK_msdyncrm_linkedincampaign_MailboxTrackingFolders)
- [msdyncrm_linkedincampaign_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_linkedincampaign_PrincipalObjectAttributeAccesses)
- [msdyncrm_linkedincampaign_ProcessSession](#BKMK_msdyncrm_linkedincampaign_ProcessSession)
- [msdyncrm_linkedincampaign_SyncErrors](#BKMK_msdyncrm_linkedincampaign_SyncErrors)
- [msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign](#BKMK_msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign)
- [msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedincampaignactivity_campaignid](#BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedincampaignactivity_campaignid)
- [msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign](#BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign)

### <a name="BKMK_msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign"></a> msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign

Many-To-One Relationship: [msdyncrm_customerjourney msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign](msdyncrm_customerjourney.md#BKMK_msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourney`|
|ReferencingAttribute|`msdyncr2_linkedincampaign`|
|ReferencedEntityNavigationPropertyName|`msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedincampaign_AsyncOperations"></a> msdyncrm_linkedincampaign_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_linkedincampaign_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_linkedincampaign_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedincampaign_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedincampaign_BulkDeleteFailures"></a> msdyncrm_linkedincampaign_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_linkedincampaign_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_linkedincampaign_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedincampaign_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedincampaign_DuplicateBaseRecord"></a> msdyncrm_linkedincampaign_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedincampaign_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_linkedincampaign_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedincampaign_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedincampaign_DuplicateMatchingRecord"></a> msdyncrm_linkedincampaign_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedincampaign_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_linkedincampaign_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedincampaign_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedincampaign_MailboxTrackingFolders"></a> msdyncrm_linkedincampaign_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_linkedincampaign_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_linkedincampaign_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedincampaign_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedincampaign_PrincipalObjectAttributeAccesses"></a> msdyncrm_linkedincampaign_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_linkedincampaign_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_linkedincampaign_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedincampaign_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedincampaign_ProcessSession"></a> msdyncrm_linkedincampaign_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_linkedincampaign_ProcessSession](processsession.md#BKMK_msdyncrm_linkedincampaign_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedincampaign_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedincampaign_SyncErrors"></a> msdyncrm_linkedincampaign_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_linkedincampaign_SyncErrors](syncerror.md#BKMK_msdyncrm_linkedincampaign_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedincampaign_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign"></a> msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign

Many-To-One Relationship: [lead msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign](lead.md#BKMK_msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdyncrm_linkedincampaign`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedincampaignactivity_campaignid"></a> msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedincampaignactivity_campaignid

Many-To-One Relationship: [msdyncrm_linkedincampaignactivity msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedincampaignactivity_campaignid](msdyncrm_linkedincampaignactivity.md#BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedincampaignactivity_campaignid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedincampaignactivity`|
|ReferencingAttribute|`msdyncrm_campaignid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedincampaignactivity_campaignid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign"></a> msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign

Many-To-One Relationship: [msdyncrm_linkedinformsubmission msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformsubmission`|
|ReferencingAttribute|`msdyncrm_linkedincampaign`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

