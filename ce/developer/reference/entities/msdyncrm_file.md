---
title: "File (msdyncrm_file) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the File (msdyncrm_file) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# File (msdyncrm_file) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the File (msdyncrm_file) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_files(*msdyncrm_fileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyncrm_files<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_files(*msdyncrm_fileid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_files(*msdyncrm_fileid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_files<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_files(*msdyncrm_fileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_files(*msdyncrm_fileid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_files(*msdyncrm_fileid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the File (msdyncrm_file) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **File** |
| **DisplayCollectionName** | **Files** |
| **SchemaName** | `msdyncrm_file` |
| **CollectionSchemaName** | `msdyncrm_files` |
| **EntitySetName** | `msdyncrm_files`|
| **LogicalName** | `msdyncrm_file` |
| **LogicalCollectionName** | `msdyncrm_files` |
| **PrimaryIdAttribute** | `msdyncrm_fileid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyncrm_Alttext](#BKMK_msdyncrm_Alttext)
- [msdyncrm_BlobCdnUri](#BKMK_msdyncrm_BlobCdnUri)
- [msdyncrm_BlobSize](#BKMK_msdyncrm_BlobSize)
- [msdyncrm_BlobUri](#BKMK_msdyncrm_BlobUri)
- [msdyncrm_category](#BKMK_msdyncrm_category)
- [msdyncrm_cmsid](#BKMK_msdyncrm_cmsid)
- [msdyncrm_ContentType](#BKMK_msdyncrm_ContentType)
- [msdyncrm_copyUrl](#BKMK_msdyncrm_copyUrl)
- [msdyncrm_fileId](#BKMK_msdyncrm_fileId)
- [msdyncrm_height](#BKMK_msdyncrm_height)
- [msdyncrm_mainimage](#BKMK_msdyncrm_mainimage)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_rethumbnail](#BKMK_msdyncrm_rethumbnail)
- [msdyncrm_sastoken](#BKMK_msdyncrm_sastoken)
- [msdyncrm_sastokenexpirationdate](#BKMK_msdyncrm_sastokenexpirationdate)
- [msdyncrm_source](#BKMK_msdyncrm_source)
- [msdyncrm_thumbnail_url](#BKMK_msdyncrm_thumbnail_url)
- [msdyncrm_width](#BKMK_msdyncrm_width)
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
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyncrm_Alttext"></a> msdyncrm_Alttext

|Property|Value|
|---|---|
|Description|**Alt text**|
|DisplayName|**Alt text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_alttext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdyncrm_BlobCdnUri"></a> msdyncrm_BlobCdnUri

|Property|Value|
|---|---|
|Description||
|DisplayName|**BLOB CDN URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_blobcdnuri`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_BlobSize"></a> msdyncrm_BlobSize

