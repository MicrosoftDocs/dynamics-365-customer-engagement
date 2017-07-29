---
title: "Microsoft Dynamics 365 Customer Engagement knowledgebaserecord EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2ae1d3c8-9ae4-4a35-a0c0-3acdcd31b340
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API knowledgebaserecord entitytype."
---
# knowledgebaserecord EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/knowledgebaserecord.md](./descriptions/knowledgebaserecord.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]knowledgebaserecords </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Knowledge Base Record</td></tr>
<tr><td><b>Primary Key:</b></td><td>knowledgebaserecordid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The knowledgebaserecord entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the knowledge base record with respect to the base currency.<br />Read-only<br />|
|knowledgebaserecordid|Edm.Guid|**Display Name**: ID<br />**Description**: This field will be used to store the Unique ID of the associated Knowledge Base records<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|privateurl|Edm.String|**Display Name**: Private URL<br />**Description**: Shows the internal Parature service desk URL of the knowledge base records.<br />|
|publicurl|Edm.String|**Display Name**: Public URL<br />**Description**: Shows the public Parature portal URL of the knowledge base records.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: KB Record Title<br />**Description**: Shows the title of the knowledge base (KB) Record.<br />|
|uniqueid|Edm.String|**Display Name**: Unique ID<br />**Description**: Shows the unique ID of the linked knowledge base (KB) article.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the Knowledge Base Record with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_KnowledgeBaseRecord_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_KnowledgeBaseRecord_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_KnowledgeBaseRecord_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_KnowledgeBaseRecord_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_KnowledgeBaseRecord|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_KnowledgeBaseRecord|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|KnowledgeBaseRecord_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_knowledgebaserecord|  
|knowledgebaserecord_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_knowledgebaserecord_adx_alertsubscription|  
|knowledgebaserecord_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_knowledgebaserecord_adx_inviteredemption|  
|knowledgebaserecord_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_knowledgebaserecord_adx_portalcomment|  
|KnowledgeBaseRecord_Annotations|[annotation EntityType](annotation.md)|objectid_knowledgebaserecord|  
|KnowledgeBaseRecord_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_knowledgebaserecord_appointment|  
|KnowledgeBaseRecord_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_knowledgebaserecord|  
|KnowledgeBaseRecord_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_knowledgebaserecord|  
|knowledgebaserecord_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_knowledgebaserecord_bulkoperation|  
|knowledgebaserecord_CampaignActivities|[campaignactivity EntityType](campaignactivity.md)|regardingobjectid_knowledgebaserecord_campaignactivity|  
|knowledgebaserecord_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_knowledgebaserecord_campaignresponse|  
|KnowledgeBaseRecord_connections1|[connection EntityType](connection.md)|record1id_knowledgebaserecord|  
|KnowledgeBaseRecord_connections2|[connection EntityType](connection.md)|record2id_knowledgebaserecord|  
|KnowledgeBaseRecord_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_knowledgebaserecord|  
|KnowledgeBaseRecord_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_knowledgebaserecord|  
|KnowledgeBaseRecord_Emails|[email EntityType](email.md)|regardingobjectid_knowledgebaserecord_email|  
|KnowledgeBaseRecord_Faxes|[fax EntityType](fax.md)|regardingobjectid_knowledgebaserecord_fax|  
|KnowledgeBaseRecord_Incident|[incident EntityType](incident.md)|KnowledgeBaseRecord_Incident|  
|knowledgebaserecord_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_knowledgebaserecord_incidentresolution|  
|KnowledgeBaseRecord_Letters|[letter EntityType](letter.md)|regardingobjectid_knowledgebaserecord_letter|  
|knowledgebaserecord_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_knowledgebaserecord_msdyn_approval|  
|knowledgebaserecord_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_knowledgebaserecord_msdyn_bookingalert|  
|knowledgebaserecord_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_knowledgebaserecord_msdyn_surveyinvite|  
|knowledgebaserecord_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_knowledgebaserecord_opportunityclose|  
|knowledgebaserecord_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_knowledgebaserecord_orderclose|  
|KnowledgeBaseRecord_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_knowledgebaserecord_phonecall|  
|knowledgebaserecord_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_knowledgebaserecord_quoteclose|  
|KnowledgeBaseRecord_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_knowledgebaserecord_recurringappointmentmaster|  
|KnowledgeBaseRecord_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_knowledgebaserecord_serviceappointment|  
|KnowledgeBaseRecord_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_knowledgebaserecord_socialactivity|  
|KnowledgeBaseRecord_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_knowledgebaserecord_syncerror|  
|KnowledgeBaseRecord_Tasks|[task EntityType](task.md)|regardingobjectid_knowledgebaserecord_task|  

## Operations
The following operations can be used with the knowledgebaserecord entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the knowledgebaserecord entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/knowledgebaserecord.md](./remarks/knowledgebaserecord.md)]

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