---
title: "FAQs on activity monitor for creating records automatically | Microsoft Docs"
description: "What FAQs are available for activity monitor"
author: neeranelli
ms.author: nenellim
ms.date: 04/23/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.reviewer: nenellim
---

# FAQs on create records automatically and activity monitor

This article contains information on frequently asked questions on the create record automatically and activity monitor features in Customer service.

## What are the scenarios in which the rule skips from creating records automatically?

Some of the scenarios in which the automatically create records rule skips are explained as follows:

### Reason 1

Email is from an unknown sender.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, check or select **Yes** for **Allow emails from unknown senders**, and choose an option in **Manage unknown senders by** according to your business needs. More information: [Configure advanced settings for rules](automatically-create-update-records.md#configure-advanced-settings-for-rules).

### Reason 2

A resolved case is already connected with this record.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, check or select **Yes** for **Wait for a specific amount of time after the connected case has been resolved**, and specify the time in the **Select the amount of time** option. More information: Configure advanced settings for rules.

### Reason 3

No valid entitlement for this email sender.

**Resolution**: On the **Advanced** tab of the **Record creation and update rule** page, select **No** for **Require a valid entitlement on the connect case**

### Reason 4

No applicable reason can be specified.

**Resolution**: if reason is empty and state says **Ready for workflow/Power automate**, and case doesn't get created, then  check systemjobs if legacy rule or check flow runs if modern rule
