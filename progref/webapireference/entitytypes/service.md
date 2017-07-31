---
title: "Microsoft Dynamics 365 Customer Engagement service EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4c60a0e6-bbac-4f12-a4cf-e2f9da658a99
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API service entitytype."
---
# service EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/service.md](./descriptions/service.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]services </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Service</td></tr>
<tr><td><b>Primary Key:</b></td><td>serviceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The service entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|anchoroffset|Edm.Int32|**Display Name**: Anchor Offset<br />**Description**: Used in conjunction with granularity to describes when services can be performed in relation to midnight on a given day.<br />|
|calendarid|Edm.Guid|**Display Name**: Calendar<br />**Description**: Unique identifier of the calendar.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the service was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of activity that represents work done to satisfy a customer's need.<br />|
|duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Duration of the service.<br />|
|granularity|Edm.String|**Display Name**: Granularity<br />**Description**: Describes how often the service is performed.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|initialstatuscode|Edm.Int32|**Display Name**: Initial Status Reason<br />**Description**: Initial status reason for the service activity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Requested</td></tr><tr><td>2</td><td>Tentative</td></tr><tr><td>3</td><td>Pending</td></tr><tr><td>4</td><td>Reserved</td></tr><tr><td>6</td><td>In Progress</td></tr><tr><td>7</td><td>Arrived</td></tr><tr><td>8</td><td>Completed</td></tr><tr><td>9</td><td>Canceled</td></tr><tr><td>10</td><td>No Show</td></tr><tbody></table>|
|isschedulable|Edm.Boolean|**Display Name**: Status<br />**Description**: Information about whether the service can be scheduled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>0</td><td>Inactive</td></tr><tbody></table>|
|isvisible|Edm.Boolean|**Display Name**: Is Visible<br />**Description**: Information about whether the service is visible to users.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the service was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the service.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|serviceid|Edm.Guid|**Display Name**: Service<br />**Description**: Unique identifier of the associated service.<br />|
|showresources|Edm.Boolean|**Display Name**: Show Resources<br />**Description**: For internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the service.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the service.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the service.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the service.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_resourcespecid_value|resourcespecid<br />|Unique identifier of the resource specification with which the service is associated.|
|_strategyid_value|strategyid<br />|Value that is taken from PluginTypeId in the Plugin Type record for the scheduling strategy. This is the ID of the scheduling strategy plug-in associated with the service.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|calendarid_calendar|[calendar EntityType](calendar.md)|calendar_services|
|createdby|[systemuser EntityType](systemuser.md)|lk_service_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_service_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_service_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_service_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_services|
|resourcespecid|[resourcespec EntityType](resourcespec.md)|resource_spec_services|
|strategyid|[plugintype EntityType](plugintype.md)|plugin_type_service|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_alertsubscription_service_serviceid|[adx_alertsubscription EntityType](adx_alertsubscription.md)|serviceid_adx_alertsubscription|  
|adx_inviteredemption_service_serviceid|[adx_inviteredemption EntityType](adx_inviteredemption.md)|serviceid_adx_inviteredemption|  
|adx_portalcomment_service_serviceid|[adx_portalcomment EntityType](adx_portalcomment.md)|serviceid_adx_portalcomment|  
|msdyn_approval_service_serviceid|[msdyn_approval EntityType](msdyn_approval.md)|serviceid_msdyn_approval|  
|msdyn_bookingalert_service_serviceid|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|serviceid_msdyn_bookingalert|  
|msdyn_surveyinvite_service_serviceid|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|serviceid_msdyn_surveyinvite|  
|service_accounts|[account EntityType](account.md)|preferredserviceid|  
|service_activity_pointers|[activitypointer EntityType](activitypointer.md)|serviceid|  
|Service_Annotation|[annotation EntityType](annotation.md)|objectid_service|  
|service_appointments|[appointment EntityType](appointment.md)|serviceid_appointment|  
|Service_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_service|  
|Service_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_service|  
|service_calendar_rules|[calendarrule EntityType](calendarrule.md)|serviceid|  
|service_contacts|[contact EntityType](contact.md)|preferredserviceid|  
|Service_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_service|  
|Service_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_service|  
|service_emails|[email EntityType](email.md)|serviceid_email|  
|service_faxes|[fax EntityType](fax.md)|serviceid_fax|  
|service_incidentresolutions|[incidentresolution EntityType](incidentresolution.md)|serviceid_incidentresolution|  
|service_letters|[letter EntityType](letter.md)|serviceid_letter|  
|service_opportunityclose|[opportunityclose EntityType](opportunityclose.md)|serviceid_opportunityclose|  
|service_orderclose|[orderclose EntityType](orderclose.md)|serviceid_orderclose|  
|service_phonecalls|[phonecall EntityType](phonecall.md)|serviceid_phonecall|  
|service_quoteclose|[quoteclose EntityType](quoteclose.md)|serviceid_quoteclose|  
|service_recurringappointmentmasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|serviceid_recurringappointmentmaster|  
|service_service_appointments|[serviceappointment EntityType](serviceappointment.md)|serviceid_serviceappointment|  
|service_socialactivities|[socialactivity EntityType](socialactivity.md)|serviceid_socialactivity|  
|Service_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_service_syncerror|  
|service_tasks|[task EntityType](task.md)|serviceid_task|  

## Operations
The following operations can be used with the service entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveByResourcesService Function](../functions/retrievebyresourcesservice.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievebyresourcesservice.md](../functions/descriptions/retrievebyresourcesservice.md)]|  

## Solutions
The following solutions include the service entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/service.md](./remarks/service.md)]

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