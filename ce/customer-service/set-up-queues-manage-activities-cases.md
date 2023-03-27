---
title: Create and manage queues for cases | MicrosoftDocs
description: "Learn how to set up queues to manage activities and cases in Dynamics 365 Customer Service."
ms.date: 11/10/2022
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
  
## Types of queues
By default, a queue is created for each user and team in Customer Service. You can use this default queue to track all your work items, or you can set up queues to reflect your organization's structure, business processes, or both. For example, you can create separate queues for first tier and second tier product support teams that reflect their differing levels of expertise, or Gold and Silver queues to reflect differing priorities based on service contracts that customers have with your organization.  

You can use queues to prioritize your activities and cases, and categorize them based on:  
  
- products or services  
  
- subscription levels (regular, premium customers)  
  
- activity categories  
  
- geography  

You can create both basic and advanced queues (for unified routing). More information: [Create and manage queues for unified routing](queues-omnichannel.md)

Based on who can view the queues, you can create:

- **Public queues** To let everyone in the organization view the queue and its work items
- **Private queues** To let a small group of members view the queue and its work items. Private queues display work items for members of that queue and help remove clutter from other users' views. Private queues don't restrict access to the records they contain. Therefore, to prevent unauthorized access to sensitive data, ensure that you set up security models based on your organization needs. More information: [Dynamics 365 security model](../customerengagement/on-premises/developer/security-dev/security-model.md)

> [!NOTE]
> - You must manually add new team members as members of private queues.
> - You must manually add new Azure AD (Active Directory) team members to the team's default queue.

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
  
   - In the **EMAIL SETTINGS** section, you can do the following:
      - Select a value in the **Convert Incoming Email To Activities** dropdown list to set the type of messages that you want to track as activities.
      - Set the email signature template. This signature is added to the email by default when you send messages from a queue or reply to messages sent to the queue. More information: [Add a default signature for a queue](add-signature-template-queue.md)
  
4. In the **Omnichannel** section of the **Conflicts Tab**, you can do the following:
    - Set **Automatic work distribution** to **No** (default option), and then select **Save** to create a basic queue.
    - Set **Automatic work distribution** to **Yes** to enable unified routing, and then select **Save** to create an advanced queue.

    > [!IMPORTANT]
    > You can update a basic queue to an advanced queue and enable it for unified routing by setting **Automatic work distribution** to **Yes**. However, once set, you can't revert the advanced queue to basic queue. You'll need to create a basic queue, and set the **Automatic work distribution** to **No**.

After you have saved the queue, the following changes happen in the SUMMARY tab:

- In the **Mailbox** field of the **EMAIL SETTINGS** section, a mailbox record for the queue is automatically created and selected. To update the mailbox, select the mailbox name [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create forward mailboxes or edit mailboxes](/power-platform/admin/create-forward-mailboxes-edit-mailboxes)

- If you selected the queue type as private, the **MEMBERS** section appears.
   -  Select **Add Existing User**. Only those users that you add can work on the items in this queue. If you add a team as a member, only the existing team members can access the queue. New team members must be added manually to the queue to be able to access it.
   - The **QUEUE ITEMS** and **RECORD CREATION AND UPDATE RULES** sections appear.

## Set up default views for routing dialogs

To optimize agent efficiency, you can set up custom views that contain a filtered list of queues. These queues are relevant to the type of cases that the agents handle. You can then set the view as the default from which agents can pick a queue or user to route the work items.

1. In the Customer Service admin center app, go to **Customer support** in the site map and select **Queues**.

1. On the page that appears, select **Manage** for **Routing dialogs**.

1. On the **Queues** > **Routing dialogs** page, do the following:
    - **Add to queues**: Set a default view that'll appear for the agents when they open the **Add to Queue** dialog to route a case from the case page.
    - **Route queue item**: Set a default view that'll appear for the agents when they open the **Route Queued Item** dialog to route a case on the **Queues** page,

1. Save and close.

At runtime, your agents will see the views that you have set for them.

For information on how to create custom views, see [Create and edit public views](/power-apps/maker/model-driven-apps/create-edit-views-app-designer).

