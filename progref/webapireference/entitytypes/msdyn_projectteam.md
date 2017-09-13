---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_projectteam EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fa2df038-ef21-4ef5-8c39-6c790d34239e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_projectteam entitytype."
---
# msdyn_projectteam EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_projectteam.md](./descriptions/msdyn_projectteam.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_projectteams </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Project Team Member</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_projectteamid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_allocationmethod|Edm.Int32|**Display Name**: Allocation method<br />**Description**: Shows the allocation method used to book resources on the project (full capacity, percentage, and so on).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>None</td></tr><tr><td>192350001</td><td>Full Capacity</td></tr><tr><td>192350004</td><td>Percentage Capacity</td></tr><tr><td>192350003</td><td>By Hours - Distribute evenly</td></tr><tr><td>192350005</td><td>By Hours - Front load</td></tr><tbody></table>|
|msdyn_applicantcount|Edm.Int32|**Display Name**: Applicant count<br />**Description**: Shows the number of applicants for this project team.<br />Computed<br />Read-only<br />|
|msdyn_applicantcount_date|Edm.DateTimeOffset|**Display Name**: Applicant count (Last Updated On)<br />**Description**: Last Updated time of rollup field Applicant count.<br />Read-only<br />|
|msdyn_applicantcount_state|Edm.Int32|**Display Name**: Applicant count (State)<br />**Description**: State of rollup field Applicant count.<br />Read-only<br />|
|msdyn_applicantsavailable|Edm.Boolean|**Display Name**: Applicants available<br />**Description**: Shows if there are applicants available for this project team.<br />Computed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_assignedhours|Edm.Decimal|**Display Name**: Assigned Hours<br />**Description**: Type the total assigned hours for project team member.<br />|
|msdyn_billingtype|Edm.Int32|**Display Name**: Billing Type<br />**Description**: Select whether the team member is billable<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Non Chargeable</td></tr><tr><td>192350001</td><td>Chargeable</td></tr><tr><td>192350002</td><td>Complimentary</td></tr><tr><td>192350003</td><td>Not Available</td></tr><tbody></table>|
|msdyn_calendarid|Edm.String|**Display Name**: Calendar Id<br />**Description**: Shows the calendar used for staffing this project team.<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type the system description.<br />|
|msdyn_from|Edm.DateTimeOffset|**Display Name**: From<br />**Description**: Enter the resource team membership start date.<br />|
|msdyn_hardbookedhours|Edm.Decimal|**Display Name**: Booked Hours<br />**Description**: Hard Book<br />|
|msdyn_hours|Edm.Decimal|**Display Name**: Hours<br />**Description**: Duplicate for resource requirement<br />|
|msdyn_hoursrequested|Edm.Double|**Display Name**: Required Hours<br />**Description**: Shows the number of hours required of this team member on the project.<br />|
|msdyn_membershipstatus|Edm.Int32|**Display Name**: Membership Status<br />**Description**: Shows the membership status of this project team member.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Requested</td></tr><tr><td>2</td><td>Assigned</td></tr><tr><td>3</td><td>Declined</td></tr><tbody></table>|
|msdyn_msprojectclientid|Edm.String|**Display Name**: MS Project Client Id<br />**Description**: The id of the project team member in MS Project Client.<br />|
|msdyn_name|Edm.String|**Display Name**: Position Name<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_number|Edm.Int32|**Display Name**: Number<br />**Description**: Shows the number of resources requested.<br />|
|msdyn_percentage|Edm.Decimal|**Display Name**: Percentage<br />**Description**: Duplicate for resource requirement<br />|
|msdyn_projectapprover|Edm.Boolean|**Display Name**: Project Approver<br />**Description**: Select whether the team member can approve time and expenses.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_projectteamid|Edm.Guid|**Display Name**: Project Team<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_requiredhours|Edm.Decimal|**Display Name**: Required Hours<br />**Description**: Required hours of team member from team member requirement<br />|
|msdyn_roledescription|Edm.String|**Display Name**: Position Description<br />**Description**: Enter a description of the role for this team member.<br />|
|msdyn_softbookedhours|Edm.Decimal|**Display Name**: Soft Book<br />**Description**: Soft Book<br />|
|msdyn_to|Edm.DateTimeOffset|**Display Name**: To<br />**Description**: Enter the end date of the resource membership in a team.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the project team.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Project Team<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_bookableresourceid_value|msdyn_bookableresourceid<br />|Shows the resource.|
|_msdyn_project_value|msdyn_project<br />|Select the project that this team members are part of.|
|_msdyn_resourcecategory_value|msdyn_resourcecategory<br />|Select the role this team member is playing in this team.|
|_msdyn_resourcerequirementid_value|msdyn_resourcerequirementid<br />|Unique identifier for Resource Requirement associated with Project Team Member.|
|_msdyn_worktemplate_value|msdyn_worktemplate<br />|Template to use for generic resource's schedule. Will be ignored if its a user or facility resource|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectteam_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectteam_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectteam_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectteam_modifiedonbehalfby|
|msdyn_bookableresourceid|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_projectteam_bookableresourceid|
|msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_projectteam_project|
|msdyn_resourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory|
|msdyn_resourcerequirementid|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_projectteam|
|msdyn_worktemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_msdyn_workhourtemplate_msdyn_projectteam_worktemplate|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_projectteam|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_projectteam|
|owningteam|[team EntityType](team.md)|team_msdyn_projectteam|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_projectteam|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_projectteamid|  
|msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|msdyn_projectteamid|  
|msdyn_msdyn_projectteam_msdyn_findworkevent_Work|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|msdyn_Work|  
|msdyn_msdyn_projectteam_msdyn_projecttask_AssignedTeamMembers|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_AssignedTeamMembers|  
|msdyn_msdyn_projectteam_msdyn_projectteammembersignup_TeamMembership|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|msdyn_TeamMembership|  
|msdyn_msdyn_projectteam_msdyn_resourceassignment_projectteamid|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|msdyn_projectteamid|  
|msdyn_projectteam_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_projectteam|  
|msdyn_projectteam_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_projectteam_adx_alertsubscription|  
|msdyn_projectteam_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_projectteam_adx_inviteredemption|  
|msdyn_projectteam_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_projectteam_adx_portalcomment|  
|msdyn_projectteam_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_projectteam|  
|msdyn_projectteam_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_projectteam_appointment|  
|msdyn_projectteam_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_projectteam|  
|msdyn_projectteam_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_projectteam|  
|msdyn_projectteam_connections1|[connection EntityType](connection.md)|record1id_msdyn_projectteam|  
|msdyn_projectteam_connections2|[connection EntityType](connection.md)|record2id_msdyn_projectteam|  
|msdyn_projectteam_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_projectteam|  
|msdyn_projectteam_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_projectteam|  
|msdyn_projectteam_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_projectteam_email|  
|msdyn_projectteam_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_projectteam_fax|  
|msdyn_projectteam_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_projectteam_letter|  
|msdyn_projectteam_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_projectteam_msdyn_approval|  
|msdyn_projectteam_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_projectteam_msdyn_bookingalert|  
|msdyn_projectteam_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_projectteam_msdyn_surveyinvite|  
|msdyn_projectteam_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_projectteam_phonecall|  
|msdyn_projectteam_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_projectteam_recurringappointmentmaster|  
|msdyn_projectteam_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_projectteam_serviceappointment|  
|msdyn_projectteam_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_projectteam_socialactivity|  
|msdyn_projectteam_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_projectteam|  
|msdyn_projectteam_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_projectteam_task|  

## Operations
The following operations can be used with the msdyn_projectteam entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_AssignGenericResource Action](../actions/msdyn_assigngenericresource.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_assigngenericresource.md](../actions/descriptions/msdyn_assigngenericresource.md)]|  
|[msdyn_ProjectTeamMemberSignUpProcess Action](../actions/msdyn_projectteammembersignupprocess.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_projectteammembersignupprocess.md](../actions/descriptions/msdyn_projectteammembersignupprocess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_projectteam entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_projectteam.md](./remarks/msdyn_projectteam.md)]

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