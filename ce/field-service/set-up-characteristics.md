---
title: Specify characteristics for resources
description: Assign characteristics to resources and work orders to list the characteristics needed to complete the job.
ms.date: 05/23/2025
ms.topic: how-to
ms.custom: bap-template
author: ryanchen8
ms.author: chenryan
---

# Specify characteristics for resources

Characteristics are skills or attributes that resources possess. For example, they can be used to indicate a license or certification is needed for certain types of work.  
  
Add details to work orders to describe the characteristics needed to complete the job. Use these details to match the characteristics of available workers to make sure the right person is chosen for the task.
  
## Add characteristics  
  
1. In Resource Scheduling, change to the **Settings** area.

1. Under **Resource**, select **Characteristics**.

1. Select **New** to add a characteristic.

1. Provide a **Name** and an optional **Description**.

1. Choose a **Characteristic Type**.

   - **Characteristic**: The characteristic is specific knowledge or experience that is rated with a [proficiency model](#create-a-proficiency-model).
   - **Certification**: The characteristic is a designated credential, status, or level of achievement earned by a resource.

1. Select **Save & Close**.

## Create a proficiency model

You can define values in a proficiency model that's used to indicate the characteristic level of a resource.

1. In Resource Scheduling, change to the **Settings** area.

1. Under **Resource**, select **Proficiency Models**.
  
1. Select **New** to create a new model or select an existing model.

1. Provide a **Name** for the proficiency model.

1. Set a minimum and maximum rating value and **Save** the proficiency model.

1. In the **Proficiency Values** section, select **New Proficiency Value**.

1. Provide a **Name** and a **Value**.

1. Select **Save & Close**. Add more rating values for your proficiency model.

## Assign characteristics to resources  
  
1. In Field Service, change to the **Resources** area.

1. Under **Resource**, select **Resources**.
  
1. Open a [bookable resource name](set-up-bookable-resources.md) and select the **Field Service** tab.

1. In the **Characteristics** section, select **New Bookable Resource Characteristic**.  
  
1. Find and select the required **Characteristics**. If applicable, add a **Rating Value** for the resource.  
  
1. Select **Save & Close**.

## Enhanced characteristics (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

Add more details to a resource's characteristics. More detail is especially useful if you want to document when a certification was issued or when it expires.

Before users can specify enhanced characteristics, a Field Service administrator has to enable the feature after [updating to the early access release](/dynamics365/get-started/release-schedule).

1. In Field Service, change to the **Settings** area.

1. Under **General**, select **Field Service Settings**.

1. On the **Features** tab, set **Enhanced characteristics** to **On**.

1. Select **Save & Close**.

With enhanced characteristics enabled, you can add more information to *Bookable Resource Characteristic* records.

A section for **Supporting Information** shows on the record. You can provide an **ID**, **Issue Date**, **Expiration Date**, and a **Description** of a characteristic that relates to a specific resource.

> [!NOTE]
> With enhanced characteristics, the system doesn't allow duplicate *Bookable Resource Characteristic* records with the same combination of **Name**, **Characteristic**, **Rating Value**, **ID**, **Issue Date**, and **Expiration Date**.

## Assign characteristics to work orders  
  
1. Open a [work order](create-work-order.md).
  
1. Select **Related** > **Characteristics**.  
  
1. On the **Requirement Characteristic Associated View** view, select **New Requirement Characteristic**.  
  
1. Choose the **Characteristic**, an optional **Rating Value**, and the related **Resource Requirement**.
  
1. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
