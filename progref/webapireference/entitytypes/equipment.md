---
title: "Microsoft Dynamics 365 Customer Engagement equipment EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 36a416ed-9684-451c-8dad-7e918f49e3e1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API equipment entitytype."
---
# equipment EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/equipment.md](./descriptions/equipment.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]equipments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Facility/Equipment</td></tr>
<tr><td><b>Primary Key:</b></td><td>equipmentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The equipment entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the facility/equipment.<br />|
|displayinserviceviews|Edm.Boolean|**Display Name**: Display in Service Views<br />**Description**: For internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|emailaddress|Edm.String|**Display Name**: Primary Email<br />**Description**: Email address of person to contact about the use of the facility/equipment.<br />|
|equipmentid|Edm.Guid|**Display Name**: Facility/Equipment<br />**Description**: Unique identifier of the facility/equipment.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the equipment with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isdisabled|Edm.Boolean|**Display Name**: Is Disabled<br />**Description**: Whether the facility/equipment is disabled or operational.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the facility/equipment.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|skills|Edm.String|**Display Name**: Skills<br />**Description**: Skills needed to operate the facility/equipment.<br />|
|timezonecode|Edm.Int32|**Display Name**: Time Zone<br />**Description**: Local time zone where the facility/equipment is located.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value|businessunitid_businessunit<br />businessunitid_systemuser<br />|Shows the associated business unit.|
|_calendarid_value|calendarid<br />|Fiscal calendar associated with the facility/equipment.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the facility/equipment entry.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows the delegate user who created the equipment.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the facility/equipment.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the equipment.|
|_organizationid_value|organizationid<br />|Unique identifier of the parent business unit.|
|_siteid_value|siteid<br />|Site where the facility/equipment is located.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the equipment.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid_businessunit|[businessunit EntityType](businessunit.md)|business_unit_equipment|
|businessunitid_systemuser|[systemuser EntityType](systemuser.md)|equipment_systemuser|
|calendarid|[calendar EntityType](calendar.md)|calendar_equipment|
|createdby|[systemuser EntityType](systemuser.md)|lk_equipment_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_equipment_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_equipment_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_equipment_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_equipment|
|siteid|[site EntityType](site.md)|site_equipment|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Equipment|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|equipment_accounts|[account EntityType](account.md)|preferredequipmentid|  
|equipment_activity_parties|[activityparty EntityType](activityparty.md)|partyid_equipment|  
|Equipment_Annotation|[annotation EntityType](annotation.md)|objectid_equipment|  
|Equipment_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_equipment|  
|Equipment_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_equipment|  
|equipment_connections1|[connection EntityType](connection.md)|record1id_equipment|  
|equipment_connections2|[connection EntityType](connection.md)|record2id_equipment|  
|equipment_contacts|[contact EntityType](contact.md)|preferredequipmentid|  
|Equipment_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_equipment|  
|Equipment_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_equipment|  
|Equipment_Email_EmailSender|[email EntityType](email.md)|emailsender_equipment|  
|equipment_resources|[resource EntityType](resource.md)|resourceid_equipment|  
|Equipment_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_equipment_syncerror|  

## Operations
The following operations can be used with the equipment entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[SetBusinessSystemUser Action](../actions/setbusinesssystemuser.md)|Not Bound|[!INCLUDE[../actions/descriptions/setbusinesssystemuser.md](../actions/descriptions/setbusinesssystemuser.md)]|  

## Solutions
The following solutions include the equipment entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/equipment.md](./remarks/equipment.md)]

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