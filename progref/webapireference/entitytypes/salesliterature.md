---
title: "Microsoft Dynamics 365 Customer Engagement salesliterature EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 07e9ad86-0838-4a75-948e-1c64873ab9e6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API salesliterature entitytype."
---
# salesliterature EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/salesliterature.md](./descriptions/salesliterature.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]salesliteratures </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sales Literature</td></tr>
<tr><td><b>Primary Key:</b></td><td>salesliteratureid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the sales literature, such as the intended audience or primary messages.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|expirationdate|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />**Description**: Enter the expiration date or last day the sales literature can be distributed.<br />|
|hasattachments|Edm.Boolean|**Display Name**: Has Attachments<br />**Description**: Tells whether the sales literature has one or more attachments.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|iscustomerviewable|Edm.Boolean|**Display Name**: Customer Viewable<br />**Description**: Select whether the sales literature can be distributed to prospects and customers or is for internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|keywords|Edm.String|**Display Name**: Key Words<br />**Description**: Type one or more topics or keywords that can be used to search for the sales literature.<br />|
|literaturetypecode|Edm.Int32|**Display Name**: Type<br />**Description**: Select a category or type to help others identify the intended use of the sales literature.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Presentation</td></tr><tr><td>1</td><td>Product Sheet</td></tr><tr><td>2</td><td>Policies And Procedures</td></tr><tr><td>3</td><td>Sales Literature</td></tr><tr><td>4</td><td>Spreadsheets</td></tr><tr><td>5</td><td>News</td></tr><tr><td>6</td><td>Bulletins</td></tr><tr><td>7</td><td>Price Sheets</td></tr><tr><td>8</td><td>Manuals</td></tr><tr><td>9</td><td>Company Background</td></tr><tr><td>100001</td><td>Marketing Collateral</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Title<br />**Description**: Type a descriptive title for the sales literature.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|salesliteratureid|Edm.Guid|**Display Name**: Sales Literature<br />**Description**: Unique identifier of the sales literature.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_employeecontactid_value|employeecontactid<br />|Choose the user who is responsible for maintaining or updating the sales literature.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_subjectid_value|subjectid<br />|Choose the subject for the sales literature to relate the item to a product or business group. Administrators can configure subjects under Business Management in the Settings area.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_salesliteraturebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_salesliterature_createdonbehalfby|
|employeecontactid|[systemuser EntityType](systemuser.md)|system_user_sales_literature|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_salesliteraturebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_salesliterature_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_sales_literature|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_salesliteratures|
|subjectid|[subject EntityType](subject.md)|subject_sales_literature|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_SalesLiterature|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|campaignactivitysalesliterature_association|[campaignactivity EntityType](campaignactivity.md)|campaignactivitysalesliterature_association|  
|campaignsalesliterature_association|[campaign EntityType](campaign.md)|campaignsalesliterature_association|  
|competitorsalesliterature_association|[competitor EntityType](competitor.md)|competitorsalesliterature_association|  
|productsalesliterature_association|[product EntityType](product.md)|productsalesliterature_association|  
|sales_literature_items|[salesliteratureitem EntityType](salesliteratureitem.md)|salesliteratureid|  
|SalesLiterature_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_salesliterature|  
|SalesLiterature_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_salesliterature|  
|SalesLiterature_SharepointDocumentLocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_salesliterature|  
|SalesLiterature_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_salesliterature_syncerror|  

## Operations
The following operations can be used with the salesliterature entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddItemCampaign Action](../actions/additemcampaign.md)|Entity|[!INCLUDE[../actions/descriptions/additemcampaign.md](../actions/descriptions/additemcampaign.md)]|  

## Solutions
The following solutions include the salesliterature entity type.


|Name|Description |  
|----|------------|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/salesliterature.md](./remarks/salesliterature.md)]

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