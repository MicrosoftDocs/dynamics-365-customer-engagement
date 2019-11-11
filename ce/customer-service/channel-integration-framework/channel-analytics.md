---
title: "Channel Analytics | MicrosoftDocs"
description: "Read about the APIs that enable you to log analytics in Dynamics 365 Channel Integration Framework."
keywords: ""
ms.date: 10/25/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: 340185D3-8C9E-43B2-901D-13D9591632F5
author: susikka
ms.author: susikka
manager: shujoshi
---

# Preview: Channel Analytics

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

The contact center analytics need operational and conversational data to provide historical and real-time insights into the performance of the contact center. To get precise insights into the call center performance, the analysts need data from the following sources 

- **CRM transactional data**: The data about the customers, their cases, their journey and all round relationship with the organizations. This is stored in Common Data Services 
- **Communication Data**: The data about the interactions (intended, ongoing and completed) with known and unknown customers 
- **Agent Behavior Data**: The data about the behavior of agents before, during and after the interactions. 

Channel Analytics in the Dynamics 365 Channel Integration Framework, provides a model to build a consistent, seamless, and unified experience when it comes to channel related analytics and insights. 

Without the channel analytics model, if you want to build a contact center analytics solution you will face following problems: 

- Disjointed and distributed communication data that is generated and maintained by the channel providers.
- Agent behavior is not logged and instrumented.
- No clear guidance on how to ingest analytical data and in what schema.

## How does Channel Analytics help?

- It generates instrumentation for agent behavior on the Dynamics 365. 
- It provides APIs to ingest the conversational data into the common data services. 
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
| [initLogAnalytics](reference/microsoft-ciframework/initLogAnalytics.md) | Invoke this method on an incoming conversation to log analytics. |
| [logAnalyticsEvent](reference/microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events. |

Ideally `initLogAnalytics` API should be called before the incoming notification is displayed. `logAnalyticsEvent` API can be called as many times as needed after the `initLogAnalytics` call succeeds. 

If there is a need to log events from the server side, the following required entity records need to be created before the event logging can take place.
- Conversation Data
- Session Data 
- Session Participant Data

After the above records are created, the event logging can be done by creating `KPI Event Data` entity record. 

### How to enable analytics for your organization

Channel Analytics can be enabled at a Dynamics 365 Channel Integration Framework provider level. 

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

For every incident conversation, the provider will call the [initLogAnalytics API](reference/microsoft-ciframework/initLogAnalytics.md). The data payload of the API will contain the information to create a conversation record (with session and participant information).

For that session, all first-party instrumentation events like notification displayed, notification response, session started, and session switched will be fired with the correlation ID.

If the partner wants to fire some custom event for their KPIs, they can do it with the same correlation ID as well using the [logAnalyticsEvent API](reference/microsoft-ciframework/logAnalyticsEvent.md).

## Channel Analytics Entities

### msdyn_kpieventdefinition

Primary entity for defining a KPI event.

**Display name**: KPI Event Definition<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_kpieventdefinitions`

### msdyn_conversationdata

Primary entity for a conversation.

**Logical name**: Conversation Data<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_conversationsdata`

### msdyn_sessiondata

Primary entity for session data.

**Display name**: Session data<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_sessionsdata`

### msdyn_sessionparticipantdata

Primary entity for representing session participants.

**Display name**: Session Participant Data<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_sessionparticipantsdata`

### msdyn_kpieventdata

Primary entity for a KPI event.

**Display name**: KPI Event Data<br />
**Primary field**: name<br />
**Entity set path**: `[Organization URI]/api/data/v9.1/msdyn_kpieventsdata`

## See also

[What's new in Dynamics 365 Channel Integration Framework](whats-new-channel-integration-framework.md)
