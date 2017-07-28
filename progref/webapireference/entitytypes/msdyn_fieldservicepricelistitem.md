---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_fieldservicepricelistitem EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b9b5dba0-ab99-4185-80d1-433aac1b1e21
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_fieldservicepricelistitem entitytype."
---
# msdyn_fieldservicepricelistitem EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_fieldservicepricelistitem.md](./descriptions/msdyn_fieldservicepricelistitem.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_fieldservicepricelistitems </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Field Service Price List Item</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_fieldservicepricelistitemid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_fieldservicepricelistitem entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_durationroundingpolicy|Edm.Int32|**Display Name**: Duration Rounding Policy<br />**Description**: Specify how the system should round the Duration To Bill on the Work Order Service<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>None</td></tr><tr><td>690970001</td><td>Up</td></tr><tr><td>690970002</td><td>Down</td></tr><tr><td>690970003</td><td>Nearest</td></tr><tbody></table>|
|msdyn_durationroundto|Edm.Int32|**Display Name**: Duration Round To<br />**Description**: Specify the rounding duration.<br />|
|msdyn_fieldservicepricelistitemid|Edm.Guid|**Display Name**: Field Service Price List Item<br />**Description**: Shows the entity instances.<br />|
|msdyn_flatfee|Edm.Boolean|**Display Name**: Flat Fee<br />**Description**: If enabled then the pricing of this item will not be multiplied by quantity<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_minimumchargeamount|Edm.Decimal|**Display Name**: Minimum Charge Amount<br />**Description**: Specify the minimum charge you wish to charge for this service. See note on Minimum Charge Duration<br />|
|msdyn_minimumchargeamount_base|Edm.Decimal|**Display Name**: Minimum Charge Amount (Base)<br />**Description**: Shows the value of the minimum charge amount in the base currency.<br />Read-only<br />|
|msdyn_minimumchargeduration|Edm.Int32|**Display Name**: Minimum Charge Duration<br />**Description**: If this field has a value, the Minimum Charge Amount will first apply to the Minimum Duration and beyond the minimum duration the regular fee will apply<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Field Service Price List Item<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the field service price list item.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Shows the price list associated with the field service price list item.|
|_msdyn_productservice_value|msdyn_productservice<br />|If you wish to limit this price list item to a certain product or service you can specify it. Otherwise this should be left blank|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicepricelistitem_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicepricelistitem_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicepricelistitem_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicepricelistitem_modifiedonbehalfby|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList|
|msdyn_productservice|[product EntityType](product.md)|msdyn_product_msdyn_fieldservicepricelistitem_ProductService|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_fieldservicepricelistitem|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_fieldservicepricelistitem|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_fieldservicepricelistitem_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_fieldservicepricelistitem|  
|msdyn_fieldservicepricelistitem_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_fieldservicepricelistitem|  
|msdyn_fieldservicepricelistitem_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_fieldservicepricelistitem|  
|msdyn_fieldservicepricelistitem_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_fieldservicepricelistitem|  
|msdyn_fieldservicepricelistitem_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_fieldservicepricelistitem|  

## Operations
The following operations can be used with the msdyn_fieldservicepricelistitem entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_fieldservicepricelistitem entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_fieldservicepricelistitem.md](./remarks/msdyn_fieldservicepricelistitem.md)]

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