---
title: Setup autonomous case management
description: Learn how to set up autonomous case management agents to help customer support teams efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to #Required; don't change.
ms.collection: get-started #Required; If this isn't a getting started article, don't remove the attribute, but leave the value blank. The values for this attribute will be updated over time.
ms.date: 01/13/2025
ms.custom: bap-template #Required; don't change.
---


# Setup autonomous case creation and update (preview)

The autonomous case management agent creates and updates cases from live chat conversations and emails using AI and Automatic record creation and update rules, reducing manual effort and minimizing data entry errors.

The agent creates and updates cases as follows:

- From conversations. The agent analyzes the customer intent in live chat conversations, predicts and populates the relevant field values, and updates case details as the conversation progresses.
- From emails. The agent uses ARC rules to create cases from emails and then updates the fields based on ongoing email interactions with customers.

## Prerequisites

- Administrators must have the CSR Manager or System Administrator role.
- Customer Service Representatives must have the Omnichannel Agent and Customer Service Representative role.
- [Automatic record creation and update (ARC) rules](../administer/set-up-rules-to-automatically-create-or-update-records) are set up to create case records from emails.
- [Provision the live chat channel](../implement/provision-channels.md). 
- [Workstream](../administer/create-workstreams.md) and [queues](../administer/queues-omnichannel.md) are setup.


## Configure autonomous case creation and update

In Customer Service admin center, perform the following steps:

1. In **Customer support**, select **Case settings**.
2. On the **Case settings** page, select **Manage** for **Case Management Agent**.
3. In the **Case Management Agent** page, select **Case creation and update with autonomous AI assistance (preview)**.
4. In the page that appears, select the channels that AI can use to create or update cases. You can select **Live chat** and **Email**.
5. In the **Default list of fields for AI prediction**, specify the fields the agent must fill in the case form using information from the chat or email conversation.  
   - The agent creates a case only if there’s enough context in the conversation to predict all these fields.  
   - New cases are created from emails based on the ARC rules configured. The case management agent updates the fields in the case created by ARC if there’s new information available.
6. In **Rules for case update with AI assistance**, specify the fields the agent must update from an ongoing conversation or incoming email after creating a case. If you don't specify update rules, the agent updates the fields you’ve added in the previous step.
7. Select the checkbox in the **Agent experience data** section if you want the application to save the agent interactions in Dataverse. You can then use this information to build reports.

### Example 

You want your agent to create a case from a live chat conversation with **Issue description** and **Contact** as fields that the agent must predict and fill. In the **Case creation and update with autonomous AI assistance (preview)** page, specify the following: 
- **Channel:** Chat  
- **Default list of fields for AI prediction:** Issue description, Contact  

After the case is created, you want the agent to update the **Product**, **Priority**, and **Serial number** fields if the case category is set to **product defect**.  In the **Case creation and update with autonomous AI assistance (preview)** page, specify the following: 
- Select **Create** for **Case update rules**. 
- In the **New rule** page, specify the **Rule name** and the following:
  - In **Define conditions**, select **Add** and then specify the following:
    - **Select a field:** Case category  
    - **Operator:** Equals  
    - **Value:** Product defect  
  - Specify fields for AI prediction when this condition is met:  
    - **Product**, **Priority**, **Serial number**

## Enable Service Representatives to Use Autonomous Case Management Agents

For agents to use the case management agents in Customer Service workspace, enable the autonomous case creation and update, case follow-up, and closure in **agent experience profiles**.

By default, service representatives added to the out-of-the-box agent experience profiles can use the autonomous case management agent.

1. Go to **Agent experience profiles** using one of the following navigation options:
   - **Agent experience** > **Workspaces**
   - In **Case Management Agent**, you can select **Agent experience profiles** **Case creation and update with autonomous AI assistance** > **Agent access** > **Agent experience profiles**
   - **Customer Support** > **Case settings** > **Case Management agent** > **Case follow-up and closure > Agent access > agent experience profiles**
2. Select the required agent experience profile.
3. In the **Copilot AI features** section:
   - Select **Edit** and then enable the required features:  
     - **Autonomous case creation and update from conversations**  
     - **Autonomous case follow-up and closure**
