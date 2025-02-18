---
title: "imagestyle (msdyncrm_imagestyle) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the imagestyle (msdyncrm_imagestyle) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# imagestyle (msdyncrm_imagestyle) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the imagestyle (msdyncrm_imagestyle) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_imagestyles(*msdyncrm_imagestyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyncrm_imagestyles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_imagestyles(*msdyncrm_imagestyleid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_imagestyles(*msdyncrm_imagestyleid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_imagestyles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_imagestyles(*msdyncrm_imagestyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_imagestyles(*msdyncrm_imagestyleid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_imagestyles(*msdyncrm_imagestyleid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the imagestyle (msdyncrm_imagestyle) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **imagestyle** |
| **DisplayCollectionName** | **imagestyle** |
| **SchemaName** | `msdyncrm_imagestyle` |
| **CollectionSchemaName** | `msdyncrm_imagestyles` |
| **EntitySetName** | `msdyncrm_imagestyles`|
| **LogicalName** | `msdyncrm_imagestyle` |
| **LogicalCollectionName** | `msdyncrm_imagestyles` |
| **PrimaryIdAttribute** | `msdyncrm_imagestyleid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_align](#BKMK_msdyncrm_align)
- [msdyncrm_alttext](#BKMK_msdyncrm_alttext)
- [msdyncrm_autowidth](#BKMK_msdyncrm_autowidth)
- [msdyncrm_emailtext](#BKMK_msdyncrm_emailtext)
- [msdyncrm_fileid](#BKMK_msdyncrm_fileid)
- [msdyncrm_fit](#BKMK_msdyncrm_fit)
- [msdyncrm_height](#BKMK_msdyncrm_height)
- [msdyncrm_imagesource](#BKMK_msdyncrm_imagesource)
- [msdyncrm_imagestyleId](#BKMK_msdyncrm_imagestyleId)
- [msdyncrm_link](#BKMK_msdyncrm_link)
- [msdyncrm_marginbottom](#BKMK_msdyncrm_marginbottom)
- [msdyncrm_marginleft](#BKMK_msdyncrm_marginleft)
- [msdyncrm_marginright](#BKMK_msdyncrm_marginright)
- [msdyncrm_margintop](#BKMK_msdyncrm_margintop)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_noalttext](#BKMK_msdyncrm_noalttext)
- [msdyncrm_originalheight](#BKMK_msdyncrm_originalheight)
- [msdyncrm_originalwidth](#BKMK_msdyncrm_originalwidth)
- [msdyncrm_paddingbottom](#BKMK_msdyncrm_paddingbottom)
- [msdyncrm_paddingleft](#BKMK_msdyncrm_paddingleft)
- [msdyncrm_paddingright](#BKMK_msdyncrm_paddingright)
- [msdyncrm_paddingtop](#BKMK_msdyncrm_paddingtop)
- [msdyncrm_roundedcorners](#BKMK_msdyncrm_roundedcorners)
- [msdyncrm_tracking](#BKMK_msdyncrm_tracking)
- [msdyncrm_verticalalign](#BKMK_msdyncrm_verticalalign)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_align"></a> msdyncrm_align

|Property|Value|
|---|---|
|Description||
|DisplayName|**Alignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_align`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_alttext"></a> msdyncrm_alttext

|Property|Value|
|---|---|
|Description||
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
|MaxLength|255|

### <a name="BKMK_msdyncrm_autowidth"></a> msdyncrm_autowidth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Auto width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_autowidth`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_imagestyle_msdyncrm_autowidth`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdyncrm_emailtext"></a> msdyncrm_emailtext

|Property|Value|
|---|---|
|Description|**Email text to be used for image asset suggestions**|
|DisplayName|**Email text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailtext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdyncrm_fileid"></a> msdyncrm_fileid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image file id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fileid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_fit"></a> msdyncrm_fit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fit`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|164230000|
|GlobalChoiceName|`msdyncrm_fittype`|

#### msdyncrm_fit Choices/Options

|Value|Label|
|---|---|
|164230000|**Fill**|
|164230001|**Custom**|

### <a name="BKMK_msdyncrm_height"></a> msdyncrm_height

|Property|Value|
|---|---|
|Description||
|DisplayName|**Height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_height`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_imagesource"></a> msdyncrm_imagesource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_imagesource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_imagestyleId"></a> msdyncrm_imagestyleId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**imagestyle**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_imagestyleid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_link"></a> msdyncrm_link

