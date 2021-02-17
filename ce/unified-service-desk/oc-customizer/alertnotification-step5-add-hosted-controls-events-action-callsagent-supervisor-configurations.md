---
title: "Add the hosted control, events,forms, and action calls to configurations | MicrosoftDocs"
description: "Learn how to add the hosted control, events, forms, and action calls to the agent and supervisor configurations in Omnichannel for Customer Service - Unified Service Desk."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# Step 5: Add the hosted control, events, forms and action calls to configurations

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Prerequisites 

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md) [Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md), [Step 2: Create Omnichannel Alert Notification hosted controls](alertnotification-step2-create-hosted-controls.md), [Step 3: Create Omnichannel Alert Notification-related action call](alertnotification-step3-create-action-call-display-notification.md), and [Step 4: Add Omnichannel Alert Notification-related action calls to events](alertnotification-step4-add-action-calls-events.md). The configurations that you completed are required for this topic. 

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Add hosted controls, events, action calls, and forms to configurations


1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Configuration** and then select a configuration from the list.

5. Select the **Hosted Controls, Events and Action Calls** tab.

6. In the **Hosted Controls** section, select the more commands (...), select **Add Existing Hosted Control**, type the name of the **Hosted Control** in the search box, and then press **Enter** or select the search icon.

7. Select the hosted control from the search results and select **Add**.

8. In the **Events** section, select the more commands (...), select **Add Existing Events**, type the name of the **Event** in the search box, and then press **Enter** or select the search icon.

9. Select the event from the search results and select **Add**.

10. In the **Action Calls** section, select the more commands (...), select **Add Existing Action Calls**, type the name of the **Action Calls** in the search box, and then press **Enter** or select the search icon.

11. Select the action calls from the search results and select **Add**.

12. Select the **Others Entities** tab.

12. In the **Forms** section, select the more commands (...), select **Add Existing Form**. The **Lookup Records** pane appears.

13. Type the name of the **Forms** in the search box. Select the form from the search results and select **Add**.

14. Select **Save** to save the changes.

> [!div class="nextstepaction"]
> [Next topic: Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)

## See also

- [Configure notification for agents](configure-notification-screen-pop-agents.md)
- [Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create Omnichannel Alert Notification hosted controls](alertnotification-step2-create-hosted-controls.md)
- [Step 3: Create Omnichannel Alert Notification-related action call](alertnotification-step3-create-action-call-display-notification.md)
- [Step 4: Add Omnichannel Alert Notification-related action calls to events](alertnotification-step4-add-action-calls-events.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]