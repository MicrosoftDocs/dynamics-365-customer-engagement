---
title: "Microsoft Dynamics 365 Customer Engagement adx_webformsession EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1d349b97-9633-496f-a581-4119a58cd82a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_webformsession entitytype."
---
# adx_webformsession EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_webformsession.md](./descriptions/adx_webformsession.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_webformsessions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web Form Session</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_webformsessionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_webformsession entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_anonymousidentification|Edm.String|**Display Name**: Anonymous Identification<br />|
|adx_currentstepindex|Edm.Int32|**Display Name**: Current Step Index<br />**Description**: The index of the current step the user last visited.<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_primaryrecordentitykeyname|Edm.String|**Display Name**: Primary Record Entity Primary Key Logical Name<br />|
|adx_primaryrecordentitylogicalname|Edm.String|**Display Name**: Primary Record Entity Logical Name<br />|
|adx_primaryrecordid|Edm.String|**Display Name**: Primary Record ID<br />**Description**: Shows the ID of the primary record created by the web form.  Used to retrieve the appropriate session record.<br />|
|adx_stephistory|Edm.String|**Display Name**: Step History<br />**Description**: History of steps in JSON<br />|
|adx_userhostaddress|Edm.String|**Display Name**: User Host Address<br />|
|adx_useridentityname|Edm.String|**Display Name**: User Identity Name<br />|
|adx_webformsessionid|Edm.Guid|**Display Name**: Web Form Session<br />**Description**: Unique identifier for entity instances<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was updated. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in the solution options.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the web form session.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the Web Form Session's status.
<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_contact_value|adx_contact<br />|Unique identifier for Contact associated with Web Form Session.|
|_adx_currentwebformstep_value|adx_currentwebformstep<br />|Unique identifier for Web Form Step associated with Web Form Session.|
|_adx_quoteid_value|adx_quoteid<br />|Unique identifier for Quote associated with Web Form Session.|
|_adx_systemuser_value|adx_systemuser<br />|Unique identifier for User associated with Web Form Session.|
|_adx_webform_value|adx_webform<br />|Unique identifier for Web Form associated with Web Form Session.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_contact|[contact EntityType](contact.md)|adx_webformsession_contact|
|adx_currentwebformstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformsession_currentwebformstep|
|adx_quoteid|[quote EntityType](quote.md)|adx_webformsession_quote|
|adx_systemuser|[systemuser EntityType](systemuser.md)|adx_webformsession_systemuser|
|adx_webform|[adx_webform EntityType](adx_webform.md)|adx_webformsession_webform|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_webformsession_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webformsession_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_webformsession_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webformsession_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_adx_webformsession|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_webformsession_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_webformsession|  
|adx_webformsession_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_webformsession|  
|adx_webformsession_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_webformsession|  

## Operations
The following operations can be used with the adx_webformsession entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the adx_webformsession entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Web Forms Solution](../solutions/microsoftwebforms.md)|[!INCLUDE[../solutions/descriptions/microsoftwebforms.md](../solutions/descriptions/microsoftwebforms.md)]|    

[!INCLUDE[./remarks/adx_webformsession.md](./remarks/adx_webformsession.md)]

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