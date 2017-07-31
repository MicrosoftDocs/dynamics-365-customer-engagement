---
title: "Microsoft Dynamics 365 Customer Engagement postregarding EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f8cedfe0-64e7-44a5-b1ff-f1b5840c277b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API postregarding entitytype."
---
# postregarding EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/postregarding.md](./descriptions/postregarding.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]postregardings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Post Regarding</td></tr>
<tr><td><b>Primary Key:</b></td><td>postregardingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The postregarding entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|latestautopostmodifiedon|Edm.DateTimeOffset|**Display Name**: Latest Auto Post<br />**Description**: Date of Latest Auto Post on the Regarding entity<br />Read-only<br />|
|latestmanualpostmodifiedon|Edm.DateTimeOffset|**Display Name**: Latest Manual Post<br />**Description**: Date of Latest Manual Post on the Regarding entity<br />Read-only<br />|
|postregardingid|Edm.Guid|**Display Name**: PostRegardingId<br />**Description**: Shows the ID of the record that the post is referring to.<br />|
|regardingobjecttypecodeforsharing|Edm.String|**Display Name**: RegardingObjectTypeCodeForSharing<br />**Description**: Indicates the entity type of the regarding object for sharing.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_regardingobjectid_value|regardingobjectid_lead<br />regardingobjectid_incident<br />regardingobjectid_opportunity<br />regardingobjectid_competitor<br />regardingobjectid_account<br />regardingobjectid_systemuser<br />regardingobjectid_contact<br />regardingobjectid_team<br />regardingobjectid_knowledgearticle<br />regardingobjectid_queue<br />|Choose the record that the post relates to.|
|_regardingobjectownerid_value||Unique identifier of the user or team who owns the regarding object.|
|_regardingobjectowningbusinessunit_value|regardingobjectowningbusinessunit<br />|Select the business unit that owns the regarding object.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|regardingobjectid_account|[account EntityType](account.md)|account_PostRegardings|
|regardingobjectid_appointment|[appointment EntityType](appointment.md)|appointment_PostRegardings|
|regardingobjectid_competitor|[competitor EntityType](competitor.md)|competitor_PostRegardings|
|regardingobjectid_contact|[contact EntityType](contact.md)|contact_PostRegardings|
|regardingobjectid_incident|[incident EntityType](incident.md)|incident_PostRegardings|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_PostRegardings|
|regardingobjectid_lead|[lead EntityType](lead.md)|lead_PostRegardings|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|opportunity_PostRegardings|
|regardingobjectid_phonecall|[phonecall EntityType](phonecall.md)|phonecall_PostRegardings|
|regardingobjectid_queue|[queue EntityType](queue.md)|queue_PostRegardings|
|regardingobjectid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|recurringappointmentmaster_PostRegardings|
|regardingobjectid_systemuser|[systemuser EntityType](systemuser.md)|systemuser_PostRegardings|
|regardingobjectid_task|[task EntityType](task.md)|task_PostRegardings|
|regardingobjectid_team|[team EntityType](team.md)|team_PostRegardings|
|regardingobjectowningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_PostRegarding|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|post_PostRegardings|[post EntityType](post.md)|postregardingid|  

## Solutions
The following solutions include the postregarding entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|    

[!INCLUDE[./remarks/postregarding.md](./remarks/postregarding.md)]

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