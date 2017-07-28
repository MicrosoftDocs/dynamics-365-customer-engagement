---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_incidenttypeproduct EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d49006e1-59f2-4733-9ba7-d5d233574346
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_incidenttypeproduct entitytype."
---
# msdyn_incidenttypeproduct EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_incidenttypeproduct.md](./descriptions/msdyn_incidenttypeproduct.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_incidenttypeproducts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Incident Type Product</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_incidenttypeproductid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_incidenttypeproduct entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Enter the description of the product as presented to the customer. The value defaults to the description defined on the product.<br />|
|msdyn_incidenttypeproductid|Edm.Guid|**Display Name**: Incident Type Product<br />**Description**: Shows the entity instances.<br />|
|msdyn_internaldescription|Edm.String|**Display Name**: Internal Description<br />**Description**: Enter any internal notes you want to track on this product.<br />|
|msdyn_lineorder|Edm.Int32|**Display Name**: Line Order<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_quantity|Edm.Double|**Display Name**: Quantity<br />**Description**: Shows the actual quantity of the product.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Incident Type Product<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Incident Type Product<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_incidenttype_value|msdyn_incidenttype<br />|The Incident related to this product|
|_msdyn_product_value|msdyn_product<br />|Unique identifier for Product/Service associated with Incident Type Product.|
|_msdyn_unit_value|msdyn_unit<br />|The unit that determines the pricing and final quantity for this product|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_incidenttypeproduct_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_incidenttypeproduct_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_incidenttypeproduct_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_incidenttypeproduct_modifiedonbehalfby|
|msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType|
|msdyn_product|[product EntityType](product.md)|msdyn_product_msdyn_incidenttypeproduct_Product|
|msdyn_unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_incidenttypeproduct_Unit|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_incidenttypeproduct|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_incidenttypeproduct|
|owningteam|[team EntityType](team.md)|team_msdyn_incidenttypeproduct|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_incidenttypeproduct|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_incidenttypeproduct_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_incidenttypeproduct_adx_alertsubscription|  
|msdyn_incidenttypeproduct_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_incidenttypeproduct_adx_inviteredemption|  
|msdyn_incidenttypeproduct_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_incidenttypeproduct_adx_portalcomment|  
|msdyn_incidenttypeproduct_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_incidenttypeproduct_appointment|  
|msdyn_incidenttypeproduct_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_connections1|[connection EntityType](connection.md)|record1id_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_connections2|[connection EntityType](connection.md)|record2id_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_incidenttypeproduct_email|  
|msdyn_incidenttypeproduct_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_incidenttypeproduct_fax|  
|msdyn_incidenttypeproduct_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_incidenttypeproduct_letter|  
|msdyn_incidenttypeproduct_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_incidenttypeproduct_msdyn_approval|  
|msdyn_incidenttypeproduct_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_incidenttypeproduct_msdyn_bookingalert|  
|msdyn_incidenttypeproduct_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_incidenttypeproduct_msdyn_surveyinvite|  
|msdyn_incidenttypeproduct_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_incidenttypeproduct_phonecall|  
|msdyn_incidenttypeproduct_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_incidenttypeproduct_recurringappointmentmaster|  
|msdyn_incidenttypeproduct_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_incidenttypeproduct_serviceappointment|  
|msdyn_incidenttypeproduct_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_incidenttypeproduct_socialactivity|  
|msdyn_incidenttypeproduct_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_incidenttypeproduct|  
|msdyn_incidenttypeproduct_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_incidenttypeproduct_task|  

## Operations
The following operations can be used with the msdyn_incidenttypeproduct entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_incidenttypeproduct entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_incidenttypeproduct.md](./remarks/msdyn_incidenttypeproduct.md)]

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