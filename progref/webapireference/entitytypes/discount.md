---
title: "Microsoft Dynamics 365 Customer Engagement discount EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: dde986a1-2fcc-4001-8b68-386a264820a8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API discount entitytype."
---
# discount EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/discount.md](./descriptions/discount.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]discounts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Discount</td></tr>
<tr><td><b>Primary Key:</b></td><td>discountid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The discount entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|amount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Amount of the discount, specified either as a percentage or as a monetary amount.<br />|
|amount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the discount was created.<br />Read-only<br />|
|discountid|Edm.Guid|**Display Name**: Discount<br />**Description**: Unique identifier of the discount.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|highquantity|Edm.Decimal|**Display Name**: End Quantity<br />**Description**: Upper boundary for the quantity range to which a particular discount can be applied.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isamounttype|Edm.Boolean|**Display Name**: Amount Type<br />**Description**: Specifies whether the discount is specified as a monetary amount or a percentage.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lowquantity|Edm.Decimal|**Display Name**: Begin Quantity<br />**Description**: Lower boundary for the quantity range to which a particular discount is applied.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the discount was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: name<br />**Description**: name<br />|
|organizationid|Edm.Guid|**Display Name**: Organization <br />**Description**: Unique identifier of the organization associated with the discount.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|percentage|Edm.Decimal|**Display Name**: Percentage<br />**Description**: Percentage discount value.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the discount.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the discount.|
|_discounttypeid_value|discounttypeid<br />|Unique identifier of the discount list associated with the discount.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the discount.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the discount.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_discountbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_discount_createdonbehalfby|
|discounttypeid|[discounttype EntityType](discounttype.md)|discount_type_discounts|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_discountbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_discount_modifiedonbehalfby|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_discount|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Discount_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_discount|  
|Discount_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_discount|  
|Discount_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_discount_syncerror|  

## Solutions
The following solutions include the discount entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/discount.md](./remarks/discount.md)]

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