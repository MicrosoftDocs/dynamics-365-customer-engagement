---
title: "Microsoft Dynamics 365 Customer Engagement contracttemplate EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 89ff88ce-2f6b-4fe2-971a-9116a69943bf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API contracttemplate entitytype."
---
# contracttemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/contracttemplate.md](./descriptions/contracttemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]contracttemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Contract Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>contracttemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The contracttemplate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|abbreviation|Edm.String|**Display Name**: Abbreviation<br />**Description**: Abbreviation of the contract template name.<br />|
|allotmenttypecode|Edm.Int32|**Display Name**: Allotment Type<br />**Description**: Criteria for the contracts based on the template, such as number of cases, time, or coverage dates.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Number of Cases</td></tr><tr><td>2</td><td>Time</td></tr><tr><td>3</td><td>Coverage Dates</td></tr><tbody></table>|
|billingfrequencycode|Edm.Int32|**Display Name**: Billing Frequency <br />**Description**: How often the customer or account is to be billed in contracts that are based on the template.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Monthly</td></tr><tr><td>2</td><td>Bimonthly</td></tr><tr><td>3</td><td>Quarterly</td></tr><tr><td>4</td><td>Semiannually</td></tr><tr><td>5</td><td>Annually</td></tr><tbody></table>|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|contractservicelevelcode|Edm.Int32|**Display Name**: Contract Service Level<br />**Description**: Unique identifier of the level of service specified in contracts that are based on the template.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Gold</td></tr><tr><td>2</td><td>Silver</td></tr><tr><td>3</td><td>Bronze</td></tr><tbody></table>|
|contracttemplateid|Edm.Guid|**Display Name**: Contract Template<br />**Description**: Unique identifier of the contract template.<br />|
|contracttemplateidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the contract template was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the contract template.<br />|
|effectivitycalendar|Edm.String|**Display Name**: Support Calendar<br />**Description**: Days of the week and times for which contracts based on the template are effective.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the contract template was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the contract template.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|usediscountaspercentage|Edm.Boolean|**Display Name**: Use Discount as Percentage<br />**Description**: Specifies whether the discount is a percentage or a monetary amount in contracts based on the template.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the contract template.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the contracttemplate.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the contract template.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the contracttemplate.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_contracttemplatebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_contracttemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_contracttemplatebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_contracttemplate_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_contract_templates|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|contract_template_contracts|[contract EntityType](contract.md)|contracttemplateid|  
|ContractTemplate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_contracttemplate|  
|ContractTemplate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_contracttemplate|  
|ContractTemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_contracttemplate_syncerror|  

## Solutions
The following solutions include the contracttemplate entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/contracttemplate.md](./remarks/contracttemplate.md)]

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