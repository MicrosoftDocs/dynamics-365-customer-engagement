---
title: "QR code style (msdynmkt_qrcodestyle) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the QR code style (msdynmkt_qrcodestyle) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# QR code style (msdynmkt_qrcodestyle) table/entity reference



## Messages

The following table lists the messages for the QR code style (msdynmkt_qrcodestyle) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_qrcodestyles(*msdynmkt_qrcodestyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_qrcodestyles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_qrcodestyles(*msdynmkt_qrcodestyleid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_qrcodestyles(*msdynmkt_qrcodestyleid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_qrcodestyles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_qrcodestyles(*msdynmkt_qrcodestyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_qrcodestyles(*msdynmkt_qrcodestyleid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_qrcodestyles(*msdynmkt_qrcodestyleid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the QR code style (msdynmkt_qrcodestyle) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the QR code style (msdynmkt_qrcodestyle) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **QR code style** |
| **DisplayCollectionName** | **QR code styles** |
| **SchemaName** | `msdynmkt_qrcodestyle` |
| **CollectionSchemaName** | `msdynmkt_qrcodestyles` |
| **EntitySetName** | `msdynmkt_qrcodestyles`|
| **LogicalName** | `msdynmkt_qrcodestyle` |
| **LogicalCollectionName** | `msdynmkt_qrcodestyles` |
| **PrimaryIdAttribute** | `msdynmkt_qrcodestyleid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_align](#BKMK_msdynmkt_align)
- [msdynmkt_alttext](#BKMK_msdynmkt_alttext)
- [msdynmkt_autowidth](#BKMK_msdynmkt_autowidth)
- [msdynmkt_emailstatuscode](#BKMK_msdynmkt_emailstatuscode)
- [msdynmkt_height](#BKMK_msdynmkt_height)
- [msdynmkt_link](#BKMK_msdynmkt_link)
- [msdynmkt_marginbottom](#BKMK_msdynmkt_marginbottom)
- [msdynmkt_marginleft](#BKMK_msdynmkt_marginleft)
- [msdynmkt_marginright](#BKMK_msdynmkt_marginright)
- [msdynmkt_margintop](#BKMK_msdynmkt_margintop)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_noalttext](#BKMK_msdynmkt_noalttext)
- [msdynmkt_originalheight](#BKMK_msdynmkt_originalheight)
- [msdynmkt_originalwidth](#BKMK_msdynmkt_originalwidth)
- [msdynmkt_paddingbottom](#BKMK_msdynmkt_paddingbottom)
- [msdynmkt_paddingleft](#BKMK_msdynmkt_paddingleft)
- [msdynmkt_paddingright](#BKMK_msdynmkt_paddingright)
- [msdynmkt_paddingtop](#BKMK_msdynmkt_paddingtop)
- [msdynmkt_placeholders](#BKMK_msdynmkt_placeholders)
- [msdynmkt_qrcodestyleId](#BKMK_msdynmkt_qrcodestyleId)
- [msdynmkt_tracking](#BKMK_msdynmkt_tracking)
- [msdynmkt_verticalalign](#BKMK_msdynmkt_verticalalign)
- [msdynmkt_width](#BKMK_msdynmkt_width)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdynmkt_align"></a> msdynmkt_align

|Property|Value|
|---|---|
|Description||
|DisplayName|**Alignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_align`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_alttext"></a> msdynmkt_alttext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Alt text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_alttext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdynmkt_autowidth"></a> msdynmkt_autowidth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Auto width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_autowidth`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_qrcodestyle_msdynmkt_autowidth`|
|DefaultValue|False|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdynmkt_emailstatuscode"></a> msdynmkt_emailstatuscode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email status code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailstatuscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdynmkt_qrcodestyle_msdynmkt_emailstatuscode`|

#### msdynmkt_emailstatuscode Choices/Options

|Value|Label|
|---|---|
|1|**Draft**|
|2|**Ready to send**|
|3|**Live editing**|
|100|**Inactive**|

### <a name="BKMK_msdynmkt_height"></a> msdynmkt_height

|Property|Value|
|---|---|
|Description||
|DisplayName|**Height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_height`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_link"></a> msdynmkt_link

|Property|Value|
|---|---|
|Description||
|DisplayName|**Link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_link`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_marginbottom"></a> msdynmkt_marginbottom

|Property|Value|
|---|---|
|Description||
|DisplayName|**Margin bottom**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marginbottom`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_marginleft"></a> msdynmkt_marginleft

|Property|Value|
|---|---|
|Description||
|DisplayName|**Margin left**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marginleft`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_marginright"></a> msdynmkt_marginright

|Property|Value|
|---|---|
|Description||
|DisplayName|**Margin right**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marginright`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_margintop"></a> msdynmkt_margintop

|Property|Value|
|---|---|
|Description||
|DisplayName|**Margin top**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_margintop`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_noalttext"></a> msdynmkt_noalttext

|Property|Value|
|---|---|
|Description||
|DisplayName|**This image doesn't need alt text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_noalttext`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_qrcodestyle_msdynmkt_noalttext`|
|DefaultValue|False|
|True Label|true|
|False Label|false|

### <a name="BKMK_msdynmkt_originalheight"></a> msdynmkt_originalheight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Original height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_originalheight`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_originalwidth"></a> msdynmkt_originalwidth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Original width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_originalwidth`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_paddingbottom"></a> msdynmkt_paddingbottom

|Property|Value|
|---|---|
|Description||
|DisplayName|**Padding bottom**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_paddingbottom`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_paddingleft"></a> msdynmkt_paddingleft

|Property|Value|
|---|---|
|Description||
|DisplayName|**Padding left**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_paddingleft`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_paddingright"></a> msdynmkt_paddingright

|Property|Value|
|---|---|
|Description||
|DisplayName|**Padding right**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_paddingright`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_paddingtop"></a> msdynmkt_paddingtop

|Property|Value|
|---|---|
|Description||
|DisplayName|**Padding top**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_paddingtop`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_placeholders"></a> msdynmkt_placeholders

|Property|Value|
|---|---|
|Description||
|DisplayName|**Placeholders**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_placeholders`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdynmkt_qrcodestyleId"></a> msdynmkt_qrcodestyleId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**QR code style**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_qrcodestyleid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_tracking"></a> msdynmkt_tracking

|Property|Value|
|---|---|
|Description||
|DisplayName|**Tracking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_tracking`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_qrcodestyle_msdynmkt_tracking`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdynmkt_verticalalign"></a> msdynmkt_verticalalign

|Property|Value|
|---|---|
|Description||
|DisplayName|**Vertical alignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_verticalalign`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_width"></a> msdynmkt_width

|Property|Value|
|---|---|
|Description||
|DisplayName|**width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_width`|
|RequiredLevel|None|
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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
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
|Description|**Status of the QR code style**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_qrcodestyle_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the QR code style**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_qrcodestyle_statuscode`|

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
|Description|**Date and time when the record was created.**|
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
|Description|**Unique identifier of the delegate user who created the record.**|
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
|Description|**Date and time when the record was modified.**|
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
|Description|**Unique identifier of the delegate user who modified the record.**|
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
|DisplayName|**Business Unit**|
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

- [business_unit_msdynmkt_qrcodestyle](#BKMK_business_unit_msdynmkt_qrcodestyle)
- [lk_msdynmkt_qrcodestyle_createdby](#BKMK_lk_msdynmkt_qrcodestyle_createdby)
- [lk_msdynmkt_qrcodestyle_createdonbehalfby](#BKMK_lk_msdynmkt_qrcodestyle_createdonbehalfby)
- [lk_msdynmkt_qrcodestyle_modifiedby](#BKMK_lk_msdynmkt_qrcodestyle_modifiedby)
- [lk_msdynmkt_qrcodestyle_modifiedonbehalfby](#BKMK_lk_msdynmkt_qrcodestyle_modifiedonbehalfby)
- [owner_msdynmkt_qrcodestyle](#BKMK_owner_msdynmkt_qrcodestyle)
- [team_msdynmkt_qrcodestyle](#BKMK_team_msdynmkt_qrcodestyle)
- [user_msdynmkt_qrcodestyle](#BKMK_user_msdynmkt_qrcodestyle)

### <a name="BKMK_business_unit_msdynmkt_qrcodestyle"></a> business_unit_msdynmkt_qrcodestyle

One-To-Many Relationship: [businessunit business_unit_msdynmkt_qrcodestyle](businessunit.md#BKMK_business_unit_msdynmkt_qrcodestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_qrcodestyle_createdby"></a> lk_msdynmkt_qrcodestyle_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_qrcodestyle_createdby](systemuser.md#BKMK_lk_msdynmkt_qrcodestyle_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_qrcodestyle_createdonbehalfby"></a> lk_msdynmkt_qrcodestyle_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_qrcodestyle_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_qrcodestyle_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_qrcodestyle_modifiedby"></a> lk_msdynmkt_qrcodestyle_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_qrcodestyle_modifiedby](systemuser.md#BKMK_lk_msdynmkt_qrcodestyle_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_qrcodestyle_modifiedonbehalfby"></a> lk_msdynmkt_qrcodestyle_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_qrcodestyle_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_qrcodestyle_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_qrcodestyle"></a> owner_msdynmkt_qrcodestyle

One-To-Many Relationship: [owner owner_msdynmkt_qrcodestyle](owner.md#BKMK_owner_msdynmkt_qrcodestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_qrcodestyle"></a> team_msdynmkt_qrcodestyle

One-To-Many Relationship: [team team_msdynmkt_qrcodestyle](team.md#BKMK_team_msdynmkt_qrcodestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_qrcodestyle"></a> user_msdynmkt_qrcodestyle

One-To-Many Relationship: [systemuser user_msdynmkt_qrcodestyle](systemuser.md#BKMK_user_msdynmkt_qrcodestyle)

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

- [msdynmkt_qrcodestyle_AsyncOperations](#BKMK_msdynmkt_qrcodestyle_AsyncOperations)
- [msdynmkt_qrcodestyle_BulkDeleteFailures](#BKMK_msdynmkt_qrcodestyle_BulkDeleteFailures)
- [msdynmkt_qrcodestyle_DuplicateBaseRecord](#BKMK_msdynmkt_qrcodestyle_DuplicateBaseRecord)
- [msdynmkt_qrcodestyle_DuplicateMatchingRecord](#BKMK_msdynmkt_qrcodestyle_DuplicateMatchingRecord)
- [msdynmkt_qrcodestyle_MailboxTrackingFolders](#BKMK_msdynmkt_qrcodestyle_MailboxTrackingFolders)
- [msdynmkt_qrcodestyle_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_qrcodestyle_PrincipalObjectAttributeAccesses)
- [msdynmkt_qrcodestyle_ProcessSession](#BKMK_msdynmkt_qrcodestyle_ProcessSession)
- [msdynmkt_qrcodestyle_SyncErrors](#BKMK_msdynmkt_qrcodestyle_SyncErrors)

### <a name="BKMK_msdynmkt_qrcodestyle_AsyncOperations"></a> msdynmkt_qrcodestyle_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_qrcodestyle_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_qrcodestyle_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_qrcodestyle_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_qrcodestyle_BulkDeleteFailures"></a> msdynmkt_qrcodestyle_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_qrcodestyle_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_qrcodestyle_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_qrcodestyle_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_qrcodestyle_DuplicateBaseRecord"></a> msdynmkt_qrcodestyle_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_qrcodestyle_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_qrcodestyle_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_qrcodestyle_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_qrcodestyle_DuplicateMatchingRecord"></a> msdynmkt_qrcodestyle_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_qrcodestyle_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_qrcodestyle_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_qrcodestyle_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_qrcodestyle_MailboxTrackingFolders"></a> msdynmkt_qrcodestyle_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_qrcodestyle_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_qrcodestyle_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_qrcodestyle_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_qrcodestyle_PrincipalObjectAttributeAccesses"></a> msdynmkt_qrcodestyle_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_qrcodestyle_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_qrcodestyle_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_qrcodestyle_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_qrcodestyle_ProcessSession"></a> msdynmkt_qrcodestyle_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_qrcodestyle_ProcessSession](processsession.md#BKMK_msdynmkt_qrcodestyle_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_qrcodestyle_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_qrcodestyle_SyncErrors"></a> msdynmkt_qrcodestyle_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_qrcodestyle_SyncErrors](syncerror.md#BKMK_msdynmkt_qrcodestyle_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_qrcodestyle_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

