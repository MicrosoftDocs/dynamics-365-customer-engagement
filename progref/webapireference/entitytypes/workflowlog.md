---
title: "Microsoft Dynamics 365 Customer Engagement workflowlog EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d30a875d-acbf-40e2-b968-5ba4789851bf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API workflowlog entitytype."
---
# workflowlog EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/workflowlog.md](./descriptions/workflowlog.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]workflowlogs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Process Log</td></tr>
<tr><td><b>Primary Key:</b></td><td>workflowlogid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The workflowlog EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activityname|Edm.String|**Display Name**: Activity Name<br />**Description**: Name of the activity which the process step is currently processing.<br />|
|completedon|Edm.DateTimeOffset|**Display Name**: Completed On<br />**Description**: Date and time when the operation was completed.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Started On<br />**Description**: Date and time when the process log entry was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Step Description<br />**Description**: Description of the process step.<br />|
|duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Duration between completed on and started on, used by business process flow.<br />Computed<br />Read-only<br />|
|errorcode|Edm.Int32|**Display Name**: Error Message<br />**Description**: Error code related to process.<br />|
|interactionactivityresult|Edm.String|**Display Name**: Interaction Activity Result<br />**Description**: String specifying the result of an interaction activity.<br />|
|message|Edm.String|**Display Name**: Message<br />**Description**: Message related to process.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the process log entry was last modified.<br />Read-only<br />|
|stagename|Edm.String|**Display Name**: Process Stage<br />**Description**: Name of the process stage.<br />|
|startedon|Edm.DateTimeOffset|**Display Name**: Started On<br />**Description**: Date and time when the operation was started.<br />|
|status|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the process step for which process log record has been created: In Progress, Successfully Completed, or Failed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>In Progress</td></tr><tr><td>2</td><td>Succeeded</td></tr><tr><td>3</td><td>Failed</td></tr><tr><td>4</td><td>Canceled</td></tr><tr><td>5</td><td>Waiting</td></tr><tbody></table>|
|stepname|Edm.String|**Display Name**: Step Name<br />**Description**: Name of the process step.<br />|
|workflowlogid|Edm.Guid|**Display Name**: Process Log<br />**Description**: Unique identifier of the process log entry.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_asyncoperationid_value|PhoneToCaseProcess_asyncoperationid<br />LeadToOpportunitySalesProcess_asyncoperationid<br />OpportunitySalesProcess_asyncoperationid<br />asyncoperationid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />asyncoperationid_msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />asyncoperationid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />asyncoperationid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39<br />asyncoperationid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />asyncoperationid_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d<br />asyncoperationid_msdyn_bpf_665e73aa18c247d886bfc50499c73b82<br />asyncoperationid_msdyncrm_leadtoopportunity<br />asyncoperationid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99<br />ExpiredProcess_asyncoperationid<br />TranslationProcess_asyncoperationid<br />asyncoperationid_asyncoperation<br />NewProcess_asyncoperationid<br />|Unique identifier of the parent record.|
|_childworkflowinstanceid_value|childworkflowinstanceid_asyncoperation<br />|Unique identifier of the system job.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the process log entry.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the process log.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the process log entry.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the process log.|
|_ownerid_value||Unique identifier of the user or team who owns the process log.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the process.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the process log.|
|_owninguser_value||Unique identifier of the user who owns the process.|
|_regardingobjectid_value||Unique identifier of the associated record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|asyncoperationid_asyncoperation|[asyncoperation EntityType](asyncoperation.md)|lk_workflowlog_asyncoperations|
|asyncoperationid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_WorkflowLogs|
|asyncoperationid_msdyncrm_leadtoopportunity|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|msdyncrm_leadtoopportunity_WorkflowLogs|
|asyncoperationid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99|[msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 EntityType](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md)|msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_WorkflowLogs|
|childworkflowinstanceid_asyncoperation|[asyncoperation EntityType](asyncoperation.md)|lk_workflowlog_asyncoperation_childworkflow|
|createdby|[systemuser EntityType](systemuser.md)|lk_workflowlog_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_workflowlog_createdonbehalfby|
|ExpiredProcess_asyncoperationid|[expiredprocess EntityType](expiredprocess.md)|workflowlogs_expiredprocess|
|LeadToOpportunitySalesProcess_asyncoperationid|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|workflowlogs_leadtoopportunitysalesprocess|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_workflowlog_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_workflowlog_modifiedonbehalfby|
|NewProcess_asyncoperationid|[newprocess EntityType](newprocess.md)|workflowlogs_newprocess|
|OpportunitySalesProcess_asyncoperationid|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|workflowlogs_opportunitysalesprocess|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_workflowlogs|
|owningteam|[team EntityType](team.md)|team_workflowlog|
|PhoneToCaseProcess_asyncoperationid|[phonetocaseprocess EntityType](phonetocaseprocess.md)|workflowlogs_phonetocaseprocess|
|TranslationProcess_asyncoperationid|[translationprocess EntityType](translationprocess.md)|workflowlogs_translationprocess|  

[!INCLUDE[./remarks/workflowlog.md](./remarks/workflowlog.md)]

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