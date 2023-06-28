---
title: Specify skills for resources
description: Learn how to set up characteristics in Dynamics 365 Field Service
ms.date: 09/26/2022
ms.topic: article
author: ryanchen8
ms.author: chenryan
---

# Specify skills for resources

Characteristics are skills or attributes that resources possess. For example, they can be used to indicate a license or certification is needed for certain types of work.  
  
Add characteristics to work orders to list skills a resource needs to complete the job. It helps finding the right resources that have the matching characteristics when scheduling the work order.
  
## Add characteristics  
  
1. In Resource Scheduling, change to the **Settings** area.

1. In the **Resource** section, go to **Skills**.

1. Select **New** to add a characteristic.

1. Provide a **Name** and an optional **Description**.

1. Choose a **Characteristic Type**. You can choose between two options:

   - Skill: Classifies the characteristic as a skill that is rated with a [proficiency level](#create-a-proficiency-model).
   - Certification: Choose between boolean true/false options for the characteristic.

## Create a proficiency model

You can define rating values in a proficiency model that's used to indicate the skill level of a resource.

1. In Resource Scheduling, change to the **Settings** area.

1. In the **Resource** section, go to **Proficiency Models**.
  
1. Select **New** to create a new model or select an existing model.

1. Provide a **Name** for the rating model.

1. Set a minimum and maximum rating value and **Save** the rating model.

1. In the **Rating Values** section, select **New Rating Value**.

1. Provide a **Name** and a **Value**.

1. **Save & Close** the rating value. Add more rating values for your rating model.

## Assign characteristics to resources  
  
1. In Field Service, change to the **Resources** area.

1. In the **Resource** section, go to **Resources**.
  
1. From the list, select a [bookable resource name](set-up-bookable-resources.md).  
  
1. In the **Field Service** tab, in the **Characteristics** section, select **New Bookable Resource Characteristic**.  
  
1. Find and select the required **Characteristics** and add a **Rating Value** for the resource.  
  
1. Select **Save & Close**.  
  
## Assign characteristics to work orders  
  
1. Open a [work order](create-work-order.md).
  
1. Select **Related** > **Characteristics**.  
  
1. On the **Requirement Characteristic Associated View** view, select **Add New Requirement Characteristic**.  
  
1. Choose the **Characteristics**, an optional **Rating Value** and the related **Resource Requirement**.
  
1. Select **Save & Close**.
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
