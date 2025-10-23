---
title: "Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table/entity reference (Microsoft Dynamics 365)

Entity that holds the configuration data for a channel provider based on Channel Integration Framework v1.0

## Messages

The following table lists the messages for the Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ciproviders<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ciproviders(*msdyn_ciproviderid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ciproviders(*msdyn_ciproviderid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ciproviders<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ciproviders(*msdyn_ciproviderid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ciproviders(*msdyn_ciproviderid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ciproviders(*msdyn_ciproviderid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Channel Integration Framework v1.0 Provider** |
| **DisplayCollectionName** | **Channel Integration Framework v1.0 Providers** |
| **SchemaName** | `msdyn_ciprovider` |
| **CollectionSchemaName** | `msdyn_ciproviders` |
| **EntitySetName** | `msdyn_ciproviders`|
| **LogicalName** | `msdyn_ciprovider` |
| **LogicalCollectionName** | `msdyn_ciproviders` |
| **PrimaryIdAttribute** | `msdyn_ciproviderid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AppSelector](#BKMK_msdyn_AppSelector)
- [msdyn_channelprovidericon](#BKMK_msdyn_channelprovidericon)
- [msdyn_cifsolversion](#BKMK_msdyn_cifsolversion)
- [msdyn_ciproviderapiversion](#BKMK_msdyn_ciproviderapiversion)
- [msdyn_ciproviderId](#BKMK_msdyn_ciproviderId)
- [msdyn_ClickToAct](#BKMK_msdyn_ClickToAct)
- [msdyn_customparams](#BKMK_msdyn_customparams)
- [msdyn_EnableAnalytics](#BKMK_msdyn_EnableAnalytics)
- [msdyn_Label](#BKMK_msdyn_Label)
- [msdyn_LandingUrl](#BKMK_msdyn_LandingUrl)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_RoleSelector](#BKMK_msdyn_RoleSelector)
- [msdyn_sandboxconfiguration](#BKMK_msdyn_sandboxconfiguration)
- [msdyn_SortOrder](#BKMK_msdyn_SortOrder)
- [msdyn_trusteddomain](#BKMK_msdyn_trusteddomain)
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

### <a name="BKMK_msdyn_AppSelector"></a> msdyn_AppSelector

|Property|Value|
|---|---|
|Description|**Select Unified Interface Apps for the Channel**|
|DisplayName|**App Selector**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_appselector`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_channelprovidericon"></a> msdyn_channelprovidericon

|Property|Value|
|---|---|
|Description|**Customize channel provider icon**|
|DisplayName|**Channel Provider Icon**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelprovidericon`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|webresource|

### <a name="BKMK_msdyn_cifsolversion"></a> msdyn_cifsolversion

|Property|Value|
|---|---|
|Description|**Version of the CIF Solution**|
|DisplayName|**CIF Sol Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cifsolversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ciproviderapiversion"></a> msdyn_ciproviderapiversion

|Property|Value|
|---|---|
|Description|**API Version**|
|DisplayName|**API Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ciproviderapiversion`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_ciproviderapiversion`|

#### msdyn_ciproviderapiversion Choices/Options

|Value|Label|
|---|---|
|0|**1.0**|
|1|**2.0**|

### <a name="BKMK_msdyn_ciproviderId"></a> msdyn_ciproviderId

|Property|Value|
|---|---|
|Description|**Unique identifier for CIProvider records**|
|DisplayName|**CIProviderId**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ciproviderid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ClickToAct"></a> msdyn_ClickToAct

|Property|Value|
|---|---|
|Description|**Enable Outbound Communication**|
|DisplayName|**Enable Outbound Communication**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_clicktoact`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ciprovider_msdyn_clicktoact`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_customparams"></a> msdyn_customparams

|Property|Value|
|---|---|
|Description|**Custom Parameters for the Widget to load**|
|DisplayName|**Custom Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customparams`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_EnableAnalytics"></a> msdyn_EnableAnalytics

|Property|Value|
|---|---|
|Description|**Enable CIF Analytics for the current provider**|
|DisplayName|**Enable Analytics**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableanalytics`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ciprovider_msdyn_enableanalytics`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Label"></a> msdyn_Label

|Property|Value|
|---|---|
|Description|**The label is displayed as the title on the widget**|
|DisplayName|**Label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_label`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_LandingUrl"></a> msdyn_LandingUrl

|Property|Value|
|---|---|
|Description|**URL for the Channel provider**|
|DisplayName|**Channel URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_landingurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Name of the Channel provider**|
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

### <a name="BKMK_msdyn_RoleSelector"></a> msdyn_RoleSelector

|Property|Value|
|---|---|
|Description|**Select the Roles for the Channel**|
|DisplayName|**Role Selector**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_roleselector`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_sandboxconfiguration"></a> msdyn_sandboxconfiguration

|Property|Value|
|---|---|
|Description|**Custom sandbox properties for the widget**|
|DisplayName|**Sandbox Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sandboxconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_SortOrder"></a> msdyn_SortOrder

|Property|Value|
|---|---|
|Description|**Select Channel Order as 0 for this Channel to take precedence over others.**|
|DisplayName|**Channel Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sortorder`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|1000|
|MinValue|0|

### <a name="BKMK_msdyn_trusteddomain"></a> msdyn_trusteddomain

|Property|Value|
|---|---|
|Description|**Domain to be added to inclusion list**|
|DisplayName|**Trusted Domain**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_trusteddomain`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
|Description|**Status of the Channel Provider**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ciprovider_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Channel Provider**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ciprovider_statuscode`|

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

- [lk_msdyn_ciprovider_createdby](#BKMK_lk_msdyn_ciprovider_createdby)
- [lk_msdyn_ciprovider_createdonbehalfby](#BKMK_lk_msdyn_ciprovider_createdonbehalfby)
- [lk_msdyn_ciprovider_modifiedby](#BKMK_lk_msdyn_ciprovider_modifiedby)
- [lk_msdyn_ciprovider_modifiedonbehalfby](#BKMK_lk_msdyn_ciprovider_modifiedonbehalfby)
- [msdyn_webresource_ciprovider_channelprovidericon](#BKMK_msdyn_webresource_ciprovider_channelprovidericon)
- [organization_msdyn_ciprovider](#BKMK_organization_msdyn_ciprovider)

### <a name="BKMK_lk_msdyn_ciprovider_createdby"></a> lk_msdyn_ciprovider_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ciprovider_createdby](systemuser.md#BKMK_lk_msdyn_ciprovider_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ciprovider_createdonbehalfby"></a> lk_msdyn_ciprovider_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ciprovider_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ciprovider_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ciprovider_modifiedby"></a> lk_msdyn_ciprovider_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ciprovider_modifiedby](systemuser.md#BKMK_lk_msdyn_ciprovider_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ciprovider_modifiedonbehalfby"></a> lk_msdyn_ciprovider_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ciprovider_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ciprovider_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webresource_ciprovider_channelprovidericon"></a> msdyn_webresource_ciprovider_channelprovidericon

One-To-Many Relationship: [webresource msdyn_webresource_ciprovider_channelprovidericon](webresource.md#BKMK_msdyn_webresource_ciprovider_channelprovidericon)

|Property|Value|
|---|---|
|ReferencedEntity|`webresource`|
|ReferencedAttribute|`webresourceid`|
|ReferencingAttribute|`msdyn_channelprovidericon`|
|ReferencingEntityNavigationPropertyName|`msdyn_channelprovidericon`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_ciprovider"></a> organization_msdyn_ciprovider

One-To-Many Relationship: [organization organization_msdyn_ciprovider](organization.md#BKMK_organization_msdyn_ciprovider)

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

- [msdyn_ciprovider_AsyncOperations](#BKMK_msdyn_ciprovider_AsyncOperations)
- [msdyn_ciprovider_BulkDeleteFailures](#BKMK_msdyn_ciprovider_BulkDeleteFailures)
- [msdyn_ciprovider_DuplicateBaseRecord](#BKMK_msdyn_ciprovider_DuplicateBaseRecord)
- [msdyn_ciprovider_DuplicateMatchingRecord](#BKMK_msdyn_ciprovider_DuplicateMatchingRecord)
- [msdyn_ciprovider_MailboxTrackingFolders](#BKMK_msdyn_ciprovider_MailboxTrackingFolders)
- [msdyn_ciprovider_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ciprovider_PrincipalObjectAttributeAccesses)
- [msdyn_ciprovider_ProcessSession](#BKMK_msdyn_ciprovider_ProcessSession)
- [msdyn_ciprovider_SyncErrors](#BKMK_msdyn_ciprovider_SyncErrors)

### <a name="BKMK_msdyn_ciprovider_AsyncOperations"></a> msdyn_ciprovider_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ciprovider_AsyncOperations](asyncoperation.md#BKMK_msdyn_ciprovider_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ciprovider_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ciprovider_BulkDeleteFailures"></a> msdyn_ciprovider_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ciprovider_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ciprovider_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ciprovider_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ciprovider_DuplicateBaseRecord"></a> msdyn_ciprovider_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ciprovider_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ciprovider_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ciprovider_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ciprovider_DuplicateMatchingRecord"></a> msdyn_ciprovider_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ciprovider_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ciprovider_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ciprovider_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ciprovider_MailboxTrackingFolders"></a> msdyn_ciprovider_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ciprovider_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ciprovider_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ciprovider_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ciprovider_PrincipalObjectAttributeAccesses"></a> msdyn_ciprovider_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ciprovider_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ciprovider_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ciprovider_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ciprovider_ProcessSession"></a> msdyn_ciprovider_ProcessSession

Many-To-One Relationship: [processsession msdyn_ciprovider_ProcessSession](processsession.md#BKMK_msdyn_ciprovider_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ciprovider_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ciprovider_SyncErrors"></a> msdyn_ciprovider_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ciprovider_SyncErrors](syncerror.md#BKMK_msdyn_ciprovider_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ciprovider_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_ciprovider_systemuser_membership"></a> msdyn_ciprovider_systemuser_membership

See [systemuser msdyn_ciprovider_systemuser_membership Many-To-Many Relationship](systemuser.md#BKMK_msdyn_ciprovider_systemuser_membership)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_ciprovider_systemuser`|
|IsCustomizable|True|
|SchemaName|`msdyn_ciprovider_systemuser_membership`|
|IntersectAttribute|`msdyn_ciproviderid`|
|NavigationPropertyName|`msdyn_ciprovider_systemuser_membership`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

