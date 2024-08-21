---
title: "msdyn_vivaorgextensioncred table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_vivaorgextensioncred table/entity with Microsoft Dynamics 365."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_vivaorgextensioncred table/entity reference

Org level extension credential for Viva apps

## Messages

The following table lists the messages for the msdyn_vivaorgextensioncred table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_vivaorgextensioncreds<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_vivaorgextensioncreds(*msdyn_vivaorgextensioncredid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_vivaorgextensioncreds(*msdyn_vivaorgextensioncredid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_vivaorgextensioncreds<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyn_vivaorgextensioncreds(*msdyn_vivaorgextensioncredid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_vivaorgextensioncreds(*msdyn_vivaorgextensioncredid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_vivaorgextensioncreds(*msdyn_vivaorgextensioncredid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the msdyn_vivaorgextensioncred table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_vivaorgextensioncred table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_vivaorgextensioncred** |
| **DisplayCollectionName** | **msdyn_vivaorgextensioncred** |
| **SchemaName** | `msdyn_vivaorgextensioncred` |
| **CollectionSchemaName** | `msdyn_vivaorgextensioncreds` |
| **EntitySetName** | `msdyn_vivaorgextensioncreds`|
| **LogicalName** | `msdyn_vivaorgextensioncred` |
| **LogicalCollectionName** | `msdyn_vivaorgextensioncreds` |
| **PrimaryIdAttribute** | `msdyn_vivaorgextensioncredid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_extensionclientid](#BKMK_msdyn_extensionclientid)
- [msdyn_extensionname](#BKMK_msdyn_extensionname)
- [msdyn_extensionproperties](#BKMK_msdyn_extensionproperties)
- [msdyn_extensionsecret](#BKMK_msdyn_extensionsecret)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_orgid](#BKMK_msdyn_orgid)
- [msdyn_producttype](#BKMK_msdyn_producttype)
- [msdyn_settingscreatedby](#BKMK_msdyn_settingscreatedby)
- [msdyn_settingsmodifiedby](#BKMK_msdyn_settingsmodifiedby)
- [msdyn_vivaorgextensioncredId](#BKMK_msdyn_vivaorgextensioncredId)
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

### <a name="BKMK_msdyn_extensionclientid"></a> msdyn_extensionclientid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Extension Client ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_extensionclientid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_extensionname"></a> msdyn_extensionname

|Property|Value|
|---|---|
|Description|**Identifies which team | extension these credential is for**|
|DisplayName|**Extension Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_extensionname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_extensionproperties"></a> msdyn_extensionproperties

|Property|Value|
|---|---|
|Description|**JSON object string of all the extension additional properties, if needed**|
|DisplayName|**Org Extension Additional Properties**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_extensionproperties`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048575|

### <a name="BKMK_msdyn_extensionsecret"></a> msdyn_extensionsecret

|Property|Value|
|---|---|
|Description||
|DisplayName|**Extension Secret**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_extensionsecret`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_orgid"></a> msdyn_orgid

|Property|Value|
|---|---|
|Description|**Identifies which org this org setting is associated with**|
|DisplayName|**Org id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_orgid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_producttype"></a> msdyn_producttype

|Property|Value|
|---|---|
|Description|**Identifier to track the association of this record with a Copilot product type**|
|DisplayName|**Product Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_producttype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|10000|
|GlobalChoiceName|`msdyn_vivacopilottype`|

#### msdyn_producttype Choices/Options

|Value|Label|
|---|---|
|10000|**Copilot for Sales**|
|10001|**Copilot for Service**|
|11000|**Shared**|

### <a name="BKMK_msdyn_settingscreatedby"></a> msdyn_settingscreatedby

|Property|Value|
|---|---|
|Description|**Track who created setting**|
|DisplayName|**Settings created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_settingscreatedby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_settingsmodifiedby"></a> msdyn_settingsmodifiedby

|Property|Value|
|---|---|
|Description|**Track who modified setting last**|
|DisplayName|**Settings modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_settingsmodifiedby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_vivaorgextensioncredId"></a> msdyn_vivaorgextensioncredId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Viva Org Extension Credential ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_vivaorgextensioncredid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the msdyn_vivaorgextensioncred**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_vivaorgextensioncred_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdyn_vivaorgextensioncred**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_vivaorgextensioncred_statuscode`|

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

- [lk_msdyn_vivaorgextensioncred_createdby](#BKMK_lk_msdyn_vivaorgextensioncred_createdby)
- [lk_msdyn_vivaorgextensioncred_createdonbehalfby](#BKMK_lk_msdyn_vivaorgextensioncred_createdonbehalfby)
- [lk_msdyn_vivaorgextensioncred_modifiedby](#BKMK_lk_msdyn_vivaorgextensioncred_modifiedby)
- [lk_msdyn_vivaorgextensioncred_modifiedonbehalfby](#BKMK_lk_msdyn_vivaorgextensioncred_modifiedonbehalfby)
- [organization_msdyn_vivaorgextensioncred](#BKMK_organization_msdyn_vivaorgextensioncred)

### <a name="BKMK_lk_msdyn_vivaorgextensioncred_createdby"></a> lk_msdyn_vivaorgextensioncred_createdby

One-To-Many Relationship: [systemuser lk_msdyn_vivaorgextensioncred_createdby](systemuser.md#BKMK_lk_msdyn_vivaorgextensioncred_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_vivaorgextensioncred_createdonbehalfby"></a> lk_msdyn_vivaorgextensioncred_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_vivaorgextensioncred_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_vivaorgextensioncred_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_vivaorgextensioncred_modifiedby"></a> lk_msdyn_vivaorgextensioncred_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_vivaorgextensioncred_modifiedby](systemuser.md#BKMK_lk_msdyn_vivaorgextensioncred_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_vivaorgextensioncred_modifiedonbehalfby"></a> lk_msdyn_vivaorgextensioncred_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_vivaorgextensioncred_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_vivaorgextensioncred_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_vivaorgextensioncred"></a> organization_msdyn_vivaorgextensioncred

One-To-Many Relationship: [organization organization_msdyn_vivaorgextensioncred](organization.md#BKMK_organization_msdyn_vivaorgextensioncred)

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

- [msdyn_vivaorgextensioncred_AsyncOperations](#BKMK_msdyn_vivaorgextensioncred_AsyncOperations)
- [msdyn_vivaorgextensioncred_BulkDeleteFailures](#BKMK_msdyn_vivaorgextensioncred_BulkDeleteFailures)
- [msdyn_vivaorgextensioncred_DuplicateBaseRecord](#BKMK_msdyn_vivaorgextensioncred_DuplicateBaseRecord)
- [msdyn_vivaorgextensioncred_DuplicateMatchingRecord](#BKMK_msdyn_vivaorgextensioncred_DuplicateMatchingRecord)
- [msdyn_vivaorgextensioncred_MailboxTrackingFolders](#BKMK_msdyn_vivaorgextensioncred_MailboxTrackingFolders)
- [msdyn_vivaorgextensioncred_PrincipalObjectAttributeAccesses](#BKMK_msdyn_vivaorgextensioncred_PrincipalObjectAttributeAccesses)
- [msdyn_vivaorgextensioncred_ProcessSession](#BKMK_msdyn_vivaorgextensioncred_ProcessSession)
- [msdyn_vivaorgextensioncred_SyncErrors](#BKMK_msdyn_vivaorgextensioncred_SyncErrors)

### <a name="BKMK_msdyn_vivaorgextensioncred_AsyncOperations"></a> msdyn_vivaorgextensioncred_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_vivaorgextensioncred_AsyncOperations](asyncoperation.md#BKMK_msdyn_vivaorgextensioncred_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_vivaorgextensioncred_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_vivaorgextensioncred_BulkDeleteFailures"></a> msdyn_vivaorgextensioncred_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_vivaorgextensioncred_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_vivaorgextensioncred_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_vivaorgextensioncred_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_vivaorgextensioncred_DuplicateBaseRecord"></a> msdyn_vivaorgextensioncred_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_vivaorgextensioncred_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_vivaorgextensioncred_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_vivaorgextensioncred_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_vivaorgextensioncred_DuplicateMatchingRecord"></a> msdyn_vivaorgextensioncred_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_vivaorgextensioncred_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_vivaorgextensioncred_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_vivaorgextensioncred_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_vivaorgextensioncred_MailboxTrackingFolders"></a> msdyn_vivaorgextensioncred_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_vivaorgextensioncred_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_vivaorgextensioncred_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_vivaorgextensioncred_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_vivaorgextensioncred_PrincipalObjectAttributeAccesses"></a> msdyn_vivaorgextensioncred_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_vivaorgextensioncred_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_vivaorgextensioncred_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_vivaorgextensioncred_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_vivaorgextensioncred_ProcessSession"></a> msdyn_vivaorgextensioncred_ProcessSession

Many-To-One Relationship: [processsession msdyn_vivaorgextensioncred_ProcessSession](processsession.md#BKMK_msdyn_vivaorgextensioncred_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_vivaorgextensioncred_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_vivaorgextensioncred_SyncErrors"></a> msdyn_vivaorgextensioncred_SyncErrors

Many-To-One Relationship: [syncerror msdyn_vivaorgextensioncred_SyncErrors](syncerror.md#BKMK_msdyn_vivaorgextensioncred_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_vivaorgextensioncred_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

