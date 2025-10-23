---
title: "Column style (msdyncrm_columnstyle) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Column style (msdyncrm_columnstyle) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Column style (msdyncrm_columnstyle) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Column style (msdyncrm_columnstyle) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_columnstyles(*msdyncrm_columnstyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyncrm_columnstyles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_columnstyles(*msdyncrm_columnstyleid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_columnstyles(*msdyncrm_columnstyleid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_columnstyles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_columnstyles(*msdyncrm_columnstyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_columnstyles(*msdyncrm_columnstyleid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_columnstyles(*msdyncrm_columnstyleid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Column style (msdyncrm_columnstyle) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Column style** |
| **DisplayCollectionName** | **Columns style** |
| **SchemaName** | `msdyncrm_columnstyle` |
| **CollectionSchemaName** | `msdyncrm_columnstyles` |
| **EntitySetName** | `msdyncrm_columnstyles`|
| **LogicalName** | `msdyncrm_columnstyle` |
| **LogicalCollectionName** | `msdyncrm_columnstyles` |
| **PrimaryIdAttribute** | `msdyncrm_columnstyleid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_alignment](#BKMK_msdyncrm_alignment)
- [msdyncrm_assetsprovider](#BKMK_msdyncrm_assetsprovider)
- [msdyncrm_backgroundcolor](#BKMK_msdyncrm_backgroundcolor)
- [msdyncrm_backgroundimage](#BKMK_msdyncrm_backgroundimage)
- [msdyncrm_backgroundimagefileid](#BKMK_msdyncrm_backgroundimagefileid)
- [msdyncrm_backgroundpositionx](#BKMK_msdyncrm_backgroundpositionx)
- [msdyncrm_backgroundpositiony](#BKMK_msdyncrm_backgroundpositiony)
- [msdyncrm_backgroundsize](#BKMK_msdyncrm_backgroundsize)
- [msdyncrm_bordercolor](#BKMK_msdyncrm_bordercolor)
- [msdyncrm_bordersize](#BKMK_msdyncrm_bordersize)
- [msdyncrm_borderstyle](#BKMK_msdyncrm_borderstyle)
- [msdyncrm_columnstyleId](#BKMK_msdyncrm_columnstyleId)
- [msdyncrm_emailcolorpalette](#BKMK_msdyncrm_emailcolorpalette)
- [msdyncrm_image](#BKMK_msdyncrm_image)
- [msdyncrm_marginbottom](#BKMK_msdyncrm_marginbottom)
- [msdyncrm_marginleft](#BKMK_msdyncrm_marginleft)
- [msdyncrm_marginright](#BKMK_msdyncrm_marginright)
- [msdyncrm_margintop](#BKMK_msdyncrm_margintop)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_paddingbottom](#BKMK_msdyncrm_paddingbottom)
- [msdyncrm_paddingleft](#BKMK_msdyncrm_paddingleft)
- [msdyncrm_paddingright](#BKMK_msdyncrm_paddingright)
- [msdyncrm_paddingtop](#BKMK_msdyncrm_paddingtop)
- [msdyncrm_roundedcorners](#BKMK_msdyncrm_roundedcorners)
- [msdyncrm_verticalalign](#BKMK_msdyncrm_verticalalign)
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

### <a name="BKMK_msdyncrm_alignment"></a> msdyncrm_alignment

|Property|Value|
|---|---|
|Description||
|DisplayName|**Alignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_alignment`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_assetsprovider"></a> msdyncrm_assetsprovider

|Property|Value|
|---|---|
|Description||
|DisplayName|**Assets provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_assetsprovider`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyncrm_imagepickerassetsproviders`|

#### msdyncrm_assetsprovider Choices/Options

|Value|Label|
|---|---|
|1|**Digital Assets**|
|2|**Commerce**|

### <a name="BKMK_msdyncrm_backgroundcolor"></a> msdyncrm_backgroundcolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Column background color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_backgroundcolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_backgroundimage"></a> msdyncrm_backgroundimage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Background image**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_backgroundimage`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_columnstyle_msdyncrm_backgroundimage`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_backgroundimagefileid"></a> msdyncrm_backgroundimagefileid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Background image file id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_backgroundimagefileid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_backgroundpositionx"></a> msdyncrm_backgroundpositionx

|Property|Value|
|---|---|
|Description||
|DisplayName|**Alignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_backgroundpositionx`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_backgroundpositiony"></a> msdyncrm_backgroundpositiony

|Property|Value|
|---|---|
|Description||
|DisplayName|**Vertical alignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_backgroundpositiony`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_backgroundsize"></a> msdyncrm_backgroundsize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_backgroundsize`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|164230000|
|GlobalChoiceName|`msdyncrm_backgroundsizetype`|

#### msdyncrm_backgroundsize Choices/Options

|Value|Label|
|---|---|
|164230000|**Fill (Cover)**|
|164230001|**Contain**|

### <a name="BKMK_msdyncrm_bordercolor"></a> msdyncrm_bordercolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Border color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_bordercolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_bordersize"></a> msdyncrm_bordersize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Border size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_bordersize`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_borderstyle"></a> msdyncrm_borderstyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Border style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_borderstyle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_columnstyleId"></a> msdyncrm_columnstyleId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Column style**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_columnstyleid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_emailcolorpalette"></a> msdyncrm_emailcolorpalette

|Property|Value|
|---|---|
|Description|**The colors present in the email body**|
|DisplayName|**Email color palette**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailcolorpalette`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdyncrm_image"></a> msdyncrm_image

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_image`|
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
|Description|**Status of the Column style**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_columnstyle_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Column style**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_columnstyle_statuscode`|

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

- [business_unit_msdyncrm_columnstyle](#BKMK_business_unit_msdyncrm_columnstyle)
- [lk_msdyncrm_columnstyle_createdby](#BKMK_lk_msdyncrm_columnstyle_createdby)
- [lk_msdyncrm_columnstyle_createdonbehalfby](#BKMK_lk_msdyncrm_columnstyle_createdonbehalfby)
- [lk_msdyncrm_columnstyle_modifiedby](#BKMK_lk_msdyncrm_columnstyle_modifiedby)
- [lk_msdyncrm_columnstyle_modifiedonbehalfby](#BKMK_lk_msdyncrm_columnstyle_modifiedonbehalfby)
- [owner_msdyncrm_columnstyle](#BKMK_owner_msdyncrm_columnstyle)
- [team_msdyncrm_columnstyle](#BKMK_team_msdyncrm_columnstyle)
- [user_msdyncrm_columnstyle](#BKMK_user_msdyncrm_columnstyle)

### <a name="BKMK_business_unit_msdyncrm_columnstyle"></a> business_unit_msdyncrm_columnstyle

One-To-Many Relationship: [businessunit business_unit_msdyncrm_columnstyle](businessunit.md#BKMK_business_unit_msdyncrm_columnstyle)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_columnstyle_createdby"></a> lk_msdyncrm_columnstyle_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_columnstyle_createdby](systemuser.md#BKMK_lk_msdyncrm_columnstyle_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_columnstyle_createdonbehalfby"></a> lk_msdyncrm_columnstyle_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_columnstyle_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_columnstyle_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_columnstyle_modifiedby"></a> lk_msdyncrm_columnstyle_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_columnstyle_modifiedby](systemuser.md#BKMK_lk_msdyncrm_columnstyle_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_columnstyle_modifiedonbehalfby"></a> lk_msdyncrm_columnstyle_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_columnstyle_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_columnstyle_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_columnstyle"></a> owner_msdyncrm_columnstyle

One-To-Many Relationship: [owner owner_msdyncrm_columnstyle](owner.md#BKMK_owner_msdyncrm_columnstyle)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_columnstyle"></a> team_msdyncrm_columnstyle

One-To-Many Relationship: [team team_msdyncrm_columnstyle](team.md#BKMK_team_msdyncrm_columnstyle)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_columnstyle"></a> user_msdyncrm_columnstyle

One-To-Many Relationship: [systemuser user_msdyncrm_columnstyle](systemuser.md#BKMK_user_msdyncrm_columnstyle)

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

- [msdyncrm_columnstyle_AsyncOperations](#BKMK_msdyncrm_columnstyle_AsyncOperations)
- [msdyncrm_columnstyle_BulkDeleteFailures](#BKMK_msdyncrm_columnstyle_BulkDeleteFailures)
- [msdyncrm_columnstyle_DuplicateBaseRecord](#BKMK_msdyncrm_columnstyle_DuplicateBaseRecord)
- [msdyncrm_columnstyle_DuplicateMatchingRecord](#BKMK_msdyncrm_columnstyle_DuplicateMatchingRecord)
- [msdyncrm_columnstyle_MailboxTrackingFolders](#BKMK_msdyncrm_columnstyle_MailboxTrackingFolders)
- [msdyncrm_columnstyle_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_columnstyle_PrincipalObjectAttributeAccesses)
- [msdyncrm_columnstyle_ProcessSession](#BKMK_msdyncrm_columnstyle_ProcessSession)
- [msdyncrm_columnstyle_SyncErrors](#BKMK_msdyncrm_columnstyle_SyncErrors)

### <a name="BKMK_msdyncrm_columnstyle_AsyncOperations"></a> msdyncrm_columnstyle_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_columnstyle_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_columnstyle_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_columnstyle_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_columnstyle_BulkDeleteFailures"></a> msdyncrm_columnstyle_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_columnstyle_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_columnstyle_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_columnstyle_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_columnstyle_DuplicateBaseRecord"></a> msdyncrm_columnstyle_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_columnstyle_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_columnstyle_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_columnstyle_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_columnstyle_DuplicateMatchingRecord"></a> msdyncrm_columnstyle_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_columnstyle_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_columnstyle_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_columnstyle_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_columnstyle_MailboxTrackingFolders"></a> msdyncrm_columnstyle_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_columnstyle_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_columnstyle_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_columnstyle_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_columnstyle_PrincipalObjectAttributeAccesses"></a> msdyncrm_columnstyle_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_columnstyle_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_columnstyle_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_columnstyle_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_columnstyle_ProcessSession"></a> msdyncrm_columnstyle_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_columnstyle_ProcessSession](processsession.md#BKMK_msdyncrm_columnstyle_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_columnstyle_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_columnstyle_SyncErrors"></a> msdyncrm_columnstyle_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_columnstyle_SyncErrors](syncerror.md#BKMK_msdyncrm_columnstyle_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_columnstyle_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

