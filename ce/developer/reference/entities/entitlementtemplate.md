---
title: "Entitlement Template (EntitlementTemplate) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Entitlement Template (EntitlementTemplate) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Entitlement Template (EntitlementTemplate) table/entity reference (Microsoft Dynamics 365)

Contains predefined customer support terms that can be used to created entitlements for customers.

## Messages

The following table lists the messages for the Entitlement Template (EntitlementTemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /entitlementtemplates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /entitlementtemplates(*entitlementtemplateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /entitlementtemplates(*entitlementtemplateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /entitlementtemplates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /entitlementtemplates(*entitlementtemplateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /entitlementtemplates(*entitlementtemplateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Entitlement Template (EntitlementTemplate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Entitlement Template** |
| **DisplayCollectionName** | **Entitlement Templates** |
| **SchemaName** | `EntitlementTemplate` |
| **CollectionSchemaName** | `EntitlementTemplates` |
| **EntitySetName** | `entitlementtemplates`|
| **LogicalName** | `entitlementtemplate` |
| **LogicalCollectionName** | `entitlementtemplates` |
| **PrimaryIdAttribute** | `entitlementtemplateid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AllocationTypeCode](#BKMK_AllocationTypeCode)
- [DecreaseRemainingOn](#BKMK_DecreaseRemainingOn)
- [Description](#BKMK_Description)
- [EndDate](#BKMK_EndDate)
- [EntitlementTemplateId](#BKMK_EntitlementTemplateId)
- [entitytype](#BKMK_entitytype)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [KbAccessLevel](#BKMK_KbAccessLevel)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RestrictCaseCreation](#BKMK_RestrictCaseCreation)
- [SLAId](#BKMK_SLAId)
- [StartDate](#BKMK_StartDate)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalTerms](#BKMK_TotalTerms)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_AllocationTypeCode"></a> AllocationTypeCode

|Property|Value|
|---|---|
|Description|**Select whether the entitlement allocation is based on number of cases or number of hours.**|
|DisplayName|**Allocation Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`allocationtypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`entitlementtemplate_allocationtype`|

#### AllocationTypeCode Choices/Options

|Value|Label|
|---|---|
|0|**Number of cases**|
|1|**Number of hours**|

### <a name="BKMK_DecreaseRemainingOn"></a> DecreaseRemainingOn

|Property|Value|
|---|---|
|Description|**Information about whether to decrease the remaining terms when the case is created or when it is resolved**|
|DisplayName|**Decrease Remaining On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`decreaseremainingon`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`entitlementtemplate_decreaseremainingon`|

#### DecreaseRemainingOn Choices/Options

|Value|Label|
|---|---|
|0|**Case Resolution**|
|1|**Case Creation**|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the account, such as an excerpt from the company's website.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_EndDate"></a> EndDate

|Property|Value|
|---|---|
|Description|**Enter the date and time when the entitlement ends.**|
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`enddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_EntitlementTemplateId"></a> EntitlementTemplateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Entitlement Template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entitlementtemplateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_entitytype"></a> entitytype

|Property|Value|
|---|---|
|Description|**Entity type for which the entitlement template applies**|
|DisplayName|**Entity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`entitytype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`entitytype`|

#### entitytype Choices/Options

|Value|Label|
|---|---|
|0|**Case**|

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

### <a name="BKMK_KbAccessLevel"></a> KbAccessLevel

|Property|Value|
|---|---|
|Description|**Select the access someone will have to the knowledge base on the portal.**|
|DisplayName|**KB Access Level**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`kbaccesslevel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`entitlementtemplate_kbaccesslevel`|

#### KbAccessLevel Choices/Options

|Value|Label|
|---|---|
|0|**Standard**|
|1|**Premium**|
|2|**None**|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type a descriptive name for the entitlement template.**|
|DisplayName|**Entitlement Template Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
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

### <a name="BKMK_RestrictCaseCreation"></a> RestrictCaseCreation

|Property|Value|
|---|---|
|Description|**Tells whether case creation is restricted based on entitlement terms.**|
|DisplayName|**Restrict By Entitlement Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`restrictcasecreation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`entitlementtemplate_restrictcasecreation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) associated with the entitlement.**|
|DisplayName|**SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`slaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_StartDate"></a> StartDate

|Property|Value|
|---|---|
|Description|**Enter the date and time when the entitlement begins.**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`startdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_TotalTerms"></a> TotalTerms

|Property|Value|
|---|---|
|Description|**Type the total number of entitlement terms.**|
|DisplayName|**Total Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalterms`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the contact.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the contact with respect to the base currency.**|
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

- [entitlementtemplate_organization](#BKMK_entitlementtemplate_organization)
- [lk_entitlementtemplate_createdby](#BKMK_lk_entitlementtemplate_createdby)
- [lk_entitlementtemplate_createdonbehalfby](#BKMK_lk_entitlementtemplate_createdonbehalfby)
- [lk_entitlementtemplate_modifiedby](#BKMK_lk_entitlementtemplate_modifiedby)
- [lk_entitlementtemplate_modifiedonbehalfby](#BKMK_lk_entitlementtemplate_modifiedonbehalfby)
- [sla_entitlementtemplate](#BKMK_sla_entitlementtemplate)
- [TransactionCurrency_entitlementtemplate](#BKMK_TransactionCurrency_entitlementtemplate)

### <a name="BKMK_entitlementtemplate_organization"></a> entitlementtemplate_organization

One-To-Many Relationship: [organization entitlementtemplate_organization](organization.md#BKMK_entitlementtemplate_organization)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlementtemplate_createdby"></a> lk_entitlementtemplate_createdby

One-To-Many Relationship: [systemuser lk_entitlementtemplate_createdby](systemuser.md#BKMK_lk_entitlementtemplate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlementtemplate_createdonbehalfby"></a> lk_entitlementtemplate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_entitlementtemplate_createdonbehalfby](systemuser.md#BKMK_lk_entitlementtemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlementtemplate_modifiedby"></a> lk_entitlementtemplate_modifiedby

One-To-Many Relationship: [systemuser lk_entitlementtemplate_modifiedby](systemuser.md#BKMK_lk_entitlementtemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlementtemplate_modifiedonbehalfby"></a> lk_entitlementtemplate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_entitlementtemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_entitlementtemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_entitlementtemplate"></a> sla_entitlementtemplate

One-To-Many Relationship: [sla sla_entitlementtemplate](sla.md#BKMK_sla_entitlementtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`slaid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_entitlementtemplate"></a> TransactionCurrency_entitlementtemplate

One-To-Many Relationship: [transactioncurrency TransactionCurrency_entitlementtemplate](transactioncurrency.md#BKMK_TransactionCurrency_entitlementtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [entitlementtemplate_ActivityPointers](#BKMK_entitlementtemplate_ActivityPointers)
- [entitlementtemplate_adx_inviteredemptions](#BKMK_entitlementtemplate_adx_inviteredemptions)
- [entitlementtemplate_adx_portalcomments](#BKMK_entitlementtemplate_adx_portalcomments)
- [entitlementtemplate_Annotations](#BKMK_entitlementtemplate_Annotations)
- [entitlementtemplate_Appointments](#BKMK_entitlementtemplate_Appointments)
- [entitlementtemplate_AsyncOperations](#BKMK_entitlementtemplate_AsyncOperations)
- [entitlementtemplate_BulkDeleteFailures](#BKMK_entitlementtemplate_BulkDeleteFailures)
- [entitlementtemplate_chats](#BKMK_entitlementtemplate_chats)
- [entitlementtemplate_DuplicateBaseRecord](#BKMK_entitlementtemplate_DuplicateBaseRecord)
- [entitlementtemplate_DuplicateMatchingRecord](#BKMK_entitlementtemplate_DuplicateMatchingRecord)
- [entitlementtemplate_Emails](#BKMK_entitlementtemplate_Emails)
- [entitlementtemplate_entitlementchannel_entitlementtemplateid](#BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid)
- [entitlementtemplate_Faxes](#BKMK_entitlementtemplate_Faxes)
- [entitlementtemplate_IncidentResolutions](#BKMK_entitlementtemplate_IncidentResolutions)
- [entitlementtemplate_Letters](#BKMK_entitlementtemplate_Letters)
- [EntitlementTemplate_MailboxTrackingFolder](#BKMK_EntitlementTemplate_MailboxTrackingFolder)
- [entitlementtemplate_msdyn_copilottranscripts](#BKMK_entitlementtemplate_msdyn_copilottranscripts)
- [entitlementtemplate_msdyn_ocliveworkitems](#BKMK_entitlementtemplate_msdyn_ocliveworkitems)
- [entitlementtemplate_msdyn_ocsessions](#BKMK_entitlementtemplate_msdyn_ocsessions)
- [entitlementtemplate_msfp_alerts](#BKMK_entitlementtemplate_msfp_alerts)
- [entitlementtemplate_msfp_surveyinvites](#BKMK_entitlementtemplate_msfp_surveyinvites)
- [entitlementtemplate_msfp_surveyresponses](#BKMK_entitlementtemplate_msfp_surveyresponses)
- [entitlementtemplate_OpportunityCloses](#BKMK_entitlementtemplate_OpportunityCloses)
- [entitlementtemplate_OrderCloses](#BKMK_entitlementtemplate_OrderCloses)
- [entitlementtemplate_PhoneCalls](#BKMK_entitlementtemplate_PhoneCalls)
- [entitlementtemplate_PrincipalObjectAttributeAccesses](#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses)
- [entitlementtemplate_ProcessSession](#BKMK_entitlementtemplate_ProcessSession)
- [entitlementtemplate_QuoteCloses](#BKMK_entitlementtemplate_QuoteCloses)
- [entitlementtemplate_RecurringAppointmentMasters](#BKMK_entitlementtemplate_RecurringAppointmentMasters)
- [entitlementtemplate_ServiceAppointments](#BKMK_entitlementtemplate_ServiceAppointments)
- [entitlementtemplate_SocialActivities](#BKMK_entitlementtemplate_SocialActivities)
- [EntitlementTemplate_SyncErrors](#BKMK_EntitlementTemplate_SyncErrors)
- [entitlementtemplate_Tasks](#BKMK_entitlementtemplate_Tasks)
- [entitlementtemplateid_RelationShip](#BKMK_entitlementtemplateid_RelationShip)

### <a name="BKMK_entitlementtemplate_ActivityPointers"></a> entitlementtemplate_ActivityPointers

Many-To-One Relationship: [activitypointer entitlementtemplate_ActivityPointers](activitypointer.md#BKMK_entitlementtemplate_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_adx_inviteredemptions"></a> entitlementtemplate_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption entitlementtemplate_adx_inviteredemptions](adx_inviteredemption.md#BKMK_entitlementtemplate_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_adx_portalcomments"></a> entitlementtemplate_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment entitlementtemplate_adx_portalcomments](adx_portalcomment.md#BKMK_entitlementtemplate_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_Annotations"></a> entitlementtemplate_Annotations

Many-To-One Relationship: [annotation entitlementtemplate_Annotations](annotation.md#BKMK_entitlementtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_Appointments"></a> entitlementtemplate_Appointments

Many-To-One Relationship: [appointment entitlementtemplate_Appointments](appointment.md#BKMK_entitlementtemplate_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_AsyncOperations"></a> entitlementtemplate_AsyncOperations

Many-To-One Relationship: [asyncoperation entitlementtemplate_AsyncOperations](asyncoperation.md#BKMK_entitlementtemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_BulkDeleteFailures"></a> entitlementtemplate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure entitlementtemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_entitlementtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_chats"></a> entitlementtemplate_chats

Many-To-One Relationship: [chat entitlementtemplate_chats](chat.md#BKMK_entitlementtemplate_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_DuplicateBaseRecord"></a> entitlementtemplate_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord entitlementtemplate_DuplicateBaseRecord](duplicaterecord.md#BKMK_entitlementtemplate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_DuplicateMatchingRecord"></a> entitlementtemplate_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord entitlementtemplate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_entitlementtemplate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_Emails"></a> entitlementtemplate_Emails

Many-To-One Relationship: [email entitlementtemplate_Emails](email.md#BKMK_entitlementtemplate_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid"></a> entitlementtemplate_entitlementchannel_entitlementtemplateid

Many-To-One Relationship: [entitlementtemplatechannel entitlementtemplate_entitlementchannel_entitlementtemplateid](entitlementtemplatechannel.md#BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementtemplatechannel`|
|ReferencingAttribute|`entitlementtemplateid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_entitlementchannel_entitlementtemplateid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_Faxes"></a> entitlementtemplate_Faxes

Many-To-One Relationship: [fax entitlementtemplate_Faxes](fax.md#BKMK_entitlementtemplate_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_IncidentResolutions"></a> entitlementtemplate_IncidentResolutions

Many-To-One Relationship: [incidentresolution entitlementtemplate_IncidentResolutions](incidentresolution.md#BKMK_entitlementtemplate_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_Letters"></a> entitlementtemplate_Letters

Many-To-One Relationship: [letter entitlementtemplate_Letters](letter.md#BKMK_entitlementtemplate_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_EntitlementTemplate_MailboxTrackingFolder"></a> EntitlementTemplate_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder EntitlementTemplate_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_EntitlementTemplate_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`EntitlementTemplate_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_msdyn_copilottranscripts"></a> entitlementtemplate_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript entitlementtemplate_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_entitlementtemplate_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_msdyn_ocliveworkitems"></a> entitlementtemplate_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem entitlementtemplate_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_entitlementtemplate_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_msdyn_ocsessions"></a> entitlementtemplate_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession entitlementtemplate_msdyn_ocsessions](msdyn_ocsession.md#BKMK_entitlementtemplate_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_msfp_alerts"></a> entitlementtemplate_msfp_alerts

Many-To-One Relationship: [msfp_alert entitlementtemplate_msfp_alerts](msfp_alert.md#BKMK_entitlementtemplate_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_msfp_surveyinvites"></a> entitlementtemplate_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite entitlementtemplate_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_entitlementtemplate_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_msfp_surveyresponses"></a> entitlementtemplate_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse entitlementtemplate_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_entitlementtemplate_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_OpportunityCloses"></a> entitlementtemplate_OpportunityCloses

Many-To-One Relationship: [opportunityclose entitlementtemplate_OpportunityCloses](opportunityclose.md#BKMK_entitlementtemplate_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_OrderCloses"></a> entitlementtemplate_OrderCloses

Many-To-One Relationship: [orderclose entitlementtemplate_OrderCloses](orderclose.md#BKMK_entitlementtemplate_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_PhoneCalls"></a> entitlementtemplate_PhoneCalls

Many-To-One Relationship: [phonecall entitlementtemplate_PhoneCalls](phonecall.md#BKMK_entitlementtemplate_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses"></a> entitlementtemplate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess entitlementtemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_ProcessSession"></a> entitlementtemplate_ProcessSession

Many-To-One Relationship: [processsession entitlementtemplate_ProcessSession](processsession.md#BKMK_entitlementtemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_QuoteCloses"></a> entitlementtemplate_QuoteCloses

Many-To-One Relationship: [quoteclose entitlementtemplate_QuoteCloses](quoteclose.md#BKMK_entitlementtemplate_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_RecurringAppointmentMasters"></a> entitlementtemplate_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster entitlementtemplate_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_entitlementtemplate_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_ServiceAppointments"></a> entitlementtemplate_ServiceAppointments

Many-To-One Relationship: [serviceappointment entitlementtemplate_ServiceAppointments](serviceappointment.md#BKMK_entitlementtemplate_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_SocialActivities"></a> entitlementtemplate_SocialActivities

Many-To-One Relationship: [socialactivity entitlementtemplate_SocialActivities](socialactivity.md#BKMK_entitlementtemplate_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_EntitlementTemplate_SyncErrors"></a> EntitlementTemplate_SyncErrors

Many-To-One Relationship: [syncerror EntitlementTemplate_SyncErrors](syncerror.md#BKMK_EntitlementTemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`EntitlementTemplate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_Tasks"></a> entitlementtemplate_Tasks

Many-To-One Relationship: [task entitlementtemplate_Tasks](task.md#BKMK_entitlementtemplate_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplateid_RelationShip"></a> entitlementtemplateid_RelationShip

Many-To-One Relationship: [entitlement entitlementtemplateid_RelationShip](entitlement.md#BKMK_entitlementtemplateid_RelationShip)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`entitlementtemplateid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplateid_RelationShip`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_product_entitlementtemplate_association"></a> product_entitlementtemplate_association

See [product product_entitlementtemplate_association Many-To-Many Relationship](product.md#BKMK_product_entitlementtemplate_association)

|Property|Value|
|---|---|
|IntersectEntityName|`entitlementtemplateproducts`|
|IsCustomizable|False|
|SchemaName|`product_entitlementtemplate_association`|
|IntersectAttribute|`entitlementtemplateid`|
|NavigationPropertyName|`product_entitlementtemplate_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

