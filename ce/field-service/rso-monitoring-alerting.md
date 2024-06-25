---
title: Get email alerts for failed or cancelled optimization requests
description: Use Power Automate flows to get automated email alerts if optimization jobs fail in the Resource Scheduling Optimization add-in for Dynamics 365 Field Service.
ms.date: 06/25/2024
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Get email alerts for failed or cancelled optimization requests

Resource Scheduling Optimization runs can fail due to various reasons. As a best practice, we recommend that you set up an automated workflow that monitors optimization jobs and alerts based on the status a job. Microsoft Power Automate is a comprehensive end-to-end automation platform that you can use to help monitor and alert when such failures happen.

## Create the flow in Power Automate

1. Sign in to [Power Automate](https://make.powerautomate.com/).
1. Choose the environment where Resource Scheduling Optimization is installed.
1. Select **Create** and choose **Automated cloud flow**.
1. Give your flow a name and select the **When a row is added, modified or deleted** trigger.
1. Configure the trigger parameters:

   - Change Type: Modified
   - Table Name: Scheduling OPtimization Requests
   - Scope: Organization
   - Selected Columns: modifiedon, mydyn_optmizationstatus, optmizationId

1. Add an action and select **Control**.
1. Choose **Condition** from the list. To alert on any failures or cancellations in the past 6 hours, set up the following expression:

   ```condition expression
   AND
      modifiedon is greater than addHours(-6)
      OR
      OptimizationStatus is equal to 192350003
      OptimizationStatus is equal to 192350004
   ```

1. In the **True** branch of the condition, add an action and choose **Send an email notification (V3)**.
1. Configure the parameters for the email notification. To include column values in the subject or body, select the lightning and choose the name of the column in the filter box.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
