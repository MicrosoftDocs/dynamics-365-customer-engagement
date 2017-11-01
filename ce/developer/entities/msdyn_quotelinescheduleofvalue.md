---
title: "msdyn_quotelinescheduleofvalue Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_quotelinescheduleofvalue entity."
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
# msdyn_quotelinescheduleofvalue Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

List of billing milestones and invoice amounts for this quote line.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_quotelinescheduleofvalues(*msdyn_quotelinescheduleofvalueid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Quote Line Milestone<br />
**DisplayCollectionName**: Quote Line Milestones<br />
**SchemaName**: msdyn_quotelinescheduleofvalue<br />
**CollectionSchemaName**: msdyn_quotelinescheduleofvalues<br />
**LogicalName**: msdyn_quotelinescheduleofvalue<br />
**LogicalCollectionName**: msdyn_quotelinescheduleofvalues<br />
**EntitySetName**: msdyn_quotelinescheduleofvalues<br />
**PrimaryIdAttribute**: msdyn_quotelinescheduleofvalueid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_amount](#BKMK_msdyn_amount)
- [msdyn_invoicedate](#BKMK_msdyn_invoicedate)
- [msdyn_invoicestatus](#BKMK_msdyn_invoicestatus)
- [msdyn_isdataimport](#BKMK_msdyn_isdataimport)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_projecttask](#BKMK_msdyn_projecttask)
- [msdyn_quoteline](#BKMK_msdyn_quoteline)
- [msdyn_quotelinescheduleofvalueId](#BKMK_msdyn_quotelinescheduleofvalueId)
- [msdyn_tax](#BKMK_msdyn_tax)
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

**Description**: Enter the value of the amount on the billing milestone.<br />
**DisplayName**: Amount<br />
**LogicalName**: msdyn_amount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_msdyn_invoicedate"></a> msdyn_invoicedate

**Description**: Enter the date on which the milestone is to be invoiced. This, in conjunction with the Invoice status, will be used by the invoice creation job.<br />
**DisplayName**: Milestone Date<br />
**LogicalName**: msdyn_invoicedate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_invoicestatus"></a> msdyn_invoicestatus

**Description**: Select whether this milestone was invoiced. Valid values are Not ready for invoicing, Ready for Invoicing, On an invoice, and Invoiced.<br />
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



### <a name="BKMK_msdyn_isdataimport"></a> msdyn_isdataimport

**Description**: Indicates if this record was created via import. It's purpose is to support data import.<br />
**DisplayName**: isdataimport<br />
**LogicalName**: msdyn_isdataimport<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Type the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_projecttask"></a> msdyn_projecttask

**Description**: Select the project task that is tracking the work for this billing milestone.<br />
**DisplayName**: Project Task<br />
**LogicalName**: msdyn_projecttask<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_projecttask


### <a name="BKMK_msdyn_quoteline"></a> msdyn_quoteline

**Description**: Shows a reference to the quote line that this milestone schedule belongs to.<br />
**DisplayName**: Quote Line<br />
**LogicalName**: msdyn_quoteline<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_quotelinescheduleofvalueId"></a> msdyn_quotelinescheduleofvalueId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Quote Line Schedule Of Value<br />
**LogicalName**: msdyn_quotelinescheduleofvalueid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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

**Description**: Status of the Quote Line Schedule Of Value<br />
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

**Description**: Reason for the status of the Quote Line Schedule Of Value<br />
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

- [msdyn_quotelinescheduleofvalue_SyncErrors](#BKMK_msdyn_quotelinescheduleofvalue_SyncErrors)
- [msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord](#BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord)
- [msdyn_quotelinescheduleofvalue_DuplicateBaseRecord](#BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord)
- [msdyn_quotelinescheduleofvalue_AsyncOperations](#BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations)
- [msdyn_quotelinescheduleofvalue_MailboxTrackingFolders](#BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders)
- [msdyn_quotelinescheduleofvalue_UserEntityInstanceDatas](#BKMK_msdyn_quotelinescheduleofvalue_UserEntityInstanceDatas)
- [msdyn_quotelinescheduleofvalue_ProcessSession](#BKMK_msdyn_quotelinescheduleofvalue_ProcessSession)
- [msdyn_quotelinescheduleofvalue_BulkDeleteFailures](#BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures)
- [msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue](#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue)
- [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue](#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue)


### <a name="BKMK_msdyn_quotelinescheduleofvalue_SyncErrors"></a> msdyn_quotelinescheduleofvalue_SyncErrors

Same as syncerror entity [msdyn_quotelinescheduleofvalue_SyncErrors](syncerror.md#BKMK_msdyn_quotelinescheduleofvalue_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_SyncErrors<br />
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


### <a name="BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord"></a> msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord"></a> msdyn_quotelinescheduleofvalue_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_quotelinescheduleofvalue_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations"></a> msdyn_quotelinescheduleofvalue_AsyncOperations

Same as asyncoperation entity [msdyn_quotelinescheduleofvalue_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotelinescheduleofvalue_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_AsyncOperations<br />
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


### <a name="BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders"></a> msdyn_quotelinescheduleofvalue_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_quotelinescheduleofvalue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_quotelinescheduleofvalue_UserEntityInstanceDatas"></a> msdyn_quotelinescheduleofvalue_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_quotelinescheduleofvalue_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_quotelinescheduleofvalue_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_quotelinescheduleofvalue_ProcessSession"></a> msdyn_quotelinescheduleofvalue_ProcessSession

Same as processsession entity [msdyn_quotelinescheduleofvalue_ProcessSession](processsession.md#BKMK_msdyn_quotelinescheduleofvalue_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_ProcessSession<br />
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


### <a name="BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures"></a> msdyn_quotelinescheduleofvalue_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_quotelinescheduleofvalue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses"></a> msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue"></a> msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue

Same as msdyn_quotelineanalyticsbreakdown entity [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineanalyticsbreakdown<br />
**ReferencingAttribute**: msdyn_quotelinescheduleofvalue<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue"></a> msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue

Same as msdyn_quotelineinvoiceschedule entity [msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineinvoiceschedule<br />
**ReferencingAttribute**: msdyn_quotelinescheduleofvalue<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineinvoiceschedule_QuoteLineScheduleOfValue<br />
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

- [lk_msdyn_quotelinescheduleofvalue_createdby](#BKMK_lk_msdyn_quotelinescheduleofvalue_createdby)
- [lk_msdyn_quotelinescheduleofvalue_createdonbehalfby](#BKMK_lk_msdyn_quotelinescheduleofvalue_createdonbehalfby)
- [lk_msdyn_quotelinescheduleofvalue_modifiedby](#BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedby)
- [lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby](#BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby)
- [user_msdyn_quotelinescheduleofvalue](#BKMK_user_msdyn_quotelinescheduleofvalue)
- [team_msdyn_quotelinescheduleofvalue](#BKMK_team_msdyn_quotelinescheduleofvalue)
- [business_unit_msdyn_quotelinescheduleofvalue](#BKMK_business_unit_msdyn_quotelinescheduleofvalue)
- [TransactionCurrency_msdyn_quotelinescheduleofvalue](#BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue)
- [msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask](#BKMK_msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask)


### <a name="BKMK_lk_msdyn_quotelinescheduleofvalue_createdby"></a> lk_msdyn_quotelinescheduleofvalue_createdby

See systemuser Entity [lk_msdyn_quotelinescheduleofvalue_createdby](systemuser.md#BKMK_lk_msdyn_quotelinescheduleofvalue_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinescheduleofvalue_createdonbehalfby"></a> lk_msdyn_quotelinescheduleofvalue_createdonbehalfby

See systemuser Entity [lk_msdyn_quotelinescheduleofvalue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelinescheduleofvalue_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedby"></a> lk_msdyn_quotelinescheduleofvalue_modifiedby

See systemuser Entity [lk_msdyn_quotelinescheduleofvalue_modifiedby](systemuser.md#BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby"></a> lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby

See systemuser Entity [lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotelinescheduleofvalue_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_quotelinescheduleofvalue"></a> user_msdyn_quotelinescheduleofvalue

See systemuser Entity [user_msdyn_quotelinescheduleofvalue](systemuser.md#BKMK_user_msdyn_quotelinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_team_msdyn_quotelinescheduleofvalue"></a> team_msdyn_quotelinescheduleofvalue

See team Entity [team_msdyn_quotelinescheduleofvalue](team.md#BKMK_team_msdyn_quotelinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_quotelinescheduleofvalue"></a> business_unit_msdyn_quotelinescheduleofvalue

See businessunit Entity [business_unit_msdyn_quotelinescheduleofvalue](businessunit.md#BKMK_business_unit_msdyn_quotelinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue"></a> TransactionCurrency_msdyn_quotelinescheduleofvalue

See transactioncurrency Entity [TransactionCurrency_msdyn_quotelinescheduleofvalue](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotelinescheduleofvalue) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask"></a> msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_quotelinescheduleofvalue?text=msdyn_quotelinescheduleofvalue EntityType" />