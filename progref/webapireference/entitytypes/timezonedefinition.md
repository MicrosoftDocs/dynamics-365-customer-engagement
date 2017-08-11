---
title: "Microsoft Dynamics 365 Customer Engagement timezonedefinition EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 586c3fdc-d8df-4e0c-a36f-05ecddabe83f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API timezonedefinition entitytype."
---
# timezonedefinition EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/timezonedefinition.md](./descriptions/timezonedefinition.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]timezonedefinitions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Time Zone Definition</td></tr>
<tr><td><b>Primary Key:</b></td><td>timezonedefinitionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>userinterfacename</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The timezonedefinition entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bias|Edm.Int32|**Display Name**: Bias<br />**Description**: Base time bias of the time zone.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the time zone record was created.<br />Read-only<br />|
|daylightname|Edm.String|**Display Name**: Daylight Name<br />**Description**: Time zone name for the daylight time.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the time zone record was modified.<br />Read-only<br />|
|retiredorder|Edm.Int32|**Display Name**: Retired Order<br />**Description**: Order an entry for a time zone definition is retired. 0 for the latest entry.<br />|
|standardname|Edm.String|**Display Name**: Standard Name<br />**Description**: Time zone name for the standard time.<br />|
|timezonecode|Edm.Int32|**Display Name**: Time Zone Code<br />**Description**: Time zone identification code.<br />|
|timezonedefinitionid|Edm.Guid|**Display Name**: Time Zone Definition<br />**Description**: Unique identifier of the time zone record.<br />|
|userinterfacename|Edm.String|**Display Name**: User Interface Name<br />**Description**: Display name for the time zone in the Microsoft Windows registry.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the time zone record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the timezonedefinition.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the time zone record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the timezonedefinition.|
|_organizationid_value||Unique identifier of the organization associated with the time zone definition.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_timezonedefinition_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_timezonedefinition_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_timezonedefinition_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_timezonedefinition_modifiedonbehalfby|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|lk_timezonelocalizedname_timezonedefinitionid|[timezonelocalizedname EntityType](timezonelocalizedname.md)|timezonedefinitionid|  
|lk_timezonerule_timezonedefinitionid|[timezonerule EntityType](timezonerule.md)|timezonedefinitionid|  

## Operations
The following operations can be used with the timezonedefinition entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GetAllTimeZonesWithDisplayName Function](../functions/getalltimezoneswithdisplayname.md)|Collection|[!INCLUDE[../functions/descriptions/getalltimezoneswithdisplayname.md](../functions/descriptions/getalltimezoneswithdisplayname.md)]|  
|[GetTimeZoneCodeByLocalizedName Function](../functions/gettimezonecodebylocalizedname.md)|Not Bound|[!INCLUDE[../functions/descriptions/gettimezonecodebylocalizedname.md](../functions/descriptions/gettimezonecodebylocalizedname.md)]|    

[!INCLUDE[./remarks/timezonedefinition.md](./remarks/timezonedefinition.md)]

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