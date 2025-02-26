---
title: "Campaign Item (CampaignItem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Campaign Item (CampaignItem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Campaign Item (CampaignItem) table/entity reference (Microsoft Dynamics 365)

Work item in a campaign, a list or sales literature.

## Messages

The following table lists the messages for the Campaign Item (CampaignItem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /campaignitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /campaignitems(*campaignitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /campaignitems(*campaignitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /campaignitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|

## Properties

The following table lists selected properties for the Campaign Item (CampaignItem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Campaign Item** |
| **DisplayCollectionName** | **Campaign Items** |
| **SchemaName** | `CampaignItem` |
| **EntitySetName** | `campaignitems`|
| **LogicalName** | `campaignitem` |
| **PrimaryIdAttribute** | `campaignitemid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CampaignId](#BKMK_CampaignId)
- [CampaignItemId](#BKMK_CampaignItemId)
- [EntityId](#BKMK_EntityId)
- [EntityType](#BKMK_EntityType)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_CampaignId"></a> CampaignId

|Property|Value|
|---|---|
|Description|**Unique identifier of the campaign that is associated with the individual item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`campaignid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|campaign|

### <a name="BKMK_CampaignItemId"></a> CampaignItemId

|Property|Value|
|---|---|
|Description|**Unique identifier of the campaign item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`campaignitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_EntityId"></a> EntityId

|Property|Value|
|---|---|
|Description|**Unique identifier of the entity for the campaign item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_EntityType"></a> EntityType

|Property|Value|
|---|---|
|Description|**Object type of entity for the campaign item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entitytype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

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
|Description|**Unique identifier of the user or team who owns the campaign item.**|
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
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier of the business unit that owns the campaign item.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier of the user that owns the campaign item.**|
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

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [campaignitem_AsyncOperations](#BKMK_campaignitem_AsyncOperations)
- [campaignitem_BulkDeleteFailures](#BKMK_campaignitem_BulkDeleteFailures)
- [campaignitem_MailboxTrackingFolders](#BKMK_campaignitem_MailboxTrackingFolders)
- [campaignitem_PrincipalObjectAttributeAccesses](#BKMK_campaignitem_PrincipalObjectAttributeAccesses)

### <a name="BKMK_campaignitem_AsyncOperations"></a> campaignitem_AsyncOperations

Many-To-One Relationship: [asyncoperation campaignitem_AsyncOperations](asyncoperation.md#BKMK_campaignitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignitem_BulkDeleteFailures"></a> campaignitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure campaignitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_campaignitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignitem_MailboxTrackingFolders"></a> campaignitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder campaignitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_campaignitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`campaignitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignitem_PrincipalObjectAttributeAccesses"></a> campaignitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess campaignitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_campaignitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`campaignitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [campaigncampaign_association](#BKMK_campaigncampaign_association)
- [campaignlist_association](#BKMK_campaignlist_association)
- [campaignproduct_association](#BKMK_campaignproduct_association)
- [campaignsalesliterature_association](#BKMK_campaignsalesliterature_association)

### <a name="BKMK_campaigncampaign_association"></a> campaigncampaign_association


|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaigncampaign_association`|

### <a name="BKMK_campaignlist_association"></a> campaignlist_association


|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaignlist_association`|

### <a name="BKMK_campaignproduct_association"></a> campaignproduct_association


|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaignproduct_association`|

### <a name="BKMK_campaignsalesliterature_association"></a> campaignsalesliterature_association


|Property|Value|
|---|---|
|IntersectEntityName|`campaignitem`|
|IsCustomizable|False|
|SchemaName|`campaignsalesliterature_association`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

