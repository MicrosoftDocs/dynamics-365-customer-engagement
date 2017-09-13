---
title: "Microsoft Dynamics 365 Customer Engagement calendar EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: eaae22ed-6651-48a5-b5d9-b7be3d53b8da
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API calendar entitytype."
---
# calendar EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/calendar.md](./descriptions/calendar.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]calendars </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Calendar</td></tr>
<tr><td><b>Primary Key:</b></td><td>calendarid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The calendar entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|calendarid|Edm.Guid|**Display Name**: Calendar<br />**Description**: Unique identifier of the calendar.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the calendar was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Calendar used by the scheduling system to define when an appointment or activity is to occur.<br />|
|isshared|Edm.Boolean|**Display Name**: Is Shared<br />**Description**: Calendar is shared by other calendars, such as the organization calendar.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the calendar was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the calendar.<br />|
|primaryuserid|Edm.Guid|**Display Name**: Primary User<br />**Description**: Unique identifier of the primary user of this calendar.<br />|
|type|Edm.Int32|**Display Name**: Calendar type<br />**Description**: Calendar type, such as User work hour calendar, or Customer service hour calendar.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default</td></tr><tr><td>1</td><td>Customer Service</td></tr><tr><td>2</td><td>Holiday Schedule</td></tr><tr><td>-1</td><td>Inner Calendar type</td></tr><tbody></table>|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value|businessunitid<br />|Unique identifier of the business unit with which the calendar is associated.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the calendar.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the calendar.|
|_holidayschedulecalendarid_value|holidayschedulecalendarid<br />|Holiday Schedule CalendarId|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the calendar.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the calendar.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the calendar is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid|[businessunit EntityType](businessunit.md)|business_unit_calendars|
|createdby|[systemuser EntityType](systemuser.md)|lk_calendar_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_calendar_createdonbehalfby|
|holidayschedulecalendarid|[calendar EntityType](calendar.md)|calendar_customercalendar_holidaycalendar|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_calendar_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_calendar_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_calendars|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|BusinessUnit_Calendar|[businessunit EntityType](businessunit.md)|calendarid|  
|Calendar_Annotation|[annotation EntityType](annotation.md)|objectid_calendar|  
|Calendar_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_calendar|  
|calendar_bookableresources|[bookableresource EntityType](bookableresource.md)|calendarid|  
|Calendar_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_calendar|  
|calendar_calendar_rules|[calendarrule EntityType](calendarrule.md)|calendarid|  
|calendar_customercalendar_holidaycalendar|[calendar EntityType](calendar.md)|holidayschedulecalendarid|  
|calendar_equipment|[equipment EntityType](equipment.md)|calendarid|  
|calendar_organization|[organization EntityType](organization.md)|businessclosurecalendarid_calendar|  
|calendar_services|[service EntityType](service.md)|calendarid_calendar|  
|calendar_system_users|[systemuser EntityType](systemuser.md)|calendarid|  
|inner_calendar_calendar_rules|[calendarrule EntityType](calendarrule.md)|innercalendarid|  
|slabase_businesshoursid|[sla EntityType](sla.md)|businesshoursid|  

## Operations
The following operations can be used with the calendar entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[ExpandCalendar Function](../functions/expandcalendar.md)|Entity|[!INCLUDE[../functions/descriptions/expandcalendar.md](../functions/descriptions/expandcalendar.md)]|    

[!INCLUDE[./remarks/calendar.md](./remarks/calendar.md)]

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