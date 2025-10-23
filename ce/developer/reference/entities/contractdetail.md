---
title: "Contract Line (ContractDetail) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Contract Line (ContractDetail) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Contract Line (ContractDetail) table/entity reference (Microsoft Dynamics 365)

Line item in a contract that specifies the type of service a customer is entitled to.

## Messages

The following table lists the messages for the Contract Line (ContractDetail) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /contractdetails<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /contractdetails(*contractdetailid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /contractdetails(*contractdetailid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /contractdetails<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /contractdetails(*contractdetailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /contractdetails(*contractdetailid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /contractdetails(*contractdetailid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Contract Line (ContractDetail) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Contract Line** |
| **DisplayCollectionName** | **Contract Lines** |
| **SchemaName** | `ContractDetail` |
| **CollectionSchemaName** | `ContractDetails` |
| **EntitySetName** | `contractdetails`|
| **LogicalName** | `contractdetail` |
| **LogicalCollectionName** | `contractdetails` |
| **PrimaryIdAttribute** | `contractdetailid` |
| **PrimaryNameAttribute** |`title` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

|Property|Value|
|---|---|
|Description|**Enter the date when the contract line becomes active.**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activeon`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ContractDetailId"></a> ContractDetailId

|Property|Value|
|---|---|
|Description|**Unique identifier of the contract line.**|
|DisplayName|**Contract Line**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contractdetailid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ContractId"></a> ContractId

|Property|Value|
|---|---|
|Description|**Unique identifier of the contract associated with the contract line.**|
|DisplayName|**Contract**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contractid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|contract|

### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|---|---|
|Description|**Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.**|
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

### <a name="BKMK_Discount"></a> Discount

|Property|Value|
|---|---|
|Description|**Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.**|
|DisplayName|**Discount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_DiscountPercentage"></a> DiscountPercentage

|Property|Value|
|---|---|
|Description|**Type the discount rate that should be applied to the Total Price, for use in calculating the net amount due for the contract line.**|
|DisplayName|**Discount (%)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discountpercentage`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100|
|MinValue|0|
|Precision|5|
|SourceTypeMask|0|

### <a name="BKMK_EffectivityCalendar"></a> EffectivityCalendar

|Property|Value|
|---|---|
|Description|**Days of the week and times for which the contract line item is effective.**|
|DisplayName|**Support Calendar**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`effectivitycalendar`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|168|

### <a name="BKMK_ExpiresOn"></a> ExpiresOn

|Property|Value|
|---|---|
|Description|**Enter the date when the contract line expires. The date is automatically filled with the contract date, but you can change it if required.**|
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`expireson`|
|RequiredLevel|SystemRequired|
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

### <a name="BKMK_InitialQuantity"></a> InitialQuantity

|Property|Value|
|---|---|
|Description|**Type the number of units of the specified product or service that are eligible for support on the contract line.**|
|DisplayName|**Quantity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`initialquantity`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_LineItemOrder"></a> LineItemOrder

|Property|Value|
|---|---|
|Description|**Type the line item number for the contract line to easily identify the contract line and make sure it's listed in the correct order in the parent contract.**|
|DisplayName|**Line Item Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lineitemorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

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

### <a name="BKMK_Price"></a> Price

|Property|Value|
|---|---|
|Description|**Type the total service charge for the contract line before any discounts are credited.**|
|DisplayName|**Total Price**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`price`|
|RequiredLevel|SystemRequired|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|---|---|
|Description|**Choose the product that is eligible for services on the contract line.**|
|DisplayName|**Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_ProductSerialNumber"></a> ProductSerialNumber

|Property|Value|
|---|---|
|Description|**Type the serial number for the product that is eligible for services on the contract line.**|
|DisplayName|**Serial Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productserialnumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ServiceAddress"></a> ServiceAddress

|Property|Value|
|---|---|
|Description|**Choose the address for the customer account or contact where the services are provided.**|
|DisplayName|**Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`serviceaddress`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|customeraddress|

### <a name="BKMK_ServiceContractUnitsCode"></a> ServiceContractUnitsCode

|Property|Value|
|---|---|
|Description|**Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.**|
|DisplayName|**Service Contract Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`servicecontractunitscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`contractdetail_servicecontractunitscode`|

#### ServiceContractUnitsCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it is saved, regardless of the status.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`contractdetail_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Existing**<br />DefaultStatus: 1<br />InvariantName: `Existing`|
|1|Label: **Renewed**<br />DefaultStatus: 2<br />InvariantName: `Renewed`|
|2|Label: **Canceled**<br />DefaultStatus: 3<br />InvariantName: `Canceled`|
|3|Label: **Expired**<br />DefaultStatus: 4<br />InvariantName: `Expired`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the contract line's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`contractdetail_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **New**<br />State:0<br />TransitionData: None|
|2|Label: **Renewed**<br />State:1<br />TransitionData: None|
|3|Label: **Canceled**<br />State:2<br />TransitionData: None|
|4|Label: **Expired**<br />State:3<br />TransitionData: None|

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

### <a name="BKMK_Title"></a> Title

|Property|Value|
|---|---|
|Description|**Type a title or name that describes the contract line.**|
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`title`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_TotalAllotments"></a> TotalAllotments

|Property|Value|
|---|---|
|Description|**Type the total number of minutes or cases allowed for the contract line.**|
|DisplayName|**Total Allotments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalallotments`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_UoMId"></a> UoMId

|Property|Value|
|---|---|
|Description|**Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`uomid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

|Property|Value|
|---|---|
|Description|**Unique identifier of the unit group associated with the contract line.**|
|DisplayName|**Unit Schedule**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`uomscheduleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|uomschedule|

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
- [AllotmentsOverage](#BKMK_AllotmentsOverage)
- [AllotmentsRemaining](#BKMK_AllotmentsRemaining)
- [AllotmentsUsed](#BKMK_AllotmentsUsed)
- [ContactId](#BKMK_ContactId)
- [ContractStateCode](#BKMK_ContractStateCode)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [Discount_Base](#BKMK_Discount_Base)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
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
- [Rate](#BKMK_Rate)
- [Rate_Base](#BKMK_Rate_Base)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|---|---|
|Description|**Unique identifier of the account with which the contract is associated.**|
|DisplayName|**Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_AllotmentsOverage"></a> AllotmentsOverage

|Property|Value|
|---|---|
|Description|**Shows the number of minutes over the Total Allotments field that have been spent on resolved cases related to the contract line.**|
|DisplayName|**Allotments Overage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`allotmentsoverage`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_AllotmentsRemaining"></a> AllotmentsRemaining

|Property|Value|
|---|---|
|Description|**Shows the number of cases or minutes remaining, based on the resolved cases logged to the contract line.**|
|DisplayName|**Allotments Remaining**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`allotmentsremaining`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_AllotmentsUsed"></a> AllotmentsUsed

|Property|Value|
|---|---|
|Description|**Shows the number of cases or minutes used in the resolved cases on the contract line.**|
|DisplayName|**Allotments Used**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`allotmentsused`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|---|---|
|Description|**Unique identifier for the contact associated with the contract line.**|
|DisplayName|**Contact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_ContractStateCode"></a> ContractStateCode

|Property|Value|
|---|---|
|Description|**Status of the contract.**|
|DisplayName|**Contract State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contractstatecode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`contractdetail_contractstatecode`|

#### ContractStateCode Choices/Options

|Value|Label|
|---|---|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Shows who created the record.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_Discount_Base"></a> Discount_Base

|Property|Value|
|---|---|
|Description|**Value of the Discount in base currency.**|
|DisplayName|**Discount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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
|Description|**Shows who last updated the record.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_Net"></a> Net

|Property|Value|
|---|---|
|Description|**Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.**|
|DisplayName|**Net**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`net`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_Net_Base"></a> Net_Base

|Property|Value|
|---|---|
|Description|**Value of the Net in base currency.**|
|DisplayName|**Net (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`net_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|ApplicationRequired|
|Type|Owner|
|Targets|systemuser, team|

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
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets||

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
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets||

### <a name="BKMK_Price_Base"></a> Price_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Price in base currency.**|
|DisplayName|**Total Price (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`price_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_Rate"></a> Rate

|Property|Value|
|---|---|
|Description|**Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or minutes allocated to the contract line.**|
|DisplayName|**Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`rate`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_Rate_Base"></a> Rate_Base

|Property|Value|
|---|---|
|Description|**Value of the Rate in base currency.**|
|DisplayName|**Rate (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`rate_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

- [contract_detail_unit_of_measure_schedule](#BKMK_contract_detail_unit_of_measure_schedule)
- [contract_line_items](#BKMK_contract_line_items)
- [contractlineitem_customer_accounts](#BKMK_contractlineitem_customer_accounts)
- [contractlineitem_customer_contacts](#BKMK_contractlineitem_customer_contacts)
- [customer_address_contract_line_items](#BKMK_customer_address_contract_line_items)
- [lk_contractdetail_createdonbehalfby](#BKMK_lk_contractdetail_createdonbehalfby)
- [lk_contractdetail_modifiedonbehalfby](#BKMK_lk_contractdetail_modifiedonbehalfby)
- [lk_contractdetailbase_createdby](#BKMK_lk_contractdetailbase_createdby)
- [lk_contractdetailbase_modifiedby](#BKMK_lk_contractdetailbase_modifiedby)
- [product_contract_line_items](#BKMK_product_contract_line_items)
- [team_contractdetail](#BKMK_team_contractdetail)
- [transactioncurrency_contractdetail](#BKMK_transactioncurrency_contractdetail)
- [unit_of_measurement_contract_line_items](#BKMK_unit_of_measurement_contract_line_items)
- [user_contractdetail](#BKMK_user_contractdetail)

### <a name="BKMK_contract_detail_unit_of_measure_schedule"></a> contract_detail_unit_of_measure_schedule

One-To-Many Relationship: [uomschedule contract_detail_unit_of_measure_schedule](uomschedule.md#BKMK_contract_detail_unit_of_measure_schedule)

|Property|Value|
|---|---|
|ReferencedEntity|`uomschedule`|
|ReferencedAttribute|`uomscheduleid`|
|ReferencingAttribute|`uomscheduleid`|
|ReferencingEntityNavigationPropertyName|`uomscheduleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_line_items"></a> contract_line_items

One-To-Many Relationship: [contract contract_line_items](contract.md#BKMK_contract_line_items)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`contractid`|
|ReferencingEntityNavigationPropertyName|`contractid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contractlineitem_customer_accounts"></a> contractlineitem_customer_accounts

One-To-Many Relationship: [account contractlineitem_customer_accounts](account.md#BKMK_contractlineitem_customer_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contractlineitem_customer_contacts"></a> contractlineitem_customer_contacts

One-To-Many Relationship: [contact contractlineitem_customer_contacts](contact.md#BKMK_contractlineitem_customer_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_customer_address_contract_line_items"></a> customer_address_contract_line_items

One-To-Many Relationship: [customeraddress customer_address_contract_line_items](customeraddress.md#BKMK_customer_address_contract_line_items)

|Property|Value|
|---|---|
|ReferencedEntity|`customeraddress`|
|ReferencedAttribute|`customeraddressid`|
|ReferencingAttribute|`serviceaddress`|
|ReferencingEntityNavigationPropertyName|`serviceaddress`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_contractdetail_createdonbehalfby"></a> lk_contractdetail_createdonbehalfby

One-To-Many Relationship: [systemuser lk_contractdetail_createdonbehalfby](systemuser.md#BKMK_lk_contractdetail_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_contractdetail_modifiedonbehalfby"></a> lk_contractdetail_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_contractdetail_modifiedonbehalfby](systemuser.md#BKMK_lk_contractdetail_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_contractdetailbase_createdby"></a> lk_contractdetailbase_createdby

One-To-Many Relationship: [systemuser lk_contractdetailbase_createdby](systemuser.md#BKMK_lk_contractdetailbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_contractdetailbase_modifiedby"></a> lk_contractdetailbase_modifiedby

One-To-Many Relationship: [systemuser lk_contractdetailbase_modifiedby](systemuser.md#BKMK_lk_contractdetailbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_contract_line_items"></a> product_contract_line_items

One-To-Many Relationship: [product product_contract_line_items](product.md#BKMK_product_contract_line_items)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`productid`|
|ReferencingEntityNavigationPropertyName|`productid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_contractdetail"></a> team_contractdetail

One-To-Many Relationship: [team team_contractdetail](team.md#BKMK_team_contractdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_contractdetail"></a> transactioncurrency_contractdetail

One-To-Many Relationship: [transactioncurrency transactioncurrency_contractdetail](transactioncurrency.md#BKMK_transactioncurrency_contractdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_unit_of_measurement_contract_line_items"></a> unit_of_measurement_contract_line_items

One-To-Many Relationship: [uom unit_of_measurement_contract_line_items](uom.md#BKMK_unit_of_measurement_contract_line_items)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`uomid`|
|ReferencingEntityNavigationPropertyName|`uomid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_contractdetail"></a> user_contractdetail

One-To-Many Relationship: [systemuser user_contractdetail](systemuser.md#BKMK_user_contractdetail)

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

- [contract_detail_cases](#BKMK_contract_detail_cases)
- [ContractDetail_Annotation](#BKMK_ContractDetail_Annotation)
- [ContractDetail_AsyncOperations](#BKMK_ContractDetail_AsyncOperations)
- [ContractDetail_BulkDeleteFailures](#BKMK_ContractDetail_BulkDeleteFailures)
- [contractdetail_MailboxTrackingFolders](#BKMK_contractdetail_MailboxTrackingFolders)
- [contractdetail_principalobjectattributeaccess](#BKMK_contractdetail_principalobjectattributeaccess)
- [ContractDetail_ProcessSessions](#BKMK_ContractDetail_ProcessSessions)
- [ContractDetail_SyncErrors](#BKMK_ContractDetail_SyncErrors)

### <a name="BKMK_contract_detail_cases"></a> contract_detail_cases

Many-To-One Relationship: [incident contract_detail_cases](incident.md#BKMK_contract_detail_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`contractdetailid`|
|ReferencedEntityNavigationPropertyName|`contract_detail_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMIncident.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010003501`|

### <a name="BKMK_ContractDetail_Annotation"></a> ContractDetail_Annotation

Many-To-One Relationship: [annotation ContractDetail_Annotation](annotation.md#BKMK_ContractDetail_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`ContractDetail_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ContractDetail_AsyncOperations"></a> ContractDetail_AsyncOperations

Many-To-One Relationship: [asyncoperation ContractDetail_AsyncOperations](asyncoperation.md#BKMK_ContractDetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ContractDetail_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ContractDetail_BulkDeleteFailures"></a> ContractDetail_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure ContractDetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ContractDetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ContractDetail_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contractdetail_MailboxTrackingFolders"></a> contractdetail_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder contractdetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_contractdetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contractdetail_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contractdetail_principalobjectattributeaccess"></a> contractdetail_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess contractdetail_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_contractdetail_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`contractdetail_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ContractDetail_ProcessSessions"></a> ContractDetail_ProcessSessions

Many-To-One Relationship: [processsession ContractDetail_ProcessSessions](processsession.md#BKMK_ContractDetail_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ContractDetail_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ContractDetail_SyncErrors"></a> ContractDetail_SyncErrors

Many-To-One Relationship: [syncerror ContractDetail_SyncErrors](syncerror.md#BKMK_ContractDetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ContractDetail_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

