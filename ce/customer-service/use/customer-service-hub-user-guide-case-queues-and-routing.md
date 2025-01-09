---
title: Manage case queues and route cases
description: Understand cases and SLA in Customer Service Hub for Dynamics 365 Customer Service.
ms.date: 12/13/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Manage case queues and route cases

Customer Service allows you to add a case to a queue, save case records, and route them to a queue.

## Add a case to a queue  

If you think another group in your team has expertise on the subject, you can move the case to a queue so that someone else can pick it up.  

To add a case to a queue, perform the following steps:

1. [!INCLUDE[proc_service_cases](../../includes/proc-service-cases.md)]  

2. In the list of cases, select the case that you want to add to a queue.  

3. On the command bar, select **Add to Queue**.  

5. In the **Queue** field, select the queue that you want to add the case to, and then select **Add**.

   If a case is already added to a queue, the **Queue** field displays the current queue by default. 

     :::image type="content" source="../media/queue-display-name-after.png" alt-text="Screenshot of the default add to queue dialog with queue displayed" lightbox="../media/queue-display-name.png":::

   The lookup for the **Queue** field displays only the queues that are configured for a specific entity. Voice and messaging queues aren't displayed in the lookup results since cases can't be added to those queues.

     :::image type="content" source="../media/add-to-queue-display-after.png" alt-text="Screenshot of the lookup displaying only relevant queues" lightbox="../media/add-to-queue-display.png":::


6. Select the queue you want to add the case to, and then select **Add**.  

To know more about queues, see [Work with queues](work-with-queues.md).

## Save and route a case  

 To save a case record and route it to a queue in a single action, use the **Save & Route** option.  

1.  From the list of cases, open a case record.  

2.  Make any changes, and on the command bar, select **Save & Route**.  

3.  In the **Route Case** dialog, select **Route**.  

     The case will be routed based on the active routing rule set.  

    > [!IMPORTANT]
    >  The **Save & Route** button is available only on active cases.  

### Related information

[Learn the basics of the Customer Service Hub ](../implement/customer-service-hub-user-guide-basics.md)  
[Use the Main form and its components](../../customerengagement/on-premises/customize/use-main-form-and-components.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
