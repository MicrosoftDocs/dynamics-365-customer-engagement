---
title: "Personalize surveys with piped data (Voice of the Customer) | MicrosoftDocs"
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
---
# Personalize surveys with piped data (Voice of the Customer)
Use piped data to automatically insert [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)] information into your Voice of the Customer for Microsoft Dynamics 365 survey. For example, you can use piped data to automatically insert customers' first names into the text on your survey's Welcome screen.  
  
1.  While designing your survey, click the **Edit** button on the question or element you want to add a piped data field to.  
  
2.  At the point in your text where you want to add the piped data field, click the **(Pipe)** box in the formatting menu.  
  
3.  Select the field you want to add. For example, if you want to display the customer's name, select **Customer**.  
  
 This inserts a field into your text. For example, if you selected **Customer**, you would see **_CUSTOMER_PIPED_DATA\_** in your text. So, this line:  
  
 Thank you _CUSTOMER_PIPED_DATA\_ for giving your feedback and helping us improve the service we are able to deliver to you.  
  
 will look like this when a customer named Marie takes your survey:  
  
 Thank you Marie for giving your feedback and helping us improve the service we are able to deliver to you.  
  
 [![Left arrow icon](media/crm-ua-icons-arrowleftbluecircled.png "Left arrow icon")](design-your-survey.md) [Design your survey](design-your-survey.md)  
  
 [Routing rules](create-a-response-routing-rule-in-a-survey.md) [![Right arrow icon](media/crm-ua-icons-arrowrightbluecircled.png "Right arrow icon")](create-a-response-routing-rule-in-a-survey.md)  
  
## See Also  
 [Get feedback with Voice of the Customer for Microsoft Dynamics 365 surveys](create-voice-of-customer-survey.md)