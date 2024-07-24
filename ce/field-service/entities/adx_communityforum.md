---
title: "Forum (Adx_communityforum) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Forum (Adx_communityforum) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Forum (Adx_communityforum) table/entity reference



## Messages

The following table lists the messages for the Forum (Adx_communityforum) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_communityforums(*adx_communityforumid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_communityforums<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_communityforums(*adx_communityforumid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_communityforums(*adx_communityforumid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_communityforums<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_communityforums(*adx_communityforumid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_communityforums(*adx_communityforumid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_communityforums(*adx_communityforumid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Forum (Adx_communityforum) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forum (Adx_communityforum) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forum** |
| **DisplayCollectionName** | **Forums** |
| **SchemaName** | `Adx_communityforum` |
| **CollectionSchemaName** | `Adx_communityforums` |
| **EntitySetName** | `adx_communityforums`|
| **LogicalName** | `adx_communityforum` |
| **LogicalCollectionName** | `adx_communityforums` |
| **PrimaryIdAttribute** | `adx_communityforumid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Adx_communityforumId](#BKMK_Adx_communityforumId)
- [Adx_Description](#BKMK_Adx_Description)
- [Adx_DisplayOrder](#BKMK_Adx_DisplayOrder)
- [Adx_enablequeuedposts](#BKMK_Adx_enablequeuedposts)
- [adx_forumpagetemplateid](#BKMK_adx_forumpagetemplateid)
- [Adx_HiddenFromSitemap](#BKMK_Adx_HiddenFromSitemap)
- [adx_lastpostid](#BKMK_adx_lastpostid)
- [Adx_name](#BKMK_Adx_name)
- [adx_parentpageid](#BKMK_adx_parentpageid)
- [Adx_PartialUrl](#BKMK_Adx_PartialUrl)
- [Adx_PostCount](#BKMK_Adx_PostCount)
- [adx_publishingstateid](#BKMK_adx_publishingstateid)
- [Adx_ThreadCount](#BKMK_Adx_ThreadCount)
- [adx_threadpagetemplateid](#BKMK_adx_threadpagetemplateid)
- [adx_websiteid](#BKMK_adx_websiteid)
- [adx_websitelanguageid](#BKMK_adx_websitelanguageid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_Adx_communityforumId"></a> Adx_communityforumId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Forum**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_communityforumid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Adx_Description"></a> Adx_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4096|

### <a name="BKMK_Adx_DisplayOrder"></a> Adx_DisplayOrder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_displayorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_Adx_enablequeuedposts"></a> Adx_enablequeuedposts

|Property|Value|
|---|---|
|Description|**Automatically put posts in a queue awaiting a moderator to approve**|
|DisplayName|**Enable queued posts**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_enablequeuedposts`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_communityforum_adx_enablequeuedposts`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_forumpagetemplateid"></a> adx_forumpagetemplateid

|Property|Value|
|---|---|
|Description|**Shows the Page Template associated with the forum.**|
|DisplayName|**Forum Page Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumpagetemplateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_pagetemplate|

### <a name="BKMK_Adx_HiddenFromSitemap"></a> Adx_HiddenFromSitemap

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hidden From Sitemap**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_hiddenfromsitemap`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_communityforum_adx_hiddenfromsitemap`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_lastpostid"></a> adx_lastpostid

|Property|Value|
|---|---|
|Description|**Shows the forum post associated with the forum.**|
|DisplayName|**Last Post**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_lastpostid`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|adx_communityforumpost|

### <a name="BKMK_Adx_name"></a> Adx_name

|Property|Value|
|---|---|
|Description|**Shows the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_parentpageid"></a> adx_parentpageid

|Property|Value|
|---|---|
|Description|**Shows the webpage associated with the forum.**|
|DisplayName|**Parent Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_parentpageid`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_Adx_PartialUrl"></a> Adx_PartialUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Partial Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_partialurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_PostCount"></a> Adx_PostCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Post Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_postcount`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_publishingstateid"></a> adx_publishingstateid

|Property|Value|
|---|---|
|Description|**Shows the Publishing State associated with the forum.**|
|DisplayName|**Publishing State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_publishingstateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_publishingstate|

### <a name="BKMK_Adx_ThreadCount"></a> Adx_ThreadCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Thread Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_threadcount`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_threadpagetemplateid"></a> adx_threadpagetemplateid

|Property|Value|
|---|---|
|Description|**Shows the Page Template associated with the forum.**|
|DisplayName|**Thread Page Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_threadpagetemplateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_pagetemplate|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description|**Shows the Website associated with the forum.**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_website|

### <a name="BKMK_adx_websitelanguageid"></a> adx_websitelanguageid

|Property|Value|
|---|---|
|Description|**Option to make forums and forum posts language specific**|
|DisplayName|**Forum Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websitelanguageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_websitelanguage|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Forum**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_communityforum_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the forum's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_communityforum_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
|DisplayName|**Shows Zone Code.**|
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
|Description|**Shows the date and time that the record was created.**|
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
|Description|**Shows the date and time that the record was last updated.**|
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
|Description|**Shows the Yomi name of the owner.**|
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
|Description|**Shows the business unit that owns the record.**|
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

- [adx_communityforum_lastpost](#BKMK_adx_communityforum_lastpost)
- [adx_forumpagetemplate_communityforum](#BKMK_adx_forumpagetemplate_communityforum)
- [adx_publishingstate_communityforum](#BKMK_adx_publishingstate_communityforum)
- [adx_threadpagetemplate_communityforum](#BKMK_adx_threadpagetemplate_communityforum)
- [adx_webpage_communityforum](#BKMK_adx_webpage_communityforum)
- [adx_website_communityforum](#BKMK_adx_website_communityforum)
- [adx_websitelanguage_communityforum](#BKMK_adx_websitelanguage_communityforum)
- [business_unit_adx_communityforum](#BKMK_business_unit_adx_communityforum)
- [lk_adx_communityforum_createdby](#BKMK_lk_adx_communityforum_createdby)
- [lk_adx_communityforum_createdonbehalfby](#BKMK_lk_adx_communityforum_createdonbehalfby)
- [lk_adx_communityforum_modifiedby](#BKMK_lk_adx_communityforum_modifiedby)
- [lk_adx_communityforum_modifiedonbehalfby](#BKMK_lk_adx_communityforum_modifiedonbehalfby)
- [owner_adx_communityforum](#BKMK_owner_adx_communityforum)
- [team_adx_communityforum](#BKMK_team_adx_communityforum)
- [user_adx_communityforum](#BKMK_user_adx_communityforum)

### <a name="BKMK_adx_communityforum_lastpost"></a> adx_communityforum_lastpost

One-To-Many Relationship: [adx_communityforumpost adx_communityforum_lastpost](adx_communityforumpost.md#BKMK_adx_communityforum_lastpost)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumpost`|
|ReferencedAttribute|`adx_communityforumpostid`|
|ReferencingAttribute|`adx_lastpostid`|
|ReferencingEntityNavigationPropertyName|`adx_lastpostid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_forumpagetemplate_communityforum"></a> adx_forumpagetemplate_communityforum

One-To-Many Relationship: [adx_pagetemplate adx_forumpagetemplate_communityforum](adx_pagetemplate.md#BKMK_adx_forumpagetemplate_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pagetemplate`|
|ReferencedAttribute|`adx_pagetemplateid`|
|ReferencingAttribute|`adx_forumpagetemplateid`|
|ReferencingEntityNavigationPropertyName|`adx_forumpagetemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_publishingstate_communityforum"></a> adx_publishingstate_communityforum

One-To-Many Relationship: [adx_publishingstate adx_publishingstate_communityforum](adx_publishingstate.md#BKMK_adx_publishingstate_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstate`|
|ReferencedAttribute|`adx_publishingstateid`|
|ReferencingAttribute|`adx_publishingstateid`|
|ReferencingEntityNavigationPropertyName|`adx_publishingstateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_threadpagetemplate_communityforum"></a> adx_threadpagetemplate_communityforum

One-To-Many Relationship: [adx_pagetemplate adx_threadpagetemplate_communityforum](adx_pagetemplate.md#BKMK_adx_threadpagetemplate_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pagetemplate`|
|ReferencedAttribute|`adx_pagetemplateid`|
|ReferencingAttribute|`adx_threadpagetemplateid`|
|ReferencingEntityNavigationPropertyName|`adx_threadpagetemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_communityforum"></a> adx_webpage_communityforum

One-To-Many Relationship: [adx_webpage adx_webpage_communityforum](adx_webpage.md#BKMK_adx_webpage_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_parentpageid`|
|ReferencingEntityNavigationPropertyName|`adx_parentpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_communityforum"></a> adx_website_communityforum

One-To-Many Relationship: [adx_website adx_website_communityforum](adx_website.md#BKMK_adx_website_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencingEntityNavigationPropertyName|`adx_websiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_websitelanguage_communityforum"></a> adx_websitelanguage_communityforum

One-To-Many Relationship: [adx_websitelanguage adx_websitelanguage_communityforum](adx_websitelanguage.md#BKMK_adx_websitelanguage_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_websitelanguage`|
|ReferencedAttribute|`adx_websitelanguageid`|
|ReferencingAttribute|`adx_websitelanguageid`|
|ReferencingEntityNavigationPropertyName|`adx_websitelanguageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_adx_communityforum"></a> business_unit_adx_communityforum

One-To-Many Relationship: [businessunit business_unit_adx_communityforum](businessunit.md#BKMK_business_unit_adx_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforum_createdby"></a> lk_adx_communityforum_createdby

One-To-Many Relationship: [systemuser lk_adx_communityforum_createdby](systemuser.md#BKMK_lk_adx_communityforum_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforum_createdonbehalfby"></a> lk_adx_communityforum_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_communityforum_createdonbehalfby](systemuser.md#BKMK_lk_adx_communityforum_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforum_modifiedby"></a> lk_adx_communityforum_modifiedby

One-To-Many Relationship: [systemuser lk_adx_communityforum_modifiedby](systemuser.md#BKMK_lk_adx_communityforum_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforum_modifiedonbehalfby"></a> lk_adx_communityforum_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_communityforum_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_communityforum_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_communityforum"></a> owner_adx_communityforum

One-To-Many Relationship: [owner owner_adx_communityforum](owner.md#BKMK_owner_adx_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_communityforum"></a> team_adx_communityforum

One-To-Many Relationship: [team team_adx_communityforum](team.md#BKMK_team_adx_communityforum)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_communityforum"></a> user_adx_communityforum

One-To-Many Relationship: [systemuser user_adx_communityforum](systemuser.md#BKMK_user_adx_communityforum)

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

- [adx_communityforum_Annotations](#BKMK_adx_communityforum_Annotations)
- [adx_communityforum_AsyncOperations](#BKMK_adx_communityforum_AsyncOperations)
- [adx_communityforum_BulkDeleteFailures](#BKMK_adx_communityforum_BulkDeleteFailures)
- [adx_communityforum_communityforumannouncement](#BKMK_adx_communityforum_communityforumannouncement)
- [adx_communityforum_communityforumthread](#BKMK_adx_communityforum_communityforumthread)
- [adx_communityforum_forumaccesspermission](#BKMK_adx_communityforum_forumaccesspermission)
- [adx_communityforum_forumnotification](#BKMK_adx_communityforum_forumnotification)
- [adx_communityforum_MailboxTrackingFolders](#BKMK_adx_communityforum_MailboxTrackingFolders)
- [adx_communityforum_PrincipalObjectAttributeAccesses](#BKMK_adx_communityforum_PrincipalObjectAttributeAccesses)
- [adx_communityforum_ProcessSession](#BKMK_adx_communityforum_ProcessSession)
- [adx_communityforum_shortcut](#BKMK_adx_communityforum_shortcut)
- [adx_communityforum_SyncErrors](#BKMK_adx_communityforum_SyncErrors)

### <a name="BKMK_adx_communityforum_Annotations"></a> adx_communityforum_Annotations

Many-To-One Relationship: [annotation adx_communityforum_Annotations](annotation.md#BKMK_adx_communityforum_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_AsyncOperations"></a> adx_communityforum_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_communityforum_AsyncOperations](asyncoperation.md#BKMK_adx_communityforum_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_BulkDeleteFailures"></a> adx_communityforum_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_communityforum_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_communityforum_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_communityforumannouncement"></a> adx_communityforum_communityforumannouncement

Many-To-One Relationship: [adx_communityforumannouncement adx_communityforum_communityforumannouncement](adx_communityforumannouncement.md#BKMK_adx_communityforum_communityforumannouncement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumannouncement`|
|ReferencingAttribute|`adx_forumid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_communityforumannouncement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100620<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_communityforumthread"></a> adx_communityforum_communityforumthread

Many-To-One Relationship: [adx_communityforumthread adx_communityforum_communityforumthread](adx_communityforumthread.md#BKMK_adx_communityforum_communityforumthread)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumthread`|
|ReferencingAttribute|`adx_forumid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_communityforumthread`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100650<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_forumaccesspermission"></a> adx_communityforum_forumaccesspermission

Many-To-One Relationship: [adx_communityforumaccesspermission adx_communityforum_forumaccesspermission](adx_communityforumaccesspermission.md#BKMK_adx_communityforum_forumaccesspermission)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumaccesspermission`|
|ReferencingAttribute|`adx_forumid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_forumaccesspermission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100600<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_forumnotification"></a> adx_communityforum_forumnotification

Many-To-One Relationship: [adx_forumnotification adx_communityforum_forumnotification](adx_forumnotification.md#BKMK_adx_communityforum_forumnotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumnotification`|
|ReferencingAttribute|`adx_forum`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_forumnotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_MailboxTrackingFolders"></a> adx_communityforum_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_communityforum_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_communityforum_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_PrincipalObjectAttributeAccesses"></a> adx_communityforum_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_communityforum_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_communityforum_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_ProcessSession"></a> adx_communityforum_ProcessSession

Many-To-One Relationship: [processsession adx_communityforum_ProcessSession](processsession.md#BKMK_adx_communityforum_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_shortcut"></a> adx_communityforum_shortcut

Many-To-One Relationship: [adx_shortcut adx_communityforum_shortcut](adx_shortcut.md#BKMK_adx_communityforum_shortcut)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_shortcut`|
|ReferencingAttribute|`adx_forumid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_shortcut`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforum_SyncErrors"></a> adx_communityforum_SyncErrors

Many-To-One Relationship: [syncerror adx_communityforum_SyncErrors](syncerror.md#BKMK_adx_communityforum_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_adx_forum_activityalert"></a> adx_forum_activityalert

See [contact adx_forum_activityalert Many-To-Many Relationship](contact.md#BKMK_adx_forum_activityalert)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_forum_activityalert`|
|IsCustomizable|True|
|SchemaName|`adx_forum_activityalert`|
|IntersectAttribute|`adx_communityforumid`|
|NavigationPropertyName|`adx_forum_activityalert`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Forum Activity Alerts<br />MenuId: null<br />Order: 100995<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

