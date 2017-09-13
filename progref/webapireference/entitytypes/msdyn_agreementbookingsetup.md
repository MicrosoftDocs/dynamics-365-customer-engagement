---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_agreementbookingsetup EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1cbd4934-0b05-4b36-91bb-c68be8e7517f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_agreementbookingsetup entitytype."
---
# msdyn_agreementbookingsetup EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_agreementbookingsetup.md](./descriptions/msdyn_agreementbookingsetup.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_agreementbookingsetups </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Agreement Booking Setup</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_agreementbookingsetupid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_agreementbookingsetup entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_agreementbookingsetupid|Edm.Guid|**Display Name**: Agreement Booking Setup<br />**Description**: Shows the entity instances.<br />|
|msdyn_autogeneratebooking|Edm.Boolean|**Display Name**: Auto Generate Booking<br />**Description**: Enable if the system should automatically generate Order Bookings for the Booking Dates of this Booking Setup<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_autogeneratewo|Edm.Boolean|**Display Name**: Auto Generate Work Order<br />**Description**: Enable if the system should automatically generate Work Orders for the Booking Dates of this Booking Setup<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type a description of this booking setup.<br />|
|msdyn_estimatedduration|Edm.Int32|**Display Name**: Estimated Duration<br />**Description**: Shows the duration of the booking.<br />|
|msdyn_generatewodaysinadvance|Edm.Int32|**Display Name**: Generate Work Order Days In Advance<br />**Description**: Specify how many days in advance of the Booking Date the system should automatically generate a Work Order<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_postbookingflexibility|Edm.Int32|**Display Name**: Post Booking Flexibility<br />**Description**: Shows the flexibility of days after the booking date.<br />|
|msdyn_postponegenerationuntil|Edm.DateTimeOffset|**Display Name**: Postpone Generation Until<br />|
|msdyn_prebookingflexibility|Edm.Int32|**Display Name**: Pre Booking Flexibility<br />**Description**: Shows the flexibility of days prior to the booking date.<br />|
|msdyn_preferredstarttime|Edm.DateTimeOffset|**Display Name**: Preferred Start Time<br />**Description**: Shows the preferred time to booking.<br />|
|msdyn_recurrencesettings|Edm.String|**Display Name**: Recurrence Settings<br />**Description**: Stores the booking recurrence settings.<br />|
|msdyn_revision|Edm.Int32|**Display Name**: Revision<br />**Description**: For internal use only.<br />|
|msdyn_timewindowend|Edm.DateTimeOffset|**Display Name**: Time Window End<br />**Description**: Shows the time window up until when this can be booked.<br />|
|msdyn_timewindowstart|Edm.DateTimeOffset|**Display Name**: Time Window Start<br />**Description**: Shows the time window from when this can be booked.<br />|
|msdyn_workordersummary|Edm.String|**Display Name**: Work Order Summary<br />**Description**: Shows the work order summary to be set on the work orders generated.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the ID of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Agreement Booking Setup<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Agreement Booking Setup<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.<br />|
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
|_msdyn_agreement_value|msdyn_agreement<br />|Agreement this Booking Setup relates to|
|_msdyn_preferredresource_value|msdyn_preferredresource<br />|Preferred Resource to booked|
|_msdyn_priority_value|msdyn_priority<br />|Booking Priority|
|_msdyn_workordertype_value|msdyn_workordertype<br />|Work Order Type to be used on generated Work Orders|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the ID of the stage where the entity is located.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreementbookingsetup_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreementbookingsetup_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreementbookingsetup_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreementbookingsetup_modifiedonbehalfby|
|msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement|
|msdyn_preferredresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource|
|msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority|
|msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_agreementbookingsetup|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_agreementbookingsetup|
|owningteam|[team EntityType](team.md)|team_msdyn_agreementbookingsetup|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_agreementbookingsetup|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_agreementbookingsetup|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_agreementbookingsetup_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_agreementbookingsetup_adx_alertsubscription|  
|msdyn_agreementbookingsetup_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_agreementbookingsetup_adx_inviteredemption|  
|msdyn_agreementbookingsetup_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_agreementbookingsetup_adx_portalcomment|  
|msdyn_agreementbookingsetup_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_agreementbookingsetup_appointment|  
|msdyn_agreementbookingsetup_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_connections1|[connection EntityType](connection.md)|record1id_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_connections2|[connection EntityType](connection.md)|record2id_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_agreementbookingsetup_email|  
|msdyn_agreementbookingsetup_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_agreementbookingsetup_fax|  
|msdyn_agreementbookingsetup_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_agreementbookingsetup_letter|  
|msdyn_agreementbookingsetup_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_agreementbookingsetup_msdyn_approval|  
|msdyn_agreementbookingsetup_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_agreementbookingsetup_msdyn_bookingalert|  
|msdyn_agreementbookingsetup_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_agreementbookingsetup_msdyn_surveyinvite|  
|msdyn_agreementbookingsetup_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_agreementbookingsetup_phonecall|  
|msdyn_agreementbookingsetup_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_agreementbookingsetup_recurringappointmentmaster|  
|msdyn_agreementbookingsetup_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_agreementbookingsetup_serviceappointment|  
|msdyn_agreementbookingsetup_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_agreementbookingsetup_socialactivity|  
|msdyn_agreementbookingsetup_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_agreementbookingsetup|  
|msdyn_agreementbookingsetup_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_agreementbookingsetup_task|  
|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingdate_BookingSetup|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_bookingsetup|  
|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingincident_AgreementBookingSetup|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingsetup|  
|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingproduct_AgreementBookingSetup|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingsetup|  
|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingsetup|  
|msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservicetask_AgreementBookingSetup|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingsetup|  

## Operations
The following operations can be used with the msdyn_agreementbookingsetup entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_agreementbookingsetup entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_agreementbookingsetup.md](./remarks/msdyn_agreementbookingsetup.md)]

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