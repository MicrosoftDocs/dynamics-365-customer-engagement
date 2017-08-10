---
title: "Microsoft Dynamics 365 Customer Engagement savedqueryvisualization EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8281e867-cc6a-4d71-9752-3e265247c34d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API savedqueryvisualization entitytype."
---
# savedqueryvisualization EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/savedqueryvisualization.md](./descriptions/savedqueryvisualization.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]savedqueryvisualizations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>System Chart</td></tr>
<tr><td><b>Primary Key:</b></td><td>savedqueryvisualizationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The savedqueryvisualization entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|canbedeleted|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Can Be Deleted<br />**Description**: Tells whether the saved query visualization can be deleted.<br />|
|charttype|Edm.Int32|**Display Name**: Chart Type<br />**Description**: Indicates the library used to render the visualization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>ASP.NET Charts</td></tr><tr><td>1</td><td>Power BI</td></tr><tbody></table>|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the system chart was created.<br />Read-only<br />|
|datadescription|Edm.String|**Display Name**: Data XML<br />**Description**: XML string used to define the underlying data for the system chart.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the system chart.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|isdefault|Edm.Boolean|**Display Name**: Default Chart<br />**Description**: Indicates whether the system chart is the default chart for the entity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the system chart was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the system chart.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|presentationdescription|Edm.String|**Display Name**: Presentation XML<br />**Description**: XML string used to define the presentation properties of the system chart.<br />|
|primaryentitytypecode|Edm.String|**Display Name**: Primary Type Code<br />**Description**: Type of entity with which the system chart is attached.<br />|
|savedqueryvisualizationid|Edm.Guid|**Display Name**: System Chart<br />**Description**: Unique identifier of the system chart.<br />|
|savedqueryvisualizationidunique|Edm.Guid|**Display Name**: System Chart<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|type|Edm.Int32|**Display Name**: Form Type<br />**Description**: Specifies where the chart will be used, 0 for data centric as well as interaction centric and 1 for just interaction centric<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>for data centric as well as interaction centric</td></tr><tr><td>1</td><td>just for interaction centric</td></tr><tbody></table>|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the system chart.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the system chart.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the system chart.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the system chart.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the system chart.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the system chart.|
|_webresourceid_value|webresourceid<br />|Unique identifier of the Web resource that will be displayed in the system chart.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_savedqueryvisualizationbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_savedqueryvisualizationbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_savedqueryvisualizationbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_savedqueryvisualizationbase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_saved_query_visualizations|
|webresourceid|[webresource EntityType](webresource.md)|webresource_savedqueryvisualizations|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SavedQueryVisualization_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_savedqueryvisualization_syncerror|  

## Operations
The following operations can be used with the savedqueryvisualization entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/savedqueryvisualization.md](./remarks/savedqueryvisualization.md)]

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