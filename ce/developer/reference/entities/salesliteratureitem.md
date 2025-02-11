---
title: "Sales Attachment (SalesLiteratureItem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sales Attachment (SalesLiteratureItem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sales Attachment (SalesLiteratureItem) table/entity reference (Microsoft Dynamics 365)

Item in the sales literature collection.

## Messages

The following table lists the messages for the Sales Attachment (SalesLiteratureItem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /salesliteratureitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /salesliteratureitems(*salesliteratureitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /salesliteratureitems(*salesliteratureitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /salesliteratureitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /salesliteratureitems(*salesliteratureitemid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /salesliteratureitems(*salesliteratureitemid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|

## Properties

The following table lists selected properties for the Sales Attachment (SalesLiteratureItem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sales Attachment** |
| **DisplayCollectionName** | **Sales Attachments** |
| **SchemaName** | `SalesLiteratureItem` |
| **CollectionSchemaName** | `SalesLiteratureItems` |
| **EntitySetName** | `salesliteratureitems`|
| **LogicalName** | `salesliteratureitem` |
| **LogicalCollectionName** | `salesliteratureitems` |
| **PrimaryIdAttribute** | `salesliteratureitemid` |
| **PrimaryNameAttribute** |`title` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Abstract](#BKMK_Abstract)
- [AttachedDocumentUrl](#BKMK_AttachedDocumentUrl)
- [AuthorName](#BKMK_AuthorName)
- [DocumentBody](#BKMK_DocumentBody)
- [FileName](#BKMK_FileName)
- [FileSize](#BKMK_FileSize)
- [FileTypeCode](#BKMK_FileTypeCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomerViewable](#BKMK_IsCustomerViewable)
- [KeyWords](#BKMK_KeyWords)
- [MimeType](#BKMK_MimeType)
- [Mode](#BKMK_Mode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [SalesLiteratureId](#BKMK_SalesLiteratureId)
- [SalesLiteratureItemId](#BKMK_SalesLiteratureItemId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [Title](#BKMK_Title)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_Abstract"></a> Abstract

|Property|Value|
|---|---|
|Description|**Abstract of the document.**|
|DisplayName|**Abstract**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`abstract`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_AttachedDocumentUrl"></a> AttachedDocumentUrl

|Property|Value|
|---|---|
|Description|**URL of the Website on which the document is located.**|
|DisplayName|**Attached Document URL**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`attacheddocumenturl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_AuthorName"></a> AuthorName

|Property|Value|
|---|---|
|Description|**Author name for the document.**|
|DisplayName|**Author Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`authorname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_DocumentBody"></a> DocumentBody

|Property|Value|
|---|---|
|Description|**Shows the encoded contents of the sales literature document attachment.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`documentbody`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_FileName"></a> FileName

|Property|Value|
|---|---|
|Description|**File name of the document.**|
|DisplayName|**File Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`filename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_FileSize"></a> FileSize

|Property|Value|
|---|---|
|Description|**File size of the document.**|
|DisplayName|**File Size (Bytes)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`filesize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_FileTypeCode"></a> FileTypeCode

|Property|Value|
|---|---|
|Description|**Select the file type of the document.**|
|DisplayName|**File Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`filetypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`salesliteratureitem_filetypecode`|

#### FileTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

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

### <a name="BKMK_IsCustomerViewable"></a> IsCustomerViewable

|Property|Value|
|---|---|
|Description|**Tells whether the document can be shared with customers or is for internal use only.**|
|DisplayName|**Customer Viewable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomerviewable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`salesliteratureitem_iscustomerviewable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_KeyWords"></a> KeyWords

|Property|Value|
|---|---|
|Description|**Keywords to use for searches in documents.**|
|DisplayName|**Key Words**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`keywords`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_MimeType"></a> MimeType

|Property|Value|
|---|---|
|Description|**Shows the file type of the sales literature document attachment, such as text or document.**|
|DisplayName|**Mime Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`mimetype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_Mode"></a> Mode

|Property|Value|
|---|---|
|Description|**Defines the mode of the sales literature document attachment.**|
|DisplayName|**Mode**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`mode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

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

### <a name="BKMK_SalesLiteratureId"></a> SalesLiteratureId

|Property|Value|
|---|---|
|Description|**Unique identifier of the sales literature that is associated with the individual item.**|
|DisplayName|**Sales Literature**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`salesliteratureid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|salesliterature|

### <a name="BKMK_SalesLiteratureItemId"></a> SalesLiteratureItemId

|Property|Value|
|---|---|
|Description|**Unique identifier for the document.**|
|DisplayName|**Sales Literature Item**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`salesliteratureitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_Title"></a> Title

|Property|Value|
|---|---|
|Description|**Type the title or name that describes the document.**|
|DisplayName|**Title**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`title`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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
- [FileType](#BKMK_FileType)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the document.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the document was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who created the salesliteratureitem.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_FileType"></a> FileType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`filetype`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the document.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the document was last modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who last modified the salesliteratureitem.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier of the organization associated with the document.**|
|DisplayName|**Organization**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
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

- [lk_salesliteratureitem_createdonbehalfby](#BKMK_lk_salesliteratureitem_createdonbehalfby)
- [lk_salesliteratureitem_modifiedonbehalfby](#BKMK_lk_salesliteratureitem_modifiedonbehalfby)
- [lk_salesliteratureitembase_createdby](#BKMK_lk_salesliteratureitembase_createdby)
- [lk_salesliteratureitembase_modifiedby](#BKMK_lk_salesliteratureitembase_modifiedby)
- [sales_literature_items](#BKMK_sales_literature_items)

### <a name="BKMK_lk_salesliteratureitem_createdonbehalfby"></a> lk_salesliteratureitem_createdonbehalfby

One-To-Many Relationship: [systemuser lk_salesliteratureitem_createdonbehalfby](systemuser.md#BKMK_lk_salesliteratureitem_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_salesliteratureitem_modifiedonbehalfby"></a> lk_salesliteratureitem_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_salesliteratureitem_modifiedonbehalfby](systemuser.md#BKMK_lk_salesliteratureitem_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_salesliteratureitembase_createdby"></a> lk_salesliteratureitembase_createdby

One-To-Many Relationship: [systemuser lk_salesliteratureitembase_createdby](systemuser.md#BKMK_lk_salesliteratureitembase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_salesliteratureitembase_modifiedby"></a> lk_salesliteratureitembase_modifiedby

One-To-Many Relationship: [systemuser lk_salesliteratureitembase_modifiedby](systemuser.md#BKMK_lk_salesliteratureitembase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sales_literature_items"></a> sales_literature_items

One-To-Many Relationship: [salesliterature sales_literature_items](salesliterature.md#BKMK_sales_literature_items)

|Property|Value|
|---|---|
|ReferencedEntity|`salesliterature`|
|ReferencedAttribute|`salesliteratureid`|
|ReferencingAttribute|`salesliteratureid`|
|ReferencingEntityNavigationPropertyName|`salesliteratureid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [SalesLiteratureItem_AsyncOperations](#BKMK_SalesLiteratureItem_AsyncOperations)
- [SalesLiteratureItem_BulkDeleteFailures](#BKMK_SalesLiteratureItem_BulkDeleteFailures)
- [salesliteratureitem_MailboxTrackingFolders](#BKMK_salesliteratureitem_MailboxTrackingFolders)
- [salesliteratureitem_PrincipalObjectAttributeAccesses](#BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses)
- [SalesLiteratureItem_ProcessSessions](#BKMK_SalesLiteratureItem_ProcessSessions)
- [salesliteratureitem_SyncErrors](#BKMK_salesliteratureitem_SyncErrors)

### <a name="BKMK_SalesLiteratureItem_AsyncOperations"></a> SalesLiteratureItem_AsyncOperations

Many-To-One Relationship: [asyncoperation SalesLiteratureItem_AsyncOperations](asyncoperation.md#BKMK_SalesLiteratureItem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesLiteratureItem_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesLiteratureItem_BulkDeleteFailures"></a> SalesLiteratureItem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure SalesLiteratureItem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_SalesLiteratureItem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesLiteratureItem_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesliteratureitem_MailboxTrackingFolders"></a> salesliteratureitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder salesliteratureitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_salesliteratureitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesliteratureitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses"></a> salesliteratureitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess salesliteratureitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`salesliteratureitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesLiteratureItem_ProcessSessions"></a> SalesLiteratureItem_ProcessSessions

Many-To-One Relationship: [processsession SalesLiteratureItem_ProcessSessions](processsession.md#BKMK_SalesLiteratureItem_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesLiteratureItem_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesliteratureitem_SyncErrors"></a> salesliteratureitem_SyncErrors

Many-To-One Relationship: [syncerror salesliteratureitem_SyncErrors](syncerror.md#BKMK_salesliteratureitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesliteratureitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