|Property|Value|
|---|---|
|Description||
|DisplayName|**Link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_link`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_marginbottom"></a> msdyncrm_marginbottom

|Property|Value|
|---|---|
|Description||
|DisplayName|**Bottom**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marginbottom`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_marginleft"></a> msdyncrm_marginleft

|Property|Value|
|---|---|
|Description||
|DisplayName|**Left**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marginleft`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_marginright"></a> msdyncrm_marginright

|Property|Value|
|---|---|
|Description||
|DisplayName|**Right**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marginright`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_margintop"></a> msdyncrm_margintop

|Property|Value|
|---|---|
|Description||
|DisplayName|**Top**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_margintop`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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
|MaxLength|100|

### <a name="BKMK_msdyncrm_noalttext"></a> msdyncrm_noalttext

|Property|Value|
|---|---|
|Description||
|DisplayName|**This image doesn't need alt text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_noalttext`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_imagestyle_msdyncrm_noalttext`|
|DefaultValue|False|
|True Label|true|
|False Label|false|

### <a name="BKMK_msdyncrm_originalheight"></a> msdyncrm_originalheight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Original height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_originalheight`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_originalwidth"></a> msdyncrm_originalwidth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Original width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_originalwidth`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_paddingbottom"></a> msdyncrm_paddingbottom

|Property|Value|
|---|---|
|Description||
|DisplayName|**Bottom**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_paddingbottom`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_paddingleft"></a> msdyncrm_paddingleft

|Property|Value|
|---|---|
|Description||
|DisplayName|**Left**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_paddingleft`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_paddingright"></a> msdyncrm_paddingright

|Property|Value|
|---|---|
|Description||
|DisplayName|**Right**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_paddingright`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_paddingtop"></a> msdyncrm_paddingtop

|Property|Value|
|---|---|
|Description||
|DisplayName|**Top**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_paddingtop`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_roundedcorners"></a> msdyncrm_roundedcorners

|Property|Value|
|---|---|
|Description||
|DisplayName|**Rounded corners**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_roundedcorners`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_tracking"></a> msdyncrm_tracking

|Property|Value|
|---|---|
|Description||
|DisplayName|**Tracking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_tracking`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_imagestyle_msdyncrm_tracking`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdyncrm_verticalalign"></a> msdyncrm_verticalalign

|Property|Value|
|---|---|
|Description||
|DisplayName|**Vertical alignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_verticalalign`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_width"></a> msdyncrm_width

