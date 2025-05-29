---
title: "Invoice table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Invoice table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Invoice table/entity reference (Microsoft Dynamics 365)

Order that has been billed.

## Messages

The following table lists the messages for the Invoice table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /invoices(*invoiceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /invoices<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /invoices(*invoiceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GenerateInvoiceFromOpportunity`<br />Event: False |**GenerateInvoiceFromOpportunity action** |<xref:Microsoft.Crm.Sdk.Messages.GenerateInvoiceFromOpportunityRequest>|
| `GetQuantityDecimal`<br />Event: False |**GetQuantityDecimal function** |<xref:Microsoft.Crm.Sdk.Messages.GetQuantityDecimalRequest>|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `LockInvoicePricing`<br />Event: True |**LockInvoicePricing action** |<xref:Microsoft.Crm.Sdk.Messages.LockInvoicePricingRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /invoices(*invoiceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /invoices<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `Rollup`<br />Event: False |<xref:Microsoft.Dynamics.CRM.Rollup?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
| `SetState`<br />Event: True |`PATCH` /invoices(*invoiceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /invoices(*invoiceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /invoices(*invoiceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Invoice table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `CalculatePrice`|<xref:Microsoft.Dynamics.CRM.CalculatePrice?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|

## Properties

The following table lists selected properties for the Invoice table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Invoice** |
| **DisplayCollectionName** | **Invoices** |
| **SchemaName** | `Invoice` |
| **CollectionSchemaName** | `Invoices` |
| **EntitySetName** | `invoices`|
| **LogicalName** | `invoice` |
| **LogicalCollectionName** | `invoices` |
| **PrimaryIdAttribute** | `invoiceid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BillTo_City](#BKMK_BillTo_City)
- [BillTo_Country](#BKMK_BillTo_Country)
- [BillTo_Fax](#BKMK_BillTo_Fax)
- [BillTo_Line1](#BKMK_BillTo_Line1)
- [BillTo_Line2](#BKMK_BillTo_Line2)
- [BillTo_Line3](#BKMK_BillTo_Line3)
- [BillTo_Name](#BKMK_BillTo_Name)
- [BillTo_PostalCode](#BKMK_BillTo_PostalCode)
- [BillTo_StateOrProvince](#BKMK_BillTo_StateOrProvince)
- [BillTo_Telephone](#BKMK_BillTo_Telephone)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [DateDelivered](#BKMK_DateDelivered)
- [Description](#BKMK_Description)
- [DiscountAmount](#BKMK_DiscountAmount)
- [DiscountPercentage](#BKMK_DiscountPercentage)
- [DueDate](#BKMK_DueDate)
- [EmailAddress](#BKMK_EmailAddress)
- [EntityImage](#BKMK_EntityImage)
- [FreightAmount](#BKMK_FreightAmount)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InvoiceId](#BKMK_InvoiceId)
- [InvoiceNumber](#BKMK_InvoiceNumber)
- [IsPriceLocked](#BKMK_IsPriceLocked)
- [LastBackofficeSubmit](#BKMK_LastBackofficeSubmit)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [Name](#BKMK_Name)
- [OpportunityId](#BKMK_OpportunityId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PaymentTermsCode](#BKMK_PaymentTermsCode)
- [PriceLevelId](#BKMK_PriceLevelId)
- [PricingErrorCode](#BKMK_PricingErrorCode)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [SalesOrderId](#BKMK_SalesOrderId)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
- [ShipTo_City](#BKMK_ShipTo_City)
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

### <a name="BKMK_DateDelivered"></a> DateDelivered

|Property|Value|
|---|---|
|Description|**Enter the date when the products included in the invoice were delivered.**|
|DisplayName|**Date Delivered**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`datedelivered`|
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
|Description|**Type additional information to describe the invoice, such as shipping details or product substitutions.**|
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
|Description|**Type the discount amount for the invoice if the customer is eligible for special savings.**|
|DisplayName|**Invoice Discount Amount**|
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
|Description|**Type the discount rate that should be applied to the Detail Amount field, for use in calculating the Pre-Freight Amount and Total Amount values for the invoice.**|
|DisplayName|**Invoice Discount (%)**|
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

### <a name="BKMK_DueDate"></a> DueDate

|Property|Value|
|---|---|
|Description|**Enter the date by which the invoice should be paid by the customer.**|
|DisplayName|**Due Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`duedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Inactive|
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
|Description|**Type the cost of freight or shipping for the products included in the invoice for use in calculating the total amount due.**|
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

### <a name="BKMK_InvoiceId"></a> InvoiceId

|Property|Value|
|---|---|
|Description|**Unique identifier of the invoice.**|
|DisplayName|**Invoice**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`invoiceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_InvoiceNumber"></a> InvoiceNumber

|Property|Value|
|---|---|
|Description|**Shows the identifying number or code of the invoice.**|
|DisplayName|**Invoice ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`invoicenumber`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|GlobalChoiceName|`invoice_ispricelocked`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_LastBackofficeSubmit"></a> LastBackofficeSubmit

|Property|Value|
|---|---|
|Description|**Enter the date and time when the invoice was last submitted to an accounting or ERP system for processing.**|
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
|Description|**Type a descriptive name for the invoice.**|
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
|Description|**Choose the opportunity that the invoice is related to for reporting and analytics.**|
|DisplayName|**Opportunity**|
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
|GlobalChoiceName|`invoice_paymenttermscode`|

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
|Description|**Type of pricing error for the invoice.**|
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
|GlobalChoiceName|`invoice_prioritycode`|

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

### <a name="BKMK_SalesOrderId"></a> SalesOrderId

|Property|Value|
|---|---|
|Description|**Choose the order related to the invoice to make sure the order is fulfilled and invoiced correctly.**|
|DisplayName|**Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesorderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|salesorder|

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
|GlobalChoiceName|`invoice_shippingmethodcode`|

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
|DisplayName|**Ship To Fax**|
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
|GlobalChoiceName|`invoice_shipto_freighttermscode`|

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
|Description|**Skip Price Calculation (For Internal Use)**|
|DisplayName|**Skip Price Calculation**|
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
|Description|**Choose the service level agreement (SLA) that you want to apply to the invoice record.**|
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
|Description|**Shows whether the invoice is active, paid, or canceled. Paid and canceled invoices are read-only and can't be edited unless they are reactivated.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`invoice_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Closed (deprecated)**<br />DefaultStatus: 100003<br />InvariantName: `Closed`|
|2|Label: **Paid**<br />DefaultStatus: 100001<br />InvariantName: `Paid`|
|3|Label: **Canceled**<br />DefaultStatus: 100003<br />InvariantName: `Canceled`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the invoice's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`invoice_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **New**<br />State:0<br />TransitionData: None|
|2|Label: **Partially Shipped**<br />State:0<br />TransitionData: None|
|3|Label: **Canceled (deprecated)**<br />State:1<br />TransitionData: None|
|4|Label: **Billed**<br />State:0<br />TransitionData: None|
|5|Label: **Booked (applies to services)**<br />State:0<br />TransitionData: None|
|6|Label: **Installed (applies to services)**<br />State:0<br />TransitionData: None|
|7|Label: **Paid in Full (deprecated)**<br />State:1<br />TransitionData: None|
|100001|Label: **Complete**<br />State:2<br />TransitionData: None|
|100002|Label: **Partial**<br />State:2<br />TransitionData: None|
|100003|Label: **Canceled**<br />State:3<br />TransitionData: None|

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
|Description|**Shows the total amount due, calculated as the sum of the products, discount, freight, and taxes for the invoice.**|
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
|Description|**Shows the total product amount due, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the invoice.**|
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
|Description|**Shows the total discount amount, based on the discount price and rate entered on the invoice.**|
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
|Description|**Shows the sum of all existing and write-in products included on the invoice, based on the specified price list and quantities.**|
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
|Description|**Shows the Manual Discount amounts specified on all products included in the invoice. This value is reflected in the Detail Amount field on the invoice and is added to any discount amount or rate specified on the invoice.**|
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
|Description|**Shows the total of the Tax amounts specified on all products included in the invoice, included in the Total Amount due calculation for the invoice.**|
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
|Description|**Select whether the products included in the invoice should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.**|
|DisplayName|**Ship To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`willcall`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`invoice_willcall`|
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
|Description|**Unique identifier of the account with which the invoice is associated.**|
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
|Description|**Unique identifier of the contact associated with the invoice.**|
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
|Description|**Value of the Invoice Discount Amount in base currency.**|
|DisplayName|**Invoice Discount Amount (Base)**|
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
|Description|**Shows the duration in minutes for which the invoice was on hold.**|
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
|Description|**Last SLA that was applied to this invoice. This field is for internal use only.**|
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

- [business_unit_invoices](#BKMK_business_unit_invoices)
- [invoice_customer_accounts](#BKMK_invoice_customer_accounts)
- [invoice_customer_contacts](#BKMK_invoice_customer_contacts)
- [lk_invoice_createdonbehalfby](#BKMK_lk_invoice_createdonbehalfby)
- [lk_invoice_modifiedonbehalfby](#BKMK_lk_invoice_modifiedonbehalfby)
- [lk_invoicebase_createdby](#BKMK_lk_invoicebase_createdby)
- [lk_invoicebase_modifiedby](#BKMK_lk_invoicebase_modifiedby)
- [manualsla_invoice](#BKMK_manualsla_invoice)
- [opportunity_invoices](#BKMK_opportunity_invoices)
- [order_invoices](#BKMK_order_invoices)
- [owner_invoices](#BKMK_owner_invoices)
- [price_level_invoices](#BKMK_price_level_invoices)
- [processstage_invoices](#BKMK_processstage_invoices)
- [sla_invoice](#BKMK_sla_invoice)
- [system_user_invoices](#BKMK_system_user_invoices)
- [team_invoices](#BKMK_team_invoices)
- [transactioncurrency_invoice](#BKMK_transactioncurrency_invoice)

### <a name="BKMK_business_unit_invoices"></a> business_unit_invoices

One-To-Many Relationship: [businessunit business_unit_invoices](businessunit.md#BKMK_business_unit_invoices)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_invoice_customer_accounts"></a> invoice_customer_accounts

One-To-Many Relationship: [account invoice_customer_accounts](account.md#BKMK_invoice_customer_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_invoice_customer_contacts"></a> invoice_customer_contacts

One-To-Many Relationship: [contact invoice_customer_contacts](contact.md#BKMK_invoice_customer_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_lk_invoice_createdonbehalfby"></a> lk_invoice_createdonbehalfby

One-To-Many Relationship: [systemuser lk_invoice_createdonbehalfby](systemuser.md#BKMK_lk_invoice_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_invoice_modifiedonbehalfby"></a> lk_invoice_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_invoice_modifiedonbehalfby](systemuser.md#BKMK_lk_invoice_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_invoicebase_createdby"></a> lk_invoicebase_createdby

One-To-Many Relationship: [systemuser lk_invoicebase_createdby](systemuser.md#BKMK_lk_invoicebase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_invoicebase_modifiedby"></a> lk_invoicebase_modifiedby

One-To-Many Relationship: [systemuser lk_invoicebase_modifiedby](systemuser.md#BKMK_lk_invoicebase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_manualsla_invoice"></a> manualsla_invoice

One-To-Many Relationship: [sla manualsla_invoice](sla.md#BKMK_manualsla_invoice)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`sla_invoice_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_invoices"></a> opportunity_invoices

One-To-Many Relationship: [opportunity opportunity_invoices](opportunity.md#BKMK_opportunity_invoices)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`opportunityid`|
|ReferencingEntityNavigationPropertyName|`opportunityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_order_invoices"></a> order_invoices

One-To-Many Relationship: [salesorder order_invoices](salesorder.md#BKMK_order_invoices)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`salesorderid`|
|ReferencingEntityNavigationPropertyName|`salesorderid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_invoices"></a> owner_invoices

One-To-Many Relationship: [owner owner_invoices](owner.md#BKMK_owner_invoices)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_price_level_invoices"></a> price_level_invoices

One-To-Many Relationship: [pricelevel price_level_invoices](pricelevel.md#BKMK_price_level_invoices)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`pricelevelid`|
|ReferencingEntityNavigationPropertyName|`pricelevelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_invoices"></a> processstage_invoices

One-To-Many Relationship: [processstage processstage_invoices](processstage.md#BKMK_processstage_invoices)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_invoice"></a> sla_invoice

One-To-Many Relationship: [sla sla_invoice](sla.md#BKMK_sla_invoice)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_invoice_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_system_user_invoices"></a> system_user_invoices

One-To-Many Relationship: [systemuser system_user_invoices](systemuser.md#BKMK_system_user_invoices)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_invoices"></a> team_invoices

One-To-Many Relationship: [team team_invoices](team.md#BKMK_team_invoices)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_invoice"></a> transactioncurrency_invoice

One-To-Many Relationship: [transactioncurrency transactioncurrency_invoice](transactioncurrency.md#BKMK_transactioncurrency_invoice)

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

- [invoice_activity_parties](#BKMK_invoice_activity_parties)
- [Invoice_ActivityPointers](#BKMK_Invoice_ActivityPointers)
- [invoice_adx_inviteredemptions](#BKMK_invoice_adx_inviteredemptions)
- [invoice_adx_portalcomments](#BKMK_invoice_adx_portalcomments)
- [Invoice_Annotation](#BKMK_Invoice_Annotation)
- [Invoice_Appointments](#BKMK_Invoice_Appointments)
- [Invoice_AsyncOperations](#BKMK_Invoice_AsyncOperations)
- [Invoice_BulkDeleteFailures](#BKMK_Invoice_BulkDeleteFailures)
- [invoice_chats](#BKMK_invoice_chats)
- [invoice_connections1](#BKMK_invoice_connections1)
- [invoice_connections2](#BKMK_invoice_connections2)
- [invoice_details](#BKMK_invoice_details)
- [Invoice_Emails](#BKMK_Invoice_Emails)
- [Invoice_Faxes](#BKMK_Invoice_Faxes)
- [Invoice_Letters](#BKMK_Invoice_Letters)
- [Invoice_MailboxTrackingFolder](#BKMK_Invoice_MailboxTrackingFolder)
- [invoice_msdyn_copilottranscripts](#BKMK_invoice_msdyn_copilottranscripts)
- [invoice_msdyn_ocliveworkitems](#BKMK_invoice_msdyn_ocliveworkitems)
- [invoice_msdyn_ocsessions](#BKMK_invoice_msdyn_ocsessions)
- [invoice_msfp_alerts](#BKMK_invoice_msfp_alerts)
- [invoice_msfp_surveyinvites](#BKMK_invoice_msfp_surveyinvites)
- [invoice_msfp_surveyresponses](#BKMK_invoice_msfp_surveyresponses)
- [Invoice_Phonecalls](#BKMK_Invoice_Phonecalls)
- [invoice_principalobjectattributeaccess](#BKMK_invoice_principalobjectattributeaccess)
- [Invoice_ProcessSessions](#BKMK_Invoice_ProcessSessions)
- [Invoice_RecurringAppointmentMasters](#BKMK_Invoice_RecurringAppointmentMasters)
- [Invoice_ServiceAppointments](#BKMK_Invoice_ServiceAppointments)
- [Invoice_SocialActivities](#BKMK_Invoice_SocialActivities)
- [Invoice_SyncErrors](#BKMK_Invoice_SyncErrors)
- [Invoice_Tasks](#BKMK_Invoice_Tasks)
- [slakpiinstance_invoice](#BKMK_slakpiinstance_invoice)

### <a name="BKMK_invoice_activity_parties"></a> invoice_activity_parties

Many-To-One Relationship: [activityparty invoice_activity_parties](activityparty.md#BKMK_invoice_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`invoice_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_ActivityPointers"></a> Invoice_ActivityPointers

Many-To-One Relationship: [activitypointer Invoice_ActivityPointers](activitypointer.md#BKMK_Invoice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_ActivityPointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_adx_inviteredemptions"></a> invoice_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption invoice_adx_inviteredemptions](adx_inviteredemption.md#BKMK_invoice_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_adx_portalcomments"></a> invoice_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment invoice_adx_portalcomments](adx_portalcomment.md#BKMK_invoice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_Annotation"></a> Invoice_Annotation

Many-To-One Relationship: [annotation Invoice_Annotation](annotation.md#BKMK_Invoice_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_Appointments"></a> Invoice_Appointments

Many-To-One Relationship: [appointment Invoice_Appointments](appointment.md#BKMK_Invoice_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_AsyncOperations"></a> Invoice_AsyncOperations

Many-To-One Relationship: [asyncoperation Invoice_AsyncOperations](asyncoperation.md#BKMK_Invoice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_BulkDeleteFailures"></a> Invoice_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Invoice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Invoice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_chats"></a> invoice_chats

Many-To-One Relationship: [chat invoice_chats](chat.md#BKMK_invoice_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_connections1"></a> invoice_connections1

Many-To-One Relationship: [connection invoice_connections1](connection.md#BKMK_invoice_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`invoice_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_connections2"></a> invoice_connections2

Many-To-One Relationship: [connection invoice_connections2](connection.md#BKMK_invoice_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`invoice_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_details"></a> invoice_details

Many-To-One Relationship: [invoicedetail invoice_details](invoicedetail.md#BKMK_invoice_details)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`invoiceid`|
|ReferencedEntityNavigationPropertyName|`invoice_details`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMInvoiceDetail.RetrieveByObject`<br />ViewId: `966f79a8-5200-4dab-bafd-6de1947ee181`|

### <a name="BKMK_Invoice_Emails"></a> Invoice_Emails

Many-To-One Relationship: [email Invoice_Emails](email.md#BKMK_Invoice_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_Faxes"></a> Invoice_Faxes

Many-To-One Relationship: [fax Invoice_Faxes](fax.md#BKMK_Invoice_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_Letters"></a> Invoice_Letters

Many-To-One Relationship: [letter Invoice_Letters](letter.md#BKMK_Invoice_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_MailboxTrackingFolder"></a> Invoice_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder Invoice_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Invoice_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_msdyn_copilottranscripts"></a> invoice_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript invoice_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_invoice_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_msdyn_ocliveworkitems"></a> invoice_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem invoice_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_invoice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_msdyn_ocsessions"></a> invoice_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession invoice_msdyn_ocsessions](msdyn_ocsession.md#BKMK_invoice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_msfp_alerts"></a> invoice_msfp_alerts

Many-To-One Relationship: [msfp_alert invoice_msfp_alerts](msfp_alert.md#BKMK_invoice_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_msfp_surveyinvites"></a> invoice_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite invoice_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_invoice_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_msfp_surveyresponses"></a> invoice_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse invoice_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_invoice_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`invoice_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_Phonecalls"></a> Invoice_Phonecalls

Many-To-One Relationship: [phonecall Invoice_Phonecalls](phonecall.md#BKMK_Invoice_Phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_Phonecalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_invoice_principalobjectattributeaccess"></a> invoice_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess invoice_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_invoice_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`invoice_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_ProcessSessions"></a> Invoice_ProcessSessions

Many-To-One Relationship: [processsession Invoice_ProcessSessions](processsession.md#BKMK_Invoice_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_RecurringAppointmentMasters"></a> Invoice_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster Invoice_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Invoice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_ServiceAppointments"></a> Invoice_ServiceAppointments

Many-To-One Relationship: [serviceappointment Invoice_ServiceAppointments](serviceappointment.md#BKMK_Invoice_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_SocialActivities"></a> Invoice_SocialActivities

Many-To-One Relationship: [socialactivity Invoice_SocialActivities](socialactivity.md#BKMK_Invoice_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_SyncErrors"></a> Invoice_SyncErrors

Many-To-One Relationship: [syncerror Invoice_SyncErrors](syncerror.md#BKMK_Invoice_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Invoice_Tasks"></a> Invoice_Tasks

Many-To-One Relationship: [task Invoice_Tasks](task.md#BKMK_Invoice_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Invoice_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_slakpiinstance_invoice"></a> slakpiinstance_invoice

Many-To-One Relationship: [slakpiinstance slakpiinstance_invoice](slakpiinstance.md#BKMK_slakpiinstance_invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`slakpiinstance`|
|ReferencingAttribute|`regarding`|
|ReferencedEntityNavigationPropertyName|`slakpiinstance_invoice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_contactinvoices_association"></a> contactinvoices_association

See [contact contactinvoices_association Many-To-Many Relationship](contact.md#BKMK_contactinvoices_association)

|Property|Value|
|---|---|
|IntersectEntityName|`contactinvoices`|
|IsCustomizable|False|
|SchemaName|`contactinvoices_association`|
|IntersectAttribute|`invoiceid`|
|NavigationPropertyName|`contactinvoices_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMInvoice.RetrieveContacts`<br />ViewId: `00000000-0000-0000-00aa-000010001210`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

