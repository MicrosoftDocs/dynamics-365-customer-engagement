---
title: "Microsoft Dynamics 365 Customer Engagement userform EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 819e14c8-26a7-4ec1-a213-741adb02a808
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API userform entitytype."
---
# userform EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/userform.md](./descriptions/userform.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]userforms </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>User Dashboard</td></tr>
<tr><td><b>Primary Key:</b></td><td>userformid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The userform EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the form or dashboard, such as the filter criteria or intended audience.<br />|
|formjson|Edm.String|**Display Name**: Json representation of the form layout.<br />**Description**: Json representation of the form layout.<br />|
|formxml|Edm.String|**Description**: Shows the XML representation of the layout of the form or dashboard.<br />|
|istabletenabled|Edm.Boolean|**Display Name**: Is Tablet Enabled<br />**Description**: Information that specifies whether the dashboard is enabled for tablet.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name for the form or dashboard.<br />|
|objecttypecode|Edm.String|**Description**: Shows the record type (entity) code that the form applies to.<br />|
|type|Edm.Int32|**Display Name**: Form Type<br />**Description**: Select the form type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Dashboard</td></tr><tr><td>103</td><td>Power BI Dashboard</td></tr><tbody></table>|
|userformid|Edm.Guid|**Display Name**: User Dashboard<br />**Description**: Unique identifier of the user dashboard.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that the record owner belongs to.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the dashboard.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the dashboard.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_userform_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_userformbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_userform_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_userformbase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_userform|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_userform|
|owningteam|[team EntityType](team.md)|team_userform|
|owninguser|[systemuser EntityType](systemuser.md)|user_userform|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|UserForm_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_userform|  
|UserForm_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_userform|  

## Operations
The following operations can be used with the userform entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/userform.md](./remarks/userform.md)]

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