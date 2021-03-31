---
title: "Channel Analytics | MicrosoftDocs"
description: "Read about the APIs that enable you to log analytics in Dynamics 365 Channel Integration Framework version 2.0."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/24/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Channel Analytics

[!INCLUDE[cc-data-platform-banner](../../../includes/cc-data-platform-banner.md)]

The contact center analytics need operational and conversational data to provide historical and real-time insights into the performance of the contact center. To get precise insights into the call center performance, the analysts need data from the following sources 

- **CRM transactional data**: The data about the customers, their cases, their journey and all round relationship with the organizations. This is stored in Microsoft Dataverse 
- **Communication Data**: The data about the interactions (intended, ongoing and completed) with known and unknown customers 
- **Agent Behavior Data**: The data about the behavior of agents before, during and after the interactions. 

Channel Analytics in the Dynamics 365 Channel Integration Framework, provides a model to build a consistent, seamless, and unified experience when it comes to channel related analytics and insights. 

Without the channel analytics model, if you want to build a contact center analytics solution you will face following problems: 

- Disjointed and distributed communication data that is generated and maintained by the channel providers.
- Agent behavior is not logged and instrumented.
- No clear guidance on how to ingest analytical data and in what schema.

> [!IMPORTANT]
> Channel Analytics is not supported for Channel Integration Framework version 1.0.

## How does Channel Analytics help?

- It generates instrumentation for agent behavior on the Dynamics 365. 
- It provides APIs to ingest the conversational data into Dataverse. 
- It standardizes schema for how the aforementioned analytical data will be stored  
- It defines mechanism to correlate the communication data from multiple providers, CRM transactional data and agent behavior data. 
- It is extensible, in the sense that it allows you to bring your own KPIs, define your own data payload so that organizations can build analytical solutions as per their need. 

Once the aforementioned data is available in CDS, the business analysts can build analytical solutions that can help users to get historical and real time insights into the contact center performance.

### How do analytics help supervisors?

Channel Analytics can help supervisors identify the root cause of anomalies in a session, prepare audit reports for dissatisfactory conversations, track KPIs that impact customer sentiment, and monitor service requests for any KPI breach.

### How do analytics help customer service managers?

Channel Analytics can help customer service managers track KPIs that indicate infrastructural health, get predictive insights about volume of requests and resource requirements, and track KPIs that impact high-priority customer sentiment in the contact center.

### How do analytics help customer service agents?

Channel Analytics can help customer service agents see their performance metrics on different dimensions like customer satisfaction and average handling time, see the burndown trend for their daily work items, and see customer sentiment for ongoing conversations.

<a name="bkmk_analyticsapi"></a>

## Channel Analytics APIs

The two APIs for tracking event analytics are:

| Name | Description |
|-------|-------|
| [updateConversation](reference/microsoft-ciframework/updateConversation.md) | Invoke this method to update a conversation record. |
| [logAnalyticsEvent](reference/microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events. |

The `updateConversation` API can be invoked if the channel provider wants to enrich the Conversation entity record with details from third party systems. `logAnalyticsEvent` API can be called as many times as needed after the `updateConversation` call succeeds. 

### How to enable analytics for your organization

Channel Analytics can be enabled at a Dynamics 365 Channel Integration Framework provider level. It can be enabled using both the user interface and the Web API.

#### Using User Interface

1. Select the drop-down button on the Dynamics 365 and select **Channel Integration Framework**.

![Dynamics 365 drop-down button to find Channel Integration Framework](../media/cif-app-navigation.png "Dynamics 365 drop-down button to find Channel Integration Framework")

2. Select **+ New** to add a new provider.

3. In the **New Channel** page, set **Enable Analytics** field to **Yes**.

![Enable channel analytics using user interface](../media/enable-channel-analytics.PNG "Enable channel analytics")

#### Using Web API

1. Query for the provider record ID by using the following Web API request:

   `GET [Organization URI]/api/data/v9.1/msdyn_ciproviders.` 
   
   Copy the value of `msdyn_ciproviderid` from the output.
   
2. Execute the following script to enable the analytics flag to `True`.

```javascript
var data = {
              "msdyn_enableanalytics": true,
           }
// Update enable analytics flag to True
Xrm.WebApi.updateRecord("msdyn_ciprovider", <msdyn_ciproviderid fetched from previous step>, data)
```

3. Reload the page.

## Typical flow for Channel Analytics

For every incident conversation, the provider will call the [updateConversation API](reference/microsoft-ciframework/updateConversation.md). The data payload of the API will contain the information to create a conversation record (with session and participant information).

For that session, all first-party instrumentation events like notification displayed, notification response, session started, and session switched will be fired with the correlation ID.

If the partner wants to fire some custom event for their KPIs, they can do it with the same correlation ID as well using the [logAnalyticsEvent API](reference/microsoft-ciframework/logAnalyticsEvent.md).

## Channel Analytics Entities

Channel Integration Framework creates a Conversation entity ([msdyn_ocliveworkitem](../../../omnichannel/developer/reference/entities/msdyn_ocliveworkitem.md)) record in Dataverse for every third party conversation launched through it.

### msdyn_kpieventdefinition

Primary entity for defining a KPI event.

**Display name**: KPI Event Definition<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_kpieventdefinitions`

More information: [msdyn_kpieventdefinition](reference/entities-attributes/msdyn_kpieventdefinition.md).

### msdyn_conversationdata

This entity is deprecated and using it to access Dataverse data is not supported.

More information: [msdyn_conversationdata](reference/entities-attributes/msdyn_conversationdata.md).

### msdyn_sessiondata

This entity is deprecated and using it to access Dataverse data is not supported.

More information: [msdyn_sessiondata](reference/entities-attributes/msdyn_sessiondata.md).

### msdyn_sessionparticipantdata

This entity is deprecated and using it to access Dataverse data is not supported.

More information: [msdyn_sessionparticipantdata](reference/entities-attributes/msdyn_sessionparticipantdata.md).

### msdyn_kpieventdata

Primary entity for a KPI event.

**Display name**: KPI Event Data<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_kpieventsdata`

More information: [msdyn_kpieventdata](reference/entities-attributes/msdyn_kpieventdata.md).

## Sample code

The softphone integration [sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/channel-integration-framework/TwilioSampleInteg_version2) implements functionalities wherein the conversation entity record is updated when a call is accepted and updating conversation entity record with case details as soon as a case is created. It uses Channel Analytics API [logAnalyticsEvent](reference/microsoft-ciframework/logAnalyticsEvent.md) to log the events when the call is put on Hold or Unhold.

More information: [Sample code for softphone integration using Dynamics 365 Channel Integration Framework version 2.0](sample-softphone-integration-v2.md).

## See also

[Softphone integration sample code for Channel Integration Framework version 2.0](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/channel-integration-framework/TwilioSampleInteg_version2)<br />
[What's new in Dynamics 365 Channel Integration Framework](../whats-new-channel-integration-framework.md)<br />
[Frequently asked questions](../faq-channel-integration-framework.md)<br />
[updateConversation API](reference/microsoft-ciframework/updateConversation.md)<br />
[logAnalyticsEvent](reference/microsoft-ciframework/logAnalyticsEvent.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]