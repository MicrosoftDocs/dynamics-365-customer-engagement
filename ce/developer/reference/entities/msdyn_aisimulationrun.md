---
title: "AI Simulation Run (msdyn_aisimulationrun) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the AI Simulation Run (msdyn_aisimulationrun) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AI Simulation Run (msdyn_aisimulationrun) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the AI Simulation Run (msdyn_aisimulationrun) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_aisimulationruns(*msdyn_aisimulationrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_aisimulationruns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_aisimulationruns(*msdyn_aisimulationrunid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_aisimulationruns(*msdyn_aisimulationrunid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_aisimulationruns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_aisimulationruns(*msdyn_aisimulationrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_aisimulationruns(*msdyn_aisimulationrunid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_aisimulationruns(*msdyn_aisimulationrunid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the AI Simulation Run (msdyn_aisimulationrun) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **AI Simulation Run** |
| **DisplayCollectionName** | **AI Simulation Runs** |
| **SchemaName** | `msdyn_aisimulationrun` |
| **CollectionSchemaName** | `msdyn_aisimulationruns` |
| **EntitySetName** | `msdyn_aisimulationruns`|
| **LogicalName** | `msdyn_aisimulationrun` |
| **LogicalCollectionName** | `msdyn_aisimulationruns` |
| **PrimaryIdAttribute** | `msdyn_aisimulationrunid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_aisimulationrunId](#BKMK_msdyn_aisimulationrunId)
- [msdyn_completedon](#BKMK_msdyn_completedon)
- [msdyn_conditionexpressionxml](#BKMK_msdyn_conditionexpressionxml)
- [msdyn_entitylogicalname](#BKMK_msdyn_entitylogicalname)
- [msdyn_mode](#BKMK_msdyn_mode)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_recordids](#BKMK_msdyn_recordids)
- [msdyn_simulationarea](#BKMK_msdyn_simulationarea)
- [msdyn_simulationcriteria](#BKMK_msdyn_simulationcriteria)
- [msdyn_simulationdatasource](#BKMK_msdyn_simulationdatasource)
- [msdyn_simulationscenarios](#BKMK_msdyn_simulationscenarios)
- [msdyn_startedon](#BKMK_msdyn_startedon)
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

### <a name="BKMK_msdyn_aisimulationrunId"></a> msdyn_aisimulationrunId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**aisimulationrun**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_aisimulationrunid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_completedon"></a> msdyn_completedon

|Property|Value|
|---|---|
|Description||
|DisplayName|**Run Completed On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_completedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_conditionexpressionxml"></a> msdyn_conditionexpressionxml

|Property|Value|
|---|---|
|Description||
|DisplayName|**Condition Expression Xml**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_conditionexpressionxml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_entitylogicalname"></a> msdyn_entitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity Logical Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_entitylogicalname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_mode"></a> msdyn_mode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Mode**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_mode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_aisimulationrun_msdyn_mode`|

#### msdyn_mode Choices/Options

|Value|Label|
|---|---|
|100230000|**Simulation**|
|100230001|**Shadow**|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_recordids"></a> msdyn_recordids

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record Ids**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_recordids`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_simulationarea"></a> msdyn_simulationarea

|Property|Value|
|---|---|
|Description||
|DisplayName|**Simulation Area**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationarea`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_aisimulationrun_msdyn_simulationarea`|

#### msdyn_simulationarea Choices/Options

|Value|Label|
|---|---|
|100230000|**Quality Evaluation Agent**|
|100230001|**Case Management Agent**|
|100230002|**Governance Agent**|
|100230003|**Email Classification**|
|100230004|**Email Resolution**|

### <a name="BKMK_msdyn_simulationcriteria"></a> msdyn_simulationcriteria

|Property|Value|
|---|---|
|Description||
|DisplayName|**Simulation Criteria**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationcriteria`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_simulationdatasource"></a> msdyn_simulationdatasource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Simulation Data Source**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationdatasource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aisimulationrun_msdyn_simulationdatasource`|

#### msdyn_simulationdatasource Choices/Options

|Value|Label|
|---|---|
|100230000|**Excel Upload**|
|100230001|**Organization Records**|

### <a name="BKMK_msdyn_simulationscenarios"></a> msdyn_simulationscenarios

|Property|Value|
|---|---|
|Description||
|DisplayName|**Simulation Scenarios**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationscenarios`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aisimulationrun_msdyn_simulationscenarios`|

#### msdyn_simulationscenarios Choices/Options

