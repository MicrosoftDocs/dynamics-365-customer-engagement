---
title: "ContractDetail Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ContractDetail entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# ContractDetail Entity Reference

Line item in a contract that specifies the type of service a customer is entitled to.

**Added by**: Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/contractdetails<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/contractdetails(*contractdetailid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/contractdetails(*contractdetailid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/contractdetails<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/contractdetails(*contractdetailid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/contractdetails(*contractdetailid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ContractDetails|
|DisplayCollectionName|Contract Lines|
|DisplayName|Contract Line|
|EntitySetName|contractdetails|
|IsBPFEntity|False|
|LogicalCollectionName|contractdetails|
|LogicalName|contractdetail|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|contractdetailid|
|PrimaryNameAttribute|title|
|SchemaName|ContractDetail|

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

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the contract line becomes active.|
|DisplayName|Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activeon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_ContractDetailId"></a> ContractDetailId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the contract line.|
|DisplayName|Contract Line|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|contractdetailid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ContractId"></a> ContractId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the contract associated with the contract line.|
|DisplayName|Contract|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contractid|
|RequiredLevel|SystemRequired|
|Targets|contract|
|Type|Lookup|


### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|SystemRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_Discount"></a> Discount

|Property|Value|
|--------|-----|
|Description|Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.|
|DisplayName|Discount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discount|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_DiscountPercentage"></a> DiscountPercentage

|Property|Value|
|--------|-----|
|Description|Type the discount rate that should be applied to the Total Price, for use in calculating the net amount due for the contract line.|
|DisplayName|Discount (%)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountpercentage|
|MaxValue|100|
|MinValue|0|
|Precision|5|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_EffectivityCalendar"></a> EffectivityCalendar

|Property|Value|
|--------|-----|
|Description|Days of the week and times for which the contract line item is effective.|
|DisplayName|Support Calendar|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|effectivitycalendar|
|MaxLength|168|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExpiresOn"></a> ExpiresOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the contract line expires. The date is automatically filled with the contract date, but you can change it if required.|
|DisplayName|End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|expireson|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_InitialQuantity"></a> InitialQuantity

|Property|Value|
|--------|-----|
|Description|Type the number of units of the specified product or service that are eligible for support on the contract line.|
|DisplayName|Quantity|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|initialquantity|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_LineItemOrder"></a> LineItemOrder

|Property|Value|
|--------|-----|
|Description|Type the line item number for the contract line to easily identify the contract line and make sure it's listed in the correct order in the parent contract.|
|DisplayName|Line Item Order|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lineitemorder|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Price"></a> Price

|Property|Value|
|--------|-----|
|Description|Type the total service charge for the contract line before any discounts are credited.|
|DisplayName|Total Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|price|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|SystemRequired|
|Type|Money|


### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|--------|-----|
|Description|Choose the product that is eligible for services on the contract line.|
|DisplayName|Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|productid|
|RequiredLevel|None|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_ProductSerialNumber"></a> ProductSerialNumber

|Property|Value|
|--------|-----|
|Description|Type the serial number for the product that is eligible for services on the contract line.|
|DisplayName|Serial Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|productserialnumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ServiceAddress"></a> ServiceAddress

|Property|Value|
|--------|-----|
|Description|Choose the address for the customer account or contact where the services are provided.|
|DisplayName|Location|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|serviceaddress|
|RequiredLevel|None|
|Targets|customeraddress|
|Type|Lookup|


### <a name="BKMK_ServiceContractUnitsCode"></a> ServiceContractUnitsCode

|Property|Value|
|--------|-----|
|Description|Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.|
|DisplayName|Service Contract Units|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|servicecontractunitscode|
|RequiredLevel|None|
|Type|Picklist|

#### ServiceContractUnitsCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it is saved, regardless of the status.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Existing|1|Existing|
|1|Renewed|2|Renewed|
|2|Canceled|3|Canceled|
|3|Expired|4|Expired|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the contract line's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|New|0|
|2|Renewed|1|
|3|Canceled|2|
|4|Expired|3|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Title"></a> Title

|Property|Value|
|--------|-----|
|Description|Type a title or name that describes the contract line.|
|DisplayName|Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|title|
|MaxLength|500|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_TotalAllotments"></a> TotalAllotments

|Property|Value|
|--------|-----|
|Description|Type the total number of minutes or cases allowed for the contract line.|
|DisplayName|Total Allotments|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalallotments|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_UoMId"></a> UoMId

|Property|Value|
|--------|-----|
|Description|Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.|
|DisplayName|Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|uomid|
|RequiredLevel|None|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the unit group associated with the contract line.|
|DisplayName|Unit Schedule|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uomscheduleid|
|RequiredLevel|None|
|Targets|uomschedule|
|Type|Lookup|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the account with which the contract is associated.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_AllotmentsOverage"></a> AllotmentsOverage

|Property|Value|
|--------|-----|
|Description|Shows the number of minutes over the Total Allotments field that have been spent on resolved cases related to the contract line.|
|DisplayName|Allotments Overage|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|allotmentsoverage|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_AllotmentsRemaining"></a> AllotmentsRemaining

|Property|Value|
|--------|-----|
|Description|Shows the number of cases or minutes remaining, based on the resolved cases logged to the contract line.|
|DisplayName|Allotments Remaining|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|allotmentsremaining|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_AllotmentsUsed"></a> AllotmentsUsed

|Property|Value|
|--------|-----|
|Description|Shows the number of cases or minutes used in the resolved cases on the contract line.|
|DisplayName|Allotments Used|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|allotmentsused|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the contact associated with the contract line.|
|DisplayName|Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ContractIdName"></a> ContractIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contractidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContractStateCode"></a> ContractStateCode

|Property|Value|
|--------|-----|
|Description|Status of the contract.|
|DisplayName|Contract State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contractstatecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ContractStateCode Options

|Value|Label|
|-----|-----|




### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridname|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridyominame|
|MaxLength|450|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_Discount_Base"></a> Discount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Discount in base currency.|
|DisplayName|Discount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Net"></a> Net

|Property|Value|
|--------|-----|
|Description|Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.|
|DisplayName|Net|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|net|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_Net_Base"></a> Net_Base

|Property|Value|
|--------|-----|
|Description|Value of the Net in base currency.|
|DisplayName|Net (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|net_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|ApplicationRequired|
|Targets||
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|ApplicationRequired|
|Targets||
|Type|Lookup|


### <a name="BKMK_Price_Base"></a> Price_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Price in base currency.|
|DisplayName|Total Price (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|price_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_ProductIdName"></a> ProductIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|productidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Rate"></a> Rate

|Property|Value|
|--------|-----|
|Description|Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or minutes allocated to the contract line.|
|DisplayName|Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|rate|
|MaxValue|100000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_Rate_Base"></a> Rate_Base

|Property|Value|
|--------|-----|
|Description|Value of the Rate in base currency.|
|DisplayName|Rate (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|rate_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_ServiceAddressName"></a> ServiceAddressName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceaddressname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UoMIdName"></a> UoMIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uomidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_UoMScheduleIdName"></a> UoMScheduleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uomscheduleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [ContractDetail_SyncErrors](#BKMK_ContractDetail_SyncErrors)
- [ContractDetail_AsyncOperations](#BKMK_ContractDetail_AsyncOperations)
- [contractdetail_MailboxTrackingFolders](#BKMK_contractdetail_MailboxTrackingFolders)
- [ContractDetail_ProcessSessions](#BKMK_ContractDetail_ProcessSessions)
- [ContractDetail_BulkDeleteFailures](#BKMK_ContractDetail_BulkDeleteFailures)
- [contractdetail_principalobjectattributeaccess](#BKMK_contractdetail_principalobjectattributeaccess)
- [ContractDetail_Annotation](#BKMK_ContractDetail_Annotation)
- [contract_detail_cases](#BKMK_contract_detail_cases)


### <a name="BKMK_ContractDetail_SyncErrors"></a> ContractDetail_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [ContractDetail_SyncErrors](syncerror.md#BKMK_ContractDetail_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ContractDetail_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_ContractDetail_AsyncOperations"></a> ContractDetail_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [ContractDetail_AsyncOperations](asyncoperation.md#BKMK_ContractDetail_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ContractDetail_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contractdetail_MailboxTrackingFolders"></a> contractdetail_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [contractdetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_contractdetail_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contractdetail_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ContractDetail_ProcessSessions"></a> ContractDetail_ProcessSessions

**Added by**: System Solution Solution

Same as processsession entity [ContractDetail_ProcessSessions](processsession.md#BKMK_ContractDetail_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ContractDetail_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ContractDetail_BulkDeleteFailures"></a> ContractDetail_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [ContractDetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ContractDetail_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ContractDetail_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contractdetail_principalobjectattributeaccess"></a> contractdetail_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [contractdetail_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_contractdetail_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|contractdetail_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ContractDetail_Annotation"></a> ContractDetail_Annotation

**Added by**: System Solution Solution

Same as annotation entity [ContractDetail_Annotation](annotation.md#BKMK_ContractDetail_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ContractDetail_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_contract_detail_cases"></a> contract_detail_cases

Same as incident entity [contract_detail_cases](incident.md#BKMK_contract_detail_cases) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|contractdetailid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|contract_detail_cases|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

**Added by**: System Solution Solution

See systemuser Entity [lk_contractdetailbase_createdby](systemuser.md#BKMK_lk_contractdetailbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_contractdetail_createdonbehalfby"></a> lk_contractdetail_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_contractdetail_createdonbehalfby](systemuser.md#BKMK_lk_contractdetail_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_contractdetailbase_modifiedby"></a> lk_contractdetailbase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_contractdetailbase_modifiedby](systemuser.md#BKMK_lk_contractdetailbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_contractdetail_modifiedonbehalfby"></a> lk_contractdetail_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_contractdetail_modifiedonbehalfby](systemuser.md#BKMK_lk_contractdetail_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_contractdetail"></a> user_contractdetail

**Added by**: System Solution Solution

See systemuser Entity [user_contractdetail](systemuser.md#BKMK_user_contractdetail) One-To-Many relationship.

### <a name="BKMK_team_contractdetail"></a> team_contractdetail

**Added by**: System Solution Solution

See team Entity [team_contractdetail](team.md#BKMK_team_contractdetail) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_contractdetail"></a> transactioncurrency_contractdetail

**Added by**: System Solution Solution

See transactioncurrency Entity [transactioncurrency_contractdetail](transactioncurrency.md#BKMK_transactioncurrency_contractdetail) One-To-Many relationship.

### <a name="BKMK_contractlineitem_customer_accounts"></a> contractlineitem_customer_accounts

**Added by**: System Solution Solution

See account Entity [contractlineitem_customer_accounts](account.md#BKMK_contractlineitem_customer_accounts) One-To-Many relationship.

### <a name="BKMK_contractlineitem_customer_contacts"></a> contractlineitem_customer_contacts

**Added by**: System Solution Solution

See contact Entity [contractlineitem_customer_contacts](contact.md#BKMK_contractlineitem_customer_contacts) One-To-Many relationship.

### <a name="BKMK_contract_line_items"></a> contract_line_items

See contract Entity [contract_line_items](contract.md#BKMK_contract_line_items) One-To-Many relationship.

### <a name="BKMK_customer_address_contract_line_items"></a> customer_address_contract_line_items

**Added by**: System Solution Solution

See customeraddress Entity [customer_address_contract_line_items](customeraddress.md#BKMK_customer_address_contract_line_items) One-To-Many relationship.

### <a name="BKMK_product_contract_line_items"></a> product_contract_line_items

**Added by**: Product Management Solution

See product Entity [product_contract_line_items](product.md#BKMK_product_contract_line_items) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_contract_line_items"></a> unit_of_measurement_contract_line_items

**Added by**: Product Management Solution

See uom Entity [unit_of_measurement_contract_line_items](uom.md#BKMK_unit_of_measurement_contract_line_items) One-To-Many relationship.

### <a name="BKMK_contract_detail_unit_of_measure_schedule"></a> contract_detail_unit_of_measure_schedule

**Added by**: Product Management Solution

See uomschedule Entity [contract_detail_unit_of_measure_schedule](uomschedule.md#BKMK_contract_detail_unit_of_measure_schedule) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.contractdetail?text=contractdetail EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]