---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_quotebookingsetup EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cb505622-41ab-4d6f-a7d7-3e323c1f351c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_quotebookingsetup entitytype."
---
# msdyn_quotebookingsetup EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_quotebookingsetup.md](./descriptions/msdyn_quotebookingsetup.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_quotebookingsetups </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Quote Booking Setup</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_quotebookingsetupid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_quotebookingsetup entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_autogeneratebooking|Edm.Boolean|**Display Name**: Auto Generate Booking<br />**Description**: Enable if the system should automatically generate Order Bookings for the Booking Dates of this Booking Setup<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_autogenerateworkorder|Edm.Boolean|**Display Name**: Auto Generate Work Order<br />**Description**: Enable if the system should automatically generate Work Orders for the Booking Dates of this Booking Setup<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type a description of this booking setup.<br />|
|msdyn_estimatedcost|Edm.Decimal|**Display Name**: Estimated Cost<br />|
|msdyn_estimatedcost_base|Edm.Decimal|**Display Name**: Estimated Cost (Base)<br />**Description**: Value of the Estimated Cost in base currency.<br />Read-only<br />|
|msdyn_estimatedduration|Edm.Int32|**Display Name**: Estimated Duration<br />**Description**: Shows the duration of the booking.<br />|
|msdyn_estimatedmargin|Edm.Decimal|**Display Name**: EstimatedMargin<br />**Description**: The estimated margin for this Quote Booking Setup<br />|
|msdyn_estimatedmarginperwo|Edm.Decimal|**Display Name**: EstimatedMarginPerWO<br />|
|msdyn_estimatedproductcost|Edm.Decimal|**Display Name**: EstimatedProductCost<br />**Description**: Estimated Costs of all Products that are associated to this Quote Booking Setup<br />|
|msdyn_estimatedproductcost_base|Edm.Decimal|**Display Name**: EstimatedProductCost (Base)<br />**Description**: Value of the EstimatedProductCost in base currency.<br />Read-only<br />|
|msdyn_estimatedproductrevenue|Edm.Decimal|**Display Name**: EstimatedProductRevenue<br />**Description**: The sum of estimated revenue of all products that are associated to this quote booking setup<br />|
|msdyn_estimatedproductrevenue_base|Edm.Decimal|**Display Name**: EstimatedProductRevenue (Base)<br />**Description**: Value of the EstimatedProductRevenue in base currency.<br />Read-only<br />|
|msdyn_estimatedrevenue|Edm.Decimal|**Display Name**: Estimated Revenue<br />|
|msdyn_estimatedrevenue_base|Edm.Decimal|**Display Name**: Estimated Revenue (Base)<br />**Description**: Value of the Estimated Revenue in base currency.<br />Read-only<br />|
|msdyn_estimatedrevenueperwo|Edm.Decimal|**Display Name**: EstimatedRevenuePerWO<br />**Description**: The Estimated Revenue per Work Order<br />|
|msdyn_estimatedrevenueperwo_base|Edm.Decimal|**Display Name**: EstimatedRevenuePerWO (Base)<br />**Description**: Value of the EstimatedRevenuePerWO in base currency.<br />Read-only<br />|
|msdyn_estimatedservicecost|Edm.Decimal|**Display Name**: EstimatedServiceCost<br />**Description**: The sum of the estimated costs of all quote booking services that are associated to this quote booking setup<br />|
|msdyn_estimatedservicecost_base|Edm.Decimal|**Display Name**: EstimatedServiceCost (Base)<br />**Description**: Value of the EstimatedServiceCost in base currency.<br />Read-only<br />|
|msdyn_estimatedservicerevenue|Edm.Decimal|**Display Name**: EstimatedServiceRevenue<br />**Description**: The sum of estimated revenue of all services that are associated to this quote booking setup<br />|
|msdyn_estimatedservicerevenue_base|Edm.Decimal|**Display Name**: EstimatedServiceRevenue (Base)<br />**Description**: Value of the EstimatedServiceRevenue in base currency.<br />Read-only<br />|
|msdyn_generateworkorderdaysinadvance|Edm.Int32|**Display Name**: Generate Work Order Days In Advance<br />**Description**: Specify how many days in advance of the Booking Date the system should automatically generate a Work Order<br />|
|msdyn_Internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_margin|Edm.Decimal|**Display Name**: Margin<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_numberofwo|Edm.Int32|**Display Name**: NumberOfWO<br />|
|msdyn_postbookingflexibility|Edm.Int32|**Display Name**: Post Booking Flexibility<br />**Description**: Shows the flexibility of days after the booking date.<br />|
|msdyn_postponegenerationuntil|Edm.DateTimeOffset|**Display Name**: Postpone Generation Until<br />**Description**: Shows the date until which Work Order generation can be postponed<br />|
|msdyn_prebookingflexibility|Edm.Int32|**Display Name**: Pre Booking Flexibility<br />**Description**: Shows the flexibility of days prior to the booking date.<br />|
|msdyn_preferredstarttime|Edm.DateTimeOffset|**Display Name**: Preferred Start Time<br />**Description**: Shows the preferred time to booking.<br />|
|msdyn_quotebookingsetupid|Edm.Guid|**Display Name**: Quote Booking Setup<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_quotedetailid|Edm.String|**Display Name**: QuoteDetailId<br />|
|msdyn_recurrencesettings|Edm.String|**Display Name**: Recurrence Settings<br />**Description**: Stores the booking recurrence settings.<br />|
|msdyn_revision|Edm.Int32|**Display Name**: Revision<br />**Description**: For internal use only.<br />|
|msdyn_timewindowend|Edm.DateTimeOffset|**Display Name**: Time Window End<br />**Description**: Shows the time window up until when this can be booked.<br />|
|msdyn_timewindowstart|Edm.DateTimeOffset|**Display Name**: Time Window Start<br />**Description**: Shows the time window from when this can be booked.<br />|
|msdyn_workordersummary|Edm.String|**Display Name**: Work Order Summary<br />**Description**: Shows the work order summary to be set on the work orders generated.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Quote Booking Setup<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Quote Booking Setup<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_preferredresource_value|msdyn_preferredresource<br />|Preferred Resource to booked|
|_msdyn_priority_value|msdyn_priority<br />|Booking Priority|
|_msdyn_quote_value|msdyn_quote<br />|Quote this Booking Setup relates to|
|_msdyn_workordertype_value|msdyn_workordertype<br />|Work Order Type to be used on generated Work Orders|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the id of the stage where the entity is located.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotebookingsetup_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotebookingsetup_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotebookingsetup_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotebookingsetup_modifiedonbehalfby|
|msdyn_preferredresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource|
|msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority|
|msdyn_quote|[quote EntityType](quote.md)|msdyn_quote_msdyn_quotebookingsetup_Quote|
|msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_quotebookingsetup|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_quotebookingsetup|
|owningteam|[team EntityType](team.md)|team_msdyn_quotebookingsetup|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_quotebookingsetup|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_quotebookingsetup|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_quotebookingsetup|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingsetup|  
|msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingsetup|  
|msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingsetup|  
|msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_QuoteBookingSetup|  
|msdyn_quotebookingsetup_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_quotebookingsetup|  
|msdyn_quotebookingsetup_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_quotebookingsetup|  
|msdyn_quotebookingsetup_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_quotebookingsetup|  
|msdyn_quotebookingsetup_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_quotebookingsetup|  
|msdyn_quotebookingsetup_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_quotebookingsetup|  

## Operations
The following operations can be used with the msdyn_quotebookingsetup entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_quotebookingsetup entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_quotebookingsetup.md](./remarks/msdyn_quotebookingsetup.md)]

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