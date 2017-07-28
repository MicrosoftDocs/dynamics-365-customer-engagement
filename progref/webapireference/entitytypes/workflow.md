---
title: "Microsoft Dynamics 365 Customer Engagement workflow EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7c5681b1-7ae7-428e-bbec-6a733a45bb34
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API workflow entitytype."
---
# workflow EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/workflow.md](./descriptions/workflow.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]workflows </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Process</td></tr>
<tr><td><b>Primary Key:</b></td><td>workflowid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|asyncautodelete|Edm.Boolean|**Display Name**: Delete Job On Completion<br />**Description**: Indicates whether the asynchronous system job is automatically deleted on completion.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|businessprocesstype|Edm.Int32|**Display Name**: Business Process Type<br />**Description**: Business Process Type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Business Flow</td></tr><tr><td>1</td><td>Task Flow</td></tr><tbody></table>|
|category|Edm.Int32|**Display Name**: Category<br />**Description**: Category of the process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Workflow</td></tr><tr><td>1</td><td>Dialog</td></tr><tr><td>2</td><td>Business Rule</td></tr><tr><td>3</td><td>Action</td></tr><tr><td>4</td><td>Business Process Flow</td></tr><tbody></table>|
|clientdata|Edm.String|**Display Name**: Client Data<br />**Description**: Business logic converted into client data<br />Read-only<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the process was created.<br />Read-only<br />|
|createstage|Edm.Int32|**Display Name**: Create Stage<br />**Description**: Stage of the process when triggered on Create.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>20</td><td>Pre-operation</td></tr><tr><td>40</td><td>Post-operation</td></tr><tbody></table>|
|deletestage|Edm.Int32|**Display Name**: Delete stage<br />**Description**: Stage of the process when triggered on Delete.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>20</td><td>Pre-operation</td></tr><tr><td>40</td><td>Post-operation</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the process.<br />|
|entityimage|Edm.Binary|**Display Name**: Default Image<br />**Description**: Shows the default image for the record.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|formid|Edm.Guid|**Display Name**: Form ID<br />**Description**: Unique identifier of the associated form.<br />|
|inputparameters|Edm.String|**Display Name**: Input Parameters<br />**Description**: Input parameters to the process.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscrmuiworkflow|Edm.Boolean|**Display Name**: Is CRM Process<br />**Description**: Indicates whether the process was created using the Microsoft Dynamics 365 Web application.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|istransacted|Edm.Boolean|**Display Name**: Is Transacted<br />**Description**: Whether or not the steps in the process are executed in a single transaction.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Language of the process.<br />|
|mode|Edm.Int32|**Display Name**: Mode<br />**Description**: Shows the mode of the process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Background</td></tr><tr><td>1</td><td>Real-time</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the process was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Process Name<br />**Description**: Name of the process.<br />|
|ondemand|Edm.Boolean|**Display Name**: Run as On Demand<br />**Description**: Indicates whether the process is able to run as an on-demand process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|primaryentity|Edm.String|**Display Name**: Primary Entity<br />**Description**: Primary entity for the process. The process can be associated for one or more SDK operations defined on the primary entity.<br />|
|processorder|Edm.Int32|**Display Name**: Process Order<br />**Description**: Type the business process flow order.<br />|
|processroleassignment|Edm.String|**Display Name**: Role assignment for Process<br />**Description**: Contains the role assignment for the process.<br />|
|rank|Edm.Int32|**Display Name**: Rank<br />**Description**: Indicates the rank for order of execution for the synchronous workflow.<br />|
|rendererobjecttypecode|Edm.String|**Display Name**: Renderer Type<br />**Description**: The renderer type of Workflow<br />|
|runas|Edm.Int32|**Display Name**: Run As User<br />**Description**: Specifies the system user account under which a workflow executes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Owner</td></tr><tr><td>1</td><td>Calling User</td></tr><tbody></table>|
|scope|Edm.Int32|**Display Name**: Scope<br />**Description**: Scope of the process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>User</td></tr><tr><td>2</td><td>Business Unit</td></tr><tr><td>3</td><td>Parent: Child Business Units</td></tr><tr><td>4</td><td>Organization</td></tr><tbody></table>|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Activated</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Additional information about status of the process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Draft</td></tr><tr><td>2</td><td>Activated</td></tr><tbody></table>|
|subprocess|Edm.Boolean|**Display Name**: Is Child Process<br />**Description**: Indicates whether the process can be included in other processes as a child process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|syncworkflowlogonfailure|Edm.Boolean|**Display Name**: Log upon Failure<br />**Description**: Select whether synchronous workflow failures will be saved to log files.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|triggeroncreate|Edm.Boolean|**Display Name**: Trigger On Create<br />**Description**: Indicates whether the process will be triggered when the primary entity is created.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|triggerondelete|Edm.Boolean|**Display Name**: Trigger On Delete<br />**Description**: Indicates whether the process will be triggered on deletion of the primary entity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|triggeronupdateattributelist|Edm.String|**Display Name**: Trigger On Update Attribute List<br />**Description**: Attributes that trigger the process when updated.<br />|
|type|Edm.Int32|**Display Name**: Type<br />**Description**: Type of the process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Definition</td></tr><tr><td>2</td><td>Activation</td></tr><tr><td>3</td><td>Template</td></tr><tbody></table>|
|uidata|Edm.String|**Display Name**: UI Data<br />**Description**: For internal use only.<br />Read-only<br />|
|uniquename|Edm.String|**Display Name**: Unique Name<br />**Description**: Unique name of the process<br />|
|updatestage|Edm.Int32|**Display Name**: Update Stage<br />**Description**: Select the stage a process will be triggered on update.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>20</td><td>Pre-operation</td></tr><tr><td>40</td><td>Post-operation</td></tr><tbody></table>|
|versionnumber|Edm.Int64|Read-only<br />|
|workflowid|Edm.Guid|**Display Name**: Process<br />**Description**: Unique identifier of the process.<br />|
|workflowidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|xaml|Edm.String|**Description**: XAML that defines the process.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_activeworkflowid_value|activeworkflowid<br />|Unique identifier of the latest activation record for the process.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the process.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the process.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the process.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the process.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the process.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the process.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the process.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the process.|
|_parentworkflowid_value|parentworkflowid<br />|Unique identifier of the definition for process activation.|
|_plugintypeid_value||Unique identifier of the plug-in type.|
|_sdkmessageid_value||Unique identifier of the SDK Message associated with this workflow.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|activeworkflowid|[workflow EntityType](workflow.md)|workflow_active_workflow|
|createdby|[systemuser EntityType](systemuser.md)|workflow_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|workflow_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|workflow_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|workflow_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_workflows|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_workflow|
|owningteam|[team EntityType](team.md)|team_workflow|
|owninguser|[systemuser EntityType](systemuser.md)|system_user_workflow|
|parentworkflowid|[workflow EntityType](workflow.md)|workflow_parent_workflow|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_invitation_redemptionworkflow|[adx_invitation EntityType](adx_invitation.md)|adx_redemptionWorkflow|  
|lk_asyncoperation_workflowactivationid|[asyncoperation EntityType](asyncoperation.md)|workflowactivationid|  
|lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_processid|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|processid|  
|lk_msdyncrm_leadtoopportunity_processid|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|processid|  
|lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_processid|[msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 EntityType](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md)|processid|  
|process_processstage|[processstage EntityType](processstage.md)|processid|  
|slabase_workflowid|[sla EntityType](sla.md)|workflowid|  
|slaitembase_workflowid|[slaitem EntityType](slaitem.md)|workflowid|  
|workflow_active_workflow|[workflow EntityType](workflow.md)|activeworkflowid|  
|Workflow_Annotation|[annotation EntityType](annotation.md)|objectid_workflow|  
|workflow_expiredprocess|[expiredprocess EntityType](expiredprocess.md)|processid|  
|workflow_leadtoopportunitysalesprocess|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|processid|  
|workflow_newprocess|[newprocess EntityType](newprocess.md)|processid|  
|workflow_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|processid|  
|workflow_parent_workflow|[workflow EntityType](workflow.md)|parentworkflowid|  
|workflow_phonetocaseprocess|[phonetocaseprocess EntityType](phonetocaseprocess.md)|processid|  
|Workflow_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_workflow_syncerror|  
|workflow_translationprocess|[translationprocess EntityType](translationprocess.md)|processid|  

## Operations
The following operations can be used with the workflow entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CreateWorkflowFromTemplate Action](../actions/createworkflowfromtemplate.md)|Not Bound|[!INCLUDE[../actions/descriptions/createworkflowfromtemplate.md](../actions/descriptions/createworkflowfromtemplate.md)]|  
|[ExecuteWorkflow Action](../actions/executeworkflow.md)|Entity|[!INCLUDE[../actions/descriptions/executeworkflow.md](../actions/descriptions/executeworkflow.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the workflow entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Gamification Solution](../solutions/gamification.md)|[!INCLUDE[../solutions/descriptions/gamification.md](../solutions/descriptions/gamification.md)]|    

[!INCLUDE[./remarks/workflow.md](./remarks/workflow.md)]

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