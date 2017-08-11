---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_productinventory EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f46556f1-31db-4aef-825e-fb6fe00a9d6a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_productinventory entitytype."
---
# msdyn_productinventory EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_productinventory.md](./descriptions/msdyn_productinventory.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_productinventories </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Product Inventory</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_productinventoryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_productinventory entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_bin|Edm.String|**Display Name**: Bin<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_productinventoryid|Edm.Guid|**Display Name**: Product Inventory<br />**Description**: Shows the entity instances.<br />|
|msdyn_qtyallocated|Edm.Double|**Display Name**: Quantity Allocated<br />|
|msdyn_qtyavailable|Edm.Double|**Display Name**: Quantity Available<br />|
|msdyn_qtyonhand|Edm.Double|**Display Name**: Quantity On Hand<br />|
|msdyn_qtyonorder|Edm.Double|**Display Name**: Quantity On Order<br />|
|msdyn_reorderpoint|Edm.Double|**Display Name**: Reorder Point<br />|
|msdyn_row|Edm.String|**Display Name**: Row<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Product Inventory<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Product Inventory<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_product_value|msdyn_product<br />|Unique identifier for Product/Service associated with Product Inventory.|
|_msdyn_unit_value|msdyn_unit<br />|Unique identifier for Unit associated with Product Inventory.|
|_msdyn_warehouse_value|msdyn_warehouse<br />|Unique identifier for Warehouse associated with Product Inventory.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_productinventory_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_productinventory_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_productinventory_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_productinventory_modifiedonbehalfby|
|msdyn_product|[product EntityType](product.md)|msdyn_product_msdyn_productinventory_Product|
|msdyn_unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_productinventory_Unit|
|msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_productinventory|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_productinventory_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_productinventory|  
|msdyn_productinventory_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_productinventory_adx_alertsubscription|  
|msdyn_productinventory_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_productinventory_adx_inviteredemption|  
|msdyn_productinventory_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_productinventory_adx_portalcomment|  
|msdyn_productinventory_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_productinventory|  
|msdyn_productinventory_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_productinventory_appointment|  
|msdyn_productinventory_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_productinventory|  
|msdyn_productinventory_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_productinventory|  
|msdyn_productinventory_connections1|[connection EntityType](connection.md)|record1id_msdyn_productinventory|  
|msdyn_productinventory_connections2|[connection EntityType](connection.md)|record2id_msdyn_productinventory|  
|msdyn_productinventory_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_productinventory|  
|msdyn_productinventory_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_productinventory|  
|msdyn_productinventory_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_productinventory_email|  
|msdyn_productinventory_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_productinventory_fax|  
|msdyn_productinventory_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_productinventory_letter|  
|msdyn_productinventory_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_productinventory_msdyn_approval|  
|msdyn_productinventory_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_productinventory_msdyn_bookingalert|  
|msdyn_productinventory_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_productinventory_msdyn_surveyinvite|  
|msdyn_productinventory_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_productinventory_phonecall|  
|msdyn_productinventory_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_productinventory_recurringappointmentmaster|  
|msdyn_productinventory_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_productinventory_serviceappointment|  
|msdyn_productinventory_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_productinventory_socialactivity|  
|msdyn_productinventory_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_productinventory|  
|msdyn_productinventory_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_productinventory_task|  

## Operations
The following operations can be used with the msdyn_productinventory entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_productinventory entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_productinventory.md](./remarks/msdyn_productinventory.md)]

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