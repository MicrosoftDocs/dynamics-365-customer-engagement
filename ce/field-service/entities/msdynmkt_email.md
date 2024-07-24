---
title: "Email (msdynmkt_email) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Email (msdynmkt_email) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Email (msdynmkt_email) table/entity reference



## Messages

The following table lists the messages for the Email (msdynmkt_email) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_emails(*msdynmkt_emailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_emails<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_emails(*msdynmkt_emailid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_emails(*msdynmkt_emailid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_emails<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_emails(*msdynmkt_emailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_emails(*msdynmkt_emailid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_emails(*msdynmkt_emailid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Email (msdynmkt_email) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Email (msdynmkt_email) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Email** |
| **DisplayCollectionName** | **Emails** |
| **SchemaName** | `msdynmkt_email` |
| **CollectionSchemaName** | `msdynmkt_emails` |
| **EntitySetName** | `msdynmkt_emails`|
| **LogicalName** | `msdynmkt_email` |
| **LogicalCollectionName** | `msdynmkt_emails` |
| **PrimaryIdAttribute** | `msdynmkt_emailid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdynmkt_automaticallygeneratetextpart](#BKMK_msdynmkt_automaticallygeneratetextpart)
- [msdynmkt_brandprofiledata](#BKMK_msdynmkt_brandprofiledata)
- [msdynmkt_brandprofileid](#BKMK_msdynmkt_brandprofileid)
- [msdynmkt_compliancesettings](#BKMK_msdynmkt_compliancesettings)
- [msdynmkt_compliancesettings3](#BKMK_msdynmkt_compliancesettings3)
- [msdynmkt_compliancesettings4](#BKMK_msdynmkt_compliancesettings4)
- [msdynmkt_compliancesettingscompanyaddress](#BKMK_msdynmkt_compliancesettingscompanyaddress)
- [msdynmkt_conditionalcontent](#BKMK_msdynmkt_conditionalcontent)
- [msdynmkt_description](#BKMK_msdynmkt_description)
- [msdynmkt_designerhtml](#BKMK_msdynmkt_designerhtml)
- [msdynmkt_emailbody](#BKMK_msdynmkt_emailbody)
- [msdynmkt_emailcontentlanguage](#BKMK_msdynmkt_emailcontentlanguage)
- [msdynmkt_emailcontenttype](#BKMK_msdynmkt_emailcontenttype)
- [msdynmkt_emailId](#BKMK_msdynmkt_emailId)
- [msdynmkt_eventtype](#BKMK_msdynmkt_eventtype)
- [msdynmkt_fromemail](#BKMK_msdynmkt_fromemail)
- [msdynmkt_fromname](#BKMK_msdynmkt_fromname)
- [msdynmkt_intendeduse](#BKMK_msdynmkt_intendeduse)
- [msdynmkt_isteamswebinaremail](#BKMK_msdynmkt_isteamswebinaremail)
- [msdynmkt_messagedesignation](#BKMK_msdynmkt_messagedesignation)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_obmmigrationinfo](#BKMK_msdynmkt_obmmigrationinfo)
- [msdynmkt_placeholders](#BKMK_msdynmkt_placeholders)
- [msdynmkt_previewhtml](#BKMK_msdynmkt_previewhtml)
- [msdynmkt_previewtext](#BKMK_msdynmkt_previewtext)
- [msdynmkt_profiletype](#BKMK_msdynmkt_profiletype)
- [msdynmkt_purpose](#BKMK_msdynmkt_purpose)
- [msdynmkt_replytoemail](#BKMK_msdynmkt_replytoemail)
- [msdynmkt_senderid](#BKMK_msdynmkt_senderid)
- [msdynmkt_subject](#BKMK_msdynmkt_subject)
- [msdynmkt_templateid](#BKMK_msdynmkt_templateid)
- [msdynmkt_testconfiguration](#BKMK_msdynmkt_testconfiguration)
- [msdynmkt_textpart](#BKMK_msdynmkt_textpart)
- [msdynmkt_to](#BKMK_msdynmkt_to)
- [msdynmkt_topic](#BKMK_msdynmkt_topic)
- [msdynmkt_virtualeventid](#BKMK_msdynmkt_virtualeventid)
- [msdynmkt_webinaremailtemplatetype](#BKMK_msdynmkt_webinaremailtemplatetype)
- [msdynmkt_webinarid](#BKMK_msdynmkt_webinarid)
- [msdynmkt_webinartitle](#BKMK_msdynmkt_webinartitle)
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
|Description|**Thumbnail preview of template**|
|DisplayName|**Thumbnail**|
|IsValidForForm|True|
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdynmkt_automaticallygeneratetextpart"></a> msdynmkt_automaticallygeneratetextpart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Automatically Generate Text Part**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_automaticallygeneratetextpart`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_email_msdynmkt_automaticallygeneratetextpart`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_brandprofiledata"></a> msdynmkt_brandprofiledata

|Property|Value|
|---|---|
|Description||
|DisplayName|**Brand profile data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_brandprofiledata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdynmkt_brandprofileid"></a> msdynmkt_brandprofileid

|Property|Value|
|---|---|
|Description|**Email brand profile**|
|DisplayName|**Brand profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_brandprofileid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_brandprofile|

### <a name="BKMK_msdynmkt_compliancesettings"></a> msdynmkt_compliancesettings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Compliance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_compliancesettings`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_compliancesettings|

### <a name="BKMK_msdynmkt_compliancesettings3"></a> msdynmkt_compliancesettings3

|Property|Value|
|---|---|
|Description||
|DisplayName|**Compliance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_compliancesettings3`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_compliancesettings3|

### <a name="BKMK_msdynmkt_compliancesettings4"></a> msdynmkt_compliancesettings4

|Property|Value|
|---|---|
|Description||
|DisplayName|**Compliance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_compliancesettings4`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_compliancesettings4|

### <a name="BKMK_msdynmkt_compliancesettingscompanyaddress"></a> msdynmkt_compliancesettingscompanyaddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Company address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_compliancesettingscompanyaddress`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_conditionalcontent"></a> msdynmkt_conditionalcontent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conditional Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_conditionalcontent`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdynmkt_description"></a> msdynmkt_description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdynmkt_designerhtml"></a> msdynmkt_designerhtml

|Property|Value|
|---|---|
|Description||
|DisplayName|**Designer Html**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_designerhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_emailbody"></a> msdynmkt_emailbody

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email body**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailbody`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_emailcontentlanguage"></a> msdynmkt_emailcontentlanguage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email content language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailcontentlanguage`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1033|
|GlobalChoiceName|`msdynmkt_email_msdynmkt_emailcontentlanguage`|

#### msdynmkt_emailcontentlanguage Choices/Options

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
|1040|**Italian (Italy)**|
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
|1055|**Turkish (Türkiye)**|
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
|2057|**English (United Kingdom)**|
|2070|**Portuguese (Portugal)**|
|2074|**Serbian (Latin, Serbia and Montenegro)**|
|3076|**Chinese (Hong Kong S.A.R.)**|
|3081|**English (Australia)**|
|3082|**Spanish**|
|3084|**French (Canada)**|
|3098|**Serbian (Cyrillic, Serbia and Montenegro)**|
|4105|**English (Canada)**|

### <a name="BKMK_msdynmkt_emailcontenttype"></a> msdynmkt_emailcontenttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email content type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailcontenttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_email_msdynmkt_emailcontenttype`|

#### msdynmkt_emailcontenttype Choices/Options

|Value|Label|
|---|---|
|534120000|**Default**|
|534120001|**Double opt-in confirmation**|

### <a name="BKMK_msdynmkt_emailId"></a> msdynmkt_emailId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Email**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_eventtype"></a> msdynmkt_eventtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_eventtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_fromemail"></a> msdynmkt_fromemail

|Property|Value|
|---|---|
|Description||
|DisplayName|**From email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_fromemail`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdynmkt_fromname"></a> msdynmkt_fromname

|Property|Value|
|---|---|
|Description||
|DisplayName|**From name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_fromname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdynmkt_intendeduse"></a> msdynmkt_intendeduse

|Property|Value|
|---|---|
|Description||
|DisplayName|**Intended use**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_intendeduse`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_cxpmessageintendeduse`|

#### msdynmkt_intendeduse Choices/Options

|Value|Label|
|---|---|
|534120000|**Default**|
|534120001|**Confirmation Request**|

### <a name="BKMK_msdynmkt_isteamswebinaremail"></a> msdynmkt_isteamswebinaremail

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is a Teams Webinar Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_isteamswebinaremail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_email_isteamswebinaremail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_messagedesignation"></a> msdynmkt_messagedesignation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Message designation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_messagedesignation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_messagedesignation`|

#### msdynmkt_messagedesignation Choices/Options

|Value|Label|
|---|---|
|534120000|**Commercial**|
|534120001|**Transactional**|

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

### <a name="BKMK_msdynmkt_obmmigrationinfo"></a> msdynmkt_obmmigrationinfo

|Property|Value|
|---|---|
|Description|**Information for result of migration from outbound marketing email.**|
|DisplayName|**Migration information**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_obmmigrationinfo`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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

### <a name="BKMK_msdynmkt_previewhtml"></a> msdynmkt_previewhtml

|Property|Value|
|---|---|
|Description||
|DisplayName|**Preview Html**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_previewhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_previewtext"></a> msdynmkt_previewtext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Preview Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_previewtext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_profiletype"></a> msdynmkt_profiletype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Profile Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_profiletype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_purpose"></a> msdynmkt_purpose

|Property|Value|
|---|---|
|Description||
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_purpose`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_purpose|

### <a name="BKMK_msdynmkt_replytoemail"></a> msdynmkt_replytoemail

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reply to email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_replytoemail`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdynmkt_senderid"></a> msdynmkt_senderid

|Property|Value|
|---|---|
|Description|**Email sender profile**|
|DisplayName|**Sender**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_senderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_brandsender|

### <a name="BKMK_msdynmkt_subject"></a> msdynmkt_subject

|Property|Value|
|---|---|
|Description||
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_subject`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_templateid"></a> msdynmkt_templateid

|Property|Value|
|---|---|
|Description|**Template for the email**|
|DisplayName|**Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_templateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_emailtemplate|

### <a name="BKMK_msdynmkt_testconfiguration"></a> msdynmkt_testconfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Test Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_testconfiguration`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_textpart"></a> msdynmkt_textpart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Text Part**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_textpart`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_to"></a> msdynmkt_to

|Property|Value|
|---|---|
|Description||
|DisplayName|**To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_to`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdynmkt_topic"></a> msdynmkt_topic

|Property|Value|
|---|---|
|Description||
|DisplayName|**Topic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_topic`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_topic|

### <a name="BKMK_msdynmkt_virtualeventid"></a> msdynmkt_virtualeventid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Virtual event Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_virtualeventid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_webinaremailtemplatetype"></a> msdynmkt_webinaremailtemplatetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar Email Template Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_webinaremailtemplatetype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_webinarid"></a> msdynmkt_webinarid

|Property|Value|
|---|---|
|Description|**This field is deprecated**|
|DisplayName|**Webinar Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_webinarid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_webinartitle"></a> msdynmkt_webinartitle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_webinartitle`|
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
|Description|**Status of the Email**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_email_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 100<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Email**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_email_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **Ready to send**<br />State:0<br />TransitionData: None|
|3|Label: **Ready to send, editing**<br />State:0<br />TransitionData: None|
|100|Label: **Inactive**<br />State:1<br />TransitionData: None|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdynmkt_email](#BKMK_business_unit_msdynmkt_email)
- [lk_msdynmkt_email_createdby](#BKMK_lk_msdynmkt_email_createdby)
- [lk_msdynmkt_email_createdonbehalfby](#BKMK_lk_msdynmkt_email_createdonbehalfby)
- [lk_msdynmkt_email_modifiedby](#BKMK_lk_msdynmkt_email_modifiedby)
- [lk_msdynmkt_email_modifiedonbehalfby](#BKMK_lk_msdynmkt_email_modifiedonbehalfby)
- [msdynmkt_msdynmkt_brandprofile_msdynmkt_email_brandprofile](#BKMK_msdynmkt_msdynmkt_brandprofile_msdynmkt_email_brandprofile)
- [msdynmkt_msdynmkt_brandsender_msdynmkt_email_sender](#BKMK_msdynmkt_msdynmkt_brandsender_msdynmkt_email_sender)
- [msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings](#BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings)
- [msdynmkt_msdynmkt_compliancesettings3_msdynmkt_email_compliancesettings3](#BKMK_msdynmkt_msdynmkt_compliancesettings3_msdynmkt_email_compliancesettings3)
- [msdynmkt_msdynmkt_compliancesettings4_msdynmkt_email_compliancesettings4](#BKMK_msdynmkt_msdynmkt_compliancesettings4_msdynmkt_email_compliancesettings4)
- [msdynmkt_msdynmkt_emailtemplate_msdynmkt_email](#BKMK_msdynmkt_msdynmkt_emailtemplate_msdynmkt_email)
- [msdynmkt_msdynmkt_purpose_msdynmkt_email_purpose](#BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_email_purpose)
- [msdynmkt_msdynmkt_topic_msdynmkt_email_topic](#BKMK_msdynmkt_msdynmkt_topic_msdynmkt_email_topic)
- [owner_msdynmkt_email](#BKMK_owner_msdynmkt_email)
- [team_msdynmkt_email](#BKMK_team_msdynmkt_email)
- [user_msdynmkt_email](#BKMK_user_msdynmkt_email)

### <a name="BKMK_business_unit_msdynmkt_email"></a> business_unit_msdynmkt_email

One-To-Many Relationship: [businessunit business_unit_msdynmkt_email](businessunit.md#BKMK_business_unit_msdynmkt_email)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_email_createdby"></a> lk_msdynmkt_email_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_email_createdby](systemuser.md#BKMK_lk_msdynmkt_email_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_email_createdonbehalfby"></a> lk_msdynmkt_email_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_email_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_email_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_email_modifiedby"></a> lk_msdynmkt_email_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_email_modifiedby](systemuser.md#BKMK_lk_msdynmkt_email_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_email_modifiedonbehalfby"></a> lk_msdynmkt_email_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_email_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_email_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_brandprofile_msdynmkt_email_brandprofile"></a> msdynmkt_msdynmkt_brandprofile_msdynmkt_email_brandprofile

One-To-Many Relationship: [msdynmkt_brandprofile msdynmkt_msdynmkt_brandprofile_msdynmkt_email_brandprofile](msdynmkt_brandprofile.md#BKMK_msdynmkt_msdynmkt_brandprofile_msdynmkt_email_brandprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_brandprofile`|
|ReferencedAttribute|`msdynmkt_brandprofileid`|
|ReferencingAttribute|`msdynmkt_brandprofileid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_brandprofileid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_brandsender_msdynmkt_email_sender"></a> msdynmkt_msdynmkt_brandsender_msdynmkt_email_sender

One-To-Many Relationship: [msdynmkt_brandsender msdynmkt_msdynmkt_brandsender_msdynmkt_email_sender](msdynmkt_brandsender.md#BKMK_msdynmkt_msdynmkt_brandsender_msdynmkt_email_sender)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_brandsender`|
|ReferencedAttribute|`msdynmkt_brandsenderid`|
|ReferencingAttribute|`msdynmkt_senderid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_senderid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings"></a> msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings

One-To-Many Relationship: [msdynmkt_compliancesettings msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings](msdynmkt_compliancesettings.md#BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_compliancesettings`|
|ReferencedAttribute|`msdynmkt_compliancesettingsid`|
|ReferencingAttribute|`msdynmkt_compliancesettings`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_compliancesettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_compliancesettings3_msdynmkt_email_compliancesettings3"></a> msdynmkt_msdynmkt_compliancesettings3_msdynmkt_email_compliancesettings3

One-To-Many Relationship: [msdynmkt_compliancesettings3 msdynmkt_msdynmkt_compliancesettings3_msdynmkt_email_compliancesettings3](msdynmkt_compliancesettings3.md#BKMK_msdynmkt_msdynmkt_compliancesettings3_msdynmkt_email_compliancesettings3)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_compliancesettings3`|
|ReferencedAttribute|`msdynmkt_compliancesettings3id`|
|ReferencingAttribute|`msdynmkt_compliancesettings3`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_compliancesettings3`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_compliancesettings4_msdynmkt_email_compliancesettings4"></a> msdynmkt_msdynmkt_compliancesettings4_msdynmkt_email_compliancesettings4

One-To-Many Relationship: [msdynmkt_compliancesettings4 msdynmkt_msdynmkt_compliancesettings4_msdynmkt_email_compliancesettings4](msdynmkt_compliancesettings4.md#BKMK_msdynmkt_msdynmkt_compliancesettings4_msdynmkt_email_compliancesettings4)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_compliancesettings4`|
|ReferencedAttribute|`msdynmkt_compliancesettings4id`|
|ReferencingAttribute|`msdynmkt_compliancesettings4`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_compliancesettings4`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_emailtemplate_msdynmkt_email"></a> msdynmkt_msdynmkt_emailtemplate_msdynmkt_email

One-To-Many Relationship: [msdynmkt_emailtemplate msdynmkt_msdynmkt_emailtemplate_msdynmkt_email](msdynmkt_emailtemplate.md#BKMK_msdynmkt_msdynmkt_emailtemplate_msdynmkt_email)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_emailtemplate`|
|ReferencedAttribute|`msdynmkt_emailtemplateid`|
|ReferencingAttribute|`msdynmkt_templateid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_templateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_email_purpose"></a> msdynmkt_msdynmkt_purpose_msdynmkt_email_purpose

One-To-Many Relationship: [msdynmkt_purpose msdynmkt_msdynmkt_purpose_msdynmkt_email_purpose](msdynmkt_purpose.md#BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_email_purpose)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_purpose`|
|ReferencedAttribute|`msdynmkt_purposeid`|
|ReferencingAttribute|`msdynmkt_purpose`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_purpose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_topic_msdynmkt_email_topic"></a> msdynmkt_msdynmkt_topic_msdynmkt_email_topic

One-To-Many Relationship: [msdynmkt_topic msdynmkt_msdynmkt_topic_msdynmkt_email_topic](msdynmkt_topic.md#BKMK_msdynmkt_msdynmkt_topic_msdynmkt_email_topic)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_topic`|
|ReferencedAttribute|`msdynmkt_topicid`|
|ReferencingAttribute|`msdynmkt_topic`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_topic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_email"></a> owner_msdynmkt_email

One-To-Many Relationship: [owner owner_msdynmkt_email](owner.md#BKMK_owner_msdynmkt_email)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_email"></a> team_msdynmkt_email

One-To-Many Relationship: [team team_msdynmkt_email](team.md#BKMK_team_msdynmkt_email)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_email"></a> user_msdynmkt_email

One-To-Many Relationship: [systemuser user_msdynmkt_email](systemuser.md#BKMK_user_msdynmkt_email)

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

- [msdynmkt_email_AsyncOperations](#BKMK_msdynmkt_email_AsyncOperations)
- [msdynmkt_email_BulkDeleteFailures](#BKMK_msdynmkt_email_BulkDeleteFailures)
- [msdynmkt_email_MailboxTrackingFolders](#BKMK_msdynmkt_email_MailboxTrackingFolders)
- [msdynmkt_email_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_email_PrincipalObjectAttributeAccesses)
- [msdynmkt_email_ProcessSession](#BKMK_msdynmkt_email_ProcessSession)
- [msdynmkt_email_SyncErrors](#BKMK_msdynmkt_email_SyncErrors)
- [msdynmkt_journeydependency_dependency_msdynmkt_email](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_email)
- [msdynmkt_marketingformsubmission_emailid](#BKMK_msdynmkt_marketingformsubmission_emailid)
- [msdynmkt_msdynmkt_email_contact_emailid](#BKMK_msdynmkt_msdynmkt_email_contact_emailid)
- [msdynmkt_msdynmkt_email_lead_emailid](#BKMK_msdynmkt_msdynmkt_email_lead_emailid)
- [msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email](#BKMK_msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email)
- [msdynmkt_msdynmkt_email_msdynmkt_webinaremailjourney_webinaremail](#BKMK_msdynmkt_msdynmkt_email_msdynmkt_webinaremailjourney_webinaremail)

### <a name="BKMK_msdynmkt_email_AsyncOperations"></a> msdynmkt_email_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_email_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_email_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_email_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_email_BulkDeleteFailures"></a> msdynmkt_email_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_email_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_email_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_email_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_email_MailboxTrackingFolders"></a> msdynmkt_email_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_email_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_email_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_email_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_email_PrincipalObjectAttributeAccesses"></a> msdynmkt_email_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_email_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_email_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_email_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_email_ProcessSession"></a> msdynmkt_email_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_email_ProcessSession](processsession.md#BKMK_msdynmkt_email_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_email_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_email_SyncErrors"></a> msdynmkt_email_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_email_SyncErrors](syncerror.md#BKMK_msdynmkt_email_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_email_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_email"></a> msdynmkt_journeydependency_dependency_msdynmkt_email

Many-To-One Relationship: [msdynmkt_journeydependency msdynmkt_journeydependency_dependency_msdynmkt_email](msdynmkt_journeydependency.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_email)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeydependency`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_dependency_msdynmkt_email`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_emailid"></a> msdynmkt_marketingformsubmission_emailid

Many-To-One Relationship: [msdynmkt_marketingformsubmission msdynmkt_marketingformsubmission_emailid](msdynmkt_marketingformsubmission.md#BKMK_msdynmkt_marketingformsubmission_emailid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformsubmission`|
|ReferencingAttribute|`msdynmkt_emailid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_emailid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_email_contact_emailid"></a> msdynmkt_msdynmkt_email_contact_emailid

Many-To-One Relationship: [contact msdynmkt_msdynmkt_email_contact_emailid](contact.md#BKMK_msdynmkt_msdynmkt_email_contact_emailid)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msdynmkt_emailid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_email_contact_emailid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_email_lead_emailid"></a> msdynmkt_msdynmkt_email_lead_emailid

Many-To-One Relationship: [lead msdynmkt_msdynmkt_email_lead_emailid](lead.md#BKMK_msdynmkt_msdynmkt_email_lead_emailid)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdynmkt_emailid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_email_lead_emailid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email"></a> msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email

Many-To-One Relationship: [msdynmkt_teamsengagement msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email](msdynmkt_teamsengagement.md#BKMK_msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_teamsengagement`|
|ReferencingAttribute|`msdynmkt_email`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_email_msdynmkt_webinaremailjourney_webinaremail"></a> msdynmkt_msdynmkt_email_msdynmkt_webinaremailjourney_webinaremail

Many-To-One Relationship: [msdynmkt_webinaremailjourney msdynmkt_msdynmkt_email_msdynmkt_webinaremailjourney_webinaremail](msdynmkt_webinaremailjourney.md#BKMK_msdynmkt_msdynmkt_email_msdynmkt_webinaremailjourney_webinaremail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_webinaremailjourney`|
|ReferencingAttribute|`msdynmkt_webinaremail`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_email_msdynmkt_webinaremailjourney_webinaremail`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdynmkt_email_fragment"></a> msdynmkt_email_fragment

See [msdynmkt_fragment msdynmkt_email_fragment Many-To-Many Relationship](msdynmkt_fragment.md#BKMK_msdynmkt_email_fragment)

|Property|Value|
|---|---|
|IntersectEntityName|`msdynmkt_email_fragment`|
|IsCustomizable|False|
|SchemaName|`msdynmkt_email_fragment`|
|IntersectAttribute|`msdynmkt_emailid`|
|NavigationPropertyName|`msdynmkt_email_fragment`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