|Property|Value|
|---|---|
|Description||
|DisplayName|**File size (bytes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_blobsize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_BlobUri"></a> msdyncrm_BlobUri

|Property|Value|
|---|---|
|Description||
|DisplayName|**BLOB URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_bloburi`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_category"></a> msdyncrm_category

|Property|Value|
|---|---|
|Description||
|DisplayName|**Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_category`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_filecategory`|

#### msdyncrm_category Choices/Options

|Value|Label|
|---|---|
|192350000|**Logo**|

### <a name="BKMK_msdyncrm_cmsid"></a> msdyncrm_cmsid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Cms Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_cmsid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_ContentType"></a> msdyncrm_ContentType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contenttype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_copyUrl"></a> msdyncrm_copyUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copy Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_copyurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_fileId"></a> msdyncrm_fileId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**File identifier**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fileid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_height"></a> msdyncrm_height

|Property|Value|
|---|---|
|Description||
|DisplayName|**Height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_height`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_mainimage"></a> msdyncrm_mainimage

|Property|Value|
|---|---|
|Description||
|DisplayName|**mainimage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_mainimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|True|
|IsPrimaryImage|True|
|MaxHeight|288|
|MaxSizeInKB|10240|
|MaxWidth|288|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
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
|MaxLength|500|

### <a name="BKMK_msdyncrm_rethumbnail"></a> msdyncrm_rethumbnail

|Property|Value|
|---|---|
|Description||
|DisplayName|**Refresh thumbnail**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_rethumbnail`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_file_msdyncrm_rethumbnail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_sastoken"></a> msdyncrm_sastoken

|Property|Value|
|---|---|
|Description|**BLOB SAS token, which permits assets to be uploaded to the BLOB URL**|
|DisplayName|**SAS token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sastoken`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_sastokenexpirationdate"></a> msdyncrm_sastokenexpirationdate

|Property|Value|
|---|---|
|Description|**SAS token expiration date**|
|DisplayName|**SAS token expiration date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sastokenexpirationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Disabled|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_source"></a> msdyncrm_source

|Property|Value|
|---|---|
|Description||
|DisplayName|**File source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_source`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyncrm_file_msdyncrm_source`|

#### msdyncrm_source Choices/Options

|Value|Label|
|---|---|
|0|**User**|
|1|**Typeface**|

### <a name="BKMK_msdyncrm_thumbnail_url"></a> msdyncrm_thumbnail_url

|Property|Value|
|---|---|
|Description||
|DisplayName|**Thumbnail URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_thumbnail_url`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_width"></a> msdyncrm_width

|Property|Value|
|---|---|
|Description||
|DisplayName|**Width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_width`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Owner ID**|
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
|Description|**Status of the file**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_file_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the file**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_file_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyncrm_filecontent](#BKMK_msdyncrm_filecontent)
- [msdyncrm_filecontent_Name](#BKMK_msdyncrm_filecontent_Name)
- [msdyncrm_mainimage_Timestamp](#BKMK_msdyncrm_mainimage_Timestamp)
- [msdyncrm_mainimage_URL](#BKMK_msdyncrm_mainimage_URL)
- [msdyncrm_mainimageId](#BKMK_msdyncrm_mainimageId)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique ID of the user who created the record**|
|DisplayName|**Created by**|
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
|DisplayName|**Created on**|
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
|Description|**Unique ID of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique ID of the user who modified the record**|
|DisplayName|**Modified by**|
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
|DisplayName|**Modified on**|
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
|Description|**Unique ID of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_filecontent"></a> msdyncrm_filecontent

|Property|Value|
|---|---|
|Description||
|DisplayName|**filecontent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_filecontent`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|2097152|

### <a name="BKMK_msdyncrm_filecontent_Name"></a> msdyncrm_filecontent_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_filecontent_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_mainimage_Timestamp"></a> msdyncrm_mainimage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_mainimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyncrm_mainimage_URL"></a> msdyncrm_mainimage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_mainimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_mainimageId"></a> msdyncrm_mainimageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_mainimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|Description|**Unique ID of the business unit that owns the record**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique ID of the team that owns the record**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique ID of the team that owns the record**|
|DisplayName|**Owning user**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
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

- [business_unit_msdyncrm_file](#BKMK_business_unit_msdyncrm_file)
- [FileAttachment_msdyncrm_file_msdyncrm_filecontent](#BKMK_FileAttachment_msdyncrm_file_msdyncrm_filecontent)
- [lk_msdyncrm_file_createdby](#BKMK_lk_msdyncrm_file_createdby)
- [lk_msdyncrm_file_createdonbehalfby](#BKMK_lk_msdyncrm_file_createdonbehalfby)
- [lk_msdyncrm_file_modifiedby](#BKMK_lk_msdyncrm_file_modifiedby)
- [lk_msdyncrm_file_modifiedonbehalfby](#BKMK_lk_msdyncrm_file_modifiedonbehalfby)
- [owner_msdyncrm_file](#BKMK_owner_msdyncrm_file)
- [team_msdyncrm_file](#BKMK_team_msdyncrm_file)
- [user_msdyncrm_file](#BKMK_user_msdyncrm_file)

### <a name="BKMK_business_unit_msdyncrm_file"></a> business_unit_msdyncrm_file

One-To-Many Relationship: [businessunit business_unit_msdyncrm_file](businessunit.md#BKMK_business_unit_msdyncrm_file)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyncrm_file_msdyncrm_filecontent"></a> FileAttachment_msdyncrm_file_msdyncrm_filecontent

One-To-Many Relationship: [fileattachment FileAttachment_msdyncrm_file_msdyncrm_filecontent](fileattachment.md#BKMK_FileAttachment_msdyncrm_file_msdyncrm_filecontent)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyncrm_filecontent`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_filecontent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_file_createdby"></a> lk_msdyncrm_file_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_file_createdby](systemuser.md#BKMK_lk_msdyncrm_file_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_file_createdonbehalfby"></a> lk_msdyncrm_file_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_file_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_file_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_file_modifiedby"></a> lk_msdyncrm_file_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_file_modifiedby](systemuser.md#BKMK_lk_msdyncrm_file_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_file_modifiedonbehalfby"></a> lk_msdyncrm_file_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_file_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_file_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_file"></a> owner_msdyncrm_file

One-To-Many Relationship: [owner owner_msdyncrm_file](owner.md#BKMK_owner_msdyncrm_file)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_file"></a> team_msdyncrm_file

One-To-Many Relationship: [team team_msdyncrm_file](team.md#BKMK_team_msdyncrm_file)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_file"></a> user_msdyncrm_file

One-To-Many Relationship: [systemuser user_msdyncrm_file](systemuser.md#BKMK_user_msdyncrm_file)

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

- [msdyncrm_file_AsyncOperations](#BKMK_msdyncrm_file_AsyncOperations)
- [msdyncrm_file_BulkDeleteFailures](#BKMK_msdyncrm_file_BulkDeleteFailures)
- [msdyncrm_file_DuplicateBaseRecord](#BKMK_msdyncrm_file_DuplicateBaseRecord)
- [msdyncrm_file_DuplicateMatchingRecord](#BKMK_msdyncrm_file_DuplicateMatchingRecord)
- [msdyncrm_file_FileAttachments](#BKMK_msdyncrm_file_FileAttachments)
- [msdyncrm_file_MailboxTrackingFolders](#BKMK_msdyncrm_file_MailboxTrackingFolders)
- [msdyncrm_file_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_file_PrincipalObjectAttributeAccesses)
- [msdyncrm_file_ProcessSession](#BKMK_msdyncrm_file_ProcessSession)
- [msdyncrm_file_SyncErrors](#BKMK_msdyncrm_file_SyncErrors)

### <a name="BKMK_msdyncrm_file_AsyncOperations"></a> msdyncrm_file_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_file_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_file_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_file_BulkDeleteFailures"></a> msdyncrm_file_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_file_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_file_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_file_DuplicateBaseRecord"></a> msdyncrm_file_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_file_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_file_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_file_DuplicateMatchingRecord"></a> msdyncrm_file_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_file_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_file_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_file_FileAttachments"></a> msdyncrm_file_FileAttachments

Many-To-One Relationship: [fileattachment msdyncrm_file_FileAttachments](fileattachment.md#BKMK_msdyncrm_file_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_file_MailboxTrackingFolders"></a> msdyncrm_file_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_file_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_file_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_file_PrincipalObjectAttributeAccesses"></a> msdyncrm_file_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_file_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_file_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_file_ProcessSession"></a> msdyncrm_file_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_file_ProcessSession](processsession.md#BKMK_msdyncrm_file_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_file_SyncErrors"></a> msdyncrm_file_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_file_SyncErrors](syncerror.md#BKMK_msdyncrm_file_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_file_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [AITags_msdyncrm_keyword_msdyncrm_file](#BKMK_AITags_msdyncrm_keyword_msdyncrm_file)
- [msdyncrm_msdyncrm_keyword_msdyncrm_file](#BKMK_msdyncrm_msdyncrm_keyword_msdyncrm_file)

### <a name="BKMK_AITags_msdyncrm_keyword_msdyncrm_file"></a> AITags_msdyncrm_keyword_msdyncrm_file

See [msdyncrm_keyword AITags_msdyncrm_keyword_msdyncrm_file Many-To-Many Relationship](msdyncrm_keyword.md#BKMK_AITags_msdyncrm_keyword_msdyncrm_file)

|Property|Value|
|---|---|
|IntersectEntityName|`aitags_msdyncrm_keyword_msdyncrm_file`|
|IsCustomizable|True|
|SchemaName|`AITags_msdyncrm_keyword_msdyncrm_file`|
|IntersectAttribute|`msdyncrm_fileid`|
|NavigationPropertyName|`AITags_msdyncrm_keyword_msdyncrm_file`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_keyword_msdyncrm_file"></a> msdyncrm_msdyncrm_keyword_msdyncrm_file

See [msdyncrm_keyword msdyncrm_msdyncrm_keyword_msdyncrm_file Many-To-Many Relationship](msdyncrm_keyword.md#BKMK_msdyncrm_msdyncrm_keyword_msdyncrm_file)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_msdyncrm_keyword_msdyncrm_file`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_msdyncrm_keyword_msdyncrm_file`|
|IntersectAttribute|`msdyncrm_fileid`|
|NavigationPropertyName|`msdyncrm_msdyncrm_keyword_msdyncrm_file`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

