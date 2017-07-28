---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_projecttask EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c9f2193d-fb23-467e-82ca-085de1759f49
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_projecttask entitytype."
---
# msdyn_projecttask EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_projecttask.md](./descriptions/msdyn_projecttask.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_projecttasks </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Project Task</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_projecttaskid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_subject</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the project task was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_actualcost|Edm.Decimal|**Display Name**: Actual Cost<br />**Description**: Enter the value of the actual cost consumed based on work reported to be completed on the task. <br />|
|msdyn_actualcost_base|Edm.Decimal|**Display Name**: Actual Cost (Base)<br />**Description**: Value of the Actual Cost in base currency.<br />Read-only<br />|
|msdyn_actualdurationminutes|Edm.Int32|**Display Name**: Actual Duration<br />**Description**: Shows the actual duration of the project task in days<br />|
|msdyn_actualeffort|Edm.Double|**Display Name**: Actual Hours<br />**Description**: Shows the hours submitted against the task.<br />|
|msdyn_actualend|Edm.DateTimeOffset|**Display Name**: Actual End Date/Time<br />**Description**: Enter the actual end time of the project task.<br />|
|msdyn_actualsales|Edm.Decimal|**Display Name**: Actual Sales<br />**Description**: Actual Sales Amount<br />|
|msdyn_actualsales_base|Edm.Decimal|**Display Name**: Actual Sales (Base)<br />**Description**: Shows the value of the actual sales in the base currency.<br />Read-only<br />|
|msdyn_actualstart|Edm.DateTimeOffset|**Display Name**: Actual Start<br />**Description**: Enter the actual start time of the project task.<br />|
|msdyn_aggregationdirection|Edm.Int32|**Display Name**: Aggregation Direction<br />**Description**: Shows whether the aggregation is happening upstream or downstream.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Upstream</td></tr><tr><td>1</td><td>Downstream</td></tr><tr><td>2</td><td>Both</td></tr><tbody></table>|
|msdyn_assignedresources|Edm.String|**Display Name**: Assigned Resources<br />**Description**: Type the project team members that are assigned to task.<br />|
|msdyn_autoscheduling|Edm.Boolean|**Display Name**: Auto Scheduling<br />**Description**: Shows whether auto scheduling was used for this task.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_costatcompleteestimate|Edm.Decimal|**Display Name**: Cost estimate at complete (EAC)<br />**Description**: Enter the forecast of the total cost to complete the task.<br />Computed<br />Read-only<br />|
|msdyn_costatcompleteestimate_base|Edm.Decimal|**Display Name**: Cost estimate at completion (EAC) (Base)<br />**Description**: Value of the Cost estimate at complete (EAC) in base currency.<br />Computed<br />Read-only<br />|
|msdyn_costconsumptionpercentage|Edm.Decimal|**Display Name**: Cost Consumption %<br />**Description**: Enter the consumption of the total cost in percentage.<br />Computed<br />Read-only<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Enter a description of the project task.<br />|
|msdyn_duration|Edm.Double|**Display Name**: Duration<br />**Description**: Shows the duration in days for the task.<br />|
|msdyn_effort|Edm.Double|**Display Name**: Estimated Effort<br />**Description**: Shows the effort hours required for the task.<br />|
|msdyn_effortestimateatcomplete|Edm.Double|**Display Name**: Effort estimate at complete (EAC)<br />**Description**: Shows the forecast of total effort to complete the task.<br />|
|msdyn_islinetask|Edm.Boolean|**Display Name**: IsLineTask<br />**Description**: Shows whether the task is a line task<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_ismilestone|Edm.Boolean|**Display Name**: Is Milestone<br />**Description**: Show whether this task is a milestone.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_msprojectclientid|Edm.String|**Display Name**: MS Project Client Id<br />**Description**: The id of the project task in MS Project Client.<br />|
|msdyn_numberofresources|Edm.Int32|**Display Name**: Number of resources<br />**Description**: Shows the number of resources that are estimated for the task. This is not the number of resources assigned to the task.<br />|
|msdyn_plannedcost|Edm.Decimal|**Display Name**: Planned cost<br />**Description**: Enter the value of the cost the service provider will incur based on the estimated work and cost rates in the pricelist.<br />|
|msdyn_plannedcost_base|Edm.Decimal|**Display Name**: Estimated cost<br />**Description**: Enter the value of cost estimated in base currency.<br />Read-only<br />|
|msdyn_plannedsales|Edm.Decimal|**Display Name**: Planned Sales<br />**Description**: Planned Sales Amount<br />|
|msdyn_plannedsales_base|Edm.Decimal|**Display Name**: Planned Sales (Base)<br />**Description**: Shows the value of the planned sales in the base currency.<br />Read-only<br />|
|msdyn_progress|Edm.Decimal|**Display Name**: Progress %<br />**Description**: Enter the percentage indicating work completed.<br />|
|msdyn_projecttaskid|Edm.Guid|**Display Name**: Project task<br />**Description**: Shows the entity instances.<br />|
|msdyn_remainingcost|Edm.Decimal|**Display Name**: Remaining Cost<br />**Description**: Enter the cost left over that can be consumed for future work.<br />|
|msdyn_remainingcost_base|Edm.Decimal|**Display Name**: Remaining Cost (Base)<br />**Description**: Shows the value of the remaining cost in the  base currency.<br />Read-only<br />|
|msdyn_remaininghours|Edm.Double|**Display Name**: Remaining Hours<br />**Description**: Shows the hours remaining to complete the task.<br />|
|msdyn_remainingsales|Edm.Decimal|**Display Name**: Remaining Sales<br />**Description**: Remaining Sales Amount<br />|
|msdyn_remainingsales_base|Edm.Decimal|**Display Name**: Remaining Sales (Base)<br />**Description**: Shows the value of the remaining sales in the base currency.<br />Read-only<br />|
|msdyn_requestedhours|Edm.Double|**Display Name**: Requested Hours<br />**Description**: Shows the hours assigned by generic resource.<br />|
|msdyn_resourceutilization|Edm.Decimal|**Display Name**: ResourceUtilization<br />**Description**: Shows the utilization units for a resource that is assigned to a project task<br />|
|msdyn_salesconsumptionpercentage|Edm.Decimal|**Display Name**: Sales Consumption %<br />**Description**: Shows the sales consumption percentage for this task.<br />Computed<br />Read-only<br />|
|msdyn_salesestimateatcomplete|Edm.Decimal|**Display Name**: Sales Estimate At Complete (EAC)<br />**Description**: Shows the sales estimate at the completion of this task.<br />Computed<br />Read-only<br />|
|msdyn_salesestimateatcomplete_base|Edm.Decimal|**Display Name**: Sales Estimate At Complete (EAC) (Base)<br />**Description**: Value of the Sales Estimate At Complete (EAC) in base currency.<br />Computed<br />Read-only<br />|
|msdyn_salesvariance|Edm.Decimal|**Display Name**: Sales Variance<br />**Description**: Shows the sales variance for this task.<br />Computed<br />Read-only<br />|
|msdyn_salesvariance_base|Edm.Decimal|**Display Name**: Sales Variance (Base)<br />**Description**: Shows the value of the sales variance in the base currency.<br />Computed<br />Read-only<br />|
|msdyn_scheduleddurationminutes|Edm.Int32|**Display Name**: Scheduled Duration<br />**Description**: Shows the scheduled duration of the project task, specified in minutes.<br />|
|msdyn_scheduledend|Edm.DateTimeOffset|**Display Name**: Due Date<br />**Description**: Enter the scheduled end time of the project.<br />|
|msdyn_scheduledhours|Edm.Double|**Display Name**: Scheduled Hours<br />**Description**: Shows the scheduled hours for the task.<br />|
|msdyn_scheduledstart|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Enter the scheduled start time of the project task.<br />|
|msdyn_schedulevariance|Edm.Double|**Display Name**: Schedule Variance<br />**Description**: Shows the variance between the estimated work and the forecasted work based on the estimate at completion (EAC).<br />|
|msdyn_skipupdateestimateline|Edm.Boolean|**Display Name**: Skip Update Estimate Line<br />**Description**: Internal flag to avoid the update process on the estimate lines of the project task<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_subject|Edm.String|**Display Name**: Project Task Name<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_varianceofcost|Edm.Decimal|**Display Name**: Cost Variance<br />**Description**: Enter the variance between the estimated cost and the forecasted cost based on the estimate at completion (EAC).<br />Computed<br />Read-only<br />|
|msdyn_varianceofcost_base|Edm.Decimal|**Display Name**: Cost Variance (Base)<br />**Description**: Shows the value of the cost variance in the base currency.<br />Computed<br />Read-only<br />|
|msdyn_wbsid|Edm.String|**Display Name**: WBS ID<br />**Description**: Shows the ID of the task in the work breakdown structure (WBS).<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Unique identifier of the Stage.<br />|
|statecode|Edm.Int32|**Display Name**: Project Task Status<br />**Description**: Status of the Project Task<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Project Task<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of user who last modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_assignedteammembers_value|msdyn_AssignedTeamMembers<br />|Select the project team member that has been assigned to a task.|
|_msdyn_parenttask_value|msdyn_parenttask<br />|Select the summary or parent task in the hierarchy that contains a child task.|
|_msdyn_project_value|msdyn_project<br />|Select the project name.|
|_msdyn_resourcecategory_value|msdyn_resourcecategory<br />|Select the resource role for the task.|
|_msdyn_resourceorganizationalunitid_value|msdyn_ResourceOrganizationalUnitId<br />|Select the organizational unit of the resource who should perform the work.|
|_msdyn_transactioncategory_value|msdyn_transactioncategory<br />|Select the transaction category for the task.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_projecttask_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projecttask_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_projecttask_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projecttask_modifiedonbehalfby|
|msdyn_AssignedTeamMembers|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_msdyn_projectteam_msdyn_projecttask_AssignedTeamMembers|
|msdyn_parenttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_msdyn_projecttask_msdyn_projecttask_parenttask|
|msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_projecttask_project|
|msdyn_resourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory|
|msdyn_ResourceOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_projecttask|
|msdyn_transactioncategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_projecttask|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_projecttask|
|owningteam|[team EntityType](team.md)|team_msdyn_projecttask|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_projecttask|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_projecttask|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_projecttask_msdyn_actual_Task|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_Task|  
|msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_projecttask|  
|msdyn_msdyn_projecttask_msdyn_estimateline_Task|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_Task|  
|msdyn_msdyn_projecttask_msdyn_fact_Task|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_Task|  
|msdyn_msdyn_projecttask_msdyn_invoicelinetransaction_Task|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_Task|  
|msdyn_msdyn_projecttask_msdyn_journalline_Task|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_Task|  
|msdyn_msdyn_projecttask_msdyn_opportunitylinetransaction_Task|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_Task|  
|msdyn_msdyn_projecttask_msdyn_orderlinetransaction_Task|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_Task|  
|msdyn_msdyn_projecttask_msdyn_projectapproval_ProjectTask|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_ProjectTask|  
|msdyn_msdyn_projecttask_msdyn_projecttask_parenttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_parenttask|  
|msdyn_msdyn_projecttask_msdyn_projecttaskdependency_PredecessorTask|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_PredecessorTask|  
|msdyn_msdyn_projecttask_msdyn_projecttaskdependency_SuccessorTask|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_SuccessorTask|  
|msdyn_msdyn_projecttask_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|msdyn_projecttaskId|  
|msdyn_msdyn_projecttask_msdyn_quotelinescheduleofvalue_projecttask|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|msdyn_projecttask|  
|msdyn_msdyn_projecttask_msdyn_quotelinetransaction_Task|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_Task|  
|msdyn_msdyn_projecttask_msdyn_resourceassignment_taskid|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|msdyn_taskid|  
|msdyn_msdyn_projecttask_msdyn_timeentry_projectTask|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_projectTask|  
|msdyn_projecttask_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_projecttask|  
|msdyn_projecttask_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_projecttask|  
|msdyn_projecttask_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_projecttask|  
|msdyn_projecttask_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_projecttask|  
|msdyn_projecttask_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_projecttask|  
|msdyn_projecttask_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_projecttask|  
|msdyn_projecttask_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_projecttask|  

