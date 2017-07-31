---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_rtvproduct EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 94e40361-4d24-4a82-9fe6-346846f9819b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_rtvproduct entitytype."
---
# msdyn_rtvproduct EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_rtvproduct.md](./descriptions/msdyn_rtvproduct.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_rtvproducts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>RTV Product</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_rtvproductid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_rtvproduct entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type a description of the product.<br />|
|msdyn_lineorder|Edm.Int32|**Display Name**: Line Order<br />**Description**: Shows the order of this product within the RTV.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_quantity|Edm.Double|**Display Name**: Quantity<br />**Description**: Enter the quantity returned.<br />|
|msdyn_rtvproductid|Edm.Guid|**Display Name**: RTV Product<br />**Description**: Shows the entity instances.<br />|
|msdyn_totalcreditamount|Edm.Decimal|**Display Name**: Total Credit Amount<br />**Description**: Shows the total Amount to be credited on this item.<br />|
|msdyn_totalcreditamount_base|Edm.Decimal|**Display Name**: Total Credit Amount (Base)<br />**Description**: Shows the value of the total credit amount in the base currency.<br />Read-only<br />|
|msdyn_unitcreditamount|Edm.Decimal|**Display Name**: Unit Credit Amount<br />**Description**: Enter the unit amount to be credited.<br />|
|msdyn_unitcreditamount_base|Edm.Decimal|**Display Name**: Unit Credit Amount (Base)<br />**Description**: Shows the value of the unit credit amount in the base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the RTV Product<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the RTV Product<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_product_value|msdyn_product<br />|Product to return|
|_msdyn_rma_value|msdyn_rma<br />|Originating RMA if item was returned from customer|
|_msdyn_rmaproduct_value|msdyn_rmaproduct<br />|Originating RMA Product if item was returned from customer|
|_msdyn_rtv_value|msdyn_rtv<br />|RTV this line item relates to|
|_msdyn_unit_value|msdyn_unit<br />|Unit for this product|
|_msdyn_warehouse_value|msdyn_warehouse<br />|Warehouse from where this product is returned|
|_msdyn_workorder_value|msdyn_workorder<br />|Originating Work Order if item was returned from customer|
|_msdyn_workorderproduct_value|msdyn_workorderproduct<br />|Originating Work Order Product if item was returned from customer|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_rtvproduct_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_rtvproduct_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_rtvproduct_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_rtvproduct_modifiedonbehalfby|
|msdyn_product|[product EntityType](product.md)|msdyn_product_msdyn_rtvproduct_Product|
|msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_msdyn_rma_msdyn_rtvproduct_RMA|
|msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_msdyn_rmaproduct_msdyn_rtvproduct_RMAProduct|
|msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_msdyn_rtv_msdyn_rtvproduct_RTV|
|msdyn_unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_rtvproduct_Unit|
|msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_msdyn_rtvproduct_Warehouse|
|msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder|
|msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_rtvproduct|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_rtvproduct|
|owningteam|[team EntityType](team.md)|team_msdyn_rtvproduct|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_rtvproduct|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_rtvproduct|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rtvproduct|  
|msdyn_rtvproduct_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_rtvproduct|  
|msdyn_rtvproduct_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_rtvproduct_adx_alertsubscription|  
|msdyn_rtvproduct_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_rtvproduct_adx_inviteredemption|  
|msdyn_rtvproduct_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_rtvproduct_adx_portalcomment|  
|msdyn_rtvproduct_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_rtvproduct|  
|msdyn_rtvproduct_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_rtvproduct_appointment|  
|msdyn_rtvproduct_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_rtvproduct|  
|msdyn_rtvproduct_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_rtvproduct|  
|msdyn_rtvproduct_connections1|[connection EntityType](connection.md)|record1id_msdyn_rtvproduct|  
|msdyn_rtvproduct_connections2|[connection EntityType](connection.md)|record2id_msdyn_rtvproduct|  
|msdyn_rtvproduct_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_rtvproduct|  
|msdyn_rtvproduct_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_rtvproduct|  
|msdyn_rtvproduct_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_rtvproduct_email|  
|msdyn_rtvproduct_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_rtvproduct_fax|  
|msdyn_rtvproduct_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_rtvproduct_letter|  
|msdyn_rtvproduct_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_rtvproduct_msdyn_approval|  
|msdyn_rtvproduct_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_rtvproduct_msdyn_bookingalert|  
|msdyn_rtvproduct_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_rtvproduct_msdyn_surveyinvite|  
|msdyn_rtvproduct_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_rtvproduct_phonecall|  
|msdyn_rtvproduct_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_rtvproduct_recurringappointmentmaster|  
|msdyn_rtvproduct_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_rtvproduct_serviceappointment|  
|msdyn_rtvproduct_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_rtvproduct_socialactivity|  
|msdyn_rtvproduct_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_rtvproduct|  
|msdyn_rtvproduct_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_rtvproduct_task|  

## Operations
The following operations can be used with the msdyn_rtvproduct entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_rtvproduct entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_rtvproduct.md](./remarks/msdyn_rtvproduct.md)]

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