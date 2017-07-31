---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_marketingformtemplate EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 47c2bb43-04fc-43e8-bc59-bbdc06af3b59
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_marketingformtemplate entitytype."
---
# msdyncrm_marketingformtemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_marketingformtemplate.md](./descriptions/msdyncrm_marketingformtemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyncrm_marketingformtemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Marketing Form Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_marketingformtemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_marketingformtemplate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_entityupdatebehavioronsubmit|Edm.Int32|**Display Name**: Update Contacts/Leads<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Contacts and Leads</td></tr><tr><td>1</td><td>Only Contacts</td></tr><tr><td>2</td><td>Only Leads</td></tr><tbody></table>|
|msdyncrm_formcontrolmapping|Edm.String|**Display Name**: Form Control Mapping<br />|
|msdyncrm_formdefinition|Edm.String|**Display Name**: Form Definition<br />|
|msdyncrm_marketingformtemplateid|Edm.Guid|**Display Name**: MarketingFormTemplate<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyncrm_purpose|Edm.Int32|**Display Name**: Purpose<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Contact capture</td></tr><tr><td>1</td><td>Newsletter subscription</td></tr><tr><td>2</td><td>Lead generation</td></tr><tr><td>3</td><td>Collateral download</td></tr><tr><td>4</td><td>Event registration</td></tr><tr><td>5</td><td>Event feedback</td></tr><tbody></table>|
|msdyncrm_validforpagetype|Edm.Int32|**Display Name**: Valid For<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Landing page</td></tr><tr><td>1</td><td>Subscription center</td></tr><tr><td>2</td><td>Forward to friend</td></tr><tbody></table>|
|msdyncrm_visualstyle|Edm.Int32|**Display Name**: Visual style<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>1-column</td></tr><tr><td>1</td><td>2-column</td></tr><tr><td>2</td><td>Mixed</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Marketing Form Template<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the Status of the Marketing Form Template<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Live</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingformtemplate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingformtemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingformtemplate_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingformtemplate_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_marketingformtemplate|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_marketingformtemplate|
|owningteam|[team EntityType](team.md)|team_msdyncrm_marketingformtemplate|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_marketingformtemplate|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_formtemplate_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|msdyncrm_formtemplate_marketingformfield|  
|msdyncrm_marketingformtemplate_Annotations|[annotation EntityType](annotation.md)|objectid_msdyncrm_marketingformtemplate|  
|msdyncrm_marketingformtemplate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_marketingformtemplate|  
|msdyncrm_marketingformtemplate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_marketingformtemplate|  
|msdyncrm_marketingformtemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_marketingformtemplate|  
|msdyncrm_msdyncrm_marketingformtemplate_list|[list EntityType](list.md)|msdyncrm_msdyncrm_marketingformtemplate_list|  
|msdyncrm_msdyncrm_marketingformtemplate_msdyncrm_marketingform_marketingformtemplate|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_marketingformtemplate|  

## Operations
The following operations can be used with the msdyncrm_marketingformtemplate entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_marketingformtemplate entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_marketingformtemplate.md](./remarks/msdyncrm_marketingformtemplate.md)]

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