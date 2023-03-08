---
title: Manage skills
description: Learn how to view or remove existing skills, and add new skills using the skill control in Omnichannel for Customer Service.
ms.date: 03/08/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
ms.custom: 
  - dyn365-customerservice
  - bap-template
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Manage skills

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Dynamics 365 comes with an out-of-the box skill control for messaging channels. When added to the case or conversation forms, the skill control enables you to view and update skills. Your administrator can enable the setting that allows you to update skills at runtime.

> [!NOTE]
> For the record type entity, you'll need to customize the case form to add the skill control. More information: [Add a skill control for routed records](add-skill-control.md)

When you receive a work item in your queue, you can view the skills required to do the work in the **Skills** field of your case or conversation record. For each work item, you can view skills that have been attached by the manual skill classification rules and those that were identified by the machine-learning skill finder models.

In the following screenshot, **Refund** is a skill attached by the manual skill classification rules, whereas skills with percentage rating such as **99% Heating** and **99% Electrical** are those that have been identified by the machine-learning model.

> [!div class="mx-imgBorder"]
> ![Add skills.](media/skill-control.png "Add skills.")

> [!NOTE]
> If you aren't able to view the skill control on the case or conversation forms, try clearing your browser cache.

## Add and remove skills

If upon assessing the work item, you think that the relevant skills are missing or incorrect, you can choose to update the skills.

To add skills, select the **Add skill** field and enter a skill name. As you enter one or more letters, a list of skill names are suggested in the dropdown list; select the relevant skill from the dropdown list. Add as many skills as you think are appropriate for the work item.

To remove skills, select **X** next to each skill that you want to delete.

The skill updates you make for your assigned work items can then be used to retrain the machine learning-based skill finder models and help with accurate work assignments. More information: [Retrain skill finder model](set-up-skill-based-routing.md#retrain-the-model-iteratively)

### See also

[Allow agents to update skills](allow-agents-update-skills.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
