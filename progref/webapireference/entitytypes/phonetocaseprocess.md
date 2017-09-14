---
title: "Microsoft Dynamics 365 Customer Engagement phonetocaseprocess EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 98a216d9-0138-4031-92fb-4d06749eebbf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API phonetocaseprocess entitytype."
---
# phonetocaseprocess EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/phonetocaseprocess.md](./descriptions/phonetocaseprocess.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]phonetocaseprocesses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Phone To Case Process</td></tr>
<tr><td><b>Primary Key:</b></td><td>businessprocessflowinstanceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The phonetocaseprocess entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activestagestartedon|Edm.DateTimeOffset|**Display Name**: Active Stage Started On<br />**Description**: Date and time when current active stage is started.<br />|
|businessprocessflowinstanceid|Edm.Guid|**Display Name**: Phone To Case Process Instance Id<br />**Description**: Unique identifier for Phone To Case Process bpf entity instances<br />|
|completedon|Edm.DateTimeOffset|**Display Name**: Completed On<br />**Description**: Date and time when Business Process Flow instance is completed.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Duration between completed on and started on, used by business process flow.<br />Computed<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Process Name<br />**Description**: Process Name.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the Delve action record is pending, completed, or tracking.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the delve action record status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Finished</td></tr><tr><td>3</td><td>Aborted</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_activestageid_value|activestageid<br />|Unique identifier of the active stage for the Business Process Flow instance.|
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_incidentid_value|incidentid<br />|Unique identifier of the workflow associated to the Business Process Flow instance.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_processid_value|processid<br />|Unique identifier of the workflow associated to the Business Process Flow instance.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|activestageid|[processstage EntityType](processstage.md)|processstage_phonetocaseprocess|
|createdbyname|[systemuser EntityType](systemuser.md)|lk_phonetocaseprocess_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_phonetocaseprocess_createdonbehalfby|
|incidentid|[incident EntityType](incident.md)|incident_phonetocaseprocess|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_phonetocaseprocess_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_phonetocaseprocess_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_phonetocaseprocess|
|processid|[workflow EntityType](workflow.md)|workflow_phonetocaseprocess|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_phonetocaseprocess|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|phonetocaseprocess_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_phonetocaseprocess|  
|phonetocaseprocess_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_phonetocaseprocess|  
|PhoneToCaseProcess_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_PhoneToCaseProcess_syncerror|  
|workflowlogs_phonetocaseprocess|[workflowlog EntityType](workflowlog.md)|PhoneToCaseProcess_asyncoperationid|  

## Solutions
The following solutions include the phonetocaseprocess entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/phonetocaseprocess.md](./remarks/phonetocaseprocess.md)]

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