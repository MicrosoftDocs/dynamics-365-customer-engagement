---
title: "Microsoft Dynamics 365 Customer Engagement productassociation EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 29302c07-c782-4f59-81e5-61317c01cbfd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API productassociation entitytype."
---
# productassociation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/productassociation.md](./descriptions/productassociation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]productassociations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Product Association</td></tr>
<tr><td><b>Primary Key:</b></td><td>productassociationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>productidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The productassociation entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|dmtimportstate|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|productassociationid|Edm.Guid|**Display Name**: Product Association ID<br />**Description**: Shows the unique identifier of the product association.<br />|
|productisrequired|Edm.Int32|**Display Name**: Required<br />**Description**: Select whether the associated product is required or optional.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Optional</td></tr><tr><td>1</td><td>Required</td></tr><tbody></table>|
|propertycustomizationstatus|Edm.Int32|**Display Name**: Property Customization<br />**Description**: Shows whether the item has properties that can be customized.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Available</td></tr><tr><td>1</td><td>Available</td></tr><tbody></table>|
|quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Type the quantity of the products added to the bundle or kit.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the associated product is active or inactive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tr><td>2</td><td>Draft</td></tr><tr><td>3</td><td>Under Revision</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the associated product's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tr><td>0</td><td>Draft</td></tr><tr><td>3</td><td>DraftActive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_associatedproduct_value|associatedproduct<br />|Select a product to add to the bundle or kit.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_productid_value|productid<br />|Select a bundle or a kit.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the record.|
|_uomid_value|uomid<br />|Shows the unit of the product association.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|associatedproduct|[product EntityType](product.md)|Product_ProductAssociation_AssocProd|
|createdby|[systemuser EntityType](systemuser.md)|lk_ProductAssociate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_ProductAssociation_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_ProductAssociation_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_ProductAssociation_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_ProductAssociation|
|productid|[product EntityType](product.md)|Product_ProductAssociation_Prod|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_ProductAssociation|
|uomid|[uom EntityType](uom.md)|unit_of_measurement_productassociation|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ProductAssociation_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_productassociation|  
|productassociation_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_productassociation|  
|ProductAssociation_DynamicProperty|[dynamicproperty EntityType](dynamicproperty.md)|regardingobjectid_productassociation|  
|ProductAssociation_DynamicPropertyAssociation|[dynamicpropertyassociation EntityType](dynamicpropertyassociation.md)|regardingobjectid_productassociation|  
|productAssociation_invoice_details|[invoicedetail EntityType](invoicedetail.md)|productassociationid_productassociation|  
|productAssociation_opportunity_product|[opportunityproduct EntityType](opportunityproduct.md)|productassociationid_productassociation|  
|productAssociation_quote_details|[quotedetail EntityType](quotedetail.md)|productassociationid_productassociation|  
|productAssociation_salesorder_details|[salesorderdetail EntityType](salesorderdetail.md)|productassociationid_productassociation|  
|ProductAssociation_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_productassociation_syncerror|  

## Solutions
The following solutions include the productassociation entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|    

[!INCLUDE[./remarks/productassociation.md](./remarks/productassociation.md)]

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