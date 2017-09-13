---
title: "Microsoft Dynamics 365 Customer Engagement savedquery EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b5c876b7-c253-4903-825e-8b60a4230123
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API savedquery entitytype."
---
# savedquery EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/savedquery.md](./descriptions/savedquery.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]savedqueries </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>View</td></tr>
<tr><td><b>Primary Key:</b></td><td>savedqueryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The savedquery entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|advancedgroupby|Edm.String|**Display Name**: Advanced Group By<br />**Description**: Type the column name that will be used to group the results from the data collected across multiple records from a system view.<br />|
|canbedeleted|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Can Be Deleted<br />**Description**: Tells whether the view can be deleted.<br />|
|columnsetxml|Edm.String|**Display Name**: Column Set XML<br />**Description**: Contains the columns and sorting criteria for the view, stored in XML format.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|conditionalformatting|Edm.String|**Display Name**: Conditional formatting<br />**Description**: Type information about how the items in the system view are formatted.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the view, such as the filter criteria or intended results set.<br />|
|fetchxml|Edm.String|**Display Name**: Fetch XML<br />**Description**: String specifying the query in Fetch XML language.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustom|Edm.Boolean|**Display Name**: Is Custom<br />**Description**: Tells whether a user created the view.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Tells whether the component can be customized.<br />|
|isdefault|Edm.Boolean|**Display Name**: Default<br />**Description**: Tells whether the view is the default view for the specified record type (entity).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Tells whether the record is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isquickfindquery|Edm.Boolean|**Display Name**: Quick Find Compatible<br />**Description**: Choose whether the view is compatible with Quick Find. When users search for specific items, you define the fields that are searched in.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isuserdefined|Edm.Boolean|**Display Name**: User Defined<br />**Description**: Tells whether the view was created by a user.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|layoutjson|Edm.String|**Display Name**: Layout data in JSON format.<br />**Description**: Layout data in JSON format.<br />|
|layoutxml|Edm.String|**Display Name**: Layout XML<br />**Description**: For internal use only.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a name for the view to describe what results the view will contain. This name is visible to users in the View list.<br />|
|offlinesqlquery|Edm.String|**Display Name**: Offline SQL Query<br />**Description**: String specifying the corresponding sql query for the fetch xml specified for offline use.<br />|
|organizationtaborder|Edm.Int32|**Display Name**: Default Organization tab order<br />**Description**: For the organization, type the tab order to determine how users navigate through the screen using only the Tab key.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|queryapi|Edm.String|**Display Name**: Query API<br />**Description**: For internal use only.<br />Read-only<br />|
|queryappusage|Edm.Int32|**Display Name**: Query Application Usage<br />**Description**: For internal use only.<br />|
|querytype|Edm.Int32|**Display Name**: Query Type<br />**Description**: Shows the type of the query.<br />|
|returnedtypecode|Edm.String|**Display Name**: Entity Name<br />**Description**: Type of entity displayed in the view.<br />|
|savedqueryid|Edm.Guid|**Display Name**: View<br />**Description**: Unique identifier of the view.<br />|
|savedqueryidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the view.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason code that explains the status of the record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the view.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Choose the ID of the organization that the record is associated with.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_savedquerybase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_savedquery_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_savedquerybase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_savedquery_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_saved_queries|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|lk_mobileofflineprofileitem_savedquery|[mobileofflineprofileitem EntityType](mobileofflineprofileitem.md)|profileitemrule|  
|SavedQuery_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_savedquery|  
|SavedQuery_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_savedquery|  
|SavedQuery_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_savedquery_syncerror|  

## Operations
The following operations can be used with the savedquery entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[InstantiateFilters Action](../actions/instantiatefilters.md)|Not Bound|[!INCLUDE[../actions/descriptions/instantiatefilters.md](../actions/descriptions/instantiatefilters.md)]|  
|[msdyn_IsProjectTemplatesView Action](../actions/msdyn_isprojecttemplatesview.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_isprojecttemplatesview.md](../actions/descriptions/msdyn_isprojecttemplatesview.md)]|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|  
|[Validate Action](../actions/validate.md)|Not Bound|[!INCLUDE[../actions/descriptions/validate.md](../actions/descriptions/validate.md)]|  
|[ValidateSavedQuery Action](../actions/validatesavedquery.md)|Not Bound|[!INCLUDE[../actions/descriptions/validatesavedquery.md](../actions/descriptions/validatesavedquery.md)]|    

[!INCLUDE[./remarks/savedquery.md](./remarks/savedquery.md)]

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