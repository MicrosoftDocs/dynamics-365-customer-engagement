---
title: "Facility/Equipment (Equipment) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Facility/Equipment (Equipment) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Facility/Equipment (Equipment) table/entity reference (Microsoft Dynamics 365)

Resource that can be scheduled.

## Messages

The following table lists the messages for the Facility/Equipment (Equipment) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /equipments<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /equipments(*equipmentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /equipments(*equipmentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /equipments<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetBusinessSystemUser`<br />Event: False |<xref:Microsoft.Dynamics.CRM.SetBusinessSystemUser?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.SetBusinessSystemUserRequest>|
| `Update`<br />Event: True |`PATCH` /equipments(*equipmentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /equipments(*equipmentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Facility/Equipment (Equipment) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Facility/Equipment** |
| **DisplayCollectionName** | **Facilities/Equipment** |
| **SchemaName** | `Equipment` |
| **CollectionSchemaName** | `Equipments` |
| **EntitySetName** | `equipments`|
| **LogicalName** | `equipment` |
| **LogicalCollectionName** | `equipments` |
| **PrimaryIdAttribute** | `equipmentid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `BusinessOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BusinessUnitId](#BKMK_BusinessUnitId)
- [CalendarId](#BKMK_CalendarId)
- [Description](#BKMK_Description)
- [DisplayInServiceViews](#BKMK_DisplayInServiceViews)
- [EMailAddress](#BKMK_EMailAddress)
- [EquipmentId](#BKMK_EquipmentId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsDisabled](#BKMK_IsDisabled)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [SiteId](#BKMK_SiteId)
- [Skills](#BKMK_Skills)
- [TimeZoneCode](#BKMK_TimeZoneCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|---|---|
|Description|**Shows the business unit that the Equipment belongs to.**|
|DisplayName|**Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`businessunitid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_CalendarId"></a> CalendarId

|Property|Value|
|---|---|
|Description|**Fiscal calendar associated with the facility/equipment.**|
|DisplayName|**Calendar**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`calendarid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|calendar|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Description of the facility/equipment.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_DisplayInServiceViews"></a> DisplayInServiceViews

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Display in Service Views**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`displayinserviceviews`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`equipment_displayinserviceviews`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_EMailAddress"></a> EMailAddress

|Property|Value|
|---|---|
|Description|**Email address of person to contact about the use of the facility/equipment.**|
|DisplayName|**Primary Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_EquipmentId"></a> EquipmentId

|Property|Value|
|---|---|
|Description|**Unique identifier of the facility/equipment.**|
|DisplayName|**Facility/Equipment**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`equipmentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_IsDisabled"></a> IsDisabled

|Property|Value|
|---|---|
|Description|**Whether the facility/equipment is disabled or operational.**|
|DisplayName|**Is Disabled**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isdisabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`equipment_isdisabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Name of the facility/equipment.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

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

### <a name="BKMK_SiteId"></a> SiteId

|Property|Value|
|---|---|
|Description|**Site where the facility/equipment is located.**|
|DisplayName|**Site**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`siteid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|site|

### <a name="BKMK_Skills"></a> Skills

|Property|Value|
|---|---|
|Description|**Skills needed to operate the facility/equipment.**|
|DisplayName|**Skills**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`skills`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TimeZoneCode"></a> TimeZoneCode

|Property|Value|
|---|---|
|Description|**Local time zone where the facility/equipment is located.**|
|DisplayName|**Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`timezonecode`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the equipment.**|
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
|Description|**Unique identifier of the user who created the facility/equipment entry.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
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
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who created the equipment.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the equipment with respect to the base currency.**|
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
|Description|**Unique identifier of the user who last modified the facility/equipment.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
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
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who last modified the equipment.**|
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
|Description|**Unique identifier of the parent business unit.**|
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

- [business_unit_equipment](#BKMK_business_unit_equipment)
- [calendar_equipment](#BKMK_calendar_equipment)
- [equipment_systemuser](#BKMK_equipment_systemuser)
- [lk_equipment_createdby](#BKMK_lk_equipment_createdby)
- [lk_equipment_createdonbehalfby](#BKMK_lk_equipment_createdonbehalfby)
- [lk_equipment_modifiedby](#BKMK_lk_equipment_modifiedby)
- [lk_equipment_modifiedonbehalfby](#BKMK_lk_equipment_modifiedonbehalfby)
- [organization_equipment](#BKMK_organization_equipment)
- [site_equipment](#BKMK_site_equipment)
- [TransactionCurrency_Equipment](#BKMK_TransactionCurrency_Equipment)

### <a name="BKMK_business_unit_equipment"></a> business_unit_equipment

One-To-Many Relationship: [businessunit business_unit_equipment](businessunit.md#BKMK_business_unit_equipment)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`businessunitid`|
|ReferencingEntityNavigationPropertyName|`businessunitid_businessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_calendar_equipment"></a> calendar_equipment

One-To-Many Relationship: [calendar calendar_equipment](calendar.md#BKMK_calendar_equipment)

|Property|Value|
|---|---|
|ReferencedEntity|`calendar`|
|ReferencedAttribute|`calendarid`|
|ReferencingAttribute|`calendarid`|
|ReferencingEntityNavigationPropertyName|`calendarid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_equipment_systemuser"></a> equipment_systemuser

One-To-Many Relationship: [systemuser equipment_systemuser](systemuser.md#BKMK_equipment_systemuser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`businessunitid`|
|ReferencingEntityNavigationPropertyName|`businessunitid_systemuser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_equipment_createdby"></a> lk_equipment_createdby

One-To-Many Relationship: [systemuser lk_equipment_createdby](systemuser.md#BKMK_lk_equipment_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_equipment_createdonbehalfby"></a> lk_equipment_createdonbehalfby

One-To-Many Relationship: [systemuser lk_equipment_createdonbehalfby](systemuser.md#BKMK_lk_equipment_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_equipment_modifiedby"></a> lk_equipment_modifiedby

One-To-Many Relationship: [systemuser lk_equipment_modifiedby](systemuser.md#BKMK_lk_equipment_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_equipment_modifiedonbehalfby"></a> lk_equipment_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_equipment_modifiedonbehalfby](systemuser.md#BKMK_lk_equipment_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_equipment"></a> organization_equipment

One-To-Many Relationship: [organization organization_equipment](organization.md#BKMK_organization_equipment)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_equipment"></a> site_equipment

One-To-Many Relationship: [site site_equipment](site.md#BKMK_site_equipment)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`siteid`|
|ReferencingEntityNavigationPropertyName|`siteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_Equipment"></a> TransactionCurrency_Equipment

One-To-Many Relationship: [transactioncurrency TransactionCurrency_Equipment](transactioncurrency.md#BKMK_TransactionCurrency_Equipment)

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

- [equipment_accounts](#BKMK_equipment_accounts)
- [equipment_activity_parties](#BKMK_equipment_activity_parties)
- [Equipment_Annotation](#BKMK_Equipment_Annotation)
- [Equipment_AsyncOperations](#BKMK_Equipment_AsyncOperations)
- [Equipment_BulkDeleteFailures](#BKMK_Equipment_BulkDeleteFailures)
- [equipment_connections1](#BKMK_equipment_connections1)
- [equipment_connections2](#BKMK_equipment_connections2)
- [equipment_contacts](#BKMK_equipment_contacts)
- [Equipment_DuplicateBaseRecord](#BKMK_Equipment_DuplicateBaseRecord)
- [Equipment_DuplicateMatchingRecord](#BKMK_Equipment_DuplicateMatchingRecord)
- [Equipment_Email_EmailSender](#BKMK_Equipment_Email_EmailSender)
- [equipment_MailboxTrackingFolders](#BKMK_equipment_MailboxTrackingFolders)
- [equipment_principalobjectattributeaccess](#BKMK_equipment_principalobjectattributeaccess)
- [Equipment_ProcessSessions](#BKMK_Equipment_ProcessSessions)
- [equipment_resources](#BKMK_equipment_resources)
- [Equipment_SyncErrors](#BKMK_Equipment_SyncErrors)

### <a name="BKMK_equipment_accounts"></a> equipment_accounts

Many-To-One Relationship: [account equipment_accounts](account.md#BKMK_equipment_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`preferredequipmentid`|
|ReferencedEntityNavigationPropertyName|`equipment_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_equipment_activity_parties"></a> equipment_activity_parties

Many-To-One Relationship: [activityparty equipment_activity_parties](activityparty.md#BKMK_equipment_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`equipment_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Equipment_Annotation"></a> Equipment_Annotation

Many-To-One Relationship: [annotation Equipment_Annotation](annotation.md#BKMK_Equipment_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Equipment_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Equipment_AsyncOperations"></a> Equipment_AsyncOperations

Many-To-One Relationship: [asyncoperation Equipment_AsyncOperations](asyncoperation.md#BKMK_Equipment_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Equipment_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Equipment_BulkDeleteFailures"></a> Equipment_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Equipment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Equipment_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Equipment_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_equipment_connections1"></a> equipment_connections1

Many-To-One Relationship: [connection equipment_connections1](connection.md#BKMK_equipment_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`equipment_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_equipment_connections2"></a> equipment_connections2

Many-To-One Relationship: [connection equipment_connections2](connection.md#BKMK_equipment_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`equipment_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_equipment_contacts"></a> equipment_contacts

Many-To-One Relationship: [contact equipment_contacts](contact.md#BKMK_equipment_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`preferredequipmentid`|
|ReferencedEntityNavigationPropertyName|`equipment_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Equipment_DuplicateBaseRecord"></a> Equipment_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord Equipment_DuplicateBaseRecord](duplicaterecord.md#BKMK_Equipment_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`Equipment_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Equipment_DuplicateMatchingRecord"></a> Equipment_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord Equipment_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Equipment_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`Equipment_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Equipment_Email_EmailSender"></a> Equipment_Email_EmailSender

Many-To-One Relationship: [email Equipment_Email_EmailSender](email.md#BKMK_Equipment_Email_EmailSender)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`emailsender`|
|ReferencedEntityNavigationPropertyName|`Equipment_Email_EmailSender`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_equipment_MailboxTrackingFolders"></a> equipment_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder equipment_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_equipment_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`equipment_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_equipment_principalobjectattributeaccess"></a> equipment_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess equipment_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_equipment_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`equipment_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Equipment_ProcessSessions"></a> Equipment_ProcessSessions

Many-To-One Relationship: [processsession Equipment_ProcessSessions](processsession.md#BKMK_Equipment_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Equipment_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_equipment_resources"></a> equipment_resources

Many-To-One Relationship: [resource equipment_resources](resource.md#BKMK_equipment_resources)

|Property|Value|
|---|---|
|ReferencingEntity|`resource`|
|ReferencingAttribute|`resourceid`|
|ReferencedEntityNavigationPropertyName|`equipment_resources`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Equipment_SyncErrors"></a> Equipment_SyncErrors

Many-To-One Relationship: [syncerror Equipment_SyncErrors](syncerror.md#BKMK_Equipment_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Equipment_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

