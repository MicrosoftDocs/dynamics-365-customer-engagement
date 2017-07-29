---
title: "Microsoft Dynamics 365 Customer Engagement syncerror EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ba5ffe82-70bb-4b26-a55c-ebbeac2b52fa
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API syncerror entitytype."
---
# syncerror EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/syncerror.md](./descriptions/syncerror.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]syncerrors </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sync Error</td></tr>
<tr><td><b>Primary Key:</b></td><td>syncerrorid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The syncerror EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|action|Edm.String|**Display Name**: Action<br />**Description**: Action Name for which sync error has occurred<br />|
|actiondata|Edm.String|**Display Name**: Action Data<br />**Description**: Show the action data<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the sync Error was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Enter a short description of the sync error.<br />|
|errorcode|Edm.String|**Display Name**: Error Code<br />**Description**: Displays the error code.<br />|
|errordetail|Edm.String|**Display Name**: Error Detail<br />**Description**: Error description from the exception<br />|
|errormessage|Edm.String|**Display Name**: Error Message<br />**Description**: Error Message of the exception<br />|
|errortime|Edm.DateTimeOffset|**Display Name**: Error Time<br />**Description**: Date and time when the upsync request was executed on CRM server<br />|
|errortype|Edm.Int32|**Display Name**: Error Type<br />**Description**: Select the preferred error type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Conflict</td></tr><tr><td>1</td><td>Record not found</td></tr><tr><td>2</td><td>Record already exists</td></tr><tr><td>3</td><td>Others</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the sync error was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Entity<br />**Description**: Entity name of the record for which sync error has occurred<br />|
|requestdata|Edm.String|**Display Name**: Request Data<br />**Description**: Request data for the entity that had the sync error.<br />|
|statecode|Edm.Int32|**Display Name**: State<br />**Description**: Shows whether the sync error is active or resolved.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Resolved</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the sync error status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Fixed</td></tr><tbody></table>|
|syncerrorid|Edm.Guid|**Display Name**: Sync Error Id<br />**Description**: Unique identifier of the sync error.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Shows the version number of the sync error.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the sync error.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the sync error.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the sync error.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the sync error.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the sync error.|
|_owningbusinessunit_value|owningbusinessunit<br />|Business unit that owns the sync error.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the sync error.|
|_owninguser_value|regardingobjectid_systemuser<br />|Unique identifier of the user who owns the sync error.|
|_regardingobjectid_value|regardingobjectid_territory_syncerror<br />regardingobjectid_leadaddress<br />regardingobjectid_lead<br />regardingobjectid_dynamicproperty<br />regardingobjectid_dynamicpropertyassociation<br />regardingobjectid_dynamicpropertyinstance<br />regardingobjectid_dynamicpropertyoptionsetitem<br />regardingobjectid_pricelevel_syncerror<br />regardingobjectid_product_syncerror<br />regardingobjectid_productassociation_syncerror<br />regardingobjectid_productpricelevel<br />regardingobjectid_productsubstitute_syncerror<br />regardingobjectid_uom<br />regardingobjectid_uomschedule_syncerror<br />regardingobjectid_bookableresource_syncerror<br />regardingobjectid_bookableresourcebooking_syncerror<br />regardingobjectid_bookableresourcebookingheader_syncerror<br />regardingobjectid_bookableresourcecategory_syncerror<br />regardingobjectid_bookableresourcecategoryassn_syncerror<br />regardingobjectid_bookableresourcecharacteristic_syncerror<br />regardingobjectid_bookableresourcegroup_syncerror<br />regardingobjectid_bookingstatus_syncerror<br />regardingobjectid_characteristic_syncerror<br />regardingobjectid_ratingmodel_syncerror<br />regardingobjectid_ratingvalue_syncerror<br />regardingobjectid_bulkoperationlog<br />regardingobjectid_campaign_syncerror<br />regardingobjectid_list_syncerror<br />regardingobjectid_constraintbasedgroup<br />regardingobjectid_contract_syncerror<br />regardingobjectid_contractdetail_syncerror<br />regardingobjectid_contracttemplate_syncerror<br />regardingobjectid_entitlement_syncerror<br />regardingobjectid_entitlementchannel<br />regardingobjectid_entitlementtemplate_syncerror<br />regardingobjectid_entitlementtemplatechannel<br />regardingobjectid_equipment_syncerror<br />regardingobjectid_incident_syncerror<br />regardingobjectid_knowledgearticleincident_syncerror<br />regardingobjectid_PhoneToCaseProcess_syncerror<br />regardingobjectid_resource_syncerror<br />regardingobjectid_resourcegroup_syncerror<br />regardingobjectid_resourcespec<br />regardingobjectid_service_syncerror<br />regardingobjectid_site_syncerror<br />regardingobjectid_competitoraddress_syncerror<br />regardingobjectid_discount_syncerror<br />regardingobjectid_discounttype_syncerror<br />regardingobjectid_invoice_syncerror<br />regardingobjectid_invoicedetail_syncerror<br />regardingobjectid_LeadToOpportunitySalesProcess_syncerror<br />regardingobjectid_opportunity_syncerror<br />regardingobjectid_opportunityproduct_syncerror<br />regardingobjectid_OpportunitySalesProcess_syncerror<br />regardingobjectid_quote_syncerror<br />regardingobjectid_quotedetail_syncerror<br />regardingobjectid_salesliterature_syncerror<br />regardingobjectid_salesliteratureitem<br />regardingobjectid_salesorder_syncerror<br />regardingobjectid_salesorderdetail_syncerror<br />regardingobjectid_competitor_syncerror<br />regardingobjectid_adx_contentsnippet<br />regardingobjectid_adx_pagetemplate<br />regardingobjectid_adx_sitemarker<br />regardingobjectid_adx_sitesetting<br />regardingobjectid_adx_webfile<br />regardingobjectid_adx_weblink<br />regardingobjectid_adx_weblinkset<br />regardingobjectid_adx_webnotificationurl<br />regardingobjectid_adx_webpage<br />regardingobjectid_adx_webrole<br />regardingobjectid_adx_website<br />regardingobjectid_adx_ad<br />regardingobjectid_adx_adplacement<br />regardingobjectid_adx_entitypermission<br />regardingobjectid_adx_invitation<br />regardingobjectid_adx_pagealert<br />regardingobjectid_adx_pagenotification<br />regardingobjectid_adx_pagetag<br />regardingobjectid_adx_poll<br />regardingobjectid_adx_polloption<br />regardingobjectid_adx_pollplacement<br />regardingobjectid_adx_pollsubmission<br />regardingobjectid_adx_portallanguage<br />regardingobjectid_adx_publishingstate<br />regardingobjectid_adx_publishingstatetransitionrule<br />regardingobjectid_adx_redirect<br />regardingobjectid_adx_setting<br />regardingobjectid_adx_shortcut<br />regardingobjectid_adx_tag<br />regardingobjectid_adx_urlhistory<br />regardingobjectid_adx_webfilelog<br />regardingobjectid_adx_webpageaccesscontrolrule<br />regardingobjectid_adx_webpagehistory<br />regardingobjectid_adx_webpagelog<br />regardingobjectid_adx_websiteaccess<br />regardingobjectid_adx_websitebinding<br />regardingobjectid_adx_websitelanguage<br />regardingobjectid_adx_webtemplate<br />regardingobjectid_adx_webnotificationentity<br />regardingobjectid_adx_externalidentity<br />regardingobjectid_adx_entityform<br />regardingobjectid_adx_entityformmetadata<br />regardingobjectid_adx_entitylist<br />regardingobjectid_adx_webform<br />regardingobjectid_adx_webformmetadata<br />regardingobjectid_adx_webformsession<br />regardingobjectid_adx_webformstep<br />regardingobjectid_msdyn_actual<br />regardingobjectid_msdyn_bookingalertstatus<br />regardingobjectid_msdyn_bookingchange<br />regardingobjectid_msdyn_bookingrule<br />regardingobjectid_msdyn_bookingsetupmetadata<br />regardingobjectid_msdyn_organizationalunit<br />regardingobjectid_msdyn_priority<br />regardingobjectid_msdyn_requirementcharacteristic<br />regardingobjectid_msdyn_requirementorganizationunit<br />regardingobjectid_msdyn_requirementresourcecategory<br />regardingobjectid_msdyn_requirementresourcepreference<br />regardingobjectid_msdyn_requirementstatus<br />regardingobjectid_msdyn_resourcerequirement<br />regardingobjectid_msdyn_resourcerequirementdetail<br />regardingobjectid_msdyn_resourceterritory<br />regardingobjectid_msdyn_scheduleboardsetting<br />regardingobjectid_msdyn_schedulingparameter<br />regardingobjectid_msdyn_systemuserschedulersetting<br />regardingobjectid_msdyn_timegroup<br />regardingobjectid_msdyn_timegroupdetail<br />regardingobjectid_msdyn_transactionorigin<br />regardingobjectid_msdyn_workhourtemplate<br />regardingobjectid_msdyn_agreement<br />regardingobjectid_msdyn_agreementbookingdate<br />regardingobjectid_msdyn_agreementbookingincident<br />regardingobjectid_msdyn_agreementbookingproduct<br />regardingobjectid_msdyn_agreementbookingservice<br />regardingobjectid_msdyn_agreementbookingservicetask<br />regardingobjectid_msdyn_agreementbookingsetup<br />regardingobjectid_msdyn_agreementinvoicedate<br />regardingobjectid_msdyn_agreementinvoiceproduct<br />regardingobjectid_msdyn_agreementinvoicesetup<br />regardingobjectid_msdyn_agreementsubstatus<br />regardingobjectid_msdyn_bookingjournal<br />regardingobjectid_msdyn_bookingtimestamp<br />regardingobjectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />regardingobjectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />regardingobjectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />regardingobjectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39<br />regardingobjectid_msdyn_customerasset<br />regardingobjectid_msdyn_fieldservicepricelistitem<br />regardingobjectid_msdyn_fieldservicesetting<br />regardingobjectid_msdyn_fieldservicesystemjob<br />regardingobjectid_msdyn_incidenttype<br />regardingobjectid_msdyn_incidenttypecharacteristic<br />regardingobjectid_msdyn_incidenttypeproduct<br />regardingobjectid_msdyn_incidenttypeservice<br />regardingobjectid_msdyn_incidenttypeservicetask<br />regardingobjectid_msdyn_inventoryadjustment<br />regardingobjectid_msdyn_inventoryadjustmentproduct<br />regardingobjectid_msdyn_inventoryjournal<br />regardingobjectid_msdyn_inventorytransfer<br />regardingobjectid_msdyn_orderinvoicingdate<br />regardingobjectid_msdyn_orderinvoicingproduct<br />regardingobjectid_msdyn_orderinvoicingsetup<br />regardingobjectid_msdyn_orderinvoicingsetupdate<br />regardingobjectid_msdyn_payment<br />regardingobjectid_msdyn_paymentdetail<br />regardingobjectid_msdyn_paymentmethod<br />regardingobjectid_msdyn_paymentterm<br />regardingobjectid_msdyn_postalcode<br />regardingobjectid_msdyn_productinventory<br />regardingobjectid_msdyn_purchaseorder<br />regardingobjectid_msdyn_purchaseorderbill<br />regardingobjectid_msdyn_purchaseorderproduct<br />regardingobjectid_msdyn_purchaseorderreceipt<br />regardingobjectid_msdyn_purchaseorderreceiptproduct<br />regardingobjectid_msdyn_purchaseordersubstatus<br />regardingobjectid_msdyn_quotebookingincident<br />regardingobjectid_msdyn_quotebookingproduct<br />regardingobjectid_msdyn_quotebookingservice<br />regardingobjectid_msdyn_quotebookingservicetask<br />regardingobjectid_msdyn_quotebookingsetup<br />regardingobjectid_msdyn_quoteinvoicingproduct<br />regardingobjectid_msdyn_quoteinvoicingsetup<br />regardingobjectid_msdyn_resourcepaytype<br />regardingobjectid_msdyn_rma<br />regardingobjectid_msdyn_rmaproduct<br />regardingobjectid_msdyn_rmareceipt<br />regardingobjectid_msdyn_rmareceiptproduct<br />regardingobjectid_msdyn_rmasubstatus<br />regardingobjectid_msdyn_rtv<br />regardingobjectid_msdyn_rtvproduct<br />regardingobjectid_msdyn_rtvsubstatus<br />regardingobjectid_msdyn_servicetasktype<br />regardingobjectid_msdyn_shipvia<br />regardingobjectid_msdyn_taxcode<br />regardingobjectid_msdyn_taxcodedetail<br />regardingobjectid_msdyn_timeoffrequest<br />regardingobjectid_msdyn_uniquenumber<br />regardingobjectid_msdyn_warehouse<br />regardingobjectid_msdyn_workorder<br />regardingobjectid_msdyn_workordercharacteristic<br />regardingobjectid_msdyn_workorderdetailsgenerationqueue<br />regardingobjectid_msdyn_workorderincident<br />regardingobjectid_msdyn_workorderproduct<br />regardingobjectid_msdyn_workorderresourcerestriction<br />regardingobjectid_msdyn_workorderservice<br />regardingobjectid_msdyn_workorderservicetask<br />regardingobjectid_msdyn_workordersubstatus<br />regardingobjectid_msdyn_workordertype<br />regardingobjectid_msdyn_glympseagent<br />regardingobjectid_msdyn_glympsesetting<br />regardingobjectid_msdyn_glympsetask<br />regardingobjectid_msdyn_iotalert<br />regardingobjectid_msdyn_iotdevice<br />regardingobjectid_msdyn_iotdevicecategory<br />regardingobjectid_msdyn_iotdevicecommand<br />regardingobjectid_msdyn_iotdeviceregistrationhistory<br />regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />regardingobjectid_msdyn_accountpricelist<br />regardingobjectid_msdyn_batchjob<br />regardingobjectid_msdyn_characteristicreqforteammember<br />regardingobjectid_msdyn_contactpricelist<br />regardingobjectid_msdyn_contractlineinvoiceschedule<br />regardingobjectid_msdyn_contractlinescheduleofvalue<br />regardingobjectid_msdyn_dataexport<br />regardingobjectid_msdyn_delegation<br />regardingobjectid_msdyn_estimate<br />regardingobjectid_msdyn_estimateline<br />regardingobjectid_msdyn_expense<br />regardingobjectid_msdyn_expensecategory<br />regardingobjectid_msdyn_expensereceipt<br />regardingobjectid_msdyn_fact<br />regardingobjectid_msdyn_fieldcomputation<br />regardingobjectid_msdyn_findworkevent<br />regardingobjectid_msdyn_integrationjob<br />regardingobjectid_msdyn_integrationjobdetail<br />regardingobjectid_msdyn_invoicefrequency<br />regardingobjectid_msdyn_invoicefrequencydetail<br />regardingobjectid_msdyn_invoicelinetransaction<br />regardingobjectid_msdyn_journal<br />regardingobjectid_msdyn_journalline<br />regardingobjectid_msdyn_mlresultcache<br />regardingobjectid_msdyn_opportunitylineresourcecategory<br />regardingobjectid_msdyn_opportunitylinetransaction<br />regardingobjectid_msdyn_opportunitylinetransactioncategory<br />regardingobjectid_msdyn_opportunitylinetransactionclassificatio<br />regardingobjectid_msdyn_opportunitypricelist<br />regardingobjectid_msdyn_orderlineresourcecategory<br />regardingobjectid_msdyn_orderlinetransaction<br />regardingobjectid_msdyn_orderlinetransactioncategory<br />regardingobjectid_msdyn_orderlinetransactionclassification<br />regardingobjectid_msdyn_orderpricelist<br />regardingobjectid_msdyn_processnotes<br />regardingobjectid_msdyn_project<br />regardingobjectid_msdyn_projectapproval<br />regardingobjectid_msdyn_projectparameter<br />regardingobjectid_msdyn_projectparameterpricelist<br />regardingobjectid_msdyn_projectpricelist<br />regardingobjectid_msdyn_projecttask<br />regardingobjectid_msdyn_projecttaskdependency<br />regardingobjectid_msdyn_projecttaskstatususer<br />regardingobjectid_msdyn_projectteam<br />regardingobjectid_msdyn_projectteammembersignup<br />regardingobjectid_msdyn_projecttransactioncategory<br />regardingobjectid_msdyn_quotelineanalyticsbreakdown<br />regardingobjectid_msdyn_quotelineinvoiceschedule<br />regardingobjectid_msdyn_quotelineresourcecategory<br />regardingobjectid_msdyn_quotelinescheduleofvalue<br />regardingobjectid_msdyn_quotelinetransaction<br />regardingobjectid_msdyn_quotelinetransactioncategory<br />regardingobjectid_msdyn_quotelinetransactionclassification<br />regardingobjectid_msdyn_quotepricelist<br />regardingobjectid_msdyn_resourceassignment<br />regardingobjectid_msdyn_resourceassignmentdetail<br />regardingobjectid_msdyn_resourcecategorypricelevel<br />regardingobjectid_msdyn_resourcerequest<br />regardingobjectid_msdyn_rolecompetencyrequirement<br />regardingobjectid_msdyn_roleutilization<br />regardingobjectid_msdyn_timeentry<br />regardingobjectid_msdyn_timeoffcalendar<br />regardingobjectid_msdyn_transactioncategory<br />regardingobjectid_msdyn_transactioncategoryclassification<br />regardingobjectid_msdyn_transactioncategoryhierarchyelement<br />regardingobjectid_msdyn_transactioncategorypricelevel<br />regardingobjectid_msdyn_transactionconnection<br />regardingobjectid_msdyn_transactiontype<br />regardingobjectid_msdyn_userworkhistory<br />regardingobjectid_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d<br />regardingobjectid_msdyn_bpf_665e73aa18c247d886bfc50499c73b82<br />regardingobjectid_msdyn_collaboration<br />regardingobjectid_msdyn_groupsheader<br />regardingobjectid_msdyn_pendinggroupmembers<br />regardingobjectid_msdyn_optimizationrequestbooking<br />regardingobjectid_msdyn_routingengineconfiguration<br />regardingobjectid_msdyn_routingjobconfiguration<br />regardingobjectid_msdyn_routingoptimizationrequest<br />regardingobjectid_msdyn_routingprofileconfiguration<br />regardingobjectid_msdyn_schedulingoptimizationhealthlog<br />regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate<br />regardingobjectid_msdyncrm_campaigncustomchannelactivity<br />regardingobjectid_msdyncrm_contentsettings<br />regardingobjectid_msdyncrm_customerinsightsinfo<br />regardingobjectid_msdyncrm_customerjourney<br />regardingobjectid_msdyncrm_customerjourneyiteration<br />regardingobjectid_msdyncrm_customerjourneytemplate<br />regardingobjectid_msdyncrm_customerjourneyworkflowlink<br />regardingobjectid_msdyncrm_file<br />regardingobjectid_msdyncrm_formpage<br />regardingobjectid_msdyncrm_formpagetemplate<br />regardingobjectid_msdyncrm_geopin<br />regardingobjectid_msdyncrm_keyword<br />regardingobjectid_msdyncrm_marketingconfiguration<br />regardingobjectid_msdyncrm_marketingdynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemail<br />regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemailtemplate<br />regardingobjectid_msdyncrm_marketingemailtestsend<br />regardingobjectid_msdyncrm_marketingform<br />regardingobjectid_msdyncrm_marketingformfield<br />regardingobjectid_msdyncrm_marketingformtemplate<br />regardingobjectid_msdyncrm_marketingpage<br />regardingobjectid_msdyncrm_marketingpageconfiguration<br />regardingobjectid_msdyncrm_marketingpagetemplate<br />regardingobjectid_msdyncrm_matchingstrategy<br />regardingobjectid_msdyncrm_mktactivity<br />regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate<br />regardingobjectid_msdyncrm_portalsettings<br />regardingobjectid_msdyncrm_redirecturl<br />regardingobjectid_msdyncrm_segment<br />regardingobjectid_msdyncrm_taskactivitymarketingtemplate<br />regardingobjectid_msdyncrm_uicconfig<br />regardingobjectid_msdyncrm_usergeoregion<br />regardingobjectid_msdyncrm_website<br />regardingobjectid_msdyncrm_leadscore<br />regardingobjectid_msdyncrm_leadscoremodel<br />regardingobjectid_msdyncrm_leadtoopportunity<br />regardingobjectid_msdyn_answer<br />regardingobjectid_msdyn_azuredeployment<br />regardingobjectid_msdyn_feedbackmapping<br />regardingobjectid_msdyn_feedbacksubsurvey<br />regardingobjectid_msdyn_image<br />regardingobjectid_msdyn_imagetokencache<br />regardingobjectid_msdyn_import<br />regardingobjectid_msdyn_linkedanswer<br />regardingobjectid_msdyn_page<br />regardingobjectid_msdyn_question<br />regardingobjectid_msdyn_questiongroup<br />regardingobjectid_msdyn_questionresponse<br />regardingobjectid_msdyn_questiontype<br />regardingobjectid_msdyn_responseaction<br />regardingobjectid_msdyn_responseblobstore<br />regardingobjectid_msdyn_responsecondition<br />regardingobjectid_msdyn_responseoutcome<br />regardingobjectid_msdyn_responserouting<br />regardingobjectid_msdyn_section<br />regardingobjectid_msdyn_survey<br />regardingobjectid_msdyn_surveylog<br />regardingobjectid_msdyn_surveyresponse<br />regardingobjectid_msdyn_theme<br />regardingobjectid_msdyn_vocconfiguration<br />regardingobjectid_msevtmgt_attendeepass<br />regardingobjectid_msevtmgt_authenticationsettings<br />regardingobjectid_msevtmgt_building<br />regardingobjectid_msevtmgt_checkin<br />regardingobjectid_msevtmgt_entitycounter<br />regardingobjectid_msevtmgt_event<br />regardingobjectid_msevtmgt_eventadministration<br />regardingobjectid_msevtmgt_eventmanagementconfiguration<br />regardingobjectid_msevtmgt_eventpurchase<br />regardingobjectid_msevtmgt_eventpurchaseattendee<br />regardingobjectid_msevtmgt_eventpurchasepass<br />regardingobjectid_msevtmgt_eventregistration<br />regardingobjectid_msevtmgt_eventteammember<br />regardingobjectid_msevtmgt_eventvendor<br />regardingobjectid_msevtmgt_hotel<br />regardingobjectid_msevtmgt_hotelroomallocation<br />regardingobjectid_msevtmgt_hotelroomreservation<br />regardingobjectid_msevtmgt_layout<br />regardingobjectid_msevtmgt_pass<br />regardingobjectid_msevtmgt_room<br />regardingobjectid_msevtmgt_session<br />regardingobjectid_msevtmgt_sessionregistration<br />regardingobjectid_msevtmgt_sessiontrack<br />regardingobjectid_msevtmgt_speaker<br />regardingobjectid_msevtmgt_speakerengagement<br />regardingobjectid_msevtmgt_sponsorablearticle<br />regardingobjectid_msevtmgt_sponsorship<br />regardingobjectid_msevtmgt_venue<br />regardingobjectid_msevtmgt_webinarconfiguration<br />regardingobjectid_msevtmgt_webinarconsent<br />regardingobjectid_msevtmgt_webinarprovider<br />regardingobjectid_msevtmgt_webinartype<br />regardingobjectid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99<br />regardingobjectid_msdyncrm_linkedinaccount<br />regardingobjectid_msdyncrm_linkedinactivity<br />regardingobjectid_msdyncrm_linkedincampaign<br />regardingobjectid_msdyncrm_linkedinconfiguration<br />regardingobjectid_msdyncrm_linkedinfieldmapping<br />regardingobjectid_msdyncrm_linkedinform<br />regardingobjectid_msdyncrm_linkedinformanswer<br />regardingobjectid_msdyncrm_linkedinformquestion<br />regardingobjectid_msdyncrm_linkedinformsubmission<br />regardingobjectid_msdyncrm_linkedinleadmatchingstrategy<br />regardingobjectid_msdyncrm_linkedinuserprofile<br />regardingobjectid_ExpiredProcess_syncerror<br />regardingobjectid_businessunit_syncerror<br />regardingobjectid_knowledgearticleviews_syncerror<br />regardingobjectid_TranslationProcess_syncerror<br />regardingobjectid_account_syncerror<br />regardingobjectid_publisher_syncerror<br />regardingobjectid_activitymimeattachment_syncerror<br />regardingobjectid_userqueryvisualization_syncerror<br />regardingobjectid_savedqueryvisualization_syncerror<br />regardingobjectid_attachment_syncerror<br />regardingobjectid_systemuser_syncerror<br />regardingobjectid_fieldsecurityprofile_syncerror<br />regardingobjectid_importmap_syncerror<br />regardingobjectid_activityparty_syncerror<br />regardingobjectid_fieldpermission_syncerror<br />regardingobjectid_processstage_syncerror<br />regardingobjectid_duplicaterulecondition_syncerror<br />regardingobjectid_duplicaterule_syncerror<br />regardingobjectid_sla_syncerror<br />regardingobjectid_knowledgearticle_syncerror<br />regardingobjectid_knowledgebaserecord_syncerror<br />regardingobjectid_reportcategory_syncerror<br />regardingobjectid_contact_syncerror<br />regardingobjectid_report_syncerror<br />regardingobjectid_category_syncerror<br />regardingobjectid_team_syncerror<br />regardingobjectid_organization_syncerror<br />regardingobjectid_queueitem_syncerror<br />regardingobjectid_connectionrole_syncerror<br />regardingobjectid_userquery_syncerror<br />regardingobjectid_solution_syncerror<br />regardingobjectid_mailbox_syncerror<br />regardingobjectid_goal_syncerror<br />regardingobjectid_socialprofile_syncerror<br />regardingobjectid_savedquery_syncerror<br />regardingobjectid_kbarticletemplate_syncerror<br />regardingobjectid_syncerror_syncerror<br />regardingobjectid_postfollow_syncerror<br />regardingobjectid_customeraddress_syncerror<br />regardingobjectid_mailmergetemplate_syncerror<br />regardingobjectid_subject_syncerror<br />regardingobjectid_workflow_syncerror<br />regardingobjectid_queue_syncerror<br />regardingobjectid_position_syncerror<br />regardingobjectid_annotation_syncerror<br />regardingobjectid_connection_syncerror<br />regardingobjectid_kbarticle_syncerror<br />regardingobjectid_slaitem_syncerror<br />regardingobjectid_template_syncerror<br />regardingobjectid_feedback_syncerror<br />regardingobjectid_metric_syncerror<br />regardingobjectid_slakpiinstance_syncerror<br />regardingobjectid_sharepointsite_syncerror<br />regardingobjectid_NewProcess_syncerror<br />regardingobjectid_sharepointdocumentlocation_syncerror<br />regardingobjectid_teamtemplate_syncerror<br />regardingobjectid_role_syncerror<br />regardingobjectid_emailserverprofile_syncerror<br />regardingobjectid_goalrollupquery_syncerror<br />regardingobjectid_transactioncurrency_syncerror<br />|Choose the record that the sync error relates to.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_syncerrorbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_syncerrorbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_syncerrorbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_syncerrorbase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_SyncError|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_SyncError|
|owningteam|[team EntityType](team.md)|team_SyncError|
|regardingobjectid_account_syncerror|[account EntityType](account.md)|Account_SyncErrors|
|regardingobjectid_activitymimeattachment_syncerror|[activitymimeattachment EntityType](activitymimeattachment.md)|ActivityMimeAttachment_SyncErrors|
|regardingobjectid_activityparty_syncerror|[activityparty EntityType](activityparty.md)|ActivityParty_SyncErrors|
|regardingobjectid_adx_ad|[adx_ad EntityType](adx_ad.md)|adx_ad_SyncErrors|
|regardingobjectid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_SyncErrors|
|regardingobjectid_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_SyncErrors|
|regardingobjectid_adx_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|adx_contentsnippet_SyncErrors|
|regardingobjectid_adx_entityform|[adx_entityform EntityType](adx_entityform.md)|adx_entityform_SyncErrors|
|regardingobjectid_adx_entityformmetadata|[adx_entityformmetadata EntityType](adx_entityformmetadata.md)|adx_entityformmetadata_SyncErrors|
|regardingobjectid_adx_entitylist|[adx_entitylist EntityType](adx_entitylist.md)|adx_entitylist_SyncErrors|
|regardingobjectid_adx_entitypermission|[adx_entitypermission EntityType](adx_entitypermission.md)|adx_entitypermission_SyncErrors|
|regardingobjectid_adx_externalidentity|[adx_externalidentity EntityType](adx_externalidentity.md)|adx_externalidentity_SyncErrors|
|regardingobjectid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_SyncErrors|
|regardingobjectid_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_SyncErrors|
|regardingobjectid_adx_pagealert|[adx_pagealert EntityType](adx_pagealert.md)|adx_pagealert_SyncErrors|
|regardingobjectid_adx_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|adx_pagenotification_SyncErrors|
|regardingobjectid_adx_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|adx_pagetag_SyncErrors|
|regardingobjectid_adx_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|adx_pagetemplate_SyncErrors|
|regardingobjectid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_SyncErrors|
|regardingobjectid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_SyncErrors|
|regardingobjectid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_SyncErrors|
|regardingobjectid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_SyncErrors|
|regardingobjectid_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|adx_portalcomment_SyncErrors|
|regardingobjectid_adx_portallanguage|[adx_portallanguage EntityType](adx_portallanguage.md)|adx_portallanguage_SyncErrors|
|regardingobjectid_adx_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_publishingstate_SyncErrors|
|regardingobjectid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_SyncErrors|
|regardingobjectid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_SyncErrors|
|regardingobjectid_adx_setting|[adx_setting EntityType](adx_setting.md)|adx_setting_SyncErrors|
|regardingobjectid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_SyncErrors|
|regardingobjectid_adx_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|adx_sitemarker_SyncErrors|
|regardingobjectid_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|adx_sitesetting_SyncErrors|
|regardingobjectid_adx_tag|[adx_tag EntityType](adx_tag.md)|adx_tag_SyncErrors|
|regardingobjectid_adx_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|adx_urlhistory_SyncErrors|
|regardingobjectid_adx_webfile|[adx_webfile EntityType](adx_webfile.md)|adx_webfile_SyncErrors|
|regardingobjectid_adx_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|adx_webfilelog_SyncErrors|
|regardingobjectid_adx_webform|[adx_webform EntityType](adx_webform.md)|adx_webform_SyncErrors|
|regardingobjectid_adx_webformmetadata|[adx_webformmetadata EntityType](adx_webformmetadata.md)|adx_webformmetadata_SyncErrors|
|regardingobjectid_adx_webformsession|[adx_webformsession EntityType](adx_webformsession.md)|adx_webformsession_SyncErrors|
|regardingobjectid_adx_webformstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformstep_SyncErrors|
|regardingobjectid_adx_weblink|[adx_weblink EntityType](adx_weblink.md)|adx_weblink_SyncErrors|
|regardingobjectid_adx_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|adx_weblinkset_SyncErrors|
|regardingobjectid_adx_webnotificationentity|[adx_webnotificationentity EntityType](adx_webnotificationentity.md)|adx_webnotificationentity_SyncErrors|
|regardingobjectid_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|adx_webnotificationurl_SyncErrors|
|regardingobjectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_SyncErrors|
|regardingobjectid_adx_webpageaccesscontrolrule|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|adx_webpageaccesscontrolrule_SyncErrors|
|regardingobjectid_adx_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|adx_webpagehistory_SyncErrors|
|regardingobjectid_adx_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|adx_webpagelog_SyncErrors|
|regardingobjectid_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_webrole_SyncErrors|
|regardingobjectid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_SyncErrors|
|regardingobjectid_adx_websiteaccess|[adx_websiteaccess EntityType](adx_websiteaccess.md)|adx_websiteaccess_SyncErrors|
|regardingobjectid_adx_websitebinding|[adx_websitebinding EntityType](adx_websitebinding.md)|adx_websitebinding_SyncErrors|
|regardingobjectid_adx_websitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|adx_websitelanguage_SyncErrors|
|regardingobjectid_adx_webtemplate|[adx_webtemplate EntityType](adx_webtemplate.md)|adx_webtemplate_SyncErrors|
|regardingobjectid_annotation_syncerror|[annotation EntityType](annotation.md)|Annotation_SyncErrors|
|regardingobjectid_appointment_syncerror|[appointment EntityType](appointment.md)|Appointment_SyncErrors|
|regardingobjectid_attachment_syncerror|[attachment EntityType](attachment.md)|Attachment_SyncErrors|
|regardingobjectid_bookableresource_syncerror|[bookableresource EntityType](bookableresource.md)|BookableResource_SyncErrors|
|regardingobjectid_bookableresourcebooking_syncerror|[bookableresourcebooking EntityType](bookableresourcebooking.md)|BookableResourceBooking_SyncErrors|
|regardingobjectid_bookableresourcebookingheader_syncerror|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|BookableResourceBookingHeader_SyncErrors|
|regardingobjectid_bookableresourcecategory_syncerror|[bookableresourcecategory EntityType](bookableresourcecategory.md)|BookableResourceCategory_SyncErrors|
|regardingobjectid_bookableresourcecategoryassn_syncerror|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|BookableResourceCategoryAssn_SyncErrors|
|regardingobjectid_bookableresourcecharacteristic_syncerror|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|BookableResourceCharacteristic_SyncErrors|
|regardingobjectid_bookableresourcegroup_syncerror|[bookableresourcegroup EntityType](bookableresourcegroup.md)|BookableResourceGroup_SyncErrors|
|regardingobjectid_bookingstatus_syncerror|[bookingstatus EntityType](bookingstatus.md)|BookingStatus_SyncErrors|
|regardingobjectid_bulkoperation_syncerror|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_SyncErrors|
|regardingobjectid_bulkoperationlog|[bulkoperationlog EntityType](bulkoperationlog.md)|bulkoperationlog_SyncErrors|
|regardingobjectid_businessunit_syncerror|[businessunit EntityType](businessunit.md)|BusinessUnit_SyncErrors|
|regardingobjectid_campaign_syncerror|[campaign EntityType](campaign.md)|Campaign_SyncErrors|
|regardingobjectid_campaignactivity_syncerror|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_SyncErrors|
|regardingobjectid_campaignresponse_syncerror|[campaignresponse EntityType](campaignresponse.md)|CampaignResponse_SyncErrors|
|regardingobjectid_category_syncerror|[category EntityType](category.md)|Category_SyncErrors|
|regardingobjectid_characteristic_syncerror|[characteristic EntityType](characteristic.md)|Characteristic_SyncErrors|
|regardingobjectid_competitor_syncerror|[competitor EntityType](competitor.md)|Competitor_SyncErrors|
|regardingobjectid_competitoraddress_syncerror|[competitoraddress EntityType](competitoraddress.md)|CompetitorAddress_SyncErrors|
|regardingobjectid_connection_syncerror|[connection EntityType](connection.md)|Connection_SyncErrors|
|regardingobjectid_connectionrole_syncerror|[connectionrole EntityType](connectionrole.md)|ConnectionRole_SyncErrors|
|regardingobjectid_constraintbasedgroup|[constraintbasedgroup EntityType](constraintbasedgroup.md)|constraintbasedgroup_SyncErrors|
|regardingobjectid_contact_syncerror|[contact EntityType](contact.md)|Contact_SyncErrors|
|regardingobjectid_contract_syncerror|[contract EntityType](contract.md)|Contract_SyncErrors|
|regardingobjectid_contractdetail_syncerror|[contractdetail EntityType](contractdetail.md)|ContractDetail_SyncErrors|
|regardingobjectid_contracttemplate_syncerror|[contracttemplate EntityType](contracttemplate.md)|ContractTemplate_SyncErrors|
|regardingobjectid_customeraddress_syncerror|[customeraddress EntityType](customeraddress.md)|CustomerAddress_SyncErrors|
|regardingobjectid_discount_syncerror|[discount EntityType](discount.md)|Discount_SyncErrors|
|regardingobjectid_discounttype_syncerror|[discounttype EntityType](discounttype.md)|DiscountType_SyncErrors|
|regardingobjectid_duplicaterule_syncerror|[duplicaterule EntityType](duplicaterule.md)|DuplicateRule_SyncErrors|
|regardingobjectid_duplicaterulecondition_syncerror|[duplicaterulecondition EntityType](duplicaterulecondition.md)|DuplicateRuleCondition_SyncErrors|
|regardingobjectid_dynamicproperty|[dynamicproperty EntityType](dynamicproperty.md)|dynamicproperty_SyncErrors|
|regardingobjectid_dynamicpropertyassociation|[dynamicpropertyassociation EntityType](dynamicpropertyassociation.md)|dynamicpropertyassociation_SyncErrors|
|regardingobjectid_dynamicpropertyinstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|dynamicpropertyinstance_SyncErrors|
|regardingobjectid_dynamicpropertyoptionsetitem|[dynamicpropertyoptionsetitem EntityType](dynamicpropertyoptionsetitem.md)|dynamicpropertyoptionsetitem_SyncErrors|
|regardingobjectid_email_syncerror|[email EntityType](email.md)|Email_SyncErrors|
|regardingobjectid_emailserverprofile_syncerror|[emailserverprofile EntityType](emailserverprofile.md)|EmailServerProfile_SyncErrors|
|regardingobjectid_entitlement_syncerror|[entitlement EntityType](entitlement.md)|Entitlement_SyncErrors|
|regardingobjectid_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|entitlementchannel_SyncErrors|
|regardingobjectid_entitlementtemplate_syncerror|[entitlementtemplate EntityType](entitlementtemplate.md)|EntitlementTemplate_SyncErrors|
|regardingobjectid_entitlementtemplatechannel|[entitlementtemplatechannel EntityType](entitlementtemplatechannel.md)|entitlementtemplatechannel_SyncErrors|
|regardingobjectid_equipment_syncerror|[equipment EntityType](equipment.md)|Equipment_SyncErrors|
|regardingobjectid_ExpiredProcess_syncerror|[expiredprocess EntityType](expiredprocess.md)|ExpiredProcess_SyncErrors|
|regardingobjectid_fax_syncerror|[fax EntityType](fax.md)|Fax_SyncErrors|
|regardingobjectid_feedback_syncerror|[feedback EntityType](feedback.md)|Feedback_SyncErrors|
|regardingobjectid_fieldpermission_syncerror|[fieldpermission EntityType](fieldpermission.md)|FieldPermission_SyncErrors|
|regardingobjectid_fieldsecurityprofile_syncerror|[fieldsecurityprofile EntityType](fieldsecurityprofile.md)|FieldSecurityProfile_SyncErrors|
|regardingobjectid_goal_syncerror|[goal EntityType](goal.md)|Goal_SyncErrors|
|regardingobjectid_goalrollupquery_syncerror|[goalrollupquery EntityType](goalrollupquery.md)|GoalRollupQuery_SyncErrors|
|regardingobjectid_importmap_syncerror|[importmap EntityType](importmap.md)|ImportMap_SyncErrors|
|regardingobjectid_incident_syncerror|[incident EntityType](incident.md)|Incident_SyncErrors|
|regardingobjectid_incidentresolution_syncerror|[incidentresolution EntityType](incidentresolution.md)|IncidentResolution_SyncErrors|
|regardingobjectid_invoice_syncerror|[invoice EntityType](invoice.md)|Invoice_SyncErrors|
|regardingobjectid_invoicedetail_syncerror|[invoicedetail EntityType](invoicedetail.md)|InvoiceDetail_SyncErrors|
|regardingobjectid_kbarticle_syncerror|[kbarticle EntityType](kbarticle.md)|KbArticle_SyncErrors|
|regardingobjectid_kbarticletemplate_syncerror|[kbarticletemplate EntityType](kbarticletemplate.md)|KbArticleTemplate_SyncErrors|
|regardingobjectid_knowledgearticle_syncerror|[knowledgearticle EntityType](knowledgearticle.md)|KnowledgeArticle_SyncErrors|
|regardingobjectid_knowledgearticleincident_syncerror|[knowledgearticleincident EntityType](knowledgearticleincident.md)|KnowledgeArticleIncident_SyncErrors|
|regardingobjectid_knowledgearticleviews_syncerror|[knowledgearticleviews EntityType](knowledgearticleviews.md)|KnowledgeArticleViews_SyncErrors|
|regardingobjectid_knowledgebaserecord_syncerror|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_SyncErrors|
|regardingobjectid_lead|[lead EntityType](lead.md)|Lead_SyncErrors|
|regardingobjectid_leadaddress|[leadaddress EntityType](leadaddress.md)|LeadAddress_SyncErrors|
|regardingobjectid_LeadToOpportunitySalesProcess_syncerror|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|LeadToOpportunitySalesProcess_SyncErrors|
|regardingobjectid_letter_syncerror|[letter EntityType](letter.md)|Letter_SyncErrors|
|regardingobjectid_list_syncerror|[list EntityType](list.md)|List_SyncErrors|
|regardingobjectid_mailbox_syncerror|[mailbox EntityType](mailbox.md)|Mailbox_SyncErrors|
|regardingobjectid_mailmergetemplate_syncerror|[mailmergetemplate EntityType](mailmergetemplate.md)|MailMergeTemplate_SyncErrors|
|regardingobjectid_metric_syncerror|[metric EntityType](metric.md)|Metric_SyncErrors|
|regardingobjectid_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|msdyn_accountpricelist_SyncErrors|
|regardingobjectid_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_actual_SyncErrors|
|regardingobjectid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_SyncErrors|
|regardingobjectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_SyncErrors|
|regardingobjectid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_SyncErrors|
|regardingobjectid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_SyncErrors|
|regardingobjectid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_SyncErrors|
|regardingobjectid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_SyncErrors|
|regardingobjectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_SyncErrors|
|regardingobjectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_SyncErrors|
|regardingobjectid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_SyncErrors|
|regardingobjectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_SyncErrors|
|regardingobjectid_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|msdyn_agreementsubstatus_SyncErrors|
|regardingobjectid_msdyn_answer|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_answer_SyncErrors|
|regardingobjectid_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_SyncErrors|
|regardingobjectid_msdyn_azuredeployment|[msdyn_azuredeployment EntityType](msdyn_azuredeployment.md)|msdyn_azuredeployment_SyncErrors|
|regardingobjectid_msdyn_batchjob|[msdyn_batchjob EntityType](msdyn_batchjob.md)|msdyn_batchjob_SyncErrors|
|regardingobjectid_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_SyncErrors|
|regardingobjectid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_SyncErrors|
|regardingobjectid_msdyn_bookingchange|[msdyn_bookingchange EntityType](msdyn_bookingchange.md)|msdyn_bookingchange_SyncErrors|
|regardingobjectid_msdyn_bookingjournal|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|msdyn_bookingjournal_SyncErrors|
|regardingobjectid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_SyncErrors|
|regardingobjectid_msdyn_bookingsetupmetadata|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|msdyn_bookingsetupmetadata_SyncErrors|
|regardingobjectid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_SyncErrors|
|regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_SyncErrors|
|regardingobjectid_msdyn_collaboration|[msdyn_collaboration EntityType](msdyn_collaboration.md)|msdyn_collaboration_SyncErrors|
|regardingobjectid_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|msdyn_contactpricelist_SyncErrors|
|regardingobjectid_msdyn_contractlineinvoiceschedule|[msdyn_contractlineinvoiceschedule EntityType](msdyn_contractlineinvoiceschedule.md)|msdyn_contractlineinvoiceschedule_SyncErrors|
|regardingobjectid_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_contractlinescheduleofvalue_SyncErrors|
|regardingobjectid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_SyncErrors|
|regardingobjectid_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|msdyn_dataexport_SyncErrors|
|regardingobjectid_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|msdyn_delegation_SyncErrors|
|regardingobjectid_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|msdyn_estimate_SyncErrors|
|regardingobjectid_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_estimateline_SyncErrors|
|regardingobjectid_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_expense_SyncErrors|
|regardingobjectid_msdyn_expensecategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_expensecategory_SyncErrors|
|regardingobjectid_msdyn_expensereceipt|[msdyn_expensereceipt EntityType](msdyn_expensereceipt.md)|msdyn_expensereceipt_SyncErrors|
|regardingobjectid_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_fact_SyncErrors|
|regardingobjectid_msdyn_feedbackmapping|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|msdyn_feedbackmapping_SyncErrors|
|regardingobjectid_msdyn_feedbacksubsurvey|[msdyn_feedbacksubsurvey EntityType](msdyn_feedbacksubsurvey.md)|msdyn_feedbacksubsurvey_SyncErrors|
|regardingobjectid_msdyn_fieldcomputation|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|msdyn_fieldcomputation_SyncErrors|
|regardingobjectid_msdyn_fieldservicepricelistitem|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|msdyn_fieldservicepricelistitem_SyncErrors|
|regardingobjectid_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_SyncErrors|
|regardingobjectid_msdyn_fieldservicesystemjob|[msdyn_fieldservicesystemjob EntityType](msdyn_fieldservicesystemjob.md)|msdyn_fieldservicesystemjob_SyncErrors|
|regardingobjectid_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|msdyn_findworkevent_SyncErrors|
|regardingobjectid_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_glympseagent_SyncErrors|
|regardingobjectid_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|msdyn_glympsesetting_SyncErrors|
|regardingobjectid_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_glympsetask_SyncErrors|
|regardingobjectid_msdyn_groupsheader|[msdyn_groupsheader EntityType](msdyn_groupsheader.md)|msdyn_groupsheader_SyncErrors|
|regardingobjectid_msdyn_image|[msdyn_image EntityType](msdyn_image.md)|msdyn_image_SyncErrors|
|regardingobjectid_msdyn_imagetokencache|[msdyn_imagetokencache EntityType](msdyn_imagetokencache.md)|msdyn_imagetokencache_SyncErrors|
|regardingobjectid_msdyn_import|[msdyn_import EntityType](msdyn_import.md)|msdyn_import_SyncErrors|
|regardingobjectid_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_incidenttype_SyncErrors|
|regardingobjectid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_SyncErrors|
|regardingobjectid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_SyncErrors|
|regardingobjectid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_SyncErrors|
|regardingobjectid_msdyn_incidenttypeservicetask|[msdyn_incidenttypeservicetask EntityType](msdyn_incidenttypeservicetask.md)|msdyn_incidenttypeservicetask_SyncErrors|
|regardingobjectid_msdyn_integrationjob|[msdyn_integrationjob EntityType](msdyn_integrationjob.md)|msdyn_integrationjob_SyncErrors|
|regardingobjectid_msdyn_integrationjobdetail|[msdyn_integrationjobdetail EntityType](msdyn_integrationjobdetail.md)|msdyn_integrationjobdetail_SyncErrors|
|regardingobjectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_SyncErrors|
|regardingobjectid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_SyncErrors|
|regardingobjectid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_SyncErrors|
|regardingobjectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_SyncErrors|
|regardingobjectid_msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|msdyn_invoicefrequency_SyncErrors|
|regardingobjectid_msdyn_invoicefrequencydetail|[msdyn_invoicefrequencydetail EntityType](msdyn_invoicefrequencydetail.md)|msdyn_invoicefrequencydetail_SyncErrors|
|regardingobjectid_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_invoicelinetransaction_SyncErrors|
|regardingobjectid_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_iotalert_SyncErrors|
|regardingobjectid_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_iotdevice_SyncErrors|
|regardingobjectid_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_iotdevicecategory_SyncErrors|
|regardingobjectid_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_iotdevicecommand_SyncErrors|
|regardingobjectid_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_iotdeviceregistrationhistory_SyncErrors|
|regardingobjectid_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|msdyn_journal_SyncErrors|
|regardingobjectid_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_journalline_SyncErrors|
|regardingobjectid_msdyn_linkedanswer|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_linkedanswer_SyncErrors|
|regardingobjectid_msdyn_mlresultcache|[msdyn_mlresultcache EntityType](msdyn_mlresultcache.md)|msdyn_mlresultcache_SyncErrors|
|regardingobjectid_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|msdyn_opportunitylineresourcecategory_SyncErrors|
|regardingobjectid_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_opportunitylinetransaction_SyncErrors|
|regardingobjectid_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|msdyn_opportunitylinetransactioncategory_SyncErrors|
|regardingobjectid_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|msdyn_opportunitylinetransactionclassificatio_SyncErrors|
|regardingobjectid_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|msdyn_opportunitypricelist_SyncErrors|
|regardingobjectid_msdyn_optimizationrequestbooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|msdyn_optimizationrequestbooking_SyncErrors|
|regardingobjectid_msdyn_orderinvoicingdate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|msdyn_orderinvoicingdate_SyncErrors|
|regardingobjectid_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|msdyn_orderinvoicingproduct_SyncErrors|
|regardingobjectid_msdyn_orderinvoicingsetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|msdyn_orderinvoicingsetup_SyncErrors|
|regardingobjectid_msdyn_orderinvoicingsetupdate|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|msdyn_orderinvoicingsetupdate_SyncErrors|
|regardingobjectid_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|msdyn_orderlineresourcecategory_SyncErrors|
|regardingobjectid_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_orderlinetransaction_SyncErrors|
|regardingobjectid_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|msdyn_orderlinetransactioncategory_SyncErrors|
|regardingobjectid_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|msdyn_orderlinetransactionclassification_SyncErrors|
|regardingobjectid_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|msdyn_orderpricelist_SyncErrors|
|regardingobjectid_msdyn_organizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_SyncErrors|
|regardingobjectid_msdyn_page|[msdyn_page EntityType](msdyn_page.md)|msdyn_page_SyncErrors|
|regardingobjectid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_SyncErrors|
|regardingobjectid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_SyncErrors|
|regardingobjectid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_SyncErrors|
|regardingobjectid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_SyncErrors|
|regardingobjectid_msdyn_pendinggroupmembers|[msdyn_pendinggroupmembers EntityType](msdyn_pendinggroupmembers.md)|msdyn_pendinggroupmembers_SyncErrors|
|regardingobjectid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_SyncErrors|
|regardingobjectid_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_priority_SyncErrors|
|regardingobjectid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_SyncErrors|
|regardingobjectid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_SyncErrors|
|regardingobjectid_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_SyncErrors|
|regardingobjectid_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_projectapproval_SyncErrors|
|regardingobjectid_msdyn_projectparameter|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_projectparameter_SyncErrors|
|regardingobjectid_msdyn_projectparameterpricelist|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|msdyn_projectparameterpricelist_SyncErrors|
|regardingobjectid_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|msdyn_projectpricelist_SyncErrors|
|regardingobjectid_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_projecttask_SyncErrors|
|regardingobjectid_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_projecttaskdependency_SyncErrors|
|regardingobjectid_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|msdyn_projecttaskstatususer_SyncErrors|
|regardingobjectid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_SyncErrors|
|regardingobjectid_msdyn_projectteammembersignup|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|msdyn_projectteammembersignup_SyncErrors|
|regardingobjectid_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|msdyn_projecttransactioncategory_SyncErrors|
|regardingobjectid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_SyncErrors|
|regardingobjectid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_SyncErrors|
|regardingobjectid_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_SyncErrors|
|regardingobjectid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_SyncErrors|
|regardingobjectid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_SyncErrors|
|regardingobjectid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_SyncErrors|
|regardingobjectid_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_SyncErrors|
|regardingobjectid_msdyn_questiongroup|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_questiongroup_SyncErrors|
|regardingobjectid_msdyn_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|msdyn_questionresponse_SyncErrors|
|regardingobjectid_msdyn_questiontype|[msdyn_questiontype EntityType](msdyn_questiontype.md)|msdyn_questiontype_SyncErrors|
|regardingobjectid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_SyncErrors|
|regardingobjectid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_SyncErrors|
|regardingobjectid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_SyncErrors|
|regardingobjectid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_SyncErrors|
|regardingobjectid_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|msdyn_quotebookingsetup_SyncErrors|
|regardingobjectid_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|msdyn_quoteinvoicingproduct_SyncErrors|
|regardingobjectid_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|msdyn_quoteinvoicingsetup_SyncErrors|
|regardingobjectid_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_quotelineanalyticsbreakdown_SyncErrors|
|regardingobjectid_msdyn_quotelineinvoiceschedule|[msdyn_quotelineinvoiceschedule EntityType](msdyn_quotelineinvoiceschedule.md)|msdyn_quotelineinvoiceschedule_SyncErrors|
|regardingobjectid_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|msdyn_quotelineresourcecategory_SyncErrors|
|regardingobjectid_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|msdyn_quotelinescheduleofvalue_SyncErrors|
|regardingobjectid_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_quotelinetransaction_SyncErrors|
|regardingobjectid_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|msdyn_quotelinetransactioncategory_SyncErrors|
|regardingobjectid_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|msdyn_quotelinetransactionclassification_SyncErrors|
|regardingobjectid_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|msdyn_quotepricelist_SyncErrors|
|regardingobjectid_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|msdyn_requirementcharacteristic_SyncErrors|
|regardingobjectid_msdyn_requirementorganizationunit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|msdyn_requirementorganizationunit_SyncErrors|
|regardingobjectid_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|msdyn_requirementresourcecategory_SyncErrors|
|regardingobjectid_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_requirementresourcepreference_SyncErrors|
|regardingobjectid_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_requirementstatus_SyncErrors|
|regardingobjectid_msdyn_resourceassignment|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|msdyn_resourceassignment_SyncErrors|
|regardingobjectid_msdyn_resourceassignmentdetail|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|msdyn_resourceassignmentdetail_SyncErrors|
|regardingobjectid_msdyn_resourcecategorypricelevel|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_resourcecategorypricelevel_SyncErrors|
|regardingobjectid_msdyn_resourcepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_resourcepaytype_SyncErrors|
|regardingobjectid_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_resourcerequest_SyncErrors|
|regardingobjectid_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_SyncErrors|
|regardingobjectid_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|msdyn_resourcerequirementdetail_SyncErrors|
|regardingobjectid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_SyncErrors|
|regardingobjectid_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_SyncErrors|
|regardingobjectid_msdyn_responseblobstore|[msdyn_responseblobstore EntityType](msdyn_responseblobstore.md)|msdyn_responseblobstore_SyncErrors|
|regardingobjectid_msdyn_responsecondition|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|msdyn_responsecondition_SyncErrors|
|regardingobjectid_msdyn_responseoutcome|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_responseoutcome_SyncErrors|
|regardingobjectid_msdyn_responserouting|[msdyn_responserouting EntityType](msdyn_responserouting.md)|msdyn_responserouting_SyncErrors|
|regardingobjectid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_SyncErrors|
|regardingobjectid_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_SyncErrors|
|regardingobjectid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_SyncErrors|
|regardingobjectid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_SyncErrors|
|regardingobjectid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_SyncErrors|
|regardingobjectid_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|msdyn_rolecompetencyrequirement_SyncErrors|
|regardingobjectid_msdyn_roleutilization|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|msdyn_roleutilization_SyncErrors|
|regardingobjectid_msdyn_routingengineconfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|msdyn_routingengineconfiguration_SyncErrors|
|regardingobjectid_msdyn_routingjobconfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|msdyn_routingjobconfiguration_SyncErrors|
|regardingobjectid_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_routingoptimizationrequest_SyncErrors|
|regardingobjectid_msdyn_routingprofileconfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|msdyn_routingprofileconfiguration_SyncErrors|
|regardingobjectid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_SyncErrors|
|regardingobjectid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_SyncErrors|
|regardingobjectid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_SyncErrors|
|regardingobjectid_msdyn_scheduleboardsetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|msdyn_scheduleboardsetting_SyncErrors|
|regardingobjectid_msdyn_schedulingoptimizationhealthlog|[msdyn_schedulingoptimizationhealthlog EntityType](msdyn_schedulingoptimizationhealthlog.md)|msdyn_schedulingoptimizationhealthlog_SyncErrors|
|regardingobjectid_msdyn_schedulingparameter|[msdyn_schedulingparameter EntityType](msdyn_schedulingparameter.md)|msdyn_schedulingparameter_SyncErrors|
|regardingobjectid_msdyn_section|[msdyn_section EntityType](msdyn_section.md)|msdyn_section_SyncErrors|
|regardingobjectid_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|msdyn_servicetasktype_SyncErrors|
|regardingobjectid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_SyncErrors|
|regardingobjectid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_SyncErrors|
|regardingobjectid_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_SyncErrors|
|regardingobjectid_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|msdyn_surveylog_SyncErrors|
|regardingobjectid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_SyncErrors|
|regardingobjectid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_SyncErrors|
|regardingobjectid_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_taxcode_SyncErrors|
|regardingobjectid_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|msdyn_taxcodedetail_SyncErrors|
|regardingobjectid_msdyn_theme|[msdyn_theme EntityType](msdyn_theme.md)|msdyn_theme_SyncErrors|
|regardingobjectid_msdyn_timeentry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_timeentry_SyncErrors|
|regardingobjectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_SyncErrors|
|regardingobjectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_SyncErrors|
|regardingobjectid_msdyn_timeoffcalendar|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|msdyn_timeoffcalendar_SyncErrors|
|regardingobjectid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_SyncErrors|
|regardingobjectid_msdyn_transactioncategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_transactioncategory_SyncErrors|
|regardingobjectid_msdyn_transactioncategoryclassification|[msdyn_transactioncategoryclassification EntityType](msdyn_transactioncategoryclassification.md)|msdyn_transactioncategoryclassification_SyncErrors|
|regardingobjectid_msdyn_transactioncategoryhierarchyelement|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|msdyn_transactioncategoryhierarchyelement_SyncErrors|
|regardingobjectid_msdyn_transactioncategorypricelevel|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_transactioncategorypricelevel_SyncErrors|
|regardingobjectid_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|msdyn_transactionconnection_SyncErrors|
|regardingobjectid_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|msdyn_transactionorigin_SyncErrors|
|regardingobjectid_msdyn_transactiontype|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|msdyn_transactiontype_SyncErrors|
|regardingobjectid_msdyn_uniquenumber|[msdyn_uniquenumber EntityType](msdyn_uniquenumber.md)|msdyn_uniquenumber_SyncErrors|
|regardingobjectid_msdyn_userworkhistory|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|msdyn_userworkhistory_SyncErrors|
|regardingobjectid_msdyn_vocconfiguration|[msdyn_vocconfiguration EntityType](msdyn_vocconfiguration.md)|msdyn_vocconfiguration_SyncErrors|
|regardingobjectid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_SyncErrors|
|regardingobjectid_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_workhourtemplate_SyncErrors|
|regardingobjectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_SyncErrors|
|regardingobjectid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_SyncErrors|
|regardingobjectid_msdyn_workorderdetailsgenerationqueue|[msdyn_workorderdetailsgenerationqueue EntityType](msdyn_workorderdetailsgenerationqueue.md)|msdyn_workorderdetailsgenerationqueue_SyncErrors|
|regardingobjectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_SyncErrors|
|regardingobjectid_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_SyncErrors|
|regardingobjectid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_SyncErrors|
|regardingobjectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_SyncErrors|
|regardingobjectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_SyncErrors|
|regardingobjectid_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|msdyn_workordersubstatus_SyncErrors|
|regardingobjectid_msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_workordertype_SyncErrors|
|regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_SyncErrors|
|regardingobjectid_msdyncrm_campaigncustomchannelactivity|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|msdyncrm_campaigncustomchannelactivity_SyncErrors|
|regardingobjectid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_SyncErrors|
|regardingobjectid_msdyncrm_customerinsightsinfo|[msdyncrm_customerinsightsinfo EntityType](msdyncrm_customerinsightsinfo.md)|msdyncrm_customerinsightsinfo_SyncErrors|
|regardingobjectid_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_SyncErrors|
|regardingobjectid_msdyncrm_customerjourneyiteration|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|msdyncrm_customerjourneyiteration_SyncErrors|
|regardingobjectid_msdyncrm_customerjourneytemplate|[msdyncrm_customerjourneytemplate EntityType](msdyncrm_customerjourneytemplate.md)|msdyncrm_customerjourneytemplate_SyncErrors|
|regardingobjectid_msdyncrm_customerjourneyworkflowlink|[msdyncrm_customerjourneyworkflowlink EntityType](msdyncrm_customerjourneyworkflowlink.md)|msdyncrm_customerjourneyworkflowlink_SyncErrors|
|regardingobjectid_msdyncrm_file|[msdyncrm_file EntityType](msdyncrm_file.md)|msdyncrm_file_SyncErrors|
|regardingobjectid_msdyncrm_formpage|[msdyncrm_formpage EntityType](msdyncrm_formpage.md)|msdyncrm_formpage_SyncErrors|
|regardingobjectid_msdyncrm_formpagetemplate|[msdyncrm_formpagetemplate EntityType](msdyncrm_formpagetemplate.md)|msdyncrm_formpagetemplate_SyncErrors|
|regardingobjectid_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|msdyncrm_geopin_SyncErrors|
|regardingobjectid_msdyncrm_keyword|[msdyncrm_keyword EntityType](msdyncrm_keyword.md)|msdyncrm_keyword_SyncErrors|
|regardingobjectid_msdyncrm_leadscore|[msdyncrm_leadscore EntityType](msdyncrm_leadscore.md)|msdyncrm_leadscore_SyncErrors|
|regardingobjectid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_SyncErrors|
|regardingobjectid_msdyncrm_leadtoopportunity|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|msdyncrm_leadtoopportunity_SyncErrors|
|regardingobjectid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_SyncErrors|
|regardingobjectid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_SyncErrors|
|regardingobjectid_msdyncrm_linkedincampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|msdyncrm_linkedincampaign_SyncErrors|
|regardingobjectid_msdyncrm_linkedinconfiguration|[msdyncrm_linkedinconfiguration EntityType](msdyncrm_linkedinconfiguration.md)|msdyncrm_linkedinconfiguration_SyncErrors|
|regardingobjectid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_SyncErrors|
|regardingobjectid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_SyncErrors|
|regardingobjectid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_SyncErrors|
|regardingobjectid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_SyncErrors|
|regardingobjectid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_SyncErrors|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_SyncErrors|
|regardingobjectid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_SyncErrors|
|regardingobjectid_msdyncrm_marketingconfiguration|[msdyncrm_marketingconfiguration EntityType](msdyncrm_marketingconfiguration.md)|msdyncrm_marketingconfiguration_SyncErrors|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_SyncErrors|
|regardingobjectid_msdyncrm_marketingemail|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|msdyncrm_marketingemail_SyncErrors|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_SyncErrors|
|regardingobjectid_msdyncrm_marketingemailtemplate|[msdyncrm_marketingemailtemplate EntityType](msdyncrm_marketingemailtemplate.md)|msdyncrm_marketingemailtemplate_SyncErrors|
|regardingobjectid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_SyncErrors|
|regardingobjectid_msdyncrm_marketingform|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_marketingform_SyncErrors|
|regardingobjectid_msdyncrm_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|msdyncrm_marketingformfield_SyncErrors|
|regardingobjectid_msdyncrm_marketingformtemplate|[msdyncrm_marketingformtemplate EntityType](msdyncrm_marketingformtemplate.md)|msdyncrm_marketingformtemplate_SyncErrors|
|regardingobjectid_msdyncrm_marketingpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_marketingpage_SyncErrors|
|regardingobjectid_msdyncrm_marketingpageconfiguration|[msdyncrm_marketingpageconfiguration EntityType](msdyncrm_marketingpageconfiguration.md)|msdyncrm_marketingpageconfiguration_SyncErrors|
|regardingobjectid_msdyncrm_marketingpagetemplate|[msdyncrm_marketingpagetemplate EntityType](msdyncrm_marketingpagetemplate.md)|msdyncrm_marketingpagetemplate_SyncErrors|
|regardingobjectid_msdyncrm_matchingstrategy|[msdyncrm_matchingstrategy EntityType](msdyncrm_matchingstrategy.md)|msdyncrm_matchingstrategy_SyncErrors|
|regardingobjectid_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_SyncErrors|
|regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_SyncErrors|
|regardingobjectid_msdyncrm_portalsettings|[msdyncrm_portalsettings EntityType](msdyncrm_portalsettings.md)|msdyncrm_portalsettings_SyncErrors|
|regardingobjectid_msdyncrm_redirecturl|[msdyncrm_redirecturl EntityType](msdyncrm_redirecturl.md)|msdyncrm_redirecturl_SyncErrors|
|regardingobjectid_msdyncrm_segment|[msdyncrm_segment EntityType](msdyncrm_segment.md)|msdyncrm_segment_SyncErrors|
|regardingobjectid_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_SyncErrors|
|regardingobjectid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_SyncErrors|
|regardingobjectid_msdyncrm_usergeoregion|[msdyncrm_usergeoregion EntityType](msdyncrm_usergeoregion.md)|msdyncrm_usergeoregion_SyncErrors|
|regardingobjectid_msdyncrm_website|[msdyncrm_website EntityType](msdyncrm_website.md)|msdyncrm_website_SyncErrors|
|regardingobjectid_msevtmgt_attendeepass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|msevtmgt_attendeepass_SyncErrors|
|regardingobjectid_msevtmgt_authenticationsettings|[msevtmgt_authenticationsettings EntityType](msevtmgt_authenticationsettings.md)|msevtmgt_authenticationsettings_SyncErrors|
|regardingobjectid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99|[msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 EntityType](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md)|msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_SyncErrors|
|regardingobjectid_msevtmgt_building|[msevtmgt_building EntityType](msevtmgt_building.md)|msevtmgt_building_SyncErrors|
|regardingobjectid_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_SyncErrors|
|regardingobjectid_msevtmgt_entitycounter|[msevtmgt_entitycounter EntityType](msevtmgt_entitycounter.md)|msevtmgt_entitycounter_SyncErrors|
|regardingobjectid_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_SyncErrors|
|regardingobjectid_msevtmgt_eventadministration|[msevtmgt_eventadministration EntityType](msevtmgt_eventadministration.md)|msevtmgt_eventadministration_SyncErrors|
|regardingobjectid_msevtmgt_eventmanagementconfiguration|[msevtmgt_eventmanagementconfiguration EntityType](msevtmgt_eventmanagementconfiguration.md)|msevtmgt_eventmanagementconfiguration_SyncErrors|
|regardingobjectid_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_SyncErrors|
|regardingobjectid_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_SyncErrors|
|regardingobjectid_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_SyncErrors|
|regardingobjectid_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_SyncErrors|
|regardingobjectid_msevtmgt_eventteammember|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|msevtmgt_eventteammember_SyncErrors|
|regardingobjectid_msevtmgt_eventvendor|[msevtmgt_eventvendor EntityType](msevtmgt_eventvendor.md)|msevtmgt_eventvendor_SyncErrors|
|regardingobjectid_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_SyncErrors|
|regardingobjectid_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_SyncErrors|
|regardingobjectid_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_SyncErrors|
|regardingobjectid_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_SyncErrors|
|regardingobjectid_msevtmgt_pass|[msevtmgt_pass EntityType](msevtmgt_pass.md)|msevtmgt_pass_SyncErrors|
|regardingobjectid_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_SyncErrors|
|regardingobjectid_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_SyncErrors|
|regardingobjectid_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_SyncErrors|
|regardingobjectid_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_SyncErrors|
|regardingobjectid_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_SyncErrors|
|regardingobjectid_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_SyncErrors|
|regardingobjectid_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_SyncErrors|
|regardingobjectid_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_SyncErrors|
|regardingobjectid_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_SyncErrors|
|regardingobjectid_msevtmgt_webinarconfiguration|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_SyncErrors|
|regardingobjectid_msevtmgt_webinarconsent|[msevtmgt_webinarconsent EntityType](msevtmgt_webinarconsent.md)|msevtmgt_webinarconsent_SyncErrors|
|regardingobjectid_msevtmgt_webinarprovider|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_SyncErrors|
|regardingobjectid_msevtmgt_webinartype|[msevtmgt_webinartype EntityType](msevtmgt_webinartype.md)|msevtmgt_webinartype_SyncErrors|
|regardingobjectid_NewProcess_syncerror|[newprocess EntityType](newprocess.md)|NewProcess_SyncErrors|
|regardingobjectid_opportunity_syncerror|[opportunity EntityType](opportunity.md)|Opportunity_SyncErrors|
|regardingobjectid_opportunityclose_syncerror|[opportunityclose EntityType](opportunityclose.md)|OpportunityClose_SyncErrors|
|regardingobjectid_opportunityproduct_syncerror|[opportunityproduct EntityType](opportunityproduct.md)|OpportunityProduct_SyncErrors|
|regardingobjectid_OpportunitySalesProcess_syncerror|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|OpportunitySalesProcess_SyncErrors|
|regardingobjectid_orderclose_syncerror|[orderclose EntityType](orderclose.md)|OrderClose_SyncErrors|
|regardingobjectid_organization_syncerror|[organization EntityType](organization.md)|Organization_SyncErrors|
|regardingobjectid_phonecall_syncerror|[phonecall EntityType](phonecall.md)|PhoneCall_SyncErrors|
|regardingobjectid_PhoneToCaseProcess_syncerror|[phonetocaseprocess EntityType](phonetocaseprocess.md)|PhoneToCaseProcess_SyncErrors|
|regardingobjectid_position_syncerror|[position EntityType](position.md)|Position_SyncErrors|
|regardingobjectid_postfollow_syncerror|[postfollow EntityType](postfollow.md)|PostFollow_SyncErrors|
|regardingobjectid_pricelevel_syncerror|[pricelevel EntityType](pricelevel.md)|PriceLevel_SyncErrors|
|regardingobjectid_processstage_syncerror|[processstage EntityType](processstage.md)|ProcessStage_SyncErrors|
|regardingobjectid_product_syncerror|[product EntityType](product.md)|Product_SyncErrors|
|regardingobjectid_productassociation_syncerror|[productassociation EntityType](productassociation.md)|ProductAssociation_SyncErrors|
|regardingobjectid_productpricelevel|[productpricelevel EntityType](productpricelevel.md)|ProductPriceLevel_SyncErrors|
|regardingobjectid_productsubstitute_syncerror|[productsubstitute EntityType](productsubstitute.md)|ProductSubstitute_SyncErrors|
|regardingobjectid_publisher_syncerror|[publisher EntityType](publisher.md)|Publisher_SyncErrors|
|regardingobjectid_queue_syncerror|[queue EntityType](queue.md)|Queue_SyncErrors|
|regardingobjectid_queueitem_syncerror|[queueitem EntityType](queueitem.md)|QueueItem_SyncErrors|
|regardingobjectid_quote_syncerror|[quote EntityType](quote.md)|Quote_SyncErrors|
|regardingobjectid_quoteclose_syncerror|[quoteclose EntityType](quoteclose.md)|QuoteClose_SyncErrors|
|regardingobjectid_quotedetail_syncerror|[quotedetail EntityType](quotedetail.md)|QuoteDetail_SyncErrors|
|regardingobjectid_ratingmodel_syncerror|[ratingmodel EntityType](ratingmodel.md)|RatingModel_SyncErrors|
|regardingobjectid_ratingvalue_syncerror|[ratingvalue EntityType](ratingvalue.md)|RatingValue_SyncErrors|
|regardingobjectid_recurringappointmentmaster_syncerror|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|RecurringAppointmentMaster_SyncErrors|
|regardingobjectid_report_syncerror|[report EntityType](report.md)|Report_SyncErrors|
|regardingobjectid_reportcategory_syncerror|[reportcategory EntityType](reportcategory.md)|ReportCategory_SyncErrors|
|regardingobjectid_resource_syncerror|[resource EntityType](resource.md)|Resource_SyncErrors|
|regardingobjectid_resourcegroup_syncerror|[resourcegroup EntityType](resourcegroup.md)|ResourceGroup_SyncErrors|
|regardingobjectid_resourcespec|[resourcespec EntityType](resourcespec.md)|resourcespec_SyncErrors|
|regardingobjectid_role_syncerror|[role EntityType](role.md)|Role_SyncErrors|
|regardingobjectid_salesliterature_syncerror|[salesliterature EntityType](salesliterature.md)|SalesLiterature_SyncErrors|
|regardingobjectid_salesliteratureitem|[salesliteratureitem EntityType](salesliteratureitem.md)|salesliteratureitem_SyncErrors|
|regardingobjectid_salesorder_syncerror|[salesorder EntityType](salesorder.md)|SalesOrder_SyncErrors|
|regardingobjectid_salesorderdetail_syncerror|[salesorderdetail EntityType](salesorderdetail.md)|SalesOrderDetail_SyncErrors|
|regardingobjectid_savedquery_syncerror|[savedquery EntityType](savedquery.md)|SavedQuery_SyncErrors|
|regardingobjectid_savedqueryvisualization_syncerror|[savedqueryvisualization EntityType](savedqueryvisualization.md)|SavedQueryVisualization_SyncErrors|
|regardingobjectid_service_syncerror|[service EntityType](service.md)|Service_SyncErrors|
|regardingobjectid_serviceappointment_syncerror|[serviceappointment EntityType](serviceappointment.md)|ServiceAppointment_SyncErrors|
|regardingobjectid_sharepointdocumentlocation_syncerror|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|SharePointDocumentLocation_SyncErrors|
|regardingobjectid_sharepointsite_syncerror|[sharepointsite EntityType](sharepointsite.md)|SharePointSite_SyncErrors|
|regardingobjectid_site_syncerror|[site EntityType](site.md)|Site_SyncErrors|
|regardingobjectid_sla_syncerror|[sla EntityType](sla.md)|SLA_SyncErrors|
|regardingobjectid_slaitem_syncerror|[slaitem EntityType](slaitem.md)|SLAItem_SyncErrors|
|regardingobjectid_slakpiinstance_syncerror|[slakpiinstance EntityType](slakpiinstance.md)|SLAKPIInstance_SyncErrors|
|regardingobjectid_socialactivity_syncerror|[socialactivity EntityType](socialactivity.md)|SocialActivity_SyncErrors|
|regardingobjectid_socialprofile_syncerror|[socialprofile EntityType](socialprofile.md)|SocialProfile_SyncErrors|
|regardingobjectid_solution_syncerror|[solution EntityType](solution.md)|Solution_SyncErrors|
|regardingobjectid_subject_syncerror|[subject EntityType](subject.md)|Subject_SyncErrors|
|regardingobjectid_syncerror_syncerror|[syncerror EntityType](syncerror.md)|SyncError_SyncErrors|
|regardingobjectid_systemuser|[systemuser EntityType](systemuser.md)|SystemUser_SyncError|
|regardingobjectid_systemuser_syncerror|[systemuser EntityType](systemuser.md)|SystemUser_SyncErrors|
|regardingobjectid_task_syncerror|[task EntityType](task.md)|Task_SyncErrors|
|regardingobjectid_team_syncerror|[team EntityType](team.md)|Team_SyncErrors|
|regardingobjectid_teamtemplate_syncerror|[teamtemplate EntityType](teamtemplate.md)|TeamTemplate_SyncErrors|
|regardingobjectid_template_syncerror|[template EntityType](template.md)|Template_SyncErrors|
|regardingobjectid_territory_syncerror|[territory EntityType](territory.md)|Territory_SyncErrors|
|regardingobjectid_transactioncurrency_syncerror|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_SyncErrors|
|regardingobjectid_TranslationProcess_syncerror|[translationprocess EntityType](translationprocess.md)|TranslationProcess_SyncErrors|
|regardingobjectid_uom|[uom EntityType](uom.md)|UoM_SyncErrors|
|regardingobjectid_uomschedule_syncerror|[uomschedule EntityType](uomschedule.md)|UoMSchedule_SyncErrors|
|regardingobjectid_userquery_syncerror|[userquery EntityType](userquery.md)|UserQuery_SyncErrors|
|regardingobjectid_userqueryvisualization_syncerror|[userqueryvisualization EntityType](userqueryvisualization.md)|UserQueryVisualization_SyncErrors|
|regardingobjectid_workflow_syncerror|[workflow EntityType](workflow.md)|Workflow_SyncErrors|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SyncError_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_syncerror_syncerror|  

## Operations
The following operations can be used with the syncerror entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|    

[!INCLUDE[./remarks/syncerror.md](./remarks/syncerror.md)]

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