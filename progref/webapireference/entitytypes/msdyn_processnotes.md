---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_processnotes EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 08e349cf-6ce6-4d79-a712-76a57ab6c12e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_processnotes entitytype."
---
# msdyn_processnotes EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_processnotes.md](./descriptions/msdyn_processnotes.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_processnoteses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Process Notes</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_processnotesid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_processnotes entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_details|Edm.String|**Display Name**: Details<br />**Description**: Process message details<br />|
|msdyn_entity|Edm.String|**Display Name**: Entity<br />**Description**: Process note entity identifier.<br />|
|msdyn_entityname|Edm.String|**Display Name**: Entity Name<br />**Description**: Process note entity name.<br />|
|msdyn_form|Edm.String|**Display Name**: Form<br />**Description**: Form identifier.<br />|
|msdyn_message|Edm.String|**Display Name**: Message<br />**Description**: Process message.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_processnotesid|Edm.Guid|**Display Name**: Process Notes<br />**Description**: Unique identifier for entity instances<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Process Notes<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Process Notes<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_processnotes_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_processnotes_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_processnotes_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_processnotes_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_processnotes|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_processnotes_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_processnotes|  
|msdyn_processnotes_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_processnotes_adx_alertsubscription|  
|msdyn_processnotes_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_processnotes_adx_inviteredemption|  
|msdyn_processnotes_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_processnotes_adx_portalcomment|  
|msdyn_processnotes_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_processnotes|  
|msdyn_processnotes_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_processnotes_appointment|  
|msdyn_processnotes_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_processnotes|  
|msdyn_processnotes_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_processnotes|  
|msdyn_processnotes_connections1|[connection EntityType](connection.md)|record1id_msdyn_processnotes|  
|msdyn_processnotes_connections2|[connection EntityType](connection.md)|record2id_msdyn_processnotes|  
|msdyn_processnotes_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_processnotes|  
|msdyn_processnotes_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_processnotes|  
|msdyn_processnotes_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_processnotes_email|  
|msdyn_processnotes_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_processnotes_fax|  
|msdyn_processnotes_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_processnotes_letter|  
|msdyn_processnotes_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_processnotes_msdyn_approval|  
|msdyn_processnotes_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_processnotes_msdyn_bookingalert|  
|msdyn_processnotes_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_processnotes_msdyn_surveyinvite|  
|msdyn_processnotes_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_processnotes_phonecall|  
|msdyn_processnotes_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_processnotes_recurringappointmentmaster|  
|msdyn_processnotes_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_processnotes_serviceappointment|  
|msdyn_processnotes_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_processnotes_socialactivity|  
|msdyn_processnotes_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_processnotes|  
|msdyn_processnotes_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_processnotes_task|  

## Operations
The following operations can be used with the msdyn_processnotes entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_processnotes entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_processnotes.md](./remarks/msdyn_processnotes.md)]

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