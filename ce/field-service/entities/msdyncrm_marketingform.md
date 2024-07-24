---
title: "Marketing form (msdyncrm_marketingform) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing form (msdyncrm_marketingform) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing form (msdyncrm_marketingform) table/entity reference



## Messages

The following table lists the messages for the Marketing form (msdyncrm_marketingform) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingforms(*msdyncrm_marketingformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingforms<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingforms(*msdyncrm_marketingformid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingforms(*msdyncrm_marketingformid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingforms<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingforms(*msdyncrm_marketingformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingforms(*msdyncrm_marketingformid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingforms(*msdyncrm_marketingformid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing form (msdyncrm_marketingform) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing form (msdyncrm_marketingform) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing form** |
| **DisplayCollectionName** | **Marketing forms** |
| **SchemaName** | `msdyncrm_marketingform` |
| **CollectionSchemaName** | `msdyncrm_marketingforms` |
| **EntitySetName** | `msdyncrm_marketingforms`|
| **LogicalName** | `msdyncrm_marketingform` |
| **LogicalCollectionName** | `msdyncrm_marketingforms` |
| **PrimaryIdAttribute** | `msdyncrm_marketingformid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_allowPrefill](#BKMK_msdyncrm_allowPrefill)
- [msdyncrm_alwaysgenerateleads](#BKMK_msdyncrm_alwaysgenerateleads)
- [msdyncrm_capturing](#BKMK_msdyncrm_capturing)
- [msdyncrm_capturing_configured](#BKMK_msdyncrm_capturing_configured)
- [msdyncrm_capturing_data](#BKMK_msdyncrm_capturing_data)
- [msdyncrm_capturing_scantime](#BKMK_msdyncrm_capturing_scantime)
- [msdyncrm_ConfirmationMessage](#BKMK_msdyncrm_ConfirmationMessage)
- [msdyncrm_contactmatchingstrategy](#BKMK_msdyncrm_contactmatchingstrategy)
- [msdyncrm_doubleoptincontentsettings](#BKMK_msdyncrm_doubleoptincontentsettings)
- [msdyncrm_doubleoptinmessage](#BKMK_msdyncrm_doubleoptinmessage)
- [msdyncrm_doubleoptinthankyouformat](#BKMK_msdyncrm_doubleoptinthankyouformat)
- [msdyncrm_doubleoptinthankyoupage](#BKMK_msdyncrm_doubleoptinthankyoupage)
- [msdyncrm_doubleoptinthankyouurl](#BKMK_msdyncrm_doubleoptinthankyouurl)
- [msdyncrm_enabledoubleoptin](#BKMK_msdyncrm_enabledoubleoptin)
- [msdyncrm_entityupdatebehavioronsubmit](#BKMK_msdyncrm_entityupdatebehavioronsubmit)
- [msdyncrm_errorImageUrl](#BKMK_msdyncrm_errorImageUrl)
- [msdyncrm_ErrorMessage](#BKMK_msdyncrm_ErrorMessage)
- [msdyncrm_eventmatchingstrategy](#BKMK_msdyncrm_eventmatchingstrategy)
- [msdyncrm_eventmatchingstrategyinfo](#BKMK_msdyncrm_eventmatchingstrategyinfo)
- [msdyncrm_formcontrolmapping](#BKMK_msdyncrm_formcontrolmapping)
- [msdyncrm_FormDefinition](#BKMK_msdyncrm_FormDefinition)
- [msdyncrm_formfieldmapping](#BKMK_msdyncrm_formfieldmapping)
- [msdyncrm_info](#BKMK_msdyncrm_info)
- [msdyncrm_insights_placeholder](#BKMK_msdyncrm_insights_placeholder)
- [msdyncrm_keepsuccessfulsubmissions](#BKMK_msdyncrm_keepsuccessfulsubmissions)
- [msdyncrm_leadmatchingstrategy](#BKMK_msdyncrm_leadmatchingstrategy)
- [msdyncrm_LimitExceededMessage](#BKMK_msdyncrm_LimitExceededMessage)
- [msdyncrm_marketingformId](#BKMK_msdyncrm_marketingformId)
- [msdyncrm_marketingformtemplate](#BKMK_msdyncrm_marketingformtemplate)
- [msdyncrm_marketingprovided](#BKMK_msdyncrm_marketingprovided)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_publishedformurl](#BKMK_msdyncrm_publishedformurl)
- [msdyncrm_purpose](#BKMK_msdyncrm_purpose)
- [msdyncrm_RedirectURL](#BKMK_msdyncrm_RedirectURL)
- [msdyncrm_successImageUrl](#BKMK_msdyncrm_successImageUrl)
- [msdyncrm_validForPageType](#BKMK_msdyncrm_validForPageType)
- [msdyncrm_visualstyle](#BKMK_msdyncrm_visualstyle)
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
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_allowPrefill"></a> msdyncrm_allowPrefill

|Property|Value|
|---|---|
|Description||
|DisplayName|**Prefill fields**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_allowprefill`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingform_allowprefill`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_alwaysgenerateleads"></a> msdyncrm_alwaysgenerateleads

|Property|Value|
|---|---|
|Description||
|DisplayName|**Always Generate Leads**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_alwaysgenerateleads`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingform_msdyncrm_alwaysgenerateleads`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_capturing"></a> msdyncrm_capturing

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form capture**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_capturing`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingform_capturing`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_capturing_configured"></a> msdyncrm_capturing_configured

|Property|Value|
|---|---|
|Description||
|DisplayName|**Capturing configured**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_capturing_configured`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_capturing_configured`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_capturing_data"></a> msdyncrm_capturing_data

|Property|Value|
|---|---|
|Description||
|DisplayName|**Capturing data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_capturing_data`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150000|

### <a name="BKMK_msdyncrm_capturing_scantime"></a> msdyncrm_capturing_scantime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Capturing Scan Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_capturing_scantime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyncrm_contactmatchingstrategy"></a> msdyncrm_contactmatchingstrategy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact form matching**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactmatchingstrategy`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_matchingstrategy|

### <a name="BKMK_msdyncrm_doubleoptincontentsettings"></a> msdyncrm_doubleoptincontentsettings

|Property|Value|
|---|---|
|Description|**Select the content settings to use for confirmation email.**|
|DisplayName|**Content settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_doubleoptincontentsettings`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_contentsettings|

### <a name="BKMK_msdyncrm_doubleoptinmessage"></a> msdyncrm_doubleoptinmessage

|Property|Value|
|---|---|
|Description|**Select the confirmation email to send contacts requesting to submit a form.**|
|DisplayName|**Double opt-in email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_doubleoptinmessage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingemail|

### <a name="BKMK_msdyncrm_doubleoptinthankyouformat"></a> msdyncrm_doubleoptinthankyouformat

|Property|Value|
|---|---|
|Description|**How to say Thank You**|
|DisplayName|**How to say thank you**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_doubleoptinthankyouformat`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_marketingform_msdyncrm_doubleoptinthankyouformat`|

#### msdyncrm_doubleoptinthankyouformat Choices/Options

|Value|Label|
|---|---|
|192350000|**Open the marketing page after confirmation**|
|192350001|**Open the web page after confirmation**|

### <a name="BKMK_msdyncrm_doubleoptinthankyoupage"></a> msdyncrm_doubleoptinthankyoupage

|Property|Value|
|---|---|
|Description|**Marketing Page displayed when customer triggers confirmation**|
|DisplayName|**Thank you marketing page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_doubleoptinthankyoupage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingpage|

### <a name="BKMK_msdyncrm_doubleoptinthankyouurl"></a> msdyncrm_doubleoptinthankyouurl

|Property|Value|
|---|---|
|Description|**Web Page displayed when customer triggers confirmation**|
|DisplayName|**Thank you web page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_doubleoptinthankyouurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyncrm_enabledoubleoptin"></a> msdyncrm_enabledoubleoptin

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable double opt-in**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_enabledoubleoptin`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingform_msdyncrm_enabledoubleoptin`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdyncrm_errorImageUrl"></a> msdyncrm_errorImageUrl

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
|DisplayName|**Error message**|
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

### <a name="BKMK_msdyncrm_eventmatchingstrategy"></a> msdyncrm_eventmatchingstrategy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event matching strategy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_eventmatchingstrategy`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyncrm_eventmatchingstrategyinfo"></a> msdyncrm_eventmatchingstrategyinfo

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event matching strategy info**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_eventmatchingstrategyinfo`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdyncrm_FormDefinition"></a> msdyncrm_FormDefinition

|Property|Value|
|---|---|
|Description|**JSON definition of the fields related to the Marketing form entity.**|
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

### <a name="BKMK_msdyncrm_info"></a> msdyncrm_info

|Property|Value|
|---|---|
|Description|**Info**|
|DisplayName|**Info**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_info`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

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

### <a name="BKMK_msdyncrm_keepsuccessfulsubmissions"></a> msdyncrm_keepsuccessfulsubmissions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_keepsuccessfulsubmissions`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingform_msdyncrm_keepsuccessfulsubmissions`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_leadmatchingstrategy"></a> msdyncrm_leadmatchingstrategy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead form matching**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadmatchingstrategy`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_matchingstrategy|

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

### <a name="BKMK_msdyncrm_marketingformId"></a> msdyncrm_marketingformId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing form**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_marketingformtemplate"></a> msdyncrm_marketingformtemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing form template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformtemplate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingformtemplate|

### <a name="BKMK_msdyncrm_marketingprovided"></a> msdyncrm_marketingprovided

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing Provided**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingprovided`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingform_msdyncrm_marketingprovided`|
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

### <a name="BKMK_msdyncrm_publishedformurl"></a> msdyncrm_publishedformurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Published form url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_publishedformurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdyncrm_validForPageType"></a> msdyncrm_validForPageType

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

#### msdyncrm_validForPageType Choices/Options

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
|Description|**Status of the marketing form**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingform_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 192350004<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the marketing form**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingform_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="1" tostatusid="192350003" /><allowedtransition sourcestatusid="1" tostatusid="2" /></allowedtransitions>`|
|2|Label: **Stopped**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="2" tostatusid="192350004" /><allowedtransition sourcestatusid="2" tostatusid="1" /><allowedtransition sourcestatusid="2" tostatusid="192350005" /></allowedtransitions>`|
|192350000|Label: **Draft**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350000" tostatusid="192350004" /><allowedtransition sourcestatusid="192350000" tostatusid="1" /><allowedtransition sourcestatusid="192350000" tostatusid="192350005" /></allowedtransitions>`|
|192350003|Label: **Live, editable**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350003" tostatusid="192350005" /><allowedtransition sourcestatusid="192350003" tostatusid="1" /></allowedtransitions>`|
|192350004|Label: **Expired**<br />State:1<br />TransitionData: None|
|192350005|Label: **Error**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350005" tostatusid="1" /><allowedtransition sourcestatusid="192350005" tostatusid="2" /></allowedtransitions>`|

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
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyncrm_externalhostedforminstructions](#BKMK_msdyncrm_externalhostedforminstructions)
- [msdyncrm_formtosave](#BKMK_msdyncrm_formtosave)
- [msdyncrm_organizationwhitelistdomain](#BKMK_msdyncrm_organizationwhitelistdomain)
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

### <a name="BKMK_msdyncrm_externalhostedforminstructions"></a> msdyncrm_externalhostedforminstructions

|Property|Value|
|---|---|
|Description||
|DisplayName|**ExternalHostedFormInstructions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_externalhostedforminstructions`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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
|GlobalChoiceName|`msdyncrm_marketingform_formtosave`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_organizationwhitelistdomain"></a> msdyncrm_organizationwhitelistdomain

|Property|Value|
|---|---|
|Description||
|DisplayName|**organizationwhitelistdomain**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_organizationwhitelistdomain`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

- [business_unit_msdyncrm_marketingform](#BKMK_business_unit_msdyncrm_marketingform)
- [lk_msdyncrm_marketingform_createdby](#BKMK_lk_msdyncrm_marketingform_createdby)
- [lk_msdyncrm_marketingform_createdonbehalfby](#BKMK_lk_msdyncrm_marketingform_createdonbehalfby)
- [lk_msdyncrm_marketingform_modifiedby](#BKMK_lk_msdyncrm_marketingform_modifiedby)
- [lk_msdyncrm_marketingform_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingform_modifiedonbehalfby)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings)
- [msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage](#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage)
- [msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate](#BKMK_msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy)
- [owner_msdyncrm_marketingform](#BKMK_owner_msdyncrm_marketingform)
- [team_msdyncrm_marketingform](#BKMK_team_msdyncrm_marketingform)
- [user_msdyncrm_marketingform](#BKMK_user_msdyncrm_marketingform)

### <a name="BKMK_business_unit_msdyncrm_marketingform"></a> business_unit_msdyncrm_marketingform

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingform](businessunit.md#BKMK_business_unit_msdyncrm_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingform_createdby"></a> lk_msdyncrm_marketingform_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingform_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingform_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingform_createdonbehalfby"></a> lk_msdyncrm_marketingform_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingform_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingform_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingform_modifiedby"></a> lk_msdyncrm_marketingform_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingform_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingform_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingform_modifiedonbehalfby"></a> lk_msdyncrm_marketingform_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingform_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingform_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings](msdyncrm_contentsettings.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`msdyncrm_doubleoptincontentsettings`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_doubleoptincontentsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage"></a> msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage

One-To-Many Relationship: [msdyncrm_marketingemail msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage](msdyncrm_marketingemail.md#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_marketingform_doubleoptinmessage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemail`|
|ReferencedAttribute|`msdyncrm_marketingemailid`|
|ReferencingAttribute|`msdyncrm_doubleoptinmessage`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_doubleoptinmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate"></a> msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate

One-To-Many Relationship: [msdyncrm_marketingformtemplate msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate](msdyncrm_marketingformtemplate.md#BKMK_msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingformtemplate`|
|ReferencedAttribute|`msdyncrm_marketingformtemplateid`|
|ReferencingAttribute|`msdyncrm_marketingformtemplate`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingformtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage

One-To-Many Relationship: [msdyncrm_marketingpage msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage](msdyncrm_marketingpage.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpage`|
|ReferencedAttribute|`msdyncrm_marketingpageid`|
|ReferencingAttribute|`msdyncrm_doubleoptinthankyoupage`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_doubleoptinthankyoupage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy

One-To-Many Relationship: [msdyncrm_matchingstrategy msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy](msdyncrm_matchingstrategy.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_contactmatchingstrategy)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_matchingstrategy`|
|ReferencedAttribute|`msdyncrm_matchingstrategyid`|
|ReferencingAttribute|`msdyncrm_contactmatchingstrategy`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_contactmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy

One-To-Many Relationship: [msdyncrm_matchingstrategy msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy](msdyncrm_matchingstrategy.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingform_leadmatchingstrategy)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_matchingstrategy`|
|ReferencedAttribute|`msdyncrm_matchingstrategyid`|
|ReferencingAttribute|`msdyncrm_leadmatchingstrategy`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_leadmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingform"></a> owner_msdyncrm_marketingform

One-To-Many Relationship: [owner owner_msdyncrm_marketingform](owner.md#BKMK_owner_msdyncrm_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingform"></a> team_msdyncrm_marketingform

One-To-Many Relationship: [team team_msdyncrm_marketingform](team.md#BKMK_team_msdyncrm_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingform"></a> user_msdyncrm_marketingform

One-To-Many Relationship: [systemuser user_msdyncrm_marketingform](systemuser.md#BKMK_user_msdyncrm_marketingform)

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

- [msdyncrm_marketingform_Annotations](#BKMK_msdyncrm_marketingform_Annotations)
- [msdyncrm_marketingform_AsyncOperations](#BKMK_msdyncrm_marketingform_AsyncOperations)
- [msdyncrm_marketingform_BulkDeleteFailures](#BKMK_msdyncrm_marketingform_BulkDeleteFailures)
- [msdyncrm_marketingform_MailboxTrackingFolders](#BKMK_msdyncrm_marketingform_MailboxTrackingFolders)
- [msdyncrm_marketingform_marketingformsubmission](#BKMK_msdyncrm_marketingform_marketingformsubmission)
- [msdyncrm_marketingform_msdyncrm_formpagetemplate](#BKMK_msdyncrm_marketingform_msdyncrm_formpagetemplate)
- [msdyncrm_marketingform_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingform_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingform_ProcessSession](#BKMK_msdyncrm_marketingform_ProcessSession)
- [msdyncrm_marketingform_SyncErrors](#BKMK_msdyncrm_marketingform_SyncErrors)
- [msdyncrm_msdyncrm_marketingform_contact_marketingformid](#BKMK_msdyncrm_msdyncrm_marketingform_contact_marketingformid)
- [msdyncrm_msdyncrm_marketingform_lead_marketingformid](#BKMK_msdyncrm_msdyncrm_marketingform_lead_marketingformid)
- [msdyncrm_msdyncrm_marketingform_msdyncrm_formpage](#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_formpage)
- [msdyncrm_msdyncrm_marketingform_msdyncrm_geopin](#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_geopin)
- [msdyncrm_msdyncrm_marketingform_msdyncrm_listform](#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_listform)
- [msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformactivity_marketingformid](#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformactivity_marketingformid)
- [msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformw](#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformw)
- [msdyncrm_msdyncrm_marketingform_msevtmgt_event](#BKMK_msdyncrm_msdyncrm_marketingform_msevtmgt_event)
- [msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId](#BKMK_msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId)
- [msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord](#BKMK_msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord)

### <a name="BKMK_msdyncrm_marketingform_Annotations"></a> msdyncrm_marketingform_Annotations

Many-To-One Relationship: [annotation msdyncrm_marketingform_Annotations](annotation.md#BKMK_msdyncrm_marketingform_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_AsyncOperations"></a> msdyncrm_marketingform_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingform_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingform_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_BulkDeleteFailures"></a> msdyncrm_marketingform_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingform_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingform_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_MailboxTrackingFolders"></a> msdyncrm_marketingform_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingform_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingform_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_marketingformsubmission"></a> msdyncrm_marketingform_marketingformsubmission

Many-To-One Relationship: [msdyncrm_marketingformsubmission msdyncrm_marketingform_marketingformsubmission](msdyncrm_marketingformsubmission.md#BKMK_msdyncrm_marketingform_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformsubmission`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_marketingformsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_msdyncrm_formpagetemplate"></a> msdyncrm_marketingform_msdyncrm_formpagetemplate

Many-To-One Relationship: [msdyncrm_formpagetemplate msdyncrm_marketingform_msdyncrm_formpagetemplate](msdyncrm_formpagetemplate.md#BKMK_msdyncrm_marketingform_msdyncrm_formpagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpagetemplate`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_msdyncrm_formpagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingform_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingform_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingform_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_ProcessSession"></a> msdyncrm_marketingform_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingform_ProcessSession](processsession.md#BKMK_msdyncrm_marketingform_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_SyncErrors"></a> msdyncrm_marketingform_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingform_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingform_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingform_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_contact_marketingformid"></a> msdyncrm_msdyncrm_marketingform_contact_marketingformid

Many-To-One Relationship: [contact msdyncrm_msdyncrm_marketingform_contact_marketingformid](contact.md#BKMK_msdyncrm_msdyncrm_marketingform_contact_marketingformid)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingform_contact_marketingformid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_lead_marketingformid"></a> msdyncrm_msdyncrm_marketingform_lead_marketingformid

Many-To-One Relationship: [lead msdyncrm_msdyncrm_marketingform_lead_marketingformid](lead.md#BKMK_msdyncrm_msdyncrm_marketingform_lead_marketingformid)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingform_lead_marketingformid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_formpage"></a> msdyncrm_msdyncrm_marketingform_msdyncrm_formpage

Many-To-One Relationship: [msdyncrm_formpage msdyncrm_msdyncrm_marketingform_msdyncrm_formpage](msdyncrm_formpage.md#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_formpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpage`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingform_msdyncrm_formpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_geopin"></a> msdyncrm_msdyncrm_marketingform_msdyncrm_geopin

Many-To-One Relationship: [msdyncrm_geopin msdyncrm_msdyncrm_marketingform_msdyncrm_geopin](msdyncrm_geopin.md#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_geopin`|
|ReferencingAttribute|`msdyncrm_marketingformgeopinsid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingform_msdyncrm_geopin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_listform"></a> msdyncrm_msdyncrm_marketingform_msdyncrm_listform

Many-To-One Relationship: [msdyncrm_listform msdyncrm_msdyncrm_marketingform_msdyncrm_listform](msdyncrm_listform.md#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_listform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_listform`|
|ReferencingAttribute|`msdyncrm_formid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingform_msdyncrm_listform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformactivity_marketingformid"></a> msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformactivity_marketingformid

Many-To-One Relationship: [msdyncrm_marketingformactivity msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformactivity_marketingformid](msdyncrm_marketingformactivity.md#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformactivity_marketingformid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformactivity`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformactivity_marketingformid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformw"></a> msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformw

Many-To-One Relationship: [msdyncrm_marketingformwhitelistrule msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformw](msdyncrm_marketingformwhitelistrule.md#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformw)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformwhitelistrule`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingform_msdyncrm_marketingformw`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_msevtmgt_event"></a> msdyncrm_msdyncrm_marketingform_msevtmgt_event

Many-To-One Relationship: [msevtmgt_event msdyncrm_msdyncrm_marketingform_msevtmgt_event](msevtmgt_event.md#BKMK_msdyncrm_msdyncrm_marketingform_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingform_msevtmgt_event`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId"></a> msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId

Many-To-One Relationship: [contact msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId](contact.md#BKMK_msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msgdpr_consentchangesourceformid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord"></a> msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord

Many-To-One Relationship: [msgdpr_gdprconsentchangerecord msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord](msgdpr_gdprconsentchangerecord.md#BKMK_msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msgdpr_gdprconsentchangerecord`|
|ReferencingAttribute|`msgdpr_consentchangesourceform`|
|ReferencedEntityNavigationPropertyName|`msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyncrm_marketingform_marketingformfield](#BKMK_msdyncrm_marketingform_marketingformfield)
- [msdyncrm_marketingform_msevtmgt_customregfield](#BKMK_msdyncrm_marketingform_msevtmgt_customregfield)
- [msdyncrm_msdyncrm_marketingform_systemuser](#BKMK_msdyncrm_msdyncrm_marketingform_systemuser)

### <a name="BKMK_msdyncrm_marketingform_marketingformfield"></a> msdyncrm_marketingform_marketingformfield

See [msdyncrm_marketingformfield msdyncrm_marketingform_marketingformfield Many-To-Many Relationship](msdyncrm_marketingformfield.md#BKMK_msdyncrm_marketingform_marketingformfield)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_marketingform_marketingformfield`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_marketingform_marketingformfield`|
|IntersectAttribute|`msdyncrm_marketingformid`|
|NavigationPropertyName|`msdyncrm_marketingform_marketingformfield`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_msevtmgt_customregfield"></a> msdyncrm_marketingform_msevtmgt_customregfield

See [msevtmgt_customregistrationfield msdyncrm_marketingform_msevtmgt_customregfield Many-To-Many Relationship](msevtmgt_customregistrationfield.md#BKMK_msdyncrm_marketingform_msevtmgt_customregfield)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_marketingform_msevtmgt_customregfield`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_marketingform_msevtmgt_customregfield`|
|IntersectAttribute|`msdyncrm_marketingformid`|
|NavigationPropertyName|`msdyncrm_marketingform_msevtmgt_customregfield`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_systemuser"></a> msdyncrm_msdyncrm_marketingform_systemuser

See [systemuser msdyncrm_msdyncrm_marketingform_systemuser Many-To-Many Relationship](systemuser.md#BKMK_msdyncrm_msdyncrm_marketingform_systemuser)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_msdyncrm_marketingform_systemuser`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_msdyncrm_marketingform_systemuser`|
|IntersectAttribute|`msdyncrm_marketingformid`|
|NavigationPropertyName|`msdyncrm_msdyncrm_marketingform_systemuser`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

