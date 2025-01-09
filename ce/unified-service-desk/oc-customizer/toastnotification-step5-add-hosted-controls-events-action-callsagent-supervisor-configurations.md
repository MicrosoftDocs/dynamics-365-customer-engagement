---
title: "Controls, events, forms, action calls for toast notifications | MicrosoftDocs"
description: "Learn how to add a hosted control, events, forms, and action calls for toast notifications in Omnichannel for Customer Service on Unified Service Desk."
ms.date: 06/27/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
monikerRange: '>= dynamics-usd-4.1'
ms.custom: evergreen
---


# Step 5: Add the hosted control, events, forms and action calls to configurations 



[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to add hosted control, events, actions calls to the configurations.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create forms to define notification layout](toastnotification-step1-create-forms-define-layout-behavior-notification.md) [Step 2: Create Omnichannel Toast Notification-related hosted control](toastnotification-step2-create-hosted-controls.md), [Step 3: Create Omnichannel Toast Notification-related action call](toastnotification-step3-create-action-call-display-notification.md), and [Step 4: Add Omnichannel Toast Notification-related action calls to events](toastnotification-step4-add-action-calls-events.md). The configurations that you completed are required for this topic.

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

13. Type the name of the **Forms** in the search box. Select the forms from the search results and select **Add**.

14. When you've finished, select **Save**.

## See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create Omnichannel Toast Notification hosted controls](toastnotification-step2-create-hosted-controls.md)
- [Step 3: Create Omnichannel Toast Notification-related action calls](toastnotification-step3-create-action-call-display-notification.md)
- [Step 4: Attach Omnichannel Toast Notification-related action calls to the events](toastnotification-step4-add-action-calls-events.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
