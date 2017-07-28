---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_project EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 97a77818-946e-49ee-a5e6-b9166327a14d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_project entitytype."
---
# msdyn_project EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_project.md](./descriptions/msdyn_project.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_projects </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Project</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_projectid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_subject</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_actualdurationminutes|Edm.Int32|**Display Name**: Actual Duration<br />**Description**: Shows the actual duration of the project in minutes.<br />|
|msdyn_actualend|Edm.DateTimeOffset|**Display Name**: Actual End<br />**Description**: Enter the actual end time of the project.<br />|
|msdyn_actualhours|Edm.Decimal|**Display Name**: Actual Hours<br />**Description**: Shows the total actual hours of the project<br />|
|msdyn_actualsales|Edm.Decimal|**Display Name**: Actual Sales<br />**Description**: Shows the actual sales value.<br />|
|msdyn_actualsales_base|Edm.Decimal|**Display Name**: Actual Sales (Base)<br />**Description**: Shows the value of the actual sales in the base currency.<br />Read-only<br />|
|msdyn_actualstart|Edm.DateTimeOffset|**Display Name**: Actual Start<br />**Description**: Enter the actual start time of the project.<br />|
|msdyn_bulkgenerationstatus|Edm.Int32|**Display Name**: Bulk Generation Status<br />**Description**: The status of the bulk generation operations running on the project entity. If no operation is running, the value is null.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Processing</td></tr><tr><td>192350001</td><td>Failed</td></tr><tbody></table>|
|msdyn_calendarid|Edm.String|**Display Name**: Calendar Id<br />**Description**: Id of the calendar for the project.<br />|
|msdyn_comments|Edm.String|**Display Name**: Comments<br />**Description**: Enter the comments that are used to describe the current project status.<br />|
|msdyn_costconsumption|Edm.Decimal|**Display Name**: Cost Consumption %<br />**Description**: Shows the actual cost divided by the estimated cost at completion.<br />Computed<br />Read-only<br />|
|msdyn_costestimateatcomplete|Edm.Decimal|**Display Name**: Cost estimate at completion (EAC)<br />**Description**: Sum of Actual Cost and Remaining cost<br />Computed<br />Read-only<br />|
|msdyn_costestimateatcomplete_base|Edm.Decimal|**Display Name**: Cost estimate at completion (EAC)(Base)<br />**Description**: Value of the Cost estimate at completion (EAC) in base currency.<br />Computed<br />Read-only<br />|
|msdyn_costperformence|Edm.Int32|**Display Name**: Cost Performance<br />Computed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>On Budget</td></tr><tr><td>192350001</td><td>Over Budget</td></tr><tr><td>192350002</td><td>Under Budget</td></tr><tbody></table>|
|msdyn_costvariance|Edm.Decimal|**Display Name**: Cost Variance<br />**Description**: Variance between the estimated cost and the forecasted cost based on the estimate at completion (EAC).<br />Computed<br />Read-only<br />|
|msdyn_costvariance_base|Edm.Decimal|**Display Name**: Cost Variance (Base)<br />**Description**: Shows the value of the cost variance in the base currency.<br />Computed<br />Read-only<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Enter a description of the project.<br />|
|msdyn_disablecreateofteammemberformanager|Edm.Boolean|**Display Name**: Disable create of team member for project manager<br />**Description**: This is an internal field, mainly used during import so that we don't create a team member record for the project manager.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_effortestimateatcompleteeac|Edm.Double|**Display Name**: Effort estimate at complete (EAC)<br />**Description**: Shows the total of actual hours and the remaining hours.<br />|
|msdyn_exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the project with respect to the base currency.<br />|
|msdyn_islinkedtomsprojectclient|Edm.Boolean|**Display Name**: Is Linked To MS Project Client<br />**Description**: Specifies if the project is linked to a project in MS Project<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_istemplate|Edm.Boolean|**Display Name**: Is Template<br />**Description**: Shows if the project is a project template.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_linkeddocumenturl|Edm.String|**Display Name**: Linked Document URL<br />**Description**: The URL for the linked document.<br />|
|msdyn_overallprojectstatus|Edm.Int32|**Display Name**: Overall Project Status<br />**Description**: Describes the project status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Green</td></tr><tr><td>2</td><td>Yellow</td></tr><tr><td>3</td><td>Red</td></tr><tbody></table>|
|msdyn_plannedhours|Edm.Decimal|**Display Name**: Estimated Hours<br />**Description**: Shows the total estimate hours of the project.<br />|
|msdyn_plannedsales|Edm.Decimal|**Display Name**: Planned Sales<br />**Description**: Shows the total planned sales.<br />|
|msdyn_plannedsales_base|Edm.Decimal|**Display Name**: Planned Sales (Base)<br />**Description**: Shows the value of the planned sales in the base currency.<br />Read-only<br />|
|msdyn_progress|Edm.Decimal|**Display Name**: Progress %<br />**Description**: Shows the actual hours divided by effort at estimate.<br />|
|msdyn_projectid|Edm.Guid|**Display Name**: Project<br />**Description**: Shows the entity instances.<br />|
|msdyn_projectresourcerequirementsvisibletore|Edm.Boolean|**Display Name**: Project resource requirements visible to resources<br />**Description**: Indicates if the project resource requirements are visible to the resources assigned to the project.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_remainingcost|Edm.Decimal|**Display Name**: Remaining Cost<br />**Description**: Shows the difference between the estimated cost and the actual cost.<br />|
|msdyn_remainingcost_base|Edm.Decimal|**Display Name**: Remaining Cost (Base)<br />**Description**: Shows the value of the remaining cost in the  base currency.<br />Read-only<br />|
|msdyn_remaininghours|Edm.Double|**Display Name**: Remaining Hours<br />**Description**: Shows the difference between the estimate at completion (EAC) and the actual hours.<br />|
|msdyn_remainingsales|Edm.Decimal|**Display Name**: Remaining Sales<br />**Description**: Shows the difference between estimated sales and the actual sales.<br />|
|msdyn_remainingsales_base|Edm.Decimal|**Display Name**: Remaining Sales (Base)<br />**Description**: Shows the value of the remaining sales in the base currency.<br />Read-only<br />|
|msdyn_salesconsumption|Edm.Decimal|**Display Name**: Sales Consumption %<br />**Description**: Shows the actual sales divided by the estimated sales.<br />Computed<br />Read-only<br />|
|msdyn_salesestimateatcompleteeac|Edm.Decimal|**Display Name**: Sales Estimate At Complete (EAC)<br />**Description**: Shows the total of actual and remaining sales.<br />Computed<br />Read-only<br />|
|msdyn_salesestimateatcompleteeac_base|Edm.Decimal|**Display Name**: Sales Estimate At Complete (EAC) (Base)<br />**Description**: Value of the Sales Estimate At Complete (EAC) in base currency.<br />Computed<br />Read-only<br />|
|msdyn_salesvariance|Edm.Decimal|**Display Name**: Sales Variance<br />**Description**: Shows the difference between the planned sales and the sales estimate at completion (EAC).<br />Computed<br />Read-only<br />|
|msdyn_salesvariance_base|Edm.Decimal|**Display Name**: Sales Variance (Base)<br />**Description**: Shows the value of the sales variance in the base currency.<br />Computed<br />Read-only<br />|
|msdyn_scheduleddurationminutes|Edm.Int32|**Display Name**: Scheduled Duration<br />**Description**: Shows the scheduled duration of the project, specified in minutes.<br />|
|msdyn_scheduledend|Edm.DateTimeOffset|**Display Name**: Estimated Finish Date<br />**Description**: Enter the scheduled end time of the project.<br />|
|msdyn_scheduledstart|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Enter the scheduled start time of the project.<br />|
|msdyn_scheduleperformance|Edm.Int32|**Display Name**: Schedule Performance<br />**Description**: Describes the schedule performance of the project.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>On Time</td></tr><tr><td>192350001</td><td>Ahead</td></tr><tr><td>192350002</td><td>Behind</td></tr><tbody></table>|
|msdyn_schedulevariance|Edm.Double|**Display Name**: Schedule Variance<br />**Description**: Shows the difference between the planned effort and the estimate at completion (EAC).<br />|
|msdyn_stagename|Edm.String|**Display Name**: Stage Name<br />**Description**: Shows the stage of the project.<br />|
|msdyn_statusupdatedon|Edm.DateTimeOffset|**Display Name**: Status Updated On<br />**Description**: Shows the most recent update on a status field(comments or overall project status).<br />|
|msdyn_subject|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_teamsize|Edm.Int32|**Display Name**: Team Size<br />**Description**: Shows the total number of team members assigned to this project<br />Computed<br />Read-only<br />|
|msdyn_teamsize_date|Edm.DateTimeOffset|**Display Name**: Team Size (Last Updated On)<br />**Description**: Last Updated time of rollup field Team Size.<br />Read-only<br />|
|msdyn_teamsize_state|Edm.Int32|**Display Name**: Team Size (State)<br />**Description**: State of rollup field Team Size.<br />Read-only<br />|
|msdyn_totalactualcost|Edm.Decimal|**Display Name**: Actual Cost<br />**Description**: Shows the aggregated cost from actuals on the project.<br />|
|msdyn_totalactualcost_base|Edm.Decimal|**Display Name**: Total Actual Cost (Base)<br />**Description**: Shows the value of the total actual cost in the base currency.<br />Read-only<br />|
|msdyn_totalplannedcost|Edm.Decimal|**Display Name**: Estimated Cost<br />**Description**: Shows the aggregate of the total planned cost of all the associated tasks.<br />|
|msdyn_totalplannedcost_base|Edm.Decimal|**Display Name**: Total Planned Cost (Base)<br />**Description**: Shows the value of the total planned cost in the base currency.<br />Read-only<br />|
|msdyn_wbsduration|Edm.Int32|**Display Name**: Duration<br />**Description**: Shows the work breakdown structure (WBS) duration in days.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Project Status<br />**Description**: Status of the Project<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Project<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_contractorganizationalunitid_value|msdyn_ContractOrganizationalUnitId<br />|Select the organizational unit sponsoring the project.|
|_msdyn_customer_value|msdyn_customer<br />|Enter the customer who the project is associated with.|
|_msdyn_projectmanager_value|msdyn_projectmanager<br />|Shows the project manager assigned to the project.|
|_msdyn_projectteamid_value|msdyn_projectteamid<br />|Select the Team associated with Project.|
|_msdyn_projecttemplate_value|msdyn_ProjectTemplate<br />|Select the project template behind the project.|
|_msdyn_salesorderid_value|msdyn_salesorderid<br />|Shows the contract for this project.|
|_msdyn_workhourtemplate_value|msdyn_workhourtemplate<br />|Select the work hour template used to create the project calendar.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the id of the stage where the entity is located.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_project_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_project_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_project_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_project_modifiedonbehalfby|
|msdyn_ContractOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_project|
|msdyn_customer|[account EntityType](account.md)|msdyn_account_msdyn_project_Customer|
|msdyn_projectmanager|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_project_projectmanager|
|msdyn_projectteamid|[team EntityType](team.md)|msdyn_team_msdyn_project_projectteamid|
|msdyn_ProjectTemplate|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_project_ProjectTemplate|
|msdyn_salesorderid|[salesorder EntityType](salesorder.md)|msdyn_salesorder_msdyn_project_salesorderid|
|msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_msdyn_workhourtemplate_msdyn_project_workhourtemplate|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_project|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_project|
|owningteam|[team EntityType](team.md)|team_msdyn_project|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_project|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_project|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_project|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_project_bookableresourcebooking_projectid|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_projectid|  
|msdyn_msdyn_project_bookableresourcebookingheader_projectid|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|msdyn_projectid|  
|msdyn_msdyn_project_invoicedetail_Project|[invoicedetail EntityType](invoicedetail.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_actual_Project|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_project|  
|msdyn_msdyn_project_msdyn_estimate_Project|[msdyn_estimate EntityType](msdyn_estimate.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_estimateline_Project|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_expense_Project|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_fact_Project|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_invoicelinetransaction_Project|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_journal_DefaultProject|[msdyn_journal EntityType](msdyn_journal.md)|msdyn_DefaultProject|  
|msdyn_msdyn_project_msdyn_journalline_Project|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_opportunitylinetransaction_Project|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_orderlinetransaction_Project|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_project_ProjectTemplate|[msdyn_project EntityType](msdyn_project.md)|msdyn_ProjectTemplate|  
|msdyn_msdyn_project_msdyn_projectapproval_Project|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_projectpricelist_Project|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_projecttask_project|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_project|  
|msdyn_msdyn_project_msdyn_projecttaskdependency_Project|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_projectteam_project|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_project|  
|msdyn_msdyn_project_msdyn_projecttransactioncategory_Project|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_quotelinetransaction_Project|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_Project|  
|msdyn_msdyn_project_msdyn_resourceassignment_projectid|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|msdyn_projectid|  
|msdyn_msdyn_project_msdyn_timeentry_project|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_project|  
|msdyn_msdyn_project_opportunityproduct_Project|[opportunityproduct EntityType](opportunityproduct.md)|msdyn_Project|  
|msdyn_msdyn_project_quotedetail_Project|[quotedetail EntityType](quotedetail.md)|msdyn_Project|  
|msdyn_msdyn_project_salesorderdetail_Project|[salesorderdetail EntityType](salesorderdetail.md)|msdyn_Project|  
|msdyn_project_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_project|  
|msdyn_project_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_project|  
|msdyn_project_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_project|  
|msdyn_project_connections1|[connection EntityType](connection.md)|record1id_msdyn_project|  
|msdyn_project_connections2|[connection EntityType](connection.md)|record2id_msdyn_project|  
|msdyn_project_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_project|  
|msdyn_project_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_project|  
|msdyn_project_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_project|  
|msdyn_project_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_projectid|  
|msdyn_project_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_project|  
|msdyn_project_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_project|  

## Operations
The following operations can be used with the msdyn_project entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_AutoGenerateProjectTeam Action](../actions/msdyn_autogenerateprojectteam.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_autogenerateprojectteam.md](../actions/descriptions/msdyn_autogenerateprojectteam.md)]|  
|[msdyn_CopyProject Action](../actions/msdyn_copyproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_copyproject.md](../actions/descriptions/msdyn_copyproject.md)]|  
|[msdyn_CopyRelatedProjectEntitiesFromTemplate Action](../actions/msdyn_copyrelatedprojectentitiesfromtemplate.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_copyrelatedprojectentitiesfromtemplate.md](../actions/descriptions/msdyn_copyrelatedprojectentitiesfromtemplate.md)]|  
|[msdyn_CopyWbsToProject Action](../actions/msdyn_copywbstoproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_copywbstoproject.md](../actions/descriptions/msdyn_copywbstoproject.md)]|  
|[msdyn_CreateTaskBasedEstimatesForProject Action](../actions/msdyn_createtaskbasedestimatesforproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createtaskbasedestimatesforproject.md](../actions/descriptions/msdyn_createtaskbasedestimatesforproject.md)]|  
|[msdyn_CreateTemplateFromProject Action](../actions/msdyn_createtemplatefromproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createtemplatefromproject.md](../actions/descriptions/msdyn_createtemplatefromproject.md)]|  
|[msdyn_FetchProjectCalendarWorkHours Action](../actions/msdyn_fetchprojectcalendarworkhours.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_fetchprojectcalendarworkhours.md](../actions/descriptions/msdyn_fetchprojectcalendarworkhours.md)]|  
|[msdyn_GetProjectCurrencies Action](../actions/msdyn_getprojectcurrencies.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_getprojectcurrencies.md](../actions/descriptions/msdyn_getprojectcurrencies.md)]|  
|[msdyn_JoinProjectTeam Action](../actions/msdyn_joinprojectteam.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_joinprojectteam.md](../actions/descriptions/msdyn_joinprojectteam.md)]|  
|[msdyn_MoveProject Action](../actions/msdyn_moveproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_moveproject.md](../actions/descriptions/msdyn_moveproject.md)]|  
|[msdyn_MSProject_ExportToProject Action](../actions/msdyn_msproject_exporttoproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_msproject_exporttoproject.md](../actions/descriptions/msdyn_msproject_exporttoproject.md)]|  
|[msdyn_MSProject_LinkToProject Action](../actions/msdyn_msproject_linktoproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_msproject_linktoproject.md](../actions/descriptions/msdyn_msproject_linktoproject.md)]|  
|[msdyn_MSProject_PublishToExistingProject Action](../actions/msdyn_msproject_publishtoexistingproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_msproject_publishtoexistingproject.md](../actions/descriptions/msdyn_msproject_publishtoexistingproject.md)]|  
|[msdyn_MSProject_ReadFromExistingProject Action](../actions/msdyn_msproject_readfromexistingproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_msproject_readfromexistingproject.md](../actions/descriptions/msdyn_msproject_readfromexistingproject.md)]|  
|[msdyn_MSProject_UnlinkFromProject Action](../actions/msdyn_msproject_unlinkfromproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_msproject_unlinkfromproject.md](../actions/descriptions/msdyn_msproject_unlinkfromproject.md)]|  
|[msdyn_UpdateAllEstimatesForProject Action](../actions/msdyn_updateallestimatesforproject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_updateallestimatesforproject.md](../actions/descriptions/msdyn_updateallestimatesforproject.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_project entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_project.md](./remarks/msdyn_project.md)]

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