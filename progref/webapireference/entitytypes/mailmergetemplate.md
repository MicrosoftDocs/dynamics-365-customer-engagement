---
title: "Microsoft Dynamics 365 Customer Engagement mailmergetemplate EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2c29bb56-789a-4d7f-89b6-323dd3681c2f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API mailmergetemplate entitytype."
---
# mailmergetemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/mailmergetemplate.md](./descriptions/mailmergetemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]mailmergetemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Mail Merge Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>mailmergetemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The mailmergetemplate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|body|Edm.String|**Display Name**: Body<br />**Description**: Body text of the mail merge template.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the mail merge template was created.<br />Read-only<br />|
|defaultfilter|Edm.String|**Display Name**: Default filter<br />**Description**: Default data fields associated with the mail merge template.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the mail merge template.<br />|
|documentformat|Edm.Int32|**Display Name**: Document Format<br />**Description**: Version of the Microsoft Office Word XML format used by the template.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>2003</td></tr><tr><td>2</td><td>2007</td></tr><tbody></table>|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the mailmergetemplate with respect to the base currency.<br />Read-only<br />|
|filename|Edm.String|**Display Name**: File Name<br />**Description**: File name of the mail merge template.<br />|
|filesize|Edm.Int32|**Display Name**: File Size (Bytes)<br />**Description**: File size of the mail merge template.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|ispersonal|Edm.Boolean|**Display Name**: Viewable By<br />**Description**: Information about whether the mail merge template is personal or is available to all users.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Individual</td></tr><tr><td>0</td><td>Organization</td></tr><tbody></table>|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Language of the mail merge template.<br />|
|mailmergetemplateid|Edm.Guid|**Display Name**: Mail Merge Template<br />**Description**: Unique identifier of the mail merge template.<br />|
|mailmergetemplateidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|mailmergetype|Edm.Int32|**Display Name**: Mail Merge Type<br />**Description**: Drop-down list for selecting the type of the mail merge.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Letter</td></tr><tr><td>2</td><td>Email Message</td></tr><tr><td>3</td><td>Envelope</td></tr><tr><td>4</td><td>Labels</td></tr><tr><td>5</td><td>Quotes</td></tr><tr><td>6</td><td>Fax</td></tr><tbody></table>|
|mimetype|Edm.String|**Display Name**: Mime Type<br />**Description**: MIME type of the mail merge template.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the mail merge template was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the mail merge template.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|parameterxml|Edm.String|**Display Name**: Parameter Xml<br />**Description**: Parameter Xml.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the mail merge template.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the mail merge template.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|templatetypecode|Edm.String|**Display Name**: Associated Entity<br />**Description**: Type of mail merge template.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the mail merge template.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the mail merge template.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the mailmergetemplate.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the mail merge template.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the mailmergetemplate.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the mail merge template.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the mail merge template.|
|_owningteam_value||Unique identifier of the team who owns the mail merge template.|
|_owninguser_value||Unique identifier of the user who owns the mail merge template.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the mailmergetemplate.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_mailmergetemplatebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_mailmergetemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_mailmergetemplatebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_mailmergetemplate_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_mailmergetemplates|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_mailmergetemplates|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_MailMergeTemplate|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|MailMergeTemplate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_mailmergetemplate|  
|MailMergeTemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_mailmergetemplate_syncerror|  

## Operations
The following operations can be used with the mailmergetemplate entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the mailmergetemplate entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/mailmergetemplate.md](./remarks/mailmergetemplate.md)]

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