---
title: "Forum Notification (adx_forumnotification) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Forum Notification (adx_forumnotification) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Forum Notification (adx_forumnotification) table/entity reference

Command pattern entity that gets created by a plug-in upon creation of the adx_communityforumpost entity. The creation of this entity triggers a workflow that sends an email.

## Messages

The following table lists the messages for the Forum Notification (adx_forumnotification) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /adx_forumnotifications<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_forumnotifications(*adx_forumnotificationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_forumnotifications(*adx_forumnotificationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_forumnotifications<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /adx_forumnotifications(*adx_forumnotificationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_forumnotifications(*adx_forumnotificationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_forumnotifications(*adx_forumnotificationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Forum Notification (adx_forumnotification) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forum Notification (adx_forumnotification) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forum Notification** |
| **DisplayCollectionName** | **Forum Notifications** |
| **SchemaName** | `adx_forumnotification` |
| **CollectionSchemaName** | `adx_forumnotifications` |
| **EntitySetName** | `adx_forumnotifications`|
| **LogicalName** | `adx_forumnotification` |
| **LogicalCollectionName** | `adx_forumnotifications` |
| **PrimaryIdAttribute** | `adx_forumnotificationid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_forum](#BKMK_adx_forum)
- [adx_forumnotificationId](#BKMK_adx_forumnotificationId)
- [adx_forumparentpage](#BKMK_adx_forumparentpage)
- [adx_forumpost](#BKMK_adx_forumpost)
- [adx_forumpostid](#BKMK_adx_forumpostid)
- [adx_forumthread](#BKMK_adx_forumthread)
- [adx_forumthreadid](#BKMK_adx_forumthreadid)
- [adx_name](#BKMK_adx_name)
- [adx_recipient](#BKMK_adx_recipient)
- [adx_website](#BKMK_adx_website)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_forum"></a> adx_forum

|Property|Value|
|---|---|
|Description|**Shows the forum associated with the forum notification.**|
|DisplayName|**Forum**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forum`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_communityforum|

### <a name="BKMK_adx_forumnotificationId"></a> adx_forumnotificationId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Forum Notification**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_forumnotificationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_forumparentpage"></a> adx_forumparentpage

|Property|Value|
|---|---|
|Description|**Shows the webpage associated with the forum notification.**|
|DisplayName|**Forum Parent Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumparentpage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_adx_forumpost"></a> adx_forumpost

|Property|Value|
|---|---|
|Description|**Shows the forum post associated with the  forum notification.**|
|DisplayName|**Forum Post**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumpost`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_communityforumpost|

### <a name="BKMK_adx_forumpostid"></a> adx_forumpostid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Forum Post Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumpostid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_forumthread"></a> adx_forumthread

|Property|Value|
|---|---|
|Description|**Shows the forum Thread associated with the forum notification.**|
|DisplayName|**Forum Thread**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumthread`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_communityforumthread|

### <a name="BKMK_adx_forumthreadid"></a> adx_forumthreadid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Forum Thread Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumthreadid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_name"></a> adx_name

|Property|Value|
|---|---|
|Description|**Shows the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_recipient"></a> adx_recipient

|Property|Value|
|---|---|
|Description|**Shows the contact associated with the forum notification.**|
|DisplayName|**Recipient**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_recipient`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_adx_website"></a> adx_website

|Property|Value|
|---|---|
|Description|**Shows the Website associated with the forum notification.**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_website`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_website|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Forum Notification**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_forumnotification_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the forum notification's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_forumnotification_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Shows the organization.**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [adx_communityforum_forumnotification](#BKMK_adx_communityforum_forumnotification)
- [adx_communityforumpost_forumnotification](#BKMK_adx_communityforumpost_forumnotification)
- [adx_communityforumthread_forumnotification_fo](#BKMK_adx_communityforumthread_forumnotification_fo)
- [adx_contact_forumnotification](#BKMK_adx_contact_forumnotification)
- [adx_webpage_forumnotification](#BKMK_adx_webpage_forumnotification)
- [adx_website_forumnotification](#BKMK_adx_website_forumnotification)
- [lk_adx_forumnotification_createdby](#BKMK_lk_adx_forumnotification_createdby)
- [lk_adx_forumnotification_createdonbehalfby](#BKMK_lk_adx_forumnotification_createdonbehalfby)
- [lk_adx_forumnotification_modifiedby](#BKMK_lk_adx_forumnotification_modifiedby)
- [lk_adx_forumnotification_modifiedonbehalfby](#BKMK_lk_adx_forumnotification_modifiedonbehalfby)
- [organization_adx_forumnotification](#BKMK_organization_adx_forumnotification)

### <a name="BKMK_adx_communityforum_forumnotification"></a> adx_communityforum_forumnotification

One-To-Many Relationship: [adx_communityforum adx_communityforum_forumnotification](adx_communityforum.md#BKMK_adx_communityforum_forumnotification)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforum`|
|ReferencedAttribute|`adx_communityforumid`|
|ReferencingAttribute|`adx_forum`|
|ReferencingEntityNavigationPropertyName|`adx_forum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_communityforumpost_forumnotification"></a> adx_communityforumpost_forumnotification

One-To-Many Relationship: [adx_communityforumpost adx_communityforumpost_forumnotification](adx_communityforumpost.md#BKMK_adx_communityforumpost_forumnotification)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumpost`|
|ReferencedAttribute|`adx_communityforumpostid`|
|ReferencingAttribute|`adx_forumpost`|
|ReferencingEntityNavigationPropertyName|`adx_forumpost`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_communityforumthread_forumnotification_fo"></a> adx_communityforumthread_forumnotification_fo

One-To-Many Relationship: [adx_communityforumthread adx_communityforumthread_forumnotification_fo](adx_communityforumthread.md#BKMK_adx_communityforumthread_forumnotification_fo)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumthread`|
|ReferencedAttribute|`adx_communityforumthreadid`|
|ReferencingAttribute|`adx_forumthread`|
|ReferencingEntityNavigationPropertyName|`adx_forumthread`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_contact_forumnotification"></a> adx_contact_forumnotification

One-To-Many Relationship: [contact adx_contact_forumnotification](contact.md#BKMK_adx_contact_forumnotification)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`adx_recipient`|
|ReferencingEntityNavigationPropertyName|`adx_recipient`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_forumnotification"></a> adx_webpage_forumnotification

One-To-Many Relationship: [adx_webpage adx_webpage_forumnotification](adx_webpage.md#BKMK_adx_webpage_forumnotification)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_forumparentpage`|
|ReferencingEntityNavigationPropertyName|`adx_forumparentpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_forumnotification"></a> adx_website_forumnotification

One-To-Many Relationship: [adx_website adx_website_forumnotification](adx_website.md#BKMK_adx_website_forumnotification)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_website`|
|ReferencingEntityNavigationPropertyName|`adx_website`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_forumnotification_createdby"></a> lk_adx_forumnotification_createdby

One-To-Many Relationship: [systemuser lk_adx_forumnotification_createdby](systemuser.md#BKMK_lk_adx_forumnotification_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_forumnotification_createdonbehalfby"></a> lk_adx_forumnotification_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_forumnotification_createdonbehalfby](systemuser.md#BKMK_lk_adx_forumnotification_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_forumnotification_modifiedby"></a> lk_adx_forumnotification_modifiedby

One-To-Many Relationship: [systemuser lk_adx_forumnotification_modifiedby](systemuser.md#BKMK_lk_adx_forumnotification_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_forumnotification_modifiedonbehalfby"></a> lk_adx_forumnotification_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_forumnotification_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_forumnotification_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_adx_forumnotification"></a> organization_adx_forumnotification

One-To-Many Relationship: [organization organization_adx_forumnotification](organization.md#BKMK_organization_adx_forumnotification)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_forumnotification_AsyncOperations](#BKMK_adx_forumnotification_AsyncOperations)
- [adx_forumnotification_BulkDeleteFailures](#BKMK_adx_forumnotification_BulkDeleteFailures)
- [adx_forumnotification_MailboxTrackingFolders](#BKMK_adx_forumnotification_MailboxTrackingFolders)
- [adx_forumnotification_PrincipalObjectAttributeAccesses](#BKMK_adx_forumnotification_PrincipalObjectAttributeAccesses)
- [adx_forumnotification_ProcessSession](#BKMK_adx_forumnotification_ProcessSession)
- [adx_forumnotification_SyncErrors](#BKMK_adx_forumnotification_SyncErrors)

### <a name="BKMK_adx_forumnotification_AsyncOperations"></a> adx_forumnotification_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_forumnotification_AsyncOperations](asyncoperation.md#BKMK_adx_forumnotification_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_forumnotification_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_forumnotification_BulkDeleteFailures"></a> adx_forumnotification_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_forumnotification_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_forumnotification_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_forumnotification_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_forumnotification_MailboxTrackingFolders"></a> adx_forumnotification_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_forumnotification_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_forumnotification_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_forumnotification_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_forumnotification_PrincipalObjectAttributeAccesses"></a> adx_forumnotification_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_forumnotification_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_forumnotification_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_forumnotification_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_forumnotification_ProcessSession"></a> adx_forumnotification_ProcessSession

Many-To-One Relationship: [processsession adx_forumnotification_ProcessSession](processsession.md#BKMK_adx_forumnotification_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_forumnotification_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_forumnotification_SyncErrors"></a> adx_forumnotification_SyncErrors

Many-To-One Relationship: [syncerror adx_forumnotification_SyncErrors](syncerror.md#BKMK_adx_forumnotification_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_forumnotification_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

