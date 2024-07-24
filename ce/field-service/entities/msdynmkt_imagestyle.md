---
title: "imagestyle (msdynmkt_imagestyle) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the imagestyle (msdynmkt_imagestyle) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# imagestyle (msdynmkt_imagestyle) table/entity reference



## Messages

The following table lists the messages for the imagestyle (msdynmkt_imagestyle) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_imagestyles(*msdynmkt_imagestyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_imagestyles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_imagestyles(*msdynmkt_imagestyleid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_imagestyles(*msdynmkt_imagestyleid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_imagestyles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_imagestyles(*msdynmkt_imagestyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_imagestyles(*msdynmkt_imagestyleid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_imagestyles(*msdynmkt_imagestyleid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the imagestyle (msdynmkt_imagestyle) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the imagestyle (msdynmkt_imagestyle) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **imagestyle** |
| **DisplayCollectionName** | **imagestyle** |
| **SchemaName** | `msdynmkt_imagestyle` |
| **CollectionSchemaName** | `msdynmkt_imagestyles` |
| **EntitySetName** | `msdynmkt_imagestyles`|
| **LogicalName** | `msdynmkt_imagestyle` |
| **LogicalCollectionName** | `msdynmkt_imagestyles` |
| **PrimaryIdAttribute** | `msdynmkt_imagestyleid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_alias](#BKMK_msdynmkt_alias)
- [msdynmkt_aliasplaceholder](#BKMK_msdynmkt_aliasplaceholder)
- [msdynmkt_align](#BKMK_msdynmkt_align)
- [msdynmkt_alttext](#BKMK_msdynmkt_alttext)
- [msdynmkt_assetsprovider](#BKMK_msdynmkt_assetsprovider)
- [msdynmkt_autowidth](#BKMK_msdynmkt_autowidth)
- [msdynmkt_emailtext](#BKMK_msdynmkt_emailtext)
- [msdynmkt_fileid](#BKMK_msdynmkt_fileid)
- [msdynmkt_fit](#BKMK_msdynmkt_fit)
- [msdynmkt_height](#BKMK_msdynmkt_height)
- [msdynmkt_imagesource](#BKMK_msdynmkt_imagesource)
- [msdynmkt_imagestyleId](#BKMK_msdynmkt_imagestyleId)
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
- [msdynmkt_parentowningbusinessunit](#BKMK_msdynmkt_parentowningbusinessunit)
- [msdynmkt_parentstatuscode](#BKMK_msdynmkt_parentstatuscode)
- [msdynmkt_placeholders](#BKMK_msdynmkt_placeholders)
- [msdynmkt_roundedcorners](#BKMK_msdynmkt_roundedcorners)
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

### <a name="BKMK_msdynmkt_alias"></a> msdynmkt_alias

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image alias**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_alias`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_aliasplaceholder"></a> msdynmkt_aliasplaceholder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image alias placeholder**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_aliasplaceholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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

### <a name="BKMK_msdynmkt_assetsprovider"></a> msdynmkt_assetsprovider

|Property|Value|
|---|---|
|Description||
|DisplayName|**Assets provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_assetsprovider`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyncrm_imagepickerassetsproviders`|

#### msdynmkt_assetsprovider Choices/Options

|Value|Label|
|---|---|
|1|**Digital Assets**|
|2|**Commerce**|

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
|GlobalChoiceName|`msdynmkt_imagestyle_msdynmkt_autowidth`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdynmkt_emailtext"></a> msdynmkt_emailtext

|Property|Value|
|---|---|
|Description|**Email text to be used for image asset suggestions**|
|DisplayName|**Email text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailtext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdynmkt_fileid"></a> msdynmkt_fileid

|Property|Value|
|---|---|
|Description||
|DisplayName|**File id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_fileid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_fit"></a> msdynmkt_fit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_fit`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|164230000|
|GlobalChoiceName|`msdynmkt_fittype`|

#### msdynmkt_fit Choices/Options

|Value|Label|
|---|---|
|164230000|**Fill**|
|164230001|**Custom**|

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

### <a name="BKMK_msdynmkt_imagesource"></a> msdynmkt_imagesource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_imagesource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_imagestyleId"></a> msdynmkt_imagestyleId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**imagestyle**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_imagestyleid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|GlobalChoiceName|`msdynmkt_imagestyle_msdynmkt_noalttext`|
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

### <a name="BKMK_msdynmkt_parentowningbusinessunit"></a> msdynmkt_parentowningbusinessunit

|Property|Value|
|---|---|
|Description|**Business unit**|
|DisplayName|**Business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_parentowningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_msdynmkt_parentstatuscode"></a> msdynmkt_parentstatuscode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Parent Status Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_parentstatuscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdynmkt_parentemailstatuscode`|

#### msdynmkt_parentstatuscode Choices/Options

|Value|Label|
|---|---|
|1|**Draft**|
|2|**Ready to send**|
|3|**Live editing**|
|100|**Inactive**|

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

### <a name="BKMK_msdynmkt_roundedcorners"></a> msdynmkt_roundedcorners

|Property|Value|
|---|---|
|Description||
|DisplayName|**Rounded corners**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_roundedcorners`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|GlobalChoiceName|`msdynmkt_imagestyle_msdynmkt_tracking`|
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
|Description|**Status of the imagestyle**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_imagestyle_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the imagestyle**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_imagestyle_statuscode`|

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

- [business_unit_msdynmkt_imagestyle](#BKMK_business_unit_msdynmkt_imagestyle)
- [lk_msdynmkt_imagestyle_createdby](#BKMK_lk_msdynmkt_imagestyle_createdby)
- [lk_msdynmkt_imagestyle_createdonbehalfby](#BKMK_lk_msdynmkt_imagestyle_createdonbehalfby)
- [lk_msdynmkt_imagestyle_modifiedby](#BKMK_lk_msdynmkt_imagestyle_modifiedby)
- [lk_msdynmkt_imagestyle_modifiedonbehalfby](#BKMK_lk_msdynmkt_imagestyle_modifiedonbehalfby)
- [msdynmkt_parentowningbusinessunit_businessunit](#BKMK_msdynmkt_parentowningbusinessunit_businessunit)
- [owner_msdynmkt_imagestyle](#BKMK_owner_msdynmkt_imagestyle)
- [team_msdynmkt_imagestyle](#BKMK_team_msdynmkt_imagestyle)
- [user_msdynmkt_imagestyle](#BKMK_user_msdynmkt_imagestyle)

### <a name="BKMK_business_unit_msdynmkt_imagestyle"></a> business_unit_msdynmkt_imagestyle

One-To-Many Relationship: [businessunit business_unit_msdynmkt_imagestyle](businessunit.md#BKMK_business_unit_msdynmkt_imagestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_imagestyle_createdby"></a> lk_msdynmkt_imagestyle_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_imagestyle_createdby](systemuser.md#BKMK_lk_msdynmkt_imagestyle_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_imagestyle_createdonbehalfby"></a> lk_msdynmkt_imagestyle_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_imagestyle_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_imagestyle_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_imagestyle_modifiedby"></a> lk_msdynmkt_imagestyle_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_imagestyle_modifiedby](systemuser.md#BKMK_lk_msdynmkt_imagestyle_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_imagestyle_modifiedonbehalfby"></a> lk_msdynmkt_imagestyle_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_imagestyle_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_imagestyle_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_parentowningbusinessunit_businessunit"></a> msdynmkt_parentowningbusinessunit_businessunit

One-To-Many Relationship: [businessunit msdynmkt_parentowningbusinessunit_businessunit](businessunit.md#BKMK_msdynmkt_parentowningbusinessunit_businessunit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`msdynmkt_parentowningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_parentowningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_imagestyle"></a> owner_msdynmkt_imagestyle

One-To-Many Relationship: [owner owner_msdynmkt_imagestyle](owner.md#BKMK_owner_msdynmkt_imagestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_imagestyle"></a> team_msdynmkt_imagestyle

One-To-Many Relationship: [team team_msdynmkt_imagestyle](team.md#BKMK_team_msdynmkt_imagestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_imagestyle"></a> user_msdynmkt_imagestyle

One-To-Many Relationship: [systemuser user_msdynmkt_imagestyle](systemuser.md#BKMK_user_msdynmkt_imagestyle)

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

- [msdynmkt_imagestyle_AsyncOperations](#BKMK_msdynmkt_imagestyle_AsyncOperations)
- [msdynmkt_imagestyle_BulkDeleteFailures](#BKMK_msdynmkt_imagestyle_BulkDeleteFailures)
- [msdynmkt_imagestyle_DuplicateBaseRecord](#BKMK_msdynmkt_imagestyle_DuplicateBaseRecord)
- [msdynmkt_imagestyle_DuplicateMatchingRecord](#BKMK_msdynmkt_imagestyle_DuplicateMatchingRecord)
- [msdynmkt_imagestyle_MailboxTrackingFolders](#BKMK_msdynmkt_imagestyle_MailboxTrackingFolders)
- [msdynmkt_imagestyle_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_imagestyle_PrincipalObjectAttributeAccesses)
- [msdynmkt_imagestyle_ProcessSession](#BKMK_msdynmkt_imagestyle_ProcessSession)
- [msdynmkt_imagestyle_SyncErrors](#BKMK_msdynmkt_imagestyle_SyncErrors)

### <a name="BKMK_msdynmkt_imagestyle_AsyncOperations"></a> msdynmkt_imagestyle_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_imagestyle_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_imagestyle_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_imagestyle_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_imagestyle_BulkDeleteFailures"></a> msdynmkt_imagestyle_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_imagestyle_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_imagestyle_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_imagestyle_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_imagestyle_DuplicateBaseRecord"></a> msdynmkt_imagestyle_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_imagestyle_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_imagestyle_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_imagestyle_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_imagestyle_DuplicateMatchingRecord"></a> msdynmkt_imagestyle_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_imagestyle_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_imagestyle_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_imagestyle_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_imagestyle_MailboxTrackingFolders"></a> msdynmkt_imagestyle_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_imagestyle_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_imagestyle_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_imagestyle_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_imagestyle_PrincipalObjectAttributeAccesses"></a> msdynmkt_imagestyle_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_imagestyle_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_imagestyle_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_imagestyle_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_imagestyle_ProcessSession"></a> msdynmkt_imagestyle_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_imagestyle_ProcessSession](processsession.md#BKMK_msdynmkt_imagestyle_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_imagestyle_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_imagestyle_SyncErrors"></a> msdynmkt_imagestyle_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_imagestyle_SyncErrors](syncerror.md#BKMK_msdynmkt_imagestyle_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_imagestyle_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

