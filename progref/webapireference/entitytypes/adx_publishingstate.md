---
title: "Microsoft Dynamics 365 Customer Engagement adx_publishingstate EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0cf2ca8f-0f62-4a98-a7f0-dcbeb826dfcf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_publishingstate entitytype."
---
# adx_publishingstate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_publishingstate.md](./descriptions/adx_publishingstate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_publishingstates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Publishing State</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_publishingstateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_publishingstate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_displayorder|Edm.Int32|**Display Name**: Display Order<br />|
|adx_isdefault|Edm.Boolean|**Display Name**: Is Default<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_isvisible|Edm.Boolean|**Display Name**: Select whether the publishing state is visible.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_publishingstateid|Edm.Guid|**Display Name**: Publishing State<br />**Description**: Shows the entity instance.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Publishing State<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the publishing state's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website associated with Publishing State.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_publishingstate|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_publishingstate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_publishingstate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_publishingstate_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_publishingstate_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_publishingstate|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_publishingstate|
|owningteam|[team EntityType](team.md)|team_adx_publishingstate|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_publishingstate|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_accesscontrolrule_publishingstate|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|adx_accesscontrolrule_publishingstate|  
|adx_adx_publishingstate_adx_websitelanguage_PublishingState|[adx_websitelanguage EntityType](adx_websitelanguage.md)|adx_PublishingState|  
|adx_frompublishingstate_statetransition|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_FromState_PublishingStateId|  
|adx_publishingstate_ad|[adx_ad EntityType](adx_ad.md)|adx_publishingstateid|  
|adx_publishingstate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_publishingstate|  
|adx_publishingstate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_publishingstate|  
|adx_publishingstate_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_adx_publishingstate|  
|adx_publishingstate_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_adx_publishingstate|  
|adx_publishingstate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_publishingstate|  
|adx_publishingstate_webfile|[adx_webfile EntityType](adx_webfile.md)|adx_publishingstateid|  
|adx_publishingstate_weblink|[adx_weblink EntityType](adx_weblink.md)|adx_publishingstateid|  
|adx_publishingstate_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|adx_publishingstateid|  
|adx_publishingstate_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_publishingstateid|  
|adx_publishingstate_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|adx_publishingstateid|  
|adx_topublishingstate_statetransition|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_ToState_PublishingStateId|  

## Operations
The following operations can be used with the adx_publishingstate entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_publishingstate entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|    

[!INCLUDE[./remarks/adx_publishingstate.md](./remarks/adx_publishingstate.md)]

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