|Property|Value|
|---|---|
|Description||
|DisplayName|**width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_width`|
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
|GlobalChoiceName|`msdyncrm_imagestyle_statecode`|

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
|GlobalChoiceName|`msdyncrm_imagestyle_statuscode`|

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

- [business_unit_msdyncrm_imagestyle](#BKMK_business_unit_msdyncrm_imagestyle)
- [lk_msdyncrm_imagestyle_createdby](#BKMK_lk_msdyncrm_imagestyle_createdby)
- [lk_msdyncrm_imagestyle_createdonbehalfby](#BKMK_lk_msdyncrm_imagestyle_createdonbehalfby)
- [lk_msdyncrm_imagestyle_modifiedby](#BKMK_lk_msdyncrm_imagestyle_modifiedby)
- [lk_msdyncrm_imagestyle_modifiedonbehalfby](#BKMK_lk_msdyncrm_imagestyle_modifiedonbehalfby)
- [owner_msdyncrm_imagestyle](#BKMK_owner_msdyncrm_imagestyle)
- [team_msdyncrm_imagestyle](#BKMK_team_msdyncrm_imagestyle)
- [user_msdyncrm_imagestyle](#BKMK_user_msdyncrm_imagestyle)

### <a name="BKMK_business_unit_msdyncrm_imagestyle"></a> business_unit_msdyncrm_imagestyle

One-To-Many Relationship: [businessunit business_unit_msdyncrm_imagestyle](businessunit.md#BKMK_business_unit_msdyncrm_imagestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_imagestyle_createdby"></a> lk_msdyncrm_imagestyle_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_imagestyle_createdby](systemuser.md#BKMK_lk_msdyncrm_imagestyle_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_imagestyle_createdonbehalfby"></a> lk_msdyncrm_imagestyle_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_imagestyle_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_imagestyle_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_imagestyle_modifiedby"></a> lk_msdyncrm_imagestyle_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_imagestyle_modifiedby](systemuser.md#BKMK_lk_msdyncrm_imagestyle_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_imagestyle_modifiedonbehalfby"></a> lk_msdyncrm_imagestyle_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_imagestyle_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_imagestyle_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_imagestyle"></a> owner_msdyncrm_imagestyle

One-To-Many Relationship: [owner owner_msdyncrm_imagestyle](owner.md#BKMK_owner_msdyncrm_imagestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_imagestyle"></a> team_msdyncrm_imagestyle

One-To-Many Relationship: [team team_msdyncrm_imagestyle](team.md#BKMK_team_msdyncrm_imagestyle)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_imagestyle"></a> user_msdyncrm_imagestyle

One-To-Many Relationship: [systemuser user_msdyncrm_imagestyle](systemuser.md#BKMK_user_msdyncrm_imagestyle)

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

- [msdyncrm_imagestyle_AsyncOperations](#BKMK_msdyncrm_imagestyle_AsyncOperations)
- [msdyncrm_imagestyle_BulkDeleteFailures](#BKMK_msdyncrm_imagestyle_BulkDeleteFailures)
- [msdyncrm_imagestyle_DuplicateBaseRecord](#BKMK_msdyncrm_imagestyle_DuplicateBaseRecord)
- [msdyncrm_imagestyle_DuplicateMatchingRecord](#BKMK_msdyncrm_imagestyle_DuplicateMatchingRecord)
- [msdyncrm_imagestyle_MailboxTrackingFolders](#BKMK_msdyncrm_imagestyle_MailboxTrackingFolders)
- [msdyncrm_imagestyle_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_imagestyle_PrincipalObjectAttributeAccesses)
- [msdyncrm_imagestyle_ProcessSession](#BKMK_msdyncrm_imagestyle_ProcessSession)
- [msdyncrm_imagestyle_SyncErrors](#BKMK_msdyncrm_imagestyle_SyncErrors)

### <a name="BKMK_msdyncrm_imagestyle_AsyncOperations"></a> msdyncrm_imagestyle_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_imagestyle_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_imagestyle_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_imagestyle_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_imagestyle_BulkDeleteFailures"></a> msdyncrm_imagestyle_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_imagestyle_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_imagestyle_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_imagestyle_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_imagestyle_DuplicateBaseRecord"></a> msdyncrm_imagestyle_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_imagestyle_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_imagestyle_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_imagestyle_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_imagestyle_DuplicateMatchingRecord"></a> msdyncrm_imagestyle_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_imagestyle_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_imagestyle_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_imagestyle_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_imagestyle_MailboxTrackingFolders"></a> msdyncrm_imagestyle_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_imagestyle_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_imagestyle_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_imagestyle_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_imagestyle_PrincipalObjectAttributeAccesses"></a> msdyncrm_imagestyle_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_imagestyle_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_imagestyle_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_imagestyle_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_imagestyle_ProcessSession"></a> msdyncrm_imagestyle_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_imagestyle_ProcessSession](processsession.md#BKMK_msdyncrm_imagestyle_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_imagestyle_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_imagestyle_SyncErrors"></a> msdyncrm_imagestyle_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_imagestyle_SyncErrors](syncerror.md#BKMK_msdyncrm_imagestyle_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_imagestyle_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

