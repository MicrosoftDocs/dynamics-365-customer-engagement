---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_orderinvoicingsetupdate EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c2505773-7112-45b3-98ed-0bd1fa254e2b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_orderinvoicingsetupdate entitytype."
---
# msdyn_orderinvoicingsetupdate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_orderinvoicingsetupdate.md](./descriptions/msdyn_orderinvoicingsetupdate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_orderinvoicingsetupdates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Order Invoicing Setup Date</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_orderinvoicingsetupdateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_orderinvoicingsetupdate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_invoicedate|Edm.DateTimeOffset|**Display Name**: Period End<br />**Description**: The last day of the invoicing period.<br />|
|msdyn_invoicestatus|Edm.Int32|**Display Name**: Invoice Status<br />**Description**: Status of the invoice generation for this Invoice Date<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Scheduled</td></tr><tr><td>690970001</td><td>Processed</td></tr><tr><td>690970002</td><td>Canceled</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_orderinvoicingsetupdateid|Edm.Guid|**Display Name**: Order Invoicing Setup Date<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_postponegenerationuntil|Edm.DateTimeOffset|**Display Name**: Postpone Generation Until<br />**Description**: Time and date used for scheduling invoice generation.<br />|
|msdyn_previousinvoicedate|Edm.DateTimeOffset|**Display Name**: Period Start<br />**Description**: The first day of the invoicing period.<br />|
|msdyn_revision|Edm.Int32|**Display Name**: Revision<br />**Description**: For internal use only.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Order Invoicing Setup Date<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Order Invoicing Setup Date<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_invoice_value|msdyn_Invoice<br />|Shows the invoice generated for this invoice date.|
|_msdyn_invoicesetup_value|msdyn_InvoiceSetup<br />|Invoice Setup this Invoice Date relates to|
|_msdyn_order_value|msdyn_Order<br />|Order this Invoice Date relates to|
|_msdyn_orderinvoicingdate_value|msdyn_OrderInvoicingDate<br />|Reference to the Order Invoicing Date that this record relates to.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_orderinvoicingsetupdate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_orderinvoicingsetupdate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_orderinvoicingsetupdate_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_orderinvoicingsetupdate_modifiedonbehalfby|
|msdyn_Invoice|[invoice EntityType](invoice.md)|msdyn_invoice_msdyn_orderinvoicingsetupdate_Invoice|
|msdyn_InvoiceSetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|msdyn_msdyn_orderinvoicingsetup_msdyn_orderinvoicingsetupdate_InvoiceSetup|
|msdyn_Order|[salesorder EntityType](salesorder.md)|msdyn_salesorder_msdyn_orderinvoicingsetupdate_Order|
|msdyn_OrderInvoicingDate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|msdyn_msdyn_orderinvoicingdate_msdyn_orderinvoicingsetupdate_OrderInvoicingDate|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_orderinvoicingsetupdate|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_orderinvoicingsetupdate|
|owningteam|[team EntityType](team.md)|team_msdyn_orderinvoicingsetupdate|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_orderinvoicingsetupdate|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_orderinvoicingsetupdate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_orderinvoicingsetupdate|  
|msdyn_orderinvoicingsetupdate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_orderinvoicingsetupdate|  
|msdyn_orderinvoicingsetupdate_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_orderinvoicingsetupdate|  
|msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_orderinvoicingsetupdate|  
|msdyn_orderinvoicingsetupdate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_orderinvoicingsetupdate|  

## Operations
The following operations can be used with the msdyn_orderinvoicingsetupdate entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_orderinvoicingsetupdate entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_orderinvoicingsetupdate.md](./remarks/msdyn_orderinvoicingsetupdate.md)]

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