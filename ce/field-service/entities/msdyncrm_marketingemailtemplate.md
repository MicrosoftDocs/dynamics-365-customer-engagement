---
title: "Marketing email template (msdyncrm_marketingemailtemplate) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing email template (msdyncrm_marketingemailtemplate) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing email template (msdyncrm_marketingemailtemplate) table/entity reference

Template for marketing emails

## Messages

The following table lists the messages for the Marketing email template (msdyncrm_marketingemailtemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingemailtemplates(*msdyncrm_marketingemailtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingemailtemplates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingemailtemplates(*msdyncrm_marketingemailtemplateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingemailtemplates(*msdyncrm_marketingemailtemplateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingemailtemplates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingemailtemplates(*msdyncrm_marketingemailtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingemailtemplates(*msdyncrm_marketingemailtemplateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingemailtemplates(*msdyncrm_marketingemailtemplateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing email template (msdyncrm_marketingemailtemplate) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing email template (msdyncrm_marketingemailtemplate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing email template** |
| **DisplayCollectionName** | **Marketing email templates** |
| **SchemaName** | `msdyncrm_marketingemailtemplate` |
| **CollectionSchemaName** | `msdyncrm_marketingemailtemplates` |
| **EntitySetName** | `msdyncrm_marketingemailtemplates`|
| **LogicalName** | `msdyncrm_marketingemailtemplate` |
| **LogicalCollectionName** | `msdyncrm_marketingemailtemplates` |
| **PrimaryIdAttribute** | `msdyncrm_marketingemailtemplateid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_automaticallygeneratetextpart](#BKMK_msdyncrm_automaticallygeneratetextpart)
- [msdyncrm_category](#BKMK_msdyncrm_category)
- [msdyncrm_description](#BKMK_msdyncrm_description)
- [msdyncrm_designerhtml](#BKMK_msdyncrm_designerhtml)
- [msdyncrm_email_contenttype](#BKMK_msdyncrm_email_contenttype)
- [msdyncrm_email_template_market_type_optionset](#BKMK_msdyncrm_email_template_market_type_optionset)
- [msdyncrm_email_template_optimizedfor_optionset](#BKMK_msdyncrm_email_template_optimizedfor_optionset)
- [msdyncrm_email_template_purpose_optionset](#BKMK_msdyncrm_email_template_purpose_optionset)
- [msdyncrm_email_template_visual_style_optionset](#BKMK_msdyncrm_email_template_visual_style_optionset)
- [msdyncrm_emailbody](#BKMK_msdyncrm_emailbody)
- [msdyncrm_FromEmail](#BKMK_msdyncrm_FromEmail)
- [msdyncrm_FromName](#BKMK_msdyncrm_FromName)
- [msdyncrm_Label](#BKMK_msdyncrm_Label)
- [msdyncrm_Language](#BKMK_msdyncrm_Language)
- [msdyncrm_marketingemailtemplateId](#BKMK_msdyncrm_marketingemailtemplateId)
- [msdyncrm_marketingprovided](#BKMK_msdyncrm_marketingprovided)
- [msdyncrm_messagedesignation](#BKMK_msdyncrm_messagedesignation)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_previewhtml](#BKMK_msdyncrm_previewhtml)
- [msdyncrm_previewtext](#BKMK_msdyncrm_previewtext)
- [msdyncrm_ReplyToEmail](#BKMK_msdyncrm_ReplyToEmail)
- [msdyncrm_sourceemailid](#BKMK_msdyncrm_sourceemailid)
- [msdyncrm_subcategory](#BKMK_msdyncrm_subcategory)
- [msdyncrm_subject](#BKMK_msdyncrm_subject)
- [msdyncrm_Tag](#BKMK_msdyncrm_Tag)
- [msdyncrm_textpart](#BKMK_msdyncrm_textpart)
- [msdyncrm_thumbnailimage](#BKMK_msdyncrm_thumbnailimage)
- [msdyncrm_To](#BKMK_msdyncrm_To)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**Thumbnail preview of template (deprecated).**|
|DisplayName|**Thumbnail (deprecated)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|False|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

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

### <a name="BKMK_msdyncrm_automaticallygeneratetextpart"></a> msdyncrm_automaticallygeneratetextpart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Automatically generate text part**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_automaticallygeneratetextpart`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingemailtemplate_msdyncrm_automaticallygeneratetextpart`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_category"></a> msdyncrm_category

|Property|Value|
|---|---|
|Description|**Template tab category**|
|DisplayName|**Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_category`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyncrm_marketingemailtemplate_msdyncrm_tabcategory`|

#### msdyncrm_category Choices/Options

|Value|Label|
|---|---|
|0|**Gallery**|
|1|**Custom templates**|

### <a name="BKMK_msdyncrm_description"></a> msdyncrm_description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_designerhtml"></a> msdyncrm_designerhtml

|Property|Value|
|---|---|
|Description|**Clean email body: HTML with no CSS inlining and no compression**|
|DisplayName|**Designer HTML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_designerhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyncrm_email_contenttype"></a> msdyncrm_email_contenttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_email_contenttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyncrm_email_contenttype`|

#### msdyncrm_email_contenttype Choices/Options

|Value|Label|
|---|---|
|0|**Default**|
|1|**Confirmation request**|

### <a name="BKMK_msdyncrm_email_template_market_type_optionset"></a> msdyncrm_email_template_market_type_optionset

|Property|Value|
|---|---|
|Description|**Market type**|
|DisplayName|**Market type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_email_template_market_type_optionset`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_email_template_market_type`|

#### msdyncrm_email_template_market_type_optionset Choices/Options

|Value|Label|
|---|---|
|0|**B2B**|
|1|**B2C**|
|2|**B2B & B2C**|

### <a name="BKMK_msdyncrm_email_template_optimizedfor_optionset"></a> msdyncrm_email_template_optimizedfor_optionset

|Property|Value|
|---|---|
|Description|**Optimized for**|
|DisplayName|**Optimized for**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_email_template_optimizedfor_optionset`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_email_template_optimized_for`|

#### msdyncrm_email_template_optimizedfor_optionset Choices/Options

|Value|Label|
|---|---|
|0|**Wide reach**|
|1|**Mobile**|
|2|**Desktop**|

### <a name="BKMK_msdyncrm_email_template_purpose_optionset"></a> msdyncrm_email_template_purpose_optionset

|Property|Value|
|---|---|
|Description|**Purpose**|
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_email_template_purpose_optionset`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_email_template_purpose`|

#### msdyncrm_email_template_purpose_optionset Choices/Options

|Value|Label|
|---|---|
|0|**Structural**|
|2|**Announcement**|
|3|**Birthday**|
|4|**Blog promotion**|
|5|**Content promotion**|
|6|**Event countdown**|
|7|**Event or webinar invitation**|
|8|**Follow-up**|
|9|**Holiday greetings**|
|10|**Information**|
|11|**Hospitality**|
|12|**Newsletter**|
|13|**Post purchase**|
|14|**Promotional (up-sell/cross-sell)**|
|15|**Abandoned shopping cart**|
|16|**Thank you**|
|17|**Upcoming event**|
|18|**Welcome**|
|19|**Win-back/re-engage**|
|20|**Feedback request**|
|21|**Anniversary**|
|22|**Lead nurturing**|
|23|**Double opt-in, email based confirmation**|

### <a name="BKMK_msdyncrm_email_template_visual_style_optionset"></a> msdyncrm_email_template_visual_style_optionset

|Property|Value|
|---|---|
|Description|**Visual style**|
|DisplayName|**Visual style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_email_template_visual_style_optionset`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_email_template_visual_style`|

#### msdyncrm_email_template_visual_style_optionset Choices/Options

|Value|Label|
|---|---|
|0|**Other**|
|1|**Light**|
|2|**Colorful**|
|3|**Dark**|

### <a name="BKMK_msdyncrm_emailbody"></a> msdyncrm_emailbody

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email body**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailbody`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyncrm_FromEmail"></a> msdyncrm_FromEmail

|Property|Value|
|---|---|
|Description||
|DisplayName|**From Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fromemail`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_FromName"></a> msdyncrm_FromName

|Property|Value|
|---|---|
|Description||
|DisplayName|**From Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fromname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_Label"></a> msdyncrm_Label

|Property|Value|
|---|---|
|Description||
|DisplayName|**Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_label`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingemailtemplate_default_labels`|

#### msdyncrm_Label Choices/Options

|Value|Label|
|---|---|
|192350000|**New**|
|192350001|**Layout enabled**|

### <a name="BKMK_msdyncrm_Language"></a> msdyncrm_Language

|Property|Value|
|---|---|
|Description||
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_language`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1033|
|GlobalChoiceName|`msdyncrm_templatesupportedlanguages`|

#### msdyncrm_Language Choices/Options

|Value|Label|
|---|---|
|1025|**Arabic (Saudi Arabia)**|
|1026|**Bulgarian (Bulgaria)**|
|1027|**Catalan (Catalan)**|
|1028|**Chinese (Taiwan)**|
|1029|**Czech (Czech Republic)**|
|1030|**Danish**|
|1031|**German**|
|1032|**Greek (Greece)**|
|1033|**English**|
|1035|**Finnish (Finland)**|
|1036|**French**|
|1037|**Hebrew (Israel)**|
|1038|**Hungarian (Hungary)**|
|1040|**Italian**|
|1041|**Japanese**|
|1042|**Korean (Korea)**|
|1043|**Dutch**|
|1044|**Norwegian, Bokmål (Norway)**|
|1045|**Polish (Poland)**|
|1046|**Portuguese (Brazil)**|
|1048|**Romanian (Romania)**|
|1049|**Russian (Russia)**|
|1050|**Croatian (Croatia)**|
|1051|**Slovak (Slovakia)**|
|1053|**Swedish (Sweden)**|
|1054|**Thai (Thailand)**|
|1055|**Turkish (Turkey)**|
|1057|**Indonesian (Indonesia)**|
|1058|**Ukrainian (Ukraine)**|
|1060|**Slovenian (Slovenia)**|
|1061|**Estonian (Estonia)**|
|1062|**Latvian (Latvia)**|
|1063|**Lithuanian (Lithuania)**|
|1066|**Vietnamese (Vietnam)**|
|1069|**Basque (Basque)**|
|1110|**Galician (Galician)**|
|2052|**Chinese (PRC)**|
|2057|**English (Great Britain)**|
|2070|**Portuguese (Portugal)**|
|2074|**Serbian (Latin, Serbia and Montenegro)**|
|3076|**Chinese (Hong Kong S.A.R.)**|
|3081|**English (Australia)**|
|3082|**Spanish**|
|3084|**French (Canada)**|
|3098|**Serbian (Cyrillic, Serbia and Montenegro)**|
|4105|**English (Canada)**|

### <a name="BKMK_msdyncrm_marketingemailtemplateId"></a> msdyncrm_marketingemailtemplateId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing email template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingemailtemplateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_marketingprovided"></a> msdyncrm_marketingprovided

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing provided**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingprovided`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingemailtemplate_msdyncrm_marketingprovided`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_messagedesignation"></a> msdyncrm_messagedesignation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Legal designation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_messagedesignation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyncrm_messagedesignation`|

#### msdyncrm_messagedesignation Choices/Options

|Value|Label|
|---|---|
|0|**Commercial**|
|1|**Transactional**|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the template**|
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
|MaxLength|256|

### <a name="BKMK_msdyncrm_previewhtml"></a> msdyncrm_previewhtml

|Property|Value|
|---|---|
|Description|**Email body used only for preview display purposes**|
|DisplayName|**Preview HTML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_previewhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyncrm_previewtext"></a> msdyncrm_previewtext

|Property|Value|
|---|---|
|Description|**The preview (pre-header) text for marketing email template**|
|DisplayName|**Preview Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_previewtext`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyncrm_ReplyToEmail"></a> msdyncrm_ReplyToEmail

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reply-to address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_replytoemail`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|770|

### <a name="BKMK_msdyncrm_sourceemailid"></a> msdyncrm_sourceemailid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source email ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sourceemailid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_subcategory"></a> msdyncrm_subcategory

|Property|Value|
|---|---|
|Description|**Template subcategory**|
|DisplayName|**Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_subcategory`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingemailtemplate_msdyncrm_subcategory`|

#### msdyncrm_subcategory Choices/Options

|Value|Label|
|---|---|
|0|**New product**|
|1|**Deals**|
|2|**Follow-up**|
|3|**Events/Webinars**|
|4|**Informational**|
|5|**Transactional**|
|6|**Layouts**|

### <a name="BKMK_msdyncrm_subject"></a> msdyncrm_subject

|Property|Value|
|---|---|
|Description||
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_subject`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyncrm_Tag"></a> msdyncrm_Tag

|Property|Value|
|---|---|
|Description|**deprecated**|
|DisplayName|**Tag**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_tag`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_default_template_tags`|

#### msdyncrm_Tag Choices/Options

|Value|Label|
|---|---|
|192350000|**New**|
|192350001|**Layout enabled**|

### <a name="BKMK_msdyncrm_textpart"></a> msdyncrm_textpart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plain text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_textpart`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyncrm_thumbnailimage"></a> msdyncrm_thumbnailimage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Thumbnail**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_thumbnailimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|True|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_msdyncrm_To"></a> msdyncrm_To

|Property|Value|
|---|---|
|Description||
|DisplayName|**To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_to`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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
|Description|**Status of the marketing email template**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingemailtemplate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350001<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Marketing email template status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingemailtemplate_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|192350000|Label: **Draft**<br />State:0<br />TransitionData: None|
|192350001|Label: **Live**<br />State:0<br />TransitionData: None|

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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyncrm_formtosave](#BKMK_msdyncrm_formtosave)
- [msdyncrm_thumbnailimage_Timestamp](#BKMK_msdyncrm_thumbnailimage_Timestamp)
- [msdyncrm_thumbnailimage_URL](#BKMK_msdyncrm_thumbnailimage_URL)
- [msdyncrm_thumbnailimageId](#BKMK_msdyncrm_thumbnailimageId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this.**|
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
|Description|**Indicates the person who created this for another person.**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who modified this.**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_formtosave"></a> msdyncrm_formtosave

|Property|Value|
|---|---|
|Description|**Form to save**|
|DisplayName|**Form to save**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formtosave`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingemailtemplate_formtosave`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_thumbnailimage_Timestamp"></a> msdyncrm_thumbnailimage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_thumbnailimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdyncrm_thumbnailimage_URL"></a> msdyncrm_thumbnailimage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_thumbnailimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_thumbnailimageId"></a> msdyncrm_thumbnailimageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_thumbnailimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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
|Description|**Indicates the business unit that owns this.**|
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
|Description|**Indicates the team that owns this.**|
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
|Description|**Indicates the team that owns this.**|
|DisplayName|**Owning user**|
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

- [business_unit_msdyncrm_marketingemailtemplate](#BKMK_business_unit_msdyncrm_marketingemailtemplate)
- [lk_msdyncrm_marketingemailtemplate_createdby](#BKMK_lk_msdyncrm_marketingemailtemplate_createdby)
- [lk_msdyncrm_marketingemailtemplate_createdonbehalfby](#BKMK_lk_msdyncrm_marketingemailtemplate_createdonbehalfby)
- [lk_msdyncrm_marketingemailtemplate_modifiedby](#BKMK_lk_msdyncrm_marketingemailtemplate_modifiedby)
- [lk_msdyncrm_marketingemailtemplate_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingemailtemplate_modifiedonbehalfby)
- [owner_msdyncrm_marketingemailtemplate](#BKMK_owner_msdyncrm_marketingemailtemplate)
- [team_msdyncrm_marketingemailtemplate](#BKMK_team_msdyncrm_marketingemailtemplate)
- [user_msdyncrm_marketingemailtemplate](#BKMK_user_msdyncrm_marketingemailtemplate)

### <a name="BKMK_business_unit_msdyncrm_marketingemailtemplate"></a> business_unit_msdyncrm_marketingemailtemplate

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingemailtemplate](businessunit.md#BKMK_business_unit_msdyncrm_marketingemailtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailtemplate_createdby"></a> lk_msdyncrm_marketingemailtemplate_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailtemplate_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingemailtemplate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailtemplate_createdonbehalfby"></a> lk_msdyncrm_marketingemailtemplate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailtemplate_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingemailtemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailtemplate_modifiedby"></a> lk_msdyncrm_marketingemailtemplate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailtemplate_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingemailtemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailtemplate_modifiedonbehalfby"></a> lk_msdyncrm_marketingemailtemplate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailtemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingemailtemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingemailtemplate"></a> owner_msdyncrm_marketingemailtemplate

One-To-Many Relationship: [owner owner_msdyncrm_marketingemailtemplate](owner.md#BKMK_owner_msdyncrm_marketingemailtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingemailtemplate"></a> team_msdyncrm_marketingemailtemplate

One-To-Many Relationship: [team team_msdyncrm_marketingemailtemplate](team.md#BKMK_team_msdyncrm_marketingemailtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingemailtemplate"></a> user_msdyncrm_marketingemailtemplate

One-To-Many Relationship: [systemuser user_msdyncrm_marketingemailtemplate](systemuser.md#BKMK_user_msdyncrm_marketingemailtemplate)

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

- [msdyncrm_marketingemailtemplate_AsyncOperations](#BKMK_msdyncrm_marketingemailtemplate_AsyncOperations)
- [msdyncrm_marketingemailtemplate_BulkDeleteFailures](#BKMK_msdyncrm_marketingemailtemplate_BulkDeleteFailures)
- [msdyncrm_marketingemailtemplate_MailboxTrackingFolders](#BKMK_msdyncrm_marketingemailtemplate_MailboxTrackingFolders)
- [msdyncrm_marketingemailtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingemailtemplate_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingemailtemplate_ProcessSession](#BKMK_msdyncrm_marketingemailtemplate_ProcessSession)
- [msdyncrm_marketingemailtemplate_SyncErrors](#BKMK_msdyncrm_marketingemailtemplate_SyncErrors)
- [msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_](#BKMK_msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_)

### <a name="BKMK_msdyncrm_marketingemailtemplate_AsyncOperations"></a> msdyncrm_marketingemailtemplate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingemailtemplate_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingemailtemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtemplate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtemplate_BulkDeleteFailures"></a> msdyncrm_marketingemailtemplate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingemailtemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingemailtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtemplate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtemplate_MailboxTrackingFolders"></a> msdyncrm_marketingemailtemplate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingemailtemplate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingemailtemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtemplate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtemplate_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingemailtemplate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingemailtemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingemailtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtemplate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtemplate_ProcessSession"></a> msdyncrm_marketingemailtemplate_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingemailtemplate_ProcessSession](processsession.md#BKMK_msdyncrm_marketingemailtemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtemplate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailtemplate_SyncErrors"></a> msdyncrm_marketingemailtemplate_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingemailtemplate_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingemailtemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailtemplate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_"></a> msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_

Many-To-One Relationship: [msdyncrm_marketingemail msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_](msdyncrm_marketingemail.md#BKMK_msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemail`|
|ReferencingAttribute|`msdyncrm_templateid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

