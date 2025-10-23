---
title: "Service Copilot Plugin Action (msdyn_servicecopilotpluginaction) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Service Copilot Plugin Action (msdyn_servicecopilotpluginaction) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Service Copilot Plugin Action (msdyn_servicecopilotpluginaction) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Service Copilot Plugin Action (msdyn_servicecopilotpluginaction) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_servicecopilotpluginactions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_servicecopilotpluginactions(*msdyn_servicecopilotpluginactionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_servicecopilotpluginactions(*msdyn_servicecopilotpluginactionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_servicecopilotpluginactions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_servicecopilotpluginactions(*msdyn_servicecopilotpluginactionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_servicecopilotpluginactions(*msdyn_servicecopilotpluginactionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_servicecopilotpluginactions(*msdyn_servicecopilotpluginactionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Service Copilot Plugin Action (msdyn_servicecopilotpluginaction) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Service Copilot Plugin Action** |
| **DisplayCollectionName** | **Service Copilot Plugin Actions** |
| **SchemaName** | `msdyn_servicecopilotpluginaction` |
| **CollectionSchemaName** | `msdyn_servicecopilotpluginactions` |
| **EntitySetName** | `msdyn_servicecopilotpluginactions`|
| **LogicalName** | `msdyn_servicecopilotpluginaction` |
| **LogicalCollectionName** | `msdyn_servicecopilotpluginactions` |
| **PrimaryIdAttribute** | `msdyn_servicecopilotpluginactionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actionuniquename](#BKMK_msdyn_actionuniquename)
- [msdyn_aipluginoperationid](#BKMK_msdyn_aipluginoperationid)
- [msdyn_botcomponentid](#BKMK_msdyn_botcomponentid)
- [msdyn_connectorname](#BKMK_msdyn_connectorname)
- [msdyn_lastactionsynctime](#BKMK_msdyn_lastactionsynctime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_parameterconfiguration](#BKMK_msdyn_parameterconfiguration)
- [msdyn_parameterconfigurationpendingpublish](#BKMK_msdyn_parameterconfigurationpendingpublish)
- [msdyn_servicecopilotpluginactionId](#BKMK_msdyn_servicecopilotpluginactionId)
- [msdyn_servicecopilotpluginid](#BKMK_msdyn_servicecopilotpluginid)
- [msdyn_status](#BKMK_msdyn_status)
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

### <a name="BKMK_msdyn_actionuniquename"></a> msdyn_actionuniquename

|Property|Value|
|---|---|
|Description|**Action Unique Name**|
|DisplayName|**Action Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionuniquename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_aipluginoperationid"></a> msdyn_aipluginoperationid

|Property|Value|
|---|---|
|Description|**AI Plugin Operation Id**|
|DisplayName|**AI Plugin Operation Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aipluginoperationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|aipluginoperation|

### <a name="BKMK_msdyn_botcomponentid"></a> msdyn_botcomponentid

|Property|Value|
|---|---|
|Description|**Bot Component id**|
|DisplayName|**Bot Component id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_botcomponentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|botcomponent|

### <a name="BKMK_msdyn_connectorname"></a> msdyn_connectorname

|Property|Value|
|---|---|
|Description|**Plugin Connector Name**|
|DisplayName|**Connector Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_connectorname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_lastactionsynctime"></a> msdyn_lastactionsynctime

|Property|Value|
|---|---|
|Description|**Last Action Metadata Sync Time**|
|DisplayName|**Last Action Metadata Sync Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastactionsynctime`|
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

### <a name="BKMK_msdyn_parameterconfigurationpendingpublish"></a> msdyn_parameterconfigurationpendingpublish

