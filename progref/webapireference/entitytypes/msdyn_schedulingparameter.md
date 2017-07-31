---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_schedulingparameter EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e05b88fd-51bd-48c6-a1ef-4a885ef14fff
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_schedulingparameter entitytype."
---
# msdyn_schedulingparameter EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_schedulingparameter.md](./descriptions/msdyn_schedulingparameter.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_schedulingparameters </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Scheduling Parameter</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_schedulingparameterid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_schedulingparameter entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_connecttomaps|Edm.Boolean|**Display Name**: Connect to Maps<br />**Description**: Determines if the mapping provider will be used for map location and distance calculations.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_customgeolatitudefield|Edm.String|**Display Name**: Custom Geo Latitude Field<br />**Description**: Shows the logical name of the latitude field to be used by geolocations.<br />|
|msdyn_customgeolocationentity|Edm.String|**Display Name**: Custom Geo Location Entity<br />**Description**: Shows the logical name of custom entity to be used for geolocations.<br />|
|msdyn_customgeolongitudefield|Edm.String|**Display Name**: Custom Geo Longitude Field<br />**Description**: Shows the logical name of the longitude field to be used for geolocations.<br />|
|msdyn_customgeoresourcefield|Edm.String|**Display Name**: Custom Geo Resource Field<br />**Description**: Shows the logical name of the resource field to be used for geolocations.<br />|
|msdyn_customgeotimestampfield|Edm.String|**Display Name**: Custom Geo Timestamp Field<br />**Description**: Shows the logical name of the timestamp field to be used for geolocations.<br />|
|msdyn_defaultradiusunit|Edm.Int32|**Display Name**: Default Radius Unit<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Miles</td></tr><tr><td>192350001</td><td>KM</td></tr><tbody></table>|
|msdyn_defaultradiusvalue|Edm.Int32|**Display Name**: Default Radius Value<br />|
|msdyn_enablecustomgeolocation|Edm.Boolean|**Display Name**: Enable Custom Geo Location<br />**Description**: Determines if a custom entity will be used as a source of geo locations for resources to be displayed in the map view.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_enableresourceschedulingoptimization|Edm.Boolean|**Display Name**: Enable Resource Scheduling Optimization<br />**Description**: Select if the Resource Scheduling Optimization engine can schedule resources to fulfill resource requirements.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_geolocationexpiresafterxminutes|Edm.Int32|**Display Name**: Geo Location Expires After X Minutes<br />|
|msdyn_geolocationrefreshintervalseconds|Edm.Int32|**Display Name**: Geo Location Refresh Interval Seconds<br />|
|msdyn_mapapikey|Edm.String|**Display Name**: Map Api Key<br />**Description**: Api key for map<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_saautofilterserviceterritory|Edm.Boolean|**Display Name**: Auto Filter Service Territory<br />**Description**: Determines if the schedule assistant should automatically filter results based on the requirement territory.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_scheduleboardrefreshintervalseconds|Edm.Int32|**Display Name**: The refresh rate of the schedule board.<br />|
|msdyn_schedulingparameterid|Edm.Guid|**Display Name**: Scheduling Parameter<br />**Description**: A unique identifier for an entity instance.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Scheduling Parameter<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Scheduling Parameter<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_schedulingparameter_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_schedulingparameter_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_schedulingparameter_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_schedulingparameter_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_schedulingparameter|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_schedulingparameter_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_schedulingparameter|  
|msdyn_schedulingparameter_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_schedulingparameter|  
|msdyn_schedulingparameter_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_schedulingparameter|  

## Operations
The following operations can be used with the msdyn_schedulingparameter entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_schedulingparameter entity type.


|Name|Description |  
|----|------------|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/msdyn_schedulingparameter.md](./remarks/msdyn_schedulingparameter.md)]

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