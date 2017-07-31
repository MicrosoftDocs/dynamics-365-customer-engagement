---
title: "Microsoft Dynamics 365 Customer Engagement ratingmodel EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8c4197c1-ac3e-4497-96d6-59b106be6f48
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API ratingmodel entitytype."
---
# ratingmodel EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/ratingmodel.md](./descriptions/ratingmodel.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]ratingmodels </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Rating Model</td></tr>
<tr><td><b>Primary Key:</b></td><td>ratingmodelid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The ratingmodel entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the ratingmodel with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|maxratingvalue|Edm.Int32|**Display Name**: Max Rating Value<br />**Description**: Enter the maximum rating value.<br />|
|minratingvalue|Edm.Int32|**Display Name**: Min Rating Value<br />**Description**: Enter the minimum rating value.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_ratableentity|Edm.Int32|**Display Name**: Ratable Entity<br />**Description**: Shows whether the entity can use the rating model.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>None</td></tr><tr><td>192350001</td><td>Skill</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the rating model.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|ratingmodelid|Edm.Guid|**Display Name**: Rating Model<br />**Description**: Unique identifier of the rating model.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Rating Model<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Rating Model<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the RatingModel with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdbyname|[systemuser EntityType](systemuser.md)|lk_ratingmodel_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_ratingmodel_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_ratingmodel_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_ratingmodel_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_ratingmodel|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_ratingmodel|
|owningteam|[team EntityType](team.md)|team_ratingmodel|
|owninguser|[systemuser EntityType](systemuser.md)|user_ratingmodel|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_ratingmodel|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ratingmodel_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_ratingmodel|  
|ratingmodel_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_ratingmodel|  
|ratingmodel_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_ratingmodel|  
|ratingmodel_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_ratingmodel|  
|ratingmodel_ratingvalue_RatingModel|[ratingvalue EntityType](ratingvalue.md)|RatingModel|  
|RatingModel_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_ratingmodel_syncerror|  

## Operations
The following operations can be used with the ratingmodel entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the ratingmodel entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Scheduling Workload Solution](../solutions/scheduling.md)|[!INCLUDE[../solutions/descriptions/scheduling.md](../solutions/descriptions/scheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/ratingmodel.md](./remarks/ratingmodel.md)]

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