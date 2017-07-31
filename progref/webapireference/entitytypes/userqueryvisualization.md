---
title: "Microsoft Dynamics 365 Customer Engagement userqueryvisualization EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4fa3fcc2-39f6-43c9-8888-125a936c7319
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API userqueryvisualization entitytype."
---
# userqueryvisualization EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/userqueryvisualization.md](./descriptions/userqueryvisualization.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]userqueryvisualizations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>User Chart</td></tr>
<tr><td><b>Primary Key:</b></td><td>userqueryvisualizationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The userqueryvisualization EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|charttype|Edm.Int32|**Display Name**: Chart Type<br />**Description**: Indicates the library used to render the visualization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>ASP.NET Charts</td></tr><tr><td>1</td><td>Power BI</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|datadescription|Edm.String|**Display Name**: Data XML<br />**Description**: Shows the fields that are used to display data in a chart, stored in XML format.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the chart, such as the filter criteria or intended audience.<br />|
|isdefault|Edm.Boolean|**Display Name**: Default Chart<br />**Description**: Select whether the chart is the default chart for the view that it is associated with.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Last Modified<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name for the chart.<br />|
|presentationdescription|Edm.String|**Display Name**: Presentation XML<br />**Description**: Contains the chart's formatting details and presentation properties, stored in XML format.<br />|
|primaryentitytypecode|Edm.String|**Display Name**: Primary Type Code<br />**Description**: Type of entity which the user chart is attached.<br />|
|userqueryvisualizationid|Edm.Guid|**Display Name**: User Chart<br />**Description**: Unique identifier of the user chart.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the user chart.<br />Read-only<br />|

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
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the user chart.|
|_owninguser_value|owninguser<br />|Unique identifier of the team who owns the user chart.|
|_webresourceid_value|webresourceid<br />|Shows the web resource that will be displayed in the chart to the user.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_userqueryvisualization_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_userqueryvisualizationbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_userqueryvisualization_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_userqueryvisualizationbase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_userqueryvisualizations|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_userqueryvisualizations|
|owningteam|[team EntityType](team.md)|team_userqueryvisualizations|
|owninguser|[systemuser EntityType](systemuser.md)|user_userqueryvisualizations|
|webresourceid|[webresource EntityType](webresource.md)|webresource_userqueryvisualizations|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|UserQueryVisualization_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_userqueryvisualization_syncerror|  

## Operations
The following operations can be used with the userqueryvisualization entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/userqueryvisualization.md](./remarks/userqueryvisualization.md)]

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