---
title: "Web File (Adx_webfile) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Web File (Adx_webfile) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Web File (Adx_webfile) table/entity reference

Storage of files used in the web Portals.

## Messages

The following table lists the messages for the Web File (Adx_webfile) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_webfiles(*adx_webfileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_webfiles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_webfiles(*adx_webfileid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_webfiles(*adx_webfileid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_webfiles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_webfiles(*adx_webfileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_webfiles(*adx_webfileid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_webfiles(*adx_webfileid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Web File (Adx_webfile) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Web File (Adx_webfile) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Web File** |
| **DisplayCollectionName** | **Web Files** |
| **SchemaName** | `Adx_webfile` |
| **CollectionSchemaName** | `Adx_webfiles` |
| **EntitySetName** | `adx_webfiles`|
| **LogicalName** | `adx_webfile` |
| **LogicalCollectionName** | `adx_webfiles` |
| **PrimaryIdAttribute** | `adx_webfileid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_AllowOrigin](#BKMK_adx_AllowOrigin)
- [adx_CloudBlobAddress](#BKMK_adx_CloudBlobAddress)
- [adx_contentdisposition](#BKMK_adx_contentdisposition)
- [Adx_createdbyipaddress](#BKMK_Adx_createdbyipaddress)
- [Adx_createdbyusername](#BKMK_Adx_createdbyusername)
- [Adx_DisplayDate](#BKMK_Adx_DisplayDate)
- [Adx_DisplayOrder](#BKMK_Adx_DisplayOrder)
- [Adx_enabletracking](#BKMK_Adx_enabletracking)
- [adx_excludefromsearch](#BKMK_adx_excludefromsearch)
- [Adx_ExpirationDate](#BKMK_Adx_ExpirationDate)
- [Adx_HiddenFromSitemap](#BKMK_Adx_HiddenFromSitemap)
- [adx_masterwebfileid](#BKMK_adx_masterwebfileid)
- [adx_migratedtofilecontent](#BKMK_adx_migratedtofilecontent)
- [Adx_ModifiedByIPAddress](#BKMK_Adx_ModifiedByIPAddress)
- [Adx_ModifiedByUsername](#BKMK_Adx_ModifiedByUsername)
- [Adx_name](#BKMK_Adx_name)
- [adx_parentpageid](#BKMK_adx_parentpageid)
- [Adx_PartialUrl](#BKMK_Adx_PartialUrl)
- [adx_publishingstateid](#BKMK_adx_publishingstateid)
- [Adx_ReleaseDate](#BKMK_Adx_ReleaseDate)
- [adx_subjectid](#BKMK_adx_subjectid)
- [Adx_Summary](#BKMK_Adx_Summary)
- [adx_title](#BKMK_adx_title)
- [Adx_webfileId](#BKMK_Adx_webfileId)
- [adx_websiteid](#BKMK_adx_websiteid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_AllowOrigin"></a> adx_AllowOrigin

|Property|Value|
|---|---|
|Description|**Defines CORS header Access-Control-Allow-Origin for cross origin requests.**|
|DisplayName|**Allow Origin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_alloworigin`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_adx_CloudBlobAddress"></a> adx_CloudBlobAddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Cloud Blob Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_cloudblobaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_contentdisposition"></a> adx_contentdisposition

|Property|Value|
|---|---|
|Description|**Shows the value to be applied to the HTTP Response Headers Content-Disposition.**|
|DisplayName|**Content-Disposition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_contentdisposition`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_webfile_adx_contentdisposition`|

#### adx_contentdisposition Choices/Options

|Value|Label|
|---|---|
|756150000|**inline**|
|756150001|**attachment**|

### <a name="BKMK_Adx_createdbyipaddress"></a> Adx_createdbyipaddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Created By IP Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_createdbyipaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_createdbyusername"></a> Adx_createdbyusername

|Property|Value|
|---|---|
|Description||
|DisplayName|**Created By Username**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_createdbyusername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_DisplayDate"></a> Adx_DisplayDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_displaydate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_Adx_enabletracking"></a> Adx_enabletracking

|Property|Value|
|---|---|
|Description|**Select whether to enable logging of users' downloads of this web file.**|
|DisplayName|**Enable Tracking (deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_enabletracking`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webfile_adx_enabletracking`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_excludefromsearch"></a> adx_excludefromsearch

|Property|Value|
|---|---|
|Description|**Shows whether the web file is excluded from the portal search.**|
|DisplayName|**Exclude From Search**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_excludefromsearch`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webfile_adx_excludefromsearch`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_ExpirationDate"></a> Adx_ExpirationDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Expiration Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_expirationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_Adx_HiddenFromSitemap"></a> Adx_HiddenFromSitemap

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hidden From Sitemap**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_hiddenfromsitemap`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`adx_webfile_adx_hiddenfromsitemap`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_masterwebfileid"></a> adx_masterwebfileid

|Property|Value|
|---|---|
|Description|**Unique identifier for Web File associated with Web File.**|
|DisplayName|**Master Web File**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_masterwebfileid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webfile|

### <a name="BKMK_adx_migratedtofilecontent"></a> adx_migratedtofilecontent

|Property|Value|
|---|---|
|Description|**This field tracks the migration status of webFiles notes attachment to fileContent attribute.**|
|DisplayName|**Migrated To File Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_migratedtofilecontent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webfile_adx_filecontentmigrationstatus`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_ModifiedByIPAddress"></a> Adx_ModifiedByIPAddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Modified By IP Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_modifiedbyipaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_ModifiedByUsername"></a> Adx_ModifiedByUsername

|Property|Value|
|---|---|
|Description||
|DisplayName|**Modified By Username**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_modifiedbyusername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Unique identifier for Web Page associated with Web File.**|
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
|DisplayName|**Partial URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_partialurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_adx_publishingstateid"></a> adx_publishingstateid

|Property|Value|
|---|---|
|Description|**Unique identifier for Publishing State associated with Web File.**|
|DisplayName|**Publishing State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_publishingstateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_publishingstate|

### <a name="BKMK_Adx_ReleaseDate"></a> Adx_ReleaseDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Release Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_releasedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_adx_subjectid"></a> adx_subjectid

|Property|Value|
|---|---|
|Description|**Unique identifier for Subject associated with Web File.**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_subjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|subject|

### <a name="BKMK_Adx_Summary"></a> Adx_Summary

|Property|Value|
|---|---|
|Description||
|DisplayName|**Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_summary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4096|

### <a name="BKMK_adx_title"></a> adx_title

|Property|Value|
|---|---|
|Description||
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_title`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|512|

### <a name="BKMK_Adx_webfileId"></a> Adx_webfileId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Web File**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_webfileid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Website associated with Web File.**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
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
|Description|**Shows when the record was migrated.**|
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
|Description|**Shows the owner ID.**|
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
|Description|**Status of the Web File**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_webfile_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Web File**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_webfile_statuscode`|

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

- [adx_filecontent](#BKMK_adx_filecontent)
- [adx_filecontent_Name](#BKMK_adx_filecontent_Name)
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

### <a name="BKMK_adx_filecontent"></a> adx_filecontent

|Property|Value|
|---|---|
|Description|**File Content column contains portal web files e.g. png, css etc.**|
|DisplayName|**File Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_filecontent`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|131072|

### <a name="BKMK_adx_filecontent_Name"></a> adx_filecontent_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_filecontent_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Shows the user who created the record.**|
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
|Description|**Shows when the record was created.**|
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
|Description|**Shows the user who updated the record.**|
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
|Description|**Shows when the record was updated.**|
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
|Description|**Unique identifier for the business unit that owns the record**|
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

- [adx_publishingstate_webfile](#BKMK_adx_publishingstate_webfile)
- [adx_subject_webfile](#BKMK_adx_subject_webfile)
- [adx_webfile_masterwebfile](#BKMK_adx_webfile_masterwebfile-many-to-one)
- [adx_webpage_webfile](#BKMK_adx_webpage_webfile)
- [adx_website_webfile](#BKMK_adx_website_webfile)
- [business_unit_adx_webfile](#BKMK_business_unit_adx_webfile)
- [FileAttachment_Adx_webfile_adx_filecontent](#BKMK_FileAttachment_Adx_webfile_adx_filecontent)
- [lk_adx_webfile_createdby](#BKMK_lk_adx_webfile_createdby)
- [lk_adx_webfile_createdonbehalfby](#BKMK_lk_adx_webfile_createdonbehalfby)
- [lk_adx_webfile_modifiedby](#BKMK_lk_adx_webfile_modifiedby)
- [lk_adx_webfile_modifiedonbehalfby](#BKMK_lk_adx_webfile_modifiedonbehalfby)
- [owner_adx_webfile](#BKMK_owner_adx_webfile)
- [team_adx_webfile](#BKMK_team_adx_webfile)
- [user_adx_webfile](#BKMK_user_adx_webfile)

### <a name="BKMK_adx_publishingstate_webfile"></a> adx_publishingstate_webfile

One-To-Many Relationship: [adx_publishingstate adx_publishingstate_webfile](adx_publishingstate.md#BKMK_adx_publishingstate_webfile)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstate`|
|ReferencedAttribute|`adx_publishingstateid`|
|ReferencingAttribute|`adx_publishingstateid`|
|ReferencingEntityNavigationPropertyName|`adx_publishingstateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_subject_webfile"></a> adx_subject_webfile

One-To-Many Relationship: [subject adx_subject_webfile](subject.md#BKMK_adx_subject_webfile)

|Property|Value|
|---|---|
|ReferencedEntity|`subject`|
|ReferencedAttribute|`subjectid`|
|ReferencingAttribute|`adx_subjectid`|
|ReferencingEntityNavigationPropertyName|`adx_subjectid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webfile_masterwebfile-many-to-one"></a> adx_webfile_masterwebfile

One-To-Many Relationship: [adx_webfile adx_webfile_masterwebfile](#BKMK_adx_webfile_masterwebfile-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webfile`|
|ReferencedAttribute|`adx_webfileid`|
|ReferencingAttribute|`adx_masterwebfileid`|
|ReferencingEntityNavigationPropertyName|`adx_masterwebfileid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_webfile"></a> adx_webpage_webfile

One-To-Many Relationship: [adx_webpage adx_webpage_webfile](adx_webpage.md#BKMK_adx_webpage_webfile)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_parentpageid`|
|ReferencingEntityNavigationPropertyName|`adx_parentpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_webfile"></a> adx_website_webfile

One-To-Many Relationship: [adx_website adx_website_webfile](adx_website.md#BKMK_adx_website_webfile)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencingEntityNavigationPropertyName|`adx_websiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_business_unit_adx_webfile"></a> business_unit_adx_webfile

One-To-Many Relationship: [businessunit business_unit_adx_webfile](businessunit.md#BKMK_business_unit_adx_webfile)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_Adx_webfile_adx_filecontent"></a> FileAttachment_Adx_webfile_adx_filecontent

One-To-Many Relationship: [fileattachment FileAttachment_Adx_webfile_adx_filecontent](fileattachment.md#BKMK_FileAttachment_Adx_webfile_adx_filecontent)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`adx_filecontent`|
|ReferencingEntityNavigationPropertyName|`adx_filecontent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webfile_createdby"></a> lk_adx_webfile_createdby

One-To-Many Relationship: [systemuser lk_adx_webfile_createdby](systemuser.md#BKMK_lk_adx_webfile_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webfile_createdonbehalfby"></a> lk_adx_webfile_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webfile_createdonbehalfby](systemuser.md#BKMK_lk_adx_webfile_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webfile_modifiedby"></a> lk_adx_webfile_modifiedby

One-To-Many Relationship: [systemuser lk_adx_webfile_modifiedby](systemuser.md#BKMK_lk_adx_webfile_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webfile_modifiedonbehalfby"></a> lk_adx_webfile_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webfile_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_webfile_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_webfile"></a> owner_adx_webfile

One-To-Many Relationship: [owner owner_adx_webfile](owner.md#BKMK_owner_adx_webfile)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_webfile"></a> team_adx_webfile

One-To-Many Relationship: [team team_adx_webfile](team.md#BKMK_team_adx_webfile)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_webfile"></a> user_adx_webfile

One-To-Many Relationship: [systemuser user_adx_webfile](systemuser.md#BKMK_user_adx_webfile)

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

- [adx_redirectwebfile_ad](#BKMK_adx_redirectwebfile_ad)
- [adx_webfile_ad](#BKMK_adx_webfile_ad)
- [adx_webfile_Annotations](#BKMK_adx_webfile_Annotations)
- [adx_webfile_AsyncOperations](#BKMK_adx_webfile_AsyncOperations)
- [adx_webfile_BulkDeleteFailures](#BKMK_adx_webfile_BulkDeleteFailures)
- [adx_webfile_FileAttachments](#BKMK_adx_webfile_FileAttachments)
- [adx_webfile_MailboxTrackingFolders](#BKMK_adx_webfile_MailboxTrackingFolders)
- [adx_webfile_masterwebfile](#BKMK_adx_webfile_masterwebfile-one-to-many)
- [adx_webfile_PrincipalObjectAttributeAccesses](#BKMK_adx_webfile_PrincipalObjectAttributeAccesses)
- [adx_webfile_ProcessSession](#BKMK_adx_webfile_ProcessSession)
- [adx_webfile_shortcut](#BKMK_adx_webfile_shortcut)
- [adx_webfile_SyncErrors](#BKMK_adx_webfile_SyncErrors)
- [adx_webfile_urlhistory](#BKMK_adx_webfile_urlhistory)
- [adx_webfile_webfilelog](#BKMK_adx_webfile_webfilelog)
- [adx_webfile_webpage_image](#BKMK_adx_webfile_webpage_image)

### <a name="BKMK_adx_redirectwebfile_ad"></a> adx_redirectwebfile_ad

Many-To-One Relationship: [adx_ad adx_redirectwebfile_ad](adx_ad.md#BKMK_adx_redirectwebfile_ad)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_ad`|
|ReferencingAttribute|`adx_redirectwebfileid`|
|ReferencedEntityNavigationPropertyName|`adx_redirectwebfile_ad`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_ad"></a> adx_webfile_ad

Many-To-One Relationship: [adx_ad adx_webfile_ad](adx_ad.md#BKMK_adx_webfile_ad)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_ad`|
|ReferencingAttribute|`adx_webfileid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_ad`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_Annotations"></a> adx_webfile_Annotations

Many-To-One Relationship: [annotation adx_webfile_Annotations](annotation.md#BKMK_adx_webfile_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_AsyncOperations"></a> adx_webfile_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_webfile_AsyncOperations](asyncoperation.md#BKMK_adx_webfile_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_BulkDeleteFailures"></a> adx_webfile_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_webfile_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_webfile_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_FileAttachments"></a> adx_webfile_FileAttachments

Many-To-One Relationship: [fileattachment adx_webfile_FileAttachments](fileattachment.md#BKMK_adx_webfile_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_MailboxTrackingFolders"></a> adx_webfile_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_webfile_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_webfile_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_masterwebfile-one-to-many"></a> adx_webfile_masterwebfile

Many-To-One Relationship: [adx_webfile adx_webfile_masterwebfile](#BKMK_adx_webfile_masterwebfile-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfile`|
|ReferencingAttribute|`adx_masterwebfileid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_masterwebfile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Subscriber Web Files<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_PrincipalObjectAttributeAccesses"></a> adx_webfile_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_webfile_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_webfile_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_ProcessSession"></a> adx_webfile_ProcessSession

Many-To-One Relationship: [processsession adx_webfile_ProcessSession](processsession.md#BKMK_adx_webfile_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_shortcut"></a> adx_webfile_shortcut

Many-To-One Relationship: [adx_shortcut adx_webfile_shortcut](adx_shortcut.md#BKMK_adx_webfile_shortcut)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_shortcut`|
|ReferencingAttribute|`adx_webfileid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_shortcut`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_SyncErrors"></a> adx_webfile_SyncErrors

Many-To-One Relationship: [syncerror adx_webfile_SyncErrors](syncerror.md#BKMK_adx_webfile_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_urlhistory"></a> adx_webfile_urlhistory

Many-To-One Relationship: [adx_urlhistory adx_webfile_urlhistory](adx_urlhistory.md#BKMK_adx_webfile_urlhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_urlhistory`|
|ReferencingAttribute|`adx_webfileid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_urlhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_webfilelog"></a> adx_webfile_webfilelog

Many-To-One Relationship: [adx_webfilelog adx_webfile_webfilelog](adx_webfilelog.md#BKMK_adx_webfile_webfilelog)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfilelog`|
|ReferencingAttribute|`adx_webfileid`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_webfilelog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webfile_webpage_image"></a> adx_webfile_webpage_image

Many-To-One Relationship: [adx_webpage adx_webfile_webpage_image](adx_webpage.md#BKMK_adx_webfile_webpage_image)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_image`|
|ReferencedEntityNavigationPropertyName|`adx_webfile_webpage_image`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

