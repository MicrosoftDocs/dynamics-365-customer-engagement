---
title: "Microsoft Dynamics 365 Customer Engagement adx_ad EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cdc9f199-d74e-4b5c-876f-b5d052c27d5f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_ad entitytype."
---
# adx_ad EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_ad.md](./descriptions/adx_ad.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_ads </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Ad</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_adid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_ad entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_adid|Edm.Guid|**Display Name**: Ad<br />**Description**: Shows the entity instance.<br />|
|adx_copy|Edm.String|**Display Name**: Copy<br />|
|adx_expirationdate|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />|
|adx_image|Edm.String|**Display Name**: image URL<br />**Description**: location of image file<br />|
|adx_imagealttext|Edm.String|**Display Name**: Image Alt Text<br />|
|adx_imageheight|Edm.Int32|**Display Name**: Image Height<br />|
|adx_imagewidth|Edm.Int32|**Display Name**: Image Width<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_openinnewwindow|Edm.Boolean|**Display Name**: Open In New Window<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_releasedate|Edm.DateTimeOffset|**Display Name**: Release Date<br />|
|adx_title|Edm.String|**Display Name**: Title<br />|
|adx_url|Edm.String|**Display Name**: Redirect URL<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Ad<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the ad's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_publishingstateid_value|adx_publishingstateid<br />|Unique identifier for Publishing State associated with Ad.|
|_adx_redirectwebfileid_value|adx_redirectwebfileid<br />|Unique identifier for Web File associated with Ad.|
|_adx_webfileid_value|adx_webfileid<br />|Unique identifier for Web File associated with Ad.|
|_adx_webpageid_value|adx_webpageid<br />|Unique identifier for Web Page associated with Ad.|
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website associated with Ad.|
|_adx_webtemplateid_value|adx_webtemplateid<br />|Unique identifier for Web Template associated with Ad.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_publishingstateid|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_publishingstate_ad|
|adx_redirectwebfileid|[adx_webfile EntityType](adx_webfile.md)|adx_redirectwebfile_ad|
|adx_webfileid|[adx_webfile EntityType](adx_webfile.md)|adx_webfile_ad|
|adx_webpageid|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_ad|
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_ad|
|adx_webtemplateid|[adx_webtemplate EntityType](adx_webtemplate.md)|adx_webtemplate_ad|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_ad_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_ad_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_ad_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_ad_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_ad|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_ad|
|owningteam|[team EntityType](team.md)|team_adx_ad|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_ad|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_ad_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_adx_ad|  
|adx_ad_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_adx_ad_adx_alertsubscription|  
|adx_ad_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_adx_ad_adx_inviteredemption|  
|adx_ad_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_adx_ad_adx_portalcomment|  
|adx_ad_Annotations|[annotation EntityType](annotation.md)|objectid_adx_ad|  
|adx_ad_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_adx_ad_appointment|  
|adx_ad_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_ad|  
|adx_ad_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_ad|  
|adx_ad_Emails|[email EntityType](email.md)|regardingobjectid_adx_ad_email|  
|adx_ad_Faxes|[fax EntityType](fax.md)|regardingobjectid_adx_ad_fax|  
|adx_ad_Letters|[letter EntityType](letter.md)|regardingobjectid_adx_ad_letter|  
|adx_ad_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_adx_ad_msdyn_approval|  
|adx_ad_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_adx_ad_msdyn_bookingalert|  
|adx_ad_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_adx_ad_msdyn_surveyinvite|  
|adx_ad_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_adx_ad_phonecall|  
|adx_ad_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_adx_ad_recurringappointmentmaster|  
|adx_ad_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_adx_ad_serviceappointment|  
|adx_ad_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_adx_ad_socialactivity|  
|adx_ad_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_ad|  
|adx_ad_Tasks|[task EntityType](task.md)|regardingobjectid_adx_ad_task|  
|adx_adplacement_ad|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_ad|  

## Operations
The following operations can be used with the adx_ad entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_ad entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|    

[!INCLUDE[./remarks/adx_ad.md](./remarks/adx_ad.md)]

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