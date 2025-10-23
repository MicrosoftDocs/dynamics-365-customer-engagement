---
title: "General styles (msdyncrm_generalstyles) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the General styles (msdyncrm_generalstyles) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# General styles (msdyncrm_generalstyles) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the General styles (msdyncrm_generalstyles) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_generalstyleses(*msdyncrm_generalstylesid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyncrm_generalstyleses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_generalstyleses(*msdyncrm_generalstylesid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_generalstyleses(*msdyncrm_generalstylesid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_generalstyleses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_generalstyleses(*msdyncrm_generalstylesid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_generalstyleses(*msdyncrm_generalstylesid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_generalstyleses(*msdyncrm_generalstylesid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the General styles (msdyncrm_generalstyles) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **General styles** |
| **DisplayCollectionName** | **General styles** |
| **SchemaName** | `msdyncrm_generalstyles` |
| **CollectionSchemaName** | `msdyncrm_generalstyleses` |
| **EntitySetName** | `msdyncrm_generalstyleses`|
| **LogicalName** | `msdyncrm_generalstyles` |
| **LogicalCollectionName** | `msdyncrm_generalstyleses` |
| **PrimaryIdAttribute** | `msdyncrm_generalstylesid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_bordercolor](#BKMK_msdyncrm_bordercolor)
- [msdyncrm_bordersize](#BKMK_msdyncrm_bordersize)
- [msdyncrm_borderstyle](#BKMK_msdyncrm_borderstyle)
- [msdyncrm_buttoncolor](#BKMK_msdyncrm_buttoncolor)
- [msdyncrm_dividercolor](#BKMK_msdyncrm_dividercolor)
- [msdyncrm_dividerlinestyle](#BKMK_msdyncrm_dividerlinestyle)
- [msdyncrm_dividersize](#BKMK_msdyncrm_dividersize)
- [msdyncrm_dividerstyle](#BKMK_msdyncrm_dividerstyle)
- [msdyncrm_emailcolorpalette](#BKMK_msdyncrm_emailcolorpalette)
- [msdyncrm_emailwidth](#BKMK_msdyncrm_emailwidth)
- [msdyncrm_font](#BKMK_msdyncrm_font)
- [msdyncrm_fontsize](#BKMK_msdyncrm_fontsize)
- [msdyncrm_generalstylesId](#BKMK_msdyncrm_generalstylesId)
- [msdyncrm_heading1color](#BKMK_msdyncrm_heading1color)
- [msdyncrm_heading1font](#BKMK_msdyncrm_heading1font)
- [msdyncrm_heading1size](#BKMK_msdyncrm_heading1size)
- [msdyncrm_heading2color](#BKMK_msdyncrm_heading2color)
- [msdyncrm_heading2font](#BKMK_msdyncrm_heading2font)
- [msdyncrm_heading2size](#BKMK_msdyncrm_heading2size)
- [msdyncrm_heading3color](#BKMK_msdyncrm_heading3color)
- [msdyncrm_heading3font](#BKMK_msdyncrm_heading3font)
- [msdyncrm_heading3size](#BKMK_msdyncrm_heading3size)
- [msdyncrm_innerbackgroundcolor](#BKMK_msdyncrm_innerbackgroundcolor)
- [msdyncrm_lineheight](#BKMK_msdyncrm_lineheight)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_outerbackgroundcolor](#BKMK_msdyncrm_outerbackgroundcolor)
- [msdyncrm_paragraphcolor](#BKMK_msdyncrm_paragraphcolor)
- [msdyncrm_paragraphfont](#BKMK_msdyncrm_paragraphfont)
- [msdyncrm_paragraphsize](#BKMK_msdyncrm_paragraphsize)
- [msdyncrm_plaintextfullwidth](#BKMK_msdyncrm_plaintextfullwidth)
- [msdyncrm_roundedcorners](#BKMK_msdyncrm_roundedcorners)
- [msdyncrm_textdecoration](#BKMK_msdyncrm_textdecoration)
- [msdyncrm_textfontweight](#BKMK_msdyncrm_textfontweight)
- [msdyncrm_textitalicstyle](#BKMK_msdyncrm_textitalicstyle)
- [msdyncrm_textlinkfontweight](#BKMK_msdyncrm_textlinkfontweight)
- [msdyncrm_textlinkitalicstyle](#BKMK_msdyncrm_textlinkitalicstyle)
- [msdyncrm_textlinkstylecolor](#BKMK_msdyncrm_textlinkstylecolor)
- [msdyncrm_textlinkstylefont](#BKMK_msdyncrm_textlinkstylefont)
- [msdyncrm_textlinktextdecoration](#BKMK_msdyncrm_textlinktextdecoration)
- [msdyncrm_textstylecolor](#BKMK_msdyncrm_textstylecolor)
- [msdyncrm_textstylefont](#BKMK_msdyncrm_textstylefont)
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

### <a name="BKMK_msdyncrm_dividercolor"></a> msdyncrm_dividercolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Divider color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_dividercolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_dividerlinestyle"></a> msdyncrm_dividerlinestyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Divider line style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_dividerlinestyle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_dividersize"></a> msdyncrm_dividersize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Divider size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_dividersize`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_dividerstyle"></a> msdyncrm_dividerstyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Divider style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_dividerstyle`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|164230000|
|GlobalChoiceName|`msdyncrm_borderstyletype`|

