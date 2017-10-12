---
title: "Microsoft Dynamics 365 Customer Engagement team EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3c62c4cc-6841-4b6e-81a4-d8992ba19d86
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API team entitytype."
---
# team EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/team.md](./descriptions/team.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]teams </td></tr>
<tr><td><b>Base Type:</b></td><td>[principal EntityType](principal.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Team</td></tr>
<tr><td><b>Primary Key:</b></td><td>ownerid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the team was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the team.<br />|
|emailaddress|Edm.String|**Display Name**: Email<br />**Description**: Email address for the team.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the team with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|isdefault|Edm.Boolean|**Display Name**: Is Default<br />**Description**: Information about whether the team is a default business unit team.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the team was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Team Name<br />**Description**: Name of the team.<br />|
|organizationid|Edm.Guid|**Display Name**: Organization <br />**Description**: Unique identifier of the organization associated with the team.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|ownerid|Edm.Guid|**Description**: Unique identifier for the Owner: systemuserid or teamid.<br />**Inherited from**: [principal EntityType](principal.md)<br />|
|processid|Edm.Guid|**Display Name**: Process<br />**Description**: Shows the ID of the process.<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Shows the ID of the stage.<br />|
|systemmanaged|Edm.Boolean|**Display Name**: Is System Managed<br />**Description**: Select whether the team will be managed by the system.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|teamid|Edm.Guid|**Display Name**: Team<br />**Description**: Unique identifier for the team.<br />|
|teamtype|Edm.Int32|**Display Name**: Team Type<br />**Description**: Select the team type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Owner</td></tr><tr><td>1</td><td>Access</td></tr><tbody></table>|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: For internal use only.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version number<br />**Description**: Version number of the team.<br />Read-only<br />|
|yominame|Edm.String|**Display Name**: Yomi Name<br />**Description**: Pronunciation of the full name of the team, written in phonetic hiragana or katakana characters.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_administratorid_value|administratorid<br />|Unique identifier of the user primary responsible for the team.|
|_businessunitid_value|businessunitid<br />|Unique identifier of the business unit with which the team is associated.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the team.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the team.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the team.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the team.|
|_queueid_value|queueid<br />|Unique identifier of the default queue for the team.|
|_regardingobjectid_value|regardingobjectid_opportunity<br />regardingobjectid_knowledgearticle<br />|Choose the record that the team relates to.|
|_teamtemplateid_value|associatedteamtemplateid<br />|Shows the team template that is associated with the team.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the team.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|administratorid|[systemuser EntityType](systemuser.md)|lk_teambase_administratorid|
|associatedteamtemplateid|[teamtemplate EntityType](teamtemplate.md)|teamtemplate_Teams|
|businessunitid|[businessunit EntityType](businessunit.md)|business_unit_teams|
|createdby|[systemuser EntityType](systemuser.md)|lk_teambase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_team_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_teambase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_team_modifiedonbehalfby|
|organizationid_organization|[organization EntityType](organization.md)|organization_teams|
|queueid|[queue EntityType](queue.md)|queue_team|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_Teams|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|opportunity_Teams|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_teams|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Team|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_alertsubscription_owner_ownerid|[adx_alertsubscription EntityType](adx_alertsubscription.md)|ownerid_adx_alertsubscription|  
|adx_alertsubscription_team_owningteam|[adx_alertsubscription EntityType](adx_alertsubscription.md)|owningteam_adx_alertsubscription|  
|adx_inviteredemption_owner_ownerid|[adx_inviteredemption EntityType](adx_inviteredemption.md)|ownerid_adx_inviteredemption|  
|adx_inviteredemption_team_owningteam|[adx_inviteredemption EntityType](adx_inviteredemption.md)|owningteam_adx_inviteredemption|  
|adx_portalcomment_owner_ownerid|[adx_portalcomment EntityType](adx_portalcomment.md)|ownerid_adx_portalcomment|  
|adx_portalcomment_team_owningteam|[adx_portalcomment EntityType](adx_portalcomment.md)|owningteam_adx_portalcomment|  
|bulkoperation_owner_ownerid|[bulkoperation EntityType](bulkoperation.md)|ownerid_bulkoperation|  
|campaignactivity_owner_ownerid|[campaignactivity EntityType](campaignactivity.md)|ownerid_campaignactivity|  
|campaignresponse_owner_ownerid|[campaignresponse EntityType](campaignresponse.md)|ownerid_campaignresponse|  
|ImportFile_Team|[importfile EntityType](importfile.md)|recordsownerid_team|  
|incidentresolution_owner_ownerid|[incidentresolution EntityType](incidentresolution.md)|ownerid_incidentresolution|  
|lead_owning_team|[lead EntityType](lead.md)|owningteam|  
|msdyn_approval_owner_ownerid|[msdyn_approval EntityType](msdyn_approval.md)|ownerid_msdyn_approval|  
|msdyn_approval_team_owningteam|[msdyn_approval EntityType](msdyn_approval.md)|owningteam_msdyn_approval|  
|msdyn_bookingalert_owner_ownerid|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|ownerid_msdyn_bookingalert|  
|msdyn_bookingalert_team_owningteam|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|owningteam_msdyn_bookingalert|  
|msdyn_surveyinvite_owner_ownerid|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|ownerid_msdyn_surveyinvite|  
|msdyn_surveyinvite_team_owningteam|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|owningteam_msdyn_surveyinvite|  
|msdyn_team_msdyn_project_projectteamid|[msdyn_project EntityType](msdyn_project.md)|msdyn_projectteamid|  
|msdyn_team_msdyn_responseaction_Teamtonotify|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_Teamtonotify|  
|opportunityclose_owner_ownerid|[opportunityclose EntityType](opportunityclose.md)|ownerid_opportunityclose|  
|orderclose_owner_ownerid|[orderclose EntityType](orderclose.md)|ownerid_orderclose|  
|owner_accounts|[account EntityType](account.md)|ownerid|  
|owner_actioncards|[actioncard EntityType](actioncard.md)|ownerid|  
|owner_activitypointers|[activitypointer EntityType](activitypointer.md)|ownerid|  
|owner_adx_ad|[adx_ad EntityType](adx_ad.md)|ownerid|  
|owner_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|ownerid|  
|owner_adx_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|ownerid|  
|owner_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|ownerid|  
|owner_adx_pagealert|[adx_pagealert EntityType](adx_pagealert.md)|ownerid|  
|owner_adx_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|ownerid|  
|owner_adx_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|ownerid|  
|owner_adx_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|ownerid|  
|owner_adx_poll|[adx_poll EntityType](adx_poll.md)|ownerid|  
|owner_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|ownerid|  
|owner_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|ownerid|  
|owner_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|ownerid|  
|owner_adx_portallanguage|[adx_portallanguage EntityType](adx_portallanguage.md)|ownerid|  
|owner_adx_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|ownerid|  
|owner_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|ownerid|  
|owner_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|ownerid|  
|owner_adx_setting|[adx_setting EntityType](adx_setting.md)|ownerid|  
|owner_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|ownerid|  
|owner_adx_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|ownerid|  
|owner_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|ownerid|  
|owner_adx_tag|[adx_tag EntityType](adx_tag.md)|ownerid|  
|owner_adx_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|ownerid|  
|owner_adx_webfile|[adx_webfile EntityType](adx_webfile.md)|ownerid|  
|owner_adx_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|ownerid|  
|owner_adx_webform|[adx_webform EntityType](adx_webform.md)|ownerid|  
|owner_adx_weblink|[adx_weblink EntityType](adx_weblink.md)|ownerid|  
|owner_adx_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|ownerid|  
|owner_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|ownerid|  
|owner_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|ownerid|  
|owner_adx_webpageaccesscontrolrule|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|ownerid|  
|owner_adx_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|ownerid|  
|owner_adx_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|ownerid|  
|owner_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|ownerid|  
|owner_adx_website|[adx_website EntityType](adx_website.md)|ownerid|  
|owner_adx_websiteaccess|[adx_websiteaccess EntityType](adx_websiteaccess.md)|ownerid|  
|owner_adx_websitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|ownerid|  
|owner_annotations|[annotation EntityType](annotation.md)|ownerid|  
|owner_asyncoperations|[asyncoperation EntityType](asyncoperation.md)|ownerid|  
|owner_bookableresource|[bookableresource EntityType](bookableresource.md)|ownerid|  
|owner_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|ownerid|  
|owner_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|ownerid|  
|owner_bookableresourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|ownerid|  
|owner_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|ownerid|  
|owner_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|ownerid|  
|owner_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|ownerid|  
|owner_bookingstatus|[bookingstatus EntityType](bookingstatus.md)|ownerid|  
|owner_bulkoperationlog|[bulkoperationlog EntityType](bulkoperationlog.md)|ownerid|  
|owner_campaigns|[campaign EntityType](campaign.md)|ownerid|  
|owner_categories|[category EntityType](category.md)|ownerid|  
|owner_characteristic|[characteristic EntityType](characteristic.md)|ownerid|  
|owner_connections|[connection EntityType](connection.md)|ownerid|  
|owner_contacts|[contact EntityType](contact.md)|ownerid|  
|owner_contractdetail|[contractdetail EntityType](contractdetail.md)|ownerid|  
|owner_contracts|[contract EntityType](contract.md)|ownerid|  
|owner_duplicaterules|[duplicaterule EntityType](duplicaterule.md)|ownerid|  
|Owner_dynamicproperyinstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|ownerid|  
|owner_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|ownerid|  
|owner_entitlement|[entitlement EntityType](entitlement.md)|ownerid|  
|owner_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|ownerid|  
|owner_exchangesyncidmapping|[exchangesyncidmapping EntityType](exchangesyncidmapping.md)|ownerid|  
|owner_feedback|[feedback EntityType](feedback.md)|ownerid|  
|owner_goal|[goal EntityType](goal.md)|ownerid|  
|owner_goalrollupquery|[goalrollupquery EntityType](goalrollupquery.md)|ownerid|  
|owner_importdatas|[importdata EntityType](importdata.md)|ownerid|  
|owner_importfiles|[importfile EntityType](importfile.md)|ownerid|  
|owner_importlogs|[importlog EntityType](importlog.md)|ownerid|  
|owner_importmaps|[importmap EntityType](importmap.md)|ownerid|  
|owner_imports|[import EntityType](import.md)|ownerid|  
|owner_incidents|[incident EntityType](incident.md)|ownerid|  
|owner_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|ownerid|  
|owner_invoices|[invoice EntityType](invoice.md)|ownerid|  
|owner_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|ownerid|  
|owner_knowledgearticleincident|[knowledgearticleincident EntityType](knowledgearticleincident.md)|ownerid|  
|owner_leads|[lead EntityType](lead.md)|ownerid|  
|owner_lists|[list EntityType](list.md)|ownerid|  
|owner_mailbox|[mailbox EntityType](mailbox.md)|ownerid|  
|owner_mailmergetemplates|[mailmergetemplate EntityType](mailmergetemplate.md)|ownerid|  
|owner_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|ownerid|  
|owner_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|ownerid|  
|owner_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|ownerid|  
|owner_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|ownerid|  
|owner_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|ownerid|  
|owner_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|ownerid|  
|owner_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|ownerid|  
|owner_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|ownerid|  
|owner_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|ownerid|  
|owner_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|ownerid|  
|owner_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|ownerid|  
|owner_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|ownerid|  
|owner_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|ownerid|  
|owner_msdyn_answer|[msdyn_answer EntityType](msdyn_answer.md)|ownerid|  
|owner_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|ownerid|  
|owner_msdyn_bookingchange|[msdyn_bookingchange EntityType](msdyn_bookingchange.md)|ownerid|  
|owner_msdyn_bookingjournal|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|ownerid|  
|owner_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|ownerid|  
|owner_msdyn_bookingsetupmetadata|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|ownerid|  
|owner_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|ownerid|  
|owner_msdyn_collaboration|[msdyn_collaboration EntityType](msdyn_collaboration.md)|ownerid|  
|owner_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|ownerid|  
|owner_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|ownerid|  
|owner_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|ownerid|  
|owner_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|ownerid|  
|owner_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|ownerid|  
|owner_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|ownerid|  
|owner_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|ownerid|  
|owner_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|ownerid|  
|owner_msdyn_expensereceipt|[msdyn_expensereceipt EntityType](msdyn_expensereceipt.md)|ownerid|  
|owner_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|ownerid|  
|owner_msdyn_feedbackmapping|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|ownerid|  
|owner_msdyn_feedbacksubsurvey|[msdyn_feedbacksubsurvey EntityType](msdyn_feedbacksubsurvey.md)|ownerid|  
|owner_msdyn_fieldcomputation|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|ownerid|  
|owner_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|ownerid|  
|owner_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|ownerid|  
|owner_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|ownerid|  
|owner_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|ownerid|  
|owner_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|ownerid|  
|owner_msdyn_groupsheader|[msdyn_groupsheader EntityType](msdyn_groupsheader.md)|ownerid|  
|owner_msdyn_image|[msdyn_image EntityType](msdyn_image.md)|ownerid|  
|owner_msdyn_import|[msdyn_import EntityType](msdyn_import.md)|ownerid|  
|owner_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|ownerid|  
|owner_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|ownerid|  
|owner_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|ownerid|  
|owner_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|ownerid|  
|owner_msdyn_incidenttypeservicetask|[msdyn_incidenttypeservicetask EntityType](msdyn_incidenttypeservicetask.md)|ownerid|  
|owner_msdyn_integrationjob|[msdyn_integrationjob EntityType](msdyn_integrationjob.md)|ownerid|  
|owner_msdyn_integrationjobdetail|[msdyn_integrationjobdetail EntityType](msdyn_integrationjobdetail.md)|ownerid|  
|owner_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|ownerid|  
|owner_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|ownerid|  
|owner_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|ownerid|  
|owner_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|ownerid|  
|owner_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|ownerid|  
|owner_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|ownerid|  
|owner_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|ownerid|  
|owner_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|ownerid|  
|owner_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|ownerid|  
|owner_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|ownerid|  
|owner_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|ownerid|  
|owner_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|ownerid|  
|owner_msdyn_linkedanswer|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|ownerid|  
|owner_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|ownerid|  
|owner_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|ownerid|  
|owner_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|ownerid|  
|owner_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|ownerid|  
|owner_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|ownerid|  
|owner_msdyn_optimizationrequestbooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|ownerid|  
|owner_msdyn_orderinvoicingdate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|ownerid|  
|owner_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|ownerid|  
|owner_msdyn_orderinvoicingsetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|ownerid|  
|owner_msdyn_orderinvoicingsetupdate|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|ownerid|  
|owner_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|ownerid|  
|owner_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|ownerid|  
|owner_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|ownerid|  
|owner_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|ownerid|  
|owner_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|ownerid|  
|owner_msdyn_page|[msdyn_page EntityType](msdyn_page.md)|ownerid|  
|owner_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|ownerid|  
|owner_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|ownerid|  
|owner_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|ownerid|  
|owner_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|ownerid|  
|owner_msdyn_pendinggroupmembers|[msdyn_pendinggroupmembers EntityType](msdyn_pendinggroupmembers.md)|ownerid|  
|owner_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|ownerid|  
|owner_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|ownerid|  
|owner_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|ownerid|  
|owner_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|ownerid|  
|owner_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|ownerid|  
|owner_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|ownerid|  
|owner_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|ownerid|  
|owner_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|ownerid|  
|owner_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|ownerid|  
|owner_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|ownerid|  
|owner_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|ownerid|  
|owner_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|ownerid|  
|owner_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|ownerid|  
|owner_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|ownerid|  
|owner_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|ownerid|  
|owner_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|ownerid|  
|owner_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|ownerid|  
|owner_msdyn_questiongroup|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|ownerid|  
|owner_msdyn_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|ownerid|  
|owner_msdyn_questiontype|[msdyn_questiontype EntityType](msdyn_questiontype.md)|ownerid|  
|owner_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|ownerid|  
|owner_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|ownerid|  
|owner_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|ownerid|  
|owner_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|ownerid|  
|owner_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|ownerid|  
|owner_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|ownerid|  
|owner_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|ownerid|  
|owner_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|ownerid|  
|owner_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|ownerid|  
|owner_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|ownerid|  
|owner_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|ownerid|  
|owner_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|ownerid|  
|owner_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|ownerid|  
|owner_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|ownerid|  
|owner_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|ownerid|  
|owner_msdyn_requirementorganizationunit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|ownerid|  
|owner_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|ownerid|  
|owner_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|ownerid|  
|owner_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|ownerid|  
|owner_msdyn_resourceassignment|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|ownerid|  
|owner_msdyn_resourceassignmentdetail|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|ownerid|  
|owner_msdyn_resourcepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|ownerid|  
|owner_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|ownerid|  
|owner_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|ownerid|  
|owner_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|ownerid|  
|owner_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|ownerid|  
|owner_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|ownerid|  
|owner_msdyn_responsecondition|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|ownerid|  
|owner_msdyn_responseoutcome|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|ownerid|  
|owner_msdyn_responserouting|[msdyn_responserouting EntityType](msdyn_responserouting.md)|ownerid|  
|owner_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|ownerid|  
|owner_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|ownerid|  
|owner_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|ownerid|  
|owner_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|ownerid|  
|owner_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|ownerid|  
|owner_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|ownerid|  
|owner_msdyn_roleutilization|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|ownerid|  
|owner_msdyn_routingengineconfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|ownerid|  
|owner_msdyn_routingjobconfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|ownerid|  
|owner_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|ownerid|  
|owner_msdyn_routingprofileconfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|ownerid|  
|owner_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|ownerid|  
|owner_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|ownerid|  
|owner_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|ownerid|  
|owner_msdyn_scheduleboardsetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|ownerid|  
|owner_msdyn_schedulingoptimizationhealthlog|[msdyn_schedulingoptimizationhealthlog EntityType](msdyn_schedulingoptimizationhealthlog.md)|ownerid|  
|owner_msdyn_section|[msdyn_section EntityType](msdyn_section.md)|ownerid|  
|owner_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|ownerid|  
|owner_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|ownerid|  
|owner_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|ownerid|  
|owner_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|ownerid|  
|owner_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|ownerid|  
|owner_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|ownerid|  
|owner_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|ownerid|  
|owner_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|ownerid|  
|owner_msdyn_theme|[msdyn_theme EntityType](msdyn_theme.md)|ownerid|  
|owner_msdyn_timeentry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|ownerid|  
|owner_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|ownerid|  
|owner_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|ownerid|  
|owner_msdyn_timeoffcalendar|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|ownerid|  
|owner_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|ownerid|  
|owner_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|ownerid|  
|owner_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|ownerid|  
|owner_msdyn_userworkhistory|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|ownerid|  
|owner_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|ownerid|  
|owner_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|ownerid|  
|owner_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|ownerid|  
|owner_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|ownerid|  
|owner_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|ownerid|  
|owner_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|ownerid|  
|owner_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|ownerid|  
|owner_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|ownerid|  
|owner_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|ownerid|  
|owner_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|ownerid|  
|owner_msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|ownerid|  
|owner_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|ownerid|  
|owner_msdyncrm_campaigncustomchannelactivity|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|ownerid|  
|owner_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|ownerid|  
|owner_msdyncrm_customerinsightsinfo|[msdyncrm_customerinsightsinfo EntityType](msdyncrm_customerinsightsinfo.md)|ownerid|  
|owner_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|ownerid|  
|owner_msdyncrm_customerjourneyiteration|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|ownerid|  
|owner_msdyncrm_customerjourneytemplate|[msdyncrm_customerjourneytemplate EntityType](msdyncrm_customerjourneytemplate.md)|ownerid|  
|owner_msdyncrm_customerjourneyworkflowlink|[msdyncrm_customerjourneyworkflowlink EntityType](msdyncrm_customerjourneyworkflowlink.md)|ownerid|  
|owner_msdyncrm_file|[msdyncrm_file EntityType](msdyncrm_file.md)|ownerid|  
|owner_msdyncrm_formpage|[msdyncrm_formpage EntityType](msdyncrm_formpage.md)|ownerid|  
|owner_msdyncrm_formpagetemplate|[msdyncrm_formpagetemplate EntityType](msdyncrm_formpagetemplate.md)|ownerid|  
|owner_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|ownerid|  
|owner_msdyncrm_keyword|[msdyncrm_keyword EntityType](msdyncrm_keyword.md)|ownerid|  
|owner_msdyncrm_leadscore|[msdyncrm_leadscore EntityType](msdyncrm_leadscore.md)|ownerid|  
|owner_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|ownerid|  
|owner_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|ownerid|  
|owner_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|ownerid|  
|owner_msdyncrm_linkedincampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|ownerid|  
|owner_msdyncrm_linkedinconfiguration|[msdyncrm_linkedinconfiguration EntityType](msdyncrm_linkedinconfiguration.md)|ownerid|  
|owner_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|ownerid|  
|owner_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|ownerid|  
|owner_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|ownerid|  
|owner_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|ownerid|  
|owner_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|ownerid|  
|owner_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|ownerid|  
|owner_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|ownerid|  
|owner_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|ownerid|  
|owner_msdyncrm_marketingemail|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|ownerid|  
|owner_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|ownerid|  
|owner_msdyncrm_marketingemailtemplate|[msdyncrm_marketingemailtemplate EntityType](msdyncrm_marketingemailtemplate.md)|ownerid|  
|owner_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|ownerid|  
|owner_msdyncrm_marketingform|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|ownerid|  
|owner_msdyncrm_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|ownerid|  
|owner_msdyncrm_marketingformtemplate|[msdyncrm_marketingformtemplate EntityType](msdyncrm_marketingformtemplate.md)|ownerid|  
|owner_msdyncrm_marketingpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|ownerid|  
|owner_msdyncrm_marketingpagetemplate|[msdyncrm_marketingpagetemplate EntityType](msdyncrm_marketingpagetemplate.md)|ownerid|  
|owner_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|ownerid|  
|owner_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|ownerid|  
|owner_msdyncrm_redirecturl|[msdyncrm_redirecturl EntityType](msdyncrm_redirecturl.md)|ownerid|  
|owner_msdyncrm_segment|[msdyncrm_segment EntityType](msdyncrm_segment.md)|ownerid|  
|owner_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|ownerid|  
|owner_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|ownerid|  
|owner_msdyncrm_usergeoregion|[msdyncrm_usergeoregion EntityType](msdyncrm_usergeoregion.md)|ownerid|  
|owner_msdyncrm_website|[msdyncrm_website EntityType](msdyncrm_website.md)|ownerid|  
|owner_msevtmgt_attendeepass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|ownerid|  
|owner_msevtmgt_authenticationsettings|[msevtmgt_authenticationsettings EntityType](msevtmgt_authenticationsettings.md)|ownerid|  
|owner_msevtmgt_building|[msevtmgt_building EntityType](msevtmgt_building.md)|ownerid|  
|owner_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|ownerid|  
|owner_msevtmgt_entitycounter|[msevtmgt_entitycounter EntityType](msevtmgt_entitycounter.md)|ownerid|  
|owner_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|ownerid|  
|owner_msevtmgt_eventadministration|[msevtmgt_eventadministration EntityType](msevtmgt_eventadministration.md)|ownerid|  
|owner_msevtmgt_eventmanagementconfiguration|[msevtmgt_eventmanagementconfiguration EntityType](msevtmgt_eventmanagementconfiguration.md)|ownerid|  
|owner_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|ownerid|  
|owner_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|ownerid|  
|owner_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|ownerid|  
|owner_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|ownerid|  
|owner_msevtmgt_eventteammember|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|ownerid|  
|owner_msevtmgt_eventvendor|[msevtmgt_eventvendor EntityType](msevtmgt_eventvendor.md)|ownerid|  
|owner_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|ownerid|  
|owner_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|ownerid|  
|owner_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|ownerid|  
|owner_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|ownerid|  
|owner_msevtmgt_pass|[msevtmgt_pass EntityType](msevtmgt_pass.md)|ownerid|  
|owner_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|ownerid|  
|owner_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|ownerid|  
|owner_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|ownerid|  
|owner_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|ownerid|  
|owner_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|ownerid|  
|owner_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|ownerid|  
|owner_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|ownerid|  
|owner_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|ownerid|  
|owner_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|ownerid|  
|owner_new_interactionforemail|[interactionforemail EntityType](interactionforemail.md)|ownerid|  
|owner_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|ownerid|  
|owner_opportunitys|[opportunity EntityType](opportunity.md)|ownerid|  
|owner_personaldocumenttemplates|[personaldocumenttemplate EntityType](personaldocumenttemplate.md)|ownerid|  
|owner_postfollows|[postfollow EntityType](postfollow.md)|ownerid|  
|owner_queues|[queue EntityType](queue.md)|ownerid|  
|owner_quotedetail|[quotedetail EntityType](quotedetail.md)|ownerid|  
|owner_quotes|[quote EntityType](quote.md)|ownerid|  
|owner_ratingmodel|[ratingmodel EntityType](ratingmodel.md)|ownerid|  
|owner_ratingvalue|[ratingvalue EntityType](ratingvalue.md)|ownerid|  
|owner_reports|[report EntityType](report.md)|ownerid|  
|owner_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|ownerid|  
|owner_salesorders|[salesorder EntityType](salesorder.md)|ownerid|  
|owner_sharepointdocumentlocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|ownerid|  
|owner_sharepointsite|[sharepointsite EntityType](sharepointsite.md)|ownerid|  
|owner_slas|[sla EntityType](sla.md)|ownerid|  
|owner_SocialProfile|[socialprofile EntityType](socialprofile.md)|ownerid|  
|owner_SyncError|[syncerror EntityType](syncerror.md)|ownerid|  
|owner_templates|[template EntityType](template.md)|ownerid|  
|owner_userform|[userform EntityType](userform.md)|ownerid|  
|owner_userquerys|[userquery EntityType](userquery.md)|ownerid|  
|owner_userqueryvisualizations|[userqueryvisualization EntityType](userqueryvisualization.md)|ownerid|  
|owner_workflows|[workflow EntityType](workflow.md)|ownerid|  
|OwningTeam_postfollows|[postfollow EntityType](postfollow.md)|owningteam|  
|quoteclose_owner_ownerid|[quoteclose EntityType](quoteclose.md)|ownerid_quoteclose|  
|serviceappointment_owner_ownerid|[serviceappointment EntityType](serviceappointment.md)|ownerid_serviceappointment|  
|slakpiinstance_owner|[slakpiinstance EntityType](slakpiinstance.md)|ownerid|  
|team_accounts|[account EntityType](account.md)|owningteam|  
|team_activity|[activitypointer EntityType](activitypointer.md)|owningteam|  
|team_adx_ad|[adx_ad EntityType](adx_ad.md)|owningteam|  
|team_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|owningteam|  
|team_adx_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|owningteam|  
|team_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|owningteam|  
|team_adx_pagealert|[adx_pagealert EntityType](adx_pagealert.md)|owningteam|  
|team_adx_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|owningteam|  
|team_adx_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|owningteam|  
|team_adx_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|owningteam|  
|team_adx_poll|[adx_poll EntityType](adx_poll.md)|owningteam|  
|team_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|owningteam|  
|team_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|owningteam|  
|team_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|owningteam|  
|team_adx_portallanguage|[adx_portallanguage EntityType](adx_portallanguage.md)|owningteam|  
|team_adx_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|owningteam|  
|team_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|owningteam|  
|team_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|owningteam|  
|team_adx_setting|[adx_setting EntityType](adx_setting.md)|owningteam|  
|team_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|owningteam|  
|team_adx_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|owningteam|  
|team_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|owningteam|  
|team_adx_tag|[adx_tag EntityType](adx_tag.md)|owningteam|  
|team_adx_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|owningteam|  
|team_adx_webfile|[adx_webfile EntityType](adx_webfile.md)|owningteam|  
|team_adx_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|owningteam|  
|team_adx_webform|[adx_webform EntityType](adx_webform.md)|owningteam|  
|team_adx_weblink|[adx_weblink EntityType](adx_weblink.md)|owningteam|  
|team_adx_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|owningteam|  
|team_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|owningteam|  
|team_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|owningteam|  
|team_adx_webpageaccesscontrolrule|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|owningteam|  
|team_adx_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|owningteam|  
|team_adx_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|owningteam|  
|team_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|owningteam|  
|team_adx_website|[adx_website EntityType](adx_website.md)|owningteam|  
|team_adx_websiteaccess|[adx_websiteaccess EntityType](adx_websiteaccess.md)|owningteam|  
|team_adx_websitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|owningteam|  
|team_annotations|[annotation EntityType](annotation.md)|owningteam|  
|team_appointment|[appointment EntityType](appointment.md)|owningteam_appointment|  
|team_asyncoperation|[asyncoperation EntityType](asyncoperation.md)|owningteam|  
|Team_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_team|  
|team_bookableresource|[bookableresource EntityType](bookableresource.md)|owningteam|  
|team_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|owningteam|  
|team_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|owningteam|  
|team_bookableresourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|owningteam|  
|team_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|owningteam|  
|team_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|owningteam|  
|team_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|owningteam|  
|team_bookingstatus|[bookingstatus EntityType](bookingstatus.md)|owningteam|  
|Team_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_team|  
|team_BulkOperation|[bulkoperation EntityType](bulkoperation.md)|owningteam_bulkoperation|  
|team_bulkoperationlog|[bulkoperationlog EntityType](bulkoperationlog.md)|owningteam|  
|team_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|owningteam_campaignactivity|  
|team_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|owningteam_campaignresponse|  
|team_Campaigns|[campaign EntityType](campaign.md)|owningteam|  
|team_characteristic|[characteristic EntityType](characteristic.md)|owningteam|  
|team_connections1|[connection EntityType](connection.md)|record1id_team|  
|team_connections2|[connection EntityType](connection.md)|record2id_team|  
|team_contacts|[contact EntityType](contact.md)|owningteam|  
|team_contractdetail|[contractdetail EntityType](contractdetail.md)|owningteam|  
|Team_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_team|  
|Team_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_team|  
|team_DuplicateRules|[duplicaterule EntityType](duplicaterule.md)|owningteam|  
|team_DynamicPropertyInstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|owningteam|  
|team_email|[email EntityType](email.md)|owningteam_email|  
|team_email_templates|[template EntityType](template.md)|owningteam|  
|team_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|owningteam|  
|team_entitlement|[entitlement EntityType](entitlement.md)|owningteam|  
|team_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|owningteam|  
|team_exchangesyncidmapping|[exchangesyncidmapping EntityType](exchangesyncidmapping.md)|owningteam|  
|team_fax|[fax EntityType](fax.md)|owningteam_fax|  
|team_goal|[goal EntityType](goal.md)|owningteam|  
|team_goal_goalowner|[goal EntityType](goal.md)|goalownerid_team|  
|team_goalrollupquery|[goalrollupquery EntityType](goalrollupquery.md)|owningteam|  
|team_ImportData|[importdata EntityType](importdata.md)|owningteam|  
|team_ImportFiles|[importfile EntityType](importfile.md)|owningteam|  
|team_ImportLogs|[importlog EntityType](importlog.md)|owningteam|  
|team_ImportMaps|[importmap EntityType](importmap.md)|owningteam|  
|team_Imports|[import EntityType](import.md)|owningteam|  
|team_incidentresolution|[incidentresolution EntityType](incidentresolution.md)|owningteam_incidentresolution|  
|team_incidents|[incident EntityType](incident.md)|owningteam|  
|team_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|owningteam|  
|team_invoices|[invoice EntityType](invoice.md)|owningteam|  
|team_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|owningteam|  
|team_knowledgearticleincident|[knowledgearticleincident EntityType](knowledgearticleincident.md)|owningteam|  
|team_letter|[letter EntityType](letter.md)|owningteam_letter|  
|team_list|[list EntityType](list.md)|owningteam|  
|team_mailbox|[mailbox EntityType](mailbox.md)|owningteam|  
|team_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|owningteam|  
|team_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|owningteam|  
|team_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|owningteam|  
|team_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|owningteam|  
|team_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|owningteam|  
|team_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|owningteam|  
|team_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|owningteam|  
|team_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|owningteam|  
|team_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|owningteam|  
|team_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|owningteam|  
|team_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|owningteam|  
|team_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|owningteam|  
|team_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|owningteam|  
|team_msdyn_answer|[msdyn_answer EntityType](msdyn_answer.md)|owningteam|  
|team_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|owningteam|  
|team_msdyn_bookingchange|[msdyn_bookingchange EntityType](msdyn_bookingchange.md)|owningteam|  
|team_msdyn_bookingjournal|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|owningteam|  
|team_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|owningteam|  
|team_msdyn_bookingsetupmetadata|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|owningteam|  
|team_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|owningteam|  
|team_msdyn_collaboration|[msdyn_collaboration EntityType](msdyn_collaboration.md)|owningteam|  
|team_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|owningteam|  
|team_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|owningteam|  
|team_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|owningteam|  
|team_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|owningteam|  
|team_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|owningteam|  
|team_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|owningteam|  
|team_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|owningteam|  
|team_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|owningteam|  
|team_msdyn_expensereceipt|[msdyn_expensereceipt EntityType](msdyn_expensereceipt.md)|owningteam|  
|team_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|owningteam|  
|team_msdyn_feedbackmapping|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|owningteam|  
|team_msdyn_feedbacksubsurvey|[msdyn_feedbacksubsurvey EntityType](msdyn_feedbacksubsurvey.md)|owningteam|  
|team_msdyn_fieldcomputation|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|owningteam|  
|team_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|owningteam|  
|team_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|owningteam|  
|team_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|owningteam|  
|team_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|owningteam|  
|team_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|owningteam|  
|team_msdyn_groupsheader|[msdyn_groupsheader EntityType](msdyn_groupsheader.md)|owningteam|  
|team_msdyn_image|[msdyn_image EntityType](msdyn_image.md)|owningteam|  
|team_msdyn_import|[msdyn_import EntityType](msdyn_import.md)|owningteam|  
|team_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|owningteam|  
|team_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|owningteam|  
|team_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|owningteam|  
|team_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|owningteam|  
|team_msdyn_incidenttypeservicetask|[msdyn_incidenttypeservicetask EntityType](msdyn_incidenttypeservicetask.md)|owningteam|  
|team_msdyn_integrationjob|[msdyn_integrationjob EntityType](msdyn_integrationjob.md)|owningteam|  
|team_msdyn_integrationjobdetail|[msdyn_integrationjobdetail EntityType](msdyn_integrationjobdetail.md)|owningteam|  
|team_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|owningteam|  
|team_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|owningteam|  
|team_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|owningteam|  
|team_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|owningteam|  
|team_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|owningteam|  
|team_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|owningteam|  
|team_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|owningteam|  
|team_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|owningteam|  
|team_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|owningteam|  
|team_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|owningteam|  
|team_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|owningteam|  
|team_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|owningteam|  
|team_msdyn_linkedanswer|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|owningteam|  
|team_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|owningteam|  
|team_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|owningteam|  
|team_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|owningteam|  
|team_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|owningteam|  
|team_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|owningteam|  
|team_msdyn_optimizationrequestbooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|owningteam|  
|team_msdyn_orderinvoicingdate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|owningteam|  
|team_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|owningteam|  
|team_msdyn_orderinvoicingsetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|owningteam|  
|team_msdyn_orderinvoicingsetupdate|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|owningteam|  
|team_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|owningteam|  
|team_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|owningteam|  
|team_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|owningteam|  
|team_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|owningteam|  
|team_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|owningteam|  
|team_msdyn_page|[msdyn_page EntityType](msdyn_page.md)|owningteam|  
|team_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|owningteam|  
|team_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|owningteam|  
|team_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|owningteam|  
|team_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|owningteam|  
|team_msdyn_pendinggroupmembers|[msdyn_pendinggroupmembers EntityType](msdyn_pendinggroupmembers.md)|owningteam|  
|team_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|owningteam|  
|team_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|owningteam|  
|team_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|owningteam|  
|team_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|owningteam|  
|team_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|owningteam|  
|team_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|owningteam|  
|team_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|owningteam|  
|team_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|owningteam|  
|team_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|owningteam|  
|team_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|owningteam|  
|team_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|owningteam|  
|team_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|owningteam|  
|team_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|owningteam|  
|team_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|owningteam|  
|team_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|owningteam|  
|team_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|owningteam|  
|team_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|owningteam|  
|team_msdyn_questiongroup|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|owningteam|  
|team_msdyn_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|owningteam|  
|team_msdyn_questiontype|[msdyn_questiontype EntityType](msdyn_questiontype.md)|owningteam|  
|team_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|owningteam|  
|team_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|owningteam|  
|team_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|owningteam|  
|team_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|owningteam|  
|team_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|owningteam|  
|team_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|owningteam|  
|team_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|owningteam|  
|team_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|owningteam|  
|team_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|owningteam|  
|team_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|owningteam|  
|team_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|owningteam|  
|team_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|owningteam|  
|team_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|owningteam|  
|team_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|owningteam|  
|team_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|owningteam|  
|team_msdyn_requirementorganizationunit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|owningteam|  
|team_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|owningteam|  
|team_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|owningteam|  
|team_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|owningteam|  
|team_msdyn_resourceassignment|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|owningteam|  
|team_msdyn_resourceassignmentdetail|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|owningteam|  
|team_msdyn_resourcepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|owningteam|  
|team_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|owningteam|  
|team_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|owningteam|  
|team_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|owningteam|  
|team_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|owningteam|  
|team_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|owningteam|  
|team_msdyn_responsecondition|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|owningteam|  
|team_msdyn_responseoutcome|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|owningteam|  
|team_msdyn_responserouting|[msdyn_responserouting EntityType](msdyn_responserouting.md)|owningteam|  
|team_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|owningteam|  
|team_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|owningteam|  
|team_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|owningteam|  
|team_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|owningteam|  
|team_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|owningteam|  
|team_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|owningteam|  
|team_msdyn_roleutilization|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|owningteam|  
|team_msdyn_routingengineconfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|owningteam|  
|team_msdyn_routingjobconfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|owningteam|  
|team_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|owningteam|  
|team_msdyn_routingprofileconfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|owningteam|  
|team_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|owningteam|  
|team_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|owningteam|  
|team_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|owningteam|  
|team_msdyn_scheduleboardsetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|owningteam|  
|team_msdyn_schedulingoptimizationhealthlog|[msdyn_schedulingoptimizationhealthlog EntityType](msdyn_schedulingoptimizationhealthlog.md)|owningteam|  
|team_msdyn_section|[msdyn_section EntityType](msdyn_section.md)|owningteam|  
|team_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|owningteam|  
|team_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|owningteam|  
|team_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|owningteam|  
|team_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|owningteam|  
|team_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|owningteam|  
|team_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|owningteam|  
|team_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|owningteam|  
|team_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|owningteam|  
|team_msdyn_theme|[msdyn_theme EntityType](msdyn_theme.md)|owningteam|  
|team_msdyn_timeentry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|owningteam|  
|team_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|owningteam|  
|team_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|owningteam|  
|team_msdyn_timeoffcalendar|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|owningteam|  
|team_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|owningteam|  
|team_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|owningteam|  
|team_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|owningteam|  
|team_msdyn_userworkhistory|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|owningteam|  
|team_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|owningteam|  
|team_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|owningteam|  
|team_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|owningteam|  
|team_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|owningteam|  
|team_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|owningteam|  
|team_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|owningteam|  
|team_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|owningteam|  
|team_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|owningteam|  
|team_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|owningteam|  
|team_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|owningteam|  
|team_msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|owningteam|  
|team_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|owningteam|  
|team_msdyncrm_campaigncustomchannelactivity|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|owningteam|  
|team_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|owningteam|  
|team_msdyncrm_customerinsightsinfo|[msdyncrm_customerinsightsinfo EntityType](msdyncrm_customerinsightsinfo.md)|owningteam|  
|team_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|owningteam|  
|team_msdyncrm_customerjourneyiteration|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|owningteam|  
|team_msdyncrm_customerjourneytemplate|[msdyncrm_customerjourneytemplate EntityType](msdyncrm_customerjourneytemplate.md)|owningteam|  
|team_msdyncrm_customerjourneyworkflowlink|[msdyncrm_customerjourneyworkflowlink EntityType](msdyncrm_customerjourneyworkflowlink.md)|owningteam|  
|team_msdyncrm_file|[msdyncrm_file EntityType](msdyncrm_file.md)|owningteam|  
|team_msdyncrm_formpage|[msdyncrm_formpage EntityType](msdyncrm_formpage.md)|owningteam|  
|team_msdyncrm_formpagetemplate|[msdyncrm_formpagetemplate EntityType](msdyncrm_formpagetemplate.md)|owningteam|  
|team_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|owningteam|  
|team_msdyncrm_keyword|[msdyncrm_keyword EntityType](msdyncrm_keyword.md)|owningteam|  
|team_msdyncrm_leadscore|[msdyncrm_leadscore EntityType](msdyncrm_leadscore.md)|owningteam|  
|team_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|owningteam|  
|team_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|owningteam|  
|team_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|owningteam|  
|team_msdyncrm_linkedincampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|owningteam|  
|team_msdyncrm_linkedinconfiguration|[msdyncrm_linkedinconfiguration EntityType](msdyncrm_linkedinconfiguration.md)|owningteam|  
|team_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|owningteam|  
|team_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|owningteam|  
|team_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|owningteam|  
|team_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|owningteam|  
|team_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|owningteam|  
|team_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|owningteam|  
|team_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|owningteam|  
|team_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|owningteam|  
|team_msdyncrm_marketingemail|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|owningteam|  
|team_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|owningteam|  
|team_msdyncrm_marketingemailtemplate|[msdyncrm_marketingemailtemplate EntityType](msdyncrm_marketingemailtemplate.md)|owningteam|  
|team_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|owningteam|  
|team_msdyncrm_marketingform|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|owningteam|  
|team_msdyncrm_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|owningteam|  
|team_msdyncrm_marketingformtemplate|[msdyncrm_marketingformtemplate EntityType](msdyncrm_marketingformtemplate.md)|owningteam|  
|team_msdyncrm_marketingpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|owningteam|  
|team_msdyncrm_marketingpagetemplate|[msdyncrm_marketingpagetemplate EntityType](msdyncrm_marketingpagetemplate.md)|owningteam|  
|team_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|owningteam|  
|team_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|owningteam|  
|team_msdyncrm_redirecturl|[msdyncrm_redirecturl EntityType](msdyncrm_redirecturl.md)|owningteam|  
|team_msdyncrm_segment|[msdyncrm_segment EntityType](msdyncrm_segment.md)|owningteam|  
|team_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|owningteam|  
|team_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|owningteam|  
|team_msdyncrm_usergeoregion|[msdyncrm_usergeoregion EntityType](msdyncrm_usergeoregion.md)|owningteam|  
|team_msdyncrm_website|[msdyncrm_website EntityType](msdyncrm_website.md)|owningteam|  
|team_msevtmgt_attendeepass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|owningteam|  
|team_msevtmgt_authenticationsettings|[msevtmgt_authenticationsettings EntityType](msevtmgt_authenticationsettings.md)|owningteam|  
|team_msevtmgt_building|[msevtmgt_building EntityType](msevtmgt_building.md)|owningteam|  
|team_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|owningteam|  
|team_msevtmgt_entitycounter|[msevtmgt_entitycounter EntityType](msevtmgt_entitycounter.md)|owningteam|  
|team_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|owningteam|  
|team_msevtmgt_eventadministration|[msevtmgt_eventadministration EntityType](msevtmgt_eventadministration.md)|owningteam|  
|team_msevtmgt_eventmanagementconfiguration|[msevtmgt_eventmanagementconfiguration EntityType](msevtmgt_eventmanagementconfiguration.md)|owningteam|  
|team_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|owningteam|  
|team_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|owningteam|  
|team_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|owningteam|  
|team_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|owningteam|  
|team_msevtmgt_eventteammember|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|owningteam|  
|team_msevtmgt_eventvendor|[msevtmgt_eventvendor EntityType](msevtmgt_eventvendor.md)|owningteam|  
|team_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|owningteam|  
|team_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|owningteam|  
|team_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|owningteam|  
|team_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|owningteam|  
|team_msevtmgt_pass|[msevtmgt_pass EntityType](msevtmgt_pass.md)|owningteam|  
|team_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|owningteam|  
|team_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|owningteam|  
|team_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|owningteam|  
|team_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|owningteam|  
|team_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|owningteam|  
|team_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|owningteam|  
|team_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|owningteam|  
|team_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|owningteam|  
|team_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|owningteam|  
|team_new_interactionforemail|[interactionforemail EntityType](interactionforemail.md)|owningteam|  
|team_opportunities|[opportunity EntityType](opportunity.md)|owningteam|  
|team_opportunityclose|[opportunityclose EntityType](opportunityclose.md)|owningteam_opportunityclose|  
|team_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|owningteam|  
|team_orderclose|[orderclose EntityType](orderclose.md)|owningteam_orderclose|  
|team_orders|[salesorder EntityType](salesorder.md)|owningteam|  
|team_phonecall|[phonecall EntityType](phonecall.md)|owningteam_phonecall|  
|team_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_team|  
|team_queueitembase_workerid|[queueitem EntityType](queueitem.md)|workerid_team|  
|team_quoteclose|[quoteclose EntityType](quoteclose.md)|owningteam_quoteclose|  
|team_quotedetail|[quotedetail EntityType](quotedetail.md)|owningteam|  
|team_quotes|[quote EntityType](quote.md)|owningteam|  
|team_ratingmodel|[ratingmodel EntityType](ratingmodel.md)|owningteam|  
|team_ratingvalue|[ratingvalue EntityType](ratingvalue.md)|owningteam|  
|team_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|owningteam_recurringappointmentmaster|  
|team_resource_groups|[resourcegroup EntityType](resourcegroup.md)|resourcegroupid_team|  
|team_resource_specs|[resourcespec EntityType](resourcespec.md)|groupobjectid_team|  
|team_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|owningteam|  
|team_service_appointments|[serviceappointment EntityType](serviceappointment.md)|owningteam_serviceappointment|  
|team_service_contracts|[contract EntityType](contract.md)|owningteam|  
|team_sharepointdocumentlocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|owningteam|  
|team_sharepointsite|[sharepointsite EntityType](sharepointsite.md)|owningteam|  
|team_slaBase|[sla EntityType](sla.md)|owningteam|  
|team_socialactivity|[socialactivity EntityType](socialactivity.md)|owningteam_socialactivity|  
|team_SyncError|[syncerror EntityType](syncerror.md)|owningteam|  
|Team_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_team_syncerror|  
|team_task|[task EntityType](task.md)|owningteam_task|  
|team_userform|[userform EntityType](userform.md)|owningteam|  
|team_userquery|[userquery EntityType](userquery.md)|owningteam|  
|team_userqueryvisualizations|[userqueryvisualization EntityType](userqueryvisualization.md)|owningteam|  
|team_workflow|[workflow EntityType](workflow.md)|owningteam|  
|team_workflowlog|[workflowlog EntityType](workflowlog.md)|owningteam|  
|teammembership_association|[systemuser EntityType](systemuser.md)|teammembership_association|  
|teamprofiles_association|[fieldsecurityprofile EntityType](fieldsecurityprofile.md)|teamprofiles_association|  
|teamroles_association|[role EntityType](role.md)|teamroles_association|  

## Operations
The following operations can be used with the team entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddMembersTeam Action](../actions/addmembersteam.md)|Entity|[!INCLUDE[../actions/descriptions/addmembersteam.md](../actions/descriptions/addmembersteam.md)]|  
|[ConvertOwnerTeamToAccessTeam Action](../actions/convertownerteamtoaccessteam.md)|Entity|[!INCLUDE[../actions/descriptions/convertownerteamtoaccessteam.md](../actions/descriptions/convertownerteamtoaccessteam.md)]|  
|[RemoveMembersTeam Action](../actions/removemembersteam.md)|Entity|[!INCLUDE[../actions/descriptions/removemembersteam.md](../actions/descriptions/removemembersteam.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrievePrincipalAttributePrivileges Function](../functions/retrieveprincipalattributeprivileges.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveprincipalattributeprivileges.md](../functions/descriptions/retrieveprincipalattributeprivileges.md)]|  
|[RetrievePrincipalSyncAttributeMappings Function](../functions/retrieveprincipalsyncattributemappings.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveprincipalsyncattributemappings.md](../functions/descriptions/retrieveprincipalsyncattributemappings.md)]|  
|[RetrieveTeamPrivileges Function](../functions/retrieveteamprivileges.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveteamprivileges.md](../functions/descriptions/retrieveteamprivileges.md)]|  
|[SetParentSystemUser Action](../actions/setparentsystemuser.md)|Not Bound|[!INCLUDE[../actions/descriptions/setparentsystemuser.md](../actions/descriptions/setparentsystemuser.md)]|  

## Solutions
The following solutions include the team entity type.


|Name|Description |  
|----|------------|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/team.md](./remarks/team.md)]

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