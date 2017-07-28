---
title: "Microsoft Dynamics 365 Customer Engagement salesorderdetail EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1bee91d4-f2b6-44f3-8c11-ad5d16a22112
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API salesorderdetail entitytype."
---
# salesorderdetail EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/salesorderdetail.md](./descriptions/salesorderdetail.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]salesorderdetails </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Order Line</td></tr>
<tr><td><b>Primary Key:</b></td><td>salesorderdetailid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>productidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|baseamount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Shows the total price of the order product, based on the price per unit, volume discount, and quantity.<br />|
|baseamount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the order product, such as manufacturing details or acceptable substitutions.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|extendedamount|Edm.Decimal|**Display Name**: Contract Line Value<br />**Description**: Shows the total amount due for the order product, based on the sum of the unit price, quantity, discounts, and tax.<br />|
|extendedamount_base|Edm.Decimal|**Display Name**: Extended Amount (Base)<br />**Description**: Shows the Extended Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|iscopied|Edm.Boolean|**Display Name**: Copied<br />**Description**: Select whether the invoice line item is copied from another item or data source.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ispriceoverridden|Edm.Boolean|**Display Name**: Pricing<br />**Description**: Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the order product.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Override Price</td></tr><tr><td>0</td><td>Use Default</td></tr><tbody></table>|
|isproductoverridden|Edm.Boolean|**Display Name**: Select Product<br />**Description**: Select whether the product exists in the Microsoft Dynamics 365 product catalog or is a write-in product specific to the order.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Write In</td></tr><tr><td>0</td><td>Existing</td></tr><tbody></table>|
|lineitemnumber|Edm.Int32|**Display Name**: Line Item Number<br />**Description**: Type the line item number for the order product to easily identify the product in the order and make sure it's listed in the correct sequence.<br />|
|manualdiscountamount|Edm.Decimal|**Display Name**: Manual Discount<br />**Description**: Type the manual discount amount for the order product to deduct any negotiated or other savings from the product total on the order.<br />|
|manualdiscountamount_base|Edm.Decimal|**Display Name**: Manual Discount (Base)<br />**Description**: Value of the Manual Discount in base currency.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_billingmethod|Edm.Int32|**Display Name**: Billing Method<br />**Description**: Billing method for the project contract line. Valid values are Time and Material and Fixed Price<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Time and Material</td></tr><tr><td>192350001</td><td>Fixed Price</td></tr><tbody></table>|
|msdyn_billingstartdate|Edm.DateTimeOffset|**Display Name**: Billing Start Date<br />**Description**: Select the billing start date for the project contract line.<br />|
|msdyn_budgetamount|Edm.Decimal|**Display Name**: Budget Amount<br />**Description**: Enter the amount the customer has set aside or is willing to pay for the project contract component.<br />|
|msdyn_budgetamount_base|Edm.Decimal|**Display Name**: Budget Amount (Base)<br />**Description**: Value of the Budget Amount in base currency.<br />Read-only<br />|
|msdyn_costamount|Edm.Decimal|**Display Name**: Cost Amount<br />**Description**: Shows the total cost price of the product based on the cost price per unit and quantity.<br />|
|msdyn_costamount_base|Edm.Decimal|**Display Name**: Cost Amount (Base)<br />**Description**: Value of the Cost Amount in base currency.<br />Read-only<br />|
|msdyn_costpriceperunit|Edm.Decimal|**Display Name**: Cost Price Per Unit<br />**Description**: Cost price per unit of the product. The default is the cost price of the product.<br />|
|msdyn_costpriceperunit_base|Edm.Decimal|**Display Name**: Cost Price Per Unit (Base)<br />**Description**: Value of the Cost Price Per Unit in base currency.<br />Read-only<br />|
|msdyn_includeexpense|Edm.Boolean|**Display Name**: Include Expense<br />**Description**: Select whether to include expenses in the project contract line.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_includefee|Edm.Boolean|**Display Name**: Include Fee<br />**Description**: Select whether to include fees in the project contract line.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_includematerial|Edm.Boolean|**Display Name**: Include Material<br />**Description**: Select whether to include materials in the project contract line.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_includetime|Edm.Boolean|**Display Name**: Include Time<br />**Description**: Select whether to include time transactions in the project contract line.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_linetype|Edm.Int32|**Display Name**: Line Type<br />**Description**: The field to distinguish the order lines to be of project service or field service<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Project Service Line</td></tr><tr><td>690970001</td><td>Field Service Line</td></tr><tbody></table>|
|msdyn_quoteline|Edm.String|**Display Name**: Quote Line<br />**Description**: Shows the quote line related to the project contract line.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|parentbundleid|Edm.Guid|**Display Name**: Parent Bundle<br />**Description**: Choose the parent bundle associated with this product<br />|
|priceperunit|Edm.Decimal|**Display Name**: Price Per Unit<br />**Description**: Type the price per unit of the order product. The default is the value in the price list specified on the order for existing products.<br />|
|priceperunit_base|Edm.Decimal|**Display Name**: Price Per Unit (Base)<br />**Description**: Value of the Price Per Unit in base currency.<br />Read-only<br />|
|pricingerrorcode|Edm.Int32|**Display Name**: Pricing Error <br />**Description**: Select the type of pricing error, such as a missing or invalid product, or missing quantity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Detail Error</td></tr><tr><td>2</td><td>Missing Price Level</td></tr><tr><td>3</td><td>Inactive Price Level</td></tr><tr><td>4</td><td>Missing Quantity</td></tr><tr><td>5</td><td>Missing Unit Price</td></tr><tr><td>6</td><td>Missing Product</td></tr><tr><td>7</td><td>Invalid Product</td></tr><tr><td>8</td><td>Missing Pricing Code</td></tr><tr><td>9</td><td>Invalid Pricing Code</td></tr><tr><td>10</td><td>Missing UOM</td></tr><tr><td>11</td><td>Product Not In Price Level</td></tr><tr><td>12</td><td>Missing Price Level Amount</td></tr><tr><td>13</td><td>Missing Price Level Percentage</td></tr><tr><td>14</td><td>Missing Price</td></tr><tr><td>15</td><td>Missing Current Cost</td></tr><tr><td>16</td><td>Missing Standard Cost</td></tr><tr><td>17</td><td>Invalid Price Level Amount</td></tr><tr><td>18</td><td>Invalid Price Level Percentage</td></tr><tr><td>19</td><td>Invalid Price</td></tr><tr><td>20</td><td>Invalid Current Cost</td></tr><tr><td>21</td><td>Invalid Standard Cost</td></tr><tr><td>22</td><td>Invalid Rounding Policy</td></tr><tr><td>23</td><td>Invalid Rounding Option</td></tr><tr><td>24</td><td>Invalid Rounding Amount</td></tr><tr><td>25</td><td>Price Calculation Error</td></tr><tr><td>26</td><td>Invalid Discount Type</td></tr><tr><td>27</td><td>Discount Type Invalid State</td></tr><tr><td>28</td><td>Invalid Discount</td></tr><tr><td>29</td><td>Invalid Quantity</td></tr><tr><td>30</td><td>Invalid Pricing Precision</td></tr><tr><td>31</td><td>Missing Product Default UOM</td></tr><tr><td>32</td><td>Missing Product UOM Schedule </td></tr><tr><td>33</td><td>Inactive Discount Type</td></tr><tr><td>34</td><td>Invalid Price Level Currency</td></tr><tr><td>35</td><td>Price Attribute Out Of Range</td></tr><tr><td>36</td><td>Base Currency Attribute Overflow</td></tr><tr><td>37</td><td>Base Currency Attribute Underflow</td></tr><tbody></table>|
|productassociationid|Edm.Guid|**Display Name**: Bundle Item Association<br />**Description**: Unique identifier of the product line item association with bundle in the sales order<br />|
|productdescription|Edm.String|**Display Name**: Name<br />**Description**: Type a name or description to identify the type of write-in product included in the order.<br />|
|producttypecode|Edm.Int32|**Display Name**: Product type<br />**Description**: Product Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Product</td></tr><tr><td>2</td><td>Bundle</td></tr><tr><td>3</td><td>Required Bundle Product</td></tr><tr><td>4</td><td>Optional Bundle Product</td></tr><tr><td>5</td><td>Project-based Service</td></tr><tbody></table>|
|propertyconfigurationstatus|Edm.Int32|**Display Name**: Property Configuration<br />**Description**: Status of the property configuration.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Edit</td></tr><tr><td>1</td><td>Rectify</td></tr><tr><td>2</td><td>NotConfigured</td></tr><tbody></table>|
|quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Type the amount or quantity of the product ordered by the customer.<br />|
|quantitybackordered|Edm.Decimal|**Display Name**: Quantity Back Ordered<br />**Description**: Type the amount or quantity of the product that is back ordered for the order.<br />|
|quantitycancelled|Edm.Decimal|**Display Name**: Quantity Canceled<br />**Description**: Type the amount or quantity of the product that was canceled.<br />|
|quantityshipped|Edm.Decimal|**Display Name**: Quantity Shipped<br />**Description**: Type the amount or quantity of the product that was shipped for the order.<br />|
|requestdeliveryby|Edm.DateTimeOffset|**Display Name**: Requested Delivery Date<br />**Description**: Enter the delivery date requested by the customer for the order product.<br />|
|salesorderdetailid|Edm.Guid|**Display Name**: Order Product<br />**Description**: Unique identifier of the product specified in the order.<br />|
|salesorderispricelocked|Edm.Boolean|**Display Name**: Order Is Price Locked<br />**Description**: Tells whether product pricing is locked for the order.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|salesorderstatecode|Edm.Int32|**Display Name**: Order Status<br />**Description**: Shows the status of the order that the order detail is associated with.<br />Read-only<br />|
|sequencenumber|Edm.Int32|**Display Name**: Sequence Number<br />**Description**: Shows the ID of the data that maintains the sequence.<br />|
|shipto_addressid|Edm.Guid|**Display Name**: Ship To Address ID<br />**Description**: Unique identifier of the shipping address.<br />|
|shipto_city|Edm.String|**Display Name**: Ship To City<br />**Description**: Type the city for the customer's shipping address.<br />|
|shipto_contactname|Edm.String|**Display Name**: Ship To Contact Name<br />**Description**: Type the primary contact name at the customer's shipping address.<br />|
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
|tax|Edm.Decimal|**Display Name**: Tax<br />**Description**: Type the tax amount for the order product.<br />|
|tax_base|Edm.Decimal|**Display Name**: Tax (Base)<br />**Description**: Value of the Tax in base currency.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|
|volumediscountamount|Edm.Decimal|**Display Name**: Volume Discount<br />**Description**: Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.<br />Read-only<br />|
|volumediscountamount_base|Edm.Decimal|**Display Name**: Volume Discount (Base)<br />**Description**: Value of the Volume Discount in base currency.<br />Read-only<br />|
|willcall|Edm.Boolean|**Display Name**: Ship To<br />**Description**: Select whether the order product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Will Call</td></tr><tr><td>0</td><td>Address</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_agreement_value|msdyn_agreement<br />|Select a Agreement for this order line|
|_msdyn_invoicefrequency_value|msdyn_invoicefrequency<br />|Select the frequency for the automatic invoice creation job to create the invoice.|
|_msdyn_project_value|msdyn_Project<br />|Select the project of the project contract line.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_productid_value|productid<br />|Choose the product to include on the order to link the product's pricing and other information to the parent order.|
|_salesorderid_value|salesorderid<br />|Shows the order for the product. The ID is used to link product pricing and other details to the total amounts and other information on the order.|
|_salesrepid_value|salesrepid<br />|Choose the user responsible for the sale of the order product.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|_uomid_value|uomid<br />|Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_salesorderdetailbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_salesorderdetail_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_salesorderdetailbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_salesorderdetail_modifiedonbehalfby|
|msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_msdyn_agreement_salesorderdetail_Agreement|
|msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency|
|msdyn_Project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_salesorderdetail_Project|
|ownerid|[principal EntityType](principal.md)|owner_salesorderdetail|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_salesorderdetail|
|owningteam|[team EntityType](team.md)|team_salesorderdetail|
|owninguser|[systemuser EntityType](systemuser.md)|user_salesorderdetail|
|parentbundleid_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|salesorderdetail_parent_salesorderdetail|
|productassociationid_productassociation|[productassociation EntityType](productassociation.md)|productAssociation_salesorder_details|
|productid|[product EntityType](product.md)|product_order_details|
|salesorderid|[salesorder EntityType](salesorder.md)|order_details|
|salesrepid|[systemuser EntityType](systemuser.md)|system_user_salesorderdetail|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_salesorderdetail|
|uomid|[uom EntityType](uom.md)|unit_of_measurement_order_details|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SalesOrderDetail_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_salesorderdetail|  
|SalesOrderDetail_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_salesorderdetail|  
|SalesOrderDetail_Dynamicpropertyinstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|regardingobjectid_salesorderdetail|  
|salesorderdetail_parent_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|parentbundleid_salesorderdetail|  
|SalesOrderDetail_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_salesorderdetail_syncerror|  

