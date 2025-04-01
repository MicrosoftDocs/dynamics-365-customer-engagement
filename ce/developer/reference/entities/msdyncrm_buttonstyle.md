---
title: "Button style (msdyncrm_buttonstyle) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Button style (msdyncrm_buttonstyle) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Button style (msdyncrm_buttonstyle) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Button style (msdyncrm_buttonstyle) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_buttonstyles(*msdyncrm_buttonstyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyncrm_buttonstyles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_buttonstyles(*msdyncrm_buttonstyleid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_buttonstyles(*msdyncrm_buttonstyleid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_buttonstyles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_buttonstyles(*msdyncrm_buttonstyleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_buttonstyles(*msdyncrm_buttonstyleid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_buttonstyles(*msdyncrm_buttonstyleid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Button style (msdyncrm_buttonstyle) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Button style** |
| **DisplayCollectionName** | **Buttons style** |
| **SchemaName** | `msdyncrm_buttonstyle` |
| **CollectionSchemaName** | `msdyncrm_buttonstyles` |
| **EntitySetName** | `msdyncrm_buttonstyles`|
| **LogicalName** | `msdyncrm_buttonstyle` |
| **LogicalCollectionName** | `msdyncrm_buttonstyles` |
| **PrimaryIdAttribute** | `msdyncrm_buttonstyleid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_alignment](#BKMK_msdyncrm_alignment)
- [msdyncrm_autowidth](#BKMK_msdyncrm_autowidth)
- [msdyncrm_bordercolor](#BKMK_msdyncrm_bordercolor)
- [msdyncrm_bordersize](#BKMK_msdyncrm_bordersize)
- [msdyncrm_borderstyle](#BKMK_msdyncrm_borderstyle)
- [msdyncrm_buttoncolor](#BKMK_msdyncrm_buttoncolor)
- [msdyncrm_buttonstyleId](#BKMK_msdyncrm_buttonstyleId)
- [msdyncrm_buttontext](#BKMK_msdyncrm_buttontext)
- [msdyncrm_emailcolorpalette](#BKMK_msdyncrm_emailcolorpalette)
- [msdyncrm_fittotext](#BKMK_msdyncrm_fittotext)
- [msdyncrm_fontfamily](#BKMK_msdyncrm_fontfamily)
- [msdyncrm_fontitalicstyle](#BKMK_msdyncrm_fontitalicstyle)
- [msdyncrm_fontsize](#BKMK_msdyncrm_fontsize)
- [msdyncrm_fontweight](#BKMK_msdyncrm_fontweight)
- [msdyncrm_height](#BKMK_msdyncrm_height)
- [msdyncrm_linkto](#BKMK_msdyncrm_linkto)
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
- [msdyncrm_target](#BKMK_msdyncrm_target)
- [msdyncrm_textdecoration](#BKMK_msdyncrm_textdecoration)
- [msdyncrm_textfontstyle](#BKMK_msdyncrm_textfontstyle)
- [msdyncrm_textstylecolor](#BKMK_msdyncrm_textstylecolor)
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
|GlobalChoiceName|`msdyncrm_buttonstyle_msdyncrm_autowidth`|
|DefaultValue|False|
|True Label|On|
|False Label|Off|

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

### <a name="BKMK_msdyncrm_buttoncolor"></a> msdyncrm_buttoncolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Button color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_buttoncolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_buttonstyleId"></a> msdyncrm_buttonstyleId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Button style**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_buttonstyleid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_buttontext"></a> msdyncrm_buttontext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Button text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_buttontext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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

### <a name="BKMK_msdyncrm_fittotext"></a> msdyncrm_fittotext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fit to text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fittotext`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_buttonstyle_msdyncrm_fittotext`|
|DefaultValue|False|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdyncrm_fontfamily"></a> msdyncrm_fontfamily

|Property|Value|
|---|---|
|Description||
|DisplayName|**Font family**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fontfamily`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_fontitalicstyle"></a> msdyncrm_fontitalicstyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Font italic style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fontitalicstyle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_fontsize"></a> msdyncrm_fontsize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Font size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fontsize`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_fontweight"></a> msdyncrm_fontweight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Font weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fontweight`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyncrm_linkto"></a> msdyncrm_linkto

|Property|Value|
|---|---|
|Description||
|DisplayName|**Link to**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkto`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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

### <a name="BKMK_msdyncrm_target"></a> msdyncrm_target

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_target`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|164230000|
|GlobalChoiceName|`msdyncrm_targettype`|

#### msdyncrm_target Choices/Options

|Value|Label|
|---|---|
|164230000|**_self**|
|164230001|**_blank**|
|164230002|**_parent**|
|164230003|**_top**|

