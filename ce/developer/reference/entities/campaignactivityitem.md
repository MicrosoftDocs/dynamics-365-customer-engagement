---
title: "Campaign Activity Item (CampaignActivityItem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Campaign Activity Item (CampaignActivityItem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Campaign Activity Item (CampaignActivityItem) table/entity reference (Microsoft Dynamics 365)

Work item of a campaign activity, such as a list or sales literature.

## Messages

The following table lists the messages for the Campaign Activity Item (CampaignActivityItem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /campaignactivityitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /campaignactivityitems(*campaignactivityitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /campaignactivityitems(*campaignactivityitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /campaignactivityitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|

## Properties

The following table lists selected properties for the Campaign Activity Item (CampaignActivityItem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Campaign Activity Item** |
| **DisplayCollectionName** | **Campaign Activity Items** |
| **SchemaName** | `CampaignActivityItem` |
| **EntitySetName** | `campaignactivityitems`|
| **LogicalName** | `campaignactivityitem` |
| **PrimaryIdAttribute** | `campaignactivityitemid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CampaignActivityId](#BKMK_CampaignActivityId)
- [CampaignActivityIdType](#BKMK_CampaignActivityIdType)
- [CampaignActivityItemId](#BKMK_CampaignActivityItemId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [ItemId](#BKMK_ItemId)
- [ItemObjectTypeCode](#BKMK_ItemObjectTypeCode)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_CampaignActivityId"></a> CampaignActivityId

|Property|Value|
|---|---|
|Description|**Unique identifier of the campaign activity for the item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`campaignactivityid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|campaignactivity|

### <a name="BKMK_CampaignActivityIdType"></a> CampaignActivityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`campaignactivityidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_CampaignActivityItemId"></a> CampaignActivityItemId

|Property|Value|
|---|---|
|Description|**Unique identifier of the campaign activity item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`campaignactivityitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_ItemId"></a> ItemId

|Property|Value|
|---|---|
|Description|**Unique identifier of the item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`itemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ItemObjectTypeCode"></a> ItemObjectTypeCode

|Property|Value|
|---|---|
|Description|**Identification of the type of the campaign activity item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`itemobjecttypecode`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**name**|
|DisplayName|**name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
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

- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Unique identifier of the user or team who owns the campaign activity item.**|
|DisplayName|**Owner**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|ApplicationRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Unique identifier of the user or team who owns the invoice detail.**|
|DisplayName|**Owner**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier of the business unit that owns the campaign activity item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier of the user that owns the campaign activity item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

### <a name="BKMK_ActivityPointer_CampaignActivityItems"></a> ActivityPointer_CampaignActivityItems

One-To-Many Relationship: [activitypointer ActivityPointer_CampaignActivityItems](activitypointer.md#BKMK_ActivityPointer_CampaignActivityItems)

|Property|Value|
|---|---|
|ReferencedEntity|`activitypointer`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`campaignactivityid`|
|ReferencingEntityNavigationPropertyName|`campaignactivityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [campaignactivityitem_AsyncOperations](#BKMK_campaignactivityitem_AsyncOperations)
- [campaignactivityitem_BulkDeleteFailures](#BKMK_campaignactivityitem_BulkDeleteFailures)
- [campaignactivityitem_MailboxTrackingFolders](#BKMK_campaignactivityitem_MailboxTrackingFolders)
- [campaignactivityitem_PrincipalObjectAttributeAccesses](#BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses)

### <a name="BKMK_campaignactivityitem_AsyncOperations"></a> campaignactivityitem_AsyncOperations

Many-To-One Relationship: [asyncoperation campaignactivityitem_AsyncOperations](asyncoperation.md#BKMK_campaignactivityitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivityitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivityitem_BulkDeleteFailures"></a> campaignactivityitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure campaignactivityitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_campaignactivityitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivityitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivityitem_MailboxTrackingFolders"></a> campaignactivityitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder campaignactivityitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_campaignactivityitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivityitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses"></a> campaignactivityitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess campaignactivityitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`campaignactivityitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [campaignactivitylist_association](#BKMK_campaignactivitylist_association)
- [campaignactivitysalesliterature_association](#BKMK_campaignactivitysalesliterature_association)

### <a name="BKMK_campaignactivitylist_association"></a> campaignactivitylist_association


|Property|Value|
|---|---|
|IntersectEntityName|`campaignactivityitem`|
|IsCustomizable|False|
|SchemaName|`campaignactivitylist_association`|

### <a name="BKMK_campaignactivitysalesliterature_association"></a> campaignactivitysalesliterature_association


|Property|Value|
|---|---|
|IntersectEntityName|`campaignactivityitem`|
|IsCustomizable|False|
|SchemaName|`campaignactivitysalesliterature_association`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

