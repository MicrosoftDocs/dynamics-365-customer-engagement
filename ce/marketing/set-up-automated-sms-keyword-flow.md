---
title: "Set up an automated text message keyword flow (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to set up an automated text message keyword flow in real-time journeys in Dynamics 365 Marketing."
ms.date: 12/16/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Set up an automated text message keyword flow

Text messages allow you to quickly communicate with your customers. But to continue the conversation effectively, you need to be able to act on customer responses. Keyword flows allow you to branch journeys based on customer replies to text messages.

## Add SMS keywords to a text message 

Adding SMS keywords in your text message allows you to use them in your customer journey to branch it based on your customer’s response to your text messages.  
 
To add a keyword to a text message: 
 
1. Select the keyword icon. 
2. Type the keyword that you’d like to add. 
3. Select it from the list if it has been used previously in the journey or select the **New keyword** button to create it. 

The following screenshot shows how to add SMS keywords in your text message. 

> ![Add SMS keywords screenshot](media/add-sms-keywords.png "[Add SMS keywords screenshot")
 
All keywords created through the SMS editor are also added to the [SMS keywords page](manage-sms-keywords.md ). 

## Set up the keyword flow in a journey

Using the **Send a text message** tile in your journey, you can define custom keywords that will direct a customer's journey based on their responses. You can even set a default text message reply for unrecognized keywords.

To create a keyword flow:

1. Select the **Send a text message** tile and choose a text message template that includes keywords. In this example, the sender has created a keyword called **CONFIRM** that allows the recipient to confirm a doctor's appointment.
1. Select **create branches** to automatically branch your customer journey based on the keywords.

    > [!div class="mx-imgBorder"]
    > ![Create branches screenshot](media/create-branches.png "Create branches screenshot")

1. Specify the next actions for each keyword and branch.

    > [!div class="mx-imgBorder"]
    > ![Specify keyword actions screenshot](media/keyword-actions.png "Specify keyword actions screenshot")

1. Choose how strict the keyword identification method should be.
 
    > [!div class="mx-imgBorder"]
    > ![Keyword identification screenshot](media/keyword-identification-method.png "Keyword identification screenshot")

Finally, you can create additional branches and select keywords from the text message keywords page that weren't included in the text message template, in case you’d like to include branching for keywords that were communicated to customers in past text messages.
