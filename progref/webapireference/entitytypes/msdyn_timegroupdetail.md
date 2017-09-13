---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_timegroupdetail EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 94cbfbca-9a03-49d1-bbb9-cbcc8d3f86be
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_timegroupdetail entitytype."
---
# msdyn_timegroupdetail EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_timegroupdetail.md](./descriptions/msdyn_timegroupdetail.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_timegroupdetails </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Time Group Detail</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_timegroupdetailid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_timegroupdetail entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|msdyn_endtime|Edm.DateTimeOffset|**Display Name**: End Time<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the "Time Group Detail" entity.<br />|
|msdyn_starttime|Edm.DateTimeOffset|**Display Name**: Start Time<br />|
|msdyn_timegroupdetailid|Edm.Guid|**Display Name**: Time Group Detail<br />**Description**: Shows the entity instances.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Shows the ID of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Time Group Detail<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Time Group Detail<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: Shows a comma-separated list of string values representing the unique identifiers of stages in a business process flow instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_timegroupid_value|msdyn_timegroupid<br />|Unique identifier for Time Group associated with Time Group Detail.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Shows the ID of the stage where the entity is located.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_timegroupdetail_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_timegroupdetail_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_timegroupdetail_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_timegroupdetail_modifiedonbehalfby|
|msdyn_timegroupid|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_msdyn_timegroup_msdyn_timegroupdetail|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_timegroupdetail|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_timegroupdetail|
|owningteam|[team EntityType](team.md)|team_msdyn_timegroupdetail|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_timegroupdetail|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_timegroupdetail|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_timegroupdetailselected|  
|msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_timegroupdetailselected|  
|msdyn_timegroupdetail_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_timegroupdetail_adx_alertsubscription|  
|msdyn_timegroupdetail_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_timegroupdetail_adx_inviteredemption|  
|msdyn_timegroupdetail_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_timegroupdetail_adx_portalcomment|  
|msdyn_timegroupdetail_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_timegroupdetail_appointment|  
|msdyn_timegroupdetail_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_connections1|[connection EntityType](connection.md)|record1id_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_connections2|[connection EntityType](connection.md)|record2id_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_timegroupdetail_email|  
|msdyn_timegroupdetail_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_timegroupdetail_fax|  
|msdyn_timegroupdetail_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_timegroupdetail_letter|  
|msdyn_timegroupdetail_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_timegroupdetail_msdyn_approval|  
|msdyn_timegroupdetail_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_timegroupdetail_msdyn_bookingalert|  
|msdyn_timegroupdetail_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_timegroupdetail_msdyn_surveyinvite|  
|msdyn_timegroupdetail_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_timegroupdetail_phonecall|  
|msdyn_timegroupdetail_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_timegroupdetail_recurringappointmentmaster|  
|msdyn_timegroupdetail_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_timegroupdetail_serviceappointment|  
|msdyn_timegroupdetail_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_timegroupdetail_socialactivity|  
|msdyn_timegroupdetail_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_timegroupdetail|  
|msdyn_timegroupdetail_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_timegroupdetail_task|  

## Operations
The following operations can be used with the msdyn_timegroupdetail entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_timegroupdetail entity type.


|Name|Description |  
|----|------------|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|    

[!INCLUDE[./remarks/msdyn_timegroupdetail.md](./remarks/msdyn_timegroupdetail.md)]

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