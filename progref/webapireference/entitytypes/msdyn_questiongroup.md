---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_questiongroup EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fb0ff6a9-d456-48ac-95b4-75a5297712fe
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_questiongroup entitytype."
---
# msdyn_questiongroup EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_questiongroup.md](./descriptions/msdyn_questiongroup.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_questiongroups </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Grid</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_questiongroupid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_questiongroup entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_columnheaders|Edm.String|**Display Name**: Column Headers<br />**Description**: Carriage return list of headers<br />|
|msdyn_displaylogic|Edm.Int32|**Display Name**: Display Logic<br />**Description**: Select whether to display the logic.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>All are true (AND)</td></tr><tr><td>986540001</td><td>Any are true (OR)</td></tr><tbody></table>|
|msdyn_gridtext|Edm.String|**Display Name**: Grid Text<br />**Description**: Type the text for the grid.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_orderindex|Edm.Int32|**Display Name**: Order Index<br />**Description**: Display order of this question group in relation to others<br />|
|msdyn_pluginignore|Edm.String|**Display Name**: Ignore Plug-In<br />**Description**: For internal use only.<br />|
|msdyn_questiongroupid|Edm.Guid|**Display Name**: Question Group<br />**Description**: Shows the entity instances.<br />|
|msdyn_questions|Edm.String|**Display Name**: Questions<br />**Description**: Type the questions.<br />|
|msdyn_ratinghalfstar|Edm.Boolean|**Display Name**: Half Rating?<br />**Description**: Should the rating control show half stars, for example,  4.5?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_ratingimagetype|Edm.Int32|**Display Name**: Rating Image Type<br />**Description**: Select an image type for rating.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Star</td></tr><tr><td>986540001</td><td>Smilies - sad to happy</td></tr><tr><td>986540002</td><td>Smilies - neutral to happy</td></tr><tr><td>986540003</td><td>Flags</td></tr><tbody></table>|
|msdyn_ratingnumberofitems|Edm.Int32|**Display Name**: Number of Items for Rating<br />**Description**: Select the number of rating items.<br />|
|msdyn_ratingshowcancel|Edm.Boolean|**Display Name**: Rating Show Cancel<br />**Description**: Select whether a rating can be canceled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_ratingsize|Edm.Int32|**Display Name**: Rating Size<br />**Description**: Size of rating image<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>24</td></tr><tbody></table>|
|msdyn_ratingtooltips|Edm.String|**Display Name**: Rating Tool Tips<br />**Description**: Tool tips to display when respondent mouse is hovered over each item.<br />|
|msdyn_reportingtext|Edm.String|**Display Name**: Reporting Text<br />**Description**: Reporting text can be used as an alternative and abbreviated text for reports.<br />|
|msdyn_requireresponseforallquestions|Edm.Boolean|**Display Name**: Require Response<br />**Description**: Select whether a response is required for all questions.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_scoredefinition|Edm.Int32|**Display Name**: Score Definition<br />**Description**: Enter a definition for the score.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540002</td><td>Ignore</td></tr><tr><td>986540000</td><td>Auto (0-100)</td></tr><tr><td>986540001</td><td>Auto (100-0)</td></tr><tr><td>986540004</td><td>User Specified Range / Weight</td></tr><tr><td>986540003</td><td>NPS</td></tr><tbody></table>|
|msdyn_scoremaxvalue|Edm.Int32|**Display Name**: Score Maximum Value<br />**Description**: Select the maximum score value.<br />|
|msdyn_scoreminvalue|Edm.Int32|**Display Name**: Score Minimum Value<br />**Description**: Select the minimum score value.<br />|
|msdyn_setdirty|Edm.String|**Display Name**: Check Grid State<br />**Description**: Select whether to check if the grid is in a consistent state.<br />|
|msdyn_type|Edm.Int32|**Display Name**: Type<br />**Description**: Select the type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Question and answer</td></tr><tr><td>986540002</td><td>Grid of single select questions</td></tr><tr><td>986540003</td><td>Grid of multiple select questions</td></tr><tr><td>986540001</td><td>Grid of image scales</td></tr><tr><td>986540004</td><td>Fixed sum questions</td></tr><tbody></table>|
|msdyn_useverticaltext|Edm.Int32|**Display Name**: Column Text Rotation<br />**Description**: Rotate the text 90 degrees<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Rotate 90 degrees</td></tr><tr><td>986540001</td><td>No rotation - aligned bottom</td></tr><tr><td>986540002</td><td>No rotation - aligned top</td></tr><tbody></table>|
|msdyn_visibility|Edm.Int32|**Display Name**: Visibility<br />**Description**: Select whether the grid is visible.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Visible</td></tr><tr><td>986540001</td><td>Do not display</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the question group.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the question group.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_importgrid_value|msdyn_ImportGrid<br />|Shows the grid associated with the grid.|
|_msdyn_importquestion_value|msdyn_ImportQuestion<br />|Provides advanced functionality to import and transpose a question and its answers|
|_msdyn_pageid_value|msdyn_PageId<br />|Shows the related page.|
|_msdyn_sectionid_value|msdyn_SectionId<br />|Shows the unique reference identifier of the related section.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_questiongroup_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_questiongroup_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_questiongroup_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_questiongroup_modifiedonbehalfby|
|msdyn_ImportGrid|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_msdyn_questiongroup_msdyn_questiongroup_ImportGrid|
|msdyn_ImportQuestion|[msdyn_question EntityType](msdyn_question.md)|msdyn_msdyn_question_msdyn_questiongroup_ImportQuestion|
|msdyn_PageId|[msdyn_page EntityType](msdyn_page.md)|msdyn_page_questiongroup|
|msdyn_SectionId|[msdyn_section EntityType](msdyn_section.md)|msdyn_section_questiongroup|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_questiongroup|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_questiongroup|
|owningteam|[team EntityType](team.md)|team_msdyn_questiongroup|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_questiongroup|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_questiongroup_msdyn_questiongroup_ImportGrid|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_ImportGrid|  
|msdyn_questiongroup_answer|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_GridId|  
|msdyn_questiongroup_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_questiongroup|  
|msdyn_questiongroup_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_questiongroup|  
|msdyn_questiongroup_msdyn_responseaction_Grid|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_Grid|  
|msdyn_questiongroup_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_QuestionGroupId|  
|msdyn_questiongroup_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_questiongroup|  

## Operations
The following operations can be used with the msdyn_questiongroup entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_questiongroup entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_questiongroup.md](./remarks/msdyn_questiongroup.md)]

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