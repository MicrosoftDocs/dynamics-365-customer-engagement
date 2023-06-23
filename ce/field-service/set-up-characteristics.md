---
title: Specify characteristics for resources
description: Assign characteristics to resources and work orders to list the skills needed to complete the job.
ms.date: 06/23/2023
ms.topic: how-to
ms.custom: bap-template
author: ryanchen8
ms.author: chenryan
---

# Specify characteristics for resources

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

## Enhanced characteristics (Preview)

Starting with 2023 release wave 2, you can add more details to a resource's characteristics. That's especially useful if you want to document when a certification was issued or when it expires.

Before users can specify enhanced characteristics, a Field Service administrator has to enable the feature after [updating to the early access release](/dynamics365/get-started/release-schedule).

In Field Service, change to the **Settings** area.
Under **General**, select **Field Service Settings**.
On the **Features** tab, set **Enhanced characteristics** to **On**.

With enhanced characteristics enabled, you can append some more information to *Bookable Resource Characteristic* records.

A section for **Supporting Information** shows on the record. You can provide an **ID**, **Issue Date**, **Expiration Date** and a **Description** of a characteristic that related to a specific resource.
  
## Assign characteristics to work orders  
  
1. Open a [work order](create-work-order.md).
  
1. Select **Related** > **Characteristics**.  
  
1. On the **Requirement Characteristic Associated View** view, select **Add New Requirement Characteristic**.  
  
1. Choose the **Characteristics**, an optional **Rating Value** and the related **Resource Requirement**.
  
1. Select **Save & Close**.


  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
