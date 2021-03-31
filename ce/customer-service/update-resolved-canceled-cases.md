---
title: "Allow updates to resolved and canceled cases | Microsoft Docs"
description: "Allow resolved and canceled cases to be updated through Power Automate flows"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Allow updates for resolved and canceled cases

## Overview

Based on your business requirement, sometimes, you might need to update case descriptions or other information after the cases have been resolved or canceled. For example, for General Data Protection Regulation compliance, you want to remove certain data from your case records. You can't update any details for cases if the status is resolved or canceled. However, you can update the case information by configuring and running flows in Power Automate or an API.

> [!NOTE]
> The option to update cases in resolved or canceled state is the default behavior.

## Enable settings for allowing updates to cases in resolved or canceled state

Perform the following steps to enable modifications to cases that are in the resolved or canceled state:

1. In Dynamics 365, go to Customer Service Hub.
2. In the change area, select **Service Management**.
3. In the site map, select **Service Configuration Settings** under **Service Terms**.
4. In **Case update after resolution**, select **Resolved and canceled cases** in the **Allow updates for** list if it is not selected. You can also select only **Resolved cases**, **Closed cases**, or **Don't allow updates** based on your business needs.
5. Configure flows in Power Automate or use an API.

### See also

[Automatically create or update records in Customer Service Hub](automatically-create-update-records.md)  