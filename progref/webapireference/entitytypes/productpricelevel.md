---
title: "Microsoft Dynamics 365 Customer Engagement productpricelevel EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 05ae4f32-d590-4abf-8d9c-4574d3d11553
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API productpricelevel entitytype."
---
# productpricelevel EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/productpricelevel.md](./descriptions/productpricelevel.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]productpricelevels </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Price List Item</td></tr>
<tr><td><b>Primary Key:</b></td><td>productpricelevelid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>productidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The productpricelevel entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|amount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Monetary amount for the price list.<br />|
|amount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the price list was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the price list was last modified.<br />Read-only<br />|
|organizationid|Edm.Guid|**Display Name**: Organization<br />**Description**: Unique identifier of the organization associated with the price list.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|percentage|Edm.Decimal|**Display Name**: Percentage<br />**Description**: Percentage for the price list.<br />|
|pricingmethodcode|Edm.Int32|**Display Name**: Pricing Method<br />**Description**: Pricing method applied to the price list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Currency Amount</td></tr><tr><td>2</td><td>Percent of List</td></tr><tr><td>3</td><td>Percent Markup - Current Cost</td></tr><tr><td>4</td><td>Percent Margin - Current Cost</td></tr><tr><td>5</td><td>Percent Markup - Standard Cost</td></tr><tr><td>6</td><td>Percent Margin - Standard Cost</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|productnumber|Edm.String|**Display Name**: Product ID<br />**Description**: User-defined product number.<br />Read-only<br />|
|productpricelevelid|Edm.Guid|**Display Name**: Product Price List<br />**Description**: Unique identifier of the price list.<br />|
|quantitysellingcode|Edm.Int32|**Display Name**: Quantity Selling Option<br />**Description**: Quantity of the product that must be sold for a given price level.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No Control</td></tr><tr><td>2</td><td>Whole</td></tr><tr><td>3</td><td>Whole and Fractional</td></tr><tbody></table>|
|roundingoptionamount|Edm.Decimal|**Display Name**: Rounding Amount<br />**Description**: Rounding option amount for the price list.<br />|
|roundingoptionamount_base|Edm.Decimal|**Display Name**: Rounding Amount (Base)<br />**Description**: Value of the Rounding Amount in base currency.<br />Read-only<br />|
|roundingoptioncode|Edm.Int32|**Display Name**: Rounding Option<br />**Description**: Option for rounding the price list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Ends in</td></tr><tr><td>2</td><td>Multiple of</td></tr><tbody></table>|
|roundingpolicycode|Edm.Int32|**Display Name**: Rounding Policy<br />**Description**: Policy for rounding the price list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>None</td></tr><tr><td>2</td><td>Up</td></tr><tr><td>3</td><td>Down</td></tr><tr><td>4</td><td>To Nearest</td></tr><tbody></table>|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the price list.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_discounttypeid_value|discounttypeid<br />|Unique identifier of the discount list associated with the price list.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the price list.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_pricelevelid_value|pricelevelid<br />|Unique identifier of the price level associated with this price list.|
|_productid_value|productid<br />|Product associated with the price list.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|_uomid_value|uomid<br />|Unique identifier of the unit for the price list.|
|_uomscheduleid_value|uomscheduleid<br />|Unique identifier of the unit schedule for the price list.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_productpricelevelbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_productpricelevelbase_createdonbehalfby|
|discounttypeid|[discounttype EntityType](discounttype.md)|discount_type_product_price_levels|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_productpricelevelbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_productpricelevelbase_modifiedonbehalfby|
|pricelevelid|[pricelevel EntityType](pricelevel.md)|price_level_product_price_levels|
|productid|[product EntityType](product.md)|product_price_levels|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_productpricelevels|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_productpricelevel|
|uomid|[uom EntityType](uom.md)|unit_of_measurement_product_price_levels|
|uomscheduleid|[uomschedule EntityType](uomschedule.md)|unit_of_measure_schedule_product_price_level|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ProductPriceLevel_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_productpricelevel|  
|ProductPriceLevel_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_productpricelevel|  
|ProductPriceLevel_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_productpricelevel|  

## Solutions
The following solutions include the productpricelevel entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/productpricelevel.md](./remarks/productpricelevel.md)]

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