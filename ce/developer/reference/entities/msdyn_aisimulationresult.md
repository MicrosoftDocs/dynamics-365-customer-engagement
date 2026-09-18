---
title: "AI Simulation Result (msdyn_aisimulationresult) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the AI Simulation Result (msdyn_aisimulationresult) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AI Simulation Result (msdyn_aisimulationresult) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the AI Simulation Result (msdyn_aisimulationresult) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_aisimulationresults(*msdyn_aisimulationresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_aisimulationresults<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_aisimulationresults(*msdyn_aisimulationresultid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_aisimulationresults(*msdyn_aisimulationresultid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_aisimulationresults<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_aisimulationresults(*msdyn_aisimulationresultid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_aisimulationresults(*msdyn_aisimulationresultid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the AI Simulation Result (msdyn_aisimulationresult) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **AI Simulation Result** |
| **DisplayCollectionName** | **AI Simulation Results** |
| **SchemaName** | `msdyn_aisimulationresult` |
| **CollectionSchemaName** | `msdyn_aisimulationresults` |
| **EntitySetName** | `msdyn_aisimulationresults`|
| **LogicalName** | `msdyn_aisimulationresult` |
| **LogicalCollectionName** | `msdyn_aisimulationresults` |
| **PrimaryIdAttribute** | `msdyn_aisimulationresultid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_aisimulationresultId](#BKMK_msdyn_aisimulationresultId)
- [msdyn_aisimulationrunid](#BKMK_msdyn_aisimulationrunid)
- [msdyn_errordetails](#BKMK_msdyn_errordetails)
- [msdyn_inputdata](#BKMK_msdyn_inputdata)
- [msdyn_intentfamily](#BKMK_msdyn_intentfamily)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_regardingentitylogicalname](#BKMK_msdyn_regardingentitylogicalname)
- [msdyn_regardingobjectid](#BKMK_msdyn_regardingobjectid)
- [msdyn_simulationcriteria](#BKMK_msdyn_simulationcriteria)
- [msdyn_simulationresultdetail](#BKMK_msdyn_simulationresultdetail)
- [msdyn_simulationscenario](#BKMK_msdyn_simulationscenario)
- [msdyn_simulationstatus](#BKMK_msdyn_simulationstatus)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdyn_aisimulationresultId"></a> msdyn_aisimulationresultId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**aisimulationresult**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_aisimulationresultid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_aisimulationrunid"></a> msdyn_aisimulationrunid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Simulation Run Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_aisimulationrunid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|msdyn_aisimulationrun|

### <a name="BKMK_msdyn_errordetails"></a> msdyn_errordetails

|Property|Value|
|---|---|
|Description|**Details about any errors that occurred during simulation**|
|DisplayName|**Error Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errordetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_inputdata"></a> msdyn_inputdata

|Property|Value|
|---|---|
|Description||
|DisplayName|**Input Data**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_inputdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_intentfamily"></a> msdyn_intentfamily

|Property|Value|
|---|---|
|Description||
|DisplayName|**Line of Business**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamily`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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

### <a name="BKMK_msdyn_regardingentitylogicalname"></a> msdyn_regardingentitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Regarding Entity Logical Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentitylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_regardingobjectid"></a> msdyn_regardingobjectid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Regarding Object Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_simulationresultdetail"></a> msdyn_simulationresultdetail

|Property|Value|
|---|---|
|Description||
|DisplayName|**Simulation Result Detail**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationresultdetail`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_simulationscenario"></a> msdyn_simulationscenario

|Property|Value|
|---|---|
|Description||
|DisplayName|**Simulation Scenario**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationscenario`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_aisimulationresult_msdyn_simulationscenario`|

#### msdyn_simulationscenario Choices/Options

|Value|Label|
|---|---|
|100000000|**Evaluation Criteria**|
|100000001|**Enrich**|
|100000002|**CRA**|
|100000003|**Follow-up & Closure**|
|100000004|**Guardrail**|
|100000005|**Email Classification**|
|100000006|**Email Resolution**|

### <a name="BKMK_msdyn_simulationstatus"></a> msdyn_simulationstatus

|Property|Value|
|---|---|
|Description|**Status of the simulation**|
|DisplayName|**Simulation Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_simulationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_aisimulationresult_msdyn_simulationstatus`|