## Operations
The following operations can be used with the salesorderdetail entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CalculatePrice Action](../actions/calculateprice.md)|Not Bound|[!INCLUDE[../actions/descriptions/calculateprice.md](../actions/descriptions/calculateprice.md)]|  
|[msdyn_CreateContractLineDetailsFromEstimate Action](../actions/msdyn_createcontractlinedetailsfromestimate.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createcontractlinedetailsfromestimate.md](../actions/descriptions/msdyn_createcontractlinedetailsfromestimate.md)]|  
|[msdyn_GenerateContractLineInvoiceSchedule Action](../actions/msdyn_generatecontractlineinvoiceschedule.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_generatecontractlineinvoiceschedule.md](../actions/descriptions/msdyn_generatecontractlineinvoiceschedule.md)]|  
|[msdyn_GenerateContractLineScheduleOfValues Action](../actions/msdyn_generatecontractlinescheduleofvalues.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_generatecontractlinescheduleofvalues.md](../actions/descriptions/msdyn_generatecontractlinescheduleofvalues.md)]|  
|[msdyn_GetContractLineChargeability Action](../actions/msdyn_getcontractlinechargeability.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_getcontractlinechargeability.md](../actions/descriptions/msdyn_getcontractlinechargeability.md)]|  
|[msdyn_GetProjectMapForContractLine Action](../actions/msdyn_getprojectmapforcontractline.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_getprojectmapforcontractline.md](../actions/descriptions/msdyn_getprojectmapforcontractline.md)]|  
|[RetrieveProductProperties Function](../functions/retrieveproductproperties.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveproductproperties.md](../functions/descriptions/retrieveproductproperties.md)]|  

## Solutions
The following solutions include the salesorderdetail entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/salesorderdetail.md](./remarks/salesorderdetail.md)]

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