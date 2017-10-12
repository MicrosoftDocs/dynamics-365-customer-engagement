---
title: "Microsoft Dynamics 365 Customer Engagement annotation EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 108a7d17-f416-4d6b-9045-e23a1f6c21a5
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API annotation entitytype."
---
# annotation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/annotation.md](./descriptions/annotation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]annotations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Note</td></tr>
<tr><td><b>Primary Key:</b></td><td>annotationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>subject</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The annotation entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|annotationid|Edm.Guid|**Display Name**: Note<br />**Description**: Unique identifier of the note.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the note was created.<br />Read-only<br />|
|documentbody|Edm.String|**Display Name**: Document<br />**Description**: Contents of the note's attachment.<br />|
|documentbody_binary|Edm.Binary|**Description**: Contents of the note's attachment.<br />|
|filename|Edm.String|**Display Name**: File Name<br />**Description**: File name of the note.<br />|
|filesize|Edm.Int32|**Display Name**: File Size (Bytes)<br />**Description**: File size of the note.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|isdocument|Edm.Boolean|**Display Name**: Is Document<br />**Description**: Specifies whether the note is an attachment.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|langid|Edm.String|**Display Name**: Language ID<br />**Description**: Language identifier for the note.<br />|
|mimetype|Edm.String|**Display Name**: Mime Type<br />**Description**: MIME type of the note's attachment.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the note was last modified.<br />Read-only<br />|
|notetext|Edm.String|**Display Name**: Description<br />**Description**: Text of the note.<br />|
|objecttypecode|Edm.String|**Display Name**: Object Type <br />**Description**: Type of entity with which the note is associated.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|stepid|Edm.String|**Display Name**: Step Id<br />**Description**: workflow step id associated with the note.<br />|
|subject|Edm.String|**Display Name**: Title<br />**Description**: Subject associated with the note.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the note.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the note.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the annotation.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the note.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the annotation.|
|_objectid_value|objectid_lead<br />objectid_product<br />objectid_bookableresource<br />objectid_bookableresourcebooking<br />objectid_bookableresourcebookingheader<br />objectid_bookableresourcecategoryassn<br />objectid_bookableresourcecharacteristic<br />objectid_bookableresourcegroup<br />objectid_campaign<br />objectid_list<br />objectid_contract<br />objectid_contractdetail<br />objectid_entitlement<br />objectid_entitlementchannel<br />objectid_entitlementtemplate<br />objectid_equipment<br />objectid_incident<br />objectid_resourcespec<br />objectid_service<br />objectid_invoice<br />objectid_opportunity<br />objectid_quote<br />objectid_salesorder<br />objectid_competitor<br />objectid_adx_sitesetting<br />objectid_adx_webfile<br />objectid_adx_weblink<br />objectid_adx_webnotificationurl<br />objectid_adx_webpage<br />objectid_adx_webrole<br />objectid_adx_website<br />objectid_adx_ad<br />objectid_adx_adplacement<br />objectid_adx_entitypermission<br />objectid_adx_invitation<br />objectid_adx_poll<br />objectid_adx_polloption<br />objectid_adx_pollplacement<br />objectid_adx_pollsubmission<br />objectid_adx_publishingstatetransitionrule<br />objectid_adx_redirect<br />objectid_adx_shortcut<br />objectid_adx_websitebinding<br />objectid_msdyn_actual<br />objectid_msdyn_bookingalertstatus<br />objectid_msdyn_bookingrule<br />objectid_msdyn_organizationalunit<br />objectid_msdyn_priority<br />objectid_msdyn_requirementcharacteristic<br />objectid_msdyn_requirementresourcecategory<br />objectid_msdyn_requirementresourcepreference<br />objectid_msdyn_requirementstatus<br />objectid_msdyn_resourcerequirement<br />objectid_msdyn_resourcerequirementdetail<br />objectid_msdyn_resourceterritory<br />objectid_msdyn_systemuserschedulersetting<br />objectid_msdyn_timegroup<br />objectid_msdyn_timegroupdetail<br />objectid_msdyn_transactionorigin<br />objectid_msdyn_agreement<br />objectid_msdyn_agreementbookingdate<br />objectid_msdyn_agreementbookingincident<br />objectid_msdyn_agreementbookingproduct<br />objectid_msdyn_agreementbookingservice<br />objectid_msdyn_agreementbookingservicetask<br />objectid_msdyn_agreementbookingsetup<br />objectid_msdyn_agreementinvoicedate<br />objectid_msdyn_agreementinvoiceproduct<br />objectid_msdyn_agreementinvoicesetup<br />objectid_msdyn_agreementsubstatus<br />objectid_msdyn_bookingjournal<br />objectid_msdyn_bookingtimestamp<br />objectid_msdyn_customerasset<br />objectid_msdyn_fieldservicesetting<br />objectid_msdyn_incidenttype<br />objectid_msdyn_incidenttypecharacteristic<br />objectid_msdyn_incidenttypeproduct<br />objectid_msdyn_incidenttypeservice<br />objectid_msdyn_inventoryadjustment<br />objectid_msdyn_inventoryadjustmentproduct<br />objectid_msdyn_inventoryjournal<br />objectid_msdyn_inventorytransfer<br />objectid_msdyn_payment<br />objectid_msdyn_paymentdetail<br />objectid_msdyn_paymentmethod<br />objectid_msdyn_paymentterm<br />objectid_msdyn_postalcode<br />objectid_msdyn_productinventory<br />objectid_msdyn_purchaseorder<br />objectid_msdyn_purchaseorderbill<br />objectid_msdyn_purchaseorderproduct<br />objectid_msdyn_purchaseorderreceipt<br />objectid_msdyn_purchaseorderreceiptproduct<br />objectid_msdyn_purchaseordersubstatus<br />objectid_msdyn_quotebookingincident<br />objectid_msdyn_quotebookingproduct<br />objectid_msdyn_quotebookingservice<br />objectid_msdyn_quotebookingservicetask<br />objectid_msdyn_resourcepaytype<br />objectid_msdyn_rma<br />objectid_msdyn_rmaproduct<br />objectid_msdyn_rmareceipt<br />objectid_msdyn_rmareceiptproduct<br />objectid_msdyn_rmasubstatus<br />objectid_msdyn_rtv<br />objectid_msdyn_rtvproduct<br />objectid_msdyn_rtvsubstatus<br />objectid_msdyn_servicetasktype<br />objectid_msdyn_shipvia<br />objectid_msdyn_taxcode<br />objectid_msdyn_taxcodedetail<br />objectid_msdyn_timeoffrequest<br />objectid_msdyn_warehouse<br />objectid_msdyn_workorder<br />objectid_msdyn_workordercharacteristic<br />objectid_msdyn_workorderincident<br />objectid_msdyn_workorderproduct<br />objectid_msdyn_workorderresourcerestriction<br />objectid_msdyn_workorderservice<br />objectid_msdyn_workorderservicetask<br />objectid_msdyn_workordersubstatus<br />objectid_msdyn_iotalert<br />objectid_msdyn_iotdevice<br />objectid_msdyn_iotdevicecategory<br />objectid_msdyn_iotdevicecommand<br />objectid_msdyn_iotdeviceregistrationhistory<br />objectid_msdyn_accountpricelist<br />objectid_msdyn_characteristicreqforteammember<br />objectid_msdyn_contactpricelist<br />objectid_msdyn_dataexport<br />objectid_msdyn_delegation<br />objectid_msdyn_estimate<br />objectid_msdyn_estimateline<br />objectid_msdyn_expense<br />objectid_msdyn_expensecategory<br />objectid_msdyn_expensereceipt<br />objectid_msdyn_fact<br />objectid_msdyn_findworkevent<br />objectid_msdyn_invoicelinetransaction<br />objectid_msdyn_journal<br />objectid_msdyn_journalline<br />objectid_msdyn_opportunitylineresourcecategory<br />objectid_msdyn_opportunitylinetransaction<br />objectid_msdyn_opportunitylinetransactioncategory<br />objectid_msdyn_opportunitylinetransactionclassificatio<br />objectid_msdyn_opportunitypricelist<br />objectid_msdyn_orderlineresourcecategory<br />objectid_msdyn_orderlinetransaction<br />objectid_msdyn_orderlinetransactioncategory<br />objectid_msdyn_orderlinetransactionclassification<br />objectid_msdyn_orderpricelist<br />objectid_msdyn_processnotes<br />objectid_msdyn_project<br />objectid_msdyn_projectapproval<br />objectid_msdyn_projectparameter<br />objectid_msdyn_projectparameterpricelist<br />objectid_msdyn_projectpricelist<br />objectid_msdyn_projecttask<br />objectid_msdyn_projecttaskdependency<br />objectid_msdyn_projecttaskstatususer<br />objectid_msdyn_projectteam<br />objectid_msdyn_projectteammembersignup<br />objectid_msdyn_projecttransactioncategory<br />objectid_msdyn_quotelineresourcecategory<br />objectid_msdyn_quotelinetransaction<br />objectid_msdyn_quotelinetransactioncategory<br />objectid_msdyn_quotelinetransactionclassification<br />objectid_msdyn_quotepricelist<br />objectid_msdyn_resourcecategorypricelevel<br />objectid_msdyn_resourcerequest<br />objectid_msdyn_rolecompetencyrequirement<br />objectid_msdyn_timeentry<br />objectid_msdyn_transactioncategory<br />objectid_msdyn_transactioncategoryclassification<br />objectid_msdyn_transactioncategoryhierarchyelement<br />objectid_msdyn_transactioncategorypricelevel<br />objectid_msdyn_transactionconnection<br />objectid_msdyn_transactiontype<br />objectid_msdyn_workhourtemplate<br />objectid_msdyncrm_appointmentactivitymarketingtemplate<br />objectid_msdyncrm_contentsettings<br />objectid_msdyncrm_customerjourney<br />objectid_msdyncrm_marketingdynamiccontentmetadata<br />objectid_msdyncrm_marketingemaildynamiccontentmetadata<br />objectid_msdyncrm_marketingemailtestsend<br />objectid_msdyncrm_marketingform<br />objectid_msdyncrm_marketingformtemplate<br />objectid_msdyncrm_marketingpage<br />objectid_msdyncrm_marketingpagetemplate<br />objectid_msdyncrm_mktactivity<br />objectid_msdyncrm_phonecallactivitymarketingtemplate<br />objectid_msdyncrm_taskactivitymarketingtemplate<br />objectid_msdyncrm_uicconfig<br />objectid_msdyncrm_leadscoremodel<br />objectid_msdyn_answer<br />objectid_msdyn_image<br />objectid_msdyn_import<br />objectid_msdyn_responseaction<br />objectid_msdyn_section<br />objectid_msdyn_survey<br />objectid_msdyn_surveylog<br />objectid_msdyn_surveyresponse<br />objectid_msdyn_vocconfiguration<br />objectid_msevtmgt_checkin<br />objectid_msevtmgt_event<br />objectid_msevtmgt_eventpurchase<br />objectid_msevtmgt_eventpurchaseattendee<br />objectid_msevtmgt_eventpurchasepass<br />objectid_msevtmgt_eventregistration<br />objectid_msevtmgt_hotel<br />objectid_msevtmgt_hotelroomallocation<br />objectid_msevtmgt_hotelroomreservation<br />objectid_msevtmgt_layout<br />objectid_msevtmgt_room<br />objectid_msevtmgt_session<br />objectid_msevtmgt_sessionregistration<br />objectid_msevtmgt_sessiontrack<br />objectid_msevtmgt_speaker<br />objectid_msevtmgt_speakerengagement<br />objectid_msevtmgt_sponsorablearticle<br />objectid_msevtmgt_sponsorship<br />objectid_msevtmgt_venue<br />objectid_msevtmgt_webinarconfiguration<br />objectid_msevtmgt_webinarprovider<br />objectid_msdyncrm_linkedinaccount<br />objectid_msdyncrm_linkedinactivity<br />objectid_msdyncrm_linkedinfieldmapping<br />objectid_msdyncrm_linkedinform<br />objectid_msdyncrm_linkedinformanswer<br />objectid_msdyncrm_linkedinformquestion<br />objectid_msdyncrm_linkedinformsubmission<br />objectid_msdyncrm_linkedinleadmatchingstrategy<br />objectid_msdyncrm_linkedinuserprofile<br />objectid_knowledgearticle<br />objectid_knowledgebaserecord<br />objectid_account<br />objectid_kbarticle<br />objectid_sla<br />objectid_calendar<br />objectid_contact<br />objectid_goal<br />objectid_workflow<br />objectid_mailbox<br />objectid_duplicaterule<br />objectid_emailserverprofile<br />|Unique identifier of the object with which the note is associated.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the note.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the note.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the note.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the note.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_annotationbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_annotationbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_annotationbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_annotationbase_modifiedonbehalfby|
|objectid_account|[account EntityType](account.md)|Account_Annotation|
|objectid_adx_ad|[adx_ad EntityType](adx_ad.md)|adx_ad_Annotations|
|objectid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_Annotations|
|objectid_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_Annotations|
|objectid_adx_entitypermission|[adx_entitypermission EntityType](adx_entitypermission.md)|adx_entitypermission_Annotations|
|objectid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_Annotations|
|objectid_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_Annotations|
|objectid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_Annotations|
|objectid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_Annotations|
|objectid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_Annotations|
|objectid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_Annotations|
|objectid_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|adx_portalcomment_Annotations|
|objectid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_Annotations|
|objectid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_Annotations|
|objectid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_Annotations|
|objectid_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|adx_sitesetting_Annotations|
|objectid_adx_webfile|[adx_webfile EntityType](adx_webfile.md)|adx_webfile_Annotations|
|objectid_adx_weblink|[adx_weblink EntityType](adx_weblink.md)|adx_weblink_Annotations|
|objectid_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|adx_webnotificationurl_Annotations|
|objectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_Annotations|
|objectid_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_webrole_Annotations|
|objectid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_Annotations|
|objectid_adx_websitebinding|[adx_websitebinding EntityType](adx_websitebinding.md)|adx_websitebinding_Annotations|
|objectid_appointment|[appointment EntityType](appointment.md)|Appointment_Annotation|
|objectid_bookableresource|[bookableresource EntityType](bookableresource.md)|bookableresource_Annotations|
|objectid_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_Annotations|
|objectid_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_Annotations|
|objectid_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|bookableresourcecategoryassn_Annotations|
|objectid_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|bookableresourcecharacteristic_Annotations|
|objectid_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|bookableresourcegroup_Annotations|
|objectid_bulkoperation|[bulkoperation EntityType](bulkoperation.md)|bulkoperation_Annotations|
|objectid_calendar|[calendar EntityType](calendar.md)|Calendar_Annotation|
|objectid_campaign|[campaign EntityType](campaign.md)|Campaign_Annotation|
|objectid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_Annotation|
|objectid_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|CampaignResponse_Annotation|
|objectid_competitor|[competitor EntityType](competitor.md)|Competitor_Annotation|
|objectid_contact|[contact EntityType](contact.md)|Contact_Annotation|
|objectid_contract|[contract EntityType](contract.md)|Contract_Annotation|
|objectid_contractdetail|[contractdetail EntityType](contractdetail.md)|ContractDetail_Annotation|
|objectid_duplicaterule|[duplicaterule EntityType](duplicaterule.md)|DuplicateRule_Annotation|
|objectid_email|[email EntityType](email.md)|Email_Annotation|
|objectid_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|EmailServerProfile_Annotation|
|objectid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_Annotations|
|objectid_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|entitlementchannel_Annotations|
|objectid_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_Annotations|
|objectid_equipment|[equipment EntityType](equipment.md)|Equipment_Annotation|
|objectid_fax|[fax EntityType](fax.md)|Fax_Annotation|
|objectid_goal|[goal EntityType](goal.md)|Goal_Annotation|
|objectid_incident|[incident EntityType](incident.md)|Incident_Annotation|
|objectid_incidentresolution|[incidentresolution EntityType](incidentresolution.md)|IncidentResolution_Annotation|
|objectid_invoice|[invoice EntityType](invoice.md)|Invoice_Annotation|
|objectid_kbarticle|[kbarticle EntityType](kbarticle.md)|KbArticle_Annotation|
|objectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_Annotations|
|objectid_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_Annotations|
|objectid_lead|[lead EntityType](lead.md)|Lead_Annotation|
|objectid_letter|[letter EntityType](letter.md)|Letter_Annotation|
|objectid_list|[list EntityType](list.md)|List_Annotation|
|objectid_mailbox|[mailbox EntityType](mailbox.md)|Mailbox_Annotation|
|objectid_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|msdyn_accountpricelist_Annotations|
|objectid_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_actual_Annotations|
|objectid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_Annotations|
|objectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_Annotations|
|objectid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_Annotations|
|objectid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_Annotations|
|objectid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_Annotations|
|objectid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_Annotations|
|objectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_Annotations|
|objectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_Annotations|
|objectid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_Annotations|
|objectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_Annotations|
|objectid_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|msdyn_agreementsubstatus_Annotations|
|objectid_msdyn_answer|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_answer_Annotations|
|objectid_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_Annotations|
|objectid_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_Annotations|
|objectid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_Annotations|
|objectid_msdyn_bookingjournal|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|msdyn_bookingjournal_Annotations|
|objectid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_Annotations|
|objectid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_Annotations|
|objectid_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|msdyn_contactpricelist_Annotations|
|objectid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_Annotations|
|objectid_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|msdyn_dataexport_Annotations|
|objectid_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|msdyn_delegation_Annotations|
|objectid_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|msdyn_estimate_Annotations|
|objectid_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_estimateline_Annotations|
|objectid_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_expense_Annotations|
|objectid_msdyn_expensecategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_expensecategory_Annotations|
|objectid_msdyn_expensereceipt|[msdyn_expensereceipt EntityType](msdyn_expensereceipt.md)|msdyn_expensereceipt_Annotations|
|objectid_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_fact_Annotations|
|objectid_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_Annotations|
|objectid_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|msdyn_findworkevent_Annotations|
|objectid_msdyn_image|[msdyn_image EntityType](msdyn_image.md)|msdyn_image_Annotations|
|objectid_msdyn_import|[msdyn_import EntityType](msdyn_import.md)|msdyn_import_Annotations|
|objectid_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_incidenttype_Annotations|
|objectid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_Annotations|
|objectid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_Annotations|
|objectid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_Annotations|
|objectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_Annotations|
|objectid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_Annotations|
|objectid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_Annotations|
|objectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_Annotations|
|objectid_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_invoicelinetransaction_Annotations|
|objectid_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_iotalert_Annotations|
|objectid_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_iotdevice_Annotations|
|objectid_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_iotdevicecategory_Annotations|
|objectid_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_iotdevicecommand_Annotations|
|objectid_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_iotdeviceregistrationhistory_Annotations|
|objectid_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|msdyn_journal_Annotations|
|objectid_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_journalline_Annotations|
|objectid_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|msdyn_opportunitylineresourcecategory_Annotations|
|objectid_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_opportunitylinetransaction_Annotations|
|objectid_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|msdyn_opportunitylinetransactioncategory_Annotations|
|objectid_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|msdyn_opportunitylinetransactionclassificatio_Annotations|
|objectid_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|msdyn_opportunitypricelist_Annotations|
|objectid_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|msdyn_orderlineresourcecategory_Annotations|
|objectid_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_orderlinetransaction_Annotations|
|objectid_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|msdyn_orderlinetransactioncategory_Annotations|
|objectid_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|msdyn_orderlinetransactionclassification_Annotations|
|objectid_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|msdyn_orderpricelist_Annotations|
|objectid_msdyn_organizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_Annotations|
|objectid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_Annotations|
|objectid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_Annotations|
|objectid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_Annotations|
|objectid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_Annotations|
|objectid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_Annotations|
|objectid_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_priority_Annotations|
|objectid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_Annotations|
|objectid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_Annotations|
|objectid_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_Annotations|
|objectid_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_projectapproval_Annotations|
|objectid_msdyn_projectparameter|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_projectparameter_Annotations|
|objectid_msdyn_projectparameterpricelist|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|msdyn_projectparameterpricelist_Annotations|
|objectid_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|msdyn_projectpricelist_Annotations|
|objectid_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_projecttask_Annotations|
|objectid_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_projecttaskdependency_Annotations|
|objectid_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|msdyn_projecttaskstatususer_Annotations|
|objectid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_Annotations|
|objectid_msdyn_projectteammembersignup|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|msdyn_projectteammembersignup_Annotations|
|objectid_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|msdyn_projecttransactioncategory_Annotations|
|objectid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_Annotations|
|objectid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_Annotations|
|objectid_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_Annotations|
|objectid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_Annotations|
|objectid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_Annotations|
|objectid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_Annotations|
|objectid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_Annotations|
|objectid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_Annotations|
|objectid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_Annotations|
|objectid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_Annotations|
|objectid_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|msdyn_quotelineresourcecategory_Annotations|
|objectid_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_quotelinetransaction_Annotations|
|objectid_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|msdyn_quotelinetransactioncategory_Annotations|
|objectid_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|msdyn_quotelinetransactionclassification_Annotations|
|objectid_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|msdyn_quotepricelist_Annotations|
|objectid_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|msdyn_requirementcharacteristic_Annotations|
|objectid_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|msdyn_requirementresourcecategory_Annotations|
|objectid_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_requirementresourcepreference_Annotations|
|objectid_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_requirementstatus_Annotations|
|objectid_msdyn_resourcecategorypricelevel|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_resourcecategorypricelevel_Annotations|
|objectid_msdyn_resourcepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_resourcepaytype_Annotations|
|objectid_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_resourcerequest_Annotations|
|objectid_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_Annotations|
|objectid_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|msdyn_resourcerequirementdetail_Annotations|
|objectid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_Annotations|
|objectid_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_Annotations|
|objectid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_Annotations|
|objectid_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_Annotations|
|objectid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_Annotations|
|objectid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_Annotations|
|objectid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_Annotations|
|objectid_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|msdyn_rolecompetencyrequirement_Annotations|
|objectid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_Annotations|
|objectid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_Annotations|
|objectid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_Annotations|
|objectid_msdyn_section|[msdyn_section EntityType](msdyn_section.md)|msdyn_section_Annotations|
|objectid_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|msdyn_servicetasktype_Annotations|
|objectid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_Annotations|
|objectid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_Annotations|
|objectid_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_Annotations|
|objectid_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|msdyn_surveylog_Annotations|
|objectid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_Annotations|
|objectid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_Annotations|
|objectid_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_taxcode_Annotations|
|objectid_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|msdyn_taxcodedetail_Annotations|
|objectid_msdyn_timeentry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_timeentry_Annotations|
|objectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_Annotations|
|objectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_Annotations|
|objectid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_Annotations|
|objectid_msdyn_transactioncategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_transactioncategory_Annotations|
|objectid_msdyn_transactioncategoryclassification|[msdyn_transactioncategoryclassification EntityType](msdyn_transactioncategoryclassification.md)|msdyn_transactioncategoryclassification_Annotations|
|objectid_msdyn_transactioncategoryhierarchyelement|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|msdyn_transactioncategoryhierarchyelement_Annotations|
|objectid_msdyn_transactioncategorypricelevel|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_transactioncategorypricelevel_Annotations|
|objectid_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|msdyn_transactionconnection_Annotations|
|objectid_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|msdyn_transactionorigin_Annotations|
|objectid_msdyn_transactiontype|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|msdyn_transactiontype_Annotations|
|objectid_msdyn_vocconfiguration|[msdyn_vocconfiguration EntityType](msdyn_vocconfiguration.md)|msdyn_vocconfiguration_Annotations|
|objectid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_Annotations|
|objectid_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_workhourtemplate_Annotations|
|objectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_Annotations|
|objectid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_Annotations|
|objectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_Annotations|
|objectid_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_Annotations|
|objectid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_Annotations|
|objectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_Annotations|
|objectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_Annotations|
|objectid_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|msdyn_workordersubstatus_Annotations|
|objectid_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_Annotations|
|objectid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_Annotations|
|objectid_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_Annotations|
|objectid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_Annotations|
|objectid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_Annotations|
|objectid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_Annotations|
|objectid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_Annotations|
|objectid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_Annotations|
|objectid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_Annotations|
|objectid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_Annotations|
|objectid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_Annotations|
|objectid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_Annotations|
|objectid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_Annotations|
|objectid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_Annotations|
|objectid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_Annotations|
|objectid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_Annotations|
|objectid_msdyncrm_marketingform|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_marketingform_Annotations|
|objectid_msdyncrm_marketingformtemplate|[msdyncrm_marketingformtemplate EntityType](msdyncrm_marketingformtemplate.md)|msdyncrm_marketingformtemplate_Annotations|
|objectid_msdyncrm_marketingpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_marketingpage_Annotations|
|objectid_msdyncrm_marketingpagetemplate|[msdyncrm_marketingpagetemplate EntityType](msdyncrm_marketingpagetemplate.md)|msdyncrm_marketingpagetemplate_Annotations|
|objectid_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_Annotations|
|objectid_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_Annotations|
|objectid_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_Annotations|
|objectid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_Annotations|
|objectid_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_Annotations|
|objectid_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_Annotations|
|objectid_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_Annotations|
|objectid_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_Annotations|
|objectid_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_Annotations|
|objectid_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_Annotations|
|objectid_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_Annotations|
|objectid_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_Annotations|
|objectid_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_Annotations|
|objectid_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_Annotations|
|objectid_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_Annotations|
|objectid_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_Annotations|
|objectid_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_Annotations|
|objectid_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_Annotations|
|objectid_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_Annotations|
|objectid_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_Annotations|
|objectid_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_Annotations|
|objectid_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_Annotations|
|objectid_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_Annotations|
|objectid_msevtmgt_webinarconfiguration|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_Annotations|
|objectid_msevtmgt_webinarprovider|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_Annotations|
|objectid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_Annotation|
|objectid_opportunityclose|[opportunityclose EntityType](opportunityclose.md)|OpportunityClose_Annotation|
|objectid_orderclose|[orderclose EntityType](orderclose.md)|OrderClose_Annotation|
|objectid_phonecall|[phonecall EntityType](phonecall.md)|PhoneCall_Annotation|
|objectid_product|[product EntityType](product.md)|Product_Annotation|
|objectid_quote|[quote EntityType](quote.md)|Quote_Annotation|
|objectid_quoteclose|[quoteclose EntityType](quoteclose.md)|QuoteClose_Annotation|
|objectid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|RecurringAppointmentMaster_Annotation|
|objectid_resourcespec|[resourcespec EntityType](resourcespec.md)|ResourceSpec_Annotation|
|objectid_salesorder|[salesorder EntityType](salesorder.md)|SalesOrder_Annotation|
|objectid_service|[service EntityType](service.md)|Service_Annotation|
|objectid_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|ServiceAppointment_Annotation|
|objectid_sla|[sla EntityType](sla.md)|sla_Annotation|
|objectid_socialactivity|[socialactivity EntityType](socialactivity.md)|SocialActivity_Annotation|
|objectid_task|[task EntityType](task.md)|Task_Annotation|
|objectid_workflow|[workflow EntityType](workflow.md)|Workflow_Annotation|
|ownerid|[principal EntityType](principal.md)|owner_annotations|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_annotations|
|owningteam|[team EntityType](team.md)|team_annotations|
|owninguser|[systemuser EntityType](systemuser.md)|annotation_owning_user|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Annotation_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_annotation|  
|Annotation_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_annotation|  
|Annotation_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_annotation_syncerror|  

## Operations
The following operations can be used with the annotation entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  

## Solutions
The following solutions include the annotation entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/annotation.md](./remarks/annotation.md)]

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