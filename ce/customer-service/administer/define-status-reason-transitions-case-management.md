---
title: Add status reason, status reason transitions to manage cases
description: Understand how to define status reason transitions for case management in Customer Service.
ms.date: 03/12/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Add status reason, status reason transitions to manage cases

If you’re in charge of incident management for an organization, it’s important to provide a model for customer service representatives to enter and update case status. In Dynamics 365 Customer Service, there are two fields in the Case table that provide information about case status: the **Status** field and the **Status Reason** field. The **Status** field for the **Case** entity has three possible values: **Active**, **Resolved**, or **Canceled**. The **Status Reason** field stores a reason for a specific status value. For example, for a case with an **Active** status, a status reason could be **In Progress**, **On Hold**, **Waiting for Details**, or **Researching**.  

 Organizations often have a large number of combinations for the **Status** and **Status Reason** fields. This can make it difficult for representatives to choose the correct next status reason. You can define status reason transitions to add another level of filtering for what the status reason value can be changed to for each status reason. Limiting these values to the allowed status reasons can help customer service representatives make the right choices.  

## Prerequisites
  
[!INCLUDE[proc_permissions_system_admin_and_customizer](../../includes/proc-permissions-system-admin-and-customizer.md)]  

## Add status reason

1. In [Power Apps](https://make.powerapps.com/), select your environment.
1. Select **Tables** and then select **Case**.
1. Select **Columns** and then select **Status Reason**.
1. In the **Edit column** pane, select the required status from the dropdown. Select **New choice** to add the required status reason transition.
1. Specify the **Default choice** dropdown. This is the default value that appears on the case form for the **Status Reason** field.
1. Select **Save**.

   :::image type="content" source="../media/powerapps-case-resol-add-value.png" alt-text="Screenshot displaying powerapps configuration":::


## Add status reason transition

Status reason transitions enable you to define what the status reason value can be changed to for each status reason. You can define status reason transitions in Power Apps. Learn more in [Define status reason transitions with Power Apps](/power-apps/maker/data-platform/define-status-reason-transitions#edit-status-reason-transitions).


### Related information

[Edit the column](/power-apps/maker/data-platform/create-edit-field-portal#edit-a-column)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
