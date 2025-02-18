---
title: "Entitlement Template Channel (EntitlementTemplateChannel) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Entitlement Template Channel (EntitlementTemplateChannel) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Entitlement Template Channel (EntitlementTemplateChannel) table/entity reference (Microsoft Dynamics 365)

Contains predefined support terms for a channel to create entitlements for customers.

## Messages

The following table lists the messages for the Entitlement Template Channel (EntitlementTemplateChannel) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /entitlementtemplatechannels<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /entitlementtemplatechannels(*entitlementtemplatechannelid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /entitlementtemplatechannels(*entitlementtemplatechannelid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /entitlementtemplatechannels<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /entitlementtemplatechannels(*entitlementtemplatechannelid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /entitlementtemplatechannels(*entitlementtemplatechannelid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|

## Properties

The following table lists selected properties for the Entitlement Template Channel (EntitlementTemplateChannel) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Entitlement Template Channel** |
| **DisplayCollectionName** | **Entitlement Template Channels** |
| **SchemaName** | `EntitlementTemplateChannel` |
| **CollectionSchemaName** | `EntitlementTemplateChannels` |
| **EntitySetName** | `entitlementtemplatechannels`|
| **LogicalName** | `entitlementtemplatechannel` |
| **LogicalCollectionName** | `entitlementtemplatechannels` |
| **PrimaryIdAttribute** | `entitlementtemplatechannelid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Channel](#BKMK_Channel)
- [EntitlementTemplateChannelId](#BKMK_EntitlementTemplateChannelId)
- [EntitlementTemplateId](#BKMK_EntitlementTemplateId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalTerms](#BKMK_TotalTerms)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_Channel"></a> Channel

|Property|Value|
|---|---|
|Description|**Select a channel for which you are defining the entitlement terms.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`channel`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`incident_caseorigincode`|

#### Channel Choices/Options

|Value|Label|
|---|---|
|1|**Phone**|
|2|**Email**|
|3|**Web**|
|2483|**Facebook**|
|3986|**Twitter**|
|700610000|**IoT**|

### <a name="BKMK_EntitlementTemplateChannelId"></a> EntitlementTemplateChannelId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Entitlement Template Channel**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entitlementtemplatechannelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_EntitlementTemplateId"></a> EntitlementTemplateId

|Property|Value|
|---|---|
|Description|**Unique identifier for Entitlement Template associated with Entitlement Template Channel.**|
|DisplayName|**Entitlement Template Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`entitlementtemplateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|entitlementchannel|

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

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Entitlement Template Channel Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_TotalTerms"></a> TotalTerms

|Property|Value|
|---|---|
|Description|**Type the total number of entitlement terms.**|
|DisplayName|**Total Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalterms`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the incident.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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
- [ExchangeRate](#BKMK_ExchangeRate)
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

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the incident with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

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
|Description|**Unique identifier of the organization with which the entitlement template channel is associated.**|
|DisplayName|**Organization**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
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

- [entitlementtemplate_entitlementchannel_entitlementtemplateid](#BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid)
- [entitlementtemplatechannel_organization](#BKMK_entitlementtemplatechannel_organization)
- [lk_entitlementtemplatechannel_createdby](#BKMK_lk_entitlementtemplatechannel_createdby)
- [lk_entitlementtemplatechannel_createdonbehalfby](#BKMK_lk_entitlementtemplatechannel_createdonbehalfby)
- [lk_entitlementtemplatechannel_modifiedby](#BKMK_lk_entitlementtemplatechannel_modifiedby)
- [lk_entitlementtemplatechannel_modifiedonbehalfby](#BKMK_lk_entitlementtemplatechannel_modifiedonbehalfby)
- [TransactionCurrency_entitlementtemplatechannel](#BKMK_TransactionCurrency_entitlementtemplatechannel)

### <a name="BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid"></a> entitlementtemplate_entitlementchannel_entitlementtemplateid

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_entitlementchannel_entitlementtemplateid](entitlementtemplate.md#BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`entitlementtemplateid`|
|ReferencingEntityNavigationPropertyName|`entitlementtemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementtemplatechannel_organization"></a> entitlementtemplatechannel_organization

One-To-Many Relationship: [organization entitlementtemplatechannel_organization](organization.md#BKMK_entitlementtemplatechannel_organization)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlementtemplatechannel_createdby"></a> lk_entitlementtemplatechannel_createdby

One-To-Many Relationship: [systemuser lk_entitlementtemplatechannel_createdby](systemuser.md#BKMK_lk_entitlementtemplatechannel_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlementtemplatechannel_createdonbehalfby"></a> lk_entitlementtemplatechannel_createdonbehalfby

One-To-Many Relationship: [systemuser lk_entitlementtemplatechannel_createdonbehalfby](systemuser.md#BKMK_lk_entitlementtemplatechannel_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlementtemplatechannel_modifiedby"></a> lk_entitlementtemplatechannel_modifiedby

One-To-Many Relationship: [systemuser lk_entitlementtemplatechannel_modifiedby](systemuser.md#BKMK_lk_entitlementtemplatechannel_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlementtemplatechannel_modifiedonbehalfby"></a> lk_entitlementtemplatechannel_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_entitlementtemplatechannel_modifiedonbehalfby](systemuser.md#BKMK_lk_entitlementtemplatechannel_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_entitlementtemplatechannel"></a> TransactionCurrency_entitlementtemplatechannel

One-To-Many Relationship: [transactioncurrency TransactionCurrency_entitlementtemplatechannel](transactioncurrency.md#BKMK_TransactionCurrency_entitlementtemplatechannel)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [entitlementtemplatechannel_AsyncOperations](#BKMK_entitlementtemplatechannel_AsyncOperations)
- [entitlementtemplatechannel_BulkDeleteFailures](#BKMK_entitlementtemplatechannel_BulkDeleteFailures)
- [entitlementtemplatechannel_connections1](#BKMK_entitlementtemplatechannel_connections1)
- [entitlementtemplatechannel_connections2](#BKMK_entitlementtemplatechannel_connections2)
- [entitlementtemplatechannel_MailboxTrackingFolders](#BKMK_entitlementtemplatechannel_MailboxTrackingFolders)
- [entitlementtemplatechannel_PrincipalObjectAttributeAccesses](#BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses)
- [entitlementtemplatechannel_SyncErrors](#BKMK_entitlementtemplatechannel_SyncErrors)

### <a name="BKMK_entitlementtemplatechannel_AsyncOperations"></a> entitlementtemplatechannel_AsyncOperations

Many-To-One Relationship: [asyncoperation entitlementtemplatechannel_AsyncOperations](asyncoperation.md#BKMK_entitlementtemplatechannel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplatechannel_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplatechannel_BulkDeleteFailures"></a> entitlementtemplatechannel_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure entitlementtemplatechannel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_entitlementtemplatechannel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplatechannel_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplatechannel_connections1"></a> entitlementtemplatechannel_connections1

Many-To-One Relationship: [connection entitlementtemplatechannel_connections1](connection.md#BKMK_entitlementtemplatechannel_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplatechannel_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplatechannel_connections2"></a> entitlementtemplatechannel_connections2

Many-To-One Relationship: [connection entitlementtemplatechannel_connections2](connection.md#BKMK_entitlementtemplatechannel_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplatechannel_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplatechannel_MailboxTrackingFolders"></a> entitlementtemplatechannel_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder entitlementtemplatechannel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_entitlementtemplatechannel_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplatechannel_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses"></a> entitlementtemplatechannel_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess entitlementtemplatechannel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplatechannel_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplatechannel_SyncErrors"></a> entitlementtemplatechannel_SyncErrors

Many-To-One Relationship: [syncerror entitlementtemplatechannel_SyncErrors](syncerror.md#BKMK_entitlementtemplatechannel_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplatechannel_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

