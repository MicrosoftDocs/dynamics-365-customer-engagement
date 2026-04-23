---
title: Configure Copilot Hub (preview)
description: Learn how to configure the Copilot Hub immersive experience in Dynamics 365 Customer Service so representatives can manage their work more efficiently.
author: laalexan
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection:
ms.date: 04/23/2026
ms.custom: bap-template
---

# Configure Copilot Hub (preview)

Copilot Hub (Copilot immersive) is an AI-powered workspace that helps customer service representatives manage their work from a single location. As an administrator, you enable Copilot immersive at the environment level, configure it in experience profiles, and manage organization-level prompts.

## Prerequisites

- You have the Dynamics 365 Customer Service Enterprise or Premium role. 
- Your organization is in a Dynamics 365 Customer Service-supported region. |

## Enable the Copilot immersive experience

You must enable Copilot Hub at both the environment level and the experience profile level.

### Enable Copilot immersive for the environment

1. In **Customer Service admin center**, go to **Productivity**.
2. Select **Copilot settings**, and then select **Manage**.
3. Turn on **Copilot immersive**.
4. Select **Save**.

### Enable Copilot immersive in experience profiles

1. In **Customer Service admin center**, go to **Workspaces** > **Experience profiles**.
2. Select the experience profile that you want to configure.
3. Ensure that **Copilot help pane** is turned on.
4. Turn on **Copilot immersive**.
5. Select **Save and close**.

All users assigned to the experience profile can access Copilot hub.

## Copilot help pane and Copilot immersive

You can enable Copilot help pane and Copilot immersive independently in an experience profile. You can enable both, either, or neither.

When a user works in Copilot Hub, the Copilot help pane isn't displayed. The help pane remains available in other sessions, such as when a user works on a case.

## Configure organization-level prompts

Administrators can create organization-level prompts that are available to all users who have access to Copilot Hub.

1. In **Customer Service admin center**, go to **Productivity** > **Copilot settings**, and then select **Manage**.
2. Under prompts, select **Add a new prompt**.
3. Enter a **prompt alias**.
4. Turn on **Show in guide** if you want the prompt to appear as a suggested prompt.
5. Select where the prompt is available:
   - **Copilot help pane**
   - **Copilot immersive**
6. Select the entity that the prompt applies to.
7. Enter the prompt instruction text.
8. Select **Save**.

## Saved prompts

Users can create and save prompts for personal use. Saved prompts are available only to the user who creates them and can't be shared or assigned through experience profiles.

Saved prompts follow the same behavior as prompts created in the Copilot help pane.

## Language support

Copilot Hub supports languages available in Dynamics 365 Customer Service. Quality might vary depending on the language.

