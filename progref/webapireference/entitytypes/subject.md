---
title: "Microsoft Dynamics 365 Customer Engagement subject EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 08c2e1fb-1c6a-4515-b9c7-77a55de8d57d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API subject entitytype."
---
# subject EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/subject.md](./descriptions/subject.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]subjects </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Subject</td></tr>
<tr><td><b>Primary Key:</b></td><td>subjectid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The subject entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the subject was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the subject.<br />|
|featuremask|Edm.Int32|**Display Name**: Feature Mask<br />**Description**: Information that specifies when the subject will be displayed in lists of subjects.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the subject was last modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|subjectid|Edm.Guid|**Display Name**: Subject<br />**Description**: Unique identifier of the subject.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Title of the subject.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the subject.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the subject.|
|_createdbyexternalparty_value||Shows the external party who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the subject.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the subject.|
|_modifiedbyexternalparty_value||Shows the external party who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the subject.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization associated with the subject.|
|_parentsubject_value|parentsubject<br />|Unique identifier of the parent subject.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_subjectbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_subject_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_subjectbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_subject_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_subjects|
|parentsubject|[subject EntityType](subject.md)|subject_parent_subject|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_subject_webfile|[adx_webfile EntityType](adx_webfile.md)|adx_subjectid|  
|adx_subject_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_subjectid|  
|Subject_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_subject|  
|Subject_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_subject|  
|subject_incidents|[incident EntityType](incident.md)|subjectid|  
|subject_kb_articles|[kbarticle EntityType](kbarticle.md)|subjectid|  
|subject_knowledgearticles|[knowledgearticle EntityType](knowledgearticle.md)|subjectid|  
|subject_parent_subject|[subject EntityType](subject.md)|parentsubject|  
|subject_products|[product EntityType](product.md)|subjectid|  
|subject_sales_literature|[salesliterature EntityType](salesliterature.md)|subjectid|  
|Subject_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_subject_syncerror|  

## Operations
The following operations can be used with the subject entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveByTopIncidentSubjectKbArticle Function](../functions/retrievebytopincidentsubjectkbarticle.md)|Entity|[!INCLUDE[../functions/descriptions/retrievebytopincidentsubjectkbarticle.md](../functions/descriptions/retrievebytopincidentsubjectkbarticle.md)]|    

[!INCLUDE[./remarks/subject.md](./remarks/subject.md)]

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