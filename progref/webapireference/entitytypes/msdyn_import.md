---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_import EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0a803da8-d339-4738-ba85-04f0813d2c2e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_import entitytype."
---
# msdyn_import EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_import.md](./descriptions/msdyn_import.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_imports </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>VoC Import</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_importid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_import entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_appendnamewithdate|Edm.Boolean|**Display Name**: Append Name With Date<br />**Description**: Select whether to append the name with the date.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_data|Edm.String|**Display Name**: Data<br />**Description**: Copy the XML from the attachment generated on the survey (publish to ensure the latest updates are included). Import related data first such as Linked Questions and Response Outcome Rules.<br />|
|msdyn_findtext|Edm.String|**Display Name**: Find Text<br />**Description**: Type the find text.<br />|
|msdyn_importid|Edm.Guid|**Display Name**: Survey Import<br />**Description**: Shows the entity instances.<br />|
|msdyn_importimages|Edm.Int32|**Display Name**: Import Images<br />**Description**: Choose "Overwrite" to maintain the IDs and make this survey updatable in the future. Choose "Create" to create a copy that can't be updated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Overwrite</td></tr><tr><td>986540001</td><td>Create</td></tr><tr><td>986540002</td><td>Ignore</td></tr><tbody></table>|
|msdyn_importtheme|Edm.Int32|**Display Name**: Import Theme<br />**Description**: Choose "Overwrite" to maintain the IDs and make this survey updatable in the future.  Choose "Create" to create a copy that can't be updated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Overwrite</td></tr><tr><td>986540001</td><td>Create</td></tr><tr><td>986540002</td><td>Ignore</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_overwriteimages|Edm.Boolean|**Display Name**: Overwrite Images<br />**Description**: Select whether to overwrite the image on import.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_overwritesurvey|Edm.Boolean|**Display Name**: Overwrite Survey<br />**Description**: Choose "True" to maintain the IDs and make this survey updatable in the future.  Choose "False" to create a copy that can't be updated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_overwritetheme|Edm.Boolean|**Display Name**: Overwrite Theme<br />**Description**: Select whether to overwrite the theme on import.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_replacetext|Edm.String|**Display Name**: Replace Text<br />**Description**: Select whether to replace the text on import.<br />|
|msdyn_sectiontoimport|Edm.String|**Display Name**: Section To Import<br />**Description**: Select the section to import.<br />|
|msdyn_setupdata|Edm.String|**Display Name**: Setup Data<br />**Description**: Select whether to import the set up data.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Survey Import<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the Survey import.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_appendtosurvey_value|msdyn_AppendToSurvey<br />|Select whether to append the survey to the existing survey.|
|_msdyn_pagetoattach_value|msdyn_PageToAttach<br />|Shows the page associated with the Survey import.|
|_msdyn_surveycreated_value|msdyn_SurveyCreated<br />|Shows when the survey was created.|
|_msdyn_surveytoattach_value|msdyn_SurveyToAttach<br />|Survey to attach to|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_import_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_import_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_import_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_import_modifiedonbehalfby|
|msdyn_AppendToSurvey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_msdyn_survey_msdyn_import_AppendToSurvey|
|msdyn_PageToAttach|[msdyn_page EntityType](msdyn_page.md)|msdyn_msdyn_page_msdyn_import_Page|
|msdyn_SurveyCreated|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_msdyn_survey_msdyn_import_SurveyCreated|
|msdyn_SurveyToAttach|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_import_SurveyToAttach|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_import|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_import|
|owningteam|[team EntityType](team.md)|team_msdyn_import|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_import|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_import_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_import|  
|msdyn_import_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_import|  
|msdyn_import_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_import|  
|msdyn_import_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_import|  

## Operations
The following operations can be used with the msdyn_import entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_import entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_import.md](./remarks/msdyn_import.md)]

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