---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_feedbackmapping EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3ac1f01b-3833-48fa-956f-67abe040c3c5
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_feedbackmapping entitytype."
---
# msdyn_feedbackmapping EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_feedbackmapping.md](./descriptions/msdyn_feedbackmapping.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_feedbackmappings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Feedback Mapping</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_feedbackmappingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_feedbackmapping entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_attributedescription|Edm.String|**Display Name**: Field Description<br />**Description**: Type a description for the field.<br />|
|msdyn_attributedisplayname|Edm.String|**Display Name**: Field Display Name<br />**Description**: Shows the display name of the field.<br />|
|msdyn_attributeformdisplayname|Edm.String|**Display Name**: Field Form Display Name<br />**Description**: Type a name for the field form display.<br />|
|msdyn_attributeoptions|Edm.String|**Display Name**: Field Options<br />**Description**: Shows the options for the field.<br />|
|msdyn_attributerequirementlevel|Edm.Int32|**Display Name**: Field Requirement Level<br />**Description**: Shows the field requirement level.<br />|
|msdyn_attributeschemaname|Edm.String|**Display Name**: Attribute Schema Name<br />**Description**: Schema name of the feedback attribute<br />|
|msdyn_attributestatus|Edm.Int32|**Display Name**: Field Status<br />**Description**: Shows the status of the field.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Awaiting Create</td></tr><tr><td>986540001</td><td>Awaiting Update</td></tr><tr><td>986540002</td><td>Complete</td></tr><tr><td>986540003</td><td>Error</td></tr><tbody></table>|
|msdyn_feedbackentityname|Edm.String|**Display Name**: Feedback Entity Name<br />**Description**: Shows the name of the feedback entity.<br />|
|msdyn_feedbackmappingid|Edm.Guid|**Display Name**: Feedback Mapping<br />**Description**: Shows the entity instances.<br />|
|msdyn_feedbackquestiontype|Edm.Int32|**Display Name**: Feedback Question Type<br />**Description**: Select the feedback question type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>7</td><td>Memo</td></tr><tr><td>14</td><td>String</td></tr><tr><td>0</td><td>Boolean</td></tr><tr><td>3</td><td>Decimal</td></tr><tr><td>5</td><td>Integer</td></tr><tr><td>11</td><td>Picklist</td></tr><tr><td>2</td><td>DateTime</td></tr><tr><td>6</td><td>Lookup</td></tr><tr><td>986540000</td><td>File</td></tr><tbody></table>|
|msdyn_generationset|Edm.Int32|**Display Name**: Generation Set<br />**Description**: Select the generation set.<br />|
|msdyn_log|Edm.String|**Display Name**: Log<br />**Description**: Text containing errors or warnings when mapping generated<br />|
|msdyn_lookupattributename|Edm.String|**Display Name**: Lookup Field Name<br />**Description**: Enter the lookup field name.<br />|
|msdyn_lookupentityname|Edm.String|**Display Name**: Lookup Entity Name<br />**Description**: Enter the lookup entity name.<br />|
|msdyn_multipleresponsetype|Edm.Int32|**Display Name**: Multiple Response Type<br />**Description**: Select the multiple response type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Check boxes</td></tr><tr><td>986540001</td><td>Big buttons</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_nps|Edm.Boolean|**Display Name**: NPS Field<br />**Description**: Select the NPS field.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_optionsetvalue|Edm.Int32|**Display Name**: Optionset Value<br />**Description**: Select a value for the option set.<br />|
|msdyn_overwriteattributeatpublish|Edm.Boolean|**Display Name**: Overwrite Field at Publish<br />**Description**: Select whether to overwrite the field when publishing.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_processedstate|Edm.Int32|**Display Name**: Processed State<br />**Description**: Shows the processed state.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Unprocessed</td></tr><tr><td>192350001</td><td>Processed</td></tr><tbody></table>|
|msdyn_singleresponsetype|Edm.Int32|**Display Name**: Single Response Type<br />**Description**: Select the single response type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Radio buttons</td></tr><tr><td>986540001</td><td>Drop-down list</td></tr><tr><td>986540002</td><td>Big buttons</td></tr><tr><td>986540003</td><td>Scale</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the feedback mapping.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the feedback mapping.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_answerid_value|msdyn_AnswerId<br />|Shows the related answer.|
|_msdyn_linkedanswerid_value|msdyn_LinkedAnswerId<br />|Shows the related linked answer.|
|_msdyn_linkedquestionid_value|msdyn_LinkedQuestionId<br />|Shows the related linked question.|
|_msdyn_questionid_value|msdyn_QuestionId<br />|Shows the related question.|
|_msdyn_surveyid_value|msdyn_SurveyId<br />|Shows the survey associated with the feedback mapping.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_feedbackmapping_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_feedbackmapping_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_feedbackmapping_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_feedbackmapping_modifiedonbehalfby|
|msdyn_AnswerId|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_answer_feedbackmapping_Answer|
|msdyn_LinkedAnswerId|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_msdyn_linkedanswer_msdyn_feedbackmapping_LinkedAnswerId|
|msdyn_LinkedQuestionId|[msdyn_questiontype EntityType](msdyn_questiontype.md)|msdyn_feedbackmapping_LinkedQuestionId|
|msdyn_QuestionId|[msdyn_question EntityType](msdyn_question.md)|msdyn_msdyn_question_msdyn_feedbackmapping_QuestionId|
|msdyn_SurveyId|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_feedbackmapping_SurveyId|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_feedbackmapping|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_feedbackmapping|
|owningteam|[team EntityType](team.md)|team_msdyn_feedbackmapping|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_feedbackmapping|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_feedbackmapping_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_feedbackmapping|  
|msdyn_feedbackmapping_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_feedbackmapping|  
|msdyn_feedbackmapping_msdyn_survey_KeyMeasureMapping|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_KeyMeasureMapping|  
|msdyn_feedbackmapping_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_feedbackmapping|  

## Operations
The following operations can be used with the msdyn_feedbackmapping entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_feedbackmapping entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_feedbackmapping.md](./remarks/msdyn_feedbackmapping.md)]

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