---
title: Manage canvases in CRM Canvas Designer (preview)
description: Learn how to manage canvas access, roll out canvases to a pilot group, switch canvases, roll back published versions, and delete custom canvases.
author: udag
ms.author: udag
ms.reviewer: dancost
ms.date: 11/17/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - ignite-2026
ms.collection: bap-ai-copilot
ai-usage: ai-generated
---

# Manage canvases in CRM Canvas Designer (preview)

Use the canvases list in Canvas studio to choose where published canvases appear and who sees them. You can roll out a canvas to a pilot group, switch the canvas used for a table, or delete a custom canvas. Use the canvas designer to review published versions and roll back changes.

To create a canvas, customize its sections and components, or publish design changes, see [Configure a canvas in CRM Canvas Designer](configure-canvas.md).

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- You have the **App Profile Manager Administrator** security role. Learn more in [Security roles](../customer-service/administer/security-roles.md).
- For access configuration and rollout, the canvas is published. For publishing instructions, see [Publish the canvas and choose who sees it](configure-canvas.md#publish-the-canvas-and-choose-who-sees-it).

## Roll out a canvas to a pilot group

Start with a small group, such as a few sellers or one team, before you make a canvas available to everyone.

1. If the canvas isn't published, [publish it](configure-canvas.md#publish-the-canvas-and-choose-who-sees-it).
2. In the canvases list, select the checkbox next to only that canvas, and then select **Configure**. **Configure** is available only when one canvas is selected.
3. On **Choose apps**, select the apps where the canvas appears, such as Sales Hub or Copilot Service workspace. This step and the next one look the same as in the guided setup.
4. On **Users**, select the **People** tab or the **Roles** tab, and then select the people or security roles in your pilot group.
5. On **Review configuration**, check the apps and people, and then save.

    :::image type="content" source="media/configure-review.png" alt-text="Screenshot of reviewing the apps, roles, and people before you save.":::

People in your pilot group see the canvas the next time they open a record. Everyone else keeps the classic form.

> [!NOTE]
> The people and roles you select get all the canvases that are enabled, not just the one you're configuring.

To add more people later, select the canvas, select **Configure** again, and add people or roles.

## Switch a table to a different canvas

Each table uses one canvas at a time. For example, after you build your own account canvas, you can switch from the default account canvas to your canvas.

1. Publish the new canvas.
2. In the canvases list, select the checkbox next to the custom canvas, and then select **Configure**.
3. In **Replace the *canvas name* canvas?**, select **Continue**. Nothing changes until you save on the last step.
4. Choose the apps and people, and then review your changes. The review shows which canvas the new one replaces.
5. Save your changes.

The previous canvas is disabled but isn't deleted. To switch back, configure the previous canvas again.

## Roll back to an earlier version

Each publish creates a new numbered version. Only published versions are listed in **Revision history**. If you never published the canvas, there's nothing to roll back to.

1. In the canvases list, select the canvas, and then select **Edit** to open the canvas designer.
2. Select **History**. **Revision history** lists each published version, with its number, who published it, and when.
3. Select **Roll back** on the version you want.

Rolling back publishes the earlier version again as a new version. People see it the next time they open a record. No version is deleted.

## Delete a canvas

Follow these steps to delete a canvas that's in use. You can't delete default canvases, such as **Account**, **Contact**, **Opportunity**, and **Case**.

1. Select the canvas you want to delete.
1. Select **Configure** and remove the associated apps and users.
1. Select **Save**.
1. In the canvases list, select the canvas you want to delete, and then select **Delete**.
1. Confirm the deletion.

Deleting a canvas also deletes all its published versions. You can't undo this action.

## Related content

- [Configure a canvas in CRM Canvas Designer](configure-canvas.md).
- [Overview of CRM Canvas Designer](canvas-overview.md).
- [Use the canvas experience for accounts](use-account-canvas.md).
