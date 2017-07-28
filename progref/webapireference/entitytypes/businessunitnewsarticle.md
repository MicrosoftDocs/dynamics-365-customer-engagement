---
title: "Microsoft Dynamics 365 Customer Engagement businessunitnewsarticle EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2c4ca93b-a837-44e9-9101-da0bec6b4a27
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API businessunitnewsarticle entitytype."
---
# businessunitnewsarticle EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/businessunitnewsarticle.md](./descriptions/businessunitnewsarticle.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]businessunitnewsarticles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Announcement</td></tr>
<tr><td><b>Primary Key:</b></td><td>businessunitnewsarticleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>articletitle</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The businessunitnewsarticle EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activeon|Edm.DateTimeOffset|**Display Name**: Active On<br />**Description**: Date and time for the announcement to become active.<br />|
|activeuntil|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />**Description**: Date and time of the last day the announcement is active.<br />|
|articletitle|Edm.String|**Display Name**: Title<br />**Description**: Title of the announcement.<br />|
|articletypecode|Edm.Int32|**Display Name**: Visible To<br />**Description**: Type of announcement.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>All Users</td></tr><tr><td>2</td><td>Sales Users</td></tr><tr><td>3</td><td>Service Users</td></tr><tbody></table>|
|articleurl|Edm.String|**Display Name**: More Information URL<br />**Description**: URL for the Website on which the announcement is located.<br />|
|businessunitnewsarticleid|Edm.Guid|**Display Name**: Announcement<br />**Description**: Unique identifier of the announcement.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the announcement was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the announcement was last modified.<br />Read-only<br />|
|newsarticle|Edm.String|**Display Name**: Description<br />**Description**: Text for the announcement.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|showonhomepage|Edm.Boolean|**Display Name**: Show in Workplace<br />**Description**: Information about whether to show the announcement on the Website home page.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the announcement.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the businessunitnewsarticle.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the announcement.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the businessunitnewsarticle.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the announcement.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_businessunitnewsarticlebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_businessunitnewsarticle_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_businessunitnewsarticlebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_businessunitnewsarticle_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_business_unit_news_articles|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|BusinessUnitNewsArticle_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_businessunitnewsarticle|  
|BusinessUnitNewsArticle_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_businessunitnewsarticle|    

[!INCLUDE[./remarks/businessunitnewsarticle.md](./remarks/businessunitnewsarticle.md)]

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