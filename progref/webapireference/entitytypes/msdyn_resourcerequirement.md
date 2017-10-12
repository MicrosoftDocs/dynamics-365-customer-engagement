---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_resourcerequirement EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4dae424e-2b39-42d3-b49c-5801ba00f2bc
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_resourcerequirement entitytype."
---
# msdyn_resourcerequirement EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_resourcerequirement.md](./descriptions/msdyn_resourcerequirement.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_resourcerequirements </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Resource Requirement</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_resourcerequirementid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_allocationmethod|Edm.Int32|**Display Name**: Allocation Method<br />**Description**: Select the allocation method to be used for creating requirement distribution over a time period.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>None</td></tr><tr><td>192350001</td><td>Full capacity</td></tr><tr><td>192350004</td><td>Percentage capacity</td></tr><tr><td>192350003</td><td>Distribute evenly</td></tr><tr><td>192350005</td><td>Front load</td></tr><tbody></table>|
|msdyn_calendarid|Edm.String|**Display Name**: Calendar Id<br />**Description**: The calendar that will be used for a resource requirement<br />|
|msdyn_city|Edm.String|**Display Name**: City<br />**Description**: Type the city where the resource is required.<br />|
|msdyn_costprice|Edm.Decimal|**Display Name**: Cost Price<br />**Description**: Enter the cost price of the resource required.<br />|
|msdyn_costprice_base|Edm.Decimal|**Display Name**: Cost Price (Base)<br />**Description**: Value of the Cost Price in base currency.<br />Read-only<br />|
|msdyn_country|Edm.String|**Display Name**: Country/Region<br />**Description**: Type the country/region where the resource is required.<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Duration of total minutes required<br />|
|msdyn_fromdate|Edm.DateTimeOffset|**Display Name**: From Date<br />|
|msdyn_fulfilledduration|Edm.Int32|**Display Name**: Fulfilled Duration<br />**Description**: The fulfilled duration, in minutes.<br />|
|msdyn_fulfilledhours|Edm.Decimal|**Display Name**: Fulfilled Hours (Deprecated)<br />**Description**: Enter the hours fulfilled against requirement when the requirement status is fulfilled.<br />|
|msdyn_hours|Edm.Decimal|**Display Name**: Hours (Deprecated)<br />**Description**: Enter the number of hours for which a requirement is required.<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_isprimary|Edm.Boolean|**Display Name**: Is Primary<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_latitude|Edm.Double|**Display Name**: Latitude<br />**Description**: The latitude to use for the location of a requirement.<br />|
|msdyn_longitude|Edm.Double|**Display Name**: Longitude<br />**Description**: The longitude to use for the location of a requirement.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_percentage|Edm.Decimal|**Display Name**: Percentage<br />**Description**: Enter the percentage of the calendar capacity required.<br />|
|msdyn_quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Enter the number of resources required.<br />|
|msdyn_reasonnotscheduled|Edm.Int32|**Display Name**: Reason Not Scheduled<br />**Description**: Shows why this Resource Requirement isn’t scheduled by the resource scheduling optimization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>None</td></tr><tr><td>192350002</td><td>Latitude Longitude Invalid</td></tr><tr><td>192350003</td><td>Service Territory Invalid</td></tr><tr><td>192350004</td><td>Estimated Duration Less Than Or Equal To 0</td></tr><tr><td>192350005</td><td>Work Location Not Onsite or Location Agnostic</td></tr><tbody></table>|
|msdyn_remainingduration|Edm.Int32|**Display Name**: Remaining Duration<br />|
|msdyn_requeststatus|Edm.String|**Display Name**: Status<br />**Description**: Type the status of the resource request associated with this requirement.<br />|
|msdyn_resourcerequirementid|Edm.Guid|**Display Name**: Resource Requirement<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_schedulingmethod|Edm.Int32|**Display Name**: Scheduling Method<br />**Description**: Whether this resource requirement should be included in the routing optimization or should be scheduled manually.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Optimize</td></tr><tr><td>192350001</td><td>Do Not Optimize</td></tr><tbody></table>|
|msdyn_stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: Type the state/province where the resource is required.<br />|
|msdyn_timefrompromised|Edm.DateTimeOffset|**Display Name**: Time From Promised<br />**Description**: Enter the starting range of the time promised to the account that incidents will be resolved.<br />|
|msdyn_timetopromised|Edm.DateTimeOffset|**Display Name**: Time To Promised<br />**Description**: Enter the ending range of the time promised to the account that incidents will be resolved.<br />|
|msdyn_timewindowend|Edm.DateTimeOffset|**Display Name**: Time Window End<br />|
|msdyn_timewindowstart|Edm.DateTimeOffset|**Display Name**: Time Window Start<br />|
|msdyn_todate|Edm.DateTimeOffset|**Display Name**: To Date<br />**Description**: End date of requirement period<br />|
|msdyn_type|Edm.Int32|**Display Name**: Type<br />**Description**: Select the type of resource requirement.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>New</td></tr><tr><td>192350001</td><td>Extend</td></tr><tbody></table>|
|msdyn_worklocation|Edm.Int32|**Display Name**: Work Location<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Onsite</td></tr><tr><td>690970001</td><td>Depot</td></tr><tr><td>690970002</td><td>Location Agnostic</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Resource Requirement<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Resource Requirement<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_bookingsetupmetadataid_value|msdyn_BookingSetupMetadataId<br />|A unique identifier for the booking setup metadata that is associated with a resource requirement.|
|_msdyn_priority_value|msdyn_Priority<br />|Priority of the requirement. To be taken into consideration while scheduling resources|
|_msdyn_projectid_value|msdyn_projectid<br />|Select the project for which the resource is required.|
|_msdyn_roleid_value|msdyn_roleid<br />|Select the required role.|
|_msdyn_status_value|msdyn_Status<br />|Requirement Status|
|_msdyn_territory_value|msdyn_Territory<br />||
|_msdyn_timegroup_value|msdyn_TimeGroup<br />||
|_msdyn_workhourtemplate_value|msdyn_workhourtemplate<br />|The working hours for a requirement.|
|_msdyn_workorder_value|msdyn_WorkOrder<br />|Unique identifier for Work Order associated with Resource Requirement.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourcerequirement_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourcerequirement_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourcerequirement_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_resourcerequirement_modifiedonbehalfby|
|msdyn_BookingSetupMetadataId|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|msdyn_msdyn_bookingsetupmetadata_msdyn_resource|
|msdyn_Priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_msdyn_priority_msdyn_resourcerequirement_Priority|
|msdyn_projectid|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_resourcerequirement|
|msdyn_roleid|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_resourcerequirement|
|msdyn_Status|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_requirementstatus_resourcerequirement_status|
|msdyn_Territory|[territory EntityType](territory.md)|msdyn_territory_msdyn_resourcerequirement_Territory|
|msdyn_TimeGroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_msdyn_timegroup_msdyn_resourcerequirement_TimeGroup|
|msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_workhourtemplate_msdyn_resourcerequirement_workhourtemplate|
|msdyn_WorkOrder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_resourcerequirement|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_resourcerequirement|
|owningteam|[team EntityType](team.md)|team_msdyn_resourcerequirement|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_resourcerequirement|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_resourcerequirement|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_ResourceRequirement|  
|msdyn_resourcerequirement_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_resourcerequirement|  
|msdyn_resourcerequirement_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_resourcerequirement|  
|msdyn_resourcerequirement_bookableresource|[bookableresource EntityType](bookableresource.md)|msdyn_resourcerequirement_bookableresource|  
|msdyn_resourcerequirement_bookableresourcebooking_ResourceRequirement|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_ResourceRequirement|  
|msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|msdyn_ResourceRequirement|  
|msdyn_resourcerequirement_bookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|msdyn_resourcerequirement_bookingheader|  
|msdyn_resourcerequirement_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_resourcerequirement|  
|msdyn_resourcerequirement_details|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|msdyn_resourcerequirementid|  
|msdyn_resourcerequirement_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_resourcerequirement|  
|msdyn_resourcerequirement_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_resourcerequirement|  
|msdyn_resourcerequirement_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_resourcerequirementid|  
|msdyn_resourcerequirement_request|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_resourcerequirementid|  
|msdyn_resourcerequirement_requirementcharacteristic_resourcerequirement|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|msdyn_ResourceRequirement|  
|msdyn_resourcerequirement_requirementorganizationunit_ResourceRequirement|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|msdyn_ResourceRequirement|  
|msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|msdyn_ResourceRequirement|  
|msdyn_resourcerequirement_requirementresourcepreference_ResourceRequirement|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_ResourceRequirement|  
|msdyn_resourcerequirement_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_resourcerequirement|  
|msdyn_resourcerequirement_systemuser|[systemuser EntityType](systemuser.md)|msdyn_resourcerequirement_systemuser|  

## Operations
The following operations can be used with the msdyn_resourcerequirement entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_AcceptProposedBooking Action](../actions/msdyn_acceptproposedbooking.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_acceptproposedbooking.md](../actions/descriptions/msdyn_acceptproposedbooking.md)]|  
|[msdyn_BookingResourceRequirement Action](../actions/msdyn_bookingresourcerequirement.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_bookingresourcerequirement.md](../actions/descriptions/msdyn_bookingresourcerequirement.md)]|  
|[msdyn_createrequestfromrequirement Action](../actions/msdyn_createrequestfromrequirement.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_createrequestfromrequirement.md](../actions/descriptions/msdyn_createrequestfromrequirement.md)]|  
|[msdyn_RejectProposedBooking Action](../actions/msdyn_rejectproposedbooking.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_rejectproposedbooking.md](../actions/descriptions/msdyn_rejectproposedbooking.md)]|  
|[msdyn_updateremainingresourcerequirement Action](../actions/msdyn_updateremainingresourcerequirement.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_updateremainingresourcerequirement.md](../actions/descriptions/msdyn_updateremainingresourcerequirement.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_resourcerequirement entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/msdyn_resourcerequirement.md](./remarks/msdyn_resourcerequirement.md)]

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