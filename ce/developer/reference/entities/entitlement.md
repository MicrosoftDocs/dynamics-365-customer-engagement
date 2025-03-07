---
title: "Entitlement table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Entitlement table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Entitlement table/entity reference (Microsoft Dynamics 365)

Defines the amount and type of support a customer should receive.

## Messages

The following table lists the messages for the Entitlement table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /entitlements(*entitlementid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /entitlements<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /entitlements(*entitlementid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `RenewEntitlement`<br />Event: False |**RenewEntitlement action** |<xref:Microsoft.Crm.Sdk.Messages.RenewEntitlementRequest>|
| `Retrieve`<br />Event: True |`GET` /entitlements(*entitlementid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /entitlements<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /entitlements(*entitlementid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /entitlements(*entitlementid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /entitlements(*entitlementid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Entitlement table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Entitlement** |
| **DisplayCollectionName** | **Entitlements** |
| **SchemaName** | `Entitlement` |
| **CollectionSchemaName** | `Entitlements` |
| **EntitySetName** | `entitlements`|
| **LogicalName** | `entitlement` |
| **LogicalCollectionName** | `entitlements` |
| **PrimaryIdAttribute** | `entitlementid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AllocationTypeCode](#BKMK_AllocationTypeCode)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [DecreaseRemainingOn](#BKMK_DecreaseRemainingOn)
- [Description](#BKMK_Description)
- [EmailAddress](#BKMK_EmailAddress)
- [EndDate](#BKMK_EndDate)
- [EntitlementId](#BKMK_EntitlementId)
- [EntitlementTemplateId](#BKMK_EntitlementTemplateId)
- [entitytype](#BKMK_entitytype)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsDefault](#BKMK_IsDefault)
- [KbAccessLevel](#BKMK_KbAccessLevel)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ProcessId](#BKMK_ProcessId)
- [RemainingTerms](#BKMK_RemainingTerms)
- [RestrictCaseCreation](#BKMK_RestrictCaseCreation)
- [SLAId](#BKMK_SLAId)
- [StageId](#BKMK_StageId)
- [StartDate](#BKMK_StartDate)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalTerms](#BKMK_TotalTerms)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_AllocationTypeCode"></a> AllocationTypeCode

|Property|Value|
|---|---|
|Description|**Select the type of entitlement terms.**|
|DisplayName|**Allocation Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`allocationtypecode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`entitlement_allocationtype`|

#### AllocationTypeCode Choices/Options

|Value|Label|
|---|---|
|0|**Number of cases**|
|1|**Number of hours**|

### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|---|---|
|Description|**Choose a contact or account for which this entitlement has been defined.**|
|DisplayName|**Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customerid`|
|RequiredLevel|SystemRequired|
|Type|Customer|
|Targets|account, contact|

### <a name="BKMK_CustomerIdType"></a> CustomerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridtype`|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|

### <a name="BKMK_DecreaseRemainingOn"></a> DecreaseRemainingOn

|Property|Value|
|---|---|
|Description|**Select whether to decrease the remaining terms when the case is created or when it is resolved.**|
|DisplayName|**Decrease Remaining On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`decreaseremainingon`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`entitlement_decreaseremainingon`|

#### DecreaseRemainingOn Choices/Options

|Value|Label|
|---|---|
|0|**Case Resolution**|
|1|**Case Creation**|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the Entitlement**|
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

### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|---|---|
|Description|**The primary email address for the entity.**|
|DisplayName|**Email Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_EndDate"></a> EndDate

|Property|Value|
|---|---|
|Description|**Enter the date when the entitlement ends.**|
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`enddate`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_EntitlementId"></a> EntitlementId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Entitlement**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entitlementid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_EntitlementTemplateId"></a> EntitlementTemplateId

|Property|Value|
|---|---|
|Description|**Unique identifier for Entitlement Template associated with Entitlement.**|
|DisplayName|**Entitlement Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`entitlementtemplateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|entitlementtemplate|

### <a name="BKMK_entitytype"></a> entitytype

|Property|Value|
|---|---|
|Description|**Entity type for which the entitlement applies**|
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

### <a name="BKMK_IsDefault"></a> IsDefault

|Property|Value|
|---|---|
|Description|**Shows whether this entitlement is the default one for the specified customer.**|
|DisplayName|**Is Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isdefault`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`entitlement_isdefault`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|GlobalChoiceName|`entitlement_kbaccesslevel`|

#### KbAccessLevel Choices/Options

|Value|Label|
|---|---|
|0|**Standard**|
|1|**Premium**|
|2|**None**|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type a meaningful name for the entitlement.**|
|DisplayName|**Entitlement Name**|
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
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_RemainingTerms"></a> RemainingTerms

|Property|Value|
|---|---|
|Description|**Type the total number of entitlement terms that are left.**|
|DisplayName|**Remaining Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`remainingterms`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_RestrictCaseCreation"></a> RestrictCaseCreation

|Property|Value|
|---|---|
|Description|**Tells whether case creation is restricted based on entitlement terms.**|
|DisplayName|**Restrict based on entitlement terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`restrictcasecreation`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`entitlement_restrictcasecreation`|
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

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StartDate"></a> StartDate

|Property|Value|
|---|---|
|Description|**Enter the date when the entitlement starts.**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`startdate`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|None|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`entitlement_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Draft**<br />DefaultStatus: 0<br />InvariantName: `Draft`|
|1|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|2|Label: **Cancelled**<br />DefaultStatus: 2<br />InvariantName: `Cancelled`|
|3|Label: **Expired**<br />DefaultStatus: 3<br />InvariantName: `Expired`|
|4|Label: **Waiting**<br />DefaultStatus: 1200<br />InvariantName: `Waiting`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the reason code that explains the status of the entitlement.**|
|DisplayName|**Status Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`entitlement_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Draft**<br />State:0<br />TransitionData: None|
|1|Label: **Active**<br />State:1<br />TransitionData: None|
|2|Label: **Cancelled**<br />State:2<br />TransitionData: None|
|3|Label: **Expired**<br />State:3<br />TransitionData: None|
|1200|Label: **Waiting**<br />State:4<br />TransitionData: None|

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

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
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

- [AccountId](#BKMK_AccountId)
- [ContactId](#BKMK_ContactId)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|---|---|
|Description|**Unique identifier for Account associated with Entitlement.**|
|DisplayName|**Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|---|---|
|Description|**Unique identifier for Contact associated with Entitlement.**|
|DisplayName|**Contact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

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
|Description|**Unique identifier of the delegate user who created the entitlement.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridyominame`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

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

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|None|
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
|RequiredLevel|None|
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
|RequiredLevel|SystemRequired|
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

- [account_entitlement_Account](#BKMK_account_entitlement_Account)
- [account_entitlement_Customer](#BKMK_account_entitlement_Customer)
- [business_unit_entitlement](#BKMK_business_unit_entitlement)
- [contact_entitlement_ContactId](#BKMK_contact_entitlement_ContactId)
- [contact_entitlement_Customer](#BKMK_contact_entitlement_Customer)
- [entitlementtemplateid_RelationShip](#BKMK_entitlementtemplateid_RelationShip)
- [lk_entitlement_createdby](#BKMK_lk_entitlement_createdby)
- [lk_entitlement_createdonbehalfby](#BKMK_lk_entitlement_createdonbehalfby)
- [lk_entitlement_modifiedby](#BKMK_lk_entitlement_modifiedby)
- [lk_entitlement_modifiedonbehalfby](#BKMK_lk_entitlement_modifiedonbehalfby)
- [owner_entitlement](#BKMK_owner_entitlement)
- [processstage_Entitlement](#BKMK_processstage_Entitlement)
- [sla_entitlement](#BKMK_sla_entitlement)
- [team_entitlement](#BKMK_team_entitlement)
- [TransactionCurrency_Entitlement](#BKMK_TransactionCurrency_Entitlement)
- [user_entitlement](#BKMK_user_entitlement)

### <a name="BKMK_account_entitlement_Account"></a> account_entitlement_Account

One-To-Many Relationship: [account account_entitlement_Account](account.md#BKMK_account_entitlement_Account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`accountid`|
|ReferencingEntityNavigationPropertyName|`accountid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_account_entitlement_Customer"></a> account_entitlement_Customer

One-To-Many Relationship: [account account_entitlement_Customer](account.md#BKMK_account_entitlement_Customer)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_entitlement"></a> business_unit_entitlement

One-To-Many Relationship: [businessunit business_unit_entitlement](businessunit.md#BKMK_business_unit_entitlement)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contact_entitlement_ContactId"></a> contact_entitlement_ContactId

One-To-Many Relationship: [contact contact_entitlement_ContactId](contact.md#BKMK_contact_entitlement_ContactId)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`contactid`|
|ReferencingEntityNavigationPropertyName|`contactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contact_entitlement_Customer"></a> contact_entitlement_Customer

One-To-Many Relationship: [contact contact_entitlement_Customer](contact.md#BKMK_contact_entitlement_Customer)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementtemplateid_RelationShip"></a> entitlementtemplateid_RelationShip

One-To-Many Relationship: [entitlementtemplate entitlementtemplateid_RelationShip](entitlementtemplate.md#BKMK_entitlementtemplateid_RelationShip)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`entitlementtemplateid`|
|ReferencingEntityNavigationPropertyName|`entitlementtemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlement_createdby"></a> lk_entitlement_createdby

One-To-Many Relationship: [systemuser lk_entitlement_createdby](systemuser.md#BKMK_lk_entitlement_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlement_createdonbehalfby"></a> lk_entitlement_createdonbehalfby

One-To-Many Relationship: [systemuser lk_entitlement_createdonbehalfby](systemuser.md#BKMK_lk_entitlement_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlement_modifiedby"></a> lk_entitlement_modifiedby

One-To-Many Relationship: [systemuser lk_entitlement_modifiedby](systemuser.md#BKMK_lk_entitlement_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_entitlement_modifiedonbehalfby"></a> lk_entitlement_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_entitlement_modifiedonbehalfby](systemuser.md#BKMK_lk_entitlement_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_entitlement"></a> owner_entitlement

One-To-Many Relationship: [owner owner_entitlement](owner.md#BKMK_owner_entitlement)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_Entitlement"></a> processstage_Entitlement

One-To-Many Relationship: [processstage processstage_Entitlement](processstage.md#BKMK_processstage_Entitlement)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_entitlement"></a> sla_entitlement

One-To-Many Relationship: [sla sla_entitlement](sla.md#BKMK_sla_entitlement)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`slaid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_entitlement"></a> team_entitlement

One-To-Many Relationship: [team team_entitlement](team.md#BKMK_team_entitlement)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_Entitlement"></a> TransactionCurrency_Entitlement

One-To-Many Relationship: [transactioncurrency TransactionCurrency_Entitlement](transactioncurrency.md#BKMK_TransactionCurrency_Entitlement)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_entitlement"></a> user_entitlement

One-To-Many Relationship: [systemuser user_entitlement](systemuser.md#BKMK_user_entitlement)

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

- [entitlement_ActivityParties](#BKMK_entitlement_ActivityParties)
- [entitlement_ActivityPointers](#BKMK_entitlement_ActivityPointers)
- [entitlement_adx_inviteredemptions](#BKMK_entitlement_adx_inviteredemptions)
- [entitlement_adx_portalcomments](#BKMK_entitlement_adx_portalcomments)
- [entitlement_Annotations](#BKMK_entitlement_Annotations)
- [entitlement_Appointments](#BKMK_entitlement_Appointments)
- [entitlement_AsyncOperations](#BKMK_entitlement_AsyncOperations)
- [entitlement_BulkDeleteFailures](#BKMK_entitlement_BulkDeleteFailures)
- [entitlement_cases](#BKMK_entitlement_cases)
- [entitlement_chats](#BKMK_entitlement_chats)
- [entitlement_connections1](#BKMK_entitlement_connections1)
- [entitlement_connections2](#BKMK_entitlement_connections2)
- [entitlement_DuplicateBaseRecord](#BKMK_entitlement_DuplicateBaseRecord)
- [entitlement_DuplicateMatchingRecord](#BKMK_entitlement_DuplicateMatchingRecord)
- [entitlement_Emails](#BKMK_entitlement_Emails)
- [entitlement_entitlementchannel_EntitlementId](#BKMK_entitlement_entitlementchannel_EntitlementId)
- [entitlement_Faxes](#BKMK_entitlement_Faxes)
- [entitlement_IncidentResolutions](#BKMK_entitlement_IncidentResolutions)
- [entitlement_Letters](#BKMK_entitlement_Letters)
- [Entitlement_MailboxTrackingFolder](#BKMK_Entitlement_MailboxTrackingFolder)
- [entitlement_msdyn_copilottranscripts](#BKMK_entitlement_msdyn_copilottranscripts)
- [entitlement_msdyn_ocliveworkitems](#BKMK_entitlement_msdyn_ocliveworkitems)
- [entitlement_msdyn_ocsessions](#BKMK_entitlement_msdyn_ocsessions)
- [entitlement_msfp_alerts](#BKMK_entitlement_msfp_alerts)
- [entitlement_msfp_surveyinvites](#BKMK_entitlement_msfp_surveyinvites)
- [entitlement_msfp_surveyresponses](#BKMK_entitlement_msfp_surveyresponses)
- [entitlement_OpportunityCloses](#BKMK_entitlement_OpportunityCloses)
- [entitlement_OrderCloses](#BKMK_entitlement_OrderCloses)
- [entitlement_PhoneCalls](#BKMK_entitlement_PhoneCalls)
- [entitlement_PrincipalObjectAttributeAccesses](#BKMK_entitlement_PrincipalObjectAttributeAccesses)
- [entitlement_ProcessSession](#BKMK_entitlement_ProcessSession)
- [entitlement_QuoteCloses](#BKMK_entitlement_QuoteCloses)
- [entitlement_RecurringAppointmentMasters](#BKMK_entitlement_RecurringAppointmentMasters)
- [entitlement_ServiceAppointments](#BKMK_entitlement_ServiceAppointments)
- [entitlement_SocialActivities](#BKMK_entitlement_SocialActivities)
- [Entitlement_SyncErrors](#BKMK_Entitlement_SyncErrors)
- [entitlement_Tasks](#BKMK_entitlement_Tasks)

### <a name="BKMK_entitlement_ActivityParties"></a> entitlement_ActivityParties

Many-To-One Relationship: [activityparty entitlement_ActivityParties](activityparty.md#BKMK_entitlement_ActivityParties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`entitlement_ActivityParties`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_ActivityPointers"></a> entitlement_ActivityPointers

Many-To-One Relationship: [activitypointer entitlement_ActivityPointers](activitypointer.md#BKMK_entitlement_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_adx_inviteredemptions"></a> entitlement_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption entitlement_adx_inviteredemptions](adx_inviteredemption.md#BKMK_entitlement_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_adx_portalcomments"></a> entitlement_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment entitlement_adx_portalcomments](adx_portalcomment.md#BKMK_entitlement_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_Annotations"></a> entitlement_Annotations

Many-To-One Relationship: [annotation entitlement_Annotations](annotation.md#BKMK_entitlement_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_Appointments"></a> entitlement_Appointments

Many-To-One Relationship: [appointment entitlement_Appointments](appointment.md#BKMK_entitlement_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_AsyncOperations"></a> entitlement_AsyncOperations

Many-To-One Relationship: [asyncoperation entitlement_AsyncOperations](asyncoperation.md#BKMK_entitlement_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_BulkDeleteFailures"></a> entitlement_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure entitlement_BulkDeleteFailures](bulkdeletefailure.md#BKMK_entitlement_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_cases"></a> entitlement_cases

Many-To-One Relationship: [incident entitlement_cases](incident.md#BKMK_entitlement_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`entitlementid`|
|ReferencedEntityNavigationPropertyName|`entitlement_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_chats"></a> entitlement_chats

Many-To-One Relationship: [chat entitlement_chats](chat.md#BKMK_entitlement_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_connections1"></a> entitlement_connections1

Many-To-One Relationship: [connection entitlement_connections1](connection.md#BKMK_entitlement_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`entitlement_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_connections2"></a> entitlement_connections2

Many-To-One Relationship: [connection entitlement_connections2](connection.md#BKMK_entitlement_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`entitlement_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_DuplicateBaseRecord"></a> entitlement_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord entitlement_DuplicateBaseRecord](duplicaterecord.md#BKMK_entitlement_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`entitlement_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_DuplicateMatchingRecord"></a> entitlement_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord entitlement_DuplicateMatchingRecord](duplicaterecord.md#BKMK_entitlement_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`entitlement_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_Emails"></a> entitlement_Emails

Many-To-One Relationship: [email entitlement_Emails](email.md#BKMK_entitlement_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_entitlementchannel_EntitlementId"></a> entitlement_entitlementchannel_EntitlementId

Many-To-One Relationship: [entitlementchannel entitlement_entitlementchannel_EntitlementId](entitlementchannel.md#BKMK_entitlement_entitlementchannel_EntitlementId)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementchannel`|
|ReferencingAttribute|`entitlementid`|
|ReferencedEntityNavigationPropertyName|`entitlement_entitlementchannel_EntitlementId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_Faxes"></a> entitlement_Faxes

Many-To-One Relationship: [fax entitlement_Faxes](fax.md#BKMK_entitlement_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_IncidentResolutions"></a> entitlement_IncidentResolutions

Many-To-One Relationship: [incidentresolution entitlement_IncidentResolutions](incidentresolution.md#BKMK_entitlement_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_Letters"></a> entitlement_Letters

Many-To-One Relationship: [letter entitlement_Letters](letter.md#BKMK_entitlement_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Entitlement_MailboxTrackingFolder"></a> Entitlement_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder Entitlement_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Entitlement_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Entitlement_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_msdyn_copilottranscripts"></a> entitlement_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript entitlement_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_entitlement_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_msdyn_ocliveworkitems"></a> entitlement_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem entitlement_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_entitlement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_msdyn_ocsessions"></a> entitlement_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession entitlement_msdyn_ocsessions](msdyn_ocsession.md#BKMK_entitlement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_msfp_alerts"></a> entitlement_msfp_alerts

Many-To-One Relationship: [msfp_alert entitlement_msfp_alerts](msfp_alert.md#BKMK_entitlement_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_msfp_surveyinvites"></a> entitlement_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite entitlement_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_entitlement_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_msfp_surveyresponses"></a> entitlement_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse entitlement_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_entitlement_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_OpportunityCloses"></a> entitlement_OpportunityCloses

Many-To-One Relationship: [opportunityclose entitlement_OpportunityCloses](opportunityclose.md#BKMK_entitlement_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_OrderCloses"></a> entitlement_OrderCloses

Many-To-One Relationship: [orderclose entitlement_OrderCloses](orderclose.md#BKMK_entitlement_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_PhoneCalls"></a> entitlement_PhoneCalls

Many-To-One Relationship: [phonecall entitlement_PhoneCalls](phonecall.md#BKMK_entitlement_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_PrincipalObjectAttributeAccesses"></a> entitlement_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess entitlement_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_entitlement_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_ProcessSession"></a> entitlement_ProcessSession

Many-To-One Relationship: [processsession entitlement_ProcessSession](processsession.md#BKMK_entitlement_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_QuoteCloses"></a> entitlement_QuoteCloses

Many-To-One Relationship: [quoteclose entitlement_QuoteCloses](quoteclose.md#BKMK_entitlement_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_RecurringAppointmentMasters"></a> entitlement_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster entitlement_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_entitlement_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_ServiceAppointments"></a> entitlement_ServiceAppointments

Many-To-One Relationship: [serviceappointment entitlement_ServiceAppointments](serviceappointment.md#BKMK_entitlement_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_entitlement_SocialActivities"></a> entitlement_SocialActivities

Many-To-One Relationship: [socialactivity entitlement_SocialActivities](socialactivity.md#BKMK_entitlement_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Entitlement_SyncErrors"></a> Entitlement_SyncErrors

Many-To-One Relationship: [syncerror Entitlement_SyncErrors](syncerror.md#BKMK_Entitlement_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Entitlement_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlement_Tasks"></a> entitlement_Tasks

Many-To-One Relationship: [task entitlement_Tasks](task.md#BKMK_entitlement_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [entitlementcontacts_association](#BKMK_entitlementcontacts_association)
- [product_entitlement_association](#BKMK_product_entitlement_association)

### <a name="BKMK_entitlementcontacts_association"></a> entitlementcontacts_association

See [contact entitlementcontacts_association Many-To-Many Relationship](contact.md#BKMK_entitlementcontacts_association)

|Property|Value|
|---|---|
|IntersectEntityName|`entitlementcontacts`|
|IsCustomizable|False|
|SchemaName|`entitlementcontacts_association`|
|IntersectAttribute|`entitlementid`|
|NavigationPropertyName|`entitlementcontacts_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_entitlement_association"></a> product_entitlement_association

See [product product_entitlement_association Many-To-Many Relationship](product.md#BKMK_product_entitlement_association)

|Property|Value|
|---|---|
|IntersectEntityName|`entitlementproducts`|
|IsCustomizable|False|
|SchemaName|`product_entitlement_association`|
|IntersectAttribute|`entitlementid`|
|NavigationPropertyName|`product_entitlement_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

