---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_workorderservice EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4d3fb589-db79-41d4-a749-a30e2bb36af9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_workorderservice entitytype."
---
# msdyn_workorderservice EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_workorderservice.md](./descriptions/msdyn_workorderservice.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_workorderservices </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Work Order Service</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_workorderserviceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_workorderservice entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_additionalcost|Edm.Decimal|**Display Name**: Additional Cost<br />**Description**: Enter any additional costs associated with this service. The values are manually entered. Note: additional cost is not unit dependent.<br />|
|msdyn_additionalcost_base|Edm.Decimal|**Display Name**: Additional Cost (Base)<br />**Description**: Shows the value of the additional cost in the base currency.<br />Read-only<br />|
|msdyn_calculatedunitamount|Edm.Decimal|**Display Name**: Calculated Unit Amount<br />**Description**: Shows the sale amount per unit calculated by the system considering the minimum charge, if applicable.<br />|
|msdyn_calculatedunitamount_base|Edm.Decimal|**Display Name**: Calculated Unit Amount (Base)<br />**Description**: Shows the value of the calculated unit amount in the base currency.<br />Read-only<br />|
|msdyn_commissioncosts|Edm.Decimal|**Display Name**: Commission Costs<br />**Description**: Enter the commission costs associated with this service. The value is manually specified and isn't automatically calculated.<br />|
|msdyn_commissioncosts_base|Edm.Decimal|**Display Name**: Commission Costs (Base)<br />**Description**: Shows the value of the commission costs in the base currency.<br />Read-only<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Enter the description of the service as presented to the customer. The value defaults to the description defined on the service.<br />|
|msdyn_discountamount|Edm.Decimal|**Display Name**: Discount Amount<br />**Description**: Specify any discount amount on this service. Note: If you enter a discount amount you cannot enter a discount %<br />|
|msdyn_discountamount_base|Edm.Decimal|**Display Name**: Discount Amount (Base)<br />**Description**: Shows the value of the discount Amount in the base currency.<br />Read-only<br />|
|msdyn_discountpercent|Edm.Double|**Display Name**: Discount %<br />**Description**: Specify any discount % on this service. Note: If you enter a discount % it will overwrite the discount $<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: Shows the actual duration of service.<br />|
|msdyn_durationtobill|Edm.Int32|**Display Name**: Duration To Bill<br />**Description**: Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."<br />|
|msdyn_estimatecalculatedunitamount|Edm.Decimal|**Display Name**: Estimate Calculated Unit Amount<br />**Description**: Shows the estimated sale amount per unit calculated by the system considering the initial charge (if applicable).<br />|
|msdyn_estimatecalculatedunitamount_base|Edm.Decimal|**Display Name**: Estimate Calculated Unit Amount (Base)<br />**Description**: Shows the value of the estimate calculated unit amount in the base currency.<br />Read-only<br />|
|msdyn_estimatediscountamount|Edm.Decimal|**Display Name**: Estimate Discount Amount<br />**Description**: Enter a discount amount on the subtotal amount. Note: If you enter a discount amount you cannot enter a discount %<br />|
|msdyn_estimatediscountamount_base|Edm.Decimal|**Display Name**: Estimate Discount Amount (Base)<br />**Description**: Shows the value of the estimate discount amount in the base currency.<br />Read-only<br />|
|msdyn_estimatediscountpercent|Edm.Double|**Display Name**: Estimate Discount %<br />**Description**: Enter a discount % on the subtotal amount. Note: If you enter a discount % it will overwrite the discount $<br />|
|msdyn_estimateduration|Edm.Int32|**Display Name**: Estimate Duration<br />**Description**: Enter the estimated duration of this service.<br />|
|msdyn_estimatesubtotal|Edm.Decimal|**Display Name**: Estimate Subtotal<br />**Description**: Shows the total amount for this service, excluding discounts.<br />|
|msdyn_estimatesubtotal_base|Edm.Decimal|**Display Name**: Estimate Subtotal (Base)<br />**Description**: Shows the value of the estimate subtotal in the base currency.<br />Read-only<br />|
|msdyn_estimatetotalamount|Edm.Decimal|**Display Name**: Estimate Total Amount<br />**Description**: Shows the estimated total amount of this service, including discounts.<br />|
|msdyn_estimatetotalamount_base|Edm.Decimal|**Display Name**: Estimate Total Amount (Base)<br />**Description**: Shows the value of the estimate total amount in the base currency.<br />Read-only<br />|
|msdyn_estimatetotalcost|Edm.Decimal|**Display Name**: Estimate Total Cost<br />**Description**: Shows the estimated total cost of this service.<br />|
|msdyn_estimatetotalcost_base|Edm.Decimal|**Display Name**: Estimate Total Cost (Base)<br />**Description**: Shows the value of the estimate total cost in the base currency.<br />Read-only<br />|
|msdyn_estimateunitamount|Edm.Decimal|**Display Name**: Estimate Unit Amount<br />**Description**: Shows the estimated sale amount per unit.<br />|
|msdyn_estimateunitamount_base|Edm.Decimal|**Display Name**: Estimate Unit Amount (Base)<br />**Description**: Shows the value of the estimate unit amount in the base currency.<br />Read-only<br />|
|msdyn_estimateunitcost|Edm.Decimal|**Display Name**: Estimate Unit Cost<br />**Description**: Shows the estimated cost amount per unit.<br />|
|msdyn_estimateunitcost_base|Edm.Decimal|**Display Name**: Estimate Unit Cost (Base)<br />**Description**: Shows the value of the estimate unit cost in the base currency.<br />Read-only<br />|
|msdyn_internaldescription|Edm.String|**Display Name**: Internal Description<br />**Description**: Enter any internal notes you want to track on this service.<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />|
|msdyn_lineorder|Edm.Int32|**Display Name**: Line Order<br />|
|msdyn_linestatus|Edm.Int32|**Display Name**: Line Status<br />**Description**: Enter the current status of the line, estimate or used.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Estimated</td></tr><tr><td>690970001</td><td>Used</td></tr><tbody></table>|
|msdyn_minimumchargeamount|Edm.Decimal|**Display Name**: Minimum Charge Amount<br />**Description**: Enter the amount charged as a minimum charge.<br />|
|msdyn_minimumchargeamount_base|Edm.Decimal|**Display Name**: Minimum Charge Amount (Base)<br />**Description**: Shows the value of the minimum charge amount in the base currency.<br />Read-only<br />|
|msdyn_minimumchargeduration|Edm.Int32|**Display Name**: Minimum Charge Duration<br />**Description**: Enter the duration of up to how long the minimum charge applies.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_subtotal|Edm.Decimal|**Display Name**: Subtotal<br />**Description**: Enter the total amount excluding discounts.<br />|
|msdyn_subtotal_base|Edm.Decimal|**Display Name**: Subtotal (Base)<br />**Description**: Shows the value of the subtotal in the base currency.<br />Read-only<br />|
|msdyn_taxable|Edm.Boolean|**Display Name**: Taxable<br />**Description**: Specify if service is taxable. If you do not wish to charge tax set this field to No.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_totalamount|Edm.Decimal|**Display Name**: Total Amount<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Shows the value of the total amount in the base currency.<br />Read-only<br />|
|msdyn_totalcost|Edm.Decimal|**Display Name**: Total Cost<br />**Description**: Shows the total cost of this service. This is calculated by (Unit Cost * Units) + Additional Cost + Commission Costs.<br />|
|msdyn_totalcost_base|Edm.Decimal|**Display Name**: Total Cost (Base)<br />**Description**: Shows the value of the total cost in the base currency.<br />Read-only<br />|
|msdyn_unitamount|Edm.Decimal|**Display Name**: Unit Amount<br />**Description**: Enter the amount you want to charge the customer per unit. By default, this is calculated based on the selected price list. The amount can be changed.<br />|
|msdyn_unitamount_base|Edm.Decimal|**Display Name**: Unit Amount (Base)<br />**Description**: Shows the value of the unit amount in the base currency.<br />Read-only<br />|
|msdyn_unitcost|Edm.Decimal|**Display Name**: Unit Cost<br />**Description**: Shows the actual cost per unit.<br />|
|msdyn_unitcost_base|Edm.Decimal|**Display Name**: Unit Cost (Base)<br />**Description**: Shows the value of the unit cost in the base currency.<br />Read-only<br />|
|msdyn_workorderserviceid|Edm.Guid|**Display Name**: Work Order Service<br />**Description**: Shows the entity instances.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Work Order Service<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Work Order Service<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_agreementbookingservice_value|msdyn_agreementbookingservice<br />|Agreement Booking Service linked to this Work Order Service|
|_msdyn_booking_value|msdyn_booking<br />|Shows the resource booking detail where this product was added.|
|_msdyn_customerasset_value|msdyn_customerasset<br />|Unique identifier for Customer Asset associated with Work Order Service.|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Price List that determines the pricing for this service|
|_msdyn_service_value|msdyn_service<br />|Service proposed or used for this work order|
|_msdyn_unit_value|msdyn_unit<br />|The unit that determines the final quantity for this service|
|_msdyn_workorder_value|msdyn_workorder<br />|The work order this service relates to|
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
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorderservice_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorderservice_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorderservice_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorderservice_modifiedonbehalfby|
|msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService|
|msdyn_booking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_bookableresourcebooking_msdyn_workorderservice_Booking|
|msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_workorderservice_PriceList|
|msdyn_service|[product EntityType](product.md)|msdyn_product_msdyn_workorderservice_Service|
|msdyn_unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_workorderservice_Unit|
|msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder|
|msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_workorderservice|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_workorderservice|
|owningteam|[team EntityType](team.md)|team_msdyn_workorderservice|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_workorderservice|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_workorderservice|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_workorderservice_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|msdyn_workorderserviceid|  
|msdyn_workorderservice_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_workorderservice|  
|msdyn_workorderservice_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_workorderservice_adx_alertsubscription|  
|msdyn_workorderservice_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_workorderservice_adx_inviteredemption|  
|msdyn_workorderservice_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_workorderservice_adx_portalcomment|  
|msdyn_workorderservice_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_workorderservice|  
|msdyn_workorderservice_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_workorderservice_appointment|  
|msdyn_workorderservice_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_workorderservice|  
|msdyn_workorderservice_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_workorderservice|  
|msdyn_workorderservice_connections1|[connection EntityType](connection.md)|record1id_msdyn_workorderservice|  
|msdyn_workorderservice_connections2|[connection EntityType](connection.md)|record2id_msdyn_workorderservice|  
|msdyn_workorderservice_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_workorderservice|  
|msdyn_workorderservice_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_workorderservice|  
|msdyn_workorderservice_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_workorderservice_email|  
|msdyn_workorderservice_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_workorderservice_fax|  
|msdyn_workorderservice_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_workorderservice_letter|  
|msdyn_workorderservice_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_workorderservice_msdyn_approval|  
|msdyn_workorderservice_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_workorderservice_msdyn_bookingalert|  
|msdyn_workorderservice_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_workorderservice_msdyn_surveyinvite|  
|msdyn_workorderservice_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_workorderservice_phonecall|  
|msdyn_workorderservice_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_workorderservice|  
|msdyn_workorderservice_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_workorderservice_recurringappointmentmaster|  
|msdyn_workorderservice_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_workorderservice_serviceappointment|  
|msdyn_workorderservice_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_workorderservice|  
|msdyn_workorderservice_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_workorderservice_socialactivity|  
|msdyn_workorderservice_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_workorderservice|  
|msdyn_workorderservice_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_workorderservice_task|  

## Operations
The following operations can be used with the msdyn_workorderservice entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_workorderservice entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_workorderservice.md](./remarks/msdyn_workorderservice.md)]

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