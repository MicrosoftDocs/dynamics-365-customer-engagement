---
title: "Marketing email (msdyncrm_marketingemail) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing email (msdyncrm_marketingemail) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing email (msdyncrm_marketingemail) table/entity reference



## Messages

The following table lists the messages for the Marketing email (msdyncrm_marketingemail) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingemails(*msdyncrm_marketingemailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingemails<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingemails(*msdyncrm_marketingemailid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingemails(*msdyncrm_marketingemailid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingemails<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingemails(*msdyncrm_marketingemailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingemails(*msdyncrm_marketingemailid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingemails(*msdyncrm_marketingemailid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing email (msdyncrm_marketingemail) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing email (msdyncrm_marketingemail) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing email** |
| **DisplayCollectionName** | **Marketing emails** |
| **SchemaName** | `msdyncrm_marketingemail` |
| **CollectionSchemaName** | `msdyncrm_marketingemails` |
| **EntitySetName** | `msdyncrm_marketingemails`|
| **LogicalName** | `msdyncrm_marketingemail` |
| **LogicalCollectionName** | `msdyncrm_marketingemails` |
| **PrimaryIdAttribute** | `msdyncrm_marketingemailid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_automaticallygeneratetextpart](#BKMK_msdyncrm_automaticallygeneratetextpart)
- [msdyncrm_ClickMap](#BKMK_msdyncrm_ClickMap)
- [msdyncrm_contentsettingscompanyaddress](#BKMK_msdyncrm_contentsettingscompanyaddress)
- [msdyncrm_Description](#BKMK_msdyncrm_Description)
- [msdyncrm_designerhtml](#BKMK_msdyncrm_designerhtml)
- [msdyncrm_email_contentlanguage](#BKMK_msdyncrm_email_contentlanguage)
- [msdyncrm_email_contenttype](#BKMK_msdyncrm_email_contenttype)
- [msdyncrm_emailbody](#BKMK_msdyncrm_emailbody)
- [msdyncrm_FromEmail](#BKMK_msdyncrm_FromEmail)
- [msdyncrm_FromName](#BKMK_msdyncrm_FromName)
- [msdyncrm_FromUser](#BKMK_msdyncrm_FromUser)
- [msdyncrm_insights_placeholder](#BKMK_msdyncrm_insights_placeholder)
- [msdyncrm_Istemplategalleryneeded](#BKMK_msdyncrm_Istemplategalleryneeded)
- [msdyncrm_marketingemailId](#BKMK_msdyncrm_marketingemailId)
- [msdyncrm_messagedesignation](#BKMK_msdyncrm_messagedesignation)
- [msdyncrm_Name](#BKMK_msdyncrm_Name)
- [msdyncrm_previewhtml](#BKMK_msdyncrm_previewhtml)
- [msdyncrm_previewtext](#BKMK_msdyncrm_previewtext)
- [msdyncrm_ReplyToEmail](#BKMK_msdyncrm_ReplyToEmail)
- [msdyncrm_subject](#BKMK_msdyncrm_subject)
- [msdyncrm_TemplateId](#BKMK_msdyncrm_TemplateId)
- [msdyncrm_testconfiguration](#BKMK_msdyncrm_testconfiguration)
- [msdyncrm_textpart](#BKMK_msdyncrm_textpart)
- [msdyncrm_To](#BKMK_msdyncrm_To)
- [msdyncrm_uicentityid](#BKMK_msdyncrm_uicentityid)
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
|Description|**Thumbnail preview of email.**|
|DisplayName|**Thumbnail**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
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
|DisplayName|**Automatically generate plain text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_automaticallygeneratetextpart`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingemail_msdyncrm_automaticallygeneratetextpart`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_ClickMap"></a> msdyncrm_ClickMap

|Property|Value|
|---|---|
|Description||
|DisplayName|**Click map**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_clickmap`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_contentsettingscompanyaddress"></a> msdyncrm_contentsettingscompanyaddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Company address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contentsettingscompanyaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_Description"></a> msdyncrm_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20000|

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

### <a name="BKMK_msdyncrm_email_contentlanguage"></a> msdyncrm_email_contentlanguage

|Property|Value|
|---|---|
|Description|**The language to be used for email content.**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_email_contentlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1033|
|GlobalChoiceName|`msdyncrm_templatesupportedlanguages`|

#### msdyncrm_email_contentlanguage Choices/Options

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

### <a name="BKMK_msdyncrm_emailbody"></a> msdyncrm_emailbody

|Property|Value|
|---|---|
|Description|**The body of the email**|
|DisplayName|**Email body**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailbody`|
|RequiredLevel|None|
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
|DisplayName|**Email from address**|
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
|DisplayName|**Email from name**|
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

### <a name="BKMK_msdyncrm_FromUser"></a> msdyncrm_FromUser

|Property|Value|
|---|---|
|Description||
|DisplayName|**From user**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_fromuser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_insights_placeholder"></a> msdyncrm_insights_placeholder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_insights_placeholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_Istemplategalleryneeded"></a> msdyncrm_Istemplategalleryneeded

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is template gallery needed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_istemplategalleryneeded`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingemail_msdyncrm_istemplategalleryneeded`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_marketingemailId"></a> msdyncrm_marketingemailId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing email**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingemailid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdyncrm_Name"></a> msdyncrm_Name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|200|

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
|Description|**The preview (pre-header) text for marketing email**|
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

### <a name="BKMK_msdyncrm_subject"></a> msdyncrm_subject

|Property|Value|
|---|---|
|Description|**The subject of the marketing email**|
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

### <a name="BKMK_msdyncrm_TemplateId"></a> msdyncrm_TemplateId

|Property|Value|
|---|---|
|Description|**Template for the email**|
|DisplayName|**Email template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_templateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingemailtemplate|

### <a name="BKMK_msdyncrm_testconfiguration"></a> msdyncrm_testconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Test Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_testconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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

### <a name="BKMK_msdyncrm_uicentityid"></a> msdyncrm_uicentityid

|Property|Value|
|---|---|
|Description||
|DisplayName|**UIC entity ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_uicentityid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the marketing email**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingemail_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 192350004<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Marketing email status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingemail_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350000|Label: **Draft**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350000" tostatusid="192350006" /><allowedtransition sourcestatusid="192350000" tostatusid="192350004" /><allowedtransition sourcestatusid="192350000" tostatusid="192350001" /></allowedtransitions>`|
|192350001|Label: **Live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350001" tostatusid="192350007" /><allowedtransition sourcestatusid="192350001" tostatusid="192350002" /><allowedtransition sourcestatusid="192350001" tostatusid="192350006" /><allowedtransition sourcestatusid="192350001" tostatusid="192350003" /><allowedtransition sourcestatusid="192350001" tostatusid="192350005" /><allowedtransition sourcestatusid="192350001" tostatusid="192350002" /></allowedtransitions>`|
|192350002|Label: **Stopped**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350002" tostatusid="192350004" /><allowedtransition sourcestatusid="192350002" tostatusid="192350006" /><allowedtransition sourcestatusid="192350002" tostatusid="192350001" /></allowedtransitions>`|
|192350003|Label: **Live, editable**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350003" tostatusid="192350001" /><allowedtransition sourcestatusid="192350003" tostatusid="192350006" /></allowedtransitions>`|
|192350004|Label: **Expired**<br />State:1<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350004" tostatusid="192350000" /></allowedtransitions>`|
|192350005|Label: **Error**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350005" tostatusid="192350006" /><allowedtransition sourcestatusid="192350005" tostatusid="192350007" /><allowedtransition sourcestatusid="192350005" tostatusid="192350001" /><allowedtransition sourcestatusid="192350005" tostatusid="192350002" /></allowedtransitions>`|
|192350006|Label: **Going live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350006" tostatusid="192350001" /><allowedtransition sourcestatusid="192350006" tostatusid="192350005" /></allowedtransitions>`|
|192350007|Label: **Stopping**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350007" tostatusid="192350002" /><allowedtransition sourcestatusid="192350007" tostatusid="192350005" /></allowedtransitions>`|

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
|GlobalChoiceName|`msdyncrm_marketingemail_formtosave`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

- [business_unit_msdyncrm_marketingemail](#BKMK_business_unit_msdyncrm_marketingemail)
- [lk_msdyncrm_marketingemail_createdby](#BKMK_lk_msdyncrm_marketingemail_createdby)
- [lk_msdyncrm_marketingemail_createdonbehalfby](#BKMK_lk_msdyncrm_marketingemail_createdonbehalfby)
- [lk_msdyncrm_marketingemail_modifiedby](#BKMK_lk_msdyncrm_marketingemail_modifiedby)
- [lk_msdyncrm_marketingemail_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingemail_modifiedonbehalfby)
- [msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_](#BKMK_msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_)
- [msdyncrm_systemuser_msdyncrm_marketingemail_FromUser](#BKMK_msdyncrm_systemuser_msdyncrm_marketingemail_FromUser)
- [owner_msdyncrm_marketingemail](#BKMK_owner_msdyncrm_marketingemail)
- [team_msdyncrm_marketingemail](#BKMK_team_msdyncrm_marketingemail)
- [user_msdyncrm_marketingemail](#BKMK_user_msdyncrm_marketingemail)

### <a name="BKMK_business_unit_msdyncrm_marketingemail"></a> business_unit_msdyncrm_marketingemail

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingemail](businessunit.md#BKMK_business_unit_msdyncrm_marketingemail)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemail_createdby"></a> lk_msdyncrm_marketingemail_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemail_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingemail_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemail_createdonbehalfby"></a> lk_msdyncrm_marketingemail_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemail_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingemail_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemail_modifiedby"></a> lk_msdyncrm_marketingemail_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemail_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingemail_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemail_modifiedonbehalfby"></a> lk_msdyncrm_marketingemail_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemail_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingemail_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_"></a> msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_

One-To-Many Relationship: [msdyncrm_marketingemailtemplate msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_](msdyncrm_marketingemailtemplate.md#BKMK_msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtemplate`|
|ReferencedAttribute|`msdyncrm_marketingemailtemplateid`|
|ReferencingAttribute|`msdyncrm_templateid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_TemplateId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_systemuser_msdyncrm_marketingemail_FromUser"></a> msdyncrm_systemuser_msdyncrm_marketingemail_FromUser

One-To-Many Relationship: [systemuser msdyncrm_systemuser_msdyncrm_marketingemail_FromUser](systemuser.md#BKMK_msdyncrm_systemuser_msdyncrm_marketingemail_FromUser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyncrm_fromuser`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_FromUser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingemail"></a> owner_msdyncrm_marketingemail

One-To-Many Relationship: [owner owner_msdyncrm_marketingemail](owner.md#BKMK_owner_msdyncrm_marketingemail)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingemail"></a> team_msdyncrm_marketingemail

One-To-Many Relationship: [team team_msdyncrm_marketingemail](team.md#BKMK_team_msdyncrm_marketingemail)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingemail"></a> user_msdyncrm_marketingemail

One-To-Many Relationship: [systemuser user_msdyncrm_marketingemail](systemuser.md#BKMK_user_msdyncrm_marketingemail)

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

- [msdyncrm_marketingemail_AsyncOperations](#BKMK_msdyncrm_marketingemail_AsyncOperations)
- [msdyncrm_marketingemail_BulkDeleteFailures](#BKMK_msdyncrm_marketingemail_BulkDeleteFailures)
- [msdyncrm_marketingemail_MailboxTrackingFolders](#BKMK_msdyncrm_marketingemail_MailboxTrackingFolders)
- [msdyncrm_marketingemail_marketingemailtest](#BKMK_msdyncrm_marketingemail_marketingemailtest)
- [msdyncrm_marketingemail_marketingformsubmission](#BKMK_msdyncrm_marketingemail_marketingformsubmission)
- [msdyncrm_marketingemail_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingemail_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingemail_ProcessSession](#BKMK_msdyncrm_marketingemail_ProcessSession)
- [msdyncrm_marketingemail_SyncErrors](#BKMK_msdyncrm_marketingemail_SyncErrors)
- [msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid](#BKMK_msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid)
- [msdyncrm_msdyncrm_marketingemail_contact_emailid](#BKMK_msdyncrm_msdyncrm_marketingemail_contact_emailid)
- [msdyncrm_msdyncrm_marketingemail_lead_emailid](#BKMK_msdyncrm_msdyncrm_marketingemail_lead_emailid)
- [msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage](#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage)
- [msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage](#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage)
- [msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin](#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin)
- [msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage](#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage)

### <a name="BKMK_msdyncrm_marketingemail_AsyncOperations"></a> msdyncrm_marketingemail_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingemail_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingemail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemail_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemail_BulkDeleteFailures"></a> msdyncrm_marketingemail_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingemail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingemail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemail_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemail_MailboxTrackingFolders"></a> msdyncrm_marketingemail_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingemail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingemail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemail_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemail_marketingemailtest"></a> msdyncrm_marketingemail_marketingemailtest

Many-To-One Relationship: [msdyncrm_marketingemailtest msdyncrm_marketingemail_marketingemailtest](msdyncrm_marketingemailtest.md#BKMK_msdyncrm_marketingemail_marketingemailtest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtest`|
|ReferencingAttribute|`msdyncrm_marketingemail`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemail_marketingemailtest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemail_marketingformsubmission"></a> msdyncrm_marketingemail_marketingformsubmission

Many-To-One Relationship: [msdyncrm_marketingformsubmission msdyncrm_marketingemail_marketingformsubmission](msdyncrm_marketingformsubmission.md#BKMK_msdyncrm_marketingemail_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformsubmission`|
|ReferencingAttribute|`msdyncrm_marketingemailid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemail_marketingformsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemail_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingemail_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingemail_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingemail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemail_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemail_ProcessSession"></a> msdyncrm_marketingemail_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingemail_ProcessSession](processsession.md#BKMK_msdyncrm_marketingemail_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemail_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemail_SyncErrors"></a> msdyncrm_marketingemail_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingemail_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingemail_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemail_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid"></a> msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid

Many-To-One Relationship: [msdyncrm_marketingemailactivity msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid](msdyncrm_marketingemailactivity.md#BKMK_msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailactivity`|
|ReferencingAttribute|`msdyncrm_emailid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingemailactivity_msdyncrm_marketingemail_msdyncrm_emailid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_contact_emailid"></a> msdyncrm_msdyncrm_marketingemail_contact_emailid

Many-To-One Relationship: [contact msdyncrm_msdyncrm_marketingemail_contact_emailid](contact.md#BKMK_msdyncrm_msdyncrm_marketingemail_contact_emailid)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msdyncrm_emailid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingemail_contact_emailid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_lead_emailid"></a> msdyncrm_msdyncrm_marketingemail_lead_emailid

Many-To-One Relationship: [lead msdyncrm_msdyncrm_marketingemail_lead_emailid](lead.md#BKMK_msdyncrm_msdyncrm_marketingemail_lead_emailid)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdyncrm_emailid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingemail_lead_emailid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage"></a> msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage](msdyncrm_defaultmarketingsetting.md#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`msdyncrm_consentconfirmationmessage`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage"></a> msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage](msdyncrm_defaultmarketingsetting.md#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`msdyncrm_subscriptionoptinmessage`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin"></a> msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin

Many-To-One Relationship: [msdyncrm_geopin msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin](msdyncrm_geopin.md#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_geopin`|
|ReferencingAttribute|`msdyncrm_marketingemailgeopinsid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage"></a> msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage

Many-To-One Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingform`|
|ReferencingAttribute|`msdyncrm_doubleoptinmessage`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyncrm_customerjourney_msdyncrm_marketingemail](#BKMK_msdyncrm_customerjourney_msdyncrm_marketingemail)
- [msdyncrm_marketingpage_marketingemail](#BKMK_msdyncrm_marketingpage_marketingemail)

### <a name="BKMK_msdyncrm_customerjourney_msdyncrm_marketingemail"></a> msdyncrm_customerjourney_msdyncrm_marketingemail

See [msdyncrm_customerjourney msdyncrm_customerjourney_msdyncrm_marketingemail Many-To-Many Relationship](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_msdyncrm_marketingemail)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_customerjourney_msdyncrm_marketingemail`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_customerjourney_msdyncrm_marketingemail`|
|IntersectAttribute|`msdyncrm_marketingemailid`|
|NavigationPropertyName|`msdyncrm_customerjourney_msdyncrm_marketingemail`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_marketingemail"></a> msdyncrm_marketingpage_marketingemail

See [msdyncrm_marketingpage msdyncrm_marketingpage_marketingemail Many-To-Many Relationship](msdyncrm_marketingpage.md#BKMK_msdyncrm_marketingpage_marketingemail)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_marketingpage_marketingemail`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_marketingpage_marketingemail`|
|IntersectAttribute|`msdyncrm_marketingemailid`|
|NavigationPropertyName|`msdyncrm_marketingpage_marketingemail`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

