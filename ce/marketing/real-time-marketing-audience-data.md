---
title: "Select the audience source for real-time journeys (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to select the audience source for real-time journeys in Dynamics 365 Marketing."
ms.date: 04/23/2021
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

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Audience configuration allows you to manage your audience data source. Real-time marketing currently supports **Contact**, **Lead**, and **Customer profile** entities.  

> [!div class="mx-imgBorder"]
> ![compliance settings](../media/audience-configuration.png)

Contacts and Leads have default recipient fields set up for emails and phone numbers. The values from these fields are automatically populated in the *Send-to* field. You can modify the default settings by adding additional recipient fields or changing the default field content.

Customer Profiles have no default fields set. You can choose which fields from a Customer Profile should be used when sending an email or text message.

To make changes to the audience configuration, select a data source and review the information in the right pane.

> [!div class="mx-imgBorder"]
> ![compliance settings](../media/audience-lead.png)

You can change the default recipient or add more recipient fields. You can select any of the fields you added when adding an email or SMS tile to a customer journey.

> [!div class="mx-imgBorder"]
> ![compliance settings](../media/audience-email-tile.png)

A default value is displayed in the *Send-to* field, but you can select any other recipient field from the drop-down menu.

> [!Important]
> For Contacts, only one recipient email address can be used. This is done to remove consent ambiguity. In outbound marketing, a Contact record may store several email addresses with one consent for the entire contact. But in real-time marketing, consent is given per each email address. Learn more in [Compliance settings](real-time-marketing-compliance-settings.md).