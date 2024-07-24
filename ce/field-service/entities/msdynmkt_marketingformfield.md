---
title: "Form field (msdynmkt_marketingformfield) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Form field (msdynmkt_marketingformfield) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Form field (msdynmkt_marketingformfield) table/entity reference



## Messages

The following table lists the messages for the Form field (msdynmkt_marketingformfield) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_marketingformfields(*msdynmkt_marketingformfieldid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_marketingformfields<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_marketingformfields(*msdynmkt_marketingformfieldid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_marketingformfields(*msdynmkt_marketingformfieldid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_marketingformfields<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_marketingformfields(*msdynmkt_marketingformfieldid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_marketingformfields(*msdynmkt_marketingformfieldid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_marketingformfields(*msdynmkt_marketingformfieldid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Form field (msdynmkt_marketingformfield) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Form field (msdynmkt_marketingformfield) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Form field** |
| **DisplayCollectionName** | **Form fields** |
| **SchemaName** | `msdynmkt_marketingformfield` |
| **CollectionSchemaName** | `msdynmkt_marketingformfields` |
| **EntitySetName** | `msdynmkt_marketingformfields`|
| **LogicalName** | `msdynmkt_marketingformfield` |
| **LogicalCollectionName** | `msdynmkt_marketingformfields` |
| **PrimaryIdAttribute** | `msdynmkt_marketingformfieldid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_allowedvalidationtypes](#BKMK_msdynmkt_allowedvalidationtypes)
- [msdynmkt_allowemptyoption](#BKMK_msdynmkt_allowemptyoption)
- [msdynmkt_countrycode](#BKMK_msdynmkt_countrycode)
- [msdynmkt_date_defaultvalue](#BKMK_msdynmkt_date_defaultvalue)
- [msdynmkt_datetime_defaultvalue](#BKMK_msdynmkt_datetime_defaultvalue)
- [msdynmkt_datetime_displayoption](#BKMK_msdynmkt_datetime_displayoption)
- [msdynmkt_defaultvalue](#BKMK_msdynmkt_defaultvalue)
- [msdynmkt_errormessage](#BKMK_msdynmkt_errormessage)
- [msdynmkt_fieldoptions](#BKMK_msdynmkt_fieldoptions)
- [msdynmkt_fieldtype](#BKMK_msdynmkt_fieldtype)
- [msdynmkt_hide](#BKMK_msdynmkt_hide)
- [msdynmkt_icon](#BKMK_msdynmkt_icon)
- [msdynmkt_lookup_targets](#BKMK_msdynmkt_lookup_targets)
- [msdynmkt_marketingformfieldId](#BKMK_msdynmkt_marketingformfieldId)
- [msdynmkt_maxlength](#BKMK_msdynmkt_maxlength)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_optionsetdisplayoption](#BKMK_msdynmkt_optionsetdisplayoption)
- [msdynmkt_placeholder](#BKMK_msdynmkt_placeholder)
- [msdynmkt_publicvisibility](#BKMK_msdynmkt_publicvisibility)
- [msdynmkt_required](#BKMK_msdynmkt_required)
- [msdynmkt_targetentity](#BKMK_msdynmkt_targetentity)
- [msdynmkt_targetproperty](#BKMK_msdynmkt_targetproperty)
- [msdynmkt_twooption_displayoption](#BKMK_msdynmkt_twooption_displayoption)
- [msdynmkt_validation](#BKMK_msdynmkt_validation)
- [msdynmkt_validationpattern](#BKMK_msdynmkt_validationpattern)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdynmkt_allowedvalidationtypes"></a> msdynmkt_allowedvalidationtypes

|Property|Value|
|---|---|
|Description|**Allowed validation types**|
|DisplayName|**Allowed validation types**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_allowedvalidationtypes`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdynmkt_allowemptyoption"></a> msdynmkt_allowemptyoption

|Property|Value|
|---|---|
|Description|**Allow empty option**|
|DisplayName|**Allow empty option**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_allowemptyoption`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_marketingformfield_msdynmkt_allowemptyoption`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_countrycode"></a> msdynmkt_countrycode

|Property|Value|
|---|---|
|Description|**Country code**|
|DisplayName|**Country code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_countrycode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdynmkt_date_defaultvalue"></a> msdynmkt_date_defaultvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date Default Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_date_defaultvalue`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_datetime_defaultvalue"></a> msdynmkt_datetime_defaultvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date Time Default Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_datetime_defaultvalue`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_datetime_displayoption"></a> msdynmkt_datetime_displayoption

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date-Time Display Option**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_datetime_displayoption`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_marketingformfield_msdynmkt_datetime_displayoption`|

#### msdynmkt_datetime_displayoption Choices/Options

|Value|Label|
|---|---|
|100000000|**Date**|
|100000001|**Date & Time**|

### <a name="BKMK_msdynmkt_defaultvalue"></a> msdynmkt_defaultvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_defaultvalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdynmkt_errormessage"></a> msdynmkt_errormessage

|Property|Value|
|---|---|
|Description|**Error message**|
|DisplayName|**Error message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_errormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdynmkt_fieldoptions"></a> msdynmkt_fieldoptions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_fieldoptions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdynmkt_fieldtype"></a> msdynmkt_fieldtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_fieldtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_hide"></a> msdynmkt_hide

|Property|Value|
|---|---|
|Description|**Hide field**|
|DisplayName|**Hide field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_hide`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_marketingformfield_msdynmkt_hide`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_icon"></a> msdynmkt_icon

|Property|Value|
|---|---|
|Description||
|DisplayName|**Icon**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_icon`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_lookup_targets"></a> msdynmkt_lookup_targets

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lookup targets**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lookup_targets`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdynmkt_marketingformfieldId"></a> msdynmkt_marketingformfieldId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Form field**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingformfieldid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_maxlength"></a> msdynmkt_maxlength

|Property|Value|
|---|---|
|Description|**Max size of form field.**|
|DisplayName|**Max size of form field.**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_maxlength`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

### <a name="BKMK_msdynmkt_optionsetdisplayoption"></a> msdynmkt_optionsetdisplayoption

|Property|Value|
|---|---|
|Description||
|DisplayName|**OptionSet Display Option**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_optionsetdisplayoption`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_marketingformfield_msdynmkt_optionsetdisplayoption`|

#### msdynmkt_optionsetdisplayoption Choices/Options

|Value|Label|
|---|---|
|100000000|**Radio button**|
|100000001|**Dropdown**|

### <a name="BKMK_msdynmkt_placeholder"></a> msdynmkt_placeholder

|Property|Value|
|---|---|
|Description|**Placeholder text**|
|DisplayName|**Placeholder text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_placeholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdynmkt_publicvisibility"></a> msdynmkt_publicvisibility

|Property|Value|
|---|---|
|Description|**I acknowledge the select lookup will be visible to public**|
|DisplayName|**Make lookup data publicly viewable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_publicvisibility`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_marketingformfield_msdynmkt_publicvisibility`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_required"></a> msdynmkt_required

|Property|Value|
|---|---|
|Description|**Required**|
|DisplayName|**Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_required`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_marketingformfield_msdynmkt_required`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_targetentity"></a> msdynmkt_targetentity

|Property|Value|
|---|---|
|Description|**Target audience attribute**|
|DisplayName|**Audience**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_targetentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdynmkt_targetproperty"></a> msdynmkt_targetproperty

|Property|Value|
|---|---|
|Description|**Form field maps to target audience property**|
|DisplayName|**Maps to property**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_targetproperty`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdynmkt_twooption_displayoption"></a> msdynmkt_twooption_displayoption

|Property|Value|
|---|---|
|Description||
|DisplayName|**Two-option Display Option**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_twooption_displayoption`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdynmkt_msdynmkt_marketingformfield_msdynmkt_twooption_displayoption`|

#### msdynmkt_twooption_displayoption Choices/Options

|Value|Label|
|---|---|
|100000000|**Radio button**|
|100000001|**Checkbox**|

### <a name="BKMK_msdynmkt_validation"></a> msdynmkt_validation

|Property|Value|
|---|---|
|Description|**Validation**|
|DisplayName|**Validation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_validation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_marketingformfield_msdynmkt_validation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_validationpattern"></a> msdynmkt_validationpattern

|Property|Value|
|---|---|
|Description|**Validation pattern**|
|DisplayName|**Validation pattern**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_validationpattern`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

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
|Description|**Status of the Form field**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_marketingformfield_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Form field**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_marketingformfield_statuscode`|

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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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
|DisplayName|**Owning Business Unit**|
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

- [business_unit_msdynmkt_marketingformfield](#BKMK_business_unit_msdynmkt_marketingformfield)
- [lk_msdynmkt_marketingformfield_createdby](#BKMK_lk_msdynmkt_marketingformfield_createdby)
- [lk_msdynmkt_marketingformfield_createdonbehalfby](#BKMK_lk_msdynmkt_marketingformfield_createdonbehalfby)
- [lk_msdynmkt_marketingformfield_modifiedby](#BKMK_lk_msdynmkt_marketingformfield_modifiedby)
- [lk_msdynmkt_marketingformfield_modifiedonbehalfby](#BKMK_lk_msdynmkt_marketingformfield_modifiedonbehalfby)
- [owner_msdynmkt_marketingformfield](#BKMK_owner_msdynmkt_marketingformfield)
- [team_msdynmkt_marketingformfield](#BKMK_team_msdynmkt_marketingformfield)
- [user_msdynmkt_marketingformfield](#BKMK_user_msdynmkt_marketingformfield)

### <a name="BKMK_business_unit_msdynmkt_marketingformfield"></a> business_unit_msdynmkt_marketingformfield

One-To-Many Relationship: [businessunit business_unit_msdynmkt_marketingformfield](businessunit.md#BKMK_business_unit_msdynmkt_marketingformfield)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingformfield_createdby"></a> lk_msdynmkt_marketingformfield_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingformfield_createdby](systemuser.md#BKMK_lk_msdynmkt_marketingformfield_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingformfield_createdonbehalfby"></a> lk_msdynmkt_marketingformfield_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingformfield_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_marketingformfield_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingformfield_modifiedby"></a> lk_msdynmkt_marketingformfield_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingformfield_modifiedby](systemuser.md#BKMK_lk_msdynmkt_marketingformfield_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingformfield_modifiedonbehalfby"></a> lk_msdynmkt_marketingformfield_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingformfield_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_marketingformfield_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_marketingformfield"></a> owner_msdynmkt_marketingformfield

One-To-Many Relationship: [owner owner_msdynmkt_marketingformfield](owner.md#BKMK_owner_msdynmkt_marketingformfield)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_marketingformfield"></a> team_msdynmkt_marketingformfield

One-To-Many Relationship: [team team_msdynmkt_marketingformfield](team.md#BKMK_team_msdynmkt_marketingformfield)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_marketingformfield"></a> user_msdynmkt_marketingformfield

One-To-Many Relationship: [systemuser user_msdynmkt_marketingformfield](systemuser.md#BKMK_user_msdynmkt_marketingformfield)

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

- [msdynmkt_marketingformfield_AsyncOperations](#BKMK_msdynmkt_marketingformfield_AsyncOperations)
- [msdynmkt_marketingformfield_BulkDeleteFailures](#BKMK_msdynmkt_marketingformfield_BulkDeleteFailures)
- [msdynmkt_marketingformfield_DuplicateBaseRecord](#BKMK_msdynmkt_marketingformfield_DuplicateBaseRecord)
- [msdynmkt_marketingformfield_DuplicateMatchingRecord](#BKMK_msdynmkt_marketingformfield_DuplicateMatchingRecord)
- [msdynmkt_marketingformfield_MailboxTrackingFolders](#BKMK_msdynmkt_marketingformfield_MailboxTrackingFolders)
- [msdynmkt_marketingformfield_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_marketingformfield_PrincipalObjectAttributeAccesses)
- [msdynmkt_marketingformfield_ProcessSession](#BKMK_msdynmkt_marketingformfield_ProcessSession)
- [msdynmkt_marketingformfield_SyncErrors](#BKMK_msdynmkt_marketingformfield_SyncErrors)

### <a name="BKMK_msdynmkt_marketingformfield_AsyncOperations"></a> msdynmkt_marketingformfield_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_marketingformfield_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_marketingformfield_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformfield_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformfield_BulkDeleteFailures"></a> msdynmkt_marketingformfield_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_marketingformfield_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_marketingformfield_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformfield_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformfield_DuplicateBaseRecord"></a> msdynmkt_marketingformfield_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_marketingformfield_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_marketingformfield_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformfield_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformfield_DuplicateMatchingRecord"></a> msdynmkt_marketingformfield_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_marketingformfield_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_marketingformfield_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformfield_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformfield_MailboxTrackingFolders"></a> msdynmkt_marketingformfield_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_marketingformfield_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_marketingformfield_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformfield_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformfield_PrincipalObjectAttributeAccesses"></a> msdynmkt_marketingformfield_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_marketingformfield_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_marketingformfield_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformfield_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformfield_ProcessSession"></a> msdynmkt_marketingformfield_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_marketingformfield_ProcessSession](processsession.md#BKMK_msdynmkt_marketingformfield_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformfield_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformfield_SyncErrors"></a> msdynmkt_marketingformfield_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_marketingformfield_SyncErrors](syncerror.md#BKMK_msdynmkt_marketingformfield_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformfield_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

