---
title: "Microsoft Dynamics 365 Customer Engagement adx_externalidentity EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c5f1db7b-1f5e-4343-ae63-43c55baa3e96
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_externalidentity entitytype."
---
# adx_externalidentity EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_externalidentity.md](./descriptions/adx_externalidentity.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]adx_externalidentities </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>External Identity</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_externalidentityid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_username</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_externalidentity entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_externalidentityid|Edm.Guid|**Display Name**: External Identity<br />**Description**: Shows the entity instances.<br />|
|adx_identityprovidername|Edm.String|**Display Name**: Identity Provider<br />|
|adx_username|Edm.String|**Display Name**: User Name<br />**Description**: Shows the name of the custom entity.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the external identity is active or inactive. Inactive records are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the external identity's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_contactid_value|adx_contactid<br />|Unique identifier for Contact associated with External Identity.|
|_createdby_value|createdby<br />|Shows the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Shows the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_contactid|[contact EntityType](contact.md)|adx_contact_externalidentity|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_externalidentity_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_externalidentity_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_externalidentity_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_externalidentity_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_adx_externalidentity|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_externalidentity_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_externalidentity|  
|adx_externalidentity_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_externalidentity|  
|adx_externalidentity_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_externalidentity|  

## Operations
The following operations can be used with the adx_externalidentity entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the adx_externalidentity entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Identity Solution](../solutions/microsoftidentity.md)|[!INCLUDE[../solutions/descriptions/microsoftidentity.md](../solutions/descriptions/microsoftidentity.md)]|    

[!INCLUDE[./remarks/adx_externalidentity.md](./remarks/adx_externalidentity.md)]

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