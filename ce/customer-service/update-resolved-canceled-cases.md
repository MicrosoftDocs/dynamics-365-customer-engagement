---
title: "Allow updates to resolved and canceled cases | Microsoft Docs"
description: "Allow resolved and canceled cases to be updated through Power Automate flows, API"
ms.date: 06/12/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Allow updates for resolved and canceled cases

## Overview

Based on your business requirements, you might need to update case descriptions or other information after the cases have been resolved or canceled. For example, for General Data Protection Regulation compliance, you want to remove certain data from your case records. You can't update any details for cases if the status is resolved or canceled. However, you can update such case information by configuring and running flows in Power Automate or an API without having to reopen the case records in the UI.

> [!NOTE]
> The option to update cases in resolved or canceled state is the default behavior.

## Enable settings for allowing updates to cases in resolved or canceled state

Perform the following steps to enable modifications to cases that are in the resolved or canceled state:

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
     
     1. In the site map, select **Case Settings** in **Customer Support**. The **Case Settings** page appears.
     
     1. Select **Manage** for **Other settings**.

   ### [Customer Service Hub](#tab/customerservicehub)
   
     1. In the **Service Management** site map, select **Service Configuration Settings** in **Service Terms**. 
    
2. In **Case update after resolution**, select **Resolved and canceled cases** in the **Allow updates for** list if it is not selected. You can also select only **Resolved cases**, **Closed cases**, or **Don't allow updates** based on your business needs. 
1. Configure flows in Power Automate or use an API that can be run to update the case records.

### See also

[Automatically create or update records in Customer Service Hub](automatically-create-update-records.md)  
