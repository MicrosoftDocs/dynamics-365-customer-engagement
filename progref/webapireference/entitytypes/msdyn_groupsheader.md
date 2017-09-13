---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_groupsheader EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1d5f6889-22c8-4a36-8dd5-86c9ade7024a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_groupsheader entitytype."
---
# msdyn_groupsheader EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_groupsheader.md](./descriptions/msdyn_groupsheader.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_groupsheaders </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Office Groups Header</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_groupsheaderid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_groupsheader entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|entityimage|Edm.Binary|**Display Name**: Group Photo<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_calendarurl|Edm.String|**Display Name**: CalendarURL<br />|
|msdyn_documentsurl|Edm.String|**Display Name**: DocumentsURL<br />|
|msdyn_editgroupurl|Edm.String|**Display Name**: EditGroupURL<br />|
|msdyn_groupsheaderid|Edm.Guid|**Display Name**: GroupsHeader<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_inboxurl|Edm.String|**Display Name**: InboxURL<br />|
|msdyn_mail|Edm.String|**Display Name**: Mail<br />|
|msdyn_mailnickname|Edm.String|**Display Name**: MailNickname<br />**Description**: The alias for this Office Groups.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: This stores the Office Groups' display name.<br />|
|msdyn_notebookurl|Edm.String|**Display Name**: Notebook URL<br />|
|msdyn_objectid|Edm.String|**Display Name**: ObjectId<br />|
|msdyn_peopleurl|Edm.String|**Display Name**: PeopleURL<br />|
|msdyn_photourl|Edm.String|**Display Name**: PhotoURL<br />|
|msdyn_siteurl|Edm.String|**Display Name**: SiteURL<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Office Groups Header<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Office Groups Header<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_collaborationid_value|msdyn_CollaborationId<br />|Unique identifier for Collaboration associated with Office Groups Header.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_groupsheader_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_groupsheader_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_groupsheader_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_groupsheader_modifiedonbehalfby|
|msdyn_CollaborationId|[msdyn_collaboration EntityType](msdyn_collaboration.md)|msdyn_msdyn_collaboration_msdyn_groupsheader|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_groupsheader|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_groupsheader|
|owningteam|[team EntityType](team.md)|team_msdyn_groupsheader|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_groupsheader|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_groupsheader_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_groupsheader|  
|msdyn_groupsheader_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_groupsheader|  
|msdyn_groupsheader_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_groupsheader|  

## Operations
The following operations can be used with the msdyn_groupsheader entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_groupsheader entity type.


|Name|Description |  
|----|------------|  
|[Office 365 Groups Solution](../solutions/office365groups.md)|[!INCLUDE[../solutions/descriptions/office365groups.md](../solutions/descriptions/office365groups.md)]|    

[!INCLUDE[./remarks/msdyn_groupsheader.md](./remarks/msdyn_groupsheader.md)]

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