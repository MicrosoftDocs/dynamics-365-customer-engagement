---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_page EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 237dfaa2-af1d-43c9-b016-b8ff1d092c91
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_page entitytype."
---
# msdyn_page EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_page.md](./descriptions/msdyn_page.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_pages </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Page</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_pageid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_page entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_autolinkquestions|Edm.Int32|**Display Name**: Automatically Link Questions<br />**Description**: Select whether to automatically create linked question records.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Link</td></tr><tr><td>986540001</td><td>Do not link</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_orderindex|Edm.Int32|**Display Name**: Order Index<br />**Description**: Order in which the pages are displayed<br />|
|msdyn_pageid|Edm.Guid|**Display Name**: Page<br />**Description**: Shows the entity instances.<br />|
|msdyn_pagetype|Edm.Int32|**Display Name**: Page Type<br />**Description**: Select the survey page type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Welcome Page</td></tr><tr><td>986540001</td><td>Questions Page</td></tr><tr><td>986540002</td><td>Completion Page</td></tr><tbody></table>|
|msdyn_pluginignore|Edm.String|**Display Name**: Ignore Plug-In<br />**Description**: For internal use only.<br />|
|msdyn_previewhtml|Edm.String|**Display Name**: Preview<br />**Description**: Shows the formed HTML.<br />|
|msdyn_setdirty|Edm.String|**Display Name**: Check Page State<br />**Description**: Select whether to check if the page is in a consistent state.<br />|
|msdyn_visibility|Edm.Int32|**Display Name**: Visibility<br />**Description**: Select whether the page is visible or hidden.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Visible</td></tr><tr><td>986540001</td><td>Do not display</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the page.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the page.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Shows the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows the delegate user who modified the record.|
|_msdyn_sectiontoimport_value|msdyn_SectionToImport<br />|Import a section into this page as a copy.  Once the page is saved, this field is cleared.|
|_msdyn_surveyid_value|msdyn_SurveyId<br />|Shows the unique identifier relating to the survey.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_page_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_page_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_page_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_page_modifiedonbehalfby|
|msdyn_SectionToImport|[msdyn_section EntityType](msdyn_section.md)|msdyn_msdyn_section_msdyn_page_SectionToImport|
|msdyn_SurveyId|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_page|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_page|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_page|
|owningteam|[team EntityType](team.md)|team_msdyn_page|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_page|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_page_msdyn_import_Page|[msdyn_import EntityType](msdyn_import.md)|msdyn_PageToAttach|  
|msdyn_page_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_page|  
|msdyn_page_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_page|  
|msdyn_page_msdyn_responseaction_Page|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_Page|  
|msdyn_page_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_PageId|  
|msdyn_page_questiongroup|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_PageId|  
|msdyn_page_section|[msdyn_section EntityType](msdyn_section.md)|msdyn_PageId|  
|msdyn_page_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_page|  

## Operations
The following operations can be used with the msdyn_page entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_page entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_page.md](./remarks/msdyn_page.md)]

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