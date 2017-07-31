---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_agreement EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ea5bd4c2-03ed-4bf7-9459-8c545fe5af2d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_agreement entitytype."
---
# msdyn_agreement EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_agreement.md](./descriptions/msdyn_agreement.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_agreements </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Agreement</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_agreementid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_agreement entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_agreementdetails|Edm.String|**Display Name**: Agreement Details<br />**Description**: Shows the details of this agreement, as presented to the customer<br />|
|msdyn_agreementid|Edm.Guid|**Display Name**: Agreement<br />**Description**: Shows the entity instances.<br />|
|msdyn_childindex|Edm.Int32|**Display Name**: Child Index<br />|
|msdyn_datecanceled|Edm.DateTimeOffset|**Display Name**: Date Canceled<br />**Description**: Enter the date this agreement was canceled.<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type a description of the agreement.<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Shows the duration how long this agreement is active.<br />|
|msdyn_enddate|Edm.DateTimeOffset|**Display Name**: End Date<br />**Description**: Enter the date when this agreement is no longer active.<br />|
|msdyn_name|Edm.String|**Display Name**: Agreement Number<br />|
|msdyn_startdate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Enter the date from when this agreement is active.<br />|
|msdyn_systemstatus|Edm.Int32|**Display Name**: System Status<br />**Description**: Tracks the current system status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Estimate</td></tr><tr><td>690970001</td><td>Active</td></tr><tr><td>690970002</td><td>Expired</td></tr><tr><td>690970003</td><td>Canceled</td></tr><tbody></table>|
|msdyn_taxable|Edm.Boolean|**Display Name**: Taxable<br />**Description**: Specify if Agreement is taxable. By default an Agreement is taxable if billing account is not tax exempt, and Agreement type is taxable. If any of the above is false it will be set to non-taxable.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the ID of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Agreement<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Agreement<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_billingaccount_value|msdyn_billingaccount<br />|Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.|
|_msdyn_originatingagreement_value|msdyn_originatingagreement_msdyn_agreement<br />|If this agreement originates from another agreement, you should specify the originating agreement here|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Price List that controls pricing for products added to this Agreement. By default the system will use the Price List specified on the account|
|_msdyn_salestaxcode_value|msdyn_salestaxcode<br />|Tax Code to be used to calculate tax when Agreement is taxable. By default the system will use the tax code specified on the service account|
|_msdyn_serviceaccount_value|msdyn_serviceaccount<br />|Account to be serviced|
|_msdyn_serviceterritory_value|msdyn_serviceterritory<br />|The service territory this Agreement relates to. By default this will be set to the Service Territory defined on the service account|
|_msdyn_substatus_value|msdyn_substatus<br />|Agreement Sub-status|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the ID of the stage where the entity is located.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreement_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreement_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreement_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_agreement_modifiedonbehalfby|
|msdyn_billingaccount|[account EntityType](account.md)|msdyn_account_msdyn_agreement_BillingAccount|
|msdyn_originatingagreement_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_agreement_PriceList|
|msdyn_salestaxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode|
|msdyn_serviceaccount|[account EntityType](account.md)|msdyn_account_msdyn_agreement_ServiceAccount|
|msdyn_serviceterritory|[territory EntityType](territory.md)|msdyn_territory_msdyn_agreement_ServiceTerritory|
|msdyn_substatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_agreement|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_agreement|
|owningteam|[team EntityType](team.md)|team_msdyn_agreement|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_agreement|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_agreement|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_agreement_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_agreement|  
|msdyn_agreement_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_agreement_adx_alertsubscription|  
|msdyn_agreement_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_agreement_adx_inviteredemption|  
|msdyn_agreement_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_agreement_adx_portalcomment|  
|msdyn_agreement_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_agreement|  
|msdyn_agreement_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_agreement_appointment|  
|msdyn_agreement_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_agreement|  
|msdyn_agreement_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_agreement|  
|msdyn_agreement_connections1|[connection EntityType](connection.md)|record1id_msdyn_agreement|  
|msdyn_agreement_connections2|[connection EntityType](connection.md)|record2id_msdyn_agreement|  
|msdyn_agreement_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_agreement|  
|msdyn_agreement_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_agreement|  
|msdyn_agreement_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_agreement_email|  
|msdyn_agreement_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_agreement_fax|  
|msdyn_agreement_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_agreement_letter|  
|msdyn_agreement_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_agreement_msdyn_approval|  
|msdyn_agreement_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_agreement_msdyn_bookingalert|  
|msdyn_agreement_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_agreement_msdyn_surveyinvite|  
|msdyn_agreement_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_agreement_phonecall|  
|msdyn_agreement_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_agreement_recurringappointmentmaster|  
|msdyn_agreement_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_agreement_serviceappointment|  
|msdyn_agreement_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_agreement|  
|msdyn_agreement_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_agreement_socialactivity|  
|msdyn_agreement_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_agreement|  
|msdyn_agreement_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_agreement_task|  
|msdyn_msdyn_agreement_invoicedetail_Agreement|[invoicedetail EntityType](invoicedetail.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_actual_Agreement|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_Agreement|  
|msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_originatingagreement_msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_msdyn_workorder_Agreement|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_agreement|  
|msdyn_msdyn_agreement_quotedetail_Agreement|[quotedetail EntityType](quotedetail.md)|msdyn_Agreement|  
|msdyn_msdyn_agreement_salesorderdetail_Agreement|[salesorderdetail EntityType](salesorderdetail.md)|msdyn_agreement|  

## Operations
The following operations can be used with the msdyn_agreement entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_agreement entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_agreement.md](./remarks/msdyn_agreement.md)]

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