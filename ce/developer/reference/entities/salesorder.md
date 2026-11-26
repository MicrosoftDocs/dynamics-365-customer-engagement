---
title: "Order (SalesOrder) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Order (SalesOrder) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Order (SalesOrder) table/entity reference (Microsoft Dynamics 365)

Quote that has been accepted.

## Messages

The following table lists the messages for the Order (SalesOrder) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /salesorders(*salesorderid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `CancelContract`<br />Event: True |**CancelContract action** |<xref:Microsoft.Crm.Sdk.Messages.CancelContractRequest>|
| `CancelSalesOrder`<br />Event: True |**CancelSalesOrder action** |<xref:Microsoft.Crm.Sdk.Messages.CancelSalesOrderRequest>|
| `ConvertSalesOrderToInvoice`<br />Event: True |**ConvertSalesOrderToInvoice action** |<xref:Microsoft.Crm.Sdk.Messages.ConvertSalesOrderToInvoiceRequest>|
| `Create`<br />Event: True |`POST` /salesorders<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /salesorders(*salesorderid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `FulfillSalesOrder`<br />Event: False |**FulfillSalesOrder action** |<xref:Microsoft.Crm.Sdk.Messages.FulfillSalesOrderRequest>|
| `GenerateSalesOrderFromOpportunity`<br />Event: False |**GenerateSalesOrderFromOpportunity action** |<xref:Microsoft.Crm.Sdk.Messages.GenerateSalesOrderFromOpportunityRequest>|
| `GetQuantityDecimal`<br />Event: False |**GetQuantityDecimal function** |<xref:Microsoft.Crm.Sdk.Messages.GetQuantityDecimalRequest>|
| `GetSalesOrderProductsFromOpportunity`<br />Event: False |**GetSalesOrderProductsFromOpportunity action** |<xref:Microsoft.Crm.Sdk.Messages.GetSalesOrderProductsFromOpportunityRequest>|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `LockSalesOrderPricing`<br />Event: True |**LockSalesOrderPricing action** |<xref:Microsoft.Crm.Sdk.Messages.LockSalesOrderPricingRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /salesorders(*salesorderid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /salesorders<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `Rollup`<br />Event: False |<xref:Microsoft.Dynamics.CRM.Rollup?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
| `SetState`<br />Event: True |`PATCH` /salesorders(*salesorderid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /salesorders(*salesorderid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /salesorders(*salesorderid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Order (SalesOrder) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `CalculatePrice`|<xref:Microsoft.Dynamics.CRM.CalculatePrice?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|

## Properties

The following table lists selected properties for the Order (SalesOrder) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Order** |
| **DisplayCollectionName** | **Orders** |
| **SchemaName** | `SalesOrder` |
| **CollectionSchemaName** | `SalesOrders` |
| **EntitySetName** | `salesorders`|
| **LogicalName** | `salesorder` |
| **LogicalCollectionName** | `salesorders` |
| **PrimaryIdAttribute** | `salesorderid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

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
|---|---|
|Description|**Unique identifier of the billing address.**|
|DisplayName|**Bill To Address ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`billto_addressid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_BillTo_City"></a> BillTo_City

|Property|Value|
|---|---|
|Description|**Type the city for the customer's billing address.**|
|DisplayName|**Bill To City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_BillTo_ContactName"></a> BillTo_ContactName

|Property|Value|
|---|---|
|Description|**Type the primary contact name at the customer's billing address.**|
|DisplayName|**Bill To Contact Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_contactname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_BillTo_Country"></a> BillTo_Country

|Property|Value|
|---|---|
|Description|**Type the country or region for the customer's billing address.**|
|DisplayName|**Bill To Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_BillTo_Fax"></a> BillTo_Fax

|Property|Value|
|---|---|
|Description|**Type the fax number for the customer's billing address.**|
|DisplayName|**Bill To Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_BillTo_Line1"></a> BillTo_Line1

|Property|Value|
|---|---|
|Description|**Type the first line of the customer's billing address.**|
|DisplayName|**Bill To Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_BillTo_Line2"></a> BillTo_Line2

|Property|Value|
|---|---|
|Description|**Type the second line of the customer's billing address.**|
|DisplayName|**Bill To Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_BillTo_Line3"></a> BillTo_Line3

|Property|Value|
|---|---|
|Description|**Type the third line of the billing address.**|
|DisplayName|**Bill To Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_BillTo_Name"></a> BillTo_Name

|Property|Value|
|---|---|
|Description|**Type a name for the customer's billing address, such as "Headquarters" or "Field office", to identify the address.**|
|DisplayName|**Bill To Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_BillTo_PostalCode"></a> BillTo_PostalCode

|Property|Value|
|---|---|
|Description|**Type the ZIP Code or postal code for the billing address.**|
|DisplayName|**Bill To ZIP/Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_BillTo_StateOrProvince"></a> BillTo_StateOrProvince

|Property|Value|
|---|---|
|Description|**Type the state or province for the billing address.**|
|DisplayName|**Bill To State/Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_BillTo_Telephone"></a> BillTo_Telephone

|Property|Value|
|---|---|
|Description|**Type the phone number for the customer's billing address.**|
|DisplayName|**Bill To Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_telephone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_CampaignId"></a> CampaignId

|Property|Value|
|---|---|
|Description|**Shows the campaign that the order was created from.**|
|DisplayName|**Source Campaign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`campaignid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|campaign|

### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|---|---|
|Description|**Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.**|
|DisplayName|**Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customerid`|
|RequiredLevel|ApplicationRequired|
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

### <a name="BKMK_DateFulfilled"></a> DateFulfilled

|Property|Value|
|---|---|
|Description|**Enter the date that all or part of the order was shipped to the customer.**|
|DisplayName|**Date Fulfilled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`datefulfilled`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the order, such as the products or services offered or details about the customer's product preferences.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_DiscountAmount"></a> DiscountAmount

|Property|Value|
|---|---|
|Description|**Type the discount amount for the order if the customer is eligible for special savings.**|
|DisplayName|**Order Discount Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_DiscountPercentage"></a> DiscountPercentage

|Property|Value|
|---|---|
|Description|**Type the discount rate that should be applied to the Detail Amount field to include additional savings for the customer in the order.**|
|DisplayName|**Order Discount (%)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discountpercentage`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

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

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**The default image for the entity.**|
|DisplayName|**Entity Image**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_FreightAmount"></a> FreightAmount

|Property|Value|
|---|---|
|Description|**Type the cost of freight or shipping for the products included in the order for use in calculating the Total Amount field.**|
|DisplayName|**Freight Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`freightamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_FreightTermsCode"></a> FreightTermsCode

|Property|Value|
|---|---|
|Description|**Select the freight terms to make sure shipping charges are processed correctly.**|
|DisplayName|**Freight Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`freighttermscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`salesorder_freighttermscode`|

#### FreightTermsCode Choices/Options

|Value|Label|
|---|---|
|1|**FOB**|
|2|**No Charge**|

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

### <a name="BKMK_IsPriceLocked"></a> IsPriceLocked

|Property|Value|
|---|---|
|Description|**Select whether prices specified on the invoice are locked from any further updates.**|
|DisplayName|**Prices Locked**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ispricelocked`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`salesorder_ispricelocked`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_LastBackofficeSubmit"></a> LastBackofficeSubmit

|Property|Value|
|---|---|
|Description|**Enter the date and time when the order was last submitted to an accounting or ERP system for processing.**|
|DisplayName|**Last Submitted to Back Office**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastbackofficesubmit`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|---|---|
|Description|**Contains the date time stamp of the last on hold time.**|
|DisplayName|**Last On Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastonholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type a descriptive name for the order.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_OpportunityId"></a> OpportunityId

|Property|Value|
|---|---|
|Description|**Choose the related opportunity so that the data for the order and opportunity are linked for reporting and analytics.**|
|DisplayName|**Opportunity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`opportunityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_OrderCreationMethod"></a> OrderCreationMethod

|Property|Value|
|---|---|
|Description||
|DisplayName|**Creation Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ordercreationmethod`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|776160000|
|GlobalChoiceName|`salesordercreationmethod`|

#### OrderCreationMethod Choices/Options

|Value|Label|
|---|---|
|776160000|**Unknown**|
|776160001|**Win Quote**|

### <a name="BKMK_OrderNumber"></a> OrderNumber

|Property|Value|
|---|---|
|Description|**Shows the order number for customer reference and to use in search. The number cannot be modified.**|
|DisplayName|**Order ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ordernumber`|
|RequiredLevel|SystemRequired|
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
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_PaymentTermsCode"></a> PaymentTermsCode

|Property|Value|
|---|---|
|Description|**Select the payment terms to indicate when the customer needs to pay the total amount.**|
|DisplayName|**Payment Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`paymenttermscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`salesorder_paymenttermscode`|

#### PaymentTermsCode Choices/Options

|Value|Label|
|---|---|
|1|**Net 30**|
|2|**2% 10, Net 30**|
|3|**Net 45**|
|4|**Net 60**|

### <a name="BKMK_PriceLevelId"></a> PriceLevelId

|Property|Value|
|---|---|
|Description|**Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`pricelevelid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_PricingErrorCode"></a> PricingErrorCode

|Property|Value|
|---|---|
|Description|**Select the type of pricing error, such as a missing or invalid product, or missing quantity.**|
|DisplayName|**Pricing Error**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`pricingerrorcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`qooi_pricingerrorcode`|

#### PricingErrorCode Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**Detail Error**|
|2|**Missing Price Level**|
|3|**Inactive Price Level**|
|4|**Missing Quantity**|
|5|**Missing Unit Price**|
|6|**Missing Product**|
|7|**Invalid Product**|
|8|**Missing Pricing Code**|
|9|**Invalid Pricing Code**|
|10|**Missing UOM**|
|11|**Product Not In Price Level**|
|12|**Missing Price Level Amount**|
|13|**Missing Price Level Percentage**|
|14|**Missing Price**|
|15|**Missing Current Cost**|
|16|**Missing Standard Cost**|
|17|**Invalid Price Level Amount**|
|18|**Invalid Price Level Percentage**|
|19|**Invalid Price**|
|20|**Invalid Current Cost**|
|21|**Invalid Standard Cost**|
|22|**Invalid Rounding Policy**|
|23|**Invalid Rounding Option**|
|24|**Invalid Rounding Amount**|
|25|**Price Calculation Error**|
|26|**Invalid Discount Type**|
|27|**Discount Type Invalid State**|
|28|**Invalid Discount**|
|29|**Invalid Quantity**|
|30|**Invalid Pricing Precision**|
|31|**Missing Product Default UOM**|
|32|**Missing Product UOM Schedule**|
|33|**Inactive Discount Type**|
|34|**Invalid Price Level Currency**|
|35|**Price Attribute Out Of Range**|
|36|**Base Currency Attribute Overflow**|
|37|**Base Currency Attribute Underflow**|
|38|**Transaction currency is not set for the product price list item**|

### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|---|---|
|Description|**Select the priority so that preferred customers or critical issues are handled quickly.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`prioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`salesorder_prioritycode`|

#### PriorityCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

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

### <a name="BKMK_QuoteId"></a> QuoteId

|Property|Value|
|---|---|
|Description|**Choose the related quote so that order data and quote data are linked for reporting and analytics.**|
|DisplayName|**Quote**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`quoteid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|quote|

### <a name="BKMK_RequestDeliveryBy"></a> RequestDeliveryBy

|Property|Value|
|---|---|
|Description|**Enter the delivery date requested by the customer for all products in the order.**|
|DisplayName|**Requested Delivery Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`requestdeliveryby`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SalesOrderId"></a> SalesOrderId

|Property|Value|
|---|---|
|Description|**Unique identifier of the order.**|
|DisplayName|**Order**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`salesorderid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|---|---|
|Description|**Select a shipping method for deliveries sent to this address.**|
|DisplayName|**Shipping Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shippingmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`salesorder_shippingmethodcode`|

#### ShippingMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Airborne**|
|2|**DHL**|
|3|**FedEx**|
|4|**UPS**|
|5|**Postal Mail**|
|6|**Full Load**|
|7|**Will Call**|

### <a name="BKMK_ShipTo_AddressId"></a> ShipTo_AddressId

|Property|Value|
|---|---|
|Description|**Unique identifier of the shipping address.**|
|DisplayName|**Ship To Address ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`shipto_addressid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ShipTo_City"></a> ShipTo_City

|Property|Value|
|---|---|
|Description|**Type the city for the customer's shipping address.**|
|DisplayName|**Ship To City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_ShipTo_ContactName"></a> ShipTo_ContactName

|Property|Value|
|---|---|
|Description|**Type the primary contact name at the customer's shipping address.**|
|DisplayName|**Ship To Contact Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_contactname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_ShipTo_Country"></a> ShipTo_Country

|Property|Value|
|---|---|
|Description|**Type the country or region for the customer's shipping address.**|
|DisplayName|**Ship To Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_ShipTo_Fax"></a> ShipTo_Fax

|Property|Value|
|---|---|
|Description|**Type the fax number for the customer's shipping address.**|
|DisplayName|**Ship to Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_ShipTo_FreightTermsCode"></a> ShipTo_FreightTermsCode

|Property|Value|
|---|---|
|Description|**Select the freight terms to make sure shipping orders are processed correctly.**|
|DisplayName|**Ship To Freight Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_freighttermscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`salesorder_shipto_freighttermscode`|

#### ShipTo_FreightTermsCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_ShipTo_Line1"></a> ShipTo_Line1

|Property|Value|
|---|---|
|Description|**Type the first line of the customer's shipping address.**|
|DisplayName|**Ship To Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_ShipTo_Line2"></a> ShipTo_Line2

|Property|Value|
|---|---|
|Description|**Type the second line of the customer's shipping address.**|
|DisplayName|**Ship To Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_ShipTo_Line3"></a> ShipTo_Line3

|Property|Value|
|---|---|
|Description|**Type the third line of the shipping address.**|
|DisplayName|**Ship To Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_ShipTo_Name"></a> ShipTo_Name

|Property|Value|
|---|---|
|Description|**Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.**|
|DisplayName|**Ship To Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_ShipTo_PostalCode"></a> ShipTo_PostalCode

|Property|Value|
|---|---|
|Description|**Type the ZIP Code or postal code for the shipping address.**|
|DisplayName|**Ship To ZIP/Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_ShipTo_StateOrProvince"></a> ShipTo_StateOrProvince

|Property|Value|
|---|---|
|Description|**Type the state or province for the shipping address.**|
|DisplayName|**Ship To State/Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_ShipTo_Telephone"></a> ShipTo_Telephone

|Property|Value|
|---|---|
|Description|**Type the phone number for the customer's shipping address.**|
|DisplayName|**Ship To Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_telephone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_SkipPriceCalculation"></a> SkipPriceCalculation

|Property|Value|
|---|---|
|Description|**Skip Price Calculation**|
|DisplayName|**Skip Price Calculation (For Internal Use)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`skippricecalculation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`qooi_skippricecalculation`|

#### SkipPriceCalculation Choices/Options

|Value|Label|
|---|---|
|0|**DoPriceCalcAlways**|
|1|**SkipPriceCalcOnRetrieve**|

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) that you want to apply to the sales order record.**|
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

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Shows whether the order is active, submitted, fulfilled, canceled, or invoiced. Only active orders can be edited.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`salesorder_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Submitted**<br />DefaultStatus: 3<br />InvariantName: `Submitted`|
|2|Label: **Canceled**<br />DefaultStatus: 4<br />InvariantName: `Canceled`|
|3|Label: **Fulfilled**<br />DefaultStatus: 100001<br />InvariantName: `Fulfilled`|
|4|Label: **Invoiced**<br />DefaultStatus: 100003<br />InvariantName: `Invoiced`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the order's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`salesorder_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **New**<br />State:0<br />TransitionData: None|
|2|Label: **Pending**<br />State:0<br />TransitionData: None|
|3|Label: **In Progress**<br />State:1<br />TransitionData: None|
|4|Label: **No Money**<br />State:2<br />TransitionData: None|
|100001|Label: **Complete**<br />State:3<br />TransitionData: None|
|100002|Label: **Partial**<br />State:3<br />TransitionData: None|
|100003|Label: **Invoiced**<br />State:4<br />TransitionData: None|

### <a name="BKMK_SubmitDate"></a> SubmitDate

|Property|Value|
|---|---|
|Description|**Enter the date when the order was submitted to the fulfillment or shipping center.**|
|DisplayName|**Date Submitted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`submitdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SubmitStatus"></a> SubmitStatus

|Property|Value|
|---|---|
|Description|**Type the code for the submitted status in the fulfillment or shipping center system.**|
|DisplayName|**Submitted Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`submitstatus`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_SubmitStatusDescription"></a> SubmitStatusDescription

|Property|Value|
|---|---|
|Description|**Type additional details or notes about the order for the fulfillment or shipping center.**|
|DisplayName|**Submitted Status Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`submitstatusdescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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

### <a name="BKMK_TotalAmount"></a> TotalAmount

|Property|Value|
|---|---|
|Description|**Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the order.**|
|DisplayName|**Total Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalAmountLessFreight"></a> TotalAmountLessFreight

|Property|Value|
|---|---|
|Description|**Shows the total product amount for the order, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the order.**|
|DisplayName|**Total Pre-Freight Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalamountlessfreight`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalDiscountAmount"></a> TotalDiscountAmount

|Property|Value|
|---|---|
|Description|**Shows the total discount amount, based on the discount price and rate entered on the order.**|
|DisplayName|**Total Discount Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaldiscountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalLineItemAmount"></a> TotalLineItemAmount

|Property|Value|
|---|---|
|Description|**Shows the sum of all existing and write-in products included on the order, based on the specified price list and quantities.**|
|DisplayName|**Total Detail Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totallineitemamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalLineItemDiscountAmount"></a> TotalLineItemDiscountAmount

|Property|Value|
|---|---|
|Description|**Shows the total of the Manual Discount amounts specified on all products included in the order. This value is reflected in the Detail Amount field on the order and is added to any discount amount or rate specified on the order.**|
|DisplayName|**Total Line Item Discount Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totallineitemdiscountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalTax"></a> TotalTax

|Property|Value|
|---|---|
|Description|**Shows the Tax amounts specified on all products included in the order, included in the Total Amount due calculation for the order.**|
|DisplayName|**Total Tax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaltax`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|ApplicationRequired|
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

### <a name="BKMK_WillCall"></a> WillCall

|Property|Value|
|---|---|
|Description|**Select whether the products included in the order should be shipped to the specified address or held until the customer calls with further pick-up or delivery instructions.**|
|DisplayName|**Ship To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`willcall`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`salesorder_willcall`|
|DefaultValue|False|
|True Label|Will Call|
|False Label|Address|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [BillTo_Composite](#BKMK_BillTo_Composite)
- [ContactId](#BKMK_ContactId)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [DiscountAmount_Base](#BKMK_DiscountAmount_Base)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [FreightAmount_Base](#BKMK_FreightAmount_Base)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ShipTo_Composite](#BKMK_ShipTo_Composite)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [TotalAmount_Base](#BKMK_TotalAmount_Base)
- [TotalAmountLessFreight_Base](#BKMK_TotalAmountLessFreight_Base)
- [TotalDiscountAmount_Base](#BKMK_TotalDiscountAmount_Base)
- [TotalLineItemAmount_Base](#BKMK_TotalLineItemAmount_Base)
- [TotalLineItemDiscountAmount_Base](#BKMK_TotalLineItemDiscountAmount_Base)
- [TotalTax_Base](#BKMK_TotalTax_Base)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|---|---|
|Description|**Shows the parent account related to the record. This information is used to link the sales order to the account selected in the Customer field for reporting and analytics.**|
|DisplayName|**Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_BillTo_Composite"></a> BillTo_Composite

|Property|Value|
|---|---|
|Description|**Shows the complete Bill To address.**|
|DisplayName|**Bill To Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billto_composite`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|---|---|
|Description|**Shows the parent contact related to the record. This information is used to link the contract to the contact selected in the Customer field for reporting and analytics.**|
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

### <a name="BKMK_DiscountAmount_Base"></a> DiscountAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Order Discount Amount in base currency.**|
|DisplayName|**Order Discount Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`discountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

### <a name="BKMK_FreightAmount_Base"></a> FreightAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Freight Amount in base currency.**|
|DisplayName|**Freight Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`freightamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|---|---|
|Description|**Shows the duration in minutes for which the order was on hold.**|
|DisplayName|**On Hold Time (Minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`onholdtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
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

### <a name="BKMK_ShipTo_Composite"></a> ShipTo_Composite

|Property|Value|
|---|---|
|Description|**Shows the complete Ship To address.**|
|DisplayName|**Ship To Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`shipto_composite`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|---|---|
|Description|**Last SLA that was applied to this sales order. This field is for internal use only.**|
|DisplayName|**Last SLA applied**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slainvokedid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_TotalAmount_Base"></a> TotalAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Amount in base currency.**|
|DisplayName|**Total Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalAmountLessFreight_Base"></a> TotalAmountLessFreight_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Pre-Freight Amount in base currency.**|
|DisplayName|**Total Pre-Freight Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totalamountlessfreight_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalDiscountAmount_Base"></a> TotalDiscountAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Discount Amount in base currency.**|
|DisplayName|**Total Discount Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaldiscountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalLineItemAmount_Base"></a> TotalLineItemAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Detail Amount in base currency.**|
|DisplayName|**Total Detail Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totallineitemamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalLineItemDiscountAmount_Base"></a> TotalLineItemDiscountAmount_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Line Item Discount Amount in base currency.**|
|DisplayName|**Total Line Item Discount Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totallineitemdiscountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_TotalTax_Base"></a> TotalTax_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Tax in base currency.**|
|DisplayName|**Total Tax (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`totaltax_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

- [business_unit_orders](#BKMK_business_unit_orders)
- [campaign_orders](#BKMK_campaign_orders)
- [lk_salesorder_createdonbehalfby](#BKMK_lk_salesorder_createdonbehalfby)
- [lk_salesorder_modifiedonbehalfby](#BKMK_lk_salesorder_modifiedonbehalfby)
- [lk_salesorderbase_createdby](#BKMK_lk_salesorderbase_createdby)
- [lk_salesorderbase_modifiedby](#BKMK_lk_salesorderbase_modifiedby)
- [manualsla_salesorder](#BKMK_manualsla_salesorder)
- [opportunity_sales_orders](#BKMK_opportunity_sales_orders)
- [order_customer_accounts](#BKMK_order_customer_accounts)
- [order_customer_contacts](#BKMK_order_customer_contacts)
- [owner_salesorders](#BKMK_owner_salesorders)
- [price_level_orders](#BKMK_price_level_orders)
- [processstage_salesorders](#BKMK_processstage_salesorders)
- [quote_orders](#BKMK_quote_orders)
- [sla_salesorder](#BKMK_sla_salesorder)
- [system_user_orders](#BKMK_system_user_orders)
- [team_orders](#BKMK_team_orders)
- [transactioncurrency_salesorder](#BKMK_transactioncurrency_salesorder)

### <a name="BKMK_business_unit_orders"></a> business_unit_orders

One-To-Many Relationship: [businessunit business_unit_orders](businessunit.md#BKMK_business_unit_orders)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaign_orders"></a> campaign_orders

One-To-Many Relationship: [campaign campaign_orders](campaign.md#BKMK_campaign_orders)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`campaignid`|
|ReferencingEntityNavigationPropertyName|`campaignid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_salesorder_createdonbehalfby"></a> lk_salesorder_createdonbehalfby

One-To-Many Relationship: [systemuser lk_salesorder_createdonbehalfby](systemuser.md#BKMK_lk_salesorder_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_salesorder_modifiedonbehalfby"></a> lk_salesorder_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_salesorder_modifiedonbehalfby](systemuser.md#BKMK_lk_salesorder_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_salesorderbase_createdby"></a> lk_salesorderbase_createdby

One-To-Many Relationship: [systemuser lk_salesorderbase_createdby](systemuser.md#BKMK_lk_salesorderbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_salesorderbase_modifiedby"></a> lk_salesorderbase_modifiedby

One-To-Many Relationship: [systemuser lk_salesorderbase_modifiedby](systemuser.md#BKMK_lk_salesorderbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_manualsla_salesorder"></a> manualsla_salesorder

One-To-Many Relationship: [sla manualsla_salesorder](sla.md#BKMK_manualsla_salesorder)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_salesorder_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_sales_orders"></a> opportunity_sales_orders

One-To-Many Relationship: [opportunity opportunity_sales_orders](opportunity.md#BKMK_opportunity_sales_orders)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`opportunityid`|
|ReferencingEntityNavigationPropertyName|`opportunityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_order_customer_accounts"></a> order_customer_accounts

One-To-Many Relationship: [account order_customer_accounts](account.md#BKMK_order_customer_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_order_customer_contacts"></a> order_customer_contacts

One-To-Many Relationship: [contact order_customer_contacts](contact.md#BKMK_order_customer_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_salesorders"></a> owner_salesorders

One-To-Many Relationship: [owner owner_salesorders](owner.md#BKMK_owner_salesorders)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_price_level_orders"></a> price_level_orders

One-To-Many Relationship: [pricelevel price_level_orders](pricelevel.md#BKMK_price_level_orders)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`pricelevelid`|
|ReferencingEntityNavigationPropertyName|`pricelevelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_salesorders"></a> processstage_salesorders

One-To-Many Relationship: [processstage processstage_salesorders](processstage.md#BKMK_processstage_salesorders)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quote_orders"></a> quote_orders

One-To-Many Relationship: [quote quote_orders](quote.md#BKMK_quote_orders)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`quoteid`|
|ReferencingEntityNavigationPropertyName|`quoteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_salesorder"></a> sla_salesorder

One-To-Many Relationship: [sla sla_salesorder](sla.md#BKMK_sla_salesorder)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_salesorder_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_system_user_orders"></a> system_user_orders

One-To-Many Relationship: [systemuser system_user_orders](systemuser.md#BKMK_system_user_orders)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_orders"></a> team_orders

One-To-Many Relationship: [team team_orders](team.md#BKMK_team_orders)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_salesorder"></a> transactioncurrency_salesorder

One-To-Many Relationship: [transactioncurrency transactioncurrency_salesorder](transactioncurrency.md#BKMK_transactioncurrency_salesorder)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [lk_opportunitysalesprocess_salesorderid](#BKMK_lk_opportunitysalesprocess_salesorderid)
- [order_details](#BKMK_order_details)
- [order_invoices](#BKMK_order_invoices)
- [salesorder_activity_parties](#BKMK_salesorder_activity_parties)
- [SalesOrder_ActivityPointers](#BKMK_SalesOrder_ActivityPointers)
- [salesorder_adx_inviteredemptions](#BKMK_salesorder_adx_inviteredemptions)
- [salesorder_adx_portalcomments](#BKMK_salesorder_adx_portalcomments)
- [SalesOrder_Annotation](#BKMK_SalesOrder_Annotation)
- [SalesOrder_Appointments](#BKMK_SalesOrder_Appointments)
- [SalesOrder_AsyncOperations](#BKMK_SalesOrder_AsyncOperations)
- [SalesOrder_BulkDeleteFailures](#BKMK_SalesOrder_BulkDeleteFailures)
- [salesorder_chats](#BKMK_salesorder_chats)
- [salesorder_connections1](#BKMK_salesorder_connections1)
- [salesorder_connections2](#BKMK_salesorder_connections2)
- [SalesOrder_Emails](#BKMK_SalesOrder_Emails)
- [SalesOrder_Faxes](#BKMK_SalesOrder_Faxes)
- [SalesOrder_Letters](#BKMK_SalesOrder_Letters)
- [SalesOrder_MailboxTrackingFolder](#BKMK_SalesOrder_MailboxTrackingFolder)
- [salesorder_msdyn_copilottranscripts](#BKMK_salesorder_msdyn_copilottranscripts)
- [salesorder_msdyn_ocliveworkitems](#BKMK_salesorder_msdyn_ocliveworkitems)
- [salesorder_msdyn_ocsessions](#BKMK_salesorder_msdyn_ocsessions)
- [salesorder_msfp_alerts](#BKMK_salesorder_msfp_alerts)
- [salesorder_msfp_surveyinvites](#BKMK_salesorder_msfp_surveyinvites)
- [salesorder_msfp_surveyresponses](#BKMK_salesorder_msfp_surveyresponses)
- [SalesOrder_OrderClose](#BKMK_SalesOrder_OrderClose)
- [SalesOrder_Phonecalls](#BKMK_SalesOrder_Phonecalls)
- [salesorder_principalobjectattributeaccess](#BKMK_salesorder_principalobjectattributeaccess)
- [SalesOrder_ProcessSessions](#BKMK_SalesOrder_ProcessSessions)
- [SalesOrder_RecurringAppointmentMasters](#BKMK_SalesOrder_RecurringAppointmentMasters)
- [SalesOrder_ServiceAppointments](#BKMK_SalesOrder_ServiceAppointments)
- [SalesOrder_SocialActivities](#BKMK_SalesOrder_SocialActivities)
- [SalesOrder_SyncErrors](#BKMK_SalesOrder_SyncErrors)
- [SalesOrder_Tasks](#BKMK_SalesOrder_Tasks)
- [slakpiinstance_salesorder](#BKMK_slakpiinstance_salesorder)

### <a name="BKMK_lk_opportunitysalesprocess_salesorderid"></a> lk_opportunitysalesprocess_salesorderid

Many-To-One Relationship: [opportunitysalesprocess lk_opportunitysalesprocess_salesorderid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_salesorderid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunitysalesprocess`|
|ReferencingAttribute|`salesorderid`|
|ReferencedEntityNavigationPropertyName|`salesorder_opportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_order_details"></a> order_details

Many-To-One Relationship: [salesorderdetail order_details](salesorderdetail.md#BKMK_order_details)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorderdetail`|
|ReferencingAttribute|`salesorderid`|
|ReferencedEntityNavigationPropertyName|`order_details`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMSalesOrderDetail.RetrieveByObject`<br />ViewId: `99ac0df8-1c36-4a57-9da8-5c116b506601`|

### <a name="BKMK_order_invoices"></a> order_invoices

Many-To-One Relationship: [invoice order_invoices](invoice.md#BKMK_order_invoices)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`salesorderid`|
|ReferencedEntityNavigationPropertyName|`order_invoices`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `a84eb3ff-6dc5-4f57-bbf0-7b664c11fb62`|

### <a name="BKMK_salesorder_activity_parties"></a> salesorder_activity_parties

Many-To-One Relationship: [activityparty salesorder_activity_parties](activityparty.md#BKMK_salesorder_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`salesorder_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_ActivityPointers"></a> SalesOrder_ActivityPointers

Many-To-One Relationship: [activitypointer SalesOrder_ActivityPointers](activitypointer.md#BKMK_SalesOrder_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_ActivityPointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_adx_inviteredemptions"></a> salesorder_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption salesorder_adx_inviteredemptions](adx_inviteredemption.md#BKMK_salesorder_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_adx_portalcomments"></a> salesorder_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment salesorder_adx_portalcomments](adx_portalcomment.md#BKMK_salesorder_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_Annotation"></a> SalesOrder_Annotation

Many-To-One Relationship: [annotation SalesOrder_Annotation](annotation.md#BKMK_SalesOrder_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_Appointments"></a> SalesOrder_Appointments

Many-To-One Relationship: [appointment SalesOrder_Appointments](appointment.md#BKMK_SalesOrder_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_AsyncOperations"></a> SalesOrder_AsyncOperations

Many-To-One Relationship: [asyncoperation SalesOrder_AsyncOperations](asyncoperation.md#BKMK_SalesOrder_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_BulkDeleteFailures"></a> SalesOrder_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure SalesOrder_BulkDeleteFailures](bulkdeletefailure.md#BKMK_SalesOrder_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_chats"></a> salesorder_chats

Many-To-One Relationship: [chat salesorder_chats](chat.md#BKMK_salesorder_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_connections1"></a> salesorder_connections1

Many-To-One Relationship: [connection salesorder_connections1](connection.md#BKMK_salesorder_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`salesorder_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_connections2"></a> salesorder_connections2

Many-To-One Relationship: [connection salesorder_connections2](connection.md#BKMK_salesorder_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`salesorder_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_Emails"></a> SalesOrder_Emails

Many-To-One Relationship: [email SalesOrder_Emails](email.md#BKMK_SalesOrder_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_Faxes"></a> SalesOrder_Faxes

Many-To-One Relationship: [fax SalesOrder_Faxes](fax.md#BKMK_SalesOrder_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_Letters"></a> SalesOrder_Letters

Many-To-One Relationship: [letter SalesOrder_Letters](letter.md#BKMK_SalesOrder_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_MailboxTrackingFolder"></a> SalesOrder_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder SalesOrder_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_SalesOrder_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_msdyn_copilottranscripts"></a> salesorder_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript salesorder_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_salesorder_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_msdyn_ocliveworkitems"></a> salesorder_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem salesorder_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_salesorder_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_msdyn_ocsessions"></a> salesorder_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession salesorder_msdyn_ocsessions](msdyn_ocsession.md#BKMK_salesorder_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_msfp_alerts"></a> salesorder_msfp_alerts

Many-To-One Relationship: [msfp_alert salesorder_msfp_alerts](msfp_alert.md#BKMK_salesorder_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_msfp_surveyinvites"></a> salesorder_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite salesorder_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_salesorder_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_msfp_surveyresponses"></a> salesorder_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse salesorder_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_salesorder_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_OrderClose"></a> SalesOrder_OrderClose

Many-To-One Relationship: [orderclose SalesOrder_OrderClose](orderclose.md#BKMK_SalesOrder_OrderClose)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`salesorderid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_OrderClose`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_Phonecalls"></a> SalesOrder_Phonecalls

Many-To-One Relationship: [phonecall SalesOrder_Phonecalls](phonecall.md#BKMK_SalesOrder_Phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_Phonecalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_salesorder_principalobjectattributeaccess"></a> salesorder_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess salesorder_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_salesorder_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`salesorder_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_ProcessSessions"></a> SalesOrder_ProcessSessions

Many-To-One Relationship: [processsession SalesOrder_ProcessSessions](processsession.md#BKMK_SalesOrder_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_RecurringAppointmentMasters"></a> SalesOrder_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster SalesOrder_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_SalesOrder_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_ServiceAppointments"></a> SalesOrder_ServiceAppointments

Many-To-One Relationship: [serviceappointment SalesOrder_ServiceAppointments](serviceappointment.md#BKMK_SalesOrder_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_SocialActivities"></a> SalesOrder_SocialActivities

Many-To-One Relationship: [socialactivity SalesOrder_SocialActivities](socialactivity.md#BKMK_SalesOrder_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_SyncErrors"></a> SalesOrder_SyncErrors

Many-To-One Relationship: [syncerror SalesOrder_SyncErrors](syncerror.md#BKMK_SalesOrder_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_SalesOrder_Tasks"></a> SalesOrder_Tasks

Many-To-One Relationship: [task SalesOrder_Tasks](task.md#BKMK_SalesOrder_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SalesOrder_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_slakpiinstance_salesorder"></a> slakpiinstance_salesorder

Many-To-One Relationship: [slakpiinstance slakpiinstance_salesorder](slakpiinstance.md#BKMK_slakpiinstance_salesorder)

|Property|Value|
|---|---|
|ReferencingEntity|`slakpiinstance`|
|ReferencingAttribute|`regarding`|
|ReferencedEntityNavigationPropertyName|`slakpiinstance_salesorder`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_contactorders_association"></a> contactorders_association

See [contact contactorders_association Many-To-Many Relationship](contact.md#BKMK_contactorders_association)

|Property|Value|
|---|---|
|IntersectEntityName|`contactorders`|
|IsCustomizable|False|
|SchemaName|`contactorders_association`|
|IntersectAttribute|`salesorderid`|
|NavigationPropertyName|`contactorders_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

