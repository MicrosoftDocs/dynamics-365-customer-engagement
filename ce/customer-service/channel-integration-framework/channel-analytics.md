---
title: "Channel Analytics | MicrosoftDocs"
description: "Read about the APIs that enable you to log analytics in Channel Integration Framework."
keywords: ""
ms.date: 10/18/2019
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
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

Channel Integration Framework provides insights about how the call center is performing in terms of agent assignments, customer satisfaction, average handling time and agent performance. It uses predictive algorithms to calculate upcoming load, customer satisfaction, relationship scores and upsell probability, and helps you utilize operational and conversational analytics for better future planning. 

> [!div class="mx-imgBorder"]
> ![Channel Analytics](media/channel-analytics.PNG "Channel Analytics")

Here are some common problems that customer service industry faces:

- Disjoint and distributed communication data that is generated and maintained by the channel providers.
- Agent behavior is not logged and instrumented.
- No clear guidance on how to ingest analytical data and in what schema.

## How does Channel Analytics help?

Channel Analytics provides a consistent, seamless, and unified experience when it comes to channel related analytics and insights. This means that:

- Channel Analytics enables users to slice and dice KPIs based on different dimensions, including the channel type.
- Users need not jump across apps to get channel specific information.
- Both the conversational data from third party providers and transactional data from Dynamics 365 apps is used to provide a comprehensive contact center analytics information.
- It generates instrumentation for client-sdie events.
- Standardize schema for the analytical data.
- Define privacy and compliance boundaries for the data stored.
- Define mechanism to correlate the communication data from multiple providers, CRM transactional data and agent behavior data.
- Provide sample dashboards with Out-of-the-box KPIs.

### How do analytics help Supervisors?

Channel Analytics can help Supervisors identify the root cause for anomalies in a session, prepare audit reports for dissatisfactory conversations, track KPIs that impact customer sentiment and monitor service requests for any KPI breach.

### How do analytics help Customer Service Managers?

Channel Analytics can help Customer Service Managers track KPIs that indicate infrastructural health, get predictive insights about volume of requests and resource requirements, and track KPIs that impact high priority customer sentiment in the contact center

### How do analytics help Customer Service Agents?

Channel Analytics can help Customer Service agents see their performance metrics on different dimensions like customer satisfaction and average handling time, see burndown trend for their daily work items and see customer sentiment for ongoing conversations.

<a name="bkmk_analyticsapi"></a>

## Channel Analytics APIs

The two APIs for tracking event analytics are:
1. `initLogAnalytics` API needs to be called only once for every conversation before any event is being logged. The ideal place would be to call it before the incoming notification is displayed.
2. `logAnalyticsEvent` can be called as many times as needed after the initLogAnalytics call succeeds.
- If there is a need to log events from the server side, the following required entity records need to be created before the event logging can take place.
              - Conversation Data
              - Session Data
              - Session Participant Data
  After the above records are created, the event logging can be done by creating `KPI Event Data` entity record.

| Name | Description |
|-------|-------|
| [initLogAnalytics](reference/microsoft-ciframework/initLogAnalytics.md) | Invoke this method on an incoming conversation to log analytics. |
| [logAnalyticsEvent](reference/microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events. |

### How to enable analytics for your organization?

Channel Analytics can be enabled at a Channel Integration Framework provider level. 
1. Query for the provider record Id by using the following Web API request - `GET [Organization URI]/api/data/v9.1/msdyn_ciproviders.` Copy the value of value of `msdyn_ciproviderid` from the output.
2. Execute the following script to enable analytics flag to `True`.

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

For that session, all first party instrumentation events like notification displayed, notification response, session started and session switched will be fired with the correlation Id.

If tha partner wants to fire some custom event for their KPIs they can do it with the same correlation Id as well using the [logAnalytics API](reference/microsoft-ciframework/logAnalytics.md).

## See also

[What's new in Channel Integration Framework](whats-new-channel-integration-framework.md)