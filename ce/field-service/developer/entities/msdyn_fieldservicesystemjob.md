---
title: "Field Service System Job (msdyn_fieldservicesystemjob) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Field Service System Job (msdyn_fieldservicesystemjob) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Field Service System Job (msdyn_fieldservicesystemjob) table/entity reference

An internal entity used to track field service system jobs.

## Messages

The following table lists the messages for the Field Service System Job (msdyn_fieldservicesystemjob) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_fieldservicesystemjobs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `msdyn_FieldServiceSystemJobWOShareUnshareAction`<br />Event: False |**msdyn_FieldServiceSystemJobWOShareUnshareAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_fieldservicesystemjobs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Field Service System Job (msdyn_fieldservicesystemjob) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Field Service System Job (msdyn_fieldservicesystemjob) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Field Service System Job** |
| **DisplayCollectionName** | **Field Service System Jobs** |
| **SchemaName** | `msdyn_fieldservicesystemjob` |
| **CollectionSchemaName** | `msdyn_fieldservicesystemjobs` |
| **EntitySetName** | `msdyn_fieldservicesystemjobs`|
| **LogicalName** | `msdyn_fieldservicesystemjob` |
| **LogicalCollectionName** | `msdyn_fieldservicesystemjobs` |
| **PrimaryIdAttribute** | `msdyn_fieldservicesystemjobid` |
| **PrimaryNameAttribute** |`msdyn_jobname` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ConditionCode](#BKMK_msdyn_ConditionCode)
- [msdyn_ExceptionMessage](#BKMK_msdyn_ExceptionMessage)
- [msdyn_ExceptionTrace](#BKMK_msdyn_ExceptionTrace)
- [msdyn_fieldservicesystemjobId](#BKMK_msdyn_fieldservicesystemjobId)
- [msdyn_InputParameter](#BKMK_msdyn_InputParameter)
- [msdyn_InputParameterType](#BKMK_msdyn_InputParameterType)
- [msdyn_jobname](#BKMK_msdyn_jobname)
- [msdyn_JobStatus](#BKMK_msdyn_JobStatus)
- [msdyn_JobType](#BKMK_msdyn_JobType)
- [msdyn_OutputParameter](#BKMK_msdyn_OutputParameter)
- [msdyn_OutputParameterType](#BKMK_msdyn_OutputParameterType)
- [msdyn_OwnerId](#BKMK_msdyn_OwnerId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

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

### <a name="BKMK_msdyn_ConditionCode"></a> msdyn_ConditionCode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Condition Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conditioncode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ExceptionMessage"></a> msdyn_ExceptionMessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Exception Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_exceptionmessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyn_ExceptionTrace"></a> msdyn_ExceptionTrace

|Property|Value|
|---|---|
|Description||
|DisplayName|**Exception Trace**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_exceptiontrace`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_fieldservicesystemjobId"></a> msdyn_fieldservicesystemjobId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Field Service System Job**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldservicesystemjobid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_InputParameter"></a> msdyn_InputParameter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Input Parameter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inputparameter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_InputParameterType"></a> msdyn_InputParameterType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Input Parameter Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inputparametertype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_parametertype`|

#### msdyn_InputParameterType Choices/Options

|Value|Label|
|---|---|
|690970000|**String List**|
|690970001|**Json**|
|690970002|**Xml**|

### <a name="BKMK_msdyn_jobname"></a> msdyn_jobname

|Property|Value|
|---|---|
|Description|**Type a name for the job.**|
|DisplayName|**Type a name for the job.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyn_JobStatus"></a> msdyn_JobStatus

|Property|Value|
|---|---|
|Description|**Enter the status of the job.**|
|DisplayName|**Job Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970002|
|GlobalChoiceName|`msdyn_jobstatus`|

#### msdyn_JobStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Pending**|
|690970001|**In Progress**|
|690970002|**Completed**|
|690970003|**Failed**|

### <a name="BKMK_msdyn_JobType"></a> msdyn_JobType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Job Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobtype`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_OutputParameter"></a> msdyn_OutputParameter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Output Parameter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outputparameter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_OutputParameterType"></a> msdyn_OutputParameterType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Output Parameter Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_outputparametertype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_parametertype`|

#### msdyn_OutputParameterType Choices/Options

|Value|Label|
|---|---|
|690970000|**String List**|
|690970001|**Json**|
|690970002|**Xml**|

### <a name="BKMK_msdyn_OwnerId"></a> msdyn_OwnerId

|Property|Value|
|---|---|
|Description|**Shows the user associated with the field service system job.**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ownerid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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
|Description|**Status of the Field Service System Job**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_fieldservicesystemjob_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Shows the reason for the status of the field service system job.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_fieldservicesystemjob_statuscode`|

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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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

- [lk_msdyn_fieldservicesystemjob_createdby](#BKMK_lk_msdyn_fieldservicesystemjob_createdby)
- [lk_msdyn_fieldservicesystemjob_createdonbehalfby](#BKMK_lk_msdyn_fieldservicesystemjob_createdonbehalfby)
- [lk_msdyn_fieldservicesystemjob_modifiedby](#BKMK_lk_msdyn_fieldservicesystemjob_modifiedby)
- [lk_msdyn_fieldservicesystemjob_modifiedonbehalfby](#BKMK_lk_msdyn_fieldservicesystemjob_modifiedonbehalfby)
- [msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId](#BKMK_msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId)
- [organization_msdyn_fieldservicesystemjob](#BKMK_organization_msdyn_fieldservicesystemjob)

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_createdby"></a> lk_msdyn_fieldservicesystemjob_createdby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicesystemjob_createdby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_createdonbehalfby"></a> lk_msdyn_fieldservicesystemjob_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicesystemjob_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_modifiedby"></a> lk_msdyn_fieldservicesystemjob_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicesystemjob_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_modifiedonbehalfby"></a> lk_msdyn_fieldservicesystemjob_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_fieldservicesystemjob_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId"></a> msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId](systemuser.md#BKMK_msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_ownerid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_fieldservicesystemjob"></a> organization_msdyn_fieldservicesystemjob

One-To-Many Relationship: [organization organization_msdyn_fieldservicesystemjob](organization.md#BKMK_organization_msdyn_fieldservicesystemjob)

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

- [msdyn_fieldservicesystemjob_AsyncOperations](#BKMK_msdyn_fieldservicesystemjob_AsyncOperations)
- [msdyn_fieldservicesystemjob_BulkDeleteFailures](#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures)
- [msdyn_fieldservicesystemjob_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders)
- [msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicesystemjob_ProcessSession](#BKMK_msdyn_fieldservicesystemjob_ProcessSession)
- [msdyn_fieldservicesystemjob_SyncErrors](#BKMK_msdyn_fieldservicesystemjob_SyncErrors)

### <a name="BKMK_msdyn_fieldservicesystemjob_AsyncOperations"></a> msdyn_fieldservicesystemjob_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_fieldservicesystemjob_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldservicesystemjob_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicesystemjob_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures"></a> msdyn_fieldservicesystemjob_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_fieldservicesystemjob_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicesystemjob_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders"></a> msdyn_fieldservicesystemjob_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_fieldservicesystemjob_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicesystemjob_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicesystemjob_ProcessSession"></a> msdyn_fieldservicesystemjob_ProcessSession

Many-To-One Relationship: [processsession msdyn_fieldservicesystemjob_ProcessSession](processsession.md#BKMK_msdyn_fieldservicesystemjob_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicesystemjob_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_fieldservicesystemjob_SyncErrors"></a> msdyn_fieldservicesystemjob_SyncErrors

Many-To-One Relationship: [syncerror msdyn_fieldservicesystemjob_SyncErrors](syncerror.md#BKMK_msdyn_fieldservicesystemjob_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicesystemjob_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

