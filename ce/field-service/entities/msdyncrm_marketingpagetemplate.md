---
title: "Marketing page template (msdyncrm_marketingpagetemplate) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing page template (msdyncrm_marketingpagetemplate) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing page template (msdyncrm_marketingpagetemplate) table/entity reference



## Messages

The following table lists the messages for the Marketing page template (msdyncrm_marketingpagetemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingpagetemplates(*msdyncrm_marketingpagetemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingpagetemplates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingpagetemplates(*msdyncrm_marketingpagetemplateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingpagetemplates(*msdyncrm_marketingpagetemplateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingpagetemplates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingpagetemplates(*msdyncrm_marketingpagetemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingpagetemplates(*msdyncrm_marketingpagetemplateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingpagetemplates(*msdyncrm_marketingpagetemplateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing page template (msdyncrm_marketingpagetemplate) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing page template (msdyncrm_marketingpagetemplate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing page template** |
| **DisplayCollectionName** | **Marketing page templates** |
| **SchemaName** | `msdyncrm_marketingpagetemplate` |
| **CollectionSchemaName** | `msdyncrm_marketingpagetemplates` |
| **EntitySetName** | `msdyncrm_marketingpagetemplates`|
| **LogicalName** | `msdyncrm_marketingpagetemplate` |
| **LogicalCollectionName** | `msdyncrm_marketingpagetemplates` |
| **PrimaryIdAttribute** | `msdyncrm_marketingpagetemplateid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_content](#BKMK_msdyncrm_content)
- [msdyncrm_contenttype](#BKMK_msdyncrm_contenttype)
- [msdyncrm_formpagemapping](#BKMK_msdyncrm_formpagemapping)
- [msdyncrm_Label](#BKMK_msdyncrm_Label)
- [msdyncrm_Language](#BKMK_msdyncrm_Language)
- [msdyncrm_marketingpagetemplateId](#BKMK_msdyncrm_marketingpagetemplateId)
- [msdyncrm_marketingprovided](#BKMK_msdyncrm_marketingprovided)
- [msdyncrm_markettype](#BKMK_msdyncrm_markettype)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_optimizedfor](#BKMK_msdyncrm_optimizedfor)
- [msdyncrm_purpose](#BKMK_msdyncrm_purpose)
- [msdyncrm_Tag](#BKMK_msdyncrm_Tag)
- [msdyncrm_type](#BKMK_msdyncrm_type)
- [msdyncrm_visualstyle](#BKMK_msdyncrm_visualstyle)
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
|Description|**Thumbnail preview of template.**|
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

### <a name="BKMK_msdyncrm_content"></a> msdyncrm_content

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_content`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_contenttype"></a> msdyncrm_contenttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contenttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_contenttype`|

#### msdyncrm_contenttype Choices/Options

|Value|Label|
|---|---|
|0|**Structural**|
|1|**Product launch**|
|2|**Product information**|
|3|**Company background**|
|4|**Event information**|
|5|**Offers and discounts**|
|6|**Confirmation request**|

### <a name="BKMK_msdyncrm_formpagemapping"></a> msdyncrm_formpagemapping

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form page mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formpagemapping`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

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
|GlobalChoiceName|`msdyncrm_marketingpagetemplate_default_labels`|

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

### <a name="BKMK_msdyncrm_marketingpagetemplateId"></a> msdyncrm_marketingpagetemplateId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing page template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingpagetemplateid`|
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
|GlobalChoiceName|`msdyncrm_marketingpagetemplate_msdyncrm_marketingprovided`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_markettype"></a> msdyncrm_markettype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Market type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_markettype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_markettype`|

#### msdyncrm_markettype Choices/Options

|Value|Label|
|---|---|
|0|**Enterprise**|
|1|**Consumer**|
|2|**All**|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**Name of the marketing page template**|
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

### <a name="BKMK_msdyncrm_optimizedfor"></a> msdyncrm_optimizedfor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Optimized for**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_optimizedfor`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_optimizedfor`|

#### msdyncrm_optimizedfor Choices/Options

|Value|Label|
|---|---|
|0|**Desktop**|
|1|**Tablet**|
|2|**Mobile**|

### <a name="BKMK_msdyncrm_purpose"></a> msdyncrm_purpose

|Property|Value|
|---|---|
|Description||
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_purpose`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_purpose`|

#### msdyncrm_purpose Choices/Options

|Value|Label|
|---|---|
|0|**Contact capture**|
|1|**Newsletter subscription**|
|2|**Lead generation**|
|3|**Collateral download**|
|4|**Event registration**|
|5|**Event feedback**|
|6|**Structural**|
|7|**Double Opt-In, Email based confirmation**|

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

### <a name="BKMK_msdyncrm_type"></a> msdyncrm_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_type`|

#### msdyncrm_type Choices/Options

|Value|Label|
|---|---|
|0|**Landing page**|
|1|**Subscription center**|
|2|**Forward to a friend**|
|3|**Event registration**|

### <a name="BKMK_msdyncrm_visualstyle"></a> msdyncrm_visualstyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Visual style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_visualstyle`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_visualstyle`|

#### msdyncrm_visualstyle Choices/Options

|Value|Label|
|---|---|
|0|**Light**|
|1|**Dark**|
|2|**Colorful**|
|3|**Other**|

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
|Description|**Status of the marketing page template**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingpagetemplate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Marketing page template status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingpagetemplate_statuscode`|

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
|GlobalChoiceName|`msdyncrm_marketingpagetemplate_formtosave`|
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

- [business_unit_msdyncrm_marketingpagetemplate](#BKMK_business_unit_msdyncrm_marketingpagetemplate)
- [lk_msdyncrm_marketingpagetemplate_createdby](#BKMK_lk_msdyncrm_marketingpagetemplate_createdby)
- [lk_msdyncrm_marketingpagetemplate_createdonbehalfby](#BKMK_lk_msdyncrm_marketingpagetemplate_createdonbehalfby)
- [lk_msdyncrm_marketingpagetemplate_modifiedby](#BKMK_lk_msdyncrm_marketingpagetemplate_modifiedby)
- [lk_msdyncrm_marketingpagetemplate_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingpagetemplate_modifiedonbehalfby)
- [owner_msdyncrm_marketingpagetemplate](#BKMK_owner_msdyncrm_marketingpagetemplate)
- [team_msdyncrm_marketingpagetemplate](#BKMK_team_msdyncrm_marketingpagetemplate)
- [user_msdyncrm_marketingpagetemplate](#BKMK_user_msdyncrm_marketingpagetemplate)

### <a name="BKMK_business_unit_msdyncrm_marketingpagetemplate"></a> business_unit_msdyncrm_marketingpagetemplate

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingpagetemplate](businessunit.md#BKMK_business_unit_msdyncrm_marketingpagetemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpagetemplate_createdby"></a> lk_msdyncrm_marketingpagetemplate_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpagetemplate_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingpagetemplate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpagetemplate_createdonbehalfby"></a> lk_msdyncrm_marketingpagetemplate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpagetemplate_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingpagetemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpagetemplate_modifiedby"></a> lk_msdyncrm_marketingpagetemplate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpagetemplate_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingpagetemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpagetemplate_modifiedonbehalfby"></a> lk_msdyncrm_marketingpagetemplate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpagetemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingpagetemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingpagetemplate"></a> owner_msdyncrm_marketingpagetemplate

One-To-Many Relationship: [owner owner_msdyncrm_marketingpagetemplate](owner.md#BKMK_owner_msdyncrm_marketingpagetemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingpagetemplate"></a> team_msdyncrm_marketingpagetemplate

One-To-Many Relationship: [team team_msdyncrm_marketingpagetemplate](team.md#BKMK_team_msdyncrm_marketingpagetemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingpagetemplate"></a> user_msdyncrm_marketingpagetemplate

One-To-Many Relationship: [systemuser user_msdyncrm_marketingpagetemplate](systemuser.md#BKMK_user_msdyncrm_marketingpagetemplate)

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

- [msdyncrm_marketingpage_marketingpagetemplate](#BKMK_msdyncrm_marketingpage_marketingpagetemplate)
- [msdyncrm_marketingpagetemplate_Annotations](#BKMK_msdyncrm_marketingpagetemplate_Annotations)
- [msdyncrm_marketingpagetemplate_AsyncOperations](#BKMK_msdyncrm_marketingpagetemplate_AsyncOperations)
- [msdyncrm_marketingpagetemplate_BulkDeleteFailures](#BKMK_msdyncrm_marketingpagetemplate_BulkDeleteFailures)
- [msdyncrm_marketingpagetemplate_formpagetemplate](#BKMK_msdyncrm_marketingpagetemplate_formpagetemplate)
- [msdyncrm_marketingpagetemplate_MailboxTrackingFolders](#BKMK_msdyncrm_marketingpagetemplate_MailboxTrackingFolders)
- [msdyncrm_marketingpagetemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingpagetemplate_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingpagetemplate_ProcessSession](#BKMK_msdyncrm_marketingpagetemplate_ProcessSession)
- [msdyncrm_marketingpagetemplate_SyncErrors](#BKMK_msdyncrm_marketingpagetemplate_SyncErrors)

### <a name="BKMK_msdyncrm_marketingpage_marketingpagetemplate"></a> msdyncrm_marketingpage_marketingpagetemplate

Many-To-One Relationship: [msdyncrm_marketingpage msdyncrm_marketingpage_marketingpagetemplate](msdyncrm_marketingpage.md#BKMK_msdyncrm_marketingpage_marketingpagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingpage`|
|ReferencingAttribute|`msdyncrm_marketingpagetemplate`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_marketingpagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_Annotations"></a> msdyncrm_marketingpagetemplate_Annotations

Many-To-One Relationship: [annotation msdyncrm_marketingpagetemplate_Annotations](annotation.md#BKMK_msdyncrm_marketingpagetemplate_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_AsyncOperations"></a> msdyncrm_marketingpagetemplate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingpagetemplate_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingpagetemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_BulkDeleteFailures"></a> msdyncrm_marketingpagetemplate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingpagetemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingpagetemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_formpagetemplate"></a> msdyncrm_marketingpagetemplate_formpagetemplate

Many-To-One Relationship: [msdyncrm_formpagetemplate msdyncrm_marketingpagetemplate_formpagetemplate](msdyncrm_formpagetemplate.md#BKMK_msdyncrm_marketingpagetemplate_formpagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpagetemplate`|
|ReferencingAttribute|`msdyncrm_marketingpagetemplateid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate_formpagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_MailboxTrackingFolders"></a> msdyncrm_marketingpagetemplate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingpagetemplate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingpagetemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingpagetemplate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingpagetemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingpagetemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_ProcessSession"></a> msdyncrm_marketingpagetemplate_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingpagetemplate_ProcessSession](processsession.md#BKMK_msdyncrm_marketingpagetemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpagetemplate_SyncErrors"></a> msdyncrm_marketingpagetemplate_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingpagetemplate_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingpagetemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

