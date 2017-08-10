---
title: "Microsoft Dynamics 365 Customer Engagement bookableresourcebookingheader EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 56830f8d-724e-4451-83c0-1e3fc5ff5fcf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bookableresourcebookingheader entitytype."
---
# bookableresourcebookingheader EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bookableresourcebookingheader.md](./descriptions/bookableresourcebookingheader.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]bookableresourcebookingheaders </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bookable Resource Booking Header</td></tr>
<tr><td><b>Primary Key:</b></td><td>bookableresourcebookingheaderid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The bookableresourcebookingheader entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bookableresourcebookingheaderid|Edm.Guid|**Display Name**: Bookable Resource Booking Header<br />**Description**: Unique identifier of the resource booking header.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Shows the aggregate duration of the linked bookings.<br />|
|endtime|Edm.DateTimeOffset|**Display Name**: End Time<br />**Description**: Shows the end date and time of the booking summary.<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the bookableresourcebookingheader with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_bookingtype|Edm.Int32|**Display Name**: Booking Type<br />**Description**: Select whether the booking is solid or liquid. Solid bookings are firm and cannot be changed whereas liquid bookings can be changed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Solid</td></tr><tr><td>2</td><td>Liquid</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: The name of the booking summary.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|starttime|Edm.DateTimeOffset|**Display Name**: Start Time<br />**Description**: Shows the start date and time of the booking summary.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Bookable Resource Booking Header<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Bookable Resource Booking Header<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_bookableresourceid_value|msdyn_bookableresourceid<br />|Shows the resource.|
|_msdyn_bookingstatusid_value|msdyn_bookingstatusid<br />|Booking Status|
|_msdyn_projectid_value|msdyn_projectid<br />|Project|
|_msdyn_projectteamid_value|msdyn_projectteamid<br />|Project Team|
|_msdyn_resourcecategoryid_value|msdyn_resourcecategoryid<br />|Resource Category|
|_msdyn_resourcerequirement_value|msdyn_ResourceRequirement<br />|Resource Requirement|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the BookableResourceBookingHeader with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcebookingheader_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcebookingheader_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcebookingheader_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcebookingheader_modifiedonbehalfby|
|msdyn_bookableresourceid|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid|
|msdyn_bookingstatusid|[bookingstatus EntityType](bookingstatus.md)|msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid|
|msdyn_projectid|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_bookableresourcebookingheader_projectid|
|msdyn_projectteamid|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid|
|msdyn_resourcecategoryid|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid|
|msdyn_ResourceRequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement|
|ownerid|[principal EntityType](principal.md)|owner_bookableresourcebookingheader|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_bookableresourcebookingheader|
|owningteam|[team EntityType](team.md)|team_bookableresourcebookingheader|
|owninguser|[systemuser EntityType](systemuser.md)|user_bookableresourcebookingheader|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_bookableresourcebookingheader|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bookableresourcebookingheader_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_bookableresourcebookingheader|  
|bookableresourcebookingheader_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_bookableresourcebookingheader_adx_alertsubscription|  
|bookableresourcebookingheader_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_bookableresourcebookingheader_adx_inviteredemption|  
|bookableresourcebookingheader_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_bookableresourcebookingheader_adx_portalcomment|  
|bookableresourcebookingheader_Annotations|[annotation EntityType](annotation.md)|objectid_bookableresourcebookingheader|  
|bookableresourcebookingheader_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_bookableresourcebookingheader_appointment|  
|bookableresourcebookingheader_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_bookableresourcebookingheader|  
|bookableresourcebookingheader_bookableresourcebooking_Header|[bookableresourcebooking EntityType](bookableresourcebooking.md)|Header|  
|bookableresourcebookingheader_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_bookableresourcebookingheader|  
|bookableresourcebookingheader_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_bookableresourcebookingheader_bulkoperation|  
|bookableresourcebookingheader_CampaignActivities|[campaignactivity EntityType](campaignactivity.md)|regardingobjectid_bookableresourcebookingheader_campaignactivity|  
|bookableresourcebookingheader_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_bookableresourcebookingheader_campaignresponse|  
|bookableresourcebookingheader_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_bookableresourcebookingheader|  
|bookableresourcebookingheader_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_bookableresourcebookingheader|  
|bookableresourcebookingheader_Emails|[email EntityType](email.md)|regardingobjectid_bookableresourcebookingheader_email|  
|bookableresourcebookingheader_Faxes|[fax EntityType](fax.md)|regardingobjectid_bookableresourcebookingheader_fax|  
|bookableresourcebookingheader_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_bookableresourcebookingheader_incidentresolution|  
|bookableresourcebookingheader_Letters|[letter EntityType](letter.md)|regardingobjectid_bookableresourcebookingheader_letter|  
|bookableresourcebookingheader_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_bookableresourcebookingheader_msdyn_approval|  
|bookableresourcebookingheader_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_bookableresourcebookingheader_msdyn_bookingalert|  
|bookableresourcebookingheader_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_bookableresourcebookingheader_msdyn_surveyinvite|  
|bookableresourcebookingheader_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_bookableresourcebookingheader_opportunityclose|  
|bookableresourcebookingheader_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_bookableresourcebookingheader_orderclose|  
|bookableresourcebookingheader_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_bookableresourcebookingheader_phonecall|  
|bookableresourcebookingheader_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_bookableresourcebookingheader_quoteclose|  
|bookableresourcebookingheader_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_bookableresourcebookingheader_recurringappointmentmaster|  
|bookableresourcebookingheader_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_bookableresourcebookingheader_serviceappointment|  
|bookableresourcebookingheader_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_bookableresourcebookingheader_socialactivity|  
|BookableResourceBookingHeader_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_bookableresourcebookingheader_syncerror|  
|bookableresourcebookingheader_Tasks|[task EntityType](task.md)|regardingobjectid_bookableresourcebookingheader_task|  
|msdyn_resourcerequirement_bookingheader|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_bookingheader|  

## Operations
The following operations can be used with the bookableresourcebookingheader entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the bookableresourcebookingheader entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Scheduling Workload Solution](../solutions/scheduling.md)|[!INCLUDE[../solutions/descriptions/scheduling.md](../solutions/descriptions/scheduling.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/bookableresourcebookingheader.md](./remarks/bookableresourcebookingheader.md)]

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