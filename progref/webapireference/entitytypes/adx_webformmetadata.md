---
title: "Microsoft Dynamics 365 Customer Engagement adx_webformmetadata EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aa182475-1f13-41cc-a94c-fbdb77fddaa4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_webformmetadata entitytype."
---
# adx_webformmetadata EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_webformmetadata.md](./descriptions/adx_webformmetadata.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]adx_webformmetadatas </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web Form Metadata</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_webformmetadataid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_attributelogicalname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_webformmetadata entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_adddescription|Edm.Boolean|**Display Name**: Add Description<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_attributelogicalname|Edm.String|**Display Name**: Attribute Logical Name<br />**Description**: The name of the attribute field to be modified<br />|
|adx_constantsummaximumtotal|Edm.Int32|**Display Name**: Constant Sum Maximum Total<br />|
|adx_constantsumminimumtotal|Edm.Int32|**Display Name**: Constant Sum Minimum Total<br />|
|adx_constantsumvalidationerrormessage|Edm.String|**Display Name**: Constant Sum Validation Error Message<br />|
|adx_controlstyle|Edm.Int32|**Display Name**: Control Style<br />**Description**: Specifies how the control should be modified or enhanced.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000003</td><td>Group Whole Number as Constant Sum</td></tr><tr><td>100000005</td><td>Group Whole Number as Rank Order Scale Allow Ties</td></tr><tr><td>100000004</td><td>Group Whole Number as Rank Order Scale No Ties</td></tr><tr><td>100000008</td><td>Group Whole Number as Stack Rank</td></tr><tr><td>100000007</td><td>Multiple Choice</td></tr><tr><td>100000006</td><td>Multiple Choice Matrix</td></tr><tr><td>100000001</td><td>Option Set as Horizontal Radio Button List</td></tr><tr><td>100000000</td><td>Option Set as Vertical Radio Button List</td></tr><tr><td>756150000</td><td>Render Lookup as Dropdown</td></tr><tr><td>100000002</td><td>Single Line of Text as Geolocation Lookup Validator</td></tr><tbody></table>|
|adx_cssclass|Edm.String|**Display Name**: CSS Class<br />|
|adx_description|Edm.String|**Display Name**: Description<br />|
|adx_descriptionposition|Edm.Int32|**Display Name**: Position<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Above the field</td></tr><tr><td>100000001</td><td>Below the field</td></tr><tr><td>100000002</td><td>Above the label</td></tr><tbody></table>|
|adx_fieldisrequired|Edm.Boolean|**Display Name**: Field is Required<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_geolocationvalidatorerrormessage|Edm.String|**Display Name**: Geolocation Validator Error Message<br />**Description**: The error message to be displayed when the geolocation validator validation fails.<br />|
|adx_groupname|Edm.String|**Display Name**: Group Name<br />**Description**: Shows which attributes are to be grouped and rendered as a composite control if the control style is a groupings type such as "Group Whole Number as Constant Sum."<br />|
|adx_ignoredefaultvalue|Edm.Boolean|**Display Name**: Ignore Default Value<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_label|Edm.String|**Display Name**: Label<br />|
|adx_maxmultiplechoiceselectedcount|Edm.Int32|**Display Name**: Multiple Choice Max Selected Count<br />|
|adx_minmultiplechoiceselectedcount|Edm.Int32|**Display Name**: Multiple Choice Minimum Required Selected Count<br />|
|adx_multiplechoicevalidationerrormessage|Edm.String|**Display Name**: Multiple Choice Validation Error Message<br />|
|adx_notes_settings|Edm.String|**Display Name**: Notes Settings<br />|
|adx_onsavefromattribute|Edm.String|**Display Name**: On Save From Attribute<br />**Description**: Use this field, in conjunction with On Save Type = Current User Contact, to map any attribute from the current user’s contact record to this record’s attribute logical name.<br />|
|adx_onsavetype|Edm.Int32|**Display Name**: On Save Type<br />**Description**: Shows the mechanisms for populating a field with a value.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Value</td></tr><tr><td>100000001</td><td>Today's Date</td></tr><tr><td>100000002</td><td>Current Portal User</td></tr><tbody></table>|
|adx_onsavevalue|Edm.String|**Display Name**: Value<br />|
|adx_prepopulatefromattribute|Edm.String|**Display Name**: Prepopulate From Attribute<br />**Description**: Use this field, in conjunction with Prepopulate Type = Current User Contact, to map any attribute from the current user’s contact record to this record’s attribute logical name.<br />|
|adx_prepopulatetype|Edm.Int32|**Display Name**: Prepopulate Type<br />**Description**: Shows the mechanisms for populating a field with a value.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Value</td></tr><tr><td>100000001</td><td>Today's Date</td></tr><tr><td>100000002</td><td>Current Portal User</td></tr><tbody></table>|
|adx_prepopulatevalue|Edm.String|**Display Name**: Prepopulate Value<br />**Description**: The value to prepopulate the field.<br />|
|adx_provisionedlanguages|Edm.Int32|**Display Name**: Provisioned Languages<br />|
|adx_purchasecreateinvoiceonpayment|Edm.Boolean|**Display Name**: Create Invoice on Payment<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_purchasefulfillorderonpayment|Edm.Boolean|**Display Name**: Fulfill Order on Payment<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_purchaselineitemdescriptionattribute|Edm.String|**Display Name**: Line Item Description Attribute Name<br />|
|adx_purchaselineiteminstructionsattribute|Edm.String|**Display Name**: Line Item Instructions Attribute Name<br />**Description**: Purchase line item entity attribute name for instructions.<br />|
|adx_purchaselineitemorderattribute|Edm.String|**Display Name**: Line Item Order Attribute Name<br />**Description**: Purchase line item entity attribute name for the order in which a line item should be displayed.<br />|
|adx_purchaselineitemproductattribute|Edm.String|**Display Name**: Line Item Product Attribute Name<br />**Description**: Purchase line item entity attribute name for Product lookup. If this value is not present and set, the corresponding line item will be excluded from the purchase.<br />|
|adx_purchaselineitemquantityattribute|Edm.String|**Display Name**: Line Item Quantity Attribute Name<br />**Description**: Purchase line item entity attribute name for item quantity. (Should be a decimal attribute.)<br />|
|adx_purchaselineitemrelationship|Edm.String|**Display Name**: Line Item Relationship Name<br />**Description**: Relationship from the purchase entity that defines purchase line items.<br />|
|adx_purchaselineitemrequiredattribute|Edm.String|**Display Name**: Line Item Required Attribute Name<br />**Description**: Purchase line item entity attribute name for whether a line item is required.<br />|
|adx_purchaselineitemuomattribute|Edm.String|**Display Name**: Line Item UoM Attribute Name<br />**Description**: Purchase line item entity attribute name for Unit of Measure lookup.<br />|
|adx_purchaseoptionalproductsrelationship|Edm.String|**Display Name**: Optional Products Relationship Name<br />**Description**: Relationship from the purchase entity for products to be purchased that are optional (the user must opt-in to purchase of these items).<br />|
|adx_purchasequotename|Edm.String|**Display Name**: Quote Name<br />**Description**: The name to be used for all purchase quotes generated by this step.<br />|
|adx_purchaserequiredproductsrelationship|Edm.String|**Display Name**: Required Products Relationship Name<br />**Description**: Relationship from the purchase entity for products to be purchased that are a required part of the purchase.<br />|
|adx_purchaserequiresshipping|Edm.Boolean|**Display Name**: Requires Shipping<br />**Description**: Select whether to require the purchase process to collect shipping information.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_purchasetargetentityinvoicerelationship|Edm.String|**Display Name**: Target Entity Invoice Relationship Name<br />|
|adx_purchasetargetentityorderrelationship|Edm.String|**Display Name**: Target Entity Order Relationship Name<br />|
|adx_purchasetargetentityrelationship|Edm.String|**Display Name**: Target Entity Relationship Name<br />**Description**: Relationship from the web form step target entity to the purchase entity, if the step target is not the purchase entity.<br />|
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
|adx_type|Edm.Int32|**Display Name**: Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Timeline</td></tr><tr><td>100000000</td><td>Attribute</td></tr><tr><td>100000005</td><td>Notes</td></tr><tr><td>100000003</td><td>Purchase</td></tr><tr><td>100000001</td><td>Section</td></tr><tr><td>100000004</td><td>Subgrid</td></tr><tr><td>100000002</td><td>Tab</td></tr><tbody></table>|
|adx_useattributedescriptionproperty|Edm.Boolean|**Display Name**: Use Attribute's Description Property<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_validationerrormessage|Edm.String|**Display Name**: Validation Error Message<br />**Description**: The error message defined for the validation.<br />|
|adx_validationregularexpression|Edm.String|**Display Name**: Validation Regular Expression<br />**Description**: Adds a regular expression validator with the specified regular expression.<br />|
|adx_validationregularexpressionerrormessage|Edm.String|**Display Name**: Regular Expression Validation Error Message<br />|
|adx_webformmetadataid|Edm.Guid|**Display Name**: Web Form Metadata<br />**Description**: Unique identifier for entity instances<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was updated. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in the solution options.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the web form metadata.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the  Web Form Metadata's status.
<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_entityformforcreate_value|adx_entityformforcreate<br />||
|_adx_webformstep_value|adx_webformstep<br />|Unique identifier for Web Form Step associated with Web Form Metadata.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_entityformforcreate|[adx_webform EntityType](adx_webform.md)|adx_webform_webformmetadata_entityformforcreate|
|adx_webformstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformmetadata_webformstep|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_webformmetadata_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webformmetadata_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_webformmetadata_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webformmetadata_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_adx_webformmetadata|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_webformmetadata_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_webformmetadata|  
|adx_webformmetadata_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_webformmetadata|  
|adx_webformmetadata_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_webformmetadata|  

## Operations
The following operations can be used with the adx_webformmetadata entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the adx_webformmetadata entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Timeline Solution](../solutions/portaltimeline.md)|[!INCLUDE[../solutions/descriptions/portaltimeline.md](../solutions/descriptions/portaltimeline.md)]|  
|[Dynamics 365 Portals - Web Forms Solution](../solutions/microsoftwebforms.md)|[!INCLUDE[../solutions/descriptions/microsoftwebforms.md](../solutions/descriptions/microsoftwebforms.md)]|    

[!INCLUDE[./remarks/adx_webformmetadata.md](./remarks/adx_webformmetadata.md)]

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