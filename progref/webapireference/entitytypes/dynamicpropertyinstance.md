---
title: "Microsoft Dynamics 365 Customer Engagement dynamicpropertyinstance EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 09cd31b8-fc25-4141-9511-00e40d21141f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API dynamicpropertyinstance entitytype."
---
# dynamicpropertyinstance EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/dynamicpropertyinstance.md](./descriptions/dynamicpropertyinstance.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]dynamicpropertyinstances </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Property Instance</td></tr>
<tr><td><b>Primary Key:</b></td><td>dynamicpropertyinstanceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The dynamicpropertyinstance entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|dmtimportstate|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|dynamicpropertyinstanceid|Edm.Guid|**Display Name**: Property Instance ID<br />**Description**: Shows the unique identifier of the property instance.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: name<br />**Description**: name<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|validationstatus|Edm.Boolean|**Display Name**: Is Valid<br />**Description**: Shows whether the property value is valid.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Valid</td></tr><tr><td>0</td><td>Invalid</td></tr><tbody></table>|
|valuedecimal|Edm.Decimal|**Display Name**: Decimal Value<br />**Description**: Shows the decimal value of the property.<br />|
|valuedouble|Edm.Double|**Display Name**: Double Value<br />**Description**: Shows the double value of the property.<br />|
|valueinteger|Edm.Int32|**Display Name**: Integer Value<br />**Description**: Shows the integer value of the property.<br />|
|valuestring|Edm.String|**Display Name**: String Value<br />**Description**: Shows the string value of the property.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_dynamicpropertyid_value|dynamicpropertyid<br />|Shows the property that this record is associated with.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_regardingobjectid_value|regardingobjectid_invoicedetail<br />regardingobjectid_opportunityproduct<br />regardingobjectid_quotedetail<br />regardingobjectid_salesorderdetail<br />|Shows the object that the property is associated with.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|Dynamicpropertyinsatance_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_Dynamicpropertyinsatanceattribute_createdonbehalfby|
|dynamicpropertyid|[dynamicproperty EntityType](dynamicproperty.md)|DynamicProperty_DynamicPropertyInstance|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_Dynamicpropertyinsatanceattribute_ModifiedBy|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy|
|ownerid|[principal EntityType](principal.md)|Owner_dynamicproperyinstance|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_dynamicproperyinstance|
|owningteam|[team EntityType](team.md)|team_DynamicPropertyInstance|
|owninguser|[systemuser EntityType](systemuser.md)|OwningUser_Dynamicpropertyinsatance|
|regardingobjectid_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|InvoiceDetail_Dynamicpropertyinstance|
|regardingobjectid_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|OpportunityProduct_Dynamicpropertyinstance|
|regardingobjectid_quotedetail|[quotedetail EntityType](quotedetail.md)|QuoteDetail_Dynamicpropertyinstance|
|regardingobjectid_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|SalesOrderDetail_Dynamicpropertyinstance|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Dynamicpropertyinsatance|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|dynamicpropertyinstance_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_dynamicpropertyinstance|  
|dynamicpropertyinstance_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_dynamicpropertyinstance|  
|dynamicpropertyinstance_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_dynamicpropertyinstance|  

## Operations
The following operations can be used with the dynamicpropertyinstance entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveProductProperties Function](../functions/retrieveproductproperties.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveproductproperties.md](../functions/descriptions/retrieveproductproperties.md)]|  
|[UpdateProductProperties Action](../actions/updateproductproperties.md)|Not Bound|[!INCLUDE[../actions/descriptions/updateproductproperties.md](../actions/descriptions/updateproductproperties.md)]|  

## Solutions
The following solutions include the dynamicpropertyinstance entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/dynamicpropertyinstance.md](./remarks/dynamicpropertyinstance.md)]

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