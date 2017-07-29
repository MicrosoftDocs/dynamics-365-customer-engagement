---
title: "Microsoft Dynamics 365 Customer Engagement transactioncurrency EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 76f8bc95-adb3-499e-aec7-e46d2ce87b87
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API transactioncurrency entitytype."
---
# transactioncurrency EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/transactioncurrency.md](./descriptions/transactioncurrency.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]transactioncurrencies </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Currency</td></tr>
<tr><td><b>Primary Key:</b></td><td>transactioncurrencyid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>currencyname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The transactioncurrency entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the transaction currency was created.<br />Read-only<br />|
|currencyname|Edm.String|**Display Name**: Currency Name<br />**Description**: Name of the transaction currency.<br />|
|currencyprecision|Edm.Int32|**Display Name**: Currency Precision<br />**Description**: Number of decimal places that can be used for currency.<br />|
|currencysymbol|Edm.String|**Display Name**: Currency Symbol<br />**Description**: Symbol for the transaction currency.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate between the transaction currency and the base currency.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|isocurrencycode|Edm.String|**Display Name**: Currency Code<br />**Description**: ISO currency code for the transaction currency.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the transaction currency was last modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the transaction currency.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the transaction currency.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|transactioncurrencyid|Edm.Guid|**Display Name**: Transaction Currency<br />**Description**: Unique identifier of the transaction currency.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the transaction currency.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the transaction currency.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the transactioncurrency.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the transaction currency.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the transactioncurrency.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the transaction currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_transactioncurrencybase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_transactioncurrency_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_transactioncurrencybase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_transactioncurrency_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_transactioncurrencies|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_alertsubscription_transactioncurrency_transactioncurrencyid|[adx_alertsubscription EntityType](adx_alertsubscription.md)|transactioncurrencyid_adx_alertsubscription|  
|adx_inviteredemption_transactioncurrency_transactioncurrencyid|[adx_inviteredemption EntityType](adx_inviteredemption.md)|transactioncurrencyid_adx_inviteredemption|  
|adx_portalcomment_transactioncurrency_transactioncurrencyid|[adx_portalcomment EntityType](adx_portalcomment.md)|transactioncurrencyid_adx_portalcomment|  
|basecurrency_organization|[organization EntityType](organization.md)|basecurrencyid|  
|bulkoperation_transactioncurrency_transactioncurrencyid|[bulkoperation EntityType](bulkoperation.md)|transactioncurrencyid_bulkoperation|  
|DynamicPropertyAssociation_TransactionCurrency|[dynamicpropertyassociation EntityType](dynamicpropertyassociation.md)|transactioncurrencyid|  
|DynamicPropertyOptionSetItem_TransactionCurrency|[dynamicpropertyoptionsetitem EntityType](dynamicpropertyoptionsetitem.md)|transactioncurrencyid|  
|incidentresolution_transactioncurrency_transactioncurrencyid|[incidentresolution EntityType](incidentresolution.md)|transactioncurrencyid_incidentresolution|  
|msdyn_approval_transactioncurrency_transactioncurrencyid|[msdyn_approval EntityType](msdyn_approval.md)|transactioncurrencyid_msdyn_approval|  
|msdyn_bookingalert_transactioncurrency_transactioncurrencyid|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|transactioncurrencyid_msdyn_bookingalert|  
|msdyn_organizationalunit_currency|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_currency|  
|msdyn_surveyinvite_transactioncurrency_transactioncurrencyid|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|transactioncurrencyid_msdyn_surveyinvite|  
|msdyn_transactioncurrency_invoicedetail_Currency|[invoicedetail EntityType](invoicedetail.md)|msdyn_currency|  
|orderclose_transactioncurrency_transactioncurrencyid|[orderclose EntityType](orderclose.md)|transactioncurrencyid_orderclose|  
|quoteclose_transactioncurrency_transactioncurrencyid|[quoteclose EntityType](quoteclose.md)|transactioncurrencyid_quoteclose|  
|transactioncurrency_account|[account EntityType](account.md)|transactioncurrencyid|  
|transactioncurrency_actioncard|[actioncard EntityType](actioncard.md)|transactioncurrencyid|  
|TransactionCurrency_ActionCardUserState|[actioncarduserstate EntityType](actioncarduserstate.md)|transactioncurrencyid|  
|TransactionCurrency_ActivityPointer|[activitypointer EntityType](activitypointer.md)|transactioncurrencyid|  
|transactioncurrency_annualfiscalcalendar|[annualfiscalcalendar EntityType](annualfiscalcalendar.md)|transactioncurrencyid|  
|TransactionCurrency_Appointment|[appointment EntityType](appointment.md)|transactioncurrencyid_appointment|  
|TransactionCurrency_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_transactioncurrency|  
|TransactionCurrency_bookableresource|[bookableresource EntityType](bookableresource.md)|transactioncurrencyid|  
|TransactionCurrency_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|transactioncurrencyid|  
|TransactionCurrency_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|transactioncurrencyid|  
|TransactionCurrency_bookableresourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|transactioncurrencyid|  
|TransactionCurrency_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|transactioncurrencyid|  
|TransactionCurrency_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|transactioncurrencyid|  
|TransactionCurrency_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|transactioncurrencyid|  
|TransactionCurrency_bookingstatus|[bookingstatus EntityType](bookingstatus.md)|transactioncurrencyid|  
|TransactionCurrency_BusinessUnit|[businessunit EntityType](businessunit.md)|transactioncurrencyid|  
|transactioncurrency_campaign|[campaign EntityType](campaign.md)|transactioncurrencyid|  
|transactioncurrency_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|transactioncurrencyid_campaignactivity|  
|TransactionCurrency_CampaignResponse|[campaignresponse EntityType](campaignresponse.md)|transactioncurrencyid_campaignresponse|  
|transactioncurrency_category|[category EntityType](category.md)|transactioncurrencyid|  
|TransactionCurrency_characteristic|[characteristic EntityType](characteristic.md)|transactioncurrencyid|  
|transactioncurrency_competitor|[competitor EntityType](competitor.md)|transactioncurrencyid|  
|TransactionCurrency_Connection|[connection EntityType](connection.md)|transactioncurrencyid|  
|transactioncurrency_contact|[contact EntityType](contact.md)|transactioncurrencyid|  
|transactioncurrency_contract|[contract EntityType](contract.md)|transactioncurrencyid|  
|transactioncurrency_contractdetail|[contractdetail EntityType](contractdetail.md)|transactioncurrencyid|  
|TransactionCurrency_CustomerAddress|[customeraddress EntityType](customeraddress.md)|transactioncurrencyid|  
|transactioncurrency_discount|[discount EntityType](discount.md)|transactioncurrencyid|  
|transactioncurrency_discounttype|[discounttype EntityType](discounttype.md)|transactioncurrencyid|  
|TransactionCurrency_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_transactioncurrency|  
|TransactionCurrency_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_transactioncurrency|  
|TransactionCurrency_Dynamicpropertyinsatance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|transactioncurrencyid|  
|TransactionCurrency_Email|[email EntityType](email.md)|transactioncurrencyid_email|  
|TransactionCurrency_Entitlement|[entitlement EntityType](entitlement.md)|transactioncurrencyid|  
|TransactionCurrency_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|transactioncurrencyid|  
|TransactionCurrency_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|transactioncurrencyid|  
|TransactionCurrency_entitlementtemplatechannel|[entitlementtemplatechannel EntityType](entitlementtemplatechannel.md)|transactioncurrencyid|  
|TransactionCurrency_Equipment|[equipment EntityType](equipment.md)|transactioncurrencyid|  
|transactioncurrency_expiredprocess|[expiredprocess EntityType](expiredprocess.md)|transactioncurrencyid|  
|TransactionCurrency_Fax|[fax EntityType](fax.md)|transactioncurrencyid_fax|  
|transactioncurrency_feedback|[feedback EntityType](feedback.md)|transactioncurrencyid|  
|transactioncurrency_fixedmonthlyfiscalcalendar|[fixedmonthlyfiscalcalendar EntityType](fixedmonthlyfiscalcalendar.md)|transactioncurrencyid|  
|TransactionCurrency_Goal|[goal EntityType](goal.md)|transactioncurrencyid|  
|TransactionCurrency_Incident|[incident EntityType](incident.md)|transactioncurrencyid|  
|TransactionCurrency_InteractionForEmail|[interactionforemail EntityType](interactionforemail.md)|transactioncurrencyid|  
|transactioncurrency_invoice|[invoice EntityType](invoice.md)|transactioncurrencyid|  
|transactioncurrency_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|transactioncurrencyid|  
|TransactionCurrency_KbArticle|[kbarticle EntityType](kbarticle.md)|transactioncurrencyid|  
|transactioncurrency_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|transactioncurrencyid|  
|transactioncurrency_knowledgearticleincident|[knowledgearticleincident EntityType](knowledgearticleincident.md)|transactioncurrencyid|  
|transactioncurrency_knowledgearticleviews|[knowledgearticleviews EntityType](knowledgearticleviews.md)|transactioncurrencyid|  
|TransactionCurrency_KnowledgeBaseRecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|transactioncurrencyid|  
|transactioncurrency_lead|[lead EntityType](lead.md)|transactioncurrencyid|  
|transactioncurrency_leadtoopportunitysalesprocess|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|transactioncurrencyid|  
|TransactionCurrency_Letter|[letter EntityType](letter.md)|transactioncurrencyid_letter|  
|transactioncurrency_list|[list EntityType](list.md)|transactioncurrencyid|  
|TransactionCurrency_MailMergeTemplate|[mailmergetemplate EntityType](mailmergetemplate.md)|transactioncurrencyid|  
|transactioncurrency_monthlyfiscalcalendar|[monthlyfiscalcalendar EntityType](monthlyfiscalcalendar.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_bookingjournal|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_fieldservicepricelistitem|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_resourcecategorypricelevel|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_transactioncategorypricelevel|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|transactioncurrencyid|  
|TransactionCurrency_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_attendeepass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|msevtmgt_transactioncurrencyid|  
|TransactionCurrency_msevtmgt_AttendeePass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_Building|[msevtmgt_building EntityType](msevtmgt_building.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_Event|[msevtmgt_event EntityType](msevtmgt_event.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_HotelRoomAllocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_pass|[msevtmgt_pass EntityType](msevtmgt_pass.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_Speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_SponsorableArticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_Sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|transactioncurrencyid|  
|TransactionCurrency_msevtmgt_Venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|transactioncurrencyid|  
|transactioncurrency_newprocess|[newprocess EntityType](newprocess.md)|transactioncurrencyid|  
|TransactionCurrency_officegraphdocument|[officegraphdocument EntityType](officegraphdocument.md)|transactioncurrencyid|  
|transactioncurrency_opportunity|[opportunity EntityType](opportunity.md)|transactioncurrencyid|  
|transactioncurrency_opportunityclose|[opportunityclose EntityType](opportunityclose.md)|transactioncurrencyid_opportunityclose|  
|transactioncurrency_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|transactioncurrencyid|  
|transactioncurrency_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|transactioncurrencyid|  
|TransactionCurrency_PhoneCall|[phonecall EntityType](phonecall.md)|transactioncurrencyid_phonecall|  
|transactioncurrency_phonetocaseprocess|[phonetocaseprocess EntityType](phonetocaseprocess.md)|transactioncurrencyid|  
|transactioncurrency_position|[position EntityType](position.md)|transactioncurrencyid|  
|transactioncurrency_pricelevel|[pricelevel EntityType](pricelevel.md)|transactioncurrencyid|  
|transactioncurrency_product|[product EntityType](product.md)|transactioncurrencyid|  
|transactioncurrency_ProductAssociation|[productassociation EntityType](productassociation.md)|transactioncurrencyid|  
|transactioncurrency_productpricelevel|[productpricelevel EntityType](productpricelevel.md)|transactioncurrencyid|  
|transactioncurrency_ProductSubstitute|[productsubstitute EntityType](productsubstitute.md)|transactioncurrencyid|  
|transactioncurrency_quarterlyfiscalcalendar|[quarterlyfiscalcalendar EntityType](quarterlyfiscalcalendar.md)|transactioncurrencyid|  
|TransactionCurrency_Queue|[queue EntityType](queue.md)|transactioncurrencyid|  
|TransactionCurrency_QueueItem|[queueitem EntityType](queueitem.md)|transactioncurrencyid|  
|transactioncurrency_quote|[quote EntityType](quote.md)|transactioncurrencyid|  
|transactioncurrency_quotedetail|[quotedetail EntityType](quotedetail.md)|transactioncurrencyid|  
|TransactionCurrency_ratingmodel|[ratingmodel EntityType](ratingmodel.md)|transactioncurrencyid|  
|TransactionCurrency_ratingvalue|[ratingvalue EntityType](ratingvalue.md)|transactioncurrencyid|  
|TransactionCurrency_recommendeddocument|[recommendeddocument EntityType](recommendeddocument.md)|transactioncurrencyidname|  
|TransactionCurrency_RecurringAppointmentMaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|transactioncurrencyid_recurringappointmentmaster|  
|TransactionCurrency_ReportCategory|[reportcategory EntityType](reportcategory.md)|transactioncurrencyid|  
|TransactionCurrency_SalesLiterature|[salesliterature EntityType](salesliterature.md)|transactioncurrencyid|  
|transactioncurrency_salesorder|[salesorder EntityType](salesorder.md)|transactioncurrencyid|  
|transactioncurrency_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|transactioncurrencyid|  
|transactioncurrency_semiannualfiscalcalendar|[semiannualfiscalcalendar EntityType](semiannualfiscalcalendar.md)|transactioncurrencyid|  
|TransactionCurrency_ServiceAppointment|[serviceappointment EntityType](serviceappointment.md)|transactioncurrencyid_serviceappointment|  
|TransactionCurrency_SharePointDocumentLocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|transactioncurrencyid|  
|TransactionCurrency_SharePointSite|[sharepointsite EntityType](sharepointsite.md)|transactioncurrencyid|  
|TransactionCurrency_SimilarityRule|[similarityrule EntityType](similarityrule.md)|transactioncurrencyid|  
|TransactionCurrency_SLA|[sla EntityType](sla.md)|transactioncurrencyid|  
|TransactionCurrency_SLAItem|[slaitem EntityType](slaitem.md)|transactioncurrencyid|  
|TransactionCurrency_slakpiinstance|[slakpiinstance EntityType](slakpiinstance.md)|transactioncurrencyid|  
|transactioncurrency_socialactivity|[socialactivity EntityType](socialactivity.md)|transactioncurrencyid_socialactivity|  
|transactioncurrency_SocialProfile|[socialprofile EntityType](socialprofile.md)|transactioncurrencyid|  
|TransactionCurrency_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_transactioncurrency_syncerror|  
|TransactionCurrency_SystemUser|[systemuser EntityType](systemuser.md)|transactioncurrencyid|  
|TransactionCurrency_Task|[task EntityType](task.md)|transactioncurrencyid_task|  
|TransactionCurrency_Team|[team EntityType](team.md)|transactioncurrencyid|  
|TransactionCurrency_Territory|[territory EntityType](territory.md)|transactioncurrencyid|  
|TransactionCurrency_Theme|[theme EntityType](theme.md)|transactioncurrencyid|  
|transactioncurrency_translationprocess|[translationprocess EntityType](translationprocess.md)|transactioncurrencyid|  
|transactioncurrency_usersettings|[usersettings EntityType](usersettings.md)|transactioncurrencyid|  

## Operations
The following operations can be used with the transactioncurrency entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveExchangeRate Function](../functions/retrieveexchangerate.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveexchangerate.md](../functions/descriptions/retrieveexchangerate.md)]|  

## Solutions
The following solutions include the transactioncurrency entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/transactioncurrency.md](./remarks/transactioncurrency.md)]

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