---
title: "Form Step (adx_webformstep) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Form Step (adx_webformstep) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Form Step (adx_webformstep) table/entity reference

Defines the flow logic of the form's user experience such as steps and conditional branching.

## Messages

The following table lists the messages for the Form Step (adx_webformstep) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /adx_webformsteps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_webformsteps(*adx_webformstepid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_webformsteps(*adx_webformstepid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_webformsteps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /adx_webformsteps(*adx_webformstepid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_webformsteps(*adx_webformstepid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_webformsteps(*adx_webformstepid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Form Step (adx_webformstep) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Form Step (adx_webformstep) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Form Step** |
| **DisplayCollectionName** | **Form Steps** |
| **SchemaName** | `adx_webformstep` |
| **CollectionSchemaName** | `adx_webformsteps` |
| **EntitySetName** | `adx_webformsteps`|
| **LogicalName** | `adx_webformstep` |
| **LogicalCollectionName** | `adx_webformsteps` |
| **PrimaryIdAttribute** | `adx_webformstepid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_accept](#BKMK_adx_accept)
- [adx_allowmultiplefiles](#BKMK_adx_allowmultiplefiles)
- [adx_appendquerystring](#BKMK_adx_appendquerystring)
- [adx_associatecurrentportaluser](#BKMK_adx_associatecurrentportaluser)
- [adx_attachfile](#BKMK_adx_attachfile)
- [adx_attachfilelabel](#BKMK_adx_attachfilelabel)
- [adx_attachfilemaxsize](#BKMK_adx_attachfilemaxsize)
- [adx_attachfilerequired](#BKMK_adx_attachfilerequired)
- [adx_attachfilerequirederrormessage](#BKMK_adx_attachfilerequirederrormessage)
- [adx_attachfilerestrictaccept](#BKMK_adx_attachfilerestrictaccept)
- [adx_attachfilesizeerrormessage](#BKMK_adx_attachfilesizeerrormessage)
- [adx_attachfilestoragelocation](#BKMK_adx_attachfilestoragelocation)
- [adx_attachfiletypeerrormessage](#BKMK_adx_attachfiletypeerrormessage)
- [adx_autogeneratesteps](#BKMK_adx_autogeneratesteps)
- [adx_autonumberattributelogicalname](#BKMK_adx_autonumberattributelogicalname)
- [adx_autonumberdefinitionname](#BKMK_adx_autonumberdefinitionname)
- [adx_captcharequired](#BKMK_adx_captcharequired)
- [adx_condition](#BKMK_adx_condition)
- [adx_conditiondefaultnextstep](#BKMK_adx_conditiondefaultnextstep)
- [adx_containername](#BKMK_adx_containername)
- [adx_createautonumber](#BKMK_adx_createautonumber)
- [adx_editexistingrecordpermitted](#BKMK_adx_editexistingrecordpermitted)
- [adx_editexpiredmessage](#BKMK_adx_editexpiredmessage)
- [adx_editexpiredstatecode](#BKMK_adx_editexpiredstatecode)
- [adx_editexpiredstatusreason](#BKMK_adx_editexpiredstatusreason)
- [adx_editnotpermittedmessage](#BKMK_adx_editnotpermittedmessage)
- [adx_entitypermissionsenabled](#BKMK_adx_entitypermissionsenabled)
- [adx_entitysourcestep](#BKMK_adx_entitysourcestep)
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
- [adx_loadeventkeyname](#BKMK_adx_loadeventkeyname)
- [adx_loguser](#BKMK_adx_loguser)
- [adx_maximumnooffiles](#BKMK_adx_maximumnooffiles)
- [adx_mode](#BKMK_adx_mode)
- [adx_movepreviouseventkeyname](#BKMK_adx_movepreviouseventkeyname)
- [adx_movepreviouspermitted](#BKMK_adx_movepreviouspermitted)
- [adx_multiplerecordsperuserpermitted](#BKMK_adx_multiplerecordsperuserpermitted)
- [adx_name](#BKMK_adx_name)
- [adx_nextbuttoncssclass](#BKMK_adx_nextbuttoncssclass)
- [adx_nextbuttontext](#BKMK_adx_nextbuttontext)
- [adx_nextstep](#BKMK_adx_nextstep)
- [adx_populatereferenceentitylookupfield](#BKMK_adx_populatereferenceentitylookupfield)
- [adx_portaluserlookupattributeisactivityparty](#BKMK_adx_portaluserlookupattributeisactivityparty)
- [adx_postbackurl](#BKMK_adx_postbackurl)
- [adx_previousbuttoncssclass](#BKMK_adx_previousbuttoncssclass)
- [adx_previousbuttontext](#BKMK_adx_previousbuttontext)
- [adx_previousstep](#BKMK_adx_previousstep)
- [adx_primarykeyattributelogicalname](#BKMK_adx_primarykeyattributelogicalname)
- [adx_primarykeyquerystringparametername](#BKMK_adx_primarykeyquerystringparametername)
- [adx_provisionedlanguages](#BKMK_adx_provisionedlanguages)
- [adx_recommendedfieldsrequired](#BKMK_adx_recommendedfieldsrequired)
- [adx_recordnotfoundmessage](#BKMK_adx_recordnotfoundmessage)
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
- [adx_referenceentitystep](#BKMK_adx_referenceentitystep)
- [adx_referencequeryattributelogicalname](#BKMK_adx_referencequeryattributelogicalname)
- [adx_referencequerystringisprimarykey](#BKMK_adx_referencequerystringisprimarykey)
- [adx_referencequerystringname](#BKMK_adx_referencequerystringname)
- [adx_referencerecordsourcerelationshipname](#BKMK_adx_referencerecordsourcerelationshipname)
- [adx_referencesourceentitylogicalname](#BKMK_adx_referencesourceentitylogicalname)
- [adx_referencetargetlookupattributelogicalname](#BKMK_adx_referencetargetlookupattributelogicalname)
- [adx_registerstartupscript](#BKMK_adx_registerstartupscript)
- [adx_renderwebresourcesinline](#BKMK_adx_renderwebresourcesinline)
- [adx_savedeventkeyname](#BKMK_adx_savedeventkeyname)
- [adx_savingeventkeyname](#BKMK_adx_savingeventkeyname)
- [adx_setentityreference](#BKMK_adx_setentityreference)
- [adx_Settings](#BKMK_adx_Settings)
- [adx_showcaptchaforauthenticatedusers](#BKMK_adx_showcaptchaforauthenticatedusers)
- [adx_showownerfields](#BKMK_adx_showownerfields)
- [adx_showunsupportedfields](#BKMK_adx_showunsupportedfields)
- [adx_storageaccountname](#BKMK_adx_storageaccountname)
- [adx_submitbuttonbusytext](#BKMK_adx_submitbuttonbusytext)
- [adx_submitbuttoncssclass](#BKMK_adx_submitbuttoncssclass)
- [adx_submitbuttontext](#BKMK_adx_submitbuttontext)
- [adx_submiteventkeyname](#BKMK_adx_submiteventkeyname)
- [adx_successmessage](#BKMK_adx_successmessage)
- [adx_tabname](#BKMK_adx_tabname)
- [adx_targetentitylogicalname](#BKMK_adx_targetentitylogicalname)
- [adx_targetentityportaluserlookupattribute](#BKMK_adx_targetentityportaluserlookupattribute)
- [adx_targetentityprimarykeylogicalname](#BKMK_adx_targetentityprimarykeylogicalname)
- [adx_title](#BKMK_adx_title)
- [adx_tooltipenabled](#BKMK_adx_tooltipenabled)
- [adx_type](#BKMK_adx_type)
- [adx_usercontrolpath](#BKMK_adx_usercontrolpath)
- [adx_usercontroltitle](#BKMK_adx_usercontroltitle)
- [adx_userhostaddressattributelogicalname](#BKMK_adx_userhostaddressattributelogicalname)
- [adx_useridentitynameattributelogicalname](#BKMK_adx_useridentitynameattributelogicalname)
- [adx_validationgroup](#BKMK_adx_validationgroup)
- [adx_validationsummarycssclass](#BKMK_adx_validationsummarycssclass)
- [adx_validationsummaryheadertext](#BKMK_adx_validationsummaryheadertext)
- [adx_validationsummarylinksenabled](#BKMK_adx_validationsummarylinksenabled)
- [adx_validationsummarylinktext](#BKMK_adx_validationsummarylinktext)
- [adx_webform](#BKMK_adx_webform)
- [adx_webformstepId](#BKMK_adx_webformstepId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_accept"></a> adx_accept

|Property|Value|
|---|---|
|Description|**The accept attribute specifies the MIME types of files that the server accepts through file upload. To specify more than one value, separate the values with a comma (e.g. audio/*,video/*,image/*).**|
|DisplayName|**Accept**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_accept`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_allowmultiplefiles"></a> adx_allowmultiplefiles

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow Multiple Files**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_allowmultiplefiles`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_allowmultiplefiles`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|GlobalChoiceName|`adx_webformstep_adx_appendquerystring`|
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
|GlobalChoiceName|`adx_webformstep_adx_associatecurrentportaluser`|
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
|GlobalChoiceName|`adx_webformstep_adx_attachfile`|
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
|DisplayName|**Attach File Maximum Size**|
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
|GlobalChoiceName|`adx_webformstep_adx_attachfilerequired`|
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
|DisplayName|**Attach File Restrict Accept**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attachfilerestrictaccept`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_attachfilerestrictaccept`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_attachfilesizeerrormessage"></a> adx_attachfilesizeerrormessage

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
|GlobalChoiceName|`adx_webformstep_adx_attachfilestoragelocation`|

#### adx_attachfilestoragelocation Choices/Options

|Value|Label|
|---|---|
|756150000|**Note Document**|
|756150001|**Azure Blob Storage**|

### <a name="BKMK_adx_attachfiletypeerrormessage"></a> adx_attachfiletypeerrormessage

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
|GlobalChoiceName|`adx_webformstep_adx_autogeneratesteps`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_autonumberattributelogicalname"></a> adx_autonumberattributelogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Auto Number Attribute Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_autonumberattributelogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_autonumberdefinitionname"></a> adx_autonumberdefinitionname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Auto Number Definition Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_autonumberdefinitionname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|GlobalChoiceName|`adx_webformstep_adx_captcharequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_condition"></a> adx_condition

|Property|Value|
|---|---|
|Description||
|DisplayName|**Condition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_condition`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_conditiondefaultnextstep"></a> adx_conditiondefaultnextstep

|Property|Value|
|---|---|
|Description|**If the condition test fails, this is the next step.**|
|DisplayName|**Condition Default Next Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_conditiondefaultnextstep`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webformstep|

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

### <a name="BKMK_adx_createautonumber"></a> adx_createautonumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**Create Auto Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_createautonumber`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_createautonumber`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_editexistingrecordpermitted"></a> adx_editexistingrecordpermitted

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Existing Record Permitted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editexistingrecordpermitted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_editexistingrecordpermitted`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_editexpiredmessage"></a> adx_editexpiredmessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Expired Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editexpiredmessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_adx_editexpiredstatecode"></a> adx_editexpiredstatecode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Expired State Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editexpiredstatecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_editexpiredstatusreason"></a> adx_editexpiredstatusreason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Expired Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editexpiredstatusreason`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_editnotpermittedmessage"></a> adx_editnotpermittedmessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Not Permitted Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editnotpermittedmessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_adx_entitypermissionsenabled"></a> adx_entitypermissionsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable Table Permissions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entitypermissionsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_entitypermissionsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_entitysourcestep"></a> adx_entitysourcestep

|Property|Value|
|---|---|
|Description|**Unique identifier for Form Step associated with Form Step.**|
|DisplayName|**Entity Source Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entitysourcestep`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webformstep|

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
|GlobalChoiceName|`adx_webformstep_adx_entitysourcetype`|

#### adx_entitysourcetype Choices/Options

|Value|Label|
|---|---|
|100000001|**Query String**|
|100000002|**Current Portal User**|
|100000003|**Result From Previous Step**|
|100000004|**Record Associated to Current Portal User**|

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
|GlobalChoiceName|`adx_webformstep_adx_forceallfieldsrequired`|
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
|RequiredLevel|None|
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
|GlobalChoiceName|`adx_webformstep_adx_geolocation_displaymap`|
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
|GlobalChoiceName|`adx_webformstep_adx_geolocation_enabled`|
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
|GlobalChoiceName|`adx_webformstep_adx_geolocation_maptype`|

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
|GlobalChoiceName|`adx_webformstep_adx_hideformonsuccess`|
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

### <a name="BKMK_adx_loadeventkeyname"></a> adx_loadeventkeyname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Load Event Key Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_loadeventkeyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_adx_loguser"></a> adx_loguser

|Property|Value|
|---|---|
|Description||
|DisplayName|**Log User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_loguser`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_loguser`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|GlobalChoiceName|`adx_webformstep_adx_mode`|

#### adx_mode Choices/Options

|Value|Label|
|---|---|
|100000000|**Insert**|
|100000001|**Edit**|
|100000002|**ReadOnly**|

### <a name="BKMK_adx_movepreviouseventkeyname"></a> adx_movepreviouseventkeyname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Move Previous Event Key Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_movepreviouseventkeyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_adx_movepreviouspermitted"></a> adx_movepreviouspermitted

|Property|Value|
|---|---|
|Description||
|DisplayName|**Move Previous Permitted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_movepreviouspermitted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_movepreviouspermitted`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_multiplerecordsperuserpermitted"></a> adx_multiplerecordsperuserpermitted

|Property|Value|
|---|---|
|Description||
|DisplayName|**Multiple Records Per User Permitted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_multiplerecordsperuserpermitted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_multiplerecordsperuserpermitted`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_adx_nextstep"></a> adx_nextstep

|Property|Value|
|---|---|
|Description|**Pointer to the next step.**|
|DisplayName|**Next Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_nextstep`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|adx_webformstep|

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
|GlobalChoiceName|`adx_webformstep_adx_populatereferenceentitylookupfield`|
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
|GlobalChoiceName|`adx_webformstep_adx_portaluserlookupattributeisactivityparty`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_postbackurl"></a> adx_postbackurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Post Back URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_postbackurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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

### <a name="BKMK_adx_previousstep"></a> adx_previousstep

|Property|Value|
|---|---|
|Description|**Pointer to the previous step.**|
|DisplayName|**Previous Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_previousstep`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|adx_webformstep|

### <a name="BKMK_adx_primarykeyattributelogicalname"></a> adx_primarykeyattributelogicalname

|Property|Value|
|---|---|
|Description|**The logical name of the primary key attribute of the target entity.**|
|DisplayName|**Primary Key Attribute Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_primarykeyattributelogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_primarykeyquerystringparametername"></a> adx_primarykeyquerystringparametername

|Property|Value|
|---|---|
|Description||
|DisplayName|**Primary Key Query String Parameter Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_primarykeyquerystringparametername`|
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
|GlobalChoiceName|`adx_webformstep_adx_recommendedfieldsrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|MaxLength|100|

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
|MaxLength|300|

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
|GlobalChoiceName|`adx_webformstep_adx_redirecturlappendentityidquerystring`|
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
|GlobalChoiceName|`adx_webformstep_adx_referenceentityshowreadonlyform`|
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
|DefaultFormValue|100000001|
|GlobalChoiceName|`adx_webformstep_adx_referenceentitysourcetype`|

#### adx_referenceentitysourcetype Choices/Options

|Value|Label|
|---|---|
|100000000|**Query String**|
|100000001|**Previous Step**|
|100000002|**Record Associated to Current Portal User**|

### <a name="BKMK_adx_referenceentitystep"></a> adx_referenceentitystep

|Property|Value|
|---|---|
|Description|**Unique identifier for Form Step associated with Form Step.**|
|DisplayName|**Reference Entity Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referenceentitystep`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webformstep|

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
|GlobalChoiceName|`adx_webformstep_adx_referencequerystringisprimarykey`|
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

### <a name="BKMK_adx_referencesourceentitylogicalname"></a> adx_referencesourceentitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference Source Table name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referencesourceentitylogicalname`|
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
|Description|**Shows your custom JavaScript that will be placed at the bottom of the page right before the closing </form> element.**|
|DisplayName|**Custom JavaScript**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_registerstartupscript`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

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
|GlobalChoiceName|`adx_webformstep_adx_renderwebresourcesinline`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_savedeventkeyname"></a> adx_savedeventkeyname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Saved Event Key Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_savedeventkeyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_adx_savingeventkeyname"></a> adx_savingeventkeyname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Saving Event Key Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_savingeventkeyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

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
|GlobalChoiceName|`adx_webformstep_adx_setentityreference`|
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

### <a name="BKMK_adx_showcaptchaforauthenticatedusers"></a> adx_showcaptchaforauthenticatedusers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Show Captcha for authenticated users**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_showcaptchaforauthenticatedusers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webformstep_adx_showcaptchaforauthenticatedusers`|
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
|GlobalChoiceName|`adx_webformstep_adx_showownerfields`|
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
|GlobalChoiceName|`adx_webformstep_adx_showunsupportedfields`|
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

### <a name="BKMK_adx_submiteventkeyname"></a> adx_submiteventkeyname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Submit Event Key Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_submiteventkeyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

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

### <a name="BKMK_adx_targetentitylogicalname"></a> adx_targetentitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target Table name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_targetentitylogicalname`|
|RequiredLevel|Recommended|
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

### <a name="BKMK_adx_targetentityprimarykeylogicalname"></a> adx_targetentityprimarykeylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target Entity Primary Key Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_targetentityprimarykeylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_title"></a> adx_title

|Property|Value|
|---|---|
|Description||
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_title`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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
|GlobalChoiceName|`adx_webformstep_adx_tooltipenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_type"></a> adx_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`adx_webformstep_adx_type`|

#### adx_type Choices/Options

|Value|Label|
|---|---|
|100000000|**Condition**|
|100000001|**Load Form**|
|100000002|**Load Tab**|
|100000003|**Redirect**|
|100000004|**Load User Control**|

### <a name="BKMK_adx_usercontrolpath"></a> adx_usercontrolpath

|Property|Value|
|---|---|
|Description||
|DisplayName|**User Control Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_usercontrolpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_adx_usercontroltitle"></a> adx_usercontroltitle

|Property|Value|
|---|---|
|Description||
|DisplayName|**User Control Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_usercontroltitle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_userhostaddressattributelogicalname"></a> adx_userhostaddressattributelogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**User Host Address Attribute Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_userhostaddressattributelogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_useridentitynameattributelogicalname"></a> adx_useridentitynameattributelogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**User Identity Name Attribute Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_useridentitynameattributelogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|GlobalChoiceName|`adx_webformstep_adx_validationsummarylinksenabled`|
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

### <a name="BKMK_adx_webform"></a> adx_webform

|Property|Value|
|---|---|
|Description|**Unique identifier for Multistep Form associated with Form Step.**|
|DisplayName|**Multistep Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_webform`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_webform|

### <a name="BKMK_adx_webformstepId"></a> adx_webformstepId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Form Step**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_webformstepid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|GlobalChoiceName|`adx_webformstep_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the Form Step's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_webformstep_statuscode`|

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

- [adx_webformstep_conditiondefaultnextstep](#BKMK_adx_webformstep_conditiondefaultnextstep-many-to-one)
- [adx_webformstep_entitysourcestep](#BKMK_adx_webformstep_entitysourcestep-many-to-one)
- [adx_webformstep_nextstep](#BKMK_adx_webformstep_nextstep-many-to-one)
- [adx_webformstep_previousstep](#BKMK_adx_webformstep_previousstep-many-to-one)
- [adx_webformstep_redirectwebpage](#BKMK_adx_webformstep_redirectwebpage)
- [adx_webformstep_referenceentitystep](#BKMK_adx_webformstep_referenceentitystep-many-to-one)
- [adx_webformstep_webform](#BKMK_adx_webformstep_webform)
- [lk_adx_webformstep_createdby](#BKMK_lk_adx_webformstep_createdby)
- [lk_adx_webformstep_createdonbehalfby](#BKMK_lk_adx_webformstep_createdonbehalfby)
- [lk_adx_webformstep_modifiedby](#BKMK_lk_adx_webformstep_modifiedby)
- [lk_adx_webformstep_modifiedonbehalfby](#BKMK_lk_adx_webformstep_modifiedonbehalfby)
- [organization_adx_webformstep](#BKMK_organization_adx_webformstep)

### <a name="BKMK_adx_webformstep_conditiondefaultnextstep-many-to-one"></a> adx_webformstep_conditiondefaultnextstep

One-To-Many Relationship: [adx_webformstep adx_webformstep_conditiondefaultnextstep](#BKMK_adx_webformstep_conditiondefaultnextstep-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webformstep`|
|ReferencedAttribute|`adx_webformstepid`|
|ReferencingAttribute|`adx_conditiondefaultnextstep`|
|ReferencingEntityNavigationPropertyName|`adx_conditiondefaultnextstep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webformstep_entitysourcestep-many-to-one"></a> adx_webformstep_entitysourcestep

One-To-Many Relationship: [adx_webformstep adx_webformstep_entitysourcestep](#BKMK_adx_webformstep_entitysourcestep-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webformstep`|
|ReferencedAttribute|`adx_webformstepid`|
|ReferencingAttribute|`adx_entitysourcestep`|
|ReferencingEntityNavigationPropertyName|`adx_entitysourcestep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webformstep_nextstep-many-to-one"></a> adx_webformstep_nextstep

One-To-Many Relationship: [adx_webformstep adx_webformstep_nextstep](#BKMK_adx_webformstep_nextstep-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webformstep`|
|ReferencedAttribute|`adx_webformstepid`|
|ReferencingAttribute|`adx_nextstep`|
|ReferencingEntityNavigationPropertyName|`adx_nextstep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webformstep_previousstep-many-to-one"></a> adx_webformstep_previousstep

One-To-Many Relationship: [adx_webformstep adx_webformstep_previousstep](#BKMK_adx_webformstep_previousstep-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webformstep`|
|ReferencedAttribute|`adx_webformstepid`|
|ReferencingAttribute|`adx_previousstep`|
|ReferencingEntityNavigationPropertyName|`adx_previousstep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webformstep_redirectwebpage"></a> adx_webformstep_redirectwebpage

One-To-Many Relationship: [adx_webpage adx_webformstep_redirectwebpage](adx_webpage.md#BKMK_adx_webformstep_redirectwebpage)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_redirectwebpage`|
|ReferencingEntityNavigationPropertyName|`adx_redirectwebpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webformstep_referenceentitystep-many-to-one"></a> adx_webformstep_referenceentitystep

One-To-Many Relationship: [adx_webformstep adx_webformstep_referenceentitystep](#BKMK_adx_webformstep_referenceentitystep-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webformstep`|
|ReferencedAttribute|`adx_webformstepid`|
|ReferencingAttribute|`adx_referenceentitystep`|
|ReferencingEntityNavigationPropertyName|`adx_referenceentitystep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webformstep_webform"></a> adx_webformstep_webform

One-To-Many Relationship: [adx_webform adx_webformstep_webform](adx_webform.md#BKMK_adx_webformstep_webform)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webform`|
|ReferencedAttribute|`adx_webformid`|
|ReferencingAttribute|`adx_webform`|
|ReferencingEntityNavigationPropertyName|`adx_webform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lk_adx_webformstep_createdby"></a> lk_adx_webformstep_createdby

One-To-Many Relationship: [systemuser lk_adx_webformstep_createdby](systemuser.md#BKMK_lk_adx_webformstep_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webformstep_createdonbehalfby"></a> lk_adx_webformstep_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webformstep_createdonbehalfby](systemuser.md#BKMK_lk_adx_webformstep_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webformstep_modifiedby"></a> lk_adx_webformstep_modifiedby

One-To-Many Relationship: [systemuser lk_adx_webformstep_modifiedby](systemuser.md#BKMK_lk_adx_webformstep_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webformstep_modifiedonbehalfby"></a> lk_adx_webformstep_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webformstep_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_webformstep_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_adx_webformstep"></a> organization_adx_webformstep

One-To-Many Relationship: [organization organization_adx_webformstep](organization.md#BKMK_organization_adx_webformstep)

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

- [adx_webform_startstep](#BKMK_adx_webform_startstep)
- [adx_webformmetadata_webformstep](#BKMK_adx_webformmetadata_webformstep)
- [adx_webformsession_currentwebformstep](#BKMK_adx_webformsession_currentwebformstep)
- [adx_webformstep_AsyncOperations](#BKMK_adx_webformstep_AsyncOperations)
- [adx_webformstep_BulkDeleteFailures](#BKMK_adx_webformstep_BulkDeleteFailures)
- [adx_webformstep_conditiondefaultnextstep](#BKMK_adx_webformstep_conditiondefaultnextstep-one-to-many)
- [adx_webformstep_entitysourcestep](#BKMK_adx_webformstep_entitysourcestep-one-to-many)
- [adx_webformstep_MailboxTrackingFolders](#BKMK_adx_webformstep_MailboxTrackingFolders)
- [adx_webformstep_nextstep](#BKMK_adx_webformstep_nextstep-one-to-many)
- [adx_webformstep_previousstep](#BKMK_adx_webformstep_previousstep-one-to-many)
- [adx_webformstep_PrincipalObjectAttributeAccesses](#BKMK_adx_webformstep_PrincipalObjectAttributeAccesses)
- [adx_webformstep_ProcessSession](#BKMK_adx_webformstep_ProcessSession)
- [adx_webformstep_referenceentitystep](#BKMK_adx_webformstep_referenceentitystep-one-to-many)
- [adx_webformstep_SyncErrors](#BKMK_adx_webformstep_SyncErrors)

### <a name="BKMK_adx_webform_startstep"></a> adx_webform_startstep

Many-To-One Relationship: [adx_webform adx_webform_startstep](adx_webform.md#BKMK_adx_webform_startstep)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webform`|
|ReferencingAttribute|`adx_startstep`|
|ReferencedEntityNavigationPropertyName|`adx_webform_startstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformmetadata_webformstep"></a> adx_webformmetadata_webformstep

Many-To-One Relationship: [adx_webformmetadata adx_webformmetadata_webformstep](adx_webformmetadata.md#BKMK_adx_webformmetadata_webformstep)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformmetadata`|
|ReferencingAttribute|`adx_webformstep`|
|ReferencedEntityNavigationPropertyName|`adx_webformmetadata_webformstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Metadata<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformsession_currentwebformstep"></a> adx_webformsession_currentwebformstep

Many-To-One Relationship: [adx_webformsession adx_webformsession_currentwebformstep](adx_webformsession.md#BKMK_adx_webformsession_currentwebformstep)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformsession`|
|ReferencingAttribute|`adx_currentwebformstep`|
|ReferencedEntityNavigationPropertyName|`adx_webformsession_currentwebformstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_AsyncOperations"></a> adx_webformstep_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_webformstep_AsyncOperations](asyncoperation.md#BKMK_adx_webformstep_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_BulkDeleteFailures"></a> adx_webformstep_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_webformstep_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_webformstep_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_conditiondefaultnextstep-one-to-many"></a> adx_webformstep_conditiondefaultnextstep

Many-To-One Relationship: [adx_webformstep adx_webformstep_conditiondefaultnextstep](#BKMK_adx_webformstep_conditiondefaultnextstep-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformstep`|
|ReferencingAttribute|`adx_conditiondefaultnextstep`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_conditiondefaultnextstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_entitysourcestep-one-to-many"></a> adx_webformstep_entitysourcestep

Many-To-One Relationship: [adx_webformstep adx_webformstep_entitysourcestep](#BKMK_adx_webformstep_entitysourcestep-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformstep`|
|ReferencingAttribute|`adx_entitysourcestep`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_entitysourcestep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Entity Source Steps<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_MailboxTrackingFolders"></a> adx_webformstep_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_webformstep_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_webformstep_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_nextstep-one-to-many"></a> adx_webformstep_nextstep

Many-To-One Relationship: [adx_webformstep adx_webformstep_nextstep](#BKMK_adx_webformstep_nextstep-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformstep`|
|ReferencingAttribute|`adx_nextstep`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_nextstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_previousstep-one-to-many"></a> adx_webformstep_previousstep

Many-To-One Relationship: [adx_webformstep adx_webformstep_previousstep](#BKMK_adx_webformstep_previousstep-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformstep`|
|ReferencingAttribute|`adx_previousstep`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_previousstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_PrincipalObjectAttributeAccesses"></a> adx_webformstep_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_webformstep_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_webformstep_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_ProcessSession"></a> adx_webformstep_ProcessSession

Many-To-One Relationship: [processsession adx_webformstep_ProcessSession](processsession.md#BKMK_adx_webformstep_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_referenceentitystep-one-to-many"></a> adx_webformstep_referenceentitystep

Many-To-One Relationship: [adx_webformstep adx_webformstep_referenceentitystep](#BKMK_adx_webformstep_referenceentitystep-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformstep`|
|ReferencingAttribute|`adx_referenceentitystep`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_referenceentitystep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Reference Entity Steps<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_SyncErrors"></a> adx_webformstep_SyncErrors

Many-To-One Relationship: [syncerror adx_webformstep_SyncErrors](syncerror.md#BKMK_adx_webformstep_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

