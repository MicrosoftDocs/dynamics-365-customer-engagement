---
title: "Microsoft Dynamics 365 Customer Engagement activityparty EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c505dbea-388a-4925-a15b-b7b740089109
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API activityparty entitytype."
---
# activityparty EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/activityparty.md](./descriptions/activityparty.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]activityparties </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Activity Party</td></tr>
<tr><td><b>Primary Key:</b></td><td>activitypartyid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>partyidname</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET (RetrieveMultiple Only)</td></tr>
</table>
  
The activityparty entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activitypartyid|Edm.Guid|**Display Name**: Activity Party<br />**Description**: Unique identifier of the activity party.<br />|
|addressused|Edm.String|**Display Name**: Address <br />**Description**: Email address to which an email is delivered, and which is associated with the target entity.<br />|
|addressusedemailcolumnnumber|Edm.Int32|**Display Name**: Email column number of party<br />**Description**: Email address column number from associated party.<br />Read-only<br />|
|donotemail|Edm.Boolean|**Display Name**: Do not allow Emails<br />**Description**: Information about whether to allow sending email to the activity party.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotfax|Edm.Boolean|**Display Name**: Do not allow Faxes<br />**Description**: Information about whether to allow sending faxes to the activity party.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotphone|Edm.Boolean|**Display Name**: Do not allow Phone Calls<br />**Description**: Information about whether to allow phone calls to the lead.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotpostalmail|Edm.Boolean|**Display Name**: Do not allow Postal Mails<br />**Description**: Information about whether to allow sending postal mail to the lead.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|effort|Edm.Double|**Display Name**: Effort<br />**Description**: Amount of effort used by the resource in a service appointment activity.<br />|
|exchangeentryid|Edm.String|**Display Name**: Exchange Entry<br />**Description**: For internal use only.<br />|
|instancetypecode|Edm.Int32|**Display Name**: Appointment Type<br />**Description**: Type of instance of a recurring series.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Recurring</td></tr><tr><td>1</td><td>Recurring Master</td></tr><tr><td>2</td><td>Recurring Instance</td></tr><tr><td>3</td><td>Recurring Exception</td></tr><tr><td>4</td><td>Recurring Future Exception</td></tr><tbody></table>|
|ispartydeleted|Edm.Boolean|**Display Name**: Is Party Deleted<br />**Description**: Information about whether the underlying entity record is deleted.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|participationtypemask|Edm.Int32|**Display Name**: Participation Type<br />**Description**: Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Sender</td></tr><tr><td>2</td><td>To Recipient</td></tr><tr><td>3</td><td>CC Recipient</td></tr><tr><td>4</td><td>BCC Recipient</td></tr><tr><td>5</td><td>Required attendee</td></tr><tr><td>6</td><td>Optional attendee</td></tr><tr><td>7</td><td>Organizer</td></tr><tr><td>8</td><td>Regarding</td></tr><tr><td>9</td><td>Owner</td></tr><tr><td>10</td><td>Resource</td></tr><tr><td>11</td><td>Customer</td></tr><tbody></table>|
|scheduledend|Edm.DateTimeOffset|**Display Name**: Scheduled End<br />**Description**: Scheduled end time of the activity.<br />Read-only<br />|
|scheduledstart|Edm.DateTimeOffset|**Display Name**: Scheduled Start<br />**Description**: Scheduled start time of the activity.<br />Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_activityid_value|activityid_activitypointer<br />|Unique identifier of the activity associated with the activity party. (A "party" is any person who is associated with an activity.)|
|_ownerid_value||Unique identifier of the user or team who owns the activity_party.|
|_partyid_value|partyid_lead<br />partyid_campaign<br />partyid_contract<br />partyid_entitlement<br />partyid_equipment<br />partyid_incident<br />partyid_invoice<br />partyid_opportunity<br />partyid_quote<br />partyid_salesorder<br />partyid_msdyn_responseaction<br />partyid_msdyn_survey<br />partyid_msdyn_surveyresponse<br />partyid_queue<br />partyid_systemuser<br />partyid_knowledgearticle<br />partyid_account<br />partyid_contact<br />|Unique identifier of the party associated with the activity.|
|_resourcespecid_value|resourcespecid<br />|Unique identifier of the resource specification for the activity party.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|activityid_activitypointer|[activitypointer EntityType](activitypointer.md)|activitypointer_activity_parties|
|activityid_adx_alertsubscription_activityparty|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_activity_parties|
|activityid_adx_inviteredemption_activityparty|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_activity_parties|
|activityid_adx_portalcomment_activityparty|[adx_portalcomment EntityType](adx_portalcomment.md)|adx_portalcomment_activity_parties|
|activityid_appointment|[appointment EntityType](appointment.md)|appointment_activity_parties|
|activityid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|campaignactivity_activity_parties|
|activityid_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|campaignresponse_activity_parties|
|activityid_email|[email EntityType](email.md)|email_activity_parties|
|activityid_fax|[fax EntityType](fax.md)|fax_activity_parties|
|activityid_incidentresolution|[incidentresolution EntityType](incidentresolution.md)|incidentresolution_activity_parties|
|activityid_letter|[letter EntityType](letter.md)|letter_activity_parties|
|activityid_msdyn_approval_activityparty|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_activity_parties|
|activityid_msdyn_bookingalert_activityparty|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_activity_parties|
|activityid_msdyn_surveyinvite_activityparty|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_activity_parties|
|activityid_opportunityclose|[opportunityclose EntityType](opportunityclose.md)|opportunityclose_activity_parties|
|activityid_orderclose|[orderclose EntityType](orderclose.md)|orderclose_activity_parties|
|activityid_phonecall|[phonecall EntityType](phonecall.md)|phonecall_activity_parties|
|activityid_quoteclose|[quoteclose EntityType](quoteclose.md)|quoteclose_activity_parties|
|activityid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|recurringappointmentmaster_activity_parties|
|activityid_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|serviceappointment_activity_parties|
|activityid_socialactivity|[socialactivity EntityType](socialactivity.md)|socialactivity_activity_parties|
|activityid_task|[task EntityType](task.md)|task_activity_parties|
|partyid_account|[account EntityType](account.md)|account_activity_parties|
|partyid_bulkoperation|[bulkoperation EntityType](bulkoperation.md)|bulkoperation_activity_parties|
|partyid_campaign|[campaign EntityType](campaign.md)|campaign_activity_parties|
|partyid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|campaignactivity_activityparties|
|partyid_contact|[contact EntityType](contact.md)|contact_activity_parties|
|partyid_contract|[contract EntityType](contract.md)|contract_activity_parties|
|partyid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_ActivityParties|
|partyid_equipment|[equipment EntityType](equipment.md)|equipment_activity_parties|
|partyid_incident|[incident EntityType](incident.md)|incident_activity_parties|
|partyid_invoice|[invoice EntityType](invoice.md)|invoice_activity_parties|
|partyid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_activity_parties|
|partyid_lead|[lead EntityType](lead.md)|lead_activity_parties|
|partyid_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_ActivityParties|
|partyid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_ActivityParties|
|partyid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_ActivityParties|
|partyid_opportunity|[opportunity EntityType](opportunity.md)|opportunity_activity_parties|
|partyid_queue|[queue EntityType](queue.md)|queue_activity_parties|
|partyid_quote|[quote EntityType](quote.md)|quote_activity_parties|
|partyid_salesorder|[salesorder EntityType](salesorder.md)|salesorder_activity_parties|
|partyid_systemuser|[systemuser EntityType](systemuser.md)|system_user_activity_parties|
|resourcespecid|[resourcespec EntityType](resourcespec.md)|ActivityPartyResourceSpec|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ActivityParty_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_activityparty_syncerror|  

## Solutions
The following solutions include the activityparty entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/activityparty.md](./remarks/activityparty.md)]

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