---
title: "Microsoft Dynamics 365 Customer Engagement territory EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1b428309-270e-4519-9b6d-118714a239aa
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API territory entitytype."
---
# territory EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/territory.md](./descriptions/territory.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]territories </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Territory</td></tr>
<tr><td><b>Primary Key:</b></td><td>territoryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The territory entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the territory.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the territory with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Territory Name<br />**Description**: Name of the territory.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|territoryid|Edm.Guid|**Display Name**: Territory<br />**Description**: Unique identifier of the territory.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the territory.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the territory.|
|_managerid_value|managerid<br />|Unique identifier of the manager of the territory.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the territory.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the territory.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the territory.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_territorybase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_territory_createdonbehalfby|
|managerid|[systemuser EntityType](systemuser.md)|system_user_territories|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_territorybase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_territory_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_territories|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Territory|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_routingjobconfiguration_territory|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|msdyn_msdyn_routingjobconfiguration_territory|  
|msdyn_territory_account_ServiceTerritory|[account EntityType](account.md)|msdyn_serviceterritory|  
|msdyn_territory_msdyn_actual_ServiceTerritory|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_ServiceTerritory|  
|msdyn_territory_msdyn_agreement_ServiceTerritory|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_serviceterritory|  
|msdyn_territory_msdyn_postalcode_ServiceTerritory|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_serviceterritory|  
|msdyn_territory_msdyn_resourcerequirement_Territory|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_Territory|  
|msdyn_territory_msdyn_resourceterritory_Territory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_territory|  
|msdyn_territory_msdyn_workorder_ServiceTerritory|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_serviceterritory|  
|msdyn_territory_quotedetail_ServiceTerritory|[quotedetail EntityType](quotedetail.md)|msdyn_ServiceTerritory|  
|territory_accounts|[account EntityType](account.md)|territoryid|  
|Territory_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_territory|  
|Territory_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_territory|  
|territory_connections1|[connection EntityType](connection.md)|record1id_territory|  
|territory_connections2|[connection EntityType](connection.md)|record2id_territory|  
|Territory_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_territory|  
|Territory_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_territory|  
|Territory_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_territory_syncerror|  
|territory_system_users|[systemuser EntityType](systemuser.md)|territoryid|  

## Solutions
The following solutions include the territory entity type.


|Name|Description |  
|----|------------|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/territory.md](./remarks/territory.md)]

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