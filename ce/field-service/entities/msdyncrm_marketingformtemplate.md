---
title: "Marketing form template (msdyncrm_marketingformtemplate) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing form template (msdyncrm_marketingformtemplate) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing form template (msdyncrm_marketingformtemplate) table/entity reference



## Messages

The following table lists the messages for the Marketing form template (msdyncrm_marketingformtemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingformtemplates(*msdyncrm_marketingformtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingformtemplates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingformtemplates(*msdyncrm_marketingformtemplateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingformtemplates(*msdyncrm_marketingformtemplateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingformtemplates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingformtemplates(*msdyncrm_marketingformtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingformtemplates(*msdyncrm_marketingformtemplateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingformtemplates(*msdyncrm_marketingformtemplateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing form template (msdyncrm_marketingformtemplate) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing form template (msdyncrm_marketingformtemplate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing form template** |
| **DisplayCollectionName** | **Marketing form templates** |
| **SchemaName** | `msdyncrm_marketingformtemplate` |
| **CollectionSchemaName** | `msdyncrm_marketingformtemplates` |
| **EntitySetName** | `msdyncrm_marketingformtemplates`|
| **LogicalName** | `msdyncrm_marketingformtemplate` |
| **LogicalCollectionName** | `msdyncrm_marketingformtemplates` |
| **PrimaryIdAttribute** | `msdyncrm_marketingformtemplateid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_ConfirmationMessage](#BKMK_msdyncrm_ConfirmationMessage)
- [msdyncrm_entityupdatebehavioronsubmit](#BKMK_msdyncrm_entityupdatebehavioronsubmit)
- [msdyncrm_errorimageurl](#BKMK_msdyncrm_errorimageurl)
- [msdyncrm_ErrorMessage](#BKMK_msdyncrm_ErrorMessage)
- [msdyncrm_formcontrolmapping](#BKMK_msdyncrm_formcontrolmapping)
- [msdyncrm_formdefinition](#BKMK_msdyncrm_formdefinition)
- [msdyncrm_formfieldmapping](#BKMK_msdyncrm_formfieldmapping)
- [msdyncrm_Label](#BKMK_msdyncrm_Label)
- [msdyncrm_Language](#BKMK_msdyncrm_Language)
- [msdyncrm_LimitExceededMessage](#BKMK_msdyncrm_LimitExceededMessage)
- [msdyncrm_marketingformtemplateId](#BKMK_msdyncrm_marketingformtemplateId)
- [msdyncrm_marketingprovided](#BKMK_msdyncrm_marketingprovided)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_purpose](#BKMK_msdyncrm_purpose)
- [msdyncrm_RedirectURL](#BKMK_msdyncrm_RedirectURL)
- [msdyncrm_successImageUrl](#BKMK_msdyncrm_successImageUrl)
- [msdyncrm_Tag](#BKMK_msdyncrm_Tag)
- [msdyncrm_validforpagetype](#BKMK_msdyncrm_validforpagetype)
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

### <a name="BKMK_msdyncrm_ConfirmationMessage"></a> msdyncrm_ConfirmationMessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Confirmation message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_confirmationmessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_entityupdatebehavioronsubmit"></a> msdyncrm_entityupdatebehavioronsubmit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Update contacts/leads**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_entityupdatebehavioronsubmit`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_entityupdatebehavioronsubmit`|

#### msdyncrm_entityupdatebehavioronsubmit Choices/Options

|Value|Label|
|---|---|
|0|**Contacts and leads**|
|1|**Only contacts**|
|2|**Only leads**|
|3|**No update**|

### <a name="BKMK_msdyncrm_errorimageurl"></a> msdyncrm_errorimageurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error image URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_errorimageurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyncrm_ErrorMessage"></a> msdyncrm_ErrorMessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_errormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_formcontrolmapping"></a> msdyncrm_formcontrolmapping

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form control mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formcontrolmapping`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyncrm_formdefinition"></a> msdyncrm_formdefinition

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formdefinition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyncrm_formfieldmapping"></a> msdyncrm_formfieldmapping

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form Field Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formfieldmapping`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150000|

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
|GlobalChoiceName|`msdyncrm_marketingformtemplate_default_labels`|

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

### <a name="BKMK_msdyncrm_LimitExceededMessage"></a> msdyncrm_LimitExceededMessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Limit Exceeded Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_limitexceededmessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_marketingformtemplateId"></a> msdyncrm_marketingformtemplateId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing form template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformtemplateid`|
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
|GlobalChoiceName|`msdyncrm_marketingformtemplate_msdyncrm_marketingprovided`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
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

### <a name="BKMK_msdyncrm_RedirectURL"></a> msdyncrm_RedirectURL

|Property|Value|
|---|---|
|Description||
|DisplayName|**Redirect URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_redirecturl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_successImageUrl"></a> msdyncrm_successImageUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Success image URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_successimageurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdyncrm_validforpagetype"></a> msdyncrm_validforpagetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_validforpagetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_type`|

#### msdyncrm_validforpagetype Choices/Options

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
|GlobalChoiceName|`msdyncrm_marketingform_visualstyle`|

#### msdyncrm_visualstyle Choices/Options

|Value|Label|
|---|---|
|0|**1-column**|
|1|**2-column**|
|2|**Mixed**|

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
|Description|**Status of the marketing form template**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingformtemplate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the marketing form template**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingformtemplate_statuscode`|

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
|Description|**The time-zone code that was in use when the record was created**|
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
|GlobalChoiceName|`msdyncrm_marketingformtemplate_formtosave`|
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
|Description|**Unique ID for the business unit that owns the record**|
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
|Description|**Indicates the person who owns this.**|
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

- [business_unit_msdyncrm_marketingformtemplate](#BKMK_business_unit_msdyncrm_marketingformtemplate)
- [lk_msdyncrm_marketingformtemplate_createdby](#BKMK_lk_msdyncrm_marketingformtemplate_createdby)
- [lk_msdyncrm_marketingformtemplate_createdonbehalfby](#BKMK_lk_msdyncrm_marketingformtemplate_createdonbehalfby)
- [lk_msdyncrm_marketingformtemplate_modifiedby](#BKMK_lk_msdyncrm_marketingformtemplate_modifiedby)
- [lk_msdyncrm_marketingformtemplate_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingformtemplate_modifiedonbehalfby)
- [owner_msdyncrm_marketingformtemplate](#BKMK_owner_msdyncrm_marketingformtemplate)
- [team_msdyncrm_marketingformtemplate](#BKMK_team_msdyncrm_marketingformtemplate)
- [user_msdyncrm_marketingformtemplate](#BKMK_user_msdyncrm_marketingformtemplate)

### <a name="BKMK_business_unit_msdyncrm_marketingformtemplate"></a> business_unit_msdyncrm_marketingformtemplate

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingformtemplate](businessunit.md#BKMK_business_unit_msdyncrm_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformtemplate_createdby"></a> lk_msdyncrm_marketingformtemplate_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformtemplate_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingformtemplate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformtemplate_createdonbehalfby"></a> lk_msdyncrm_marketingformtemplate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformtemplate_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingformtemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformtemplate_modifiedby"></a> lk_msdyncrm_marketingformtemplate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformtemplate_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingformtemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformtemplate_modifiedonbehalfby"></a> lk_msdyncrm_marketingformtemplate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformtemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingformtemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingformtemplate"></a> owner_msdyncrm_marketingformtemplate

One-To-Many Relationship: [owner owner_msdyncrm_marketingformtemplate](owner.md#BKMK_owner_msdyncrm_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingformtemplate"></a> team_msdyncrm_marketingformtemplate

One-To-Many Relationship: [team team_msdyncrm_marketingformtemplate](team.md#BKMK_team_msdyncrm_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingformtemplate"></a> user_msdyncrm_marketingformtemplate

One-To-Many Relationship: [systemuser user_msdyncrm_marketingformtemplate](systemuser.md#BKMK_user_msdyncrm_marketingformtemplate)

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

- [msdyncrm_marketingformtemplate_Annotations](#BKMK_msdyncrm_marketingformtemplate_Annotations)
- [msdyncrm_marketingformtemplate_AsyncOperations](#BKMK_msdyncrm_marketingformtemplate_AsyncOperations)
- [msdyncrm_marketingformtemplate_BulkDeleteFailures](#BKMK_msdyncrm_marketingformtemplate_BulkDeleteFailures)
- [msdyncrm_marketingformtemplate_MailboxTrackingFolders](#BKMK_msdyncrm_marketingformtemplate_MailboxTrackingFolders)
- [msdyncrm_marketingformtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingformtemplate_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingformtemplate_ProcessSession](#BKMK_msdyncrm_marketingformtemplate_ProcessSession)
- [msdyncrm_marketingformtemplate_SyncErrors](#BKMK_msdyncrm_marketingformtemplate_SyncErrors)
- [msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate](#BKMK_msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate)

### <a name="BKMK_msdyncrm_marketingformtemplate_Annotations"></a> msdyncrm_marketingformtemplate_Annotations

Many-To-One Relationship: [annotation msdyncrm_marketingformtemplate_Annotations](annotation.md#BKMK_msdyncrm_marketingformtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformtemplate_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformtemplate_AsyncOperations"></a> msdyncrm_marketingformtemplate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingformtemplate_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingformtemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformtemplate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformtemplate_BulkDeleteFailures"></a> msdyncrm_marketingformtemplate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingformtemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingformtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformtemplate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformtemplate_MailboxTrackingFolders"></a> msdyncrm_marketingformtemplate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingformtemplate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingformtemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformtemplate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformtemplate_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingformtemplate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingformtemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingformtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformtemplate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformtemplate_ProcessSession"></a> msdyncrm_marketingformtemplate_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingformtemplate_ProcessSession](processsession.md#BKMK_msdyncrm_marketingformtemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformtemplate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformtemplate_SyncErrors"></a> msdyncrm_marketingformtemplate_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingformtemplate_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingformtemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformtemplate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate"></a> msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate

Many-To-One Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingform`|
|ReferencingAttribute|`msdyncrm_marketingformtemplate`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyncrm_formtemplate_marketingformfield](#BKMK_msdyncrm_formtemplate_marketingformfield)
- [msdyncrm_maktformtemp_msevtmgt_customregfield](#BKMK_msdyncrm_maktformtemp_msevtmgt_customregfield)

### <a name="BKMK_msdyncrm_formtemplate_marketingformfield"></a> msdyncrm_formtemplate_marketingformfield

See [msdyncrm_marketingformfield msdyncrm_formtemplate_marketingformfield Many-To-Many Relationship](msdyncrm_marketingformfield.md#BKMK_msdyncrm_formtemplate_marketingformfield)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_formtemplate_marketingformfield`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_formtemplate_marketingformfield`|
|IntersectAttribute|`msdyncrm_marketingformtemplateid`|
|NavigationPropertyName|`msdyncrm_formtemplate_marketingformfield`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_maktformtemp_msevtmgt_customregfield"></a> msdyncrm_maktformtemp_msevtmgt_customregfield

See [msevtmgt_customregistrationfield msdyncrm_maktformtemp_msevtmgt_customregfield Many-To-Many Relationship](msevtmgt_customregistrationfield.md#BKMK_msdyncrm_maktformtemp_msevtmgt_customregfield)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_maktformtemp_msevtmgt_customregfield`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_maktformtemp_msevtmgt_customregfield`|
|IntersectAttribute|`msdyncrm_marketingformtemplateid`|
|NavigationPropertyName|`msdyncrm_maktformtemp_msevtmgt_customregfield`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

