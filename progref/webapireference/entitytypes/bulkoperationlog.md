---
title: "Microsoft Dynamics 365 Customer Engagement bulkoperationlog EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fb1b40b6-1b3c-4e2f-912b-f17ed9176b73
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bulkoperationlog entitytype."
---
# bulkoperationlog EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bulkoperationlog.md](./descriptions/bulkoperationlog.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]bulkoperationlogs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bulk Operation Log</td></tr>
<tr><td><b>Primary Key:</b></td><td>bulkoperationlogid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET</td></tr>
</table>
  
The bulkoperationlog entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|additionalinfo|Edm.String|**Display Name**: Failed on Line<br />**Description**: Shows the data value at which an error occurred during the quick campaign.<br />|
|bulkoperationlogid|Edm.Guid|**Display Name**: Bulk Operation Log Number<br />**Description**: Unique identifier of the bulk operation log.<br />|
|errornumber|Edm.Int32|**Display Name**: Reason Id<br />**Description**: Shows the error code that is used to troubleshoot issues in the bulk operation.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|name|Edm.String|**Display Name**: name<br />**Description**: name<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_bulkoperationid_value|bulkoperationid_activitypointer<br />|Shows the quick campaign record that the log applies to. This information is used to relate log data to the parent quick campaign.|
|_createdobjectid_value|createdobjectid_account<br />createdobjectid_activitypointer<br />createdobjectid_contact<br />createdobjectid_lead<br />createdobjectid_opportunity<br />|Choose the activity or other item created by the bulk operation.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_regardingobjectid_value|regardingobjectid_account<br />regardingobjectid_contact<br />regardingobjectid_lead<br />|Choose the account, contact, lead, or list that the bulk operation log item applies to.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|bulkoperationid|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_logs|
|bulkoperationid_activitypointer|[activitypointer EntityType](activitypointer.md)|activity_pointer_BulkOperation_logs|
|createdobjectid_account|[account EntityType](account.md)|CreatedAccount_BulkOperationLogs2|
|createdobjectid_activitypointer|[activitypointer EntityType](activitypointer.md)|CreatedActivity_BulkOperationLogs|
|createdobjectid_contact|[contact EntityType](contact.md)|CreatedContact_BulkOperationLogs|
|createdobjectid_lead|[lead EntityType](lead.md)|CreatedLead_BulkOperationLogs|
|createdobjectid_opportunity|[opportunity EntityType](opportunity.md)|CreatedOpportunity_BulkOperationLogs|
|ownerid|[principal EntityType](principal.md)|owner_bulkoperationlog|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_bulkoperationlog|
|owningteam|[team EntityType](team.md)|team_bulkoperationlog|
|owninguser|[systemuser EntityType](systemuser.md)|user_bulkoperationlog|
|regardingobjectid_account|[account EntityType](account.md)|SourceAccount_BulkOperationLogs|
|regardingobjectid_contact|[contact EntityType](contact.md)|SourceContact_BulkOperationLogs|
|regardingobjectid_lead|[lead EntityType](lead.md)|SourceLead_BulkOperationLogs|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|BulkOperationLog_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_bulkoperationlog|  
|BulkOperationLog_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_bulkoperationlog|  
|bulkoperationlog_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_bulkoperationlog|  

## Solutions
The following solutions include the bulkoperationlog entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/bulkoperationlog.md](./remarks/bulkoperationlog.md)]

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