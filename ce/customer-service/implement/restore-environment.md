---
title: Reset, restore, recover omnichannel environments
description: Follow these steps to reset,restore or recover a Dynamics 365 environment that includes omnichannel capabilities.
author: neeranelli
ms.author: nenellim
ms.reviewer: 
ms.topic: how-to
ms.collection: 
ms.date: 08/12/2024
ms.custom: bap-template
ai.usage: ai-assisted
---

# Reset, restore, recover omnichannel environments

In your omnichannel environments, you can manage various events and operations that are essential to maintain and oversee your organization's environments within specific platforms or systems.

You can reset, restore, or recover your omnichannel environments.

## Reset organization

This operation restores the environment to its original state. It can be used create a new project, free up storage space, and remove an environment containing personal data. In Power Platform admin center, follow the steps in [Reset environment](/power-platform/admin/reset-environment) to reset the environment.

After you reset the environment, you must provision the channels again to use omnichannel capabilities. Learn more at [provision channels](omnichannel-provision-channels.md).

## Restore organization

This process involves returning the environment to a previous state using a backup or restore point to recover data and ensure continuous availability of service. To restore the environment, perform the steps in [Restore environment](/power-platform/admin/backup-restore-environments) in Power Platform admin center.

After you restore the environment, you must provision the channels again to use omnichannel capabilities. Learn more at [provision channels](omnichannel-provision-channels.md).

## Recover organization

This process retrieves a recently deleted environment, restoring it to its state before deletion. It's useful for recovering an environment that was accidentally deleted, along with all its data and configurations. In Power Platform admin center to perform the steps in [Recover environment](/power-platform/admin/recover-environment) to revert to the default settings.

Recovering a deleted environment restores the omnichannel environment to its state prior to deletion.

## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
