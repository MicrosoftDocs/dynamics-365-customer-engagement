---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_customerjourney EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a5da5e6c-0654-409c-baa3-5e87a63f1792
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_customerjourney entitytype."
---
# msdyncrm_customerjourney EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_customerjourney.md](./descriptions/msdyncrm_customerjourney.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_customerjourneies </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Customer Journey</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_customerjourneyid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_customerjourney entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_customerjourneydesignerstate|Edm.String|**Display Name**: Customer Journey Designer State<br />**Description**: The state of customer journey designer.<br />|
|msdyncrm_customerjourneyid|Edm.Guid|**Display Name**: Customer Journey<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_customerjourneytimezone|Edm.Int32|**Display Name**: Time Zone<br />**Description**: Effective time zone for this customer journey.<br />|
|msdyncrm_description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the purpose of the customer journey.<br />|
|msdyncrm_enddatetime|Edm.DateTimeOffset|**Display Name**: End Date Time<br />**Description**: The end date of customer journey<br />|
|msdyncrm_insights_placeholder|Edm.String|**Display Name**: Insights<br />|
|msdyncrm_isrecurring|Edm.Boolean|**Display Name**: Is Recurring<br />**Description**: Determine whether the customer journey is recurrent.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the customer journey.<br />|
|msdyncrm_recurrencecount|Edm.Int32|**Display Name**: Recurrence Count<br />**Description**: Determine the number of iterations.<br />|
|msdyncrm_recurrenceintervaldays|Edm.Int32|**Display Name**: Recurrence Interval Days<br />**Description**: The duration of iteration in days.<br />|
|msdyncrm_startdatetime|Edm.DateTimeOffset|**Display Name**: Start Date Time<br />**Description**: The start date of customer journey<br />|
|msdyncrm_type|Edm.Int32|**Display Name**: Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>LinkedIn</td></tr><tr><td>192350000</td><td>Automated</td></tr><tbody></table>|
|msdyncrm_validationresults|Edm.String|**Display Name**: Validation Results<br />|
|msdyncrm_workflowdefinition|Edm.String|**Display Name**: Workflow Definition<br />**Description**: The customer journey design definition<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Customer Journey<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Customer Journey<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Live</td></tr><tr><td>192350002</td><td>Stopped</td></tr><tr><td>192350003</td><td>Live editable</td></tr><tr><td>192350004</td><td>Expired</td></tr><tbody></table>|
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
|_msdyncr2_linkedincampaign_value|msdyncr2_LinkedInCampaign<br />|Link to LinkedIn Campaign|
|_msdyncrm_contentsettingsid_value|msdyncrm_contentsettingsId<br />|Content settings applicable to this customer journey.|
|_msdyncrm_customerjourneytemplate_value|msdyncrm_CustomerJourneyTemplate<br />|The template defining the basic design of this customer journey.|
|_msdyncrm_suppressionsegmentid_value|msdyncrm_SuppressionSegmentId<br />|Segment defining a list of contacts excluded from this customer journey flow.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_customerjourney_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_customerjourney_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_customerjourney_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_customerjourney_modifiedonbehalfby|
|msdyncr2_LinkedInCampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign|
|msdyncrm_contentsettingsId|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid|
|msdyncrm_CustomerJourneyTemplate|[msdyncrm_customerjourneytemplate EntityType](msdyncrm_customerjourneytemplate.md)|msdyncrm_msdyncrm_customerjourneytemplate_msdyncrm_customerjourney_CustomerJourneyTemplate|
|msdyncrm_SuppressionSegmentId|[msdyncrm_segment EntityType](msdyncrm_segment.md)|msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_customerjourney|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_customerjourney|
|owningteam|[team EntityType](team.md)|team_msdyncrm_customerjourney|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_customerjourney|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncr2_linkedinformsubmission_customerjourney|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncr2_customerjourney|  
|msdyncrm_customerjourney_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyncrm_customerjourney|  
|msdyncrm_customerjourney_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyncrm_customerjourney_adx_alertsubscription|  
|msdyncrm_customerjourney_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyncrm_customerjourney_adx_inviteredemption|  
|msdyncrm_customerjourney_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyncrm_customerjourney_adx_portalcomment|  
|msdyncrm_customerjourney_Annotations|[annotation EntityType](annotation.md)|objectid_msdyncrm_customerjourney|  
|msdyncrm_customerjourney_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyncrm_customerjourney_appointment|  
|msdyncrm_customerjourney_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_customerjourney|  
|msdyncrm_customerjourney_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_customerjourney|  
|msdyncrm_customerjourney_Emails|[email EntityType](email.md)|regardingobjectid_msdyncrm_customerjourney_email|  
|msdyncrm_customerjourney_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyncrm_customerjourney_fax|  
|msdyncrm_customerjourney_Feedback|[feedback EntityType](feedback.md)|regardingobjectid_msdyncrm_customerjourney|  
|msdyncrm_customerjourney_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyncrm_customerjourney_letter|  
|msdyncrm_customerjourney_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyncrm_customerjourney_msdyn_approval|  
|msdyncrm_customerjourney_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyncrm_customerjourney_msdyn_bookingalert|  
|msdyncrm_customerjourney_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyncrm_customerjourney_msdyn_surveyinvite|  
|msdyncrm_customerjourney_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyncrm_customerjourney_phonecall|  
|msdyncrm_customerjourney_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyncrm_customerjourney_recurringappointmentmaster|  
|msdyncrm_customerjourney_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyncrm_customerjourney_serviceappointment|  
|msdyncrm_customerjourney_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyncrm_customerjourney_socialactivity|  
|msdyncrm_customerjourney_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_customerjourney|  
|msdyncrm_customerjourney_Tasks|[task EntityType](task.md)|regardingobjectid_msdyncrm_customerjourney_task|  
|msdyncrm_msdyncrm_customerjourney_contact_campaignid|[contact EntityType](contact.md)|msdyncrm_campaignid|  
|msdyncrm_msdyncrm_customerjourney_lead_campaignid|[lead EntityType](lead.md)|msdyncrm_campaignid|  
|msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_CustomerJourney|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|msdyncrm_customerjourney|  
|msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj|  

## Operations
The following operations can be used with the msdyncrm_customerjourney entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_customerjourney entity type.


|Name|Description |  
|----|------------|  
|[LinkedIn Lead Gen Forms (Link to Marketing) Solution](../solutions/linkedinleadgenintegrationlink.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegrationlink.md](../solutions/descriptions/linkedinleadgenintegrationlink.md)]|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_customerjourney.md](./remarks/msdyncrm_customerjourney.md)]

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