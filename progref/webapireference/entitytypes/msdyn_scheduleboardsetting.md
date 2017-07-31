---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_scheduleboardsetting EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 27115ce1-4870-4717-b379-f983257480c4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_scheduleboardsetting entitytype."
---
# msdyn_scheduleboardsetting EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_scheduleboardsetting.md](./descriptions/msdyn_scheduleboardsetting.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_scheduleboardsettinges </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Schedule Board Setting</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_scheduleboardsettingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_tabname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_scheduleboardsetting entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|msdyn_customtabname|Edm.String|**Display Name**: Custom Tab Name<br />|
|msdyn_customtabwebresource|Edm.String|**Display Name**: Custom Tab Web Resource<br />|
|msdyn_fullybookedcolor|Edm.String|**Display Name**: Fully Booked Color<br />|
|msdyn_hidecancelled|Edm.Boolean|**Display Name**: Hide Canceled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_ispublic|Edm.Boolean|**Display Name**: Is Public (Deprecated)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_issynchronizeresources|Edm.Boolean|**Display Name**: Is Synchronize Resources<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_mapviewtabplacement|Edm.Boolean|**Display Name**: Map View Tab Placement<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Details</td></tr><tr><td>0</td><td>Filter</td></tr><tbody></table>|
|msdyn_notbookedcolor|Edm.String|**Display Name**: Not Booked Color<br />|
|msdyn_ordernumber|Edm.Int32|**Display Name**: Order Number<br />**Description**: Tab index.<br />|
|msdyn_organizationalunittooltipsviewid|Edm.String|**Display Name**: Organizational Unit Tooltips View Id<br />|
|msdyn_organizationalunitviewid|Edm.String|**Display Name**: Organizational Unit View Id<br />|
|msdyn_overbookedcolor|Edm.String|**Display Name**: Overbooked Color<br />|
|msdyn_partiallybookedcolor|Edm.String|**Display Name**: Partially Booked Color<br />|
|msdyn_scheduleboardsettingid|Edm.Guid|**Display Name**: Schedule Board Setting<br />**Description**: Shows the entity instances.<br />|
|msdyn_scheduleralertsview|Edm.String|**Display Name**: Scheduler Alerts View<br />|
|msdyn_schedulerbusinessunitdetailsview|Edm.String|**Display Name**: Unit Details View (Deprecated)<br />|
|msdyn_schedulerbusinessunittooltipview|Edm.String|**Display Name**: Business Unit Tooltips View (Deprecated)<br />|
|msdyn_schedulercoredetailsview|Edm.String|**Display Name**: Core Details View (Deprecated)<br />|
|msdyn_schedulercoreslottexttemplate|Edm.String|**Display Name**: Core Slot Text Template (Deprecated)<br />|
|msdyn_schedulercoretooltipview|Edm.String|**Display Name**: Core Tooltip View (Deprecated)<br />|
|msdyn_schedulerfieldservicedetailsview|Edm.String|**Display Name**: Field Service Details View (Deprecated)<br />|
|msdyn_schedulerfieldserviceslottexttemplate|Edm.String|**Display Name**: Field Service Slot Text Template (Deprecated)<br />|
|msdyn_schedulerfieldservicetooltipview|Edm.String|**Display Name**: Field Service Tooltip View (Deprecated)<br />|
|msdyn_schedulerresourcedetailsview|Edm.String|**Display Name**: Resource Details View<br />|
|msdyn_schedulerresourcetooltipview|Edm.String|**Display Name**: Resource Tooltips View<br />|
|msdyn_settings|Edm.String|**Display Name**: Settings<br />**Description**: Shows the settings as a JSON string.<br />|
|msdyn_sharetype|Edm.Int32|**Display Name**: Share Type<br />**Description**: Field is used to determine if Schedule Board Tab are Private, Public or Shareable<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Everyone</td></tr><tr><td>192350001</td><td>Just me</td></tr><tr><td>192350002</td><td>Specific people</td></tr><tbody></table>|
|msdyn_tabname|Edm.String|**Display Name**: Tab name.<br />**Description**: Enter the tab name.<br />|
|msdyn_unscheduledrequirementsviewid|Edm.String|**Display Name**: Requirements View Id<br />|
|msdyn_unscheduledviewid|Edm.String|**Display Name**: Unscheduled View (Deprecated)<br />|
|msdyn_unscheduledwopagereccount|Edm.Int32|**Display Name**: Resource Requirement View Page Record Count<br />**Description**: Shows the number of records to be displayed per page in 'Resource Requirement' section.<br />|
|msdyn_unscheduledwotooltipsviewid|Edm.String|**Display Name**: Unscheduled WO Tooltips View (Deprecated)<br />|
|msdyn_workinghourscolor|Edm.String|**Display Name**: Working Hours Color<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Schedule Board Setting<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Schedule Board Setting<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_scheduleboardsetting_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_scheduleboardsetting_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_scheduleboardsetting_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_scheduleboardsetting_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_scheduleboardsetting|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_scheduleboardsetting|
|owningteam|[team EntityType](team.md)|team_msdyn_scheduleboardsetting|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_scheduleboardsetting|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_scheduleboardsetting_msdyn_routingjobconfiguration_ScheduleBoardSetting|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|msdyn_ScheduleBoardSetting|  
|msdyn_scheduleboardsetting_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_scheduleboardsetting|  
|msdyn_scheduleboardsetting_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_scheduleboardsetting|  
|msdyn_scheduleboardsetting_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_scheduleboardsetting|  
|msdyn_scheduleboardsetting_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_scheduleboardsetting|  
|msdyn_scheduleboardsetting_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_scheduleboardsetting|  

## Operations
The following operations can be used with the msdyn_scheduleboardsetting entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_scheduleboardsetting entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|    

[!INCLUDE[./remarks/msdyn_scheduleboardsetting.md](./remarks/msdyn_scheduleboardsetting.md)]

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