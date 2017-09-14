---
title: "Microsoft Dynamics 365 Customer Engagement productsubstitute EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d3f383db-ebca-4082-927f-15b29af51ada
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API productsubstitute entitytype."
---
# productsubstitute EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/productsubstitute.md](./descriptions/productsubstitute.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]productsubstitutes </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Product Relationship</td></tr>
<tr><td><b>Primary Key:</b></td><td>productsubstituteid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The productsubstitute entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|direction|Edm.Int32|**Display Name**: Direction<br />**Description**: Select whether the relationship is unidirectional or bidirectional.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Uni-Directional</td></tr><tr><td>1</td><td>Bi-Directional</td></tr><tbody></table>|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: name<br />**Description**: name<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|productsubstituteid|Edm.Guid|**Display Name**: Product Relationship ID<br />**Description**: Shows the unique identifier of the product relationship.<br />|
|salesrelationshiptype|Edm.Int32|**Display Name**: Sales Relationship Type<br />**Description**: Select the type of the product relationship.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Up-sell</td></tr><tr><td>1</td><td>Cross-sell</td></tr><tr><td>2</td><td>Accessory</td></tr><tr><td>3</td><td>Substitute</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Select the product relationship's status.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows whether the product relationship is active or inactive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_productid_value|productid<br />|Shows the product that the relationship is defined for.|
|_substitutedproductid_value|substitutedproductid<br />|Select the related product that the relationship needs to be defined for.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_ProductSubstitute_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_ProductSubstitute_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_ProductSubstitute_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_ProductSubstitute_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_ProductSubstitute|
|productid|[product EntityType](product.md)|product_ProductSubstitute_productid|
|substitutedproductid|[product EntityType](product.md)|product_ProductSubstitute_substitutedproductid|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_ProductSubstitute|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ProductSubstitute_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_productsubstitute|  
|ProductSubstitute_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_productsubstitute|  
|ProductSubstitute_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_productsubstitute_syncerror|  

## Solutions
The following solutions include the productsubstitute entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|    

[!INCLUDE[./remarks/productsubstitute.md](./remarks/productsubstitute.md)]

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