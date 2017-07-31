---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_projectparameter EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9c6df298-6b3e-42be-b958-7a956630c607
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_projectparameter entitytype."
---
# msdyn_projectparameter EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_projectparameter.md](./descriptions/msdyn_projectparameter.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_projectparameters </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Project Parameter</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_projectparameterid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_description</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_projectparameter entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_allowskillupdatebyresource|Edm.Boolean|**Display Name**: Allow skill update by resource<br />**Description**: Allow resources to update their skills via the Project Finder Mobile app.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type the name of the project parameters.<br />|
|msdyn_projectparameterid|Edm.Guid|**Display Name**: Project Parameter<br />**Description**: Shows the entity instances.<br />|
|msdyn_projectresourcerequirementsvisibletore|Edm.Boolean|**Display Name**: Resource requirements visible to resources<br />**Description**: Select whether project resource requirements are visible to resources.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_resourceallocationmode|Edm.Int32|**Display Name**: Resource allocation mode<br />**Description**: Select the default method for allocating resources to projects.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Centralized</td></tr><tr><td>2</td><td>Hybrid</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Project Parameter<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Project Parameter<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_defaultorganizationalunit_value|msdyn_defaultorganizationalunit<br />|Select the default organizational unit that will be used for new resources.|
|_msdyn_defaultworktemplate_value|msdyn_defaultWorkTemplate<br />|Select the default work template for new projects.|
|_msdyn_invoicefrequency_value|msdyn_invoicefrequency<br />|Select the default frequency for generating invoices.|
|_msdyn_projectmanagerrole_value|msdyn_projectmanagerrole<br />|Shows the default role to be used when a project manager is added to the project team.|
|_msdyn_teammemberrole_value|msdyn_teammemberrole<br />|Shows the default role to be used when a team member is added to the project team.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectparameter_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectparameter_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectparameter_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectparameter_modifiedonbehalfby|
|msdyn_defaultorganizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_projectparameter_defaultorganizationalunit|
|msdyn_defaultWorkTemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate|
|msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency|
|msdyn_projectmanagerrole|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole|
|msdyn_teammemberrole|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_projectparameter|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|msdyn_ProjectParameter|  
|msdyn_projectparameter_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_projectparameter|  
|msdyn_projectparameter_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_projectparameter|  
|msdyn_projectparameter_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_projectparameter|  
|msdyn_projectparameter_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_projectparameter|  
|msdyn_projectparameter_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_projectparameter|  
|msdyn_projectparameter_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_projectparameter|  

## Operations
The following operations can be used with the msdyn_projectparameter entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_projectparameter entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_projectparameter.md](./remarks/msdyn_projectparameter.md)]

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