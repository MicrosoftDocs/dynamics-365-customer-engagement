---
title: "Insights (msdyn_datainsightsandanalyticsfeature) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Insights (msdyn_datainsightsandanalyticsfeature) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Insights (msdyn_datainsightsandanalyticsfeature) table/entity reference (Microsoft Dynamics 365)

Analytics and insights feature entity

## Messages

The following table lists the messages for the Insights (msdyn_datainsightsandanalyticsfeature) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_datainsightsandanalyticsfeatures<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_datainsightsandanalyticsfeatures(*msdyn_datainsightsandanalyticsfeatureid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_datainsightsandanalyticsfeatures(*msdyn_datainsightsandanalyticsfeatureid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_datainsightsandanalyticsfeatures<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_datainsightsandanalyticsfeatures(*msdyn_datainsightsandanalyticsfeatureid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_datainsightsandanalyticsfeatures(*msdyn_datainsightsandanalyticsfeatureid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_datainsightsandanalyticsfeatures(*msdyn_datainsightsandanalyticsfeatureid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Insights (msdyn_datainsightsandanalyticsfeature) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Insights** |
| **DisplayCollectionName** | **Insights** |
| **SchemaName** | `msdyn_datainsightsandanalyticsfeature` |
| **CollectionSchemaName** | `msdyn_datainsightsandanalyticsfeatures` |
| **EntitySetName** | `msdyn_datainsightsandanalyticsfeatures`|
| **LogicalName** | `msdyn_datainsightsandanalyticsfeature` |
| **LogicalCollectionName** | `msdyn_datainsightsandanalyticsfeatures` |
| **PrimaryIdAttribute** | `msdyn_datainsightsandanalyticsfeatureid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_analyticschecksum](#BKMK_msdyn_analyticschecksum)
- [msdyn_datainsightsandanalyticsfeatureId](#BKMK_msdyn_datainsightsandanalyticsfeatureId)
- [msdyn_datasourcemode](#BKMK_msdyn_datasourcemode)
- [msdyn_isdemoenabled](#BKMK_msdyn_isdemoenabled)
- [msdyn_isenabled](#BKMK_msdyn_isenabled)
- [msdyn_lastaccesstime](#BKMK_msdyn_lastaccesstime)
- [msdyn_lastprovisionsenttime](#BKMK_msdyn_lastprovisionsenttime)
- [msdyn_lastreportrefreshtime](#BKMK_msdyn_lastreportrefreshtime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_provisionerrorcode](#BKMK_msdyn_provisionerrorcode)
- [msdyn_provisionstatus](#BKMK_msdyn_provisionstatus)
- [msdyn_provisionstatusdetail](#BKMK_msdyn_provisionstatusdetail)
- [msdyn_provisionsubstatus](#BKMK_msdyn_provisionsubstatus)
- [msdyn_reporttype](#BKMK_msdyn_reporttype)
- [msdyn_schedule](#BKMK_msdyn_schedule)
- [msdyn_templateid](#BKMK_msdyn_templateid)
- [msdyn_timezonecode](#BKMK_msdyn_timezonecode)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_analyticschecksum"></a> msdyn_analyticschecksum

|Property|Value|
|---|---|
|Description|**Internal analytics checksum**|
|DisplayName|**Analytics Checksum**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_analyticschecksum`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeatureId"></a> msdyn_datainsightsandanalyticsfeatureId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**DataInsightsAndAnalyticsFeature**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_datainsightsandanalyticsfeatureid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_datasourcemode"></a> msdyn_datasourcemode

|Property|Value|
|---|---|
|Description|**Data Source Mode for the Power BI dataset used by this feature**|
|DisplayName|**Data Source Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datasourcemode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|487460000|
|GlobalChoiceName|`msdyn_datainsightsandanalyticsfeature_msdyn_datasourcemode`|

#### msdyn_datasourcemode Choices/Options

|Value|Label|
|---|---|
|487460000|**Import**|
|487460001|**DirectQuery**|

### <a name="BKMK_msdyn_isdemoenabled"></a> msdyn_isdemoenabled

|Property|Value|
|---|---|
|Description|**Is Demo Enabled**|
|DisplayName|**Is Demo Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdemoenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_datainsightsandanalyticsfeature_msdyn_isdemoenabled`|
|DefaultValue|False|
|True Label|Enabled|
|False Label|Disabled|

### <a name="BKMK_msdyn_isenabled"></a> msdyn_isenabled

|Property|Value|
|---|---|
|Description|**Is Enabled**|
|DisplayName|**Is Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_datainsightsandanalyticsfeature_msdyn_isenabled`|
|DefaultValue|False|
|True Label|Enabled|
|False Label|Disabled|

### <a name="BKMK_msdyn_lastaccesstime"></a> msdyn_lastaccesstime

|Property|Value|
|---|---|
|Description|**Record the most recent usage of the feature**|
|DisplayName|**Last Access Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastaccesstime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_lastprovisionsenttime"></a> msdyn_lastprovisionsenttime

|Property|Value|
|---|---|
|Description|**Last Provision Sent Time**|
|DisplayName|**Last Provision Sent Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastprovisionsenttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_lastreportrefreshtime"></a> msdyn_lastreportrefreshtime

|Property|Value|
|---|---|
|Description|**Last Report Refresh Time**|
|DisplayName|**Last Report Refresh Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastreportrefreshtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
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
|IsLocalizable|True|
|MaxLength|100|

### <a name="BKMK_msdyn_provisionerrorcode"></a> msdyn_provisionerrorcode

|Property|Value|
|---|---|
|Description|**Provision Error Code**|
|DisplayName|**Provision Error Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisionerrorcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_provisionstatus"></a> msdyn_provisionstatus

|Property|Value|
|---|---|
|Description|**Provision Status**|
|DisplayName|**Provision Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisionstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyn_datainsightsandanalyticsfeature_msdyn_provisionstatus`|

#### msdyn_provisionstatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Provisioned**|
|192350001|**Not Provisioned**|
|192350002|**Provision Failed**|
|192350003|**Provision in Progress**|

### <a name="BKMK_msdyn_provisionstatusdetail"></a> msdyn_provisionstatusdetail

|Property|Value|
|---|---|
|Description|**Provision Status Detail**|
|DisplayName|**Provision Status Detail**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisionstatusdetail`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_provisionsubstatus"></a> msdyn_provisionsubstatus

|Property|Value|
|---|---|
|Description|**Provision SubStatus (Deprecated), use Provision Status Detail**|
|DisplayName|**Provision SubStatus (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisionsubstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_reporttype"></a> msdyn_reporttype

|Property|Value|
|---|---|
|Description|**Report Type**|
|DisplayName|**Report Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reporttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_analyticsreporttype`|

#### msdyn_reporttype Choices/Options

|Value|Label|
|---|---|
|192350000|**Default**|
|192350001|**Published**|
|192350002|**Draft**|

### <a name="BKMK_msdyn_schedule"></a> msdyn_schedule

|Property|Value|
|---|---|
|Description|**Job Schedule for the feature**|
|DisplayName|**Schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedule`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_templateid"></a> msdyn_templateid

|Property|Value|
|---|---|
|Description|**Template Id for Reports**|
|DisplayName|**Template Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_templateid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_timezonecode"></a> msdyn_timezonecode

|Property|Value|
|---|---|
|Description|**timezonecode from TimeZoneDefinition Entity for the Job Schedule**|
|DisplayName|**Job Schedule Timezone Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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
|Description|**Status of the DataInsightsAndAnalyticsFeature**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_datainsightsandanalyticsfeature_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the DataInsightsAndAnalyticsFeature**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_datainsightsandanalyticsfeature_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_iscustomizationsupported](#BKMK_msdyn_iscustomizationsupported)
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_msdyn_iscustomizationsupported"></a> msdyn_iscustomizationsupported

|Property|Value|
|---|---|
|Description|**Is Customization Supported**|
|DisplayName|**Is Customization Supported**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscustomizationsupported`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_datainsightsandanalyticsfeature_msdyn_iscustomizationsupported`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [lk_msdyn_datainsightsandanalyticsfeature_createdby](#BKMK_lk_msdyn_datainsightsandanalyticsfeature_createdby)
- [lk_msdyn_datainsightsandanalyticsfeature_createdonbehalfby](#BKMK_lk_msdyn_datainsightsandanalyticsfeature_createdonbehalfby)
- [lk_msdyn_datainsightsandanalyticsfeature_modifiedby](#BKMK_lk_msdyn_datainsightsandanalyticsfeature_modifiedby)
- [lk_msdyn_datainsightsandanalyticsfeature_modifiedonbehalfby](#BKMK_lk_msdyn_datainsightsandanalyticsfeature_modifiedonbehalfby)
- [organization_msdyn_datainsightsandanalyticsfeature](#BKMK_organization_msdyn_datainsightsandanalyticsfeature)

### <a name="BKMK_lk_msdyn_datainsightsandanalyticsfeature_createdby"></a> lk_msdyn_datainsightsandanalyticsfeature_createdby

One-To-Many Relationship: [systemuser lk_msdyn_datainsightsandanalyticsfeature_createdby](systemuser.md#BKMK_lk_msdyn_datainsightsandanalyticsfeature_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_datainsightsandanalyticsfeature_createdonbehalfby"></a> lk_msdyn_datainsightsandanalyticsfeature_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_datainsightsandanalyticsfeature_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_datainsightsandanalyticsfeature_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_datainsightsandanalyticsfeature_modifiedby"></a> lk_msdyn_datainsightsandanalyticsfeature_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_datainsightsandanalyticsfeature_modifiedby](systemuser.md#BKMK_lk_msdyn_datainsightsandanalyticsfeature_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_datainsightsandanalyticsfeature_modifiedonbehalfby"></a> lk_msdyn_datainsightsandanalyticsfeature_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_datainsightsandanalyticsfeature_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_datainsightsandanalyticsfeature_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_datainsightsandanalyticsfeature"></a> organization_msdyn_datainsightsandanalyticsfeature

One-To-Many Relationship: [organization organization_msdyn_datainsightsandanalyticsfeature](organization.md#BKMK_organization_msdyn_datainsightsandanalyticsfeature)

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

- [msdyn_dasfeature_copilot_datainsightsandanalyticsfeatureId](#BKMK_msdyn_dasfeature_copilot_datainsightsandanalyticsfeatureId)
- [msdyn_dasfeature_dascsrmanager_datainsightsandanalyticsfeatureId](#BKMK_msdyn_dasfeature_dascsrmanager_datainsightsandanalyticsfeatureId)
- [msdyn_dasfeature_dasemail_datainsightsandanalyticsfeatureId](#BKMK_msdyn_dasfeature_dasemail_datainsightsandanalyticsfeatureId)
- [msdyn_dasfeature_dasforecast_datainsightsandanalyticsfeatureId](#BKMK_msdyn_dasfeature_dasforecast_datainsightsandanalyticsfeatureId)
- [msdyn_dasfeature_dasksi_datainsightsandanalyticsfeatureId](#BKMK_msdyn_dasfeature_dasksi_datainsightsandanalyticsfeatureId)
- [msdyn_dasfeature_dasmc_datainsightsandanalyticsfeatureId](#BKMK_msdyn_dasfeature_dasmc_datainsightsandanalyticsfeatureId)
- [msdyn_dasfeature_dasoc_datainsightsandanalyticsfeatureid](#BKMK_msdyn_dasfeature_dasoc_datainsightsandanalyticsfeatureid)
- [msdyn_dasfeature_dasoc_rt_datainsightsandanalyticsfeatureid](#BKMK_msdyn_dasfeature_dasoc_rt_datainsightsandanalyticsfeatureid)
- [msdyn_dasfeature_dassareporting_datainsightsandanalyticsfeatureid](#BKMK_msdyn_dasfeature_dassareporting_datainsightsandanalyticsfeatureid)
- [msdyn_dasfeature_dassutreporting_datainsightsandanalyticsfeatureid](#BKMK_msdyn_dasfeature_dassutreporting_datainsightsandanalyticsfeatureid)
- [msdyn_dasfeature_dasurrt_datainsightsandanalyticsfeatureId](#BKMK_msdyn_dasfeature_dasurrt_datainsightsandanalyticsfeatureId)
- [msdyn_dataanalyticsdataset_datainsightsandanalyticsfeatureid](#BKMK_msdyn_dataanalyticsdataset_datainsightsandanalyticsfeatureid)
- [msdyn_datainsightsandanalyticsfeature_AsyncOperations](#BKMK_msdyn_datainsightsandanalyticsfeature_AsyncOperations)
- [msdyn_datainsightsandanalyticsfeature_BulkDeleteFailures](#BKMK_msdyn_datainsightsandanalyticsfeature_BulkDeleteFailures)
- [msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId](#BKMK_msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId)
- [msdyn_datainsightsandanalyticsfeature_MailboxTrackingFolders](#BKMK_msdyn_datainsightsandanalyticsfeature_MailboxTrackingFolders)
- [msdyn_datainsightsandanalyticsfeature_PrincipalObjectAttributeAccesses](#BKMK_msdyn_datainsightsandanalyticsfeature_PrincipalObjectAttributeAccesses)
- [msdyn_datainsightsandanalyticsfeature_ProcessSession](#BKMK_msdyn_datainsightsandanalyticsfeature_ProcessSession)
- [msdyn_datainsightsandanalyticsfeature_SyncErrors](#BKMK_msdyn_datainsightsandanalyticsfeature_SyncErrors)
- [msdyn_feature_customizedreport_datainsightsandanalyticsfeatureId](#BKMK_msdyn_feature_customizedreport_datainsightsandanalyticsfeatureId)
- [msdyn_msdyn_dataanalyticsworkspace_datainsightsandanalyticsfeatureid](#BKMK_msdyn_msdyn_dataanalyticsworkspace_datainsightsandanalyticsfeatureid)
- [msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid](#BKMK_msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid)

### <a name="BKMK_msdyn_dasfeature_copilot_datainsightsandanalyticsfeatureId"></a> msdyn_dasfeature_copilot_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticsreport_copilot msdyn_dasfeature_copilot_datainsightsandanalyticsfeatureId](msdyn_dataanalyticsreport_copilot.md#BKMK_msdyn_dasfeature_copilot_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_copilot`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_copilot_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dascsrmanager_datainsightsandanalyticsfeatureId"></a> msdyn_dasfeature_dascsrmanager_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticsreport_csrmanager msdyn_dasfeature_dascsrmanager_datainsightsandanalyticsfeatureId](msdyn_dataanalyticsreport_csrmanager.md#BKMK_msdyn_dasfeature_dascsrmanager_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_csrmanager`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dascsrmanager_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasemail_datainsightsandanalyticsfeatureId"></a> msdyn_dasfeature_dasemail_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticsreport_email msdyn_dasfeature_dasemail_datainsightsandanalyticsfeatureId](msdyn_dataanalyticsreport_email.md#BKMK_msdyn_dasfeature_dasemail_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_email`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasemail_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasforecast_datainsightsandanalyticsfeatureId"></a> msdyn_dasfeature_dasforecast_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticsreport_forecast msdyn_dasfeature_dasforecast_datainsightsandanalyticsfeatureId](msdyn_dataanalyticsreport_forecast.md#BKMK_msdyn_dasfeature_dasforecast_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_forecast`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasforecast_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasksi_datainsightsandanalyticsfeatureId"></a> msdyn_dasfeature_dasksi_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticsreport_ksinsights msdyn_dasfeature_dasksi_datainsightsandanalyticsfeatureId](msdyn_dataanalyticsreport_ksinsights.md#BKMK_msdyn_dasfeature_dasksi_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_ksinsights`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasksi_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasmc_datainsightsandanalyticsfeatureId"></a> msdyn_dasfeature_dasmc_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticsreport_mc msdyn_dasfeature_dasmc_datainsightsandanalyticsfeatureId](msdyn_dataanalyticsreport_mc.md#BKMK_msdyn_dasfeature_dasmc_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_mc`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasmc_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasoc_datainsightsandanalyticsfeatureid"></a> msdyn_dasfeature_dasoc_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsreport_oc msdyn_dasfeature_dasoc_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsreport_oc.md#BKMK_msdyn_dasfeature_dasoc_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_oc`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasoc_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasoc_rt_datainsightsandanalyticsfeatureid"></a> msdyn_dasfeature_dasoc_rt_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsreport_oc_rt msdyn_dasfeature_dasoc_rt_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsreport_oc_rt.md#BKMK_msdyn_dasfeature_dasoc_rt_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_oc_rt`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasoc_rt_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dassareporting_datainsightsandanalyticsfeatureid"></a> msdyn_dasfeature_dassareporting_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsreport_sareporting msdyn_dasfeature_dassareporting_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsreport_sareporting.md#BKMK_msdyn_dasfeature_dassareporting_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_sareporting`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dassareporting_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dassutreporting_datainsightsandanalyticsfeatureid"></a> msdyn_dasfeature_dassutreporting_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsreport_sutreporting msdyn_dasfeature_dassutreporting_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsreport_sutreporting.md#BKMK_msdyn_dasfeature_dassutreporting_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_sutreporting`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dassutreporting_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasurrt_datainsightsandanalyticsfeatureId"></a> msdyn_dasfeature_dasurrt_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticsreport_ur_recordrouting_rt msdyn_dasfeature_dasurrt_datainsightsandanalyticsfeatureId](msdyn_dataanalyticsreport_ur_recordrouting_rt.md#BKMK_msdyn_dasfeature_dasurrt_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_ur_recordrouting_rt`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasurrt_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataanalyticsdataset_datainsightsandanalyticsfeatureid"></a> msdyn_dataanalyticsdataset_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsdataset msdyn_dataanalyticsdataset_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsdataset.md#BKMK_msdyn_dataanalyticsdataset_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsdataset`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataanalyticsdataset_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeature_AsyncOperations"></a> msdyn_datainsightsandanalyticsfeature_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_datainsightsandanalyticsfeature_AsyncOperations](asyncoperation.md#BKMK_msdyn_datainsightsandanalyticsfeature_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeature_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeature_BulkDeleteFailures"></a> msdyn_datainsightsandanalyticsfeature_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_datainsightsandanalyticsfeature_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_datainsightsandanalyticsfeature_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeature_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId"></a> msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticsreport msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId](msdyn_dataanalyticsreport.md#BKMK_msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeature_MailboxTrackingFolders"></a> msdyn_datainsightsandanalyticsfeature_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_datainsightsandanalyticsfeature_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_datainsightsandanalyticsfeature_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeature_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeature_PrincipalObjectAttributeAccesses"></a> msdyn_datainsightsandanalyticsfeature_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_datainsightsandanalyticsfeature_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_datainsightsandanalyticsfeature_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeature_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeature_ProcessSession"></a> msdyn_datainsightsandanalyticsfeature_ProcessSession

Many-To-One Relationship: [processsession msdyn_datainsightsandanalyticsfeature_ProcessSession](processsession.md#BKMK_msdyn_datainsightsandanalyticsfeature_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeature_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeature_SyncErrors"></a> msdyn_datainsightsandanalyticsfeature_SyncErrors

Many-To-One Relationship: [syncerror msdyn_datainsightsandanalyticsfeature_SyncErrors](syncerror.md#BKMK_msdyn_datainsightsandanalyticsfeature_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeature_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_feature_customizedreport_datainsightsandanalyticsfeatureId"></a> msdyn_feature_customizedreport_datainsightsandanalyticsfeatureId

Many-To-One Relationship: [msdyn_dataanalyticscustomizedreport msdyn_feature_customizedreport_datainsightsandanalyticsfeatureId](msdyn_dataanalyticscustomizedreport.md#BKMK_msdyn_feature_customizedreport_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticscustomizedreport`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_feature_customizedreport_datainsightsandanalyticsfeatureId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_dataanalyticsworkspace_datainsightsandanalyticsfeatureid"></a> msdyn_msdyn_dataanalyticsworkspace_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsworkspace msdyn_msdyn_dataanalyticsworkspace_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsworkspace.md#BKMK_msdyn_msdyn_dataanalyticsworkspace_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsworkspace`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_dataanalyticsworkspace_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid"></a> msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid

Many-To-One Relationship: [msdyn_forecastsettingsandsummary msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid](msdyn_forecastsettingsandsummary.md#BKMK_msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastsettingsandsummary`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_datainsightsandanalyticsfeature_msdyn_forecastsettingsandsummary_diafeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

