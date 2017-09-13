---
title: "Microsoft Dynamics 365 Customer Engagement adx_entityformmetadata EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d49a450a-9d2e-48b0-811c-6ab40b01425c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_entityformmetadata entitytype."
---
# adx_entityformmetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_entityformmetadata.md](./descriptions/adx_entityformmetadata.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_entityformmetadatas </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Entity Form Metadata</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_entityformmetadataid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_entityformmetadata entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_adddescription|Edm.Boolean|**Display Name**: Add Description<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_attributelogicalname|Edm.String|**Display Name**: Attribute Logical Name<br />|
|adx_constantsummaximumtotal|Edm.Int32|**Display Name**: Constant Sum Maximum Total<br />|
|adx_constantsumminimumtotal|Edm.Int32|**Display Name**: Constant Sum Minimum Total<br />|
|adx_constantsumvalidationerrormessage|Edm.String|**Display Name**: Constant Sum Validation Error Message<br />|
|adx_controlstyle|Edm.Int32|**Display Name**: Control Style<br />**Description**: Specifies how the control should be modified or enhanced.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000003</td><td>Group Whole Number as Constant Sum</td></tr><tr><td>100000005</td><td>Group Whole Number as Rank Order Scale Allow Ties</td></tr><tr><td>100000004</td><td>Group Whole Number as Rank Order Scale No Ties</td></tr><tr><td>100000008</td><td>Group Whole Number as Stack Rank</td></tr><tr><td>100000007</td><td>Multiple Choice</td></tr><tr><td>100000006</td><td>Multiple Choice Matrix</td></tr><tr><td>100000001</td><td>Option Set as Horizontal Radio Button List</td></tr><tr><td>100000000</td><td>Option Set as Vertical Radio Button List</td></tr><tr><td>756150000</td><td>Render Lookup as Dropdown</td></tr><tr><td>100000002</td><td>Single Line of Text as Geolocation Lookup Validator</td></tr><tbody></table>|
|adx_cssclass|Edm.String|**Display Name**: CSS Class<br />|
|adx_description|Edm.String|**Display Name**: Description<br />|
|adx_descriptionposition|Edm.Int32|**Display Name**: Position<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Above the field</td></tr><tr><td>100000001</td><td>Below the field</td></tr><tr><td>100000002</td><td>Above the label</td></tr><tbody></table>|
|adx_entityformmetadataid|Edm.Guid|**Display Name**: Entity Form Metadata<br />**Description**: Unique identifier for entity instances<br />|
|adx_fieldisrequired|Edm.Boolean|**Display Name**: Field is Required<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_geolocationvalidatorerrormessage|Edm.String|**Display Name**: Geolocation Validator Error Message<br />**Description**: The error message to be displayed when the geolocation validator validation fails.<br />|
|adx_groupname|Edm.String|**Display Name**: Group Name<br />**Description**: Shows which attributes are to be grouped and rendered as a composite control if the control style is a groupings type such as "Group Whole Number as Constant Sum."<br />|
|adx_ignoredefaultvalue|Edm.Boolean|**Display Name**: Ignore Default Value<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_label|Edm.String|**Display Name**: Label<br />|
|adx_maxmultiplechoiceselectedcount|Edm.Int32|**Display Name**: Multiple Choice Max Selected Count<br />|
|adx_minmultiplechoiceselectedcount|Edm.Int32|**Display Name**: Multiple Choice Minimum Required Selected Count<br />|
|adx_multiplechoicevalidationerrormessage|Edm.String|**Display Name**: Multiple Choice Validation Error Message<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_notes_settings|Edm.String|**Display Name**: Notes Settings<br />|
|adx_onsavefromattribute|Edm.String|**Display Name**: On Save From Attribute<br />**Description**: Use this field, in conjunction with On Save Type = Current User Contact, to map any attribute from the current user’s contact record to this record’s attribute logical name.<br />|
|adx_onsavetype|Edm.Int32|**Display Name**: On Save Type<br />**Description**: Shows the mechanisms for populating a field with a value.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Value</td></tr><tr><td>100000001</td><td>Today's Date</td></tr><tr><td>100000002</td><td>Current Portal User</td></tr><tbody></table>|
|adx_onsavevalue|Edm.String|**Display Name**: Value<br />|
|adx_prepopulatefromattribute|Edm.String|**Display Name**: Prepopulate From Attribute<br />**Description**: Use this field, in conjunction with Prepopulate Type = Current User Contact, to map any attribute from the current user’s contact record to this record’s attribute logical name.<br />|
|adx_prepopulatetype|Edm.Int32|**Display Name**: Prepopulate Type<br />**Description**: Shows the mechanisms for populating a field with a value.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Value</td></tr><tr><td>100000001</td><td>Today's Date</td></tr><tr><td>100000002</td><td>Current Portal User</td></tr><tbody></table>|
|adx_prepopulatevalue|Edm.String|**Display Name**: Prepopulate Value<br />**Description**: The value to prepopulate the field.<br />|
|adx_provisionedlanguages|Edm.Int32|**Display Name**: Provisioned Languages<br />|
|adx_randomizeoptionsetvalues|Edm.Boolean|**Display Name**: Randomize Option Set Values<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_rangevalidationerrormessage|Edm.String|**Display Name**: Range Validation Error Message<br />|
|adx_rankordernotiesvalidationerrormessage|Edm.String|**Display Name**: Rank Order No Ties Validation Error Message<br />|
|adx_requiredfieldvalidationerrormessage|Edm.String|**Display Name**: Required Field Validation Error Message<br />**Description**: The error message shown when a required field does not contain a value.<br />|
|adx_sectionname|Edm.String|**Display Name**: Section Name<br />|
|adx_setvalueonsave|Edm.Boolean|**Display Name**: Set Value On Save<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_subgrid_name|Edm.String|**Display Name**: Subgrid Name<br />|
|adx_subgrid_settings|Edm.String|**Display Name**: Subgrid Settings<br />|
|adx_tabname|Edm.String|**Display Name**: Tab Name<br />|
|adx_timeline_settings|Edm.String|**Display Name**: Timeline Settings<br />|
|adx_type|Edm.Int32|**Display Name**: Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Attribute</td></tr><tr><td>100000005</td><td>Notes</td></tr><tr><td>100000001</td><td>Section</td></tr><tr><td>100000003</td><td>Subgrid</td></tr><tr><td>100000002</td><td>Tab</td></tr><tr><td>756150000</td><td>Timeline</td></tr><tbody></table>|
|adx_useattributedescriptionproperty|Edm.Boolean|**Display Name**: Use Attribute's Description Property<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_validationerrormessage|Edm.String|**Display Name**: Validation Error Message<br />**Description**: The error message defined for the validation.<br />|
|adx_validationregularexpression|Edm.String|**Display Name**: Validation Regular Expression<br />**Description**: Adds a regular expression validator with the specified regular expression.<br />|
|adx_validationregularexpressionerrormessage|Edm.String|**Display Name**: Regular Expression Validation Error Message<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was updated. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in the solution options.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the entity form metadata.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the  Entity Form Metadata's status.
<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_entityform_value|adx_entityform<br />|Unique identifier for Entity Form associated with Entity Form Metadata.|
|_adx_entityformforcreate_value|adx_entityformforcreate<br />||
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_entityform|[adx_entityform EntityType](adx_entityform.md)|adx_entityformmetadata_entityform|
|adx_entityformforcreate|[adx_entityform EntityType](adx_entityform.md)|adx_entityform_entityformmetadata_entityformforcreate|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_entityformmetadata_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_entityformmetadata_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_entityformmetadata_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_entityformmetadata_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_adx_entityformmetadata|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_entityformmetadata_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_entityformmetadata|  
|adx_entityformmetadata_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_entityformmetadata|  
|adx_entityformmetadata_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_entityformmetadata|  

## Operations
The following operations can be used with the adx_entityformmetadata entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the adx_entityformmetadata entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Timeline Solution](../solutions/portaltimeline.md)|[!INCLUDE[../solutions/descriptions/portaltimeline.md](../solutions/descriptions/portaltimeline.md)]|  
|[Dynamics 365 Portals - Web Forms Solution](../solutions/microsoftwebforms.md)|[!INCLUDE[../solutions/descriptions/microsoftwebforms.md](../solutions/descriptions/microsoftwebforms.md)]|    

[!INCLUDE[./remarks/adx_entityformmetadata.md](./remarks/adx_entityformmetadata.md)]

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