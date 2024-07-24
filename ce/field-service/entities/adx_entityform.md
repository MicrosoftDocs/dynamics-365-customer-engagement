---
title: "Basic Form (adx_entityform) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Basic Form (adx_entityform) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Basic Form (adx_entityform) table/entity reference

Defines the form to render for a given entity type.

## Messages

The following table lists the messages for the Basic Form (adx_entityform) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /adx_entityforms<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_entityforms(*adx_entityformid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_entityforms(*adx_entityformid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_entityforms<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /adx_entityforms(*adx_entityformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_entityforms(*adx_entityformid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_entityforms(*adx_entityformid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Basic Form (adx_entityform) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Basic Form (adx_entityform) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Basic Form** |
| **DisplayCollectionName** | **Basic Forms** |
| **SchemaName** | `adx_entityform` |
| **CollectionSchemaName** | `adx_entityforms` |
| **EntitySetName** | `adx_entityforms`|
| **LogicalName** | `adx_entityform` |
| **LogicalCollectionName** | `adx_entityforms` |
| **PrimaryIdAttribute** | `adx_entityformid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_appendquerystring](#BKMK_adx_appendquerystring)
- [adx_associatecurrentportaluser](#BKMK_adx_associatecurrentportaluser)
- [adx_attachfile](#BKMK_adx_attachfile)
- [adx_attachfileaccept](#BKMK_adx_attachfileaccept)
- [adx_attachfileacceptextensions](#BKMK_adx_attachfileacceptextensions)
- [adx_attachfileallowmultiple](#BKMK_adx_attachfileallowmultiple)
- [adx_attachfilelabel](#BKMK_adx_attachfilelabel)
- [adx_attachfilemaxsize](#BKMK_adx_attachfilemaxsize)
- [adx_attachfilerequired](#BKMK_adx_attachfilerequired)
- [adx_attachfilerequirederrormessage](#BKMK_adx_attachfilerequirederrormessage)
- [adx_attachfilerestrictaccept](#BKMK_adx_attachfilerestrictaccept)
- [adx_attachfilesaveoption](#BKMK_adx_attachfilesaveoption)
- [adx_AttachFileSizeErrorMessage](#BKMK_adx_AttachFileSizeErrorMessage)
- [adx_attachfilestoragelocation](#BKMK_adx_attachfilestoragelocation)
- [adx_AttachFileTypeErrorMessage](#BKMK_adx_AttachFileTypeErrorMessage)
- [adx_autogeneratesteps](#BKMK_adx_autogeneratesteps)
- [adx_captcharequired](#BKMK_adx_captcharequired)
- [adx_containername](#BKMK_adx_containername)
- [adx_entityformId](#BKMK_adx_entityformId)
- [adx_entityname](#BKMK_adx_entityname)
- [adx_entitypermissionsenabled](#BKMK_adx_entitypermissionsenabled)
- [adx_entitysourcetype](#BKMK_adx_entitysourcetype)
- [adx_forceallfieldsrequired](#BKMK_adx_forceallfieldsrequired)
- [adx_formname](#BKMK_adx_formname)
- [adx_geolocation_addresslinefieldname](#BKMK_adx_geolocation_addresslinefieldname)
- [adx_geolocation_cityfieldname](#BKMK_adx_geolocation_cityfieldname)
- [adx_geolocation_countryfieldname](#BKMK_adx_geolocation_countryfieldname)
- [adx_geolocation_countyfieldname](#BKMK_adx_geolocation_countyfieldname)
- [adx_geolocation_displaymap](#BKMK_adx_geolocation_displaymap)
- [adx_geolocation_enabled](#BKMK_adx_geolocation_enabled)
- [adx_geolocation_formattedaddressfieldname](#BKMK_adx_geolocation_formattedaddressfieldname)
- [adx_geolocation_latitudefieldname](#BKMK_adx_geolocation_latitudefieldname)
- [adx_geolocation_longitudefieldname](#BKMK_adx_geolocation_longitudefieldname)
- [adx_geolocation_maptype](#BKMK_adx_geolocation_maptype)
- [adx_geolocation_neighborhoodfieldname](#BKMK_adx_geolocation_neighborhoodfieldname)
- [adx_geolocation_postalcodefieldname](#BKMK_adx_geolocation_postalcodefieldname)
- [adx_geolocation_statefieldname](#BKMK_adx_geolocation_statefieldname)
- [adx_hideformonsuccess](#BKMK_adx_hideformonsuccess)
- [adx_instructions](#BKMK_adx_instructions)
- [adx_maximumnooffiles](#BKMK_adx_maximumnooffiles)
- [adx_mode](#BKMK_adx_mode)
- [adx_name](#BKMK_adx_name)
- [adx_nextbuttoncssclass](#BKMK_adx_nextbuttoncssclass)
- [adx_nextbuttontext](#BKMK_adx_nextbuttontext)
- [adx_onsuccess](#BKMK_adx_onsuccess)
- [adx_populatereferenceentitylookupfield](#BKMK_adx_populatereferenceentitylookupfield)
- [adx_portaluserlookupattributeisactivityparty](#BKMK_adx_portaluserlookupattributeisactivityparty)
- [adx_previousbuttoncssclass](#BKMK_adx_previousbuttoncssclass)
- [adx_previousbuttontext](#BKMK_adx_previousbuttontext)
- [adx_primarykeyname](#BKMK_adx_primarykeyname)
- [adx_provisionedlanguages](#BKMK_adx_provisionedlanguages)
- [adx_recommendedfieldsrequired](#BKMK_adx_recommendedfieldsrequired)
- [adx_recordidquerystringparametername](#BKMK_adx_recordidquerystringparametername)
- [adx_recordnotfoundmessage](#BKMK_adx_recordnotfoundmessage)
- [adx_recordsourceallowcreateonnull](#BKMK_adx_recordsourceallowcreateonnull)
- [adx_recordsourceentitylogicalname](#BKMK_adx_recordsourceentitylogicalname)
- [adx_recordsourcerelationshipname](#BKMK_adx_recordsourcerelationshipname)
- [adx_redirecturl](#BKMK_adx_redirecturl)
- [adx_redirecturlappendentityidquerystring](#BKMK_adx_redirecturlappendentityidquerystring)
- [adx_redirecturlcustomquerystring](#BKMK_adx_redirecturlcustomquerystring)
- [adx_redirecturlquerystringattribute](#BKMK_adx_redirecturlquerystringattribute)
- [adx_redirecturlquerystringattributeparamname](#BKMK_adx_redirecturlquerystringattributeparamname)
- [adx_redirecturlquerystringname](#BKMK_adx_redirecturlquerystringname)
- [adx_redirectwebpage](#BKMK_adx_redirectwebpage)
- [adx_referenceentitylogicalname](#BKMK_adx_referenceentitylogicalname)
- [adx_referenceentityprimarykeylogicalname](#BKMK_adx_referenceentityprimarykeylogicalname)
- [adx_referenceentityreadonlyformname](#BKMK_adx_referenceentityreadonlyformname)
- [adx_referenceentityrelationshipname](#BKMK_adx_referenceentityrelationshipname)
- [adx_referenceentityshowreadonlyform](#BKMK_adx_referenceentityshowreadonlyform)
- [adx_referenceentitysourcetype](#BKMK_adx_referenceentitysourcetype)
- [adx_referencequeryattributelogicalname](#BKMK_adx_referencequeryattributelogicalname)
- [adx_referencequerystringisprimarykey](#BKMK_adx_referencequerystringisprimarykey)
- [adx_referencequerystringname](#BKMK_adx_referencequerystringname)
- [adx_referencerecordsourcerelationshipname](#BKMK_adx_referencerecordsourcerelationshipname)
- [adx_referencetargetlookupattributelogicalname](#BKMK_adx_referencetargetlookupattributelogicalname)
- [adx_registerstartupscript](#BKMK_adx_registerstartupscript)
- [adx_renderwebresourcesinline](#BKMK_adx_renderwebresourcesinline)
- [adx_setentityreference](#BKMK_adx_setentityreference)
- [adx_Settings](#BKMK_adx_Settings)
- [adx_ShowCaptchaforAuthenticatedUsers](#BKMK_adx_ShowCaptchaforAuthenticatedUsers)
- [adx_showownerfields](#BKMK_adx_showownerfields)
- [adx_showunsupportedfields](#BKMK_adx_showunsupportedfields)
- [adx_storageaccountname](#BKMK_adx_storageaccountname)
- [adx_submitbuttonbusytext](#BKMK_adx_submitbuttonbusytext)
- [adx_submitbuttoncssclass](#BKMK_adx_submitbuttoncssclass)
- [adx_submitbuttontext](#BKMK_adx_submitbuttontext)
- [adx_successmessage](#BKMK_adx_successmessage)
- [adx_tabname](#BKMK_adx_tabname)
- [adx_targetentityportaluserlookupattribute](#BKMK_adx_targetentityportaluserlookupattribute)
- [adx_tooltipenabled](#BKMK_adx_tooltipenabled)
- [adx_validationgroup](#BKMK_adx_validationgroup)
- [adx_validationsummarycssclass](#BKMK_adx_validationsummarycssclass)
- [adx_validationsummaryheadertext](#BKMK_adx_validationsummaryheadertext)
- [adx_validationsummarylinksenabled](#BKMK_adx_validationsummarylinksenabled)
- [adx_validationsummarylinktext](#BKMK_adx_validationsummarylinktext)
- [adx_websiteid](#BKMK_adx_websiteid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_appendquerystring"></a> adx_appendquerystring

|Property|Value|
|---|---|
|Description||
|DisplayName|**Append Query String**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_appendquerystring`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_appendquerystring`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_associatecurrentportaluser"></a> adx_associatecurrentportaluser

|Property|Value|
|---|---|
|Description||
|DisplayName|**Associate Current Portal User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_associatecurrentportaluser`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_associatecurrentportaluser`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_attachfile"></a> adx_attachfile

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfile`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_attachfile`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_attachfileaccept"></a> adx_attachfileaccept

|Property|Value|
|---|---|
|Description|**The accept attribute specifies the MIME types of files that the server accepts through file upload. To specify more than one value, separate the values with a comma (e.g. audio/*,video/*,image/*).**|
|DisplayName|**Attach File MIME Type Accept**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfileaccept`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_adx_attachfileacceptextensions"></a> adx_attachfileacceptextensions

|Property|Value|
|---|---|
|Description|**The accept attribute specifies the extension types of files that the server accepts through file upload. To specify more than one value, separate the values with a comma (e.g. .docx,.pdf,.txt).**|
|DisplayName|**Attach File Extension Type Accept**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfileacceptextensions`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_adx_attachfileallowmultiple"></a> adx_attachfileallowmultiple

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File Allow Multiple**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfileallowmultiple`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_attachfileallowmultiple`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_attachfilelabel"></a> adx_attachfilelabel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilelabel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_attachfilemaxsize"></a> adx_attachfilemaxsize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Maximum File Size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilemaxsize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_attachfilerequired"></a> adx_attachfilerequired

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilerequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_attachfilerequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_attachfilerequirederrormessage"></a> adx_attachfilerequirederrormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File Required Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilerequirederrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_attachfilerestrictaccept"></a> adx_attachfilerestrictaccept

|Property|Value|
|---|---|
|Description||
|DisplayName|**Restrict Files To Accepted Types**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilerestrictaccept`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_attachfilerestrictaccept`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_attachfilesaveoption"></a> adx_attachfilesaveoption

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File Save Option**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilesaveoption`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entityform_adx_attachfilesaveoption`|

#### adx_attachfilesaveoption Choices/Options

|Value|Label|
|---|---|
|756150000|**Notes**|
|756150001|**Portal Comment**|

### <a name="BKMK_adx_AttachFileSizeErrorMessage"></a> adx_AttachFileSizeErrorMessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File Size Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilesizeerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_attachfilestoragelocation"></a> adx_attachfilestoragelocation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File Storage Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilestoragelocation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entityform_adx_attachfilestoragelocation`|

#### adx_attachfilestoragelocation Choices/Options

|Value|Label|
|---|---|
|756150000|**Note Attachment**|
|756150001|**Azure Blob Storage**|

### <a name="BKMK_adx_AttachFileTypeErrorMessage"></a> adx_AttachFileTypeErrorMessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attach File Type Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfiletypeerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_autogeneratesteps"></a> adx_autogeneratesteps

|Property|Value|
|---|---|
|Description||
|DisplayName|**Auto Generate Steps From Tabs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_autogeneratesteps`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_autogeneratesteps`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_captcharequired"></a> adx_captcharequired

|Property|Value|
|---|---|
|Description||
|DisplayName|**Captcha Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_captcharequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_captcharequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_containername"></a> adx_containername

|Property|Value|
|---|---|
|Description||
|DisplayName|**Container Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_containername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_entityformId"></a> adx_entityformId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Basic Form**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_entityformid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_entityname"></a> adx_entityname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Table Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entityname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_entitypermissionsenabled"></a> adx_entitypermissionsenabled

|Property|Value|
|---|---|
|Description|**Indicates whether or not the table permission provider will assert privileges.**|
|DisplayName|**Enable Table Permissions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entitypermissionsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_entitypermissionsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_entitysourcetype"></a> adx_entitysourcetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Table Source Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entitysourcetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entityform_adx_entitysourcetype`|

#### adx_entitysourcetype Choices/Options

|Value|Label|
|---|---|
|756150001|**Query String**|
|756150002|**Current Portal User**|
|756150003|**Record Associated to Current Portal User**|

### <a name="BKMK_adx_forceallfieldsrequired"></a> adx_forceallfieldsrequired

|Property|Value|
|---|---|
|Description||
|DisplayName|**Make All Fields Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forceallfieldsrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_forceallfieldsrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_formname"></a> adx_formname

|Property|Value|
|---|---|
|Description|**Shows the name of the entity form to render.**|
|DisplayName|**Form Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_formname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_addresslinefieldname"></a> adx_geolocation_addresslinefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Address Line Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_addresslinefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_cityfieldname"></a> adx_geolocation_cityfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**City Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_cityfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_countryfieldname"></a> adx_geolocation_countryfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Country/Region Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_countryfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_countyfieldname"></a> adx_geolocation_countyfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**County Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_countyfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_displaymap"></a> adx_geolocation_displaymap

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Map**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_displaymap`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_geolocation_displaymap`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_geolocation_enabled"></a> adx_geolocation_enabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_geolocation_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_geolocation_formattedaddressfieldname"></a> adx_geolocation_formattedaddressfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Formatted Address Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_formattedaddressfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_latitudefieldname"></a> adx_geolocation_latitudefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Latitude Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_latitudefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_longitudefieldname"></a> adx_geolocation_longitudefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Longitude Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_longitudefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_maptype"></a> adx_geolocation_maptype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Map Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_maptype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_entityform_adx_geolocation_maptype`|

#### adx_geolocation_maptype Choices/Options

|Value|Label|
|---|---|
|756150000|**Bing**|
|756150001|**Google**|
|756150002|**Esri**|

### <a name="BKMK_adx_geolocation_neighborhoodfieldname"></a> adx_geolocation_neighborhoodfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Neighborhood Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_neighborhoodfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_postalcodefieldname"></a> adx_geolocation_postalcodefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Zip/Postal Code Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_postalcodefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_geolocation_statefieldname"></a> adx_geolocation_statefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**State or Province Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocation_statefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_hideformonsuccess"></a> adx_hideformonsuccess

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hide Form on Success**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_hideformonsuccess`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_hideformonsuccess`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_instructions"></a> adx_instructions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Instructions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_instructions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_adx_maximumnooffiles"></a> adx_maximumnooffiles

|Property|Value|
|---|---|
|Description||
|DisplayName|**Maximum No Of Files**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_maximumnooffiles`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_mode"></a> adx_mode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_mode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`adx_entityform_adx_mode`|

#### adx_mode Choices/Options

|Value|Label|
|---|---|
|100000000|**Insert**|
|100000001|**Edit**|
|100000002|**ReadOnly**|

### <a name="BKMK_adx_name"></a> adx_name

|Property|Value|
|---|---|
|Description|**Type the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_nextbuttoncssclass"></a> adx_nextbuttoncssclass

|Property|Value|
|---|---|
|Description||
|DisplayName|**Next Button CSS Class**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_nextbuttoncssclass`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_nextbuttontext"></a> adx_nextbuttontext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Next Button Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_nextbuttontext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_onsuccess"></a> adx_onsuccess

|Property|Value|
|---|---|
|Description||
|DisplayName|**On Success**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_onsuccess`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_entityform_adx_onsuccess`|

#### adx_onsuccess Choices/Options

|Value|Label|
|---|---|
|756150000|**Display Success Message**|
|756150001|**Redirect**|

### <a name="BKMK_adx_populatereferenceentitylookupfield"></a> adx_populatereferenceentitylookupfield

|Property|Value|
|---|---|
|Description||
|DisplayName|**Populate Table Reference Lookup Field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_populatereferenceentitylookupfield`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_populatereferenceentitylookupfield`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_portaluserlookupattributeisactivityparty"></a> adx_portaluserlookupattributeisactivityparty

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Activity Party**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_portaluserlookupattributeisactivityparty`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_portaluserlookupattributeisactivityparty`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_previousbuttoncssclass"></a> adx_previousbuttoncssclass

|Property|Value|
|---|---|
|Description||
|DisplayName|**Previous Button CSS Class**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_previousbuttoncssclass`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_previousbuttontext"></a> adx_previousbuttontext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Previous Button Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_previousbuttontext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_primarykeyname"></a> adx_primarykeyname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Primary Key Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_primarykeyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_provisionedlanguages"></a> adx_provisionedlanguages

|Property|Value|
|---|---|
|Description||
|DisplayName|**Provisioned Languages**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_provisionedlanguages`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_recommendedfieldsrequired"></a> adx_recommendedfieldsrequired

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recommended Fields Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_recommendedfieldsrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_recommendedfieldsrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_recordidquerystringparametername"></a> adx_recordidquerystringparametername

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record ID Parameter Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_recordidquerystringparametername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_recordnotfoundmessage"></a> adx_recordnotfoundmessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record Not Found Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_recordnotfoundmessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_recordsourceallowcreateonnull"></a> adx_recordsourceallowcreateonnull

|Property|Value|
|---|---|
|Description|**This flag, when set to "true," allows the user to create a record if the record doesn't already exist and the Record Source Type is "Record Associated with Current Portal User."**|
|DisplayName|**Allow Create If Null**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_recordsourceallowcreateonnull`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_recordsourceallowcreateonnull`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_recordsourceentitylogicalname"></a> adx_recordsourceentitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record Source Table Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_recordsourceentitylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_recordsourcerelationshipname"></a> adx_recordsourcerelationshipname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Relationship Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_recordsourcerelationshipname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_adx_redirecturl"></a> adx_redirecturl

|Property|Value|
|---|---|
|Description|**Shows the URL to redirect to.**|
|DisplayName|**Redirect URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_redirecturl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|3000|

### <a name="BKMK_adx_redirecturlappendentityidquerystring"></a> adx_redirecturlappendentityidquerystring

|Property|Value|
|---|---|
|Description||
|DisplayName|**Append Table ID To Query String**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_redirecturlappendentityidquerystring`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_redirecturlappendentityidquerystring`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_redirecturlcustomquerystring"></a> adx_redirecturlcustomquerystring

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom Query String**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_redirecturlcustomquerystring`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_adx_redirecturlquerystringattribute"></a> adx_redirecturlquerystringattribute

|Property|Value|
|---|---|
|Description|**Add an attribute value as a query string value by specifying the logical name of the attribute to assign its value to the query string.**|
|DisplayName|**Attribute Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_redirecturlquerystringattribute`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_redirecturlquerystringattributeparamname"></a> adx_redirecturlquerystringattributeparamname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Query String Parameter Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_redirecturlquerystringattributeparamname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_redirecturlquerystringname"></a> adx_redirecturlquerystringname

|Property|Value|
|---|---|
|Description|**The url to redirect to is dynamically retrieved from the query string using this parameter name**|
|DisplayName|**Redirect URL Query String Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_redirecturlquerystringname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_redirectwebpage"></a> adx_redirectwebpage

|Property|Value|
|---|---|
|Description|**Web Page to redirect to.**|
|DisplayName|**Redirect Web Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_redirectwebpage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_adx_referenceentitylogicalname"></a> adx_referenceentitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Table name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referenceentitylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_referenceentityprimarykeylogicalname"></a> adx_referenceentityprimarykeylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Table Primary Key Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referenceentityprimarykeylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_referenceentityreadonlyformname"></a> adx_referenceentityreadonlyformname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Entity ReadOnly Form Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referenceentityreadonlyformname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_referenceentityrelationshipname"></a> adx_referenceentityrelationshipname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Entity Relationship Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referenceentityrelationshipname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_adx_referenceentityshowreadonlyform"></a> adx_referenceentityshowreadonlyform

|Property|Value|
|---|---|
|Description||
|DisplayName|**Show Reference Entity ReadOnly Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referenceentityshowreadonlyform`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_referenceentityshowreadonlyform`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_referenceentitysourcetype"></a> adx_referenceentitysourcetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referenceentitysourcetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entityform_adx_referenceentitysourcetype`|

#### adx_referenceentitysourcetype Choices/Options

|Value|Label|
|---|---|
|756150000|**Query String**|
|756150001|**Record Associated to Current Portal User**|

### <a name="BKMK_adx_referencequeryattributelogicalname"></a> adx_referencequeryattributelogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Query Attribute Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referencequeryattributelogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_referencequerystringisprimarykey"></a> adx_referencequerystringisprimarykey

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Query String Is Primary Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referencequerystringisprimarykey`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_referencequerystringisprimarykey`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_referencequerystringname"></a> adx_referencequerystringname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Query String Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referencequerystringname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_referencerecordsourcerelationshipname"></a> adx_referencerecordsourcerelationshipname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record Source Relationship Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referencerecordsourcerelationshipname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_referencetargetlookupattributelogicalname"></a> adx_referencetargetlookupattributelogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Target Lookup Attribute Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referencetargetlookupattributelogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_registerstartupscript"></a> adx_registerstartupscript

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom JavaScript**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_registerstartupscript`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_adx_renderwebresourcesinline"></a> adx_renderwebresourcesinline

|Property|Value|
|---|---|
|Description||
|DisplayName|**Render Web Resources Inline**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_renderwebresourcesinline`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_renderwebresourcesinline`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_setentityreference"></a> adx_setentityreference

|Property|Value|
|---|---|
|Description||
|DisplayName|**Set Table Reference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_setentityreference`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_setentityreference`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_Settings"></a> adx_Settings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_settings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_adx_ShowCaptchaforAuthenticatedUsers"></a> adx_ShowCaptchaforAuthenticatedUsers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Show Captcha for Authenticated Users**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_showcaptchaforauthenticatedusers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_showcaptchaforauthenticatedusers`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_showownerfields"></a> adx_showownerfields

|Property|Value|
|---|---|
|Description||
|DisplayName|**Show Owner Fields**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_showownerfields`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_showownerfields`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_showunsupportedfields"></a> adx_showunsupportedfields

|Property|Value|
|---|---|
|Description||
|DisplayName|**Show Unsupported Fields**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_showunsupportedfields`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_showunsupportedfields`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_storageaccountname"></a> adx_storageaccountname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Storage Account Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_storageaccountname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_submitbuttonbusytext"></a> adx_submitbuttonbusytext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Submit Button Busy Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_submitbuttonbusytext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_submitbuttoncssclass"></a> adx_submitbuttoncssclass

|Property|Value|
|---|---|
|Description||
|DisplayName|**Submit Button CSS Class**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_submitbuttoncssclass`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_submitbuttontext"></a> adx_submitbuttontext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Submit Button Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_submitbuttontext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_successmessage"></a> adx_successmessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Success Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_successmessage`|
|RequiredLevel|Recommended|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_tabname"></a> adx_tabname

|Property|Value|
|---|---|
|Description|**The name of the tab on an entity form to render.**|
|DisplayName|**Tab Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_tabname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_targetentityportaluserlookupattribute"></a> adx_targetentityportaluserlookupattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Portal User Lookup Column**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_targetentityportaluserlookupattribute`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_tooltipenabled"></a> adx_tooltipenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**ToolTip Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_tooltipenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_tooltipenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_validationgroup"></a> adx_validationgroup

|Property|Value|
|---|---|
|Description||
|DisplayName|**Validation Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_validationgroup`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_validationsummarycssclass"></a> adx_validationsummarycssclass

|Property|Value|
|---|---|
|Description||
|DisplayName|**Validation Summary CSS Class**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_validationsummarycssclass`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_validationsummaryheadertext"></a> adx_validationsummaryheadertext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Validation Summary Header Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_validationsummaryheadertext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_validationsummarylinksenabled"></a> adx_validationsummarylinksenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable Validation Summary Links**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_validationsummarylinksenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityform_adx_validationsummarylinksenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_validationsummarylinktext"></a> adx_validationsummarylinktext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Validation Summary Link Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_validationsummarylinktext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Website entity associated with this record.**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_website|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in the solution options.**|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Shows the status of the Form Step.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_entityform_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the Entity Form's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_entityform_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
- [OrganizationId](#BKMK_OrganizationId)
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in the solution options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was updated. The date and time are displayed in the time zone selected in the solution options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Shows the organization.**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [adx_entityform_redirectwebpage](#BKMK_adx_entityform_redirectwebpage)
- [adx_website_entityform](#BKMK_adx_website_entityform)
- [lk_adx_entityform_createdby](#BKMK_lk_adx_entityform_createdby)
- [lk_adx_entityform_createdonbehalfby](#BKMK_lk_adx_entityform_createdonbehalfby)
- [lk_adx_entityform_modifiedby](#BKMK_lk_adx_entityform_modifiedby)
- [lk_adx_entityform_modifiedonbehalfby](#BKMK_lk_adx_entityform_modifiedonbehalfby)
- [organization_adx_entityform](#BKMK_organization_adx_entityform)

### <a name="BKMK_adx_entityform_redirectwebpage"></a> adx_entityform_redirectwebpage

One-To-Many Relationship: [adx_webpage adx_entityform_redirectwebpage](adx_webpage.md#BKMK_adx_entityform_redirectwebpage)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_redirectwebpage`|
|ReferencingEntityNavigationPropertyName|`adx_redirectwebpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_entityform"></a> adx_website_entityform

One-To-Many Relationship: [adx_website adx_website_entityform](adx_website.md#BKMK_adx_website_entityform)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencingEntityNavigationPropertyName|`adx_websiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entityform_createdby"></a> lk_adx_entityform_createdby

One-To-Many Relationship: [systemuser lk_adx_entityform_createdby](systemuser.md#BKMK_lk_adx_entityform_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entityform_createdonbehalfby"></a> lk_adx_entityform_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_entityform_createdonbehalfby](systemuser.md#BKMK_lk_adx_entityform_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entityform_modifiedby"></a> lk_adx_entityform_modifiedby

One-To-Many Relationship: [systemuser lk_adx_entityform_modifiedby](systemuser.md#BKMK_lk_adx_entityform_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entityform_modifiedonbehalfby"></a> lk_adx_entityform_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_entityform_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_entityform_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_adx_entityform"></a> organization_adx_entityform

One-To-Many Relationship: [organization organization_adx_entityform](organization.md#BKMK_organization_adx_entityform)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_entityform_AsyncOperations](#BKMK_adx_entityform_AsyncOperations)
- [adx_entityform_BulkDeleteFailures](#BKMK_adx_entityform_BulkDeleteFailures)
- [adx_entityform_entityformmetadata_entityformforcreate](#BKMK_adx_entityform_entityformmetadata_entityformforcreate)
- [adx_entityform_MailboxTrackingFolders](#BKMK_adx_entityform_MailboxTrackingFolders)
- [adx_entityform_PrincipalObjectAttributeAccesses](#BKMK_adx_entityform_PrincipalObjectAttributeAccesses)
- [adx_entityform_ProcessSession](#BKMK_adx_entityform_ProcessSession)
- [adx_entityform_SyncErrors](#BKMK_adx_entityform_SyncErrors)
- [adx_entityform_webformmetadata_entityformforcreate](#BKMK_adx_entityform_webformmetadata_entityformforcreate)
- [adx_entityformmetadata_entityform](#BKMK_adx_entityformmetadata_entityform)
- [adx_webpage_entityform](#BKMK_adx_webpage_entityform)

### <a name="BKMK_adx_entityform_AsyncOperations"></a> adx_entityform_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_entityform_AsyncOperations](asyncoperation.md#BKMK_adx_entityform_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityform_BulkDeleteFailures"></a> adx_entityform_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_entityform_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_entityform_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityform_entityformmetadata_entityformforcreate"></a> adx_entityform_entityformmetadata_entityformforcreate

Many-To-One Relationship: [adx_entityformmetadata adx_entityform_entityformmetadata_entityformforcreate](adx_entityformmetadata.md#BKMK_adx_entityform_entityformmetadata_entityformforcreate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entityformmetadata`|
|ReferencingAttribute|`adx_entityformforcreate`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_entityformmetadata_entityformforcreate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityform_MailboxTrackingFolders"></a> adx_entityform_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_entityform_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_entityform_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityform_PrincipalObjectAttributeAccesses"></a> adx_entityform_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_entityform_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_entityform_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityform_ProcessSession"></a> adx_entityform_ProcessSession

Many-To-One Relationship: [processsession adx_entityform_ProcessSession](processsession.md#BKMK_adx_entityform_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityform_SyncErrors"></a> adx_entityform_SyncErrors

Many-To-One Relationship: [syncerror adx_entityform_SyncErrors](syncerror.md#BKMK_adx_entityform_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityform_webformmetadata_entityformforcreate"></a> adx_entityform_webformmetadata_entityformforcreate

Many-To-One Relationship: [adx_webformmetadata adx_entityform_webformmetadata_entityformforcreate](adx_webformmetadata.md#BKMK_adx_entityform_webformmetadata_entityformforcreate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformmetadata`|
|ReferencingAttribute|`adx_entityformforcreateinwebformmetadata`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_webformmetadata_entityformforcreate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityformmetadata_entityform"></a> adx_entityformmetadata_entityform

Many-To-One Relationship: [adx_entityformmetadata adx_entityformmetadata_entityform](adx_entityformmetadata.md#BKMK_adx_entityformmetadata_entityform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entityformmetadata`|
|ReferencingAttribute|`adx_entityform`|
|ReferencedEntityNavigationPropertyName|`adx_entityformmetadata_entityform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_entityform"></a> adx_webpage_entityform

Many-To-One Relationship: [adx_webpage adx_webpage_entityform](adx_webpage.md#BKMK_adx_webpage_entityform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_entityform`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_entityform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

