---
title: "GDPR consent change record (msgdpr_gdprconsentchangerecord) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the GDPR consent change record (msgdpr_gdprconsentchangerecord) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# GDPR consent change record (msgdpr_gdprconsentchangerecord) table/entity reference



## Messages

The following table lists the messages for the GDPR consent change record (msgdpr_gdprconsentchangerecord) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msgdpr_gdprconsentchangerecords<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msgdpr_gdprconsentchangerecords(*msgdpr_gdprconsentchangerecordid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msgdpr_gdprconsentchangerecords(*msgdpr_gdprconsentchangerecordid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msgdpr_gdprconsentchangerecords<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msgdpr_gdprconsentchangerecords(*msgdpr_gdprconsentchangerecordid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msgdpr_gdprconsentchangerecords(*msgdpr_gdprconsentchangerecordid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msgdpr_gdprconsentchangerecords(*msgdpr_gdprconsentchangerecordid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the GDPR consent change record (msgdpr_gdprconsentchangerecord) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the GDPR consent change record (msgdpr_gdprconsentchangerecord) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **GDPR consent change record** |
| **DisplayCollectionName** | **GDPR consent change records** |
| **SchemaName** | `msgdpr_gdprconsentchangerecord` |
| **CollectionSchemaName** | `msgdpr_gdprconsentchangerecords` |
| **EntitySetName** | `msgdpr_gdprconsentchangerecords`|
| **LogicalName** | `msgdpr_gdprconsentchangerecord` |
| **LogicalCollectionName** | `msgdpr_gdprconsentchangerecords` |
| **PrimaryIdAttribute** | `msgdpr_gdprconsentchangerecordid` |
| **PrimaryNameAttribute** |`msgdpr_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msgdpr_changedby](#BKMK_msgdpr_changedby)
- [msgdpr_consentchangesource](#BKMK_msgdpr_consentchangesource)
- [msgdpr_consentchangesourceform](#BKMK_msgdpr_consentchangesourceform)
- [msgdpr_contactid](#BKMK_msgdpr_contactid)
- [msgdpr_gdprconsentchangerecordId](#BKMK_msgdpr_gdprconsentchangerecordId)
- [msgdpr_name](#BKMK_msgdpr_name)
- [msgdpr_value](#BKMK_msgdpr_value)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msgdpr_changedby"></a> msgdpr_changedby

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Changed By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_changedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msgdpr_consentchangesource"></a> msgdpr_consentchangesource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_consentchangesource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msgdpr_consentchangesourceform"></a> msgdpr_consentchangesourceform

|Property|Value|
|---|---|
|Description|**Source form id**|
|DisplayName|**Source Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_consentchangesourceform`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingform|

### <a name="BKMK_msgdpr_contactid"></a> msgdpr_contactid

|Property|Value|
|---|---|
|Description|**Unique identifier for contact associated with GDPR consent change record**|
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_contactid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msgdpr_gdprconsentchangerecordId"></a> msgdpr_gdprconsentchangerecordId

|Property|Value|
|---|---|
|Description|**Unique identifier for this entity**|
|DisplayName|**GDPR consent change record**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msgdpr_gdprconsentchangerecordid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msgdpr_name"></a> msgdpr_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msgdpr_value"></a> msgdpr_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_value`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msgdpr_gdpr_consent_option_set`|

#### msgdpr_value Choices/Options

|Value|Label|
|---|---|
|587030001|**(1) Consent**|
|587030002|**(2) Transactional**|
|587030003|**(3) Subscriptions**|
|587030004|**(4) Marketing**|
|587030005|**(5) Profiling**|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the GDPR consent change record**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msgdpr_gdprconsentchangerecord_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the GDPR consent change record**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msgdpr_gdprconsentchangerecord_statuscode`|

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
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization ID**|
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

- [lk_msgdpr_gdprconsentchangerecord_createdby](#BKMK_lk_msgdpr_gdprconsentchangerecord_createdby)
- [lk_msgdpr_gdprconsentchangerecord_createdonbehalfby](#BKMK_lk_msgdpr_gdprconsentchangerecord_createdonbehalfby)
- [lk_msgdpr_gdprconsentchangerecord_modifiedby](#BKMK_lk_msgdpr_gdprconsentchangerecord_modifiedby)
- [lk_msgdpr_gdprconsentchangerecord_modifiedonbehalfby](#BKMK_lk_msgdpr_gdprconsentchangerecord_modifiedonbehalfby)
- [msgdpr_contact_msgdpr_gdprconsentchangerecord](#BKMK_msgdpr_contact_msgdpr_gdprconsentchangerecord)
- [msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord](#BKMK_msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord)
- [msgdpr_systemuser_msgdpr_gdprconsentchangerecord_changedby](#BKMK_msgdpr_systemuser_msgdpr_gdprconsentchangerecord_changedby)
- [organization_msgdpr_gdprconsentchangerecord](#BKMK_organization_msgdpr_gdprconsentchangerecord)

### <a name="BKMK_lk_msgdpr_gdprconsentchangerecord_createdby"></a> lk_msgdpr_gdprconsentchangerecord_createdby

One-To-Many Relationship: [systemuser lk_msgdpr_gdprconsentchangerecord_createdby](systemuser.md#BKMK_lk_msgdpr_gdprconsentchangerecord_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msgdpr_gdprconsentchangerecord_createdonbehalfby"></a> lk_msgdpr_gdprconsentchangerecord_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msgdpr_gdprconsentchangerecord_createdonbehalfby](systemuser.md#BKMK_lk_msgdpr_gdprconsentchangerecord_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msgdpr_gdprconsentchangerecord_modifiedby"></a> lk_msgdpr_gdprconsentchangerecord_modifiedby

One-To-Many Relationship: [systemuser lk_msgdpr_gdprconsentchangerecord_modifiedby](systemuser.md#BKMK_lk_msgdpr_gdprconsentchangerecord_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msgdpr_gdprconsentchangerecord_modifiedonbehalfby"></a> lk_msgdpr_gdprconsentchangerecord_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msgdpr_gdprconsentchangerecord_modifiedonbehalfby](systemuser.md#BKMK_lk_msgdpr_gdprconsentchangerecord_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msgdpr_contact_msgdpr_gdprconsentchangerecord"></a> msgdpr_contact_msgdpr_gdprconsentchangerecord

One-To-Many Relationship: [contact msgdpr_contact_msgdpr_gdprconsentchangerecord](contact.md#BKMK_msgdpr_contact_msgdpr_gdprconsentchangerecord)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msgdpr_contactid`|
|ReferencingEntityNavigationPropertyName|`msgdpr_contactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord"></a> msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord

One-To-Many Relationship: [msdyncrm_marketingform msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord](msdyncrm_marketingform.md#BKMK_msgdpr_msdyncrm_marketingform_msgdpr_gdprconsentchangerecord)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingform`|
|ReferencedAttribute|`msdyncrm_marketingformid`|
|ReferencingAttribute|`msgdpr_consentchangesourceform`|
|ReferencingEntityNavigationPropertyName|`msgdpr_consentchangesourceform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msgdpr_systemuser_msgdpr_gdprconsentchangerecord_changedby"></a> msgdpr_systemuser_msgdpr_gdprconsentchangerecord_changedby

One-To-Many Relationship: [systemuser msgdpr_systemuser_msgdpr_gdprconsentchangerecord_changedby](systemuser.md#BKMK_msgdpr_systemuser_msgdpr_gdprconsentchangerecord_changedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msgdpr_changedby`|
|ReferencingEntityNavigationPropertyName|`msgdpr_changedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msgdpr_gdprconsentchangerecord"></a> organization_msgdpr_gdprconsentchangerecord

One-To-Many Relationship: [organization organization_msgdpr_gdprconsentchangerecord](organization.md#BKMK_organization_msgdpr_gdprconsentchangerecord)

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

- [msgdpr_gdprconsentchangerecord_AsyncOperations](#BKMK_msgdpr_gdprconsentchangerecord_AsyncOperations)
- [msgdpr_gdprconsentchangerecord_BulkDeleteFailures](#BKMK_msgdpr_gdprconsentchangerecord_BulkDeleteFailures)
- [msgdpr_gdprconsentchangerecord_DuplicateBaseRecord](#BKMK_msgdpr_gdprconsentchangerecord_DuplicateBaseRecord)
- [msgdpr_gdprconsentchangerecord_DuplicateMatchingRecord](#BKMK_msgdpr_gdprconsentchangerecord_DuplicateMatchingRecord)
- [msgdpr_gdprconsentchangerecord_MailboxTrackingFolders](#BKMK_msgdpr_gdprconsentchangerecord_MailboxTrackingFolders)
- [msgdpr_gdprconsentchangerecord_PrincipalObjectAttributeAccesses](#BKMK_msgdpr_gdprconsentchangerecord_PrincipalObjectAttributeAccesses)
- [msgdpr_gdprconsentchangerecord_ProcessSession](#BKMK_msgdpr_gdprconsentchangerecord_ProcessSession)
- [msgdpr_gdprconsentchangerecord_SyncErrors](#BKMK_msgdpr_gdprconsentchangerecord_SyncErrors)

### <a name="BKMK_msgdpr_gdprconsentchangerecord_AsyncOperations"></a> msgdpr_gdprconsentchangerecord_AsyncOperations

Many-To-One Relationship: [asyncoperation msgdpr_gdprconsentchangerecord_AsyncOperations](asyncoperation.md#BKMK_msgdpr_gdprconsentchangerecord_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_gdprconsentchangerecord_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_gdprconsentchangerecord_BulkDeleteFailures"></a> msgdpr_gdprconsentchangerecord_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msgdpr_gdprconsentchangerecord_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msgdpr_gdprconsentchangerecord_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_gdprconsentchangerecord_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_gdprconsentchangerecord_DuplicateBaseRecord"></a> msgdpr_gdprconsentchangerecord_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msgdpr_gdprconsentchangerecord_DuplicateBaseRecord](duplicaterecord.md#BKMK_msgdpr_gdprconsentchangerecord_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_gdprconsentchangerecord_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_gdprconsentchangerecord_DuplicateMatchingRecord"></a> msgdpr_gdprconsentchangerecord_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msgdpr_gdprconsentchangerecord_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msgdpr_gdprconsentchangerecord_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_gdprconsentchangerecord_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_gdprconsentchangerecord_MailboxTrackingFolders"></a> msgdpr_gdprconsentchangerecord_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msgdpr_gdprconsentchangerecord_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msgdpr_gdprconsentchangerecord_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_gdprconsentchangerecord_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_gdprconsentchangerecord_PrincipalObjectAttributeAccesses"></a> msgdpr_gdprconsentchangerecord_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msgdpr_gdprconsentchangerecord_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msgdpr_gdprconsentchangerecord_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_gdprconsentchangerecord_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_gdprconsentchangerecord_ProcessSession"></a> msgdpr_gdprconsentchangerecord_ProcessSession

Many-To-One Relationship: [processsession msgdpr_gdprconsentchangerecord_ProcessSession](processsession.md#BKMK_msgdpr_gdprconsentchangerecord_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_gdprconsentchangerecord_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_gdprconsentchangerecord_SyncErrors"></a> msgdpr_gdprconsentchangerecord_SyncErrors

Many-To-One Relationship: [syncerror msgdpr_gdprconsentchangerecord_SyncErrors](syncerror.md#BKMK_msgdpr_gdprconsentchangerecord_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_gdprconsentchangerecord_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

