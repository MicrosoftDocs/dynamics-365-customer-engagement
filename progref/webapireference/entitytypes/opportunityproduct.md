---
title: "Microsoft Dynamics 365 Customer Engagement opportunityproduct EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 705d3a47-3986-4f18-bce8-8b0b408ee3af
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API opportunityproduct entitytype."
---
# opportunityproduct EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/opportunityproduct.md](./descriptions/opportunityproduct.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]opportunityproducts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Opportunity Line</td></tr>
<tr><td><b>Primary Key:</b></td><td>opportunityproductid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>productidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|baseamount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Shows the total price of the opportunity product, based on the price per unit, volume discount, and quantity.<br />|
|baseamount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the opportunity product, such as manufacturing details.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|extendedamount|Edm.Decimal|**Display Name**: Opportunity Line Amount<br />**Description**: Shows the total amount due for the opportunity product, calculated on the Amount value minus the Manual Discount amount.<br />|
|extendedamount_base|Edm.Decimal|**Display Name**: Extended Amount (Base)<br />**Description**: Shows the Extended Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|ispriceoverridden|Edm.Boolean|**Display Name**: Price Overridden<br />**Description**: Select whether the pricing on the opportunity product reflects an override of the product catalog pricing.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Override Price</td></tr><tr><td>0</td><td>Use Default</td></tr><tbody></table>|
|isproductoverridden|Edm.Boolean|**Display Name**: Select Product<br />**Description**: For system use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Write-In</td></tr><tr><td>0</td><td>Existing</td></tr><tbody></table>|
|lineitemnumber|Edm.Int32|**Display Name**: Line Item Number<br />**Description**: Type the line item number for the opportunity product to easily identify the product in the opportunity documents and make sure it's listed in the correct order.<br />|
|manualdiscountamount|Edm.Decimal|**Display Name**: Manual Discount Amount<br />**Description**: Type the manual discount amount for the opportunity product to deduct any negotiated or other savings from the product total.<br />|
|manualdiscountamount_base|Edm.Decimal|**Display Name**: Manual Discount Amount (Base)<br />**Description**: Value of the Manual Discount Amount in base currency.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_billingmethod|Edm.Int32|**Display Name**: Billing Method<br />**Description**: Billing method for the project opportunity line. Valid values are Time and Material and Fixed Price<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Time and Material</td></tr><tr><td>192350001</td><td>Fixed Price</td></tr><tbody></table>|
|msdyn_budgetamount|Edm.Decimal|**Display Name**: Budget Amount<br />**Description**: Enter the customer budget amount for this opportunity line.<br />|
|msdyn_budgetamount_base|Edm.Decimal|**Display Name**: Budget Amount (Base)<br />**Description**: Value of the Budget Amount in base currency.<br />Read-only<br />|
|msdyn_costamount|Edm.Decimal|**Display Name**: Cost Amount<br />**Description**: Shows the total cost price of the product based on the cost price per unit and quantity.<br />|
|msdyn_costamount_base|Edm.Decimal|**Display Name**: Cost Amount (Base)<br />**Description**: Value of the Cost Amount in base currency.<br />Read-only<br />|
|msdyn_costpriceperunit|Edm.Decimal|**Display Name**: Cost Price Per Unit<br />**Description**: Cost price per unit of the product. The default is the cost price of the product.<br />|
|msdyn_costpriceperunit_base|Edm.Decimal|**Display Name**: Cost Price Per Unit (Base)<br />**Description**: Value of the Cost Price Per Unit in base currency.<br />Read-only<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Enter the duration of the agreement<br />|
|msdyn_enddate|Edm.DateTimeOffset|**Display Name**: End Date<br />**Description**: Enter the end date of the agreement<br />|
|msdyn_linetype|Edm.Int32|**Display Name**: Line Type<br />**Description**: The field to distinguish the order lines to be of project service or field service<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Project Service Line</td></tr><tr><td>690970001</td><td>Field Service Line</td></tr><tbody></table>|
|msdyn_startdate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Start date of the Agreement<br />|
|opportunityproductid|Edm.Guid|**Display Name**: Opportunity Product<br />**Description**: Unique identifier of the opportunity product.<br />|
|opportunitystatecode|Edm.Int32|**Display Name**: Opportunity Status<br />**Description**: Select the status of the opportunity product.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|parentbundleid|Edm.Guid|**Display Name**: Parent Bundle<br />**Description**: Choose the parent bundle associated with this product<br />|
|priceperunit|Edm.Decimal|**Display Name**: Price Per Unit<br />**Description**: Shows the price per unit of the opportunity product, based on the price list specified on the parent opportunity.<br />|
|priceperunit_base|Edm.Decimal|**Display Name**: Price Per Unit (Base)<br />**Description**: Value of the Price Per Unit in base currency.<br />Read-only<br />|
|pricingerrorcode|Edm.Int32|**Display Name**: Pricing Error <br />**Description**: Select the pricing error for the opportunity product.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Detail Error</td></tr><tr><td>2</td><td>Missing Price Level</td></tr><tr><td>3</td><td>Inactive Price Level</td></tr><tr><td>4</td><td>Missing Quantity</td></tr><tr><td>5</td><td>Missing Unit Price</td></tr><tr><td>6</td><td>Missing Product</td></tr><tr><td>7</td><td>Invalid Product</td></tr><tr><td>8</td><td>Missing Pricing Code</td></tr><tr><td>9</td><td>Invalid Pricing Code</td></tr><tr><td>10</td><td>Missing UOM</td></tr><tr><td>11</td><td>Product Not In Price Level</td></tr><tr><td>12</td><td>Missing Price Level Amount</td></tr><tr><td>13</td><td>Missing Price Level Percentage</td></tr><tr><td>14</td><td>Missing Price</td></tr><tr><td>15</td><td>Missing Current Cost</td></tr><tr><td>16</td><td>Missing Standard Cost</td></tr><tr><td>17</td><td>Invalid Price Level Amount</td></tr><tr><td>18</td><td>Invalid Price Level Percentage</td></tr><tr><td>19</td><td>Invalid Price</td></tr><tr><td>20</td><td>Invalid Current Cost</td></tr><tr><td>21</td><td>Invalid Standard Cost</td></tr><tr><td>22</td><td>Invalid Rounding Policy</td></tr><tr><td>23</td><td>Invalid Rounding Option</td></tr><tr><td>24</td><td>Invalid Rounding Amount</td></tr><tr><td>25</td><td>Price Calculation Error</td></tr><tr><td>26</td><td>Invalid Discount Type</td></tr><tr><td>27</td><td>Discount Type Invalid State</td></tr><tr><td>28</td><td>Invalid Discount</td></tr><tr><td>29</td><td>Invalid Quantity</td></tr><tr><td>30</td><td>Invalid Pricing Precision</td></tr><tr><td>31</td><td>Missing Product Default UOM</td></tr><tr><td>32</td><td>Missing Product UOM Schedule </td></tr><tr><td>33</td><td>Inactive Discount Type</td></tr><tr><td>34</td><td>Invalid Price Level Currency</td></tr><tr><td>35</td><td>Price Attribute Out Of Range</td></tr><tr><td>36</td><td>Base Currency Attribute Overflow</td></tr><tr><td>37</td><td>Base Currency Attribute Underflow</td></tr><tbody></table>|
|productassociationid|Edm.Guid|**Display Name**: Bundle Item Association<br />**Description**: Unique identifier of the product line item association with bundle in the opportunity<br />|
|productdescription|Edm.String|**Display Name**: Name<br />**Description**: Type a detailed product description or additional notes about the opportunity product, such as talking points or product updates, that will assist the sales team when they discuss the product with the customer.<br />|
|producttypecode|Edm.Int32|**Display Name**: Product type<br />**Description**: Product Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Product</td></tr><tr><td>2</td><td>Bundle</td></tr><tr><td>3</td><td>Required Bundle Product</td></tr><tr><td>4</td><td>Optional Bundle Product</td></tr><tr><td>5</td><td>Project-based Service</td></tr><tbody></table>|
|propertyconfigurationstatus|Edm.Int32|**Display Name**: Property Configuration<br />**Description**: Status of the property configuration.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Edit</td></tr><tr><td>1</td><td>Rectify</td></tr><tr><td>2</td><td>NotConfigured</td></tr><tbody></table>|
|quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Type the amount or quantity of the product the customer would like to purchase.<br />|
|sequencenumber|Edm.Int32|**Display Name**: Sequence Number<br />**Description**: Shows the ID of the data that maintains the sequence.<br />|
|tax|Edm.Decimal|**Display Name**: Tax<br />**Description**: Type the tax amount to be applied on the opportunity product.<br />|
|tax_base|Edm.Decimal|**Display Name**: Tax (Base)<br />**Description**: Value of the Tax in base currency.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|
|volumediscountamount|Edm.Decimal|**Display Name**: Volume Discount<br />**Description**: Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.<br />Read-only<br />|
|volumediscountamount_base|Edm.Decimal|**Display Name**: Volume Discount (Base)<br />**Description**: Value of the Volume Discount in base currency.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the opportunityproduct.|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Select a price list for the opportunity line|
|_msdyn_project_value|msdyn_Project<br />|Select the project for this opportunity line.|
|_msdyn_serviceaccount_value|msdyn_serviceaccount<br />|Select the service account for the opportunity line|
|_opportunityid_value|opportunityid<br />|Unique identifier of the opportunity with which the opportunity product is associated.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_productid_value|productid<br />|Choose the product to include on the opportunity to link the product's pricing and other information to the opportunity.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|_uomid_value|uomid<br />|Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_opportunityproductbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_opportunityproduct_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_opportunityproductbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_opportunityproduct_modifiedonbehalfby|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_opportunityproduct_PriceList|
|msdyn_Project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_opportunityproduct_Project|
|msdyn_serviceaccount|[account EntityType](account.md)|msdyn_account_opportunityproduct_ServiceAccount|
|opportunityid|[opportunity EntityType](opportunity.md)|product_opportunities|
|ownerid|[principal EntityType](principal.md)|owner_opportunityproduct|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_opportunityproduct|
|owningteam|[team EntityType](team.md)|team_opportunityproduct|
|owninguser|[systemuser EntityType](systemuser.md)|user_opportunityproduct|
|parentbundleid_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|opportunityproduct_parent_opportunityproduct|
|productassociationid_productassociation|[productassociation EntityType](productassociation.md)|productAssociation_opportunity_product|
|productid|[product EntityType](product.md)|opportunity_products|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_opportunityproduct|
|uomid|[uom EntityType](uom.md)|unit_of_measurement_opportunity_products|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|OpportunityProduct_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_opportunityproduct|  
|OpportunityProduct_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_opportunityproduct|  
|OpportunityProduct_Dynamicpropertyinstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|regardingobjectid_opportunityproduct|  
|opportunityproduct_parent_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|parentbundleid_opportunityproduct|  
|OpportunityProduct_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_opportunityproduct_syncerror|  

## Operations
The following operations can be used with the opportunityproduct entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CalculatePrice Action](../actions/calculateprice.md)|Not Bound|[!INCLUDE[../actions/descriptions/calculateprice.md](../actions/descriptions/calculateprice.md)]|  
|[RetrieveProductProperties Function](../functions/retrieveproductproperties.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveproductproperties.md](../functions/descriptions/retrieveproductproperties.md)]|  

## Solutions
The following solutions include the opportunityproduct entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/opportunityproduct.md](./remarks/opportunityproduct.md)]

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