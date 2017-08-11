---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_resourcecategorypricelevel EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ec13a064-378e-4695-b8fd-8dd7c68ce2af
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_resourcecategorypricelevel entitytype."
---
# msdyn_resourcecategorypricelevel EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_resourcecategorypricelevel.md](./descriptions/msdyn_resourcecategorypricelevel.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_resourcecategorypricelevels </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Role Price</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_resourcecategorypricelevelid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_description</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_resourcecategorypricelevel entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_percent|Edm.Decimal|**Display Name**: Percent<br />**Description**: Enter the markup percent over cost. This field is relevant only when the price calculation method selected is "Markup over cost."<br />|
|msdyn_price|Edm.Decimal|**Display Name**: Price<br />**Description**: Enter the price in time units of the role.<br />|
|msdyn_price_base|Edm.Decimal|**Display Name**: Price (Base)<br />**Description**: Value of the Price in base currency.<br />Read-only<br />|
|msdyn_pricecalculation|Edm.Int32|**Display Name**: Price Calculation<br />**Description**: Select the price calculation method to determine the price as a function of cost. This field is only relevant for expense categories.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Price per unit</td></tr><tr><td>192350001</td><td>At cost</td></tr><tr><td>192350002</td><td>Markup percentage</td></tr><tbody></table>|
|msdyn_priceinprimaryunit|Edm.Decimal|**Display Name**: Price In Primary Unit<br />**Description**: Value of the price in primary unit of the unit group<br />|
|msdyn_priceinprimaryunit_base|Edm.Decimal|**Display Name**: Price In Primary Unit (Base)<br />**Description**: Value of the Price In Primary Unit in base currency.<br />Read-only<br />|
|msdyn_resourcecategorypricelevelid|Edm.Guid|**Display Name**: Resource Category Price<br />**Description**: Unique identifier for entity instances<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Resource Category Price<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Resource Category Price<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_organizationalunit_value|msdyn_organizationalunit<br />|Select the organizational unit of the resource performing the work.|
|_msdyn_pricelist_value|msdyn_PriceList<br />|Select the price list to which this price list item is being added.|
|_msdyn_primaryunit_value|msdyn_PrimaryUnit<br />|Select the primary unit of the unit schedule selected.|
|_msdyn_resourcecategory_value|msdyn_ResourceCategory<br />|Select the role that the price is being set for.|
|_msdyn_unit_value|msdyn_Unit<br />|Select the units of time in which role is being priced.|
|_msdyn_unitschedule_value|msdyn_UnitSchedule<br />|Select the unit schedule of the time unit selected.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourcecategorypricelevel_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourcecategorypricelevel_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourcecategorypricelevel_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourcecategorypricelevel_modifiedonbehalfby|
|msdyn_organizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_resourcecategorypricelevel_organizationalunit|
|msdyn_PriceList|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList|
|msdyn_PrimaryUnit|[uom EntityType](uom.md)|msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit|
|msdyn_ResourceCategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory|
|msdyn_Unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_resourcecategorypricelevel_Unit|
|msdyn_UnitSchedule|[uomschedule EntityType](uomschedule.md)|msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_resourcecategorypricelevel|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_resourcecategorypricelevel|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_resourcecategorypricelevel_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_resourcecategorypricelevel|  
|msdyn_resourcecategorypricelevel_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_resourcecategorypricelevel|  
|msdyn_resourcecategorypricelevel_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_resourcecategorypricelevel|  
|msdyn_resourcecategorypricelevel_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_resourcecategorypricelevel|  
|msdyn_resourcecategorypricelevel_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_resourcecategorypricelevel|  
|msdyn_resourcecategorypricelevel_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_resourcecategorypricelevel|  

## Operations
The following operations can be used with the msdyn_resourcecategorypricelevel entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_resourcecategorypricelevel entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_resourcecategorypricelevel.md](./remarks/msdyn_resourcecategorypricelevel.md)]

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