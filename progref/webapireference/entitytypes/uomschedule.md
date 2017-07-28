---
title: "Microsoft Dynamics 365 Customer Engagement uomschedule EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cfe7927a-a45b-49c1-8cb5-47119e75c2aa
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API uomschedule entitytype."
---
# uomschedule EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/uomschedule.md](./descriptions/uomschedule.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]uomschedules </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Unit Group</td></tr>
<tr><td><b>Primary Key:</b></td><td>uomscheduleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The uomschedule entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|baseuomname|Edm.String|**Display Name**: Base Unit name<br />**Description**: Name of the base unit.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the unit group was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the unit group.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the unit group was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the unit group.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Unit Group.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Unit Group.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|uomscheduleid|Edm.Guid|**Display Name**: Unit Group<br />**Description**: Unique identifier for the unit group.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the unit group.|
|_createdbyexternalparty_value||Shows the external party who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the uomschedule.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the unit group.|
|_modifiedbyexternalparty_value||Shows the external party who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the uomschedule.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_uomschedulebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_uomschedulebase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_uomschedulebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_uomschedulebase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_uof_schedules|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|contract_detail_unit_of_measure_schedule|[contractdetail EntityType](contractdetail.md)|uomscheduleid|  
|msdyn_uomschedule_msdyn_actual_UnitSchedule|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_estimateline_UnitSchedule|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_journalline_UnitSchedule|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_transactioncategory_UnitGroup|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_UnitGroup|  
|msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_UnitSchedule|  
|msdyn_uomschedule_msdyn_transactiontype_UnitGroup|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|msdyn_UnitGroup|  
|unit_of_measure_schedule_conversions|[uom EntityType](uom.md)|uomscheduleid|  
|unit_of_measure_schedule_product_price_level|[productpricelevel EntityType](productpricelevel.md)|uomscheduleid|  
|unit_of_measurement_schedule_products|[product EntityType](product.md)|defaultuomscheduleid|  
|UoMSchedule_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_uomschedule|  
|UoMSchedule_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_uomschedule|  
|UoMSchedule_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_uomschedule_syncerror|  

## Solutions
The following solutions include the uomschedule entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/uomschedule.md](./remarks/uomschedule.md)]

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