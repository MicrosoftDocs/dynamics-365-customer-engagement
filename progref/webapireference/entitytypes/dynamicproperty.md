---
title: "Microsoft Dynamics 365 Customer Engagement dynamicproperty EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: de026d08-ef5f-4b3b-bbff-172e903d1375
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API dynamicproperty entitytype."
---
# dynamicproperty EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/dynamicproperty.md](./descriptions/dynamicproperty.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]dynamicproperties </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Property</td></tr>
<tr><td><b>Primary Key:</b></td><td>dynamicpropertyid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The dynamicproperty entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|datatype|Edm.Int32|**Display Name**: Data Type<br />**Description**: Select the data type of the property.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Option Set</td></tr><tr><td>1</td><td>Decimal</td></tr><tr><td>2</td><td>Floating Point Number</td></tr><tr><td>3</td><td>Single Line Of Text</td></tr><tr><td>4</td><td>Whole Number</td></tr><tbody></table>|
|defaultvaluedecimal|Edm.Decimal|**Display Name**: Default Decimal Value<br />**Description**: Shows the default value of the property for a decimal data type.<br />|
|defaultvaluedouble|Edm.Double|**Display Name**: Default Double Value<br />**Description**: Shows the default value of the property for a double data type.<br />|
|defaultvalueinteger|Edm.Int32|**Display Name**: Default Whole Number Value<br />**Description**: Shows the default value of the property for a whole number data type.<br />|
|defaultvaluestring|Edm.String|**Display Name**: Default String Value<br />**Description**: Shows the default value of the property for a string data type.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type a description for the property.<br />|
|dmtimportstate|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|dynamicpropertyid|Edm.Guid|**Display Name**: Property ID<br />**Description**: Shows the unique identifier of the property.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|ishidden|Edm.Boolean|**Display Name**: Hidden<br />**Description**: Defines whether the attribute is hidden or shown.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isreadonly|Edm.Boolean|**Display Name**: Read-Only<br />**Description**: Defines whether the attribute is read-only or if it can be edited.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isrequired|Edm.Boolean|**Display Name**: Required<br />**Description**: Defines whether the attribute is mandatory.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|maxlengthstring|Edm.Int32|**Display Name**: Maximum String Length<br />**Description**: Shows the maximum allowed length of the property for a string data type.<br />|
|maxvaluedecimal|Edm.Decimal|**Display Name**: Maximum Decimal Value<br />**Description**: Shows the maximum allowed value of the property for a decimal data type.<br />|
|maxvaluedouble|Edm.Double|**Display Name**: Maximum Double Value<br />**Description**: Shows the maximum allowed value of the property for a double data type.<br />|
|maxvalueinteger|Edm.Int32|**Display Name**: Maximum Whole Number Value<br />**Description**: Shows the maximum allowed value of the property for a whole number data type.<br />|
|minvaluedecimal|Edm.Decimal|**Display Name**: Minimum Decimal Value<br />**Description**: Shows the minimum allowed value of the property for a decimal data type.<br />|
|minvaluedouble|Edm.Double|**Display Name**: Minimum Double Value<br />**Description**: Shows the minimum allowed value of the property for a double data type.<br />|
|minvalueinteger|Edm.Int32|**Display Name**: Minimum Whole Number Value<br />**Description**: Shows the minimum allowed value of the property for a whole number data type.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the property.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|overwrittendynamicpropertyid|Edm.Guid|**Display Name**: Overwritten Property<br />**Description**: Shows the related overwritten property.<br />|
|precision|Edm.Int32|**Display Name**: Precision<br />**Description**: Shows the allowed precision of the property for a whole number data type.<br />|
|rootdynamicpropertyid|Edm.Guid|**Display Name**: Root Property<br />**Description**: Shows the root property that this property is derived from.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the state of the property.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Draft</td></tr><tr><td>2</td><td>Retired</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows whether the property is active or inactive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>0</td><td>Draft</td></tr><tr><td>2</td><td>Retired</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_basedynamicpropertyid_value|basedynamicpropertyid<br />|Shows the property in the product family that this property is being inherited from.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_defaultvalueoptionset_value|dynamicpropertyoptionsetvalueid<br />|Shows the default value of the property.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_regardingobjectid_value|regardingobjectid_product<br />regardingobjectid_productassociation<br />|Choose the product that the property is associated with.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|basedynamicpropertyid|[dynamicproperty EntityType](dynamicproperty.md)|dynamicproperty_base_dynamicproperty|
|createdby|[systemuser EntityType](systemuser.md)|lk_DynamicProperty_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_DynamicProperty_createdonbehalfby|
|dynamicpropertyoptionsetvalueid|[dynamicpropertyoptionsetitem EntityType](dynamicpropertyoptionsetitem.md)|DefaultValueOptionSet_DynamicProperty|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_DynamicProperty_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_DynamicProperty_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|dynamicproperty_organization|
|regardingobjectid_product|[product EntityType](product.md)|Product_DynamicProperty|
|regardingobjectid_productassociation|[productassociation EntityType](productassociation.md)|ProductAssociation_DynamicProperty|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|dynamicproperty_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_dynamicproperty|  
|dynamicproperty_base_dynamicproperty|[dynamicproperty EntityType](dynamicproperty.md)|basedynamicpropertyid|  
|dynamicproperty_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_dynamicproperty|  
|Dynamicproperty_DynamicPropertyAssociation|[dynamicpropertyassociation EntityType](dynamicpropertyassociation.md)|dynamicpropertyid|  
|DynamicProperty_DynamicPropertyInstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|dynamicpropertyid|  
|DynamicProperty_DynamicPropertyOptionSetItem|[dynamicpropertyoptionsetitem EntityType](dynamicpropertyoptionsetitem.md)|dynamicpropertyid|  
|dynamicproperty_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_dynamicproperty|  
|msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|msdyn_PropertyId|  

## Solutions
The following solutions include the dynamicproperty entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|    

[!INCLUDE[./remarks/dynamicproperty.md](./remarks/dynamicproperty.md)]

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