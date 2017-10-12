---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_eventpurchase EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 71ad0fe0-a56a-4c73-bb9c-150d9231bd4f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_eventpurchase entitytype."
---
# msevtmgt_eventpurchase EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_eventpurchase.md](./descriptions/msevtmgt_eventpurchase.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msevtmgt_eventpurchases </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Event Purchase</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_eventpurchaseid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_eventpurchase entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_area|Edm.Int32|**Display Name**: Area<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Administration</td></tr><tr><td>100000001</td><td>Customer Service</td></tr><tr><td>100000002</td><td>Executive/Management</td></tr><tr><td>100000003</td><td>Logistics</td></tr><tr><td>100000004</td><td>Finance</td></tr><tr><td>100000005</td><td>HR</td></tr><tr><td>100000006</td><td>IT</td></tr><tr><td>100000007</td><td>Legal</td></tr><tr><td>100000008</td><td>Marketing</td></tr><tr><td>100000009</td><td>Sales</td></tr><tbody></table>|
|msevtmgt_companysize|Edm.Int32|**Display Name**: Company Size<br />**Description**: The size of the company<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>50 or less</td></tr><tr><td>100000001</td><td>51 to 100</td></tr><tr><td>100000002</td><td>101 to 250</td></tr><tr><td>100000003</td><td>251 to 500</td></tr><tr><td>100000004</td><td>501 to 1000</td></tr><tr><td>100000005</td><td>1001 to 2500</td></tr><tr><td>100000006</td><td>2501 to 5000</td></tr><tr><td>100000007</td><td>5001 to 10000</td></tr><tr><td>100000008</td><td>10001 or more</td></tr><tbody></table>|
|msevtmgt_eventpurchaseid|Edm.Guid|**Display Name**: Event Purchase<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_industry|Edm.Int32|**Display Name**: Industry<br />**Description**: The industry of the company of attendee<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Architecture and Engineering</td></tr><tr><td>100000001</td><td>Financial Services</td></tr><tr><td>100000002</td><td>Manufacturing</td></tr><tr><td>100000003</td><td>Media, Entertainment</td></tr><tr><td>100000004</td><td>Professional Services</td></tr><tr><td>100000005</td><td>Public Sector</td></tr><tr><td>100000006</td><td>Retail</td></tr><tr><td>100000007</td><td>Wholesale and Distribution</td></tr><tr><td>100000008</td><td>Other</td></tr><tbody></table>|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_paid|Edm.Boolean|**Display Name**: Paid<br />**Description**: The payment for the purchased have been processed already<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msevtmgt_processed|Edm.Boolean|**Display Name**: Processed<br />**Description**: The purchase was properly converted to Event Management entities<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msevtmgt_yearsinindustry|Edm.Int32|**Display Name**: Years In Industry<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Under 1 year</td></tr><tr><td>100000001</td><td>1 to 5 year</td></tr><tr><td>100000002</td><td>5 to 10 years</td></tr><tr><td>100000003</td><td>Over 10 years</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Event Purchase<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Event Purchase<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_eventid_value|msevtmgt_EventId<br />|The event purchases are made for|
|_msevtmgt_purchasingcontactid_value|msevtmgt_PurchasingContactId<br />|The contact making the purchase|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventpurchase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventpurchase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventpurchase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_eventpurchase_modifiedonbehalfby|
|msevtmgt_EventId|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_msevtmgt_event_msevtmgt_eventpurchase|
|msevtmgt_PurchasingContactId|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_eventpurchase|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_eventpurchase|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_eventpurchase|
|owningteam|[team EntityType](team.md)|team_msevtmgt_eventpurchase|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_eventpurchase|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_eventpurchase_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msevtmgt_eventpurchase|  
|msevtmgt_eventpurchase_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msevtmgt_eventpurchase_adx_alertsubscription|  
|msevtmgt_eventpurchase_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msevtmgt_eventpurchase_adx_inviteredemption|  
|msevtmgt_eventpurchase_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msevtmgt_eventpurchase_adx_portalcomment|  
|msevtmgt_eventpurchase_Annotations|[annotation EntityType](annotation.md)|objectid_msevtmgt_eventpurchase|  
|msevtmgt_eventpurchase_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msevtmgt_eventpurchase_appointment|  
|msevtmgt_eventpurchase_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_eventpurchase|  
|msevtmgt_eventpurchase_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_eventpurchase|  
|msevtmgt_eventpurchase_Emails|[email EntityType](email.md)|regardingobjectid_msevtmgt_eventpurchase_email|  
|msevtmgt_eventpurchase_Faxes|[fax EntityType](fax.md)|regardingobjectid_msevtmgt_eventpurchase_fax|  
|msevtmgt_eventpurchase_Letters|[letter EntityType](letter.md)|regardingobjectid_msevtmgt_eventpurchase_letter|  
|msevtmgt_eventpurchase_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msevtmgt_eventpurchase_msdyn_approval|  
|msevtmgt_eventpurchase_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msevtmgt_eventpurchase_msdyn_bookingalert|  
|msevtmgt_eventpurchase_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msevtmgt_eventpurchase_msdyn_surveyinvite|  
|msevtmgt_eventpurchase_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msevtmgt_eventpurchase_phonecall|  
|msevtmgt_eventpurchase_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msevtmgt_eventpurchase_recurringappointmentmaster|  
|msevtmgt_eventpurchase_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msevtmgt_eventpurchase_serviceappointment|  
|msevtmgt_eventpurchase_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msevtmgt_eventpurchase_socialactivity|  
|msevtmgt_eventpurchase_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_eventpurchase|  
|msevtmgt_eventpurchase_Tasks|[task EntityType](task.md)|regardingobjectid_msevtmgt_eventpurchase_task|  
|msevtmgt_msevtmgt_eventpurchase_msevtmgt_eventpurc|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_PurchaseId|  

## Operations
The following operations can be used with the msevtmgt_eventpurchase entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_eventpurchase entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|  
|[Event Portal Base Solution](../solutions/eventportallink.md)|[!INCLUDE[../solutions/descriptions/eventportallink.md](../solutions/descriptions/eventportallink.md)]|    

[!INCLUDE[./remarks/msevtmgt_eventpurchase.md](./remarks/msevtmgt_eventpurchase.md)]

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