---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_iotdevice EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 267b6b1b-33de-4b33-985e-0b48e156046d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_iotdevice entitytype."
---
# msdyn_iotdevice EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_iotdevice.md](./descriptions/msdyn_iotdevice.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_iotdevices </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>IoT Device</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_iotdeviceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_iotdevice entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_deviceid|Edm.String|**Display Name**: Device ID<br />**Description**: Device ID used to register with IoT hub.<br />|
|msdyn_iotdeviceid|Edm.Guid|**Display Name**: IoT Device<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_lastcommandsenttime|Edm.DateTimeOffset|**Display Name**: [Deprecated] Last Command Sent Time<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_registrationmessage|Edm.String|**Display Name**: Registration Message<br />**Description**: A message field that explains the IoT Registration Status.<br />|
|msdyn_registrationstatus|Edm.Int32|**Display Name**: Registration Status<br />**Description**: A status field that denotes whether the device is registered with the IoT hub.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Unknown</td></tr><tr><td>192350001</td><td>Unregistered</td></tr><tr><td>192350002</td><td>In Progress</td></tr><tr><td>192350003</td><td>Registered</td></tr><tr><td>192350004</td><td>Error</td></tr><tbody></table>|
|msdyn_timezone|Edm.Int32|**Display Name**: Time Zone<br />**Description**: The device's time zone.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the IoT Device<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the IoT Device<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_account_value|msdyn_Account<br />|Parent customer of this device|
|_msdyn_category_value|msdyn_Category<br />|The device category that this IoT device belongs to.|
|_msdyn_lastcommandsent_value|msdyn_LastCommandSent<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_iotdevice_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_iotdevice_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_iotdevice_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_iotdevice_modifiedonbehalfby|
|msdyn_Account|[account EntityType](account.md)|msdyn_account_msdyn_iotdevice_Account|
|msdyn_Category|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category|
|msdyn_LastCommandSent|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_iotdevice|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_iotdevice|
|owningteam|[team EntityType](team.md)|team_msdyn_iotdevice|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_iotdevice|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_iotdevice_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_iotdevice|  
|msdyn_iotdevice_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_iotdevice|  
|msdyn_iotdevice_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_iotdevice|  
|msdyn_iotdevice_connections1|[connection EntityType](connection.md)|record1id_msdyn_iotdevice|  
|msdyn_iotdevice_connections2|[connection EntityType](connection.md)|record2id_msdyn_iotdevice|  
|msdyn_iotdevice_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_iotdevice|  
|msdyn_iotdevice_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_iotdevice|  
|msdyn_iotdevice_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_iotdevice|  
|msdyn_msdyn_iotdevice_msdyn_iotalert_Device|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_Device|  
|msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_Device|  
|msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_Device|  

## Operations
The following operations can be used with the msdyn_iotdevice entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_iotdevice entity type.


|Name|Description |  
|----|------------|  
|[IoT Connector for Microsoft Dynamics 365 Solution](../solutions/iotconnector.md)|[!INCLUDE[../solutions/descriptions/iotconnector.md](../solutions/descriptions/iotconnector.md)]|    

[!INCLUDE[./remarks/msdyn_iotdevice.md](./remarks/msdyn_iotdevice.md)]

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