---
title: "Microsoft Dynamics 365 Customer Engagement category EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 37533ff7-ce6e-4ac9-ae03-a02367474749
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API category entitytype."
---
# category EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/category.md](./descriptions/category.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]categories </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Category</td></tr>
<tr><td><b>Primary Key:</b></td><td>categoryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The category EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|categoryid|Edm.Guid|**Display Name**: Category ID<br />**Description**: Shows the category.<br />|
|categorynumber|Edm.String|**Display Name**: Category Number<br />**Description**: Shows the category number for customer reference.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type a detailed description of the category<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|sequencenumber|Edm.Int32|**Display Name**: Display Order<br />**Description**: Enter a number to define the display position of the category in the hierarchy.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Type a title for the Category.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|lk_category_createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|lk_category_createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|lk_category_modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|lk_category_modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that the record owner belongs to.|
|_owningteam_value||Unique identifier of the team who owns the category.|
|_owninguser_value||Unique identifier of the user who owns this category.|
|_parentcategoryid_value|parentcategoryid<br />|Select an existing category article for the category.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|lk_category_createdby|[systemuser EntityType](systemuser.md)|lk_category_createdby|
|lk_category_createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_category_createdonbehalfby|
|lk_category_modifiedby|[systemuser EntityType](systemuser.md)|lk_category_modifiedby|
|lk_category_modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_category_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_categories|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_category|
|parentcategoryid|[category EntityType](category.md)|category_parent_category|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_category|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|category_parent_category|[category EntityType](category.md)|parentcategoryid|  
|Category_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_category_syncerror|  
|knowledgearticle_category|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_category|  

## Operations
The following operations can be used with the category entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/category.md](./remarks/category.md)]

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