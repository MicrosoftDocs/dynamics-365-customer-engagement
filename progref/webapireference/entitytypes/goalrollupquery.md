---
title: "Microsoft Dynamics 365 Customer Engagement goalrollupquery EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 42684f6f-a130-4985-a00b-9b7875ce196c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API goalrollupquery entitytype."
---
# goalrollupquery EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/goalrollupquery.md](./descriptions/goalrollupquery.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]goalrollupqueries </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Rollup Query</td></tr>
<tr><td><b>Primary Key:</b></td><td>goalrollupqueryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The goalrollupquery EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|fetchxml|Edm.String|**Display Name**: Condition Criteria<br />**Description**: String that specifies the condition criteria in FetchXML.<br />|
|goalrollupqueryid|Edm.Guid|**Display Name**: Goal Rollup Query<br />**Description**: Unique identifier of the rollup query.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name for the goal rollup query.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|queryentitytype|Edm.String|**Display Name**: Entity Type<br />**Description**: Enter the record type of the rollup query.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the goal rollup query is active or inactive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the goal rollup query's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Open</td></tr><tr><td>1</td><td>Closed</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the goal rollup query.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the record.|
|_owninguser_value||Unique identifier of the user who owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_goalrollupquery_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_goalrollupquery_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_goalrollupquery_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_goalrollupquery_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_goalrollupquery|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_goalrollupquery|
|owningteam|[team EntityType](team.md)|team_goalrollupquery|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|goal_rollupquery_actualdecimal|[goal EntityType](goal.md)|rollupqueryactualdecimalid|  
|goal_rollupquery_actualmoney|[goal EntityType](goal.md)|rollupqueryactualmoneyid|  
|goal_rollupquery_customdecimal|[goal EntityType](goal.md)|rollupquerycustomdecimalid|  
|goal_rollupquery_customint|[goal EntityType](goal.md)|rollupquerycustomintegerid|  
|goal_rollupquery_custommoney|[goal EntityType](goal.md)|rollupquerycustommoneyid|  
|goal_rollupquery_inprogressdecimal|[goal EntityType](goal.md)|rollupqueryinprogressdecimalid|  
|goal_rollupquery_inprogressint|[goal EntityType](goal.md)|rollupqueryinprogressintegerid|  
|goal_rollupquery_inprogressmoney|[goal EntityType](goal.md)|rollupqueryinprogressmoneyid|  
|goalrollupquery_actualint|[goal EntityType](goal.md)|rollupqueryactualintegerid|  
|goalrollupquery_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_goalrollupquery|  
|GoalRollupQuery_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_goalrollupquery|  
|GoalRollupQuery_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_goalrollupquery|  
|GoalRollupQuery_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_goalrollupquery_syncerror|  

## Operations
The following operations can be used with the goalrollupquery entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/goalrollupquery.md](./remarks/goalrollupquery.md)]

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