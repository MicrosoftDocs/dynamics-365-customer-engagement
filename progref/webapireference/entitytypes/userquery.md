---
title: "Microsoft Dynamics 365 Customer Engagement userquery EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2c1f6da8-bf99-4a94-a5ef-74143d34f0b7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API userquery entitytype."
---
# userquery EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/userquery.md](./descriptions/userquery.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]userqueries </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Saved View</td></tr>
<tr><td><b>Primary Key:</b></td><td>userqueryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The userquery EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|advancedgroupby|Edm.String|**Display Name**: Advanced Group By<br />**Description**: Type the column name that will be used to group the results from the data collected across multiple records from a user view.<br />|
|columnsetxml|Edm.String|**Display Name**: Column Set XML<br />**Description**: Shows the columns and sorting criteria for the saved view, stored in XML format.<br />|
|conditionalformatting|Edm.String|**Display Name**: User Group By<br />**Description**: Type information about how the items in the user view are formatted.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the saved view, such as the filter criteria or intended results set.<br />|
|fetchxml|Edm.String|**Display Name**: Fetch XML<br />**Description**: Contains the Fetch XML query that defines the entities and attributes included in the saved view.<br />|
|layoutjson|Edm.String|**Display Name**: Layout data in JSON format.<br />**Description**: Layout data in JSON format.<br />|
|layoutxml|Edm.String|**Display Name**: Layout XML<br />**Description**: For internal use only.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Last Modified<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name for the saved view.<br />|
|offlinesqlquery|Edm.String|**Display Name**: Offline SQL Query<br />**Description**: String specifying the corresponding sql query for the fetch xml specified for offline use.<br />|
|querytype|Edm.Int32|**Display Name**: Query Type<br />**Description**: Shows the code for the query type to indicate whether the saved view is an address book filter, advanced search, or other view.<br />|
|returnedtypecode|Edm.String|**Display Name**: Returned Type<br />**Description**: Type of entity that the saved view displays.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the saved view is active or inactive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the item's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>3</td><td>All</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|userqueryid|Edm.Guid|**Display Name**: User Query<br />**Description**: Unique identifier of the saved view.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the saved view.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that the record owner belongs to.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns this saved view.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns this saved view.|
|_parentqueryid_value||Choose the ID of the saved query that the record was created from.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_userquery_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_userquery_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_userquery_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_userquery_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_userquerys|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_userquery|
|owningteam|[team EntityType](team.md)|team_userquery|
|owninguser|[systemuser EntityType](systemuser.md)|user_userquery|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|UserQuery_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_userquery|  
|UserQuery_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_userquery|  
|UserQuery_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_userquery_syncerror|  

## Operations
The following operations can be used with the userquery entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/userquery.md](./remarks/userquery.md)]

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