---
title: "Opportunity Sales Process (OpportunitySalesProcess) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Opportunity Sales Process (OpportunitySalesProcess) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Opportunity Sales Process (OpportunitySalesProcess) table/entity reference (Microsoft Dynamics 365)

Opportunity Sales Process Business Process Flow

## Messages

The following table lists the messages for the Opportunity Sales Process (OpportunitySalesProcess) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /opportunitysalesprocesses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: False |`GET` /opportunitysalesprocesses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|

## Properties

The following table lists selected properties for the Opportunity Sales Process (OpportunitySalesProcess) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Opportunity Sales Process** |
| **DisplayCollectionName** | **Opportunity Sales Process** |
| **SchemaName** | `OpportunitySalesProcess` |
| **CollectionSchemaName** | `OpportunitySalesProcesses` |
| **EntitySetName** | `opportunitysalesprocesses`|
| **LogicalName** | `opportunitysalesprocess` |
| **LogicalCollectionName** | `opportunitysalesprocesses` |
| **PrimaryIdAttribute** | `businessprocessflowinstanceid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActiveStageId](#BKMK_ActiveStageId)
- [ActiveStageStartedOn](#BKMK_ActiveStageStartedOn)
- [BusinessProcessFlowInstanceId](#BKMK_BusinessProcessFlowInstanceId)
- [CompletedOn](#BKMK_CompletedOn)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OpportunityId](#BKMK_OpportunityId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProcessId](#BKMK_ProcessId)
- [QuoteId](#BKMK_QuoteId)
- [SalesOrderId](#BKMK_SalesOrderId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ActiveStageId"></a> ActiveStageId

|Property|Value|
|---|---|
|Description|**Unique identifier of the active stage for the Business Process Flow instance.**|
|DisplayName|**Active Stage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activestageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|processstage|

### <a name="BKMK_ActiveStageStartedOn"></a> ActiveStageStartedOn

|Property|Value|
|---|---|
|Description|**Date and time when current active stage is started.**|
|DisplayName|**Active Stage Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activestagestartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_BusinessProcessFlowInstanceId"></a> BusinessProcessFlowInstanceId

|Property|Value|
|---|---|
|Description|**Unique identifier for Opportunity Sales Process bpf entity instances**|
|DisplayName|**Opportunity Sales Process Instance Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`businessprocessflowinstanceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_CompletedOn"></a> CompletedOn

|Property|Value|
|---|---|
|Description|**Date and time when Business Process Flow instance is completed.**|
|DisplayName|**Completed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`completedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Process Name.**|
|DisplayName|**Process Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_OpportunityId"></a> OpportunityId

|Property|Value|
|---|---|
|Description|**Unique identifier of the workflow associated to the Business Process Flow instance.**|
|DisplayName|**Opportunity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`opportunityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

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

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Unique identifier of the workflow associated to the Business Process Flow instance.**|
|DisplayName|**Process**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|workflow|

### <a name="BKMK_QuoteId"></a> QuoteId

|Property|Value|
|---|---|
|Description|**Unique identifier of the workflow associated to the Business Process Flow instance.**|
|DisplayName|**Related Quote**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quoteid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|quote|

### <a name="BKMK_SalesOrderId"></a> SalesOrderId

