---
title: "Microsoft Dynamics 365 Customer Engagement discounttype EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cd5556b4-b520-4d2f-a92d-ebb21794de93
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API discounttype entitytype."
---
# discounttype EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/discounttype.md](./descriptions/discounttype.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]discounttypes </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Discount List</td></tr>
<tr><td><b>Primary Key:</b></td><td>discounttypeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The discounttype entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the discount list was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the discount list.<br />|
|discounttypeid|Edm.Guid|**Display Name**: Discount List<br />**Description**: Unique identifier of the discount list.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isamounttype|Edm.Boolean|**Display Name**: Type<br />**Description**: Information about whether the discount list amounts are specified as monetary amounts or percentages.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Amount</td></tr><tr><td>0</td><td>Percentage</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the discount list was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the discount list.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the discount list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the discount list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100001</td><td>Active</td></tr><tr><td>100002</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the discount list.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the discounttype.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the discount list.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the discounttype.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the discount type.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_discounttypebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_discounttype_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_discounttypebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_discounttype_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_discount_types|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_discounttype|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|discount_type_discounts|[discount EntityType](discount.md)|discounttypeid|  
|discount_type_product_price_levels|[productpricelevel EntityType](productpricelevel.md)|discounttypeid|  
|DiscountType_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_discounttype|  
|DiscountType_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_discounttype|  
|DiscountType_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_discounttype_syncerror|  

## Solutions
The following solutions include the discounttype entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/discounttype.md](./remarks/discounttype.md)]

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