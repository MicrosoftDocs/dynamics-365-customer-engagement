---
title: "Microsoft Dynamics 365 Customer Engagement calendarrule EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 35884440-4397-47e6-a8f7-d85746b7209b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API calendarrule entitytype."
---
# calendarrule EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/calendarrule.md](./descriptions/calendarrule.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]calendarrules </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Calendar Rule</td></tr>
<tr><td><b>Primary Key:</b></td><td>calendarruleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The calendarrule EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|businessunitid|Edm.Guid|**Display Name**: Business Unit<br />**Description**: Unique identifier of the business unit with which the calendar rule is associated.<br />Read-only<br />|
|calendarruleid|Edm.Guid|**Display Name**: Calendar Rule<br />**Description**: Unique identifier of the calendar rule.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the calendar rule was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.<br />|
|duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Duration of the calendar rule in minutes.<br />|
|effectiveintervalend|Edm.DateTimeOffset|**Display Name**: Effective Interval End<br />**Description**: Effective interval end of the calendar rule.<br />|
|effectiveintervalstart|Edm.DateTimeOffset|**Display Name**: Effective Interval Start<br />**Description**: Effective interval start of the calendar rule.<br />|
|effort|Edm.Double|**Display Name**: Effort<br />**Description**: Effort available for a resource during the time described by the calendar rule.<br />|
|endtime|Edm.DateTimeOffset|**Display Name**: End<br />**Description**: For internal use only.<br />|
|extentcode|Edm.Int32|**Display Name**: Extent Code<br />**Description**: Extent of the calendar rule.<br />|
|groupdesignator|Edm.String|**Display Name**: Group Designator<br />**Description**: Unique identifier of the group.<br />|
|ismodified|Edm.Boolean|**Display Name**: Is Modified<br />**Description**: For internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isselected|Edm.Boolean|**Display Name**: Is Selected<br />**Description**: Flag used in vary-by-day calendar rules.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|issimple|Edm.Boolean|**Display Name**: Is Simple<br />**Description**: Flag used in vary-by-day calendar rules.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isvaried|Edm.Boolean|**Display Name**: Is Varied<br />**Description**: Flag used in leaf nonrecurring rules.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the calendar rule was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the calendar rule.<br />|
|offset|Edm.Int32|**Display Name**: Offset<br />**Description**: Start offset for leaf nonrecurring rules.<br />|
|organizationid|Edm.Guid|**Display Name**: Organization <br />**Description**: Unique identifier of the organization with which the calendar rule is associated.<br />Read-only<br />|
|pattern|Edm.String|**Display Name**: Recurrence Pattern<br />**Description**: Pattern of the rule recurrence.<br />|
|rank|Edm.Int32|**Display Name**: Rank<br />**Description**: Rank of the calendar rule.<br />|
|starttime|Edm.DateTimeOffset|**Display Name**: Start<br />**Description**: Start time for the rule.<br />|
|subcode|Edm.Int32|**Display Name**: Sub Code<br />**Description**: Sub-type of calendar rule.<br />|
|timecode|Edm.Int32|**Display Name**: Type<br />**Description**: Type of calendar rule such as working hours, break, holiday, or time off.<br />|
|timezonecode|Edm.Int32|**Display Name**: Time Zone<br />**Description**: Local time zone for the calendar rule.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_calendarid_value|calendarid<br />|Unique identifier of the calendar with which the calendar rule is associated.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the calendar rule.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the calendarrule.|
|_innercalendarid_value|innercalendarid<br />|Unique identifier of the inner calendar for non-leaf calendar rules.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the calendar rule.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the calendarrule.|
|_serviceid_value|serviceid<br />|Unique identifier of the service with which the calendar rule is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|calendarid|[calendar EntityType](calendar.md)|calendar_calendar_rules|
|createdby|[systemuser EntityType](systemuser.md)|lk_calendarrule_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_calendarrule_createdonbehalfby|
|innercalendarid|[calendar EntityType](calendar.md)|inner_calendar_calendar_rules|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_calendarrule_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_calendarrule_modifiedonbehalfby|
|serviceid|[service EntityType](service.md)|service_calendar_rules|

## Solutions
The following solutions include the calendarrule entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/calendarrule.md](./remarks/calendarrule.md)]

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