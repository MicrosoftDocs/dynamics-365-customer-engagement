---
title: "ContractDetail Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ContractDetail entity."
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
# ContractDetail Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Line item in a contract that specifies the type of service a customer is entitled to.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/contractdetails<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/contractdetails(*contractdetailid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/contractdetails(*contractdetailid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/contractdetails<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/contractdetails(*contractdetailid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/contractdetails(*contractdetailid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Contract Line<br />
**DisplayCollectionName**: Contract Lines<br />
**SchemaName**: ContractDetail<br />
**CollectionSchemaName**: ContractDetails<br />
**LogicalName**: contractdetail<br />
**LogicalCollectionName**: contractdetails<br />
**EntitySetName**: contractdetails<br />
**PrimaryIdAttribute**: contractdetailid<br />
**PrimaryNameAttribute**: title<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActiveOn](#BKMK_ActiveOn)
- [ContractDetailId](#BKMK_ContractDetailId)
- [ContractId](#BKMK_ContractId)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [Discount](#BKMK_Discount)
- [DiscountPercentage](#BKMK_DiscountPercentage)
- [EffectivityCalendar](#BKMK_EffectivityCalendar)
- [ExpiresOn](#BKMK_ExpiresOn)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InitialQuantity](#BKMK_InitialQuantity)
- [LineItemOrder](#BKMK_LineItemOrder)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [Price](#BKMK_Price)
- [ProductId](#BKMK_ProductId)
- [ProductSerialNumber](#BKMK_ProductSerialNumber)
- [ServiceAddress](#BKMK_ServiceAddress)
- [ServiceContractUnitsCode](#BKMK_ServiceContractUnitsCode)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [Title](#BKMK_Title)
- [TotalAllotments](#BKMK_TotalAllotments)
- [UoMId](#BKMK_UoMId)
- [UoMScheduleId](#BKMK_UoMScheduleId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActiveOn"></a> ActiveOn

**Description**: Enter the date when the contract line becomes active.<br />
**DisplayName**: Start Date<br />
**LogicalName**: activeon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ContractDetailId"></a> ContractDetailId

**Description**: Unique identifier of the contract line.<br />
**DisplayName**: Contract Line<br />
**LogicalName**: contractdetailid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ContractId"></a> ContractId

**Description**: Unique identifier of the contract associated with the contract line.<br />
**DisplayName**: Contract<br />
**LogicalName**: contractid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: contract


### <a name="BKMK_CustomerId"></a> CustomerId

**Description**: Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.<br />
**DisplayName**: Customer<br />
**LogicalName**: customerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Customer<br />
**Targets**: account,contact


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Description**: <br />
**DisplayName**: Customer Type<br />
**LogicalName**: customeridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_Discount"></a> Discount

**Description**: Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.<br />
**DisplayName**: Discount<br />
**LogicalName**: discount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_DiscountPercentage"></a> DiscountPercentage

**Description**: Type the discount rate that should be applied to the Total Price, for use in calculating the net amount due for the contract line.<br />
**DisplayName**: Discount (%)<br />
**LogicalName**: discountpercentage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100<br />
**MinValue**: 0<br />
**Precision**: 5


### <a name="BKMK_EffectivityCalendar"></a> EffectivityCalendar

**Description**: Days of the week and times for which the contract line item is effective.<br />
**DisplayName**: Support Calendar<br />
**LogicalName**: effectivitycalendar<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 168


### <a name="BKMK_ExpiresOn"></a> ExpiresOn

**Description**: Enter the date when the contract line expires. The date is automatically filled with the contract date, but you can change it if required.<br />
**DisplayName**: End Date<br />
**LogicalName**: expireson<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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


### <a name="BKMK_InitialQuantity"></a> InitialQuantity

**Description**: Type the number of units of the specified product or service that are eligible for support on the contract line.<br />
**DisplayName**: Quantity<br />
**LogicalName**: initialquantity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_LineItemOrder"></a> LineItemOrder

**Description**: Type the line item number for the contract line to easily identify the contract line and make sure it's listed in the correct order in the parent contract.<br />
**DisplayName**: Line Item Order<br />
**LogicalName**: lineitemorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


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


### <a name="BKMK_Price"></a> Price

**Description**: Type the total service charge for the contract line before any discounts are credited.<br />
**DisplayName**: Total Price<br />
**LogicalName**: price<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Money<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_ProductId"></a> ProductId

**Description**: Choose the product that is eligible for services on the contract line.<br />
**DisplayName**: Product<br />
**LogicalName**: productid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_ProductSerialNumber"></a> ProductSerialNumber

**Description**: Type the serial number for the product that is eligible for services on the contract line.<br />
**DisplayName**: Serial Number<br />
**LogicalName**: productserialnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ServiceAddress"></a> ServiceAddress

**Description**: Choose the address for the customer account or contact where the services are provided.<br />
**DisplayName**: Location<br />
**LogicalName**: serviceaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: customeraddress


### <a name="BKMK_ServiceContractUnitsCode"></a> ServiceContractUnitsCode

**Description**: Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.<br />
**DisplayName**: Service Contract Units<br />
**LogicalName**: servicecontractunitscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it is saved, regardless of the status.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Existing **DefaultStatus**: 1 **InvariantName**: Existing
- **Value**: 1 **Label**: Renewed **DefaultStatus**: 2 **InvariantName**: Renewed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 3 **InvariantName**: Canceled
- **Value**: 3 **Label**: Expired **DefaultStatus**: 4 **InvariantName**: Expired



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the contract line's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: New **State**: 0
- **Value**: 2 **Label**: Renewed **State**: 1
- **Value**: 3 **Label**: Canceled **State**: 2
- **Value**: 4 **Label**: Expired **State**: 3



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
**MinValue**: -2147483648


### <a name="BKMK_Title"></a> Title

**Description**: Type a title or name that describes the contract line.<br />
**DisplayName**: Title<br />
**LogicalName**: title<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 500


### <a name="BKMK_TotalAllotments"></a> TotalAllotments

**Description**: Type the total number of minutes or cases allowed for the contract line.<br />
**DisplayName**: Total Allotments<br />
**LogicalName**: totalallotments<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_UoMId"></a> UoMId

**Description**: Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.<br />
**DisplayName**: Unit<br />
**LogicalName**: uomid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

**Description**: Unique identifier of the unit group associated with the contract line.<br />
**DisplayName**: Unit Schedule<br />
**LogicalName**: uomscheduleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uomschedule


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
**MinValue**: -2147483648

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [AllotmentsOverage](#BKMK_AllotmentsOverage)
- [AllotmentsRemaining](#BKMK_AllotmentsRemaining)
- [AllotmentsUsed](#BKMK_AllotmentsUsed)
- [ContactId](#BKMK_ContactId)
- [ContractIdName](#BKMK_ContractIdName)
- [ContractStateCode](#BKMK_ContractStateCode)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [Discount_Base](#BKMK_Discount_Base)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [Net](#BKMK_Net)
- [Net_Base](#BKMK_Net_Base)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [Price_Base](#BKMK_Price_Base)
- [ProductIdName](#BKMK_ProductIdName)
- [Rate](#BKMK_Rate)
- [Rate_Base](#BKMK_Rate_Base)
- [ServiceAddressName](#BKMK_ServiceAddressName)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [UoMIdName](#BKMK_UoMIdName)
- [UoMScheduleIdName](#BKMK_UoMScheduleIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AccountId"></a> AccountId

**Description**: Unique identifier of the account with which the contract is associated.<br />
**DisplayName**: Account<br />
**LogicalName**: accountid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_AllotmentsOverage"></a> AllotmentsOverage

**Description**: Shows the number of minutes over the Total Allotments field that have been spent on resolved cases related to the contract line.<br />
**DisplayName**: Allotments Overage<br />
**LogicalName**: allotmentsoverage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_AllotmentsRemaining"></a> AllotmentsRemaining

**Description**: Shows the number of cases or minutes remaining, based on the resolved cases logged to the contract line.<br />
**DisplayName**: Allotments Remaining<br />
**LogicalName**: allotmentsremaining<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_AllotmentsUsed"></a> AllotmentsUsed

**Description**: Shows the number of cases or minutes used in the resolved cases on the contract line.<br />
**DisplayName**: Allotments Used<br />
**LogicalName**: allotmentsused<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_ContactId"></a> ContactId

**Description**: Unique identifier for the contact associated with the contract line.<br />
**DisplayName**: Contact<br />
**LogicalName**: contactid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_ContractIdName"></a> ContractIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: contractidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ContractStateCode"></a> ContractStateCode

**Description**: Status of the contract.<br />
**DisplayName**: Contract State<br />
**LogicalName**: contractstatecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:




### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
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
**RequiredLevel**: None<br />
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
**Format**: DateOnly


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: customeridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: customeridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_Discount_Base"></a> Discount_Base

**Description**: Value of the Discount in base currency.<br />
**DisplayName**: Discount (Base)<br />
**LogicalName**: discount_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
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

**Description**: Shows who last updated the record.<br />
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
**RequiredLevel**: None<br />
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
**Format**: DateOnly


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
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
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Net"></a> Net

**Description**: Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.<br />
**DisplayName**: Net<br />
**LogicalName**: net<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_Net_Base"></a> Net_Base

**Description**: Value of the Net in base currency.<br />
**DisplayName**: Net (Base)<br />
**LogicalName**: net_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


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


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


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
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: 


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
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: 


### <a name="BKMK_Price_Base"></a> Price_Base

**Description**: Value of the Total Price in base currency.<br />
**DisplayName**: Total Price (Base)<br />
**LogicalName**: price_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_ProductIdName"></a> ProductIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: productidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Rate"></a> Rate

**Description**: Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or minutes allocated to the contract line.<br />
**DisplayName**: Rate<br />
**LogicalName**: rate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 100000000000000<br />
**MinValue**: 0<br />
**Precision**: 2<br />
**PrecisionSource**: 2


### <a name="BKMK_Rate_Base"></a> Rate_Base

**Description**: Value of the Rate in base currency.<br />
**DisplayName**: Rate (Base)<br />
**LogicalName**: rate_base<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Money<br />
**MaxValue**: 922337203685477<br />
**MinValue**: -922337203685477<br />
**Precision**: 4<br />
**PrecisionSource**: 2


### <a name="BKMK_ServiceAddressName"></a> ServiceAddressName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: serviceaddressname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


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


### <a name="BKMK_UoMIdName"></a> UoMIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: uomidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_UoMScheduleIdName"></a> UoMScheduleIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: uomscheduleidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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

- [ContractDetail_SyncErrors](#BKMK_ContractDetail_SyncErrors)
- [ContractDetail_AsyncOperations](#BKMK_ContractDetail_AsyncOperations)
- [contractdetail_MailboxTrackingFolders](#BKMK_contractdetail_MailboxTrackingFolders)
- [userentityinstancedata_contractdetail](#BKMK_userentityinstancedata_contractdetail)
- [ContractDetail_ProcessSessions](#BKMK_ContractDetail_ProcessSessions)
- [ContractDetail_BulkDeleteFailures](#BKMK_ContractDetail_BulkDeleteFailures)
- [contractdetail_principalobjectattributeaccess](#BKMK_contractdetail_principalobjectattributeaccess)
- [ContractDetail_Annotation](#BKMK_ContractDetail_Annotation)
- [contract_detail_cases](#BKMK_contract_detail_cases)


### <a name="BKMK_ContractDetail_SyncErrors"></a> ContractDetail_SyncErrors

Same as syncerror entity [ContractDetail_SyncErrors](syncerror.md#BKMK_ContractDetail_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ContractDetail_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_ContractDetail_AsyncOperations"></a> ContractDetail_AsyncOperations

Same as asyncoperation entity [ContractDetail_AsyncOperations](asyncoperation.md#BKMK_ContractDetail_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ContractDetail_AsyncOperations<br />
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


### <a name="BKMK_contractdetail_MailboxTrackingFolders"></a> contractdetail_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [contractdetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_contractdetail_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contractdetail_MailboxTrackingFolders<br />
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


### <a name="BKMK_userentityinstancedata_contractdetail"></a> userentityinstancedata_contractdetail

Same as userentityinstancedata entity [userentityinstancedata_contractdetail](userentityinstancedata.md#BKMK_userentityinstancedata_contractdetail) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_contractdetail<br />
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


### <a name="BKMK_ContractDetail_ProcessSessions"></a> ContractDetail_ProcessSessions

Same as processsession entity [ContractDetail_ProcessSessions](processsession.md#BKMK_ContractDetail_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ContractDetail_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_ContractDetail_BulkDeleteFailures"></a> ContractDetail_BulkDeleteFailures

Same as bulkdeletefailure entity [ContractDetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ContractDetail_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ContractDetail_BulkDeleteFailures<br />
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


### <a name="BKMK_contractdetail_principalobjectattributeaccess"></a> contractdetail_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [contractdetail_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_contractdetail_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: contractdetail_principalobjectattributeaccess<br />
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


### <a name="BKMK_ContractDetail_Annotation"></a> ContractDetail_Annotation

Same as annotation entity [ContractDetail_Annotation](annotation.md#BKMK_ContractDetail_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ContractDetail_Annotation<br />
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


### <a name="BKMK_contract_detail_cases"></a> contract_detail_cases

Same as incident entity [contract_detail_cases](incident.md#BKMK_contract_detail_cases) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: contractdetailid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: contract_detail_cases<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_contractdetailbase_createdby](#BKMK_lk_contractdetailbase_createdby)
- [lk_contractdetail_createdonbehalfby](#BKMK_lk_contractdetail_createdonbehalfby)
- [lk_contractdetailbase_modifiedby](#BKMK_lk_contractdetailbase_modifiedby)
- [lk_contractdetail_modifiedonbehalfby](#BKMK_lk_contractdetail_modifiedonbehalfby)
- [user_contractdetail](#BKMK_user_contractdetail)
- [team_contractdetail](#BKMK_team_contractdetail)
- [transactioncurrency_contractdetail](#BKMK_transactioncurrency_contractdetail)
- [contractlineitem_customer_accounts](#BKMK_contractlineitem_customer_accounts)
- [contractlineitem_customer_contacts](#BKMK_contractlineitem_customer_contacts)
- [contract_line_items](#BKMK_contract_line_items)
- [customer_address_contract_line_items](#BKMK_customer_address_contract_line_items)
- [product_contract_line_items](#BKMK_product_contract_line_items)
- [unit_of_measurement_contract_line_items](#BKMK_unit_of_measurement_contract_line_items)
- [contract_detail_unit_of_measure_schedule](#BKMK_contract_detail_unit_of_measure_schedule)


### <a name="BKMK_lk_contractdetailbase_createdby"></a> lk_contractdetailbase_createdby

See systemuser Entity [lk_contractdetailbase_createdby](systemuser.md#BKMK_lk_contractdetailbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_contractdetail_createdonbehalfby"></a> lk_contractdetail_createdonbehalfby

See systemuser Entity [lk_contractdetail_createdonbehalfby](systemuser.md#BKMK_lk_contractdetail_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_contractdetailbase_modifiedby"></a> lk_contractdetailbase_modifiedby

See systemuser Entity [lk_contractdetailbase_modifiedby](systemuser.md#BKMK_lk_contractdetailbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_contractdetail_modifiedonbehalfby"></a> lk_contractdetail_modifiedonbehalfby

See systemuser Entity [lk_contractdetail_modifiedonbehalfby](systemuser.md#BKMK_lk_contractdetail_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_contractdetail"></a> user_contractdetail

See systemuser Entity [user_contractdetail](systemuser.md#BKMK_user_contractdetail) One-To-Many relationship.

### <a name="BKMK_team_contractdetail"></a> team_contractdetail

See team Entity [team_contractdetail](team.md#BKMK_team_contractdetail) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_contractdetail"></a> transactioncurrency_contractdetail

See transactioncurrency Entity [transactioncurrency_contractdetail](transactioncurrency.md#BKMK_transactioncurrency_contractdetail) One-To-Many relationship.

### <a name="BKMK_contractlineitem_customer_accounts"></a> contractlineitem_customer_accounts

See account Entity [contractlineitem_customer_accounts](account.md#BKMK_contractlineitem_customer_accounts) One-To-Many relationship.

### <a name="BKMK_contractlineitem_customer_contacts"></a> contractlineitem_customer_contacts

See contact Entity [contractlineitem_customer_contacts](contact.md#BKMK_contractlineitem_customer_contacts) One-To-Many relationship.

### <a name="BKMK_contract_line_items"></a> contract_line_items

See contract Entity [contract_line_items](contract.md#BKMK_contract_line_items) One-To-Many relationship.

### <a name="BKMK_customer_address_contract_line_items"></a> customer_address_contract_line_items

See customeraddress Entity [customer_address_contract_line_items](customeraddress.md#BKMK_customer_address_contract_line_items) One-To-Many relationship.

### <a name="BKMK_product_contract_line_items"></a> product_contract_line_items

See product Entity [product_contract_line_items](product.md#BKMK_product_contract_line_items) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_contract_line_items"></a> unit_of_measurement_contract_line_items

See uom Entity [unit_of_measurement_contract_line_items](uom.md#BKMK_unit_of_measurement_contract_line_items) One-To-Many relationship.

### <a name="BKMK_contract_detail_unit_of_measure_schedule"></a> contract_detail_unit_of_measure_schedule

See uomschedule Entity [contract_detail_unit_of_measure_schedule](uomschedule.md#BKMK_contract_detail_unit_of_measure_schedule) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.contractdetail?text=contractdetail EntityType" />