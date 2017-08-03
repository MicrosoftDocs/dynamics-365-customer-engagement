---
title: "Microsoft Dynamics 365 Customer Engagement entitlementtemplate EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 98fa7459-450b-418b-83b6-9441b4470a3c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API entitlementtemplate entitytype."
---
# entitlementtemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/entitlementtemplate.md](./descriptions/entitlementtemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]entitlementtemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Entitlement Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>entitlementtemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The entitlementtemplate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|allocationtypecode|Edm.Int32|**Display Name**: Allocation Type<br />**Description**: Select whether the entitlement allocation is based on number of cases or number of hours.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Number of cases</td></tr><tr><td>1</td><td>Number of hours</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|decreaseremainingon|Edm.Int32|**Display Name**: Decrease Remaining On<br />**Description**: Information about whether to decrease the remaining terms when the case is created or when it is resolved<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Case Resolution</td></tr><tr><td>1</td><td>Case Creation</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the account, such as an excerpt from the company's website.<br />|
|enddate|Edm.DateTimeOffset|**Display Name**: End Date<br />**Description**: Enter the date and time when the entitlement ends.<br />|
|entitlementtemplateid|Edm.Guid|**Display Name**: Entitlement Template<br />**Description**: Unique identifier for entity instances<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the contact with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|kbaccesslevel|Edm.Int32|**Display Name**: KB Access Level<br />**Description**: Select the access someone will have to the knowledge base on the portal.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Standard</td></tr><tr><td>1</td><td>Premium</td></tr><tr><td>2</td><td>None</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Entitlement Template Name<br />**Description**: Type a descriptive name for the entitlement template.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|restrictcasecreation|Edm.Boolean|**Display Name**: Restrict By Entitlement Terms<br />**Description**: Tells whether case creation is restricted based on entitlement terms.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|startdate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Enter the date and time when the entitlement begins.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|totalterms|Edm.Decimal|**Display Name**: Total Terms<br />**Description**: Type the total number of entitlement terms.<br />|
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
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_slaid_value|slaid<br />|Choose the service level agreement (SLA) associated with the entitlement.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the contact.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_entitlementtemplate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_entitlementtemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_entitlementtemplate_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_entitlementtemplate_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|entitlementtemplate_organization|
|slaid|[sla EntityType](sla.md)|sla_entitlementtemplate|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_entitlementtemplate|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|entitlementtemplate_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_entitlementtemplate|  
|entitlementtemplate_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_entitlementtemplate_adx_alertsubscription|  
|entitlementtemplate_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_entitlementtemplate_adx_inviteredemption|  
|entitlementtemplate_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_entitlementtemplate_adx_portalcomment|  
|entitlementtemplate_Annotations|[annotation EntityType](annotation.md)|objectid_entitlementtemplate|  
|entitlementtemplate_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_entitlementtemplate_appointment|  
|entitlementtemplate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_entitlementtemplate|  
|entitlementtemplate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_entitlementtemplate|  
|entitlementtemplate_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_entitlementtemplate|  
|entitlementtemplate_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_entitlementtemplate|  
|entitlementtemplate_Emails|[email EntityType](email.md)|regardingobjectid_entitlementtemplate_email|  
|entitlementtemplate_entitlementchannel_entitlementtemplateid|[entitlementtemplatechannel EntityType](entitlementtemplatechannel.md)|entitlementtemplateid|  
|entitlementtemplate_Faxes|[fax EntityType](fax.md)|regardingobjectid_entitlementtemplate_fax|  
|entitlementtemplate_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_entitlementtemplate_incidentresolution|  
|entitlementtemplate_Letters|[letter EntityType](letter.md)|regardingobjectid_entitlementtemplate_letter|  
|entitlementtemplate_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_entitlementtemplate_msdyn_approval|  
|entitlementtemplate_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_entitlementtemplate_msdyn_bookingalert|  
|entitlementtemplate_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_entitlementtemplate_msdyn_surveyinvite|  
|entitlementtemplate_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_entitlementtemplate_opportunityclose|  
|entitlementtemplate_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_entitlementtemplate_orderclose|  
|entitlementtemplate_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_entitlementtemplate_phonecall|  
|entitlementtemplate_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_entitlementtemplate_quoteclose|  
|entitlementtemplate_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_entitlementtemplate_recurringappointmentmaster|  
|entitlementtemplate_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_entitlementtemplate_serviceappointment|  
|entitlementtemplate_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_entitlementtemplate_socialactivity|  
|EntitlementTemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_entitlementtemplate_syncerror|  
|entitlementtemplate_Tasks|[task EntityType](task.md)|regardingobjectid_entitlementtemplate_task|  
|entitlementtemplateid_RelationShip|[entitlement EntityType](entitlement.md)|entitlementtemplateid|  
|product_entitlementtemplate_association|[product EntityType](product.md)|product_entitlementtemplate_association|  

## Solutions
The following solutions include the entitlementtemplate entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/entitlementtemplate.md](./remarks/entitlementtemplate.md)]

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