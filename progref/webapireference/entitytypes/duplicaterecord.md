---
title: "Microsoft Dynamics 365 Customer Engagement duplicaterecord EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a29c6379-e1d1-495e-9062-97d25604f27e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API duplicaterecord entitytype."
---
# duplicaterecord EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/duplicaterecord.md](./descriptions/duplicaterecord.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]duplicaterecords </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Duplicate Record</td></tr>
<tr><td><b>Primary Key:</b></td><td>duplicateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The duplicaterecord EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Description**: Date and time when the duplicate record was created.<br />Read-only<br />|
|duplicateid|Edm.Guid|**Description**: Unique identifier of the duplicate record.<br />|
|owningbusinessunit|Edm.Guid|**Display Name**: Owning Business Unit<br />**Description**: Unique identifier of the business unit that owns the duplicate record.<br />Read-only<br />|
|owninguser|Edm.Guid|**Display Name**: Owning User<br />**Description**: Unique identifier of the user who owns the duplicate record.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_asyncoperationid_value|asyncoperationid<br />|Unique identifier of the system job that created this record.|
|_baserecordid_value|baserecordid_lead<br />baserecordid_bookableresource<br />baserecordid_bookableresourcebooking<br />baserecordid_bookableresourcebookingheader<br />baserecordid_bookableresourcecategory<br />baserecordid_bookableresourcecategoryassn<br />baserecordid_bookableresourcecharacteristic<br />baserecordid_bookableresourcegroup<br />baserecordid_bookingstatus<br />baserecordid_characteristic<br />baserecordid_ratingmodel<br />baserecordid_ratingvalue<br />baserecordid_campaign<br />baserecordid_list<br />baserecordid_contract<br />baserecordid_equipment<br />baserecordid_incident<br />baserecordid_entitlement<br />baserecordid_entitlementchannel<br />baserecordid_entitlementtemplate<br />baserecordid_resourcegroup<br />baserecordid_service<br />baserecordid_opportunity<br />baserecordid_quote<br />baserecordid_competitor<br />baserecordid_territory<br />baserecordid_adx_contentsnippet<br />baserecordid_adx_pagetemplate<br />baserecordid_adx_sitemarker<br />baserecordid_adx_sitesetting<br />baserecordid_adx_webnotificationurl<br />baserecordid_adx_webrole<br />baserecordid_adx_website<br />baserecordid_adx_adplacement<br />baserecordid_adx_invitation<br />baserecordid_adx_pagenotification<br />baserecordid_adx_pagetag<br />baserecordid_adx_poll<br />baserecordid_adx_polloption<br />baserecordid_adx_pollplacement<br />baserecordid_adx_pollsubmission<br />baserecordid_adx_publishingstate<br />baserecordid_adx_publishingstatetransitionrule<br />baserecordid_adx_redirect<br />baserecordid_adx_shortcut<br />baserecordid_adx_tag<br />baserecordid_adx_webfilelog<br />baserecordid_adx_webpagelog<br />baserecordid_adx_websitebinding<br />baserecordid_adx_webnotificationentity<br />baserecordid_adx_webform<br />baserecordid_feedback<br />baserecordid_msdyn_actual<br />baserecordid_msdyn_bookingalertstatus<br />baserecordid_msdyn_bookingrule<br />baserecordid_msdyn_organizationalunit<br />baserecordid_msdyn_priority<br />baserecordid_msdyn_requirementcharacteristic<br />baserecordid_msdyn_requirementorganizationunit<br />baserecordid_msdyn_requirementresourcecategory<br />baserecordid_msdyn_requirementresourcepreference<br />baserecordid_msdyn_requirementstatus<br />baserecordid_msdyn_resourcerequirement<br />baserecordid_msdyn_resourcerequirementdetail<br />baserecordid_msdyn_resourceterritory<br />baserecordid_msdyn_scheduleboardsetting<br />baserecordid_msdyn_systemuserschedulersetting<br />baserecordid_msdyn_timegroup<br />baserecordid_msdyn_timegroupdetail<br />baserecordid_msdyn_transactionorigin<br />baserecordid_msdyn_workhourtemplate<br />baserecordid_msdyn_agreement<br />baserecordid_msdyn_agreementbookingdate<br />baserecordid_msdyn_agreementbookingincident<br />baserecordid_msdyn_agreementbookingproduct<br />baserecordid_msdyn_agreementbookingservice<br />baserecordid_msdyn_agreementbookingservicetask<br />baserecordid_msdyn_agreementbookingsetup<br />baserecordid_msdyn_agreementinvoicedate<br />baserecordid_msdyn_agreementinvoiceproduct<br />baserecordid_msdyn_agreementinvoicesetup<br />baserecordid_msdyn_agreementsubstatus<br />baserecordid_msdyn_bookingtimestamp<br />baserecordid_msdyn_customerasset<br />baserecordid_msdyn_fieldservicepricelistitem<br />baserecordid_msdyn_incidenttype<br />baserecordid_msdyn_incidenttypecharacteristic<br />baserecordid_msdyn_incidenttypeproduct<br />baserecordid_msdyn_incidenttypeservice<br />baserecordid_msdyn_incidenttypeservicetask<br />baserecordid_msdyn_inventoryadjustment<br />baserecordid_msdyn_inventoryadjustmentproduct<br />baserecordid_msdyn_inventoryjournal<br />baserecordid_msdyn_inventorytransfer<br />baserecordid_msdyn_orderinvoicingdate<br />baserecordid_msdyn_orderinvoicingproduct<br />baserecordid_msdyn_orderinvoicingsetup<br />baserecordid_msdyn_orderinvoicingsetupdate<br />baserecordid_msdyn_payment<br />baserecordid_msdyn_paymentdetail<br />baserecordid_msdyn_paymentmethod<br />baserecordid_msdyn_paymentterm<br />baserecordid_msdyn_postalcode<br />baserecordid_msdyn_productinventory<br />baserecordid_msdyn_purchaseorder<br />baserecordid_msdyn_purchaseorderbill<br />baserecordid_msdyn_purchaseorderreceipt<br />baserecordid_msdyn_purchaseorderreceiptproduct<br />baserecordid_msdyn_purchaseordersubstatus<br />baserecordid_msdyn_quotebookingincident<br />baserecordid_msdyn_quotebookingproduct<br />baserecordid_msdyn_quotebookingservice<br />baserecordid_msdyn_quotebookingservicetask<br />baserecordid_msdyn_quotebookingsetup<br />baserecordid_msdyn_quoteinvoicingproduct<br />baserecordid_msdyn_quoteinvoicingsetup<br />baserecordid_msdyn_rma<br />baserecordid_msdyn_rmareceipt<br />baserecordid_msdyn_rmareceiptproduct<br />baserecordid_msdyn_rmasubstatus<br />baserecordid_msdyn_rtv<br />baserecordid_msdyn_rtvproduct<br />baserecordid_msdyn_rtvsubstatus<br />baserecordid_msdyn_servicetasktype<br />baserecordid_msdyn_shipvia<br />baserecordid_msdyn_taxcode<br />baserecordid_msdyn_taxcodedetail<br />baserecordid_msdyn_timeoffrequest<br />baserecordid_msdyn_warehouse<br />baserecordid_msdyn_workorder<br />baserecordid_msdyn_workordercharacteristic<br />baserecordid_msdyn_workorderdetailsgenerationqueue<br />baserecordid_msdyn_workorderincident<br />baserecordid_msdyn_workorderresourcerestriction<br />baserecordid_msdyn_workorderservice<br />baserecordid_msdyn_workorderservicetask<br />baserecordid_msdyn_workordersubstatus<br />baserecordid_msdyn_workordertype<br />baserecordid_msdyn_glympseagent<br />baserecordid_msdyn_glympsesetting<br />baserecordid_msdyn_glympsetask<br />baserecordid_msdyn_iotdevice<br />baserecordid_msdyn_iotdevicecategory<br />baserecordid_msdyn_iotdevicecommand<br />baserecordid_msdyn_iotdeviceregistrationhistory<br />baserecordid_msdyn_accountpricelist<br />baserecordid_msdyn_batchjob<br />baserecordid_msdyn_characteristicreqforteammember<br />baserecordid_msdyn_contactpricelist<br />baserecordid_msdyn_contractlineinvoiceschedule<br />baserecordid_msdyn_contractlinescheduleofvalue<br />baserecordid_msdyn_dataexport<br />baserecordid_msdyn_delegation<br />baserecordid_msdyn_estimate<br />baserecordid_msdyn_estimateline<br />baserecordid_msdyn_expense<br />baserecordid_msdyn_expensecategory<br />baserecordid_msdyn_fact<br />baserecordid_msdyn_fieldcomputation<br />baserecordid_msdyn_findworkevent<br />baserecordid_msdyn_invoicefrequency<br />baserecordid_msdyn_invoicefrequencydetail<br />baserecordid_msdyn_invoicelinetransaction<br />baserecordid_msdyn_journal<br />baserecordid_msdyn_journalline<br />baserecordid_msdyn_opportunitylineresourcecategory<br />baserecordid_msdyn_opportunitylinetransaction<br />baserecordid_msdyn_opportunitylinetransactioncategory<br />baserecordid_msdyn_opportunitylinetransactionclassificatio<br />baserecordid_msdyn_opportunitypricelist<br />baserecordid_msdyn_orderlineresourcecategory<br />baserecordid_msdyn_orderlinetransaction<br />baserecordid_msdyn_orderlinetransactioncategory<br />baserecordid_msdyn_orderlinetransactionclassification<br />baserecordid_msdyn_orderpricelist<br />baserecordid_msdyn_processnotes<br />baserecordid_msdyn_project<br />baserecordid_msdyn_projectapproval<br />baserecordid_msdyn_projectparameter<br />baserecordid_msdyn_projectparameterpricelist<br />baserecordid_msdyn_projectpricelist<br />baserecordid_msdyn_projecttask<br />baserecordid_msdyn_projecttaskdependency<br />baserecordid_msdyn_projecttaskstatususer<br />baserecordid_msdyn_projectteam<br />baserecordid_msdyn_projectteammembersignup<br />baserecordid_msdyn_projecttransactioncategory<br />baserecordid_msdyn_quotelineanalyticsbreakdown<br />baserecordid_msdyn_quotelineinvoiceschedule<br />baserecordid_msdyn_quotelineresourcecategory<br />baserecordid_msdyn_quotelinescheduleofvalue<br />baserecordid_msdyn_quotelinetransaction<br />baserecordid_msdyn_quotelinetransactioncategory<br />baserecordid_msdyn_quotelinetransactionclassification<br />baserecordid_msdyn_quotepricelist<br />baserecordid_msdyn_resourceassignmentdetail<br />baserecordid_msdyn_resourcecategorypricelevel<br />baserecordid_msdyn_resourcerequest<br />baserecordid_msdyn_rolecompetencyrequirement<br />baserecordid_msdyn_roleutilization<br />baserecordid_msdyn_timeoffcalendar<br />baserecordid_msdyn_transactioncategory<br />baserecordid_msdyn_transactioncategoryclassification<br />baserecordid_msdyn_transactioncategoryhierarchyelement<br />baserecordid_msdyn_transactioncategorypricelevel<br />baserecordid_msdyn_transactionconnection<br />baserecordid_msdyn_transactiontype<br />baserecordid_msdyn_userworkhistory<br />baserecordid_msdyn_optimizationrequestbooking<br />baserecordid_msdyn_routingengineconfiguration<br />baserecordid_msdyn_routingjobconfiguration<br />baserecordid_msdyn_routingoptimizationrequest<br />baserecordid_msdyn_routingprofileconfiguration<br />baserecordid_msdyncrm_appointmentactivitymarketingtemplate<br />baserecordid_msdyncrm_campaigncustomchannelactivity<br />baserecordid_msdyncrm_contentsettings<br />baserecordid_msdyncrm_customerinsightsinfo<br />baserecordid_msdyncrm_customerjourneyiteration<br />baserecordid_msdyncrm_customerjourneyworkflowlink<br />baserecordid_msdyncrm_file<br />baserecordid_msdyncrm_keyword<br />baserecordid_msdyncrm_marketingconfiguration<br />baserecordid_msdyncrm_marketingdynamiccontentmetadata<br />baserecordid_msdyncrm_marketingemaildynamiccontentmetadata<br />baserecordid_msdyncrm_marketingemailtestsend<br />baserecordid_msdyncrm_marketingformfield<br />baserecordid_msdyncrm_mktactivity<br />baserecordid_msdyncrm_phonecallactivitymarketingtemplate<br />baserecordid_msdyncrm_taskactivitymarketingtemplate<br />baserecordid_msdyncrm_uicconfig<br />baserecordid_msdyncrm_leadscoremodel<br />baserecordid_msdyn_survey<br />baserecordid_msdyn_surveylog<br />baserecordid_msdyncrm_linkedinaccount<br />baserecordid_msdyncrm_linkedinactivity<br />baserecordid_msdyncrm_linkedincampaign<br />baserecordid_msdyncrm_linkedinconfiguration<br />baserecordid_msdyncrm_linkedinfieldmapping<br />baserecordid_msdyncrm_linkedinform<br />baserecordid_msdyncrm_linkedinformanswer<br />baserecordid_msdyncrm_linkedinformquestion<br />baserecordid_msdyncrm_linkedinformsubmission<br />baserecordid_msdyncrm_linkedinleadmatchingstrategy<br />baserecordid_msdyncrm_linkedinuserprofile<br />baserecordid_knowledgearticle<br />baserecordid_knowledgebaserecord<br />baserecordid_goalrollupquery<br />baserecordid_transactioncurrency<br />baserecordid_socialprofile<br />baserecordid_team<br />baserecordid_systemuser<br />baserecordid_account<br />baserecordid_sharepointdocumentlocation<br />baserecordid_publisher<br />baserecordid_sharepointsite<br />baserecordid_kbarticle<br />baserecordid_goal<br />baserecordid_contact<br />baserecordid_queue<br />baserecordid_emailserverprofile<br />|Unique identifier of the base record.|
|_duplicaterecordid_value|duplicaterecordid_lead<br />duplicaterecordid_bookableresource<br />duplicaterecordid_bookableresourcebooking<br />duplicaterecordid_bookableresourcebookingheader<br />duplicaterecordid_bookableresourcecategory<br />duplicaterecordid_bookableresourcecategoryassn<br />duplicaterecordid_bookableresourcecharacteristic<br />duplicaterecordid_bookableresourcegroup<br />duplicaterecordid_bookingstatus<br />duplicaterecordid_characteristic<br />duplicaterecordid_ratingmodel<br />duplicaterecordid_ratingvalue<br />duplicaterecordid_campaign<br />duplicaterecordid_list<br />duplicaterecordid_contract<br />duplicaterecordid_equipment<br />duplicaterecordid_incident<br />duplicaterecordid_entitlement<br />duplicaterecordid_entitlementchannel<br />duplicaterecordid_entitlementtemplate<br />duplicaterecordid_resourcegroup<br />duplicaterecordid_service<br />duplicaterecordid_opportunity<br />duplicaterecordid_quote<br />duplicaterecordid_competitor<br />duplicaterecordid_territory<br />duplicaterecordid_adx_contentsnippet<br />duplicaterecordid_adx_pagetemplate<br />duplicaterecordid_adx_sitemarker<br />duplicaterecordid_adx_sitesetting<br />duplicaterecordid_adx_webnotificationurl<br />duplicaterecordid_adx_webrole<br />duplicaterecordid_adx_website<br />duplicaterecordid_adx_adplacement<br />duplicaterecordid_adx_invitation<br />duplicaterecordid_adx_pagenotification<br />duplicaterecordid_adx_pagetag<br />duplicaterecordid_adx_poll<br />duplicaterecordid_adx_polloption<br />duplicaterecordid_adx_pollplacement<br />duplicaterecordid_adx_pollsubmission<br />duplicaterecordid_adx_publishingstate<br />duplicaterecordid_adx_publishingstatetransitionrule<br />duplicaterecordid_adx_redirect<br />duplicaterecordid_adx_shortcut<br />duplicaterecordid_adx_tag<br />duplicaterecordid_adx_webfilelog<br />duplicaterecordid_adx_webpagelog<br />duplicaterecordid_adx_websitebinding<br />duplicaterecordid_adx_webnotificationentity<br />duplicaterecordid_adx_webform<br />duplicaterecordid_feedback<br />duplicaterecordid_msdyn_actual<br />duplicaterecordid_msdyn_bookingalertstatus<br />duplicaterecordid_msdyn_bookingrule<br />duplicaterecordid_msdyn_organizationalunit<br />duplicaterecordid_msdyn_priority<br />duplicaterecordid_msdyn_requirementcharacteristic<br />duplicaterecordid_msdyn_requirementorganizationunit<br />duplicaterecordid_msdyn_requirementresourcecategory<br />duplicaterecordid_msdyn_requirementresourcepreference<br />duplicaterecordid_msdyn_requirementstatus<br />duplicaterecordid_msdyn_resourcerequirement<br />duplicaterecordid_msdyn_resourcerequirementdetail<br />duplicaterecordid_msdyn_resourceterritory<br />duplicaterecordid_msdyn_scheduleboardsetting<br />duplicaterecordid_msdyn_systemuserschedulersetting<br />duplicaterecordid_msdyn_timegroup<br />duplicaterecordid_msdyn_timegroupdetail<br />duplicaterecordid_msdyn_transactionorigin<br />duplicaterecordid_msdyn_workhourtemplate<br />duplicaterecordid_msdyn_agreement<br />duplicaterecordid_msdyn_agreementbookingdate<br />duplicaterecordid_msdyn_agreementbookingincident<br />duplicaterecordid_msdyn_agreementbookingproduct<br />duplicaterecordid_msdyn_agreementbookingservice<br />duplicaterecordid_msdyn_agreementbookingservicetask<br />duplicaterecordid_msdyn_agreementbookingsetup<br />duplicaterecordid_msdyn_agreementinvoicedate<br />duplicaterecordid_msdyn_agreementinvoiceproduct<br />duplicaterecordid_msdyn_agreementinvoicesetup<br />duplicaterecordid_msdyn_agreementsubstatus<br />duplicaterecordid_msdyn_bookingtimestamp<br />duplicaterecordid_msdyn_customerasset<br />duplicaterecordid_msdyn_fieldservicepricelistitem<br />duplicaterecordid_msdyn_incidenttype<br />duplicaterecordid_msdyn_incidenttypecharacteristic<br />duplicaterecordid_msdyn_incidenttypeproduct<br />duplicaterecordid_msdyn_incidenttypeservice<br />duplicaterecordid_msdyn_incidenttypeservicetask<br />duplicaterecordid_msdyn_inventoryadjustment<br />duplicaterecordid_msdyn_inventoryadjustmentproduct<br />duplicaterecordid_msdyn_inventoryjournal<br />duplicaterecordid_msdyn_inventorytransfer<br />duplicaterecordid_msdyn_orderinvoicingdate<br />duplicaterecordid_msdyn_orderinvoicingproduct<br />duplicaterecordid_msdyn_orderinvoicingsetup<br />duplicaterecordid_msdyn_orderinvoicingsetupdate<br />duplicaterecordid_msdyn_payment<br />duplicaterecordid_msdyn_paymentdetail<br />duplicaterecordid_msdyn_paymentmethod<br />duplicaterecordid_msdyn_paymentterm<br />duplicaterecordid_msdyn_postalcode<br />duplicaterecordid_msdyn_productinventory<br />duplicaterecordid_msdyn_purchaseorder<br />duplicaterecordid_msdyn_purchaseorderbill<br />duplicaterecordid_msdyn_purchaseorderreceipt<br />duplicaterecordid_msdyn_purchaseorderreceiptproduct<br />duplicaterecordid_msdyn_purchaseordersubstatus<br />duplicaterecordid_msdyn_quotebookingincident<br />duplicaterecordid_msdyn_quotebookingproduct<br />duplicaterecordid_msdyn_quotebookingservice<br />duplicaterecordid_msdyn_quotebookingservicetask<br />duplicaterecordid_msdyn_quotebookingsetup<br />duplicaterecordid_msdyn_quoteinvoicingproduct<br />duplicaterecordid_msdyn_quoteinvoicingsetup<br />duplicaterecordid_msdyn_rma<br />duplicaterecordid_msdyn_rmareceipt<br />duplicaterecordid_msdyn_rmareceiptproduct<br />duplicaterecordid_msdyn_rmasubstatus<br />duplicaterecordid_msdyn_rtv<br />duplicaterecordid_msdyn_rtvproduct<br />duplicaterecordid_msdyn_rtvsubstatus<br />duplicaterecordid_msdyn_servicetasktype<br />duplicaterecordid_msdyn_shipvia<br />duplicaterecordid_msdyn_taxcode<br />duplicaterecordid_msdyn_taxcodedetail<br />duplicaterecordid_msdyn_timeoffrequest<br />duplicaterecordid_msdyn_warehouse<br />duplicaterecordid_msdyn_workorder<br />duplicaterecordid_msdyn_workordercharacteristic<br />duplicaterecordid_msdyn_workorderdetailsgenerationqueue<br />duplicaterecordid_msdyn_workorderincident<br />duplicaterecordid_msdyn_workorderresourcerestriction<br />duplicaterecordid_msdyn_workorderservice<br />duplicaterecordid_msdyn_workorderservicetask<br />duplicaterecordid_msdyn_workordersubstatus<br />duplicaterecordid_msdyn_workordertype<br />duplicaterecordid_msdyn_glympseagent<br />duplicaterecordid_msdyn_glympsesetting<br />duplicaterecordid_msdyn_glympsetask<br />duplicaterecordid_msdyn_iotdevice<br />duplicaterecordid_msdyn_iotdevicecategory<br />duplicaterecordid_msdyn_iotdevicecommand<br />duplicaterecordid_msdyn_iotdeviceregistrationhistory<br />duplicaterecordid_msdyn_accountpricelist<br />duplicaterecordid_msdyn_batchjob<br />duplicaterecordid_msdyn_characteristicreqforteammember<br />duplicaterecordid_msdyn_contactpricelist<br />duplicaterecordid_msdyn_contractlineinvoiceschedule<br />duplicaterecordid_msdyn_contractlinescheduleofvalue<br />duplicaterecordid_msdyn_dataexport<br />duplicaterecordid_msdyn_delegation<br />duplicaterecordid_msdyn_estimate<br />duplicaterecordid_msdyn_estimateline<br />duplicaterecordid_msdyn_expense<br />duplicaterecordid_msdyn_expensecategory<br />duplicaterecordid_msdyn_fact<br />duplicaterecordid_msdyn_fieldcomputation<br />duplicaterecordid_msdyn_findworkevent<br />duplicaterecordid_msdyn_invoicefrequency<br />duplicaterecordid_msdyn_invoicefrequencydetail<br />duplicaterecordid_msdyn_invoicelinetransaction<br />duplicaterecordid_msdyn_journal<br />duplicaterecordid_msdyn_journalline<br />duplicaterecordid_msdyn_opportunitylineresourcecategory<br />duplicaterecordid_msdyn_opportunitylinetransaction<br />duplicaterecordid_msdyn_opportunitylinetransactioncategory<br />duplicaterecordid_msdyn_opportunitylinetransactionclassificatio<br />duplicaterecordid_msdyn_opportunitypricelist<br />duplicaterecordid_msdyn_orderlineresourcecategory<br />duplicaterecordid_msdyn_orderlinetransaction<br />duplicaterecordid_msdyn_orderlinetransactioncategory<br />duplicaterecordid_msdyn_orderlinetransactionclassification<br />duplicaterecordid_msdyn_orderpricelist<br />duplicaterecordid_msdyn_processnotes<br />duplicaterecordid_msdyn_project<br />duplicaterecordid_msdyn_projectapproval<br />duplicaterecordid_msdyn_projectparameter<br />duplicaterecordid_msdyn_projectparameterpricelist<br />duplicaterecordid_msdyn_projectpricelist<br />duplicaterecordid_msdyn_projecttask<br />duplicaterecordid_msdyn_projecttaskdependency<br />duplicaterecordid_msdyn_projecttaskstatususer<br />duplicaterecordid_msdyn_projectteam<br />duplicaterecordid_msdyn_projectteammembersignup<br />duplicaterecordid_msdyn_projecttransactioncategory<br />duplicaterecordid_msdyn_quotelineanalyticsbreakdown<br />duplicaterecordid_msdyn_quotelineinvoiceschedule<br />duplicaterecordid_msdyn_quotelineresourcecategory<br />duplicaterecordid_msdyn_quotelinescheduleofvalue<br />duplicaterecordid_msdyn_quotelinetransaction<br />duplicaterecordid_msdyn_quotelinetransactioncategory<br />duplicaterecordid_msdyn_quotelinetransactionclassification<br />duplicaterecordid_msdyn_quotepricelist<br />duplicaterecordid_msdyn_resourceassignmentdetail<br />duplicaterecordid_msdyn_resourcecategorypricelevel<br />duplicaterecordid_msdyn_resourcerequest<br />duplicaterecordid_msdyn_rolecompetencyrequirement<br />duplicaterecordid_msdyn_roleutilization<br />duplicaterecordid_msdyn_timeoffcalendar<br />duplicaterecordid_msdyn_transactioncategory<br />duplicaterecordid_msdyn_transactioncategoryclassification<br />duplicaterecordid_msdyn_transactioncategoryhierarchyelement<br />duplicaterecordid_msdyn_transactioncategorypricelevel<br />duplicaterecordid_msdyn_transactionconnection<br />duplicaterecordid_msdyn_transactiontype<br />duplicaterecordid_msdyn_userworkhistory<br />duplicaterecordid_msdyn_optimizationrequestbooking<br />duplicaterecordid_msdyn_routingengineconfiguration<br />duplicaterecordid_msdyn_routingjobconfiguration<br />duplicaterecordid_msdyn_routingoptimizationrequest<br />duplicaterecordid_msdyn_routingprofileconfiguration<br />duplicaterecordid_msdyncrm_appointmentactivitymarketingtemplate<br />duplicaterecordid_msdyncrm_campaigncustomchannelactivity<br />duplicaterecordid_msdyncrm_contentsettings<br />duplicaterecordid_msdyncrm_customerinsightsinfo<br />duplicaterecordid_msdyncrm_customerjourneyiteration<br />duplicaterecordid_msdyncrm_customerjourneyworkflowlink<br />duplicaterecordid_msdyncrm_file<br />duplicaterecordid_msdyncrm_keyword<br />duplicaterecordid_msdyncrm_marketingconfiguration<br />duplicaterecordid_msdyncrm_marketingdynamiccontentmetadata<br />duplicaterecordid_msdyncrm_marketingemaildynamiccontentmetadata<br />duplicaterecordid_msdyncrm_marketingemailtestsend<br />duplicaterecordid_msdyncrm_marketingformfield<br />duplicaterecordid_msdyncrm_mktactivity<br />duplicaterecordid_msdyncrm_phonecallactivitymarketingtemplate<br />duplicaterecordid_msdyncrm_taskactivitymarketingtemplate<br />duplicaterecordid_msdyncrm_uicconfig<br />duplicaterecordid_msdyncrm_leadscoremodel<br />duplicaterecordid_msdyn_survey<br />duplicaterecordid_msdyn_surveylog<br />duplicaterecordid_msdyncrm_linkedinaccount<br />duplicaterecordid_msdyncrm_linkedinactivity<br />duplicaterecordid_msdyncrm_linkedincampaign<br />duplicaterecordid_msdyncrm_linkedinconfiguration<br />duplicaterecordid_msdyncrm_linkedinfieldmapping<br />duplicaterecordid_msdyncrm_linkedinform<br />duplicaterecordid_msdyncrm_linkedinformanswer<br />duplicaterecordid_msdyncrm_linkedinformquestion<br />duplicaterecordid_msdyncrm_linkedinformsubmission<br />duplicaterecordid_msdyncrm_linkedinleadmatchingstrategy<br />duplicaterecordid_msdyncrm_linkedinuserprofile<br />duplicaterecordid_knowledgearticle<br />duplicaterecordid_knowledgebaserecord<br />duplicaterecordid_publisher<br />duplicaterecordid_goal<br />duplicaterecordid_transactioncurrency<br />duplicaterecordid_sharepointsite<br />duplicaterecordid_kbarticle<br />duplicaterecordid_team<br />duplicaterecordid_goalrollupquery<br />duplicaterecordid_contact<br />duplicaterecordid_systemuser<br />duplicaterecordid_sharepointdocumentlocation<br />duplicaterecordid_socialprofile<br />duplicaterecordid_account<br />duplicaterecordid_queue<br />duplicaterecordid_emailserverprofile<br />|Unique identifier of the potential duplicate record.|
|_duplicateruleid_value|duplicateruleid<br />|Unique identifier of the duplicate rule against which this duplicate was found.|
|_ownerid_value||Unique identifier of the user or team who owns the duplicate record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|asyncoperationid|[asyncoperation EntityType](asyncoperation.md)|AsyncOperation_DuplicateBaseRecord|
|baserecordid_account|[account EntityType](account.md)|Account_DuplicateBaseRecord|
|baserecordid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_DuplicateBaseRecord|
|baserecordid_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_DuplicateBaseRecord|
|baserecordid_adx_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|adx_contentsnippet_DuplicateBaseRecord|
|baserecordid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_DuplicateBaseRecord|
|baserecordid_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_DuplicateBaseRecord|
|baserecordid_adx_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|adx_pagenotification_DuplicateBaseRecord|
|baserecordid_adx_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|adx_pagetag_DuplicateBaseRecord|
|baserecordid_adx_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|adx_pagetemplate_DuplicateBaseRecord|
|baserecordid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_DuplicateBaseRecord|
|baserecordid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_DuplicateBaseRecord|
|baserecordid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_DuplicateBaseRecord|
|baserecordid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_DuplicateBaseRecord|
|baserecordid_adx_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_publishingstate_DuplicateBaseRecord|
|baserecordid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_DuplicateBaseRecord|
|baserecordid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_DuplicateBaseRecord|
|baserecordid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_DuplicateBaseRecord|
|baserecordid_adx_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|adx_sitemarker_DuplicateBaseRecord|
|baserecordid_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|adx_sitesetting_DuplicateBaseRecord|
|baserecordid_adx_tag|[adx_tag EntityType](adx_tag.md)|adx_tag_DuplicateBaseRecord|
|baserecordid_adx_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|adx_webfilelog_DuplicateBaseRecord|
|baserecordid_adx_webform|[adx_webform EntityType](adx_webform.md)|adx_webform_DuplicateBaseRecord|
|baserecordid_adx_webnotificationentity|[adx_webnotificationentity EntityType](adx_webnotificationentity.md)|adx_webnotificationentity_DuplicateBaseRecord|
|baserecordid_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|adx_webnotificationurl_DuplicateBaseRecord|
|baserecordid_adx_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|adx_webpagelog_DuplicateBaseRecord|
|baserecordid_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_webrole_DuplicateBaseRecord|
|baserecordid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_DuplicateBaseRecord|
|baserecordid_adx_websitebinding|[adx_websitebinding EntityType](adx_websitebinding.md)|adx_websitebinding_DuplicateBaseRecord|
|baserecordid_appointment|[appointment EntityType](appointment.md)|Appointment_DuplicateBaseRecord|
|baserecordid_bookableresource|[bookableresource EntityType](bookableresource.md)|bookableresource_DuplicateBaseRecord|
|baserecordid_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_DuplicateBaseRecord|
|baserecordid_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_DuplicateBaseRecord|
|baserecordid_bookableresourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|bookableresourcecategory_DuplicateBaseRecord|
|baserecordid_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|bookableresourcecategoryassn_DuplicateBaseRecord|
|baserecordid_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|bookableresourcecharacteristic_DuplicateBaseRecord|
|baserecordid_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|bookableresourcegroup_DuplicateBaseRecord|
|baserecordid_bookingstatus|[bookingstatus EntityType](bookingstatus.md)|bookingstatus_DuplicateBaseRecord|
|baserecordid_campaign|[campaign EntityType](campaign.md)|Campaign_DuplicateBaseRecord|
|baserecordid_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|CampaignResponse_DuplicateBaseRecord|
|baserecordid_characteristic|[characteristic EntityType](characteristic.md)|characteristic_DuplicateBaseRecord|
|baserecordid_competitor|[competitor EntityType](competitor.md)|Competitor_DuplicateBaseRecord|
|baserecordid_contact|[contact EntityType](contact.md)|Contact_DuplicateBaseRecord|
|baserecordid_contract|[contract EntityType](contract.md)|Contract_DuplicateBaseRecord|
|baserecordid_email|[email EntityType](email.md)|Email_DuplicateBaseRecord|
|baserecordid_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|emailserverprofile_duplicatebaserecord|
|baserecordid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_DuplicateBaseRecord|
|baserecordid_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|entitlementchannel_DuplicateBaseRecord|
|baserecordid_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_DuplicateBaseRecord|
|baserecordid_equipment|[equipment EntityType](equipment.md)|Equipment_DuplicateBaseRecord|
|baserecordid_fax|[fax EntityType](fax.md)|Fax_DuplicateBaseRecord|
|baserecordid_feedback|[feedback EntityType](feedback.md)|feedback_DuplicateBaseRecord|
|baserecordid_goal|[goal EntityType](goal.md)|Goal_DuplicateBaseRecord|
|baserecordid_goalrollupquery|[goalrollupquery EntityType](goalrollupquery.md)|GoalRollupQuery_DuplicateBaseRecord|
|baserecordid_incident|[incident EntityType](incident.md)|Incident_DuplicateBaseRecord|
|baserecordid_kbarticle|[kbarticle EntityType](kbarticle.md)|KbArticle_DuplicateBaseRecord|
|baserecordid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_DuplicateBaseRecord|
|baserecordid_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_DuplicateBaseRecord|
|baserecordid_lead|[lead EntityType](lead.md)|Lead_DuplicateBaseRecord|
|baserecordid_letter|[letter EntityType](letter.md)|Letter_DuplicateBaseRecord|
|baserecordid_list|[list EntityType](list.md)|List_DuplicateBaseRecord|
|baserecordid_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|msdyn_accountpricelist_DuplicateBaseRecord|
|baserecordid_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_actual_DuplicateBaseRecord|
|baserecordid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_DuplicateBaseRecord|
|baserecordid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_DuplicateBaseRecord|
|baserecordid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_DuplicateBaseRecord|
|baserecordid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_DuplicateBaseRecord|
|baserecordid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_DuplicateBaseRecord|
|baserecordid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_DuplicateBaseRecord|
|baserecordid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_DuplicateBaseRecord|
|baserecordid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_DuplicateBaseRecord|
|baserecordid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_DuplicateBaseRecord|
|baserecordid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_DuplicateBaseRecord|
|baserecordid_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|msdyn_agreementsubstatus_DuplicateBaseRecord|
|baserecordid_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_DuplicateBaseRecord|
|baserecordid_msdyn_batchjob|[msdyn_batchjob EntityType](msdyn_batchjob.md)|msdyn_batchjob_DuplicateBaseRecord|
|baserecordid_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_DuplicateBaseRecord|
|baserecordid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_DuplicateBaseRecord|
|baserecordid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_DuplicateBaseRecord|
|baserecordid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_DuplicateBaseRecord|
|baserecordid_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|msdyn_contactpricelist_DuplicateBaseRecord|
|baserecordid_msdyn_contractlineinvoiceschedule|[msdyn_contractlineinvoiceschedule EntityType](msdyn_contractlineinvoiceschedule.md)|msdyn_contractlineinvoiceschedule_DuplicateBaseRecord|
|baserecordid_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_contractlinescheduleofvalue_DuplicateBaseRecord|
|baserecordid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_DuplicateBaseRecord|
|baserecordid_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|msdyn_dataexport_DuplicateBaseRecord|
|baserecordid_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|msdyn_delegation_DuplicateBaseRecord|
|baserecordid_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|msdyn_estimate_DuplicateBaseRecord|
|baserecordid_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_estimateline_DuplicateBaseRecord|
|baserecordid_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_expense_DuplicateBaseRecord|
|baserecordid_msdyn_expensecategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_expensecategory_DuplicateBaseRecord|
|baserecordid_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_fact_DuplicateBaseRecord|
|baserecordid_msdyn_fieldcomputation|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|msdyn_fieldcomputation_DuplicateBaseRecord|
|baserecordid_msdyn_fieldservicepricelistitem|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|msdyn_fieldservicepricelistitem_DuplicateBaseRecord|
|baserecordid_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|msdyn_findworkevent_DuplicateBaseRecord|
|baserecordid_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_glympseagent_DuplicateBaseRecord|
|baserecordid_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|msdyn_glympsesetting_DuplicateBaseRecord|
|baserecordid_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_glympsetask_DuplicateBaseRecord|
|baserecordid_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_incidenttype_DuplicateBaseRecord|
|baserecordid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_DuplicateBaseRecord|
|baserecordid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_DuplicateBaseRecord|
|baserecordid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_DuplicateBaseRecord|
|baserecordid_msdyn_incidenttypeservicetask|[msdyn_incidenttypeservicetask EntityType](msdyn_incidenttypeservicetask.md)|msdyn_incidenttypeservicetask_DuplicateBaseRecord|
|baserecordid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_DuplicateBaseRecord|
|baserecordid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_DuplicateBaseRecord|
|baserecordid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_DuplicateBaseRecord|
|baserecordid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_DuplicateBaseRecord|
|baserecordid_msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|msdyn_invoicefrequency_DuplicateBaseRecord|
|baserecordid_msdyn_invoicefrequencydetail|[msdyn_invoicefrequencydetail EntityType](msdyn_invoicefrequencydetail.md)|msdyn_invoicefrequencydetail_DuplicateBaseRecord|
|baserecordid_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_invoicelinetransaction_DuplicateBaseRecord|
|baserecordid_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_iotdevice_DuplicateBaseRecord|
|baserecordid_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_iotdevicecategory_DuplicateBaseRecord|
|baserecordid_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_iotdevicecommand_DuplicateBaseRecord|
|baserecordid_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord|
|baserecordid_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|msdyn_journal_DuplicateBaseRecord|
|baserecordid_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_journalline_DuplicateBaseRecord|
|baserecordid_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|msdyn_opportunitylineresourcecategory_DuplicateBaseRecord|
|baserecordid_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_opportunitylinetransaction_DuplicateBaseRecord|
|baserecordid_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|msdyn_opportunitylinetransactioncategory_DuplicateBaseRecord|
|baserecordid_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|msdyn_opportunitylinetransactionclassificatio_DuplicateBaseRecord|
|baserecordid_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|msdyn_opportunitypricelist_DuplicateBaseRecord|
|baserecordid_msdyn_optimizationrequestbooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|msdyn_optimizationrequestbooking_DuplicateBaseRecord|
|baserecordid_msdyn_orderinvoicingdate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|msdyn_orderinvoicingdate_DuplicateBaseRecord|
|baserecordid_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|msdyn_orderinvoicingproduct_DuplicateBaseRecord|
|baserecordid_msdyn_orderinvoicingsetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|msdyn_orderinvoicingsetup_DuplicateBaseRecord|
|baserecordid_msdyn_orderinvoicingsetupdate|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|msdyn_orderinvoicingsetupdate_DuplicateBaseRecord|
|baserecordid_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|msdyn_orderlineresourcecategory_DuplicateBaseRecord|
|baserecordid_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_orderlinetransaction_DuplicateBaseRecord|
|baserecordid_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|msdyn_orderlinetransactioncategory_DuplicateBaseRecord|
|baserecordid_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|msdyn_orderlinetransactionclassification_DuplicateBaseRecord|
|baserecordid_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|msdyn_orderpricelist_DuplicateBaseRecord|
|baserecordid_msdyn_organizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_DuplicateBaseRecord|
|baserecordid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_DuplicateBaseRecord|
|baserecordid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_DuplicateBaseRecord|
|baserecordid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_DuplicateBaseRecord|
|baserecordid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_DuplicateBaseRecord|
|baserecordid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_DuplicateBaseRecord|
|baserecordid_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_priority_DuplicateBaseRecord|
|baserecordid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_DuplicateBaseRecord|
|baserecordid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_DuplicateBaseRecord|
|baserecordid_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_DuplicateBaseRecord|
|baserecordid_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_projectapproval_DuplicateBaseRecord|
|baserecordid_msdyn_projectparameter|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_projectparameter_DuplicateBaseRecord|
|baserecordid_msdyn_projectparameterpricelist|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|msdyn_projectparameterpricelist_DuplicateBaseRecord|
|baserecordid_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|msdyn_projectpricelist_DuplicateBaseRecord|
|baserecordid_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_projecttask_DuplicateBaseRecord|
|baserecordid_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_projecttaskdependency_DuplicateBaseRecord|
|baserecordid_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|msdyn_projecttaskstatususer_DuplicateBaseRecord|
|baserecordid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_DuplicateBaseRecord|
|baserecordid_msdyn_projectteammembersignup|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|msdyn_projectteammembersignup_DuplicateBaseRecord|
|baserecordid_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|msdyn_projecttransactioncategory_DuplicateBaseRecord|
|baserecordid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_DuplicateBaseRecord|
|baserecordid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_DuplicateBaseRecord|
|baserecordid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_DuplicateBaseRecord|
|baserecordid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord|
|baserecordid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_DuplicateBaseRecord|
|baserecordid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_DuplicateBaseRecord|
|baserecordid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_DuplicateBaseRecord|
|baserecordid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_DuplicateBaseRecord|
|baserecordid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_DuplicateBaseRecord|
|baserecordid_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|msdyn_quotebookingsetup_DuplicateBaseRecord|
|baserecordid_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|msdyn_quoteinvoicingproduct_DuplicateBaseRecord|
|baserecordid_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|msdyn_quoteinvoicingsetup_DuplicateBaseRecord|
|baserecordid_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord|
|baserecordid_msdyn_quotelineinvoiceschedule|[msdyn_quotelineinvoiceschedule EntityType](msdyn_quotelineinvoiceschedule.md)|msdyn_quotelineinvoiceschedule_DuplicateBaseRecord|
|baserecordid_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|msdyn_quotelineresourcecategory_DuplicateBaseRecord|
|baserecordid_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|msdyn_quotelinescheduleofvalue_DuplicateBaseRecord|
|baserecordid_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_quotelinetransaction_DuplicateBaseRecord|
|baserecordid_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|msdyn_quotelinetransactioncategory_DuplicateBaseRecord|
|baserecordid_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|msdyn_quotelinetransactionclassification_DuplicateBaseRecord|
|baserecordid_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|msdyn_quotepricelist_DuplicateBaseRecord|
|baserecordid_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|msdyn_requirementcharacteristic_DuplicateBaseRecord|
|baserecordid_msdyn_requirementorganizationunit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|msdyn_requirementorganizationunit_DuplicateBaseRecord|
|baserecordid_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|msdyn_requirementresourcecategory_DuplicateBaseRecord|
|baserecordid_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_requirementresourcepreference_DuplicateBaseRecord|
|baserecordid_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_requirementstatus_DuplicateBaseRecord|
|baserecordid_msdyn_resourceassignmentdetail|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|msdyn_resourceassignmentdetail_DuplicateBaseRecord|
|baserecordid_msdyn_resourcecategorypricelevel|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_resourcecategorypricelevel_DuplicateBaseRecord|
|baserecordid_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_resourcerequest_DuplicateBaseRecord|
|baserecordid_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_DuplicateBaseRecord|
|baserecordid_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|msdyn_resourcerequirementdetail_DuplicateBaseRecord|
|baserecordid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_DuplicateBaseRecord|
|baserecordid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_DuplicateBaseRecord|
|baserecordid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_DuplicateBaseRecord|
|baserecordid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_DuplicateBaseRecord|
|baserecordid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_DuplicateBaseRecord|
|baserecordid_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|msdyn_rolecompetencyrequirement_DuplicateBaseRecord|
|baserecordid_msdyn_roleutilization|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|msdyn_roleutilization_DuplicateBaseRecord|
|baserecordid_msdyn_routingengineconfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|msdyn_routingengineconfiguration_DuplicateBaseRecord|
|baserecordid_msdyn_routingjobconfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|msdyn_routingjobconfiguration_DuplicateBaseRecord|
|baserecordid_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_routingoptimizationrequest_DuplicateBaseRecord|
|baserecordid_msdyn_routingprofileconfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|msdyn_routingprofileconfiguration_DuplicateBaseRecord|
|baserecordid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_DuplicateBaseRecord|
|baserecordid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_DuplicateBaseRecord|
|baserecordid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_DuplicateBaseRecord|
|baserecordid_msdyn_scheduleboardsetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|msdyn_scheduleboardsetting_DuplicateBaseRecord|
|baserecordid_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|msdyn_servicetasktype_DuplicateBaseRecord|
|baserecordid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_DuplicateBaseRecord|
|baserecordid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_DuplicateBaseRecord|
|baserecordid_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|msdyn_surveylog_DuplicateBaseRecord|
|baserecordid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_DuplicateBaseRecord|
|baserecordid_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_taxcode_DuplicateBaseRecord|
|baserecordid_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|msdyn_taxcodedetail_DuplicateBaseRecord|
|baserecordid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_DuplicateBaseRecord|
|baserecordid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_DuplicateBaseRecord|
|baserecordid_msdyn_timeoffcalendar|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|msdyn_timeoffcalendar_DuplicateBaseRecord|
|baserecordid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_DuplicateBaseRecord|
|baserecordid_msdyn_transactioncategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_transactioncategory_DuplicateBaseRecord|
|baserecordid_msdyn_transactioncategoryclassification|[msdyn_transactioncategoryclassification EntityType](msdyn_transactioncategoryclassification.md)|msdyn_transactioncategoryclassification_DuplicateBaseRecord|
|baserecordid_msdyn_transactioncategoryhierarchyelement|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|msdyn_transactioncategoryhierarchyelement_DuplicateBaseRecord|
|baserecordid_msdyn_transactioncategorypricelevel|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_transactioncategorypricelevel_DuplicateBaseRecord|
|baserecordid_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|msdyn_transactionconnection_DuplicateBaseRecord|
|baserecordid_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|msdyn_transactionorigin_DuplicateBaseRecord|
|baserecordid_msdyn_transactiontype|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|msdyn_transactiontype_DuplicateBaseRecord|
|baserecordid_msdyn_userworkhistory|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|msdyn_userworkhistory_DuplicateBaseRecord|
|baserecordid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_DuplicateBaseRecord|
|baserecordid_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_workhourtemplate_DuplicateBaseRecord|
|baserecordid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_DuplicateBaseRecord|
|baserecordid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_DuplicateBaseRecord|
|baserecordid_msdyn_workorderdetailsgenerationqueue|[msdyn_workorderdetailsgenerationqueue EntityType](msdyn_workorderdetailsgenerationqueue.md)|msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord|
|baserecordid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_DuplicateBaseRecord|
|baserecordid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_DuplicateBaseRecord|
|baserecordid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_DuplicateBaseRecord|
|baserecordid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_DuplicateBaseRecord|
|baserecordid_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|msdyn_workordersubstatus_DuplicateBaseRecord|
|baserecordid_msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_workordertype_DuplicateBaseRecord|
|baserecordid_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_DuplicateBaseRecord|
|baserecordid_msdyncrm_campaigncustomchannelactivity|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|msdyncrm_campaigncustomchannelactivity_DuplicateBaseRecord|
|baserecordid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_DuplicateBaseRecord|
|baserecordid_msdyncrm_customerinsightsinfo|[msdyncrm_customerinsightsinfo EntityType](msdyncrm_customerinsightsinfo.md)|msdyncrm_customerinsightsinfo_DuplicateBaseRecord|
|baserecordid_msdyncrm_customerjourneyiteration|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|msdyncrm_customerjourneyiteration_DuplicateBaseRecord|
|baserecordid_msdyncrm_customerjourneyworkflowlink|[msdyncrm_customerjourneyworkflowlink EntityType](msdyncrm_customerjourneyworkflowlink.md)|msdyncrm_customerjourneyworkflowlink_DuplicateBaseRecord|
|baserecordid_msdyncrm_file|[msdyncrm_file EntityType](msdyncrm_file.md)|msdyncrm_file_DuplicateBaseRecord|
|baserecordid_msdyncrm_keyword|[msdyncrm_keyword EntityType](msdyncrm_keyword.md)|msdyncrm_keyword_DuplicateBaseRecord|
|baserecordid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedincampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|msdyncrm_linkedincampaign_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinconfiguration|[msdyncrm_linkedinconfiguration EntityType](msdyncrm_linkedinconfiguration.md)|msdyncrm_linkedinconfiguration_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_DuplicateBaseRecord|
|baserecordid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_DuplicateBaseRecord|
|baserecordid_msdyncrm_marketingconfiguration|[msdyncrm_marketingconfiguration EntityType](msdyncrm_marketingconfiguration.md)|msdyncrm_marketingconfiguration_DuplicateBaseRecord|
|baserecordid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_DuplicateBaseRecord|
|baserecordid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_DuplicateBaseRecord|
|baserecordid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_DuplicateBaseRecord|
|baserecordid_msdyncrm_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|msdyncrm_marketingformfield_DuplicateBaseRecord|
|baserecordid_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_DuplicateBaseRecord|
|baserecordid_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_DuplicateBaseRecord|
|baserecordid_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_DuplicateBaseRecord|
|baserecordid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_DuplicateBaseRecord|
|baserecordid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_DuplicateBaseRecord|
|baserecordid_phonecall|[phonecall EntityType](phonecall.md)|PhoneCall_DuplicateBaseRecord|
|baserecordid_publisher|[publisher EntityType](publisher.md)|Publisher_DuplicateBaseRecord|
|baserecordid_queue|[queue EntityType](queue.md)|Queue_DuplicateBaseRecord|
|baserecordid_quote|[quote EntityType](quote.md)|Quote_DuplicateBaseRecord|
|baserecordid_ratingmodel|[ratingmodel EntityType](ratingmodel.md)|ratingmodel_DuplicateBaseRecord|
|baserecordid_ratingvalue|[ratingvalue EntityType](ratingvalue.md)|ratingvalue_DuplicateBaseRecord|
|baserecordid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|RecurringAppointmentMaster_DuplicateBaseRecord|
|baserecordid_resourcegroup|[resourcegroup EntityType](resourcegroup.md)|ResourceGroup_DuplicateBaseRecord|
|baserecordid_service|[service EntityType](service.md)|Service_DuplicateBaseRecord|
|baserecordid_sharepointdocumentlocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|SharePointDocumentLocation_DuplicateBaseRecord|
|baserecordid_sharepointsite|[sharepointsite EntityType](sharepointsite.md)|SharePointSite_DuplicateBaseRecord|
|baserecordid_socialactivity|[socialactivity EntityType](socialactivity.md)|SocialActivity_DuplicateBaseRecord|
|baserecordid_socialprofile|[socialprofile EntityType](socialprofile.md)|SocialProfile_DuplicateBaseRecord|
|baserecordid_systemuser|[systemuser EntityType](systemuser.md)|SystemUser_DuplicateBaseRecord|
|baserecordid_task|[task EntityType](task.md)|Task_DuplicateBaseRecord|
|baserecordid_team|[team EntityType](team.md)|Team_DuplicateBaseRecord|
|baserecordid_territory|[territory EntityType](territory.md)|Territory_DuplicateBaseRecord|
|baserecordid_transactioncurrency|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_DuplicateBaseRecord|
|duplicaterecordid_account|[account EntityType](account.md)|Account_DuplicateMatchingRecord|
|duplicaterecordid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_DuplicateMatchingRecord|
|duplicaterecordid_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_DuplicateMatchingRecord|
|duplicaterecordid_adx_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|adx_contentsnippet_DuplicateMatchingRecord|
|duplicaterecordid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_DuplicateMatchingRecord|
|duplicaterecordid_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_DuplicateMatchingRecord|
|duplicaterecordid_adx_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|adx_pagenotification_DuplicateMatchingRecord|
|duplicaterecordid_adx_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|adx_pagetag_DuplicateMatchingRecord|
|duplicaterecordid_adx_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|adx_pagetemplate_DuplicateMatchingRecord|
|duplicaterecordid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_DuplicateMatchingRecord|
|duplicaterecordid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_DuplicateMatchingRecord|
|duplicaterecordid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_DuplicateMatchingRecord|
|duplicaterecordid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_DuplicateMatchingRecord|
|duplicaterecordid_adx_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_publishingstate_DuplicateMatchingRecord|
|duplicaterecordid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_DuplicateMatchingRecord|
|duplicaterecordid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_DuplicateMatchingRecord|
|duplicaterecordid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_DuplicateMatchingRecord|
|duplicaterecordid_adx_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|adx_sitemarker_DuplicateMatchingRecord|
|duplicaterecordid_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|adx_sitesetting_DuplicateMatchingRecord|
|duplicaterecordid_adx_tag|[adx_tag EntityType](adx_tag.md)|adx_tag_DuplicateMatchingRecord|
|duplicaterecordid_adx_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|adx_webfilelog_DuplicateMatchingRecord|
|duplicaterecordid_adx_webform|[adx_webform EntityType](adx_webform.md)|adx_webform_DuplicateMatchingRecord|
|duplicaterecordid_adx_webnotificationentity|[adx_webnotificationentity EntityType](adx_webnotificationentity.md)|adx_webnotificationentity_DuplicateMatchingRecord|
|duplicaterecordid_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|adx_webnotificationurl_DuplicateMatchingRecord|
|duplicaterecordid_adx_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|adx_webpagelog_DuplicateMatchingRecord|
|duplicaterecordid_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_webrole_DuplicateMatchingRecord|
|duplicaterecordid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_DuplicateMatchingRecord|
|duplicaterecordid_adx_websitebinding|[adx_websitebinding EntityType](adx_websitebinding.md)|adx_websitebinding_DuplicateMatchingRecord|
|duplicaterecordid_appointment|[appointment EntityType](appointment.md)|Appointment_DuplicateMatchingRecord|
|duplicaterecordid_bookableresource|[bookableresource EntityType](bookableresource.md)|bookableresource_DuplicateMatchingRecord|
|duplicaterecordid_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_DuplicateMatchingRecord|
|duplicaterecordid_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_DuplicateMatchingRecord|
|duplicaterecordid_bookableresourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|bookableresourcecategory_DuplicateMatchingRecord|
|duplicaterecordid_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|bookableresourcecategoryassn_DuplicateMatchingRecord|
|duplicaterecordid_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|bookableresourcecharacteristic_DuplicateMatchingRecord|
|duplicaterecordid_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|bookableresourcegroup_DuplicateMatchingRecord|
|duplicaterecordid_bookingstatus|[bookingstatus EntityType](bookingstatus.md)|bookingstatus_DuplicateMatchingRecord|
|duplicaterecordid_campaign|[campaign EntityType](campaign.md)|Campaign_DuplicateMatchingRecord|
|duplicaterecordid_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|CampaignResponse_DuplicateMatchingRecord|
|duplicaterecordid_characteristic|[characteristic EntityType](characteristic.md)|characteristic_DuplicateMatchingRecord|
|duplicaterecordid_competitor|[competitor EntityType](competitor.md)|Competitor_DuplicateMatchingRecord|
|duplicaterecordid_contact|[contact EntityType](contact.md)|Contact_DuplicateMatchingRecord|
|duplicaterecordid_contract|[contract EntityType](contract.md)|Contract_DuplicateMatchingRecord|
|duplicaterecordid_email|[email EntityType](email.md)|Email_DuplicateMatchingRecord|
|duplicaterecordid_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|emailserverprofile_duplicatematchingrecord|
|duplicaterecordid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_DuplicateMatchingRecord|
|duplicaterecordid_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|entitlementchannel_DuplicateMatchingRecord|
|duplicaterecordid_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_DuplicateMatchingRecord|
|duplicaterecordid_equipment|[equipment EntityType](equipment.md)|Equipment_DuplicateMatchingRecord|
|duplicaterecordid_fax|[fax EntityType](fax.md)|Fax_DuplicateMatchingRecord|
|duplicaterecordid_feedback|[feedback EntityType](feedback.md)|feedback_DuplicateMatchingRecord|
|duplicaterecordid_goal|[goal EntityType](goal.md)|Goal_DuplicateMatchingRecord|
|duplicaterecordid_goalrollupquery|[goalrollupquery EntityType](goalrollupquery.md)|GoalRollupQuery_DuplicateMatchingRecord|
|duplicaterecordid_incident|[incident EntityType](incident.md)|Incident_DuplicateMatchingRecord|
|duplicaterecordid_kbarticle|[kbarticle EntityType](kbarticle.md)|KbArticle_DuplicateMatchingRecord|
|duplicaterecordid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_DuplicateMatchingRecord|
|duplicaterecordid_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_DuplicateMatchingRecord|
|duplicaterecordid_lead|[lead EntityType](lead.md)|Lead_DuplicateMatchingRecord|
|duplicaterecordid_letter|[letter EntityType](letter.md)|Letter_DuplicateMatchingRecord|
|duplicaterecordid_list|[list EntityType](list.md)|List_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|msdyn_accountpricelist_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_actual_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|msdyn_agreementsubstatus_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_batchjob|[msdyn_batchjob EntityType](msdyn_batchjob.md)|msdyn_batchjob_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|msdyn_contactpricelist_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_contractlineinvoiceschedule|[msdyn_contractlineinvoiceschedule EntityType](msdyn_contractlineinvoiceschedule.md)|msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|msdyn_dataexport_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|msdyn_delegation_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|msdyn_estimate_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_estimateline_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_expense_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_expensecategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_expensecategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_fact_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_fieldcomputation|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|msdyn_fieldcomputation_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_fieldservicepricelistitem|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|msdyn_fieldservicepricelistitem_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|msdyn_findworkevent_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_glympseagent_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|msdyn_glympsesetting_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_glympsetask_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_incidenttype_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_incidenttypeservicetask|[msdyn_incidenttypeservicetask EntityType](msdyn_incidenttypeservicetask.md)|msdyn_incidenttypeservicetask_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|msdyn_invoicefrequency_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_invoicefrequencydetail|[msdyn_invoicefrequencydetail EntityType](msdyn_invoicefrequencydetail.md)|msdyn_invoicefrequencydetail_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_invoicelinetransaction_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_iotdevice_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_iotdevicecategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_iotdevicecommand_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|msdyn_journal_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_journalline_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|msdyn_opportunitylineresourcecategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_opportunitylinetransaction_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|msdyn_opportunitylinetransactioncategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|msdyn_opportunitylinetransactionclassificatio_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|msdyn_opportunitypricelist_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_optimizationrequestbooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|msdyn_optimizationrequestbooking_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderinvoicingdate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|msdyn_orderinvoicingdate_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|msdyn_orderinvoicingproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderinvoicingsetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|msdyn_orderinvoicingsetup_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderinvoicingsetupdate|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|msdyn_orderlineresourcecategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_orderlinetransaction_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|msdyn_orderlinetransactioncategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|msdyn_orderlinetransactionclassification_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|msdyn_orderpricelist_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_organizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_priority_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_projectapproval_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projectparameter|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_projectparameter_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projectparameterpricelist|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|msdyn_projectparameterpricelist_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|msdyn_projectpricelist_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_projecttask_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_projecttaskdependency_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|msdyn_projecttaskstatususer_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projectteammembersignup|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|msdyn_projectteammembersignup_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|msdyn_projecttransactioncategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|msdyn_quotebookingsetup_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|msdyn_quoteinvoicingproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|msdyn_quoteinvoicingsetup_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotelineinvoiceschedule|[msdyn_quotelineinvoiceschedule EntityType](msdyn_quotelineinvoiceschedule.md)|msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|msdyn_quotelineresourcecategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_quotelinetransaction_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|msdyn_quotelinetransactioncategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|msdyn_quotelinetransactionclassification_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|msdyn_quotepricelist_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|msdyn_requirementcharacteristic_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_requirementorganizationunit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|msdyn_requirementorganizationunit_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|msdyn_requirementresourcecategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_requirementresourcepreference_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_requirementstatus_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_resourceassignmentdetail|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|msdyn_resourceassignmentdetail_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_resourcecategorypricelevel|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_resourcecategorypricelevel_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_resourcerequest_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|msdyn_resourcerequirementdetail_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|msdyn_rolecompetencyrequirement_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_roleutilization|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|msdyn_roleutilization_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_routingengineconfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|msdyn_routingengineconfiguration_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_routingjobconfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|msdyn_routingjobconfiguration_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_routingoptimizationrequest_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_routingprofileconfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|msdyn_routingprofileconfiguration_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_scheduleboardsetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|msdyn_scheduleboardsetting_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|msdyn_servicetasktype_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|msdyn_surveylog_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_taxcode_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|msdyn_taxcodedetail_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_timeoffcalendar|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|msdyn_timeoffcalendar_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_transactioncategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_transactioncategory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_transactioncategoryclassification|[msdyn_transactioncategoryclassification EntityType](msdyn_transactioncategoryclassification.md)|msdyn_transactioncategoryclassification_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_transactioncategoryhierarchyelement|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|msdyn_transactioncategoryhierarchyelement_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_transactioncategorypricelevel|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_transactioncategorypricelevel_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|msdyn_transactionconnection_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|msdyn_transactionorigin_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_transactiontype|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|msdyn_transactiontype_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_userworkhistory|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|msdyn_userworkhistory_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_workhourtemplate_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workorderdetailsgenerationqueue|[msdyn_workorderdetailsgenerationqueue EntityType](msdyn_workorderdetailsgenerationqueue.md)|msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|msdyn_workordersubstatus_DuplicateMatchingRecord|
|duplicaterecordid_msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_workordertype_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_campaigncustomchannelactivity|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|msdyncrm_campaigncustomchannelactivity_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_customerinsightsinfo|[msdyncrm_customerinsightsinfo EntityType](msdyncrm_customerinsightsinfo.md)|msdyncrm_customerinsightsinfo_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_customerjourneyiteration|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|msdyncrm_customerjourneyiteration_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_customerjourneyworkflowlink|[msdyncrm_customerjourneyworkflowlink EntityType](msdyncrm_customerjourneyworkflowlink.md)|msdyncrm_customerjourneyworkflowlink_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_file|[msdyncrm_file EntityType](msdyncrm_file.md)|msdyncrm_file_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_keyword|[msdyncrm_keyword EntityType](msdyncrm_keyword.md)|msdyncrm_keyword_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedincampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|msdyncrm_linkedincampaign_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinconfiguration|[msdyncrm_linkedinconfiguration EntityType](msdyncrm_linkedinconfiguration.md)|msdyncrm_linkedinconfiguration_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_marketingconfiguration|[msdyncrm_marketingconfiguration EntityType](msdyncrm_marketingconfiguration.md)|msdyncrm_marketingconfiguration_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|msdyncrm_marketingformfield_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_DuplicateMatchingRecord|
|duplicaterecordid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_DuplicateMatchingRecord|
|duplicaterecordid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_DuplicateMatchingRecord|
|duplicaterecordid_phonecall|[phonecall EntityType](phonecall.md)|PhoneCall_DuplicateMatchingRecord|
|duplicaterecordid_publisher|[publisher EntityType](publisher.md)|Publisher_DuplicateMatchingRecord|
|duplicaterecordid_queue|[queue EntityType](queue.md)|Queue_DuplicateMatchingRecord|
|duplicaterecordid_quote|[quote EntityType](quote.md)|Quote_DuplicateMatchingRecord|
|duplicaterecordid_ratingmodel|[ratingmodel EntityType](ratingmodel.md)|ratingmodel_DuplicateMatchingRecord|
|duplicaterecordid_ratingvalue|[ratingvalue EntityType](ratingvalue.md)|ratingvalue_DuplicateMatchingRecord|
|duplicaterecordid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|RecurringAppointmentMaster_DuplicateMatchingRecord|
|duplicaterecordid_resourcegroup|[resourcegroup EntityType](resourcegroup.md)|ResourceGroup_DuplicateMatchingRecord|
|duplicaterecordid_service|[service EntityType](service.md)|Service_DuplicateMatchingRecord|
|duplicaterecordid_sharepointdocumentlocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|SharePointDocumentLocation_DuplicateMatchingRecord|
|duplicaterecordid_sharepointsite|[sharepointsite EntityType](sharepointsite.md)|SharePointSite_DuplicateMatchingRecord|
|duplicaterecordid_socialactivity|[socialactivity EntityType](socialactivity.md)|SocialActivity_DuplicateMatchingRecord|
|duplicaterecordid_socialprofile|[socialprofile EntityType](socialprofile.md)|SocialProfile_DuplicateMatchingRecord|
|duplicaterecordid_systemuser|[systemuser EntityType](systemuser.md)|SystemUser_DuplicateMatchingRecord|
|duplicaterecordid_task|[task EntityType](task.md)|Task_DuplicateMatchingRecord|
|duplicaterecordid_team|[team EntityType](team.md)|Team_DuplicateMatchingRecord|
|duplicaterecordid_territory|[territory EntityType](territory.md)|Territory_DuplicateMatchingRecord|
|duplicaterecordid_transactioncurrency|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_DuplicateMatchingRecord|
|duplicateruleid|[duplicaterule EntityType](duplicaterule.md)|DuplicateRule_DuplicateBaseRecord|  

[!INCLUDE[./remarks/duplicaterecord.md](./remarks/duplicaterecord.md)]

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