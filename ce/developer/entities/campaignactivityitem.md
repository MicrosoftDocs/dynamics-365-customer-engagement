---
title: "CampaignActivityItem Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CampaignActivityItem entity."
ms.date: 12/05/2017
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

Work item of a campaign activity, such as a list or sales literature.

**Added by**: Marketing Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/campaignactivityitems<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/campaignactivityitems(*campaignactivityitemid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/campaignactivityitems(*campaignactivityitemid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/campaignactivityitems<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName||
|DisplayCollectionName|Campaign Activity Items|
|DisplayName|Campaign Activity Item|
|EntitySetName|campaignactivityitems|
|IsBPFEntity|False|
|LogicalCollectionName||
|LogicalName|campaignactivityitem|
|OwnershipType|None|
|PrimaryIdAttribute|campaignactivityitemid|
|PrimaryNameAttribute|name|
|SchemaName|CampaignActivityItem|

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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the campaign activity for the item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignactivityid|
|RequiredLevel|SystemRequired|
|Targets|campaignactivity|
|Type|Lookup|


### <a name="BKMK_CampaignActivityIdType"></a> CampaignActivityIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignactivityidtype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_CampaignActivityItemId"></a> CampaignActivityItemId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the campaign activity item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|campaignactivityitemid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ItemId"></a> ItemId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|itemid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ItemObjectTypeCode"></a> ItemObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Identification of the type of the campaign activity item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|itemobjecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|name|
|DisplayName|name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignactivityidname|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CampaignActivityIdYomiName"></a> CampaignActivityIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignactivityidyominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the campaign activity item.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the invoice detail.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the campaign activity item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user that owns the campaign activity item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

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
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignactivityitem_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignactivityitem_MailboxTrackingFolders"></a> campaignactivityitem_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [campaignactivityitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_campaignactivityitem_MailboxTrackingFolders) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignactivityitem_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaignactivityitem_UserEntityInstanceDatas"></a> campaignactivityitem_UserEntityInstanceDatas

Same as userentityinstancedata entity [campaignactivityitem_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_campaignactivityitem_UserEntityInstanceDatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignactivityitem_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignactivityitem_BulkDeleteFailures"></a> campaignactivityitem_BulkDeleteFailures

Same as bulkdeletefailure entity [campaignactivityitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_campaignactivityitem_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignactivityitem_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses"></a> campaignactivityitem_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [campaignactivityitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignactivityitem_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_userentityinstancedata_campaignactivityitem"></a> userentityinstancedata_campaignactivityitem

Same as userentityinstancedata entity [userentityinstancedata_campaignactivityitem](userentityinstancedata.md#BKMK_userentityinstancedata_campaignactivityitem) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_campaignactivityitem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.campaignactivityitem?text=campaignactivityitem EntityType" />