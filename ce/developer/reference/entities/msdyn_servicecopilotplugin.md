---
title: "Service Copilot Plugin (msdyn_servicecopilotplugin) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Service Copilot Plugin (msdyn_servicecopilotplugin) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Service Copilot Plugin (msdyn_servicecopilotplugin) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Service Copilot Plugin (msdyn_servicecopilotplugin) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_servicecopilotplugins<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_servicecopilotplugins(*msdyn_servicecopilotpluginid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_servicecopilotplugins(*msdyn_servicecopilotpluginid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_servicecopilotplugins<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_servicecopilotplugins(*msdyn_servicecopilotpluginid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_servicecopilotplugins(*msdyn_servicecopilotpluginid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_servicecopilotplugins(*msdyn_servicecopilotpluginid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Service Copilot Plugin (msdyn_servicecopilotplugin) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Service Copilot Plugin** |
| **DisplayCollectionName** | **Service Copilot Plugins** |
| **SchemaName** | `msdyn_servicecopilotplugin` |
| **CollectionSchemaName** | `msdyn_servicecopilotplugins` |
| **EntitySetName** | `msdyn_servicecopilotplugins`|
| **LogicalName** | `msdyn_servicecopilotplugin` |
| **LogicalCollectionName** | `msdyn_servicecopilotplugins` |
| **PrimaryIdAttribute** | `msdyn_servicecopilotpluginid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [LastPublishSuccessOn](#BKMK_LastPublishSuccessOn)
- [msdyn_aipluginid](#BKMK_msdyn_aipluginid)
- [msdyn_analyticsenabled](#BKMK_msdyn_analyticsenabled)
- [msdyn_authmode](#BKMK_msdyn_authmode)
- [msdyn_botcomponentid](#BKMK_msdyn_botcomponentid)
- [msdyn_connectionidpendingpublish](#BKMK_msdyn_connectionidpendingpublish)
- [msdyn_customconnectorcontext](#BKMK_msdyn_customconnectorcontext)
- [msdyn_ispublishpending](#BKMK_msdyn_ispublishpending)
- [msdyn_lastbappluginsynctime](#BKMK_msdyn_lastbappluginsynctime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_needsrolecheck](#BKMK_msdyn_needsrolecheck)
- [msdyn_parameterconfiguration](#BKMK_msdyn_parameterconfiguration)
- [msdyn_plugindescription](#BKMK_msdyn_plugindescription)
- [msdyn_pluginname](#BKMK_msdyn_pluginname)
- [msdyn_plugintype](#BKMK_msdyn_plugintype)
- [msdyn_pluginuniquename](#BKMK_msdyn_pluginuniquename)
- [msdyn_servicecopilotpluginId](#BKMK_msdyn_servicecopilotpluginId)
- [msdyn_skipgptresponse](#BKMK_msdyn_skipgptresponse)
- [msdyn_status](#BKMK_msdyn_status)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [PublishInitiatedOn](#BKMK_PublishInitiatedOn)
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

### <a name="BKMK_LastPublishSuccessOn"></a> LastPublishSuccessOn

|Property|Value|
|---|---|
|Description|**Last Publish Success Time**|
|DisplayName|**Last Publish Success Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastpublishsuccesson`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_aipluginid"></a> msdyn_aipluginid

|Property|Value|
|---|---|
|Description|**AI Plugin Id**|
|DisplayName|**AI Plugin Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aipluginid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|aiplugin|

### <a name="BKMK_msdyn_analyticsenabled"></a> msdyn_analyticsenabled

|Property|Value|
|---|---|
|Description|**Interaction For Record**|
|DisplayName|**Interaction For Record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_analyticsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_servicecopilotplugin_msdyn_analyticsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_authmode"></a> msdyn_authmode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plugin auth mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_authmode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_servicecopilotplugin_msdyn_authmode`|

#### msdyn_authmode Choices/Options

|Value|Label|
|---|---|
|0|**Invoker**|
|1|**Maker**|

### <a name="BKMK_msdyn_botcomponentid"></a> msdyn_botcomponentid

|Property|Value|
|---|---|
|Description|**Bot component id**|
|DisplayName|**Bot component id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_botcomponentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|botcomponent|

### <a name="BKMK_msdyn_connectionidpendingpublish"></a> msdyn_connectionidpendingpublish

|Property|Value|
|---|---|
|Description|**Is Connection Id Publish Pending**|
|DisplayName|**Is Connection Id Publish Pending**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_connectionidpendingpublish`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_servicecopilotplugin_msdyn_connectionidpendingpublish`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_customconnectorcontext"></a> msdyn_customconnectorcontext

