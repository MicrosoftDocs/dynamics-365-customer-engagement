---
title: Create and manage capacity profiles | MicrosoftDocs
description: "Know how to create and manage capacity profiles in Customer Service"
ms.date: 01/19/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Create and manage capacity profiles

## Introduction

You can create capacity profiles and assign them to agents to define the types and amount of work they can take. Capacity profiles contain information, such as the amount of work, concurrent or daily capacity, and whether other channels are affected.

- Capacity management helps administrators create various capacity profiles and associate users with the matching profiles.
- The administrator has the capability to block certain period of agents' time while they are busy working with high priority cases.
- The supervisor can override the agent's configured capacity and assign work to user manually.
- In the queue assignment rule, you can create a rule to find an agent whose capacity profile matches that of the work item.

Configure profile-based capacity if any of the following scenarios are applicable:

- Your agents are varied on experience and skill sets.
- Agents need upper limit on the amount of work assigned to them.
- Agents work items are of different complexity, originate on different channels.
- Assignment on one channel impacts the assignment of another channel. For example, agents on phone calls shouldn't be assigned another work.

> [!IMPORTANT]
>
> - We recommend that you configure either capacity profiles or capacity units in your organization, but not both.
> - The capacity is not considered during consult or monitor.

## Create a capacity profile and assign to users

Create a capacity profile, and use it in a workstream that is used for routing work items.

For a capacity profile, you can edit any setting except reset frequency, and add or remove users. If you no longer require the profile, you can delete it.

Perform the following steps to configure the capacity profile:

1. In Omnichannel admin center, select **User attributes** in **Advanced settings** in the site map. In Customer Service Hub, select **User attributes** in **Unified routing** in the site map.

  > [!NOTE]
  > In Customer Service Hub, the **User attributes** area will appear in the site map only if unified routing is enabled in service configuration settings.

2. On the **User attributes** page, select the **Manage** option for **Capacity profile**.

3. On the **Capacity profiles** page, select **Create new**.

4. On the **Details** tab of the **Create capacity profile** dialog box, enter the following details:
   - **Profile name**: Name for the capacity profile.
   -  **Work item limit**: Number of units of the work type that the agent can be assigned.
   -  **Reset frequency**: Period after which capacity consumption can be reset for agents. If you select **Immediate**, capacity will be reset immediately. If you select **End of day**, capacity will be reset after the agent's shift ends. Once configured, you'll have to recreate the capacity profile if you want to change the reset frequency.
   -  **Assignment blocking**: Set the toggle to **Yes**. When the agent reaches the work item limit of the capacity profile, any new work items won't be automatically assigned to the agent.

   :::image type="content" source="media/create-capacity-profile.png" alt-text="Create a capacity profile.":::

5. On the **Users** tab, select **Add user**, and in the **Users** list, select the users. Alternatively, use the **Search** option to search for and add the user.
   
   > [!IMPORTANT]
   > Users must be configured as a bookable resource to be assigned the capacity profile. More information: [Manage users](users-user-profiles.md).

6. Select **Add user**. The capacity profile is assigned to the user.

> [!NOTE]
> In Omnichannel Administration, you can create a capacity profile in the **Capacity** area of the **User** page.

## Use capacity profiles

After you have created the capacity profiles, you can configure the following settings to assign work items to agents at runtime:

- Set the capacity profile in the work distribution settings. The profile will be applied to all the work items that are routed through the workstream. More information: [Configure work distribution](create-workstreams.md#configure-work-distribution)
- Set the capacity profile in a classification ruleset for the workstream as a rule output. This setting will override the capacity profile that you have defined at the work distribution level. More information: [Create classification rulesets based on capacity profiles](configure-work-classification.md#create-classification-rulesets-based-on-capacity-profiles)

You needn't define assignment rules specific to capacity profiles at queue level to find agents with matching capacity profiles. If capacity profile is attached to a work item, then the system will ensure that the assigned agent has the matching capacity profile.

### Escalation profiles

The escalation profile is a default profile that's used when a chat conversation is escalated to a voice or video call. Escalation profiles are preconfigured and you can't modify them to add or remove users. When the agent escalates a chat to a voice or video call, a new session is created and an escalation profile is attached to the work item, so that the agent doesn’t receive a new chat or voice call till the current call with the customer is complete. If the agent transfers a video or voice call to another agent, the escalation profile becomes applicable to the new agent.

### Multiple capacity profiles in a single workstream

Let us take a scenario where you want to route cases such that agents can work on maximum two high priority cases per day.

- Agents can work on max 4 normal capacity profile per day
- But the agent should never be assigned more than 5 cases per day.

**To achieve the scenario**

1. create the following profiles:

   -	**High priority profile**: 2 cases per day, reset at the end of day
   -	**Normal priority profile**: 4 cases per day, reset at the end of day
   -	**Total capacity profile**:  5 cases per day, reset at the end of day

1.	In the workstream, set the "Total capacity profile" as the default profile.

1	Use the classification rule to set the capacity profiles as "High priority profile" or "Normal priority profile" according to the priority of the case.

1. Ensure that the agents have all the three profiles

**Run time behavior**

1. When the high priority case comes, the case will be stamped with the "Total capacity profile" and "High priority profile".
2. An agent who has capacity in both these profiles will be selected. When the case is assigned, capacity will be consumed from both the profiles.
3. Similarly, for normal priority cases, the capacity will be consumed from both the total capacity profile and normal priority profile.


### See also

[Create workstreams](create-workstreams.md)  
[Manage users in Omnichannel for Customer Service](users-user-profiles.md)  
[Map role personas](role-persona-mapping.md)  
