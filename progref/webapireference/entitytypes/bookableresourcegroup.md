---
title: "Microsoft Dynamics 365 Customer Engagement bookableresourcegroup EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a3ce9bdb-3a63-4d1d-adff-acc8bf5adadc
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bookableresourcegroup entitytype."
---
# bookableresourcegroup EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bookableresourcegroup.md](./descriptions/bookableresourcegroup.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]bookableresourcegroups </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bookable Resource Group</td></tr>
<tr><td><b>Primary Key:</b></td><td>bookableresourcegroupid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The bookableresourcegroup entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bookableresourcegroupid|Edm.Guid|**Display Name**: Bookable Resource Group<br />**Description**: Unique identifier of the resource group.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the bookableresourcegroup with respect to the base currency.<br />Read-only<br />|
|fromdate|Edm.DateTimeOffset|**Display Name**: From Date<br />**Description**: Enter the group membership start date.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the resource group.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Bookable Resource Group<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Bookable Resource Group<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|todate|Edm.DateTimeOffset|**Display Name**: To Date<br />**Description**: Enter the group membership end date.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_childresource_value|ChildResource<br />|The child resource that is a part of the group.|
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_parentresource_value|ParentResource<br />|The parent resource that is a part of the group.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the BookableResourceGroup with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|ChildResource|[bookableresource EntityType](bookableresource.md)|bookableresource_bookableresourcegroup_ChildResource|
|createdbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcegroup_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcegroup_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcegroup_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcegroup_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_bookableresourcegroup|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_bookableresourcegroup|
|owningteam|[team EntityType](team.md)|team_bookableresourcegroup|
|owninguser|[systemuser EntityType](systemuser.md)|user_bookableresourcegroup|
|ParentResource|[bookableresource EntityType](bookableresource.md)|bookableresource_bookableresourcegroup_ParentResource|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_bookableresourcegroup|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bookableresourcegroup_Annotations|[annotation EntityType](annotation.md)|objectid_bookableresourcegroup|  
|bookableresourcegroup_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_bookableresourcegroup|  
|bookableresourcegroup_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_bookableresourcegroup|  
|bookableresourcegroup_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_bookableresourcegroup|  
|bookableresourcegroup_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_bookableresourcegroup|  
|BookableResourceGroup_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_bookableresourcegroup_syncerror|  

## Operations
The following operations can be used with the bookableresourcegroup entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the bookableresourcegroup entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Scheduling Workload Solution](../solutions/scheduling.md)|[!INCLUDE[../solutions/descriptions/scheduling.md](../solutions/descriptions/scheduling.md)]|    

[!INCLUDE[./remarks/bookableresourcegroup.md](./remarks/bookableresourcegroup.md)]

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