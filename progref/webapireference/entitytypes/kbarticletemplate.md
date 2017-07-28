---
title: "Microsoft Dynamics 365 Customer Engagement kbarticletemplate EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0be249f4-6672-4b45-9101-a585df5f8a6f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API kbarticletemplate entitytype."
---
# kbarticletemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/kbarticletemplate.md](./descriptions/kbarticletemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]kbarticletemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Article Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>kbarticletemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The kbarticletemplate EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the knowledge base article template was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the knowledge base article template.<br />|
|formatxml|Edm.String|**Display Name**: Format XML<br />**Description**: XML format of the knowledge base article template.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|isactive|Edm.Boolean|**Display Name**: Status<br />**Description**: Information about whether the knowledge base article is active.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>0</td><td>Inactive</td></tr><tbody></table>|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|kbarticletemplateid|Edm.Guid|**Display Name**: Article Template<br />**Description**: Unique identifier of the knowledge base article template.<br />|
|kbarticletemplateidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Language of the Article Template<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the knowledge base article template was last modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|structurexml|Edm.String|**Display Name**: Structure XML<br />**Description**: XML structure of the knowledge base article.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Title of the knowledge base article template.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the knowledge base article template.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the kbarticletemplate.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the knowledge base article template.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the kbarticletemplate.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the template.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_kbarticletemplatebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_kbarticletemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_kbarticletemplatebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_kbarticletemplate_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_kb_article_templates|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|kb_article_template_kb_articles|[kbarticle EntityType](kbarticle.md)|kbarticletemplateid|  
|KbArticleTemplate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_kbarticletemplate|  
|KbArticleTemplate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_kbarticletemplate|  
|KbArticleTemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_kbarticletemplate_syncerror|    

[!INCLUDE[./remarks/kbarticletemplate.md](./remarks/kbarticletemplate.md)]

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