### <a name="BKMK_msdyncrm_textdecoration"></a> msdyncrm_textdecoration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text decoration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textdecoration`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_textfontstyle"></a> msdyncrm_textfontstyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text font style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textfontstyle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_textstylecolor"></a> msdyncrm_textstylecolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text style color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textstylecolor`|
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
|GlobalChoiceName|`msdyncrm_buttonstyle_msdyncrm_tracking`|
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
|DisplayName|**Width**|
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
|Description|**Status of the Button style**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_buttonstyle_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Button style**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_buttonstyle_statuscode`|

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

- [business_unit_msdyncrm_buttonstyle](#BKMK_business_unit_msdyncrm_buttonstyle)
- [lk_msdyncrm_buttonstyle_createdby](#BKMK_lk_msdyncrm_buttonstyle_createdby)
- [lk_msdyncrm_buttonstyle_createdonbehalfby](#BKMK_lk_msdyncrm_buttonstyle_createdonbehalfby)
- [lk_msdyncrm_buttonstyle_modifiedby](#BKMK_lk_msdyncrm_buttonstyle_modifiedby)
- [lk_msdyncrm_buttonstyle_modifiedonbehalfby](#BKMK_lk_msdyncrm_buttonstyle_modifiedonbehalfby)
- [owner_msdyncrm_buttonstyle](#BKMK_owner_msdyncrm_buttonstyle)
- [team_msdyncrm_buttonstyle](#BKMK_team_msdyncrm_buttonstyle)
- [user_msdyncrm_buttonstyle](#BKMK_user_msdyncrm_buttonstyle)

### <a name="BKMK_business_unit_msdyncrm_buttonstyle"></a> business_unit_msdyncrm_buttonstyle

One-To-Many Relationship: [businessunit business_unit_msdyncrm_buttonstyle](businessunit.md#BKMK_business_unit_msdyncrm_buttonstyle)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_buttonstyle_createdby"></a> lk_msdyncrm_buttonstyle_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_buttonstyle_createdby](systemuser.md#BKMK_lk_msdyncrm_buttonstyle_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_buttonstyle_createdonbehalfby"></a> lk_msdyncrm_buttonstyle_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_buttonstyle_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_buttonstyle_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_buttonstyle_modifiedby"></a> lk_msdyncrm_buttonstyle_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_buttonstyle_modifiedby](systemuser.md#BKMK_lk_msdyncrm_buttonstyle_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_buttonstyle_modifiedonbehalfby"></a> lk_msdyncrm_buttonstyle_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_buttonstyle_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_buttonstyle_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_buttonstyle"></a> owner_msdyncrm_buttonstyle

One-To-Many Relationship: [owner owner_msdyncrm_buttonstyle](owner.md#BKMK_owner_msdyncrm_buttonstyle)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_buttonstyle"></a> team_msdyncrm_buttonstyle

One-To-Many Relationship: [team team_msdyncrm_buttonstyle](team.md#BKMK_team_msdyncrm_buttonstyle)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_buttonstyle"></a> user_msdyncrm_buttonstyle

One-To-Many Relationship: [systemuser user_msdyncrm_buttonstyle](systemuser.md#BKMK_user_msdyncrm_buttonstyle)

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

- [msdyncrm_buttonstyle_AsyncOperations](#BKMK_msdyncrm_buttonstyle_AsyncOperations)
- [msdyncrm_buttonstyle_BulkDeleteFailures](#BKMK_msdyncrm_buttonstyle_BulkDeleteFailures)
- [msdyncrm_buttonstyle_DuplicateBaseRecord](#BKMK_msdyncrm_buttonstyle_DuplicateBaseRecord)
- [msdyncrm_buttonstyle_DuplicateMatchingRecord](#BKMK_msdyncrm_buttonstyle_DuplicateMatchingRecord)
- [msdyncrm_buttonstyle_MailboxTrackingFolders](#BKMK_msdyncrm_buttonstyle_MailboxTrackingFolders)
- [msdyncrm_buttonstyle_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_buttonstyle_PrincipalObjectAttributeAccesses)
- [msdyncrm_buttonstyle_ProcessSession](#BKMK_msdyncrm_buttonstyle_ProcessSession)
- [msdyncrm_buttonstyle_SyncErrors](#BKMK_msdyncrm_buttonstyle_SyncErrors)

### <a name="BKMK_msdyncrm_buttonstyle_AsyncOperations"></a> msdyncrm_buttonstyle_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_buttonstyle_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_buttonstyle_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_buttonstyle_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_buttonstyle_BulkDeleteFailures"></a> msdyncrm_buttonstyle_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_buttonstyle_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_buttonstyle_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_buttonstyle_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_buttonstyle_DuplicateBaseRecord"></a> msdyncrm_buttonstyle_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_buttonstyle_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_buttonstyle_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_buttonstyle_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_buttonstyle_DuplicateMatchingRecord"></a> msdyncrm_buttonstyle_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_buttonstyle_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_buttonstyle_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_buttonstyle_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_buttonstyle_MailboxTrackingFolders"></a> msdyncrm_buttonstyle_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_buttonstyle_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_buttonstyle_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_buttonstyle_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_buttonstyle_PrincipalObjectAttributeAccesses"></a> msdyncrm_buttonstyle_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_buttonstyle_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_buttonstyle_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_buttonstyle_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_buttonstyle_ProcessSession"></a> msdyncrm_buttonstyle_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_buttonstyle_ProcessSession](processsession.md#BKMK_msdyncrm_buttonstyle_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_buttonstyle_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_buttonstyle_SyncErrors"></a> msdyncrm_buttonstyle_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_buttonstyle_SyncErrors](syncerror.md#BKMK_msdyncrm_buttonstyle_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_buttonstyle_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

