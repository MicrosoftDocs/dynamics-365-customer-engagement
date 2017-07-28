---
title: "Microsoft Dynamics 365 Customer Engagement msevtmgt_building EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 27e5b06f-5907-4136-bf41-92bc288f685e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msevtmgt_building entitytype."
---
# msevtmgt_building EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msevtmgt_building.md](./descriptions/msevtmgt_building.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msevtmgt_buildings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Building</td></tr>
<tr><td><b>Primary Key:</b></td><td>msevtmgt_buildingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msevtmgt_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msevtmgt_building entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msevtmgt_accessibletoilets|Edm.Int32|**Display Name**: Accessible Toilets<br />**Description**: There are accessible toilets or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_additionalfacilities|Edm.String|**Display Name**: Additional Facilities<br />**Description**: Some additional facilities which is not covered by available options.<br />|
|msevtmgt_addresscomposite|Edm.String|**Display Name**: Address Composite<br />Computed<br />Read-only<br />|
|msevtmgt_addressline1|Edm.String|**Display Name**: Address Line 1<br />**Description**: Address (except of city, country/region, state or province and postal code).<br />|
|msevtmgt_addressline2|Edm.String|**Display Name**: Address Line 2<br />**Description**: Additional address details.<br />|
|msevtmgt_addressline3|Edm.String|**Display Name**: Address Line 3<br />**Description**: Additional address details.<br />|
|msevtmgt_buildingid|Edm.Guid|**Display Name**: Building<br />**Description**: Unique identifier for entity instances<br />|
|msevtmgt_city|Edm.String|**Display Name**: City<br />**Description**: City. Part of address info.<br />|
|msevtmgt_cost|Edm.Decimal|**Display Name**: Cost<br />**Description**: Cost (of using the building)<br />|
|msevtmgt_cost_base|Edm.Decimal|**Display Name**: Cost (Base)<br />**Description**: Value of the Cost in base currency.<br />Read-only<br />|
|msevtmgt_country|Edm.String|**Display Name**: Country/Region<br />**Description**: Country/Region. Part of address info.<br />|
|msevtmgt_description|Edm.String|**Display Name**: Description<br />**Description**: Description of the building.<br />|
|msevtmgt_disabledaccess|Edm.Int32|**Display Name**: Disabled Access<br />**Description**: There is disabled access or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_disabledparking|Edm.Int32|**Display Name**: Disabled Parkting<br />**Description**: There is disabled parking or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_email|Edm.String|**Display Name**: Email<br />**Description**: Email to contact the building<br />|
|msevtmgt_estimatedcapacity|Edm.Int32|**Display Name**: Estimated Capacity<br />**Description**: Estimated capacity of building<br />|
|msevtmgt_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msevtmgt_numberofrooms|Edm.Int32|**Display Name**: Number of Rooms<br />**Description**: Number of available rooms.<br />Computed<br />Read-only<br />|
|msevtmgt_numberofrooms_date|Edm.DateTimeOffset|**Display Name**: Number of Rooms (Last Updated On)<br />**Description**: Last Updated time of rollup field Number of Rooms.<br />Read-only<br />|
|msevtmgt_numberofrooms_state|Edm.Int32|**Display Name**: Number of Rooms (State)<br />**Description**: State of rollup field Number of Rooms.<br />Read-only<br />|
|msevtmgt_postalcode|Edm.String|**Display Name**: Postal Code<br />**Description**: Postal code. Part of address info.<br />|
|msevtmgt_publictelephoneavailable|Edm.Int32|**Display Name**: Public Telephone Available<br />**Description**: There is available public telephone or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_stateprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or province. Part of address info.<br />|
|msevtmgt_telephone1|Edm.String|**Display Name**: Telephone 1<br />**Description**: Telephone to contact the building<br />|
|msevtmgt_telephone2|Edm.String|**Display Name**: Telephone 2<br />**Description**: Telephone to contact the building<br />|
|msevtmgt_telephone3|Edm.String|**Display Name**: Telephone 3<br />**Description**: Telephone to contact the building<br />|
|msevtmgt_website|Edm.String|**Display Name**: Website<br />**Description**: Website to contact the building<br />|
|msevtmgt_wifiavailable|Edm.Int32|**Display Name**: Wifi Available<br />**Description**: There is available wifi or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Yes</td></tr><tr><td>100000002</td><td>No</td></tr><tbody></table>|
|msevtmgt_wifipassword|Edm.String|**Display Name**: Wifi Password<br />**Description**: Wifi password.<br />|
|msevtmgt_wifissid|Edm.String|**Display Name**: Wifi SSID<br />**Description**: SSID of the wifi<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Building<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Building<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msevtmgt_primarycontact_value|msevtmgt_PrimaryContact<br />|A person who is responsible for the building.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_building_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_building_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_building_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msevtmgt_building_modifiedonbehalfby|
|msevtmgt_PrimaryContact|[contact EntityType](contact.md)|msevtmgt_contact_msevtmgt_building_PrimaryContact|
|ownerid|[principal EntityType](principal.md)|owner_msevtmgt_building|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msevtmgt_building|
|owningteam|[team EntityType](team.md)|team_msevtmgt_building|
|owninguser|[systemuser EntityType](systemuser.md)|user_msevtmgt_building|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msevtmgt_Building|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msevtmgt_building_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msevtmgt_building|  
|msevtmgt_building_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msevtmgt_building|  
|msevtmgt_building_msevtmgt_room_Building|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_Building|  
|msevtmgt_building_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msevtmgt_building|  
|msevtmgt_msevtmgt_building_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_BuildingId|  

## Operations
The following operations can be used with the msevtmgt_building entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msevtmgt_building entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|    

[!INCLUDE[./remarks/msevtmgt_building.md](./remarks/msevtmgt_building.md)]

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