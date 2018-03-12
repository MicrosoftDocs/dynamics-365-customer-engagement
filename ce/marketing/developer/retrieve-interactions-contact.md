---
title: "Retrieve interactions for a contact (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Know about the installed solutions, entities, and custom actions in your marketing organization."
ms.custom: ""
ms.date: 04/01/2017
ms.service: "crm-online"
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 36cebc83-203f-4afc-9070-efebd8b592ec
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Retrieve interactions for a contact

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Use the **msdyncrm_LoadInteractionsPublic** action to programmatically retrieve interactions for a contact.

## Action parameters

The **msdyncrm_LoadInteractionsPublic** action expects the following input parameters:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td>ContactId</td>
<td>Edm.String</td>
<td>ID of the contact record to retrieve the interactions for</td>
</tr>
<tr>
<td valign="top">InteractionType</td>
<td valign="top">Edm.String</td>
<td>Type of interaction to be retrieved. You can specify one of the following values:
<ul>
<li>ActivityContactBlocked</li>
<li>ActivityContactDispatched</li>
<li>ActivityContactProcessingFailed</li>
<li>ContactUpserted</li>
<li>CreateCrmActivityContactProcessed</li>
<li>CreateCustomChannelActivityContactProcessed</li>
<li>CustomChannelResponse</li>
<li>CustomerJourneyContactRecordUpdated</li>
<li>EmailBlockBounced</li>
<li>EmailBlocked</li>
<li>EmailClicked</li>
<li>EmailContainsBlacklistedLinks</li>
<li>EmailDelivered</li>
<li>EmailFeedbackLoop</li>
<li>EmailForwarded</li>
<li>EmailHardBounced</li>
<li>EmailOpened</li>
<li>EmailSendingFailed</li>
<li>EmailSent</li>
<li>EmailSoftBounced</li>
<li>EmailSubscriptionSubmit</li>
<li>EventCheckIn</li>
<li>EventRegistration</li>
<li>FormSubmitted</li>
<li>FormVisited</li>
<li>InvalidRecipientAddress</li>
<li>InvalidSenderAddress</li>
<li>LeadScoreBoost</li>
<li>LeadUpserted</li>
<li>OutOfEmailCredits</li>
<li>PassThroughActivityContactProcessed</li>
<li>RedirectLinkClicked</li>
<li>SchedulerActivityContactProcessed</li>
<li>SegmentRelationshipEdited</li>
<li>SegmentSubscribed</li>
<li>SegmentUnsubscribed</li>
<li>SplitterActivityContactProcessed</li>
<li>SurveyResponse</li>
<li>TriggerActivityContactProcessed</li>
<li>TriggerCrmWorkflowActivityContactProcessed</li>
<li>WebsiteClicked</li>
<li>WebsiteVisited</li>
</ul></td>
</tr>
</table>

## Action return type

The **msdyncrm_LoadInteractionsPublic** action returns the following value:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td>msdyncrm_LoadInteractionsPublicResponse</td>
<td><a href="/dynamics365/customer-engagement/developer/webapi/web-api-types-operations#complex-types">ComplexType</a> </td>
<td>Contains the response from msdyncrm_LoadInteractionsPublic action. It contains the following properties that contain the structured data of the type:
<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
<tr>
<td>Data</td>
<td>Edm.String</td>
<td>List of interactions as an escaped JSON array.</td>
</tr>
<tr>
<td>NextSkiptToken</td>
<td>Edm.String</td>
<td>TODO: Add description.</td>
</tr>
</table>
</table>

## Example

TODO: Add request and response examples