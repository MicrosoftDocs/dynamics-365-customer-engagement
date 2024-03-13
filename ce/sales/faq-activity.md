---
title: Activity management FAQs
description: Get answers to frequently asked questions about the Activity management.
ms.date: 3/15/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Activity management FAQs

This article answers frequently asked questions about the Activity management in Dynamics 365 Sales, Sales premium, and Sales professional.

## I'm redirected to the default tab when I save an appointment from a non-default tab. Why?

This is by design. If the SchedulingEngine feature is enabled for appointments, you're redirected to the default tab, when you save the appointment from a non-default tab.

## Why are appointments saved automatically even when there's a custom script to stop automatic saving?

This is by design. If the SchedulingEngine feature is enabled for appointments, the system overrides any custom script and saves the appointments automatically.

## Why does the Open Record Set button disappear when an appointment is saved?

If the SchedulingEngine feature is enabled for appointments, the **Open Record Set** button disappears when you select **Save** but reappears when you refresh the page. For more information, go to [Open Record Set](/powerapps/user/navigation#record-set-navigation).

## Why are synchronized appointments from Outlook shown as unsaved in Dynamics 365?

This is by design. Disable the automatic save option in Dynamics 365 to show synchronized appointments from Outlook as saved in Dynamics 365.

## Why can't I see the What's new functionality in Unified Interface?

This is by design. The What's new functionality is only available in the legacy web client. The equivalent in Unified Interface is to insert the Timeline control (with posts enabled) on the dashboard:

1. In your app, select **Settings** ![Settings.](media/settings-icon.png), and then select **Advanced Settings**.

    The **Business Management** page opens in a new browser tab.

1. On the navigation bar, select **Settings**, and then under **Customization**, select **Customizations**.

1. Select **Customize the System**.

1. Under **Components** in the solution explorer, select **Dashboards**.

1. Select and open the dashboard to which you want to add the Timeline control.

1. On the toolbar at the top of the page, select **Timeline**.

1. Update the **Timeline Control Properties** as required, and then select **OK**.

1. Save the dashboard, and then publish the customization.