|Value|Label|
|---|---|
|100000000|**Evaluation Criteria**|
|100000001|**Enrich**|
|100000002|**CRA**|
|100000003|**Follow-up & Closure**|
|100000004|**Guardrail**|
|100000005|**Email Classification**|
|100000006|**Email Resolution**|

### <a name="BKMK_msdyn_startedon"></a> msdyn_startedon

|Property|Value|
|---|---|
|Description||
|DisplayName|**Run Started On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_startedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|Description|**Status of the aisimulationrun**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aisimulationrun_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Not Started**<br />DefaultStatus: 1<br />InvariantName: `Not Started`|
|1|Label: **In Progress**<br />DefaultStatus: 2<br />InvariantName: `In Progress`|
|2|Label: **Completed**<br />DefaultStatus: 3<br />InvariantName: `Completed`|
|3|Label: **Failed**<br />DefaultStatus: 4<br />InvariantName: `Failed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the aisimulationrun**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_aisimulationrun_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Not Started**<br />State:0<br />TransitionData: None|
|2|Label: **In Progress**<br />State:1<br />TransitionData: None|
|3|Label: **Completed**<br />State:2<br />TransitionData: None|
|4|Label: **Failed**<br />State:3<br />TransitionData: None|

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
- [msdyn_simulationinputfile](#BKMK_msdyn_simulationinputfile)
- [msdyn_simulationinputfile_Name](#BKMK_msdyn_simulationinputfile_Name)
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

### <a name="BKMK_msdyn_simulationinputfile"></a> msdyn_simulationinputfile

|Property|Value|
|---|---|
|Description|**File containing simulation input data (maximum 32,768 KB)**|
|DisplayName|**Simulation Input File**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationinputfile`|
|RequiredLevel|None|
|Type|File|
|MaxSizeInKB|32768|

### <a name="BKMK_msdyn_simulationinputfile_Name"></a> msdyn_simulationinputfile_Name

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationinputfile_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

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

