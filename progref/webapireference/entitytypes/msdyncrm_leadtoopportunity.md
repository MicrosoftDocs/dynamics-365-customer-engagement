---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_leadtoopportunity EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 01a0fea5-c923-4048-9eb9-989003b5156f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_leadtoopportunity entitytype."
---
# msdyncrm_leadtoopportunity EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_leadtoopportunity.md](./descriptions/msdyncrm_leadtoopportunity.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_leadtoopportunities </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Lead to Opportunity</td></tr>
<tr><td><b>Primary Key:</b></td><td>businessprocessflowinstanceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_leadtoopportunity entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activestagestartedon|Edm.DateTimeOffset|**Display Name**: Active Stage Started On<br />**Description**: Date and time when current active stage is started<br />|
|businessprocessflowinstanceid|Edm.Guid|**Display Name**: Lead to Opportunity<br />**Description**: Unique identifier for entity instances<br />|
|completedon|Edm.DateTimeOffset|**Display Name**: Completed On<br />**Description**: Date and time when Business Process Flow instance is completed.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Duration of Business Process Flow<br />Computed<br />Read-only<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: Description<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Lead to Opportunity<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Lead to Opportunity<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Finished</td></tr><tr><td>3</td><td>Aborted</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_activestageid_value|activestageid<br />|Unique identifier of the active stage for the Business Process Flow instance.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyncrm_leadid_value|msdyncrm_leadid<br />||
|_msdyncrm_opportunityid_value|msdyncrm_opportunityid<br />||
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_processid_value|processid<br />|Unique identifier of the workflow associated to the Business Process Flow instance.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|activestageid|[processstage EntityType](processstage.md)|lk_msdyncrm_leadtoopportunity_activestageid|
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_leadtoopportunity_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_leadtoopportunity_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_leadtoopportunity_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_leadtoopportunity_modifiedonbehalfby|
|msdyncrm_leadid|[lead EntityType](lead.md)|msdyncrm_lead_msdyncrm_leadtoopportunity|
|msdyncrm_opportunityid|[opportunity EntityType](opportunity.md)|msdyncrm_opportunity_msdyncrm_leadtoopportunity|
|organizationid|[organization EntityType](organization.md)|organization_msdyncrm_leadtoopportunity|
|processid|[workflow EntityType](workflow.md)|lk_msdyncrm_leadtoopportunity_processid|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_leadtoopportunity_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_leadtoopportunity|  
|msdyncrm_leadtoopportunity_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_leadtoopportunity|  
|msdyncrm_leadtoopportunity_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_leadtoopportunity|  
|msdyncrm_leadtoopportunity_WorkflowLogs|[workflowlog EntityType](workflowlog.md)|asyncoperationid_msdyncrm_leadtoopportunity|  

## Operations
The following operations can be used with the msdyncrm_leadtoopportunity entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyncrm_leadtoopportunity entity type.


|Name|Description |  
|----|------------|  
|[Lead Management Solution Solution](../solutions/leadmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/leadmanagementsolution.md](../solutions/descriptions/leadmanagementsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_leadtoopportunity.md](./remarks/msdyncrm_leadtoopportunity.md)]

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