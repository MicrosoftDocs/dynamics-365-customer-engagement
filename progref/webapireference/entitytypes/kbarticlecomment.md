---
title: "Microsoft Dynamics 365 Customer Engagement kbarticlecomment EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 529378c9-49b0-4ff3-b353-04cf07c4e976
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API kbarticlecomment entitytype."
---
# kbarticlecomment EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/kbarticlecomment.md](./descriptions/kbarticlecomment.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]kbarticlecomments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Article Comment</td></tr>
<tr><td><b>Primary Key:</b></td><td>kbarticlecommentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The kbarticlecomment EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|commenttext|Edm.String|**Display Name**: Comment Text<br />**Description**: Comment text for the knowledge base article.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the knowledge base article comment was created.<br />Read-only<br />|
|kbarticlecommentid|Edm.Guid|**Display Name**: Article Comment<br />**Description**: Unique identifier of the knowledge base article comment.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the knowledge base article comment was last modified.<br />Read-only<br />|
|organizationid|Edm.Guid|**Display Name**: Organization <br />**Description**: Unique identifier of the organization with which the article comment is associated.<br />Read-only<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Title of the knowledge base article comment.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the knowledge base article comment.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the kbarticlecomment.|
|_kbarticleid_value|kbarticleid<br />|Unique identifier of the knowledge base article to which the comment applies.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the knowledge base article comment.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the kbarticlecomment.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_kbarticlecommentbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_kbarticlecomment_createdonbehalfby|
|kbarticleid|[kbarticle EntityType](kbarticle.md)|kbarticle_comments|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_kbarticlecommentbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_kbarticlecomment_modifiedonbehalfby|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|KbArticleComment_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_kbarticlecomment|  
|KbArticleComment_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_kbarticlecomment|    

[!INCLUDE[./remarks/kbarticlecomment.md](./remarks/kbarticlecomment.md)]

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