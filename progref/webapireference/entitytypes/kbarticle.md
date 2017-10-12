---
title: "Microsoft Dynamics 365 Customer Engagement kbarticle EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c84bf378-717f-4d69-a19b-1c95aeaeb3c5
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API kbarticle entitytype."
---
# kbarticle EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/kbarticle.md](./descriptions/kbarticle.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]kbarticles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Article</td></tr>
<tr><td><b>Primary Key:</b></td><td>kbarticleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_averagerating|Edm.Double|**Display Name**: Average Rating<br />**Description**: The average rating of this article.<br />|
|adx_averagerating_int|Edm.Int32|**Display Name**: Average Rating (Whole Number)<br />**Description**: The average rating of this article, rounded to a whole number (positive integer).<br />|
|adx_downvotes|Edm.Int32|**Display Name**: Downvotes<br />**Description**: The number of negative vote ratings applied to this article.<br />|
|adx_ratingcount|Edm.Int32|**Display Name**: Rating Count<br />|
|adx_ratingsum|Edm.Int32|**Display Name**: Rating Sum<br />**Description**: The sum of the values of all ratings applied to this article.<br />|
|adx_upvotes|Edm.Int32|**Display Name**: Upvotes<br />**Description**: The number of positive vote ratings applied to this article.<br />|
|articlexml|Edm.String|**Display Name**: Article XML<br />**Description**: Shows the article content and formatting, stored as XML.<br />|
|comments|Edm.String|**Display Name**: Comments<br />**Description**: Comments regarding the knowledge base article.<br />|
|content|Edm.String|**Display Name**: Content<br />**Description**: Description of the content of the knowledge base article.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the knowledge base article was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information that describes the knowledge base article.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|kbarticleid|Edm.Guid|**Display Name**: Article<br />**Description**: Shows the ID of the article.<br />|
|keywords|Edm.String|**Display Name**: Key Words<br />**Description**: Keywords to be used for searches in knowledge base articles.<br />|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Select which language the article must be available in. This list is based on the list of language packs that are installed in your Microsoft Dynamics 365 environment.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the knowledge base article was last modified.<br />Read-only<br />|
|msa_publishtoweb|Edm.Boolean|**Display Name**: Publish to Web<br />**Description**: If set to Yes, the article will be visible and searchable on portals connected to this organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|number|Edm.String|**Display Name**: Number<br />**Description**: Knowledge base article number.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status <br />**Description**: Shows whether the knowledge base article is in draft, unapproved, or published status. Published articles are read-only and can't be edited unless they are unpublished.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Draft</td></tr><tr><td>2</td><td>Unapproved</td></tr><tr><td>3</td><td>Published</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the article's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Draft</td></tr><tr><td>2</td><td>Unapproved</td></tr><tr><td>3</td><td>Published</td></tr><tbody></table>|
|title|Edm.String|**Display Name**: Title<br />**Description**: Type a subject or descriptive name for the article to assist with article searches.<br />|
|versionnumber|Edm.Int64|**Display Name**: Title<br />**Description**: Title of the knowledge base article.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the knowledge base article.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the article.|
|_kbarticletemplateid_value|kbarticletemplateid<br />|Choose the template that you want to use as a base for creating the new article.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the knowledge base article.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the kbarticle.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the article.|
|_subjectid_value|subjectid<br />|Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_kbarticlebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_kbarticle_createdonbehalfby|
|kbarticletemplateid|[kbarticletemplate EntityType](kbarticletemplate.md)|kb_article_template_kb_articles|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_kbarticlebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_kbarticle_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_kb_articles|
|subjectid|[subject EntityType](subject.md)|subject_kb_articles|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_KbArticle|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_kbarticle_kbarticle|[kbarticle EntityType](kbarticle.md)|adx_kbarticle_kbarticle_referenced|  
|adx_kbarticle_kbarticle_referenced|[kbarticle EntityType](kbarticle.md)|adx_kbarticle_kbarticle|  
|KbArticle_Annotation|[annotation EntityType](annotation.md)|objectid_kbarticle|  
|KbArticle_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_kbarticle|  
|KbArticle_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_kbarticle|  
|kbarticle_comments|[kbarticlecomment EntityType](kbarticlecomment.md)|kbarticleid|  
|KbArticle_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_kbarticle|  
|KbArticle_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_kbarticle|  
|kbarticle_incidents|[incident EntityType](incident.md)|kbarticleid|  
|KbArticle_SharepointDocumentLocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_kbarticle|  
|KbArticle_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_kbarticle_syncerror|  

## Operations
The following operations can be used with the kbarticle entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveByTopIncidentProductKbArticle Function](../functions/retrievebytopincidentproductkbarticle.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievebytopincidentproductkbarticle.md](../functions/descriptions/retrievebytopincidentproductkbarticle.md)]|  
|[RetrieveByTopIncidentSubjectKbArticle Function](../functions/retrievebytopincidentsubjectkbarticle.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievebytopincidentsubjectkbarticle.md](../functions/descriptions/retrievebytopincidentsubjectkbarticle.md)]|  
|[SearchByBodyKbArticle Function](../functions/searchbybodykbarticle.md)|Collection|[!INCLUDE[../functions/descriptions/searchbybodykbarticle.md](../functions/descriptions/searchbybodykbarticle.md)]|  
|[SearchByKeywordsKbArticle Function](../functions/searchbykeywordskbarticle.md)|Collection|[!INCLUDE[../functions/descriptions/searchbykeywordskbarticle.md](../functions/descriptions/searchbykeywordskbarticle.md)]|  
|[SearchByTitleKbArticle Function](../functions/searchbytitlekbarticle.md)|Collection|[!INCLUDE[../functions/descriptions/searchbytitlekbarticle.md](../functions/descriptions/searchbytitlekbarticle.md)]|  

## Solutions
The following solutions include the kbarticle entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|    

[!INCLUDE[./remarks/kbarticle.md](./remarks/kbarticle.md)]

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