---
title: "Configure session name information | MicrosoftDocs"
description: "Learn how to configure session name information when using Omnichannel for Customer Service in Unified Service Desk."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Configure session name information using session lines

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The topic describes how to dynamically display the session tab name, you'll configure a session lines rules using the replacement parameters.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Configure session name

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Session Lines** and then select **+ New**.

5. In the new page, specify the following.

    | Tab           | Field             | Value              |
    |---------------|-------------------|--------------------|
    | General | Name | Omnichannel Session Name |
    | General | Type | Session Name |
    | General | Display | \[\[$Context.From\]+\] |

6. Save the session name information.

## Add the session name information to configuration

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**

4. Select **Configuration** and then select a configuration from the list.

5. Select the **Session Lines, Agent Scripts, and Scriptlets** tab.

6. In the **Session Lines** section, select the more commands (...), select **Add Existing Session Information**, type the name of the **Session Lines** in the search box, and then press **Enter** or select the search icon.

7. Select the session lines from the search results and select **Add**.

8. When you've finished, select **Save**.

## See also

- [Configure Omnichannel Agent Dashboard](configure-agent-dashboard.md)
- [Configure notifications for agents](configure-notification-screen-pop-agents.md)
- [Configure customer summary](configure-customer-summary.md)
- [Configure communication panel for agents](configure-communication-panel.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]