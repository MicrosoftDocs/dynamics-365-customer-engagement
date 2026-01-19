---
title: Enable tables for queues
description: Learn how you can enable tables for queues so that they can be routed through unified routing.
ms.date: 01/19/2026
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# Enable tables for queues in unified routing

Any record that you want to enable for routing needs to be enabled for queues.

## Enable a table for queues<a name="enable-entities"> </a>

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.

2. Select **Tables** and then select the required table such as **Account** or **Email** for which you want to enable queues.

5. In **Table properties**, select **Properties**.

6. Select **Advanced options**, and then select **Can be added to a queue** in the **Rows in this table** section.

7. Select **Save**.

> [!NOTE]
>- You can't disable the table, if you enable it for a queue. The app disables the **Can be added to a queue** checkbox after you select it.
>- If you enable the option **When the rows are created or assigned, move them to the owner's default queue**, in the table customization, then the record won't be automatically distributed to the customer service representatives. You must clear the checkbox to automatically distribute the records.

<br><br> ![Automatic record movement to the representative's default queue.](../media/route-owner-queue.png "Automatic record movement to the representative's default queue")

## Enable audits for queuemembership

Auditing on an intersect (many-to-many relationship) entity in Dynamics 365 is automatically enabled as part of the auditing process for the related entities. You can’t enable or disable auditing specifically for the intersect entity itself through the user interface. The association and disassociation of records are logged as events when auditing is enabled on the primary entities involved in the relationship. 

Here's an example of queuemembership intersect entity between queue and system user.

### Prerequisites

- You must have a System Administrator or System Customizer security role.   

### Steps to enable audit

You must first enable audit at the global level (environment or organization level) and then at the entity level through the Power Platform Admin Center or the classic Dynamics 365 Advanced Settings. 

1. Enable audit at the environment level. Learn more in [Configure auditing for an environment](/power-platform/admin/manage-dataverse-auditing?tabs=new#configure-auditing-for-an-environment).
2. Enable audit on the primary entities: Queue and System user entity. Learn more in [Configure auditing for one or more tables and columns in Power Apps](/power-platform/admin/manage-dataverse-auditing?tabs=new#configure-auditing-for-one-or-more-tables-and-columns-in-power-apps).

Once auditing is fully enabled, any association or disassociation events in the (many-to-many relationship) relationship is logged in the **Audit History** of the entity.

:::image type="content" source="../media/queue-membership-audit.png" alt-text="Screenshopt of queue membership audit." lightbox="../media/queue-membership-audit.png":::

### Related information

[Set up record routing](set-up-record-routing.md)  
[Set up unified routing for email records](configure-routing-for-email-records.md)
