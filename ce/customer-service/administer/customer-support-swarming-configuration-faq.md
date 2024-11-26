---
title: "Customer support swarming configuration FAQ | MicrosoftDocs"
description: "This article answers some commonly asked questions about configuring customer support swarming for cases in Dynamics 365 Customer Service and Microsoft Teams."
ms.date: 01/04/2023
ms.topic: article
author: lalexms
ms.author: laalexan
ms.reviewer: nenellim
---
# Customer support swarming FAQ

This article contains information on frequently asked questions about configuring customer support swarming for cases in Dynamics 365 Customer Service.

## How do I sync a swarm expert who isn't a member of my organization?

Users who aren't members in your organization might not be directly synced to all of the Dynamics 365 organizations within your tenant. If you are unsure about whether a swarm expert is part of your organization, you can manually sync their membership by doing the following steps:
   1. In Power Platform admin center, go to **Environments** > **Environment name** > **Settings** > **Users + permissions** > **Users**. 
   1. On the command bar, select **+ Add user**. The **Add user** dialog is displayed on the right-hand side.
   1. Enter the user details, and then select **Add**.

## I've manually added a participant to the swarm group chat but they can't access the chat. What do I do?

If a user is manually added to a swarm, the first time they access the chat, they might encounter an error message that says they don't have access to the records. To fix this issue, perform the following steps:
   1. Go to **Advanced Settings** > **Security** > **Teams**.
   1. Select **Swarm collaborators team**, and then manually add the user to the team.
      > [!Note]
      > The Swarm collaborators team will only be available if one expert has already accepted an invite in the organization.
   1. Select **Save**.
