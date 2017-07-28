---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_workorderproduct EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a826d265-3afa-4965-856c-2fd66abfab26
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_workorderproduct entitytype."
---
# msdyn_workorderproduct EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_workorderproduct.md](./descriptions/msdyn_workorderproduct.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_workorderproducts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Work Order Product</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_workorderproductid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_workorderproduct entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_additionalcost|Edm.Decimal|**Display Name**: Additional Cost<br />**Description**: Enter any additional costs associated with this product. The values are manually entered. Note: additional cost is not unit dependent.<br />|
|msdyn_additionalcost_base|Edm.Decimal|**Display Name**: Additional Cost (Base)<br />**Description**: Shows the value of the additional cost in the base currency.<br />Read-only<br />|
|msdyn_allocated|Edm.Boolean|**Display Name**: Allocated<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_commissioncosts|Edm.Decimal|**Display Name**: Commission Costs<br />**Description**: Enter the commission costs associated with this product. The value is manually specified and isn't automatically calculated.<br />|
|msdyn_commissioncosts_base|Edm.Decimal|**Display Name**: Commission Costs (Base)<br />**Description**: Shows the value of the commission costs in the base currency.<br />Read-only<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Enter the description of the product as presented to the customer. The value defaults to the description defined on the product.<br />|
|msdyn_discountamount|Edm.Decimal|**Display Name**: Discount Amount<br />**Description**: Specify any discount amount on this product. Note: If you enter a discount amount you cannot enter a discount %<br />|
|msdyn_discountamount_base|Edm.Decimal|**Display Name**: Discount Amount (Base)<br />**Description**: Shows the value of the discount amount in the base currency.<br />Read-only<br />|
|msdyn_discountpercent|Edm.Double|**Display Name**: Discount %<br />**Description**: Specify any discount % on this product. Note: If you enter a discount % it will overwrite the discount $<br />|
|msdyn_estimatediscountamount|Edm.Decimal|**Display Name**: Estimate Discount Amount<br />**Description**: Enter a discount amount on the subtotal amount. Note: If you enter a discount amount you cannot enter a discount %<br />|
|msdyn_estimatediscountamount_base|Edm.Decimal|**Display Name**: Estimate Discount Amount (Base)<br />**Description**: Shows the value of the estimate discount amount in the base currency.<br />Read-only<br />|
|msdyn_estimatediscountpercent|Edm.Double|**Display Name**: Estimate Discount %<br />**Description**: Enter a discount % on the subtotal amount. Note: If you enter a discount % it will overwrite the discount $<br />|
|msdyn_estimatequantity|Edm.Double|**Display Name**: Estimate Quantity<br />**Description**: Enter the estimated required quantity of this product.<br />|
|msdyn_estimatesubtotal|Edm.Decimal|**Display Name**: Estimate Subtotal<br />**Description**: Shows the total amount for this product, excluding discounts.<br />|
|msdyn_estimatesubtotal_base|Edm.Decimal|**Display Name**: Estimate Subtotal (Base)<br />**Description**: Shows the value of the estimate subtotal in the base currency.<br />Read-only<br />|
|msdyn_estimatetotalamount|Edm.Decimal|**Display Name**: Estimate Total Amount<br />**Description**: Shows the estimated total amount of this product, including discounts.<br />|
|msdyn_estimatetotalamount_base|Edm.Decimal|**Display Name**: Estimate Total Amount (Base)<br />**Description**: Shows the value of the estimate total amount in the base currency.<br />Read-only<br />|
|msdyn_estimatetotalcost|Edm.Decimal|**Display Name**: Estimate Total Cost<br />**Description**: Shows the estimated total cost of this product.<br />|
|msdyn_estimatetotalcost_base|Edm.Decimal|**Display Name**: Estimate Total Cost (Base)<br />**Description**: Shows the value of the estimate total cost in the base currency.<br />Read-only<br />|
|msdyn_estimateunitamount|Edm.Decimal|**Display Name**: Estimate Unit Amount<br />**Description**: Shows the estimated sale amount per unit.<br />|
|msdyn_estimateunitamount_base|Edm.Decimal|**Display Name**: Estimate Unit Amount (Base)<br />**Description**: Shows the value of the estimate unit amount in the base currency.<br />Read-only<br />|
|msdyn_estimateunitcost|Edm.Decimal|**Display Name**: Estimate Unit Cost<br />**Description**: Shows the estimated cost amount per unit.<br />|
|msdyn_estimateunitcost_base|Edm.Decimal|**Display Name**: Estimate Unit Cost (Base)<br />**Description**: Shows the value of the estimate unit cost in the base currency.<br />Read-only<br />|
|msdyn_internaldescription|Edm.String|**Display Name**: Internal Description<br />**Description**: Enter any internal notes you want to track on this product.<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_lineorder|Edm.Int32|**Display Name**: Line Order<br />|
|msdyn_linestatus|Edm.Int32|**Display Name**: Line Status<br />**Description**: Enter the current status of the line, estimate or used.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Estimated</td></tr><tr><td>690970001</td><td>Used</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_qtytobill|Edm.Double|**Display Name**: Quantity To Bill<br />**Description**: Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."<br />|
|msdyn_quantity|Edm.Double|**Display Name**: Quantity<br />**Description**: Shows the actual quantity of the product.<br />|
|msdyn_subtotal|Edm.Decimal|**Display Name**: Subtotal<br />**Description**: Enter the total amount excluding discounts.<br />|
|msdyn_subtotal_base|Edm.Decimal|**Display Name**: Subtotal (Base)<br />**Description**: Shows the value of the subtotal in the base currency.<br />Read-only<br />|
|msdyn_taxable|Edm.Boolean|**Display Name**: Taxable<br />**Description**: Specify if product is taxable. If you do not wish to charge tax set this field to No.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Enter the total amount charged to the customer.<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Shows the value of the total amount in the base currency.<br />Read-only<br />|
|msdyn_totalcost|Edm.Decimal|**Display Name**: Total Cost<br />**Description**: Shows the total cost of this product. This is calculated by (Unit Cost * Units) + Additional Cost + Commission Costs.<br />|
|msdyn_totalcost_base|Edm.Decimal|**Display Name**: Total Cost (Base)<br />**Description**: Shows the value of the total cost in the base currency.<br />Read-only<br />|
|msdyn_unitamount|Edm.Decimal|**Display Name**: Unit Amount<br />**Description**: Enter the amount you want to charge the customer per unit. By default, this is calculated based on the selected price list. The amount can be changed.<br />|
|msdyn_unitamount_base|Edm.Decimal|**Display Name**: Unit Amount (Base)<br />**Description**: Shows the value of the unit amount in the base currency.<br />Read-only<br />|
|msdyn_unitcost|Edm.Decimal|**Display Name**: Unit Cost<br />**Description**: Shows the actual cost per unit.<br />|
|msdyn_unitcost_base|Edm.Decimal|**Display Name**: Unit Cost (Base)<br />**Description**: Shows the value of the unit cost in the base currency.<br />Read-only<br />|
|msdyn_workorderproductid|Edm.Guid|**Display Name**: Work Order Product<br />**Description**: Shows the entity instances.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Work Order Product<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Work Order Product<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_agreementbookingproduct_value|msdyn_agreementbookingproduct<br />|Agreement Booking Product linked to this Work Order Product|
|_msdyn_booking_value|msdyn_booking<br />|The booking where this product was added|
|_msdyn_customerasset_value|msdyn_customerasset<br />|Unique identifier for Customer Asset associated with Work Order Product.|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Price List that determines the pricing for this product|
|_msdyn_product_value|msdyn_product<br />|Product to use|
|_msdyn_purchaseorderreceiptproduct_value|msdyn_purchaseorderreceiptproduct<br />|Purchase Order Receipt Product linked to this Work Order Product|
|_msdyn_unit_value|msdyn_unit<br />|The unit that determines the pricing and final quantity for this product|
|_msdyn_warehouse_value|msdyn_warehouse<br />|Warehouse this product is being retrieved from|
|_msdyn_workorder_value|msdyn_workorder<br />|Unique identifier for Work Order associated with Work Order Product.|
|_msdyn_workorderincident_value|msdyn_workorderincident<br />|The Incident related to this product|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorderproduct_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorderproduct_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorderproduct_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorderproduct_modifiedonbehalfby|
|msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct|
|msdyn_booking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking|
|msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_workorderproduct_PriceList|
|msdyn_product|[product EntityType](product.md)|msdyn_product_msdyn_workorderproduct_Product|
|msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct|
|msdyn_unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_workorderproduct_Unit|
|msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse|
|msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder|
|msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_workorderproduct|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_workorderproduct|
|owningteam|[team EntityType](team.md)|team_msdyn_workorderproduct|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_workorderproduct|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_workorderproduct|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_workorderproduct_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|msdyn_workorderproductid|  
|msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_workorderproduct|  
|msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_workorderproduct|  
|msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_woproduct|  
|msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_workorderproduct|  
|msdyn_workorderproduct_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_workorderproduct|  
|msdyn_workorderproduct_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_workorderproduct_adx_alertsubscription|  
|msdyn_workorderproduct_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_workorderproduct_adx_inviteredemption|  
|msdyn_workorderproduct_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_workorderproduct_adx_portalcomment|  
|msdyn_workorderproduct_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_workorderproduct|  
|msdyn_workorderproduct_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_workorderproduct_appointment|  
|msdyn_workorderproduct_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_workorderproduct|  
|msdyn_workorderproduct_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_workorderproduct|  
|msdyn_workorderproduct_connections1|[connection EntityType](connection.md)|record1id_msdyn_workorderproduct|  
|msdyn_workorderproduct_connections2|[connection EntityType](connection.md)|record2id_msdyn_workorderproduct|  
|msdyn_workorderproduct_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_workorderproduct_email|  
|msdyn_workorderproduct_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_workorderproduct_fax|  
|msdyn_workorderproduct_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_workorderproduct_letter|  
|msdyn_workorderproduct_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_workorderproduct_msdyn_approval|  
|msdyn_workorderproduct_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_workorderproduct_msdyn_bookingalert|  
|msdyn_workorderproduct_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_workorderproduct_msdyn_surveyinvite|  
|msdyn_workorderproduct_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_workorderproduct_phonecall|  
|msdyn_workorderproduct_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_workorderproduct_recurringappointmentmaster|  
|msdyn_workorderproduct_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_workorderproduct_serviceappointment|  
|msdyn_workorderproduct_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_workorderproduct|  
|msdyn_workorderproduct_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_workorderproduct_socialactivity|  
|msdyn_workorderproduct_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_workorderproduct|  
|msdyn_workorderproduct_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_workorderproduct_task|  

## Operations
The following operations can be used with the msdyn_workorderproduct entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_workorderproduct entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_workorderproduct.md](./remarks/msdyn_workorderproduct.md)]

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