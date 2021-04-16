---
title: "Configure link to conversation button | MicrosoftDocs"
description: "Learn how to configure link to conversation button for agents using Omnichannel for Customer Service in Unified Service Desk."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/29/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Configure link to conversation button in Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

You accept a conversation request and there is no record in the Omnichannel application linked to this conversation. Now, you create the contact or account record, and you want to link the record to the conversation. This topic describes, as a system customizer, how to configure the link to conversation button for agents using Omnichannel app in Unified Service Desk to link the records.

Consider the following scenario:

- Agent accepts the conversation request
- Agent creates an account record
- Link the record to the conversation

For this scenario, you must create the following:

1. **Create a hosted control:** Communication Panel is the hosted control.
1. **Create a action call:** Link to conversation is the action call.
2. **Create a toolbar and toolbar button:** Link records is the toolbar.
3. **Attach the action call and toolbar:** Link to conversation is the toolbar button.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

- You must have configured communication panel. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure communication panel for agents](configure-communication-panel.md).

## Link to conversation

### Configure Link Account To Conversation action call

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**.

5. In the new page, specify the following details:

   | Tab | Field | Value |
   |------------------|------------------|------------------|
   | General | Name       | Link Account To Conversation  |
   | General | Hosted Control | Communication Panel |
   | General | Action     | OmnichannelLinkRecordToConversation | 
   | General | Data | EntityRecordId=\[\[account.Id\]\] <br> EntityPrimaryAttributeValue=\[\[account.name\]\] <br> LiveWorkItemId=\[\[$Context.LiveWorkItemId\]\] <br> EntityLogicalName=account|

6. Save the action call.

### Configure Session Toolbar

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Toolbar** and select **+ New**.

   | Tab | Field | Value |
   |------------------|------------------|------------------|
   | General | Name       | Link Records  |
   | General | Order | 1 |

5. Select **Save** to save the toolbar. After you save the toolbar, the **Buttons** section appears.

6. Select **+ Add New Toolbar Button** in the **Buttons** section.

7. Specify the following in the **New Toolbar Button** page.

   | Tab | Field | Value |
   |------------------|------------------|------------------|
   | General | Name       | Link Account To Conversation  |
   | General | Button Text | Link to conversation |
   | General | Tooltip | Link the account to the conversation. |
   | General | Order | 1 |

8. Select **Save** to save the toolbar button. After you save, the **Actions** section appears.

9. Select **Add Existing Action Call** in the **Actions** section. The **Lookup Records** pane appears.

10. Type the name of the action call in the search box. Select the action call that appears in the list, and select **Add**.

11. Select **Save** to save the changes.

### Add the action call and toolbar to configurations

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Configuration** and then select a configuration from the list.

5. Select the **Hosted Controls, Events and Action Calls** tab.

6. In the **Action Calls** section, select the more commands (...), select **Add Existing Action Calls**, type the name of the **Action Calls** in the search box, and then press **Enter** or select the search icon.

7. Select the action call from the search results and select **Add**.

8. Select the **Toolbars, Window Navigation Rules and Entity Searches** tab.

9. In the **Toolbars** section, select the more commands (...) and select **Add Existing Toolbars**. The **Lookup Records** pane appears. 

10. Type the name of the **Toolbar** in the search box. Select the toolbar that appears in the list, and select **Add**.

11. Select **Save** to save the changes.

## See also

- [Configure Omnichannel Agent Dashboard](configure-agent-dashboard.md)
- [Configure notifications for agents](configure-notification-screen-pop-agents.md)
- [Configure customer summary](configure-customer-summary.md)
- [Configure communication panel for agents](configure-communication-panel.md)
- [Configure session name information using session lines](configure-session-name-information.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]