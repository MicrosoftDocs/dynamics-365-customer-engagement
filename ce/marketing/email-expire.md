---
title: "Set expiration dates on email messages (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to prevent customer journeys from delivering out-of-date information by assigning an expiration date for one or more email tiles in Dynamics 365 Marketing"
ms.date: 12/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: kamaybac
ms.author: kamaybac
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

# Preview: Set expiration dates for selected email tiles in a customer journey

> [!IMPORTANT]
> This is a preview feature. [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

Some of your customer journeys may include email messages with time-sensitive content, such as a time-limited offer, holiday promotional, or a two-week reminder for an upcoming event. Because contacts might join the journey at any time, you can choose to prevent delivering outdated information by setting an expiration date for one or more selected email messages. Any contact who enters an email tile after its expiration date has past will simply pass through that tile without being sent the message.

> [!NOTE]
> Because this is a preview feature, your administrator must explicitly enable it for your instance to make it available. If you don't see the features described in this topic and would like to use them, then please ask your admin to enable them. However, as mentioned, we don't recommend enabling preview features on production instances. More information: [Enable and configure artificial intelligence features](admin-machine-learning.md)

