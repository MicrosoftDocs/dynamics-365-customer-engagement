---
title: "Microsoft Dynamics 365 Customer Engagement timezonerule EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 39e610e8-cbae-4447-8dc6-9e027cec349c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API timezonerule entitytype."
---
# timezonerule EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/timezonerule.md](./descriptions/timezonerule.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]timezonerules </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Time Zone Rule</td></tr>
<tr><td><b>Primary Key:</b></td><td>timezoneruleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>timezoneruleversionnumber</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The timezonerule EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bias|Edm.Int32|**Display Name**: Bias<br />**Description**: Base time bias of the time zone rule.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the time zone rule was created.<br />Read-only<br />|
|daylightbias|Edm.Int32|**Display Name**: Daylight Bias<br />**Description**: Time bias in addition to the base bias for daylight savings time.<br />|
|daylightday|Edm.Int32|**Display Name**: Daylight Day<br />**Description**: Day of the month when daylight savings time starts.<br />|
|daylightdayofweek|Edm.Int32|**Display Name**: Daylight Day Of Week<br />**Description**: Day of the week when daylight savings time starts.<br />|
|daylighthour|Edm.Int32|**Display Name**: Daylight Hour<br />**Description**: Hour of the day when daylight savings time starts<br />|
|daylightminute|Edm.Int32|**Display Name**: Daylight Minute<br />**Description**: Minute of the hour when daylight savings time starts.<br />|
|daylightmonth|Edm.Int32|**Display Name**: Daylight Month<br />**Description**: Month when daylight savings time starts.<br />|
|daylightsecond|Edm.Int32|**Display Name**: Daylight Second<br />**Description**: Second of the minute when daylight savings time starts<br />|
|daylightyear|Edm.Int32|**Display Name**: Daylight Year<br />**Description**: Year when daylight savings times starts.<br />|
|effectivedatetime|Edm.DateTimeOffset|**Display Name**: Effective Date Time<br />**Description**: Time that this rule takes effect, in local time.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the time zone rule was modified.<br />Read-only<br />|
|standardbias|Edm.Int32|**Display Name**: Standard Bias<br />**Description**: Time bias in addition to the base bias for standard time.<br />|
|standardday|Edm.Int32|**Display Name**: Standard Day<br />**Description**: Day of the month when standard time starts.<br />|
|standarddayofweek|Edm.Int32|**Display Name**: Standard Day Of Week<br />**Description**: Day of the week when standard time starts.<br />|
|standardhour|Edm.Int32|**Display Name**: Standard Hour<br />**Description**: Hour of the day when standard time starts.<br />|
|standardminute|Edm.Int32|**Display Name**: Standard Minute<br />**Description**: Minute of the hour when standard time starts.<br />|
|standardmonth|Edm.Int32|**Display Name**: Standard Month<br />**Description**: Month when standard time starts.<br />|
|standardsecond|Edm.Int32|**Display Name**: Standard Second<br />**Description**: Second of the Minute when standard time starts.<br />|
|standardyear|Edm.Int32|**Display Name**: Standard Year<br />**Description**: Year when standard time starts.<br />|
|timezoneruleid|Edm.Guid|**Display Name**: Time Zone Rule<br />**Description**: Unique identifier of the time zone rule.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the time zone rule.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the timezonerule.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the time zone rule.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the timezonerule.|
|_organizationid_value||Unique identifier of the organization associated with the time zone rule.|
|_timezonedefinitionid_value|timezonedefinitionid<br />|Unique identifier of the time zone definition.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_timezonerule_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_timezonerule_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_timezonerule_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_timezonerule_modifiedonbehalfby|
|timezonedefinitionid|[timezonedefinition EntityType](timezonedefinition.md)|lk_timezonerule_timezonedefinitionid|  

[!INCLUDE[./remarks/timezonerule.md](./remarks/timezonerule.md)]

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