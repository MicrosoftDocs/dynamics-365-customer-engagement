---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_organizationalunit EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aed7003c-e9e7-4f0b-b4df-643b795c339f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_organizationalunit entitytype."
---
# msdyn_organizationalunit EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_organizationalunit.md](./descriptions/msdyn_organizationalunit.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_organizationalunits </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Organizational Unit</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_organizationalunitid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_organizationalunit entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Enter a description of the organizational unit.<br />|
|msdyn_latitude|Edm.Double|**Display Name**: Latitude<br />**Description**: The latitude to use for the location of organizational unit.<br />|
|msdyn_longitude|Edm.Double|**Display Name**: Longitude<br />**Description**: The longitude to use for the location of organizational unit.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_organizationalunitid|Edm.Guid|**Display Name**: Organizational Unit<br />**Description**: Unique identifier for entity instances<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Organizational Unit<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Organizational Unit<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_currency_value|msdyn_currency<br />|Select the currency that the organization uses to track its costs.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_organizationalunit_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_organizationalunit_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_organizationalunit_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_organizationalunit_modifiedonbehalfby|
|msdyn_currency|[transactioncurrency EntityType](transactioncurrency.md)|msdyn_organizationalunit_currency|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_organizationalunit|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_organizationalunit_bookableresource_organizationalunit|[bookableresource EntityType](bookableresource.md)|msdyn_OrganizationalUnit|  
|msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_contractorganizationalunitid|  
|msdyn_msdyn_organizationalunit_msdyn_invoicelinetransaction_ContractOrganizationalUnitId|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_contractorganizationalunitid|  
|msdyn_msdyn_organizationalunit_msdyn_journalline_ContractOrganizationalUnitId|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_contractorganizationalunitid|  
|msdyn_organizationalunit_actual|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_organizationalunit|  
|msdyn_organizationalunit_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_organizationalunit|  
|msdyn_organizationalunit_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_organizationalunit|  
|msdyn_organizationalunit_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_organizationalunit|  
|msdyn_organizationalunit_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_organizationalunit|  
|msdyn_organizationalunit_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_expense|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_opportunity|[opportunity EntityType](opportunity.md)|msdyn_ContractOrganizationalUnitId|  
|msdyn_organizationalunit_opportunitylinedetail|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_pricelevel|[pricelevel EntityType](pricelevel.md)|msdyn_organizationalunit_pricelevel|  
|msdyn_organizationalunit_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_ContractOrganizationalUnitId|  
|msdyn_organizationalunit_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_quote|[quote EntityType](quote.md)|msdyn_ContractOrganizationalUnitId|  
|msdyn_organizationalunit_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_organizationalunit_requirementorganizationunit_OrganizationalUnit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|msdyn_OrganizationalUnit|  
|msdyn_organizationalunit_salesorder|[salesorder EntityType](salesorder.md)|msdyn_ContractOrganizationalUnitId|  
|msdyn_organizationalunit_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_organizationalunit|  
|msdyn_organizationalunit_timeentry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_ResourceOrganizationalUnitId|  
|msdyn_projectparameter_defaultorganizationalunit|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_defaultorganizationalunit|  
|msdyn_resourcecategorypricelevel_organizationalunit|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_organizationalunit|  

## Operations
The following operations can be used with the msdyn_organizationalunit entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_organizationalunit entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_organizationalunit.md](./remarks/msdyn_organizationalunit.md)]

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