---
title: "msdyn_contractlinescheduleofvalue Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_contractlinescheduleofvalue entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_contractlinescheduleofvalue Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

List of billing milestones and invoice amounts for this project contract line.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlinescheduleofvalues(*msdyn_contractlinescheduleofvalueid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Project Contract Line Milestone<br />
**DisplayCollectionName**: Project Contract Line Milestones<br />
**SchemaName**: msdyn_contractlinescheduleofvalue<br />
**CollectionSchemaName**: msdyn_contractlinescheduleofvalues<br />
**LogicalName**: msdyn_contractlinescheduleofvalue<br />
**LogicalCollectionName**: msdyn_contractlinescheduleofvalues<br />
**EntitySetName**: msdyn_contractlinescheduleofvalues<br />
**PrimaryIdAttribute**: msdyn_contractlinescheduleofvalueid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_amount](#BKMK_msdyn_amount)
- [msdyn_contract](#BKMK_msdyn_contract)
- [msdyn_ContractLine](#BKMK_msdyn_ContractLine)
- [msdyn_ContractLineDescription](#BKMK_msdyn_ContractLineDescription)
- [msdyn_contractlinescheduleofvalueId](#BKMK_msdyn_contractlinescheduleofvalueId)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_externaldescription](#BKMK_msdyn_externaldescription)
- [msdyn_Invoicedate](#BKMK_msdyn_Invoicedate)
- [msdyn_Invoicestatus](#BKMK_msdyn_Invoicestatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_price](#BKMK_msdyn_price)
- [msdyn_project](#BKMK_msdyn_project)
- [msdyn_projecttask](#BKMK_msdyn_projecttask)
- [msdyn_startdatetime](#BKMK_msdyn_startdatetime)
- [msdyn_tax](#BKMK_msdyn_tax)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_TransactionTypeCode](#BKMK_msdyn_TransactionTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_amount"></a> msdyn_amount

**Description**: Enter the value of the milestone.<br />
**DisplayName**: Milestone Amount<br />
**LogicalName**: msdyn_amount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_contract"></a> msdyn_contract

**Description**: Select the project contract associated with this milestone.<br />
**DisplayName**: Project Contract<br />
**LogicalName**: msdyn_contract<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: salesorder


### <a name="BKMK_msdyn_ContractLine"></a> msdyn_ContractLine

**Description**: Shows the project contract line that has this milestone<br />
**DisplayName**: Project Contract Line<br />
**LogicalName**: msdyn_contractline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ContractLineDescription"></a> msdyn_ContractLineDescription

**Description**: Enter a description of the project contract line that has this milestone.<br />
**DisplayName**: Project Contract Line Description<br />
**LogicalName**: msdyn_contractlinedescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_contractlinescheduleofvalueId"></a> msdyn_contractlinescheduleofvalueId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Project Contract Line Milestone<br />
**LogicalName**: msdyn_contractlinescheduleofvalueid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_description"></a> msdyn_description

**Description**: Type a description of the milestone.<br />
**DisplayName**: Milestone Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_externaldescription"></a> msdyn_externaldescription

**Description**: Description of the project contract line milestone<br />
**DisplayName**: External Description<br />
**LogicalName**: msdyn_externaldescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_Invoicedate"></a> msdyn_Invoicedate

**Description**: Enter the date of which this milestone should be achieved<br />
**DisplayName**: Milestone Date<br />
**LogicalName**: msdyn_invoicedate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_Invoicestatus"></a> msdyn_Invoicestatus

**Description**: Select the status of invoicing of this milestone<br />
**DisplayName**: Invoice Status<br />
**LogicalName**: msdyn_invoicestatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Not Ready for invoicing
- **Value**: 192350001 **Label**: Ready for invoicing
- **Value**: 192350002 **Label**: Customer invoice created
- **Value**: 192350003 **Label**: Customer invoice posted



### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Type the name of the milestone.<br />
**DisplayName**: Milestone Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_price"></a> msdyn_price

**Description**: Enter the price of the transaction.<br />
**DisplayName**: Price<br />
**LogicalName**: msdyn_price<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_project"></a> msdyn_project

**Description**: Select the project that is tracking the work required to achieve this milestone.<br />
**DisplayName**: Project<br />
**LogicalName**: msdyn_project<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_project


### <a name="BKMK_msdyn_projecttask"></a> msdyn_projecttask

**Description**: Select the project work breakdown structure (WBS) task that is tracking the work for this milestone.<br />
**DisplayName**: Project Task<br />
**LogicalName**: msdyn_projecttask<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_projecttask


### <a name="BKMK_msdyn_startdatetime"></a> msdyn_startdatetime

**Description**: Date of project contract line milestone<br />
**DisplayName**: Start Date<br />
**LogicalName**: msdyn_startdatetime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_tax"></a> msdyn_tax

**Description**: <br />
**DisplayName**: tax<br />
**LogicalName**: msdyn_tax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: 0<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

**Description**: Transaction classification of the project contract line milestone<br />
**DisplayName**: Transaction Class<br />
**LogicalName**: msdyn_transactionclassification<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Time
- **Value**: 192350001 **Label**: Expense
- **Value**: 192350002 **Label**: Material
- **Value**: 192350003 **Label**: Milestone
- **Value**: 192350004 **Label**: Fee
- **Value**: 690970000 **Label**: Commission
- **Value**: 690970001 **Label**: Additional
- **Value**: 690970002 **Label**: Tax



### <a name="BKMK_msdyn_TransactionTypeCode"></a> msdyn_TransactionTypeCode

**Description**: Transaction type of the project contract line milestone<br />
**DisplayName**: Transaction Type<br />
**LogicalName**: msdyn_transactiontypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Cost
- **Value**: 192350004 **Label**: Project Contract
- **Value**: 192350005 **Label**: Unbilled Sales
- **Value**: 192350006 **Label**: Billed Sales
- **Value**: 192350007 **Label**: Resourcing Unit Cost
- **Value**: 192350008 **Label**: Inter-Organizational Sales



### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the project contract line milestone.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the project contract line milestone.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Shows the currency associated with the entity.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_amount_after_tax](#BKMK_msdyn_amount_after_tax)
- [msdyn_amount_after_tax_Base](#BKMK_msdyn_amount_after_tax_Base)
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_contractName](#BKMK_msdyn_contractName)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_projectName](#BKMK_msdyn_projectName)
- [msdyn_projecttaskName](#BKMK_msdyn_projecttaskName)
- [msdyn_tax_Base](#BKMK_msdyn_tax_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_amount_after_tax"></a> msdyn_amount_after_tax

**Description**: <br />
**DisplayName**: amount_after_tax<br />
**LogicalName**: msdyn_amount_after_tax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_amount_after_tax_Base"></a> msdyn_amount_after_tax_Base

**Description**: Value of the amount_after_tax in base currency.<br />
**DisplayName**: amount_after_tax (Base)<br />
**LogicalName**: msdyn_amount_after_tax_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_amount_Base"></a> msdyn_amount_Base

**Description**: Value of the Amount in base currency.<br />
**DisplayName**: Amount (Base)<br />
**LogicalName**: msdyn_amount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_contractName"></a> msdyn_contractName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_contractname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_msdyn_price_Base"></a> msdyn_price_Base

**Description**: Value of the Price in base currency.<br />
**DisplayName**: Price (Base)<br />
**LogicalName**: msdyn_price_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_projectName"></a> msdyn_projectName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_projectname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_projecttaskName"></a> msdyn_projecttaskName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_projecttaskname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_msdyn_tax_Base"></a> msdyn_tax_Base

**Description**: Value of the tax in base currency.<br />
**DisplayName**: tax (Base)<br />
**LogicalName**: msdyn_tax_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_contractlinescheduleofvalue_SyncErrors](#BKMK_msdyn_contractlinescheduleofvalue_SyncErrors)
- [msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord](#BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord)
- [msdyn_contractlinescheduleofvalue_DuplicateBaseRecord](#BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord)
- [msdyn_contractlinescheduleofvalue_AsyncOperations](#BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations)
- [msdyn_contractlinescheduleofvalue_MailboxTrackingFolders](#BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders)
- [msdyn_contractlinescheduleofvalue_UserEntityInstanceDatas](#BKMK_msdyn_contractlinescheduleofvalue_UserEntityInstanceDatas)
- [msdyn_contractlinescheduleofvalue_ProcessSession](#BKMK_msdyn_contractlinescheduleofvalue_ProcessSession)
- [msdyn_contractlinescheduleofvalue_BulkDeleteFailures](#BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures)
- [msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses)
- [msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule](#BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule)


### <a name="BKMK_msdyn_contractlinescheduleofvalue_SyncErrors"></a> msdyn_contractlinescheduleofvalue_SyncErrors

Same as syncerror entity [msdyn_contractlinescheduleofvalue_SyncErrors](syncerror.md#BKMK_msdyn_contractlinescheduleofvalue_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord"></a> msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord"></a> msdyn_contractlinescheduleofvalue_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_contractlinescheduleofvalue_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations"></a> msdyn_contractlinescheduleofvalue_AsyncOperations

Same as asyncoperation entity [msdyn_contractlinescheduleofvalue_AsyncOperations](asyncoperation.md#BKMK_msdyn_contractlinescheduleofvalue_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders"></a> msdyn_contractlinescheduleofvalue_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_contractlinescheduleofvalue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_UserEntityInstanceDatas"></a> msdyn_contractlinescheduleofvalue_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_contractlinescheduleofvalue_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_contractlinescheduleofvalue_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_ProcessSession"></a> msdyn_contractlinescheduleofvalue_ProcessSession

Same as processsession entity [msdyn_contractlinescheduleofvalue_ProcessSession](processsession.md#BKMK_msdyn_contractlinescheduleofvalue_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures"></a> msdyn_contractlinescheduleofvalue_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_contractlinescheduleofvalue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses"></a> msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule"></a> msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule

Same as msdyn_contractlineinvoiceschedule entity [msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule) Many-To-One relationship.

**ReferencingEntity**: msdyn_contractlineinvoiceschedule<br />
**ReferencingAttribute**: msdyn_contractlinescheduleofvalue<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_contractlinescheduleofvalue_createdby](#BKMK_lk_msdyn_contractlinescheduleofvalue_createdby)
- [lk_msdyn_contractlinescheduleofvalue_createdonbehalfby](#BKMK_lk_msdyn_contractlinescheduleofvalue_createdonbehalfby)
- [lk_msdyn_contractlinescheduleofvalue_modifiedby](#BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedby)
- [lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby](#BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby)
- [user_msdyn_contractlinescheduleofvalue](#BKMK_user_msdyn_contractlinescheduleofvalue)
- [team_msdyn_contractlinescheduleofvalue](#BKMK_team_msdyn_contractlinescheduleofvalue)
- [business_unit_msdyn_contractlinescheduleofvalue](#BKMK_business_unit_msdyn_contractlinescheduleofvalue)
- [TransactionCurrency_msdyn_contractlinescheduleofvalue](#BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue)
- [msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project](#BKMK_msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project)
- [msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask](#BKMK_msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask)
- [msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract](#BKMK_msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract)


### <a name="BKMK_lk_msdyn_contractlinescheduleofvalue_createdby"></a> lk_msdyn_contractlinescheduleofvalue_createdby

See systemuser Entity [lk_msdyn_contractlinescheduleofvalue_createdby](systemuser.md#BKMK_lk_msdyn_contractlinescheduleofvalue_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlinescheduleofvalue_createdonbehalfby"></a> lk_msdyn_contractlinescheduleofvalue_createdonbehalfby

See systemuser Entity [lk_msdyn_contractlinescheduleofvalue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_contractlinescheduleofvalue_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedby"></a> lk_msdyn_contractlinescheduleofvalue_modifiedby

See systemuser Entity [lk_msdyn_contractlinescheduleofvalue_modifiedby](systemuser.md#BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby"></a> lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby

See systemuser Entity [lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_contractlinescheduleofvalue"></a> user_msdyn_contractlinescheduleofvalue

See systemuser Entity [user_msdyn_contractlinescheduleofvalue](systemuser.md#BKMK_user_msdyn_contractlinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_team_msdyn_contractlinescheduleofvalue"></a> team_msdyn_contractlinescheduleofvalue

See team Entity [team_msdyn_contractlinescheduleofvalue](team.md#BKMK_team_msdyn_contractlinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_contractlinescheduleofvalue"></a> business_unit_msdyn_contractlinescheduleofvalue

See businessunit Entity [business_unit_msdyn_contractlinescheduleofvalue](businessunit.md#BKMK_business_unit_msdyn_contractlinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue"></a> TransactionCurrency_msdyn_contractlinescheduleofvalue

See transactioncurrency Entity [TransactionCurrency_msdyn_contractlinescheduleofvalue](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_contractlinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project"></a> msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask"></a> msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract"></a> msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract

See salesorder Entity [msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract](salesorder.md#BKMK_msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_contractlinescheduleofvalue?text=msdyn_contractlinescheduleofvalue EntityType" />