## View queue items for a queue

The **QUEUE ITEMS** section lists all activities that are either routed automatically by the routing rules or manually assigned to the queue.

## Set up rules for creating or updating records automatically

In the **RECORD CREATION AND UPDATE RULES** section, you can create rules for automatically creating records for cases from incoming emails. More information: [Automatically create or update records](automatically-create-update-records.md)
  
## Route items to basic queues  

For all cases that are automatically created from incoming email and social posts, create routing rules to route the cases to queues. Then, assign the items in the queue to appropriate agents. More information: [Create rules to automatically route cases](create-rules-automatically-route-cases.md)

Alternatively, you can manually add cases and activities to queues. More information: [Add a case to a queue](customer-service-hub-user-guide-case-queues-and-routing.md#add-a-case-to-a-queue)

  
## Assign items to agents

Queues share cases or activities as a group until they're removed from the queue or accepted by a customer service agent who assumes responsibility for handling them. Agents can pick the items for themselves, or a customer service manager can manually route these cases to the agents, or to other queues, users, and teams.  

To assign items in the queue to agents, select **Assign** after selecting one or more items in the queues grid. In the **Assign Queue** box, you can choose to assign to other users or teams.

> [!NOTE]
>
> - When two agents simultaneously add cases to the queue, the system creates two queue items instead of a single queue item.
> - If you've created workflows or used custom API to assign cases to agents and if the same case is assigned to two agents at the same time, then the system creates two queue items instead of a single queue item.
> - When an agent picks a case created by another agent and releases it from the queue, the case gets assigned to the queue owner and not to the agent who created the case.

#### Create a queue in legacy Service Management

**To create or edit a queue**
  
1. Make sure that you have the Sales or Marketing Manager, Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.  
   #### Check your security role
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. Go to **Settings** > **Service Management**.  
  
3. [!INCLUDE[proc_click_or_tap_queues](../includes/proc-click-or-tap-queues.md)]  
  
4. To create a new queue, select **New**. To edit a queue, select the queue from the list of queues, and then select **Edit** on the command bar.
  
5. Enter the following information in the **Summary** tab.
  
   - In the **SUMMARY** section:
  
       - **Name**: Enter the name of the queue.  
  
       - **Type**: Select whether the queue is a private or public queue. You can use a private queue to allow only a specific set of people to work on activities in this queue.
       - **Incoming Email**: Enter the email address that'll receive all messages sent to the queue.  
  
   - In the **EMAIL SETTINGS** section:
       - **Convert Incoming Email To Activities**: From the dropdown list, select a value depending on the type of messages that you want to track as activities.  
  
       - **Mailbox**: A mailbox record for the queue is automatically created and selected as soon as you save the queue record. To update the mailbox details, select the mailbox name. More information: [Create forward mailboxes or edit mailboxes](/power-platform/admin/create-forward-mailboxes-edit-mailboxes)  
  
   - In the **Record creation and update rules** section, add a **Record Creation and Update Rule** record. By using these rules, you can automatically create or update system or custom records with incoming activities such as emails, social activities, or other custom activities. More information: [Set up rules to automatically create or update records](../customer-service/set-up-rules-to-automatically-create-or-update-records.md)  
  
   > [!IMPORTANT]
   >
   >  - This is a central place to manage rules across all supported activities including out-of-the-box and custom activities associated with the queue.  
   >  - The **Record creation and update rules** section displays rules using the **Email Activity Conversation Setting**  or **Social Activity Conversation Setting** and that have the same queue ID as the queue.
   >  - Multiple rules with the same source type and same queue can exist. So when you select **Email Activity Conversion Settings** or **Social Activity Conversion Settings**, the rule with the latest **Last Modified On** date is applied.  
  
6. [!INCLUDE[proc_click_or_tap_save](../includes/proc-click-or-tap-save.md)]

### See also  

[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Add a case to a queue](customer-service-hub-user-guide-case-queues-and-routing.md)    

[!INCLUDE[footer-include](../includes/footer-banner.md)]
