---
title: Enable agents to update skills
description: Learn how to enable the setting that allows agents to update skills at runtime in Customer Service Hub and Omnichannel for Customer Service.
ms.date: 03/08/2023
ms.service: dynamics-365-customerservice
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Enable agents to update skills

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

By default, skill-based routing is enabled. You can create skills to attach to agents and define proficiency levels by using a rating model. You can also enable your agents to add or remove skills for their assigned work items at runtime. To do this, you must enable the update skill control toggle in the Customer Service admin center or Omnichannel admin center app.

> [!NOTE]
> By default, the skill control is available only for messaging channels. For the records channel, you'll need to customize the form to add the skill control. More information: [Add a skill control for routed records](add-skill-control.md)

## Prerequisite

To ensure that the skill control is loaded and displayed properly for the routed records, you must [allow access to these websites](system-requirements-omnichannel.md#allow-access-to-websites).  

## Enable agents to update skills at runtime

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
   
    - In the site map, select **User management** in **Customer support**. The **User management** page appears.
       
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **User attributes** under **Advanced settings**.
    
   ### [Customer Service Hub](#tab/customerservicehub) 

    - Go to the **Service Management** site map, and select **User attributes** in **Unified routing**.

2. Select **Manage** for **Skill-based routing**.

3. On the **Skill based routing** tab, set the **Enable update skill control** toggle to **Yes**.

:::image type="content" source="media/enable-update-skill-control.png" alt-text="Enable update skill control toggle":::

By enabling your agents to evaluate and update skills required for their work items, you make use of your agents' experience to identify the actual skills that are required for the work items. These skills are also used in training the skill finder model. Accurate data on skills improves the model accuracy and prediction. More information: [Retrain skill finder model](set-up-skill-based-routing.md#retrain-the-model-iteratively)

### See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Set up skills and assign agents](setup-skills-assign-agents.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
