---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_venue EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f9421634-2521-4aec-aeda-329465efcb6d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_venue entitytype."
---
# msevtmgt_venue EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_venue.md](./descriptions/msevtmgt_venue.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msevtmgt_venues </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Venue</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_venueid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_venue entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_accessibletoilets|Edm.Int32|**Display Name**: Accessible Toilets<br />**Description**: There are accessible toilets or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_additionalfacilities|Edm.String|**Display Name**: Additional Facilities<br />**Description**: Some additional facilities which is not covered by available options.<br />|
|msevtmgt_addresscomposite|Edm.String|**Display Name**: Address Composite<br />Computed<br />Read-only<br />|
|msevtmgt_addressline1|Edm.String|**Display Name**: Address Line 1<br />**Description**: Address (except of city, country/region, state or province and postal code).<br />|
|msevtmgt_addressline2|Edm.String|**Display Name**: Address Line 2<br />**Description**: Additional address details.<br />|
|msevtmgt_addressline3|Edm.String|**Display Name**: Address Line 3<br />**Description**: Additional address details.<br />|
|msevtmgt_city|Edm.String|**Display Name**: City<br />**Description**: City part of address info.<br />|
|msevtmgt_cost|Edm.Decimal|**Display Name**: Cost<br />**Description**: Cost of the venue.<br />|
|msevtmgt_cost_base|Edm.Decimal|**Display Name**: Cost (Base)<br />**Description**: Value of the Cost in base currency.<br />Read-only<br />|
|msevtmgt_country|Edm.String|**Display Name**: Country/Region<br />**Description**: Country/Region part of address info.<br />|
|msevtmgt_description|Edm.String|**Display Name**: Description<br />**Description**: Description of the venue.<br />|
|msevtmgt_disabledaccess|Edm.Int32|**Display Name**: Disabled Access<br />**Description**: There is disabled access or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_disabledparking|Edm.Int32|**Display Name**: Disable parking<br />**Description**: There is disabled parking or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_email|Edm.String|**Display Name**: Email<br />**Description**: Email. Part of the venue contact information.<br />|
|msevtmgt_estcapacity|Edm.Int32|**Display Name**: Est. Capacity<br />**Description**: Estimated capacity of the venue.<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_postalcode|Edm.String|**Display Name**: Postal Code<br />**Description**: Postal code part of address info.<br />|
|msevtmgt_publictelephoneavailable|Edm.Int32|**Display Name**: Public Telephone Available<br />**Description**: There is available public telephone or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_stateprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or province part of address info.<br />|
|msevtmgt_telephone1|Edm.String|**Display Name**: Telephone1<br />**Description**: Telephone 1. Part of the venue contact information.<br />|
|msevtmgt_telephone2|Edm.String|**Display Name**: Telephone2<br />**Description**: Telephone 2. Part of the venue contact information.<br />|
|msevtmgt_telephone3|Edm.String|**Display Name**: Telephone3<br />**Description**: Telephone 3. Part of the venue contact information.<br />|
|msevtmgt_venueid|Edm.Guid|**Display Name**: Venue<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_website|Edm.String|**Display Name**: Website<br />**Description**: Website. Part of the venue contact information.<br />|
|msevtmgt_wifiavailable|Edm.Int32|**Display Name**: Wifi Available<br />**Description**: There is available wifi or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_wifipassword|Edm.String|**Display Name**: Wifi Password<br />**Description**: Wifi password.<br />|
|msevtmgt_wifissid|Edm.String|**Display Name**: Wifi SSID<br />**Description**: SSID of Wifi<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Venue<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Venue<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_buildingid_value|msevtmgt_BuildingId<br />|Unique identifier for Building associated with Venue.|
|_msevtmgt_parentvenueid_value|msevtmgt_ParentVenueId<br />|Unique identifier for Venue associated with Venue.|
|_msevtmgt_primarycontact_value|msevtmgt_PrimaryContact<br />|A person who is responsible for the venue.|
|_msevtmgt_roomid_value|msevtmgt_RoomId<br />|Unique identifier for Room associated with Venue.|
|_msevtmgt_transactioncurrencyid_value||Unique identifier of the currency associated with the entity.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_venue_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_venue_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_venue_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_venue_modifiedonbehalfby|
|msevtmgt_BuildingId|[msevtmgt_building EntityType](msevtmgt_building.md)|msevtmgt_msevtmgt_building_msevtmgt_venue|
|msevtmgt_ParentVenueId|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_msevtmgt_venue_msevtmgt_venue|
|msevtmgt_PrimaryContact|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_venue_PrimaryContact|
|msevtmgt_RoomId|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_msevtmgt_room_msevtmgt_venue|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_venue|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_venue|
|owningteam|[team EntityType](team.md)|team_msevtmgt_venue|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_venue|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msevtmgt_Venue|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_msevtmgt_venue_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_ParentVenueId|  
|msevtmgt_venue_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_venue|  
|msevtmgt_venue_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_venue_adx_alertsubscription|  
|msevtmgt_venue_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_venue_adx_inviteredemption|  
|msevtmgt_venue_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_venue_adx_portalcomment|  
|msevtmgt_venue_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_venue|  
|msevtmgt_venue_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_venue_appointment|  
|msevtmgt_venue_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_venue|  
|msevtmgt_venue_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_venue|  
|msevtmgt_venue_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_venue_email|  
|msevtmgt_venue_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_venue_fax|  
|msevtmgt_venue_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_venue_letter|  
|msevtmgt_venue_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_venue_msdyn_approval|  
|msevtmgt_venue_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_venue_msdyn_bookingalert|  
|msevtmgt_venue_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_venue_msdyn_surveyinvite|  
|msevtmgt_venue_msevtmgt_event_PrimaryVenue|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_PrimaryVenue|  
|msevtmgt_Venue_msevtmgt_Session_Venue|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_Venue|  
|msevtmgt_venue_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_venue_phonecall|  
|msevtmgt_venue_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_venue_recurringappointmentmaster|  
|msevtmgt_venue_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_venue_serviceappointment|  
|msevtmgt_venue_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_venue_socialactivity|  
|msevtmgt_venue_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_venue|  
|msevtmgt_venue_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_venue_task|  

## Operations
The following operations can be used with the msevtmgt_venue entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_venue entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_venue.md](./remarks/msevtmgt_venue.md)]

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