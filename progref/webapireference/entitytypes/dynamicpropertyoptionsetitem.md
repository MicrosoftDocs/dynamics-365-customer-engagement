---
title: "Microsoft Dynamics 365 Customer Engagement dynamicpropertyoptionsetitem EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4188f606-afac-458a-a1f0-f1e3fc9808c4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API dynamicpropertyoptionsetitem entitytype."
---
# dynamicpropertyoptionsetitem EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/dynamicpropertyoptionsetitem.md](./descriptions/dynamicpropertyoptionsetitem.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]dynamicpropertyoptionsetitems </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Property Option Set Item</td></tr>
<tr><td><b>Primary Key:</b></td><td>dynamicpropertyoptionsetvalueid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>dynamicpropertyoptionname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The dynamicpropertyoptionsetitem entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|dmtimportstate|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|dynamicpropertyoptiondescription|Edm.String|**Display Name**: Description<br />**Description**: Type additional information about the property option set item.<br />|
|dynamicpropertyoptionname|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the property option set item.<br />|
|dynamicpropertyoptionsetvalueid|Edm.Guid|**Display Name**: Property Option Set ID<br />**Description**: Shows the unique identifier of the property option set item.<br />|
|dynamicpropertyoptionsetvaluesequencenumber|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|dynamicpropertyoptionvalue|Edm.Int32|**Display Name**: Value<br />**Description**: Shows the value of the property option set item.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
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
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_DynamicPropertyOptionSetItem_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_DynamicPropertyOptionSetItem_createdonbehalfby|
|dynamicpropertyid|[dynamicproperty EntityType](dynamicproperty.md)|DynamicProperty_DynamicPropertyOptionSetItem|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_DynamicPropertyOptionSetItem_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_DynamicPropertyOptionSetItem_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|DynamicPropertyOptionSetItem_organization|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|DynamicPropertyOptionSetItem_TransactionCurrency|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|DefaultValueOptionSet_DynamicProperty|[dynamicproperty EntityType](dynamicproperty.md)|dynamicpropertyoptionsetvalueid|  
|dynamicpropertyoptionsetitem_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_dynamicpropertyoptionsetitem|  
|dynamicpropertyoptionsetitem_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_dynamicpropertyoptionsetitem|  
|dynamicpropertyoptionsetitem_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_dynamicpropertyoptionsetitem|  

## Solutions
The following solutions include the dynamicpropertyoptionsetitem entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|    

[!INCLUDE[./remarks/dynamicpropertyoptionsetitem.md](./remarks/dynamicpropertyoptionsetitem.md)]

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