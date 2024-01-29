---
title: "Order (SalesOrder)  table/entity reference"
description: "Includes schema information and supported messages for the Order (SalesOrder)  table/entity."
ms.date: 01/29/2024
ms.service: "dynamics-365-sales"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "lavanyakr01"
ms.author: "lavanyakr"
search.audienceType: 
  - developer
---

# Order (SalesOrder)  table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Quote that has been accepted.

**Added by**: Sales Solution


## Messages

|Message|Web API Operation|SDK class or method|
|-|-|-|
|Assign|PATCH /salesorders(*salesorderid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Associate|[Associate and disassociate entities](/powerapps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|CalculatePrice|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|CancelContract||<xref:Microsoft.Crm.Sdk.Messages.CancelContractRequest>|
|CancelSalesOrder||<xref:Microsoft.Crm.Sdk.Messages.CancelSalesOrderRequest>|
|ConvertSalesOrderToInvoice||<xref:Microsoft.Crm.Sdk.Messages.ConvertSalesOrderToInvoiceRequest>|
|Create|POST /salesorders<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|DELETE /salesorders(*salesorderid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|[Associate and disassociate entities](/powerapps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|FulfillSalesOrder||<xref:Microsoft.Crm.Sdk.Messages.FulfillSalesOrderRequest>|
|GenerateSalesOrderFromOpportunity||<xref:Microsoft.Crm.Sdk.Messages.GenerateSalesOrderFromOpportunityRequest>|
|GetQuantityDecimal||<xref:Microsoft.Crm.Sdk.Messages.GetQuantityDecimalRequest>|
|GetSalesOrderProductsFromOpportunity||<xref:Microsoft.Crm.Sdk.Messages.GetSalesOrderProductsFromOpportunityRequest>|
|GrantAccess|<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|LockSalesOrderPricing||<xref:Microsoft.Crm.Sdk.Messages.LockSalesOrderPricingRequest>|
|ModifyAccess|<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Restore||Use <xref:Microsoft.Xrm.Sdk.OrganizationRequest><br/>where <xref:Microsoft.Xrm.Sdk.OrganizationRequest.RequestName> = Restore|
|Retrieve|GET /salesorders(*salesorderid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET /salesorders<br />See [Query Data](/powerapps/developer/data-platform/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref:Microsoft.Dynamics.CRM.Rollup?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|PATCH /salesorders(*salesorderid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH /salesorders(*salesorderid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SalesOrders|
|DisplayCollectionName|Orders|
|DisplayName|Order|
|EntitySetName|salesorders|
|IsBPFEntity|False|
|LogicalCollectionName|salesorders|
|LogicalName|salesorder|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|salesorderid|
|PrimaryNameAttribute|name|
|SchemaName|SalesOrder|

<a name="writable-attributes"></a>

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BillTo_AddressId](#BKMK_BillTo_AddressId)
- [BillTo_City](#BKMK_BillTo_City)
- [BillTo_ContactName](#BKMK_BillTo_ContactName)
- [BillTo_Country](#BKMK_BillTo_Country)
- [BillTo_Fax](#BKMK_BillTo_Fax)
- [BillTo_Line1](#BKMK_BillTo_Line1)
- [BillTo_Line2](#BKMK_BillTo_Line2)
- [BillTo_Line3](#BKMK_BillTo_Line3)
- [BillTo_Name](#BKMK_BillTo_Name)
- [BillTo_PostalCode](#BKMK_BillTo_PostalCode)
- [BillTo_StateOrProvince](#BKMK_BillTo_StateOrProvince)
- [BillTo_Telephone](#BKMK_BillTo_Telephone)
- [CampaignId](#BKMK_CampaignId)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [DateFulfilled](#BKMK_DateFulfilled)
- [Description](#BKMK_Description)
- [DiscountAmount](#BKMK_DiscountAmount)
- [DiscountPercentage](#BKMK_DiscountPercentage)
- [EmailAddress](#BKMK_EmailAddress)
- [EntityImage](#BKMK_EntityImage)
- [FreightAmount](#BKMK_FreightAmount)
- [FreightTermsCode](#BKMK_FreightTermsCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsPriceLocked](#BKMK_IsPriceLocked)
- [LastBackofficeSubmit](#BKMK_LastBackofficeSubmit)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [msdyn_ArePricesIncludingSalesTax](#BKMK_msdyn_ArePricesIncludingSalesTax)
- [msdyn_Company](#BKMK_msdyn_Company)
- [msdyn_ConfirmedReceiptDate](#BKMK_msdyn_ConfirmedReceiptDate)
- [msdyn_ConfirmedShippingDate](#BKMK_msdyn_ConfirmedShippingDate)
- [msdyn_ContactPerson](#BKMK_msdyn_ContactPerson)
- [msdyn_CustomerRequisitionNumber](#BKMK_msdyn_CustomerRequisitionNumber)
- [msdyn_customersorderreference](#BKMK_msdyn_customersorderreference)
- [msdyn_DefaultShippingSite](#BKMK_msdyn_DefaultShippingSite)
- [msdyn_DefaultShippingWarehouse](#BKMK_msdyn_DefaultShippingWarehouse)
- [msdyn_DeliveryAddressCountyId](#BKMK_msdyn_DeliveryAddressCountyId)
- [msdyn_DeliveryAddressDescription](#BKMK_msdyn_DeliveryAddressDescription)
- [msdyn_DeliveryAddressDistrictName](#BKMK_msdyn_DeliveryAddressDistrictName)
- [msdyn_DeliveryAddressDUNSNumber](#BKMK_msdyn_DeliveryAddressDUNSNumber)
- [msdyn_DeliveryAddressLatitude](#BKMK_msdyn_DeliveryAddressLatitude)
- [msdyn_DeliveryAddressLocationId](#BKMK_msdyn_DeliveryAddressLocationId)
- [msdyn_DeliveryAddressLongitude](#BKMK_msdyn_DeliveryAddressLongitude)
- [msdyn_DeliveryAddressName](#BKMK_msdyn_DeliveryAddressName)
- [msdyn_DeliveryAddressPostBox](#BKMK_msdyn_DeliveryAddressPostBox)
- [msdyn_DeliveryBuildingCompliment](#BKMK_msdyn_DeliveryBuildingCompliment)
- [msdyn_deliverymode](#BKMK_msdyn_deliverymode)
- [msdyn_deliveryterms](#BKMK_msdyn_deliveryterms)
- [msdyn_FormattedDeliveryAddress](#BKMK_msdyn_FormattedDeliveryAddress)
- [msdyn_FormattedInvoiceAddress](#BKMK_msdyn_FormattedInvoiceAddress)
- [msdyn_InvoiceAddressCountyId](#BKMK_msdyn_InvoiceAddressCountyId)
- [msdyn_InvoiceAddressDistrictName](#BKMK_msdyn_InvoiceAddressDistrictName)
- [msdyn_InvoiceAddressLatitude](#BKMK_msdyn_InvoiceAddressLatitude)
- [msdyn_InvoiceAddressLongitude](#BKMK_msdyn_InvoiceAddressLongitude)
- [msdyn_InvoiceAddressPostBox](#BKMK_msdyn_InvoiceAddressPostBox)
- [msdyn_InvoiceBuildingCompliment](#BKMK_msdyn_InvoiceBuildingCompliment)
- [msdyn_InvoiceCustomer](#BKMK_msdyn_InvoiceCustomer)
- [msdyn_invoicecustomerid](#BKMK_msdyn_invoicecustomerid)
- [msdyn_invoicecustomeridIdType](#BKMK_msdyn_invoicecustomeridIdType)
- [msdyn_IsDeliveryAddressOrderSpecific](#BKMK_msdyn_IsDeliveryAddressOrderSpecific)
- [msdyn_IsDeliveryAddressPrivate](#BKMK_msdyn_IsDeliveryAddressPrivate)
- [msdyn_IsInvoiceAddressPrivate](#BKMK_msdyn_IsInvoiceAddressPrivate)
- [msdyn_isocurrencycode](#BKMK_msdyn_isocurrencycode)
- [msdyn_IsOneTimeCustomer](#BKMK_msdyn_IsOneTimeCustomer)
- [msdyn_isreadytosync](#BKMK_msdyn_isreadytosync)
- [msdyn_IsSalesProcessingStopped](#BKMK_msdyn_IsSalesProcessingStopped)
- [msdyn_Language](#BKMK_msdyn_Language)
- [msdyn_ordertype](#BKMK_msdyn_ordertype)
- [msdyn_PaymentTerms](#BKMK_msdyn_PaymentTerms)
- [msdyn_PaymentTermsBaseDate](#BKMK_msdyn_PaymentTermsBaseDate)
- [msdyn_PriceCustomerGroup](#BKMK_msdyn_PriceCustomerGroup)
- [msdyn_ProcessingStatus](#BKMK_msdyn_ProcessingStatus)
- [msdyn_QuotationNumber](#BKMK_msdyn_QuotationNumber)
- [msdyn_RequestedReceiptDate](#BKMK_msdyn_RequestedReceiptDate)
- [msdyn_SalesOrderNumber](#BKMK_msdyn_SalesOrderNumber)
- [msdyn_salesorderorigin](#BKMK_msdyn_salesorderorigin)
- [msdyn_SalesOrderPromisingMethod](#BKMK_msdyn_SalesOrderPromisingMethod)
- [msdyn_SkipGlobalUnifiedPricingCalculation](#BKMK_msdyn_SkipGlobalUnifiedPricingCalculation)
- [msdyn_URL](#BKMK_msdyn_URL)
- [Name](#BKMK_Name)
- [OpportunityId](#BKMK_OpportunityId)
- [OrderCreationMethod](#BKMK_OrderCreationMethod)
- [OrderNumber](#BKMK_OrderNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PaymentTermsCode](#BKMK_PaymentTermsCode)
- [PriceLevelId](#BKMK_PriceLevelId)
- [PricingErrorCode](#BKMK_PricingErrorCode)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [QuoteId](#BKMK_QuoteId)
- [RequestDeliveryBy](#BKMK_RequestDeliveryBy)
- [SalesOrderId](#BKMK_SalesOrderId)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
- [ShipTo_AddressId](#BKMK_ShipTo_AddressId)
- [ShipTo_City](#BKMK_ShipTo_City)
- [ShipTo_ContactName](#BKMK_ShipTo_ContactName)
- [ShipTo_Country](#BKMK_ShipTo_Country)
- [ShipTo_Fax](#BKMK_ShipTo_Fax)
- [ShipTo_FreightTermsCode](#BKMK_ShipTo_FreightTermsCode)
- [ShipTo_Line1](#BKMK_ShipTo_Line1)
- [ShipTo_Line2](#BKMK_ShipTo_Line2)
- [ShipTo_Line3](#BKMK_ShipTo_Line3)
- [ShipTo_Name](#BKMK_ShipTo_Name)
- [ShipTo_PostalCode](#BKMK_ShipTo_PostalCode)
- [ShipTo_StateOrProvince](#BKMK_ShipTo_StateOrProvince)
- [ShipTo_Telephone](#BKMK_ShipTo_Telephone)
- [SkipPriceCalculation](#BKMK_SkipPriceCalculation)
- [SLAId](#BKMK_SLAId)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [SubmitDate](#BKMK_SubmitDate)
- [SubmitStatus](#BKMK_SubmitStatus)
- [SubmitStatusDescription](#BKMK_SubmitStatusDescription)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalAmount](#BKMK_TotalAmount)
- [TotalAmountLessFreight](#BKMK_TotalAmountLessFreight)
- [TotalDiscountAmount](#BKMK_TotalDiscountAmount)
- [TotalLineItemAmount](#BKMK_TotalLineItemAmount)
- [TotalLineItemDiscountAmount](#BKMK_TotalLineItemDiscountAmount)
- [TotalTax](#BKMK_TotalTax)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WillCall](#BKMK_WillCall)


### <a name="BKMK_BillTo_AddressId"></a> BillTo_AddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the billing address.|
|DisplayName|Bill To Address ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|billto_addressid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_BillTo_City"></a> BillTo_City

|Property|Value|
|--------|-----|
|Description|Type the city for the customer's billing address.|
|DisplayName|Bill To City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_ContactName"></a> BillTo_ContactName

|Property|Value|
|--------|-----|
|Description|Type the primary contact name at the customer's billing address.|
|DisplayName|Bill To Contact Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_contactname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Country"></a> BillTo_Country

|Property|Value|
|--------|-----|
|Description|Type the country or region for the customer's billing address.|
|DisplayName|Bill To Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Fax"></a> BillTo_Fax

|Property|Value|
|--------|-----|
|Description|Type the fax number for the customer's billing address.|
|DisplayName|Bill To Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Line1"></a> BillTo_Line1

|Property|Value|
|--------|-----|
|Description|Type the first line of the customer's billing address.|
|DisplayName|Bill To Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Line2"></a> BillTo_Line2

|Property|Value|
|--------|-----|
|Description|Type the second line of the customer's billing address.|
|DisplayName|Bill To Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Line3"></a> BillTo_Line3

|Property|Value|
|--------|-----|
|Description|Type the third line of the billing address.|
|DisplayName|Bill To Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Name"></a> BillTo_Name

|Property|Value|
|--------|-----|
|Description|Type a name for the customer's billing address, such as "Headquarters" or "Field office", to identify the address.|
|DisplayName|Bill To Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_PostalCode"></a> BillTo_PostalCode

|Property|Value|
|--------|-----|
|Description|Type the ZIP Code or postal code for the billing address.|
|DisplayName|Bill To ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_StateOrProvince"></a> BillTo_StateOrProvince

|Property|Value|
|--------|-----|
|Description|Type the state or province for the billing address.|
|DisplayName|Bill To State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Telephone"></a> BillTo_Telephone

|Property|Value|
|--------|-----|
|Description|Type the phone number for the customer's billing address.|
|DisplayName|Bill To Phone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_telephone|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CampaignId"></a> CampaignId

**Added by**: Marketing Sales Solution

|Property|Value|
|--------|-----|
|Description|Shows the campaign that the order was created from.|
|DisplayName|Source Campaign|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|campaignid|
|RequiredLevel|None|
|Targets|campaign|
|Type|Lookup|


### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|ApplicationRequired|
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


### <a name="BKMK_DateFulfilled"></a> DateFulfilled

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date that all or part of the order was shipped to the customer.|
|DisplayName|Date Fulfilled|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|datefulfilled|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the order, such as the products or services offered or details about the customer's product preferences.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DiscountAmount"></a> DiscountAmount

|Property|Value|
|--------|-----|
|Description|Type the discount amount for the order if the customer is eligible for special savings.|
|DisplayName|Order Discount Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountamount|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_DiscountPercentage"></a> DiscountPercentage

|Property|Value|
|--------|-----|
|Description|Type the discount rate that should be applied to the Detail Amount field to include additional savings for the customer in the order.|
|DisplayName|Order Discount (%)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountpercentage|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|--------|-----|
|Description|The primary email address for the entity.|
|DisplayName|Email Address|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImage"></a> EntityImage

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|The default image for the entity.|
|DisplayName|Entity Image|
|IsPrimaryImage|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_FreightAmount"></a> FreightAmount

|Property|Value|
|--------|-----|
|Description|Type the cost of freight or shipping for the products included in the order for use in calculating the Total Amount field.|
|DisplayName|Freight Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|freightamount|
|MaxValue|1000000000000|
|MinValue|-1000000000000|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_FreightTermsCode"></a> FreightTermsCode

|Property|Value|
|--------|-----|
|Description|Select the freight terms to make sure shipping charges are processed correctly.|
|DisplayName|Freight Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### FreightTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|FOB||
|2|No Charge||



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


### <a name="BKMK_IsPriceLocked"></a> IsPriceLocked

|Property|Value|
|--------|-----|
|Description|Select whether prices specified on the invoice are locked from any further updates.|
|DisplayName|Prices Locked|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ispricelocked|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### IsPriceLocked Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_LastBackofficeSubmit"></a> LastBackofficeSubmit

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date and time when the order was last submitted to an accounting or ERP system for processing.|
|DisplayName|Last Submitted to Back Office|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastbackofficesubmit|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Contains the date time stamp of the last on hold time.|
|DisplayName|Last On Hold Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastonholdtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_ArePricesIncludingSalesTax"></a> msdyn_ArePricesIncludingSalesTax

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Are Prices Including Sales Tax|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_arepricesincludingsalestax|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_ArePricesIncludingSalesTax Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_Company"></a> msdyn_Company

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Company|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_company|
|RequiredLevel|ApplicationRequired|
|Targets|cdm_company|
|Type|Lookup|


### <a name="BKMK_msdyn_ConfirmedReceiptDate"></a> msdyn_ConfirmedReceiptDate

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description||
|DisplayName|Confirmed Receipt Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_confirmedreceiptdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_ConfirmedShippingDate"></a> msdyn_ConfirmedShippingDate

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description||
|DisplayName|Confirmed Shipping Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_confirmedshippingdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_ContactPerson"></a> msdyn_ContactPerson

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Contact Person|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contactperson|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_msdyn_CustomerRequisitionNumber"></a> msdyn_CustomerRequisitionNumber

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer Requisition Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customerrequisitionnumber|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_customersorderreference"></a> msdyn_customersorderreference

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customers Order Reference|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customersorderreference|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultShippingSite"></a> msdyn_DefaultShippingSite

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Default Shipping Site|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultshippingsite|
|RequiredLevel|None|
|Targets|msdyn_operationalsite|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultShippingWarehouse"></a> msdyn_DefaultShippingWarehouse

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Default Shipping Warehouse|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultshippingwarehouse|
|RequiredLevel|None|
|Targets|msdyn_warehouse|
|Type|Lookup|


### <a name="BKMK_msdyn_DeliveryAddressCountyId"></a> msdyn_DeliveryAddressCountyId

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address County Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresscountyid|
|MaxLength|30|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeliveryAddressDescription"></a> msdyn_DeliveryAddressDescription

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddressdescription|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeliveryAddressDistrictName"></a> msdyn_DeliveryAddressDistrictName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address District Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddressdistrictname|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeliveryAddressDUNSNumber"></a> msdyn_DeliveryAddressDUNSNumber

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address DUNS Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddressdunsnumber|
|MaxLength|9|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeliveryAddressLatitude"></a> msdyn_DeliveryAddressLatitude

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresslatitude|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_DeliveryAddressLocationId"></a> msdyn_DeliveryAddressLocationId

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Location Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresslocationid|
|MaxLength|30|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeliveryAddressLongitude"></a> msdyn_DeliveryAddressLongitude

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresslongitude|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_DeliveryAddressName"></a> msdyn_DeliveryAddressName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddressname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeliveryAddressPostBox"></a> msdyn_DeliveryAddressPostBox

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Address PostBox|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryaddresspostbox|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeliveryBuildingCompliment"></a> msdyn_DeliveryBuildingCompliment

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Building Compliment|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliverybuildingcompliment|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliverymode"></a> msdyn_deliverymode

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Mode|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliverymode|
|RequiredLevel|None|
|Targets|msdyn_shipvia|
|Type|Lookup|


### <a name="BKMK_msdyn_deliveryterms"></a> msdyn_deliveryterms

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Delivery Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deliveryterms|
|RequiredLevel|None|
|Targets|msdyn_termsofdelivery|
|Type|Lookup|


### <a name="BKMK_msdyn_FormattedDeliveryAddress"></a> msdyn_FormattedDeliveryAddress

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Formatted Delivery Address|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_formatteddeliveryaddress|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_FormattedInvoiceAddress"></a> msdyn_FormattedInvoiceAddress

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Formatted Invoice Address|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_formattedinvoiceaddress|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InvoiceAddressCountyId"></a> msdyn_InvoiceAddressCountyId

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice Address County Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoiceaddresscountyid|
|MaxLength|30|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InvoiceAddressDistrictName"></a> msdyn_InvoiceAddressDistrictName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice Address District Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoiceaddressdistrictname|
|MaxLength|10|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InvoiceAddressLatitude"></a> msdyn_InvoiceAddressLatitude

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice Address Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoiceaddresslatitude|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_InvoiceAddressLongitude"></a> msdyn_InvoiceAddressLongitude

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice Address Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoiceaddresslongitude|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_InvoiceAddressPostBox"></a> msdyn_InvoiceAddressPostBox

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice Address PostBox|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoiceaddresspostbox|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InvoiceBuildingCompliment"></a> msdyn_InvoiceBuildingCompliment

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice Building Compliment|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicebuildingcompliment|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InvoiceCustomer"></a> msdyn_InvoiceCustomer

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicecustomer|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_invoicecustomerid"></a> msdyn_invoicecustomerid

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicecustomerid|
|RequiredLevel|ApplicationRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_msdyn_invoicecustomeridIdType"></a> msdyn_invoicecustomeridIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_invoicecustomerididtype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_msdyn_IsDeliveryAddressOrderSpecific"></a> msdyn_IsDeliveryAddressOrderSpecific

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Delivery Address Order Specific|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isdeliveryaddressorderspecific|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsDeliveryAddressOrderSpecific Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_IsDeliveryAddressPrivate"></a> msdyn_IsDeliveryAddressPrivate

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Delivery Address Private|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isdeliveryaddressprivate|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsDeliveryAddressPrivate Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_IsInvoiceAddressPrivate"></a> msdyn_IsInvoiceAddressPrivate

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Invoice Address Private|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isinvoiceaddressprivate|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsInvoiceAddressPrivate Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_isocurrencycode"></a> msdyn_isocurrencycode

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|ISO Currency Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isocurrencycode|
|MaxLength|3|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_IsOneTimeCustomer"></a> msdyn_IsOneTimeCustomer

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is One Time Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isonetimecustomer|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsOneTimeCustomer Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_isreadytosync"></a> msdyn_isreadytosync

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description|Is Ready To Sync.|
|DisplayName|Is Ready To Sync|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isreadytosync|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_isreadytosync Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 1



### <a name="BKMK_msdyn_IsSalesProcessingStopped"></a> msdyn_IsSalesProcessingStopped

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Sales Processing Stopped|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_issalesprocessingstopped|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsSalesProcessingStopped Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_Language"></a> msdyn_Language

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description|Default language of the sales order|
|DisplayName|Language|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_language|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_Language Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|192350000|ar|Arabic|
|192350001|ar-ae|Arabic (U.A.E.)|
|192350002|cs|Czech|
|192350003|da|Danish|
|192350004|de|German|
|192350005|de-at|German (Austria)|
|192350006|de-ch|German (Switzerland)|
|192350007|en-au|English (Australia)|
|192350008|en-ca|English (Canada)|
|192350009|en-gb|English (United Kingdom)|
|192350010|en-ie|English (Ireland)|
|192350011|en-in|English (India)|
|192350012|en-my|English (Malaysia)|
|192350013|en-nz|English (New Zealand)|
|192350014|en-sg|English (Singapore)|
|192350015|en-us|English (United States)|
|192350016|en-za|English (South Africa)|
|192350017|es|Spanish|
|192350018|es-mx|Spanish (Mexico)|
|192350019|et|Estonian|
|192350020|fi|Finnish|
|192350021|fr|French|
|192350022|fr-be|French (Belgium)|
|192350023|fr-ca|French (Canada)|
|192350024|fr-ch|French (Switzerland)|
|192350025|hu|Hungarian|
|192350026|is|Icelandic|
|192350027|it|Italian|
|192350028|it-ch|Italian (Switzerland)|
|192350029|ja|Japanese|
|192350030|lt|Lithuanian|
|192350031|lv|Latvian|
|192350032|nb-no|Norwegian, Bokmål (Norway)|
|192350033|nl|Dutch|
|192350034|nl-be|Dutch (Belgium)|
|192350035|pl|Polish|
|192350036|pt-br|Portuguese (Brazil)|
|192350037|ru|Russian|
|192350038|sv|Swedish|
|192350039|th|Thai|
|192350040|tr|Turkish|
|192350041|zh-hans|Chinese (Simplified)|



### <a name="BKMK_msdyn_ordertype"></a> msdyn_ordertype

**Added by**: Field Service Common Solution

|Property|Value|
|--------|-----|
|Description|Whether it is for an Item-based or a different type of sale|
|DisplayName|Order Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ordertype|
|RequiredLevel|Recommended|
|Type|Picklist|

#### msdyn_ordertype Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|192350000|Item based||



### <a name="BKMK_msdyn_PaymentTerms"></a> msdyn_PaymentTerms

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Payment Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_paymentterms|
|RequiredLevel|None|
|Targets|msdyn_paymentterm|
|Type|Lookup|


### <a name="BKMK_msdyn_PaymentTermsBaseDate"></a> msdyn_PaymentTermsBaseDate

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description||
|DisplayName|Payment Terms Base Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_paymenttermsbasedate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_PriceCustomerGroup"></a> msdyn_PriceCustomerGroup

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Price Customer Group|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricecustomergroup|
|RequiredLevel|None|
|Targets|msdyn_pricecustomergroup|
|Type|Lookup|


### <a name="BKMK_msdyn_ProcessingStatus"></a> msdyn_ProcessingStatus

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description|The sales order processing status|
|DisplayName|Processing Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_processingstatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_ProcessingStatus Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|192350000|Active||
|192350001|Confirmed||
|192350002|Picked||
|192350003|Partially Delivered||
|192350004|Delivered||
|192350005|Invoiced||
|192350006|Partially Invoiced||
|192350007|Canceled||
|192350008|Delivered And Partially Invoiced||



### <a name="BKMK_msdyn_QuotationNumber"></a> msdyn_QuotationNumber

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Quotation Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quotationnumber|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RequestedReceiptDate"></a> msdyn_RequestedReceiptDate

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description||
|DisplayName|Requested Receipt Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requestedreceiptdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_SalesOrderNumber"></a> msdyn_SalesOrderNumber

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description|Shows the sales order number.|
|DisplayName|Sales Order Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salesordernumber|
|MaxLength|20|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_salesorderorigin"></a> msdyn_salesorderorigin

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Sales Order Origin|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salesorderorigin|
|RequiredLevel|None|
|Targets|msdyn_salesorderorigin|
|Type|Lookup|


### <a name="BKMK_msdyn_SalesOrderPromisingMethod"></a> msdyn_SalesOrderPromisingMethod

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Sales Order Promising Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salesorderpromisingmethod|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_SalesOrderPromisingMethod Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|192350000|None||
|192350001|Sales Lead Time||
|192350002|ATP||
|192350003|ATP + Issue Margin||
|192350004|CTP||



### <a name="BKMK_msdyn_SkipGlobalUnifiedPricingCalculation"></a> msdyn_SkipGlobalUnifiedPricingCalculation

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Skip Global Unified Pricing Calculation|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_skipglobalunifiedpricingcalculation|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_SkipGlobalUnifiedPricingCalculation Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_URL"></a> msdyn_URL

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|URL|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_url|
|MaxLength|255|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name for the order.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|300|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OpportunityId"></a> OpportunityId

|Property|Value|
|--------|-----|
|Description|Choose the related opportunity so that the data for the order and opportunity are linked for reporting and analytics.|
|DisplayName|Opportunity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opportunityid|
|RequiredLevel|None|
|Targets|opportunity|
|Type|Lookup|


### <a name="BKMK_OrderCreationMethod"></a> OrderCreationMethod

**Added by**: Sales Patch Version 3 Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Creation Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ordercreationmethod|
|RequiredLevel|None|
|Type|Picklist|

#### OrderCreationMethod Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|776160000|Unknown||
|776160001|Win Quote||



### <a name="BKMK_OrderNumber"></a> OrderNumber

|Property|Value|
|--------|-----|
|Description|Shows the order number for customer reference and to use in search. The number cannot be modified.|
|DisplayName|Order ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ordernumber|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PaymentTermsCode"></a> PaymentTermsCode

|Property|Value|
|--------|-----|
|Description|Select the payment terms to indicate when the customer needs to pay the total amount.|
|DisplayName|Payment Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|paymenttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### PaymentTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Net 30||
|2|2% 10, Net 30||
|3|Net 45||
|4|Net 60||



### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|--------|-----|
|Description|Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|pricelevelid|
|RequiredLevel|ApplicationRequired|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_PricingErrorCode"></a> PricingErrorCode

|Property|Value|
|--------|-----|
|Description|Select the type of pricing error, such as a missing or invalid product, or missing quantity.|
|DisplayName|Pricing Error |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricingerrorcode|
|RequiredLevel|None|
|Type|Picklist|

#### PricingErrorCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|None||
|1|Detail Error||
|2|Missing Price Level||
|3|Inactive Price Level||
|4|Missing Quantity||
|5|Missing Unit Price||
|6|Missing Product||
|7|Invalid Product||
|8|Missing Pricing Code||
|9|Invalid Pricing Code||
|10|Missing UOM||
|11|Product Not In Price Level||
|12|Missing Price Level Amount||
|13|Missing Price Level Percentage||
|14|Missing Price||
|15|Missing Current Cost||
|16|Missing Standard Cost||
|17|Invalid Price Level Amount||
|18|Invalid Price Level Percentage||
|19|Invalid Price||
|20|Invalid Current Cost||
|21|Invalid Standard Cost||
|22|Invalid Rounding Policy||
|23|Invalid Rounding Option||
|24|Invalid Rounding Amount||
|25|Price Calculation Error||
|26|Invalid Discount Type||
|27|Discount Type Invalid State||
|28|Invalid Discount||
|29|Invalid Quantity||
|30|Invalid Pricing Precision||
|31|Missing Product Default UOM||
|32|Missing Product UOM Schedule ||
|33|Inactive Discount Type||
|34|Invalid Price Level Currency||
|35|Price Attribute Out Of Range||
|36|Base Currency Attribute Overflow||
|37|Base Currency Attribute Underflow||
|38|Transaction currency is not set for the product price list item||



### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|--------|-----|
|Description|Select the priority so that preferred customers or critical issues are handled quickly.|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|prioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### PriorityCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_QuoteId"></a> QuoteId

|Property|Value|
|--------|-----|
|Description|Choose the related quote so that order data and quote data are linked for reporting and analytics.|
|DisplayName|Quote|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quoteid|
|RequiredLevel|None|
|Targets|quote|
|Type|Lookup|


### <a name="BKMK_RequestDeliveryBy"></a> RequestDeliveryBy

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the delivery date requested by the customer for all products in the order.|
|DisplayName|Requested Delivery Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|requestdeliveryby|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SalesOrderId"></a> SalesOrderId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the order.|
|DisplayName|Order|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|salesorderid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Select a shipping method for deliveries sent to this address.|
|DisplayName|Shipping Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### ShippingMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Airborne||
|2|DHL||
|3|FedEx||
|4|UPS||
|5|Postal Mail||
|6|Full Load||
|7|Will Call||



### <a name="BKMK_ShipTo_AddressId"></a> ShipTo_AddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the shipping address.|
|DisplayName|Ship To Address ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|shipto_addressid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ShipTo_City"></a> ShipTo_City

|Property|Value|
|--------|-----|
|Description|Type the city for the customer's shipping address.|
|DisplayName|Ship To City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_ContactName"></a> ShipTo_ContactName

|Property|Value|
|--------|-----|
|Description|Type the primary contact name at the customer's shipping address.|
|DisplayName|Ship To Contact Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_contactname|
|MaxLength|150|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Country"></a> ShipTo_Country

|Property|Value|
|--------|-----|
|Description|Type the country or region for the customer's shipping address.|
|DisplayName|Ship To Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Fax"></a> ShipTo_Fax

|Property|Value|
|--------|-----|
|Description|Type the fax number for the customer's shipping address.|
|DisplayName|Ship to Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_FreightTermsCode"></a> ShipTo_FreightTermsCode

|Property|Value|
|--------|-----|
|Description|Select the freight terms to make sure shipping orders are processed correctly.|
|DisplayName|Ship To Freight Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_freighttermscode|
|RequiredLevel|None|
|Type|Picklist|

#### ShipTo_FreightTermsCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_ShipTo_Line1"></a> ShipTo_Line1

|Property|Value|
|--------|-----|
|Description|Type the first line of the customer's shipping address.|
|DisplayName|Ship To Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Line2"></a> ShipTo_Line2

|Property|Value|
|--------|-----|
|Description|Type the second line of the customer's shipping address.|
|DisplayName|Ship To Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Line3"></a> ShipTo_Line3

|Property|Value|
|--------|-----|
|Description|Type the third line of the shipping address.|
|DisplayName|Ship To Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Name"></a> ShipTo_Name

|Property|Value|
|--------|-----|
|Description|Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.|
|DisplayName|Ship To Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_PostalCode"></a> ShipTo_PostalCode

|Property|Value|
|--------|-----|
|Description|Type the ZIP Code or postal code for the shipping address.|
|DisplayName|Ship To ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_StateOrProvince"></a> ShipTo_StateOrProvince

|Property|Value|
|--------|-----|
|Description|Type the state or province for the shipping address.|
|DisplayName|Ship To State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Telephone"></a> ShipTo_Telephone

|Property|Value|
|--------|-----|
|Description|Type the phone number for the customer's shipping address.|
|DisplayName|Ship To Phone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_telephone|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SkipPriceCalculation"></a> SkipPriceCalculation

**Added by**: Sales Patch Solution

|Property|Value|
|--------|-----|
|Description|Skip Price Calculation|
|DisplayName|Skip Price Calculation (For Internal Use)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|skippricecalculation|
|RequiredLevel|None|
|Type|Picklist|

#### SkipPriceCalculation Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|DoPriceCalcAlways||
|1|SkipPriceCalcOnRetrieve||



### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the sales order record.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|(Deprecated) Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the order is active, submitted, fulfilled, canceled, or invoiced. Only active orders can be edited.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Submitted|3|Submitted|
|2|Canceled|4|Canceled|
|3|Fulfilled|100001|Fulfilled|
|4|Invoiced|100003|Invoiced|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the order's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|New|0|
|2|Pending|0|
|3|In Progress|1|
|4|No Money|2|
|100001|Complete|3|
|100002|Partial|3|
|100003|Invoiced|4|
|700970000|In Progress|0|



### <a name="BKMK_SubmitDate"></a> SubmitDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when the order was submitted to the fulfillment or shipping center.|
|DisplayName|Date Submitted|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|submitdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SubmitStatus"></a> SubmitStatus

|Property|Value|
|--------|-----|
|Description|Type the code for the submitted status in the fulfillment or shipping center system.|
|DisplayName|Submitted Status|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|submitstatus|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_SubmitStatusDescription"></a> SubmitStatusDescription

|Property|Value|
|--------|-----|
|Description|Type additional details or notes about the order for the fulfillment or shipping center.|
|DisplayName|Submitted Status Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|submitstatusdescription|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_TotalAmount"></a> TotalAmount

|Property|Value|
|--------|-----|
|Description|Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the order.|
|DisplayName|Total Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalAmountLessFreight"></a> TotalAmountLessFreight

|Property|Value|
|--------|-----|
|Description|Shows the total product amount for the order, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the order.|
|DisplayName|Total Pre-Freight Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamountlessfreight|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalDiscountAmount"></a> TotalDiscountAmount

|Property|Value|
|--------|-----|
|Description|Shows the total discount amount, based on the discount price and rate entered on the order.|
|DisplayName|Total Discount Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaldiscountamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemAmount"></a> TotalLineItemAmount

|Property|Value|
|--------|-----|
|Description|Shows the sum of all existing and write-in products included on the order, based on the specified price list and quantities.|
|DisplayName|Total Detail Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemDiscountAmount"></a> TotalLineItemDiscountAmount

|Property|Value|
|--------|-----|
|Description|Shows the total of the Manual Discount amounts specified on all products included in the order. This value is reflected in the Detail Amount field on the order and is added to any discount amount or rate specified on the order.|
|DisplayName|Total Line Item Discount Amount|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemdiscountamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalTax"></a> TotalTax

|Property|Value|
|--------|-----|
|Description|Shows the Tax amounts specified on all products included in the order, included in the Total Amount due calculation for the order.|
|DisplayName|Total Tax|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaltax|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|transactioncurrencyid|
|RequiredLevel|ApplicationRequired|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_WillCall"></a> WillCall

|Property|Value|
|--------|-----|
|Description|Select whether the products included in the order should be shipped to the specified address or held until the customer calls with further pick-up or delivery instructions.|
|DisplayName|Ship To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|willcall|
|RequiredLevel|None|
|Type|Boolean|

#### WillCall Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Will Call||
|0|Address||

**DefaultValue**: 0


<a name="read-only-attributes"></a>

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [AccountIdName](#BKMK_AccountIdName)
- [AccountIdYomiName](#BKMK_AccountIdYomiName)
- [BillTo_Composite](#BKMK_BillTo_Composite)
- [CampaignIdName](#BKMK_CampaignIdName)
- [ContactId](#BKMK_ContactId)
- [ContactIdName](#BKMK_ContactIdName)
- [ContactIdYomiName](#BKMK_ContactIdYomiName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [DiscountAmount_Base](#BKMK_DiscountAmount_Base)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [FreightAmount_Base](#BKMK_FreightAmount_Base)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_CompanyName](#BKMK_msdyn_CompanyName)
- [msdyn_ContactPersonName](#BKMK_msdyn_ContactPersonName)
- [msdyn_ContactPersonYomiName](#BKMK_msdyn_ContactPersonYomiName)
- [msdyn_DefaultShippingSiteName](#BKMK_msdyn_DefaultShippingSiteName)
- [msdyn_DefaultShippingWarehouseName](#BKMK_msdyn_DefaultShippingWarehouseName)
- [msdyn_deliverymodeName](#BKMK_msdyn_deliverymodeName)
- [msdyn_deliverytermsName](#BKMK_msdyn_deliverytermsName)
- [msdyn_invoicecustomeridName](#BKMK_msdyn_invoicecustomeridName)
- [msdyn_invoicecustomeridYomiName](#BKMK_msdyn_invoicecustomeridYomiName)
- [msdyn_InvoiceCustomerName](#BKMK_msdyn_InvoiceCustomerName)
- [msdyn_InvoiceCustomerYomiName](#BKMK_msdyn_InvoiceCustomerYomiName)
- [msdyn_PaymentTermsName](#BKMK_msdyn_PaymentTermsName)
- [msdyn_PriceCustomerGroupName](#BKMK_msdyn_PriceCustomerGroupName)
- [msdyn_salesorderoriginName](#BKMK_msdyn_salesorderoriginName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OpportunityIdName](#BKMK_OpportunityIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PriceLevelIdName](#BKMK_PriceLevelIdName)
- [QuoteIdName](#BKMK_QuoteIdName)
- [ShipTo_Composite](#BKMK_ShipTo_Composite)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TotalAmount_Base](#BKMK_TotalAmount_Base)
- [TotalAmountLessFreight_Base](#BKMK_TotalAmountLessFreight_Base)
- [TotalDiscountAmount_Base](#BKMK_TotalDiscountAmount_Base)
- [TotalLineItemAmount_Base](#BKMK_TotalLineItemAmount_Base)
- [TotalLineItemDiscountAmount_Base](#BKMK_TotalLineItemDiscountAmount_Base)
- [TotalTax_Base](#BKMK_TotalTax_Base)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|--------|-----|
|Description|Shows the parent account related to the record. This information is used to link the sales order to the account selected in the Customer field for reporting and analytics.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_AccountIdName"></a> AccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BillTo_Composite"></a> BillTo_Composite

|Property|Value|
|--------|-----|
|Description|Shows the complete Bill To address.|
|DisplayName|Bill To Address|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billto_composite|
|MaxLength|1000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_CampaignIdName"></a> CampaignIdName

**Added by**: Marketing Sales Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|--------|-----|
|Description|Shows the parent contact related to the record. This information is used to link the contract to the contact selected in the Customer field for reporting and analytics.|
|DisplayName|Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ContactIdName"></a> ContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_DiscountAmount_Base"></a> DiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Order Discount Amount in base currency.|
|DisplayName|Order Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|discountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


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
|MinValue|0.000000000001|
|Precision|12|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_FreightAmount_Base"></a> FreightAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Freight Amount in base currency.|
|DisplayName|Freight Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|freightamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_msdyn_CompanyName"></a> msdyn_CompanyName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_companyname|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContactPersonName"></a> msdyn_ContactPersonName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contactpersonname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContactPersonYomiName"></a> msdyn_ContactPersonYomiName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contactpersonyominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultShippingSiteName"></a> msdyn_DefaultShippingSiteName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultshippingsitename|
|MaxLength|60|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultShippingWarehouseName"></a> msdyn_DefaultShippingWarehouseName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultshippingwarehousename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliverymodeName"></a> msdyn_deliverymodeName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_deliverymodename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_deliverytermsName"></a> msdyn_deliverytermsName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_deliverytermsname|
|MaxLength|10|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_invoicecustomeridName"></a> msdyn_invoicecustomeridName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_invoicecustomeridname|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_invoicecustomeridYomiName"></a> msdyn_invoicecustomeridYomiName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_invoicecustomeridyominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InvoiceCustomerName"></a> msdyn_InvoiceCustomerName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_invoicecustomername|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InvoiceCustomerYomiName"></a> msdyn_InvoiceCustomerYomiName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_invoicecustomeryominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PaymentTermsName"></a> msdyn_PaymentTermsName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_paymenttermsname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PriceCustomerGroupName"></a> msdyn_PriceCustomerGroupName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_pricecustomergroupname|
|MaxLength|10|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_salesorderoriginName"></a> msdyn_salesorderoriginName

**Added by**: Dynamics 365 Supply Chain Extended Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_salesorderoriginname|
|MaxLength|10|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|--------|-----|
|Description|Shows the duration in minutes for which the order was on hold.|
|DisplayName|On Hold Time (Minutes)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|onholdtime|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OpportunityIdName"></a> OpportunityIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|opportunityidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_PriceLevelIdName"></a> PriceLevelIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricelevelidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_QuoteIdName"></a> QuoteIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quoteidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ShipTo_Composite"></a> ShipTo_Composite

|Property|Value|
|--------|-----|
|Description|Shows the complete Ship To address.|
|DisplayName|Ship To Address|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|shipto_composite|
|MaxLength|1000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this sales order. This field is for internal use only.|
|DisplayName|Last SLA applied|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAName"></a> SLAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TotalAmount_Base"></a> TotalAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Amount in base currency.|
|DisplayName|Total Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalAmountLessFreight_Base"></a> TotalAmountLessFreight_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Pre-Freight Amount in base currency.|
|DisplayName|Total Pre-Freight Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalamountlessfreight_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalDiscountAmount_Base"></a> TotalDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Discount Amount in base currency.|
|DisplayName|Total Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaldiscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemAmount_Base"></a> TotalLineItemAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Detail Amount in base currency.|
|DisplayName|Total Detail Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalLineItemDiscountAmount_Base"></a> TotalLineItemDiscountAmount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Line Item Discount Amount in base currency.|
|DisplayName|Total Line Item Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totallineitemdiscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_TotalTax_Base"></a> TotalTax_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Tax in base currency.|
|DisplayName|Total Tax (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totaltax_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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

- [lk_opportunitysalesprocess_salesorderid](#BKMK_lk_opportunitysalesprocess_salesorderid)
- [order_invoices](#BKMK_order_invoices)
- [SalesOrder_OrderClose](#BKMK_SalesOrder_OrderClose)
- [msdyn_salesorder_quote_generatedsalesordernumber](#BKMK_msdyn_salesorder_quote_generatedsalesordernumber)
- [order_details](#BKMK_order_details)


### <a name="BKMK_lk_opportunitysalesprocess_salesorderid"></a> lk_opportunitysalesprocess_salesorderid

Same as the [lk_opportunitysalesprocess_salesorderid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_salesorderid) many-to-one relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunitysalesprocess|
|ReferencingAttribute|salesorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|salesorder_opportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_order_invoices"></a> order_invoices

Same as the [order_invoices](invoice.md#BKMK_order_invoices) many-to-one relationship for the [invoice](invoice.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|salesorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|order_invoices|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_SalesOrder_OrderClose"></a> SalesOrder_OrderClose

Same as the [SalesOrder_OrderClose](orderclose.md#BKMK_SalesOrder_OrderClose) many-to-one relationship for the [orderclose](orderclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|salesorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|SalesOrder_OrderClose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_salesorder_quote_generatedsalesordernumber"></a> msdyn_salesorder_quote_generatedsalesordernumber

**Added by**: Dynamics 365 Supply Chain Extended Solution

Same as the [msdyn_salesorder_quote_generatedsalesordernumber](quote.md#BKMK_msdyn_salesorder_quote_generatedsalesordernumber) many-to-one relationship for the [quote](quote.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|msdyn_generatedsalesordernumber|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_salesorder_quote_generatedsalesordernumber|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_order_details"></a> order_details

Same as the [order_details](salesorderdetail.md#BKMK_order_details) many-to-one relationship for the [salesorderdetail](salesorderdetail.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|salesorderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|order_details|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [order_customer_accounts](#BKMK_order_customer_accounts)
- [order_customer_contacts](#BKMK_order_customer_contacts)
- [opportunity_sales_orders](#BKMK_opportunity_sales_orders)
- [price_level_orders](#BKMK_price_level_orders)
- [quote_orders](#BKMK_quote_orders)
- [campaign_orders](#BKMK_campaign_orders)
- [msdyn_account_salesorder_InvoiceCustomer](#BKMK_msdyn_account_salesorder_InvoiceCustomer)
- [msdyn_account_salesorder_InvoiceCustomerId](#BKMK_msdyn_account_salesorder_InvoiceCustomerId)
- [msdyn_contact_salesorder_ContactPerson](#BKMK_msdyn_contact_salesorder_ContactPerson)
- [msdyn_contact_salesorder_InvoiceCustomerId](#BKMK_msdyn_contact_salesorder_InvoiceCustomerId)


### <a name="BKMK_order_customer_accounts"></a> order_customer_accounts

**Added by**: System Solution Solution

See the [order_customer_accounts](account.md#BKMK_order_customer_accounts) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_order_customer_contacts"></a> order_customer_contacts

**Added by**: System Solution Solution

See the [order_customer_contacts](contact.md#BKMK_order_customer_contacts) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_opportunity_sales_orders"></a> opportunity_sales_orders

See the [opportunity_sales_orders](opportunity.md#BKMK_opportunity_sales_orders) one-to-many relationship for the [opportunity](opportunity.md) table/entity.

### <a name="BKMK_price_level_orders"></a> price_level_orders

**Added by**: Product Management Solution

See the [price_level_orders](pricelevel.md#BKMK_price_level_orders) one-to-many relationship for the [pricelevel](pricelevel.md) table/entity.

### <a name="BKMK_quote_orders"></a> quote_orders

See the [quote_orders](quote.md#BKMK_quote_orders) one-to-many relationship for the [quote](quote.md) table/entity.

### <a name="BKMK_campaign_orders"></a> campaign_orders

**Added by**: Marketing Solution

See the [campaign_orders](campaign.md#BKMK_campaign_orders) one-to-many relationship for the [campaign](campaign.md) table/entity.

### <a name="BKMK_msdyn_account_salesorder_InvoiceCustomer"></a> msdyn_account_salesorder_InvoiceCustomer

**Added by**: System Solution Solution

See the [msdyn_account_salesorder_InvoiceCustomer](account.md#BKMK_msdyn_account_salesorder_InvoiceCustomer) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_msdyn_account_salesorder_InvoiceCustomerId"></a> msdyn_account_salesorder_InvoiceCustomerId

**Added by**: System Solution Solution

See the [msdyn_account_salesorder_InvoiceCustomerId](account.md#BKMK_msdyn_account_salesorder_InvoiceCustomerId) one-to-many relationship for the [account](account.md) table/entity.

### <a name="BKMK_msdyn_contact_salesorder_ContactPerson"></a> msdyn_contact_salesorder_ContactPerson

**Added by**: System Solution Solution

See the [msdyn_contact_salesorder_ContactPerson](contact.md#BKMK_msdyn_contact_salesorder_ContactPerson) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_msdyn_contact_salesorder_InvoiceCustomerId"></a> msdyn_contact_salesorder_InvoiceCustomerId

**Added by**: System Solution Solution

See the [msdyn_contact_salesorder_InvoiceCustomerId](contact.md#BKMK_msdyn_contact_salesorder_InvoiceCustomerId) one-to-many relationship for the [contact](contact.md) table/entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the SalesOrder table is the first table in the relationship. Listed by **SchemaName**.


### <a name="BKMK_contactorders_association"></a> contactorders_association

IntersectEntityName: contactorders<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|salesorderid|
|IsCustomizable|False|
|LogicalName|salesorder|
|NavigationPropertyName|contactorders_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|contact|
|IntersectAttribute|contactid|
|NavigationPropertyName|contactorders_association|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)