#### msdyn_simulationstatus Choices/Options

|Value|Label|
|---|---|
|100230000|**InProgress**|
|100230001|**Success**|
|100230002|**Failed**|
|100230003|**Skipped**|

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

### <a name="BKMK_PartitionId"></a> PartitionId

|Property|Value|
|---|---|
|Description|**Logical partition id. A logical partition consists of a set of records with same partition id.**|
|DisplayName|**Partition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TTLInSeconds"></a> TTLInSeconds

|Property|Value|
|---|---|
|Description|**Time to live in seconds.**|
|DisplayName|**Time to live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ttlinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|


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

- [business_unit_msdyn_aisimulationresult](#BKMK_business_unit_msdyn_aisimulationresult)
- [lk_msdyn_aisimulationresult_createdby](#BKMK_lk_msdyn_aisimulationresult_createdby)
- [lk_msdyn_aisimulationresult_createdonbehalfby](#BKMK_lk_msdyn_aisimulationresult_createdonbehalfby)
- [lk_msdyn_aisimulationresult_modifiedby](#BKMK_lk_msdyn_aisimulationresult_modifiedby)
- [lk_msdyn_aisimulationresult_modifiedonbehalfby](#BKMK_lk_msdyn_aisimulationresult_modifiedonbehalfby)
- [msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult](#BKMK_msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult)
- [owner_msdyn_aisimulationresult](#BKMK_owner_msdyn_aisimulationresult)
- [team_msdyn_aisimulationresult](#BKMK_team_msdyn_aisimulationresult)
- [user_msdyn_aisimulationresult](#BKMK_user_msdyn_aisimulationresult)

### <a name="BKMK_business_unit_msdyn_aisimulationresult"></a> business_unit_msdyn_aisimulationresult

One-To-Many Relationship: [businessunit business_unit_msdyn_aisimulationresult](businessunit.md#BKMK_business_unit_msdyn_aisimulationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aisimulationresult_createdby"></a> lk_msdyn_aisimulationresult_createdby

One-To-Many Relationship: [systemuser lk_msdyn_aisimulationresult_createdby](systemuser.md#BKMK_lk_msdyn_aisimulationresult_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aisimulationresult_createdonbehalfby"></a> lk_msdyn_aisimulationresult_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aisimulationresult_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_aisimulationresult_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aisimulationresult_modifiedby"></a> lk_msdyn_aisimulationresult_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_aisimulationresult_modifiedby](systemuser.md#BKMK_lk_msdyn_aisimulationresult_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_aisimulationresult_modifiedonbehalfby"></a> lk_msdyn_aisimulationresult_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_aisimulationresult_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_aisimulationresult_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult"></a> msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult

One-To-Many Relationship: [msdyn_aisimulationrun msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult](msdyn_aisimulationrun.md#BKMK_msdyn_aisimulationrun_aisimulationrunid_msdyn_aisimulationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_aisimulationrun`|
|ReferencedAttribute|`msdyn_aisimulationrunid`|
|ReferencingAttribute|`msdyn_aisimulationrunid`|
|ReferencingEntityNavigationPropertyName|`msdyn_aisimulationrunid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_aisimulationresult"></a> owner_msdyn_aisimulationresult

One-To-Many Relationship: [owner owner_msdyn_aisimulationresult](owner.md#BKMK_owner_msdyn_aisimulationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_aisimulationresult"></a> team_msdyn_aisimulationresult

One-To-Many Relationship: [team team_msdyn_aisimulationresult](team.md#BKMK_team_msdyn_aisimulationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_aisimulationresult"></a> user_msdyn_aisimulationresult

One-To-Many Relationship: [systemuser user_msdyn_aisimulationresult](systemuser.md#BKMK_user_msdyn_aisimulationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

