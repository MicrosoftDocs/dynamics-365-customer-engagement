---
title: Enable custom entities for service-level agreements
description: Enable custom entities for service-level agreements to use custom entities based on user requirements.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.collection:
ms.date: 12/06/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:12/01/2023
---

# Enable custom entities for service-level agreements

You can enable custom entities for service-level agreements so that users can use their own custom entities based on their requirements. You can enable custom entities either through the Power Apps portal or through your Dynamics 365 Customer Engagement (on-premises) organization.

## Prerequisites

Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

## Enable from Power Apps

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Select **Solutions** > **Default Solution**.
1. From **Objects**, select **Table**.
1. Find the custom entity page name on the list and open it.
1. On the custom entity page, **Table properties** section, select **Properties**.
    1. On the **Edit table** dialog, expand **Advanced options**.
    1. Go to the **Make this table an option when** section and select the **Setting up service level agreements** checkbox.
    1. Select **Save**.
1. On the custom entity, select **Schema** > **Columns**, and then select **New Column**. On the **New column** dialog,
    1. Enter a **Display name**.
    1. For **Data Type**, select **Lookup**.
    1. For **Related table**, select **SLA KPI Instance**.  
    1. Select **Save**.
1. On the custom entity page, select **Advanced** > **Publish table**.
1. Go back to **Solutions** and select **Publish all customizations**.

## Enable from your Dynamics 365 Customer Engagement (on-premises) organization

1. Sign in to your Dynamics 365 Customer Engagement (on-premises) instance.
1. Go to **Settings** > **Advanced Settings** > **Customizations** > **Customize the System** to open the default solution.
1. Select **Entities**.
1. Find the custom entity from the list and open it.
1. In the **General** tab, **Communication & Collaboration** section, select the **Enable for SLA (Fields will be created)** checkbox.
1. Select **Save and close**. SLA is enabled for the custom entity.
1. To create **SLA KPI Instance** fields for the custom entity, from **Entities**, search for the custom entity **Widget**.
1. From **Widget**, select **Fields**, and then select **New**.
1. In the **New for Widget** dialog, **General** tab, **Type** section, do the following steps:
    1. For **Data Type**, select **Lookup**.
    1. For **Target Record Type**, select **SLA KPI Instance**.
    
    **Relationship Name** automatically appears in the format: (Target Record Type)_ (Entity Name)_ (Field Name). For example, slakpiinstance_new_widget_Custom_Field_KPI.
1.	Select **Save and close**, and then select **Publish All Customizations**.

## Related information

[Enable entities for service level agreements](enable-entities-service-level-agreements.md#enable-entities-for-service-level-agreements)
