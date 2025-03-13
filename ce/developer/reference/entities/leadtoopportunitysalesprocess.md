---
title: "Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table/entity reference (Microsoft Dynamics 365)

Lead To Opportunity Sales Process Business Process Flow

## Messages

The following table lists the messages for the Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /leadtoopportunitysalesprocesses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /leadtoopportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /leadtoopportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: False |`GET` /leadtoopportunitysalesprocesses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /leadtoopportunitysalesprocesses(*businessprocessflowinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /leadtoopportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /leadtoopportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|

## Properties

The following table lists selected properties for the Lead To Opportunity Sales Process (LeadToOpportunitySalesProcess) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Lead To Opportunity Sales Process** |
| **DisplayCollectionName** | **Lead To Opportunity Sales Process** |
| **SchemaName** | `LeadToOpportunitySalesProcess` |
| **CollectionSchemaName** | `LeadToOpportunitySalesProcesses` |
| **EntitySetName** | `leadtoopportunitysalesprocesses`|
| **LogicalName** | `leadtoopportunitysalesprocess` |
| **LogicalCollectionName** | `leadtoopportunitysalesprocesses` |
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
- [LeadId](#BKMK_LeadId)
- [Name](#BKMK_Name)
- [OpportunityId](#BKMK_OpportunityId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProcessId](#BKMK_ProcessId)
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
|Description|**Unique identifier for Lead To Opportunity Sales Process bpf entity instances**|
|DisplayName|**Lead To Opportunity Sales Process Instance Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`businessprocessflowinstanceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_CompletedOn"></a> CompletedOn

|Property|Value|
|---|---|
|Description|**Date and time when Business Process Flow instance is completed**|
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

### <a name="BKMK_LeadId"></a> LeadId

|Property|Value|
|---|---|
|Description|**Unique identifier of the workflow associated to the Business Process Flow instance.**|
|DisplayName|**Lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`leadid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

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
|DisplayName|**Opportunity Id**|
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
|GlobalChoiceName|`leadtoopportunitysalesprocess_statecode`|

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
|GlobalChoiceName|`leadtoopportunitysalesprocess_statuscode`|

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
|Description|**Duration between completed on and started on, used by business process flow.**|
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

- [lk_leadtoopportunitysalesprocess_activestageid](#BKMK_lk_leadtoopportunitysalesprocess_activestageid)
- [lk_leadtoopportunitysalesprocess_createdby](#BKMK_lk_leadtoopportunitysalesprocess_createdby)
- [lk_leadtoopportunitysalesprocess_createdonbehalfby](#BKMK_lk_leadtoopportunitysalesprocess_createdonbehalfby)
- [lk_leadtoopportunitysalesprocess_leadid](#BKMK_lk_leadtoopportunitysalesprocess_leadid)
- [lk_leadtoopportunitysalesprocess_modifiedby](#BKMK_lk_leadtoopportunitysalesprocess_modifiedby)
- [lk_leadtoopportunitysalesprocess_modifiedonbehalfby](#BKMK_lk_leadtoopportunitysalesprocess_modifiedonbehalfby)
- [lk_leadtoopportunitysalesprocess_opportunityid](#BKMK_lk_leadtoopportunitysalesprocess_opportunityid)
- [lk_leadtoopportunitysalesprocess_processid](#BKMK_lk_leadtoopportunitysalesprocess_processid)
- [organization_leadtoopportunitysalesprocess](#BKMK_organization_leadtoopportunitysalesprocess)
- [transactioncurrency_leadtoopportunitysalesprocess](#BKMK_transactioncurrency_leadtoopportunitysalesprocess)

### <a name="BKMK_lk_leadtoopportunitysalesprocess_activestageid"></a> lk_leadtoopportunitysalesprocess_activestageid

One-To-Many Relationship: [processstage lk_leadtoopportunitysalesprocess_activestageid](processstage.md#BKMK_lk_leadtoopportunitysalesprocess_activestageid)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`activestageid`|
|ReferencingEntityNavigationPropertyName|`activestageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_createdby"></a> lk_leadtoopportunitysalesprocess_createdby

One-To-Many Relationship: [systemuser lk_leadtoopportunitysalesprocess_createdby](systemuser.md#BKMK_lk_leadtoopportunitysalesprocess_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_createdonbehalfby"></a> lk_leadtoopportunitysalesprocess_createdonbehalfby

One-To-Many Relationship: [systemuser lk_leadtoopportunitysalesprocess_createdonbehalfby](systemuser.md#BKMK_lk_leadtoopportunitysalesprocess_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_leadid"></a> lk_leadtoopportunitysalesprocess_leadid

One-To-Many Relationship: [lead lk_leadtoopportunitysalesprocess_leadid](lead.md#BKMK_lk_leadtoopportunitysalesprocess_leadid)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`leadid`|
|ReferencingEntityNavigationPropertyName|`leadId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_modifiedby"></a> lk_leadtoopportunitysalesprocess_modifiedby

One-To-Many Relationship: [systemuser lk_leadtoopportunitysalesprocess_modifiedby](systemuser.md#BKMK_lk_leadtoopportunitysalesprocess_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_modifiedonbehalfby"></a> lk_leadtoopportunitysalesprocess_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_leadtoopportunitysalesprocess_modifiedonbehalfby](systemuser.md#BKMK_lk_leadtoopportunitysalesprocess_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_opportunityid"></a> lk_leadtoopportunitysalesprocess_opportunityid

One-To-Many Relationship: [opportunity lk_leadtoopportunitysalesprocess_opportunityid](opportunity.md#BKMK_lk_leadtoopportunitysalesprocess_opportunityid)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`opportunityid`|
|ReferencingEntityNavigationPropertyName|`opportunityId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_processid"></a> lk_leadtoopportunitysalesprocess_processid

One-To-Many Relationship: [workflow lk_leadtoopportunitysalesprocess_processid](workflow.md#BKMK_lk_leadtoopportunitysalesprocess_processid)

|Property|Value|
|---|---|
|ReferencedEntity|`workflow`|
|ReferencedAttribute|`workflowid`|
|ReferencingAttribute|`processid`|
|ReferencingEntityNavigationPropertyName|`processid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_leadtoopportunitysalesprocess"></a> organization_leadtoopportunitysalesprocess

One-To-Many Relationship: [organization organization_leadtoopportunitysalesprocess](organization.md#BKMK_organization_leadtoopportunitysalesprocess)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_leadtoopportunitysalesprocess"></a> transactioncurrency_leadtoopportunitysalesprocess

One-To-Many Relationship: [transactioncurrency transactioncurrency_leadtoopportunitysalesprocess](transactioncurrency.md#BKMK_transactioncurrency_leadtoopportunitysalesprocess)

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

- [leadtoopportunitysalesprocess_AsyncOperations](#BKMK_leadtoopportunitysalesprocess_AsyncOperations)
- [leadtoopportunitysalesprocess_BulkDeleteFailures](#BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures)
- [leadtoopportunitysalesprocess_MailboxTrackingFolders](#BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders)
- [leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses](#BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses)
- [leadtoopportunitysalesprocess_ProcessSession](#BKMK_leadtoopportunitysalesprocess_ProcessSession)
- [LeadToOpportunitySalesProcess_SyncErrors](#BKMK_LeadToOpportunitySalesProcess_SyncErrors)
- [lk_leadtoopportunitysalesprocess_workflowlogs](#BKMK_lk_leadtoopportunitysalesprocess_workflowlogs)

### <a name="BKMK_leadtoopportunitysalesprocess_AsyncOperations"></a> leadtoopportunitysalesprocess_AsyncOperations

Many-To-One Relationship: [asyncoperation leadtoopportunitysalesprocess_AsyncOperations](asyncoperation.md#BKMK_leadtoopportunitysalesprocess_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`leadtoopportunitysalesprocess_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures"></a> leadtoopportunitysalesprocess_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure leadtoopportunitysalesprocess_BulkDeleteFailures](bulkdeletefailure.md#BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`leadtoopportunitysalesprocess_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders"></a> leadtoopportunitysalesprocess_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder leadtoopportunitysalesprocess_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`leadtoopportunitysalesprocess_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses"></a> leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_leadtoopportunitysalesprocess_ProcessSession"></a> leadtoopportunitysalesprocess_ProcessSession

Many-To-One Relationship: [processsession leadtoopportunitysalesprocess_ProcessSession](processsession.md#BKMK_leadtoopportunitysalesprocess_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`leadtoopportunitysalesprocess_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_LeadToOpportunitySalesProcess_SyncErrors"></a> LeadToOpportunitySalesProcess_SyncErrors

Many-To-One Relationship: [syncerror LeadToOpportunitySalesProcess_SyncErrors](syncerror.md#BKMK_LeadToOpportunitySalesProcess_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`LeadToOpportunitySalesProcess_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_leadtoopportunitysalesprocess_workflowlogs"></a> lk_leadtoopportunitysalesprocess_workflowlogs

Many-To-One Relationship: [workflowlog lk_leadtoopportunitysalesprocess_workflowlogs](workflowlog.md#BKMK_lk_leadtoopportunitysalesprocess_workflowlogs)

|Property|Value|
|---|---|
|ReferencingEntity|`workflowlog`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencedEntityNavigationPropertyName|`workflowlogs_leadtoopportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