|Property|Value|
|---|---|
|Description|**Parameter Configuration to store input parameter changes, pending publish**|
|DisplayName|**Parameter Configuration to store input parameter changes, pending publish**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parameterconfigurationpendingpublish`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_servicecopilotpluginactionId"></a> msdyn_servicecopilotpluginactionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Service Copilot Plugin Action Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_servicecopilotpluginactionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_servicecopilotpluginid"></a> msdyn_servicecopilotpluginid

|Property|Value|
|---|---|
|Description|**Service Copilot plugin Id**|
|DisplayName|**Service Copilot plugin Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_servicecopilotpluginid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_servicecopilotplugin|

### <a name="BKMK_msdyn_status"></a> msdyn_status

|Property|Value|
|---|---|
|Description|**Action Status**|
|DisplayName|**Action Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_servicecopilotpluginaction_msdyn_status`|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the servicecopilotpluginaction**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_servicecopilotpluginaction_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the servicecopilotpluginaction**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_servicecopilotpluginaction_statuscode`|

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

- [lk_msdyn_servicecopilotpluginaction_createdby](#BKMK_lk_msdyn_servicecopilotpluginaction_createdby)
- [lk_msdyn_servicecopilotpluginaction_createdonbehalfby](#BKMK_lk_msdyn_servicecopilotpluginaction_createdonbehalfby)
- [lk_msdyn_servicecopilotpluginaction_modifiedby](#BKMK_lk_msdyn_servicecopilotpluginaction_modifiedby)
- [lk_msdyn_servicecopilotpluginaction_modifiedonbehalfby](#BKMK_lk_msdyn_servicecopilotpluginaction_modifiedonbehalfby)
- [msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid](#BKMK_msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid)
- [msdyn_botcomponent_msdyn_servicecopilotpluginaction_botcomponentid](#BKMK_msdyn_botcomponent_msdyn_servicecopilotpluginaction_botcomponentid)
- [msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid](#BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid)
- [organization_msdyn_servicecopilotpluginaction](#BKMK_organization_msdyn_servicecopilotpluginaction)

### <a name="BKMK_lk_msdyn_servicecopilotpluginaction_createdby"></a> lk_msdyn_servicecopilotpluginaction_createdby

One-To-Many Relationship: [systemuser lk_msdyn_servicecopilotpluginaction_createdby](systemuser.md#BKMK_lk_msdyn_servicecopilotpluginaction_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_servicecopilotpluginaction_createdonbehalfby"></a> lk_msdyn_servicecopilotpluginaction_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_servicecopilotpluginaction_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_servicecopilotpluginaction_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_servicecopilotpluginaction_modifiedby"></a> lk_msdyn_servicecopilotpluginaction_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_servicecopilotpluginaction_modifiedby](systemuser.md#BKMK_lk_msdyn_servicecopilotpluginaction_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_servicecopilotpluginaction_modifiedonbehalfby"></a> lk_msdyn_servicecopilotpluginaction_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_servicecopilotpluginaction_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_servicecopilotpluginaction_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid"></a> msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid

One-To-Many Relationship: [aipluginoperation msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid](aipluginoperation.md#BKMK_msdyn_aipluginoperation_msdyn_servicecopilotpluginaction_aipluginoperationid)

|Property|Value|
|---|---|
|ReferencedEntity|`aipluginoperation`|
|ReferencedAttribute|`aipluginoperationid`|
|ReferencingAttribute|`msdyn_aipluginoperationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_aipluginoperationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_botcomponent_msdyn_servicecopilotpluginaction_botcomponentid"></a> msdyn_botcomponent_msdyn_servicecopilotpluginaction_botcomponentid

