---
title: "Web Link (Adx_weblink) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Web Link (Adx_weblink) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Web Link (Adx_weblink) table/entity reference

A textual or imaged based link to an interal or external URL.

## Messages

The following table lists the messages for the Web Link (Adx_weblink) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_weblinks(*adx_weblinkid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_weblinks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_weblinks(*adx_weblinkid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_weblinks(*adx_weblinkid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_weblinks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_weblinks(*adx_weblinkid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_weblinks(*adx_weblinkid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_weblinks(*adx_weblinkid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Web Link (Adx_weblink) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Web Link (Adx_weblink) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Web Link** |
| **DisplayCollectionName** | **Web Links** |
| **SchemaName** | `Adx_weblink` |
| **CollectionSchemaName** | `Adx_weblinks` |
| **EntitySetName** | `adx_weblinks`|
| **LogicalName** | `adx_weblink` |
| **LogicalCollectionName** | `adx_weblinks` |
| **PrimaryIdAttribute** | `adx_weblinkid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Adx_createdbyipaddress](#BKMK_Adx_createdbyipaddress)
- [Adx_createdbyusername](#BKMK_Adx_createdbyusername)
- [Adx_Description](#BKMK_Adx_Description)
- [Adx_DisablePageValidation](#BKMK_Adx_DisablePageValidation)
- [adx_displayimageonly](#BKMK_adx_displayimageonly)
- [Adx_DisplayOrder](#BKMK_Adx_DisplayOrder)
- [adx_displaypagechildlinks](#BKMK_adx_displaypagechildlinks)
- [Adx_ExternalUrl](#BKMK_Adx_ExternalUrl)
- [Adx_ImageAltText](#BKMK_Adx_ImageAltText)
- [Adx_ImageHeight](#BKMK_Adx_ImageHeight)
- [Adx_ImageUrl](#BKMK_Adx_ImageUrl)
- [Adx_ImageWidth](#BKMK_Adx_ImageWidth)
- [Adx_ModifiedByIPAddress](#BKMK_Adx_ModifiedByIPAddress)
- [Adx_ModifiedByUsername](#BKMK_Adx_ModifiedByUsername)
- [Adx_name](#BKMK_Adx_name)
- [Adx_OpenInNewWindow](#BKMK_Adx_OpenInNewWindow)
- [adx_pageid](#BKMK_adx_pageid)
- [adx_parentweblinkid](#BKMK_adx_parentweblinkid)
- [adx_publishingstateid](#BKMK_adx_publishingstateid)
- [Adx_RobotsFollowLink](#BKMK_Adx_RobotsFollowLink)
- [Adx_weblinkId](#BKMK_Adx_weblinkId)
- [adx_weblinksetid](#BKMK_adx_weblinksetid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

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
|MaxLength|2000|

### <a name="BKMK_Adx_DisablePageValidation"></a> Adx_DisablePageValidation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Disable Page Validation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_disablepagevalidation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_weblink_adx_disablepagevalidation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_displayimageonly"></a> adx_displayimageonly

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Image Only**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_displayimageonly`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_weblink_adx_displayimageonly`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_DisplayOrder"></a> Adx_DisplayOrder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_displayorder`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_adx_displaypagechildlinks"></a> adx_displaypagechildlinks

|Property|Value|
|---|---|
|Description|**Select whether to display the children of the page as child links for this link.**|
|DisplayName|**Display Page Child Links**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_displaypagechildlinks`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_weblink_adx_displaypagechildlinks`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_ExternalUrl"></a> Adx_ExternalUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**External Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_externalurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2048|

### <a name="BKMK_Adx_ImageAltText"></a> Adx_ImageAltText

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image Alt Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_imagealttext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_Adx_ImageHeight"></a> Adx_ImageHeight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image Height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_imageheight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_Adx_ImageUrl"></a> Adx_ImageUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_imageurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_Adx_ImageWidth"></a> Adx_ImageWidth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image Width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_imagewidth`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

### <a name="BKMK_Adx_OpenInNewWindow"></a> Adx_OpenInNewWindow

|Property|Value|
|---|---|
|Description||
|DisplayName|**Open In New Window**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_openinnewwindow`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`adx_weblink_adx_openinnewwindow`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_pageid"></a> adx_pageid

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Page associated with Web Link.**|
|DisplayName|**Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_pageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_adx_parentweblinkid"></a> adx_parentweblinkid

|Property|Value|
|---|---|
|Description|**Unique identifier for parent Web Link associated with Web Link.**|
|DisplayName|**Parent Web Link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_parentweblinkid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_weblink|

### <a name="BKMK_adx_publishingstateid"></a> adx_publishingstateid

|Property|Value|
|---|---|
|Description|**Unique identifier for Publishing State associated with Web Link.**|
|DisplayName|**Publishing State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_publishingstateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_publishingstate|

### <a name="BKMK_Adx_RobotsFollowLink"></a> Adx_RobotsFollowLink

|Property|Value|
|---|---|
|Description||
|DisplayName|**Robots Follow Link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_robotsfollowlink`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`adx_weblink_adx_robotsfollowlink`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_weblinkId"></a> Adx_weblinkId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Web Link**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_weblinkid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_weblinksetid"></a> adx_weblinksetid

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Link Set associated with Web Link.**|
|DisplayName|**Web Link Set**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_weblinksetid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_weblinkset|

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
|Description|**Status of the Web Link**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_weblink_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Web Link**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_weblink_statuscode`|

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

- [adx_publishingstate_weblink](#BKMK_adx_publishingstate_weblink)
- [adx_weblink_weblink](#BKMK_adx_weblink_weblink-many-to-one)
- [adx_weblinkset_weblink](#BKMK_adx_weblinkset_weblink)
- [adx_webpage_weblink](#BKMK_adx_webpage_weblink)
- [business_unit_adx_weblink](#BKMK_business_unit_adx_weblink)
- [lk_adx_weblink_createdby](#BKMK_lk_adx_weblink_createdby)
- [lk_adx_weblink_createdonbehalfby](#BKMK_lk_adx_weblink_createdonbehalfby)
- [lk_adx_weblink_modifiedby](#BKMK_lk_adx_weblink_modifiedby)
- [lk_adx_weblink_modifiedonbehalfby](#BKMK_lk_adx_weblink_modifiedonbehalfby)
- [owner_adx_weblink](#BKMK_owner_adx_weblink)
- [team_adx_weblink](#BKMK_team_adx_weblink)
- [user_adx_weblink](#BKMK_user_adx_weblink)

### <a name="BKMK_adx_publishingstate_weblink"></a> adx_publishingstate_weblink

One-To-Many Relationship: [adx_publishingstate adx_publishingstate_weblink](adx_publishingstate.md#BKMK_adx_publishingstate_weblink)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstate`|
|ReferencedAttribute|`adx_publishingstateid`|
|ReferencingAttribute|`adx_publishingstateid`|
|ReferencingEntityNavigationPropertyName|`adx_publishingstateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_weblink_weblink-many-to-one"></a> adx_weblink_weblink

One-To-Many Relationship: [adx_weblink adx_weblink_weblink](#BKMK_adx_weblink_weblink-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_weblink`|
|ReferencedAttribute|`adx_weblinkid`|
|ReferencingAttribute|`adx_parentweblinkid`|
|ReferencingEntityNavigationPropertyName|`adx_parentweblinkid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_weblinkset_weblink"></a> adx_weblinkset_weblink

One-To-Many Relationship: [adx_weblinkset adx_weblinkset_weblink](adx_weblinkset.md#BKMK_adx_weblinkset_weblink)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_weblinkset`|
|ReferencedAttribute|`adx_weblinksetid`|
|ReferencingAttribute|`adx_weblinksetid`|
|ReferencingEntityNavigationPropertyName|`adx_weblinksetid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_webpage_weblink"></a> adx_webpage_weblink

One-To-Many Relationship: [adx_webpage adx_webpage_weblink](adx_webpage.md#BKMK_adx_webpage_weblink)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_pageid`|
|ReferencingEntityNavigationPropertyName|`adx_pageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_adx_weblink"></a> business_unit_adx_weblink

One-To-Many Relationship: [businessunit business_unit_adx_weblink](businessunit.md#BKMK_business_unit_adx_weblink)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_weblink_createdby"></a> lk_adx_weblink_createdby

One-To-Many Relationship: [systemuser lk_adx_weblink_createdby](systemuser.md#BKMK_lk_adx_weblink_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_weblink_createdonbehalfby"></a> lk_adx_weblink_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_weblink_createdonbehalfby](systemuser.md#BKMK_lk_adx_weblink_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_weblink_modifiedby"></a> lk_adx_weblink_modifiedby

One-To-Many Relationship: [systemuser lk_adx_weblink_modifiedby](systemuser.md#BKMK_lk_adx_weblink_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_weblink_modifiedonbehalfby"></a> lk_adx_weblink_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_weblink_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_weblink_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_weblink"></a> owner_adx_weblink

One-To-Many Relationship: [owner owner_adx_weblink](owner.md#BKMK_owner_adx_weblink)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_weblink"></a> team_adx_weblink

One-To-Many Relationship: [team team_adx_weblink](team.md#BKMK_team_adx_weblink)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_weblink"></a> user_adx_weblink

One-To-Many Relationship: [systemuser user_adx_weblink](systemuser.md#BKMK_user_adx_weblink)

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

- [adx_weblink_Annotations](#BKMK_adx_weblink_Annotations)
- [adx_weblink_AsyncOperations](#BKMK_adx_weblink_AsyncOperations)
- [adx_weblink_BulkDeleteFailures](#BKMK_adx_weblink_BulkDeleteFailures)
- [adx_weblink_MailboxTrackingFolders](#BKMK_adx_weblink_MailboxTrackingFolders)
- [adx_weblink_PrincipalObjectAttributeAccesses](#BKMK_adx_weblink_PrincipalObjectAttributeAccesses)
- [adx_weblink_ProcessSession](#BKMK_adx_weblink_ProcessSession)
- [adx_weblink_SyncErrors](#BKMK_adx_weblink_SyncErrors)
- [adx_weblink_weblink](#BKMK_adx_weblink_weblink-one-to-many)

### <a name="BKMK_adx_weblink_Annotations"></a> adx_weblink_Annotations

Many-To-One Relationship: [annotation adx_weblink_Annotations](annotation.md#BKMK_adx_weblink_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_weblink_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_weblink_AsyncOperations"></a> adx_weblink_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_weblink_AsyncOperations](asyncoperation.md#BKMK_adx_weblink_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_weblink_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_weblink_BulkDeleteFailures"></a> adx_weblink_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_weblink_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_weblink_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_weblink_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_weblink_MailboxTrackingFolders"></a> adx_weblink_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_weblink_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_weblink_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_weblink_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_weblink_PrincipalObjectAttributeAccesses"></a> adx_weblink_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_weblink_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_weblink_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_weblink_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_weblink_ProcessSession"></a> adx_weblink_ProcessSession

Many-To-One Relationship: [processsession adx_weblink_ProcessSession](processsession.md#BKMK_adx_weblink_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_weblink_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_weblink_SyncErrors"></a> adx_weblink_SyncErrors

Many-To-One Relationship: [syncerror adx_weblink_SyncErrors](syncerror.md#BKMK_adx_weblink_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_weblink_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_weblink_weblink-one-to-many"></a> adx_weblink_weblink

Many-To-One Relationship: [adx_weblink adx_weblink_weblink](#BKMK_adx_weblink_weblink-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_weblink`|
|ReferencingAttribute|`adx_parentweblinkid`|
|ReferencedEntityNavigationPropertyName|`adx_weblink_weblink`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Child Links<br />MenuId: null<br />Order: 100500<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

