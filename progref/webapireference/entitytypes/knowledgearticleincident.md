---
title: "Microsoft Dynamics 365 Customer Engagement knowledgearticleincident EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 96de4e8d-5cec-4b44-84c3-f5e9e214e04d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API knowledgearticleincident entitytype."
---
# knowledgearticleincident EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/knowledgearticleincident.md](./descriptions/knowledgearticleincident.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]knowledgearticleincidents </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>KnowledgeArticle Incident</td></tr>
<tr><td><b>Primary Key:</b></td><td>knowledgearticleincidentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>knowledgearticleidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The knowledgearticleincident entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|issenttocustomer|Edm.Boolean|**Display Name**: Sent To Customer<br />**Description**: This should be set to Yes when the user emails the article link to a customer. <br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|knowledgearticleincidentid|Edm.Guid|**Display Name**: KnowledgeArticle Incident<br />**Description**: Unique identifier of the Knowledge Article for the incident.<br />|
|knowledgeusage|Edm.Int32|**Display Name**: Knowledge Usage <br />**Description**: Knowledge Usage.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Reference</td></tr><tr><td>2</td><td>Solution</td></tr><tr><td>3</td><td>Source</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Knowledge Article Incident<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Knowledge Article Incident<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_incidentid_value|incidentid<br />|Choose the Incident id for the knowledge article.|
|_knowledgearticleid_value|knowledgearticleid<br />|Choose the Knowledge Article.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_knowledgearticleincident_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_knowledgearticleincident_createdonbehalfby|
|incidentid|[incident EntityType](incident.md)|knowledgearticle_incidents|
|knowledgearticleid|[knowledgearticle EntityType](knowledgearticle.md)|incident_knowledgearticles|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_knowledgearticleincident_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_knowledgearticleincident_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_knowledgearticleincident|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_knowledgearticleincident|
|owningteam|[team EntityType](team.md)|team_knowledgearticleincident|
|owninguser|[systemuser EntityType](systemuser.md)|user_knowledgearticleincident|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_knowledgearticleincident|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|knowledgearticleincident_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_knowledgearticleincident|  
|knowledgearticleincident_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_knowledgearticleincident|  
|KnowledgeArticleIncident_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_knowledgearticleincident_syncerror|  

## Solutions
The following solutions include the knowledgearticleincident entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/knowledgearticleincident.md](./remarks/knowledgearticleincident.md)]

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