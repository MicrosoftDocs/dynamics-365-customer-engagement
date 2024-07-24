---
title: "(Deprecated) Contact Point Consent (msdynmkt_contactpointconsent2) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the (Deprecated) Contact Point Consent (msdynmkt_contactpointconsent2) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# (Deprecated) Contact Point Consent (msdynmkt_contactpointconsent2) table/entity reference



## Messages

The following table lists the messages for the (Deprecated) Contact Point Consent (msdynmkt_contactpointconsent2) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_contactpointconsent2s<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_contactpointconsent2s(*msdynmkt_contactpointconsent2id*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_contactpointconsent2s(*msdynmkt_contactpointconsent2id*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_contactpointconsent2s<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_contactpointconsent2s(*msdynmkt_contactpointconsent2id*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_contactpointconsent2s(*msdynmkt_contactpointconsent2id*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_contactpointconsent2s(*msdynmkt_contactpointconsent2id*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the (Deprecated) Contact Point Consent (msdynmkt_contactpointconsent2) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the (Deprecated) Contact Point Consent (msdynmkt_contactpointconsent2) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **(Deprecated) Contact Point Consent** |
| **DisplayCollectionName** | **(Deprecated) Contact Point Consents** |
| **SchemaName** | `msdynmkt_contactpointconsent2` |
| **CollectionSchemaName** | `msdynmkt_contactpointconsent2s` |
| **EntitySetName** | `msdynmkt_contactpointconsent2s`|
| **LogicalName** | `msdynmkt_contactpointconsent2` |
| **LogicalCollectionName** | `msdynmkt_contactpointconsent2s` |
| **PrimaryIdAttribute** | `msdynmkt_contactpointconsent2id` |
| **PrimaryNameAttribute** |`msdynmkt_contactpointvalue` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_consenttypevalue](#BKMK_msdynmkt_consenttypevalue)
- [msdynmkt_contactpointconsent2Id](#BKMK_msdynmkt_contactpointconsent2Id)
- [msdynmkt_contactpointtype](#BKMK_msdynmkt_contactpointtype)
- [msdynmkt_contactpointvalue](#BKMK_msdynmkt_contactpointvalue)
- [msdynmkt_logicalreason](#BKMK_msdynmkt_logicalreason)
- [msdynmkt_migrationtimestamp](#BKMK_msdynmkt_migrationtimestamp)
- [msdynmkt_modifiedonbehalf](#BKMK_msdynmkt_modifiedonbehalf)
- [msdynmkt_reason](#BKMK_msdynmkt_reason)
- [msdynmkt_source](#BKMK_msdynmkt_source)
- [msdynmkt_uionly_value_marketingmessage](#BKMK_msdynmkt_uionly_value_marketingmessage)
- [msdynmkt_uionly_value_tracking](#BKMK_msdynmkt_uionly_value_tracking)
- [msdynmkt_value](#BKMK_msdynmkt_value)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdynmkt_consenttypevalue"></a> msdynmkt_consenttypevalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent Type Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_consenttypevalue`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_consenttypevalue`|

#### msdynmkt_consenttypevalue Choices/Options

|Value|Label|
|---|---|
|534120000|**Marketing Communication**|
|534120001|**Tracking**|

### <a name="BKMK_msdynmkt_contactpointconsent2Id"></a> msdynmkt_contactpointconsent2Id

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Contact Point Consent**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactpointconsent2id`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_contactpointtype"></a> msdynmkt_contactpointtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactpointtype`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_contactpointtype`|

#### msdynmkt_contactpointtype Choices/Options

|Value|Label|
|---|---|
|534120000|**Email**|
|534120001|**Text Message**|
|534120002|**Custom**|

### <a name="BKMK_msdynmkt_contactpointvalue"></a> msdynmkt_contactpointvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact point**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactpointvalue`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_logicalreason"></a> msdynmkt_logicalreason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_logicalreason`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_reason`|

#### msdynmkt_logicalreason Choices/Options

|Value|Label|
|---|---|
|534119999|**No reasons**|
|534120000|**Opt-in - Advertisement**|
|534120001|**Opt-in - Landing page**|
|534120002|**Opt-in - Events**|
|534120003|**Opt-out - Content was irrelevant**|
|534120004|**Opt-out - Received too frequently**|
|534120005|**Opt-out - Didn’t recall signing up**|
|534120006|**Opt-out - Privacy concerns**|
|534120007|**Opt-out - One-click unsubscribe**|

### <a name="BKMK_msdynmkt_migrationtimestamp"></a> msdynmkt_migrationtimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**Migration timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_migrationtimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_modifiedonbehalf"></a> msdynmkt_modifiedonbehalf

|Property|Value|
|---|---|
|Description||
|DisplayName|**Who requested the change**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modifiedonbehalf`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_reason"></a> msdynmkt_reason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reason Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_reason`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_source"></a> msdynmkt_source

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_source`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_consentsource`|

#### msdynmkt_source Choices/Options

|Value|Label|
|---|---|
|534120000|**Internal**|
|534120001|**Preference page**|
|534120002|**Text message**|
|534120003|**Loaded**|
|534120004|**Preference Center**|
|534120005|**Realtime Marketing Form**|
|534120006|**Subscription Center**|
|534120007|**Email - list-unsubscribe**|

### <a name="BKMK_msdynmkt_uionly_value_marketingmessage"></a> msdynmkt_uionly_value_marketingmessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing message (used in ui only)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionly_value_marketingmessage`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_consentvalue`|

#### msdynmkt_uionly_value_marketingmessage Choices/Options

|Value|Label|
|---|---|
|534120000|**Not Set**|
|534120001|**Opted In**|
|534120002|**Opted Out**|

### <a name="BKMK_msdynmkt_uionly_value_tracking"></a> msdynmkt_uionly_value_tracking

|Property|Value|
|---|---|
|Description||
|DisplayName|**Tracking (used in ui only)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionly_value_tracking`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_consentvalue`|

#### msdynmkt_uionly_value_tracking Choices/Options

|Value|Label|
|---|---|
|534120000|**Not Set**|
|534120001|**Opted In**|
|534120002|**Opted Out**|

### <a name="BKMK_msdynmkt_value"></a> msdynmkt_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_value`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_consentvalue`|

#### msdynmkt_value Choices/Options

|Value|Label|
|---|---|
|534120000|**Not Set**|
|534120001|**Opted In**|
|534120002|**Opted Out**|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Contact Point Consent**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_contactpointconsent2_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Contact Point Consent**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_contactpointconsent2_statuscode`|

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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
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

- [lk_msdynmkt_contactpointconsent2_createdby](#BKMK_lk_msdynmkt_contactpointconsent2_createdby)
- [lk_msdynmkt_contactpointconsent2_createdonbehalfby](#BKMK_lk_msdynmkt_contactpointconsent2_createdonbehalfby)
- [lk_msdynmkt_contactpointconsent2_modifiedby](#BKMK_lk_msdynmkt_contactpointconsent2_modifiedby)
- [lk_msdynmkt_contactpointconsent2_modifiedonbehalfby](#BKMK_lk_msdynmkt_contactpointconsent2_modifiedonbehalfby)
- [organization_msdynmkt_contactpointconsent2](#BKMK_organization_msdynmkt_contactpointconsent2)

### <a name="BKMK_lk_msdynmkt_contactpointconsent2_createdby"></a> lk_msdynmkt_contactpointconsent2_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_contactpointconsent2_createdby](systemuser.md#BKMK_lk_msdynmkt_contactpointconsent2_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_contactpointconsent2_createdonbehalfby"></a> lk_msdynmkt_contactpointconsent2_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_contactpointconsent2_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_contactpointconsent2_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_contactpointconsent2_modifiedby"></a> lk_msdynmkt_contactpointconsent2_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_contactpointconsent2_modifiedby](systemuser.md#BKMK_lk_msdynmkt_contactpointconsent2_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_contactpointconsent2_modifiedonbehalfby"></a> lk_msdynmkt_contactpointconsent2_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_contactpointconsent2_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_contactpointconsent2_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdynmkt_contactpointconsent2"></a> organization_msdynmkt_contactpointconsent2

One-To-Many Relationship: [organization organization_msdynmkt_contactpointconsent2](organization.md#BKMK_organization_msdynmkt_contactpointconsent2)

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

- [msdynmkt_contactpointconsent2_AsyncOperations](#BKMK_msdynmkt_contactpointconsent2_AsyncOperations)
- [msdynmkt_contactpointconsent2_BulkDeleteFailures](#BKMK_msdynmkt_contactpointconsent2_BulkDeleteFailures)
- [msdynmkt_contactpointconsent2_DuplicateBaseRecord](#BKMK_msdynmkt_contactpointconsent2_DuplicateBaseRecord)
- [msdynmkt_contactpointconsent2_DuplicateMatchingRecord](#BKMK_msdynmkt_contactpointconsent2_DuplicateMatchingRecord)
- [msdynmkt_contactpointconsent2_MailboxTrackingFolders](#BKMK_msdynmkt_contactpointconsent2_MailboxTrackingFolders)
- [msdynmkt_contactpointconsent2_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_contactpointconsent2_PrincipalObjectAttributeAccesses)
- [msdynmkt_contactpointconsent2_ProcessSession](#BKMK_msdynmkt_contactpointconsent2_ProcessSession)
- [msdynmkt_contactpointconsent2_SyncErrors](#BKMK_msdynmkt_contactpointconsent2_SyncErrors)

### <a name="BKMK_msdynmkt_contactpointconsent2_AsyncOperations"></a> msdynmkt_contactpointconsent2_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_contactpointconsent2_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_contactpointconsent2_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent2_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent2_BulkDeleteFailures"></a> msdynmkt_contactpointconsent2_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_contactpointconsent2_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_contactpointconsent2_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent2_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent2_DuplicateBaseRecord"></a> msdynmkt_contactpointconsent2_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_contactpointconsent2_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_contactpointconsent2_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent2_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent2_DuplicateMatchingRecord"></a> msdynmkt_contactpointconsent2_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_contactpointconsent2_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_contactpointconsent2_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent2_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent2_MailboxTrackingFolders"></a> msdynmkt_contactpointconsent2_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_contactpointconsent2_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_contactpointconsent2_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent2_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent2_PrincipalObjectAttributeAccesses"></a> msdynmkt_contactpointconsent2_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_contactpointconsent2_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_contactpointconsent2_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent2_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent2_ProcessSession"></a> msdynmkt_contactpointconsent2_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_contactpointconsent2_ProcessSession](processsession.md#BKMK_msdynmkt_contactpointconsent2_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent2_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_contactpointconsent2_SyncErrors"></a> msdynmkt_contactpointconsent2_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_contactpointconsent2_SyncErrors](syncerror.md#BKMK_msdynmkt_contactpointconsent2_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_contactpointconsent2_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

