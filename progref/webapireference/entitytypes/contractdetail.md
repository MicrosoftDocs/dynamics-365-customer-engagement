---
title: "Microsoft Dynamics 365 Customer Engagement contractdetail EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c4d6fb96-a1cc-4b3b-943c-1f5189b69385
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API contractdetail entitytype."
---
# contractdetail EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/contractdetail.md](./descriptions/contractdetail.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]contractdetails </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Contract Line</td></tr>
<tr><td><b>Primary Key:</b></td><td>contractdetailid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The contractdetail entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activeon|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Enter the date when the contract line becomes active.<br />|
|allotmentsoverage|Edm.Int32|**Display Name**: Allotments Overage<br />**Description**: Shows the number of minutes over the Total Allotments field that have been spent on resolved cases related to the contract line.<br />Read-only<br />|
|allotmentsremaining|Edm.Int32|**Display Name**: Allotments Remaining<br />**Description**: Shows the number of cases or minutes remaining, based on the resolved cases logged to the contract line.<br />Read-only<br />|
|allotmentsused|Edm.Int32|**Display Name**: Allotments Used<br />**Description**: Shows the number of cases or minutes used in the resolved cases on the contract line.<br />Read-only<br />|
|contractdetailid|Edm.Guid|**Display Name**: Contract Line<br />**Description**: Unique identifier of the contract line.<br />|
|contractstatecode|Edm.Int32|**Display Name**: Contract State<br />**Description**: Status of the contract.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|discount|Edm.Decimal|**Display Name**: Discount<br />**Description**: Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.<br />|
|discount_base|Edm.Decimal|**Display Name**: Discount (Base)<br />**Description**: Value of the Discount in base currency.<br />Read-only<br />|
|discountpercentage|Edm.Decimal|**Display Name**: Discount (%)<br />**Description**: Type the discount rate that should be applied to the Total Price, for use in calculating the net amount due for the contract line.<br />|
|effectivitycalendar|Edm.String|**Display Name**: Support Calendar<br />**Description**: Days of the week and times for which the contract line item is effective.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|expireson|Edm.DateTimeOffset|**Display Name**: End Date<br />**Description**: Enter the date when the contract line expires. The date is automatically filled with the contract date, but you can change it if required.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|initialquantity|Edm.Int32|**Display Name**: Quantity<br />**Description**: Type the number of units of the specified product or service that are eligible for support on the contract line.<br />|
|lineitemorder|Edm.Int32|**Display Name**: Line Item Order<br />**Description**: Type the line item number for the contract line to easily identify the contract line and make sure it's listed in the correct order in the parent contract.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|net|Edm.Decimal|**Display Name**: Net<br />**Description**: Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.<br />Read-only<br />|
|net_base|Edm.Decimal|**Display Name**: Net (Base)<br />**Description**: Value of the Net in base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|price|Edm.Decimal|**Display Name**: Total Price<br />**Description**: Type the total service charge for the contract line before any discounts are credited.<br />|
|price_base|Edm.Decimal|**Display Name**: Total Price (Base)<br />**Description**: Value of the Total Price in base currency.<br />Read-only<br />|
|productserialnumber|Edm.String|**Display Name**: Serial Number<br />**Description**: Type the serial number for the product that is eligible for services on the contract line.<br />|
|rate|Edm.Decimal|**Display Name**: Rate<br />**Description**: Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or minutes allocated to the contract line.<br />Read-only<br />|
|rate_base|Edm.Decimal|**Display Name**: Rate (Base)<br />**Description**: Value of the Rate in base currency.<br />Read-only<br />|
|servicecontractunitscode|Edm.Int32|**Display Name**: Service Contract Units<br />**Description**: Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it is saved, regardless of the status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Existing</td></tr><tr><td>1</td><td>Renewed</td></tr><tr><td>2</td><td>Canceled</td></tr><tr><td>3</td><td>Expired</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the contract line's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>New</td></tr><tr><td>2</td><td>Renewed</td></tr><tr><td>3</td><td>Canceled</td></tr><tr><td>4</td><td>Expired</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Type a title or name that describes the contract line.<br />|
|totalallotments|Edm.Int32|**Display Name**: Total Allotments<br />**Description**: Type the total number of minutes or cases allowed for the contract line.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Unique identifier of the account with which the contract is associated.|
|_contactid_value||Unique identifier for the contact associated with the contract line.|
|_contractid_value|contractid<br />|Unique identifier of the contract associated with the contract line.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_productid_value|productid<br />|Choose the product that is eligible for services on the contract line.|
|_serviceaddress_value|serviceaddress<br />|Choose the address for the customer account or contact where the services are provided.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|_uomid_value|uomid<br />|Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.|
|_uomscheduleid_value|uomscheduleid<br />|Unique identifier of the unit group associated with the contract line.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|contractid|[contract EntityType](contract.md)|contract_line_items|
|createdby|[systemuser EntityType](systemuser.md)|lk_contractdetailbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_contractdetail_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|contractlineitem_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|contractlineitem_customer_contacts|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_contractdetailbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_contractdetail_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_contractdetail|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_contractdetail|
|owningteam|[team EntityType](team.md)|team_contractdetail|
|owninguser|[systemuser EntityType](systemuser.md)|user_contractdetail|
|productid|[product EntityType](product.md)|product_contract_line_items|
|serviceaddress|[customeraddress EntityType](customeraddress.md)|customer_address_contract_line_items|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_contractdetail|
|uomid|[uom EntityType](uom.md)|unit_of_measurement_contract_line_items|
|uomscheduleid|[uomschedule EntityType](uomschedule.md)|contract_detail_unit_of_measure_schedule|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|contract_detail_cases|[incident EntityType](incident.md)|contractdetailid|  
|ContractDetail_Annotation|[annotation EntityType](annotation.md)|objectid_contractdetail|  
|ContractDetail_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_contractdetail|  
|ContractDetail_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_contractdetail|  
|ContractDetail_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_contractdetail_syncerror|  

## Solutions
The following solutions include the contractdetail entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/contractdetail.md](./remarks/contractdetail.md)]

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