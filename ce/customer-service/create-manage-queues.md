---
title: Set up queues to manage activities and cases (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to create and manage queues in Dynamics 365 for Customer Service 
keywords: Dynamics 365; Customer Service; create queues; manage queues; route cases to queues
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 06/01/2018
ms.topic: article
ms.service: crm-online
ms.assetid: deef5606-bbd9-452a-bc0c-63abdd658a81
---

# Create and manage queues

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use queues to organize, prioritize, and monitor the progress of your work. In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], queues are containers used to store anything that needs to be completed or requires an action, for example completing a task or closing a case.  

 Queues can be useful in:  
  
-   Having a centralized list of pending work that needs attention  
  
-   Sorting tasks by type or by the people assigned to complete them  
  
Use queues to categorize and prioritize your activities and cases. You can categorize based on:  
  
-   Different products or services  
  
-   Different subscription levels (regular, premium customers)  
  
-   Various activity categories  
  
-   Different geography  
  
> [!TIP]
>  You can use an [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] shared mailbox when you create a queue in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and not consume an [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] license for a forwarding email account.  
>   
>  See Blog: [CRM Queue with an Office 365 Shared Mailbox](http://joegilldotcom.blogspot.com/2015/01/crm-queue-with-office-365-shared-mailbox.html)  
  
## Create queues  
 By default, a queue is created for each user and team in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. You can use this default queue to track all your work items, or you can set up queues to reflect your organization's structure, business processes, or both. How you set up queues depends on how your business works. For example, you could create separate queues for First tier and Second tier product support teams that reflect their differing levels of expertise, or Gold and Silver queues to reflect differing priorities based on service contracts that customers have with your organization.  
  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] lets you create two types of queues: 

- **Private queues**: Create private queues with limited sets of members to let only those members view the items in the queue.
- **Public queues**: Create public queues to let everyone in the organization view the items in a queue.  

1.  Make sure that you have the Sales or Marketing Manager, Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2.  Go to **Settings** > **Service Management**.  
  
3. [!INCLUDE[proc_click_or_tap_queues](../includes/proc-click-or-tap-queues.md)]  
  
4.  To create a new queue, click **New**.  
  
     -OR-  
  
     To edit a queue, in the list of queues, click the queue, and then on the command bar, click **Edit**.  
  
5.  Type or change information in the text boxes.  
  
     Hovertips provide hints about what to enter.  
  
    -   In the **Summary** section, complete the required fields.  
  
    -   In the **Name** field, type the name of the queue.  
  
    -   In the **Type** field, choose if the queue is a private or public queue. You can use a private queue to allow only a specific set of people to work on activities in this queue.  
  
         If you’re creating a private queue, you’ll need to add members to this queue manually. In the **Members** section, click the **Add** button **+** to add members to the queue. Only these members will be able to work on the items in this queue.  
  
        > [!NOTE]
        >  The email address you enter in the **Incoming Email** field receives all messages sent to the queue.  
  
    -   In the **Email Settings** section, in the **Convert to email activities** drop-down list, choose which messages to track as activities.  
  
    -   In the **Mailbox** field, a mailbox record for the queue is automatically created and selected as soon as you save the queue record. To update the mailbox details, click the mailbox name. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create forward mailboxes or edit mailboxes](../admin/create-forward-mailboxes-edit-mailboxes.md)  
  
    -   In the **Record creation and update rules** section, add a **Record Creation and Update Rule** record. By using these rules, you can automatically create or update system or custom records from incoming [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] activities, such as emails, social activities, or custom activities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up rules to automatically create or update records](../customer-service/set-up-rules-to-automatically-create-or-update-records.md)  
  
 > [!IMPORTANT]
 >  This is a central place to manage rules across all supported activities including out-of-the-box and custom activities associated with the queue.  
 >  The **Record creation and update rules** section displays rules using the **Email Activity Conversation Setting**  or **Social Activity Conversation Setting** and that have the same queue ID as the queue.   
 >  Multiple rules with the same source type and same queue can exist. Therefore, when you click **Email Activity Conversion Settings** or **Social Activity Conversion Settings**, the rule with the latest **Last Modified On** date is applied.  
  
6. [!INCLUDE[proc_click_or_tap_save](../includes/proc-click-or-tap-save.md)] 


## View queue items  
 In the **Queue Items** section, all activities that are either routed to this queue automatically by the routing rules or the activities that are manually assigned to this queue will be listed here.    
  
## Route items to queues  
 For all cases that are automatically created from incoming email and social posts, create routing rules to route the cases to queues. Then assign the items in the queue to appropriate CSRs or users. Alternatively, you can manually add cases and activities to queues.  
  
## Assign items in the queue to work  
 Queues share cases or activities as a group until these are taken out of the queue, or accepted, by a customer service representative (CSR) who assumes responsibility for handling them. CSRs can pick the items for themselves, or a customer service manager (CSM) can manually route these cases to the CSRs or to other queues, users, or teams.  

## Additional actions  
 To create records for this queue, on the command bar, click **Email Activity Conversation Settings** or **Social Activity Conversation Settings**.  
  
### See also  
 [Create or change a queue](../customer-service/create-edit-queue.md)<br> 
 [Create rules to automatically route cases](../customer-service/create-rules-automatically-route-cases.md)   
 [Automatically create a case from an email](../customer-service/automatically-create-case-from-email.md)</br>
 [Find what's assigned to you in a queue (Customer Service Hub)](../customer-service/user-guide-customer-service-hub.md)</br>
 [Find what's assigned to you in a queue (Customer Service)](../customer-service/user-guide-customer-service.md) 
