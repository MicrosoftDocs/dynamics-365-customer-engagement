---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_inventoryjournal EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 36d88867-4d5d-4302-b67e-1efa130c5ce7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_inventoryjournal entitytype."
---
# msdyn_inventoryjournal EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_inventoryjournal.md](./descriptions/msdyn_inventoryjournal.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_inventoryjournals </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Inventory Journal</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_inventoryjournalid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_inventoryjournal entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_inventoryjournalid|Edm.Guid|**Display Name**: Inventory Journal<br />**Description**: Shows the entity instances.<br />|
|msdyn_journaltype|Edm.Int32|**Display Name**: Journal Type<br />**Description**: Shows the transaction type of this journal.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>On Hand</td></tr><tr><td>690970001</td><td>On Order</td></tr><tr><td>690970002</td><td>Allocated</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_quantity|Edm.Double|**Display Name**: Quantity<br />**Description**: Enter the quantity affected. A positive quantity indicates the receipt of this product into the specified warehouse, whereas a negative indicates a withdrawal.<br />|
|msdyn_reversal|Edm.Boolean|**Display Name**: Reversal<br />**Description**: Indicates if this Journal reverses a previous journal record<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_transactiontype|Edm.Int32|**Display Name**: Transaction Type<br />**Description**: Shows the transaction type of this journal.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Purchase Order Product</td></tr><tr><td>690970001</td><td>Purchase Order Receipt</td></tr><tr><td>690970002</td><td>WO Product</td></tr><tr><td>690970003</td><td>Inventory Adjustment</td></tr><tr><td>690970004</td><td>Inventory Transfer</td></tr><tr><td>690970005</td><td>RMA Product</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Inventory Journal<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Inventory Journal<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_allocatedtoworkorder_value|msdyn_allocatedtoworkorder<br />|Work Order this product is allocated to|
|_msdyn_inventoryadjustmentproduct_value|msdyn_inventoryadjustmentproduct<br />|The Inventory Adjustment Product record related to this journal|
|_msdyn_originatingjournal_value|msdyn_originatingjournal_msdyn_inventoryjournal<br />|Indicates the Journal reversed by this journal record|
|_msdyn_product_value|msdyn_product<br />|Product this journal relates to|
|_msdyn_purchaseorderproduct_value|msdyn_purchaseorderproduct<br />|The Purchase Order Product record related to this journal|
|_msdyn_purchaseorderreceiptproduct_value|msdyn_purchaseorderreceiptproduct<br />|Unique identifier for Purchase Order Receipt Product associated with Inventory Journal.|
|_msdyn_rmareceiptproduct_value|msdyn_rmareceiptproduct<br />|The RMA Receipt Product record related to this journal|
|_msdyn_unit_value|msdyn_unit<br />|Unit of product used|
|_msdyn_warehouse_value|msdyn_warehouse<br />|Warehouse affected by this transaction|
|_msdyn_workorderproduct_value|msdyn_workorderproduct<br />|The Work Order Product record related to this journal|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_inventoryjournal_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_inventoryjournal_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_inventoryjournal_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_inventoryjournal_modifiedonbehalfby|
|msdyn_allocatedtoworkorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder|
|msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_msdyn_inventoryadjustmentproduct_msdyn_inventoryjournal_InventoryAdjstProduct|
|msdyn_originatingjournal_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal|
|msdyn_product|[product EntityType](product.md)|msdyn_product_msdyn_inventoryjournal_Product|
|msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_msdyn_purchaseorderproduct_msdyn_inventoryjournal_POProduct|
|msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_msdyn_purchaseorderreceiptproduct_msdyn_inventoryjournal_PurchaseOrderReceiptProduct|
|msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct|
|msdyn_unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_inventoryjournal_Unit|
|msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_msdyn_inventoryjournal_Warehouse|
|msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_inventoryjournal|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_inventoryjournal|
|owningteam|[team EntityType](team.md)|team_msdyn_inventoryjournal|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_inventoryjournal|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_inventoryjournal_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_inventoryjournal_adx_alertsubscription|  
|msdyn_inventoryjournal_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_inventoryjournal_adx_inviteredemption|  
|msdyn_inventoryjournal_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_inventoryjournal_adx_portalcomment|  
|msdyn_inventoryjournal_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_inventoryjournal_appointment|  
|msdyn_inventoryjournal_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_connections1|[connection EntityType](connection.md)|record1id_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_connections2|[connection EntityType](connection.md)|record2id_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_inventoryjournal_email|  
|msdyn_inventoryjournal_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_inventoryjournal_fax|  
|msdyn_inventoryjournal_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_inventoryjournal_letter|  
|msdyn_inventoryjournal_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_inventoryjournal_msdyn_approval|  
|msdyn_inventoryjournal_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_inventoryjournal_msdyn_bookingalert|  
|msdyn_inventoryjournal_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_inventoryjournal_msdyn_surveyinvite|  
|msdyn_inventoryjournal_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_inventoryjournal_phonecall|  
|msdyn_inventoryjournal_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_inventoryjournal_recurringappointmentmaster|  
|msdyn_inventoryjournal_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_inventoryjournal_serviceappointment|  
|msdyn_inventoryjournal_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_inventoryjournal_socialactivity|  
|msdyn_inventoryjournal_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_inventoryjournal|  
|msdyn_inventoryjournal_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_inventoryjournal_task|  
|msdyn_msdyn_inventoryjournal_msdyn_inventoryjournal_OriginatingJournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_originatingjournal_msdyn_inventoryjournal|  

## Operations
The following operations can be used with the msdyn_inventoryjournal entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_inventoryjournal entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_inventoryjournal.md](./remarks/msdyn_inventoryjournal.md)]

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