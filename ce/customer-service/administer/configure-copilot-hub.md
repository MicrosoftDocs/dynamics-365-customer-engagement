---
title: Configure Copilot Hub (preview)
description: Learn how to configure the Copilot Hub immersive experience in Dynamics 365 Customer Service so representatives can manage their work more efficiently.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection:
ms.date: 04/23/2026
ms.custom: bap-template
---

# Configure Copilot Hub (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Copilot Hub (Copilot immersive) is an AI-powered workspace that helps customer service representatives manage their work from a single location. As an administrator, you enable Copilot immersive at the environment level, configure it in experience profiles, and manage organization-level prompts.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- You have the appropriate license for your configuration. Licensing requirements vary based on your organization's setup. Learn more in the [Dynamics 365 Licensing Guide](https://cdn-dynmedia-1.microsoft.com/is/content/microsoftcorp/microsoft/bade/documents/products-and-services/en-us/bizapps/Dynamics-365-Licensing-Guide-April-2026.pdf). 
- Your organization is in a Dynamics 365 Customer Service-supported region.

## Enable the Copilot immersive experience

You must enable Copilot Hub at both the environment level and the experience profile level.

### Enable Copilot immersive for the environment

1. In **Copilot Service admin center**, go to **Productivity**.
2. Select **Copilot settings**, and then select **Manage**.
3. Turn on **Copilot immersive (preview)**.
4. Select **Save**.

### Enable Copilot immersive in experience profiles

1. In **Copilot Service admin center**, go to **Workspaces** > **Experience profiles**.
2. Select the experience profile that you want to configure.
3. Ensure that **Copilot help pane** is turned on.
4. Turn on **Copilot immersive**.
5. Select **Save and close**.

All users assigned to the experience profile can access Copilot Hub.

## Copilot side pane and Copilot immersive

You can enable Copilot side pane and Copilot immersive independently in an experience profile. You can enable both, either, or neither.

When a user works in Copilot Hub, the Copilot side pane isn't displayed. The side pane remains available in other sessions, such as when a user works on a case form outside of Copilot Hub.

## Configure organization-level prompts

Administrators can create organization-level prompts that are available to all users who have access to Copilot Hub.

1. In **Copilot Service admin center**, go to **Productivity** > **Copilot settings**, and then select **Manage**.
1. In the prompts section, select **Add a new prompt**.
1. Enter a **prompt alias**, a short name users see when they select the prompt.
1. (Optional): Turn on **Show in guide** if you want the prompt to appear as a suggested prompt.
1. Select where the prompt is available:
   - **Copilot side pane**
   - **Copilot immersive**
   If you want a prompt to be available in both locations, create a separate record for each.
1. Select the entity that the prompt applies to.
1. Enter the prompt instruction text.
1. Select **Save**.

## Saved prompts

Users can create and save prompts for personal use. Saved prompts are available only to the user who creates them and can't be shared or assigned through experience profiles.

Saved prompts have a 10,000 character limit and follow the same behavior as prompts created in the Copilot help pane.

## Language support

Copilot Hub supports languages available in Dynamics 365 Customer Service. Quality might vary depending on the language.

## Related information

- [Use Copilot Hub](../use/use-copilot-hub.md)
- [Copilot Hub FAQ](../use/copilot-hub-faq.md)

