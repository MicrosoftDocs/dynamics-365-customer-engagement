---
title: "CampaignActivityItem Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CampaignActivityItem entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CampaignActivityItem Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Work item of a campaign activity, such as a list or sales literature.

**Added by**: Marketing Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/campaignactivityitems<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/campaignactivityitems(*campaignactivityitemid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/campaignactivityitems(*campaignactivityitemid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/campaignactivityitems<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

**DisplayName**: Campaign Activity Item<br />
**DisplayCollectionName**: Campaign Activity Items<br />
**SchemaName**: CampaignActivityItem<br />
**CollectionSchemaName**: <br />
**LogicalName**: campaignactivityitem<br />
**LogicalCollectionName**: <br />
**EntitySetName**: campaignactivityitems<br />
**PrimaryIdAttribute**: campaignactivityitemid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

**Description**: Unique identifier of the campaign activity for the item.<br />
**DisplayName**: <br />
**LogicalName**: campaignactivityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: campaignactivity


### <a name="BKMK_CampaignActivityIdType"></a> CampaignActivityIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: campaignactivityidtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_CampaignActivityItemId"></a> CampaignActivityItemId

**Description**: Unique identifier of the campaign activity item.<br />
**DisplayName**: <br />
**LogicalName**: campaignactivityitemid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_ItemId"></a> ItemId

**Description**: Unique identifier of the item.<br />
**DisplayName**: <br />
**LogicalName**: itemid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ItemObjectTypeCode"></a> ItemObjectTypeCode

**Description**: Identification of the type of the campaign activity item.<br />
**DisplayName**: <br />
**LogicalName**: itemobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_Name"></a> Name

**Description**: name<br />
**DisplayName**: name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CampaignActivityIdName](#BKMK_CampaignActivityIdName)
- [CampaignActivityIdYomiName](#BKMK_CampaignActivityIdYomiName)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CampaignActivityIdName"></a> CampaignActivityIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: campaignactivityidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


### <a name="BKMK_CampaignActivityIdYomiName"></a> CampaignActivityIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: campaignactivityidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the campaign activity item.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Unique identifier of the user or team who owns the invoice detail.<br />
**DisplayName**: Owner<br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns the campaign activity item.<br />
**DisplayName**: <br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user that owns the campaign activity item.<br />
**DisplayName**: <br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [campaignactivityitem_AsyncOperations](#BKMK_campaignactivityitem_AsyncOperations)
- [campaignactivityitem_MailboxTrackingFolders](#BKMK_campaignactivityitem_MailboxTrackingFolders)
- [campaignactivityitem_UserEntityInstanceDatas](#BKMK_campaignactivityitem_UserEntityInstanceDatas)
- [campaignactivityitem_BulkDeleteFailures](#BKMK_campaignactivityitem_BulkDeleteFailures)
- [campaignactivityitem_PrincipalObjectAttributeAccesses](#BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses)
- [userentityinstancedata_campaignactivityitem](#BKMK_userentityinstancedata_campaignactivityitem)


### <a name="BKMK_campaignactivityitem_AsyncOperations"></a> campaignactivityitem_AsyncOperations

Same as asyncoperation entity [campaignactivityitem_AsyncOperations](asyncoperation.md#BKMK_campaignactivityitem_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivityitem_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignactivityitem_MailboxTrackingFolders"></a> campaignactivityitem_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [campaignactivityitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_campaignactivityitem_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivityitem_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_campaignactivityitem_UserEntityInstanceDatas"></a> campaignactivityitem_UserEntityInstanceDatas

Same as userentityinstancedata entity [campaignactivityitem_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_campaignactivityitem_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivityitem_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignactivityitem_BulkDeleteFailures"></a> campaignactivityitem_BulkDeleteFailures

Same as bulkdeletefailure entity [campaignactivityitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_campaignactivityitem_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivityitem_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses"></a> campaignactivityitem_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [campaignactivityitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivityitem_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_userentityinstancedata_campaignactivityitem"></a> userentityinstancedata_campaignactivityitem

Same as userentityinstancedata entity [userentityinstancedata_campaignactivityitem](userentityinstancedata.md#BKMK_userentityinstancedata_campaignactivityitem) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_campaignactivityitem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_ActivityPointer_CampaignActivityItems"></a> ActivityPointer_CampaignActivityItems

See activitypointer Entity [ActivityPointer_CampaignActivityItems](activitypointer.md#BKMK_ActivityPointer_CampaignActivityItems) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the CampaignActivityItem entity is the first entity in the relationship. Listed by **SchemaName**.

- [campaignactivitylist_association](#BKMK_campaignactivitylist_association)
- [campaignactivitysalesliterature_association](#BKMK_campaignactivitysalesliterature_association)


### <a name="BKMK_campaignactivitylist_association"></a> campaignactivitylist_association

See campaignactivity Entity [campaignactivitylist_association](campaignactivity.md#BKMK_campaignactivitylist_association) Many-To-Many Relationship.

### <a name="BKMK_campaignactivitysalesliterature_association"></a> campaignactivitysalesliterature_association

See campaignactivity Entity [campaignactivitysalesliterature_association](campaignactivity.md#BKMK_campaignactivitysalesliterature_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.campaignactivityitem?text=campaignactivityitem EntityType" />