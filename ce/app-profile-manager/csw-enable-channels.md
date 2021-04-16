---
title: "Set up Omnichannel for Customer Service channels in Customer Service workspace | MicrosoftDocs"
description: "Learn how to configure Omnichannel for Customer Service channels in Customer Service workspace"
ms.date: 11/10/2020
ms.service: "dynamics-365-customerservice"
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---

# Set up Omnichannel for Customer Service channels in Customer Service workspace

When your agents are working on cases, there may be times when you want them to also be able to have conversations with customers. Using Omnichannel for Customer Service add-on [licensing](https://dynamics.microsoft.com/customer-service/overview/#pricing), you can set up your Customer Service workspace environment so that agents are able to work on both cases and conversations without having to leave the Customer Service workspace app.

## Enable channel conversations in Customer Service workspace 

To enable agents to be able to have conversations in Customer Service workspace, do the following: 

1. Obtain Omnichannel for Customer Service add-on [licenses](https://dynamics.microsoft.com/pricing/customer-service/#plans) and set up your Omnichannel environment. More information: [Provision Omnichannel](../customer-service/omnichannel-provision-license.md). 

2. Configure the following in the Omnichannel administrator app: 

    a. [Channels](../customer-service/channels.md)
    
    b. [Queues and users](../customer-service/queues-omnichannel.md)
    
    c. [Work streams](../customer-service/create-workstreams.md)
    
3. Assign the Omnichannel agent and/or Omnichannel supervisor roles to your users. More information: [Assign roles and enable users for Omnichannel for Customer Service](../customer-service/add-users-assign-roles.md).

## Set up profiles in app profile manager

Once you've completed the configurations above, go to App profile manager and complete the following:

1.	Create a new app profile or use the default, out-of-box **Customer Service workspace + Channels** profile. More information: [Create and use app profiles to manage apps](app-profile-manager.md).

2.	Assign the app profile you created to the agents and supervisors you want to work on both cases and conversations. More information: [Roles and permissions](security-roles.md).

3.	Verify that you've assigned Omnichannel for Customer Service-related roles to the agents and supervisors you want to work on both conversations and cases.

## Access Omnichannel for Customer Service dashboard views 

When configured, the following dashboards are available in Customer Service workspace:

For agents:
- Omnichannel Agent Dashboard
- Customer Service Representative Dashboard

For supervisors:
- Omnichannel Agent dashboard
- Omnichannel Ongoing Conversations Dashboard
- Intraday Insights
- Customer Service Representative Dashboard
- Customer Service Manager Dashboard


### Agent experience
After you have configured the Omnichannel for Customer Service and app profile manager features, agents will have a user experience in Customer Service workspace that is similar to the following:

1.	The agent signs in to Customer Service workspace and can view the Omnichannel agent dashboard from the dashboard view.

2.	The agent can work on conversations by accepting or selecting a conversation from the dashboard, and all the functionality of Omnichannel for Customer Service is available to them, including:

    a.	Notifications - More information: [View notifications](../customer-service/oc-notifications.md) <br>
    b.	Customer summary - More information: [View a customer summary to get information about a customer](../customer-service/oc-customer-summary.md) <br>
    c.	Notes – More information: [Take notes specific to a conversation](../customer-service/oc-take-notes.md) <br>
    d.	Conversation and session forms – More information: [View conversation and session forms](../customer-service/oc-view-activity-types.md) <br>
    e.	Transcripts – More information: [Search transcripts](../customer-service/oc-search-transcipts.md) <br>
    f.	Viewing customer summaries for conversation requests – More information: [View customer summaries for incoming conversation requests](../customer-service/oc-view-customer-summary-incoming-conversation-request.md) <br>
    g.	Presence status – More information: [Manage presence status](../customer-service/oc-manage-presence-status.md)

### Supervisor experience

When a supervisor signs in to Customer Service workspace, they can select a dashboard to do the following:

- Monitor agent conversations - More information: [Monitor and assign conversations](../customer-service/monitor-conversations.md)
- Monitor ongoing conversations - More information: [View and understand Omnichannel Ongoing Conversations conversations dashboard](../customer-service/ongoing-conversations-dashboard.md)
- View intraday insights - More information: [View and understand Omnichannel intraday insights dashboard](../customer-service/intraday-insights-dashboard.md)
- View customer satisfaction levels - More information: [Sentiment monitoring](../customer-service/supervisor-sentiment-monitoring.md)

### See also
[App profile manager overview](overview.md)  
[Roles and privileges associated with app profile manager](security-roles.md)  
[Customer Service workspace overview](../customer-service/csw-overview.md)  
[Omnichannel agent overview](../customer-service/omnichannel-agent-overview.md)  
[Introduction to intraday supervisor experiences](../customer-service/intro-intraday-insights-dashboard.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]