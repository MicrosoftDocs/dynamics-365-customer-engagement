---
title: Configure intent-based routing (preview)
description:
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 04/17/2025
ms.custom: bap-template
---

# Configure intent-based routing (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

To be written.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- [Customer Intent Agent is enabled](/dynamics365/contact-center/administer/manage-customer-intent-agent#enable-customer-intent-agent).

- [Intent discovery is set up](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intent-discovery-setup).
- [intents are created and in approved state](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intents).
- [Intent groups are created](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intent-groups).

## How intent-based routing works

1. The intent is generated in runtime and matched against one of the intents in intent library (as part of the discovery process). 
   - For cases, the system uses the case title, description, and case notes to determine the intent.
   - For conversations, the agent in Microsoft Copilot Studio generates customer intent based on its interaction with the customer. The same intent is used for routing.

1.	An intent group is identified corresponding to the identified intent.
1.	The conversation is routed through the workstream and queue, and a user group is identified based on the manually curated intent group to user group mapping.
1.	From the identified user group, a matching user is found based on the queue’s assignment strategy.

## Enable intent-based routing

By using generative AI, capture customer intents for incoming conversations and map them to solutions tailored to fulfill requests. The intent groups are manually mapped to one or more user groups.
After you enable intent-based routing, you can control at the line of business-level to route some conversations using intent, and some through the conventional unified routing method. 

## Manage lines of business

A line of business can be a service, product, product category, or the way your company organizes and supports its business activities. You need to add lines of business if you want to enable intent-based routing for a selective set of workstreams and queues. Otherwise, intent-based routing is enabled for the whole organization.
The following entities are associated with a line of business:   

- Intents and intent groups

- User groups (A representative can be a part of many user groups that belong to different lines of business)
- Workstreams
- Queues

### Add a line of business

1.	In the site map of Copilot Service admin center, go to **Intent**, and select **Manage** for **Add Line of business (Optional)**.
1.	On the **Manage Lines of business **page, select **Add Line of business**.
1.	Enter the name and description that indicates the line of business.
1.	Select **Add**. The line of business is listed in the Lines of business table.

### Create rules for cases and converstaions

For every line of business that you have identified, you can create rules for cases and conversations. You can create one rule only (one each for a case and conversation) per line of business.

> [!IMPoRTANT]
> During runtime, for chat and other channels, Copilot and intent-based suggestions must be enabled to determine the intent.

1.	On the **Manage Lines of business** page, in **Case Rules**, select **Create rule**.
1.	On the dialog that appears, enter the rule name and select a line of business.
1.	In **Conditions**, define the conditions for the rules to run. In the rules for conversations, we recommend that you configure the same workstream that’s associated with the line of business. 
1.	Optionally, select **Run backfill**. The system associates past cases with a line of business for intent discovery. This makes sure that intent discovery works properly by tagging past cases with the appropriate line of business.
1.	Save and close.

Repeat the steps for creating rules and conditions for conversations for the lines of business you’d like to.

## Create user groups

A user group can be a part of many intent groups and an intent group can be associated with many user groups.

> [!NOTE]
> Capacity profiles-based assignments only are supported.

1.	On the **Customer Intent Agent (preview)** page, select **Manage** for **Create user groups**.
1.	Select **New user group**.
1.	Enter a group name and description, and then select a line of business.
1.	Do the following:
   - On the **Attributes** tab:
      1.	Select one or more languages in the Language   list. You can expand the categories for the languages and select the applicable ones.
      1. Select the regions that are applicable.
   
         The selections indicate the languages and regions that the user group supports. During runtime, the user group attributes are implicitly matched based on the requirements for the work item. You don't have to write mapping rules for the user group attributes. You can also set the language and regions for each user in the user management page.
      
         The language and region are supported as new out-of-the-box entities. You can configure the list of supported languages and regions as explained here.
   - On the **Users** tab:
      1.	Select **Add**, and in the list that appears, choose the users that you want to add.
      1.	Select **Add**.
      1.	Save the changes.

## Map user groups with intent groups

You must map the user groups with intent groups so that for an incoming conversation, the intent and intent group are determined, and the appropriate user group is identified from the identified intent group.

If multiple conditions in the intent group to user groups mapping match the work item requirement, then the user group is selected based on the order in which they are listed on the **User groups** tab.

If none of the user groups match, the default user group configured for the intent group is selected. You can also set up a fallback user group for a line of business to which a conversation can be routed when no intents or intent groups are identified or fail to match.

1.	On the **Customer Intent Agent (preview)** page, select **Manage** for **Add user groups to intent groups**.
1.	Select an intent group, and on **User groups** tab, select **Add group**.
1.	On **Add user group**, select a user group in the list.
1.	Select the **Default** checkbox if you want to use the selected group when no other user group matches.
1.	Optionally, define the conditions that must match for the user group to be considered. These conditions are evaluated with the language and region settings for the user group.

:::image type="content" source="../media/screenshot-of-manage-intent-groups.png" alt-text="Screenshot of manage intent groups in intent-based routing." lightbox="../media/screenshot-of-manage-intent-groups.png":::

The mapping is channel agnostic. For example, if you want  the same  user group to serve cases and chats and you want to write mapping rules on case and chat attributes, you must write rules addressing both the channels and use an OR operator between the two rule groups as seen in the following screenshot. The mapping rules are optional and by default user groups serve all channels for which intent-based routing is configured.

:::image type="content" source="../media/screenshot-of-rules-for-channels.png" alt-text="Screenshot that shows the OR condition between channels.":::

## Assign queues to lines of business

1.	On the **Customer Intent Agent (preview)** page, select **Manage** for **Assign queues to Lines of business**.
1.	On the **Queues** page, select the queue to edit and on the page that appears, select **Edit** for **Line of business mapping**.
1.	On the pane that appears, select a line of business from the list and save and close. The selected line of business is displayed on the queue page.

## Set up queues for record channel in intent-based routing

In intent-based routing, users aren't required to be part of queues. However, for record channel, a user assigned to the queue item must be a member of the queue, otherwise, the queue item update fails and assignment fails. Learn about how [unified routing affects queue items](../develop/unified-routing-impact-on-APIs.md). Therefore, we recommend that you update your record queues to be public for intent-based routing. If you prefer to use private queues for intent-based routing, make sure that users are added to the user groups and queues.


## Assign workstream to lines of business

You must make sure that the workstreams and their associated queues belong to the same line of business so that the conversations are routed within the same line of business.

1.	On the **Customer Intent Agent (preview)** page, select **Manage** for** Assign workstream to Lines of business**.
1.	On the **Workstreams** page, select the workstream to edit, and on the page that appears, select **Edit for Intent-based routing**.
1.	On the pane that appears, select a line of business from the list and save and close. The selected line of business is displayed on the workstream page.    


## Configure classification rules

Follow the steps in [Configure work classification rulesets](configure-work-classification.md) to set up classification rules to determine the requirements of the work items so that they can be routed to the correct intent group.

You need to write classification rules to enrich live work item with the language and region. The system does an implicit match of language and region attributes during the user group identification stage.

Configure the workstream name in the line of business configuration rules for chat workstreams. Because the chat widget is tightly coupled with the line of business, by specifying the line of business, you can make sure that the chat belongs to the same line of business as its workstream otherwise the chat can end up with a different line of business other than its workstream.

## Configure the assignment method

Follow the steps in [Assignment methods for queues](assignment-methods.md) to select an out-of-the-box assignment method.

> [!NOTE]
> The check for user language and region is implicitly done for the out-of-the-box assignment method.

## Customize the case form to display intent labels

During runtime, to indicate the intent and intent group that the case belongs to, you can customize the case form to display the labels on the **Summary** tab of the case.

1.	In Power Apps, edit the **Case for multisession form** to add the intent and intent group fields. Learn more in [Add or delete columns to a form](/power-apps/maker/model-driven-apps/add-move-or-delete-fields-on-form).
   :::image type="content" source="../media/screenshot-of-multisession-case-intent-attribute.png" alt-text="Screenshot of multisession case form for intent and intent group.":::

1. Import the PopulateIntent script file as a webresource. The script helps fetch the current attributes for the intent and intent group fields and populates them in the UI.
1.	Go to **Form Properties** to link the script and attach it to the **OnLoad** event.

### Runtime behavior

When the service representative opens a case that’s routed through intent, the form displays the fields with the intent data.

:::image type="content" source="../media/screenshot-runtime-intent-intent-group-case-form.png" alt-text="Screenshot of runtime behavior of display of intent and intent group on case for multisession form." lightbox="../media/screenshot-runtime-intent-intent-group-case-form.png":::

### What happens when you save and route or transfer a case

When a service representative uses **Save & Route** on a case to reroute it because the original intent was incorrect or for some other reason, they can select a new intent on the dialog that appears. Otherwise, the system determines the intent anew, and retriggers the routing 

:::image type="content" source="../media/screenshot-save-and-route.png" alt-text="Screenshot of save and route with intent UI.":::

When the representative uses **Add to a queue** to transfer the case to a queue, if the destination queue is intent enabled, the intent is determined again with line of business, intent group, and agent group. The work moves to the chosen destination queue and is assigned to a user from the identified user group. If the destination queue isn’t intent enabled, the case is assigned to the destination queue without any changes.

## Conversation diagnostics

You can view the conversation diagnostics in App Insights. Learn more in [Configure conversation diagnostics (preview)](configure-conversation-diagnostics.md) and [Understand conversation diagnostics (preview)](converation-diagnositcs-subscenarios.md).

### Related information

[Overview of Customer Intent Agent](/dynamics365/contact-center/administer/overview-customer-intent-agent)