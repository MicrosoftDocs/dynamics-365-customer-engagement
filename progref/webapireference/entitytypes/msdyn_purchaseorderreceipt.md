---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_purchaseorderreceipt EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0e4e9d51-a24a-47fa-b560-460e808ded39
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_purchaseorderreceipt entitytype."
---
# msdyn_purchaseorderreceipt EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_purchaseorderreceipt.md](./descriptions/msdyn_purchaseorderreceipt.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_purchaseorderreceipts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Purchase Order Receipt</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_purchaseorderreceiptid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_purchaseorderreceipt entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_datereceived|Edm.DateTimeOffset|**Display Name**: Date Received<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_note|Edm.String|**Display Name**: Note<br />|
|msdyn_purchaseorderreceiptid|Edm.Guid|**Display Name**: Purchase Order Receipt<br />**Description**: Shows the entity instances.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the ID of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Purchase Order Receipt<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Purchase Order Receipt<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.<br />|
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
|_msdyn_purchaseorder_value|msdyn_purchaseorder<br />|Unique identifier for Purchase Order associated with Purchase Order Receipt.|
|_msdyn_receivedby_value|msdyn_receivedby<br />|Unique identifier for User associated with Purchase Order Receipt.|
|_msdyn_shipvia_value|msdyn_shipvia<br />|Unique identifier for Ship Via associated with Purchase Order Receipt.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the ID of the stage where the entity is located.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_purchaseorderreceipt_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_purchaseorderreceipt_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_purchaseorderreceipt_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_purchaseorderreceipt_modifiedonbehalfby|
|msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_msdyn_purchaseorder_msdyn_purchaseorderreceipt_PurchaseOrder|
|msdyn_receivedby|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_purchaseorderreceipt_ReceivedBy|
|msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_msdyn_shipvia_msdyn_purchaseorderreceipt_ShipVia|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_purchaseorderreceipt|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_purchaseorderreceipt|
|owningteam|[team EntityType](team.md)|team_msdyn_purchaseorderreceipt|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_purchaseorderreceipt|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_purchaseorderreceipt|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_purchaseorderreceipt_msdyn_purchaseorderreceiptproduct_PurchaseOrderReceipt|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_purchaseorderreceipt_adx_alertsubscription|  
|msdyn_purchaseorderreceipt_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_purchaseorderreceipt_adx_inviteredemption|  
|msdyn_purchaseorderreceipt_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_purchaseorderreceipt_adx_portalcomment|  
|msdyn_purchaseorderreceipt_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_purchaseorderreceipt_appointment|  
|msdyn_purchaseorderreceipt_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_connections1|[connection EntityType](connection.md)|record1id_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_connections2|[connection EntityType](connection.md)|record2id_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_purchaseorderreceipt_email|  
|msdyn_purchaseorderreceipt_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_purchaseorderreceipt_fax|  
|msdyn_purchaseorderreceipt_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_purchaseorderreceipt_letter|  
|msdyn_purchaseorderreceipt_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_purchaseorderreceipt_msdyn_approval|  
|msdyn_purchaseorderreceipt_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_purchaseorderreceipt_msdyn_bookingalert|  
|msdyn_purchaseorderreceipt_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_purchaseorderreceipt_msdyn_surveyinvite|  
|msdyn_purchaseorderreceipt_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_purchaseorderreceipt_phonecall|  
|msdyn_purchaseorderreceipt_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_purchaseorderreceipt_recurringappointmentmaster|  
|msdyn_purchaseorderreceipt_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_purchaseorderreceipt_serviceappointment|  
|msdyn_purchaseorderreceipt_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_purchaseorderreceipt_socialactivity|  
|msdyn_purchaseorderreceipt_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_purchaseorderreceipt|  
|msdyn_purchaseorderreceipt_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_purchaseorderreceipt_task|  

## Operations
The following operations can be used with the msdyn_purchaseorderreceipt entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_purchaseorderreceipt entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_purchaseorderreceipt.md](./remarks/msdyn_purchaseorderreceipt.md)]

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