#### msdyncrm_dividerstyle Choices/Options

|Value|Label|
|---|---|
|164230000|**None**|
|164230001|**Solid**|
|164230002|**Dotted**|
|164230003|**Dashed**|
|164230004|**Double**|

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

### <a name="BKMK_msdyncrm_emailwidth"></a> msdyncrm_emailwidth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailwidth`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_font"></a> msdyncrm_font

|Property|Value|
|---|---|
|Description||
|DisplayName|**Font**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_font`|
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

### <a name="BKMK_msdyncrm_generalstylesId"></a> msdyncrm_generalstylesId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**General styles**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_generalstylesid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_heading1color"></a> msdyncrm_heading1color

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 1 color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading1color`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_heading1font"></a> msdyncrm_heading1font

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 1 font**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading1font`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_heading1size"></a> msdyncrm_heading1size

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 1 size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading1size`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_heading2color"></a> msdyncrm_heading2color

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 2 color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading2color`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_heading2font"></a> msdyncrm_heading2font

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 2 font**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading2font`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_heading2size"></a> msdyncrm_heading2size

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 2 size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading2size`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_heading3color"></a> msdyncrm_heading3color

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 3 color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading3color`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_heading3font"></a> msdyncrm_heading3font

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 3 font**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading3font`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_heading3size"></a> msdyncrm_heading3size

|Property|Value|
|---|---|
|Description||
|DisplayName|**Heading 3 size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_heading3size`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_innerbackgroundcolor"></a> msdyncrm_innerbackgroundcolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Inner background color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_innerbackgroundcolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_lineheight"></a> msdyncrm_lineheight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Line height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lineheight`|
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

### <a name="BKMK_msdyncrm_outerbackgroundcolor"></a> msdyncrm_outerbackgroundcolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Outer background color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_outerbackgroundcolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_paragraphcolor"></a> msdyncrm_paragraphcolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Paragraph color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_paragraphcolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_paragraphfont"></a> msdyncrm_paragraphfont

|Property|Value|
|---|---|
|Description||
|DisplayName|**Paragraph font**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_paragraphfont`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_paragraphsize"></a> msdyncrm_paragraphsize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Paragraph size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_paragraphsize`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_plaintextfullwidth"></a> msdyncrm_plaintextfullwidth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plain text full width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_plaintextfullwidth`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_generalstyles_msdyncrm_plaintextfullwidth`|
|DefaultValue|False|
|True Label|On|
|False Label|Off|

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

### <a name="BKMK_msdyncrm_textfontweight"></a> msdyncrm_textfontweight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text font weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textfontweight`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_textitalicstyle"></a> msdyncrm_textitalicstyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text italic style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textitalicstyle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_textlinkfontweight"></a> msdyncrm_textlinkfontweight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text link font weight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textlinkfontweight`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_textlinkitalicstyle"></a> msdyncrm_textlinkitalicstyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text link italic style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textlinkitalicstyle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_textlinkstylecolor"></a> msdyncrm_textlinkstylecolor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text link style color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textlinkstylecolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_textlinkstylefont"></a> msdyncrm_textlinkstylefont

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text link style font**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textlinkstylefont`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_textlinktextdecoration"></a> msdyncrm_textlinktextdecoration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text link text decoration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textlinktextdecoration`|
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

### <a name="BKMK_msdyncrm_textstylefont"></a> msdyncrm_textstylefont

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text style font**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textstylefont`|
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
|Description|**Status of the General styles**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_generalstyles_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the General styles**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_generalstyles_statuscode`|

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

