---
title: "Create a project quote (Dynamics 365 for Project Service Automation) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "project-service-automation"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "mduelae"
ms.assetid: 38361a18-b034-45ad-9494-15bf81feffaf
caps.latest.revision: 13
ms.author: "mkaur"
manager: "brycho"
---
# Create a project quote (Project Service Automation)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Creating a quote is similar to creating an opportunity. While an opportunity is for internal information, a quote is what you send out to your potential customers. You can create one or more quotes for each opportunity. When you’re creating a quote to send to your potential customer, you’re in the **Propose** stage of your project.  
  
1.  To create a quote from an opportunity, go to **Project Service > Opportunities**, and then click the opportunity you want to create a quote for.  
  
2.  Click **Next Stage** on the right side of the process bar, and then either select an existing quote or click **Create** to create a new quote.  
  
3.  In the **Summary** area, change any information as necessary.  
  
4.  Click **Save** to create the quote so you can continue editing it.  
  
5.  To add a product to the quote, click **New** under **Product-based Lines** in the **Quote Lines** area. Select an item under **Product Name**, and then specify the quantity, sales price, and quoted amount.  
  
6.  To add a project estimate to the quote, click **+** under **Project-based Lines** in the **Quote Lines** area. Enter the name, budget amount, and project, if available. If you need to create a project with a work breakdown structure to come up with an estimate, see [Create a project](../project-service/create-project.md).  
  
7.  When you’re done editing, click the **Save** button at the bottom right of the screen.  
  
8.  When you’re ready to send the quote to your customer, click **More** (…), click **Run Report**, and then click **Quote**. Save the report as a [!INCLUDE[pn_ms_Word_short](../includes/pn-ms-word-short.md)] document, edit as necessary, and send the quote to your customer.  
  
9. If your customer accepts your quote, click **Close as Won** at the top of the **Quote** screen. If your customer wants you to change some items, follow this entire process again to create a new quote. If your customer decides not to use your services at this time, click **Close as Lost** at the top of the **Quote** screen.  
  
 When you close a quote as won, your project moves on to the **Contract** stage, and the **Project Contract** screen prompts you to create a contract for this project.  
  
### See Also  
 [Account Manager Guide](../project-service/account-manager-guide.md)
