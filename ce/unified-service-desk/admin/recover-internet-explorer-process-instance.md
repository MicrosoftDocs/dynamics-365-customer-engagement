---
title: "Reload Internet explorer process instance in Unified Service Desk | MicrosoftDocs"
description: "Learn about recovering the internet explorer process instance"
ms.custom: ""
ms.date: 01/25/2018
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 1AEA6B45-3646-400D-B0C1-08B503897E8D
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Recover Internet Explorer process
The `IE process` browser control hosts your controls in individual Internet Explorer process instances, and displays them in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. Internet Explorer process (IEWebPageRecovery) recovery feature enables you to reload any Internet Explorer process instance (may have more than one webpage) that are unresponsive in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. 

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] does not recover an inline navigation of an Internet Explorer webpage. 
For example, you open an **Account** Internet Explorer webpage and perform an inline navigation to a Case Internet Explorer webpage. If the **Case** Internet Explorer webpage becomes unresponsive. The recovery feature reloads only the **Account** Internet Explorer webpage and not **Case** Internet Explorer webpage.
By default, the Internet Explorer process instance recovery feature is enabled. However, to disable the feature, administrator must configure the option the option and set it to **false**. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage a Unified Service Desk option](../admin/manage-options-unified-service-desk.md)

<a name="BKMK_When_you_can_recover_the_Internet_Explorer_process_instances"></a>
## When you can recover the Internet Explorer process instances

You can recover the Internet Explorer process instance in the following scenarios:

- When Internet Explorer closes abruptly.
- When Internet Explorer webpage is unresponsive.
- When you manually end an unresponsive Internet Explorer process instance from Task Manager.
- When a script on the hosted control that uses `IE process` browser control takes time more than the timeout period for page navigation.
- When you use the keyboard shortcut to manually terminate the Internet Explorer webpage.

<a name="BKMK_recover_unresponsive_Internet_Explorer_process_instance"></a>
## Recover unresponsive Internet Explorer process instance

You can re the Internet Explorer process instance in the following ways:

When a hosted control that uses IE process browser control closes unexpectedly, Unified Service Desk client application displays a window, which reads – **Internet Explorer closed abruptly**.

To recover the closed Internet Explorer process instance (may contain one more webpages), select the **Reload** option in the window. If you do not want to recover, select the **Cancel** option. The [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application skips the recovery of the Internet Explorer process instance and displays a message, which reads – **The webpage stopped responding. If you frequently experience unexpected closing of Internet Explorer webpage, contact your system administrator**.

The list provides the option and description.

|Option|Description|
|:------|:------|
|Reload|Recovers the Internet Explorer process instance|
|Option|Skips the recovery of the Internet Explorer process instance|

<a name="BKMK_recover_when_using_RunScript_on_a_hosted_control"></a>
## Recover when using RunScript on a hosted control

A script running on the hosted control causes the Internet Explorer webpage to run slowly. If you have configured the **IEWebPageInactivityTimeOut** UII option, then [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] waits until the timeout period. By default, the **IEWebPageInactivityTimeOut** timeout period is 15000 milliseconds (15 seconds).

> [!Note]
> - To change the default timeout period, System Administrator need to configure the **IEWebPageInactivityTimeOut** on the **Active UII Options** page and type the value. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md).
> - If you set the value as 0 milliseconds, then the **IEWebPageInactivityTimeOut** is disabled.

After the timeout period, [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays a message window, which reads - **A script on \<Hosted Control Name> is causing the Internet Explorer webpage to run slowly**. 

To recover the Internet Explorer webpage, select the **Reload** option. If you want to end and not to recover the Internet Explorer webpage, select the **Stop** option. If you want to wait for the Internet Explorer webpage to respond, select the **Continue** option.

After you select **Continue** and wait for the Internet Explorer webpage to respond, if the Internet Explorer webpage does not respond, the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays the window again after the timeout period.

The list provides the set of options and descriptions to select when you see the message window.

|Option|Description|
|:------|:------|
|Reload|Recovers the Internet Explorer webpage|
|Stop|Terminates and does not to recover the Internet Explorer webpage.|
|Continue|Wait until the Internet Explorer webpage to respond|

If the webpage runs slowly while executing a script on the `IE process` browser hosting hosted control, and when you select the **Reload** option, the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays another window, which reads – **Internet Explorer closed abruptly.** Select the **Reload** option again to recover the Internet Explorer webpage.

> [!Note]
> If the web browser runs slowly while executing a script, and you choose the **Stop** option to terminate and not to recover the Internet Explorer webpage, the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] may terminate other Internet Explorer webpages.

<a name="Recover_unresponsive_Internet_Explorer_process_instance using_keyboard_shortcut"></a>
## Recover unresponsive Internet Explorer process instance using keyboard shortcut

When the Internet Explorer webpage is unresponsive and causes the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to freeze, hover the cursor on the unresponsive tab and use the keyboard shortcut combination – **Ctrl + Alt + K** to end. In turn, the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays a window, which reads - **\<Message>**. Select **Yes** to end the Internet Explorer process instance. Select **No** to cancel the operation.

After you end the Internet Explorer process instance, the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays a window, which reads – **Internet Explorer closed abruptly**. Select the **Reload** option to recover the closed Internet Explorer process instance. If you do not want to recover, select the **Cancel** option.

> [!Note]
> - Agent must wait until first for the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring process to detect and terminate the unresponsive Internet Explorer process instance.</br>
> - The agent must use keyboard shortcut as the last option when the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring process fails to detect the unresponsive Internet Explorer process instance.</br>
> - Using the keyboard shortcut may terminate any responsive Internet Explorer webpage causing you to lose any unsaved work.</br>
> - Agent need to use the keyboard shortcut as a last option only when terminating an Internet Explorer web page can recover the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

After you end the Internet Explorer process instance, the [pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays a window, which reads – **Internet Explorer closed abruptly**. Select the **Reload** option to recover the closed Internet Explorer process instance. If you do not want to recover, select the **Cancel** option.

## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)
