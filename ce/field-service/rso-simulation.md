---
title: "Run Resource Scheduling Optimization as a simulation in Dynamics 365 Field Service | Microsoft Docs"
description: Learn how to run Resource Scheduling Optimization as a simulation in Dynamics 365 Field Service
ms.date: 07/17/2020

ms.subservice: resource-scheduling-optimization
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FeifeiQiu
ms.author: feiqiu
---

# Run Resource Scheduling Optimization as a simulation

Running an optimization as a simulation allows Resource Scheduling Optimization admins to better adjust:  

- Optimization scope (include/exclude more resources)
- Objectives (reorder objective rankings)
- Other parameters

With simulation runs, admins can see what optimization results will look like for each run before locking down the recurring schedule. The simulation feature also empowers admins to review optimization results before pushing the assignments to all resources, or to discard the results and rerun by adjusting optimization parameters.

## Prerequisites

- Resource scheduling optimization version 2.6+

## How to trigger a simulation run

There are two ways to run an optimization request in simulation mode:

1. **Triggering a simulation run through the schedule board.** To do this, open the Resource Scheduling Optimization schedule board, select **Run**, and then select **Run as Simulation**. This triggers a simulation optimization request. Selecting **Run Now** triggers a regular optimization request.

2. **Triggering a simulation run from the optimization schedule.** While on the optimization schedule, check **Yes** for Run as Simulation. Then select **Run Now** to trigger an optimization request. This open optimization request allows users to review simulated booking details and the optimization status. Users can also review their simulations through the Resource Scheduling Optimization schedule board.

After reviewing the results of their simulation runs, users can then apply or discard the simulation.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
