---
title: "Cases to queues and routing in Customer Service Hub | MicrosoftDocs"
description: "Understand cases and SLA in Customer Service Hub for Dynamics 365 Customer Service."
ms.date: 02/01/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Case queues and routing

Customer Service Hub provides you with the ability to add a case to a queue, and save case records and route them to a queue.

## Add a case to a queue  

If you think another group in your team has expertise on the subject, you can move the case to a queue so that someone else can pick it up.  

**To add a case to a queue**

1. [!INCLUDE[proc_service_cases](../includes/proc-service-cases.md)]  

2. In the list of cases, select the case that you want to add to a queue.  

3. On the command bar, select **Add to Queue**.  

4. The **Queue** field displays the queue the case is currently added to. The **Lookup** displays only queues that are configured for the specific entity. The lookup only displays queues that cases can be added to. Voice and messaging queues aren't displayed.

6.   Select the queue you want to add the case to, and then select **Add**.  

To know more about queues, see [Work with queues](work-with-queues.md).

## Save and route a case  

 To save a case record and route it to a queue in a single action, use the **Save & Route** option.  

1.  From the list of cases, open a case record.  

2.  Make any changes, and on the command bar, select **Save & Route**.  

3.  In the **Route Case** dialog, select **Route**.  

     The case will be routed based on the active routing rule set.  

    > [!IMPORTANT]
    >  The **Save & Route** button is available only on active cases.  

### See also

[Learn the basics of the Customer Service Hub ](customer-service-hub-user-guide-basics.md)  
[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
