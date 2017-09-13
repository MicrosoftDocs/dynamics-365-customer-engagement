---
title: "Microsoft Dynamics 365 Customer Engagement timezonelocalizedname EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 096b8217-b92d-415a-a86e-8d5348c27122
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API timezonelocalizedname entitytype."
---
# timezonelocalizedname EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/timezonelocalizedname.md](./descriptions/timezonelocalizedname.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]timezonelocalizednames </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Time Zone Localized Name</td></tr>
<tr><td><b>Primary Key:</b></td><td>timezonelocalizednameid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>userinterfacename</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The timezonelocalizedname EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|cultureid|Edm.Int32|**Display Name**: Culture<br />**Description**: Unique identifier of the culture that the UI names are encoded in.<br />|
|daylightname|Edm.String|**Display Name**: Daylight Name<br />**Description**: Name of the time zone for the daylight time.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|standardname|Edm.String|**Display Name**: Standard Name<br />**Description**: Name of the time zone for the standard time.<br />|
|timezonelocalizednameid|Edm.Guid|**Display Name**: Time Zone Localized Name<br />**Description**: Unique identifier of entity instances.<br />|
|userinterfacename|Edm.String|**Display Name**: User Interface Name<br />**Description**: Unique display name for the time zone in the Microsoft Windows registry.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the timezonelocalizedname.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the time zone localized name.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the timezonelocalizedname.|
|_organizationid_value||Unique identifier of the organization associated with the time zone localized name.|
|_timezonedefinitionid_value|timezonedefinitionid<br />|Unique identifier of time zone definition entity instances.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_timezonelocalizedname_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_timezonelocalizedname_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_timezonelocalizedname_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_timezonelocalizedname_modifiedonbehalfby|
|timezonedefinitionid|[timezonedefinition EntityType](timezonedefinition.md)|lk_timezonelocalizedname_timezonedefinitionid|  

[!INCLUDE[./remarks/timezonelocalizedname.md](./remarks/timezonelocalizedname.md)]

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