---
title: "Microsoft Dynamics 365 Customer Engagement teamtemplate EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f2acf955-3ed2-4cfb-aecf-8c7226021dbb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API teamtemplate entitytype."
---
# teamtemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/teamtemplate.md](./descriptions/teamtemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]teamtemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Team template</td></tr>
<tr><td><b>Primary Key:</b></td><td>teamtemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>teamtemplatename</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The teamtemplate EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the team template was created.<br />Read-only<br />|
|defaultaccessrightsmask|Edm.Int32|**Display Name**: Access Rights<br />**Description**: Default access rights mask for the access teams associated with entity instances.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information that describes the team.<br />|
|issystem|Edm.Boolean|**Display Name**: Is System<br />**Description**: Information about whether this team template is user-defined or system-defined.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the team template was last modified.<br />Read-only<br />|
|objecttypecode|Edm.Int32|**Display Name**: Entity<br />**Description**: Object type code of entity which is enabled for access teams<br />|
|teamtemplateid|Edm.Guid|**Display Name**: Primary key for team template<br />**Description**: Unique identifier of the team template.<br />|
|teamtemplatename|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the team template.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the team template.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the team template.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the team template.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the team template.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_teamtemplate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_teamtemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_teamtemplate_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_teamtemplate_modifiedonbehalfby|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|TeamTemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_teamtemplate_syncerror|  
|teamtemplate_Teams|[team EntityType](team.md)|associatedteamtemplateid|  

## Operations
The following operations can be used with the teamtemplate entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddUserToRecordTeam Action](../actions/addusertorecordteam.md)|Not Bound|[!INCLUDE[../actions/descriptions/addusertorecordteam.md](../actions/descriptions/addusertorecordteam.md)]|  
|[RemoveUserFromRecordTeam Action](../actions/removeuserfromrecordteam.md)|Not Bound|[!INCLUDE[../actions/descriptions/removeuserfromrecordteam.md](../actions/descriptions/removeuserfromrecordteam.md)]|    

[!INCLUDE[./remarks/teamtemplate.md](./remarks/teamtemplate.md)]

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