## Operations
The following operations can be used with the msdyn_projecttask entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_BulkCreatePredecessorsForTask Action](../actions/msdyn_bulkcreatepredecessorsfortask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_bulkcreatepredecessorsfortask.md](../actions/descriptions/msdyn_bulkcreatepredecessorsfortask.md)]|  
|[msdyn_BulkDeletePredecessorsForTask Action](../actions/msdyn_bulkdeletepredecessorsfortask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_bulkdeletepredecessorsfortask.md](../actions/descriptions/msdyn_bulkdeletepredecessorsfortask.md)]|  
|[msdyn_CreateEstimatesForProjectTask Action](../actions/msdyn_createestimatesforprojecttask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createestimatesforprojecttask.md](../actions/descriptions/msdyn_createestimatesforprojecttask.md)]|  
|[msdyn_DeleteEstimatesForProjectTask Action](../actions/msdyn_deleteestimatesforprojecttask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_deleteestimatesforprojecttask.md](../actions/descriptions/msdyn_deleteestimatesforprojecttask.md)]|  
|[msdyn_IndentWBSTask Action](../actions/msdyn_indentwbstask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_indentwbstask.md](../actions/descriptions/msdyn_indentwbstask.md)]|  
|[msdyn_MoveDownWBSTask Action](../actions/msdyn_movedownwbstask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_movedownwbstask.md](../actions/descriptions/msdyn_movedownwbstask.md)]|  
|[msdyn_MoveUpWBSTask Action](../actions/msdyn_moveupwbstask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_moveupwbstask.md](../actions/descriptions/msdyn_moveupwbstask.md)]|  
|[msdyn_OutdentWBSTask Action](../actions/msdyn_outdentwbstask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_outdentwbstask.md](../actions/descriptions/msdyn_outdentwbstask.md)]|  
|[msdyn_ResAssignResourcesForTask Action](../actions/msdyn_resassignresourcesfortask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_resassignresourcesfortask.md](../actions/descriptions/msdyn_resassignresourcesfortask.md)]|  
|[msdyn_SaveProjectLineTasks Action](../actions/msdyn_saveprojectlinetasks.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_saveprojectlinetasks.md](../actions/descriptions/msdyn_saveprojectlinetasks.md)]|  
|[msdyn_updateprojecttask Action](../actions/msdyn_updateprojecttask.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_updateprojecttask.md](../actions/descriptions/msdyn_updateprojecttask.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_projecttask entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_projecttask.md](./remarks/msdyn_projecttask.md)]

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