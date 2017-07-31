---
title: "Microsoft Dynamics 365 Customer Engagement leadcompetitors EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 590c59f7-83de-42a5-915f-875f11542681
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API leadcompetitors entitytype."
---
# leadcompetitors EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/leadcompetitors.md](./descriptions/leadcompetitors.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]leadcompetitorscollection </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>LeadCompetitors</td></tr>
<tr><td><b>Primary Key:</b></td><td>leadcompetitorid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET (RetrieveMultiple Only)</td></tr>
</table>
  
The leadcompetitors entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|competitorid|Edm.Guid|Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|leadcompetitorid|Edm.Guid|**Description**: Unique identifier of the lead competitor.<br />|
|leadid|Edm.Guid|Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: name<br />**Description**: name<br />|
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
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_leadcompetitors_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_leadcompetitors_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_leadcompetitors_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_leadcompetitors_modifiedonbehalfby|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|leadcompetitors_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_leadcompetitors|  
|leadcompetitors_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_leadcompetitors|  

## Solutions
The following solutions include the leadcompetitors entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|    

[!INCLUDE[./remarks/leadcompetitors.md](./remarks/leadcompetitors.md)]

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