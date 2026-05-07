---
title: Use the assistant to guide customer communications
description: Use the assistant to stay on top of your day through insight cards that provide tailored and actionable insights. 
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to 
ms.date: 04/30/2026
ms.custom: bap-template
---

# Use the assistant to guide customer communications

The assistant helps you stay on top of your customer communications. By analyzing your interactions and activities with customers, the assistant displays actionable insight cards to ensure you never miss any important activities with your customers. Here are some ways the assistant reminds you of upcoming activities:  

- It evaluates your communications and notifies you when a contact or account is inactive.
- It identifies email messages that might be waiting for a reply.
- It alerts you when an opportunity is nearing its close date.

## Prerequisites

Your administrator must enable the assistant before you can try it. For complete details about prerequisites, how to enable the feature, and how to set it up, see [Configure the assistant](configure-assistant.md).

## How and where the assistant helps

The assistant works by analyzing the data at its disposal and generating a collection of insight cards. Each card includes a message that summarizes the content of the card and presents a set of actions. The assistant sorts the cards by priority and filters them for your current context. You can access the assistant in a variety of ways in the Sales Insights app.

> [!NOTE]
> The locations where you access the assistant might vary depending on the configuration set by your administrator. 

- **Navigation bar**: When you select the bulb icon to open the assistant, a pane displays insight cards as shown in the following example.

    :::image type="content" source="media/assistant-widget-navigation-bar.png" alt-text="Screenshot of the assistant widget through the navigation bar." lightbox="media/assistant-widget-navigation-bar.png":::

- **Dashboards**: Go to your dashboard and the **Assistant** widget is displayed in the **Sales Activity Social Dashboard** view. 

- **Entities**: An assistant widget displays insight cards related to the following entities: accounts, contacts, leads, opportunities, and cases. The following image is an example of an assistant widget displayed on an entity.

    :::image type="content" source="media/assistant-widget-entities.png" alt-text="Screenshot of the assistant widget on an entity record." lightbox="media/assistant-widget-entities.png":::

## What cards do I see?

- When you open the assistant by using the navigation bar or dashboard, you see the cards that you own or are part of a team that owns the card.

   > [!NOTE]
   > Meeting cards are special and displayed to users who are either the owner, organizer, or an attendee in the meeting.

- When you open the assistant through an entity record, you see the cards that belong to the record or to related records. The list of related records varies from one entity to another:
   -	**Account**: Account and its related contacts, opportunities, and incidents.
   -	**Opportunity**: Opportunity and its related contacts.
   -	**Incident**: Incident and its related contacts, and accounts.
   -	**Lead**: Lead and its related contacts.
   -	**Custom Entity**: Related accounts and contacts.
   -	**All other entities**: The entity itself only.

## How are insight cards categorized?

Insight cards are categorized either as notifications that need immediate attention, or insights that provide information to be acted on later.

- **Notifications** display insight cards about your upcoming and past-due items and events. They include **upcoming meetings** cards for any meetings scheduled for the day and **reminders** for items that require your attention.

   > [!NOTE]
   > Any custom insight cards created by your organization through Assistant Studio are displayed as reminders.

- **Insights**: Displays suggestions based on AI-driven models for things that require your attention. For example, a card might highlight an email with a negative sentiment that could put an opportunity at risk, suggest ways to prioritize an opportunity, suggest a cross-sale, or prompt you to look at recent items that have been auto-captured.

## Characteristics of insight card categories

By default, the assistant displays the top five insight cards for upcoming meetings, reminders, and insights. Select **Show more** to view more available cards. The heading displays the total number of insight cards that are available for you or for the record you're associated with in each category.

In this example, you're viewing the **reminders** category. The heading specifies that there are 13 reminders available. The latest five are displayed, along with summary information about them. 

:::image type="content" source="media/assistant-reminders-section.png" alt-text="Screenshot of the reminder section." lightbox="media/assistant-reminders-section.png":::

To view complete details of the activity, select the card. In this example, you select the meeting **Stage changed**. You can select **Open** to view more details.

:::image type="content" source="media/assistant-reminders-section-stage-chnaged.png" alt-text="Screenshot of the Stage changed card with details." lightbox="media/assistant-reminders-section-stage-chnaged.png":::

You can perform actions such as open, snooze, dismiss, like, or dislike on the card. The following section describes these actions.

## Elements of an insight card

When you open the assistant, it displays the name and basic description of each card. Select and open the card to view further details. Typically, a card consists of the elements illustrated in the following image.

:::image type="content" source="media/assistant-elements-of-an-insight-card.png" alt-text="Screenshot of the elements of an insight card." lightbox="media/assistant-elements-of-an-insight-card.png":::

1. **Main content area**: Shows the title of the record the card refers to, its summary, card type, and other basic information.

1. **Actions area**: Provides convenient links to help you complete whatever action the card is recommending. The type of links and number of links (up to two) vary by card type. For more information, see [Insight cards reference](action-cards-reference.md).

1. **Snooze**: The snooze time varies by card type. All the high priority and cards of type Today are snoozed for one hour, and all other cards are snoozed for 24 hours. After the snooze time expires, the card is visible again.

1. **Dismiss**: Select this button to dismiss the card permanently, regardless of whether you completed the action it recommends.

   > [!NOTE]
   > - When you snooze or dismiss a card, a confirmation message is displayed for a specified time. If you don't undo the action before the time expires, the card is automatically snoozed or dismissed. You can configure how long to display the confirmation message. For more information, see [Configure Sales Insights Assistant](configure-assistant.md).
   > - After a certain period of time, insight cards are automatically dismissed if no action is performed on the cards.

1. **Feedback**: Helps you give feedback about whether the card was useful for you. The feedback helps Microsoft and your organization administrators improve the card experience and make it more helpful for you. For more information, see [View card usage metrics](edit-insight-cards.md#view-card-usage-metrics).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Configure the assistant](configure-assistant.md)  
[Turn on or off the insight cards](turn-on-off-insight-cards.md)  
[Insight cards reference](action-cards-reference.md)  
