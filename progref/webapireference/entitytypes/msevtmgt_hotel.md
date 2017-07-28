---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_hotel EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7189b83b-9ca5-4d25-b45f-3e30a34a696d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_hotel entitytype."
---
# msevtmgt_hotel EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_hotel.md](./descriptions/msevtmgt_hotel.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msevtmgt_hotels </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Hotel</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_hotelid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_hotel entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_addressline1|Edm.String|**Display Name**: Address Line 1<br />|
|msevtmgt_addressline2|Edm.String|**Display Name**: Address Line 2<br />|
|msevtmgt_addressline3|Edm.String|**Display Name**: Address Line 3<br />|
|msevtmgt_city|Edm.String|**Display Name**: City<br />**Description**: City where the hotel is located<br />|
|msevtmgt_country|Edm.String|**Display Name**: Country/Region<br />**Description**: Country/Region where the hotel is located<br />|
|msevtmgt_description|Edm.String|**Display Name**: Description<br />**Description**: Hotel description<br />|
|msevtmgt_facilities|Edm.String|**Display Name**: Facilities<br />**Description**: Hotel facilities<br />|
|msevtmgt_hotelid|Edm.Guid|**Display Name**: Hotel<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the hotel.<br />|
|msevtmgt_stateprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or Province where the hotel is located<br />|
|msevtmgt_website|Edm.String|**Display Name**: Website<br />**Description**: Hotel website<br />|
|msevtmgt_zippostalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: Hotel ZIP postal code<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Hotel<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Hotel<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_hotelgroup_value|msevtmgt_HotelGroup<br />||
|_msevtmgt_primarycontact_value|msevtmgt_PrimaryContact<br />|Hotel primary contact|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotel_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotel_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotel_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_hotel_modifiedonbehalfby|
|msevtmgt_HotelGroup|[msevtmgt_eventvendor EntityType](msevtmgt_eventvendor.md)|msevtmgt_msevtmgt_eventvendor_msevtmgt_hotel_HotelGroup|
|msevtmgt_PrimaryContact|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_hotel_PrimaryContact|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_hotel|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_hotel|
|owningteam|[team EntityType](team.md)|team_msevtmgt_hotel|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_hotel|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_hotel_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_hotel|  
|msevtmgt_hotel_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_hotel_adx_alertsubscription|  
|msevtmgt_hotel_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_hotel_adx_inviteredemption|  
|msevtmgt_hotel_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_hotel_adx_portalcomment|  
|msevtmgt_hotel_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_hotel|  
|msevtmgt_hotel_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_hotel_appointment|  
|msevtmgt_hotel_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_hotel|  
|msevtmgt_hotel_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_hotel|  
|msevtmgt_hotel_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_hotel_email|  
|msevtmgt_hotel_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_hotel_fax|  
|msevtmgt_hotel_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_hotel_letter|  
|msevtmgt_hotel_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_hotel_msdyn_approval|  
|msevtmgt_hotel_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_hotel_msdyn_bookingalert|  
|msevtmgt_hotel_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_hotel_msdyn_surveyinvite|  
|msevtmgt_hotel_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_hotel_phonecall|  
|msevtmgt_hotel_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_hotel_recurringappointmentmaster|  
|msevtmgt_hotel_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_hotel_serviceappointment|  
|msevtmgt_hotel_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_hotel_socialactivity|  
|msevtmgt_hotel_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_hotel|  
|msevtmgt_hotel_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_hotel_task|  
|msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_HotelProperty|  

## Operations
The following operations can be used with the msevtmgt_hotel entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_hotel entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_hotel.md](./remarks/msevtmgt_hotel.md)]

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