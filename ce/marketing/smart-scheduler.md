---
title: "Improve email engagement with a smart scheduler (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to use smart scheduling to let the AI find the best times and days to deliver email messages to each contact in Dynamics 365 Marketing"
keywords:
ms.date: 06/12/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
ms.assetid: 33934b6f-8d55-4a8e-9593-9de34af2b854
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Preview: Use smart scheduler to help improve email engagement

> [!IMPORTANT]
> This is a preview feature. [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

The smart scheduler feature applies artificial intelligence to identify the days and times when each contact is most likely to be actively reading their email. The feature has two main components:

- **Auto scheduler for customer journeys**: enables customer journeys to schedule message deliveries to each individual contact automatically based on the _best time to email_ calculated by the AI for that contact.
- **Detailed email interaction results**: provide informative heat-map graphs that summarize the email-interaction trends for each individual contact. The following insights are provided here:
  - **Email open times**: shows how often the contact opened one of your emails for each hour of the day on each day of the week. This can indicate the days and times when the contact is usually using their email client.
  - **Email reaction times:** shows how quickly the contact opened a message in relation to the hour of the day and day of the week it was delivered.
  - **Best time to email** : displays a matrix that indicates which times on which days of the week are probably best for sending a message to the current contact. For each contact, the AI analyzes their reaction-time and open-time results and combines them with data collected for similar contacts to generate the overall recommendations.

> [!NOTE]
> Before you can use smart scheduling, your admin must enable and configure it. If you don't see the features described in this topic, then please ask your admin to enable smart scheduling for your site. More information: [Enable and configure artificial intelligence features](admin-machine-learning.md)

## Create a customer journey that automatically sends messages at the optimal time

When you use manual scheduling, the customer journey processes all the contacts in its target segment at once and delivers messages according to its run schedule without regard to each contact's interaction history. However, with smart scheduling, you can now leverage the AI to apply delivery times optimized for each individual recipient. This can often help improve your open rates.

To create a journey that uses optimized delivery times:

1. Go to **Marketing** > **Marketing execution** > **Customer journeys**, and then either create or open a journey.

1. Design your journey as usual but add a scheduler tile in front of each email tile where you want to use smart scheduling.

    ![Place a scheduler before your email tile](media/smart-scheduler-cj-tiles.png "Place a scheduler before your email tile")

1. Select a scheduler tile and open the **Properties** tab.

    ![Set scheduler properties](media/smart-scheduler-cj-properties.png "Set scheduler properties")

    Make the following settings:

    - Set the **Smart scheduling** slider to "on" to enable the smart scheduler.
    - To use a date-and-time schedule (in which all contacts will be forwarded by the scheduler on the same day(s), regardless of when they arrive (such as on October 12, 2019, &plusmn;3 days)) do the following:
        - Set the **Scheduler type** to **Date and time**.
        - Set the **Date and time** to the approximate date and time you'd like to send messages to these contacts.
        - Set the start and end sliders of the **Optimize sending window** to establish a date range during which to forward the contacts waiting here. The AI will check the email interaction record for each individual contact and use that information to choose the best date and time within this defined time window.
    - To use a duration schedule (in which each contact waits here for an amount of time related to the day they entered the tile (such as 7 &plusmn;3 days)) do the following:
        - Set the **Scheduler type** to **Duration**.
        - Set the **Duration** to the approximate time that contacts should wait here. Specify both an integer and a unit (hours, days, weeks, or months).
        - Set the start and end sliders of the **Optimize sending window** to establish a date range during which to forward the contacts waiting here. The AI will check the email interaction record for each individual contact and use that information to choose the best date and time within this defined time window.

1. Repeat the previous step for each scheduler in your journey.

## View email interaction details and delivery recommendations for a contact

To see information about when a specific contact tends to open your messages, how long it takes them to open them, and advice for the best time to send to them:

1. Go to **Marketing** > **Customers** > **Contacts** to open your list of contacts.
1. Find and select the contact you want to analyze.

1. Open the **Insights** tab and then select **Email open times** from the tab navigator. This page includes three graphs that summarize how and when this contact interacts with your emails, plus a graph that shows the best time to email to this contact based on those results.

    ![Enter the keyword name](media/smart-scheduler-insights.png "Enter the keyword name")

1. Read the **Email open times** graph as follows:

    - The x-axis indicates the hours of day.
    - The y-axis indicates the days of the week.
    - Colored squares at each day/time intersection indicate how often the contact opened a message at that day and time. The darker the square, the more often the contact opened a message at that time.

1. Read the **Email reaction time** graph as follows:

    - The x-axis indicates the hours of day.
    - The y-axis indicates the days of the week.
    - Colored squares at each day/time intersection indicate how long the contact typically takes to open a message delivered at that day and time. The darker the square, the faster the contact tends to open messages delivered at that day and time.

1. Read the **Best time to email** matrix as follows:

      - The x-axis indicates the hours of day.
      - The y-axis indicates the days of the week.
      - Colored squares at each day/time intersection indicate the days and times that the AI thinks are best for delivering to this contact. The darkest squares indicate the days and times that the AI thinks are best for delivering to this contact, and the lightest squares are worst. Most day/time combinations are in between, but the darker the better.

When you choose to auto-schedule email delivery, the system will use these results to decide when to deliver to each contact.
