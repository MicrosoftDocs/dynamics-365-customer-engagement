---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_questionresponse EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8f6e0c06-b3a6-404b-ac19-9debca1d4bfa
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_questionresponse entitytype."
---
# msdyn_questionresponse EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_questionresponse.md](./descriptions/msdyn_questionresponse.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_questionresponses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Question Response</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_questionresponseid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_questionresponse entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_answerindex|Edm.Int32|**Display Name**: Answer Index<br />**Description**: Shows the answer index.<br />|
|msdyn_maxvalue|Edm.Decimal|**Display Name**: Maximum Value<br />**Description**: Shows the maximum value that's possible for this question response, which is used for reporting purposes.<br />|
|msdyn_name|Edm.String|**Display Name**: Response<br />**Description**: The name of the custom entity.<br />|
|msdyn_orderindex|Edm.Int32|**Display Name**: Order Index<br />**Description**: Shows the order index of the response.<br />|
|msdyn_questionresponseid|Edm.Guid|**Display Name**: Question Response<br />**Description**: Shows the entity instances.<br />|
|msdyn_responsemapping|Edm.Int32|**Display Name**: Response Mapping<br />**Description**: Shows the response mapping.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540065</td><td>None</td></tr><tr><td>986540064</td><td>NPS Comment</td></tr><tr><td>986540000</td><td>First Name</td></tr><tr><td>986540001</td><td>Last Name</td></tr><tr><td>986540002</td><td>Email</td></tr><tr><td>986540021</td><td>Salutation</td></tr><tr><td>986540003</td><td>Web site</td></tr><tr><td>986540004</td><td>Telephone</td></tr><tr><td>986540005</td><td>Job title</td></tr><tr><td>986540006</td><td>Company Name</td></tr><tr><td>986540007</td><td>Street 1</td></tr><tr><td>986540008</td><td>Street 2</td></tr><tr><td>986540009</td><td>Street 3</td></tr><tr><td>986540010</td><td>City</td></tr><tr><td>986540011</td><td>State</td></tr><tr><td>986540012</td><td>Postal code</td></tr><tr><td>986540013</td><td>Country</td></tr><tr><td>986540067</td><td>Facial Expression</td></tr><tr><td>986540068</td><td>Face Selected</td></tr><tr><td>986540014</td><td>Slot 1</td></tr><tr><td>986540015</td><td>Slot 2</td></tr><tr><td>986540016</td><td>Slot 3</td></tr><tr><td>986540017</td><td>Slot 4</td></tr><tr><td>986540018</td><td>Slot 5</td></tr><tr><td>986540019</td><td>None</td></tr><tr><td>986540020</td><td>Satisfaction Rating 1</td></tr><tr><td>986540022</td><td>Custom Text 1</td></tr><tr><td>986540023</td><td>Custom Text 2</td></tr><tr><td>986540024</td><td>Custom Text 3</td></tr><tr><td>986540025</td><td>Custom Text 4</td></tr><tr><td>986540026</td><td>Custom Text 5</td></tr><tr><td>986540048</td><td>Custom Number 1</td></tr><tr><td>986540028</td><td>Custom Number 2</td></tr><tr><td>986540029</td><td>Custom Number 3</td></tr><tr><td>986540030</td><td>Custom Number 4</td></tr><tr><td>986540031</td><td>Custom Number 5</td></tr><tr><td>986540027</td><td>Custom Number 6</td></tr><tr><td>986540035</td><td>Custom Number 7</td></tr><tr><td>986540036</td><td>Custom Number 8</td></tr><tr><td>986540034</td><td>Custom Number 9</td></tr><tr><td>986540037</td><td>Custom Number 10</td></tr><tr><td>986540038</td><td>Custom Number 11</td></tr><tr><td>986540039</td><td>Custom Number 12</td></tr><tr><td>986540040</td><td>Custom Number 13</td></tr><tr><td>986540041</td><td>Custom Number 14</td></tr><tr><td>986540042</td><td>Custom Number 15</td></tr><tr><td>986540043</td><td>Custom Number 16</td></tr><tr><td>986540044</td><td>Custom Number 17</td></tr><tr><td>986540046</td><td>Custom Number 18</td></tr><tr><td>986540045</td><td>Custom Number 19</td></tr><tr><td>986540047</td><td>Custom Number 20</td></tr><tr><td>986540032</td><td>Custom Date 1</td></tr><tr><td>986540033</td><td>Custom Date 2</td></tr><tr><td>986540049</td><td>Linked Answer 1</td></tr><tr><td>986540050</td><td>Linked Answer 2</td></tr><tr><td>986540051</td><td>Linked Answer 3</td></tr><tr><td>986540052</td><td>Linked Answer 4</td></tr><tr><td>986540053</td><td>Linked Answer 5</td></tr><tr><td>986540054</td><td>Linked Answer 6</td></tr><tr><td>986540055</td><td>Linked Answer 7</td></tr><tr><td>986540056</td><td>Linked Answer 8</td></tr><tr><td>986540057</td><td>Linked Answer 9</td></tr><tr><td>986540058</td><td>Linked Answer 10</td></tr><tr><td>986540059</td><td>Linked Answer 11</td></tr><tr><td>986540060</td><td>Linked Answer 12</td></tr><tr><td>986540061</td><td>Linked Answer 13</td></tr><tr><td>986540062</td><td>Linked Answer 14</td></tr><tr><td>986540063</td><td>Linked Answer 15</td></tr><tr><td>986540066</td><td>Customer Effort Score</td></tr><tbody></table>|
|msdyn_valueasdate|Edm.DateTimeOffset|**Display Name**: Value As Date<br />**Description**: Shows the value as a date.<br />|
|msdyn_valueasdecimal|Edm.Decimal|**Display Name**: Value As Decimal<br />**Description**: Select whether to display the value as a decimal.<br />|
|msdyn_valueasstring|Edm.String|**Display Name**: Value As String<br />**Description**: Select  whether to display the value as a string.<br />|
|msdyn_weightedvalue|Edm.Decimal|**Display Name**: Weighted Value<br />**Description**: Shows the weighted value of the response.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the question response.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the question response.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_answerid_value|msdyn_AnswerId<br />|Shows the answer associated with the question response.|
|_msdyn_questionid_value|msdyn_QuestionId<br />|Shows the question associated with the question response.|
|_msdyn_questiontypelookup_value|msdyn_questiontypelookup<br />|Shows the question type associated with the question response.|
|_msdyn_surveyid_value|msdyn_SurveyId<br />|Shows the survey associated with the question response.|
|_msdyn_surveyresponseid_value|msdyn_SurveyResponseId<br />|Shows the survey response associated with the question response.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_questionresponse_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_questionresponse_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_questionresponse_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_questionresponse_modifiedonbehalfby|
|msdyn_AnswerId|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_answer_questionresponse|
|msdyn_QuestionId|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_questionresponse|
|msdyn_questiontypelookup|[msdyn_questiontype EntityType](msdyn_questiontype.md)|msdyn_questiontype_questionresponse_questiontypelookup|
|msdyn_SurveyId|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_msdyn_questionresponse|
|msdyn_SurveyResponseId|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_questionresponse|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_questionresponse|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_questionresponse|
|owningteam|[team EntityType](team.md)|team_msdyn_questionresponse|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_questionresponse|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_questionresponse_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_questionresponse|  
|msdyn_questionresponse_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_questionresponse|  
|msdyn_questionresponse_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_questionresponse|  

## Operations
The following operations can be used with the msdyn_questionresponse entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_questionresponse entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_questionresponse.md](./remarks/msdyn_questionresponse.md)]

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