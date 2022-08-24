---
title: Create and manage queues for cases | MicrosoftDocs
description: "Learn how to set up queues to manage activities and cases in Dynamics 365 Customer Service."
ms.date: 08/24/2022
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
searchScope: 
  - D365-App-customerservicehub
  - D365-Entity-queueitem
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Customer Service
---

# Create and manage queues for cases

[!INCLUDE[cc-trial-sign-up](../includes/cc-trial-sign-up.md)]

In Dynamics 365 Customer Service, *queues* are containers used to store anything that needs to be completed or requires an action such as completing a task or closing a case. Queues help you to organize, prioritize, and monitor the progress of your work. 

Queues can be useful in:
  
- Having a centralized list of pending work that needs attention.  
  
- Sorting tasks by type, or by people assigned to complete them.  
  
Use queues to categorize and prioritize your activities and cases. You can categorize based on:  
  
- products or services  
  
- subscription levels (regular, premium customers)  
  
- activity categories  
  
- geography  

You can create both basic and advanced queues (for unified routing). For information about creating advanced queues, see [Create and manage queues for unified routing](queues-omnichannel.md).

By default, a queue is created for each user and team in Dynamics 365 Customer Service. You can use this default queue to track all your work items, or you can set up queues to reflect your organization's structure, business processes, or both. For example, you can create separate queues for first tier and second tier product support teams that reflect their differing levels of expertise, or Gold and Silver queues to reflect differing priorities based on service contracts that customers have with your organization.  

> [!Note]
> You must manually add new Azure AD (Active Directory) team members to the team's default queue.
  
## Types of queues
You can create the following two types of queues:

- **Private queues** For limited set of members to help those members easily view the work items in that queue. Private queues streamline queue items for the members of that queue only and help to remove clutter from other users' views.
- **Public queues** To let everyone in the organization view the queue and all of its items.

> [!IMPORTANT]
>
> - Private queues are a great way to organize cases, but they don't restrict access to the records they contain. If your organization handles sensitive data and needs to restrict access to queue items or fields, explore the different options available in [Dynamics 365 security model](../customerengagement/on-premises/developer/security-dev/security-model.md).
> - In private queues, you must manually add new team members as members of the queue.
> - If unified routing is enabled, make sure that the **Queue** form, which is the default form, exists and hasn't been removed through customization. Otherwise, you'll not be able to create a basic queue in Customer Service Hub.

## Prerequisites
Make sure that you have the Sales or Marketing Manager, Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.
   #### Check your security role
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

## Create a queue


1. Go to one of the admin apps, and perform the following steps:
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
        
    1. In the site map, select **Queues** in **Customer support**.
    
    1. On the **Queues** page, select **Manage** for **Basic queues**.

   ### [Customer Service Hub](#tab/customerservicehub)

    1. Go to **Service Management**, and then select **Queues** in **Case Settings**.
  
2. To create a queue, select **New**. To edit a queue, select the queue in the list of queues, and then select **Edit** on the command bar.  
  
3. Enter the following information in the **Summary** tab:
   - In the **SUMMARY** section, do the following:  
      - **Name**: Enter the name of the queue.  
      - **Type**: Select whether the queue is a private or public queue. 
          If you’re creating a private queue, you’ll need to add members to this queue manually. In the **Members** section, select **Add** to add members to the queue. Only these members will be able to work on the items in this queue.  
      - **Incoming Email**: Enter the email address that'll receive all messages sent to the queue.  
      - **Description**: Enter a description.
  
   - In the **EMAIL SETTINGS** section, in the **Convert Incoming Email To Activities** dropdown list, select a value depending on the type of messages that you want to track as activities.
  
4. In the **Omnichannel** section of the **Conflicts Tab**, you can do the following:
    - Set **Automatic work distribution** to **No** (default option), and then select **Save** to create a basic queue.
    - Set **Automatic work distribution** to **Yes** to enable unified routing, and then select **Save** to create an advanced queue.

    > [!IMPORTANT]
    > You can update a basic queue to an advanced queue and enable it for unified routing by setting **Automatic work distribution** to **Yes**. However, once set, you can't revert the advanced queue to basic queue. You'll need to create a basic queue, and set the **Automatic work distribution** to **No**.

After you have saved the queue, the following changes happen in the SUMMARY tab:

   - In the **Mailbox** field of the EMAIL SETTINGS section, a mailbox record for the queue is automatically created and selected. To update the mailbox, select the mailbox name [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create forward mailboxes or edit mailboxes](/power-platform/admin/create-forward-mailboxes-edit-mailboxes)

   - If you selected the queue type as private, the **MEMBERS** section appears.
          - Select **Add Existing User**. Only those users that you add can work on the items in this queue. If you add a team as a member, only the existing team members can access the queue. New team members must be added manually to the queue to be able to access it.

   - The **QUEUE ITEMS** and **RECORD CREATION AND UPDATE RULES** sections appear.

## View queue items for a queue

The **QUEUE ITEMS** section lists all activities that are either routed automatically by the routing rules or manually assigned to the queue.
  
## Route items to basic queues  

For all cases that are automatically created from incoming email and social posts, create routing rules to route the cases to queues. Then, assign the items in the queue to appropriate agents. More information: [Create rules to automatically route cases](create-rules-automatically-route-cases.md)

Alternatively, you can manually add cases and activities to queues. More information: [Add a case to a queue](customer-service-hub-user-guide-case-queues-and-routing.md#add-a-case-to-a-queue)
  
## Assign items to agents

Queues share cases or activities as a group until they're removed from the queue or accepted by a customer service agent who assumes responsibility for handling them. Agents can pick the items for themselves, or a customer service manager can manually route these cases to the agents, or to other queues, users, and teams.  

To assign items in the queue to agents, select **Assign** after selecting one or more items in the queues grid. In the **Assign Queue** box, you can choose to assign to other users or teams.

> [!Note]
>
> - When two agents simultaneously add cases to the queue, the system creates two queue items instead of a single queue item.
> - If you've created workflows or used custom API to assign cases to agents and if the same case is assigned to two agents at the same time, then the system creates two queue items instead of a single queue item.
> - When an agent picks a case created by another agent and releases it from the queue, the case gets assigned to the queue owner and not to the agent that created the case.


### See also  

[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Add a case to a queue](customer-service-hub-user-guide-case-queues-and-routing.md)    

[!INCLUDE[footer-include](../includes/footer-banner.md)]