- [business_unit_msdyncrm_generalstyles](#BKMK_business_unit_msdyncrm_generalstyles)
- [lk_msdyncrm_generalstyles_createdby](#BKMK_lk_msdyncrm_generalstyles_createdby)
- [lk_msdyncrm_generalstyles_createdonbehalfby](#BKMK_lk_msdyncrm_generalstyles_createdonbehalfby)
- [lk_msdyncrm_generalstyles_modifiedby](#BKMK_lk_msdyncrm_generalstyles_modifiedby)
- [lk_msdyncrm_generalstyles_modifiedonbehalfby](#BKMK_lk_msdyncrm_generalstyles_modifiedonbehalfby)
- [owner_msdyncrm_generalstyles](#BKMK_owner_msdyncrm_generalstyles)
- [team_msdyncrm_generalstyles](#BKMK_team_msdyncrm_generalstyles)
- [user_msdyncrm_generalstyles](#BKMK_user_msdyncrm_generalstyles)

### <a name="BKMK_business_unit_msdyncrm_generalstyles"></a> business_unit_msdyncrm_generalstyles

One-To-Many Relationship: [businessunit business_unit_msdyncrm_generalstyles](businessunit.md#BKMK_business_unit_msdyncrm_generalstyles)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_generalstyles_createdby"></a> lk_msdyncrm_generalstyles_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_generalstyles_createdby](systemuser.md#BKMK_lk_msdyncrm_generalstyles_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_generalstyles_createdonbehalfby"></a> lk_msdyncrm_generalstyles_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_generalstyles_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_generalstyles_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_generalstyles_modifiedby"></a> lk_msdyncrm_generalstyles_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_generalstyles_modifiedby](systemuser.md#BKMK_lk_msdyncrm_generalstyles_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_generalstyles_modifiedonbehalfby"></a> lk_msdyncrm_generalstyles_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_generalstyles_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_generalstyles_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_generalstyles"></a> owner_msdyncrm_generalstyles

One-To-Many Relationship: [owner owner_msdyncrm_generalstyles](owner.md#BKMK_owner_msdyncrm_generalstyles)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_generalstyles"></a> team_msdyncrm_generalstyles

One-To-Many Relationship: [team team_msdyncrm_generalstyles](team.md#BKMK_team_msdyncrm_generalstyles)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_generalstyles"></a> user_msdyncrm_generalstyles

One-To-Many Relationship: [systemuser user_msdyncrm_generalstyles](systemuser.md#BKMK_user_msdyncrm_generalstyles)

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

- [msdyncrm_generalstyles_AsyncOperations](#BKMK_msdyncrm_generalstyles_AsyncOperations)
- [msdyncrm_generalstyles_BulkDeleteFailures](#BKMK_msdyncrm_generalstyles_BulkDeleteFailures)
- [msdyncrm_generalstyles_DuplicateBaseRecord](#BKMK_msdyncrm_generalstyles_DuplicateBaseRecord)
- [msdyncrm_generalstyles_DuplicateMatchingRecord](#BKMK_msdyncrm_generalstyles_DuplicateMatchingRecord)
- [msdyncrm_generalstyles_MailboxTrackingFolders](#BKMK_msdyncrm_generalstyles_MailboxTrackingFolders)
- [msdyncrm_generalstyles_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_generalstyles_PrincipalObjectAttributeAccesses)
- [msdyncrm_generalstyles_ProcessSession](#BKMK_msdyncrm_generalstyles_ProcessSession)
- [msdyncrm_generalstyles_SyncErrors](#BKMK_msdyncrm_generalstyles_SyncErrors)

### <a name="BKMK_msdyncrm_generalstyles_AsyncOperations"></a> msdyncrm_generalstyles_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_generalstyles_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_generalstyles_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_generalstyles_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_generalstyles_BulkDeleteFailures"></a> msdyncrm_generalstyles_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_generalstyles_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_generalstyles_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_generalstyles_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_generalstyles_DuplicateBaseRecord"></a> msdyncrm_generalstyles_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_generalstyles_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_generalstyles_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_generalstyles_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_generalstyles_DuplicateMatchingRecord"></a> msdyncrm_generalstyles_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_generalstyles_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_generalstyles_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_generalstyles_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_generalstyles_MailboxTrackingFolders"></a> msdyncrm_generalstyles_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_generalstyles_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_generalstyles_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_generalstyles_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_generalstyles_PrincipalObjectAttributeAccesses"></a> msdyncrm_generalstyles_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_generalstyles_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_generalstyles_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_generalstyles_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_generalstyles_ProcessSession"></a> msdyncrm_generalstyles_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_generalstyles_ProcessSession](processsession.md#BKMK_msdyncrm_generalstyles_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_generalstyles_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_generalstyles_SyncErrors"></a> msdyncrm_generalstyles_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_generalstyles_SyncErrors](syncerror.md#BKMK_msdyncrm_generalstyles_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_generalstyles_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

