---
title: "Table Permission (adx_entitypermission) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Table Permission (adx_entitypermission) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Table Permission (adx_entitypermission) table/entity reference



## Messages

The following table lists the messages for the Table Permission (adx_entitypermission) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /adx_entitypermissions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_entitypermissions(*adx_entitypermissionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_entitypermissions(*adx_entitypermissionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_entitypermissions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /adx_entitypermissions(*adx_entitypermissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_entitypermissions(*adx_entitypermissionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_entitypermissions(*adx_entitypermissionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Table Permission (adx_entitypermission) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Table Permission (adx_entitypermission) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Table Permission** |
| **DisplayCollectionName** | **Table Permissions** |
| **SchemaName** | `adx_entitypermission` |
| **CollectionSchemaName** | `adx_entitypermissions` |
| **EntitySetName** | `adx_entitypermissions`|
| **LogicalName** | `adx_entitypermission` |
| **LogicalCollectionName** | `adx_entitypermissions` |
| **PrimaryIdAttribute** | `adx_entitypermissionid` |
| **PrimaryNameAttribute** |`adx_entityname` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_accountrelationship](#BKMK_adx_accountrelationship)
- [adx_append](#BKMK_adx_append)
- [adx_appendto](#BKMK_adx_appendto)
- [adx_contactrelationship](#BKMK_adx_contactrelationship)
- [adx_create](#BKMK_adx_create)
- [adx_delete](#BKMK_adx_delete)
- [adx_entitylogicalname](#BKMK_adx_entitylogicalname)
- [adx_entityname](#BKMK_adx_entityname)
- [adx_entitypermissionId](#BKMK_adx_entitypermissionId)
- [adx_parententitypermission](#BKMK_adx_parententitypermission)
- [adx_parentrelationship](#BKMK_adx_parentrelationship)
- [adx_read](#BKMK_adx_read)
- [adx_scope](#BKMK_adx_scope)
- [adx_websiteid](#BKMK_adx_websiteid)
- [adx_write](#BKMK_adx_write)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_accountrelationship"></a> adx_accountrelationship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Account Relationship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_accountrelationship`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_adx_append"></a> adx_append

|Property|Value|
|---|---|
|Description|**Controls whether the user can attach another record to the specified record. The Append and Append To permissions work in combination.**|
|DisplayName|**Append**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_append`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitypermission_adx_append`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_appendto"></a> adx_appendto

|Property|Value|
|---|---|
|Description|**Controls whether the user can append the specified record to another record. The Append and Append To permissions work in combination.**|
|DisplayName|**Append To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_appendto`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitypermission_adx_appendto`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_contactrelationship"></a> adx_contactrelationship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact Relationship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_contactrelationship`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_adx_create"></a> adx_create

|Property|Value|
|---|---|
|Description|**The Create privilege controls whether you can create a record.**|
|DisplayName|**Create**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_create`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitypermission_adx_create`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_delete"></a> adx_delete

|Property|Value|
|---|---|
|Description|**Controls whether the user can delete a record.**|
|DisplayName|**Delete**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_delete`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitypermission_adx_delete`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_entitylogicalname"></a> adx_entitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Table Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entitylogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_adx_entityname"></a> adx_entityname

|Property|Value|
|---|---|
|Description|**Type the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entityname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_adx_entitypermissionId"></a> adx_entitypermissionId

|Property|Value|
|---|---|
|Description|**Shows the entity instance.**|
|DisplayName|**Table Permission**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_entitypermissionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_parententitypermission"></a> adx_parententitypermission

|Property|Value|
|---|---|
|Description||
|DisplayName|**Parent Table Permission**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_parententitypermission`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_entitypermission|

### <a name="BKMK_adx_parentrelationship"></a> adx_parentrelationship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Parent Relationship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_parentrelationship`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_adx_read"></a> adx_read

|Property|Value|
|---|---|
|Description|**Controls whether the user can read a record.**|
|DisplayName|**Read**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_read`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitypermission_adx_read`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_scope"></a> adx_scope

|Property|Value|
|---|---|
|Description||
|DisplayName|**Access Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_scope`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_entitypermission_adx_scope`|

#### adx_scope Choices/Options

|Value|Label|
|---|---|
|756150000|**Global**|
|756150001|**Contact**|
|756150002|**Account**|
|756150003|**Parent**|
|756150004|**Self**|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Website associated with Entity Permission**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_website|

### <a name="BKMK_adx_write"></a> adx_write

|Property|Value|
|---|---|
|Description|**Controls whether the user can update a record.**|
|DisplayName|**Write**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_write`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_entitypermission_adx_write`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|Description|**Shows the date and time that the record was migrated.**|
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
|Description|**Status of the Table Permission**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_entitypermission_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the table permission's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_entitypermission_statuscode`|

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
|Description|**Shows who created the record.**|
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
|Description|**Shows the date and time when the record was created.**|
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
|Description|**Shows who last updated the record.**|
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
|Description|**Shows the date and time when the record was modified.**|
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
|DisplayName|**Shows the organization.**|
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

- [adx_entitypermission_parententitypermission](#BKMK_adx_entitypermission_parententitypermission-many-to-one)
- [adx_website_adx_entitypermission](#BKMK_adx_website_adx_entitypermission)
- [lk_adx_entitypermission_createdby](#BKMK_lk_adx_entitypermission_createdby)
- [lk_adx_entitypermission_createdonbehalfby](#BKMK_lk_adx_entitypermission_createdonbehalfby)
- [lk_adx_entitypermission_modifiedby](#BKMK_lk_adx_entitypermission_modifiedby)
- [lk_adx_entitypermission_modifiedonbehalfby](#BKMK_lk_adx_entitypermission_modifiedonbehalfby)
- [organization_adx_entitypermission](#BKMK_organization_adx_entitypermission)

### <a name="BKMK_adx_entitypermission_parententitypermission-many-to-one"></a> adx_entitypermission_parententitypermission

One-To-Many Relationship: [adx_entitypermission adx_entitypermission_parententitypermission](#BKMK_adx_entitypermission_parententitypermission-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_entitypermission`|
|ReferencedAttribute|`adx_entitypermissionid`|
|ReferencingAttribute|`adx_parententitypermission`|
|ReferencingEntityNavigationPropertyName|`adx_parententitypermission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_website_adx_entitypermission"></a> adx_website_adx_entitypermission

One-To-Many Relationship: [adx_website adx_website_adx_entitypermission](adx_website.md#BKMK_adx_website_adx_entitypermission)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencingEntityNavigationPropertyName|`adx_websiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entitypermission_createdby"></a> lk_adx_entitypermission_createdby

One-To-Many Relationship: [systemuser lk_adx_entitypermission_createdby](systemuser.md#BKMK_lk_adx_entitypermission_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entitypermission_createdonbehalfby"></a> lk_adx_entitypermission_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_entitypermission_createdonbehalfby](systemuser.md#BKMK_lk_adx_entitypermission_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entitypermission_modifiedby"></a> lk_adx_entitypermission_modifiedby

One-To-Many Relationship: [systemuser lk_adx_entitypermission_modifiedby](systemuser.md#BKMK_lk_adx_entitypermission_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_entitypermission_modifiedonbehalfby"></a> lk_adx_entitypermission_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_entitypermission_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_entitypermission_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_adx_entitypermission"></a> organization_adx_entitypermission

One-To-Many Relationship: [organization organization_adx_entitypermission](organization.md#BKMK_organization_adx_entitypermission)

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

- [adx_entitypermission_Annotations](#BKMK_adx_entitypermission_Annotations)
- [adx_entitypermission_AsyncOperations](#BKMK_adx_entitypermission_AsyncOperations)
- [adx_entitypermission_BulkDeleteFailures](#BKMK_adx_entitypermission_BulkDeleteFailures)
- [adx_entitypermission_MailboxTrackingFolders](#BKMK_adx_entitypermission_MailboxTrackingFolders)
- [adx_entitypermission_parententitypermission](#BKMK_adx_entitypermission_parententitypermission-one-to-many)
- [adx_entitypermission_PrincipalObjectAttributeAccesses](#BKMK_adx_entitypermission_PrincipalObjectAttributeAccesses)
- [adx_entitypermission_ProcessSession](#BKMK_adx_entitypermission_ProcessSession)
- [adx_entitypermission_SyncErrors](#BKMK_adx_entitypermission_SyncErrors)

### <a name="BKMK_adx_entitypermission_Annotations"></a> adx_entitypermission_Annotations

Many-To-One Relationship: [annotation adx_entitypermission_Annotations](annotation.md#BKMK_adx_entitypermission_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitypermission_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitypermission_AsyncOperations"></a> adx_entitypermission_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_entitypermission_AsyncOperations](asyncoperation.md#BKMK_adx_entitypermission_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitypermission_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitypermission_BulkDeleteFailures"></a> adx_entitypermission_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_entitypermission_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_entitypermission_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitypermission_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitypermission_MailboxTrackingFolders"></a> adx_entitypermission_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_entitypermission_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_entitypermission_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitypermission_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitypermission_parententitypermission-one-to-many"></a> adx_entitypermission_parententitypermission

Many-To-One Relationship: [adx_entitypermission adx_entitypermission_parententitypermission](#BKMK_adx_entitypermission_parententitypermission-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entitypermission`|
|ReferencingAttribute|`adx_parententitypermission`|
|ReferencedEntityNavigationPropertyName|`adx_entitypermission_parententitypermission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitypermission_PrincipalObjectAttributeAccesses"></a> adx_entitypermission_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_entitypermission_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_entitypermission_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitypermission_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitypermission_ProcessSession"></a> adx_entitypermission_ProcessSession

Many-To-One Relationship: [processsession adx_entitypermission_ProcessSession](processsession.md#BKMK_adx_entitypermission_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitypermission_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitypermission_SyncErrors"></a> adx_entitypermission_SyncErrors

Many-To-One Relationship: [syncerror adx_entitypermission_SyncErrors](syncerror.md#BKMK_adx_entitypermission_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_entitypermission_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_adx_entitypermission_webrole"></a> adx_entitypermission_webrole

See [adx_webrole adx_entitypermission_webrole Many-To-Many Relationship](adx_webrole.md#BKMK_adx_entitypermission_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_entitypermission_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_entitypermission_webrole`|
|IntersectAttribute|`adx_entitypermissionid`|
|NavigationPropertyName|`adx_entitypermission_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

