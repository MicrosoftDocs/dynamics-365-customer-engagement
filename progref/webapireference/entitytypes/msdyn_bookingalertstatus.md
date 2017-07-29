---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_bookingalertstatus EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 99899afc-ac12-433a-bca1-ba37b7dcad4e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_bookingalertstatus entitytype."
---
# msdyn_bookingalertstatus EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_bookingalertstatus.md](./descriptions/msdyn_bookingalertstatus.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_bookingalertstatuses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Booking Alert Status</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_bookingalertstatusid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_bookingalertstatus entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|msdyn_bookingalertstatusid|Edm.Guid|**Display Name**: Booking Alert Status<br />**Description**: Shows the entity instances.<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_nexttimetoshow|Edm.DateTimeOffset|**Display Name**: Next Time To Show<br />|
|msdyn_status|Edm.Int32|**Display Name**: Alert Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970001</td><td>Normal</td></tr><tr><td>690970000</td><td>Snoozed</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Booking Alert Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Booking Alert Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
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
|_msdyn_bookingalert_value||Unique identifier for Booking Alert associated with Booking Alert Status.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingalertstatus_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingalertstatus_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingalertstatus_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_bookingalertstatus_modifiedonbehalfby|
|msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_msdyn_bookingalert_msdyn_bookingalertstatus_BookingAlert|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_bookingalertstatus|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_bookingalertstatus|
|owningteam|[team EntityType](team.md)|team_msdyn_bookingalertstatus|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_bookingalertstatus|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_bookingalertstatus_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_bookingalertstatus_adx_alertsubscription|  
|msdyn_bookingalertstatus_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_bookingalertstatus_adx_inviteredemption|  
|msdyn_bookingalertstatus_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_bookingalertstatus_adx_portalcomment|  
|msdyn_bookingalertstatus_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_bookingalertstatus_appointment|  
|msdyn_bookingalertstatus_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_connections1|[connection EntityType](connection.md)|record1id_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_connections2|[connection EntityType](connection.md)|record2id_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_bookingalertstatus_email|  
|msdyn_bookingalertstatus_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_bookingalertstatus_fax|  
|msdyn_bookingalertstatus_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_bookingalertstatus_letter|  
|msdyn_bookingalertstatus_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_bookingalertstatus_msdyn_approval|  
|msdyn_bookingalertstatus_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_bookingalertstatus_msdyn_bookingalert|  
|msdyn_bookingalertstatus_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_bookingalertstatus_msdyn_surveyinvite|  
|msdyn_bookingalertstatus_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_bookingalertstatus_phonecall|  
|msdyn_bookingalertstatus_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_bookingalertstatus_recurringappointmentmaster|  
|msdyn_bookingalertstatus_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_bookingalertstatus_serviceappointment|  
|msdyn_bookingalertstatus_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_bookingalertstatus_socialactivity|  
|msdyn_bookingalertstatus_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_bookingalertstatus|  
|msdyn_bookingalertstatus_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_bookingalertstatus_task|  

## Operations
The following operations can be used with the msdyn_bookingalertstatus entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_bookingalertstatus entity type.


|Name|Description |  
|----|------------|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|    

[!INCLUDE[./remarks/msdyn_bookingalertstatus.md](./remarks/msdyn_bookingalertstatus.md)]

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