One-To-Many Relationship: [botcomponent msdyn_botcomponent_msdyn_servicecopilotpluginaction_botcomponentid](botcomponent.md#BKMK_msdyn_botcomponent_msdyn_servicecopilotpluginaction_botcomponentid)

|Property|Value|
|---|---|
|ReferencedEntity|`botcomponent`|
|ReferencedAttribute|`botcomponentid`|
|ReferencingAttribute|`msdyn_botcomponentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_botcomponentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid"></a> msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid

One-To-Many Relationship: [msdyn_servicecopilotplugin msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid](msdyn_servicecopilotplugin.md#BKMK_msdyn_msdyn_servicecopilotplugin_msdyn_servicecopilotpluginaction_servicecopilotpluginid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicecopilotplugin`|
|ReferencedAttribute|`msdyn_servicecopilotpluginid`|
|ReferencingAttribute|`msdyn_servicecopilotpluginid`|
|ReferencingEntityNavigationPropertyName|`msdyn_servicecopilotpluginid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_servicecopilotpluginaction"></a> organization_msdyn_servicecopilotpluginaction

One-To-Many Relationship: [organization organization_msdyn_servicecopilotpluginaction](organization.md#BKMK_organization_msdyn_servicecopilotpluginaction)

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

- [msdyn_servicecopilotpluginaction_AsyncOperations](#BKMK_msdyn_servicecopilotpluginaction_AsyncOperations)
- [msdyn_servicecopilotpluginaction_BulkDeleteFailures](#BKMK_msdyn_servicecopilotpluginaction_BulkDeleteFailures)
- [msdyn_servicecopilotpluginaction_DuplicateBaseRecord](#BKMK_msdyn_servicecopilotpluginaction_DuplicateBaseRecord)
- [msdyn_servicecopilotpluginaction_DuplicateMatchingRecord](#BKMK_msdyn_servicecopilotpluginaction_DuplicateMatchingRecord)
- [msdyn_servicecopilotpluginaction_MailboxTrackingFolders](#BKMK_msdyn_servicecopilotpluginaction_MailboxTrackingFolders)
- [msdyn_servicecopilotpluginaction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_servicecopilotpluginaction_PrincipalObjectAttributeAccesses)
- [msdyn_servicecopilotpluginaction_ProcessSession](#BKMK_msdyn_servicecopilotpluginaction_ProcessSession)
- [msdyn_servicecopilotpluginaction_SyncErrors](#BKMK_msdyn_servicecopilotpluginaction_SyncErrors)

### <a name="BKMK_msdyn_servicecopilotpluginaction_AsyncOperations"></a> msdyn_servicecopilotpluginaction_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_servicecopilotpluginaction_AsyncOperations](asyncoperation.md#BKMK_msdyn_servicecopilotpluginaction_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotpluginaction_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotpluginaction_BulkDeleteFailures"></a> msdyn_servicecopilotpluginaction_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_servicecopilotpluginaction_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_servicecopilotpluginaction_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotpluginaction_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotpluginaction_DuplicateBaseRecord"></a> msdyn_servicecopilotpluginaction_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_servicecopilotpluginaction_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_servicecopilotpluginaction_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotpluginaction_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotpluginaction_DuplicateMatchingRecord"></a> msdyn_servicecopilotpluginaction_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_servicecopilotpluginaction_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_servicecopilotpluginaction_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotpluginaction_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotpluginaction_MailboxTrackingFolders"></a> msdyn_servicecopilotpluginaction_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_servicecopilotpluginaction_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_servicecopilotpluginaction_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotpluginaction_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotpluginaction_PrincipalObjectAttributeAccesses"></a> msdyn_servicecopilotpluginaction_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_servicecopilotpluginaction_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_servicecopilotpluginaction_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotpluginaction_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotpluginaction_ProcessSession"></a> msdyn_servicecopilotpluginaction_ProcessSession

Many-To-One Relationship: [processsession msdyn_servicecopilotpluginaction_ProcessSession](processsession.md#BKMK_msdyn_servicecopilotpluginaction_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotpluginaction_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_servicecopilotpluginaction_SyncErrors"></a> msdyn_servicecopilotpluginaction_SyncErrors

Many-To-One Relationship: [syncerror msdyn_servicecopilotpluginaction_SyncErrors](syncerror.md#BKMK_msdyn_servicecopilotpluginaction_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_servicecopilotpluginaction_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

