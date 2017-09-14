---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_iotalert EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 92c3daeb-80a3-4243-8623-b11b5b057db6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_iotalert entitytype."
---
# msdyn_iotalert EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_iotalert.md](./descriptions/msdyn_iotalert.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_iotalerts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>IoT Alert</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_iotalertid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_description</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_alertdata|Edm.String|**Display Name**: Alert Data<br />**Description**: Data sent from the device about the alert.<br />|
|msdyn_alerttime|Edm.DateTimeOffset|**Display Name**: Alert Time<br />**Description**: The time the alert was issued.<br />|
|msdyn_alerttoken|Edm.String|**Display Name**: Alert Token<br />**Description**: The unique reference to the event id on the IoT hub.<br />|
|msdyn_alerttype|Edm.Int32|**Display Name**: Alert Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Anomaly</td></tr><tr><td>192350001</td><td>Info</td></tr><tr><td>192350002</td><td>Preventive Maintenance</td></tr><tr><td>192350003</td><td>Test</td></tr><tbody></table>|
|msdyn_alerturl|Edm.String|**Display Name**: Alert URL<br />**Description**: External URL to view more information about the iot alert.<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: A description for the alert.<br />|
|msdyn_deviceid|Edm.String|**Display Name**: Device ID<br />**Description**: The ID of the IoT device that sent the alert.<br />|
|msdyn_iotalertid|Edm.Guid|**Display Name**: IoT Alert<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_lastcommandsenttime|Edm.DateTimeOffset|**Display Name**: Last Command Sent Time<br />|
|msdyn_parentalerttoken|Edm.String|**Display Name**: Parent Alert Token<br />**Description**: Reference to a previously created parent iot alert<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the IoT Alert<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the IoT Alert<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
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
|_msdyn_customerasset_value|msdyn_CustomerAsset<br />|The asset connected to the IoT device that raised the alert.|
|_msdyn_device_value|msdyn_Device<br />|The IoT device for which this alert was raised.|
|_msdyn_lastcommandsent_value|msdyn_LastCommandSent<br />||
|_msdyn_parentalert_value|msdyn_ParentAlert<br />|Reference to a parent alert. This field is inferred if Parent Alert Token is set.|
|_msdyn_workorder_value|msdyn_Workorder<br />|Work order created for this iot alert.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the id of the stage where the entity is located.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_iotalert_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_iotalert_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_iotalert_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_iotalert_modifiedonbehalfby|
|msdyn_CustomerAsset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset|
|msdyn_Device|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_msdyn_iotdevice_msdyn_iotalert_Device|
|msdyn_LastCommandSent|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent|
|msdyn_ParentAlert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_iotalert_msdyn_iotalert|
|msdyn_Workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_iotalert_Workorder|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_iotalert|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_iotalert|
|owningteam|[team EntityType](team.md)|team_msdyn_iotalert|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_iotalert|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_iotalert|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bpf_msdyn_iotalert_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|bpf_msdyn_iotalertid|  
|msdyn_iotalert_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_iotalert|  
|msdyn_iotalert_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_iotalert|  
|msdyn_iotalert_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_iotalert|  
|msdyn_iotalert_connections1|[connection EntityType](connection.md)|record1id_msdyn_iotalert|  
|msdyn_iotalert_connections2|[connection EntityType](connection.md)|record2id_msdyn_iotalert|  
|msdyn_iotalert_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_ParentAlert|  
|msdyn_iotalert_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_iotalert|  
|msdyn_iotalert_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_iotalert|  
|msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_ParentAlert|  
|msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_IoTAlert|  

## Operations
The following operations can be used with the msdyn_iotalert entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_ParentIoTAlerts Action](../actions/msdyn_parentiotalerts.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_parentiotalerts.md](../actions/descriptions/msdyn_parentiotalerts.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_iotalert entity type.


|Name|Description |  
|----|------------|  
|[Connected Field Service for Microsoft Dynamics 365 Solution](../solutions/connectedfieldservice.md)|[!INCLUDE[../solutions/descriptions/connectedfieldservice.md](../solutions/descriptions/connectedfieldservice.md)]|  
|[IoT Connector for Microsoft Dynamics 365 Solution](../solutions/iotconnector.md)|[!INCLUDE[../solutions/descriptions/iotconnector.md](../solutions/descriptions/iotconnector.md)]|    

[!INCLUDE[./remarks/msdyn_iotalert.md](./remarks/msdyn_iotalert.md)]

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