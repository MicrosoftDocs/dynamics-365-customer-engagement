---
title: "Microsoft Dynamics 365 Customer Engagement dynamicpropertyassociation EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: dee3b9ff-5c2b-452b-9a57-4576710b488d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API dynamicpropertyassociation entitytype."
---
# dynamicpropertyassociation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/dynamicpropertyassociation.md](./descriptions/dynamicpropertyassociation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]dynamicpropertyassociations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Property Association</td></tr>
<tr><td><b>Primary Key:</b></td><td>dynamicpropertyassociationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The dynamicpropertyassociation entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|associationstatus|Edm.Int32|**Display Name**: Association Status.<br />**Description**: Shows the status of the property association.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Deleted</td></tr><tr><td>2</td><td>Draft</td></tr><tr><td>3</td><td>Draft Added</td></tr><tr><td>4</td><td>Draft Deleted</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|dmtimportstate|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|dynamicpropertyassociationid|Edm.Guid|**Display Name**: Property Association ID<br />**Description**: Shows the unique identifier of the property association.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|inheritancestate|Edm.Int32|**Display Name**: Inheritance State.<br />**Description**: Shows the inheritance state in relationship to the parent property.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Inherited</td></tr><tr><td>1</td><td>Overridden</td></tr><tr><td>2</td><td>Owned</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: name<br />**Description**: name<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_dynamicpropertyid_value|dynamicpropertyid<br />|Shows the property that uses this option set item.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_regardingobjectid_value|regardingobjectid_product<br />regardingobjectid_productassociation<br />|Shows the object that the property is associated with.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_DynamicPropertyAssociationattribute_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy|
|dynamicpropertyid|[dynamicproperty EntityType](dynamicproperty.md)|Dynamicproperty_DynamicPropertyAssociation|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_DynamicPropertyAssociationattribute_ModifiedBy|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy|
|organizationid|[organization EntityType](organization.md)|DynamicPropertyAssociation_organization|
|regardingobjectid_product|[product EntityType](product.md)|Product_DynamicPropertyAssociation|
|regardingobjectid_productassociation|[productassociation EntityType](productassociation.md)|ProductAssociation_DynamicPropertyAssociation|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|DynamicPropertyAssociation_TransactionCurrency|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|dynamicpropertyassociation_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_dynamicpropertyassociation|  
|dynamicpropertyassociation_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_dynamicpropertyassociation|  
|dynamicpropertyassociation_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_dynamicpropertyassociation|  

## Solutions
The following solutions include the dynamicpropertyassociation entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|    

[!INCLUDE[./remarks/dynamicpropertyassociation.md](./remarks/dynamicpropertyassociation.md)]

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