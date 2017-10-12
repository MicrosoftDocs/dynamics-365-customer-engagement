---
title: "Microsoft Dynamics 365 Customer Engagement postfollow EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 91b2760f-6981-4b78-b5f6-f326eca2b4b0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API postfollow entitytype."
---
# postfollow EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/postfollow.md](./descriptions/postfollow.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]postfollows </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Follow</td></tr>
<tr><td><b>Primary Key:</b></td><td>postfollowid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>regardingobjectidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,DELETE</td></tr>
</table>
  
The postfollow entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|postfollowid|Edm.Guid|**Display Name**: PostFollow<br />**Description**: Shows the ID of the post follow.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of post follow.<br />Read-only<br />|
|yammerpoststate|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the follow.|
|_owninguser_value|owninguser<br />|Unique identifier for the user who owns the record.|
|_regardingobjectid_value|regardingobjectid_lead<br />regardingobjectid_incident<br />regardingobjectid_opportunity<br />regardingobjectid_competitor<br />regardingobjectid_account<br />regardingobjectid_contact<br />regardingobjectid_systemuser<br />regardingobjectid_queue<br />regardingobjectid_knowledgearticle<br />|Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_PostFollow_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_postfollow_createdonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_postfollows|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_postfollows|
|owningteam|[team EntityType](team.md)|OwningTeam_postfollows|
|owninguser|[systemuser EntityType](systemuser.md)|user_owner_postfollows|
|regardingobjectid_account|[account EntityType](account.md)|account_PostFollows|
|regardingobjectid_appointment|[appointment EntityType](appointment.md)|appointment_PostFollows|
|regardingobjectid_competitor|[competitor EntityType](competitor.md)|competitor_PostFollows|
|regardingobjectid_contact|[contact EntityType](contact.md)|contact_PostFollows|
|regardingobjectid_incident|[incident EntityType](incident.md)|incident_PostFollows|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_PostFollows|
|regardingobjectid_lead|[lead EntityType](lead.md)|lead_PostFollows|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|opportunity_PostFollows|
|regardingobjectid_phonecall|[phonecall EntityType](phonecall.md)|phonecall_PostFollows|
|regardingobjectid_queue|[queue EntityType](queue.md)|queue_PostFollows|
|regardingobjectid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|recurringappointmentmaster_PostFollows|
|regardingobjectid_systemuser|[systemuser EntityType](systemuser.md)|systemuser_PostFollows|
|regardingobjectid_task|[task EntityType](task.md)|task_PostFollows|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|PostFollow_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_postfollow|  
|PostFollow_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_postfollow_syncerror|  

## Solutions
The following solutions include the postfollow entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|    

[!INCLUDE[./remarks/postfollow.md](./remarks/postfollow.md)]

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