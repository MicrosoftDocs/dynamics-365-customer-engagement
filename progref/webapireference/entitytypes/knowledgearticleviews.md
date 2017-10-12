---
title: "Microsoft Dynamics 365 Customer Engagement knowledgearticleviews EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 95643677-4672-481f-b793-ecc68c83643a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API knowledgearticleviews entitytype."
---
# knowledgearticleviews EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/knowledgearticleviews.md](./descriptions/knowledgearticleviews.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]knowledgearticleviews </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Knowledge Article Views</td></tr>
<tr><td><b>Primary Key:</b></td><td>knowledgearticleviewsid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>knowledgearticleidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The knowledgearticleviews EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|knowledgearticleview|Edm.Int32|**Display Name**: Knowledge Article View<br />**Description**: Number of Knowledge Article Views visited per day<br />|
|knowledgearticleviewsid|Edm.Guid|**Display Name**: View<br />**Description**: Unique identifier of the Knowledge Article Views<br />|
|location|Edm.Int32|**Display Name**: Location<br />**Description**: Shows where the knowledge was used<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Internal</td></tr><tr><td>2</td><td>Web</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|owningbusinessunit|Edm.Guid|**Display Name**: Owning Business Unit<br />**Description**: Unique identifier of the business unit that owns the knowledge article views.<br />Read-only<br />|
|owninguser|Edm.Guid|**Display Name**: Owning User<br />**Description**: Unique identifier of the user who owns the knowledge article views.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Knowledge Article Views<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Knowledge Article Views<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|
|viewdate|Edm.DateTimeOffset|**Display Name**: Day<br />**Description**: Information about the Day<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_knowledgearticleid_value|knowledgearticleid<br />|Choose the Knowledge Article.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value||Unique identifier of the user or team who owns the knowledge article views.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_knowledgearticleviews_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_knowledgearticleviews_createdonbehalfby|
|knowledgearticleid|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_views|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_knowledgearticleviews_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_knowledgearticleviews_modifiedonbehalfby|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_knowledgearticleviews|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|KnowledgeArticleViews_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_knowledgearticleviews_syncerror|  

## Operations
The following operations can be used with the knowledgearticleviews entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IncrementKnowledgeArticleViewCount Function](../functions/incrementknowledgearticleviewcount.md)|Not Bound|[!INCLUDE[../functions/descriptions/incrementknowledgearticleviewcount.md](../functions/descriptions/incrementknowledgearticleviewcount.md)]|    

[!INCLUDE[./remarks/knowledgearticleviews.md](./remarks/knowledgearticleviews.md)]

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