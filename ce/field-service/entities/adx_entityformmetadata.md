---
title: "Basic Form Metadata (adx_entityformmetadata) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Basic Form Metadata (adx_entityformmetadata) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Basic Form Metadata (adx_entityformmetadata) table/entity reference

Defines the additional behavior modification logic to augment or override the functionality of form components that is not possible with entity and form metadata.

## Messages

The following table lists the messages for the Basic Form Metadata (adx_entityformmetadata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /adx_entityformmetadatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_entityformmetadatas(*adx_entityformmetadataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_entityformmetadatas(*adx_entityformmetadataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_entityformmetadatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /adx_entityformmetadatas(*adx_entityformmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_entityformmetadatas(*adx_entityformmetadataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_entityformmetadatas(*adx_entityformmetadataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Basic Form Metadata (adx_entityformmetadata) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Basic Form Metadata (adx_entityformmetadata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Basic Form Metadata** |
| **DisplayCollectionName** | **Basic Form Metadata** |
| **SchemaName** | `adx_entityformmetadata` |
| **CollectionSchemaName** | `adx_entityformmetadatas` |
| **EntitySetName** | `adx_entityformmetadatas`|
| **LogicalName** | `adx_entityformmetadata` |
| **LogicalCollectionName** | `adx_entityformmetadatas` |
| **PrimaryIdAttribute** | `adx_entityformmetadataid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_adddescription](#BKMK_adx_adddescription)
- [adx_attributelogicalname](#BKMK_adx_attributelogicalname)
- [adx_constantsummaximumtotal](#BKMK_adx_constantsummaximumtotal)
- [adx_constantsumminimumtotal](#BKMK_adx_constantsumminimumtotal)
- [adx_constantsumvalidationerrormessage](#BKMK_adx_constantsumvalidationerrormessage)
- [adx_controlstyle](#BKMK_adx_controlstyle)
- [adx_cssclass](#BKMK_adx_cssclass)
- [adx_description](#BKMK_adx_description)
- [adx_descriptionposition](#BKMK_adx_descriptionposition)
- [adx_entityform](#BKMK_adx_entityform)
- [adx_entityformforcreate](#BKMK_adx_entityformforcreate)
- [adx_entityformmetadataId](#BKMK_adx_entityformmetadataId)
- [adx_fieldisrequired](#BKMK_adx_fieldisrequired)
- [adx_geolocationvalidatorerrormessage](#BKMK_adx_geolocationvalidatorerrormessage)
- [adx_groupname](#BKMK_adx_groupname)
- [adx_ignoredefaultvalue](#BKMK_adx_ignoredefaultvalue)
- [adx_label](#BKMK_adx_label)
- [adx_maxmultiplechoiceselectedcount](#BKMK_adx_maxmultiplechoiceselectedcount)
- [adx_minmultiplechoiceselectedcount](#BKMK_adx_minmultiplechoiceselectedcount)
- [adx_multiplechoicevalidationerrormessage](#BKMK_adx_multiplechoicevalidationerrormessage)
- [adx_name](#BKMK_adx_name)
- [adx_notes_settings](#BKMK_adx_notes_settings)
- [adx_onsavefromattribute](#BKMK_adx_onsavefromattribute)
- [adx_onsavetype](#BKMK_adx_onsavetype)
- [adx_onsavevalue](#BKMK_adx_onsavevalue)
- [adx_prepopulatefromattribute](#BKMK_adx_prepopulatefromattribute)
- [adx_prepopulatetype](#BKMK_adx_prepopulatetype)
- [adx_prepopulatevalue](#BKMK_adx_prepopulatevalue)
- [adx_provisionedlanguages](#BKMK_adx_provisionedlanguages)
- [adx_randomizeoptionsetvalues](#BKMK_adx_randomizeoptionsetvalues)
- [adx_rangevalidationerrormessage](#BKMK_adx_rangevalidationerrormessage)
- [adx_rankordernotiesvalidationerrormessage](#BKMK_adx_rankordernotiesvalidationerrormessage)
- [adx_requiredfieldvalidationerrormessage](#BKMK_adx_requiredfieldvalidationerrormessage)
- [adx_sectionname](#BKMK_adx_sectionname)
- [adx_setvalueonsave](#BKMK_adx_setvalueonsave)
- [adx_subgrid_name](#BKMK_adx_subgrid_name)
- [adx_subgrid_settings](#BKMK_adx_subgrid_settings)
- [adx_tabname](#BKMK_adx_tabname)
- [adx_timeline_settings](#BKMK_adx_timeline_settings)
- [adx_type](#BKMK_adx_type)
- [adx_useattributedescriptionproperty](#BKMK_adx_useattributedescriptionproperty)
- [adx_validationerrormessage](#BKMK_adx_validationerrormessage)
- [adx_validationregularexpression](#BKMK_adx_validationregularexpression)
- [adx_validationregularexpressionerrormessage](#BKMK_adx_validationregularexpressionerrormessage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_adddescription"></a> adx_adddescription

|Property|Value|
|---|---|
|Description||
|DisplayName|**Add Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_adddescription`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityformmetadata_adx_adddescription`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_attributelogicalname"></a> adx_attributelogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attribute Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_attributelogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_constantsummaximumtotal"></a> adx_constantsummaximumtotal

|Property|Value|
|---|---|
|Description||
|DisplayName|**Constant Sum Maximum Total**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_constantsummaximumtotal`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_constantsumminimumtotal"></a> adx_constantsumminimumtotal

|Property|Value|
|---|---|
|Description||
|DisplayName|**Constant Sum Minimum Total**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_constantsumminimumtotal`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_constantsumvalidationerrormessage"></a> adx_constantsumvalidationerrormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Constant Sum Validation Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_constantsumvalidationerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_controlstyle"></a> adx_controlstyle

|Property|Value|
|---|---|
|Description|**Specifies how the control should be modified or enhanced.**|
|DisplayName|**Control Style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_controlstyle`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entityformmetadata_adx_controlstyle`|

#### adx_controlstyle Choices/Options

|Value|Label|
|---|---|
|100000000|**Option Set as Vertical Radio Button List**|
|100000001|**Option Set as Horizontal Radio Button List**|
|100000002|**Single Line of Text as Geolocation Lookup Validator**|
|100000003|**Group Whole Number as Constant Sum**|
|100000004|**Group Whole Number as Rank Order Scale No Ties**|
|100000005|**Group Whole Number as Rank Order Scale Allow Ties**|
|100000006|**Multiple Choice Matrix**|
|100000007|**Multiple Choice**|
|100000008|**Group Whole Number as Stack Rank**|
|756150000|**Render Lookup as Dropdown**|
|756150001|**Code component**|

### <a name="BKMK_adx_cssclass"></a> adx_cssclass

|Property|Value|
|---|---|
|Description||
|DisplayName|**CSS Class**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_cssclass`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_description"></a> adx_description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_descriptionposition"></a> adx_descriptionposition

|Property|Value|
|---|---|
|Description||
|DisplayName|**Position**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_descriptionposition`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`adx_entityformmetadata_adx_descriptionposition`|

#### adx_descriptionposition Choices/Options

|Value|Label|
|---|---|
|100000000|**Above the field**|
|100000001|**Below the field**|
|100000002|**Above the label**|

### <a name="BKMK_adx_entityform"></a> adx_entityform

|Property|Value|
|---|---|
|Description|**Unique identifier for Entity Form associated with Entity Form Metadata.**|
|DisplayName|**Basic Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entityform`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_entityform|

### <a name="BKMK_adx_entityformforcreate"></a> adx_entityformforcreate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Basic Form for Create**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entityformforcreate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_entityform|

### <a name="BKMK_adx_entityformmetadataId"></a> adx_entityformmetadataId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Basic Form Metadata**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_entityformmetadataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_fieldisrequired"></a> adx_fieldisrequired

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field is Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_fieldisrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityformmetadata_adx_fieldisrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_geolocationvalidatorerrormessage"></a> adx_geolocationvalidatorerrormessage

|Property|Value|
|---|---|
|Description|**The error message to be displayed when the geolocation validator validation fails.**|
|DisplayName|**Geolocation Validator Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_geolocationvalidatorerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_groupname"></a> adx_groupname

|Property|Value|
|---|---|
|Description|**Shows which attributes are to be grouped and rendered as a composite control if the control style is a groupings type such as "Group Whole Number as Constant Sum."**|
|DisplayName|**Group Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_groupname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_ignoredefaultvalue"></a> adx_ignoredefaultvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Ignore Default Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_ignoredefaultvalue`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityformmetadata_adx_ignoredefaultvalue`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_label"></a> adx_label

|Property|Value|
|---|---|
|Description||
|DisplayName|**Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_label`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_maxmultiplechoiceselectedcount"></a> adx_maxmultiplechoiceselectedcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Multiple Choice Max Selected Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_maxmultiplechoiceselectedcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_adx_minmultiplechoiceselectedcount"></a> adx_minmultiplechoiceselectedcount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Multiple Choice Minimum Required Selected Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_minmultiplechoiceselectedcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_adx_multiplechoicevalidationerrormessage"></a> adx_multiplechoicevalidationerrormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Multiple Choice Validation Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_multiplechoicevalidationerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_name"></a> adx_name

|Property|Value|
|---|---|
|Description|**Type the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_notes_settings"></a> adx_notes_settings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Notes Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_notes_settings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_adx_onsavefromattribute"></a> adx_onsavefromattribute

|Property|Value|
|---|---|
|Description|**Use this field, in conjunction with On Save Type = Current User Contact, to map any attribute from the current user’s contact record to this record’s attribute logical name.**|
|DisplayName|**On Save From Attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_onsavefromattribute`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_onsavetype"></a> adx_onsavetype

|Property|Value|
|---|---|
|Description|**Shows the mechanisms for populating a field with a value.**|
|DisplayName|**On Save Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_onsavetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entityformmetadata_adx_onsavetype`|

#### adx_onsavetype Choices/Options

|Value|Label|
|---|---|
|100000000|**Value**|
|100000001|**Today's Date**|
|100000002|**Current Portal User**|

### <a name="BKMK_adx_onsavevalue"></a> adx_onsavevalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_onsavevalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_prepopulatefromattribute"></a> adx_prepopulatefromattribute

|Property|Value|
|---|---|
|Description|**Use this field, in conjunction with Prepopulate Type = Current User Contact, to map any attribute from the current user’s contact record to this record’s attribute logical name.**|
|DisplayName|**Prepopulate From Attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_prepopulatefromattribute`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_prepopulatetype"></a> adx_prepopulatetype

|Property|Value|
|---|---|
|Description|**Shows the mechanisms for populating a field with a value.**|
|DisplayName|**Prepopulate Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_prepopulatetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entityformmetadata_adx_prepopulatetype`|

#### adx_prepopulatetype Choices/Options

|Value|Label|
|---|---|
|100000000|**Value**|
|100000001|**Today's Date**|
|100000002|**Current Portal User**|

### <a name="BKMK_adx_prepopulatevalue"></a> adx_prepopulatevalue

|Property|Value|
|---|---|
|Description|**The value to prepopulate the field.**|
|DisplayName|**Prepopulate Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_prepopulatevalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_adx_randomizeoptionsetvalues"></a> adx_randomizeoptionsetvalues

|Property|Value|
|---|---|
|Description||
|DisplayName|**Randomize Option Set Values**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_randomizeoptionsetvalues`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityformmetadata_adx_randomizeoptionsetvalues`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_rangevalidationerrormessage"></a> adx_rangevalidationerrormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Range Validation Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_rangevalidationerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_rankordernotiesvalidationerrormessage"></a> adx_rankordernotiesvalidationerrormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Rank Order No Ties Validation Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_rankordernotiesvalidationerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_requiredfieldvalidationerrormessage"></a> adx_requiredfieldvalidationerrormessage

|Property|Value|
|---|---|
|Description|**The error message shown when a required field does not contain a value.**|
|DisplayName|**Required Field Validation Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_requiredfieldvalidationerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_sectionname"></a> adx_sectionname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Section Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_sectionname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_adx_setvalueonsave"></a> adx_setvalueonsave

|Property|Value|
|---|---|
|Description||
|DisplayName|**Set Value On Save**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_setvalueonsave`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityformmetadata_adx_setvalueonsave`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_subgrid_name"></a> adx_subgrid_name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Subgrid Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_subgrid_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_adx_subgrid_settings"></a> adx_subgrid_settings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Subgrid Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_subgrid_settings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_adx_tabname"></a> adx_tabname

|Property|Value|
|---|---|
|Description||
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
|MaxLength|200|

### <a name="BKMK_adx_timeline_settings"></a> adx_timeline_settings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Timeline Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_timeline_settings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|100000|

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
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entityformmetadata_adx_type`|

#### adx_type Choices/Options

|Value|Label|
|---|---|
|100000000|**Attribute**|
|100000001|**Section**|
|100000002|**Tab**|
|100000003|**Subgrid**|
|100000005|**Notes**|
|756150000|**Timeline**|

### <a name="BKMK_adx_useattributedescriptionproperty"></a> adx_useattributedescriptionproperty

|Property|Value|
|---|---|
|Description||
|DisplayName|**Use Attribute's Description Property**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_useattributedescriptionproperty`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entityformmetadata_adx_useattributedescriptionproperty`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_validationerrormessage"></a> adx_validationerrormessage

|Property|Value|
|---|---|
|Description|**The error message defined for the validation.**|
|DisplayName|**Validation Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_validationerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_validationregularexpression"></a> adx_validationregularexpression

|Property|Value|
|---|---|
|Description|**Adds a regular expression validator with the specified regular expression.**|
|DisplayName|**Validation Regular Expression**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_validationregularexpression`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_validationregularexpressionerrormessage"></a> adx_validationregularexpressionerrormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Regular Expression Validation Error Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_validationregularexpressionerrormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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
|Description|**Shows the status of the basic form metadata.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_entityformmetadata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the  Basic Form Metadata's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_entityformmetadata_statuscode`|

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

- [adx_entityform_entityformmetadata_entityformforcreate](#BKMK_adx_entityform_entityformmetadata_entityformforcreate)
- [adx_entityformmetadata_entityform](#BKMK_adx_entityformmetadata_entityform)
- [lk_adx_entityformmetadata_createdby](#BKMK_lk_adx_entityformmetadata_createdby)
- [lk_adx_entityformmetadata_createdonbehalfby](#BKMK_lk_adx_entityformmetadata_createdonbehalfby)
- [lk_adx_entityformmetadata_modifiedby](#BKMK_lk_adx_entityformmetadata_modifiedby)
- [lk_adx_entityformmetadata_modifiedonbehalfby](#BKMK_lk_adx_entityformmetadata_modifiedonbehalfby)
- [organization_adx_entityformmetadata](#BKMK_organization_adx_entityformmetadata)

### <a name="BKMK_adx_entityform_entityformmetadata_entityformforcreate"></a> adx_entityform_entityformmetadata_entityformforcreate

One-To-Many Relationship: [adx_entityform adx_entityform_entityformmetadata_entityformforcreate](adx_entityform.md#BKMK_adx_entityform_entityformmetadata_entityformforcreate)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_entityform`|
|ReferencedAttribute|`adx_entityformid`|
|ReferencingAttribute|`adx_entityformforcreate`|
|ReferencingEntityNavigationPropertyName|`adx_entityformforcreate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_entityformmetadata_entityform"></a> adx_entityformmetadata_entityform

One-To-Many Relationship: [adx_entityform adx_entityformmetadata_entityform](adx_entityform.md#BKMK_adx_entityformmetadata_entityform)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_entityform`|
|ReferencedAttribute|`adx_entityformid`|
|ReferencingAttribute|`adx_entityform`|
|ReferencingEntityNavigationPropertyName|`adx_entityform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entityformmetadata_createdby"></a> lk_adx_entityformmetadata_createdby

One-To-Many Relationship: [systemuser lk_adx_entityformmetadata_createdby](systemuser.md#BKMK_lk_adx_entityformmetadata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entityformmetadata_createdonbehalfby"></a> lk_adx_entityformmetadata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_entityformmetadata_createdonbehalfby](systemuser.md#BKMK_lk_adx_entityformmetadata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entityformmetadata_modifiedby"></a> lk_adx_entityformmetadata_modifiedby

One-To-Many Relationship: [systemuser lk_adx_entityformmetadata_modifiedby](systemuser.md#BKMK_lk_adx_entityformmetadata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entityformmetadata_modifiedonbehalfby"></a> lk_adx_entityformmetadata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_entityformmetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_entityformmetadata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_adx_entityformmetadata"></a> organization_adx_entityformmetadata

One-To-Many Relationship: [organization organization_adx_entityformmetadata](organization.md#BKMK_organization_adx_entityformmetadata)

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

- [adx_entityformmetadata_AsyncOperations](#BKMK_adx_entityformmetadata_AsyncOperations)
- [adx_entityformmetadata_BulkDeleteFailures](#BKMK_adx_entityformmetadata_BulkDeleteFailures)
- [adx_entityformmetadata_MailboxTrackingFolders](#BKMK_adx_entityformmetadata_MailboxTrackingFolders)
- [adx_entityformmetadata_PrincipalObjectAttributeAccesses](#BKMK_adx_entityformmetadata_PrincipalObjectAttributeAccesses)
- [adx_entityformmetadata_ProcessSession](#BKMK_adx_entityformmetadata_ProcessSession)
- [adx_entityformmetadata_SyncErrors](#BKMK_adx_entityformmetadata_SyncErrors)

### <a name="BKMK_adx_entityformmetadata_AsyncOperations"></a> adx_entityformmetadata_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_entityformmetadata_AsyncOperations](asyncoperation.md#BKMK_adx_entityformmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityformmetadata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityformmetadata_BulkDeleteFailures"></a> adx_entityformmetadata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_entityformmetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_entityformmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityformmetadata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityformmetadata_MailboxTrackingFolders"></a> adx_entityformmetadata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_entityformmetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_entityformmetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityformmetadata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityformmetadata_PrincipalObjectAttributeAccesses"></a> adx_entityformmetadata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_entityformmetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_entityformmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityformmetadata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityformmetadata_ProcessSession"></a> adx_entityformmetadata_ProcessSession

Many-To-One Relationship: [processsession adx_entityformmetadata_ProcessSession](processsession.md#BKMK_adx_entityformmetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityformmetadata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entityformmetadata_SyncErrors"></a> adx_entityformmetadata_SyncErrors

Many-To-One Relationship: [syncerror adx_entityformmetadata_SyncErrors](syncerror.md#BKMK_adx_entityformmetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entityformmetadata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

