---
title: "Microsoft Dynamics 365 Customer Engagement invoicedetail EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7f55bf98-38d0-475a-b425-787e944b0024
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API invoicedetail entitytype."
---
# invoicedetail EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/invoicedetail.md](./descriptions/invoicedetail.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]invoicedetails </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Invoice Line</td></tr>
<tr><td><b>Primary Key:</b></td><td>invoicedetailid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>productidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|actualdeliveryon|Edm.DateTimeOffset|**Display Name**: Delivered On<br />**Description**: Enter the date when the invoiced product was delivered to the customer.<br />|
|baseamount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Shows the total price of the invoice product, based on the price per unit, volume discount, and quantity.<br />|
|baseamount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the product line item of the invoice.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the invoice detail with respect to the base currency.<br />Read-only<br />|
|extendedamount|Edm.Decimal|**Display Name**: Extended Amount<br />**Description**: Shows the total amount due for the invoice product, based on the sum of the unit price, quantity, discounts, and tax.<br />|
|extendedamount_base|Edm.Decimal|**Display Name**: Extended Amount (Base)<br />**Description**: Value of the Extended Amount in base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|invoicedetailid|Edm.Guid|**Display Name**: Invoice Product<br />**Description**: Unique identifier of the invoice product line item.<br />|
|invoiceispricelocked|Edm.Boolean|**Display Name**: Invoice Is Price Locked<br />**Description**: Information about whether invoice product pricing is locked.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|invoicestatecode|Edm.Int32|**Display Name**: Invoice Status<br />**Description**: Status of the invoice product.<br />Read-only<br />|
|iscopied|Edm.Boolean|**Display Name**: Copied<br />**Description**: Select whether the invoice product is copied from another item or data source.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ispriceoverridden|Edm.Boolean|**Display Name**: Pricing<br />**Description**: Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the invoice product.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Override Price</td></tr><tr><td>0</td><td>Use Default</td></tr><tbody></table>|
|isproductoverridden|Edm.Boolean|**Display Name**: Select Product<br />**Description**: Select whether the product exists in the Microsoft Dynamics 365 product catalog or is a write-in product specific to the parent invoice.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Write In</td></tr><tr><td>0</td><td>Existing</td></tr><tbody></table>|
|lineitemnumber|Edm.Int32|**Display Name**: Line Item Number<br />**Description**: Type the line item number for the invoice product to easily identify the product in the invoice and make sure it's listed in the correct order.<br />|
|manualdiscountamount|Edm.Decimal|**Display Name**: Manual Discount<br />**Description**: Type the manual discount amount for the invoice product to deduct any negotiated or other savings from the product total.<br />|
|manualdiscountamount_base|Edm.Decimal|**Display Name**: Manual Discount (Base)<br />**Description**: Value of the Manual Discount in base currency.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_billingmethod|Edm.Int32|**Display Name**: Billing Method<br />**Description**: Billing method for the project invoice line. Valid values are Time and Material and Fixed Price<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Time and Material</td></tr><tr><td>192350001</td><td>Fixed Price</td></tr><tbody></table>|
|msdyn_chargeableamount|Edm.Decimal|**Display Name**: Chargeable Amount<br />**Description**: The amount from included line details that is chargeable.<br />|
|msdyn_chargeableamount_base|Edm.Decimal|**Display Name**: Chargeable Amount (Base)<br />**Description**: Value of the Chargeable Amount in base currency.<br />Read-only<br />|
|msdyn_complimentaryamount|Edm.Decimal|**Display Name**: Complimentary Amount<br />**Description**: The amount from included line details that is complimentary and won't be charged.<br />|
|msdyn_complimentaryamount_base|Edm.Decimal|**Display Name**: Complimentary Amount (Base)<br />**Description**: Value of the Complimentary Amount in base currency.<br />Read-only<br />|
|msdyn_contractline|Edm.String|**Display Name**: Project Contract Line<br />**Description**: Shows the project contract line for this invoice line.<br />|
|msdyn_contractlineamount|Edm.Decimal|**Display Name**: Contract Line Amount<br />**Description**: Amount from the related project contract line if present.<br />|
|msdyn_contractlineamount_base|Edm.Decimal|**Display Name**: Contract Line Amount (Base)<br />**Description**: Value of the project contract line amount in base currency.<br />Read-only<br />|
|msdyn_invoicedtilldate|Edm.Decimal|**Display Name**: Amount Previously Invoiced<br />**Description**: Amount already invoiced to customer for the same project contract line.<br />|
|msdyn_invoicedtilldate_base|Edm.Decimal|**Display Name**: Amount Previously Invoiced (Base)<br />**Description**: Value of the Amount Previously Invoiced in base currency.<br />Read-only<br />|
|msdyn_lineorder|Edm.Int32|**Display Name**: Line Order<br />**Description**: Shows the order of this invoice product within the invoice.<br />|
|msdyn_linetype|Edm.Int32|**Display Name**: Line Type<br />**Description**: The field to distinguish the Invoice lines to be of project service or field service<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Project Service Line</td></tr><tr><td>690970001</td><td>Field Service Line</td></tr><tbody></table>|
|msdyn_nonchargeableamount|Edm.Decimal|**Display Name**: Non Chargeable Amount<br />**Description**: The amount from included line details that is non-chargeable.<br />|
|msdyn_nonchargeableamount_base|Edm.Decimal|**Display Name**: Non Chargeable Amount (Base)<br />**Description**: Value of the Non Chargeable Amount in base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|parentbundleid|Edm.Guid|**Display Name**: Parent Bundle<br />**Description**: Choose the parent bundle associated with this product<br />|
|priceperunit|Edm.Decimal|**Display Name**: Price Per Unit<br />**Description**: Type the price per unit of the invoice product. The default is the value in the price list specified on the parent invoice for existing products.<br />|
|priceperunit_base|Edm.Decimal|**Display Name**: Price Per Unit (Base)<br />**Description**: Value of the Price Per Unit in base currency.<br />Read-only<br />|
|pricingerrorcode|Edm.Int32|**Display Name**: Pricing Error <br />**Description**: Pricing error for the invoice product line item.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Detail Error</td></tr><tr><td>2</td><td>Missing Price Level</td></tr><tr><td>3</td><td>Inactive Price Level</td></tr><tr><td>4</td><td>Missing Quantity</td></tr><tr><td>5</td><td>Missing Unit Price</td></tr><tr><td>6</td><td>Missing Product</td></tr><tr><td>7</td><td>Invalid Product</td></tr><tr><td>8</td><td>Missing Pricing Code</td></tr><tr><td>9</td><td>Invalid Pricing Code</td></tr><tr><td>10</td><td>Missing UOM</td></tr><tr><td>11</td><td>Product Not In Price Level</td></tr><tr><td>12</td><td>Missing Price Level Amount</td></tr><tr><td>13</td><td>Missing Price Level Percentage</td></tr><tr><td>14</td><td>Missing Price</td></tr><tr><td>15</td><td>Missing Current Cost</td></tr><tr><td>16</td><td>Missing Standard Cost</td></tr><tr><td>17</td><td>Invalid Price Level Amount</td></tr><tr><td>18</td><td>Invalid Price Level Percentage</td></tr><tr><td>19</td><td>Invalid Price</td></tr><tr><td>20</td><td>Invalid Current Cost</td></tr><tr><td>21</td><td>Invalid Standard Cost</td></tr><tr><td>22</td><td>Invalid Rounding Policy</td></tr><tr><td>23</td><td>Invalid Rounding Option</td></tr><tr><td>24</td><td>Invalid Rounding Amount</td></tr><tr><td>25</td><td>Price Calculation Error</td></tr><tr><td>26</td><td>Invalid Discount Type</td></tr><tr><td>27</td><td>Discount Type Invalid State</td></tr><tr><td>28</td><td>Invalid Discount</td></tr><tr><td>29</td><td>Invalid Quantity</td></tr><tr><td>30</td><td>Invalid Pricing Precision</td></tr><tr><td>31</td><td>Missing Product Default UOM</td></tr><tr><td>32</td><td>Missing Product UOM Schedule </td></tr><tr><td>33</td><td>Inactive Discount Type</td></tr><tr><td>34</td><td>Invalid Price Level Currency</td></tr><tr><td>35</td><td>Price Attribute Out Of Range</td></tr><tr><td>36</td><td>Base Currency Attribute Overflow</td></tr><tr><td>37</td><td>Base Currency Attribute Underflow</td></tr><tbody></table>|
|productassociationid|Edm.Guid|**Display Name**: Bundle Item Association<br />**Description**: Unique identifier of the product line item association with bundle in the invoice<br />|
|productdescription|Edm.String|**Display Name**: Name<br />**Description**: Type a name or description to identify the type of write-in product included in the invoice.<br />|
|producttypecode|Edm.Int32|**Display Name**: Product type<br />**Description**: Product Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Product</td></tr><tr><td>2</td><td>Bundle</td></tr><tr><td>3</td><td>Required Bundle Product</td></tr><tr><td>4</td><td>Optional Bundle Product</td></tr><tr><td>5</td><td>Project-based Service</td></tr><tbody></table>|
|propertyconfigurationstatus|Edm.Int32|**Display Name**: Property Configuration<br />**Description**: Status of the property configuration.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Edit</td></tr><tr><td>1</td><td>Rectify</td></tr><tr><td>2</td><td>NotConfigured</td></tr><tbody></table>|
|quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Type the amount or quantity of the product included in the invoice's total amount due.<br />|
|quantitybackordered|Edm.Decimal|**Display Name**: Quantity Back Ordered<br />**Description**: Type the amount or quantity of the product that is back ordered for the invoice.<br />|
|quantitycancelled|Edm.Decimal|**Display Name**: Quantity Canceled<br />**Description**: Type the amount or quantity of the product that was canceled for the invoice line item.<br />|
|quantityshipped|Edm.Decimal|**Display Name**: Quantity Shipped<br />**Description**: Type the amount or quantity of the product that was shipped.<br />|
|sequencenumber|Edm.Int32|**Display Name**: Sequence Number<br />**Description**: Shows the ID of the data that maintains the sequence.<br />|
|shippingtrackingnumber|Edm.String|**Display Name**: Shipment Tracking Number<br />**Description**: Type a tracking number for shipment of the invoiced product.<br />|
|shipto_city|Edm.String|**Display Name**: Ship To City<br />**Description**: Type the city for the customer's shipping address.<br />|
|shipto_country|Edm.String|**Display Name**: Ship To Country/Region<br />**Description**: Type the country or region for the customer's shipping address.<br />|
|shipto_fax|Edm.String|**Display Name**: Ship To Fax<br />**Description**: Type the fax number for the customer's shipping address.<br />|
|shipto_freighttermscode|Edm.Int32|**Display Name**: Freight Terms<br />**Description**: Select the freight terms to make sure shipping orders are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FOB</td></tr><tr><td>2</td><td>No Charge</td></tr><tbody></table>|
|shipto_line1|Edm.String|**Display Name**: Ship To Street 1<br />**Description**: Type the first line of the customer's shipping address.<br />|
|shipto_line2|Edm.String|**Display Name**: Ship To Street 2<br />**Description**: Type the second line of the customer's shipping address.<br />|
|shipto_line3|Edm.String|**Display Name**: Ship To Street 3<br />**Description**: Type the third line of the shipping address.<br />|
|shipto_name|Edm.String|**Display Name**: Ship To Name<br />**Description**: Type a name for the customer's shipping address, such as "Headquarters" or "Field office",  to identify the address.<br />|
|shipto_postalcode|Edm.String|**Display Name**: Ship To ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the shipping address.<br />|
|shipto_stateorprovince|Edm.String|**Display Name**: Ship To State/Province<br />**Description**: Type the state or province for the shipping address.<br />|
|shipto_telephone|Edm.String|**Display Name**: Ship To Phone<br />**Description**: Type the phone number for the customer's shipping address.<br />|
|tax|Edm.Decimal|**Display Name**: Tax<br />**Description**: Type the tax amount for the invoice product.<br />|
|tax_base|Edm.Decimal|**Display Name**: Tax (Base)<br />**Description**: Value of the Tax in base currency.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|
|volumediscountamount|Edm.Decimal|**Display Name**: Volume Discount<br />**Description**: Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.<br />Read-only<br />|
|volumediscountamount_base|Edm.Decimal|**Display Name**: Volume Discount (Base)<br />**Description**: Value of the Volume Discount in base currency.<br />Read-only<br />|
|willcall|Edm.Boolean|**Display Name**: Ship To<br />**Description**: Select whether the invoice product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Will Call</td></tr><tr><td>0</td><td>Address</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows the user who created the invoice product line item.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows the delegate user who created the invoice detail.|
|_invoiceid_value|invoiceid<br />|Unique identifier of the invoice associated with the invoice product line item.|
|_modifiedby_value|modifiedby<br />|Shows the user who last modified the invoice product line item.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows the delegate user who last modified the invoice detail.|
|_msdyn_agreement_value|msdyn_agreement<br />|Unique identifier for Agreement associated with Invoice Product.|
|_msdyn_agreementinvoiceproduct_value|msdyn_agreementinvoiceproduct<br />|Unique identifier for Agreement Invoice Product associated with Invoice Product.|
|_msdyn_currency_value|msdyn_currency<br />|Unique identifier for Currency associated with Invoice Product.|
|_msdyn_orderinvoicingproduct_value|msdyn_OrderInvoicingProduct<br />|Unique identifier for Order Invoicing Product associated with Invoice Product.|
|_msdyn_project_value|msdyn_Project<br />|Shows the project for this invoice line.|
|_msdyn_workorderid_value|msdyn_workorderid<br />|Unique identifier for Work Order associated with Invoice Product.|
|_msdyn_workorderproductid_value|msdyn_workorderproductid<br />|Unique identifier for Work Order Product associated with Invoice Product.|
|_msdyn_workorderserviceid_value|msdyn_workorderserviceid<br />|Unique identifier for Work Order Service associated with Invoice Product.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_productid_value|productid<br />|Choose the product to include on the invoice.|
|_salesrepid_value|salesrepid<br />|Choose the user responsible for the sale of the invoice product.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|_uomid_value|uomid<br />|Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_invoicedetailbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_invoicedetail_createdonbehalfby|
|invoiceid|[invoice EntityType](invoice.md)|invoice_details|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_invoicedetailbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_invoicedetail_modifiedonbehalfby|
|msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_msdyn_agreement_invoicedetail_Agreement|
|msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_msdyn_agreementinvoiceproduct_invoicedetail_AgreementInvoiceProduct|
|msdyn_currency|[transactioncurrency EntityType](transactioncurrency.md)|msdyn_transactioncurrency_invoicedetail_Currency|
|msdyn_OrderInvoicingProduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|msdyn_msdyn_orderinvoicingproduct_invoicedetail_OrderInvoiceProduct|
|msdyn_Project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_invoicedetail_Project|
|msdyn_workorderid|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_invoicedetail|
|msdyn_workorderproductid|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_msdyn_workorderproduct_invoicedetail|
|msdyn_workorderserviceid|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_msdyn_workorderservice_invoicedetail|
|ownerid|[principal EntityType](principal.md)|owner_invoicedetail|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_invoicedetail|
|owningteam|[team EntityType](team.md)|team_invoicedetail|
|owninguser|[systemuser EntityType](systemuser.md)|user_invoicedetail|
|parentbundleid_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|invoicedetail_parent_invoicedetail|
|productassociationid_productassociation|[productassociation EntityType](productassociation.md)|productAssociation_invoice_details|
|productid|[product EntityType](product.md)|product_invoice_details|
|salesrepid|[systemuser EntityType](systemuser.md)|system_user_invoicedetail|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_invoicedetail|
|uomid|[uom EntityType](uom.md)|unit_of_measurement_invoice_details|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|InvoiceDetail_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_invoicedetail|  
|InvoiceDetail_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_invoicedetail|  
|InvoiceDetail_Dynamicpropertyinstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|regardingobjectid_invoicedetail|  
|invoicedetail_parent_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|parentbundleid_invoicedetail|  
|InvoiceDetail_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_invoicedetail_syncerror|  

## Operations
The following operations can be used with the invoicedetail entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CalculatePrice Action](../actions/calculateprice.md)|Not Bound|[!INCLUDE[../actions/descriptions/calculateprice.md](../actions/descriptions/calculateprice.md)]|  
|[RetrieveProductProperties Function](../functions/retrieveproductproperties.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveproductproperties.md](../functions/descriptions/retrieveproductproperties.md)]|  

## Solutions
The following solutions include the invoicedetail entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/invoicedetail.md](./remarks/invoicedetail.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />