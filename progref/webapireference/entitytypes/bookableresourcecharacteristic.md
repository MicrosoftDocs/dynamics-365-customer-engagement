---
title: "Microsoft Dynamics 365 Customer Engagement bookableresourcecharacteristic EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a3f1e87c-6504-48b8-8d5d-8eadb915ec45
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bookableresourcecharacteristic entitytype."
---
# bookableresourcecharacteristic EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bookableresourcecharacteristic.md](./descriptions/bookableresourcecharacteristic.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]bookableresourcecharacteristics </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bookable Resource Characteristic</td></tr>
<tr><td><b>Primary Key:</b></td><td>bookableresourcecharacteristicid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The bookableresourcecharacteristic entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bookableresourcecharacteristicid|Edm.Guid|**Display Name**: Bookable Resource Characteristic<br />**Description**: Unique identifier of the resource characteristic.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the bookableresourcecharacteristic with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_approvalstatus|Edm.Int32|**Display Name**: Approval status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Saved</td></tr><tr><td>192350001</td><td>Pending Approval</td></tr><tr><td>192350002</td><td>Rejected</td></tr><tr><td>192350003</td><td>Approved</td></tr><tr><td>192350004</td><td>Recalled</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the association between the resource and characteristic.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Bookable Resource Characteristic<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Bookable Resource Characteristic<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_characteristic_value|Characteristic<br />|Choose the characteristic to associate with the resource.|
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_supportingrecord_value|msdyn_supportingrecord<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_ratingvalue_value|RatingValue<br />||
|_resource_value|Resource<br />|Shows the resource associated with the characteristic.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the BookableResourceCharacteristic with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|Characteristic|[characteristic EntityType](characteristic.md)|characteristic_bookableresourcecharacteristic_Characteristic|
|createdbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcecharacteristic_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcecharacteristic_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcecharacteristic_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcecharacteristic_modifiedonbehalfby|
|msdyn_supportingrecord|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord|
|ownerid|[principal EntityType](principal.md)|owner_bookableresourcecharacteristic|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_bookableresourcecharacteristic|
|owningteam|[team EntityType](team.md)|team_bookableresourcecharacteristic|
|owninguser|[systemuser EntityType](systemuser.md)|user_bookableresourcecharacteristic|
|RatingValue|[ratingvalue EntityType](ratingvalue.md)|ratingvalue_bookableresourcecharacteristic_RatingValue|
|Resource|[bookableresource EntityType](bookableresource.md)|bookableresource_bookableresourcecharacteristic_Resource|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_bookableresourcecharacteristic|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bookableresourcecharacteristic_Annotations|[annotation EntityType](annotation.md)|objectid_bookableresourcecharacteristic|  
|bookableresourcecharacteristic_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_bookableresourcecharacteristic|  
|bookableresourcecharacteristic_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_bookableresourcecharacteristic|  
|bookableresourcecharacteristic_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_bookableresourcecharacteristic|  
|bookableresourcecharacteristic_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_bookableresourcecharacteristic|  
|BookableResourceCharacteristic_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_bookableresourcecharacteristic_syncerror|  
|msdyn_bookableresourcecharacteristic_bookableresourcecharacteristic_supportingrecord|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|msdyn_supportingrecord|  
|msdyn_bookableresourcecharacteristic_msdyn_approval_Characteristic|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_Characteristic_msdyn_approval|  

## Operations
The following operations can be used with the bookableresourcecharacteristic entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the bookableresourcecharacteristic entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Scheduling Workload Solution](../solutions/scheduling.md)|[!INCLUDE[../solutions/descriptions/scheduling.md](../solutions/descriptions/scheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/bookableresourcecharacteristic.md](./remarks/bookableresourcecharacteristic.md)]

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