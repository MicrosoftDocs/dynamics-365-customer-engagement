---
title: Get email alerts for failed or canceled optimization requests
description: Use Power Automate flows to get automated email alerts if optimization jobs fail in the Resource Scheduling Optimization add-in for Dynamics 365 Field Service.
ms.date: 07/09/2024
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Get email alerts for failed or canceled optimization requests

Resource Scheduling Optimization runs can fail for various reasons. As a best practice, we recommend that you set up an automated workflow that monitors optimization jobs and sends alerts based job status. Microsoft Power Automate is a comprehensive end-to-end automation platform that you can use to help with monitoring and send alerts when failures occur.

## Create a flow in Power Automate

1. Sign in to [Power Automate](https://make.powerautomate.com/).
1. Select the environment where Resource Scheduling Optimization is installed.
1. Select **Create**, and then select **Automated cloud flow**.
1. Give your flow a name, and select the **When a row is added, modified, or deleted** trigger.
1. Configure the trigger parameters:

    - **Change Type**: *Modified*
    - **Table Name**: *Scheduling Optimization Requests*
    - **Scope**: *Organization*
    - **Selected Columns**: *modifiedon*, *mydyn_optmizationstatus*, and *optmizationId*

1. Add an action, and select **Control**.
1. Select **Condition** in the list. For alerts about any failures or cancellations in the past six hours, set up the following expression.

    ```condition expression
    AND
        modifiedon is greater than addHours(-6)
        OR
        OptimizationStatus is equal to 192350003
        OptimizationStatus is equal to 192350004
    ```

    In this expression, `192350003` represents a canceled optimization request, and `192350004` represents a failed request.

1. In the **True** branch of the condition, add an action, and select **Send an email notification (V3)**.
1. Configure the parameters for the email notification. To include column values in the subject or body, select the lightning bolt symbol, and then select the name of the column in the filter box.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
