---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_layout EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6cf510c0-6705-46f2-8daf-7dc6143ba72e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_layout entitytype."
---
# msevtmgt_layout EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_layout.md](./descriptions/msevtmgt_layout.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_layouts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Layout</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_layoutid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_layout entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_capacity|Edm.Int32|**Display Name**: Capacity<br />**Description**: How many people is possible to locate here.<br />|
|msevtmgt_description|Edm.String|**Display Name**: Description<br />**Description**: Description of layout.<br />|
|msevtmgt_disabledaccess|Edm.Int32|**Display Name**: Disabled access<br />**Description**: There is disabled access or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_disabledcapacity|Edm.Int32|**Display Name**: Disabled capacity<br />**Description**: How many disabled is possible to locate here.<br />|
|msevtmgt_floorplan|Edm.Int32|**Display Name**: Floor Plan<br />**Description**: Standardized floor plan type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Theatre</td></tr><tr><td>100000001</td><td>Classroom</td></tr><tr><td>100000002</td><td>Herringbone</td></tr><tr><td>100000003</td><td>U Shape</td></tr><tr><td>100000004</td><td>Horse Shoe</td></tr><tr><td>100000005</td><td>Hollow Square</td></tr><tr><td>100000006</td><td>Boardroom</td></tr><tr><td>100000007</td><td>Banquet</td></tr><tr><td>100000008</td><td>Cabaret</td></tr><tr><td>100000009</td><td>Cocktail</td></tr><tr><td>100000010</td><td>Booth</td></tr><tbody></table>|
|msevtmgt_layoutid|Edm.Guid|**Display Name**: Layout<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_units|Edm.Int32|**Display Name**: Units<br />**Description**: Square units.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Sq. meters</td></tr><tr><td>100000001</td><td>Sq. feet</td></tr><tbody></table>|
|msevtmgt_usablearea|Edm.Int32|**Display Name**: Usable area<br />**Description**: Usable area (square units).<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Layout<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Layout<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_room_value|msevtmgt_Room<br />|Link to the room.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_layout_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_layout_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_layout_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_layout_modifiedonbehalfby|
|msevtmgt_Room|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_msevtmgt_layout_Room|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_layout|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_layout|
|owningteam|[team EntityType](team.md)|team_msevtmgt_layout|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_layout|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_layout_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_layout|  
|msevtmgt_layout_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_layout_adx_alertsubscription|  
|msevtmgt_layout_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_layout_adx_inviteredemption|  
|msevtmgt_layout_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_layout_adx_portalcomment|  
|msevtmgt_layout_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_layout|  
|msevtmgt_layout_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_layout_appointment|  
|msevtmgt_layout_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_layout|  
|msevtmgt_layout_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_layout|  
|msevtmgt_layout_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_layout_email|  
|msevtmgt_layout_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_layout_fax|  
|msevtmgt_layout_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_layout_letter|  
|msevtmgt_layout_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_layout_msdyn_approval|  
|msevtmgt_layout_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_layout_msdyn_bookingalert|  
|msevtmgt_layout_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_layout_msdyn_surveyinvite|  
|msevtmgt_layout_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_layout_phonecall|  
|msevtmgt_layout_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_layout_recurringappointmentmaster|  
|msevtmgt_layout_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_layout_serviceappointment|  
|msevtmgt_layout_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_layout_socialactivity|  
|msevtmgt_layout_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_layout|  
|msevtmgt_layout_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_layout_task|  

## Operations
The following operations can be used with the msevtmgt_layout entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_layout entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_layout.md](./remarks/msevtmgt_layout.md)]

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