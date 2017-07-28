---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_linkedincampaign EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4e5bbe6d-16a9-49b4-90ad-473d8c788189
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_linkedincampaign entitytype."
---
# msdyncrm_linkedincampaign EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_linkedincampaign.md](./descriptions/msdyncrm_linkedincampaign.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_linkedincampaigns </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>LinkedIn Campaign</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_linkedincampaignid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_linkedincampaign entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_campaigntype|Edm.Int32|**Display Name**: Campaign Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>LinkedIn Sponsored Content</td></tr><tr><td>192350001</td><td>Text Advertisement</td></tr><tbody></table>|
|msdyncrm_enddate|Edm.DateTimeOffset|**Display Name**: Proposed End Date<br />|
|msdyncrm_linkedincampaignid|Edm.Guid|**Display Name**: LinkedIn Campaign<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_linkedinid|Edm.String|**Display Name**: LinkedIn ID<br />|
|msdyncrm_linkedinstatus|Edm.Int32|**Display Name**: LinkedIn Status<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Active</td></tr><tr><td>192350001</td><td>Paused</td></tr><tr><td>192350002</td><td>Archived</td></tr><tr><td>192350003</td><td>Completed</td></tr><tr><td>192350004</td><td>Canceled</td></tr><tr><td>192350005</td><td>Draft</td></tr><tbody></table>|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the campaign.<br />|
|msdyncrm_startdate|Edm.DateTimeOffset|**Display Name**: Proposed Start Date<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the LinkedIn Campaign<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the LinkedIn Campaign<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyncrm_linkedinaccount_value|msdyncrm_LinkedInAccount<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedincampaign_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedincampaign_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedincampaign_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedincampaign_modifiedonbehalfby|
|msdyncrm_LinkedInAccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_linkedincampaign|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_linkedincampaign|
|owningteam|[team EntityType](team.md)|team_msdyncrm_linkedincampaign|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_linkedincampaign|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncr2_msdyncrm_linkedincampaign_msdyncrm_customerjourney_LinkedInCampaign|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncr2_LinkedInCampaign|  
|msdyncrm_linkedincampaign_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_linkedincampaign|  
|msdyncrm_linkedincampaign_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_linkedincampaign|  
|msdyncrm_linkedincampaign_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyncrm_linkedincampaign|  
|msdyncrm_linkedincampaign_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyncrm_linkedincampaign|  
|msdyncrm_linkedincampaign_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_linkedincampaign|  
|msdyncrm_msdyncrm_linkedincampaign_lead_LinkedInCampaign|[lead EntityType](lead.md)|msdyncrm_LinkedInCampaign|  
|msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_LinkedInCampaign|  

## Operations
The following operations can be used with the msdyncrm_linkedincampaign entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_linkedincampaign entity type.


|Name|Description |  
|----|------------|  
|[LinkedIn Lead Gen Forms (Link to Marketing) Solution](../solutions/linkedinleadgenintegrationlink.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegrationlink.md](../solutions/descriptions/linkedinleadgenintegrationlink.md)]|  
|[LinkedIn Lead Gen Forms Solution](../solutions/linkedinleadgenintegration.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegration.md](../solutions/descriptions/linkedinleadgenintegration.md)]|    

[!INCLUDE[./remarks/msdyncrm_linkedincampaign.md](./remarks/msdyncrm_linkedincampaign.md)]

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