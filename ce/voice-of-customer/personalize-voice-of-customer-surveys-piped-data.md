---
title: "Personalize Voice of the Customer for Dynamics 365 survey with piped data | MicrosoftDocs"
description: ""
ms.assetid: e788349d-acc4-4f07-bbf1-2fcc397261fe
keywords: ""
ms.custom:
  - dyn365-VoC
ms.date: 07/26/2017
ms.service: dynamics-365-customerservice
ms.topic: "article"
applies_to: "Dynamics 365 (online)"
redirect_url: /dynamics365/customer-engagement/voice-of-customer/design-basic-survey
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Personalize your Voice of the Customer survey to automatically insert Dynamics 365 data
Use piped data to automatically insert [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] information into your [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] survey. For example, you can use piped data to automatically insert customers' first names into the text on your survey's Welcome screen.  
  
1.  While designing your survey, click the **Edit** button on the question or element you want to add a piped data field to.  
  
2.  At the point in your text where you want to add the piped data field, click the **(Pipe)** box in the formatting menu.  
  
3.  Select the field you want to add. For example, if you want to display the customer's name, select **Customer**.  
  
 This inserts a field into your text. For example, if you selected **Customer**, you would see **_CUSTOMER_PIPED_DATA\_** in your text. So, this line:  
  
 Thank you _CUSTOMER_PIPED_DATA\_ for giving your feedback and helping us improve the service we are able to deliver to you.  
  
 will look like this when a customer named Marie takes your survey:  
  
 Thank you Marie for giving your feedback and helping us improve the service we are able to deliver to you.  
  
