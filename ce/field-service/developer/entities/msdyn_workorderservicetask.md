---
title: "Work Order Service Task (msdyn_workorderservicetask) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Work Order Service Task (msdyn_workorderservicetask) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Work Order Service Task (msdyn_workorderservicetask) table/entity reference

Store service tasks that are to be performed for this work order

## Messages

The following table lists the messages for the Work Order Service Task (msdyn_workorderservicetask) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_workorderservicetasks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_workorderservicetasks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Work Order Service Task (msdyn_workorderservicetask) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Work Order Service Task (msdyn_workorderservicetask) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Work Order Service Task** |
| **DisplayCollectionName** | **Work Order Service Tasks** |
| **SchemaName** | `msdyn_workorderservicetask` |
| **CollectionSchemaName** | `msdyn_workorderservicetasks` |
| **EntitySetName** | `msdyn_workorderservicetasks`|
| **LogicalName** | `msdyn_workorderservicetask` |
| **LogicalCollectionName** | `msdyn_workorderservicetasks` |
| **PrimaryIdAttribute** | `msdyn_workorderservicetaskid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ActualDuration](#BKMK_msdyn_ActualDuration)
- [msdyn_AgreementBookingServiceTask](#BKMK_msdyn_AgreementBookingServiceTask)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_Inspection](#BKMK_msdyn_Inspection)
- [msdyn_inspectiondefinitionid](#BKMK_msdyn_inspectiondefinitionid)
- [msdyn_InspectionEnabled](#BKMK_msdyn_InspectionEnabled)
- [msdyn_inspectionresponseid](#BKMK_msdyn_inspectionresponseid)
- [msdyn_InspectionResult](#BKMK_msdyn_InspectionResult)
- [msdyn_inspectiontaskresult](#BKMK_msdyn_inspectiontaskresult)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PercentComplete](#BKMK_msdyn_PercentComplete)
- [msdyn_surveyboundedoutput](#BKMK_msdyn_surveyboundedoutput)
- [msdyn_TaskType](#BKMK_msdyn_TaskType)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_WorkOrderIncident](#BKMK_msdyn_WorkOrderIncident)
- [msdyn_workorderservicetaskId](#BKMK_msdyn_workorderservicetaskId)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ActualDuration"></a> msdyn_ActualDuration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Actual Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actualduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_AgreementBookingServiceTask"></a> msdyn_AgreementBookingServiceTask

|Property|Value|
|---|---|
|Description|**Agreement Booking Service Task linked to this Work Order Service Task**|
|DisplayName|**Agreement Booking Service Task**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementbookingservicetask`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreementbookingservicetask|

### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|---|---|
|Description|**Unique identifier for Resource Booking associated with Work Order Service Task.**|
|DisplayName|**Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_booking`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresourcebooking|

### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|---|---|
|Description|**Unique identifier for Customer Asset associated with Work Order Service Task.**|
|DisplayName|**Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_EstimatedDuration"></a> msdyn_EstimatedDuration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Estimated Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Inspection"></a> msdyn_Inspection

|Property|Value|
|---|---|
|Description|**Unique identifier for Inspection Template associated with Work Order Service Task.**|
|DisplayName|**Inspection Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspection`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_inspection|

### <a name="BKMK_msdyn_inspectiondefinitionid"></a> msdyn_inspectiondefinitionid

|Property|Value|
|---|---|
|Description|**Unique identifier for Inspection Definition associated with Work Order Service Task.**|
|DisplayName|**Inspection Template Version Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectiondefinitionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_inspectiondefinition|

### <a name="BKMK_msdyn_InspectionEnabled"></a> msdyn_InspectionEnabled

|Property|Value|
|---|---|
|Description|**Depicts whether inspection template is enabled for Work Order Service Task Type.**|
|DisplayName|**Has Inspection**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectionenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_workorderservicetask_msdyn_inspectionenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_inspectionresponseid"></a> msdyn_inspectionresponseid

|Property|Value|
|---|---|
|Description|**Unique identifier for Inspection Response associated with Work Order Service Task.**|
|DisplayName|**Inspection Response Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectionresponseid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_inspectionresponse|

### <a name="BKMK_msdyn_InspectionResult"></a> msdyn_InspectionResult