|Property|Value|
|---|---|
|Description|**Custom connector context**|
|DisplayName|**Custom connector context**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customconnectorcontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_ispublishpending"></a> msdyn_ispublishpending

|Property|Value|
|---|---|
|Description|**Is Publish Pending**|
|DisplayName|**Is Publish Pending**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ispublishpending`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_servicecopilotplugin_msdyn_ispublishpending`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_lastbappluginsynctime"></a> msdyn_lastbappluginsynctime

|Property|Value|
|---|---|
|Description|**Last Plugin Metadata Sync Time**|
|DisplayName|**Last Plugin Metadata Sync Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastbappluginsynctime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_needsrolecheck"></a> msdyn_needsrolecheck

|Property|Value|
|---|---|
|Description|**Needs Role check**|
|DisplayName|**Needs Role check**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_needsrolecheck`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_servicecopilotplugin_msdyn_needsrolecheck`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_parameterconfiguration"></a> msdyn_parameterconfiguration

|Property|Value|
|---|---|
|Description|**Parameter Configuration**|
|DisplayName|**Parameter Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parameterconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_plugindescription"></a> msdyn_plugindescription

|Property|Value|
|---|---|
|Description|**Plugin Description**|
|DisplayName|**Plugin Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_plugindescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_pluginname"></a> msdyn_pluginname

|Property|Value|
|---|---|
|Description|**Plugin Name**|
|DisplayName|**Plugin Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pluginname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_plugintype"></a> msdyn_plugintype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plugin type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_plugintype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_servicecopilotplugin_msdyn_plugintype`|

#### msdyn_plugintype Choices/Options

|Value|Label|
|---|---|
|0|**Dataverse**|
|1|**CustomConnector**|
|2|**Connector**|

### <a name="BKMK_msdyn_pluginuniquename"></a> msdyn_pluginuniquename

|Property|Value|
|---|---|
|Description|**Plugin Unique Name**|
|DisplayName|**Plugin Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pluginuniquename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_servicecopilotpluginId"></a> msdyn_servicecopilotpluginId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Service Copilot Plugin**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_servicecopilotpluginid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_skipgptresponse"></a> msdyn_skipgptresponse

|Property|Value|
|---|---|
|Description|**Skip GPT response for plugin**|
|DisplayName|**Skip GPT Response**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_skipgptresponse`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_servicecopilotplugin_msdyn_skipgptresponse`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_status"></a> msdyn_status

|Property|Value|
|---|---|
|Description|**Enabled Status**|
|DisplayName|**Enabled Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_servicecopilotplugin_msdyn_status`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_PublishInitiatedOn"></a> PublishInitiatedOn

|Property|Value|
|---|---|
|Description|**Publish Initiated Time**|
|DisplayName|**Publish Initiated Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_publishinitiatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Service Copilot Plugin**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_servicecopilotplugin_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Service Copilot Plugin**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_servicecopilotplugin_statuscode`|

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

