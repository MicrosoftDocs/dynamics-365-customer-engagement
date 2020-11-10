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

When your agents are working on cases, there may be times when you want them to also be able to have conversations with customers. Using Omnichannel for Customer Service add-on licensing, you can set up your Customer Service workspace environment so that agents are able to work on both cases and conversations without having to leave the Customer Service workspace app.

## Enable channel conversations in Customer Service workspace 

To enable agents to be able to have conversations in Customer Service workspace, do the following: 

1. Obtain Omnichannel for Customer Service add-on licenses and set up your Omnichannel environment. More information: [Provision Omnichannel](../omnichannel/administrator/omnichannel-provision-license.md). 

2. Configure the following in the Omnichannel administrator app: 

    a. [Channels](../omnichannel/administrator/channels.md)
    
    b. [Queues and users](../omnichannel/administrator/queues-omnichannel.md)
    
    c. [Work streams](../omnichannel/administrator/work-streams-introduction.md)
    
3. Assign the Omnichannel agent and/or Omnichannel supervisor roles to your users. More information: [Assign roles and enable users for Omnichannel for Customer Service](../omnichannel/administrator/add-users-assign-roles.md).

## Set up profiles in App profile manager

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
Once you have configured the Omnichannel and App profile manager features, agents will have a user experience in Customer Service workspace that is similar to the following:

1.	The agent signs in to Customer Service workspace and can view the Omnichannel agent dashboard from the dashboard view.

2.	The agent can work on conversations by accepting or selecting a conversation from the dashboard, and all the functionality of Omnichannel for Customer Service is available to them, including:

    a.	Notifications - More information: [View notifications](../omnichannel/agent/agent-oc/oc-notifications.md) <br>
    b.	Customer summary - More information: [View a customer summary to get information about a customer](../omnichannel/agent/agent-oc/oc-customer-summary.md) <br>
    c.	Notes – More information: [Take notes specific to a conversation](../omnichannel/agent/agent-oc/oc-take-notes.md) <br>
    d.	Conversation and session forms – More information: [View conversation and session forms](../omnichannel/agent/agent-oc/oc-view-activity-types.md) <br>
    e.	Transcripts – More information: [Search transcripts](../omnichannel/agent/agent-oc/oc-search-transcipts.md) <br>
    f.	Viewing customer summaries for conversation requests – More information: [View customer summaries for incoming conversation requests](../omnichannel/agent/agent-oc/oc-view-customer-summary-incoming-conversation-request.md) <br>
    g.	Presence status – More information: [Manage presence status](../omnichannel/agent/agent-oc/oc-manage-presence-status.md)

### Supervisor experience

When a supervisor signs in to Customer Service workspace, they can select a dashboard to do the following:

- Monitor agent conversations - More information: [Monitor and assign conversations](../omnichannel/supervisor/monitor-conversations.md)
- Monitor ongoing conversations - More information: [View and understand Omnichannel Ongoing Conversations conversations dashboard](../omnichannel/supervisor/ongoing-conversations-dashboard.md)
- View intraday insights - More information: [View and understand Omnichannel intraday insights dashboard](../omnichannel/supervisor/intraday-insights-dashboard.md)
- View customer satisfaction levels - More information: [Sentiment monitoring](../omnichannel/supervisor/supervisor-sentiment-monitoring.md)

### See also
- [App profile manager overview](app-profile-manager/overview.md) <br>
- [Roles and privileges associated with app profile manager](app-profile-manager/security-roles.md) <br>
- [Customer Service workspace overview](../customer-service/csw-overview.md) <br>
- [Omnichannel agent overview](../omnichannel/agent/omnichannel-agent-overview.md)<br>
- [Introduction to intraday supervisor experiences](..omnichannel/supervisor/intro-intraday-insights-dashboard.md)
