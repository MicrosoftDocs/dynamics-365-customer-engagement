---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_workordertype EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 693fd610-2d37-4d85-9c20-2c3064a05b3c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_workordertype entitytype."
---
# msdyn_workordertype EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_workordertype.md](./descriptions/msdyn_workordertype.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_workordertypes </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Work Order Type</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_workordertypeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_workordertype entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_incidentrequired|Edm.Boolean|**Display Name**: Incident Required<br />**Description**: Select whether work orders of this type require an incident to be recorded on the work order.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the work order type.<br />|
|msdyn_taxable|Edm.Boolean|**Display Name**: Taxable<br />**Description**: Select whether work orders of this type are taxable.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_workordertypeid|Edm.Guid|**Display Name**: Work Order Type<br />**Description**: Shows the entity instances.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Work Order Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Work Order Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_pricelist_value|msdyn_pricelist<br />|Default Price List to be used on Work Orders linked to this Work Order Type. Please review the help for further details on Price Lists|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_workordertype_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_workordertype_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_workordertype_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_workordertype_modifiedonbehalfby|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_workordertype_PriceList|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_workordertype|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_workordertype|
|owningteam|[team EntityType](team.md)|team_msdyn_workordertype|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_workordertype|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_workordertype_msdyn_actual_WorkOrderType|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_WorkOrderType|  
|msdyn_msdyn_workordertype_msdyn_agreementbookingsetup_WorkOrderType|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_workordertype|  
|msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_defaultworkordertype|  
|msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|msdyn_workordertype|  
|msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workordertype|  
|msdyn_msdyn_workordertype_opportunity_WorkOrderType|[opportunity EntityType](opportunity.md)|msdyn_workordertype|  
|msdyn_workordertype_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_workordertype|  
|msdyn_workordertype_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_workordertype|  
|msdyn_workordertype_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_workordertype|  
|msdyn_workordertype_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_workordertype|  
|msdyn_workordertype_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_workordertype|  

## Operations
The following operations can be used with the msdyn_workordertype entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_workordertype entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_workordertype.md](./remarks/msdyn_workordertype.md)]

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