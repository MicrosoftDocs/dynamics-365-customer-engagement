---
title: "Microsoft Dynamics 365 Customer Engagement bookableresource EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 50a2b8b0-ca74-4012-97cb-e4df9a03571e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bookableresource entitytype."
---
# bookableresource EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bookableresource.md](./descriptions/bookableresource.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]bookableresources </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bookable Resource</td></tr>
<tr><td><b>Primary Key:</b></td><td>bookableresourceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bookableresourceid|Edm.Guid|**Display Name**: Bookable Resource<br />**Description**: Unique identifier of the resource.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the bookableresource with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_bookingstodrip|Edm.Int32|**Display Name**: Bookings To Drip<br />**Description**: The number of bookings to drip on the Mobile . This field is disabled/enabled based on Enable Drip Scheduling field<br />|
|msdyn_displayonscheduleassistant|Edm.Boolean|**Display Name**: Enable for Availability Search<br />**Description**: Specify if this resource should be enabled for availablity search.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_displayonscheduleboard|Edm.Boolean|**Display Name**: Display On Schedule Board<br />**Description**: Specify if this resource should be displayed on the schedule board.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_enabledripscheduling|Edm.Boolean|**Display Name**: Enable Drip Scheduling<br />**Description**: Enables drip scheduling on the mobile app.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_endlocation|Edm.Int32|**Display Name**: End Location<br />**Description**: Shows the default ending location type when booking daily schedules for this resource.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970002</td><td>Location Agnostic</td></tr><tr><td>690970000</td><td>Resource Address</td></tr><tr><td>690970001</td><td>Organizational Unit Address</td></tr><tbody></table>|
|msdyn_generictype|Edm.Int32|**Display Name**: Generic Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Service Center</td></tr><tbody></table>|
|msdyn_hourlyrate|Edm.Decimal|**Display Name**: Hourly Rate<br />|
|msdyn_hourlyrate_base|Edm.Decimal|**Display Name**: Hourly Rate (Base)<br />**Description**: Value of the Hourly Rate in base currency.<br />Read-only<br />|
|msdyn_isgenericresourceprojectscoped|Edm.Boolean|**Display Name**: Is Default<br />**Description**: Is Default<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_isglympseenabled|Edm.Boolean|**Display Name**: Is Glympse Enabled<br />**Description**: Field to indicate if the bookable resource is glympse enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_optimizeroute|Edm.Boolean|**Display Name**: Optimize Schedule<br />**Description**: Indicates if a resource will be included in scheduling optimization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_primaryemail|Edm.String|**Display Name**: Primary EMail<br />|
|msdyn_resourcereasonnotscheduled|Edm.Int32|**Display Name**: Reason Not Scheduled<br />**Description**: Shows why this Bookable Resource is not scheduled by the resource scheduling optimization engine.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>None</td></tr><tr><td>192350002</td><td>Latitude Longitude Invalid</td></tr><tr><td>192350003</td><td>Service Territory Invalid</td></tr><tr><td>192350004</td><td>Start End Location Invalid</td></tr><tr><td>192350005</td><td>Organizational Unit Invalid</td></tr><tr><td>192350006</td><td>Organizational Unit Latitude Longitude Invalid</td></tr><tbody></table>|
|msdyn_startlocation|Edm.Int32|**Display Name**: Start Location<br />**Description**: Shows the default starting location type when booking daily schedules for this resource.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970002</td><td>Location Agnostic</td></tr><tr><td>690970000</td><td>Resource Address</td></tr><tr><td>690970001</td><td>Organizational Unit Address</td></tr><tbody></table>|
|msdyn_targetutilization|Edm.Int32|**Display Name**: Target Utilization<br />**Description**: Shows the target utilization for the resource.<br />|
|msdyn_timeoffapprovalrequired|Edm.Boolean|**Display Name**: Time Off Approval Required<br />**Description**: Specifies if approval required for Time Off Requests.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the resource.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|resourcetype|Edm.Int32|**Display Name**: Resource Type<br />**Description**: Select whether the resource is a user, equipment, contact, account, generic resource or a group of resources.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Generic</td></tr><tr><td>2</td><td>Contact</td></tr><tr><td>3</td><td>User</td></tr><tr><td>4</td><td>Equipment</td></tr><tr><td>5</td><td>Account</td></tr><tr><td>6</td><td>Group</td></tr><tbody></table>|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Bookable Resource<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Bookable Resource<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezone|Edm.Int32|**Display Name**: Time Zone<br />**Description**: Specifies the timezone for the resource's working hours.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value|AccountId<br />|Select the account that represents this resource.|
|_calendarid_value|calendarid<br />|Specifies the working days and hours of the resource.|
|_contactid_value|ContactId<br />|Select the contact that represents this resource.|
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_glympseagent_value|msdyn_glympseagent<br />||
|_msdyn_organizationalunit_value|msdyn_OrganizationalUnit<br />|Organizational Unit that resource belong to|
|_msdyn_warehouse_value|msdyn_warehouse<br />|Default Warehouse for this resource.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the BookableResource with respect to the base currency.|
|_userid_value|UserId<br />|Select the user who represents this resource.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|AccountId|[account EntityType](account.md)|account_bookableresource_AccountId|
|calendarid|[calendar EntityType](calendar.md)|calendar_bookableresources|
|ContactId|[contact EntityType](contact.md)|contact_bookableresource_ContactId|
|createdbyname|[systemuser EntityType](systemuser.md)|lk_bookableresource_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresource_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_bookableresource_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresource_modifiedonbehalfby|
|msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_msdyn_glympseagent_bookableresource_GlympseAgent|
|msdyn_OrganizationalUnit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_msdyn_organizationalunit_bookableresource_organizationalunit|
|msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_bookableresource_Warehouse|
|ownerid|[principal EntityType](principal.md)|owner_bookableresource|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_bookableresource|
|owningteam|[team EntityType](team.md)|team_bookableresource|
|owninguser|[systemuser EntityType](systemuser.md)|user_bookableresource|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_bookableresource|
|UserId|[systemuser EntityType](systemuser.md)|systemuser_bookableresource_UserId|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bookableresource_Annotations|[annotation EntityType](annotation.md)|objectid_bookableresource|  
|bookableresource_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_bookableresource|  
|bookableresource_bookableresourcebooking_Resource|[bookableresourcebooking EntityType](bookableresourcebooking.md)|Resource|  
|bookableresource_bookableresourcecategoryassn_Resource|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|Resource|  
|bookableresource_bookableresourcecharacteristic_Resource|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|Resource|  
|bookableresource_bookableresourcegroup_ChildResource|[bookableresourcegroup EntityType](bookableresourcegroup.md)|ChildResource|  
|bookableresource_bookableresourcegroup_ParentResource|[bookableresourcegroup EntityType](bookableresourcegroup.md)|ParentResource|  
|bookableresource_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_bookableresource|  
|bookableresource_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_bookableresource|  
|bookableresource_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_bookableresource|  
|BookableResource_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_bookableresource_syncerror|  
|msdyn_bookableresource_account_PreferredResource|[account EntityType](account.md)|msdyn_PreferredResource|  
|msdyn_bookableresource_bookableresourcebooking_ResourceGroup|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_resourcegroup|  
|msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|msdyn_bookableresourceid|  
|msdyn_bookableresource_msdyn_actual_bookableresource|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_agreementbookingdate_Resource|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_resource|  
|msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_preferredresource|  
|msdyn_bookableresource_msdyn_delegation_delegationfrom|[msdyn_delegation EntityType](msdyn_delegation.md)|msdyn_delegationfrom|  
|msdyn_bookableresource_msdyn_delegation_delegationto|[msdyn_delegation EntityType](msdyn_delegation.md)|msdyn_delegationto|  
|msdyn_bookableresource_msdyn_estimateline_bookableresource|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_expense_bookableresource|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_fact_bookableresource|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_findworkevent_BookableResource|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|msdyn_BookableResource|  
|msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_adjustedbyresource|  
|msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_requestedbyresource|  
|msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_transferredbyresource|  
|msdyn_bookableresource_msdyn_invoicelinetransaction_bookableresource|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_journalline_bookableresource|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_opportunitylinetransaction_bookableresource|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_orderlinetransaction_bookableresource|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_projectapproval_bookableresource|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_projectapproval_SubmittedBy|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_SubmittedBy|  
|msdyn_bookableresource_msdyn_projecttaskstatususer_BookableResource|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|msdyn_BookableResource|  
|msdyn_bookableresource_msdyn_projectteam_bookableresourceid|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_bookableresourceid|  
|msdyn_bookableresource_msdyn_projectteammembersignup_BookableResource|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|msdyn_BookableResource|  
|msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_requestedbyresource|  
|msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|msdyn_preferredresource|  
|msdyn_bookableresource_msdyn_quotelinetransaction_bookableresource|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_BookableResource|  
|msdyn_bookableresource_msdyn_resourceassignment_bookableresourceid|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|msdyn_bookableresourceid|  
|msdyn_bookableresource_msdyn_resourceterritory_Resource|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resource|  
|msdyn_bookableresource_msdyn_timeentry_bookableresource|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_bookableresource|  
|msdyn_bookableresource_msdyn_timeoffrequest_Resource|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_resource|  
|msdyn_bookableresource_msdyn_userworkhistory_Bookableresource|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|msdyn_Bookableresource|  
|msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_bookableresourceid|  
|msdyn_bookableresource_msdyn_workorder_PreferredResource|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_preferredresource|  
|msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_resource|  
|msdyn_resourcerequirement_bookableresource|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_bookableresource|  

## Operations
The following operations can be used with the bookableresource entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_GetBookingDetailsByResource Action](../actions/msdyn_getbookingdetailsbyresource.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_getbookingdetailsbyresource.md](../actions/descriptions/msdyn_getbookingdetailsbyresource.md)]|  
|[msdyn_GetResourceBookingDetails Action](../actions/msdyn_getresourcebookingdetails.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_getresourcebookingdetails.md](../actions/descriptions/msdyn_getresourcebookingdetails.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the bookableresource entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Integration with Glympse Solution](../solutions/glympse.md)|[!INCLUDE[../solutions/descriptions/glympse.md](../solutions/descriptions/glympse.md)]|  
|[Microsoft Dynamics Scheduling Workload Solution](../solutions/scheduling.md)|[!INCLUDE[../solutions/descriptions/scheduling.md](../solutions/descriptions/scheduling.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Resource Scheduling Optimization Solution](../solutions/resourceschedulingoptimization.md)|[!INCLUDE[../solutions/descriptions/resourceschedulingoptimization.md](../solutions/descriptions/resourceschedulingoptimization.md)]|    

[!INCLUDE[./remarks/bookableresource.md](./remarks/bookableresource.md)]

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