---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_rtv EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2aa309bc-5eac-485b-be02-4fe334858851
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_rtv entitytype."
---
# msdyn_rtv EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_rtv.md](./descriptions/msdyn_rtv.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_rtvs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>RTV</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_rtvid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_rtv entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_address1|Edm.String|**Display Name**: Address 1<br />|
|msdyn_address2|Edm.String|**Display Name**: Address 2<br />|
|msdyn_address3|Edm.String|**Display Name**: Address 3<br />|
|msdyn_city|Edm.String|**Display Name**: City<br />|
|msdyn_country|Edm.String|**Display Name**: Country/Region<br />|
|msdyn_latitude|Edm.Double|**Display Name**: Latitude<br />|
|msdyn_longitude|Edm.Double|**Display Name**: Longitude<br />|
|msdyn_name|Edm.String|**Display Name**: RTV Number<br />**Description**: Shows the unique number for identifying this RTV record.<br />|
|msdyn_postalcode|Edm.String|**Display Name**: Postal Code<br />|
|msdyn_referenceno|Edm.String|**Display Name**: Reference No<br />|
|msdyn_requestdate|Edm.DateTimeOffset|**Display Name**: Request Date<br />**Description**: Enter the date when return was requested.<br />|
|msdyn_returndate|Edm.DateTimeOffset|**Display Name**: Return Date<br />**Description**: Enter the date items were returned to vendor.<br />|
|msdyn_rtvid|Edm.Guid|**Display Name**: RTV<br />**Description**: Shows the entity instances.<br />|
|msdyn_stateorprovince|Edm.String|**Display Name**: State Or Province<br />|
|msdyn_systemstatus|Edm.Int32|**Display Name**: System Status<br />**Description**: Enter the current status of the RTV.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Draft</td></tr><tr><td>690970001</td><td>Approved</td></tr><tr><td>690970002</td><td>Shipped</td></tr><tr><td>690970003</td><td>Received</td></tr><tr><td>690970004</td><td>Canceled</td></tr><tbody></table>|
|msdyn_totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Shows the total Amount to be credited on this RTV.<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Shows the value of the total amount in the base currency.<br />Read-only<br />|
|msdyn_vendorrma|Edm.String|**Display Name**: Vendor RMA<br />**Description**: RMA from Vendor<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the RTV<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the RTV<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_approveddeclinedby_value|msdyn_approveddeclinedby<br />|The user who approved or rejected this return|
|_msdyn_booking_value|msdyn_booking<br />|Unique identifier for Resource Booking associated with RTV.|
|_msdyn_originalpurchaseorder_value|msdyn_originalpurchaseorder<br />|Purchase Order from where items are originating|
|_msdyn_originatingrma_value|msdyn_originatingrma<br />|Originating RMA if items were returned from customer|
|_msdyn_returnedby_value|msdyn_returnedby<br />|User processing this return|
|_msdyn_shipvia_value|msdyn_shipvia<br />|Method of Shipment to Vendor|
|_msdyn_substatus_value|msdyn_substatus<br />|RTV Sub-Status|
|_msdyn_taxcode_value|msdyn_taxcode<br />|Tax code vendor charges you|
|_msdyn_vendor_value|msdyn_vendor<br />|Vendor where items will be returned|
|_msdyn_vendorcontact_value|msdyn_vendorcontact<br />|Contact person at Vendor|
|_msdyn_workorder_value|msdyn_workorder<br />|Unique identifier for Work Order associated with RTV.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_rtv_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_rtv_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_rtv_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_rtv_modifiedonbehalfby|
|msdyn_approveddeclinedby|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_rtv_ApprovedDeclinedBy|
|msdyn_booking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_bookableresourcebooking_msdyn_rtv_Booking|
|msdyn_originalpurchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_msdyn_purchaseorder_msdyn_rtv_OriginalPO|
|msdyn_originatingrma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_msdyn_rma_msdyn_rtv_OriginatingRMA|
|msdyn_returnedby|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_rtv_ReturnedBy|
|msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_msdyn_shipvia_msdyn_rtv_ShipVia|
|msdyn_substatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus|
|msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_msdyn_taxcode_msdyn_rtv_TaxCode|
|msdyn_vendor|[account EntityType](account.md)|msdyn_account_msdyn_rtv_Vendor|
|msdyn_vendorcontact|[contact EntityType](contact.md)|msdyn_contact_msdyn_rtv_VendorContact|
|msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_rtv_WorkOrder|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_rtv|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_rtv|
|owningteam|[team EntityType](team.md)|team_msdyn_rtv|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_rtv|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_rtv|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rtv|  
|msdyn_msdyn_rtv_msdyn_rtvproduct_RTV|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtv|  
|msdyn_rtv_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_rtv|  
|msdyn_rtv_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_rtv_adx_alertsubscription|  
|msdyn_rtv_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_rtv_adx_inviteredemption|  
|msdyn_rtv_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_rtv_adx_portalcomment|  
|msdyn_rtv_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_rtv|  
|msdyn_rtv_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_rtv_appointment|  
|msdyn_rtv_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_rtv|  
|msdyn_rtv_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_rtv|  
|msdyn_rtv_connections1|[connection EntityType](connection.md)|record1id_msdyn_rtv|  
|msdyn_rtv_connections2|[connection EntityType](connection.md)|record2id_msdyn_rtv|  
|msdyn_rtv_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_rtv|  
|msdyn_rtv_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_rtv|  
|msdyn_rtv_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_rtv_email|  
|msdyn_rtv_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_rtv_fax|  
|msdyn_rtv_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_rtv_letter|  
|msdyn_rtv_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_rtv_msdyn_approval|  
|msdyn_rtv_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_rtv_msdyn_bookingalert|  
|msdyn_rtv_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_rtv_msdyn_surveyinvite|  
|msdyn_rtv_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_rtv_phonecall|  
|msdyn_rtv_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_rtv_recurringappointmentmaster|  
|msdyn_rtv_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_rtv_serviceappointment|  
|msdyn_rtv_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_rtv|  
|msdyn_rtv_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_rtv_socialactivity|  
|msdyn_rtv_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_rtv|  
|msdyn_rtv_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_rtv_task|  

## Operations
The following operations can be used with the msdyn_rtv entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_rtv entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_rtv.md](./remarks/msdyn_rtv.md)]

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