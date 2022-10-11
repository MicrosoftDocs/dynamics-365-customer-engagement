---
title: "Customer support swarming for agents | MicrosoftDocs"
description: "Learn how to use customer support swarming to help resolve case issues more quickly in Dynamics 365 Customer Service."
ms.date: 10/05/2022
ms.topic: article
author: lalexms
ms.author: laalexan
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

# Use customer support swarming (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

When you work on time-sensitive, complex customer issues, there are times when it's useful to apply the expertise of coworkers outside of your Dynamics 365 Customer Service team. 

Using the customer support swarming feature, you can effortlessly find the right set of experts to work with on your customer issue, and collaborate with those peers directly from your desktop.

## Prerequisites

To be able to create a swarm when working on a customer issue, you must have the following prerequisites in place.

- Swarming privileges 
- Embedded Microsoft Teams chat enabled for the agent desktop or on the Teams web app

## Start a swarm

1. On the Customer Service command bar, select **Create swarm**. (You might need to select the ellipsis to see this option.)

   > [!div class="mx-imgBorder"] 
   > ![Create swarm option on the command bar.](media/teams-create-swarm.png "Create swarm option on the command bar")

  The **Swarm** page opens with the **Case details** displayed on the left side pane. The case and account fields are read-only, and are designed to give other swarm participants the associated details about the case.
 
   > [!div class="mx-imgBorder"] 
   > ![Swarm page with case details side pane.](media/teams-swarm-case-details.png "Swarm page with case details side pane displayed")

   > [!Note]
   > If you don't see the **Create swarm** option, check the overflow actions. If you still don't see it, ask your administrator to assign access privileges for you.

1.  On the **Swarm** form, type information into the following fields:
    - **Swarm request**: Type a succinct question about what you want help with. The question will be used to find skills and experts to help you.
    - **Steps already tried** (optional, 2,000-character limit): Type the details about steps you've already taken to try to resolve the issue, and any results. These details help confirm that any required processes have been followed, and also provides immediate context for other swarm participants who are invited to collaborate on the issue.
    - **What skills do you need?** (optional): As part of the swarm request, the system takes the following actions: 
       - Attempts to match skills based on your swarm question
       - Suggests skills based on case title or other case-related conditions your administrator has defined
     
     Suggested skills have the light bulb icon. You can also select up to 10 skills (both system-suggested and manually selected) that you think are relevant to the case. (Manually selected skills won't have the light bulb icon next to them.)
    
      > [!Note]
      > If neither the system or you designate any skills, you can still create the swarm but no experts will be added. In this scenario, we recommend asking your supervisor for help with identifying the appropriate skills to get expert support.

1. Save and send your swarm invitation. A linked swarm chat is created, and the contacts configured by your administrator are automatically added to the chat.

   > [!Note]
   > By default, your supervisor is automatically added to create the swarm. If you don't have a supervisor, your administrator who configured the swarm is automatically added.

  > [!div class="mx-imgBorder"] 
  > ![View of the linked swarm chat page.](media/teams-swarm-request.png "Linked swarm chat page")
   
   The following actions and views occur:
   - The system finds the minimum set of experts needed to cover as many of the skills suggested or that you added as possible.
   - A participants section opens, where you can see the number of experts invited to your swarm who match a particular number of skills.
   - You can view the names of skills not matched to an expert. If a skill is unmatched, you can work with your supervisor to find experts who match the skill.
   - You can view names of contacts who are automatically added to the swarm chat.
   - When an invited expert accepts the swarm invitation, they're automatically added to the swarm chat.
   - If you select **Edit**, existing saved skills remain. If you edit the swarm request, then the following actions occur:
     - The system will search for skills to account for the newest information, and will append skills found to the existing ones.
     - Invited experts and experts who are already in the swarm remain.

### How the invitation to experts works

When you select an expert for your swarm, they're sent an automated invitation via an adaptive card. When they accept your invitation, they're attached to the swarm and their skills are indicated. If the expert declines the invitation, the system then looks for the next expert(s) that contain the needed skill(s).

The swarm invitation shows the following information:
   - Inviting agent: The agent who initiated the swarm and invited the expert.
   - Swarm request: The question the agent needs help with.
   - What the agent has tried: A brief description of what the agent has tried prior to creating the swarm.
   - Expert skills: The required skills the expert has for the swarm.
   - Accept and reject: Options for the expert to either join or decline the swarm. If an expert declines an invitation and then later decides they want to join, they can participate by asking you to add them manually. They won't be able to view the swarm form from the group chat.
 
When an expert joins a group chat, they'll see a read-only version of the **Swarm details** form added as a tab. The right-side pane displays the associated case details. There's a section that shows the agent's swarm request and a summary of what the agent has tried to do to resolve the issue.

Experts who join a swarm can see all participants in the swarm and the skills they have that resulted in their invitation to the swarm.

### Swarm completion

When a swarm completes, you can close it and optionally document the swarm resolution.

### Swarm impact on the timeline

When a swarm is created or closed, an auto post is created on the associated case timeline.

### Associated swarm

You can see the swarms that are associated with a case from the record. To view the associated swarms, in Customer Service workspace, go to the **Details** tab, and then view the **Associated swarms** card.

### Swarm views

To view a list of swarms, go to **Swarms** on the site map. The following views are available:

- All swarms
- Cancelled swarms
- My active swarms
- Resolved swarms
- Swarms being followed
- Swarms I follow


### See also

[Configure customer support swarming](configure-customer-support-swarming.md)<br>
[Configure Teams chat](configure-teams-chat.md)<br>
[Use Teams chat](use-teams-chat.md)
