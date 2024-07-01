---
title: Set up service task types
description: Learn how to set up service task types in Dynamics 365 Field Service
ms.date: 06/25/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---
# Set up service task types

Service task types in Dynamics 365 Field Service define the "types" of service tasks that  a field technician performs at the service location. Use them to create process steps or checklists for the field technician to follow when completing a work order. Service tasks are added manually or by associating incident types with each work order. They can be assigned a duration that rolls up to the work order duration.  
  
For example, in a work order that calls for replacing the compressor of a refrigerator, a service task type list can show five important steps in the processes. The field technician can then mark each task as it is completed.  
  
1. In **Field Service**, change to the **Settings** area. Then under **Work orders**, select **Service Task Type**.  
  
1. Select **New**.  
  
1. Enter the following information:

   - **Name**: Name for the service task type.

   - **Estimated Duration**: How long the service task takes a technician.  
  
   - **Has Inspection**: Yes if this service task type is [associated with an inspection](inspections.md#associate-inspection-to-service-task-type).

   - **Description**: Description for the task.  
  
1. Select **Save**.  
  
1. In the **Notes** section, enter any other notes regarding the task.  
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
