---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_answer EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8759539f-cd23-40ac-87f3-6b0f0456209b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_answer entitytype."
---
# msdyn_answer EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_answer.md](./descriptions/msdyn_answer.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_answers </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Answer</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_answerid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_answer entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_answerid|Edm.Guid|**Display Name**: Answer<br />**Description**: Shows the entity instances.<br />|
|msdyn_answerindex|Edm.Int32|**Display Name**: Answer Index<br />**Description**: Shows the answer index.<br />|
|msdyn_default|Edm.Boolean|**Display Name**: Default<br />**Description**: Select whether this is the default answer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_faceexpression|Edm.Int32|**Display Name**: Face Expression<br />**Description**: Select the face expression value.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>No expression</td></tr><tr><td>986540001</td><td>Satisfied</td></tr><tr><td>986540002</td><td>Very Satisfied</td></tr><tr><td>986540003</td><td>Delighted</td></tr><tr><td>986540004</td><td>Not engaged</td></tr><tr><td>986540005</td><td>Not sure / don't know</td></tr><tr><td>986540006</td><td>Bored</td></tr><tr><td>986540007</td><td>Waiting</td></tr><tr><td>986540008</td><td>Disappointed</td></tr><tr><td>986540009</td><td>Sad</td></tr><tr><td>986540010</td><td>Annoyed</td></tr><tr><td>986540011</td><td>Angry</td></tr><tbody></table>|
|msdyn_imageurl|Edm.String|**Display Name**: Image Url<br />**Description**: Image URL of vertical text.  This can be changed to a custom uploaded image if required.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_orderindex|Edm.Int32|**Display Name**: Order Index<br />**Description**: Order in which to display the answers<br />|
|msdyn_pluginignore|Edm.String|**Display Name**: Ignore Plug-In<br />**Description**: For internal use only.<br />|
|msdyn_reportingtext|Edm.String|**Display Name**: Reporting Text<br />**Description**: Text used for reporting and feedback generation purposes.  Usually, shortens or simplifies answer text.<br />|
|msdyn_setdirty|Edm.String|**Display Name**: Check Answer State<br />**Description**: Select whether to check if the answer is in a consistent state.<br />|
|msdyn_totalresponsecount|Edm.Int32|**Display Name**: Total Response Count<br />**Description**: Number of times respondents have responded to this answer<br />|
|msdyn_totalresponsevalue|Edm.Decimal|**Display Name**: Total Response Value<br />**Description**: Total response value<br />|
|msdyn_weight|Edm.Decimal|**Display Name**: Weight<br />**Description**: Weight of answer<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the answer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the answer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_gridid_value|msdyn_GridId<br />|Parent grid containing the answers|
|_msdyn_linkedanswer_value|msdyn_LinkedAnswer<br />|Linked Answer that is common to this answer and other answers.|
|_msdyn_questionid_value|msdyn_QuestionId<br />|Parent question|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_answer_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_answer_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_answer_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_answer_modifiedonbehalfby|
|msdyn_GridId|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_questiongroup_answer|
|msdyn_LinkedAnswer|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_msdyn_linkedanswer_msdyn_answer_LinkedAnswer|
|msdyn_QuestionId|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_answer|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_answer|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_answer|
|owningteam|[team EntityType](team.md)|team_msdyn_answer|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_answer|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_answer_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_answer|  
|msdyn_answer_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_answer|  
|msdyn_answer_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_answer|  
|msdyn_answer_feedbackmapping_Answer|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|msdyn_AnswerId|  
|msdyn_answer_logic_ComparisonAnswer|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|msdyn_ComparisonAnswer|  
|msdyn_answer_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|msdyn_AnswerId|  
|msdyn_answer_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_answer|  
|msdyn_msdyn_answer_msdyn_question_MeasuringAnswer|[msdyn_question EntityType](msdyn_question.md)|msdyn_MeasuringAnswer|  
|msdyn_question_answer_n_n|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_answer_n_n|  

## Operations
The following operations can be used with the msdyn_answer entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_answer entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_answer.md](./remarks/msdyn_answer.md)]

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