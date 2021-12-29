---
title: Create and manage queues for cases | MicrosoftDocs
description: "Learn how to set up queues to manage activities and cases in Dynamics 365 Customer Service."
ms.date: 12/21/2021
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
searchScope:
- D365-App-customerservicehub
- D365-Entity-queueitem
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Create and manage queues for cases

Queues help you to organize, prioritize, and monitor the progress of your work. In Dynamics 365 Customer Service, queues are containers used to store anything that needs to be completed or requires an action such as completing a task or closing a case. You can create both basic and advanced queues (queues that are enabled for unified routing) in Customer Service Hub. For information about creating advanced queues, see [Create and manage queues for unified routing](queues-omnichannel.md).

Queues can be useful in:
  
- Having a centralized list of pending work that needs attention  
  
- Sorting tasks by type, or by people assigned to complete them  
  
Use queues to categorize and prioritize your activities and cases. You can categorize based on:  
  
- products or services  
  
- subscription levels (regular, premium customers)  
  
- activity categories  
  
- geography  

By default, a queue is created for each user and team in Dynamics 365 Customer Service. You can use this default queue to track all your work items, or you can set up queues to reflect your organization's structure, business processes, or both. For example, you can create separate queues for first tier and second tier product support teams that reflect their differing levels of expertise, or Gold and Silver queues to reflect differing priorities based on service contracts that customers have with your organization.  
  
In Customer Service, you can create two types of queues:

- **Private queues:** Create with limited set of members to help those members easily view the queue items in that queue. Private queues streamline queue items for the members of that queue only and help to remove clutter from other user’s views.
- **Public queues:** Create to let everyone in the organization view the queue and all of its items.

> [!IMPORTANT]
>
> - Private queues are a great way to organize cases, but they don't restrict access to the records they contain. If your organization handles sensitive data and needs to restrict access to queue items or fields, explore the different options available in [Dynamics 365 security model](../customerengagement/on-premises/developer/security-dev/security-model.md).
> - If unified routing is enabled, make sure that the **Queue** form, which is the default form, exists and hasn't been removed through customization. Otherwise, you'll not be able to create a basic queue in Customer Service Hub.

## Create a queue in Customer Service Hub

**To create or edit a queue**
  
1. Make sure that you have the Sales or Marketing Manager, Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.
   #### Check your security role
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. In the site map of Customer Service Hub, go to **Service Management**, and then select **Case Settings** > **Queues**.
  
3. To create a new queue, select **New**. To edit a queue, select the queue in the list of queues, and then on the command bar, select **Edit**.  
  
4. Enter the following information in the **Summary** tab.
   - In the **SUMMARY** section, do the following:  
      - **Name**: Enter the name of the queue.  
      - **Type**: Select whether the queue is a private or public queue. You can use a private queue to allow only a specific set of people to work on activities in this queue. If you’re creating a private queue, you’ll need to add members to this queue manually. In the **Members** section, select **Add** to add members to the queue. Only these members will be able to work on the items in this queue.  
      - **Incoming Email**: Enter the email address that'll receive all messages sent to the queue.  
      - **Description**: Enter a description.
  
   - In the **EMAIL SETTINGS** section, in the **Convert Incoming Email To Activities** dropdown list, select a value depending on the type of messages that you want to track as activities.
  
5. In the **Omnichannel** section of the **Conflicts Tab**, you can do the following:
    - Set **Automatic work distribution** to **No** (default option), and then select **Save** to create a basic queue.
    - Set **Automatic work distribution** to **Yes** to enable unified routing, and then select **Save** to create an advanced queue.

    > [!IMPORTANT]
    > You can update a basic queue to an advanced queue and enable unified routing by setting **Automatic work distribution** to **Yes**.
    > You cannot change an advanced queue back to a basic queue by setting the **Automatic work distribution** from **Yes** to **No**. You must create a new basic queue by setting the **Automatic work distribution** to **No**.

6. Save the changes. The following changes will happen:

      - In the **Mailbox** field, a mailbox record for the queue is automatically created and selected as soon as you save the queue record. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create forward mailboxes or edit mailboxes](/power-platform/admin/create-forward-mailboxes-edit-mailboxes)

      - If you selected the queue type as private, the **MEMBERS** section appears.
          - Select **Add Existing User**. Only those users that you add can work on the items in this queue. If you add a team as a member, only the existing team members can access the queue. New team members must be added manually to the queue to be able to access it.

      - The **QUEUE ITEMS** and **RECORD CREATION AND UPDATE RULES** sections appear.

## Create a queue in Customer Service app

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

## View queue items for a queue

The **Queue Items** section lists all activities that are either routed automatically by the routing rules or manually assigned to the queue.
  
## Route items to basic queues  

For all cases that are automatically created from incoming email and social posts, create routing rules to route the cases to queues. Then, assign the items in the queue to appropriate agents. More information: [Create rules to automatically route cases](create-rules-automatically-route-cases.md)

Alternatively, you can manually add cases and activities to queues. More information: [Add a case to a queue](customer-service-hub-user-guide-case-queues-and-routing.md#add-a-case-to-a-queue)
  
## Assign items to agents

Queues share cases or activities as a group until these are taken out of the queue or accepted by a customer service agent who assumes responsibility for handling them. Agents can pick the items for themselves, or a customer service manager can manually route these cases to the agents, or to other queues, users, and teams.  

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
