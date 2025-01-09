---
title: "Recover unresponsive Chrome process instances | MicrosoftDocs"
description: "Learn how to recover Chrome process instances in Unified Service Desk. Also, know how to use keyboard shortcuts to terminate and recover such instances."
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - admin
ms.custom: evergreen
monikerRange: '>= dynamics-usd-4.1'
---

# Recover a Chrome Process instance



[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Chrome Process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, Chrome Process instance recovery is enabled.

## When Unified Service Desk can help recover Chrome Process instances

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover an Chrome Process instance in the following scenarios:

- When Chrome Process closes abruptly.
- When you manually end an unresponsive Chrome Process instance from Task Manager.
- When you manually end an unresponsive Chrome Process instance using a keyboard shortcut.

## Recover an unresponsive Chrome Process instance

When a hosted control that uses an Chrome Process browser control closes abruptly, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays the message **Chrome Process closed abruptly**.

 > [!div class="mx-imageBorder"]
 > ![Chrome Process closed abruptly.](../../unified-service-desk/media/usd-chrome-process-closed-abruptly.PNG "Chrome Process closed abruptly")

To recover the closed instance (which may contain more than one webpage), select **Reload**. After you select **Reload**, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] reloads the webpage to the last known URL.

 > [!div class="mx-imageBorder"]
 > ![Chrome Process closed abruptly. Select Relod to recover the Process.](../../unified-service-desk/media/usd-chrome-process-webpage-closed-abruptly-gif.GIF "Chrome Process closed abruptly")

 In the above illustration, the **Customer Service Dashboard** application is hosted using the **Chrome Process**. The Chrome Process instance closed abruptly and selecting the **Reload** option loads tha **Customer Service Dashboard** application.

If you don't want to recover, select **Cancel**. If you cancel, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application skips recovery of the Chrome Process instance and displays a message, **The webpage stopped responding. If you frequently experience unexpected closing of Chrome Process webpage, contact your system administrator**.

 > [!div class="mx-imageBorder"]
 > ![Cancel to skip the recovery of Chrome Process webpage.](../../unified-service-desk/media/usd-chrome-process-closed-abruptly-cancel.PNG "Cancel to skip the recovery of Chrome Process webpage")

## Use keyboard shortcut to terminate and recover unresponsive Chrome Process instance

When the Chrome Process webpage is unresponsive and causes the webpage to freeze, select the webpage and use the keyboard shortcut **Ctrl+K** to terminate. Use the mouse to click anywhere on the webpage.

 > [!div class="mx-imageBorder"]
 > ![Select the form area including the application management toolbar except the tabs.](../../unified-service-desk/media/usd-chrome-process-select-form-area.PNG "Select the form area including the application management toolbar except the tabs")

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays a dialog box: **You have chosen to end the Chrome Process instance of \<name of application\> by Pressing** **CTRL** + **K** **. Do you want to continue?**. 

 > [!div class="mx-imageBorder"]
 > ![Keyboard shortcut to terminate and not to recover Chrome Process webpage.](../../unified-service-desk/media/usd-chrome-process-terminate-shortcutkey.PNG "Keyboard shortcut to terminate and not to recover Chrome Process webpage")

Select **Yes** to terminate the Chrome Process instance. Select **No** to cancel the operation.

After you end the Chrome Process instance, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays a message, **Chrome Process closed abruptly**. Select **Reload** to recover the closed Chrome Process instance. If you don't want to recover, select **Cancel**.

 > [!div class="mx-imageBorder"]
 > ![Chrome Process closed abruptly.](../../unified-service-desk/media/usd-chrome-process-closed-abruptly.PNG "Chrome Process closed abruptly")

By default, the keyboard shortcut for terminating an unresponsive Chrome Process instance is **CTRL** + **K**.

To update an additional keyboard shortcut, you must add the UII option and provide the character as the value. To learn about the allowed set of character values, see [Keys](/dotnet/api/system.windows.forms.keys?view=netframework-4.7.2#fields&preserve-view=true).

| UII option  | Example character |
|-------------|-------------------|
| On-DemandChromeProcessTerminationShortcut | `B` |

Now as per the above example, the keyboard shortcut for terminating an unresponsive Chrome Process instance is **CTRL** + **B**.

> [!NOTE]
> You must ensure that character you update for the UII option doesn't conflict with your existing keyboard shortcuts.

### Change keyboard shortcut

To change the keyboard shortcut:

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**. 

4. Select **Options** under **Advance Settings** in the sitemap.

5. Select **+ New** in the **Active UII Options** page.

6. Choose **Others** for the **Global Option** field.

7. Type **On-DemandChromeProcessTerminationShortcut** for the **Name** field.

8. Type the character value for the **Value** field. <br>See the list of [value keys](/dotnet/api/system.windows.forms.keys#fields).

9. Select **Save**.

## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)

[Use Chrome Process to host web application](../chrome-process.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
