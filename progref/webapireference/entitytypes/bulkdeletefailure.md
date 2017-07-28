---
title: "Microsoft Dynamics 365 Customer Engagement bulkdeletefailure EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 190d387a-f97a-4d9d-ab6a-0b72a7ede0cb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bulkdeletefailure entitytype."
---
# bulkdeletefailure EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bulkdeletefailure.md](./descriptions/bulkdeletefailure.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]bulkdeletefailures </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bulk Delete Failure</td></tr>
<tr><td><b>Primary Key:</b></td><td>bulkdeletefailureid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The bulkdeletefailure EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bulkdeletefailureid|Edm.Guid|**Display Name**: Bulk Deletion Failure<br />**Description**: Unique identifier of the bulk deletion failure record.<br />Read-only<br />|
|errordescription|Edm.String|**Display Name**: Error Description<br />**Description**: Description of the error.<br />Read-only<br />|
|errornumber|Edm.Int32|**Display Name**: Error Code<br />**Description**: Error code for the failed bulk deletion.<br />Read-only<br />|
|orderedqueryindex|Edm.Int32|**Display Name**: Index<br />**Description**: Index of the ordered query expression that retrieved this record.<br />Read-only<br />|
|owningbusinessunit|Edm.Guid|**Display Name**: Owning Business Unit<br />**Description**: Unique identifier of the business unit that owns the bulk deletion failure.<br />Read-only<br />|
|owninguser|Edm.Guid|**Display Name**: Owning User<br />**Description**: Unique identifier of the user who owns the bulk deletion failure record.
<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_asyncoperationid_value||Unique identifier of the system job that created this record.|
|_bulkdeleteoperationid_value|bulkdeleteoperationid<br />|Unique identifier of the bulk operation job which created this record|
|_ownerid_value||Unique identifier of the user or team who owns the bulk operation log.|
|_regardingobjectid_value|regardingobjectid_territory<br />regardingobjectid_leadaddress<br />regardingobjectid_leadcompetitors<br />regardingobjectid_lead<br />regardingobjectid_dynamicproperty<br />regardingobjectid_dynamicpropertyassociation<br />regardingobjectid_dynamicpropertyinstance<br />regardingobjectid_dynamicpropertyoptionsetitem<br />regardingobjectid_pricelevel<br />regardingobjectid_product<br />regardingobjectid_productassociation<br />regardingobjectid_productpricelevel<br />regardingobjectid_productsubstitute<br />regardingobjectid_uom<br />regardingobjectid_uomschedule<br />regardingobjectid_bookableresource<br />regardingobjectid_bookableresourcebooking<br />regardingobjectid_bookableresourcebookingheader<br />regardingobjectid_bookableresourcecategory<br />regardingobjectid_bookableresourcecategoryassn<br />regardingobjectid_bookableresourcecharacteristic<br />regardingobjectid_bookableresourcegroup<br />regardingobjectid_bookingstatus<br />regardingobjectid_characteristic<br />regardingobjectid_ratingmodel<br />regardingobjectid_ratingvalue<br />regardingobjectid_bulkoperationlog<br />regardingobjectid_campaign<br />regardingobjectid_campaignactivityitem<br />regardingobjectid_campaignitem<br />regardingobjectid_list<br />regardingobjectid_listmember<br />regardingobjectid_constraintbasedgroup<br />regardingobjectid_contract<br />regardingobjectid_contractdetail<br />regardingobjectid_contracttemplate<br />regardingobjectid_entitlement<br />regardingobjectid_entitlementchannel<br />regardingobjectid_entitlementtemplate<br />regardingobjectid_entitlementtemplatechannel<br />regardingobjectid_equipment<br />regardingobjectid_incident<br />regardingobjectid_knowledgearticleincident<br />regardingobjectid_phonetocaseprocess<br />regardingobjectid_resource<br />regardingobjectid_resourcegroup<br />regardingobjectid_resourcespec<br />regardingobjectid_service<br />regardingobjectid_site<br />regardingobjectid_competitoraddress<br />regardingobjectid_competitorproduct<br />regardingobjectid_competitorsalesliterature<br />regardingobjectid_contactinvoices<br />regardingobjectid_contactorders<br />regardingobjectid_contactquotes<br />regardingobjectid_discount<br />regardingobjectid_discounttype<br />regardingobjectid_invoice<br />regardingobjectid_invoicedetail<br />regardingobjectid_leadproduct<br />regardingobjectid_leadtoopportunitysalesprocess<br />regardingobjectid_opportunity<br />regardingobjectid_opportunitycompetitors<br />regardingobjectid_opportunityproduct<br />regardingobjectid_opportunitysalesprocess<br />regardingobjectid_productsalesliterature<br />regardingobjectid_quote<br />regardingobjectid_quotedetail<br />regardingobjectid_salesliterature<br />regardingobjectid_salesliteratureitem<br />regardingobjectid_salesorder<br />regardingobjectid_salesorderdetail<br />regardingobjectid_competitor<br />regardingobjectid_adx_contentsnippet<br />regardingobjectid_adx_pagetemplate<br />regardingobjectid_adx_sitemarker<br />regardingobjectid_adx_sitesetting<br />regardingobjectid_adx_webfile<br />regardingobjectid_adx_weblink<br />regardingobjectid_adx_weblinkset<br />regardingobjectid_adx_webnotificationurl<br />regardingobjectid_adx_webpage<br />regardingobjectid_adx_webrole<br />regardingobjectid_adx_website<br />regardingobjectid_adx_ad<br />regardingobjectid_adx_adplacement<br />regardingobjectid_adx_entitypermission<br />regardingobjectid_adx_invitation<br />regardingobjectid_adx_pagealert<br />regardingobjectid_adx_pagenotification<br />regardingobjectid_adx_pagetag<br />regardingobjectid_adx_poll<br />regardingobjectid_adx_polloption<br />regardingobjectid_adx_pollplacement<br />regardingobjectid_adx_pollsubmission<br />regardingobjectid_adx_portallanguage<br />regardingobjectid_adx_publishingstate<br />regardingobjectid_adx_publishingstatetransitionrule<br />regardingobjectid_adx_redirect<br />regardingobjectid_adx_setting<br />regardingobjectid_adx_shortcut<br />regardingobjectid_adx_tag<br />regardingobjectid_adx_urlhistory<br />regardingobjectid_adx_webfilelog<br />regardingobjectid_adx_webpageaccesscontrolrule<br />regardingobjectid_adx_webpagehistory<br />regardingobjectid_adx_webpagelog<br />regardingobjectid_adx_websiteaccess<br />regardingobjectid_adx_websitebinding<br />regardingobjectid_adx_websitelanguage<br />regardingobjectid_adx_webtemplate<br />regardingobjectid_adx_webnotificationentity<br />regardingobjectid_adx_externalidentity<br />regardingobjectid_adx_entityform<br />regardingobjectid_adx_entityformmetadata<br />regardingobjectid_adx_entitylist<br />regardingobjectid_adx_webform<br />regardingobjectid_adx_webformmetadata<br />regardingobjectid_adx_webformsession<br />regardingobjectid_adx_webformstep<br />regardingobjectid_msdyn_actual<br />regardingobjectid_msdyn_bookingalertstatus<br />regardingobjectid_msdyn_bookingchange<br />regardingobjectid_msdyn_bookingrule<br />regardingobjectid_msdyn_bookingsetupmetadata<br />regardingobjectid_msdyn_organizationalunit<br />regardingobjectid_msdyn_priority<br />regardingobjectid_msdyn_requirementcharacteristic<br />regardingobjectid_msdyn_requirementorganizationunit<br />regardingobjectid_msdyn_requirementresourcecategory<br />regardingobjectid_msdyn_requirementresourcepreference<br />regardingobjectid_msdyn_requirementstatus<br />regardingobjectid_msdyn_resourcerequirement<br />regardingobjectid_msdyn_resourcerequirementdetail<br />regardingobjectid_msdyn_resourceterritory<br />regardingobjectid_msdyn_scheduleboardsetting<br />regardingobjectid_msdyn_schedulingparameter<br />regardingobjectid_msdyn_systemuserschedulersetting<br />regardingobjectid_msdyn_timegroup<br />regardingobjectid_msdyn_timegroupdetail<br />regardingobjectid_msdyn_transactionorigin<br />regardingobjectid_msdyn_workhourtemplate<br />regardingobjectid_msdyn_agreement<br />regardingobjectid_msdyn_agreementbookingdate<br />regardingobjectid_msdyn_agreementbookingincident<br />regardingobjectid_msdyn_agreementbookingproduct<br />regardingobjectid_msdyn_agreementbookingservice<br />regardingobjectid_msdyn_agreementbookingservicetask<br />regardingobjectid_msdyn_agreementbookingsetup<br />regardingobjectid_msdyn_agreementinvoicedate<br />regardingobjectid_msdyn_agreementinvoiceproduct<br />regardingobjectid_msdyn_agreementinvoicesetup<br />regardingobjectid_msdyn_agreementsubstatus<br />regardingobjectid_msdyn_bookingjournal<br />regardingobjectid_msdyn_bookingtimestamp<br />regardingobjectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />regardingobjectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />regardingobjectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />regardingobjectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39<br />regardingobjectid_msdyn_customerasset<br />regardingobjectid_msdyn_fieldservicepricelistitem<br />regardingobjectid_msdyn_fieldservicesetting<br />regardingobjectid_msdyn_fieldservicesystemjob<br />regardingobjectid_msdyn_incidenttype<br />regardingobjectid_msdyn_incidenttypecharacteristic<br />regardingobjectid_msdyn_incidenttypeproduct<br />regardingobjectid_msdyn_incidenttypeservice<br />regardingobjectid_msdyn_incidenttypeservicetask<br />regardingobjectid_msdyn_inventoryadjustment<br />regardingobjectid_msdyn_inventoryadjustmentproduct<br />regardingobjectid_msdyn_inventoryjournal<br />regardingobjectid_msdyn_inventorytransfer<br />regardingobjectid_msdyn_orderinvoicingdate<br />regardingobjectid_msdyn_orderinvoicingproduct<br />regardingobjectid_msdyn_orderinvoicingsetup<br />regardingobjectid_msdyn_orderinvoicingsetupdate<br />regardingobjectid_msdyn_payment<br />regardingobjectid_msdyn_paymentdetail<br />regardingobjectid_msdyn_paymentmethod<br />regardingobjectid_msdyn_paymentterm<br />regardingobjectid_msdyn_postalcode<br />regardingobjectid_msdyn_productinventory<br />regardingobjectid_msdyn_purchaseorder<br />regardingobjectid_msdyn_purchaseorderbill<br />regardingobjectid_msdyn_purchaseorderproduct<br />regardingobjectid_msdyn_purchaseorderreceipt<br />regardingobjectid_msdyn_purchaseorderreceiptproduct<br />regardingobjectid_msdyn_purchaseordersubstatus<br />regardingobjectid_msdyn_quotebookingincident<br />regardingobjectid_msdyn_quotebookingproduct<br />regardingobjectid_msdyn_quotebookingservice<br />regardingobjectid_msdyn_quotebookingservicetask<br />regardingobjectid_msdyn_quotebookingsetup<br />regardingobjectid_msdyn_quoteinvoicingproduct<br />regardingobjectid_msdyn_quoteinvoicingsetup<br />regardingobjectid_msdyn_resourcepaytype<br />regardingobjectid_msdyn_rma<br />regardingobjectid_msdyn_rmaproduct<br />regardingobjectid_msdyn_rmareceipt<br />regardingobjectid_msdyn_rmareceiptproduct<br />regardingobjectid_msdyn_rmasubstatus<br />regardingobjectid_msdyn_rtv<br />regardingobjectid_msdyn_rtvproduct<br />regardingobjectid_msdyn_rtvsubstatus<br />regardingobjectid_msdyn_servicetasktype<br />regardingobjectid_msdyn_shipvia<br />regardingobjectid_msdyn_taxcode<br />regardingobjectid_msdyn_taxcodedetail<br />regardingobjectid_msdyn_timeoffrequest<br />regardingobjectid_msdyn_uniquenumber<br />regardingobjectid_msdyn_warehouse<br />regardingobjectid_msdyn_workorder<br />regardingobjectid_msdyn_workordercharacteristic<br />regardingobjectid_msdyn_workorderdetailsgenerationqueue<br />regardingobjectid_msdyn_workorderincident<br />regardingobjectid_msdyn_workorderproduct<br />regardingobjectid_msdyn_workorderresourcerestriction<br />regardingobjectid_msdyn_workorderservice<br />regardingobjectid_msdyn_workorderservicetask<br />regardingobjectid_msdyn_workordersubstatus<br />regardingobjectid_msdyn_workordertype<br />regardingobjectid_msdyn_glympseagent<br />regardingobjectid_msdyn_glympsesetting<br />regardingobjectid_msdyn_glympsetask<br />regardingobjectid_msdyn_iotalert<br />regardingobjectid_msdyn_iotdevice<br />regardingobjectid_msdyn_iotdevicecategory<br />regardingobjectid_msdyn_iotdevicecommand<br />regardingobjectid_msdyn_iotdeviceregistrationhistory<br />regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />regardingobjectid_msdyn_accountpricelist<br />regardingobjectid_msdyn_batchjob<br />regardingobjectid_msdyn_characteristicreqforteammember<br />regardingobjectid_msdyn_contactpricelist<br />regardingobjectid_msdyn_contractlineinvoiceschedule<br />regardingobjectid_msdyn_contractlinescheduleofvalue<br />regardingobjectid_msdyn_dataexport<br />regardingobjectid_msdyn_delegation<br />regardingobjectid_msdyn_estimate<br />regardingobjectid_msdyn_estimateline<br />regardingobjectid_msdyn_expense<br />regardingobjectid_msdyn_expensecategory<br />regardingobjectid_msdyn_expensereceipt<br />regardingobjectid_msdyn_fact<br />regardingobjectid_msdyn_fieldcomputation<br />regardingobjectid_msdyn_findworkevent<br />regardingobjectid_msdyn_integrationjob<br />regardingobjectid_msdyn_integrationjobdetail<br />regardingobjectid_msdyn_invoicefrequency<br />regardingobjectid_msdyn_invoicefrequencydetail<br />regardingobjectid_msdyn_invoicelinetransaction<br />regardingobjectid_msdyn_journal<br />regardingobjectid_msdyn_journalline<br />regardingobjectid_msdyn_mlresultcache<br />regardingobjectid_msdyn_opportunitylineresourcecategory<br />regardingobjectid_msdyn_opportunitylinetransaction<br />regardingobjectid_msdyn_opportunitylinetransactioncategory<br />regardingobjectid_msdyn_opportunitylinetransactionclassificatio<br />regardingobjectid_msdyn_opportunitypricelist<br />regardingobjectid_msdyn_orderlineresourcecategory<br />regardingobjectid_msdyn_orderlinetransaction<br />regardingobjectid_msdyn_orderlinetransactioncategory<br />regardingobjectid_msdyn_orderlinetransactionclassification<br />regardingobjectid_msdyn_orderpricelist<br />regardingobjectid_msdyn_processnotes<br />regardingobjectid_msdyn_project<br />regardingobjectid_msdyn_projectapproval<br />regardingobjectid_msdyn_projectparameter<br />regardingobjectid_msdyn_projectparameterpricelist<br />regardingobjectid_msdyn_projectpricelist<br />regardingobjectid_msdyn_projecttask<br />regardingobjectid_msdyn_projecttaskdependency<br />regardingobjectid_msdyn_projecttaskstatususer<br />regardingobjectid_msdyn_projectteam<br />regardingobjectid_msdyn_projectteammembersignup<br />regardingobjectid_msdyn_projecttransactioncategory<br />regardingobjectid_msdyn_quotelineanalyticsbreakdown<br />regardingobjectid_msdyn_quotelineinvoiceschedule<br />regardingobjectid_msdyn_quotelineresourcecategory<br />regardingobjectid_msdyn_quotelinescheduleofvalue<br />regardingobjectid_msdyn_quotelinetransaction<br />regardingobjectid_msdyn_quotelinetransactioncategory<br />regardingobjectid_msdyn_quotelinetransactionclassification<br />regardingobjectid_msdyn_quotepricelist<br />regardingobjectid_msdyn_resourceassignment<br />regardingobjectid_msdyn_resourceassignmentdetail<br />regardingobjectid_msdyn_resourcecategorypricelevel<br />regardingobjectid_msdyn_resourcerequest<br />regardingobjectid_msdyn_rolecompetencyrequirement<br />regardingobjectid_msdyn_roleutilization<br />regardingobjectid_msdyn_timeentry<br />regardingobjectid_msdyn_timeoffcalendar<br />regardingobjectid_msdyn_transactioncategory<br />regardingobjectid_msdyn_transactioncategoryclassification<br />regardingobjectid_msdyn_transactioncategoryhierarchyelement<br />regardingobjectid_msdyn_transactioncategorypricelevel<br />regardingobjectid_msdyn_transactionconnection<br />regardingobjectid_msdyn_transactiontype<br />regardingobjectid_msdyn_userworkhistory<br />regardingobjectid_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d<br />regardingobjectid_msdyn_bpf_665e73aa18c247d886bfc50499c73b82<br />regardingobjectid_msdyn_collaboration<br />regardingobjectid_msdyn_groupsheader<br />regardingobjectid_msdyn_pendinggroupmembers<br />regardingobjectid_msdyn_optimizationrequestbooking<br />regardingobjectid_msdyn_routingengineconfiguration<br />regardingobjectid_msdyn_routingjobconfiguration<br />regardingobjectid_msdyn_routingoptimizationrequest<br />regardingobjectid_msdyn_routingprofileconfiguration<br />regardingobjectid_msdyn_schedulingoptimizationhealthlog<br />regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate<br />regardingobjectid_msdyncrm_campaigncustomchannelactivity<br />regardingobjectid_msdyncrm_contentsettings<br />regardingobjectid_msdyncrm_customerinsightsinfo<br />regardingobjectid_msdyncrm_customerjourney<br />regardingobjectid_msdyncrm_customerjourneyiteration<br />regardingobjectid_msdyncrm_customerjourneytemplate<br />regardingobjectid_msdyncrm_customerjourneyworkflowlink<br />regardingobjectid_msdyncrm_file<br />regardingobjectid_msdyncrm_formpage<br />regardingobjectid_msdyncrm_formpagetemplate<br />regardingobjectid_msdyncrm_geopin<br />regardingobjectid_msdyncrm_keyword<br />regardingobjectid_msdyncrm_marketingconfiguration<br />regardingobjectid_msdyncrm_marketingdynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemail<br />regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemailtemplate<br />regardingobjectid_msdyncrm_marketingemailtestsend<br />regardingobjectid_msdyncrm_marketingform<br />regardingobjectid_msdyncrm_marketingformfield<br />regardingobjectid_msdyncrm_marketingformtemplate<br />regardingobjectid_msdyncrm_marketingpage<br />regardingobjectid_msdyncrm_marketingpageconfiguration<br />regardingobjectid_msdyncrm_marketingpagetemplate<br />regardingobjectid_msdyncrm_matchingstrategy<br />regardingobjectid_msdyncrm_mktactivity<br />regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate<br />regardingobjectid_msdyncrm_portalsettings<br />regardingobjectid_msdyncrm_redirecturl<br />regardingobjectid_msdyncrm_segment<br />regardingobjectid_msdyncrm_taskactivitymarketingtemplate<br />regardingobjectid_msdyncrm_uicconfig<br />regardingobjectid_msdyncrm_usergeoregion<br />regardingobjectid_msdyncrm_website<br />regardingobjectid_msdyncrm_leadscore<br />regardingobjectid_msdyncrm_leadscoremodel<br />regardingobjectid_msdyncrm_leadtoopportunity<br />regardingobjectid_msdyn_answer<br />regardingobjectid_msdyn_azuredeployment<br />regardingobjectid_msdyn_feedbackmapping<br />regardingobjectid_msdyn_feedbacksubsurvey<br />regardingobjectid_msdyn_image<br />regardingobjectid_msdyn_imagetokencache<br />regardingobjectid_msdyn_import<br />regardingobjectid_msdyn_linkedanswer<br />regardingobjectid_msdyn_page<br />regardingobjectid_msdyn_question<br />regardingobjectid_msdyn_questiongroup<br />regardingobjectid_msdyn_questionresponse<br />regardingobjectid_msdyn_questiontype<br />regardingobjectid_msdyn_responseaction<br />regardingobjectid_msdyn_responseblobstore<br />regardingobjectid_msdyn_responsecondition<br />regardingobjectid_msdyn_responseoutcome<br />regardingobjectid_msdyn_responserouting<br />regardingobjectid_msdyn_section<br />regardingobjectid_msdyn_survey<br />regardingobjectid_msdyn_surveylog<br />regardingobjectid_msdyn_surveyresponse<br />regardingobjectid_msdyn_theme<br />regardingobjectid_msdyn_vocconfiguration<br />regardingobjectid_msevtmgt_attendeepass<br />regardingobjectid_msevtmgt_authenticationsettings<br />regardingobjectid_msevtmgt_building<br />regardingobjectid_msevtmgt_checkin<br />regardingobjectid_msevtmgt_entitycounter<br />regardingobjectid_msevtmgt_event<br />regardingobjectid_msevtmgt_eventadministration<br />regardingobjectid_msevtmgt_eventmanagementconfiguration<br />regardingobjectid_msevtmgt_eventpurchase<br />regardingobjectid_msevtmgt_eventpurchaseattendee<br />regardingobjectid_msevtmgt_eventpurchasepass<br />regardingobjectid_msevtmgt_eventregistration<br />regardingobjectid_msevtmgt_eventteammember<br />regardingobjectid_msevtmgt_eventvendor<br />regardingobjectid_msevtmgt_hotel<br />regardingobjectid_msevtmgt_hotelroomallocation<br />regardingobjectid_msevtmgt_hotelroomreservation<br />regardingobjectid_msevtmgt_layout<br />regardingobjectid_msevtmgt_pass<br />regardingobjectid_msevtmgt_room<br />regardingobjectid_msevtmgt_session<br />regardingobjectid_msevtmgt_sessionregistration<br />regardingobjectid_msevtmgt_sessiontrack<br />regardingobjectid_msevtmgt_speaker<br />regardingobjectid_msevtmgt_speakerengagement<br />regardingobjectid_msevtmgt_sponsorablearticle<br />regardingobjectid_msevtmgt_sponsorship<br />regardingobjectid_msevtmgt_venue<br />regardingobjectid_msevtmgt_webinarconfiguration<br />regardingobjectid_msevtmgt_webinarconsent<br />regardingobjectid_msevtmgt_webinarprovider<br />regardingobjectid_msevtmgt_webinartype<br />regardingobjectid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99<br />regardingobjectid_msdyncrm_linkedinaccount<br />regardingobjectid_msdyncrm_linkedinactivity<br />regardingobjectid_msdyncrm_linkedincampaign<br />regardingobjectid_msdyncrm_linkedinconfiguration<br />regardingobjectid_msdyncrm_linkedinfieldmapping<br />regardingobjectid_msdyncrm_linkedinform<br />regardingobjectid_msdyncrm_linkedinformanswer<br />regardingobjectid_msdyncrm_linkedinformquestion<br />regardingobjectid_msdyncrm_linkedinformsubmission<br />regardingobjectid_msdyncrm_linkedinleadmatchingstrategy<br />regardingobjectid_msdyncrm_linkedinuserprofile<br />regardingobjectid_theme<br />regardingobjectid_knowledgearticle<br />regardingobjectid_post<br />regardingobjectid_knowledgebaserecord<br />regardingobjectid_customeraddress<br />regardingobjectid_annualfiscalcalendar<br />regardingobjectid_queue<br />regardingobjectid_calendar<br />regardingobjectid_kbarticlecomment<br />regardingobjectid_annotation<br />regardingobjectid_privilege<br />regardingobjectid_fixedmonthlyfiscalcalendar<br />regardingobjectid_businessunitnewsarticle<br />regardingobjectid_systemuser<br />regardingobjectid_kbarticle<br />regardingobjectid_template<br />regardingobjectid_quarterlyfiscalcalendar<br />regardingobjectid_semiannualfiscalcalendar<br />regardingobjectid_importfile<br />regardingobjectid_systemform<br />regardingobjectid_importlog<br />regardingobjectid_role<br />regardingobjectid_userform<br />regardingobjectid_account<br />regardingobjectid_savedquery<br />regardingobjectid_userquery<br />regardingobjectid_organization<br />regardingobjectid_businessunit<br />regardingobjectid_monthlyfiscalcalendar<br />regardingobjectid_activitymimeattachment<br />regardingobjectid_kbarticletemplate<br />regardingobjectid_emailserverprofile<br />regardingobjectid_sla<br />regardingobjectid_import<br />regardingobjectid_importmap<br />regardingobjectid_importdata<br />regardingobjectid_contact<br />regardingobjectid_activitypointer<br />regardingobjectid_team<br />regardingobjectid_queueitem<br />regardingobjectid_subject<br />||


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|bulkdeleteoperationid|[bulkdeleteoperation EntityType](bulkdeleteoperation.md)|BulkDeleteOperation_BulkDeleteFailure|
|regardingobjectid_account|[account EntityType](account.md)|Account_BulkDeleteFailures|
|regardingobjectid_activitymimeattachment|[activitymimeattachment EntityType](activitymimeattachment.md)|ActivityMimeAttachment_BulkDeleteFailures|
|regardingobjectid_activitypointer|[activitypointer EntityType](activitypointer.md)|ActivityPointer_BulkDeleteFailures|
|regardingobjectid_adx_ad|[adx_ad EntityType](adx_ad.md)|adx_ad_BulkDeleteFailures|
|regardingobjectid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_BulkDeleteFailures|
|regardingobjectid_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_BulkDeleteFailures|
|regardingobjectid_adx_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|adx_contentsnippet_BulkDeleteFailures|
|regardingobjectid_adx_entityform|[adx_entityform EntityType](adx_entityform.md)|adx_entityform_BulkDeleteFailures|
|regardingobjectid_adx_entityformmetadata|[adx_entityformmetadata EntityType](adx_entityformmetadata.md)|adx_entityformmetadata_BulkDeleteFailures|
|regardingobjectid_adx_entitylist|[adx_entitylist EntityType](adx_entitylist.md)|adx_entitylist_BulkDeleteFailures|
|regardingobjectid_adx_entitypermission|[adx_entitypermission EntityType](adx_entitypermission.md)|adx_entitypermission_BulkDeleteFailures|
|regardingobjectid_adx_externalidentity|[adx_externalidentity EntityType](adx_externalidentity.md)|adx_externalidentity_BulkDeleteFailures|
|regardingobjectid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_BulkDeleteFailures|
|regardingobjectid_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_BulkDeleteFailures|
|regardingobjectid_adx_pagealert|[adx_pagealert EntityType](adx_pagealert.md)|adx_pagealert_BulkDeleteFailures|
|regardingobjectid_adx_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|adx_pagenotification_BulkDeleteFailures|
|regardingobjectid_adx_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|adx_pagetag_BulkDeleteFailures|
|regardingobjectid_adx_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|adx_pagetemplate_BulkDeleteFailures|
|regardingobjectid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_BulkDeleteFailures|
|regardingobjectid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_BulkDeleteFailures|
|regardingobjectid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_BulkDeleteFailures|
|regardingobjectid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_BulkDeleteFailures|
|regardingobjectid_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|adx_portalcomment_BulkDeleteFailures|
|regardingobjectid_adx_portallanguage|[adx_portallanguage EntityType](adx_portallanguage.md)|adx_portallanguage_BulkDeleteFailures|
|regardingobjectid_adx_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_publishingstate_BulkDeleteFailures|
|regardingobjectid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_BulkDeleteFailures|
|regardingobjectid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_BulkDeleteFailures|
|regardingobjectid_adx_setting|[adx_setting EntityType](adx_setting.md)|adx_setting_BulkDeleteFailures|
|regardingobjectid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_BulkDeleteFailures|
|regardingobjectid_adx_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|adx_sitemarker_BulkDeleteFailures|
|regardingobjectid_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|adx_sitesetting_BulkDeleteFailures|
|regardingobjectid_adx_tag|[adx_tag EntityType](adx_tag.md)|adx_tag_BulkDeleteFailures|
|regardingobjectid_adx_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|adx_urlhistory_BulkDeleteFailures|
|regardingobjectid_adx_webfile|[adx_webfile EntityType](adx_webfile.md)|adx_webfile_BulkDeleteFailures|
|regardingobjectid_adx_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|adx_webfilelog_BulkDeleteFailures|
|regardingobjectid_adx_webform|[adx_webform EntityType](adx_webform.md)|adx_webform_BulkDeleteFailures|
|regardingobjectid_adx_webformmetadata|[adx_webformmetadata EntityType](adx_webformmetadata.md)|adx_webformmetadata_BulkDeleteFailures|
|regardingobjectid_adx_webformsession|[adx_webformsession EntityType](adx_webformsession.md)|adx_webformsession_BulkDeleteFailures|
|regardingobjectid_adx_webformstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformstep_BulkDeleteFailures|
|regardingobjectid_adx_weblink|[adx_weblink EntityType](adx_weblink.md)|adx_weblink_BulkDeleteFailures|
|regardingobjectid_adx_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|adx_weblinkset_BulkDeleteFailures|
|regardingobjectid_adx_webnotificationentity|[adx_webnotificationentity EntityType](adx_webnotificationentity.md)|adx_webnotificationentity_BulkDeleteFailures|
|regardingobjectid_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|adx_webnotificationurl_BulkDeleteFailures|
|regardingobjectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_BulkDeleteFailures|
|regardingobjectid_adx_webpageaccesscontrolrule|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|adx_webpageaccesscontrolrule_BulkDeleteFailures|
|regardingobjectid_adx_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|adx_webpagehistory_BulkDeleteFailures|
|regardingobjectid_adx_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|adx_webpagelog_BulkDeleteFailures|
|regardingobjectid_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_webrole_BulkDeleteFailures|
|regardingobjectid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_BulkDeleteFailures|
|regardingobjectid_adx_websiteaccess|[adx_websiteaccess EntityType](adx_websiteaccess.md)|adx_websiteaccess_BulkDeleteFailures|
|regardingobjectid_adx_websitebinding|[adx_websitebinding EntityType](adx_websitebinding.md)|adx_websitebinding_BulkDeleteFailures|
|regardingobjectid_adx_websitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|adx_websitelanguage_BulkDeleteFailures|
|regardingobjectid_adx_webtemplate|[adx_webtemplate EntityType](adx_webtemplate.md)|adx_webtemplate_BulkDeleteFailures|
|regardingobjectid_annotation|[annotation EntityType](annotation.md)|Annotation_BulkDeleteFailures|
|regardingobjectid_annualfiscalcalendar|[annualfiscalcalendar EntityType](annualfiscalcalendar.md)|AnnualFiscalCalendar_BulkDeleteFailures|
|regardingobjectid_appointment|[appointment EntityType](appointment.md)|Appointment_BulkDeleteFailures|
|regardingobjectid_bookableresource|[bookableresource EntityType](bookableresource.md)|bookableresource_BulkDeleteFailures|
|regardingobjectid_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_BulkDeleteFailures|
|regardingobjectid_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_BulkDeleteFailures|
|regardingobjectid_bookableresourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|bookableresourcecategory_BulkDeleteFailures|
|regardingobjectid_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|bookableresourcecategoryassn_BulkDeleteFailures|
|regardingobjectid_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|bookableresourcecharacteristic_BulkDeleteFailures|
|regardingobjectid_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|bookableresourcegroup_BulkDeleteFailures|
|regardingobjectid_bookingstatus|[bookingstatus EntityType](bookingstatus.md)|bookingstatus_BulkDeleteFailures|
|regardingobjectid_bulkoperation|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_BulkDeleteFailures|
|regardingobjectid_bulkoperationlog|[bulkoperationlog EntityType](bulkoperationlog.md)|BulkOperationLog_BulkDeleteFailures|
|regardingobjectid_businessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_BulkDeleteFailures|
|regardingobjectid_businessunitnewsarticle|[businessunitnewsarticle EntityType](businessunitnewsarticle.md)|BusinessUnitNewsArticle_BulkDeleteFailures|
|regardingobjectid_calendar|[calendar EntityType](calendar.md)|Calendar_BulkDeleteFailures|
|regardingobjectid_campaign|[campaign EntityType](campaign.md)|Campaign_BulkDeleteFailures|
|regardingobjectid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_BulkDeleteFailures|
|regardingobjectid_campaignactivityitem|[campaignactivityitem EntityType](campaignactivityitem.md)|campaignactivityitem_BulkDeleteFailures|
|regardingobjectid_campaignitem|[campaignitem EntityType](campaignitem.md)|campaignitem_BulkDeleteFailures|
|regardingobjectid_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|CampaignResponse_BulkDeleteFailures|
|regardingobjectid_characteristic|[characteristic EntityType](characteristic.md)|characteristic_BulkDeleteFailures|
|regardingobjectid_competitor|[competitor EntityType](competitor.md)|Competitor_BulkDeleteFailures|
|regardingobjectid_competitoraddress|[competitoraddress EntityType](competitoraddress.md)|competitoraddress_BulkDeleteFailures|
|regardingobjectid_competitorproduct|[competitorproduct EntityType](competitorproduct.md)|competitorproduct_BulkDeleteFailures|
|regardingobjectid_competitorsalesliterature|[competitorsalesliterature EntityType](competitorsalesliterature.md)|competitorsalesliterature_BulkDeleteFailures|
|regardingobjectid_constraintbasedgroup|[constraintbasedgroup EntityType](constraintbasedgroup.md)|ConstraintBasedGroup_BulkDeleteFailures|
|regardingobjectid_contact|[contact EntityType](contact.md)|Contact_BulkDeleteFailures|
|regardingobjectid_contactinvoices|[contactinvoices EntityType](contactinvoices.md)|contactinvoices_BulkDeleteFailures|
|regardingobjectid_contactorders|[contactorders EntityType](contactorders.md)|contactorders_BulkDeleteFailures|
|regardingobjectid_contactquotes|[contactquotes EntityType](contactquotes.md)|contactquotes_BulkDeleteFailures|
|regardingobjectid_contract|[contract EntityType](contract.md)|Contract_BulkDeleteFailures|
|regardingobjectid_contractdetail|[contractdetail EntityType](contractdetail.md)|ContractDetail_BulkDeleteFailures|
|regardingobjectid_contracttemplate|[contracttemplate EntityType](contracttemplate.md)|ContractTemplate_BulkDeleteFailures|
|regardingobjectid_customeraddress|[customeraddress EntityType](customeraddress.md)|CustomerAddress_BulkDeleteFailures|
|regardingobjectid_discount|[discount EntityType](discount.md)|Discount_BulkDeleteFailures|
|regardingobjectid_discounttype|[discounttype EntityType](discounttype.md)|DiscountType_BulkDeleteFailures|
|regardingobjectid_dynamicproperty|[dynamicproperty EntityType](dynamicproperty.md)|dynamicproperty_BulkDeleteFailures|
|regardingobjectid_dynamicpropertyassociation|[dynamicpropertyassociation EntityType](dynamicpropertyassociation.md)|dynamicpropertyassociation_BulkDeleteFailures|
|regardingobjectid_dynamicpropertyinstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|dynamicpropertyinstance_BulkDeleteFailures|
|regardingobjectid_dynamicpropertyoptionsetitem|[dynamicpropertyoptionsetitem EntityType](dynamicpropertyoptionsetitem.md)|dynamicpropertyoptionsetitem_BulkDeleteFailures|
|regardingobjectid_email|[email EntityType](email.md)|Email_BulkDeleteFailures|
|regardingobjectid_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|emailserverprofile_bulkdeletefailures|
|regardingobjectid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_BulkDeleteFailures|
|regardingobjectid_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|entitlementchannel_BulkDeleteFailures|
|regardingobjectid_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_BulkDeleteFailures|
|regardingobjectid_entitlementtemplatechannel|[entitlementtemplatechannel EntityType](entitlementtemplatechannel.md)|entitlementtemplatechannel_BulkDeleteFailures|
|regardingobjectid_equipment|[equipment EntityType](equipment.md)|Equipment_BulkDeleteFailures|
|regardingobjectid_fax|[fax EntityType](fax.md)|Fax_BulkDeleteFailures|
|regardingobjectid_fixedmonthlyfiscalcalendar|[fixedmonthlyfiscalcalendar EntityType](fixedmonthlyfiscalcalendar.md)|FixedMonthlyFiscalCalendar_BulkDeleteFailures|
|regardingobjectid_import|[import EntityType](import.md)|Import_BulkDeleteFailures|
|regardingobjectid_importdata|[importdata EntityType](importdata.md)|ImportData_BulkDeleteFailures|
|regardingobjectid_importfile|[importfile EntityType](importfile.md)|ImportFile_BulkDeleteFailures|
|regardingobjectid_importlog|[importlog EntityType](importlog.md)|ImportLog_BulkDeleteFailures|
|regardingobjectid_importmap|[importmap EntityType](importmap.md)|ImportMap_BulkDeleteFailures|
|regardingobjectid_incident|[incident EntityType](incident.md)|Incident_BulkDeleteFailures|
|regardingobjectid_incidentresolution|[incidentresolution EntityType](incidentresolution.md)|IncidentResolution_BulkDeleteFailures|
|regardingobjectid_invoice|[invoice EntityType](invoice.md)|Invoice_BulkDeleteFailures|
|regardingobjectid_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|InvoiceDetail_BulkDeleteFailures|
|regardingobjectid_kbarticle|[kbarticle EntityType](kbarticle.md)|KbArticle_BulkDeleteFailures|
|regardingobjectid_kbarticlecomment|[kbarticlecomment EntityType](kbarticlecomment.md)|KbArticleComment_BulkDeleteFailures|
|regardingobjectid_kbarticletemplate|[kbarticletemplate EntityType](kbarticletemplate.md)|KbArticleTemplate_BulkDeleteFailures|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_BulkDeleteFailures|
|regardingobjectid_knowledgearticleincident|[knowledgearticleincident EntityType](knowledgearticleincident.md)|knowledgearticleincident_BulkDeleteFailures|
|regardingobjectid_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_BulkDeleteFailures|
|regardingobjectid_lead|[lead EntityType](lead.md)|Lead_BulkDeleteFailures|
|regardingobjectid_leadaddress|[leadaddress EntityType](leadaddress.md)|leadaddress_BulkDeleteFailures|
|regardingobjectid_leadcompetitors|[leadcompetitors EntityType](leadcompetitors.md)|leadcompetitors_BulkDeleteFailures|
|regardingobjectid_leadproduct|[leadproduct EntityType](leadproduct.md)|leadproduct_BulkDeleteFailures|
|regardingobjectid_leadtoopportunitysalesprocess|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|leadtoopportunitysalesprocess_BulkDeleteFailures|
|regardingobjectid_letter|[letter EntityType](letter.md)|Letter_BulkDeleteFailures|
|regardingobjectid_list|[list EntityType](list.md)|List_BulkDeleteFailures|
|regardingobjectid_listmember|[listmember EntityType](listmember.md)|listmember_BulkDeleteFailures|
|regardingobjectid_monthlyfiscalcalendar|[monthlyfiscalcalendar EntityType](monthlyfiscalcalendar.md)|MonthlyFiscalCalendar_BulkDeleteFailures|
|regardingobjectid_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|msdyn_accountpricelist_BulkDeleteFailures|
|regardingobjectid_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_actual_BulkDeleteFailures|
|regardingobjectid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_BulkDeleteFailures|
|regardingobjectid_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|msdyn_agreementsubstatus_BulkDeleteFailures|
|regardingobjectid_msdyn_answer|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_answer_BulkDeleteFailures|
|regardingobjectid_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_BulkDeleteFailures|
|regardingobjectid_msdyn_azuredeployment|[msdyn_azuredeployment EntityType](msdyn_azuredeployment.md)|msdyn_azuredeployment_BulkDeleteFailures|
|regardingobjectid_msdyn_batchjob|[msdyn_batchjob EntityType](msdyn_batchjob.md)|msdyn_batchjob_BulkDeleteFailures|
|regardingobjectid_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_BulkDeleteFailures|
|regardingobjectid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_BulkDeleteFailures|
|regardingobjectid_msdyn_bookingchange|[msdyn_bookingchange EntityType](msdyn_bookingchange.md)|msdyn_bookingchange_BulkDeleteFailures|
|regardingobjectid_msdyn_bookingjournal|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|msdyn_bookingjournal_BulkDeleteFailures|
|regardingobjectid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_BulkDeleteFailures|
|regardingobjectid_msdyn_bookingsetupmetadata|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|msdyn_bookingsetupmetadata_BulkDeleteFailures|
|regardingobjectid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_BulkDeleteFailures|
|regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures|
|regardingobjectid_msdyn_collaboration|[msdyn_collaboration EntityType](msdyn_collaboration.md)|msdyn_collaboration_BulkDeleteFailures|
|regardingobjectid_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|msdyn_contactpricelist_BulkDeleteFailures|
|regardingobjectid_msdyn_contractlineinvoiceschedule|[msdyn_contractlineinvoiceschedule EntityType](msdyn_contractlineinvoiceschedule.md)|msdyn_contractlineinvoiceschedule_BulkDeleteFailures|
|regardingobjectid_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_contractlinescheduleofvalue_BulkDeleteFailures|
|regardingobjectid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_BulkDeleteFailures|
|regardingobjectid_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|msdyn_dataexport_BulkDeleteFailures|
|regardingobjectid_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|msdyn_delegation_BulkDeleteFailures|
|regardingobjectid_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|msdyn_estimate_BulkDeleteFailures|
|regardingobjectid_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_estimateline_BulkDeleteFailures|
|regardingobjectid_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_expense_BulkDeleteFailures|
|regardingobjectid_msdyn_expensecategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_expensecategory_BulkDeleteFailures|
|regardingobjectid_msdyn_expensereceipt|[msdyn_expensereceipt EntityType](msdyn_expensereceipt.md)|msdyn_expensereceipt_BulkDeleteFailures|
|regardingobjectid_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_fact_BulkDeleteFailures|
|regardingobjectid_msdyn_feedbackmapping|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|msdyn_feedbackmapping_BulkDeleteFailures|
|regardingobjectid_msdyn_feedbacksubsurvey|[msdyn_feedbacksubsurvey EntityType](msdyn_feedbacksubsurvey.md)|msdyn_feedbacksubsurvey_BulkDeleteFailures|
|regardingobjectid_msdyn_fieldcomputation|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|msdyn_fieldcomputation_BulkDeleteFailures|
|regardingobjectid_msdyn_fieldservicepricelistitem|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|msdyn_fieldservicepricelistitem_BulkDeleteFailures|
|regardingobjectid_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_BulkDeleteFailures|
|regardingobjectid_msdyn_fieldservicesystemjob|[msdyn_fieldservicesystemjob EntityType](msdyn_fieldservicesystemjob.md)|msdyn_fieldservicesystemjob_BulkDeleteFailures|
|regardingobjectid_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|msdyn_findworkevent_BulkDeleteFailures|
|regardingobjectid_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_glympseagent_BulkDeleteFailures|
|regardingobjectid_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|msdyn_glympsesetting_BulkDeleteFailures|
|regardingobjectid_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_glympsetask_BulkDeleteFailures|
|regardingobjectid_msdyn_groupsheader|[msdyn_groupsheader EntityType](msdyn_groupsheader.md)|msdyn_groupsheader_BulkDeleteFailures|
|regardingobjectid_msdyn_image|[msdyn_image EntityType](msdyn_image.md)|msdyn_image_BulkDeleteFailures|
|regardingobjectid_msdyn_imagetokencache|[msdyn_imagetokencache EntityType](msdyn_imagetokencache.md)|msdyn_imagetokencache_BulkDeleteFailures|
|regardingobjectid_msdyn_import|[msdyn_import EntityType](msdyn_import.md)|msdyn_import_BulkDeleteFailures|
|regardingobjectid_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_incidenttype_BulkDeleteFailures|
|regardingobjectid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_BulkDeleteFailures|
|regardingobjectid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_BulkDeleteFailures|
|regardingobjectid_msdyn_incidenttypeservicetask|[msdyn_incidenttypeservicetask EntityType](msdyn_incidenttypeservicetask.md)|msdyn_incidenttypeservicetask_BulkDeleteFailures|
|regardingobjectid_msdyn_integrationjob|[msdyn_integrationjob EntityType](msdyn_integrationjob.md)|msdyn_integrationjob_BulkDeleteFailures|
|regardingobjectid_msdyn_integrationjobdetail|[msdyn_integrationjobdetail EntityType](msdyn_integrationjobdetail.md)|msdyn_integrationjobdetail_BulkDeleteFailures|
|regardingobjectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_BulkDeleteFailures|
|regardingobjectid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_BulkDeleteFailures|
|regardingobjectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_BulkDeleteFailures|
|regardingobjectid_msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|msdyn_invoicefrequency_BulkDeleteFailures|
|regardingobjectid_msdyn_invoicefrequencydetail|[msdyn_invoicefrequencydetail EntityType](msdyn_invoicefrequencydetail.md)|msdyn_invoicefrequencydetail_BulkDeleteFailures|
|regardingobjectid_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_invoicelinetransaction_BulkDeleteFailures|
|regardingobjectid_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_iotalert_BulkDeleteFailures|
|regardingobjectid_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_iotdevice_BulkDeleteFailures|
|regardingobjectid_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_iotdevicecategory_BulkDeleteFailures|
|regardingobjectid_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_iotdevicecommand_BulkDeleteFailures|
|regardingobjectid_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_iotdeviceregistrationhistory_BulkDeleteFailures|
|regardingobjectid_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|msdyn_journal_BulkDeleteFailures|
|regardingobjectid_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_journalline_BulkDeleteFailures|
|regardingobjectid_msdyn_linkedanswer|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_linkedanswer_BulkDeleteFailures|
|regardingobjectid_msdyn_mlresultcache|[msdyn_mlresultcache EntityType](msdyn_mlresultcache.md)|msdyn_mlresultcache_BulkDeleteFailures|
|regardingobjectid_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|msdyn_opportunitylineresourcecategory_BulkDeleteFailures|
|regardingobjectid_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_opportunitylinetransaction_BulkDeleteFailures|
|regardingobjectid_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|msdyn_opportunitylinetransactioncategory_BulkDeleteFailures|
|regardingobjectid_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|msdyn_opportunitylinetransactionclassificatio_BulkDeleteFailures|
|regardingobjectid_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|msdyn_opportunitypricelist_BulkDeleteFailures|
|regardingobjectid_msdyn_optimizationrequestbooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|msdyn_optimizationrequestbooking_BulkDeleteFailures|
|regardingobjectid_msdyn_orderinvoicingdate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|msdyn_orderinvoicingdate_BulkDeleteFailures|
|regardingobjectid_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|msdyn_orderinvoicingproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_orderinvoicingsetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|msdyn_orderinvoicingsetup_BulkDeleteFailures|
|regardingobjectid_msdyn_orderinvoicingsetupdate|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|msdyn_orderinvoicingsetupdate_BulkDeleteFailures|
|regardingobjectid_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|msdyn_orderlineresourcecategory_BulkDeleteFailures|
|regardingobjectid_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_orderlinetransaction_BulkDeleteFailures|
|regardingobjectid_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|msdyn_orderlinetransactioncategory_BulkDeleteFailures|
|regardingobjectid_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|msdyn_orderlinetransactionclassification_BulkDeleteFailures|
|regardingobjectid_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|msdyn_orderpricelist_BulkDeleteFailures|
|regardingobjectid_msdyn_organizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_BulkDeleteFailures|
|regardingobjectid_msdyn_page|[msdyn_page EntityType](msdyn_page.md)|msdyn_page_BulkDeleteFailures|
|regardingobjectid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_BulkDeleteFailures|
|regardingobjectid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_BulkDeleteFailures|
|regardingobjectid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_BulkDeleteFailures|
|regardingobjectid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_BulkDeleteFailures|
|regardingobjectid_msdyn_pendinggroupmembers|[msdyn_pendinggroupmembers EntityType](msdyn_pendinggroupmembers.md)|msdyn_pendinggroupmembers_BulkDeleteFailures|
|regardingobjectid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_BulkDeleteFailures|
|regardingobjectid_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_priority_BulkDeleteFailures|
|regardingobjectid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_BulkDeleteFailures|
|regardingobjectid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_BulkDeleteFailures|
|regardingobjectid_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_BulkDeleteFailures|
|regardingobjectid_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_projectapproval_BulkDeleteFailures|
|regardingobjectid_msdyn_projectparameter|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_projectparameter_BulkDeleteFailures|
|regardingobjectid_msdyn_projectparameterpricelist|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|msdyn_projectparameterpricelist_BulkDeleteFailures|
|regardingobjectid_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|msdyn_projectpricelist_BulkDeleteFailures|
|regardingobjectid_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_projecttask_BulkDeleteFailures|
|regardingobjectid_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_projecttaskdependency_BulkDeleteFailures|
|regardingobjectid_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|msdyn_projecttaskstatususer_BulkDeleteFailures|
|regardingobjectid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_BulkDeleteFailures|
|regardingobjectid_msdyn_projectteammembersignup|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|msdyn_projectteammembersignup_BulkDeleteFailures|
|regardingobjectid_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|msdyn_projecttransactioncategory_BulkDeleteFailures|
|regardingobjectid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_BulkDeleteFailures|
|regardingobjectid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_BulkDeleteFailures|
|regardingobjectid_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_BulkDeleteFailures|
|regardingobjectid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_BulkDeleteFailures|
|regardingobjectid_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_BulkDeleteFailures|
|regardingobjectid_msdyn_questiongroup|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_questiongroup_BulkDeleteFailures|
|regardingobjectid_msdyn_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|msdyn_questionresponse_BulkDeleteFailures|
|regardingobjectid_msdyn_questiontype|[msdyn_questiontype EntityType](msdyn_questiontype.md)|msdyn_questiontype_BulkDeleteFailures|
|regardingobjectid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_BulkDeleteFailures|
|regardingobjectid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_BulkDeleteFailures|
|regardingobjectid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_BulkDeleteFailures|
|regardingobjectid_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|msdyn_quotebookingsetup_BulkDeleteFailures|
|regardingobjectid_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|msdyn_quoteinvoicingproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|msdyn_quoteinvoicingsetup_BulkDeleteFailures|
|regardingobjectid_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures|
|regardingobjectid_msdyn_quotelineinvoiceschedule|[msdyn_quotelineinvoiceschedule EntityType](msdyn_quotelineinvoiceschedule.md)|msdyn_quotelineinvoiceschedule_BulkDeleteFailures|
|regardingobjectid_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|msdyn_quotelineresourcecategory_BulkDeleteFailures|
|regardingobjectid_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|msdyn_quotelinescheduleofvalue_BulkDeleteFailures|
|regardingobjectid_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_quotelinetransaction_BulkDeleteFailures|
|regardingobjectid_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|msdyn_quotelinetransactioncategory_BulkDeleteFailures|
|regardingobjectid_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|msdyn_quotelinetransactionclassification_BulkDeleteFailures|
|regardingobjectid_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|msdyn_quotepricelist_BulkDeleteFailures|
|regardingobjectid_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|msdyn_requirementcharacteristic_BulkDeleteFailures|
|regardingobjectid_msdyn_requirementorganizationunit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|msdyn_requirementorganizationunit_BulkDeleteFailures|
|regardingobjectid_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|msdyn_requirementresourcecategory_BulkDeleteFailures|
|regardingobjectid_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_requirementresourcepreference_BulkDeleteFailures|
|regardingobjectid_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_requirementstatus_BulkDeleteFailures|
|regardingobjectid_msdyn_resourceassignment|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|msdyn_resourceassignment_BulkDeleteFailures|
|regardingobjectid_msdyn_resourceassignmentdetail|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|msdyn_resourceassignmentdetail_BulkDeleteFailures|
|regardingobjectid_msdyn_resourcecategorypricelevel|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_resourcecategorypricelevel_BulkDeleteFailures|
|regardingobjectid_msdyn_resourcepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_resourcepaytype_BulkDeleteFailures|
|regardingobjectid_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_resourcerequest_BulkDeleteFailures|
|regardingobjectid_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_BulkDeleteFailures|
|regardingobjectid_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|msdyn_resourcerequirementdetail_BulkDeleteFailures|
|regardingobjectid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_BulkDeleteFailures|
|regardingobjectid_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_BulkDeleteFailures|
|regardingobjectid_msdyn_responseblobstore|[msdyn_responseblobstore EntityType](msdyn_responseblobstore.md)|msdyn_responseblobstore_BulkDeleteFailures|
|regardingobjectid_msdyn_responsecondition|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|msdyn_responsecondition_BulkDeleteFailures|
|regardingobjectid_msdyn_responseoutcome|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_responseoutcome_BulkDeleteFailures|
|regardingobjectid_msdyn_responserouting|[msdyn_responserouting EntityType](msdyn_responserouting.md)|msdyn_responserouting_BulkDeleteFailures|
|regardingobjectid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_BulkDeleteFailures|
|regardingobjectid_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_BulkDeleteFailures|
|regardingobjectid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_BulkDeleteFailures|
|regardingobjectid_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|msdyn_rolecompetencyrequirement_BulkDeleteFailures|
|regardingobjectid_msdyn_roleutilization|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|msdyn_roleutilization_BulkDeleteFailures|
|regardingobjectid_msdyn_routingengineconfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|msdyn_routingengineconfiguration_BulkDeleteFailures|
|regardingobjectid_msdyn_routingjobconfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|msdyn_routingjobconfiguration_BulkDeleteFailures|
|regardingobjectid_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_routingoptimizationrequest_BulkDeleteFailures|
|regardingobjectid_msdyn_routingprofileconfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|msdyn_routingprofileconfiguration_BulkDeleteFailures|
|regardingobjectid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_BulkDeleteFailures|
|regardingobjectid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_BulkDeleteFailures|
|regardingobjectid_msdyn_scheduleboardsetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|msdyn_scheduleboardsetting_BulkDeleteFailures|
|regardingobjectid_msdyn_schedulingoptimizationhealthlog|[msdyn_schedulingoptimizationhealthlog EntityType](msdyn_schedulingoptimizationhealthlog.md)|msdyn_schedulingoptimizationhealthlog_BulkDeleteFailures|
|regardingobjectid_msdyn_schedulingparameter|[msdyn_schedulingparameter EntityType](msdyn_schedulingparameter.md)|msdyn_schedulingparameter_BulkDeleteFailures|
|regardingobjectid_msdyn_section|[msdyn_section EntityType](msdyn_section.md)|msdyn_section_BulkDeleteFailures|
|regardingobjectid_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|msdyn_servicetasktype_BulkDeleteFailures|
|regardingobjectid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_BulkDeleteFailures|
|regardingobjectid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_BulkDeleteFailures|
|regardingobjectid_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_BulkDeleteFailures|
|regardingobjectid_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|msdyn_surveylog_BulkDeleteFailures|
|regardingobjectid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_BulkDeleteFailures|
|regardingobjectid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_BulkDeleteFailures|
|regardingobjectid_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_taxcode_BulkDeleteFailures|
|regardingobjectid_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|msdyn_taxcodedetail_BulkDeleteFailures|
|regardingobjectid_msdyn_theme|[msdyn_theme EntityType](msdyn_theme.md)|msdyn_theme_BulkDeleteFailures|
|regardingobjectid_msdyn_timeentry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_timeentry_BulkDeleteFailures|
|regardingobjectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_BulkDeleteFailures|
|regardingobjectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_BulkDeleteFailures|
|regardingobjectid_msdyn_timeoffcalendar|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|msdyn_timeoffcalendar_BulkDeleteFailures|
|regardingobjectid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_BulkDeleteFailures|
|regardingobjectid_msdyn_transactioncategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_transactioncategory_BulkDeleteFailures|
|regardingobjectid_msdyn_transactioncategoryclassification|[msdyn_transactioncategoryclassification EntityType](msdyn_transactioncategoryclassification.md)|msdyn_transactioncategoryclassification_BulkDeleteFailures|
|regardingobjectid_msdyn_transactioncategoryhierarchyelement|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|msdyn_transactioncategoryhierarchyelement_BulkDeleteFailures|
|regardingobjectid_msdyn_transactioncategorypricelevel|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_transactioncategorypricelevel_BulkDeleteFailures|
|regardingobjectid_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|msdyn_transactionconnection_BulkDeleteFailures|
|regardingobjectid_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|msdyn_transactionorigin_BulkDeleteFailures|
|regardingobjectid_msdyn_transactiontype|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|msdyn_transactiontype_BulkDeleteFailures|
|regardingobjectid_msdyn_uniquenumber|[msdyn_uniquenumber EntityType](msdyn_uniquenumber.md)|msdyn_uniquenumber_BulkDeleteFailures|
|regardingobjectid_msdyn_userworkhistory|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|msdyn_userworkhistory_BulkDeleteFailures|
|regardingobjectid_msdyn_vocconfiguration|[msdyn_vocconfiguration EntityType](msdyn_vocconfiguration.md)|msdyn_vocconfiguration_BulkDeleteFailures|
|regardingobjectid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_BulkDeleteFailures|
|regardingobjectid_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_workhourtemplate_BulkDeleteFailures|
|regardingobjectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_BulkDeleteFailures|
|regardingobjectid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_BulkDeleteFailures|
|regardingobjectid_msdyn_workorderdetailsgenerationqueue|[msdyn_workorderdetailsgenerationqueue EntityType](msdyn_workorderdetailsgenerationqueue.md)|msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures|
|regardingobjectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_BulkDeleteFailures|
|regardingobjectid_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_BulkDeleteFailures|
|regardingobjectid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_BulkDeleteFailures|
|regardingobjectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_BulkDeleteFailures|
|regardingobjectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_BulkDeleteFailures|
|regardingobjectid_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|msdyn_workordersubstatus_BulkDeleteFailures|
|regardingobjectid_msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_workordertype_BulkDeleteFailures|
|regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_BulkDeleteFailures|
|regardingobjectid_msdyncrm_campaigncustomchannelactivity|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|msdyncrm_campaigncustomchannelactivity_BulkDeleteFailures|
|regardingobjectid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_BulkDeleteFailures|
|regardingobjectid_msdyncrm_customerinsightsinfo|[msdyncrm_customerinsightsinfo EntityType](msdyncrm_customerinsightsinfo.md)|msdyncrm_customerinsightsinfo_BulkDeleteFailures|
|regardingobjectid_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_BulkDeleteFailures|
|regardingobjectid_msdyncrm_customerjourneyiteration|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|msdyncrm_customerjourneyiteration_BulkDeleteFailures|
|regardingobjectid_msdyncrm_customerjourneytemplate|[msdyncrm_customerjourneytemplate EntityType](msdyncrm_customerjourneytemplate.md)|msdyncrm_customerjourneytemplate_BulkDeleteFailures|
|regardingobjectid_msdyncrm_customerjourneyworkflowlink|[msdyncrm_customerjourneyworkflowlink EntityType](msdyncrm_customerjourneyworkflowlink.md)|msdyncrm_customerjourneyworkflowlink_BulkDeleteFailures|
|regardingobjectid_msdyncrm_file|[msdyncrm_file EntityType](msdyncrm_file.md)|msdyncrm_file_BulkDeleteFailures|
|regardingobjectid_msdyncrm_formpage|[msdyncrm_formpage EntityType](msdyncrm_formpage.md)|msdyncrm_formpage_BulkDeleteFailures|
|regardingobjectid_msdyncrm_formpagetemplate|[msdyncrm_formpagetemplate EntityType](msdyncrm_formpagetemplate.md)|msdyncrm_formpagetemplate_BulkDeleteFailures|
|regardingobjectid_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|msdyncrm_geopin_BulkDeleteFailures|
|regardingobjectid_msdyncrm_keyword|[msdyncrm_keyword EntityType](msdyncrm_keyword.md)|msdyncrm_keyword_BulkDeleteFailures|
|regardingobjectid_msdyncrm_leadscore|[msdyncrm_leadscore EntityType](msdyncrm_leadscore.md)|msdyncrm_leadscore_BulkDeleteFailures|
|regardingobjectid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_BulkDeleteFailures|
|regardingobjectid_msdyncrm_leadtoopportunity|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|msdyncrm_leadtoopportunity_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedincampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|msdyncrm_linkedincampaign_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinconfiguration|[msdyncrm_linkedinconfiguration EntityType](msdyncrm_linkedinconfiguration.md)|msdyncrm_linkedinconfiguration_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_BulkDeleteFailures|
|regardingobjectid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingconfiguration|[msdyncrm_marketingconfiguration EntityType](msdyncrm_marketingconfiguration.md)|msdyncrm_marketingconfiguration_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingemail|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|msdyncrm_marketingemail_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingemailtemplate|[msdyncrm_marketingemailtemplate EntityType](msdyncrm_marketingemailtemplate.md)|msdyncrm_marketingemailtemplate_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingform|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_marketingform_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|msdyncrm_marketingformfield_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingformtemplate|[msdyncrm_marketingformtemplate EntityType](msdyncrm_marketingformtemplate.md)|msdyncrm_marketingformtemplate_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_marketingpage_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingpageconfiguration|[msdyncrm_marketingpageconfiguration EntityType](msdyncrm_marketingpageconfiguration.md)|msdyncrm_marketingpageconfiguration_BulkDeleteFailures|
|regardingobjectid_msdyncrm_marketingpagetemplate|[msdyncrm_marketingpagetemplate EntityType](msdyncrm_marketingpagetemplate.md)|msdyncrm_marketingpagetemplate_BulkDeleteFailures|
|regardingobjectid_msdyncrm_matchingstrategy|[msdyncrm_matchingstrategy EntityType](msdyncrm_matchingstrategy.md)|msdyncrm_matchingstrategy_BulkDeleteFailures|
|regardingobjectid_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_BulkDeleteFailures|
|regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_BulkDeleteFailures|
|regardingobjectid_msdyncrm_portalsettings|[msdyncrm_portalsettings EntityType](msdyncrm_portalsettings.md)|msdyncrm_portalsettings_BulkDeleteFailures|
|regardingobjectid_msdyncrm_redirecturl|[msdyncrm_redirecturl EntityType](msdyncrm_redirecturl.md)|msdyncrm_redirecturl_BulkDeleteFailures|
|regardingobjectid_msdyncrm_segment|[msdyncrm_segment EntityType](msdyncrm_segment.md)|msdyncrm_segment_BulkDeleteFailures|
|regardingobjectid_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_BulkDeleteFailures|
|regardingobjectid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_BulkDeleteFailures|
|regardingobjectid_msdyncrm_usergeoregion|[msdyncrm_usergeoregion EntityType](msdyncrm_usergeoregion.md)|msdyncrm_usergeoregion_BulkDeleteFailures|
|regardingobjectid_msdyncrm_website|[msdyncrm_website EntityType](msdyncrm_website.md)|msdyncrm_website_BulkDeleteFailures|
|regardingobjectid_msevtmgt_attendeepass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|msevtmgt_attendeepass_BulkDeleteFailures|
|regardingobjectid_msevtmgt_authenticationsettings|[msevtmgt_authenticationsettings EntityType](msevtmgt_authenticationsettings.md)|msevtmgt_authenticationsettings_BulkDeleteFailures|
|regardingobjectid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99|[msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 EntityType](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md)|msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_BulkDeleteFailures|
|regardingobjectid_msevtmgt_building|[msevtmgt_building EntityType](msevtmgt_building.md)|msevtmgt_building_BulkDeleteFailures|
|regardingobjectid_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_BulkDeleteFailures|
|regardingobjectid_msevtmgt_entitycounter|[msevtmgt_entitycounter EntityType](msevtmgt_entitycounter.md)|msevtmgt_entitycounter_BulkDeleteFailures|
|regardingobjectid_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_BulkDeleteFailures|
|regardingobjectid_msevtmgt_eventadministration|[msevtmgt_eventadministration EntityType](msevtmgt_eventadministration.md)|msevtmgt_eventadministration_BulkDeleteFailures|
|regardingobjectid_msevtmgt_eventmanagementconfiguration|[msevtmgt_eventmanagementconfiguration EntityType](msevtmgt_eventmanagementconfiguration.md)|msevtmgt_eventmanagementconfiguration_BulkDeleteFailures|
|regardingobjectid_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_BulkDeleteFailures|
|regardingobjectid_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_BulkDeleteFailures|
|regardingobjectid_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_BulkDeleteFailures|
|regardingobjectid_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_BulkDeleteFailures|
|regardingobjectid_msevtmgt_eventteammember|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|msevtmgt_eventteammember_BulkDeleteFailures|
|regardingobjectid_msevtmgt_eventvendor|[msevtmgt_eventvendor EntityType](msevtmgt_eventvendor.md)|msevtmgt_eventvendor_BulkDeleteFailures|
|regardingobjectid_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_BulkDeleteFailures|
|regardingobjectid_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_BulkDeleteFailures|
|regardingobjectid_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_BulkDeleteFailures|
|regardingobjectid_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_BulkDeleteFailures|
|regardingobjectid_msevtmgt_pass|[msevtmgt_pass EntityType](msevtmgt_pass.md)|msevtmgt_pass_BulkDeleteFailures|
|regardingobjectid_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_BulkDeleteFailures|
|regardingobjectid_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_BulkDeleteFailures|
|regardingobjectid_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_BulkDeleteFailures|
|regardingobjectid_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_BulkDeleteFailures|
|regardingobjectid_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_BulkDeleteFailures|
|regardingobjectid_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_BulkDeleteFailures|
|regardingobjectid_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_BulkDeleteFailures|
|regardingobjectid_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_BulkDeleteFailures|
|regardingobjectid_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_BulkDeleteFailures|
|regardingobjectid_msevtmgt_webinarconfiguration|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_BulkDeleteFailures|
|regardingobjectid_msevtmgt_webinarconsent|[msevtmgt_webinarconsent EntityType](msevtmgt_webinarconsent.md)|msevtmgt_webinarconsent_BulkDeleteFailures|
|regardingobjectid_msevtmgt_webinarprovider|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_BulkDeleteFailures|
|regardingobjectid_msevtmgt_webinartype|[msevtmgt_webinartype EntityType](msevtmgt_webinartype.md)|msevtmgt_webinartype_BulkDeleteFailures|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_BulkDeleteFailures|
|regardingobjectid_opportunityclose|[opportunityclose EntityType](opportunityclose.md)|OpportunityClose_BulkDeleteFailures|
|regardingobjectid_opportunitycompetitors|[opportunitycompetitors EntityType](opportunitycompetitors.md)|opportunitycompetitors_BulkDeleteFailures|
|regardingobjectid_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|OpportunityProduct_BulkDeleteFailures|
|regardingobjectid_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|opportunitysalesprocess_BulkDeleteFailures|
|regardingobjectid_orderclose|[orderclose EntityType](orderclose.md)|OrderClose_BulkDeleteFailures|
|regardingobjectid_organization|[organization EntityType](organization.md)|Organization_BulkDeleteFailures|
|regardingobjectid_phonecall|[phonecall EntityType](phonecall.md)|PhoneCall_BulkDeleteFailures|
|regardingobjectid_phonetocaseprocess|[phonetocaseprocess EntityType](phonetocaseprocess.md)|phonetocaseprocess_BulkDeleteFailures|
|regardingobjectid_post|[post EntityType](post.md)|post_BulkDeleteFailures|
|regardingobjectid_pricelevel|[pricelevel EntityType](pricelevel.md)|PriceLevel_BulkDeleteFailures|
|regardingobjectid_privilege|[privilege EntityType](privilege.md)|Privilege_BulkDeleteFailures|
|regardingobjectid_product|[product EntityType](product.md)|Product_BulkDeleteFailures|
|regardingobjectid_productassociation|[productassociation EntityType](productassociation.md)|productassociation_BulkDeleteFailures|
|regardingobjectid_productpricelevel|[productpricelevel EntityType](productpricelevel.md)|ProductPriceLevel_BulkDeleteFailures|
|regardingobjectid_productsalesliterature|[productsalesliterature EntityType](productsalesliterature.md)|productsalesliterature_BulkDeleteFailures|
|regardingobjectid_productsubstitute|[productsubstitute EntityType](productsubstitute.md)|ProductSubstitute_BulkDeleteFailures|
|regardingobjectid_quarterlyfiscalcalendar|[quarterlyfiscalcalendar EntityType](quarterlyfiscalcalendar.md)|QuarterlyFiscalCalendar_BulkDeleteFailures|
|regardingobjectid_queue|[queue EntityType](queue.md)|Queue_BulkDeleteFailures|
|regardingobjectid_queueitem|[queueitem EntityType](queueitem.md)|QueueItem_BulkDeleteFailures|
|regardingobjectid_quote|[quote EntityType](quote.md)|Quote_BulkDeleteFailures|
|regardingobjectid_quoteclose|[quoteclose EntityType](quoteclose.md)|QuoteClose_BulkDeleteFailures|
|regardingobjectid_quotedetail|[quotedetail EntityType](quotedetail.md)|QuoteDetail_BulkDeleteFailures|
|regardingobjectid_ratingmodel|[ratingmodel EntityType](ratingmodel.md)|ratingmodel_BulkDeleteFailures|
|regardingobjectid_ratingvalue|[ratingvalue EntityType](ratingvalue.md)|ratingvalue_BulkDeleteFailures|
|regardingobjectid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|RecurringAppointmentMaster_BulkDeleteFailures|
|regardingobjectid_resource|[resource EntityType](resource.md)|Resource_BulkDeleteFailures|
|regardingobjectid_resourcegroup|[resourcegroup EntityType](resourcegroup.md)|ResourceGroup_BulkDeleteFailures|
|regardingobjectid_resourcespec|[resourcespec EntityType](resourcespec.md)|ResourceSpec_BulkDeleteFailures|
|regardingobjectid_role|[role EntityType](role.md)|Role_BulkDeleteFailures|
|regardingobjectid_salesliterature|[salesliterature EntityType](salesliterature.md)|SalesLiterature_BulkDeleteFailures|
|regardingobjectid_salesliteratureitem|[salesliteratureitem EntityType](salesliteratureitem.md)|SalesLiteratureItem_BulkDeleteFailures|
|regardingobjectid_salesorder|[salesorder EntityType](salesorder.md)|SalesOrder_BulkDeleteFailures|
|regardingobjectid_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|SalesOrderDetail_BulkDeleteFailures|
|regardingobjectid_savedquery|[savedquery EntityType](savedquery.md)|SavedQuery_BulkDeleteFailures|
|regardingobjectid_semiannualfiscalcalendar|[semiannualfiscalcalendar EntityType](semiannualfiscalcalendar.md)|SemiAnnualFiscalCalendar_BulkDeleteFailures|
|regardingobjectid_service|[service EntityType](service.md)|Service_BulkDeleteFailures|
|regardingobjectid_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|ServiceAppointment_BulkDeleteFailures|
|regardingobjectid_site|[site EntityType](site.md)|Site_BulkDeleteFailures|
|regardingobjectid_sla|[sla EntityType](sla.md)|slabase_BulkDeleteFailures|
|regardingobjectid_socialactivity|[socialactivity EntityType](socialactivity.md)|SocialActivity_BulkDeleteFailures|
|regardingobjectid_subject|[subject EntityType](subject.md)|Subject_BulkDeleteFailures|
|regardingobjectid_systemform|[systemform EntityType](systemform.md)|SystemForm_BulkDeleteFailures|
|regardingobjectid_systemuser|[systemuser EntityType](systemuser.md)|SystemUser_BulkDeleteFailures|
|regardingobjectid_task|[task EntityType](task.md)|Task_BulkDeleteFailures|
|regardingobjectid_team|[team EntityType](team.md)|Team_BulkDeleteFailures|
|regardingobjectid_template|[template EntityType](template.md)|Template_BulkDeleteFailures|
|regardingobjectid_territory|[territory EntityType](territory.md)|Territory_BulkDeleteFailures|
|regardingobjectid_theme|[theme EntityType](theme.md)|theme_BulkDeleteFailures|
|regardingobjectid_uom|[uom EntityType](uom.md)|UoM_BulkDeleteFailures|
|regardingobjectid_uomschedule|[uomschedule EntityType](uomschedule.md)|UoMSchedule_BulkDeleteFailures|
|regardingobjectid_userform|[userform EntityType](userform.md)|UserForm_BulkDeleteFailures|
|regardingobjectid_userquery|[userquery EntityType](userquery.md)|UserQuery_BulkDeleteFailures|  

[!INCLUDE[./remarks/bulkdeletefailure.md](./remarks/bulkdeletefailure.md)]

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