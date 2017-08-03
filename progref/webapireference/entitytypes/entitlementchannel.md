---
title: "Microsoft Dynamics 365 Customer Engagement entitlementchannel EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cf7817d5-4745-4aaa-9c9b-d44b2702a51f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API entitlementchannel entitytype."
---
# entitlementchannel EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/entitlementchannel.md](./descriptions/entitlementchannel.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]entitlementchannels </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Entitlement Channel</td></tr>
<tr><td><b>Primary Key:</b></td><td>entitlementchannelid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The entitlementchannel entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|channel|Edm.Int32|**Display Name**: Name<br />**Description**: Select a channel for which you are defining the entitlement terms.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Phone</td></tr><tr><td>2</td><td>Email</td></tr><tr><td>3</td><td>Web</td></tr><tr><td>2483</td><td>Facebook</td></tr><tr><td>3986</td><td>Twitter</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|entitlementchannelid|Edm.Guid|**Display Name**: Entitlement Channel<br />**Description**: Unique identifier for entity instances<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the incident with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Entitlement Channel Name<br />**Description**: The name of the custom entity.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|remainingterms|Edm.Decimal|**Display Name**: Remaining Terms<br />**Description**: Type the total number of entitlement terms that are left.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|totalterms|Edm.Decimal|**Display Name**: Total Terms<br />**Description**: Type the total number of entitlement terms.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_entitlementid_value|entitlementid<br />|Unique identifier for Entitlement associated with Entitlement Channel.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the entitlement channel is associated.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the incident.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_entitlementchannel_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_entitlementchannel_createdonbehalfby|
|entitlementid|[entitlement EntityType](entitlement.md)|entitlement_entitlementchannel_EntitlementId|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_entitlementchannel_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_entitlementchannel_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|entitlementchannel_organization|
|ownerid|[principal EntityType](principal.md)|owner_entitlementchannel|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_entitlementchannel|
|owningteam|[team EntityType](team.md)|team_entitlementchannel|
|owninguser|[systemuser EntityType](systemuser.md)|user_entitlementchannel|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_entitlementchannel|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|entitlementchannel_Annotations|[annotation EntityType](annotation.md)|objectid_entitlementchannel|  
|entitlementchannel_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_entitlementchannel|  
|entitlementchannel_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_entitlementchannel|  
|entitlementchannel_connections1|[connection EntityType](connection.md)|record1id_entitlementchannel|  
|entitlementchannel_connections2|[connection EntityType](connection.md)|record2id_entitlementchannel|  
|entitlementchannel_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_entitlementchannel|  
|entitlementchannel_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_entitlementchannel|  
|entitlementchannel_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_entitlementchannel|  

## Solutions
The following solutions include the entitlementchannel entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/entitlementchannel.md](./remarks/entitlementchannel.md)]

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