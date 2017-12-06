---
title: "CampaignItem Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CampaignItem entity."
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
# CampaignItem Entity Reference

Work item in a campaign, a list or sales literature.

**Added by**: Marketing Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/campaignitems<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/campaignitems(*campaignitemid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/campaignitems(*campaignitemid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/campaignitems<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName||
|DisplayCollectionName|Campaign Items|
|DisplayName|Campaign Item|
|EntitySetName|campaignitems|
|IsBPFEntity|False|
|LogicalCollectionName||
|LogicalName|campaignitem|
|OwnershipType|None|
|PrimaryIdAttribute|campaignitemid|
|PrimaryNameAttribute|name|
|SchemaName|CampaignItem|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|--------|-----|
|Description|Unique identifier of the campaign that is associated with the individual item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignid|
|RequiredLevel|SystemRequired|
|Targets|campaign|
|Type|Lookup|


### <a name="BKMK_CampaignItemId"></a> CampaignItemId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the campaign item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|campaignitemid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_EntityId"></a> EntityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the entity for the campaign item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_EntityType"></a> EntityType

|Property|Value|
|--------|-----|
|Description|Object type of entity for the campaign item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entitytype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


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

- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the campaign item.|
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
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the campaign item.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user that owns the campaign item.|
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

- [campaignitem_AsyncOperations](#BKMK_campaignitem_AsyncOperations)
- [campaignitem_MailboxTrackingFolders](#BKMK_campaignitem_MailboxTrackingFolders)
- [campaignitem_UserEntityInstanceDatas](#BKMK_campaignitem_UserEntityInstanceDatas)
- [campaignitem_BulkDeleteFailures](#BKMK_campaignitem_BulkDeleteFailures)
- [campaignitem_PrincipalObjectAttributeAccesses](#BKMK_campaignitem_PrincipalObjectAttributeAccesses)
- [userentityinstancedata_campaignitem](#BKMK_userentityinstancedata_campaignitem)


### <a name="BKMK_campaignitem_AsyncOperations"></a> campaignitem_AsyncOperations

Same as asyncoperation entity [campaignitem_AsyncOperations](asyncoperation.md#BKMK_campaignitem_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignitem_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignitem_MailboxTrackingFolders"></a> campaignitem_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [campaignitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_campaignitem_MailboxTrackingFolders) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignitem_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_campaignitem_UserEntityInstanceDatas"></a> campaignitem_UserEntityInstanceDatas

Same as userentityinstancedata entity [campaignitem_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_campaignitem_UserEntityInstanceDatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignitem_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignitem_BulkDeleteFailures"></a> campaignitem_BulkDeleteFailures

Same as bulkdeletefailure entity [campaignitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_campaignitem_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignitem_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignitem_PrincipalObjectAttributeAccesses"></a> campaignitem_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [campaignitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_campaignitem_PrincipalObjectAttributeAccesses) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignitem_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_userentityinstancedata_campaignitem"></a> userentityinstancedata_campaignitem

Same as userentityinstancedata entity [userentityinstancedata_campaignitem](userentityinstancedata.md#BKMK_userentityinstancedata_campaignitem) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_campaignitem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the CampaignItem entity is the first entity in the relationship. Listed by **SchemaName**.

- [campaigncampaign_association](#BKMK_campaigncampaign_association)
- [campaignproduct_association](#BKMK_campaignproduct_association)
- [campaignlist_association](#BKMK_campaignlist_association)
- [campaignsalesliterature_association](#BKMK_campaignsalesliterature_association)


### <a name="BKMK_campaigncampaign_association"></a> campaigncampaign_association

See campaign Entity [campaigncampaign_association](campaign.md#BKMK_campaigncampaign_association) Many-To-Many Relationship.

### <a name="BKMK_campaignproduct_association"></a> campaignproduct_association

See campaign Entity [campaignproduct_association](campaign.md#BKMK_campaignproduct_association) Many-To-Many Relationship.

### <a name="BKMK_campaignlist_association"></a> campaignlist_association

See campaign Entity [campaignlist_association](campaign.md#BKMK_campaignlist_association) Many-To-Many Relationship.

### <a name="BKMK_campaignsalesliterature_association"></a> campaignsalesliterature_association

See campaign Entity [campaignsalesliterature_association](campaign.md#BKMK_campaignsalesliterature_association) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.campaignitem?text=campaignitem EntityType" />