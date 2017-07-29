---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_customerjourneyiteration EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 10c4c0e5-314b-445a-a744-9339b3419f1c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_customerjourneyiteration entitytype."
---
# msdyncrm_customerjourneyiteration EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_customerjourneyiteration.md](./descriptions/msdyncrm_customerjourneyiteration.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_customerjourneyiterations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Customer Journey Iteration</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_customerjourneyiterationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_customerjourneyiteration entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_customerjourneyiterationid|Edm.Guid|**Display Name**: Campaign Iteration<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_designerstate|Edm.String|**Display Name**: Designer State<br />**Description**: The state of customer journey iteration designer.<br />|
|msdyncrm_enddate|Edm.DateTimeOffset|**Display Name**: End Date<br />**Description**: The end date of the campaign iteration.<br />|
|msdyncrm_iterationnumber|Edm.Int32|**Display Name**: Iteration Number<br />**Description**: The iteration number of the campaign iteration.<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyncrm_startdate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: The start date of the campaign iteration.<br />|
|msdyncrm_workflowdefinition|Edm.String|**Display Name**: Workflow Definition<br />**Description**: The customer journey iteration design definition<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Campaign Iteration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Campaign Iteration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyncrm_customerjourney_value|msdyncrm_customerjourney<br />|The customer journey this iteration belongs to.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_customerjourneyiteration_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_customerjourneyiteration_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_customerjourneyiteration_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_customerjourneyiteration_modifiedonbehalfby|
|msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_CustomerJourney|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_customerjourneyiteration|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_customerjourneyiteration|
|owningteam|[team EntityType](team.md)|team_msdyncrm_customerjourneyiteration|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_customerjourneyiteration|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_customerjourneyiteration_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_customerjourneyiteration|  
|msdyncrm_customerjourneyiteration_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_customerjourneyiteration|  
|msdyncrm_customerjourneyiteration_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyncrm_customerjourneyiteration|  
|msdyncrm_customerjourneyiteration_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyncrm_customerjourneyiteration|  
|msdyncrm_customerjourneyiteration_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_customerjourneyiteration|  
|msdyncrm_msdyncrm_customerjourneyiteration_appointment|[appointment EntityType](appointment.md)|msdyncrm_associatedcustomerjourneyiteration_Appointment|  
|msdyncrm_msdyncrm_customerjourneyiteration_msdyncrm_campaigncustomchannelactivity_CJIteration|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|msdyncrm_CustomerJourneyIteration|  
|msdyncrm_msdyncrm_customerjourneyiteration_phonecall|[phonecall EntityType](phonecall.md)|msdyncrm_associatedcustomerjourneyiteration_PhoneCall|  
|msdyncrm_msdyncrm_customerjourneyiteration_task|[task EntityType](task.md)|msdyncrm_associatedcustomerjourneyiteration_Task|  

## Operations
The following operations can be used with the msdyncrm_customerjourneyiteration entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_customerjourneyiteration entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_customerjourneyiteration.md](./remarks/msdyncrm_customerjourneyiteration.md)]

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