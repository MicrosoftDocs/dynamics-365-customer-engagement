---
title: "Recovering an Internet Explorer process instance in Unified Service Desk | MicrosoftDocs"
description: "Learn about recovering an Internet Explorer process instance"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 02/06/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---
# Recover an Internet Explorer process instance

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Internet Explorer process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, Internet Explorer process instance recovery is enabled. To disable the feature, a system administrator must configure the `IEWebPageRecovery` option on the **Active UII Options** page, and set it to **false**. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage a Unified Service Desk option](../admin/manage-options-unified-service-desk.md)

### Disable IEWebPageRecovery option

1. Sign in to Dynamics 365.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**. 

4. Select **Options** under **Advance Settings** in the sitemap.

5. Select **+ New** in the **Active UII Options** page.

6. Choose **Others** for the **Global Option** field.

7. Type **IEWebPageRecovery** for the **Name** field.

8. Type **false** for the **Value** field.

9. Select **Save**.

<a name="BKMK_When_Unified_Service_Desk_can_help_recover_the_Internet_Explorer_process_instances"></a>
## When [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help recover Internet Explorer process instances

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover an Internet Explorer process instance in the following scenarios:

- When Internet Explorer closes abruptly.
- When you manually end an unresponsive Internet Explorer process instance from Task Manager.
- When a script on the hosted control that uses `IE process` browser control takes time more than the timeout period ([IEWebPageInactivityTimeout](#change-iewebpageinactivitytimeout-option)) for page navigation.

<a name="BKMK_recover_unresponsive_Internet_Explorer_process_instance"></a>
## Recover an unresponsive Internet Explorer process instance

When a hosted control that uses an Internet Explorer process browser control closes abruptly, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays the message **Internet Explorer closed abruptly**.

![Internet Explorer closed abruptly](../../unified-service-desk/media/usd-ie-closed-abruptly-33update.PNG "Internet Explorer closed abruptly")

To recover the closed instance (which may contain more than one webpage), select **Reload**. After you select **Reload**, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] reloads the webpage to the last known URL. That is, when you open an **Account** Internet Explorer webpage and navigate inline to a **Case** Internet Explorer webpage. If the **Case** webpage becomes unresponsive, the recovery feature reloads only the **Account** webpage.

If you do not want to recover, select **Cancel**. If you cancel, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application skips recovery of the Internet Explorer process instance and displays a message, **The webpage stopped responding. If you frequently experience unexpected closing of Internet Explorer webpage, contact your system administrator**.

![Cancel to skip the recovery of Internet Explorer webpage](../../unified-service-desk/media/usd-ie-closed-abruptly-cancel.PNG "Cancel to skip the recovery of Internet Explorer webpage")

<a name="BKMK_recover_when_using_RunScript_on_a_hosted_control"></a>
## Recover when script executed on the webpage causes the webpage to run slowly

If a script running on a Internet Explorer causes the Internet Explorer webpage to run slowly, then [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] waits until the timeout period ([IEWebPageInactivityTimeout](../admin/recover-internet-explorer-process-instance.md#change-iewebpageinactivitytimeout-option)) to display the message - **A script on \<Hosted Control Name> is causing the Internet Explorer webpage to run slowly**.

To recover the webpage, select **Reload**. After you select **Reload**, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] reloads the webpage to the last known URL.

Select **Stop** if you want to terminate and do not want to recover the webpage on which the script is executed. 

If you want to wait for the Internet Explorer webpage to respond, select **Continue**, and wait for the Internet Explorer webpage to respond. If the webpage does not respond, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays the window again after the timeout period.

The following list shows the options and descriptions to select when you see the message window. 

| Option   | Description                                                                                                                                                                                                               |
|:---------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Reload   | Recovers the Internet Explorer webpage.                                                                                                                                                                                   |
| Stop     | Terminates and does not to recover the Internet Explorer webpage.                                                                                                                                                         |
| Continue | Waits until the Internet Explorer webpage to respond. If the webpage does not respond, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays the window again after the timeout period. |

![Script causing Internet Explorer webpage to run slowly](../../unified-service-desk/media/usd-ie-runscript.PNG "Script causing Internet Explorer webpage to run slowly")

> [!Note]
> If there are other webpages that are unresponsive, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays the message - **Internet Explorer closed abruptly.** <br><br>
> Select **Reload** to recover the webpage to the last known URL. Or, select **Cancel** to not to recover the webpage.</br>
> ![Internet Explorer closed abruptly](../../unified-service-desk/media/usd-ie-closed-abruptly-33update.PNG "Internet Explorer closed abruptly")

### Change IEWebPageInactivityTimeout option

**IEWebPageInactivityTimeout** Indicates the timeout period for the duration (in milliseconds) that the Unified Service Desk waits before displaying a message - **A script on \<Hosted Control Name> is causing the Internet Explorer webpage to run slowly**.

By default, the **IEWebPageInactivityTimeout** is enabled and timeout period is 15000 milliseconds (15 seconds).
To change the default timeout period, a System Administrator must configure the **IEWebPageInactivityTimeout** on the **Active UII Options** page and type the value in milliseconds. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md).
If you set the value as 0 milliseconds, then the **IEWebPageInactivityTimeout** is disabled.

To change the **IEWebPageInactivityTimeout** timeout value:

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**. 

4. Select **Options** under **Advance Settings** in the sitemap.

5. Select **+ New** in the **Active UII Options** page.

6. Choose **Others** for the **Global Option** field.

7. Type **IEWebPageInactivityTimeout** for the **Name** field.

8. Type the value in milliseconds for the **Value** field.

9. Select **Save**.

<a name="Terminate_recover_unresponsive_Internet_Explorer_process_instance using_keyboard_shortcut"></a>
## Terminate and recover unresponsive Internet Explorer process instances using a keyboard shortcut

When the Internet Explorer webpage is unresponsive and causes the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to freeze, hover the cursor on the unresponsive tab and use the keyboard shortcut **Ctrl+Alt+K** to terminate. 

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays a dialog box: **You have chosen to end the Internet Explorer process that is active in Unified Service Desk by pressing Ctrl+Alt+K. Do you want to continue?**. 

![Keyboard shortcut to terminate and not to recover Internet Explorer webpage](../../unified-service-desk/media/usd-ie-terminate-shortcutkey.PNG "Keyboard shortcut to terminate and not to recover Internet Explorer webpage")

Select **Yes** to terminate the Internet Explorer process instance. Select **No** to cancel the operation.

After you end the Internet Explorer process instance, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays a message, **Internet Explorer closed abruptly**. Select **Reload** to recover the closed Internet Explorer process instance. If you do not want to recover, select **Cancel**.

![Internet Explorer closed abruptly](../../unified-service-desk/media/usd-ie-closed-abruptly-33update.PNG "Internet Explorer closed abruptly")

> [!Note]
> - An agent must wait for the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring process (usdmp.exe) to detect and terminate the unresponsive Internet Explorer process instance.</br>
> - The agent must use the keyboard shortcut as last option when the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring process fails to detect the unresponsive Internet Explorer process instance.</br>
> - Using the keyboard shortcut may terminate any Internet Explorer webpage, causing you to lose any unsaved work.

### Change keyboard shortcut

To change the keyboard shortcut:

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**. 

4. Select **Options** under **Advance Settings** in the sitemap.

5. Select **+ New** in the **Active UII Options** page.

6. Choose **Others** for the **Global Option** field.

7. Type **On-DemandIETerminationShortcut** for the **Name** field.

8. Type the keyboard shortcut in the format _key1+key2+key3_ for the **Value** field.

9. Select **Save**.

![Change On-DemandIETerminationShortcut](../../unified-service-desk/unified-interface/media/crm-usd-options-on-demand-ie-termination-shortcut.PNG "Change On-DemandIETerminationShortcut")

<a name="BKMK_Limitations"></a>
## Limitations 

- When you recover an Internet Explorer webpage, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] triggers again all the events that associate with the webpage. </br>
  For example: </br> **TaskUpdated** is a event configured for the **Agent Scripting** hosted control (webpage) and has **Action Call for Reminder** and **Action Call for Resolve Case** as Action Calls. 
  If you recover **Agent Scripting** webpage, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] triggers again the **TaskUpdated** event and the **Action Calls**. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Events](../events.md)

- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] does not recover inline navigation of an Internet Explorer webpage.</br>
  For example: </br>
  You open an **Account** Internet Explorer webpage and navigate inline to a **Case** Internet Explorer webpage. If the **Case** webpage becomes unresponsive, the recovery feature reloads only the **Account** webpage and not the **Case** webpage.

- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] does not recover unsaved work. </br>
  For example: </br>
  You open an **Account** Internet Explorer webpage and navigate inline to a **Case** Internet Explorer webpage, and enter details on the **case** webpage. If the **Case** webpage becomes unresponsive, the recovery feature reloads only the **Account** webpage and not the **Case** webpage. You may lose any unsaved data that you had entered in the **Case** webpage.

- If the web browser runs slowly while executing a script, and you choose **Stop** to terminate and not to recover the Internet Explorer webpage, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] may terminate other Internet Explorer webpages.

- Using **Ctrl+Alt+K** keyboard shortcut may terminate other Internet Explorer webpage, causing you to lose any unsaved work.

## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]