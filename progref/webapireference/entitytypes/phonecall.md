---
title: "Microsoft Dynamics 365 Customer Engagement phonecall EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3a0d230a-e605-44a6-b4d1-48ad1684d748
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API phonecall entitytype."
---
# phonecall EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/phonecall.md](./descriptions/phonecall.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]phonecalls </td></tr>
<tr><td><b>Base Type:</b></td><td>[activitypointer EntityType](activitypointer.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Phone Call</td></tr>
<tr><td><b>Primary Key:</b></td><td>activityid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>subject</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The phonecall entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activityadditionalparams|Edm.String|**Display Name**: Additional Parameters<br />**Description**: Additional information provided by the external application as JSON. For internal use only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|activityid|Edm.Guid|**Display Name**: Phone Call<br />**Description**: Unique identifier of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|activitytypecode|Edm.String|**Display Name**: Activity Type<br />**Description**: Type of activity.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|actualdurationminutes|Edm.Int32|**Display Name**: Duration<br />**Description**: Actual duration of the activity in minutes.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|actualend|Edm.DateTimeOffset|**Display Name**: Actual End<br />**Description**: Actual end time of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|actualstart|Edm.DateTimeOffset|**Display Name**: Actual Start<br />**Description**: Actual start time of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|category|Edm.String|**Display Name**: Category<br />**Description**: Type a category to identify the phone call type, such as lead gathering or customer follow-up, to tie the phone call to a business group or function.<br />|
|community|Edm.Int32|**Description**: Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the activity was created.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|deliverylastattemptedon|Edm.DateTimeOffset|**Description**: Date and time when the delivery of the activity was last attempted.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|deliveryprioritycode|Edm.Int32|**Description**: Priority of delivery of the activity to the email server.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|directioncode|Edm.Boolean|**Display Name**: Direction<br />**Description**: Select the direction of the phone call as incoming or outbound.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Outgoing</td></tr><tr><td>0</td><td>Incoming</td></tr><tbody></table>|
|exchangeitemid|Edm.String|**Description**: The message id of activity which is returned from Exchange Server.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the activitypointer with respect to the base currency.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|exchangeweblink|Edm.String|**Description**: Shows the web link of Activity of type email.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|instancetypecode|Edm.Int32|**Description**: Type of instance of a recurring series.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|isbilled|Edm.Boolean|**Display Name**: Is Billed<br />**Description**: Information regarding whether the activity was billed as part of resolving a case.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismapiprivate|Edm.Boolean|**Description**: For internal use only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|isregularactivity|Edm.Boolean|**Display Name**: Is Regular Activity<br />**Description**: Information regarding whether the activity is a regular activity type or event type.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isworkflowcreated|Edm.Boolean|**Display Name**: Is Workflow Created<br />**Description**: Information regarding whether the activity was created from a workflow rule.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date and time stamp of the last on hold time.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|leftvoicemail|Edm.Boolean|**Display Name**: Left Voice Mail<br />**Description**: Left the voice mail<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when activity was last modified.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows how long, in minutes, that the record was on hold.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|phonenumber|Edm.String|**Display Name**: Phone Number<br />**Description**: Type the phone number.<br />|
|postponeactivityprocessinguntil|Edm.DateTimeOffset|**Description**: For internal use only.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Priority of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Low</td></tr><tr><td>1</td><td>Normal</td></tr><tr><td>2</td><td>High</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process<br />**Description**: Unique identifier of the Process.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|scheduleddurationminutes|Edm.Int32|**Display Name**: Scheduled Duration<br />**Description**: Scheduled duration of the activity, specified in minutes.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|scheduledend|Edm.DateTimeOffset|**Display Name**: Due<br />**Description**: Scheduled end time of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|scheduledstart|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Scheduled start time of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|senton|Edm.DateTimeOffset|**Description**: Date and time when the activity was sent.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|seriesid|Edm.Guid|**Description**: Uniqueidentifier specifying the id of recurring series of an instance.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|sortdate|Edm.DateTimeOffset|**Display Name**: Sort Date<br />**Description**: Shows the date and time by which the activities are sorted.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Unique identifier of the Stage.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|statecode|Edm.Int32|**Display Name**: Activity Status<br />**Description**: Status of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Open</td></tr><tr><td>1</td><td>Completed</td></tr><tr><td>2</td><td>Canceled</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Open</td></tr><tr><td>2</td><td>Made</td></tr><tr><td>3</td><td>Canceled</td></tr><tr><td>4</td><td>Received</td></tr><tbody></table>|
|subcategory|Edm.String|**Display Name**: Sub-Category<br />**Description**: Type a subcategory to identify the phone call type and relate the activity to a specific product, sales region, business group, or other function.<br />|
|subject|Edm.String|**Display Name**: Subject<br />**Description**: Subject associated with the activity.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|subscriptionid|Edm.Guid|**Display Name**: Subscription<br />**Description**: For internal use only.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: For internal use only.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the activity.<br />Read-only<br />**Inherited from**: [activitypointer EntityType](activitypointer.md)<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value||Unique identifier of the user who created the activity.|
|_createdonbehalfby_value||Unique identifier of the delegate user who created the activitypointer.|
|_modifiedby_value||Unique identifier of user who last modified the activity.|
|_modifiedonbehalfby_value||Unique identifier of the delegate user who last modified the activitypointer.|
|_msdyncrm_associatedcustomerjourneyiteration_value|msdyncrm_associatedcustomerjourneyiteration_PhoneCall<br />|Customer Journey Iteration|
|_ownerid_value||Unique identifier of the user or team who owns the activity.|
|_owningbusinessunit_value||Unique identifier of the business unit that owns the activity.|
|_owningteam_value||Unique identifier of the team that owns the activity.|
|_owninguser_value||Unique identifier of the user that owns the activity.|
|_regardingobjectid_value||Unique identifier of the object with which the activity is associated.|
|_sendermailboxid_value||Unique identifier of the mailbox associated with the sender of the email message.|
|_serviceid_value||Unique identifier of an associated service.|
|_slaid_value||Choose the service level agreement (SLA) that you want to apply to the case record.|
|_slainvokedid_value||Last SLA that was applied to this case. This field is for internal use only.|
|_transactioncurrencyid_value||Unique identifier of the currency associated with the activitypointer.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|activityid_activitypointer|[activitypointer EntityType](activitypointer.md)|activity_pointer_phonecall|
|createdby|[systemuser EntityType](systemuser.md)|lk_activitypointer_createdby|
|createdby_phonecall|[systemuser EntityType](systemuser.md)|lk_phonecall_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_activitypointer_createdonbehalfby|
|createdonbehalfby_phonecall|[systemuser EntityType](systemuser.md)|lk_phonecall_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_activitypointer_modifiedby|
|modifiedby_phonecall|[systemuser EntityType](systemuser.md)|lk_phonecall_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_activitypointer_modifiedonbehalfby|
|modifiedonbehalfby_phonecall|[systemuser EntityType](systemuser.md)|lk_phonecall_modifiedonbehalfby|
|msdyncrm_associatedcustomerjourneyiteration_PhoneCall|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|msdyncrm_msdyncrm_customerjourneyiteration_phonecall|
|ownerid|[principal EntityType](principal.md)|owner_activitypointers|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_activitypointer|
|owningbusinessunit_phonecall|[businessunit EntityType](businessunit.md)|business_unit_phone_call_activities|
|owningteam|[team EntityType](team.md)|team_activity|
|owningteam_phonecall|[team EntityType](team.md)|team_phonecall|
|owninguser|[systemuser EntityType](systemuser.md)|user_activity|
|owninguser_phonecall|[systemuser EntityType](systemuser.md)|user_phonecall|
|regardingobjectid_account|[account EntityType](account.md)|Account_ActivityPointers|
|regardingobjectid_account_phonecall|[account EntityType](account.md)|Account_Phonecalls|
|regardingobjectid_adx_ad|[adx_ad EntityType](adx_ad.md)|adx_ad_ActivityPointers|
|regardingobjectid_adx_ad_phonecall|[adx_ad EntityType](adx_ad.md)|adx_ad_PhoneCalls|
|regardingobjectid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_ActivityPointers|
|regardingobjectid_adx_adplacement_phonecall|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_PhoneCalls|
|regardingobjectid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_ActivityPointers|
|regardingobjectid_adx_invitation_phonecall|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_PhoneCalls|
|regardingobjectid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_ActivityPointers|
|regardingobjectid_adx_poll_phonecall|[adx_poll EntityType](adx_poll.md)|adx_poll_PhoneCalls|
|regardingobjectid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_ActivityPointers|
|regardingobjectid_adx_polloption_phonecall|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_PhoneCalls|
|regardingobjectid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_ActivityPointers|
|regardingobjectid_adx_pollplacement_phonecall|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_PhoneCalls|
|regardingobjectid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_ActivityPointers|
|regardingobjectid_adx_pollsubmission_phonecall|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_PhoneCalls|
|regardingobjectid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_ActivityPointers|
|regardingobjectid_adx_publishingstatetransitionrule_phonecall|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_PhoneCalls|
|regardingobjectid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_ActivityPointers|
|regardingobjectid_adx_redirect_phonecall|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_PhoneCalls|
|regardingobjectid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_ActivityPointers|
|regardingobjectid_adx_shortcut_phonecall|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_PhoneCalls|
|regardingobjectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_ActivityPointers|
|regardingobjectid_adx_webpage_phonecall|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_PhoneCalls|
|regardingobjectid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_ActivityPointers|
|regardingobjectid_adx_website_phonecall|[adx_website EntityType](adx_website.md)|adx_website_PhoneCalls|
|regardingobjectid_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_ActivityPointers|
|regardingobjectid_bookableresourcebooking_phonecall|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_PhoneCalls|
|regardingobjectid_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_ActivityPointers|
|regardingobjectid_bookableresourcebookingheader_phonecall|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_PhoneCalls|
|regardingobjectid_bulkoperation|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_ActivityPointers|
|regardingobjectid_bulkoperation_phonecall|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_Phonecall|
|regardingobjectid_campaign|[campaign EntityType](campaign.md)|Campaign_ActivityPointers|
|regardingobjectid_campaign_phonecall|[campaign EntityType](campaign.md)|Campaign_Phonecalls|
|regardingobjectid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_ActivityPointers|
|regardingobjectid_campaignactivity_phonecall|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_Phonecalls|
|regardingobjectid_contact|[contact EntityType](contact.md)|Contact_ActivityPointers|
|regardingobjectid_contact_phonecall|[contact EntityType](contact.md)|Contact_Phonecalls|
|regardingobjectid_contract|[contract EntityType](contract.md)|Contract_ActivityPointers|
|regardingobjectid_contract_phonecall|[contract EntityType](contract.md)|Contract_Phonecalls|
|regardingobjectid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_ActivityPointers|
|regardingobjectid_entitlement_phonecall|[entitlement EntityType](entitlement.md)|entitlement_PhoneCalls|
|regardingobjectid_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_ActivityPointers|
|regardingobjectid_entitlementtemplate_phonecall|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_PhoneCalls|
|regardingobjectid_incident|[incident EntityType](incident.md)|Incident_ActivityPointers|
|regardingobjectid_incident_phonecall|[incident EntityType](incident.md)|Incident_Phonecalls|
|regardingobjectid_invoice|[invoice EntityType](invoice.md)|Invoice_ActivityPointers|
|regardingobjectid_invoice_phonecall|[invoice EntityType](invoice.md)|Invoice_Phonecalls|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|KnowledgeArticle_ActivityPointers|
|regardingobjectid_knowledgearticle_phonecall|[knowledgearticle EntityType](knowledgearticle.md)|KnowledgeArticle_Phonecalls|
|regardingobjectid_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_ActivityPointers|
|regardingobjectid_knowledgebaserecord_phonecall|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_PhoneCalls|
|regardingobjectid_lead|[lead EntityType](lead.md)|Lead_ActivityPointers|
|regardingobjectid_lead_phonecall|[lead EntityType](lead.md)|Lead_Phonecalls|
|regardingobjectid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_ActivityPointers|
|regardingobjectid_msdyn_agreement_phonecall|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_PhoneCalls|
|regardingobjectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingdate_phonecall|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_PhoneCalls|
|regardingobjectid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingincident_phonecall|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_PhoneCalls|
|regardingobjectid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingproduct_phonecall|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_PhoneCalls|
|regardingobjectid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingservice_phonecall|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_PhoneCalls|
|regardingobjectid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingservicetask_phonecall|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_PhoneCalls|
|regardingobjectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_ActivityPointers|
|regardingobjectid_msdyn_agreementbookingsetup_phonecall|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_PhoneCalls|
|regardingobjectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoicedate_phonecall|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_PhoneCalls|
|regardingobjectid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoiceproduct_phonecall|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_PhoneCalls|
|regardingobjectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_ActivityPointers|
|regardingobjectid_msdyn_agreementinvoicesetup_phonecall|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_PhoneCalls|
|regardingobjectid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_ActivityPointers|
|regardingobjectid_msdyn_bookingalertstatus_phonecall|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_PhoneCalls|
|regardingobjectid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_ActivityPointers|
|regardingobjectid_msdyn_bookingrule_phonecall|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_PhoneCalls|
|regardingobjectid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_ActivityPointers|
|regardingobjectid_msdyn_bookingtimestamp_phonecall|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_PhoneCalls|
|regardingobjectid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_ActivityPointers|
|regardingobjectid_msdyn_customerasset_phonecall|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_PhoneCalls|
|regardingobjectid_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_ActivityPointers|
|regardingobjectid_msdyn_fieldservicesetting_phonecall|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_PhoneCalls|
|regardingobjectid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_ActivityPointers|
|regardingobjectid_msdyn_incidenttypecharacteristic_phonecall|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_PhoneCalls|
|regardingobjectid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_ActivityPointers|
|regardingobjectid_msdyn_incidenttypeproduct_phonecall|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_PhoneCalls|
|regardingobjectid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_ActivityPointers|
|regardingobjectid_msdyn_incidenttypeservice_phonecall|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_PhoneCalls|
|regardingobjectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_ActivityPointers|
|regardingobjectid_msdyn_inventoryadjustment_phonecall|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_PhoneCalls|
|regardingobjectid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_ActivityPointers|
|regardingobjectid_msdyn_inventoryadjustmentproduct_phonecall|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_PhoneCalls|
|regardingobjectid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_ActivityPointers|
|regardingobjectid_msdyn_inventoryjournal_phonecall|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_PhoneCalls|
|regardingobjectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_ActivityPointers|
|regardingobjectid_msdyn_inventorytransfer_phonecall|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_PhoneCalls|
|regardingobjectid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_ActivityPointers|
|regardingobjectid_msdyn_payment_phonecall|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_PhoneCalls|
|regardingobjectid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_ActivityPointers|
|regardingobjectid_msdyn_paymentdetail_phonecall|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_PhoneCalls|
|regardingobjectid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_ActivityPointers|
|regardingobjectid_msdyn_paymentmethod_phonecall|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_PhoneCalls|
|regardingobjectid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_ActivityPointers|
|regardingobjectid_msdyn_paymentterm_phonecall|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_PhoneCalls|
|regardingobjectid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_ActivityPointers|
|regardingobjectid_msdyn_postalcode_phonecall|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_PhoneCalls|
|regardingobjectid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_ActivityPointers|
|regardingobjectid_msdyn_processnotes_phonecall|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_PhoneCalls|
|regardingobjectid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_ActivityPointers|
|regardingobjectid_msdyn_productinventory_phonecall|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_PhoneCalls|
|regardingobjectid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_ActivityPointers|
|regardingobjectid_msdyn_projectteam_phonecall|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_PhoneCalls|
|regardingobjectid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_ActivityPointers|
|regardingobjectid_msdyn_purchaseorder_phonecall|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_PhoneCalls|
|regardingobjectid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderbill_phonecall|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_PhoneCalls|
|regardingobjectid_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderproduct_phonecall|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_PhoneCalls|
|regardingobjectid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderreceipt_phonecall|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_PhoneCalls|
|regardingobjectid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_ActivityPointers|
|regardingobjectid_msdyn_purchaseorderreceiptproduct_phonecall|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_PhoneCalls|
|regardingobjectid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_ActivityPointers|
|regardingobjectid_msdyn_purchaseordersubstatus_phonecall|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_PhoneCalls|
|regardingobjectid_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_ActivityPointers|
|regardingobjectid_msdyn_question_phonecall|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_PhoneCalls|
|regardingobjectid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_ActivityPointers|
|regardingobjectid_msdyn_quotebookingincident_phonecall|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_PhoneCalls|
|regardingobjectid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_ActivityPointers|
|regardingobjectid_msdyn_quotebookingproduct_phonecall|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_PhoneCalls|
|regardingobjectid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_ActivityPointers|
|regardingobjectid_msdyn_quotebookingservice_phonecall|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_PhoneCalls|
|regardingobjectid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_ActivityPointers|
|regardingobjectid_msdyn_quotebookingservicetask_phonecall|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_PhoneCalls|
|regardingobjectid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_ActivityPointers|
|regardingobjectid_msdyn_resourceterritory_phonecall|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_PhoneCalls|
|regardingobjectid_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_ActivityPointers|
|regardingobjectid_msdyn_responseaction_phonecall|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_PhoneCalls|
|regardingobjectid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_ActivityPointers|
|regardingobjectid_msdyn_rma_phonecall|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_PhoneCalls|
|regardingobjectid_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_ActivityPointers|
|regardingobjectid_msdyn_rmaproduct_phonecall|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_PhoneCalls|
|regardingobjectid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_ActivityPointers|
|regardingobjectid_msdyn_rmareceipt_phonecall|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_PhoneCalls|
|regardingobjectid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_ActivityPointers|
|regardingobjectid_msdyn_rmareceiptproduct_phonecall|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_PhoneCalls|
|regardingobjectid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_ActivityPointers|
|regardingobjectid_msdyn_rmasubstatus_phonecall|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_PhoneCalls|
|regardingobjectid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_ActivityPointers|
|regardingobjectid_msdyn_rtv_phonecall|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_PhoneCalls|
|regardingobjectid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_ActivityPointers|
|regardingobjectid_msdyn_rtvproduct_phonecall|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_PhoneCalls|
|regardingobjectid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_ActivityPointers|
|regardingobjectid_msdyn_rtvsubstatus_phonecall|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_PhoneCalls|
|regardingobjectid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_ActivityPointers|
|regardingobjectid_msdyn_shipvia_phonecall|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_PhoneCalls|
|regardingobjectid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_ActivityPointers|
|regardingobjectid_msdyn_survey_phonecall|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_PhoneCalls|
|regardingobjectid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_ActivityPointers|
|regardingobjectid_msdyn_surveyresponse_phonecall|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_PhoneCalls|
|regardingobjectid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_ActivityPointers|
|regardingobjectid_msdyn_systemuserschedulersetting_phonecall|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_PhoneCalls|
|regardingobjectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_ActivityPointers|
|regardingobjectid_msdyn_timegroup_phonecall|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_PhoneCalls|
|regardingobjectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_ActivityPointers|
|regardingobjectid_msdyn_timegroupdetail_phonecall|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_PhoneCalls|
|regardingobjectid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_ActivityPointers|
|regardingobjectid_msdyn_timeoffrequest_phonecall|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_PhoneCalls|
|regardingobjectid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_ActivityPointers|
|regardingobjectid_msdyn_warehouse_phonecall|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_PhoneCalls|
|regardingobjectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_ActivityPointers|
|regardingobjectid_msdyn_workorder_phonecall|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_PhoneCalls|
|regardingobjectid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_ActivityPointers|
|regardingobjectid_msdyn_workordercharacteristic_phonecall|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_PhoneCalls|
|regardingobjectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_ActivityPointers|
|regardingobjectid_msdyn_workorderincident_phonecall|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_PhoneCalls|
|regardingobjectid_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_ActivityPointers|
|regardingobjectid_msdyn_workorderproduct_phonecall|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_PhoneCalls|
|regardingobjectid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_ActivityPointers|
|regardingobjectid_msdyn_workorderresourcerestriction_phonecall|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_PhoneCalls|
|regardingobjectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_ActivityPointers|
|regardingobjectid_msdyn_workorderservice_phonecall|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_PhoneCalls|
|regardingobjectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_ActivityPointers|
|regardingobjectid_msdyn_workorderservicetask_phonecall|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_PhoneCalls|
|regardingobjectid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_ActivityPointers|
|regardingobjectid_msdyncrm_contentsettings_phonecall|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_PhoneCalls|
|regardingobjectid_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_ActivityPointers|
|regardingobjectid_msdyncrm_customerjourney_phonecall|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_PhoneCalls|
|regardingobjectid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_ActivityPointers|
|regardingobjectid_msdyncrm_leadscoremodel_phonecall|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinaccount_phonecall|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinactivity_phonecall|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinfieldmapping_phonecall|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinform_phonecall|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformanswer_phonecall|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformquestion_phonecall|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinformsubmission_phonecall|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy_phonecall|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_PhoneCalls|
|regardingobjectid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_ActivityPointers|
|regardingobjectid_msdyncrm_linkedinuserprofile_phonecall|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_PhoneCalls|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_ActivityPointers|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata_phonecall|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_PhoneCalls|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_ActivityPointers|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata_phonecall|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_PhoneCalls|
|regardingobjectid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_ActivityPointers|
|regardingobjectid_msdyncrm_marketingemailtestsend_phonecall|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_PhoneCalls|
|regardingobjectid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_ActivityPointers|
|regardingobjectid_msdyncrm_uicconfig_phonecall|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_PhoneCalls|
|regardingobjectid_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_ActivityPointers|
|regardingobjectid_msevtmgt_checkin_phonecall|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_PhoneCalls|
|regardingobjectid_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_ActivityPointers|
|regardingobjectid_msevtmgt_event_phonecall|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_PhoneCalls|
|regardingobjectid_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchase_phonecall|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_PhoneCalls|
|regardingobjectid_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchaseattendee_phonecall|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_PhoneCalls|
|regardingobjectid_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_ActivityPointers|
|regardingobjectid_msevtmgt_eventpurchasepass_phonecall|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_PhoneCalls|
|regardingobjectid_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_ActivityPointers|
|regardingobjectid_msevtmgt_eventregistration_phonecall|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_PhoneCalls|
|regardingobjectid_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_ActivityPointers|
|regardingobjectid_msevtmgt_hotel_phonecall|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_PhoneCalls|
|regardingobjectid_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_ActivityPointers|
|regardingobjectid_msevtmgt_hotelroomallocation_phonecall|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_PhoneCalls|
|regardingobjectid_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_ActivityPointers|
|regardingobjectid_msevtmgt_hotelroomreservation_phonecall|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_PhoneCalls|
|regardingobjectid_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_ActivityPointers|
|regardingobjectid_msevtmgt_layout_phonecall|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_PhoneCalls|
|regardingobjectid_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_ActivityPointers|
|regardingobjectid_msevtmgt_room_phonecall|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_PhoneCalls|
|regardingobjectid_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_ActivityPointers|
|regardingobjectid_msevtmgt_session_phonecall|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_PhoneCalls|
|regardingobjectid_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_ActivityPointers|
|regardingobjectid_msevtmgt_sessionregistration_phonecall|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_PhoneCalls|
|regardingobjectid_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_ActivityPointers|
|regardingobjectid_msevtmgt_sessiontrack_phonecall|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_PhoneCalls|
|regardingobjectid_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_ActivityPointers|
|regardingobjectid_msevtmgt_speaker_phonecall|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_PhoneCalls|
|regardingobjectid_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_ActivityPointers|
|regardingobjectid_msevtmgt_speakerengagement_phonecall|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_PhoneCalls|
|regardingobjectid_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_ActivityPointers|
|regardingobjectid_msevtmgt_sponsorablearticle_phonecall|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_PhoneCalls|
|regardingobjectid_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_ActivityPointers|
|regardingobjectid_msevtmgt_sponsorship_phonecall|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_PhoneCalls|
|regardingobjectid_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_ActivityPointers|
|regardingobjectid_msevtmgt_venue_phonecall|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_PhoneCalls|
|regardingobjectid_msevtmgt_webinarconfiguration|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_ActivityPointers|
|regardingobjectid_msevtmgt_webinarconfiguration_phonecall|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_PhoneCalls|
|regardingobjectid_msevtmgt_webinarprovider|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_ActivityPointers|
|regardingobjectid_msevtmgt_webinarprovider_phonecall|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_PhoneCalls|
|regardingobjectid_new_interactionforemail|[interactionforemail EntityType](interactionforemail.md)|new_interactionforemail_ActivityPointers|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_ActivityPointers|
|regardingobjectid_opportunity_phonecall|[opportunity EntityType](opportunity.md)|Opportunity_Phonecalls|
|regardingobjectid_quote|[quote EntityType](quote.md)|Quote_ActivityPointers|
|regardingobjectid_quote_phonecall|[quote EntityType](quote.md)|Quote_Phonecalls|
|regardingobjectid_salesorder|[salesorder EntityType](salesorder.md)|SalesOrder_ActivityPointers|
|regardingobjectid_salesorder_phonecall|[salesorder EntityType](salesorder.md)|SalesOrder_Phonecalls|
|regardingobjectid_site|[site EntityType](site.md)|site_ActivityPointers|
|regardingobjectid_site_phonecall|[site EntityType](site.md)|site_PhoneCalls|
|sendermailboxid|[mailbox EntityType](mailbox.md)|activitypointer_sendermailboxid_mailbox|
|serviceid|[service EntityType](service.md)|service_activity_pointers|
|serviceid_phonecall|[service EntityType](service.md)|service_phonecalls|
|sla_activitypointer_sla|[sla EntityType](sla.md)|manualsla_activitypointer|
|sla_phonecall_sla|[sla EntityType](sla.md)|manualsla_phonecall|
|slainvokedid_activitypointer_sla|[sla EntityType](sla.md)|sla_activitypointer|
|slainvokedid_phonecall_sla|[sla EntityType](sla.md)|sla_phonecall|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_phonecalls|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_ActivityPointer|
|transactioncurrencyid_phonecall|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_PhoneCall|

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
|msdyn_phonecall_msdyn_surveyinvite_OriginatingTelephone|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_OriginatingPhoneCall|  
|phonecall_actioncard|[actioncard EntityType](actioncard.md)|regardingobjectid_phonecall_actioncard|  
|phonecall_activity_parties|[activityparty EntityType](activityparty.md)|activityid_phonecall|  
|PhoneCall_Annotation|[annotation EntityType](annotation.md)|objectid_phonecall|  
|PhoneCall_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_phonecall|  
|PhoneCall_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_phonecall|  
|phonecall_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|originatingactivityid_phonecall|  
|phonecall_connections1|[connection EntityType](connection.md)|record1id_phonecall|  
|phonecall_connections2|[connection EntityType](connection.md)|record2id_phonecall|  
|PhoneCall_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_phonecall|  
|PhoneCall_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_phonecall|  
|phonecall_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_phonecall|  
|phonecall_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_phonecall|  
|PhoneCall_QueueItem|[queueitem EntityType](queueitem.md)|objectid_phonecall|  
|PhoneCall_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_phonecall_syncerror|  
|slakpiinstance_activitypointer|[slakpiinstance EntityType](slakpiinstance.md)|regarding_activitypointer|  
|slakpiinstance_phonecall|[slakpiinstance EntityType](slakpiinstance.md)|regarding_phonecall|  

## Operations
The following operations can be used with the phonecall entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the phonecall entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Activities Solution](../solutions/activities.md)|[!INCLUDE[../solutions/descriptions/activities.md](../solutions/descriptions/activities.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Gamification Solution](../solutions/gamification.md)|[!INCLUDE[../solutions/descriptions/gamification.md](../solutions/descriptions/gamification.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[Microsoft Dynamics CRM Utility Workload Solution](../solutions/clientutility.md)|[!INCLUDE[../solutions/descriptions/clientutility.md](../solutions/descriptions/clientutility.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/phonecall.md](./remarks/phonecall.md)]

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