|Property|Value|
|---|---|
|Description|**Output of the Inspection.**|
|DisplayName|**Inspection Result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectionresult`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_msdyn_workorderservicetask_msdyn_inspectionresult`|

#### msdyn_InspectionResult Choices/Options

|Value|Label|
|---|---|
|100000000|**Pass**|
|100000001|**Fail**|
|100000002|**Invalid**|

### <a name="BKMK_msdyn_inspectiontaskresult"></a> msdyn_inspectiontaskresult

|Property|Value|
|---|---|
|Description|**Depicts the result of Inspection that the user enters**|
|DisplayName|**Result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectiontaskresult`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_inspectionresult`|

#### msdyn_inspectiontaskresult Choices/Options

|Value|Label|
|---|---|
|192350000|**Pass**|
|192350001|**Fail**|
|192350002|**Partial Success**|
|192350003|**NA**|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

|Property|Value|
|---|---|
|Description|**Shows the order of this task within the work order service tasks.**|
|DisplayName|**Line Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lineorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_PercentComplete"></a> msdyn_PercentComplete

|Property|Value|
|---|---|
|Description||
|DisplayName|**% Complete**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_percentcomplete`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|100|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_surveyboundedoutput"></a> msdyn_surveyboundedoutput

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**SurveyControl**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_surveyboundedoutput`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_TaskType"></a> msdyn_TaskType

|Property|Value|
|---|---|
|Description|**Unique identifier for Service Task Type associated with Work Order Service Task.**|
|DisplayName|**Task Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tasktype`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_servicetasktype|

### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order associated with Work Order Service Task.**|
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorder`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_msdyn_WorkOrderIncident"></a> msdyn_WorkOrderIncident

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order Incident associated with Work Order Service Task.**|
|DisplayName|**Work Order Incident**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderincident`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorderincident|

### <a name="BKMK_msdyn_workorderservicetaskId"></a> msdyn_workorderservicetaskId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Work Order Service Task**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderservicetaskid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Work Order Service Task**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorderservicetask_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Work Order Service Task**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorderservicetask_statuscode`|

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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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

