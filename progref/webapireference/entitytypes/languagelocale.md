---
title: "Microsoft Dynamics 365 Customer Engagement languagelocale EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 27d8ca67-df4e-46c3-a4bf-bff78f898336
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API languagelocale entitytype."
---
# languagelocale EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/languagelocale.md](./descriptions/languagelocale.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]languagelocale </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Language</td></tr>
<tr><td><b>Primary Key:</b></td><td>languagelocaleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET,PATCH</td></tr>
</table>
  
The languagelocale EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|code|Edm.String|**Display Name**: Code<br />**Description**: Code<br />Read-only<br />|
|language|Edm.String|**Display Name**: Language<br />**Description**: Language<br />Read-only<br />|
|languagelocaleid|Edm.Guid|**Description**: LanguageLocaleId<br />|
|localeid|Edm.Int32|**Display Name**: Locale ID<br />**Description**: Locale ID<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name<br />Read-only<br />|
|region|Edm.String|**Display Name**: Region<br />**Description**: Region<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: State Code<br />**Description**: State Code<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Language Status Code<br />**Description**: Language Status Code<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the language locale.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|organizationid|[organization EntityType](organization.md)|languagelocale_organization|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|knowledgearticle_languagelocaleid|[knowledgearticle EntityType](knowledgearticle.md)|languagelocaleid|    

[!INCLUDE[./remarks/languagelocale.md](./remarks/languagelocale.md)]

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