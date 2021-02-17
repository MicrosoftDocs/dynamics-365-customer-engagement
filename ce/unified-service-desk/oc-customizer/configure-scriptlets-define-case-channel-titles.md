---
title: "Configure scripts using scriptlets to define case and channel titles | MicrosoftDocs"
description: "Learn how to configure sto define case and channel titles when using Omnichannel for Customer Service in Unified Service Desk."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Configure scriptlets to define case and channel titles

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The topic describes how to configure scripts using scriptlets to define case and channel titles.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Configure scriptlets

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Scriptlets** and then select **+ New**.

5. In the new page, specify the following for **ResoleCaseTitle**.

    | Tab           | Field             | Value              |
    |---------------|-------------------|--------------------|
    | General | Name | ResolveCaseTitle |
    | General | Script Text | function ResolveCaseNameTitle() { <br>  if ("\[\[incident.title\]+\]" != "") { <br>    return "\[\[incident.title\]+\]"; <br>  } <br>  else <br>    return "\[\[$Resources.ResolveCaseTitleScriptletDefaultText\]\]"; <br>  } <br> ResolveCaseNameTitle(); |

6. Repeat step 4 and 5 to create **ResolveChannelTitle**.

    | Tab           | Field             | Value              |
    |---------------|-------------------|--------------------|
    | General | Name | ResolveChannelTitle |
    | General | Script Text | function GetChannelIdRequestMessage() {  <br> var channelName = "\[\[channelName\]+\]"; <br> var resString = "\[\[$Resources.ChatRequestTitle\]\]";  <br> if(channelName == "SMS") { <br> resString = "\[\[$Resources.SMSRequestTitle\]\]"; <br> } <br> return resString;  <br>  }  <br> GetChannelIdRequestMessage(); |
   
7. Save the session name information.

## Add the session name information to configuration

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**

4. Select **Configuration** and then select a configuration from the list.

5. Select the **Session Lines, Agent Scripts, and Scriptlets** tab.

6. In the **Scriptlets** section, select the more commands (...), select **Add Existing Session Scriptlets**. The **Lookup Records** pane appears.

7. Type the name of the **Scriptlets** in the search box. Select the scriplet from the search results and select **Add**.

8. Select **Save** to save the changes.

## See also

- [Configure Omnichannel Agent Dashboard](configure-agent-dashboard.md)
- [Configure notifications for agents](configure-notification-screen-pop-agents.md)
- [Configure customer summary](configure-customer-summary.md)
- [Configure communication panel for agents](configure-communication-panel.md)
- [Configure session name information using session lines](configure-session-name-information.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]