- [business_unit_msdyn_aisimulationrun](#BKMK_business_unit_msdyn_aisimulationrun)
- [FileAttachment_msdyn_aisimulationrun_msdyn_simulationinputfile](#BKMK_FileAttachment_msdyn_aisimulationrun_msdyn_simulationinputfile)
- [lk_msdyn_aisimulationrun_createdby](#BKMK_lk_msdyn_aisimulationrun_createdby)
- [lk_msdyn_aisimulationrun_createdonbehalfby](#BKMK_lk_msdyn_aisimulationrun_createdonbehalfby)
- [lk_msdyn_aisimulationrun_modifiedby](#BKMK_lk_msdyn_aisimulationrun_modifiedby)
- [lk_msdyn_aisimulationrun_modifiedonbehalfby](#BKMK_lk_msdyn_aisimulationrun_modifiedonbehalfby)
- [owner_msdyn_aisimulationrun](#BKMK_owner_msdyn_aisimulationrun)
- [team_msdyn_aisimulationrun](#BKMK_team_msdyn_aisimulationrun)
- [user_msdyn_aisimulationrun](#BKMK_user_msdyn_aisimulationrun)

### <a name="BKMK_business_unit_msdyn_aisimulationrun"></a> business_unit_msdyn_aisimulationrun

One-To-Many Relationship: [businessunit business_unit_msdyn_aisimulationrun](businessunit.md#BKMK_business_unit_msdyn_aisimulationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_FileAttachment_msdyn_aisimulationrun_msdyn_simulationinputfile"></a> FileAttachment_msdyn_aisimulationrun_msdyn_simulationinputfile

One-To-Many Relationship: [fileattachment FileAttachment_msdyn_aisimulationrun_msdyn_simulationinputfile](fileattachment.md#BKMK_FileAttachment_msdyn_aisimulationrun_msdyn_simulationinputfile)

|Property|Value|
|---|---|
|ReferencedEntity|`fileattachment`|
|ReferencedAttribute|`fileattachmentid`|
|ReferencingAttribute|`msdyn_simulationinputfile`|
|ReferencingEntityNavigationPropertyName|`msdyn_simulationinputfile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aisimulationrun_createdby"></a> lk_msdyn_aisimulationrun_createdby

One-To-Many Relationship: [systemuser lk_msdyn_aisimulationrun_createdby](systemuser.md#BKMK_lk_msdyn_aisimulationrun_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aisimulationrun_createdonbehalfby"></a> lk_msdyn_aisimulationrun_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aisimulationrun_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_aisimulationrun_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aisimulationrun_modifiedby"></a> lk_msdyn_aisimulationrun_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_aisimulationrun_modifiedby](systemuser.md#BKMK_lk_msdyn_aisimulationrun_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aisimulationrun_modifiedonbehalfby"></a> lk_msdyn_aisimulationrun_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aisimulationrun_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_aisimulationrun_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_aisimulationrun"></a> owner_msdyn_aisimulationrun

One-To-Many Relationship: [owner owner_msdyn_aisimulationrun](owner.md#BKMK_owner_msdyn_aisimulationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_aisimulationrun"></a> team_msdyn_aisimulationrun

One-To-Many Relationship: [team team_msdyn_aisimulationrun](team.md#BKMK_team_msdyn_aisimulationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_aisimulationrun"></a> user_msdyn_aisimulationrun

One-To-Many Relationship: [systemuser user_msdyn_aisimulationrun](systemuser.md#BKMK_user_msdyn_aisimulationrun)

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

- [msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun](#BKMK_msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun)
- [msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult](#BKMK_msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult)
- [msdyn_aisimulationrun_AsyncOperations](#BKMK_msdyn_aisimulationrun_AsyncOperations)
- [msdyn_aisimulationrun_BulkDeleteFailures](#BKMK_msdyn_aisimulationrun_BulkDeleteFailures)
- [msdyn_aisimulationrun_FileAttachments](#BKMK_msdyn_aisimulationrun_FileAttachments)
- [msdyn_aisimulationrun_MailboxTrackingFolders](#BKMK_msdyn_aisimulationrun_MailboxTrackingFolders)
- [msdyn_aisimulationrun_PrincipalObjectAttributeAccesses](#BKMK_msdyn_aisimulationrun_PrincipalObjectAttributeAccesses)
- [msdyn_aisimulationrun_ProcessSession](#BKMK_msdyn_aisimulationrun_ProcessSession)
- [msdyn_aisimulationrun_SyncErrors](#BKMK_msdyn_aisimulationrun_SyncErrors)
- [msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun](#BKMK_msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun)

### <a name="BKMK_msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun"></a> msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun

Many-To-One Relationship: [msdyn_aidescriptionrun msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun](msdyn_aidescriptionrun.md#BKMK_msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aidescriptionrun`|
|ReferencingAttribute|`msdyn_aisimulationrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aidescriptionrun_msdyn_aisimulationrunid_msdyn_aisimulationrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult"></a> msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult

Many-To-One Relationship: [msdyn_aisimulationresult msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult](msdyn_aisimulationresult.md#BKMK_msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aisimulationresult`|
|ReferencingAttribute|`msdyn_aisimulationrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aisimulationrun_AsyncOperations"></a> msdyn_aisimulationrun_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_aisimulationrun_AsyncOperations](asyncoperation.md#BKMK_msdyn_aisimulationrun_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aisimulationrun_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aisimulationrun_BulkDeleteFailures"></a> msdyn_aisimulationrun_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_aisimulationrun_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_aisimulationrun_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aisimulationrun_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aisimulationrun_FileAttachments"></a> msdyn_aisimulationrun_FileAttachments

Many-To-One Relationship: [fileattachment msdyn_aisimulationrun_FileAttachments](fileattachment.md#BKMK_msdyn_aisimulationrun_FileAttachments)

|Property|Value|
|---|---|
|ReferencingEntity|`fileattachment`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aisimulationrun_FileAttachments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aisimulationrun_MailboxTrackingFolders"></a> msdyn_aisimulationrun_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_aisimulationrun_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_aisimulationrun_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aisimulationrun_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aisimulationrun_PrincipalObjectAttributeAccesses"></a> msdyn_aisimulationrun_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_aisimulationrun_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_aisimulationrun_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aisimulationrun_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aisimulationrun_ProcessSession"></a> msdyn_aisimulationrun_ProcessSession

Many-To-One Relationship: [processsession msdyn_aisimulationrun_ProcessSession](processsession.md#BKMK_msdyn_aisimulationrun_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aisimulationrun_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_aisimulationrun_SyncErrors"></a> msdyn_aisimulationrun_SyncErrors

Many-To-One Relationship: [syncerror msdyn_aisimulationrun_SyncErrors](syncerror.md#BKMK_msdyn_aisimulationrun_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_aisimulationrun_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun"></a> msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun

Many-To-One Relationship: [msdyn_evaluationsimulationrun msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun](msdyn_evaluationsimulationrun.md#BKMK_msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_evaluationsimulationrun`|
|ReferencingAttribute|`msdyn_simulationrunid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_evaluationsimulationrun_simulationrunid_msdyn_aisimulationrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

