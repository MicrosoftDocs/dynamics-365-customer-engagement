---
title: "Microsoft Dynamics 365 Customer Engagement activitypointer EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d8413f17-5b14-41c1-bb4b-b8553945ab90
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API activitypointer entitytype."
---
# activitypointer EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/activitypointer.md](./descriptions/activitypointer.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]activitypointers </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Activity</td></tr>
<tr><td><b>Primary Key:</b></td><td>activityid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>subject</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The activitypointer entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activityadditionalparams|Edm.String|**Display Name**: Activity Additional Parameters<br />**Description**: Additional information provided by the external application as JSON. For internal use only.<br />|
|activityid|Edm.Guid|**Display Name**: Activity<br />**Description**: Unique identifier of the activity.<br />|
|activitytypecode|Edm.String|**Display Name**: Activity Type<br />**Description**: Type of activity.<br />Read-only<br />|
|actualdurationminutes|Edm.Int32|**Display Name**: Actual Duration<br />**Description**: Actual duration of the activity in minutes.<br />|
|actualend|Edm.DateTimeOffset|**Display Name**: Actual End<br />**Description**: Actual end time of the activity.<br />|
|actualstart|Edm.DateTimeOffset|**Display Name**: Actual Start<br />**Description**: Actual start time of the activity.<br />|
|community|Edm.Int32|**Display Name**: Social Channel<br />**Description**: Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Facebook</td></tr><tr><td>2</td><td>Twitter</td></tr><tr><td>0</td><td>Other</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Date Created<br />**Description**: Date and time when the activity was created.<br />Read-only<br />|
|deliverylastattemptedon|Edm.DateTimeOffset|**Display Name**: Date Delivery Last Attempted<br />**Description**: Date and time when the delivery of the activity was last attempted.<br />Read-only<br />|
|deliveryprioritycode|Edm.Int32|**Display Name**: Delivery Priority<br />**Description**: Priority of delivery of the activity to the email server.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Low</td></tr><tr><td>1</td><td>Normal</td></tr><tr><td>2</td><td>High</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the activity.<br />|
|exchangeitemid|Edm.String|**Display Name**: Exchange Item ID<br />**Description**: The message id of activity which is returned from Exchange Server.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the activitypointer with respect to the base currency.<br />Read-only<br />|
|exchangeweblink|Edm.String|**Display Name**: Exchange WebLink<br />**Description**: Shows the web link of Activity of type email.<br />|
|instancetypecode|Edm.Int32|**Display Name**: Recurring Instance Type<br />**Description**: Type of instance of a recurring series.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Recurring</td></tr><tr><td>1</td><td>Recurring Master</td></tr><tr><td>2</td><td>Recurring Instance</td></tr><tr><td>3</td><td>Recurring Exception</td></tr><tr><td>4</td><td>Recurring Future Exception</td></tr><tbody></table>|
|isbilled|Edm.Boolean|**Display Name**: Is Billed<br />**Description**: Information regarding whether the activity was billed as part of resolving a case.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismapiprivate|Edm.Boolean|**Display Name**: Is Private<br />**Description**: For internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isregularactivity|Edm.Boolean|**Display Name**: Is Regular Activity<br />**Description**: Information regarding whether the activity is a regular activity type or event type.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isworkflowcreated|Edm.Boolean|**Display Name**: Is Workflow Created<br />**Description**: Information regarding whether the activity was created from a workflow rule.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date and time stamp of the last on hold time.<br />|
|leftvoicemail|Edm.Boolean|**Display Name**: Left Voice Mail<br />**Description**: Left the voice mail<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Last Updated<br />**Description**: Date and time when activity was last modified.<br />Read-only<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows how long, in minutes, that the record was on hold.<br />Read-only<br />|
|postponeactivityprocessinguntil|Edm.DateTimeOffset|**Display Name**: Delay activity processing until<br />**Description**: For internal use only.<br />Read-only<br />|
|prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Priority of the activity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Low</td></tr><tr><td>1</td><td>Normal</td></tr><tr><td>2</td><td>High</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process<br />**Description**: Unique identifier of the Process.<br />|
|scheduleddurationminutes|Edm.Int32|**Display Name**: Scheduled Duration<br />**Description**: Scheduled duration of the activity, specified in minutes.<br />|
|scheduledend|Edm.DateTimeOffset|**Display Name**: Due Date<br />**Description**: Scheduled end time of the activity.<br />|
|scheduledstart|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Scheduled start time of the activity.<br />|
|senton|Edm.DateTimeOffset|**Display Name**: Date Sent<br />**Description**: Date and time when the activity was sent.<br />Read-only<br />|
|seriesid|Edm.Guid|**Display Name**: Series Id<br />**Description**: Uniqueidentifier specifying the id of recurring series of an instance.<br />Read-only<br />|
|sortdate|Edm.DateTimeOffset|**Display Name**: Sort Date<br />**Description**: Shows the date and time by which the activities are sorted.<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Unique identifier of the Stage.<br />|
|statecode|Edm.Int32|**Display Name**: Activity Status<br />**Description**: Status of the activity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Open</td></tr><tr><td>1</td><td>Completed</td></tr><tr><td>2</td><td>Canceled</td></tr><tr><td>3</td><td>Scheduled</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the activity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Open</td></tr><tr><td>2</td><td>Completed</td></tr><tr><td>3</td><td>Canceled</td></tr><tr><td>4</td><td>Scheduled</td></tr><tbody></table>|
|subject|Edm.String|**Display Name**: Subject<br />**Description**: Subject associated with the activity.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the activity.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the activity.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the activitypointer.|
|_modifiedby_value|modifiedby<br />|Unique identifier of user who last modified the activity.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the activitypointer.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the activity.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the activity.|
|_owningteam_value|owningteam<br />|Unique identifier of the team that owns the activity.|
|_owninguser_value|owninguser<br />|Unique identifier of the user that owns the activity.|
|_regardingobjectid_value|regardingobjectid_lead<br />regardingobjectid_bookableresourcebooking<br />regardingobjectid_bookableresourcebookingheader<br />regardingobjectid_campaign<br />regardingobjectid_contract<br />regardingobjectid_entitlement<br />regardingobjectid_entitlementtemplate<br />regardingobjectid_incident<br />regardingobjectid_site<br />regardingobjectid_invoice<br />regardingobjectid_opportunity<br />regardingobjectid_quote<br />regardingobjectid_salesorder<br />regardingobjectid_adx_webpage<br />regardingobjectid_adx_website<br />regardingobjectid_adx_ad<br />regardingobjectid_adx_adplacement<br />regardingobjectid_adx_invitation<br />regardingobjectid_adx_poll<br />regardingobjectid_adx_polloption<br />regardingobjectid_adx_pollplacement<br />regardingobjectid_adx_pollsubmission<br />regardingobjectid_adx_publishingstatetransitionrule<br />regardingobjectid_adx_redirect<br />regardingobjectid_adx_shortcut<br />regardingobjectid_msdyn_bookingalertstatus<br />regardingobjectid_msdyn_bookingrule<br />regardingobjectid_msdyn_resourceterritory<br />regardingobjectid_msdyn_systemuserschedulersetting<br />regardingobjectid_msdyn_timegroup<br />regardingobjectid_msdyn_timegroupdetail<br />regardingobjectid_msdyn_agreement<br />regardingobjectid_msdyn_agreementbookingdate<br />regardingobjectid_msdyn_agreementbookingincident<br />regardingobjectid_msdyn_agreementbookingproduct<br />regardingobjectid_msdyn_agreementbookingservice<br />regardingobjectid_msdyn_agreementbookingservicetask<br />regardingobjectid_msdyn_agreementbookingsetup<br />regardingobjectid_msdyn_agreementinvoicedate<br />regardingobjectid_msdyn_agreementinvoiceproduct<br />regardingobjectid_msdyn_agreementinvoicesetup<br />regardingobjectid_msdyn_bookingtimestamp<br />regardingobjectid_msdyn_customerasset<br />regardingobjectid_msdyn_fieldservicesetting<br />regardingobjectid_msdyn_incidenttypecharacteristic<br />regardingobjectid_msdyn_incidenttypeproduct<br />regardingobjectid_msdyn_incidenttypeservice<br />regardingobjectid_msdyn_inventoryadjustment<br />regardingobjectid_msdyn_inventoryadjustmentproduct<br />regardingobjectid_msdyn_inventoryjournal<br />regardingobjectid_msdyn_inventorytransfer<br />regardingobjectid_msdyn_payment<br />regardingobjectid_msdyn_paymentdetail<br />regardingobjectid_msdyn_paymentmethod<br />regardingobjectid_msdyn_paymentterm<br />regardingobjectid_msdyn_postalcode<br />regardingobjectid_msdyn_productinventory<br />regardingobjectid_msdyn_purchaseorder<br />regardingobjectid_msdyn_purchaseorderbill<br />regardingobjectid_msdyn_purchaseorderproduct<br />regardingobjectid_msdyn_purchaseorderreceipt<br />regardingobjectid_msdyn_purchaseorderreceiptproduct<br />regardingobjectid_msdyn_purchaseordersubstatus<br />regardingobjectid_msdyn_quotebookingincident<br />regardingobjectid_msdyn_quotebookingproduct<br />regardingobjectid_msdyn_quotebookingservice<br />regardingobjectid_msdyn_quotebookingservicetask<br />regardingobjectid_msdyn_rma<br />regardingobjectid_msdyn_rmaproduct<br />regardingobjectid_msdyn_rmareceipt<br />regardingobjectid_msdyn_rmareceiptproduct<br />regardingobjectid_msdyn_rmasubstatus<br />regardingobjectid_msdyn_rtv<br />regardingobjectid_msdyn_rtvproduct<br />regardingobjectid_msdyn_rtvsubstatus<br />regardingobjectid_msdyn_shipvia<br />regardingobjectid_msdyn_timeoffrequest<br />regardingobjectid_msdyn_warehouse<br />regardingobjectid_msdyn_workorder<br />regardingobjectid_msdyn_workordercharacteristic<br />regardingobjectid_msdyn_workorderincident<br />regardingobjectid_msdyn_workorderproduct<br />regardingobjectid_msdyn_workorderresourcerestriction<br />regardingobjectid_msdyn_workorderservice<br />regardingobjectid_msdyn_workorderservicetask<br />regardingobjectid_msdyn_processnotes<br />regardingobjectid_msdyn_projectteam<br />regardingobjectid_msdyncrm_contentsettings<br />regardingobjectid_msdyncrm_customerjourney<br />regardingobjectid_msdyncrm_marketingdynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemailtestsend<br />regardingobjectid_msdyncrm_uicconfig<br />regardingobjectid_msdyncrm_leadscoremodel<br />regardingobjectid_msdyn_question<br />regardingobjectid_msdyn_responseaction<br />regardingobjectid_msdyn_survey<br />regardingobjectid_msdyn_surveyresponse<br />regardingobjectid_msevtmgt_checkin<br />regardingobjectid_msevtmgt_event<br />regardingobjectid_msevtmgt_eventpurchase<br />regardingobjectid_msevtmgt_eventpurchaseattendee<br />regardingobjectid_msevtmgt_eventpurchasepass<br />regardingobjectid_msevtmgt_eventregistration<br />regardingobjectid_msevtmgt_hotel<br />regardingobjectid_msevtmgt_hotelroomallocation<br />regardingobjectid_msevtmgt_hotelroomreservation<br />regardingobjectid_msevtmgt_layout<br />regardingobjectid_msevtmgt_room<br />regardingobjectid_msevtmgt_session<br />regardingobjectid_msevtmgt_sessionregistration<br />regardingobjectid_msevtmgt_sessiontrack<br />regardingobjectid_msevtmgt_speaker<br />regardingobjectid_msevtmgt_speakerengagement<br />regardingobjectid_msevtmgt_sponsorablearticle<br />regardingobjectid_msevtmgt_sponsorship<br />regardingobjectid_msevtmgt_venue<br />regardingobjectid_msevtmgt_webinarconfiguration<br />regardingobjectid_msevtmgt_webinarprovider<br />regardingobjectid_msdyncrm_linkedinaccount<br />regardingobjectid_msdyncrm_linkedinactivity<br />regardingobjectid_msdyncrm_linkedinfieldmapping<br />regardingobjectid_msdyncrm_linkedinform<br />regardingobjectid_msdyncrm_linkedinformanswer<br />regardingobjectid_msdyncrm_linkedinformquestion<br />regardingobjectid_msdyncrm_linkedinformsubmission<br />regardingobjectid_msdyncrm_linkedinleadmatchingstrategy<br />regardingobjectid_msdyncrm_linkedinuserprofile<br />regardingobjectid_new_interactionforemail<br />regardingobjectid_knowledgebaserecord<br />regardingobjectid_account<br />regardingobjectid_contact<br />regardingobjectid_knowledgearticle<br />|Unique identifier of the object with which the activity is associated.|
|_sendermailboxid_value|sendermailboxid<br />|Unique identifier of the mailbox associated with the sender of the email message.|
|_serviceid_value|serviceid<br />|Unique identifier of an associated service.|
|_slaid_value|sla_activitypointer_sla<br />|Choose the service level agreement (SLA) that you want to apply to the case record.|
|_slainvokedid_value|slainvokedid_activitypointer_sla<br />|Last SLA that was applied to this case. This field is for internal use only.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the activitypointer.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_activitypointer_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_activitypointer_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_activitypointer_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_activitypointer_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_activitypointers|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_activitypointer|
|owningteam|[team EntityType](team.md)|team_activity|
|owninguser|[systemuser EntityType](systemuser.md)|user_activity|
|regardingobjectid_account|[account EntityType](account.md)|Account_ActivityPointers|
|regardingobjectid_adx_ad|[adx_ad EntityType](adx_ad.md)|adx_ad_ActivityPointers|
|regardingobjectid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_ActivityPointers|
|regardingobjectid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_ActivityPointers|
|regardingobjectid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_ActivityPointers|
|regardingobjectid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_ActivityPointers|
|regardingobjectid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_ActivityPointers|
|regardingobjectid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_ActivityPointers|
|regardingobjectid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_ActivityPointers|
|regardingobjectid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_ActivityPointers|
|regardingobjectid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_ActivityPointers|
|regardingobjectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_ActivityPointers|
|regardingobjectid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_ActivityPointers|
|regardingobjectid_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_ActivityPointers|
|regardingobjectid_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_ActivityPointers|
|regardingobjectid_bulkoperation|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_ActivityPointers|
|regardingobjectid_campaign|[campaign EntityType](campaign.md)|Campaign_ActivityPointers|
|regardingobjectid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_ActivityPointers|
|regardingobjectid_contact|[contact EntityType](contact.md)|Contact_ActivityPointers|
|regardingobjectid_contract|[contract EntityType](contract.md)|Contract_ActivityPointers|
|regardingobjectid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_ActivityPointers|
|regardingobjectid_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_ActivityPointers|
|regardingobjectid_incident|[incident EntityType](incident.md)|Incident_ActivityPointers|
|regardingobjectid_invoice|[invoice EntityType](invoice.md)|Invoice_ActivityPointers|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|KnowledgeArticle_ActivityPointers|
|regardingobjectid_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_ActivityPointers|
|regardingobjectid_lead|[lead EntityType](lead.md)|Lead_ActivityPointers|
|regardingobjectid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_ActivityPointers|
|regardingobjectid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_ActivityPointers|
|regardingobjectid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_ActivityPointers|
|regardingobjectid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_ActivityPointers|
|regardingobjectid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_ActivityPointers|
|regardingobjectid_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_ActivityPointers|
|regardingobjectid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_ActivityPointers|
|regardingobjectid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_ActivityPointers|
|regardingobjectid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_ActivityPointers|
|regardingobjectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_ActivityPointers|
|regardingobjectid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_ActivityPointers|
|regardingobjectid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_ActivityPointers|
|regardingobjectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_ActivityPointers|
|regardingobjectid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_ActivityPointers|
|regardingobjectid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_ActivityPointers|
|regardingobjectid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_ActivityPointers|
|regardingobjectid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_ActivityPointers|
|regardingobjectid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_ActivityPointers|
|regardingobjectid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_ActivityPointers|
|regardingobjectid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_ActivityPointers|
|regardingobjectid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_ActivityPointers|
|regardingobjectid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_ActivityPointers|
|regardingobjectid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_ActivityPointers|
|regardingobjectid_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_ActivityPointers|
|regardingobjectid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_ActivityPointers|
|regardingobjectid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_ActivityPointers|
|regardingobjectid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_ActivityPointers|
|regardingobjectid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_ActivityPointers|
|regardingobjectid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_ActivityPointers|
|regardingobjectid_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_ActivityPointers|
|regardingobjectid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_ActivityPointers|
|regardingobjectid_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_ActivityPointers|
|regardingobjectid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_ActivityPointers|
|regardingobjectid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_ActivityPointers|
|regardingobjectid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_ActivityPointers|
|regardingobjectid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_ActivityPointers|
|regardingobjectid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_ActivityPointers|
|regardingobjectid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_ActivityPointers|
|regardingobjectid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_ActivityPointers|
|regardingobjectid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_ActivityPointers|
|regardingobjectid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_ActivityPointers|
|regardingobjectid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_ActivityPointers|
|regardingobjectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_ActivityPointers|
|regardingobjectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_ActivityPointers|
|regardingobjectid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_ActivityPointers|
|regardingobjectid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_ActivityPointers|
|regardingobjectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_ActivityPointers|
|regardingobjectid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_ActivityPointers|
|regardingobjectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_ActivityPointers|
|regardingobjectid_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_ActivityPointers|
|regardingobjectid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_ActivityPointers|
|regardingobjectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_ActivityPointers|
|regardingobjectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_ActivityPointers|
|regardingobjectid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_ActivityPointers|
|regardingobjectid_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_ActivityPointers|
|regardingobjectid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_ActivityPointers|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_ActivityPointers|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers|
|regardingobjectid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_ActivityPointers|
|regardingobjectid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_ActivityPointers|
|regardingobjectid_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_ActivityPointers|
|regardingobjectid_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_ActivityPointers|
|regardingobjectid_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_ActivityPointers|
|regardingobjectid_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_ActivityPointers|
|regardingobjectid_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_ActivityPointers|
|regardingobjectid_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_ActivityPointers|
|regardingobjectid_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_ActivityPointers|
|regardingobjectid_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_ActivityPointers|
|regardingobjectid_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_ActivityPointers|
|regardingobjectid_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_ActivityPointers|
|regardingobjectid_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_ActivityPointers|
|regardingobjectid_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_ActivityPointers|
|regardingobjectid_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_ActivityPointers|
|regardingobjectid_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_ActivityPointers|
|regardingobjectid_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_ActivityPointers|
|regardingobjectid_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_ActivityPointers|
|regardingobjectid_msevtmgt_webinarconfiguration|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_ActivityPointers|
|regardingobjectid_msevtmgt_webinarprovider|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_ActivityPointers|
|regardingobjectid_new_interactionforemail|[interactionforemail EntityType](interactionforemail.md)|new_interactionforemail_ActivityPointers|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_ActivityPointers|
|regardingobjectid_quote|[quote EntityType](quote.md)|Quote_ActivityPointers|
|regardingobjectid_salesorder|[salesorder EntityType](salesorder.md)|SalesOrder_ActivityPointers|
|regardingobjectid_site|[site EntityType](site.md)|site_ActivityPointers|
|sendermailboxid|[mailbox EntityType](mailbox.md)|activitypointer_sendermailboxid_mailbox|
|serviceid|[service EntityType](service.md)|service_activity_pointers|
|sla_activitypointer_sla|[sla EntityType](sla.md)|manualsla_activitypointer|
|slainvokedid_activitypointer_sla|[sla EntityType](sla.md)|sla_activitypointer|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_ActivityPointer|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|activity_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|originatingactivityid_activitypointer|  
|activity_pointer_activity_mime_attachment|[activitymimeattachment EntityType](activitymimeattachment.md)|objectid_activitypointer|  
|activity_pointer_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|activityid_adx_alertsubscription|  
|activity_pointer_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|activityid_adx_inviteredemption|  
|activity_pointer_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|activityid_adx_portalcomment|  
|activity_pointer_appointment|[appointment EntityType](appointment.md)|activityid_activitypointer|  
|activity_pointer_BulkOperation|[bulkoperation EntityType](bulkoperation.md)|activityid_activitypointer|  
|activity_pointer_BulkOperation_logs|[bulkoperationlog EntityType](bulkoperationlog.md)|bulkoperationid_activitypointer|  
|activity_pointer_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|activityid_activitypointer|  
|activity_pointer_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|activityid_activitypointer|  
|activity_pointer_email|[email EntityType](email.md)|activityid_activitypointer|  
|activity_pointer_fax|[fax EntityType](fax.md)|activityid_activitypointer|  
|activity_pointer_incident_resolution|[incidentresolution EntityType](incidentresolution.md)|activityid_activitypointer|  
|activity_pointer_letter|[letter EntityType](letter.md)|activityid_activitypointer|  
|activity_pointer_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|activityid_msdyn_approval|  
|activity_pointer_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|activityid_msdyn_bookingalert|  
|activity_pointer_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|activityid_msdyn_surveyinvite|  
|activity_pointer_opportunity_close|[opportunityclose EntityType](opportunityclose.md)|activityid_activitypointer|  
|activity_pointer_order_close|[orderclose EntityType](orderclose.md)|activityid_activitypointer|  
|activity_pointer_phonecall|[phonecall EntityType](phonecall.md)|activityid_activitypointer|  
|activity_pointer_quote_close|[quoteclose EntityType](quoteclose.md)|activityid_activitypointer|  
|activity_pointer_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|activityid_activitypointer|  
|activity_pointer_service_appointment|[serviceappointment EntityType](serviceappointment.md)|activityid_activitypointer|  
|activity_pointer_socialactivity|[socialactivity EntityType](socialactivity.md)|activityid_activitypointer|  
|activity_pointer_task|[task EntityType](task.md)|activityid_activitypointer|  
|activitypointer_activity_parties|[activityparty EntityType](activityparty.md)|activityid_activitypointer|  
|ActivityPointer_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_activitypointer|  
|ActivityPointer_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_activitypointer|  
|ActivityPointer_CampaignActivityItems|[campaignactivityitem EntityType](campaignactivityitem.md)|campaignactivityid|  
|activitypointer_connections1|[connection EntityType](connection.md)|record1id_activitypointer|  
|activitypointer_connections2|[connection EntityType](connection.md)|record2id_activitypointer|  
|ActivityPointer_QueueItem|[queueitem EntityType](queueitem.md)|objectid_activitypointer|  
|CreatedActivity_BulkOperationLogs|[bulkoperationlog EntityType](bulkoperationlog.md)|createdobjectid_activitypointer|  
|slakpiinstance_activitypointer|[slakpiinstance EntityType](slakpiinstance.md)|regarding_activitypointer|  

