---
title: "Add the hosted controls, events, and action calls to the agent and supervisor configurations | MicrosoftDocs"
description: "Learn how to add the hosted controls, events, action calls to the agent and supervisor configurations in Omni-channel Engagement Hub - Unified Service Desk."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 39fa4483-8b31-4a42-99b3-1f46b62767d8
ms.custom: 
---

# Step 5: Add the hosted controls, events, and action calls to the agent and supervisor configurations 

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

## Prerequisites

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create forms to define notification layout](toastnotification-step1-create-forms-define-layout-behavior-notification.md) [Step 2: Create hosted controls](toastnotification-step2-create-hosted-controls.md), [Step 3: Create an action call to display the notification](toastnotification-step3-create-action-call-display-notification.md), and [Step 4: Add the action calls to the events](toastnotification-step4-add-action-calls-events.md). The configurations that you completed are required for this topic.

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

1.  Sign in to Microsoft Dynamics 365 for Customer Engagement instance. 

2.  Go to **Settings** > **Unified Service Desk** > **Configuration**. 

3.  Select the configuration from the list. 

4.  On the nav bar, select the down arrow next to Configuration, and select **Action Calls**. 

5.  On the next page, select **Add Existing Action Call**, type the name of the action in the search bar, and then press ENTER or select the search icon.

6.  Add the Action calls that are displayed in the search results. 

7.  Similarly, add the hosted controls and the events by selecting the down arrow next to Configuration, and selecting Hosted Controls and Events, respectively. 

8.  Select **Save**.

## See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create hosted controls](toastnotification-step2-create-hosted-controls.md)
- [Step 3: Create an action call to display the notification](toastnotification-step3-create-action-call-display-notification.md)
- [Step 4: Add the action calls to the events](toastnotification-step4-add-action-calls-events.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)