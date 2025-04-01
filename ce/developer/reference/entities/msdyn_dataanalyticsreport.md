---
title: "Data Analytics Report (msdyn_dataanalyticsreport) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Data Analytics Report (msdyn_dataanalyticsreport) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Data Analytics Report (msdyn_dataanalyticsreport) table/entity reference (Microsoft Dynamics 365)

Data Analytics Reports

## Messages

The following table lists the messages for the Data Analytics Report (msdyn_dataanalyticsreport) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_dataanalyticsreports(*msdyn_dataanalyticsreportid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_dataanalyticsreports<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_dataanalyticsreports(*msdyn_dataanalyticsreportid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_dataanalyticsreports(*msdyn_dataanalyticsreportid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_dataanalyticsreports<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_dataanalyticsreports(*msdyn_dataanalyticsreportid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_dataanalyticsreports(*msdyn_dataanalyticsreportid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_dataanalyticsreports(*msdyn_dataanalyticsreportid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Data Analytics Report (msdyn_dataanalyticsreport) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Data Analytics Report** |
| **DisplayCollectionName** | **Data Analytics Reports** |
| **SchemaName** | `msdyn_dataanalyticsreport` |
| **CollectionSchemaName** | `msdyn_dataanalyticsreports` |
| **EntitySetName** | `msdyn_dataanalyticsreports`|
| **LogicalName** | `msdyn_dataanalyticsreport` |
| **LogicalCollectionName** | `msdyn_dataanalyticsreports` |
| **PrimaryIdAttribute** | `msdyn_dataanalyticsreportid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_analyticschecksum](#BKMK_msdyn_analyticschecksum)
- [msdyn_dataanalyticsreportId](#BKMK_msdyn_dataanalyticsreportId)
- [msdyn_datainsightsandanalyticsfeatureId](#BKMK_msdyn_datainsightsandanalyticsfeatureId)
- [msdyn_datasetid](#BKMK_msdyn_datasetid)
- [msdyn_dataversereportid](#BKMK_msdyn_dataversereportid)
- [msdyn_displayname](#BKMK_msdyn_displayname)
- [msdyn_displayorder](#BKMK_msdyn_displayorder)
- [msdyn_isenabled](#BKMK_msdyn_isenabled)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_provisionstatus](#BKMK_msdyn_provisionstatus)
- [msdyn_reportentityname](#BKMK_msdyn_reportentityname)
- [msdyn_reportgroup](#BKMK_msdyn_reportgroup)
- [msdyn_reportid](#BKMK_msdyn_reportid)
- [msdyn_reportpage](#BKMK_msdyn_reportpage)
- [msdyn_reporttemplateid](#BKMK_msdyn_reporttemplateid)
- [msdyn_workspaceid](#BKMK_msdyn_workspaceid)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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
|Description|**Record the Checksum during initial provision so we can validate if the org has been restored or copied over.**|
|DisplayName|**Analytics Checksum**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_analyticschecksum`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_dataanalyticsreportId"></a> msdyn_dataanalyticsreportId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Data Analytics Report**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_dataanalyticsreportid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeatureId"></a> msdyn_datainsightsandanalyticsfeatureId

|Property|Value|
|---|---|
|Description|**Data Insights And Analytics Feature Id**|
|DisplayName|**datainsightsandanalyticsfeatureId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datainsightsandanalyticsfeatureid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_datainsightsandanalyticsfeature|

### <a name="BKMK_msdyn_datasetid"></a> msdyn_datasetid

|Property|Value|
|---|---|
|Description|**Power BI Dataset Id**|
|DisplayName|**Dataset Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datasetid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_dataversereportid"></a> msdyn_dataversereportid

|Property|Value|
|---|---|
|Description|**Report Id of dataverse report entity**|
|DisplayName|**msdyn_dataversereportid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dataversereportid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_displayname"></a> msdyn_displayname

|Property|Value|
|---|---|
|Description|**The display name of the custom entity.**|
|DisplayName|**Display name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_displayorder"></a> msdyn_displayorder

|Property|Value|
|---|---|
|Description|**Report Display Order**|
|DisplayName|**Report Display Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayorder`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_isenabled"></a> msdyn_isenabled

|Property|Value|
|---|---|
|Description|**Specifies whether this report is enabled for rendering**|
|DisplayName|**Is Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_dataanalyticsreport_msdyn_isenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

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
|MaxLength|500|

### <a name="BKMK_msdyn_provisionstatus"></a> msdyn_provisionstatus

|Property|Value|
|---|---|
|Description|**Power BI Report Provision Status for this Analytics Record**|
|DisplayName|**Report Provision Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisionstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_dataanalyticsreport_msdyn_provisionstatus`|
|DefaultValue|False|
|True Label|Provisioned Successfully|
|False Label|Not Provisioned|

### <a name="BKMK_msdyn_reportentityname"></a> msdyn_reportentityname

|Property|Value|
|---|---|
|Description|**Report Entity Name**|
|DisplayName|**Report Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reportentityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_reportgroup"></a> msdyn_reportgroup

|Property|Value|
|---|---|
|Description|**Report Group**|
|DisplayName|**Report Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reportgroup`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_reportid"></a> msdyn_reportid

|Property|Value|
|---|---|
|Description|**Power BI Report ID**|
|DisplayName|**Report Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reportid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_reportpage"></a> msdyn_reportpage

|Property|Value|
|---|---|
|Description|**Report Page**|
|DisplayName|**Report Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reportpage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_reporttemplateid"></a> msdyn_reporttemplateid

|Property|Value|
|---|---|
|Description|**Report Template Id used for sending provision request**|
|DisplayName|**Report Template Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reporttemplateid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_workspaceid"></a> msdyn_workspaceid

|Property|Value|
|---|---|
|Description|**Power BI Workspace ID**|
|DisplayName|**Workspace Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workspaceid`|
|RequiredLevel|ApplicationRequired|
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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Data Analytics Report**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_dataanalyticsreport_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Data Analytics Report**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_dataanalyticsreport_statuscode`|

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
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

- [business_unit_msdyn_dataanalyticsreport](#BKMK_business_unit_msdyn_dataanalyticsreport)
- [lk_msdyn_dataanalyticsreport_createdby](#BKMK_lk_msdyn_dataanalyticsreport_createdby)
- [lk_msdyn_dataanalyticsreport_createdonbehalfby](#BKMK_lk_msdyn_dataanalyticsreport_createdonbehalfby)
- [lk_msdyn_dataanalyticsreport_modifiedby](#BKMK_lk_msdyn_dataanalyticsreport_modifiedby)
- [lk_msdyn_dataanalyticsreport_modifiedonbehalfby](#BKMK_lk_msdyn_dataanalyticsreport_modifiedonbehalfby)
- [msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId](#BKMK_msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId)
- [owner_msdyn_dataanalyticsreport](#BKMK_owner_msdyn_dataanalyticsreport)
- [team_msdyn_dataanalyticsreport](#BKMK_team_msdyn_dataanalyticsreport)
- [user_msdyn_dataanalyticsreport](#BKMK_user_msdyn_dataanalyticsreport)

### <a name="BKMK_business_unit_msdyn_dataanalyticsreport"></a> business_unit_msdyn_dataanalyticsreport

One-To-Many Relationship: [businessunit business_unit_msdyn_dataanalyticsreport](businessunit.md#BKMK_business_unit_msdyn_dataanalyticsreport)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dataanalyticsreport_createdby"></a> lk_msdyn_dataanalyticsreport_createdby

One-To-Many Relationship: [systemuser lk_msdyn_dataanalyticsreport_createdby](systemuser.md#BKMK_lk_msdyn_dataanalyticsreport_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dataanalyticsreport_createdonbehalfby"></a> lk_msdyn_dataanalyticsreport_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_dataanalyticsreport_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_dataanalyticsreport_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dataanalyticsreport_modifiedby"></a> lk_msdyn_dataanalyticsreport_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_dataanalyticsreport_modifiedby](systemuser.md#BKMK_lk_msdyn_dataanalyticsreport_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dataanalyticsreport_modifiedonbehalfby"></a> lk_msdyn_dataanalyticsreport_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_dataanalyticsreport_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_dataanalyticsreport_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId"></a> msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId

One-To-Many Relationship: [msdyn_datainsightsandanalyticsfeature msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId](msdyn_datainsightsandanalyticsfeature.md#BKMK_msdyn_datainsightsandanalyticsfeature_dataanalyticsreport_datainsightsandanalyticsfeatureId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_datainsightsandanalyticsfeature`|
|ReferencedAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencingEntityNavigationPropertyName|`msdyn_datainsightsandanalyticsfeatureId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_dataanalyticsreport"></a> owner_msdyn_dataanalyticsreport

One-To-Many Relationship: [owner owner_msdyn_dataanalyticsreport](owner.md#BKMK_owner_msdyn_dataanalyticsreport)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_dataanalyticsreport"></a> team_msdyn_dataanalyticsreport

One-To-Many Relationship: [team team_msdyn_dataanalyticsreport](team.md#BKMK_team_msdyn_dataanalyticsreport)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_dataanalyticsreport"></a> user_msdyn_dataanalyticsreport

One-To-Many Relationship: [systemuser user_msdyn_dataanalyticsreport](systemuser.md#BKMK_user_msdyn_dataanalyticsreport)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_dataanalyticsreport_AsyncOperations](#BKMK_msdyn_dataanalyticsreport_AsyncOperations)
- [msdyn_dataanalyticsreport_BulkDeleteFailures](#BKMK_msdyn_dataanalyticsreport_BulkDeleteFailures)
- [msdyn_dataanalyticsreport_dataanalyticscustomizedreport_dataanalyticsreportid](#BKMK_msdyn_dataanalyticsreport_dataanalyticscustomizedreport_dataanalyticsreportid)
- [msdyn_dataanalyticsreport_MailboxTrackingFolders](#BKMK_msdyn_dataanalyticsreport_MailboxTrackingFolders)
- [msdyn_dataanalyticsreport_PrincipalObjectAttributeAccesses](#BKMK_msdyn_dataanalyticsreport_PrincipalObjectAttributeAccesses)
- [msdyn_dataanalyticsreport_ProcessSession](#BKMK_msdyn_dataanalyticsreport_ProcessSession)
- [msdyn_dataanalyticsreport_SyncErrors](#BKMK_msdyn_dataanalyticsreport_SyncErrors)

### <a name="BKMK_msdyn_dataanalyticsreport_AsyncOperations"></a> msdyn_dataanalyticsreport_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_dataanalyticsreport_AsyncOperations](asyncoperation.md#BKMK_msdyn_dataanalyticsreport_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataanalyticsreport_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataanalyticsreport_BulkDeleteFailures"></a> msdyn_dataanalyticsreport_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_dataanalyticsreport_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_dataanalyticsreport_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataanalyticsreport_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataanalyticsreport_dataanalyticscustomizedreport_dataanalyticsreportid"></a> msdyn_dataanalyticsreport_dataanalyticscustomizedreport_dataanalyticsreportid

Many-To-One Relationship: [msdyn_dataanalyticscustomizedreport msdyn_dataanalyticsreport_dataanalyticscustomizedreport_dataanalyticsreportid](msdyn_dataanalyticscustomizedreport.md#BKMK_msdyn_dataanalyticsreport_dataanalyticscustomizedreport_dataanalyticsreportid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticscustomizedreport`|
|ReferencingAttribute|`msdyn_dataanalyticsreportid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataanalyticsreport_dataanalyticscustomizedreport_dataanalyticsreportid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataanalyticsreport_MailboxTrackingFolders"></a> msdyn_dataanalyticsreport_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_dataanalyticsreport_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_dataanalyticsreport_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataanalyticsreport_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataanalyticsreport_PrincipalObjectAttributeAccesses"></a> msdyn_dataanalyticsreport_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_dataanalyticsreport_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_dataanalyticsreport_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataanalyticsreport_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataanalyticsreport_ProcessSession"></a> msdyn_dataanalyticsreport_ProcessSession

Many-To-One Relationship: [processsession msdyn_dataanalyticsreport_ProcessSession](processsession.md#BKMK_msdyn_dataanalyticsreport_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataanalyticsreport_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataanalyticsreport_SyncErrors"></a> msdyn_dataanalyticsreport_SyncErrors

Many-To-One Relationship: [syncerror msdyn_dataanalyticsreport_SyncErrors](syncerror.md#BKMK_msdyn_dataanalyticsreport_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataanalyticsreport_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