## Derived Types
The following entity types inherit from the activitypointer entity type.


|Name|Description|  
|----|---------|  
|[adx_alertsubscription EntityType](adx_alertsubscription.md)|[!INCLUDE[./descriptions/adx_alertsubscription.md](./descriptions/adx_alertsubscription.md)]|
|[adx_inviteredemption EntityType](adx_inviteredemption.md)|[!INCLUDE[./descriptions/adx_inviteredemption.md](./descriptions/adx_inviteredemption.md)]|
|[adx_portalcomment EntityType](adx_portalcomment.md)|[!INCLUDE[./descriptions/adx_portalcomment.md](./descriptions/adx_portalcomment.md)]|
|[appointment EntityType](appointment.md)|[!INCLUDE[./descriptions/appointment.md](./descriptions/appointment.md)]|
|[bulkoperation EntityType](bulkoperation.md)|[!INCLUDE[./descriptions/bulkoperation.md](./descriptions/bulkoperation.md)]|
|[campaignactivity EntityType](campaignactivity.md)|[!INCLUDE[./descriptions/campaignactivity.md](./descriptions/campaignactivity.md)]|
|[campaignresponse EntityType](campaignresponse.md)|[!INCLUDE[./descriptions/campaignresponse.md](./descriptions/campaignresponse.md)]|
|[email EntityType](email.md)|[!INCLUDE[./descriptions/email.md](./descriptions/email.md)]|
|[fax EntityType](fax.md)|[!INCLUDE[./descriptions/fax.md](./descriptions/fax.md)]|
|[incidentresolution EntityType](incidentresolution.md)|[!INCLUDE[./descriptions/incidentresolution.md](./descriptions/incidentresolution.md)]|
|[letter EntityType](letter.md)|[!INCLUDE[./descriptions/letter.md](./descriptions/letter.md)]|
|[msdyn_approval EntityType](msdyn_approval.md)|[!INCLUDE[./descriptions/msdyn_approval.md](./descriptions/msdyn_approval.md)]|
|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|[!INCLUDE[./descriptions/msdyn_bookingalert.md](./descriptions/msdyn_bookingalert.md)]|
|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|[!INCLUDE[./descriptions/msdyn_surveyinvite.md](./descriptions/msdyn_surveyinvite.md)]|
|[opportunityclose EntityType](opportunityclose.md)|[!INCLUDE[./descriptions/opportunityclose.md](./descriptions/opportunityclose.md)]|
|[orderclose EntityType](orderclose.md)|[!INCLUDE[./descriptions/orderclose.md](./descriptions/orderclose.md)]|
|[phonecall EntityType](phonecall.md)|[!INCLUDE[./descriptions/phonecall.md](./descriptions/phonecall.md)]|
|[quoteclose EntityType](quoteclose.md)|[!INCLUDE[./descriptions/quoteclose.md](./descriptions/quoteclose.md)]|
|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|[!INCLUDE[./descriptions/recurringappointmentmaster.md](./descriptions/recurringappointmentmaster.md)]|
|[serviceappointment EntityType](serviceappointment.md)|[!INCLUDE[./descriptions/serviceappointment.md](./descriptions/serviceappointment.md)]|
|[socialactivity EntityType](socialactivity.md)|[!INCLUDE[./descriptions/socialactivity.md](./descriptions/socialactivity.md)]|
|[task EntityType](task.md)|[!INCLUDE[./descriptions/task.md](./descriptions/task.md)]|

## Operations
The following operations can be used with the activitypointer entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  

## Solutions
The following solutions include the activitypointer entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Timeline Solution](../solutions/portaltimeline.md)|[!INCLUDE[../solutions/descriptions/portaltimeline.md](../solutions/descriptions/portaltimeline.md)]|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Activities Solution](../solutions/activities.md)|[!INCLUDE[../solutions/descriptions/activities.md](../solutions/descriptions/activities.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/activitypointer.md](./remarks/activitypointer.md)]

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