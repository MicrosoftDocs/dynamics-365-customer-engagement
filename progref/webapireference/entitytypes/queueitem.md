---
title: "Microsoft Dynamics 365 Customer Engagement queueitem EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bdb8e12f-1f2d-40ce-8a80-ed6efd71edd2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API queueitem entitytype."
---
# queueitem EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/queueitem.md](./descriptions/queueitem.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]queueitems </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Queue Item</td></tr>
<tr><td><b>Primary Key:</b></td><td>queueitemid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|enteredon|Edm.DateTimeOffset|**Display Name**: Entered Queue<br />**Description**: Shows the date the record was assigned to the queue.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|objecttypecode|Edm.Int32|**Display Name**: Type<br />**Description**: Select the type of the queue item, such as activity, case, or appointment.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|queueitemid|Edm.Guid|**Display Name**: Queue Item<br />**Description**: Unique identifier of the queue item.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the queue record is active or inactive. Inactive queue records are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the item's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>2</td><td>Inactive</td></tr><tr><td>1</td><td>Active</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Shows the title or name that describes the queue record. This value is copied from the record that was assigned to the queue.<br />Read-only<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the queue item.<br />Read-only<br />|
|workeridmodifiedon|Edm.DateTimeOffset|**Display Name**: Worked On<br />**Description**: Shows the date and time when the queue item was last assigned to a user.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the queueitem.|
|_objectid_value|objectid_incident<br />objectid_msdyn_timegroup<br />objectid_msdyn_timegroupdetail<br />objectid_msdyn_agreementbookingdate<br />objectid_msdyn_agreementbookingsetup<br />objectid_msdyn_agreementinvoicedate<br />objectid_msdyn_agreementinvoicesetup<br />objectid_msdyn_inventoryadjustment<br />objectid_msdyn_inventorytransfer<br />objectid_msdyn_workorder<br />objectid_msdyn_workorderincident<br />objectid_msdyn_workorderservice<br />objectid_msdyn_workorderservicetask<br />objectid_msdyn_iotalert<br />objectid_msdyn_project<br />objectid_msdyn_projecttask<br />objectid_msdyn_resourcerequest<br />objectid_msdyncrm_appointmentactivitymarketingtemplate<br />objectid_msdyncrm_mktactivity<br />objectid_msdyncrm_phonecallactivitymarketingtemplate<br />objectid_msdyncrm_taskactivitymarketingtemplate<br />objectid_msdyn_surveyresponse<br />objectid_knowledgearticle<br />objectid_activitypointer<br />|Choose the activity, case, or article assigned to the queue.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the queue item is associated.|
|_ownerid_value||Unique identifier of the user or team who owns the queue item.|
|_owningbusinessunit_value||Unique identifier of the business unit that owns the queue item.|
|_owninguser_value||Unique identifier of the user who owns the queue item.|
|_queueid_value|queueid<br />|Choose the queue that the item is assigned to.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|_workerid_value|workerid_systemuser<br />workerid_team<br />|Shows who is working on the queue item.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_queueitembase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_queueitem_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_queueitembase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_queueitem_modifiedonbehalfby|
|objectid_activitypointer|[activitypointer EntityType](activitypointer.md)|ActivityPointer_QueueItem|
|objectid_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_QueueItems|
|objectid_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_QueueItems|
|objectid_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|adx_portalcomment_QueueItems|
|objectid_appointment|[appointment EntityType](appointment.md)|Appointment_QueueItem|
|objectid_bulkoperation|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_QueueItem|
|objectid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_QueueItem|
|objectid_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|CampaignResponse_QueueItem|
|objectid_email|[email EntityType](email.md)|Email_QueueItem|
|objectid_fax|[fax EntityType](fax.md)|Fax_QueueItem|
|objectid_incident|[incident EntityType](incident.md)|Incident_QueueItem|
|objectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_QueueItems|
|objectid_letter|[letter EntityType](letter.md)|Letter_QueueItem|
|objectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_QueueItems|
|objectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_QueueItems|
|objectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_QueueItems|
|objectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_QueueItems|
|objectid_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_QueueItems|
|objectid_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_QueueItems|
|objectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_QueueItems|
|objectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_QueueItems|
|objectid_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_iotalert_QueueItems|
|objectid_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_QueueItems|
|objectid_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_projecttask_QueueItems|
|objectid_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_resourcerequest_QueueItems|
|objectid_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_QueueItems|
|objectid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_QueueItems|
|objectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_QueueItems|
|objectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_QueueItems|
|objectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_QueueItems|
|objectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_QueueItems|
|objectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_QueueItems|
|objectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_QueueItems|
|objectid_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_QueueItems|
|objectid_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_QueueItems|
|objectid_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_QueueItems|
|objectid_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_QueueItems|
|objectid_phonecall|[phonecall EntityType](phonecall.md)|PhoneCall_QueueItem|
|objectid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|RecurringAppointmentMaster_QueueItem|
|objectid_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|ServiceAppointment_QueueItem|
|objectid_socialactivity|[socialactivity EntityType](socialactivity.md)|SocialActivity_QueueItem|
|objectid_task|[task EntityType](task.md)|Task_QueueItem|
|organizationid|[organization EntityType](organization.md)|organization_queueitems|
|queueid|[queue EntityType](queue.md)|queue_entries|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_QueueItem|
|workerid_systemuser|[systemuser EntityType](systemuser.md)|lk_queueitembase_workerid|
|workerid_team|[team EntityType](team.md)|team_queueitembase_workerid|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|QueueItem_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_queueitem|  
|QueueItem_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_queueitem|  
|QueueItem_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_queueitem_syncerror|  

## Operations
The following operations can be used with the queueitem entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddToQueue Action](../actions/addtoqueue.md)|Not Bound|[!INCLUDE[../actions/descriptions/addtoqueue.md](../actions/descriptions/addtoqueue.md)]|  
|[PickFromQueue Action](../actions/pickfromqueue.md)|Entity|[!INCLUDE[../actions/descriptions/pickfromqueue.md](../actions/descriptions/pickfromqueue.md)]|  
|[ReleaseToQueue Action](../actions/releasetoqueue.md)|Entity|[!INCLUDE[../actions/descriptions/releasetoqueue.md](../actions/descriptions/releasetoqueue.md)]|  
|[RemoveFromQueue Action](../actions/removefromqueue.md)|Entity|[!INCLUDE[../actions/descriptions/removefromqueue.md](../actions/descriptions/removefromqueue.md)]|  
|[RouteTo Action](../actions/routeto.md)|Not Bound|[!INCLUDE[../actions/descriptions/routeto.md](../actions/descriptions/routeto.md)]|  

## Solutions
The following solutions include the queueitem entity type.


|Name|Description |  
|----|------------|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|    

[!INCLUDE[./remarks/queueitem.md](./remarks/queueitem.md)]

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