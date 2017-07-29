---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_customerasset EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cadc4ce4-7955-4731-8d00-ec77de19d5e1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_customerasset entitytype."
---
# msdyn_customerasset EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_customerasset.md](./descriptions/msdyn_customerasset.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_customerassets </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Customer Asset</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_customerassetid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_customerasset entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_customerassetid|Edm.Guid|**Display Name**: Customer Asset<br />**Description**: Shows the entity instances.<br />|
|msdyn_deviceid|Edm.String|**Display Name**: Device ID<br />**Description**: Device ID used to register with IoT hub. This will not be used if there are two or more connected devices for this asset.<br />|
|msdyn_lastcommandsenttime|Edm.DateTimeOffset|**Display Name**: Last Command Sent Time<br />**Description**: The timestamp of the last command sent for any of the connected devices for this asset.<br />|
|msdyn_latitude|Edm.Double|**Display Name**: Latitude<br />|
|msdyn_longitude|Edm.Double|**Display Name**: Longitude<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_registrationstatus|Edm.Int32|**Display Name**: Registration Status<br />**Description**: A status field that denotes whether all the devices connected to this asset are registered with the IoT hub.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Unknown</td></tr><tr><td>192350001</td><td>Unregistered</td></tr><tr><td>192350002</td><td>In Progress</td></tr><tr><td>192350003</td><td>Registered</td></tr><tr><td>192350004</td><td>Error</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Customer Asset<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Customer Asset<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_account_value|msdyn_account<br />|Parent Customer of this Asset|
|_msdyn_lastcommandsent_value|msdyn_LastCommandSent<br />|The last command sent to any of the connected devices for this asset.|
|_msdyn_masterasset_value|msdyn_masterasset_msdyn_customerasset<br />|Top level Asset, (if this asset is a sub asset)|
|_msdyn_parentasset_value|msdyn_parentasset_msdyn_customerasset<br />|Parent Asset|
|_msdyn_product_value|msdyn_product<br />|Reference to Product associated with this Asset|
|_msdyn_workorderproduct_value|msdyn_workorderproduct<br />|Indicates a link to the Work Order Product from where this Asset was auto created by the system.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_customerasset_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_customerasset_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_customerasset_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_customerasset_modifiedonbehalfby|
|msdyn_account|[account EntityType](account.md)|msdyn_account_msdyn_customerasset_Account|
|msdyn_LastCommandSent|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent|
|msdyn_masterasset_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset|
|msdyn_parentasset_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset|
|msdyn_product|[product EntityType](product.md)|msdyn_product_msdyn_customerasset_Product|
|msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_customerasset|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_customerasset|
|owningteam|[team EntityType](team.md)|team_msdyn_customerasset|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_customerasset|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_customerasset_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_customerasset|  
|msdyn_customerasset_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_customerasset_adx_alertsubscription|  
|msdyn_customerasset_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_customerasset_adx_inviteredemption|  
|msdyn_customerasset_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_customerasset_adx_portalcomment|  
|msdyn_customerasset_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_customerasset|  
|msdyn_customerasset_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_customerasset_appointment|  
|msdyn_customerasset_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_customerasset|  
|msdyn_customerasset_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_customerasset|  
|msdyn_customerasset_connections1|[connection EntityType](connection.md)|record1id_msdyn_customerasset|  
|msdyn_customerasset_connections2|[connection EntityType](connection.md)|record2id_msdyn_customerasset|  
|msdyn_customerasset_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_customerasset|  
|msdyn_customerasset_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_customerasset|  
|msdyn_customerasset_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_customerasset_email|  
|msdyn_customerasset_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_customerasset_fax|  
|msdyn_customerasset_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_customerasset_letter|  
|msdyn_customerasset_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_customerasset_msdyn_approval|  
|msdyn_customerasset_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_customerasset_msdyn_bookingalert|  
|msdyn_customerasset_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_customerasset_msdyn_surveyinvite|  
|msdyn_customerasset_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_customerasset_phonecall|  
|msdyn_customerasset_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_customerasset_recurringappointmentmaster|  
|msdyn_customerasset_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_customerasset_serviceappointment|  
|msdyn_customerasset_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_customerasset_socialactivity|  
|msdyn_customerasset_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_customerasset|  
|msdyn_customerasset_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_customerasset_task|  
|msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_masterasset_msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_parentasset_msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_CustomerAsset|  
|msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_CustomerAsset|  
|msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_customerasset|  
|msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_customerasset|  

## Operations
The following operations can be used with the msdyn_customerasset entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_customerasset entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Connected Field Service for Microsoft Dynamics 365 Solution](../solutions/connectedfieldservice.md)|[!INCLUDE[../solutions/descriptions/connectedfieldservice.md](../solutions/descriptions/connectedfieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_customerasset.md](./remarks/msdyn_customerasset.md)]

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