---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_quoteinvoicingproduct EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 44bde551-c438-49a7-850e-3fb0f4cde7ab
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_quoteinvoicingproduct entitytype."
---
# msdyn_quoteinvoicingproduct EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_quoteinvoicingproduct.md](./descriptions/msdyn_quoteinvoicingproduct.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_quoteinvoicingproducts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Quote Invoicing Product</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_quoteinvoicingproductid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_quoteinvoicingproduct entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_amount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Total sales amount for the product line.<br />Computed<br />Read-only<br />|
|msdyn_amount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Computed<br />Read-only<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_lineorder|Edm.Int32|**Display Name**: Line Order<br />**Description**: Shows the order of this product within the quote invoicing setup.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Enter the quantity to bill.<br />|
|msdyn_quoteinvoicingproductid|Edm.Guid|**Display Name**: Quote Invoicing Produc<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_unitprice|Edm.Decimal|**Display Name**: Unit Price<br />**Description**: Enter the amount you want to charge the customer per unit.<br />|
|msdyn_unitprice_base|Edm.Decimal|**Display Name**: Unit Price (Base)<br />**Description**: Value of the Unit Price in base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Quote Invoicing Produc<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Quote Invoicing Produc<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_product_value|msdyn_Product<br />|The product associated with the transaction.|
|_msdyn_quoteinvoicingsetup_value|msdyn_QuoteInvoicingSetup<br />|The invoicing setup this product belongs to.|
|_msdyn_unit_value|msdyn_Unit<br />|The unit that determines the pricing for this product|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_quoteinvoicingproduct_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_quoteinvoicingproduct_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_quoteinvoicingproduct_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_quoteinvoicingproduct_modifiedonbehalfby|
|msdyn_Product|[product EntityType](product.md)|msdyn_product_msdyn_quoteinvoicingproduct_Product|
|msdyn_QuoteInvoicingSetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|msdyn_msdyn_quoteinvoicingsetup_msdyn_quoteinvoicingproduct_QuoteInvoicingSetup|
|msdyn_Unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_quoteinvoicingproduct_Unit|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_quoteinvoicingproduct|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_quoteinvoicingproduct|
|owningteam|[team EntityType](team.md)|team_msdyn_quoteinvoicingproduct|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_quoteinvoicingproduct|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_quoteinvoicingproduct|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_quoteinvoicingproduct_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_quoteinvoicingproduct|  
|msdyn_quoteinvoicingproduct_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_quoteinvoicingproduct|  
|msdyn_quoteinvoicingproduct_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_quoteinvoicingproduct|  
|msdyn_quoteinvoicingproduct_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_quoteinvoicingproduct|  
|msdyn_quoteinvoicingproduct_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_quoteinvoicingproduct|  

## Operations
The following operations can be used with the msdyn_quoteinvoicingproduct entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_quoteinvoicingproduct entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_quoteinvoicingproduct.md](./remarks/msdyn_quoteinvoicingproduct.md)]

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