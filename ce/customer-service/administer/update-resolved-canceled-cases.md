---
title: Allow updates to resolved and canceled cases
description: Allow resolved and canceled cases to be updated through Power Automate flows, API.
ms.date: 06/21/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Allow updates for resolved and canceled cases

You might need to update case descriptions or other information after the cases are resolved or canceled. For example, for General Data Protection Regulation compliance, you want to remove certain data from your case records. You can't update any details for cases if the status is resolved or canceled. However, you can update such case information using Power Automate flows or an API without having to reopen the case.

> [!NOTE]
> The option to update cases in resolved or canceled state is the default behavior.

## Enable settings for allowing updates to cases in resolved or canceled state

Perform the following steps to enable modifications to cases that are in the resolved or canceled state:

1. In the site map of Customer Service admin center, select **Case Settings** in **Customer Support**. The **Case Settings** page appears.

1. Select **Manage** for **Other settings**.

1. In **Case update after resolution**, select **Resolved and canceled cases** in the **Allow updates for** dropdown if it isn't selected. You can also select only **Resolved cases**, **Closed cases**, or **Don't allow updates** based on your business needs.

1. Configure flows in Power Automate or use an API to update the case records.

### Related information

[Automatically create or update records in Customer Service Hub](automatically-create-update-records.md)  
