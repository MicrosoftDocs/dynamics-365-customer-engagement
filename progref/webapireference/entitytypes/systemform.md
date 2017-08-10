---
title: "Microsoft Dynamics 365 Customer Engagement systemform EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 50faefe8-7c41-48fe-8c19-3656c8366ce3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API systemform entitytype."
---
# systemform EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/systemform.md](./descriptions/systemform.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]systemforms </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>System Form</td></tr>
<tr><td><b>Primary Key:</b></td><td>formid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The systemform entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|canbedeleted|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Can Be Deleted<br />**Description**: Information that specifies whether this component can be deleted.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the form or dashboard.<br />|
|formactivationstate|Edm.Int32|**Display Name**: Form State<br />**Description**: Specifies the state of the form.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Inactive</td></tr><tr><td>1</td><td>Active</td></tr><tbody></table>|
|formid|Edm.Guid|**Description**: Unique identifier of the record type form.<br />|
|formidunique|Edm.Guid|**Description**: Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook.<br />Read-only<br />|
|formjson|Edm.String|**Description**: Json representation of the form layout.<br />|
|formpresentation|Edm.Int32|**Display Name**: AIR Refreshed<br />**Description**: Specifies whether this form is in the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>ClassicForm</td></tr><tr><td>1</td><td>AirForm</td></tr><tr><td>2</td><td>ConvertedICForm</td></tr><tbody></table>|
|formxml|Edm.String|**Description**: XML representation of the form layout.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|isairmerged|Edm.Boolean|**Display Name**: Refreshed<br />**Description**: Specifies whether this form is merged with the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|isdefault|Edm.Boolean|**Display Name**: Default Form<br />**Description**: Information that specifies whether the form or the dashboard is the system default.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isdesktopenabled|Edm.Boolean|**Display Name**: Is Desktop Enabled<br />**Description**: Information that specifies whether the dashboard is enabled for desktop.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: State<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|istabletenabled|Edm.Boolean|**Display Name**: Is Tablet Enabled<br />**Description**: Information that specifies whether the dashboard is enabled for tablet.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the form.<br />|
|objecttypecode|Edm.String|**Display Name**: Entity Name<br />**Description**: Code that represents the record type.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|publishedon|Edm.DateTimeOffset|**Display Name**: Published On<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|type|Edm.Int32|**Display Name**: Form Type<br />**Description**: Type of the form, for example, Dashboard or Preview.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Dashboard</td></tr><tr><td>1</td><td>AppointmentBook</td></tr><tr><td>2</td><td>Main</td></tr><tr><td>3</td><td>MiniCampaignBO</td></tr><tr><td>4</td><td>Preview</td></tr><tr><td>5</td><td>Mobile - Express</td></tr><tr><td>6</td><td>Quick View Form</td></tr><tr><td>7</td><td>Quick Create</td></tr><tr><td>8</td><td>Dialog</td></tr><tr><td>9</td><td>Task Flow Form</td></tr><tr><td>10</td><td>InteractionCentricDashboard</td></tr><tr><td>11</td><td>Card</td></tr><tr><td>12</td><td>Main - Interactive experience</td></tr><tr><td>100</td><td>Other</td></tr><tr><td>101</td><td>MainBackup</td></tr><tr><td>102</td><td>AppointmentBookBackup</td></tr><tr><td>103</td><td>Power BI Dashboard</td></tr><tbody></table>|
|uniquename|Edm.String|**Display Name**: Unique Name<br />**Description**: Unique Name<br />|
|version|Edm.Int32|**Description**: For internal use only.<br />|
|versionnumber|Edm.Int64|**Description**: Represents a version of customizations to be synchronized with the Microsoft Dynamics 365 client for Outlook.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_ancestorformid_value|ancestorformid<br />|Unique identifier of the parent form.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|ancestorformid|[systemform EntityType](systemform.md)|form_ancestor_form|
|organizationid|[organization EntityType](organization.md)|organization_systemforms|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|form_ancestor_form|[systemform EntityType](systemform.md)|ancestorformid|  
|SystemForm_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_systemform|  
|SystemForm_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_systemform|  

## Operations
The following operations can be used with the systemform entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CopySystemForm Action](../actions/copysystemform.md)|Entity|[!INCLUDE[../actions/descriptions/copysystemform.md](../actions/descriptions/copysystemform.md)]|  
|[RetrieveFilteredForms Function](../functions/retrievefilteredforms.md)|Collection|[!INCLUDE[../functions/descriptions/retrievefilteredforms.md](../functions/descriptions/retrievefilteredforms.md)]|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/systemform.md](./remarks/systemform.md)]

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