- [lk_msdyn_servicecopilotplugin_createdby](#BKMK_lk_msdyn_servicecopilotplugin_createdby)
- [lk_msdyn_servicecopilotplugin_createdonbehalfby](#BKMK_lk_msdyn_servicecopilotplugin_createdonbehalfby)
- [lk_msdyn_servicecopilotplugin_modifiedby](#BKMK_lk_msdyn_servicecopilotplugin_modifiedby)
- [lk_msdyn_servicecopilotplugin_modifiedonbehalfby](#BKMK_lk_msdyn_servicecopilotplugin_modifiedonbehalfby)
- [msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid](#BKMK_msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid)
- [msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid](#BKMK_msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid)
- [organization_msdyn_servicecopilotplugin](#BKMK_organization_msdyn_servicecopilotplugin)

### <a name="BKMK_lk_msdyn_servicecopilotplugin_createdby"></a> lk_msdyn_servicecopilotplugin_createdby

One-To-Many Relationship: [systemuser lk_msdyn_servicecopilotplugin_createdby](systemuser.md#BKMK_lk_msdyn_servicecopilotplugin_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_servicecopilotplugin_createdonbehalfby"></a> lk_msdyn_servicecopilotplugin_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_servicecopilotplugin_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_servicecopilotplugin_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_servicecopilotplugin_modifiedby"></a> lk_msdyn_servicecopilotplugin_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_servicecopilotplugin_modifiedby](systemuser.md#BKMK_lk_msdyn_servicecopilotplugin_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_servicecopilotplugin_modifiedonbehalfby"></a> lk_msdyn_servicecopilotplugin_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_servicecopilotplugin_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_servicecopilotplugin_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid"></a> msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid

One-To-Many Relationship: [aiplugin msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid](aiplugin.md#BKMK_msdyn_aiplugin_msdyn_servicecopilotplugin_aipluginid)

|Property|Value|
|---|---|
|ReferencedEntity|`aiplugin`|
|ReferencedAttribute|`aipluginid`|
|ReferencingAttribute|`msdyn_aipluginid`|
|ReferencingEntityNavigationPropertyName|`msdyn_aipluginid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid"></a> msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid

One-To-Many Relationship: [botcomponent msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid](botcomponent.md#BKMK_msdyn_botcomponent_msdyn_servicecopilotplugin_botcomponentid)

|Property|Value|
|---|---|
|ReferencedEntity|`botcomponent`|
|ReferencedAttribute|`botcomponentid`|
|ReferencingAttribute|`msdyn_botcomponentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_botcomponentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_servicecopilotplugin"></a> organization_msdyn_servicecopilotplugin

One-To-Many Relationship: [organization organization_msdyn_servicecopilotplugin](organization.md#BKMK_organization_msdyn_servicecopilotplugin)

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

- [msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid](#BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid)
- [msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginrole_servicecopilotpluginId](#BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginrole_servicecopilotpluginId)
- [msdyn_servicecopilotplugin_AsyncOperations](#BKMK_msdyn_servicecopilotplugin_AsyncOperations)
- [msdyn_servicecopilotplugin_BulkDeleteFailures](#BKMK_msdyn_servicecopilotplugin_BulkDeleteFailures)
- [msdyn_servicecopilotplugin_DuplicateBaseRecord](#BKMK_msdyn_servicecopilotplugin_DuplicateBaseRecord)
- [msdyn_servicecopilotplugin_DuplicateMatchingRecord](#BKMK_msdyn_servicecopilotplugin_DuplicateMatchingRecord)
- [msdyn_servicecopilotplugin_MailboxTrackingFolders](#BKMK_msdyn_servicecopilotplugin_MailboxTrackingFolders)
- [msdyn_servicecopilotplugin_PrincipalObjectAttributeAccesses](#BKMK_msdyn_servicecopilotplugin_PrincipalObjectAttributeAccesses)
- [msdyn_servicecopilotplugin_ProcessSession](#BKMK_msdyn_servicecopilotplugin_ProcessSession)
- [msdyn_servicecopilotplugin_SyncErrors](#BKMK_msdyn_servicecopilotplugin_SyncErrors)

### <a name="BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid"></a> msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid

Many-To-One Relationship: [msdyn_servicecopilotpluginaction msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid](msdyn_servicecopilotpluginaction.md#BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotpluginaction`|
|ReferencingAttribute|`msdyn_servicecopilotpluginid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginrole_servicecopilotpluginId"></a> msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginrole_servicecopilotpluginId

Many-To-One Relationship: [msdyn_servicecopilotpluginrole msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginrole_servicecopilotpluginId](msdyn_servicecopilotpluginrole.md#BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginrole_servicecopilotpluginId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotpluginrole`|
|ReferencingAttribute|`msdyn_servicecopilotpluginid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginrole_servicecopilotpluginId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotplugin_AsyncOperations"></a> msdyn_servicecopilotplugin_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_servicecopilotplugin_AsyncOperations](asyncoperation.md#BKMK_msdyn_servicecopilotplugin_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotplugin_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotplugin_BulkDeleteFailures"></a> msdyn_servicecopilotplugin_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_servicecopilotplugin_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_servicecopilotplugin_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotplugin_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotplugin_DuplicateBaseRecord"></a> msdyn_servicecopilotplugin_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_servicecopilotplugin_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_servicecopilotplugin_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotplugin_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotplugin_DuplicateMatchingRecord"></a> msdyn_servicecopilotplugin_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_servicecopilotplugin_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_servicecopilotplugin_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotplugin_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotplugin_MailboxTrackingFolders"></a> msdyn_servicecopilotplugin_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_servicecopilotplugin_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_servicecopilotplugin_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotplugin_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotplugin_PrincipalObjectAttributeAccesses"></a> msdyn_servicecopilotplugin_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_servicecopilotplugin_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_servicecopilotplugin_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotplugin_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotplugin_ProcessSession"></a> msdyn_servicecopilotplugin_ProcessSession

Many-To-One Relationship: [processsession msdyn_servicecopilotplugin_ProcessSession](processsession.md#BKMK_msdyn_servicecopilotplugin_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotplugin_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotplugin_SyncErrors"></a> msdyn_servicecopilotplugin_SyncErrors

Many-To-One Relationship: [syncerror msdyn_servicecopilotplugin_SyncErrors](syncerror.md#BKMK_msdyn_servicecopilotplugin_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotplugin_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

