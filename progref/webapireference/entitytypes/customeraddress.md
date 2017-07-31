---
title: "Microsoft Dynamics 365 Customer Engagement customeraddress EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0ce92c6e-08b5-4657-a2e2-f4532540cbb7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API customeraddress entitytype."
---
# customeraddress EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/customeraddress.md](./descriptions/customeraddress.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]customeraddresses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Address</td></tr>
<tr><td><b>Primary Key:</b></td><td>customeraddressid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The customeraddress EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|addressnumber|Edm.Int32|**Display Name**: Address Number<br />**Description**: Shows the number of the address, to indicate whether the address is the primary, secondary, or other address for the customer.<br />|
|addresstypecode|Edm.Int32|**Display Name**: Address Type<br />**Description**: Select the address type, such as primary or billing.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Bill To</td></tr><tr><td>2</td><td>Ship To</td></tr><tr><td>3</td><td>Primary</td></tr><tr><td>4</td><td>Other</td></tr><tbody></table>|
|city|Edm.String|**Display Name**: City<br />**Description**: Type the city for the customer's address to help identify the location.<br />|
|composite|Edm.String|**Display Name**: Address<br />**Description**: Shows the complete address.<br />Read-only<br />|
|country|Edm.String|**Display Name**: Country/Region<br />**Description**: Type the country or region for the customer's address.<br />|
|county|Edm.String|**Display Name**: County<br />**Description**: Type the county for the customer's address.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|customeraddressid|Edm.Guid|**Display Name**: Address<br />**Description**: Unique identifier of the customer address.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|fax|Edm.String|**Display Name**: Fax<br />**Description**: Type the fax number associated with the customer's address.<br />|
|freighttermscode|Edm.Int32|**Display Name**: Freight Terms<br />**Description**: Select the freight terms to make sure shipping charges are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FOB</td></tr><tr><td>2</td><td>No Charge</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|latitude|Edm.Double|**Display Name**: Latitude<br />**Description**: Type the latitude value for the customer's address, for use in mapping and other applications.<br />|
|line1|Edm.String|**Display Name**: Street 1<br />**Description**: Type the first line of the customer's address to help identify the location.<br />|
|line2|Edm.String|**Display Name**: Street 2<br />**Description**: Type the second line of the customer's address.<br />|
|line3|Edm.String|**Display Name**: Street 3<br />**Description**: Type the third line of the customer's address.<br />|
|longitude|Edm.Double|**Display Name**: Longitude<br />**Description**: Type the longitude value for the customer's address, for use in mapping and other applications.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Address Name<br />**Description**: Type a descriptive name for the customer's address, such as Corporate Headquarters.<br />|
|objecttypecode|Edm.String|**Display Name**: Object Type <br />**Description**: Shows the type code of the customer record to indicate whether the address belongs to a customer account or contact.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|postalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the address.<br />|
|postofficebox|Edm.String|**Display Name**: Post Office Box<br />**Description**: Type the post office box number of the customer's address.<br />|
|primarycontactname|Edm.String|**Display Name**: Address Contact<br />**Description**: Type the name of the primary contact person for the customer's address.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Airborne</td></tr><tr><td>2</td><td>DHL</td></tr><tr><td>3</td><td>FedEx</td></tr><tr><td>4</td><td>UPS</td></tr><tr><td>5</td><td>Postal Mail</td></tr><tr><td>6</td><td>Full Load</td></tr><tr><td>7</td><td>Will Call</td></tr><tbody></table>|
|stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: Type the state or province of the customer's address.<br />|
|telephone1|Edm.String|**Display Name**: Main Phone<br />**Description**: Type the primary phone number for the customer's address.<br />|
|telephone2|Edm.String|**Display Name**: Phone 2<br />**Description**: Type a second phone number for the customer's address.<br />|
|telephone3|Edm.String|**Display Name**: Telephone 3<br />**Description**: Type a third phone number for the customer's address.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|upszone|Edm.String|**Display Name**: UPS Zone<br />**Description**: Type the UPS zone of the customer's address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|utcoffset|Edm.Int32|**Display Name**: UTC Offset<br />**Description**: Select the time zone for the address.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the customer address.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value||Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value||Shows the business unit that the record owner belongs to.|
|_owninguser_value||Unique identifier of the user who owns the customer address.|
|_parentid_value|parentid_account<br />parentid_contact<br />|Choose the customer's address.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_customeraddressbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_customeraddress_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_customeraddressbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_customeraddress_modifiedonbehalfby|
|parentid_account|[account EntityType](account.md)|Account_CustomerAddress|
|parentid_contact|[contact EntityType](contact.md)|Contact_CustomerAddress|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_CustomerAddress|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|customer_address_contract_line_items|[contractdetail EntityType](contractdetail.md)|serviceaddress|  
|customer_address_contracts_as_billing_address|[contract EntityType](contract.md)|billtoaddress|  
|customer_address_contracts_as_service_address|[contract EntityType](contract.md)|serviceaddress|  
|CustomerAddress_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_customeraddress|  
|CustomerAddress_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_customeraddress|  
|CustomerAddress_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_customeraddress_syncerror|    

[!INCLUDE[./remarks/customeraddress.md](./remarks/customeraddress.md)]

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