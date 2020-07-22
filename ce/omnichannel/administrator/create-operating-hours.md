---
title: "Create and manage operating hours | MicrosoftDocs"
description: "Instructions to create and manage operating hours in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 08/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Create and manage operating hours

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Introduction

Operating hours define the hours when your organization's customer support team is active and available to serve customers. By setting up operating hours, you help your customers and your organization work together to resolve issues. 

The following options are available for setting the operating hours schedules:

- Customize schedules to show non availability on public holidays that are otherwise operating hours.
- Accommodate change of timings for daylight saving time twice an year.
- Set up separate schedules for agents, bots, and queues

After you create an operating hour record, you must add it to the **Design** tab of the appropriate chat widget to control the display of the widget.

## Create an operating hour record

1. Sign in to Omnichannel Administration.

2. Go to **Settings** \> **Operating Hours**.

3. Select **New**. The **New Operating Hour** page is displayed.

4. On the **General** tab, provide the following information:

    - **Name**: Enter a name for the operating hour record.
    - **Owner:** Accept the default value or search to specify a different owner.
    - **Description**: Enter an optional description of the operating hour record.
5. Select **Save**. The **Working Hours** tab is displayed.
   
    > ![Create an operating hour record](../media/oc-create-operating-hour.png "Create an operating hour record")

6. Select **Working Hours**. The calendar view is displayed.
7. Select **New** > **Working hours** to define the  operation hour schedule.
8. Select Save.

## Add operating hours to chat widget

1.	Open the chat widget to which you want to add operating hours.
2.	Go to the **Design** tab.
3.	In the **Operating hours** field, browse and select the operating hour record. The chat widget is displayed during the hours specified in the selected operating hour record.

    > [!div class=mx-imgBorder]
    > ![Add operating hours in a chat widget](../media/oc-chat-widget-design-tab.png "Add operating hours in a chat widget")

### See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Create quick replies](create-quick-replies.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)
