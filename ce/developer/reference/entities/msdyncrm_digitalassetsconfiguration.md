---
title: "Digital assets configuration (msdyncrm_digitalassetsconfiguration) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Digital assets configuration (msdyncrm_digitalassetsconfiguration) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Digital assets configuration (msdyncrm_digitalassetsconfiguration) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Digital assets configuration (msdyncrm_digitalassetsconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyncrm_digitalassetsconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_digitalassetsconfigurations(*msdyncrm_digitalassetsconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_digitalassetsconfigurations(*msdyncrm_digitalassetsconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_digitalassetsconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_digitalassetsconfigurations(*msdyncrm_digitalassetsconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_digitalassetsconfigurations(*msdyncrm_digitalassetsconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_digitalassetsconfigurations(*msdyncrm_digitalassetsconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Digital assets configuration (msdyncrm_digitalassetsconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Digital assets configuration** |
| **DisplayCollectionName** | **Digital assets configurations** |
| **SchemaName** | `msdyncrm_digitalassetsconfiguration` |
| **CollectionSchemaName** | `msdyncrm_digitalassetsconfigurations` |
| **EntitySetName** | `msdyncrm_digitalassetsconfigurations`|
| **LogicalName** | `msdyncrm_digitalassetsconfiguration` |
| **LogicalCollectionName** | `msdyncrm_digitalassetsconfigurations` |
| **PrimaryIdAttribute** | `msdyncrm_digitalassetsconfigurationid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_configcacheexpirationdate](#BKMK_msdyncrm_configcacheexpirationdate)
- [msdyncrm_ConfigCacheExpirationPeriodInMs](#BKMK_msdyncrm_ConfigCacheExpirationPeriodInMs)
- [msdyncrm_default](#BKMK_msdyncrm_default)
- [msdyncrm_digitalassetsconfigurationId](#BKMK_msdyncrm_digitalassetsconfigurationId)
- [msdyncrm_DiscoveryEndpointUrl](#BKMK_msdyncrm_DiscoveryEndpointUrl)
- [msdyncrm_httptimeout](#BKMK_msdyncrm_httptimeout)
- [msdyncrm_IsCxpFlowEnabled](#BKMK_msdyncrm_IsCxpFlowEnabled)
- [msdyncrm_IsInstallComplete](#BKMK_msdyncrm_IsInstallComplete)
- [msdyncrm_librarystatus](#BKMK_msdyncrm_librarystatus)
- [msdyncrm_maxretryattempts](#BKMK_msdyncrm_maxretryattempts)
- [msdyncrm_migrationstatus](#BKMK_msdyncrm_migrationstatus)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_organization_config](#BKMK_msdyncrm_organization_config)
- [msdyncrm_tokenauthenticationresource](#BKMK_msdyncrm_tokenauthenticationresource)
- [msdyncrm_UseBasicAuth](#BKMK_msdyncrm_UseBasicAuth)
- [msdyncrm_usedlibrary](#BKMK_msdyncrm_usedlibrary)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_configcacheexpirationdate"></a> msdyncrm_configcacheexpirationdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Config cache expiration date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_configcacheexpirationdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_ConfigCacheExpirationPeriodInMs"></a> msdyncrm_ConfigCacheExpirationPeriodInMs

|Property|Value|
|---|---|
|Description||
|DisplayName|**Config cache expiration period (milliseconds)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_configcacheexpirationperiodinms`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_default"></a> msdyncrm_default

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_default`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_msdyncrm_default`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_digitalassetsconfigurationId"></a> msdyncrm_digitalassetsconfigurationId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Digital assets configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_digitalassetsconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_DiscoveryEndpointUrl"></a> msdyncrm_DiscoveryEndpointUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Digital assets service discovery endpoint URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_discoveryendpointurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_httptimeout"></a> msdyncrm_httptimeout

|Property|Value|
|---|---|
|Description||
|DisplayName|**HTTP timeout (milliseconds)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_httptimeout`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|120000|
|MinValue|0|

### <a name="BKMK_msdyncrm_IsCxpFlowEnabled"></a> msdyncrm_IsCxpFlowEnabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is new flow enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_iscxpflowenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_msdyncrm_iscxpflowenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_IsInstallComplete"></a> msdyncrm_IsInstallComplete

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is install complete**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_isinstallcomplete`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_msdyncrm_isinstallcomplete`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_librarystatus"></a> msdyncrm_librarystatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Library status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_librarystatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|270100000|
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_msdyncrm_librarystatus`|

#### msdyncrm_librarystatus Choices/Options

|Value|Label|
|---|---|
|270100000|**Unknown**|
|270100001|**Ready**|
|270100002|**Installing**|
|270100003|**Uninstalling**|
|270100004|**Failed**|

### <a name="BKMK_msdyncrm_maxretryattempts"></a> msdyncrm_maxretryattempts

|Property|Value|
|---|---|
|Description||
|DisplayName|**Maximum retry attempts**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_maxretryattempts`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|20|
|MinValue|0|

### <a name="BKMK_msdyncrm_migrationstatus"></a> msdyncrm_migrationstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Migration status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_migrationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|270100000|
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_msdyncrm_migrationstatus`|

#### msdyncrm_migrationstatus Choices/Options

|Value|Label|
|---|---|
|270100000|**Unknown**|
|270100001|**Completed**|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the digital assets configuration entity**|
|DisplayName|**Digital assets configuration**|
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

### <a name="BKMK_msdyncrm_organization_config"></a> msdyncrm_organization_config

