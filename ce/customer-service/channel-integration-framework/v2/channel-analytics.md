---
title: "Channel analytics in Dynamics 365 Channel Integration Framework 2.0| MicrosoftDocs"
description: "Read about the APIs that enable you to log analytics in Dynamics 365 Channel Integration Framework 2.0."
ms.date: 11/18/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Channel analytics in Dynamics 365 Channel Integration Framework 2.0

The contact center analytics need operational and conversational data to provide historical and real-time insights into the performance of the contact center. To get precise insights into the call center performance, the analysts need data from the following sources:

- **CRM transactional data** The data about customers, their cases, their journey, and all-round relationship with the organization. This is stored in Microsoft Dataverse. 
- **Communication Data** The data about the interactions (intended, ongoing, and completed) with known and unknown customers 
- **Agent Behavior Data** The data about the behavior of agents before, during and after the interactions. 

If you want to build a contact center analytics solution without the channel analytics model, you might face issues like: 

- Disjointed and distributed communication data that's generated and maintained by the channel providers.
- Agent behavior that's not logged or instrumented.
- No clear guidance on how to ingest analytical data and in what schema.

> [!IMPORTANT]
> Channel Analytics is not supported in Dynamics 365 Channel Integration Framework 1.0.

## What does channel analytics do?

In Dynamics 365 Channel Integration Framework 2.0, channel analytics provides a model to build a consistent, seamless, and unified experience when it comes to channel-related analytics and insights. 

- It generates instrumentation for agent behavior on Dynamics 365. 
- It provides APIs to ingest the conversational data into Dataverse. 
- It standardizes schema for how the analytical data will be stored.  
- It defines mechanism to correlate the communication data from multiple providers, CRM transactional data, and agent behavior data. 
- It is extensible in the sense that it allows you to bring your own KPIs and define your own data payload so that you can build analytical solutions based on your requirements. 

When the analytics data is available in Dataverse, business analysts can build analytical solutions that can help users to get historical and real-time insights into the contact center performance.

### How does analytics help supervisors?

Channel analytics can help supervisors identify the root cause of anomalies in a session, prepare audit reports for dissatisfactory conversations, track KPIs that impact customer sentiment, and monitor service requests for any KPI breach.

### How does analytics help customer service managers?

Channel analytics can help customer service managers track KPIs that indicate infrastructural health, get predictive insights about volume of requests and resource requirements, and track KPIs that impact high-priority customer sentiment in the contact center.

### How does analytics help customer service agents?

Channel analytics can help customer service agents see their performance metrics on different dimensions like customer satisfaction and average handling time, see the burndown trend for their daily work items, and see customer sentiment for ongoing conversations.

<a name="bkmk_analyticsapi"></a>

## Channel analytics APIs

The API for tracking event analytics is as follows.

| Name | Description |
|-------|-------|
| [logAnalyticsEvent](reference/microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events. |

The `updateConversation` API can be invoked if the channel provider wants to enrich the Conversation entity record with details from third-party systems. `logAnalyticsEvent` API can be called as many times as needed after the `updateConversation` call succeeds. 

## How to enable analytics for your organization

Channel Analytics can be enabled at a Dynamics 365 Channel Integration Framework provider level. It can be enabled using both the user interface and the Web API.

### Using app profile manager

1. Sign in to your [Power Apps](https://make.powerapps.com) portal.

2. Under the available apps, select the ellipses to the right of **Omnichannel for Customer Service** or **Customer Service workspace**.

3. On the menu that appears, select **App profile manager**.

4. Select **App profiles** from the site map, and then select your app profile.

5. Select the **Channels** tab.

6. Select **+ New** to add a new provider.

7. In the **New Channel** page, set **Enable Analytics** field to **Yes**.

![Enable channel analytics using user interface.](../media/enable-channel-analytics.PNG "Enable channel analytics")

### Using Web API

1. Query for the provider record ID by using the following Web API request:

   `GET [Organization URI]/api/data/v9.1/msdyn_ciproviders.` 
   
   Copy the value of `msdyn_ciproviderid` from the output.
   
2. Run the following script to enable the analytics flag to `True`.

```javascript
var data = {
              "msdyn_enableanalytics": true,
           }
// Update enable analytics flag to True
Xrm.WebApi.updateRecord("msdyn_ciprovider", <msdyn_ciproviderid fetched from previous step>, data)
```

3. Reload the page.

## Typical flow for channel analytics

For every incident conversation, the provider will call the [updateConversation API](reference/microsoft-ciframework/updateConversation.md). The data payload of the API will contain the information to create a conversation record (with session and participant information).

For that session, all first-party instrumentation events like notification displayed, notification response, session started, and session switched will be fired with the correlation ID.

If the partner wants to fire some custom event for their KPIs, they can do it with the same correlation ID as well using the [logAnalyticsEvent API](reference/microsoft-ciframework/logAnalyticsEvent.md).

## Channel analytics entities

Dynamics 365 Channel Integration Framework 2.0 creates a Conversation entity ([msdyn_ocliveworkitem](/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) record in Dataverse for every third-party conversation launched through it.

### msdyn_kpieventdefinition

Primary entity for defining a KPI event.

**Display name**: KPI Event Definition<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_kpieventdefinitions`

More information: [msdyn_kpieventdefinition](reference/entities-attributes/msdyn_kpieventdefinition.md)

### msdyn_kpieventdata

Primary entity for a KPI event.

**Display name**: KPI Event Data<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_kpieventsdata`

More information: [msdyn_kpieventdata](reference/entities-attributes/msdyn_kpieventdata.md)

### msdyn_conversationdata

This entity is deprecated and using it to access Dataverse data is not supported.

More information: [msdyn_conversationdata](reference/entities-attributes/msdyn_conversationdata.md)

### msdyn_sessiondata

This entity is deprecated and using it to access Dataverse data is not supported.

More information: [msdyn_sessiondata](reference/entities-attributes/msdyn_sessiondata.md)

### msdyn_sessionparticipantdata

This entity is deprecated and using it to access Dataverse data is not supported.

More information: [msdyn_sessionparticipantdata](reference/entities-attributes/msdyn_sessionparticipantdata.md)

## Sample code

The softphone integration [sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/channel-integration-framework/TwilioSampleInteg_version2) implements functionalities wherein the conversation entity record is updated when a call is accepted and updating conversation entity record with case details as soon as a case is created. It uses Channel Analytics API [logAnalyticsEvent](reference/microsoft-ciframework/logAnalyticsEvent.md) to log the events when the call is put on hold or removed from hold.

More information: [Sample code for softphone integration using Dynamics 365 Channel Integration Framework 2.0](sample-softphone-integration-v2.md)

### See also

[Agent experience profiles](../../../app-profile-manager/overview.md)
[What's new in Dynamics 365 Channel Integration Framework](../whats-new-channel-integration-framework.md)  
[Frequently asked questions](../faq-channel-integration-framework.md)  



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
