---
title: Configure intent-based routing (preview)
description: Learn how to configure and manage intent-based routing within your organization to optimize your customer service operations and improve overall customer satisfaction.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 07/17/2025
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Configure intent-based routing (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Intent-based routing is an advanced approach that uses generative AI to enhance the efficiency and accuracy of routing customer interactions. By capturing customer intents from incoming conversations and mapping them to appropriate solutions, intent-based routing makes sure that customer queries are directed to the most suitable service representatives. This method allows for a more dynamic and responsive customer service experience, moving beyond traditional static routing rules. The system organizes intents into intent groups. The intent groups are then mapped to user groups with the necessary expertise to address the specific intents.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- [Customer Intent Agent is enabled](/dynamics365/contact-center/administer/manage-customer-intent-agent#enable-customer-intent-agent).
- [Lines of business are created](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-lines-of-business).
- [Intent discovery is set up](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intent-discovery-setup).
- [Intents are created and in approved state](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intents).
- [Intent groups are created](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intent-groups).

## How intent-based routing works

1. The intent is generated in runtime and matched against one of the intents in intent library (as part of the discovery process). 
   - For cases, the system uses the case title, description, and case notes to determine the intent.
   - For conversations, the agent in Microsoft Copilot Studio generates customer intent based on its interaction with the customer. The same intent is used for routing.

1. An intent group is identified corresponding to the identified intent.
1. The conversation is routed through the workstream and queue, and a user group is identified based on the manually curated intent group to user group mapping.
1. From the identified user group, a matching user is found based on the queue’s assignment strategy.

## Enable intent-based routing

You can use generative AI to capture customer intents for incoming conversations and map them to solutions tailored to fulfill requests. The intent groups are manually mapped to one or more user groups.

After you enable intent-based routing, you can control at the line of business-level to route some conversations using intent, and some through the conventional unified routing method.

If you want to enable intent-based routing for a selective set of workstreams and queues, add lines of business. Otherwise, intent-based routing is enabled for the whole organization.

## Create user groups

A user group can be a part of many intent groups and an intent group can be associated with many user groups.

> [!NOTE]
> Capacity profiles-based assignments only are supported.

1. On the **Customer Intent Agent (preview)** page, select **Manage** for **Create user groups**.
1. Select **New user group**.
1. Enter a group name and description, and then select a line of business.
1. Do the following:
   - On the **Attributes** tab:
      1. Select one or more languages in the Language list. You can expand the categories for the languages and select the applicable ones.
      1. Select the regions that are applicable.
   
         The selections indicate the languages and regions that the user group supports. During runtime, the user group attributes are implicitly matched based on the requirements for the work item. You don't have to write mapping rules for the user group attributes. You can also set the language and regions for each user in the user management page.
      
         The language and region are supported as new out-of-the-box entities.
   
   - On the **Users** tab:
      1. Select **Add**, and in the list that appears, choose the users that you want to add.
      1. Select **Add**.
      1. Save the changes.

## Map user groups with intent groups

You must map the user groups with intent groups so that for an incoming conversation, the intent and intent group are determined, and the appropriate user group is identified from the identified intent group.

If multiple conditions in the intent group to user groups mapping match the work item requirement, then the user group is selected based on the order in which they're listed on the **User groups** tab.

If none of the user groups match, the default user group configured for the intent group is selected. You can also set up a fallback user group for a line of business to which a conversation can be routed when no intents or intent groups are identified or fail to match.

1. On the **Customer Intent Agent (preview)** page, select **Manage** for **Add user groups to intent groups**.
1. Select an intent group, and on **User groups** tab, select **Add group**.
1. On **Add user group**, select a user group in the list.
1. Select the **Default** checkbox if you want to use the selected group when no other user group matches.
1. Optionally, define the conditions that must match for the user group to be considered. These conditions are evaluated with the language and region settings for the user group.

   :::image type="content" source="../media/screenshot-of-manage-intent-groups.png" alt-text="Screenshot of manage intent groups in intent-based routing." lightbox="../media/screenshot-of-manage-intent-groups.png":::

The mapping is channel agnostic. For example, if you want the same user group to serve cases and chats and you want to write mapping rules on case and chat attributes, you must write rules that address both the channels and use an OR operator between the two rule groups, as seen in the following screenshot. The mapping rules are optional, and by default, user groups serve all channels for which intent-based routing is configured.

  :::image type="content" source="../media/screenshot-of-rules-for-channels.png" alt-text="Screenshot that shows the OR condition between channels.":::

## Assign queues to lines of business

1. On the **Customer Intent Agent (preview)** page, select **Manage** for **Assign queues to Lines of business**.
1. On the **Queues** page, select the queue to edit and on the page that appears, select **Edit** for **Line of business mapping**.
1. On the pane that appears, select a line of business from the list and save and close. The selected line of business is displayed on the queue page.

## Set up queues for record channel in intent-based routing

In intent-based routing, users aren't required to be part of queues. However, for record channel, a user assigned to the queue item must be a member of the queue, otherwise, the queue item update fails and assignment fails. Learn about how [unified routing affects queue items](../develop/unified-routing-impact-on-APIs.md). Therefore, we recommend that you update your record queues to be public for intent-based routing. If you prefer to use private queues for intent-based routing, make sure that users are added to the user groups and queues.

|Routing type | Queue Type           | Users Association             |
|---|----------------------|----------------------------------------------------|
| Intent-based routing | Public <br> recommended approach |Add users to user groups only|
|Intent-based routing | Private  | Add users to both user groups and queues |
| Traditional routing | Public   |Add users to both user groups and queues  |
|Traditional routing| Private<br>Recommended approach   |  Add users to both user groups and queues |

## Assign workstream to lines of business

You must make sure that the workstreams and their associated queues belong to the same line of business so that the conversations are routed within the same line of business.

1. On the **Customer Intent Agent (preview)** page, select **Manage** for **Assign workstream to Lines of business**.
1. On the **Workstreams** page, select the workstream to edit, and on the page that appears, select **Edit for Intent-based routing**.
1. On the pane that appears, select a line of business from the list and save and close. The selected line of business is displayed on the workstream page.    

## Configure classification rules

Follow the steps in [Configure work classification rulesets](configure-work-classification.md) to set up classification rules to determine the requirements of the work items so that they can be routed to the correct intent group.

You need to write classification rules to enrich live work item with the language and region. The system does an implicit match of language and region attributes during the user group identification stage.

## Configure the assignment method

Follow the steps in [Assignment methods for queues](assignment-methods.md) to select an out-of-the-box assignment method. Even though users aren't required to be a part of the queues, you can continue to configure the assignment strategy for the queues. During runtime, after a queue is identified, the system determines the user group. Then, based on the assignment strategy configured in the queue, the conversation is assigned to a user from the user group. 

> [!NOTE]
> The check for user language and region is implicitly done for the out-of-the-box assignment method.

## Customize the case form to display intent labels

You can customize the case form to display the intent and intent group that the case belongs to. These fields aren't available out of the box, and you must manually create and add them to display on the **Summary** tab of the case.

1. In Power Apps, edit the **Case for multisession form** to add the intent and intent group fields. Learn more in [Add or delete columns to a form](/power-apps/maker/model-driven-apps/add-move-or-delete-fields-on-form).
   
    :::image type="content" source="../media/screenshot-of-multisession-case-intent-attribute.png" alt-text="Screenshot of multisession case form for intent and intent group.":::

1. Download and import the [intentLib.js](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/intent-based-routing/intentLib.js) script file as a webresource and add it to the form as a form library. The script helps fetch the current attributes for the intent and intent group fields and populates them in the UI. Learn more in [Create or edit model-driven app web resources to extend an app](/power-apps/maker/model-driven-apps/create-edit-web-resources).

1. Go to **Form Properties** to link the script and the attach PopulateIntent function to the **OnLoad** event of the form.

### Runtime behavior

When the service representative opens a case that’s routed through intent, the form displays the fields with the intent data.

:::image type="content" source="../media/screenshot-runtime-intent-intent-group-case-form.png" alt-text="Screenshot of runtime behavior of display of intent and intent group on case for multisession form." lightbox="../media/screenshot-runtime-intent-intent-group-case-form.png":::

### What happens when you save and route or transfer a case

When a service representative uses **Save & Route** on a case to reroute it because the original intent was incorrect or for some other reason, they can select a new intent on the dialog that appears. Otherwise, the system determines the intent anew, and retriggers the routing. 

:::image type="content" source="../media/screenshot-save-and-route.png" alt-text="Screenshot of save and route with intent UI.":::

When the representative uses **Add to a queue** to transfer the case to a queue, if the destination queue is intent enabled, the intent is determined again with line of business, intent group, and agent group. The work moves to the chosen destination queue and is assigned to a user from the identified user group. If the destination queue isn’t intent enabled, the case is assigned to the destination queue without any changes.

### Fallback options

If the intent-based routing fails to identify a user group, the fallback options are as follows:
- **No line of business determined**: Routing happens via regular unified routing flow.
- **Line of business determined, intent not determined**: The conversation is assigned to the fallback user group configured at the line of business level.
- **Line of business and intent determined, intent group not determined**: The conversation is assigned to the fallback user group configured at the line of business level.
- **Line of business, intent, and intent group determined, but no matching user group found**: The conversation is assigned to the default user group configured at the intent group level.

## Conversation diagnostics

You can view the conversation diagnostics in App Insights. Learn more in [Configure conversation diagnostics (preview)](configure-conversation-diagnostics.md) and [Understand conversation diagnostics (preview)](conversation-diagnostics-subscenarios.md).

### Considerations

- The workstreams and representatives must be configured with capacity profiles only for assignment.
- Overflow actions like transfer to queue are supported but assignment uses the identified user group to assign to a representative.
- Routing to preferred representatives isn't supported.
- Skill-based routing isn't supported.

### Related information

[Overview of Customer Intent Agent](/dynamics365/contact-center/administer/overview-customer-intent-agent)  
