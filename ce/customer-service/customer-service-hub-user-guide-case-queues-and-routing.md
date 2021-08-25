---
title: "Cases to queues and routing in Customer Service Hub | MicrosoftDocs"
description: "Understand cases and SLA in Customer Service Hub for Dynamics 365 Customer Service."
ms.date: 03/25/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Case queues and routing

Customer Service Hub provides you with the ability to add a case to a queue, and save case records and route them to a queue.

## Add a case to a queue  

 If you think another group in your team has expertise on the subject, you can move the case to a queue so that someone else can pick it up.  

**To add a case to a queue**

1. [!INCLUDE[proc_service_cases](../includes/proc-service-cases.md)]  

2. In the list of cases, select the case that you want to add to a queue.  

3. On the command bar, select **Add to Queue**.  

4. In the **Queue** field, select the queue that you want to add the case to, and then select **Add**.  

To know more about queues, see [Work with queues](work-with-queues.md).

## Save and route a case  

 To save a case record and route it to a queue in a single action, use the **Save & Route** button.  

1.  From the list of cases, open a case record.  

2.  Make any changes, and on the command bar, select **Save & Route**.  

3.  In the **Route Case** dialog, select **Route**.  

     The case will be routed based on the active routing rule set.  

    > [!IMPORTANT]
    >  The **Save & Route** button is available only on active cases.  

## Manage skills

When the custom skill control is added on all routed records in Customer Service Hub, you can view and update the skill set to  view and delete existing skills, or even add new skills from the existing skill set.

> [!Note]
> To be able to update skills, your administrator must enable the setting in Omnichannel admin center or Customer Service Hub. More information: [Allow agents to update skills](allow-agents-update-skills.md).

Sometimes agent facing skill control on case form and on conversation form doesnt load and thus skills are not visible. 

To troubleshoot this, user needs to clear the browser cache 

### See also

[Learn the basics of the Customer Service Hub ](customer-service-hub-user-guide-basics.md)  
[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
