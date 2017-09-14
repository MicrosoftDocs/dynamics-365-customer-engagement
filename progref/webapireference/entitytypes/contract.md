---
title: "Microsoft Dynamics 365 Customer Engagement contract EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e63d72f0-d78d-49b1-9da5-32bea2a8deb2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API contract entitytype."
---
# contract EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/contract.md](./descriptions/contract.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]contracts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Contract</td></tr>
<tr><td><b>Primary Key:</b></td><td>contractid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activeon|Edm.DateTimeOffset|**Display Name**: Contract Start Date<br />**Description**: Enter the date when the contract becomes active.<br />|
|allotmenttypecode|Edm.Int32|**Display Name**: Allotment Type<br />**Description**: Type of allotment that the contract supports.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Number of Cases</td></tr><tr><td>2</td><td>Time</td></tr><tr><td>3</td><td>Coverage Dates</td></tr><tbody></table>|
|billingendon|Edm.DateTimeOffset|**Display Name**: Billing End Date<br />**Description**: Enter the end date for the contract's billing period to indicate the period for which the customer must pay for a service.<br />|
|billingfrequencycode|Edm.Int32|**Display Name**: Billing Frequency<br />**Description**: Select the billing schedule of the contract to indicate how often the customer should be invoiced.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Monthly</td></tr><tr><td>2</td><td>Bimonthly</td></tr><tr><td>3</td><td>Quarterly</td></tr><tr><td>4</td><td>Semiannually</td></tr><tr><td>5</td><td>Annually</td></tr><tbody></table>|
|billingstarton|Edm.DateTimeOffset|**Display Name**: Billing Start Date<br />**Description**: Enter the start date for the contract's billing period to indicate the period for which the customer must pay for a service. This defaults to the same date that is selected in the Contract Start Date field.<br />|
|cancelon|Edm.DateTimeOffset|**Display Name**: Cancellation Date<br />**Description**: Shows the date and time when the contract was canceled.<br />Read-only<br />|
|contractid|Edm.Guid|**Display Name**: Contract<br />**Description**: Unique identifier of the contract.<br />|
|contractlanguage|Edm.String|**Display Name**: Description<br />**Description**: Type additional information about the contract, such as the products or services provided to the customer.<br />|
|contractnumber|Edm.String|**Display Name**: Contract ID<br />**Description**: Shows the number for the contract for customer reference and searching capabilities. You cannot modify this number.<br />|
|contractservicelevelcode|Edm.Int32|**Display Name**: Service Level<br />**Description**: Select the level of service that should be provided for the contract based on your company's definition of bronze, silver, or gold.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Gold</td></tr><tr><td>2</td><td>Silver</td></tr><tr><td>3</td><td>Bronze</td></tr><tbody></table>|
|contracttemplateabbreviation|Edm.String|**Display Name**: Template Abbreviation<br />**Description**: Shows the abbreviation of the contract template selected when the contract is created.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Shows for the duration of the contract, in days, based on the contract start and end dates.<br />Read-only<br />|
|effectivitycalendar|Edm.String|**Display Name**: Support Calendar<br />**Description**: Days of the week and times during which customer service support is available for the duration of the contract.<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|expireson|Edm.DateTimeOffset|**Display Name**: Contract End Date<br />**Description**: Enter the date when the contract expires.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|netprice|Edm.Decimal|**Display Name**: Net Price<br />**Description**: Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field for each existing contract line related to the contract.<br />Read-only<br />|
|netprice_base|Edm.Decimal|**Display Name**: Net Price (Base)<br />**Description**: Value of the Net Price in base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the contracts that are in draft status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Invoiced</td></tr><tr><td>2</td><td>Active</td></tr><tr><td>3</td><td>On Hold</td></tr><tr><td>4</td><td>Canceled</td></tr><tr><td>5</td><td>Expired</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the contract's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Draft</td></tr><tr><td>2</td><td>Invoiced</td></tr><tr><td>3</td><td>Active</td></tr><tr><td>4</td><td>On Hold</td></tr><tr><td>5</td><td>Canceled</td></tr><tr><td>6</td><td>Expired</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Contract Name<br />**Description**: Type a title or name for the contract that indicates the purpose of the contract.<br />|
|totaldiscount|Edm.Decimal|**Display Name**: Total Discount<br />**Description**: Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount fields for each existing contract line related to the contract.<br />Read-only<br />|
|totaldiscount_base|Edm.Decimal|**Display Name**: Total Discount (Base)<br />**Description**: Value of the Total Discount in base currency.<br />Read-only<br />|
|totalprice|Edm.Decimal|**Display Name**: Total Price<br />**Description**: Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum of values in the Total Price field for each existing contract line related to the contract.<br />Read-only<br />|
|totalprice_base|Edm.Decimal|**Display Name**: Total Price (Base)<br />**Description**: Value of the Total Price in base currency.<br />Read-only<br />|
|usediscountaspercentage|Edm.Boolean|**Display Name**: Discount<br />**Description**: Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a fixed dollar value.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Percentage</td></tr><tr><td>0</td><td>Amount</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Unique identifier of the account with which the contract is associated.|
|_billingaccountid_value||Unique identifier of the account to which the contract is to be billed.|
|_billingcontactid_value||Unique identifier of the contact to whom the contract is to be billed.|
|_billingcustomerid_value|billingcustomerid_account<br />billingcustomerid_contact<br />|Select the customer account or contact to which the contract should be billed to provide a quick link to address and other customer details.|
|_billtoaddress_value|billtoaddress<br />|Choose which address to send the invoice to.|
|_contactid_value||Unique identifier of the contact specified for the contract.|
|_contracttemplateid_value|contracttemplateid<br />|Choose the contract template that should be used to determine the terms of the contract, such as allotment type, available hours, and billing frequency.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_originatingcontract_value|originatingcontract<br />|Choose the original contract that this contract was created from. This information is used to track renewal history.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_serviceaddress_value|serviceaddress<br />|Choose the address for the customer account or contact where the services are provided.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|billingcustomerid_account|[account EntityType](account.md)|contract_billingcustomer_accounts|
|billingcustomerid_contact|[contact EntityType](contact.md)|contract_billingcustomer_contacts|
|billtoaddress|[customeraddress EntityType](customeraddress.md)|customer_address_contracts_as_billing_address|
|contracttemplateid|[contracttemplate EntityType](contracttemplate.md)|contract_template_contracts|
|createdby|[systemuser EntityType](systemuser.md)|lk_contractbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_contract_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|contract_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|contract_customer_contacts|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_contractbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_contract_modifiedonbehalfby|
|originatingcontract|[contract EntityType](contract.md)|contract_originating_contract|
|ownerid|[principal EntityType](principal.md)|owner_contracts|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_service_contracts|
|owningteam|[team EntityType](team.md)|team_service_contracts|
|owninguser|[systemuser EntityType](systemuser.md)|system_user_service_contracts|
|serviceaddress|[customeraddress EntityType](customeraddress.md)|customer_address_contracts_as_service_address|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_contract|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|contract_activity_parties|[activityparty EntityType](activityparty.md)|partyid_contract|  
|Contract_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_contract|  
|contract_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_contract_adx_alertsubscription|  
|contract_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_contract_adx_inviteredemption|  
|contract_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_contract_adx_portalcomment|  
|Contract_Annotation|[annotation EntityType](annotation.md)|objectid_contract|  
|Contract_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_contract_appointment|  
|Contract_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_contract|  
|Contract_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_contract|  
|contract_cases|[incident EntityType](incident.md)|contractid|  
|contract_connections1|[connection EntityType](connection.md)|record1id_contract|  
|contract_connections2|[connection EntityType](connection.md)|record2id_contract|  
|Contract_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_contract|  
|Contract_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_contract|  
|Contract_Emails|[email EntityType](email.md)|regardingobjectid_contract_email|  
|Contract_Faxes|[fax EntityType](fax.md)|regardingobjectid_contract_fax|  
|Contract_Letters|[letter EntityType](letter.md)|regardingobjectid_contract_letter|  
|contract_line_items|[contractdetail EntityType](contractdetail.md)|contractid|  
|contract_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_contract_msdyn_approval|  
|contract_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_contract_msdyn_bookingalert|  
|contract_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_contract_msdyn_surveyinvite|  
|contract_originating_contract|[contract EntityType](contract.md)|originatingcontract|  
|Contract_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_contract_phonecall|  
|Contract_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_contract_recurringappointmentmaster|  
|Contract_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_contract_serviceappointment|  
|Contract_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_contract_socialactivity|  
|Contract_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_contract_syncerror|  
|Contract_Tasks|[task EntityType](task.md)|regardingobjectid_contract_task|  
|servicecontractcontacts_association|[contact EntityType](contact.md)|servicecontractcontacts_association|  

## Operations
The following operations can be used with the contract entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CancelContract Action](../actions/cancelcontract.md)|Entity|[!INCLUDE[../actions/descriptions/cancelcontract.md](../actions/descriptions/cancelcontract.md)]|  
|[CancelSalesOrder Action](../actions/cancelsalesorder.md)|Not Bound|[!INCLUDE[../actions/descriptions/cancelsalesorder.md](../actions/descriptions/cancelsalesorder.md)]|  
|[CloneContract Action](../actions/clonecontract.md)|Entity|[!INCLUDE[../actions/descriptions/clonecontract.md](../actions/descriptions/clonecontract.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RenewContract Action](../actions/renewcontract.md)|Entity|[!INCLUDE[../actions/descriptions/renewcontract.md](../actions/descriptions/renewcontract.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  

## Solutions
The following solutions include the contract entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/contract.md](./remarks/contract.md)]

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