|Property|Value|
|---|---|
|Description|**The configuration JSON**|
|DisplayName|**Organization config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_organization_config`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_tokenauthenticationresource"></a> msdyncrm_tokenauthenticationresource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Token authentication resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_tokenauthenticationresource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyncrm_UseBasicAuth"></a> msdyncrm_UseBasicAuth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Use basic authentication**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_usebasicauth`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_msdyncrm_usebasicauth`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_usedlibrary"></a> msdyncrm_usedlibrary

|Property|Value|
|---|---|
|Description||
|DisplayName|**Used library**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_usedlibrary`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|270100000|
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_msdyncrm_usedlibrary`|

#### msdyncrm_usedlibrary Choices/Options

|Value|Label|
|---|---|
|270100000|**Unknown**|
|270100001|**DigitalAssets**|
|270100002|**CMS**|

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
|Description|**Status of the digital assets configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Digital assets configuration status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_digitalassetsconfiguration_statuscode`|

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
|Description|**Unique ID of the organization**|
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

- [lk_msdyncrm_digitalassetsconfiguration_createdby](#BKMK_lk_msdyncrm_digitalassetsconfiguration_createdby)
- [lk_msdyncrm_digitalassetsconfiguration_createdonbehalfby](#BKMK_lk_msdyncrm_digitalassetsconfiguration_createdonbehalfby)
- [lk_msdyncrm_digitalassetsconfiguration_modifiedby](#BKMK_lk_msdyncrm_digitalassetsconfiguration_modifiedby)
- [lk_msdyncrm_digitalassetsconfiguration_modifiedonbehalfby](#BKMK_lk_msdyncrm_digitalassetsconfiguration_modifiedonbehalfby)
- [organization_msdyncrm_digitalassetsconfiguration](#BKMK_organization_msdyncrm_digitalassetsconfiguration)

### <a name="BKMK_lk_msdyncrm_digitalassetsconfiguration_createdby"></a> lk_msdyncrm_digitalassetsconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_digitalassetsconfiguration_createdby](systemuser.md#BKMK_lk_msdyncrm_digitalassetsconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_digitalassetsconfiguration_createdonbehalfby"></a> lk_msdyncrm_digitalassetsconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_digitalassetsconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_digitalassetsconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_digitalassetsconfiguration_modifiedby"></a> lk_msdyncrm_digitalassetsconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_digitalassetsconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyncrm_digitalassetsconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_digitalassetsconfiguration_modifiedonbehalfby"></a> lk_msdyncrm_digitalassetsconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_digitalassetsconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_digitalassetsconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyncrm_digitalassetsconfiguration"></a> organization_msdyncrm_digitalassetsconfiguration

One-To-Many Relationship: [organization organization_msdyncrm_digitalassetsconfiguration](organization.md#BKMK_organization_msdyncrm_digitalassetsconfiguration)

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

- [msdyncrm_digitalassetsconfiguration_AsyncOperations](#BKMK_msdyncrm_digitalassetsconfiguration_AsyncOperations)
- [msdyncrm_digitalassetsconfiguration_BulkDeleteFailures](#BKMK_msdyncrm_digitalassetsconfiguration_BulkDeleteFailures)
- [msdyncrm_digitalassetsconfiguration_DuplicateBaseRecord](#BKMK_msdyncrm_digitalassetsconfiguration_DuplicateBaseRecord)
- [msdyncrm_digitalassetsconfiguration_DuplicateMatchingRecord](#BKMK_msdyncrm_digitalassetsconfiguration_DuplicateMatchingRecord)
- [msdyncrm_digitalassetsconfiguration_MailboxTrackingFolders](#BKMK_msdyncrm_digitalassetsconfiguration_MailboxTrackingFolders)
- [msdyncrm_digitalassetsconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_digitalassetsconfiguration_PrincipalObjectAttributeAccesses)
- [msdyncrm_digitalassetsconfiguration_ProcessSession](#BKMK_msdyncrm_digitalassetsconfiguration_ProcessSession)
- [msdyncrm_digitalassetsconfiguration_SyncErrors](#BKMK_msdyncrm_digitalassetsconfiguration_SyncErrors)

### <a name="BKMK_msdyncrm_digitalassetsconfiguration_AsyncOperations"></a> msdyncrm_digitalassetsconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_digitalassetsconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_digitalassetsconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_digitalassetsconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_digitalassetsconfiguration_BulkDeleteFailures"></a> msdyncrm_digitalassetsconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_digitalassetsconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_digitalassetsconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_digitalassetsconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_digitalassetsconfiguration_DuplicateBaseRecord"></a> msdyncrm_digitalassetsconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_digitalassetsconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_digitalassetsconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_digitalassetsconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_digitalassetsconfiguration_DuplicateMatchingRecord"></a> msdyncrm_digitalassetsconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_digitalassetsconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_digitalassetsconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_digitalassetsconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_digitalassetsconfiguration_MailboxTrackingFolders"></a> msdyncrm_digitalassetsconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_digitalassetsconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_digitalassetsconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_digitalassetsconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_digitalassetsconfiguration_PrincipalObjectAttributeAccesses"></a> msdyncrm_digitalassetsconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_digitalassetsconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_digitalassetsconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_digitalassetsconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_digitalassetsconfiguration_ProcessSession"></a> msdyncrm_digitalassetsconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_digitalassetsconfiguration_ProcessSession](processsession.md#BKMK_msdyncrm_digitalassetsconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_digitalassetsconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_digitalassetsconfiguration_SyncErrors"></a> msdyncrm_digitalassetsconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_digitalassetsconfiguration_SyncErrors](syncerror.md#BKMK_msdyncrm_digitalassetsconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_digitalassetsconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