|Property|Value|
|---|---|
|Description|**Unique identifier of the workflow associated to the Business Process Flow instance.**|
|DisplayName|**Related Sales Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesorderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|salesorder|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Shows whether the Delve action record is pending, completed, or tracking.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`opportunitysalesprocess_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the delve action record status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`opportunitysalesprocess_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Finished**<br />State:1<br />TransitionData: None|
|3|Label: **Aborted**<br />State:1<br />TransitionData: None|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.**|
|DisplayName|**Traversed Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Active|
|IsLocalizable|False|
|MaxLength|1250|

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
- [Duration](#BKMK_Duration)
- [ExchangeRate](#BKMK_ExchangeRate)
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

### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|---|---|
|Description|**Duration the business process flow was active.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`duration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

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
|RequiredLevel|SystemRequired|
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

- [lk_opportunitysalesprocess_activestageid](#BKMK_lk_opportunitysalesprocess_activestageid)
- [lk_opportunitysalesprocess_createdby](#BKMK_lk_opportunitysalesprocess_createdby)
- [lk_opportunitysalesprocess_createdonbehalfby](#BKMK_lk_opportunitysalesprocess_createdonbehalfby)
- [lk_opportunitysalesprocess_modifiedby](#BKMK_lk_opportunitysalesprocess_modifiedby)
- [lk_opportunitysalesprocess_modifiedonbehalfby](#BKMK_lk_opportunitysalesprocess_modifiedonbehalfby)
- [lk_opportunitysalesprocess_opportunityid](#BKMK_lk_opportunitysalesprocess_opportunityid)
- [lk_opportunitysalesprocess_processid](#BKMK_lk_opportunitysalesprocess_processid)
- [lk_opportunitysalesprocess_quoteid](#BKMK_lk_opportunitysalesprocess_quoteid)
- [lk_opportunitysalesprocess_salesorderid](#BKMK_lk_opportunitysalesprocess_salesorderid)
- [organization_opportunitysalesprocess](#BKMK_organization_opportunitysalesprocess)
- [transactioncurrency_opportunitysalesprocess](#BKMK_transactioncurrency_opportunitysalesprocess)

### <a name="BKMK_lk_opportunitysalesprocess_activestageid"></a> lk_opportunitysalesprocess_activestageid

One-To-Many Relationship: [processstage lk_opportunitysalesprocess_activestageid](processstage.md#BKMK_lk_opportunitysalesprocess_activestageid)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`activestageid`|
|ReferencingEntityNavigationPropertyName|`activestageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitysalesprocess_createdby"></a> lk_opportunitysalesprocess_createdby

One-To-Many Relationship: [systemuser lk_opportunitysalesprocess_createdby](systemuser.md#BKMK_lk_opportunitysalesprocess_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitysalesprocess_createdonbehalfby"></a> lk_opportunitysalesprocess_createdonbehalfby

One-To-Many Relationship: [systemuser lk_opportunitysalesprocess_createdonbehalfby](systemuser.md#BKMK_lk_opportunitysalesprocess_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitysalesprocess_modifiedby"></a> lk_opportunitysalesprocess_modifiedby

One-To-Many Relationship: [systemuser lk_opportunitysalesprocess_modifiedby](systemuser.md#BKMK_lk_opportunitysalesprocess_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitysalesprocess_modifiedonbehalfby"></a> lk_opportunitysalesprocess_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_opportunitysalesprocess_modifiedonbehalfby](systemuser.md#BKMK_lk_opportunitysalesprocess_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitysalesprocess_opportunityid"></a> lk_opportunitysalesprocess_opportunityid

One-To-Many Relationship: [opportunity lk_opportunitysalesprocess_opportunityid](opportunity.md#BKMK_lk_opportunitysalesprocess_opportunityid)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`opportunityid`|
|ReferencingEntityNavigationPropertyName|`opportunityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitysalesprocess_processid"></a> lk_opportunitysalesprocess_processid

One-To-Many Relationship: [workflow lk_opportunitysalesprocess_processid](workflow.md#BKMK_lk_opportunitysalesprocess_processid)

|Property|Value|
|---|---|
|ReferencedEntity|`workflow`|
|ReferencedAttribute|`workflowid`|
|ReferencingAttribute|`processid`|
|ReferencingEntityNavigationPropertyName|`processid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitysalesprocess_quoteid"></a> lk_opportunitysalesprocess_quoteid

One-To-Many Relationship: [quote lk_opportunitysalesprocess_quoteid](quote.md#BKMK_lk_opportunitysalesprocess_quoteid)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`quoteid`|
|ReferencingEntityNavigationPropertyName|`quoteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_opportunitysalesprocess_salesorderid"></a> lk_opportunitysalesprocess_salesorderid

One-To-Many Relationship: [salesorder lk_opportunitysalesprocess_salesorderid](salesorder.md#BKMK_lk_opportunitysalesprocess_salesorderid)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`salesorderid`|
|ReferencingEntityNavigationPropertyName|`salesorderid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_opportunitysalesprocess"></a> organization_opportunitysalesprocess

One-To-Many Relationship: [organization organization_opportunitysalesprocess](organization.md#BKMK_organization_opportunitysalesprocess)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_opportunitysalesprocess"></a> transactioncurrency_opportunitysalesprocess

One-To-Many Relationship: [transactioncurrency transactioncurrency_opportunitysalesprocess](transactioncurrency.md#BKMK_transactioncurrency_opportunitysalesprocess)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_opportunitysalesprocess_workflowlogs](#BKMK_lk_opportunitysalesprocess_workflowlogs)
- [opportunitysalesprocess_AsyncOperations](#BKMK_opportunitysalesprocess_AsyncOperations)
- [opportunitysalesprocess_BulkDeleteFailures](#BKMK_opportunitysalesprocess_BulkDeleteFailures)
- [opportunitysalesprocess_MailboxTrackingFolders](#BKMK_opportunitysalesprocess_MailboxTrackingFolders)
- [opportunitysalesprocess_PrincipalObjectAttributeAccesses](#BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses)
- [opportunitysalesprocess_ProcessSession](#BKMK_opportunitysalesprocess_ProcessSession)
- [OpportunitySalesProcess_SyncErrors](#BKMK_OpportunitySalesProcess_SyncErrors)

### <a name="BKMK_lk_opportunitysalesprocess_workflowlogs"></a> lk_opportunitysalesprocess_workflowlogs

Many-To-One Relationship: [workflowlog lk_opportunitysalesprocess_workflowlogs](workflowlog.md#BKMK_lk_opportunitysalesprocess_workflowlogs)

|Property|Value|
|---|---|
|ReferencingEntity|`workflowlog`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencedEntityNavigationPropertyName|`workflowlogs_opportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunitysalesprocess_AsyncOperations"></a> opportunitysalesprocess_AsyncOperations

Many-To-One Relationship: [asyncoperation opportunitysalesprocess_AsyncOperations](asyncoperation.md#BKMK_opportunitysalesprocess_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunitysalesprocess_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunitysalesprocess_BulkDeleteFailures"></a> opportunitysalesprocess_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure opportunitysalesprocess_BulkDeleteFailures](bulkdeletefailure.md#BKMK_opportunitysalesprocess_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunitysalesprocess_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunitysalesprocess_MailboxTrackingFolders"></a> opportunitysalesprocess_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder opportunitysalesprocess_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_opportunitysalesprocess_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunitysalesprocess_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses"></a> opportunitysalesprocess_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess opportunitysalesprocess_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`opportunitysalesprocess_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunitysalesprocess_ProcessSession"></a> opportunitysalesprocess_ProcessSession

Many-To-One Relationship: [processsession opportunitysalesprocess_ProcessSession](processsession.md#BKMK_opportunitysalesprocess_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`opportunitysalesprocess_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_OpportunitySalesProcess_SyncErrors"></a> OpportunitySalesProcess_SyncErrors

Many-To-One Relationship: [syncerror OpportunitySalesProcess_SyncErrors](syncerror.md#BKMK_OpportunitySalesProcess_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`OpportunitySalesProcess_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

