---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_rmaproduct EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: abdc1d4d-a24b-4bb5-8f7a-41ea8f0f2dff
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_rmaproduct entitytype."
---
# msdyn_rmaproduct EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_rmaproduct.md](./descriptions/msdyn_rmaproduct.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_rmaproducts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>RMA Product</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_rmaproductid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_rmaproduct entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_credittoaccount|Edm.Boolean|**Display Name**: Credit to Account<br />**Description**: Specify if credit invoice should be generated for this product when returned<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type a description of the product.<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />|
|msdyn_itemstatus|Edm.Int32|**Display Name**: Item Status<br />**Description**: Enter the current status of this product.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Pending</td></tr><tr><td>690970001</td><td>Received</td></tr><tr><td>690970002</td><td>Canceled</td></tr><tbody></table>|
|msdyn_lineorder|Edm.Int32|**Display Name**: Line Order<br />**Description**: Shows the order of this product within the RMA.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_processingaction|Edm.Int32|**Display Name**: Processing Action<br />**Description**: Shows the action to be performed by the system once the product is received (either create RTV, return to warehouse, or change asset ownership).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Create RTV</td></tr><tr><td>690970001</td><td>Return to Warehouse</td></tr><tr><td>690970002</td><td>Change Asset Ownership</td></tr><tbody></table>|
|msdyn_qtyprocessed|Edm.Double|**Display Name**: Quantity Processed<br />**Description**: Shows the quantity processed as per the processing action.<br />|
|msdyn_qtyreceived|Edm.Double|**Display Name**: Quantity Received<br />**Description**: Enter the quantity currently received.<br />|
|msdyn_quantitytoreturn|Edm.Double|**Display Name**: Quantity<br />**Description**: Enter the quantity to return.<br />|
|msdyn_rmaproductid|Edm.Guid|**Display Name**: RMA Product<br />**Description**: Shows the entity instances.<br />|
|msdyn_taxable|Edm.Boolean|**Display Name**: Taxable<br />**Description**: Specify if product is taxable<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_totalamount|Edm.Decimal|**Display Name**: Total Amount<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Shows the value of the total amount in the base currency.<br />Read-only<br />|
|msdyn_unitamount|Edm.Decimal|**Display Name**: Unit Amount<br />**Description**: Shows the unit amount to be credited to the customer<br />|
|msdyn_unitamount_base|Edm.Decimal|**Display Name**: Unit Amount (Base)<br />**Description**: Shows the value of the unit amount in the base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the RMA Product<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the RMA Product<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_changeownership_value|msdyn_changeownership<br />|Account where ownership of associated asset should be transferred to (if Product Action is Change Asset Ownership)|
|_msdyn_customerasset_value|msdyn_customerasset<br />|Asset this line item relates to|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Price List that determines the pricing for this product|
|_msdyn_product_value|msdyn_product<br />|Product to return|
|_msdyn_returntovendor_value|msdyn_returntovendor<br />|Vendor to where this product should be returned (if Product Action is RTV)|
|_msdyn_returntowarehouse_value|msdyn_returntowarehouse<br />|Warehouse to which this product should be returned to (if Product Action is Warehouse)|
|_msdyn_rma_value|msdyn_rma<br />|RMA this line item relates to|
|_msdyn_unit_value|msdyn_unit<br />|Unit for this product|
|_msdyn_woproduct_value|msdyn_woproduct<br />|Work Order Product to be returned|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_rmaproduct_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_rmaproduct_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_rmaproduct_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_rmaproduct_modifiedonbehalfby|
|msdyn_changeownership|[account EntityType](account.md)|msdyn_account_msdyn_rmaproduct_Changeownership|
|msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_rmaproduct_PriceList|
|msdyn_product|[product EntityType](product.md)|msdyn_product_msdyn_rmaproduct_Product|
|msdyn_returntovendor|[account EntityType](account.md)|msdyn_account_msdyn_rmaproduct_ReturntoVendor|
|msdyn_returntowarehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_msdyn_rmaproduct_ReturntoWarehouse|
|msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_msdyn_rma_msdyn_rmaproduct_RMA|
|msdyn_unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_rmaproduct_Unit|
|msdyn_woproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_rmaproduct|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_rmaproduct|
|owningteam|[team EntityType](team.md)|team_msdyn_rmaproduct|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_rmaproduct|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_rmaproduct|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmaproduct|  
|msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rmaproduct|  
|msdyn_rmaproduct_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_rmaproduct|  
|msdyn_rmaproduct_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_rmaproduct_adx_alertsubscription|  
|msdyn_rmaproduct_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_rmaproduct_adx_inviteredemption|  
|msdyn_rmaproduct_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_rmaproduct_adx_portalcomment|  
|msdyn_rmaproduct_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_rmaproduct|  
|msdyn_rmaproduct_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_rmaproduct_appointment|  
|msdyn_rmaproduct_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_rmaproduct|  
|msdyn_rmaproduct_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_rmaproduct|  
|msdyn_rmaproduct_connections1|[connection EntityType](connection.md)|record1id_msdyn_rmaproduct|  
|msdyn_rmaproduct_connections2|[connection EntityType](connection.md)|record2id_msdyn_rmaproduct|  
|msdyn_rmaproduct_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_rmaproduct_email|  
|msdyn_rmaproduct_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_rmaproduct_fax|  
|msdyn_rmaproduct_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_rmaproduct_letter|  
|msdyn_rmaproduct_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_rmaproduct_msdyn_approval|  
|msdyn_rmaproduct_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_rmaproduct_msdyn_bookingalert|  
|msdyn_rmaproduct_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_rmaproduct_msdyn_surveyinvite|  
|msdyn_rmaproduct_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_rmaproduct_phonecall|  
|msdyn_rmaproduct_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_rmaproduct_recurringappointmentmaster|  
|msdyn_rmaproduct_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_rmaproduct_serviceappointment|  
|msdyn_rmaproduct_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_rmaproduct_socialactivity|  
|msdyn_rmaproduct_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_rmaproduct|  
|msdyn_rmaproduct_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_rmaproduct_task|  

## Operations
The following operations can be used with the msdyn_rmaproduct entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_rmaproduct entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_rmaproduct.md](./remarks/msdyn_rmaproduct.md)]

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