---
title: "Select the audience source for real-time journeys (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to select the audience source for real-time journeys in Dynamics 365 Marketing."
ms.date: 03/24/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
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

# Select the audience source for real-time journeys

Audience configuration is the place where you can set up the data sources for your audience. For Public Preview, the entities supported are **Contact**, **Lead** and **Customer profile**.  

> [!div class="mx-imgBorder"]
> ![compliance settings](../media/audience-configuration.png)

For Contacts and Leads there are default recipient fields set up, both for email and phone number. These fields will be put into the "Send-to" field be default. You can also add additional recipient fields or change the default one.
For Customer Profiles, there's no default fields set. This is up to you, to tell the system which fields should be used when email or text message should be sent.

In order to make changes to the audience, click on the data source and review information on the right pane.

> [!div class="mx-imgBorder"]
> ![compliance settings](../media/audience-lead.png)
> 
You can change the default recipient, as well as add more recipient fields. These fields will be available for selection when adding email or sms tile to the customer journey..

> [!div class="mx-imgBorder"]
> ![compliance settings](../media/audience-email-tile.png)
> 
As you can see, there's a default value displayed in the "Send-to" field, but you can also select any other recipient field from the drop-down menu.

[!Important]
For Contacts, only one email address can be used as a recipient field. This is done to remove ambiguity for consent (as Contact record may store several email addresses and one cosnent for all, while in real-time marketing we use email-based consent model. More details avaiable on **Compliance settings** page) 
