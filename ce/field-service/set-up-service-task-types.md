---
title: Set up service task types
description: Learn how to set up service task types in Dynamics 365 Field Service.
ms.date: 06/25/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---
# Set up service task types

In Dynamics 365 Field Service, service task types define the types of service tasks that a field technician performs at a service location. Use them to create process steps or checklists that the field technician follows when they complete a work order. For example, on a work order for the replacement of a refrigerator's compressor, a service task type list can show five important steps in the processes. The field technician can then mark each task as it's completed.

You add service tasks either manually or by associating incident types with each work order. You can assign a duration to each service task. This duration rolls up to the work order duration.

1. In Field Service, select the **Settings** area.
1. Under **Work orders**, select **Service Task Type**.
1. Select **New**.
1. Enter the following information:

    - **Name**: Enter a name for the service task type.
    - **Estimated Duration**: Specify how long the service task takes a technician to complete.
    - **Has Inspection**: Set this option to *Yes* if the service task type is [associated with an inspection](inspections.md#associate-the-inspection-to-a-service-task-type).
    - **Description**: Enter a description of the service task.

1. Select **Save**.
1. In the **Notes** section, enter any other notes about the service task.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
