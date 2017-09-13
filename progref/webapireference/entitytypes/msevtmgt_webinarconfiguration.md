---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_webinarconfiguration EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2cc6b9dc-8953-48c0-81e2-82bd647dc5fc
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_webinarconfiguration entitytype."
---
# msevtmgt_webinarconfiguration EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_webinarconfiguration.md](./descriptions/msevtmgt_webinarconfiguration.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_webinarconfigurations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Webinar Configuration</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_webinarconfigurationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_webinarconfiguration entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_accesstokenkey|Edm.String|**Display Name**: Access Token Key<br />|
|msevtmgt_accesstokensecret|Edm.String|**Display Name**: Access Token Secret<br />|
|msevtmgt_appurl|Edm.String|**Display Name**: App URL<br />|
|msevtmgt_clientid|Edm.String|**Display Name**: Client Id<br />|
|msevtmgt_key|Edm.String|**Display Name**: Key<br />|
|msevtmgt_lastupdatedatetime|Edm.DateTimeOffset|**Display Name**: Last update of Metrics<br />|
|msevtmgt_message|Edm.String|**Display Name**: Message<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_updatecredentials|Edm.Int32|**Display Name**: Update credentials?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_webinarconfigurationid|Edm.Guid|**Display Name**: Webinar Configuration<br />**Description**: Unique identifier for entity instances<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Webinar Configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Webinar Configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_webinarproviderid_value|msevtmgt_WebinarProviderId<br />|Unique identifier for Webinar Provider associated with Webinar Configuration.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_webinarconfiguration_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_webinarconfiguration_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_webinarconfiguration_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_webinarconfiguration_modifiedonbehalfby|
|msevtmgt_WebinarProviderId|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov|
|organizationid|[organization EntityType](organization.md)|organization_msevtmgt_webinarconfiguration|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_webinarconfiguration_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_webinarconfiguration|  
|msevtmgt_webinarconfiguration_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_webinarconfiguration_adx_alertsubscription|  
|msevtmgt_webinarconfiguration_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_webinarconfiguration_adx_inviteredemption|  
|msevtmgt_webinarconfiguration_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_webinarconfiguration_adx_portalcomment|  
|msevtmgt_webinarconfiguration_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_webinarconfiguration|  
|msevtmgt_webinarconfiguration_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_webinarconfiguration_appointment|  
|msevtmgt_webinarconfiguration_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_webinarconfiguration|  
|msevtmgt_webinarconfiguration_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_webinarconfiguration|  
|msevtmgt_webinarconfiguration_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_webinarconfiguration_email|  
|msevtmgt_webinarconfiguration_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_webinarconfiguration_fax|  
|msevtmgt_webinarconfiguration_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_webinarconfiguration_letter|  
|msevtmgt_webinarconfiguration_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_webinarconfiguration_msdyn_approval|  
|msevtmgt_webinarconfiguration_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_webinarconfiguration_msdyn_bookingalert|  
|msevtmgt_webinarconfiguration_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_webinarconfiguration_msdyn_surveyinvite|  
|msevtmgt_webinarconfiguration_msevtmgt_event_Web|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_WebinarConfigurationId|  
|msevtmgt_webinarconfiguration_msevtmgt_session_Web|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_WebinarConfigurationId|  
|msevtmgt_webinarconfiguration_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_webinarconfiguration_phonecall|  
|msevtmgt_webinarconfiguration_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_webinarconfiguration_recurringappointmentmaster|  
|msevtmgt_webinarconfiguration_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_webinarconfiguration_serviceappointment|  
|msevtmgt_webinarconfiguration_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_webinarconfiguration_socialactivity|  
|msevtmgt_webinarconfiguration_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_webinarconfiguration|  
|msevtmgt_webinarconfiguration_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_webinarconfiguration_task|  

## Operations
The following operations can be used with the msevtmgt_webinarconfiguration entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msevtmgt_webinarconfiguration entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_webinarconfiguration.md](./remarks/msevtmgt_webinarconfiguration.md)]

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