- [business_unit_msdyn_workorderservicetask](#BKMK_business_unit_msdyn_workorderservicetask)
- [lk_msdyn_workorderservicetask_createdby](#BKMK_lk_msdyn_workorderservicetask_createdby)
- [lk_msdyn_workorderservicetask_createdonbehalfby](#BKMK_lk_msdyn_workorderservicetask_createdonbehalfby)
- [lk_msdyn_workorderservicetask_modifiedby](#BKMK_lk_msdyn_workorderservicetask_modifiedby)
- [lk_msdyn_workorderservicetask_modifiedonbehalfby](#BKMK_lk_msdyn_workorderservicetask_modifiedonbehalfby)
- [msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking)
- [msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask](#BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask)
- [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)
- [msdyn_msdyn_inspection_msdyn_workorderservicetask_Inspection](#BKMK_msdyn_msdyn_inspection_msdyn_workorderservicetask_Inspection)
- [msdyn_msdyn_inspectiondefinition_msdyn_workorderservicetask_inspectiondefinitionid](#BKMK_msdyn_msdyn_inspectiondefinition_msdyn_workorderservicetask_inspectiondefinitionid)
- [msdyn_msdyn_inspectionresponse_msdyn_workorderservicetask_inspectionresponseid](#BKMK_msdyn_msdyn_inspectionresponse_msdyn_workorderservicetask_inspectionresponseid)
- [msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType](#BKMK_msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType)
- [msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder)
- [msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident)
- [owner_msdyn_workorderservicetask](#BKMK_owner_msdyn_workorderservicetask)
- [team_msdyn_workorderservicetask](#BKMK_team_msdyn_workorderservicetask)
- [user_msdyn_workorderservicetask](#BKMK_user_msdyn_workorderservicetask)

### <a name="BKMK_business_unit_msdyn_workorderservicetask"></a> business_unit_msdyn_workorderservicetask

One-To-Many Relationship: [businessunit business_unit_msdyn_workorderservicetask](businessunit.md#BKMK_business_unit_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderservicetask_createdby"></a> lk_msdyn_workorderservicetask_createdby

One-To-Many Relationship: [systemuser lk_msdyn_workorderservicetask_createdby](systemuser.md#BKMK_lk_msdyn_workorderservicetask_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderservicetask_createdonbehalfby"></a> lk_msdyn_workorderservicetask_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workorderservicetask_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderservicetask_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderservicetask_modifiedby"></a> lk_msdyn_workorderservicetask_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_workorderservicetask_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderservicetask_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderservicetask_modifiedonbehalfby"></a> lk_msdyn_workorderservicetask_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workorderservicetask_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderservicetask_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking

One-To-Many Relationship: [bookableresourcebooking msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencingEntityNavigationPropertyName|`msdyn_booking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask"></a> msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask

One-To-Many Relationship: [msdyn_agreementbookingservicetask msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservicetask`|
|ReferencedAttribute|`msdyn_agreementbookingservicetaskid`|
|ReferencingAttribute|`msdyn_agreementbookingservicetask`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreementbookingservicetask`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_inspection_msdyn_workorderservicetask_Inspection"></a> msdyn_msdyn_inspection_msdyn_workorderservicetask_Inspection

One-To-Many Relationship: [msdyn_inspection msdyn_msdyn_inspection_msdyn_workorderservicetask_Inspection](msdyn_inspection.md#BKMK_msdyn_msdyn_inspection_msdyn_workorderservicetask_Inspection)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspection`|
|ReferencedAttribute|`msdyn_inspectionid`|
|ReferencingAttribute|`msdyn_inspection`|
|ReferencingEntityNavigationPropertyName|`msdyn_Inspection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_inspectiondefinition_msdyn_workorderservicetask_inspectiondefinitionid"></a> msdyn_msdyn_inspectiondefinition_msdyn_workorderservicetask_inspectiondefinitionid

One-To-Many Relationship: [msdyn_inspectiondefinition msdyn_msdyn_inspectiondefinition_msdyn_workorderservicetask_inspectiondefinitionid](msdyn_inspectiondefinition.md#BKMK_msdyn_msdyn_inspectiondefinition_msdyn_workorderservicetask_inspectiondefinitionid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectiondefinition`|
|ReferencedAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingAttribute|`msdyn_inspectiondefinitionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_inspectiondefinitionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_inspectionresponse_msdyn_workorderservicetask_inspectionresponseid"></a> msdyn_msdyn_inspectionresponse_msdyn_workorderservicetask_inspectionresponseid

One-To-Many Relationship: [msdyn_inspectionresponse msdyn_msdyn_inspectionresponse_msdyn_workorderservicetask_inspectionresponseid](msdyn_inspectionresponse.md#BKMK_msdyn_msdyn_inspectionresponse_msdyn_workorderservicetask_inspectionresponseid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_inspectionresponse`|
|ReferencedAttribute|`msdyn_inspectionresponseid`|
|ReferencingAttribute|`msdyn_inspectionresponseid`|
|ReferencingEntityNavigationPropertyName|`msdyn_inspectionresponseid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType"></a> msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType

One-To-Many Relationship: [msdyn_servicetasktype msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType](msdyn_servicetasktype.md#BKMK_msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_servicetasktype`|
|ReferencedAttribute|`msdyn_servicetasktypeid`|
|ReferencingAttribute|`msdyn_tasktype`|
|ReferencingEntityNavigationPropertyName|`msdyn_tasktype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident

One-To-Many Relationship: [msdyn_workorderincident msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`msdyn_workorderincident`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_workorderservicetask"></a> owner_msdyn_workorderservicetask

One-To-Many Relationship: [owner owner_msdyn_workorderservicetask](owner.md#BKMK_owner_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_workorderservicetask"></a> team_msdyn_workorderservicetask

One-To-Many Relationship: [team team_msdyn_workorderservicetask](team.md#BKMK_team_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_workorderservicetask"></a> user_msdyn_workorderservicetask

One-To-Many Relationship: [systemuser user_msdyn_workorderservicetask](systemuser.md#BKMK_user_msdyn_workorderservicetask)

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

- [msdyn_workorderservicetask_ActivityPointers](#BKMK_msdyn_workorderservicetask_ActivityPointers)
- [msdyn_workorderservicetask_adx_inviteredemptions](#BKMK_msdyn_workorderservicetask_adx_inviteredemptions)
- [msdyn_workorderservicetask_adx_portalcomments](#BKMK_msdyn_workorderservicetask_adx_portalcomments)
- [msdyn_workorderservicetask_Annotations](#BKMK_msdyn_workorderservicetask_Annotations)
- [msdyn_workorderservicetask_Appointments](#BKMK_msdyn_workorderservicetask_Appointments)
- [msdyn_workorderservicetask_AsyncOperations](#BKMK_msdyn_workorderservicetask_AsyncOperations)
- [msdyn_workorderservicetask_BulkDeleteFailures](#BKMK_msdyn_workorderservicetask_BulkDeleteFailures)
- [msdyn_workorderservicetask_chats](#BKMK_msdyn_workorderservicetask_chats)
- [msdyn_workorderservicetask_connections1](#BKMK_msdyn_workorderservicetask_connections1)
- [msdyn_workorderservicetask_connections2](#BKMK_msdyn_workorderservicetask_connections2)
- [msdyn_workorderservicetask_DuplicateBaseRecord](#BKMK_msdyn_workorderservicetask_DuplicateBaseRecord)
- [msdyn_workorderservicetask_DuplicateMatchingRecord](#BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord)
- [msdyn_workorderservicetask_Emails](#BKMK_msdyn_workorderservicetask_Emails)
- [msdyn_workorderservicetask_Faxes](#BKMK_msdyn_workorderservicetask_Faxes)
- [msdyn_workorderservicetask_Letters](#BKMK_msdyn_workorderservicetask_Letters)
- [msdyn_workorderservicetask_MailboxTrackingFolders](#BKMK_msdyn_workorderservicetask_MailboxTrackingFolders)
- [msdyn_workorderservicetask_msdyn_bookingalerts](#BKMK_msdyn_workorderservicetask_msdyn_bookingalerts)
- [msdyn_workorderservicetask_msdyn_copilottranscripts](#BKMK_msdyn_workorderservicetask_msdyn_copilottranscripts)
- [msdyn_workorderservicetask_msdyn_ocliveworkitems](#BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems)
- [msdyn_workorderservicetask_msdyn_ocsessions](#BKMK_msdyn_workorderservicetask_msdyn_ocsessions)
- [msdyn_workorderservicetask_msfp_alerts](#BKMK_msdyn_workorderservicetask_msfp_alerts)
- [msdyn_workorderservicetask_msfp_surveyinvites](#BKMK_msdyn_workorderservicetask_msfp_surveyinvites)
- [msdyn_workorderservicetask_msfp_surveyresponses](#BKMK_msdyn_workorderservicetask_msfp_surveyresponses)
- [msdyn_workorderservicetask_PhoneCalls](#BKMK_msdyn_workorderservicetask_PhoneCalls)
- [msdyn_workorderservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_workorderservicetask_ProcessSession](#BKMK_msdyn_workorderservicetask_ProcessSession)
- [msdyn_workorderservicetask_QueueItems](#BKMK_msdyn_workorderservicetask_QueueItems)
- [msdyn_workorderservicetask_RecurringAppointmentMasters](#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters)
- [msdyn_workorderservicetask_ServiceAppointments](#BKMK_msdyn_workorderservicetask_ServiceAppointments)
- [msdyn_workorderservicetask_SharePointDocumentLocations](#BKMK_msdyn_workorderservicetask_SharePointDocumentLocations)
- [msdyn_workorderservicetask_SocialActivities](#BKMK_msdyn_workorderservicetask_SocialActivities)
- [msdyn_workorderservicetask_SyncErrors](#BKMK_msdyn_workorderservicetask_SyncErrors)
- [msdyn_workorderservicetask_Tasks](#BKMK_msdyn_workorderservicetask_Tasks)

### <a name="BKMK_msdyn_workorderservicetask_ActivityPointers"></a> msdyn_workorderservicetask_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_workorderservicetask_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderservicetask_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_adx_inviteredemptions"></a> msdyn_workorderservicetask_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_workorderservicetask_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_workorderservicetask_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_adx_portalcomments"></a> msdyn_workorderservicetask_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_workorderservicetask_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_workorderservicetask_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_Annotations"></a> msdyn_workorderservicetask_Annotations

Many-To-One Relationship: [annotation msdyn_workorderservicetask_Annotations](annotation.md#BKMK_msdyn_workorderservicetask_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_Appointments"></a> msdyn_workorderservicetask_Appointments

Many-To-One Relationship: [appointment msdyn_workorderservicetask_Appointments](appointment.md#BKMK_msdyn_workorderservicetask_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_AsyncOperations"></a> msdyn_workorderservicetask_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_workorderservicetask_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderservicetask_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_BulkDeleteFailures"></a> msdyn_workorderservicetask_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_workorderservicetask_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderservicetask_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_chats"></a> msdyn_workorderservicetask_chats

Many-To-One Relationship: [chat msdyn_workorderservicetask_chats](chat.md#BKMK_msdyn_workorderservicetask_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_connections1"></a> msdyn_workorderservicetask_connections1

Many-To-One Relationship: [connection msdyn_workorderservicetask_connections1](connection.md#BKMK_msdyn_workorderservicetask_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_connections2"></a> msdyn_workorderservicetask_connections2

Many-To-One Relationship: [connection msdyn_workorderservicetask_connections2](connection.md#BKMK_msdyn_workorderservicetask_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_DuplicateBaseRecord"></a> msdyn_workorderservicetask_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_workorderservicetask_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderservicetask_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord"></a> msdyn_workorderservicetask_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_workorderservicetask_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_Emails"></a> msdyn_workorderservicetask_Emails

Many-To-One Relationship: [email msdyn_workorderservicetask_Emails](email.md#BKMK_msdyn_workorderservicetask_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_Faxes"></a> msdyn_workorderservicetask_Faxes

Many-To-One Relationship: [fax msdyn_workorderservicetask_Faxes](fax.md#BKMK_msdyn_workorderservicetask_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_Letters"></a> msdyn_workorderservicetask_Letters

Many-To-One Relationship: [letter msdyn_workorderservicetask_Letters](letter.md#BKMK_msdyn_workorderservicetask_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_MailboxTrackingFolders"></a> msdyn_workorderservicetask_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_workorderservicetask_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderservicetask_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_msdyn_bookingalerts"></a> msdyn_workorderservicetask_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_workorderservicetask_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderservicetask_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_msdyn_copilottranscripts"></a> msdyn_workorderservicetask_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_workorderservicetask_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_workorderservicetask_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems"></a> msdyn_workorderservicetask_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_workorderservicetask_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_workorderservicetask_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_msdyn_ocsessions"></a> msdyn_workorderservicetask_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_workorderservicetask_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_workorderservicetask_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_msfp_alerts"></a> msdyn_workorderservicetask_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_workorderservicetask_msfp_alerts](msfp_alert.md#BKMK_msdyn_workorderservicetask_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_msfp_surveyinvites"></a> msdyn_workorderservicetask_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_workorderservicetask_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_workorderservicetask_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_msfp_surveyresponses"></a> msdyn_workorderservicetask_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_workorderservicetask_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_workorderservicetask_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_PhoneCalls"></a> msdyn_workorderservicetask_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_workorderservicetask_PhoneCalls](phonecall.md#BKMK_msdyn_workorderservicetask_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_workorderservicetask_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_workorderservicetask_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_ProcessSession"></a> msdyn_workorderservicetask_ProcessSession

Many-To-One Relationship: [processsession msdyn_workorderservicetask_ProcessSession](processsession.md#BKMK_msdyn_workorderservicetask_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_QueueItems"></a> msdyn_workorderservicetask_QueueItems

Many-To-One Relationship: [queueitem msdyn_workorderservicetask_QueueItems](queueitem.md#BKMK_msdyn_workorderservicetask_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters"></a> msdyn_workorderservicetask_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_workorderservicetask_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_ServiceAppointments"></a> msdyn_workorderservicetask_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_workorderservicetask_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderservicetask_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_SharePointDocumentLocations"></a> msdyn_workorderservicetask_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_workorderservicetask_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderservicetask_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_SocialActivities"></a> msdyn_workorderservicetask_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_workorderservicetask_SocialActivities](socialactivity.md#BKMK_msdyn_workorderservicetask_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_SyncErrors"></a> msdyn_workorderservicetask_SyncErrors

Many-To-One Relationship: [syncerror msdyn_workorderservicetask_SyncErrors](syncerror.md#BKMK_msdyn_workorderservicetask_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservicetask_Tasks"></a> msdyn_workorderservicetask_Tasks

Many-To-One Relationship: [task msdyn_workorderservicetask_Tasks](task.md#BKMK_msdyn_workorderservicetask_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservicetask_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

