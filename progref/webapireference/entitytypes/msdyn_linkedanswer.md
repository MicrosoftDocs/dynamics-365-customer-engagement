---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_linkedanswer EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 30adce3f-46b2-48c6-9dfb-a18ae0e89313
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_linkedanswer entitytype."
---
# msdyn_linkedanswer EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_linkedanswer.md](./descriptions/msdyn_linkedanswer.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_linkedanswers </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Linked Answer</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_linkedanswerid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_linkedanswer entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_answerindex|Edm.Int32|**Display Name**: Answer Index<br />**Description**: Zero based index<br />|
|msdyn_linkedanswerid|Edm.Guid|**Display Name**: Linked Answer<br />**Description**: Shows the entity instances.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_orderindex|Edm.Int32|**Display Name**: Order Index<br />**Description**: Enter the order that the answer is displayed.<br />|
|msdyn_pluginignore|Edm.String|**Display Name**: Ignore Plug-In<br />**Description**: For internal use only.<br />|
|msdyn_reportingtext|Edm.String|**Display Name**: Reporting Text<br />**Description**: Shows the text that's displayed for reporting purposes.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the linked answer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the linked answer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_linkedquestion_value|msdyn_LinkedQuestion<br />|Parent Question|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_linkedanswer_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_linkedanswer_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_linkedanswer_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_linkedanswer_modifiedonbehalfby|
|msdyn_LinkedQuestion|[msdyn_questiontype EntityType](msdyn_questiontype.md)|msdyn_msdyn_questiontype_msdyn_linkedanswer_LinkedQuestion|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_linkedanswer|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_linkedanswer|
|owningteam|[team EntityType](team.md)|team_msdyn_linkedanswer|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_linkedanswer|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_linkedanswer_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_linkedanswer|  
|msdyn_linkedanswer_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_linkedanswer|  
|msdyn_linkedanswer_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_linkedanswer|  
|msdyn_LinkedAnswer10Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer10|  
|msdyn_LinkedAnswer11Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer11|  
|msdyn_LinkedAnswer12Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer12|  
|msdyn_LinkedAnswer13Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer13|  
|msdyn_LinkedAnswer14Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer14|  
|msdyn_LinkedAnswer15id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer15|  
|msdyn_LinkedAnswer1Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer1|  
|msdyn_LinkedAnswer2Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer2|  
|msdyn_LinkedAnswer3Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer3|  
|msdyn_LinkedAnswer4Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer4|  
|msdyn_LinkedAnswer5Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer5|  
|msdyn_LinkedAnswer6Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer6|  
|msdyn_LinkedAnswer7Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer7|  
|msdyn_LinkedAnswer8Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer8|  
|msdyn_LinkedAnswer9Id|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_LinkedAnswer9|  
|msdyn_msdyn_linkedanswer_msdyn_answer_LinkedAnswer|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_LinkedAnswer|  
|msdyn_msdyn_linkedanswer_msdyn_feedbackmapping_LinkedAnswerId|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|msdyn_LinkedAnswerId|  

## Operations
The following operations can be used with the msdyn_linkedanswer entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_linkedanswer entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_linkedanswer.md](./remarks/msdyn_linkedanswer.md)]

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