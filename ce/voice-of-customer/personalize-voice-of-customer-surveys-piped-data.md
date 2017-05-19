---
title: "Personalize Voice of the Customer for Dynamics 365 survey with piped data | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-01"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics CRM Online"
ms.assetid: fb8dc2de-eff2-459f-9315-1c4a98db3d3b
caps.latest.revision: 8
author: "brycho"
ms.author: "brycho"
manager: "brycho"
---
# Personalize your Voice of the Customer survey to automatically insert Dynamics 365 data
Use piped data to automatically insert [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] information into your Voice of the Customer for Dynamics 365 survey. For example, you can use piped data to automatically insert customers' first names into the text on your survey's Welcome screen.  
  
1.  While designing your survey, click the **Edit** button on the question or element you want to add a piped data field to.  
  
2.  At the point in your text where you want to add the piped data field, click the **(Pipe)** box in the formatting menu.  
  
3.  Select the field you want to add. For example, if you want to display the customer's name, select **Customer**.  
  
 This inserts a field into your text. For example, if you selected **Customer**, you would see **_CUSTOMER_PIPED_DATA\_** in your text. So, this line:  
  
 Thank you _CUSTOMER_PIPED_DATA\_ for giving your feedback and helping us improve the service we are able to deliver to you.  
  
 will look like this when a customer named Marie takes your survey:  
  
 Thank you Marie for giving your feedback and helping us improve the service we are able to deliver to you.  
  
