---
title: "Microsoft Dynamics 365 Customer Engagement sharepointsite EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: eba98254-45d2-409b-8127-ff3ba0752289
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sharepointsite entitytype."
---
# sharepointsite EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sharepointsite.md](./descriptions/sharepointsite.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]sharepointsites </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>SharePoint Site</td></tr>
<tr><td><b>Primary Key:</b></td><td>sharepointsiteid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The sharepointsite entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|absoluteurl|Edm.String|**Display Name**: Absolute URL<br />**Description**: Absolute URL of the SharePoint site.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the SharePoint site record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the SharePoint site record.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate between the currency associated with the SharePoint site record and the base currency.<br />Read-only<br />|
|folderstructureentity|Edm.String|**Display Name**: Entity for SharePoint Folder Structure<br />**Description**: Entity on which the folder structure for Microsoft Dynamics 365 records will be created in SharePoint.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isdefault|Edm.Boolean|**Display Name**: Default Site<br />**Description**: Indicates whether the SharePoint site is the default site or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isgridpresent|Edm.Boolean|**Display Name**: List component is installed<br />**Description**: Indicates if SharePoint Grid is present or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ispowerbisite|Edm.Boolean|**Display Name**: Allow Embedding of Power BI Reports<br />**Description**: Allows embedding of Power BI Reports available in this SharePoint site.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastvalidated|Edm.DateTimeOffset|**Display Name**: Last Validated<br />**Description**: Date and time when the SharePoint site URL was last validated.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the SharePoint site record was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the SharePoint site record.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|relativeurl|Edm.String|**Display Name**: Relative URL<br />**Description**: Relative URL of the SharePoint site.<br />|
|servicetype|Edm.Int32|**Display Name**: Service Type<br />**Description**: Shows the service type of location of the SharePoint site.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>SharePoint</td></tr><tr><td>1</td><td>OneDrive</td></tr><tr><td>2</td><td>Shared with me</td></tr><tbody></table>|
|sharepointsiteid|Edm.Guid|**Display Name**: SharePoint Site ID<br />**Description**: Unique identifier of the SharePoint site in Dynamics 365<br />|
|sitecollectionid|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the SharePoint site record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the SharePoint site record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|userid|Edm.Guid|**Display Name**: SharePoint Site Owner<br />**Description**: Choose the user who owns the SharePoint site.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|
|validationstatus|Edm.Int32|**Display Name**: Last Validation Status<br />**Description**: Validation status of the SharePoint site URL.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Not Validated</td></tr><tr><td>2</td><td>In Progress</td></tr><tr><td>3</td><td>Invalid</td></tr><tr><td>4</td><td>Valid</td></tr><tr><td>5</td><td>Could not validate</td></tr><tbody></table>|
|validationstatuserrorcode|Edm.Int32|**Display Name**: Additional Information<br />**Description**: Reason for validation status of the URL<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>This record's URL has not been validated.</td></tr><tr><td>2</td><td>This record's URL is valid.</td></tr><tr><td>3</td><td>This record's URL is not valid.</td></tr><tr><td>4</td><td>The URL schemes of Microsoft Dynamics 365 and SharePoint are different.</td></tr><tr><td>5</td><td>The URL could not be accessed because of Internet Explorer security settings.</td></tr><tr><td>6</td><td>Authentication failure.</td></tr><tr><td>7</td><td>Invalid certificates.</td></tr><tbody></table>|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the SharePoint site record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the SharePoint site record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the SharePoint site record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the SharePoint site record.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the SharePoint site.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the document location record.|
|_owningteam_value|owningteam<br />|Unique identifier of the team that owns the SharePoint site record.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the SharePoint site record.|
|_parentsite_value|parentsite<br />|Unique identifier of the parent SharePoint site.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the SharePoint site record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_sharepointsitebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_sharepointsitebase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_sharepointsitebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_sharepointsitebase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_sharepointsite|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_sharepointsites|
|owningteam|[team EntityType](team.md)|team_sharepointsite|
|owninguser|[systemuser EntityType](systemuser.md)|user_sharepointsite|
|parentsite|[sharepointsite EntityType](sharepointsite.md)|sharepointsite_parentsite_sharepointsite|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_SharePointSite|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|sharepointdocumentlocation_parent_sharepointsite|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|parentsiteorlocation_sharepointsite|  
|SharePointSite_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_sharepointsite|  
|SharePointSite_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_sharepointsite|  
|SharePointSite_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_sharepointsite|  
|sharepointsite_parentsite_sharepointsite|[sharepointsite EntityType](sharepointsite.md)|parentsite|  
|SharePointSite_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_sharepointsite_syncerror|  

## Operations
The following operations can be used with the sharepointsite entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrieveAbsoluteAndSiteCollectionUrl Function](../functions/retrieveabsoluteandsitecollectionurl.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveabsoluteandsitecollectionurl.md](../functions/descriptions/retrieveabsoluteandsitecollectionurl.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/sharepointsite.md](./remarks/sharepointsite.md)]

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