---
title: "List (adx_entitylist) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the List (adx_entitylist) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# List (adx_entitylist) table/entity reference



## Messages

The following table lists the messages for the List (adx_entitylist) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /adx_entitylists<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_entitylists(*adx_entitylistid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_entitylists(*adx_entitylistid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_entitylists<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /adx_entitylists(*adx_entitylistid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_entitylists(*adx_entitylistid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_entitylists(*adx_entitylistid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the List (adx_entitylist) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the List (adx_entitylist) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **List** |
| **DisplayCollectionName** | **Lists** |
| **SchemaName** | `adx_entitylist` |
| **CollectionSchemaName** | `adx_entitylists` |
| **EntitySetName** | `adx_entitylists`|
| **LogicalName** | `adx_entitylist` |
| **LogicalCollectionName** | `adx_entitylists` |
| **PrimaryIdAttribute** | `adx_entitylistid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_calendar_alldayfieldname](#BKMK_adx_calendar_alldayfieldname)
- [adx_calendar_descriptionfieldname](#BKMK_adx_calendar_descriptionfieldname)
- [adx_calendar_enabled](#BKMK_adx_calendar_enabled)
- [adx_calendar_enddatefieldname](#BKMK_adx_calendar_enddatefieldname)
- [adx_calendar_initialdate](#BKMK_adx_calendar_initialdate)
- [adx_calendar_initialview](#BKMK_adx_calendar_initialview)
- [adx_calendar_locationfieldname](#BKMK_adx_calendar_locationfieldname)
- [adx_calendar_organizerfieldname](#BKMK_adx_calendar_organizerfieldname)
- [adx_calendar_startdatefieldname](#BKMK_adx_calendar_startdatefieldname)
- [adx_calendar_style](#BKMK_adx_calendar_style)
- [adx_calendar_summaryfieldname](#BKMK_adx_calendar_summaryfieldname)
- [adx_calendar_timezone](#BKMK_adx_calendar_timezone)
- [adx_calendar_timezonemode](#BKMK_adx_calendar_timezonemode)
- [adx_createbuttonlabel](#BKMK_adx_createbuttonlabel)
- [adx_detailsbuttonlabel](#BKMK_adx_detailsbuttonlabel)
- [adx_emptylisttext](#BKMK_adx_emptylisttext)
- [adx_entitylistId](#BKMK_adx_entitylistId)
- [adx_entityname](#BKMK_adx_entityname)
- [adx_entitypermissionsenabled](#BKMK_adx_entitypermissionsenabled)
- [adx_filter_applybuttonlabel](#BKMK_adx_filter_applybuttonlabel)
- [adx_filter_definition](#BKMK_adx_filter_definition)
- [adx_filter_enabled](#BKMK_adx_filter_enabled)
- [adx_filter_orientation](#BKMK_adx_filter_orientation)
- [adx_filteraccount](#BKMK_adx_filteraccount)
- [adx_filterportaluser](#BKMK_adx_filterportaluser)
- [adx_filterwebsite](#BKMK_adx_filterwebsite)
- [adx_idquerystringparametername](#BKMK_adx_idquerystringparametername)
- [adx_iscodecomponent](#BKMK_adx_iscodecomponent)
- [adx_key](#BKMK_adx_key)
- [adx_map_credentials](#BKMK_adx_map_credentials)
- [adx_map_distanceunits](#BKMK_adx_map_distanceunits)
- [adx_map_distancevalues](#BKMK_adx_map_distancevalues)
- [adx_map_enabled](#BKMK_adx_map_enabled)
- [adx_map_infoboxdescriptionfieldname](#BKMK_adx_map_infoboxdescriptionfieldname)
- [adx_map_infoboxoffsetx](#BKMK_adx_map_infoboxoffsetx)
- [adx_map_infoboxoffsety](#BKMK_adx_map_infoboxoffsety)
- [adx_map_infoboxtitlefieldname](#BKMK_adx_map_infoboxtitlefieldname)
- [adx_map_latitude](#BKMK_adx_map_latitude)
- [adx_map_latitudefieldname](#BKMK_adx_map_latitudefieldname)
- [adx_map_longitude](#BKMK_adx_map_longitude)
- [adx_map_longitudefieldname](#BKMK_adx_map_longitudefieldname)
- [adx_map_pushpinheight](#BKMK_adx_map_pushpinheight)
- [adx_map_pushpinurl](#BKMK_adx_map_pushpinurl)
- [adx_map_pushpinwidth](#BKMK_adx_map_pushpinwidth)
- [adx_map_resturl](#BKMK_adx_map_resturl)
- [adx_map_type](#BKMK_adx_map_type)
- [adx_map_zoom](#BKMK_adx_map_zoom)
- [adx_name](#BKMK_adx_name)
- [adx_odata_enabled](#BKMK_adx_odata_enabled)
- [adx_odata_entitysetname](#BKMK_adx_odata_entitysetname)
- [adx_odata_entitytypename](#BKMK_adx_odata_entitytypename)
- [adx_odata_view](#BKMK_adx_odata_view)
- [adx_pagesize](#BKMK_adx_pagesize)
- [adx_primarykeyname](#BKMK_adx_primarykeyname)
- [adx_provisionedlanguages](#BKMK_adx_provisionedlanguages)
- [adx_registerstartupscript](#BKMK_adx_registerstartupscript)
- [adx_searchenabled](#BKMK_adx_searchenabled)
- [adx_searchplaceholdertext](#BKMK_adx_searchplaceholdertext)
- [adx_searchtooltiptext](#BKMK_adx_searchtooltiptext)
- [adx_settings](#BKMK_adx_settings)
- [adx_view](#BKMK_adx_view)
- [adx_views](#BKMK_adx_views)
- [adx_webpageforcreate](#BKMK_adx_webpageforcreate)
- [adx_webpagefordetailsview](#BKMK_adx_webpagefordetailsview)
- [adx_websiteid](#BKMK_adx_websiteid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_calendar_alldayfieldname"></a> adx_calendar_alldayfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is All Day Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_alldayfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_calendar_descriptionfieldname"></a> adx_calendar_descriptionfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_descriptionfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_calendar_enabled"></a> adx_calendar_enabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Calendar View Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitylist_adx_calendar_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_calendar_enddatefieldname"></a> adx_calendar_enddatefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**End Date Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_enddatefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_calendar_initialdate"></a> adx_calendar_initialdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Calendar Initial Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_initialdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_adx_calendar_initialview"></a> adx_calendar_initialview

|Property|Value|
|---|---|
|Description||
|DisplayName|**Calendar Initial View**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_initialview`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150001|
|GlobalChoiceName|`adx_entitylist_adx_calendar_initialview`|

#### adx_calendar_initialview Choices/Options

|Value|Label|
|---|---|
|756150000|**Year**|
|756150001|**Month**|
|756150002|**Week**|
|756150003|**Day**|

### <a name="BKMK_adx_calendar_locationfieldname"></a> adx_calendar_locationfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Location Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_locationfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_calendar_organizerfieldname"></a> adx_calendar_organizerfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Organizer Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_organizerfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_calendar_startdatefieldname"></a> adx_calendar_startdatefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start Date Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_startdatefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_calendar_style"></a> adx_calendar_style

|Property|Value|
|---|---|
|Description||
|DisplayName|**Calendar Style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_style`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_entitylist_adx_calendar_style`|

#### adx_calendar_style Choices/Options

|Value|Label|
|---|---|
|756150000|**Full calendar**|
|756150001|**Event list**|

### <a name="BKMK_adx_calendar_summaryfieldname"></a> adx_calendar_summaryfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Summary Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_summaryfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_calendar_timezone"></a> adx_calendar_timezone

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_timezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_adx_calendar_timezonemode"></a> adx_calendar_timezonemode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time Zone Display Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_calendar_timezonemode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_entitylist_adx_calendar_timezonemode`|

#### adx_calendar_timezonemode Choices/Options

|Value|Label|
|---|---|
|756150000|**User Local Time Zone**|
|756150001|**Specific Time Zone**|

### <a name="BKMK_adx_createbuttonlabel"></a> adx_createbuttonlabel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Create Button Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_createbuttonlabel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_detailsbuttonlabel"></a> adx_detailsbuttonlabel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Details Button Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_detailsbuttonlabel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_emptylisttext"></a> adx_emptylisttext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Empty List Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_emptylisttext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_entitylistId"></a> adx_entitylistId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**List**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_entitylistid`|
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
|Description|**Indicates whether or not the table permission provider will assert privileges on the entity type associated with this list.**|
|DisplayName|**Enable Table Permissions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entitypermissionsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitylist_adx_entitypermissionsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_filter_applybuttonlabel"></a> adx_filter_applybuttonlabel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Apply Button Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_filter_applybuttonlabel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_filter_definition"></a> adx_filter_definition

|Property|Value|
|---|---|
|Description||
|DisplayName|**Filter Definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_filter_definition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|65536|

### <a name="BKMK_adx_filter_enabled"></a> adx_filter_enabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Filter Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_filter_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitylist_adx_filter_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_filter_orientation"></a> adx_filter_orientation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Filter Orientation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_filter_orientation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entitylist_adx_filter_orientation`|

#### adx_filter_orientation Choices/Options

|Value|Label|
|---|---|
|756150000|**Horizontal**|
|756150001|**Vertical**|

### <a name="BKMK_adx_filteraccount"></a> adx_filteraccount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Filter Account Attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_filteraccount`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_adx_filterportaluser"></a> adx_filterportaluser

|Property|Value|
|---|---|
|Description||
|DisplayName|**Filter Portal User Attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_filterportaluser`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_adx_filterwebsite"></a> adx_filterwebsite

|Property|Value|
|---|---|
|Description||
|DisplayName|**Filter Website Attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_filterwebsite`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_adx_idquerystringparametername"></a> adx_idquerystringparametername

|Property|Value|
|---|---|
|Description|**The name of the parameter added to the Query String of the list item's URL that will contain the list item record's ID.**|
|DisplayName|**ID Query String Parameter Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_idquerystringparametername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_iscodecomponent"></a> adx_iscodecomponent

|Property|Value|
|---|---|
|Description|**Use a configured code component**|
|DisplayName|**Use a configured code component**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_iscodecomponent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitylist_adx_iscodecomponent`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_key"></a> adx_key

|Property|Value|
|---|---|
|Description|**A non-localizable string that can be used by queries to retrieve the record.**|
|DisplayName|**Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_key`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_map_credentials"></a> adx_map_credentials

|Property|Value|
|---|---|
|Description||
|DisplayName|**Credentials**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_credentials`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_map_distanceunits"></a> adx_map_distanceunits

|Property|Value|
|---|---|
|Description||
|DisplayName|**Distance Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_distanceunits`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150001|
|GlobalChoiceName|`adx_entitylist_adx_map_distanceunits`|

#### adx_map_distanceunits Choices/Options

|Value|Label|
|---|---|
|756150000|**Km**|
|756150001|**miles**|

### <a name="BKMK_adx_map_distancevalues"></a> adx_map_distancevalues

|Property|Value|
|---|---|
|Description|**Shows a comma-delimited list of integer values to be populated in the drop-down list  in the web portal for selecting the distance to search for a location on the map.**|
|DisplayName|**Distance Values**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_distancevalues`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_map_enabled"></a> adx_map_enabled

|Property|Value|
|---|---|
|Description|**Indicates if a map view of the data is to be rendered.**|
|DisplayName|**Map Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitylist_adx_map_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_map_infoboxdescriptionfieldname"></a> adx_map_infoboxdescriptionfieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Infobox Description Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_infoboxdescriptionfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_map_infoboxoffsetx"></a> adx_map_infoboxoffsetx

|Property|Value|
|---|---|
|Description||
|DisplayName|**Infobox Offset x**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_infoboxoffsetx`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_adx_map_infoboxoffsety"></a> adx_map_infoboxoffsety

|Property|Value|
|---|---|
|Description||
|DisplayName|**Infobox Offset y**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_infoboxoffsety`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_adx_map_infoboxtitlefieldname"></a> adx_map_infoboxtitlefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Infobox Title Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_infoboxtitlefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_map_latitude"></a> adx_map_latitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_adx_map_latitudefieldname"></a> adx_map_latitudefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Latitude Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_latitudefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_map_longitude"></a> adx_map_longitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_adx_map_longitudefieldname"></a> adx_map_longitudefieldname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Longitude Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_longitudefieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_map_pushpinheight"></a> adx_map_pushpinheight

|Property|Value|
|---|---|
|Description||
|DisplayName|**Pin Image Height**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_pushpinheight`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_map_pushpinurl"></a> adx_map_pushpinurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Pin Image URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_pushpinurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_adx_map_pushpinwidth"></a> adx_map_pushpinwidth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Pin Image Width**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_pushpinwidth`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_map_resturl"></a> adx_map_resturl

|Property|Value|
|---|---|
|Description||
|DisplayName|**REST URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_resturl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_adx_map_type"></a> adx_map_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Map Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_type`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_entitylist_adx_map_type`|

#### adx_map_type Choices/Options

|Value|Label|
|---|---|
|756150000|**Bing**|
|756150001|**Google**|
|756150002|**Esri**|

### <a name="BKMK_adx_map_zoom"></a> adx_map_zoom

|Property|Value|
|---|---|
|Description||
|DisplayName|**Zoom**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_map_zoom`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

### <a name="BKMK_adx_odata_enabled"></a> adx_odata_enabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**OData Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_odata_enabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitylist_adx_odata_enabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_odata_entitysetname"></a> adx_odata_entitysetname

|Property|Value|
|---|---|
|Description||
|DisplayName|**OData Entity Set Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_odata_entitysetname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_odata_entitytypename"></a> adx_odata_entitytypename

|Property|Value|
|---|---|
|Description||
|DisplayName|**OData Entity Type Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_odata_entitytypename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_odata_view"></a> adx_odata_view

|Property|Value|
|---|---|
|Description|**The entity view that defines the columns that will be mapped to properties of the entity exposed in the OData feed.**|
|DisplayName|**OData View**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_odata_view`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_pagesize"></a> adx_pagesize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Page Size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_pagesize`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

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
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_searchenabled"></a> adx_searchenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Search Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_searchenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitylist_adx_searchenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_searchplaceholdertext"></a> adx_searchplaceholdertext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Search Placeholder Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_searchplaceholdertext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_searchtooltiptext"></a> adx_searchtooltiptext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Search Tooltip Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_searchtooltiptext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_settings"></a> adx_settings

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
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_adx_view"></a> adx_view

|Property|Value|
|---|---|
|Description|**Deprecated**|
|DisplayName|**View**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_view`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_views"></a> adx_views

|Property|Value|
|---|---|
|Description||
|DisplayName|**Views**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_views`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_adx_webpageforcreate"></a> adx_webpageforcreate

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Page associated with Entity List.**|
|DisplayName|**Web Page for Create**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_webpageforcreate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_adx_webpagefordetailsview"></a> adx_webpagefordetailsview

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Page associated with Entity List.**|
|DisplayName|**Web Page for Details View**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_webpagefordetailsview`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Website entity associated with this record**|
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
|Description|**Shows the status of the entity list.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_entitylist_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the List's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_entitylist_statuscode`|

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

- [adx_entitylist_webpageforcreate](#BKMK_adx_entitylist_webpageforcreate)
- [adx_entitylist_webpagefordetailsview](#BKMK_adx_entitylist_webpagefordetailsview)
- [adx_website_entitylist](#BKMK_adx_website_entitylist)
- [lk_adx_entitylist_createdby](#BKMK_lk_adx_entitylist_createdby)
- [lk_adx_entitylist_createdonbehalfby](#BKMK_lk_adx_entitylist_createdonbehalfby)
- [lk_adx_entitylist_modifiedby](#BKMK_lk_adx_entitylist_modifiedby)
- [lk_adx_entitylist_modifiedonbehalfby](#BKMK_lk_adx_entitylist_modifiedonbehalfby)
- [organization_adx_entitylist](#BKMK_organization_adx_entitylist)

### <a name="BKMK_adx_entitylist_webpageforcreate"></a> adx_entitylist_webpageforcreate

One-To-Many Relationship: [adx_webpage adx_entitylist_webpageforcreate](adx_webpage.md#BKMK_adx_entitylist_webpageforcreate)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_webpageforcreate`|
|ReferencingEntityNavigationPropertyName|`adx_webpageforcreate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_entitylist_webpagefordetailsview"></a> adx_entitylist_webpagefordetailsview

One-To-Many Relationship: [adx_webpage adx_entitylist_webpagefordetailsview](adx_webpage.md#BKMK_adx_entitylist_webpagefordetailsview)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_webpagefordetailsview`|
|ReferencingEntityNavigationPropertyName|`adx_webpagefordetailsview`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_entitylist"></a> adx_website_entitylist

One-To-Many Relationship: [adx_website adx_website_entitylist](adx_website.md#BKMK_adx_website_entitylist)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencingEntityNavigationPropertyName|`adx_websiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entitylist_createdby"></a> lk_adx_entitylist_createdby

One-To-Many Relationship: [systemuser lk_adx_entitylist_createdby](systemuser.md#BKMK_lk_adx_entitylist_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entitylist_createdonbehalfby"></a> lk_adx_entitylist_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_entitylist_createdonbehalfby](systemuser.md#BKMK_lk_adx_entitylist_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entitylist_modifiedby"></a> lk_adx_entitylist_modifiedby

One-To-Many Relationship: [systemuser lk_adx_entitylist_modifiedby](systemuser.md#BKMK_lk_adx_entitylist_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entitylist_modifiedonbehalfby"></a> lk_adx_entitylist_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_entitylist_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_entitylist_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_adx_entitylist"></a> organization_adx_entitylist

One-To-Many Relationship: [organization organization_adx_entitylist](organization.md#BKMK_organization_adx_entitylist)

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

- [adx_entitylist_AsyncOperations](#BKMK_adx_entitylist_AsyncOperations)
- [adx_entitylist_BulkDeleteFailures](#BKMK_adx_entitylist_BulkDeleteFailures)
- [adx_entitylist_MailboxTrackingFolders](#BKMK_adx_entitylist_MailboxTrackingFolders)
- [adx_entitylist_PrincipalObjectAttributeAccesses](#BKMK_adx_entitylist_PrincipalObjectAttributeAccesses)
- [adx_entitylist_ProcessSession](#BKMK_adx_entitylist_ProcessSession)
- [adx_entitylist_SyncErrors](#BKMK_adx_entitylist_SyncErrors)
- [adx_webpage_entitylist](#BKMK_adx_webpage_entitylist)

### <a name="BKMK_adx_entitylist_AsyncOperations"></a> adx_entitylist_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_entitylist_AsyncOperations](asyncoperation.md#BKMK_adx_entitylist_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitylist_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitylist_BulkDeleteFailures"></a> adx_entitylist_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_entitylist_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_entitylist_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitylist_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitylist_MailboxTrackingFolders"></a> adx_entitylist_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_entitylist_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_entitylist_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitylist_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitylist_PrincipalObjectAttributeAccesses"></a> adx_entitylist_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_entitylist_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_entitylist_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitylist_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitylist_ProcessSession"></a> adx_entitylist_ProcessSession

Many-To-One Relationship: [processsession adx_entitylist_ProcessSession](processsession.md#BKMK_adx_entitylist_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitylist_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitylist_SyncErrors"></a> adx_entitylist_SyncErrors

Many-To-One Relationship: [syncerror adx_entitylist_SyncErrors](syncerror.md#BKMK_adx_entitylist_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitylist_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_entitylist"></a> adx_webpage_entitylist

Many-To-One Relationship: [adx_webpage adx_webpage_entitylist](adx_webpage.md#BKMK_adx_webpage_entitylist)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_entitylist`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_entitylist`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

