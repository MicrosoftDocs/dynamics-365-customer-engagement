---
title: "Microsoft Dynamics 365 Customer Engagement site EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d7588eae-c24f-480b-87a3-6c340b4d1d93
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API site entitytype."
---
# site EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/site.md](./descriptions/site.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]sites </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Site</td></tr>
<tr><td><b>Primary Key:</b></td><td>siteid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The site entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|address1_addressid|Edm.Guid|**Display Name**: Address 1: ID<br />**Description**: Unique identifier for address 1.<br />|
|address1_addresstypecode|Edm.Int32|**Display Name**: Address 1: Address Type<br />**Description**: Type of address for address 1, such as billing, shipping, or primary address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_city|Edm.String|**Display Name**: City<br />**Description**: City name for address 1.<br />|
|address1_country|Edm.String|**Display Name**: Country/Region<br />**Description**: Country/region name for address 1.<br />|
|address1_county|Edm.String|**Display Name**: Address 1: County<br />**Description**: County name for address 1.<br />|
|address1_fax|Edm.String|**Display Name**: Fax<br />**Description**: Fax number for address 1.<br />|
|address1_latitude|Edm.Double|**Display Name**: Address 1: Latitude<br />**Description**: Latitude for address 1.<br />|
|address1_line1|Edm.String|**Display Name**: Street 1<br />**Description**: First line for entering address 1 information.<br />|
|address1_line2|Edm.String|**Display Name**: Street 2<br />**Description**: Second line for entering address 1 information.<br />|
|address1_line3|Edm.String|**Display Name**: Street 3<br />**Description**: Third line for entering address 1 information.<br />|
|address1_longitude|Edm.Double|**Display Name**: Address 1: Longitude<br />**Description**: Longitude for address 1.<br />|
|address1_name|Edm.String|**Display Name**: Address 1: Name<br />**Description**: Name to enter for address 1.<br />|
|address1_postalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: ZIP Code or postal code for address 1.<br />|
|address1_postofficebox|Edm.String|**Display Name**: Address 1: Post Office Box<br />**Description**: Post office box number for address 1.<br />|
|address1_shippingmethodcode|Edm.Int32|**Display Name**: Address 1: Shipping Method<br />**Description**: Method of shipment for address 1.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or province for address 1.<br />|
|address1_telephone1|Edm.String|**Display Name**: Main Phone<br />**Description**: First telephone number associated with address 1.<br />|
|address1_telephone2|Edm.String|**Display Name**: Other Phone<br />**Description**: Second telephone number associated with address 1.<br />|
|address1_telephone3|Edm.String|**Display Name**: Address 1: Telephone 3<br />**Description**: Third telephone number associated with address 1.<br />|
|address1_upszone|Edm.String|**Display Name**: Address 1: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for address 1.<br />|
|address1_utcoffset|Edm.Int32|**Display Name**: Address 1: UTC Offset<br />**Description**: UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.<br />|
|address2_addressid|Edm.Guid|**Display Name**: Address 2: ID<br />**Description**: Unique identifier for address 2.<br />|
|address2_addresstypecode|Edm.Int32|**Display Name**: Address 2: Address Type<br />**Description**: Type of address for address 2, such as billing, shipping, or primary address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_city|Edm.String|**Display Name**: Address 2: City<br />**Description**: City name for address 2.<br />|
|address2_country|Edm.String|**Display Name**: Address 2: Country/Region<br />**Description**: Country/region name for address 2.<br />|
|address2_county|Edm.String|**Display Name**: Address 2: County<br />**Description**: County name for address 2.<br />|
|address2_fax|Edm.String|**Display Name**: Address 2: Fax<br />**Description**: Fax number for address 2.<br />|
|address2_latitude|Edm.Double|**Display Name**: Address 2: Latitude<br />**Description**: Latitude for address 2.<br />|
|address2_line1|Edm.String|**Display Name**: Address 2: Street 1<br />**Description**: First line for entering address 2 information.<br />|
|address2_line2|Edm.String|**Display Name**: Address 2: Street 2<br />**Description**: Second line for entering address 2 information.<br />|
|address2_line3|Edm.String|**Display Name**: Address 2: Street 3<br />**Description**: Third line for entering address 2 information.<br />|
|address2_longitude|Edm.Double|**Display Name**: Address 2: Longitude<br />**Description**: Longitude for address 2.<br />|
|address2_name|Edm.String|**Display Name**: Address 2: Name<br />**Description**: Name to enter for address 2.<br />|
|address2_postalcode|Edm.String|**Display Name**: Address 2: ZIP/Postal Code<br />**Description**: ZIP Code or postal code for address 2.<br />|
|address2_postofficebox|Edm.String|**Display Name**: Address 2: Post Office Box<br />**Description**: Post office box number for address 2.<br />|
|address2_shippingmethodcode|Edm.Int32|**Display Name**: Address 2: Shipping Method<br />**Description**: Method of shipment for address 2.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_stateorprovince|Edm.String|**Display Name**: Address 2: State/Province<br />**Description**: State or province for address 2.<br />|
|address2_telephone1|Edm.String|**Display Name**: Address 2: Telephone 1<br />**Description**: First telephone number associated with address 2.<br />|
|address2_telephone2|Edm.String|**Display Name**: Address 2: Telephone 2<br />**Description**: Second telephone number associated with address 2.<br />|
|address2_telephone3|Edm.String|**Display Name**: Address 2: Telephone 3<br />**Description**: Third telephone number associated with address 2.<br />|
|address2_upszone|Edm.String|**Display Name**: Address 2: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for address 2.<br />|
|address2_utcoffset|Edm.Int32|**Display Name**: Address 2: UTC Offset<br />**Description**: UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the site was created.<br />Read-only<br />|
|emailaddress|Edm.String|**Display Name**: Email<br />**Description**: Email address for the site.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the site was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the site.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|siteid|Edm.Guid|**Display Name**: Site<br />**Description**: Unique identifier of the site.<br />|
|timezonecode|Edm.Int32|**Display Name**: Time Zone<br />**Description**: Local time zone for the site.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the site.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the site.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the site.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the site.|
|_organizationid_value|organizationid_organization<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_sitebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_site_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_sitebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_site_modifiedonbehalfby|
|organizationid_organization|[organization EntityType](organization.md)|organization_sites|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|site_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_site|  
|site_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_site_adx_alertsubscription|  
|site_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_site_adx_inviteredemption|  
|site_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_site_adx_portalcomment|  
|site_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_site_appointment|  
|Site_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_site|  
|Site_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_site|  
|site_Emails|[email EntityType](email.md)|regardingobjectid_site_email|  
|site_equipment|[equipment EntityType](equipment.md)|siteid|  
|site_Faxes|[fax EntityType](fax.md)|regardingobjectid_site_fax|  
|site_Letters|[letter EntityType](letter.md)|regardingobjectid_site_letter|  
|site_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_site_msdyn_approval|  
|site_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_site_msdyn_bookingalert|  
|site_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_site_msdyn_surveyinvite|  
|site_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_site_opportunityclose|  
|site_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_site_orderclose|  
|site_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_site_phonecall|  
|site_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_site_quoteclose|  
|site_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_site_recurringappointmentmaster|  
|site_resources|[resource EntityType](resource.md)|siteid|  
|site_service_appointments|[serviceappointment EntityType](serviceappointment.md)|siteid|  
|site_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_site_serviceappointment|  
|site_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_site_socialactivity|  
|Site_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_site_syncerror|  
|site_system_users|[systemuser EntityType](systemuser.md)|siteid|  
|site_Tasks|[task EntityType](task.md)|regardingobjectid_site_task|  

## Solutions
The following solutions include the site entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/site.md](./remarks/site.md)]

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