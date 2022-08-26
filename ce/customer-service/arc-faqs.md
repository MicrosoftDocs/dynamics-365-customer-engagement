---
title: "FAQ on activity monitor for creating records automatically | Microsoft Docs"
description: "This article answers some commonly asked questions about automatic record creation and activity monitoring in Dynamics 365 Customer Service."
ms.date: 05/18/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# FAQ about creating records automatically and activity monitor

This article contains information on frequently asked questions about the automatic record creation and activity monitor features in Dynamics 365 Customer Service.

## What are the scenarios in which the rule skips creating records automatically?

The automatic record creation rule doesn't create records in the following scenarios:

### Reason 1

Email is from an unknown sender.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **Yes** for **Allow emails from unknown senders**, and choose an option in **Manage unknown senders by** according to your business needs. More information: [Configure advanced settings for rules](automatically-create-update-records.md#configure-advanced-settings-for-rules).

### Reason 2

A resolved case is already connected with this record.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **Yes** for **Wait for a specific amount of time after the connected case has been resolved**, and specify the time in the **Select the amount of time** option. More information: [Configure advanced settings for rules](automatically-create-update-records.md#configure-advanced-settings-for-rules).

### Reason 3

No valid entitlement for this email sender.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **No** for **Require a valid entitlement on the connect case**.

### Reason 4

No applicable reason can be specified.

**Resolution**: If the reason is empty and the state says **Ready for workflow/Power automate**, and the case doesn't get created, then check system jobs if it's a legacy rule, or check flow runs if it's a modern rule.
