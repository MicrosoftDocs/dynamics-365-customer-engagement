---
title: "Microsoft Dynamics 365 Customer Engagement competitor EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d8f7e9f4-5fa0-4c42-ad4f-c9f88e0c93d7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API competitor entitytype."
---
# competitor EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/competitor.md](./descriptions/competitor.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]competitors </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Competitor</td></tr>
<tr><td><b>Primary Key:</b></td><td>competitorid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The competitor entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|address1_addressid|Edm.Guid|**Display Name**: Address 1: ID<br />**Description**: Unique identifier for address 1.<br />|
|address1_addresstypecode|Edm.Int32|**Display Name**: Address 1: Address Type<br />**Description**: Select the primary address type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_city|Edm.String|**Display Name**: City<br />**Description**: Type the city for the primary address.<br />|
|address1_composite|Edm.String|**Display Name**: Address 1<br />**Description**: Shows the complete primary address.<br />Read-only<br />|
|address1_country|Edm.String|**Display Name**: Country/Region<br />**Description**: Type the country or region for the primary address.<br />|
|address1_county|Edm.String|**Display Name**: Address 1: County<br />**Description**: Type the county for the primary address.<br />|
|address1_fax|Edm.String|**Display Name**: Address 1: Fax<br />**Description**: Type the fax number associated with the primary address.<br />|
|address1_latitude|Edm.Double|**Display Name**: Address 1: Latitude<br />**Description**: Type the latitude value for the primary address for use in mapping and other applications.<br />|
|address1_line1|Edm.String|**Display Name**: Street 1<br />**Description**: Type the first line of the primary address.<br />|
|address1_line2|Edm.String|**Display Name**: Street 2<br />**Description**: Type the second line of the primary address.<br />|
|address1_line3|Edm.String|**Display Name**: Street 3<br />**Description**: Type the third line of the primary address.<br />|
|address1_longitude|Edm.Double|**Display Name**: Address 1: Longitude<br />**Description**: Type the longitude value for the primary address for use in mapping and other applications.<br />|
|address1_name|Edm.String|**Display Name**: Address 1: Name<br />**Description**: Type a descriptive name for the primary address, such as Corporate Headquarters.<br />|
|address1_postalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the primary address.<br />|
|address1_postofficebox|Edm.String|**Display Name**: Address 1: Post Office Box<br />**Description**: Type the post office box number of the primary address.<br />|
|address1_shippingmethodcode|Edm.Int32|**Display Name**: Address 1: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: Type the state or province of the primary address.<br />|
|address1_telephone1|Edm.String|**Display Name**: Address 1: Telephone 1<br />**Description**: Type the main phone number associated with the primary address.<br />|
|address1_telephone2|Edm.String|**Display Name**: Address 1: Telephone 2<br />**Description**: Type a second phone number associated with the primary address.<br />|
|address1_telephone3|Edm.String|**Display Name**: Address 1: Telephone 3<br />**Description**: Type a third phone number associated with the primary address.<br />|
|address1_upszone|Edm.String|**Display Name**: Address 1: UPS Zone<br />**Description**: Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />|
|address1_utcoffset|Edm.Int32|**Display Name**: Address 1: UTC Offset<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|address2_addressid|Edm.Guid|**Display Name**: Address 2: ID<br />**Description**: Unique identifier for address 2.<br />|
|address2_addresstypecode|Edm.Int32|**Display Name**: Address 2: Address Type<br />**Description**: Select the secondary address type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_city|Edm.String|**Display Name**: Address 2: City<br />**Description**: Type the city for the secondary address.<br />|
|address2_composite|Edm.String|**Display Name**: Address 2<br />**Description**: Shows the complete secondary address.<br />Read-only<br />|
|address2_country|Edm.String|**Display Name**: Address 2: Country/Region<br />**Description**: Type the country or region for the secondary address.<br />|
|address2_county|Edm.String|**Display Name**: Address 2: County<br />**Description**: Type the county for the secondary address.<br />|
|address2_fax|Edm.String|**Display Name**: Address 2: Fax<br />**Description**: Type the fax number associated with the secondary address.<br />|
|address2_latitude|Edm.Double|**Display Name**: Address 2: Latitude<br />**Description**: Type the latitude value for the secondary address for use in mapping and other applications.<br />|
|address2_line1|Edm.String|**Display Name**: Address 2: Street 1<br />**Description**: Type the first line of the secondary address.<br />|
|address2_line2|Edm.String|**Display Name**: Address 2: Street 2<br />**Description**: Type the second line of the secondary address.<br />|
|address2_line3|Edm.String|**Display Name**: Address 2: Street 3<br />**Description**: Type the third line of the secondary address.<br />|
|address2_longitude|Edm.Double|**Display Name**: Address 2: Longitude<br />**Description**: Type the longitude value for the secondary address for use in mapping and other applications.<br />|
|address2_name|Edm.String|**Display Name**: Address 2: Name<br />**Description**: Type a descriptive name for the secondary address, such as Corporate Headquarters.<br />|
|address2_postalcode|Edm.String|**Display Name**: Address 2: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the secondary address.<br />|
|address2_postofficebox|Edm.String|**Display Name**: Address 2: Post Office Box<br />**Description**: Type the post office box number of the secondary address.<br />|
|address2_shippingmethodcode|Edm.Int32|**Display Name**: Address 2: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_stateorprovince|Edm.String|**Display Name**: Address 2: State/Province<br />**Description**: Type the state or province of the secondary address.<br />|
|address2_telephone1|Edm.String|**Display Name**: Address 2: Telephone 1<br />**Description**: Type the main phone number associated with the secondary address.<br />|
|address2_telephone2|Edm.String|**Display Name**: Address 2: Telephone 2<br />**Description**: Type a second phone number associated with the secondary address.<br />|
|address2_telephone3|Edm.String|**Display Name**: Address 2: Telephone 3<br />**Description**: Type a third phone number associated with the secondary address.<br />|
|address2_upszone|Edm.String|**Display Name**: Address 2: UPS Zone<br />**Description**: Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly , if shipped by UPS.<br />|
|address2_utcoffset|Edm.Int32|**Display Name**: Address 2: UTC Offset<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|competitorid|Edm.Guid|**Display Name**: Competitor <br />**Description**: Unique identifier of the competitor.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: Shows the default image for the record.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|keyproduct|Edm.String|**Display Name**: Key Product<br />**Description**: Type the competitor's primary product, service, or specialty.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the company or business name used to identify the competitor in data views and related records.<br />|
|opportunities|Edm.String|**Display Name**: Opportunity<br />**Description**: Type notes or other information about the competitive opportunities or selling points you can make.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|overview|Edm.String|**Display Name**: Overview<br />**Description**: Type notes or other information about the competitor's business, such as location, revenue, or distribution channel.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|referenceinfourl|Edm.String|**Display Name**: Reference Info URL<br />**Description**: Type the URL for the website used to obtain reference information about the competitor.<br />|
|reportedrevenue|Edm.Decimal|**Display Name**: Reported Revenue<br />**Description**: Type the amount of revenue reported in the competitor's annual report or other source.<br />|
|reportedrevenue_base|Edm.Decimal|**Display Name**: Reported Revenue (Base)<br />**Description**: Value of the Reported Revenue in base currency.<br />Read-only<br />|
|reportingquarter|Edm.Int32|**Display Name**: Reporting Quarter<br />**Description**: Type the quarter number during which the competitor's reported revenue was recorded or announced for use in reporting and analysis.<br />|
|reportingyear|Edm.Int32|**Display Name**: Reporting Year<br />**Description**: Type the fiscal year during which the competitor's reported revenue was announced for use in reporting and analysis.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|stockexchange|Edm.String|**Display Name**: Stock Exchange<br />**Description**: Type the stock exchange at which the competitor is listed to track their stock and financial performance of the company.<br />|
|strengths|Edm.String|**Display Name**: Strength<br />**Description**: Type notes or other information about the competitor's strengths, such as top-selling products and targeted industries or markets.<br />|
|threats|Edm.String|**Display Name**: Threat<br />**Description**: Type notes or other information about the competitor's threats to your organization when you sell to the same prospect or customer.<br />|
|tickersymbol|Edm.String|**Display Name**: Ticker Symbol<br />**Description**: Type the stock exchange symbol for the competitor to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|
|weaknesses|Edm.String|**Display Name**: Weakness<br />**Description**: Type notes or other information about the competitor's weaknesses or areas in which your organization outperforms the competitor.<br />|
|websiteurl|Edm.String|**Display Name**: Website<br />**Description**: Type the website URL for the competitor.<br />|
|winpercentage|Edm.Double|**Display Name**: Win Percentage<br />**Description**: Type the percentage of your organization's lost opportunities that are won by the competitor to identify your strongest competitors.<br />|
|yominame|Edm.String|**Display Name**: Yomi Name<br />**Description**: Type the phonetic spelling of the competitor's name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_competitorbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_competitor_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_competitorbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_competitor_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_competitors|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_competitors|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_competitor|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|competitor_addresses|[competitoraddress EntityType](competitoraddress.md)|parentid|  
|Competitor_Annotation|[annotation EntityType](annotation.md)|objectid_competitor|  
|Competitor_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_competitor|  
|Competitor_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_competitor|  
|competitor_connections1|[connection EntityType](connection.md)|record1id_competitor|  
|competitor_connections2|[connection EntityType](connection.md)|record2id_competitor|  
|Competitor_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_competitor|  
|Competitor_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_competitor|  
|competitor_opportunity_activities|[opportunityclose EntityType](opportunityclose.md)|competitorid|  
|competitor_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_competitor|  
|competitor_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_competitor|  
|Competitor_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_competitor_syncerror|  
|competitorproduct_association|[product EntityType](product.md)|competitorproduct_association|  
|competitorsalesliterature_association|[salesliterature EntityType](salesliterature.md)|competitorsalesliterature_association|  
|leadcompetitors_association|[lead EntityType](lead.md)|leadcompetitors_association|  
|opportunitycompetitors_association|[opportunity EntityType](opportunity.md)|opportunitycompetitors_association|  

## Solutions
The following solutions include the competitor entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/competitor.md](./remarks/competitor.md)]

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