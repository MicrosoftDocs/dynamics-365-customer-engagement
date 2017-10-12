---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_workorder EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 51be2e22-cd12-49f6-a0b2-327436d2190d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_workorder entitytype."
---
# msdyn_workorder EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_workorder.md](./descriptions/msdyn_workorder.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_workorders </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Work Order</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_workorderid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_workorder entitytype has no functions or actions bound to it.

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
|msdyn_addressname|Edm.String|**Display Name**: Address Name<br />|
|msdyn_bookingsummary|Edm.String|**Display Name**: Booking Summary<br />**Description**: Shows a synopsis of the bookings on the work order. This field is automatically updated by the system whenever a resource booking on the work order is changed.<br />|
|msdyn_childindex|Edm.Int32|**Display Name**: Child Index<br />|
|msdyn_city|Edm.String|**Display Name**: City<br />|
|msdyn_country|Edm.String|**Display Name**: Country/Region<br />|
|msdyn_datewindowend|Edm.DateTimeOffset|**Display Name**: Date Window End<br />|
|msdyn_datewindowstart|Edm.DateTimeOffset|**Display Name**: Date Window Start<br />|
|msdyn_estimatesubtotalamount|Edm.Decimal|**Display Name**: Estimate Subtotal Amount<br />**Description**: Enter the summary of total estimated billing amount for this work order<br />|
|msdyn_estimatesubtotalamount_base|Edm.Decimal|**Display Name**: Estimate Subtotal Amount (Base)<br />**Description**: Shows the value of the estimate subtotal amount in the base currency.<br />Read-only<br />|
|msdyn_followupnote|Edm.String|**Display Name**: Follow Up Note (Deprecated)<br />**Description**: Indicate the details of the follow up work<br />|
|msdyn_followuprequired|Edm.Boolean|**Display Name**: Follow Up Required (Deprecated)<br />**Description**: Allows indication if follow up work is required for a work order.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_instructions|Edm.String|**Display Name**: Instructions<br />**Description**: Shows instructions for booked resources. By default, this information is taken from the work order instructions field on the service account.<br />|
|msdyn_internalflags|Edm.String|**Display Name**: Internal Flags<br />**Description**: For internal use only.<br />|
|msdyn_isfollowup|Edm.Boolean|**Display Name**: Is FollowUp (Deprecated)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_ismobile|Edm.Boolean|**Display Name**: Is Mobile<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_latitude|Edm.Double|**Display Name**: Latitude<br />|
|msdyn_longitude|Edm.Double|**Display Name**: Longitude<br />|
|msdyn_name|Edm.String|**Display Name**: Work Order Number<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_postalcode|Edm.String|**Display Name**: Postal Code<br />|
|msdyn_primaryincidentdescription|Edm.String|**Display Name**: Primary Incident Description<br />**Description**: Incident description<br />|
|msdyn_primaryincidentestimatedduration|Edm.Int32|**Display Name**: Primary Incident Estimated Duration<br />**Description**: Shows the time estimated to resolve this incident.<br />|
|msdyn_stateorprovince|Edm.String|**Display Name**: State Or Province<br />|
|msdyn_subtotalamount|Edm.Decimal|**Display Name**: Subtotal Amount<br />**Description**: Enter the summary of subtotal billing amount excluding tax for this work order.<br />|
|msdyn_subtotalamount_base|Edm.Decimal|**Display Name**: Subtotal Amount (Base)<br />**Description**: Shows the value of the subtotal amount in the base currency.<br />Read-only<br />|
|msdyn_systemstatus|Edm.Int32|**Display Name**: System Status<br />**Description**: Tracks the current system status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Open - Unscheduled</td></tr><tr><td>690970001</td><td>Open - Scheduled</td></tr><tr><td>690970002</td><td>Open - In Progress</td></tr><tr><td>690970003</td><td>Open - Completed</td></tr><tr><td>690970004</td><td>Closed - Posted</td></tr><tr><td>690970005</td><td>Closed - Canceled</td></tr><tbody></table>|
|msdyn_taxable|Edm.Boolean|**Display Name**: Taxable<br />**Description**: Shows whether sales tax is to be charged for this work order.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_timeclosed|Edm.DateTimeOffset|**Display Name**: Closed On<br />**Description**: Enter the time this work order was last closed.<br />|
|msdyn_timefrompromised|Edm.DateTimeOffset|**Display Name**: Time From Promised<br />**Description**: Enter the starting range of the time promised to the account that incidents will be resolved.<br />|
|msdyn_timetopromised|Edm.DateTimeOffset|**Display Name**: Time To Promised<br />**Description**: Enter the ending range of the time promised to the account that incidents will be resolved.<br />|
|msdyn_timewindowend|Edm.DateTimeOffset|**Display Name**: Time Window End<br />|
|msdyn_timewindowstart|Edm.DateTimeOffset|**Display Name**: Time Window Start<br />|
|msdyn_totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Enter the summary of total billing amount for this work order.<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Shows the value of the total amount in the base currency.<br />Read-only<br />|
|msdyn_totalsalestax|Edm.Decimal|**Display Name**: Total Sales Tax<br />**Description**: Enter the summary of total sales tax charged for this work order.<br />|
|msdyn_totalsalestax_base|Edm.Decimal|**Display Name**: Total Sales Tax (Base)<br />**Description**: Shows the value of the total sales tax in the base currency.<br />Read-only<br />|
|msdyn_worklocation|Edm.Int32|**Display Name**: Work Location<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Onsite</td></tr><tr><td>690970001</td><td>Depot</td></tr><tr><td>690970002</td><td>Location Agnostic</td></tr><tbody></table>|
|msdyn_workorderid|Edm.Guid|**Display Name**: WO Number<br />**Description**: Shows the entity instances.<br />|
|msdyn_workordersummary|Edm.String|**Display Name**: Work Order Summary<br />**Description**: Type a summary description of the job.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Shows the ID of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Work Order<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Work Order<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: Shows a comma-separated list of string values representing the unique identifiers of stages in a business process flow instance in the order that they occur.<br />|
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
|_msdyn_agreement_value|msdyn_agreement<br />|Shows the agreement linked to this work order.|
|_msdyn_billingaccount_value|msdyn_billingaccount<br />|Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.|
|_msdyn_closedby_value|msdyn_closedby<br />|The user that last closed this work order|
|_msdyn_customerasset_value|msdyn_customerasset<br />|Customer Asset related to this incident reported|
|_msdyn_iotalert_value|msdyn_IoTAlert<br />|The iot alert which initiated this work order.|
|_msdyn_opportunityid_value|msdyn_opportunityid<br />|Unique identifier for Opportunity associated with Work Order.|
|_msdyn_parentworkorder_value|msdyn_parentworkorder_msdyn_workorder<br />|Unique identifier for Work Order associated with Work Order.|
|_msdyn_preferredresource_value|msdyn_preferredresource<br />|The customer Preferred Resource to work on this job. Should be taken into consideration while scheduling resources|
|_msdyn_pricelist_value|msdyn_pricelist<br />|Price List that controls pricing for products / services added to this work order. By default the system will use the Price List specified on the account|
|_msdyn_primaryincidenttype_value|msdyn_primaryincidenttype<br />|Primary incident type reported|
|_msdyn_priority_value|msdyn_priority<br />|Priority of the Work Order. To be taken into consideration while scheduling resources|
|_msdyn_reportedbycontact_value|msdyn_reportedbycontact<br />|The contact that reported this Work Order|
|_msdyn_serviceaccount_value|msdyn_serviceaccount<br />|Account to be serviced|
|_msdyn_servicerequest_value|msdyn_servicerequest<br />|Case of which this work order originates from|
|_msdyn_serviceterritory_value|msdyn_serviceterritory<br />|The service territory this work order relates to. By default this will be set to the Service Territory defined on the service account|
|_msdyn_substatus_value|msdyn_substatus<br />|Work Order sub-status|
|_msdyn_taxcode_value|msdyn_taxcode<br />|Tax Code to be used to calculate tax when Work Order is taxable. By default the system will use the tax code specified on the service account|
|_msdyn_timegroup_value|msdyn_timegroup<br />||
|_msdyn_timegroupdetailselected_value|msdyn_timegroupdetailselected<br />||
|_msdyn_workordertype_value|msdyn_workordertype<br />|Work Order Type|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Shows the ID of the stage where the entity is located.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorder_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorder_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorder_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_workorder_modifiedonbehalfby|
|msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_msdyn_agreement_msdyn_workorder_Agreement|
|msdyn_billingaccount|[account EntityType](account.md)|msdyn_account_msdyn_workorder_BillingAccount|
|msdyn_closedby|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_workorder_ClosedBy|
|msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset|
|msdyn_IoTAlert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert|
|msdyn_opportunityid|[opportunity EntityType](opportunity.md)|msdyn_opportunity_msdyn_workorder|
|msdyn_parentworkorder_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder|
|msdyn_preferredresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_workorder_PreferredResource|
|msdyn_pricelist|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_workorder_PriceList|
|msdyn_primaryincidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType|
|msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_msdyn_priority_msdyn_workorder_Priority|
|msdyn_reportedbycontact|[contact EntityType](contact.md)|msdyn_contact_msdyn_workorder_ReportedByContact|
|msdyn_serviceaccount|[account EntityType](account.md)|msdyn_account_msdyn_workorder_ServiceAccount|
|msdyn_servicerequest|[incident EntityType](incident.md)|msdyn_incident_msdyn_workorder_ServiceRequest|
|msdyn_serviceterritory|[territory EntityType](territory.md)|msdyn_territory_msdyn_workorder_ServiceTerritory|
|msdyn_substatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|msdyn_msdyn_workordersubstatus_msdyn_workorder_Status|
|msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_msdyn_taxcode_msdyn_workorder_TaxCode|
|msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_msdyn_timegroup_msdyn_workorder_TimeGroup|
|msdyn_timegroupdetailselected|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected|
|msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_workorder|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_workorder|
|owningteam|[team EntityType](team.md)|team_msdyn_workorder|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_workorder|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_workorder|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_workorder|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bpf_msdyn_workorder_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|bpf_msdyn_workorderid|  
|msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|msdyn_workorderid|  
|msdyn_msdyn_workorder_msdyn_actual_WorkOrder|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_WorkOrder|  
|msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_allocatedtoworkorder|  
|msdyn_msdyn_workorder_msdyn_iotalert_Workorder|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_Workorder|  
|msdyn_msdyn_workorder_msdyn_payment_WorkOrder|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_paymentdetail_Workorder|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_associatetoworkorder|  
|msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_associatetoworkorder|  
|msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|msdyn_WorkOrder|  
|msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_WorkOrder|  
|msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_WorkOrder|  
|msdyn_msdyn_workorder_msdyn_rma_WorkOrder|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_rtv_WorkOrder|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_parentworkorder_msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorder|  
|msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorder|  
|msdyn_workorder_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_workorder|  
|msdyn_workorder_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_workorder_adx_alertsubscription|  
|msdyn_workorder_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_workorder_adx_inviteredemption|  
|msdyn_workorder_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_workorder_adx_portalcomment|  
|msdyn_workorder_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_workorder|  
|msdyn_workorder_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_workorder_appointment|  
|msdyn_workorder_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_workorder|  
|msdyn_workorder_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_workorder|  
|msdyn_workorder_connections1|[connection EntityType](connection.md)|record1id_msdyn_workorder|  
|msdyn_workorder_connections2|[connection EntityType](connection.md)|record2id_msdyn_workorder|  
|msdyn_workorder_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_workorder|  
|msdyn_workorder_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_workorder|  
|msdyn_workorder_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_workorder_email|  
|msdyn_workorder_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_workorder_fax|  
|msdyn_workorder_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_workorder_letter|  
|msdyn_workorder_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_workorder_msdyn_approval|  
|msdyn_workorder_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_workorder_msdyn_bookingalert|  
|msdyn_workorder_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_workorder_msdyn_surveyinvite|  
|msdyn_workorder_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_workorder_phonecall|  
|msdyn_workorder_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_workorder|  
|msdyn_workorder_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_workorder_recurringappointmentmaster|  
|msdyn_workorder_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_workorder_serviceappointment|  
|msdyn_workorder_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_workorder|  
|msdyn_workorder_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_workorder_socialactivity|  
|msdyn_workorder_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_workorder|  
|msdyn_workorder_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_workorder_task|  

## Operations
The following operations can be used with the msdyn_workorder entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_workorder entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Connected Field Service for Microsoft Dynamics 365 Solution](../solutions/connectedfieldservice.md)|[!INCLUDE[../solutions/descriptions/connectedfieldservice.md](../solutions/descriptions/connectedfieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_workorder.md](./remarks/msdyn_workorder.md)]

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