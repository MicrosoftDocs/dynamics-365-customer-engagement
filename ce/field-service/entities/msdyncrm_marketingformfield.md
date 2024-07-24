---
title: "Marketing form field (msdyncrm_marketingformfield) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing form field (msdyncrm_marketingformfield) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing form field (msdyncrm_marketingformfield) table/entity reference



## Messages

The following table lists the messages for the Marketing form field (msdyncrm_marketingformfield) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingformfields(*msdyncrm_marketingformfieldid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingformfields<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingformfields(*msdyncrm_marketingformfieldid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingformfields(*msdyncrm_marketingformfieldid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingformfields<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingformfields(*msdyncrm_marketingformfieldid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingformfields(*msdyncrm_marketingformfieldid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingformfields(*msdyncrm_marketingformfieldid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing form field (msdyncrm_marketingformfield) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing form field (msdyncrm_marketingformfield) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing form field** |
| **DisplayCollectionName** | **Marketing form fields** |
| **SchemaName** | `msdyncrm_marketingformfield` |
| **CollectionSchemaName** | `msdyncrm_marketingformfields` |
| **EntitySetName** | `msdyncrm_marketingformfields`|
| **LogicalName** | `msdyncrm_marketingformfield` |
| **LogicalCollectionName** | `msdyncrm_marketingformfields` |
| **PrimaryIdAttribute** | `msdyncrm_marketingformfieldid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_contactmapping](#BKMK_msdyncrm_contactmapping)
- [msdyncrm_contactmapping_target](#BKMK_msdyncrm_contactmapping_target)
- [msdyncrm_defaultformlabel](#BKMK_msdyncrm_defaultformlabel)
- [msdyncrm_defaultformplaceholder](#BKMK_msdyncrm_defaultformplaceholder)
- [msdyncrm_format](#BKMK_msdyncrm_format)
- [msdyncrm_leadmapping](#BKMK_msdyncrm_leadmapping)
- [msdyncrm_leadmapping_target](#BKMK_msdyncrm_leadmapping_target)
- [msdyncrm_lookup_target](#BKMK_msdyncrm_lookup_target)
- [msdyncrm_marketingformfieldId](#BKMK_msdyncrm_marketingformfieldId)
- [msdyncrm_marketingformfieldtype](#BKMK_msdyncrm_marketingformfieldtype)
- [msdyncrm_marketingprovided](#BKMK_msdyncrm_marketingprovided)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_prototype_attribute](#BKMK_msdyncrm_prototype_attribute)
- [msdyncrm_prototype_entity](#BKMK_msdyncrm_prototype_entity)
- [msdyncrm_prototype_target](#BKMK_msdyncrm_prototype_target)
- [msdyncrm_PublicVisibility](#BKMK_msdyncrm_PublicVisibility)
- [msdyncrm_renderas](#BKMK_msdyncrm_renderas)
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

### <a name="BKMK_msdyncrm_contactmapping"></a> msdyncrm_contactmapping

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactmapping`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_contactmapping_target"></a> msdyncrm_contactmapping_target

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact mapping targets**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactmapping_target`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_defaultformlabel"></a> msdyncrm_defaultformlabel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultformlabel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_defaultformplaceholder"></a> msdyncrm_defaultformplaceholder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Placeholder**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultformplaceholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_format"></a> msdyncrm_format

|Property|Value|
|---|---|
|Description||
|DisplayName|**Format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_format`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingformfield_supporteddataformats`|

#### msdyncrm_format Choices/Options

|Value|Label|
|---|---|
|1|**Text**|
|2|**Text area**|
|3|**Email**|
|4|**URL**|
|5|**Phone**|
|6|**Date**|
|7|**Date and time**|

### <a name="BKMK_msdyncrm_leadmapping"></a> msdyncrm_leadmapping

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadmapping`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_leadmapping_target"></a> msdyncrm_leadmapping_target

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead mapping targets**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadmapping_target`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_lookup_target"></a> msdyncrm_lookup_target

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lookup targets**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lookup_target`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_marketingformfieldId"></a> msdyncrm_marketingformfieldId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing form field**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformfieldid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_marketingformfieldtype"></a> msdyncrm_marketingformfieldtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformfieldtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingformfield_supporteddatatypes`|

#### msdyncrm_marketingformfieldtype Choices/Options

|Value|Label|
|---|---|
|1|**Single line of text**|
|2|**Multiple lines of text**|
|3|**Option set**|
|4|**Two options**|
|5|**Whole number**|
|6|**Floating point number**|
|7|**Decimal number**|
|8|**Date and time**|
|9|**Currency**|
|10|**Multi-select option set**|
|11|**Lookup**|

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
|GlobalChoiceName|`msdyncrm_marketingformfield_msdyncrm_marketingprovided`|
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

### <a name="BKMK_msdyncrm_prototype_attribute"></a> msdyncrm_prototype_attribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Unmapped attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_prototype_attribute`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_prototype_entity"></a> msdyncrm_prototype_entity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Unmapped entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_prototype_entity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_prototype_target"></a> msdyncrm_prototype_target

|Property|Value|
|---|---|
|Description||
|DisplayName|**Unmapped targets**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_prototype_target`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_PublicVisibility"></a> msdyncrm_PublicVisibility

|Property|Value|
|---|---|
|Description|**I acknowledge the select lookup will be visible to public**|
|DisplayName|**Lookup will be visible to public**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_publicvisibility`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_msdyncrm_marketingformfield_msdyncrm_publicvisibility`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_renderas"></a> msdyncrm_renderas

|Property|Value|
|---|---|
|Description||
|DisplayName|**Rendering control**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_renderas`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingformfield_renderingcontrols`|

#### msdyncrm_renderas Choices/Options

|Value|Label|
|---|---|
|1|**Text box**|
|2|**Email input**|
|3|**URL input**|
|4|**Phone input**|
|5|**Number input**|
|6|**Text area**|
|7|**Checkbox**|
|8|**Drop-down**|
|9|**Radio buttons**|
|10|**Date picker**|
|11|**Date time picker**|
|12|**Checkbox list**|
|13|**Lookup**|

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
|Description|**Status of the marketing form field**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingformfield_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the marketing form field**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingformfield_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyncrm_marketingformfield](#BKMK_business_unit_msdyncrm_marketingformfield)
- [lk_msdyncrm_marketingformfield_createdby](#BKMK_lk_msdyncrm_marketingformfield_createdby)
- [lk_msdyncrm_marketingformfield_createdonbehalfby](#BKMK_lk_msdyncrm_marketingformfield_createdonbehalfby)
- [lk_msdyncrm_marketingformfield_modifiedby](#BKMK_lk_msdyncrm_marketingformfield_modifiedby)
- [lk_msdyncrm_marketingformfield_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingformfield_modifiedonbehalfby)
- [owner_msdyncrm_marketingformfield](#BKMK_owner_msdyncrm_marketingformfield)
- [team_msdyncrm_marketingformfield](#BKMK_team_msdyncrm_marketingformfield)
- [user_msdyncrm_marketingformfield](#BKMK_user_msdyncrm_marketingformfield)

### <a name="BKMK_business_unit_msdyncrm_marketingformfield"></a> business_unit_msdyncrm_marketingformfield

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingformfield](businessunit.md#BKMK_business_unit_msdyncrm_marketingformfield)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformfield_createdby"></a> lk_msdyncrm_marketingformfield_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformfield_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingformfield_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformfield_createdonbehalfby"></a> lk_msdyncrm_marketingformfield_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformfield_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingformfield_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformfield_modifiedby"></a> lk_msdyncrm_marketingformfield_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformfield_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingformfield_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformfield_modifiedonbehalfby"></a> lk_msdyncrm_marketingformfield_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformfield_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingformfield_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingformfield"></a> owner_msdyncrm_marketingformfield

One-To-Many Relationship: [owner owner_msdyncrm_marketingformfield](owner.md#BKMK_owner_msdyncrm_marketingformfield)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingformfield"></a> team_msdyncrm_marketingformfield

One-To-Many Relationship: [team team_msdyncrm_marketingformfield](team.md#BKMK_team_msdyncrm_marketingformfield)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingformfield"></a> user_msdyncrm_marketingformfield

One-To-Many Relationship: [systemuser user_msdyncrm_marketingformfield](systemuser.md#BKMK_user_msdyncrm_marketingformfield)

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

- [msdyncrm_marketingformfield_AsyncOperations](#BKMK_msdyncrm_marketingformfield_AsyncOperations)
- [msdyncrm_marketingformfield_BulkDeleteFailures](#BKMK_msdyncrm_marketingformfield_BulkDeleteFailures)
- [msdyncrm_marketingformfield_DuplicateBaseRecord](#BKMK_msdyncrm_marketingformfield_DuplicateBaseRecord)
- [msdyncrm_marketingformfield_DuplicateMatchingRecord](#BKMK_msdyncrm_marketingformfield_DuplicateMatchingRecord)
- [msdyncrm_marketingformfield_MailboxTrackingFolders](#BKMK_msdyncrm_marketingformfield_MailboxTrackingFolders)
- [msdyncrm_marketingformfield_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingformfield_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingformfield_ProcessSession](#BKMK_msdyncrm_marketingformfield_ProcessSession)
- [msdyncrm_marketingformfield_submission](#BKMK_msdyncrm_marketingformfield_submission)
- [msdyncrm_marketingformfield_SyncErrors](#BKMK_msdyncrm_marketingformfield_SyncErrors)

### <a name="BKMK_msdyncrm_marketingformfield_AsyncOperations"></a> msdyncrm_marketingformfield_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingformfield_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingformfield_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformfield_BulkDeleteFailures"></a> msdyncrm_marketingformfield_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingformfield_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingformfield_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformfield_DuplicateBaseRecord"></a> msdyncrm_marketingformfield_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_marketingformfield_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_marketingformfield_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformfield_DuplicateMatchingRecord"></a> msdyncrm_marketingformfield_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_marketingformfield_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_marketingformfield_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformfield_MailboxTrackingFolders"></a> msdyncrm_marketingformfield_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingformfield_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingformfield_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformfield_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingformfield_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingformfield_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingformfield_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformfield_ProcessSession"></a> msdyncrm_marketingformfield_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingformfield_ProcessSession](processsession.md#BKMK_msdyncrm_marketingformfield_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformfield_submission"></a> msdyncrm_marketingformfield_submission

Many-To-One Relationship: [msdyncrm_marketingfieldsubmission msdyncrm_marketingformfield_submission](msdyncrm_marketingfieldsubmission.md#BKMK_msdyncrm_marketingformfield_submission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingfieldsubmission`|
|ReferencingAttribute|`msdyncrm_marketingformfieldid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_submission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformfield_SyncErrors"></a> msdyncrm_marketingformfield_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingformfield_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingformfield_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformfield_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyncrm_formtemplate_marketingformfield](#BKMK_msdyncrm_formtemplate_marketingformfield)
- [msdyncrm_marketingform_marketingformfield](#BKMK_msdyncrm_marketingform_marketingformfield)

### <a name="BKMK_msdyncrm_formtemplate_marketingformfield"></a> msdyncrm_formtemplate_marketingformfield

See [msdyncrm_marketingformtemplate msdyncrm_formtemplate_marketingformfield Many-To-Many Relationship](msdyncrm_marketingformtemplate.md#BKMK_msdyncrm_formtemplate_marketingformfield)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_formtemplate_marketingformfield`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_formtemplate_marketingformfield`|
|IntersectAttribute|`msdyncrm_marketingformfieldid`|
|NavigationPropertyName|`msdyncrm_formtemplate_marketingformfield`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_marketingformfield"></a> msdyncrm_marketingform_marketingformfield

See [msdyncrm_marketingform msdyncrm_marketingform_marketingformfield Many-To-Many Relationship](msdyncrm_marketingform.md#BKMK_msdyncrm_marketingform_marketingformfield)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_marketingform_marketingformfield`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_marketingform_marketingformfield`|
|IntersectAttribute|`msdyncrm_marketingformfieldid`|
|NavigationPropertyName|`msdyncrm_marketingform_marketingformfield`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

