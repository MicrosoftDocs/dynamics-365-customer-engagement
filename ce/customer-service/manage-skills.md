---
title: "Manage skills| MicrosoftDocs"
description: "Learn how to view or remove existing skills, and add new skills using the skill control in Omnichannel for Customer Service."
ms.date: 09/25/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
ms.reviewer: nenellim
---

# Manage skills

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Dynamics 365 comes with an out-of-the box skill control for messaging channels. The skill control when added to the case or conversation forms enables you to view and update skills. Your administrator can enable the setting that allows you to update skills at runtime.

## Introduction

When you receive a work item in your queue, you can view the skills required to do the work in the **Skills** field of your case or conversation record. For each work item, you can view skills that have been manually added by your administrator and those that were identified by the machine-learning models.

In the following illustration, **Refund** is a skill added by your administrator, and skills with the percentage rating such as **99% Heating** and **99% Electrical** are skills that have been identified by the machine-learning model.

> [!div class="mx-imgBorder"]
> ![Add skills.](media/skill-control.png "Add skills.")

> [!Note] 
> If you are not able to view the skill control on the case or conversation forms, try clearing your browser cache.

## Add and remove skills

If upon assessing the work item, you think that the relevant skills are missing or incorrect, you can choose to add or remove skills as appropriate.
To add skills, select **Add skill**, enter a skill name, and select the plus (**+**) symbol. To add multiple skills at a time, simply add the skills names separated by commas, and then select the plus (**+**) symbol.

To remove skills, select **X** next to each skill that you want to delete.

### See also

[Allow agents to update skills](allow-agents-update-skills.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]