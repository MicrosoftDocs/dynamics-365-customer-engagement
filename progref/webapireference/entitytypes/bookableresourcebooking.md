---
title: "Microsoft Dynamics 365 Customer Engagement bookableresourcebooking EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8fe3f331-110e-4c17-832d-78034ffe2ca2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bookableresourcebooking entitytype."
---
# bookableresourcebooking EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bookableresourcebooking.md](./descriptions/bookableresourcebooking.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]bookableresourcebookings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bookable Resource Booking</td></tr>
<tr><td><b>Primary Key:</b></td><td>bookableresourcebookingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The bookableresourcebooking entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bookableresourcebookingid|Edm.Guid|**Display Name**: Bookable Resource Booking<br />**Description**: Unique identifier of the resource booking.<br />|
|bookingtype|Edm.Int32|**Display Name**: Booking Type<br />**Description**: Select whether the booking is solid or liquid. Solid bookings are firm and cannot be changed whereas liquid bookings can be changed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>2</td><td>Liquid</td></tr><tr><td>1</td><td>Solid</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Enter the duration of the booking.<br />|
|endtime|Edm.DateTimeOffset|**Display Name**: End Time<br />**Description**: Enter the end date and time of the booking.<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the bookableresourcebooking with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_actualarrivaltime|Edm.DateTimeOffset|**Display Name**: Actual Arrival Time<br />**Description**: Shows the time that work started.<br />|
|msdyn_actualtravelduration|Edm.Int32|**Display Name**: Actual Travel Duration<br />**Description**: Shows the total travel duration. If you leave this field blank the system automatically determines the travel duration by calculating the resource journal details.<br />|
|msdyn_allowoverlapping|Edm.Boolean|**Display Name**: Allow Overlapping<br />**Description**: Allow the time of this booking to be displayed on the schedule assistant as available.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_bookingmethod|Edm.Int32|**Display Name**: Booking Method<br />**Description**: Shows the method used to create this booking.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Resource Scheduling Optimization</td></tr><tr><td>690970001</td><td>Schedule Board</td></tr><tr><td>690970002</td><td>Mobile</td></tr><tr><td>690970003</td><td>Manual</td></tr><tr><td>690970004</td><td>Schedule Assistant</td></tr><tr><td>690970005</td><td>System - Agreement Schedule</td></tr><tbody></table>|
|msdyn_cascadecrewchanges|Edm.Boolean|**Display Name**: Cascade Crew Changes<br />**Description**: Defines whether changing any of the following fields (Start Time, End Time, Status) should cascade the changes to other bookings on this requirement that have the same start and end time.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_datewindowend|Edm.DateTimeOffset|**Display Name**: Date Window End<br />|
|msdyn_datewindowstart|Edm.DateTimeOffset|**Display Name**: Date Window Start<br />|
|msdyn_estimatedarrivaltime|Edm.DateTimeOffset|**Display Name**: Estimated Arrival Time<br />**Description**: Estimated Arrival Time<br />|
|msdyn_estimatedtravelduration|Edm.Int32|**Display Name**: Estimated Travel Duration<br />**Description**: Estimated Travel Duration<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_latitude|Edm.Double|**Display Name**: Latitude<br />|
|msdyn_longitude|Edm.Double|**Display Name**: Longitude<br />|
|msdyn_milestraveled|Edm.Double|**Display Name**: Miles Traveled<br />**Description**: In this field you can enter the total miles the resource drove to the job site<br />|
|msdyn_preventtimestampcreation|Edm.Boolean|**Display Name**: Prevent Timestamp Creation<br />**Description**: Prevents time stamp creation if the time stamp was already created on a mobile device.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_schedulinglockoptions|Edm.Int32|**Display Name**: Scheduling Lock Options<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Time Range</td></tr><tr><td>192350001</td><td>Resource</td></tr><tr><td>192350002</td><td>Time</td></tr><tr><td>192350003</td><td>Resource + Time</td></tr><tbody></table>|
|msdyn_schedulingsnapshot|Edm.String|**Display Name**: Scheduling Snapshot<br />**Description**: A snapshot of scheduling information when resource scheduling optimization started.<br />|
|msdyn_signature|Edm.String|**Display Name**: Signature<br />**Description**: This field is used for capturing signature on MoCa (using the Pen Control)<br />|
|msdyn_slottext|Edm.String|**Display Name**: Slot Text<br />**Description**: Shows the automatically generated text of the time slot on the schedule board.<br />|
|msdyn_timefrompromised|Edm.DateTimeOffset|**Display Name**: Time From Promised<br />|
|msdyn_timetopromised|Edm.DateTimeOffset|**Display Name**: Time To Promised<br />|
|msdyn_timewindowend|Edm.DateTimeOffset|**Display Name**: Time Window End<br />|
|msdyn_timewindowstart|Edm.DateTimeOffset|**Display Name**: Time Window Start<br />|
|msdyn_totalbillableduration|Edm.Int32|**Display Name**: Total Billable Duration<br />**Description**: Shows the total billable duration. If you leave this field blank the system automatically determines the billable duration by calculating the resource journal details.<br />|
|msdyn_totalbreakduration|Edm.Int32|**Display Name**: Total Break Duration<br />**Description**: Shows the total break duration. If you leave this field blank the system automatically determines the break duration by calculating the resource journal details.<br />|
|msdyn_totalcost|Edm.Decimal|**Display Name**: Total Cost<br />**Description**: Shows the total cost for this booking.<br />|
|msdyn_totalcost_base|Edm.Decimal|**Display Name**: Total Cost (Base)<br />**Description**: Value of the Total Cost in base currency.<br />Read-only<br />|
|msdyn_totaldurationinprogress|Edm.Int32|**Display Name**: Total Duration In Progress<br />**Description**: Shows the total duration that this booking was in progress.<br />|
|msdyn_traveltimerescheduling|Edm.Boolean|**Display Name**: Travel Time Rescheduling (Deprecated)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a name for the booking.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|starttime|Edm.DateTimeOffset|**Display Name**: Start Time<br />**Description**: Enter the start date and time of the booking.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Bookable Resource Booking<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Bookable Resource Booking<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_bookingstatus_value|BookingStatus<br />|Select the status of the booking.|
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_header_value|Header<br />|Shows the reference to the booking header record that represents the summary of bookings.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_agreementbookingdate_value|msdyn_agreementbookingdate<br />|Agreement Booking Date from where this Booking was generated|
|_msdyn_bookingsetupmetadataid_value|msdyn_BookingSetupMetadataId<br />|A unique identifier for the booking setup metadata that is associated with a bookable resource booking.|
|_msdyn_glympsetaskid_value|msdyn_glympsetaskId<br />|Relationship between the glympse task and the bookable resource booking.|
|_msdyn_projectid_value|msdyn_projectid<br />|Project of booking detail record|
|_msdyn_projectteamid_value|msdyn_projectteamid<br />|Project team member of booking detail record|
|_msdyn_resourcecategoryid_value|msdyn_resourcecategoryid<br />|Resource Category|
|_msdyn_resourcegroup_value|msdyn_resourcegroup<br />|Unique identifier for Resource associated with Resource Booking|
|_msdyn_resourcerequirement_value|msdyn_ResourceRequirement<br />|Resource Requirement|
|_msdyn_timegroupdetailselected_value|msdyn_timegroupdetailselected<br />||
|_msdyn_workorder_value|msdyn_workorder<br />|Unique identifier for Work Order associated with Resource Booking.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_resource_value|Resource<br />|Shows the resource that is booked.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the BookableResourceBooking with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|BookingStatus|[bookingstatus EntityType](bookingstatus.md)|bookingstatus_bookableresourcebooking_BookingStatus|
|createdbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcebooking_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcebooking_createdonbehalfby|
|Header|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_bookableresourcebooking_Header|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcebooking_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcebooking_modifiedonbehalfby|
|msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_msdyn_agreementbookingdate_bookableresourcebooking_AgreementBookingDate|
|msdyn_BookingSetupMetadataId|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|msdyn_msdyn_bookingsetupmetadata_bookableresour|
|msdyn_glympsetaskId|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_msdyn_glympsetask_bookableresourcebooking|
|msdyn_projectid|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_bookableresourcebooking_projectid|
|msdyn_projectteamid|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid|
|msdyn_resourcecategoryid|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid|
|msdyn_resourcegroup|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_bookableresourcebooking_ResourceGroup|
|msdyn_ResourceRequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement|
|msdyn_timegroupdetailselected|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected|
|msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder|
|ownerid|[principal EntityType](principal.md)|owner_bookableresourcebooking|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_bookableresourcebooking|
|owningteam|[team EntityType](team.md)|team_bookableresourcebooking|
|owninguser|[systemuser EntityType](systemuser.md)|user_bookableresourcebooking|
|Resource|[bookableresource EntityType](bookableresource.md)|bookableresource_bookableresourcebooking_Resource|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_bookableresourcebooking|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bookableresourcebooking_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_bookableresourcebooking|  
|bookableresourcebooking_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_bookableresourcebooking_adx_alertsubscription|  
|bookableresourcebooking_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_bookableresourcebooking_adx_inviteredemption|  
|bookableresourcebooking_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_bookableresourcebooking_adx_portalcomment|  
|bookableresourcebooking_Annotations|[annotation EntityType](annotation.md)|objectid_bookableresourcebooking|  
|bookableresourcebooking_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_bookableresourcebooking_appointment|  
|bookableresourcebooking_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_bookableresourcebooking|  
|bookableresourcebooking_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_bookableresourcebooking|  
|bookableresourcebooking_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_bookableresourcebooking_bulkoperation|  
|bookableresourcebooking_CampaignActivities|[campaignactivity EntityType](campaignactivity.md)|regardingobjectid_bookableresourcebooking_campaignactivity|  
|bookableresourcebooking_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_bookableresourcebooking_campaignresponse|  
|bookableresourcebooking_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_bookableresourcebooking|  
|bookableresourcebooking_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_bookableresourcebooking|  
|bookableresourcebooking_Emails|[email EntityType](email.md)|regardingobjectid_bookableresourcebooking_email|  
|bookableresourcebooking_Faxes|[fax EntityType](fax.md)|regardingobjectid_bookableresourcebooking_fax|  
|bookableresourcebooking_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_bookableresourcebooking_incidentresolution|  
|bookableresourcebooking_Letters|[letter EntityType](letter.md)|regardingobjectid_bookableresourcebooking_letter|  
|bookableresourcebooking_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_bookableresourcebooking_msdyn_approval|  
|bookableresourcebooking_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_bookableresourcebooking_msdyn_bookingalert|  
|bookableresourcebooking_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_bookableresourcebooking_msdyn_surveyinvite|  
|bookableresourcebooking_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_bookableresourcebooking_opportunityclose|  
|bookableresourcebooking_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_bookableresourcebooking_orderclose|  
|bookableresourcebooking_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_bookableresourcebooking_phonecall|  
|bookableresourcebooking_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_bookableresourcebooking_quoteclose|  
|bookableresourcebooking_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_bookableresourcebooking_recurringappointmentmaster|  
|bookableresourcebooking_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_bookableresourcebooking_serviceappointment|  
|bookableresourcebooking_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_bookableresourcebooking_socialactivity|  
|BookableResourceBooking_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_bookableresourcebooking_syncerror|  
|bookableresourcebooking_Tasks|[task EntityType](task.md)|regardingobjectid_bookableresourcebooking_task|  
|msdyn_bookableresourcebooking_msdyn_bookingjournal_Booking|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|msdyn_booking|  
|msdyn_bookableresourcebooking_msdyn_bookingtimestamp_Booking|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_booking|  
|msdyn_bookableresourcebooking_msdyn_optimizationrequestbooking_BookableResourceBooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|msdyn_BookableResourceBooking|  
|msdyn_bookableresourcebooking_msdyn_purchaseorder_Booking|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_booking|  
|msdyn_bookableresourcebooking_msdyn_purchaseorderproduct_AssociateToBooking|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_associatetobooking|  
|msdyn_bookableresourcebooking_msdyn_purchaseorderreceiptproduct_AssociateToBooking|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_associatetobooking|  
|msdyn_bookableresourcebooking_msdyn_rtv_Booking|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_booking|  
|msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_booking|  
|msdyn_bookableresourcebooking_msdyn_workorderservice_Booking|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_booking|  
|msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_booking|  

## Operations
The following operations can be used with the bookableresourcebooking entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the bookableresourcebooking entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Integration with Glympse Solution](../solutions/glympse.md)|[!INCLUDE[../solutions/descriptions/glympse.md](../solutions/descriptions/glympse.md)]|  
|[Microsoft Dynamics Scheduling Workload Solution](../solutions/scheduling.md)|[!INCLUDE[../solutions/descriptions/scheduling.md](../solutions/descriptions/scheduling.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/bookableresourcebooking.md](./remarks/bookableresourcebooking.md)]

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