---
title: "Retrieve insights data using msdyn_RetrieveTypeValuesFromDCI action (Dynamics 365 Customer Engagement) | Microsoft Docs  "
description: "Use the **msdyn_RetrieveTypeValuesFromDCI** action to programmatically retrieve profiles, interactions, and KPIs for an account, contact, lead or opportunity that is stored in Customer Insights for Dynamics 365"
keywords: "GDPR; data protection; privacy; embedded intelligence"
ms.date: 04/18/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d0d20528-0a72-4dd2-8c91-6367a9d4279d
author: KumarVivek
ms.author: kvivek
manager: kvivek
---

# Retrieve insights data using msdyn_RetrieveTypeValuesFromDCI action

Applies to Dynamics 365 (online), version 9.0.2

Use the **msdyn_RetrieveTypeValuesFromDCI** action to programmatically retrieve profiles, interactions, and KPIs stored in Customer Insights for Dynamics 365 for an account, contact, lead or opportunity. This action is useful for responding to data requests in order to fulfill the GDPR compliance in Embedded Intelligence.

> [!TIP]
> You can also generate request and response classes for this action to include in your application code. More information: [Generate early-bound types for an action](../../developer/create-own-actions.md#generate-early-bound-types-for-an-action)

## Action parameters

The **msdyn_RetrieveTypeValuesFromDCI** action expects the following input parameters:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td><code>CrmRecord</code></td>
<td>[mscrm.crmbaseentity](/dynamics365/customer-engagement/web-api/crmbaseentity)</td>
<td><p>Entity type for which you want to retrieve the data. Required.</p>
<p>You can specify one of the following values:</p>
<ul>
<li><code>Microsoft.Dynamics.CRM.account</code></li>
<li><code>Microsoft.Dynamics.CRM.contact</code></li>
<li><code>Microsoft.Dynamics.CRM.lead</code></li>
<li><code>Microsoft.Dynamics.CRM.opportunity</code></li>
</ul>

<p>Depending on the specified entity type, you must specify <code>accountid</code>, 
<code>contactid</code>, <code>leadid</code>, or <code>opportunityid</code> as the second key to identify the entity record you want to retrieve data for.</p></td>
</tr>

<tr>
<td><code>DateFrom</code></td>
<td>Edm.String</td>
<td>Start date and time from which you want to retrieve the interactions. Optional.</td>
</tr>
<tr>
<td><code>DateTo</code></td>
<td>Edm.String</td>
<td>End date and time until which you want to retrieve the interactions. Optional.</td>
</tr>
<tr>
<td valign="top"><code>InteractionType</code></td>
<td valign="top">Edm.String</td>
<td>Type of interaction to be retrieved. Required.<br/> You can specify one of the following values:
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

<tr>
<td><code>Top</code></td>
<td>Edm.Int32</td>
<td>Optional. Non-negative integer that limits the number of interactions returned for a contact record. Optional.</td>
</tr>

<tr>
<td><code>SkipToken</code></td>
<td>Edm.String</td>
<td>Identifies a starting point in the collection of interactions returned for a contact record. Optional.</td>
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
<td><code>msdyncrm_LoadInteractionsPublicResponse</code></td>
<td><a href="/dynamics365/customer-engagement/developer/webapi/web-api-types-operations#complex-types">ComplexType</a> </td>
<td>Contains the response from msdyncrm_LoadInteractionsPublic action. It contains the following properties that contain the structured data of the type:
<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
<tr>
<td><code>Data</code></td>
<td>Edm.String</td>
<td>List of interactions as an escaped JSON array.</td>
</tr>
<tr>
<td><code>NextSkipToken</code></td>
<td>Edm.String</td>
<td>Identifies the next cursor or bookmark in the collection of interactions returned for a contact record.</td>
</tr>
</table>
</table>

## Example

**Request**

```http
GET [Organization URI]/api/data/v9.0/msdyncrm_LoadInteractionsPublic  
{
    "InteractionType": "WebsiteClicked",
    "ContactId" : "0dbe0fa3-8e18-e811-a951-000d3a37caec"
}
```

**Response**

The response contains a JSON object with a `Data` property containing the full list of interactions.

```http
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0

{
    "@odata.context":"[Organization URI]/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyncrm_LoadInteractionsPublicResponse",
    "Data":"[{\"InteractionId\":\"172C1E59A3CD4D85B392316DD76651CE\",\"InteractionType\":\"EmailSent\",\"Timestamp\":\"2018-02-23T13:10:48Z\",\"OrganizationId\":\"e47e99c2-20e3-4ef3-bbd4-288258bd6bf9\",\"EmailDomain\":\"microsoft.com\",\"ActivityId\":\"b6aeb700-f1c1-4cb1-e8f8-e883eac6bfbc\",\"SendingId\":\"5a019802-f763-3b72-fc91-0a9c95b67c5f\",\"ContactId\":\"0dbe0fa3-8e18-e811-a951-000d3a37caec\",\"MessageId\":\"5a2f3e76-9518-e811-a951-000d3a38caec\",\"CustomerJourneyId\":\"4c3846a1-9618-e811-a951-000d3a37cafc\",\"CustomerJourneyIterationId\":\"538825cf-fe1c-4fee-a671-7984eabb62eb\",\"UsageType\":\"CustomerJourney\",\"EmailAddressUsed\":\"sample@adventure-works.com\"}]",
    "NextSkipToken":null
}
```

### See also

[Data protection and the GDPR](../gdpr.md)