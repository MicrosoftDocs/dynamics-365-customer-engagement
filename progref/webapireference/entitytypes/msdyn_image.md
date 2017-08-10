---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_image EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5a606a0c-8590-4486-8678-885c30c0429a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_image entitytype."
---
# msdyn_image EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_image.md](./descriptions/msdyn_image.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_images </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Image</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_imageid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_image entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_alternativetext|Edm.String|**Display Name**: Alternative Text<br />**Description**: Type alternative text for the image.<br />|
|msdyn_extension|Edm.Int32|**Display Name**: Extension<br />**Description**: Shows the file extension for the image.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>.png</td></tr><tr><td>986540001</td><td>.jpg</td></tr><tr><td>986540002</td><td>.gif</td></tr><tbody></table>|
|msdyn_imageformat|Edm.Int32|**Display Name**: Image Format<br />**Description**: Image format<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540002</td><td>.gif</td></tr><tr><td>986540000</td><td>.jpg</td></tr><tr><td>986540001</td><td>.png</td></tr><tbody></table>|
|msdyn_imageid|Edm.Guid|**Display Name**: Image<br />**Description**: Shows the entity instances.<br />|
|msdyn_imagetitle|Edm.String|**Display Name**: Image Title<br />**Description**: Type a title for the image.<br />|
|msdyn_imagetype|Edm.Int32|**Display Name**: Image type<br />**Description**: Select the image type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Stock image</td></tr><tr><td>986540001</td><td>Uploaded custom image</td></tr><tbody></table>|
|msdyn_imageurl|Edm.String|**Display Name**: Image URL<br />**Description**: Enter the image URL.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_size|Edm.Int32|**Display Name**: Size<br />**Description**: Select the size of the image<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>32</td><td>32</td></tr><tr><td>48</td><td>48</td></tr><tr><td>72</td><td>72</td></tr><tr><td>128</td><td>128</td></tr><tbody></table>|
|msdyn_stockiconname|Edm.String|**Display Name**: Stock Icon Name<br />**Description**: Enter the name of the stock icon.<br />|
|msdyn_token|Edm.String|**Display Name**: Token<br />**Description**: Security token<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the image.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the image.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Shows the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_image_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_image_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_image_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_image_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_image|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_image|
|owningteam|[team EntityType](team.md)|team_msdyn_image|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_image|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_image_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_image|  
|msdyn_image_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_image|  
|msdyn_image_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_image|  
|msdyn_image_section|[msdyn_section EntityType](msdyn_section.md)|msdyn_ImageId|  
|msdyn_image_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_SurveyImageId|  
|msdyn_image_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_image|  

## Operations
The following operations can be used with the msdyn_image entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_image entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_image.md](./remarks/msdyn_image.md)]

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