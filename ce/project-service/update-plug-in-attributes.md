---
title: Update plug-in attributes to include new pricing dimensions
description: This topic provides information about updating plug-in attributes for pricing dimensions.
author: Rumant
manager: kfend
ms.custom: 
  - dyn365-projectservice
ms.date: 11/19/2018
ms.topic: article
ms.prod: Project Service
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365PS
  - ProjectOperations
---


# Update plug-in attributes to include new pricing dimensions

> [!NOTE]
> If you are not using the Project Service Automation (PSA) Quoting and Contracting features, you can skip this topic.

This topic assumes that you have completed the procedures in the topics, [Create custom fields and entities](create-custom-fields-entities.md), [Add custom fields to price setup and transactional entities](field-references.md), and [Set up custom fields as pricing dimensions](set-up-pricing-dimensions.md). If you haven't completed those procedures, go back and complete them and then return to this topic.

When a quote line detail is created on the **Quote Line** page for a project quote line, the system creates two estimate lines in the background -- one line for the cost side of the estimate and one for sales side. This is the same  for project contract lines.

When you make a change to the quantity or a field on the cost side, that change is propagated to the sales side. This is possible because of the following plug-ins that must be re-registered after a change to pricing dimensions.

- PreOperationContractLineDetailUpdate - Updates **msdyn_orderlinetransaction**.
- PreOperationQuoteLineDetailUpdate - Updates **msdyn_quotelinetransaction**.

The following steps walk you through the process of registering the plug-ins.

1. Open the **PluginRegistrationTool** and connect to your online instance.
2. Click **Search** and search for the plug-in to be updated.

 ![Screenshot of the search tree](media/PRT-1.png)

3. After the plug-in is found, select it and then click **Select on Main Form**.

4. Select the step of the plug-in to be updated, right-click, and then select **Update**.

 ![Screenshot of the plug-in to be updated](media/PRT-2.png)
 
5. In the update window, click the ellipsis (**...**) in the filtering attributes.

 ![Screenshot of the Update existing step config information](media/PRT-3.png)
 
6. Select the pricing attribute check boxes.

 ![Screenshot showing checkbox selection for pricing attributes](media/PRT-4.png)

7. Click **OK** to close the page and then select **Update Step**.

 ![Screenshot showing the “Update Step” button](media/PRT-5.png)
 
8. Repeat this process for the second plug-in, **PreOperationQuoteLineDetail - Update of msdyn_quotelinetransaction**.

9. Close the plug-in registration tool.

