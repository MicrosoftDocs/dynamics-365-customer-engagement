---
title: "Microsoft Dynamics 365 Customer Engagement similarityrule EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 262f5af3-362f-496c-96fe-9c88024456c8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API similarityrule entitytype."
---
# similarityrule EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/similarityrule.md](./descriptions/similarityrule.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]similarityrules </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Similarity Rule</td></tr>
<tr><td><b>Primary Key:</b></td><td>similarityruleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The similarityrule EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activerulefetchxml|Edm.String|**Display Name**: Active Rule Fetch Xml<br />**Description**: Generated Fetch xml from Active rule and rule conditions.<br />|
|baseentityname|Edm.String|**Display Name**: Base Record Type<br />**Description**: Record type of the record being evaluated for potential similarities.<br />|
|baseentitytypecode|Edm.Int32|**Display Name**: Base Record Type<br />**Description**: Record type of the record being evaluated for potential similarities.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the similarity detection rule.<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the SimilarityRule with respect to the base currency.<br />Read-only<br />|
|excludeinactiverecords|Edm.Boolean|**Display Name**: Exclude Inactive Records<br />**Description**: Determines whether to flag inactive records as similarities<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|fetchxmllist|Edm.String|**Display Name**: Fetch Xml<br />**Description**: Fetch Xml<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the similarity rule is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Is Managed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|matchingentityname|Edm.String|**Display Name**: Matching Record Type<br />**Description**: Record type of the records being evaluated as potential similarities.<br />|
|matchingentitytypecode|Edm.Int32|**Display Name**: Matching Record Type<br />**Description**: Record type of the records being evaluated as potential similarities.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|maxkeywords|Edm.Int32|**Display Name**: Maximum Number of Key Phrases<br />**Description**: Enter the maximum number of keywords and key phrases to use with text analytics.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|ngramsize|Edm.Int32|**Display Name**: Maximum Key Phrase Words<br />**Description**: Enter the maximum number of words in a key phrase to use with text analytics.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|ruleconditionxml|Edm.String|**Display Name**: Rule Conditions Xml<br />**Description**: ConditionXml for similarity rule conditions.<br />|
|similarityruleid|Edm.Guid|**Display Name**: Similarity Rule<br />**Description**: Unique identifier for entity instances<br />|
|similarityruleidunique|Edm.Guid|**Display Name**: SimilarityRule<br />**Description**: Unique identifier of the Similarity Rule used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Similarity Rule<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Active</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Similarity Rule<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Active</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the SimilarityRule with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_similarityrule_createdonbehalfby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_similarityrule_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_similarityrule|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_SimilarityRule|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|similarityrule_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_similarityrule|    

[!INCLUDE[./remarks/similarityrule.md](./remarks/similarityrule.md)]

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