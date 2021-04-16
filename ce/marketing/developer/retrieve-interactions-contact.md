---
title: "Retrieve interactions for a contact using code (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how to programmatically retrieve interactions for a contact using an action."
ms.date: 01/06/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Retrieve interactions for a contact using code

Use the **msdyncrm_LoadInteractionsPublic** action to programmatically retrieve interactions for a contact. This action is useful for responding to [get-my-data requests](../gdpr.md#respond-to-get-my-data-requests) in order to fulfill the General Data Protection Regulation (GDPR) compliance.

> [!TIP]
> You can also generate request and response classes for this action to include in your application code. More information: [Generate early-bound types for an action](/powerapps/developer/common-data-service/custom-actions#generate-early-bound-types-for-an-action)

## Action parameters

The **msdyncrm_LoadInteractionsPublic** action expects the following input parameters:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td><code>ContactId</code></td>
<td>Edm.String</td>
<td>ID of the contact record to retrieve the interactions for. Required.</td>
</tr>

<tr>
<td><code>DateFrom</code></td>
<td>Edm.String</td>
<td>Start date in the MM-DD-YYYY format from which you want to retrieve interactions. Optional.</td>
</tr>
<tr>
<td><code>DateTo</code></td>
<td>Edm.String</td>
<td>End date in the MM-DD-YYYY format until which you want to retrieve interactions. Optional.</td>
</tr>
<tr>
<td valign="top"><code>InteractionType</code></td>
<td valign="top">Edm.String</td>
<td>Type of interaction to be retrieved. Required.<br/> You can specify one of the following values:
<ul>
<li>ActivityContactBlocked</li>
<li>ActivityContactDispatched</li>
<li>ActivityContactProcessingFailed</li>
<li>CreateCrmActivityContactProcessed</li>
<li>CreateCustomChannelActivityContactProcessed</li>
<li>CustomChannelResponse</li>
<li>CustomerJourneyContactRecordUpdated</li>
<li>EmailBlockBounced</li>
<li>EmailBlocked</li>
<li>EmailClicked</li>
<li>EmailContainsBlockListedLinks</li>
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
POST [Organization URI]/api/data/v9.0/msdyncrm_LoadInteractionsPublic HTTP/1.1
Accept: application/json
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
  
{
    "InteractionType": "WebsiteClicked",
    "ContactId": "0dbe0fa3-8e18-e811-a951-000d3a37caec",
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
[Preview: Prepare for analytic reporting with Power BI](../custom-analytics.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]