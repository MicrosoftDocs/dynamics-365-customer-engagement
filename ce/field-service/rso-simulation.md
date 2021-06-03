---
title: "Run resource scheduling optimization as a simulation in Dynamics 365 Field Service | Microsoft Docs"
description: Learn how to run resource scheduling optimization as a simulation in Dynamics 365 Field Service
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/17/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Run resource scheduling optimization as a simulation

Running an optimization as a simulation allows resource scheduling optimization admins to better adjust:  

- Optimization scope (include/exclude more resources)
- Objectives (reorder objective rankings)
- Other parameters

With simulation runs, admins can see what optimization results will look like for each run before locking down the recurring schedule. The simulation feature also empowers admins to review optimization results before pushing the assignments to all resources, or to discard the results and rerun by adjusting optimization parameters.

## Prerequisites

- Resource scheduling optimization version 2.6+

## How to trigger a simulation run

There are two ways to run an optimization request in simulation mode:

1. **Triggering a simulation run through the schedule board.** To do this, open the resource scheduling optimization schedule board, select **Run**, and then select **Run as Simulation**. This triggers a simulation optimization request. Selecting **Run Now** triggers a regular optimization request.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of triggering a simulation through the schedule board.](media/rso_trigger_sim_1.png)

2. **Triggering a simulation run from the optimization schedule.** While on the optimization schedule, check **Yes** for Run as Simulation. Then select **Run Now** to trigger an optimization request.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of triggering a simulation run through the optimization schedule.](media/rso_trigger_sim_2.png)

This is what an open optimization request looks like, allowing users to review simulated booking details and the optimization status.

> [!div class="mx-imgBorder"]
> ![Screenshot of an open optimization request.](media/rso_trigger_sim_3.png)

Users can also review their simulations through the resource scheduling optimization schedule board, as shown in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of simulation review through the resource scheduling optimization schedule board.](media/rso_trigger_sim_4.png)

After reviewing the results of their simulation runs, users can then apply or discard the simulation.

> [!div class="mx-imgBorder"]
> ![Screenshot showing the apply or discard option](media/rso_trigger_sim_5.png)

> [!div class="mx-imgBorder"]
> ![Screenshot showing simulation status](media/rso_trigger_sim_6.png)


[!INCLUDE[footer-include](../includes/footer-banner.md)]