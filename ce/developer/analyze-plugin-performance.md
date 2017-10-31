---
title: "Analyze plug-in performance (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The Plug-in Profiler is a tool that profiles the execution of plug-ins and custom workflow activities for an enhanced debugging experience in Visual Studio."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 17e6f8ae-c9ac-48ef-b547-3df380b9c0f7
caps.latest.revision: 43
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Analyze plug-in performance

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The *Plug-in Profiler* is a tool that profiles the execution of plug-ins and custom workflow activities for an enhanced debugging experience in 
[!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. This tool, which can be run from the Command Prompt window or from within the Plug-in Registration tool, makes developing custom code against [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement quicker and easier. In addition, users can profile the execution of failing code and send the results to the developer of the code or independent software vendor (ISV) for analysis. The developer can replay the plug-in or custom workflow activity execution and debug the code remotely even when disconnected from the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server.

The tool can be used in either the debug or replay mode. Each of these modes is described in the following sections.

<a name="debug"></a>

## Debug a plug-in using the plug-in profiler

1. Run the Plug-in Registration tool. [!INCLUDE [proc-download-plugin-registration-tool](../includes/proc-download-plugin-registration-tool.md)]
2. Click **CREATE NEW CONNECTION** to connect to a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server and organization. For more information on connecting to a server and organization, refer to the SDK topic: [Walkthrough: Register a Plug-in using the Plug-in Registration Tool](walkthrough-register-plugin-using-plugin-registration-tool.md).
3. Register a plug-in and step on the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server. Keep a copy of the debug compiled plug-in assembly on the computer where you are running the tool.
4. In the toolbar for the target organization, select **Install Profiler**. You will now see a **Plug-in Profiler** node in the list.
5. Select a plug-in step and click **Start Profiling** in the toolbar to begin profiling. You can choose how the profiler executes in the displayed **Profiler Settings** dialog.
6. Perform the operation in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] that causes the plug-in to run. For example, if the step is configured for an update to an account, then update an account.
7. If you have selected the **Exception** option in the **Profiler Settings** dialog, after the plug-in throws an exception and the **Business Process Error** dialog is displayed, click **Download Log File** and save this file. Alternately, if the plug-in does not throw an exception, click **Stop Profiling**.
8. In the Plug-in Registration tool, click **Debug**.
9. In the **Debug an Existing Plug-in** dialog box, provide the requested information in the **Setup** tab. Enter the location of the previously saved log file in the **Profile** field. Enter or select the location of the plug-in assembly and the class name of the plug-in that was executed.
10. Launch [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] and attach the debugger to the PluginRegistration.exe process.
11. Set a breakpoint in the plug-in code.
12. Click **Start Execution** in the **Debug an Existing Plug-in** dialog box.
13. After a slight delay, the plug-in will execute using the same execution context that was passed to it by the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server and the debugger will stop execution on the breakpoint that you previously set.
14. Continue debugging the plug-in as you would normally do. Any traces that the plug-in outputs are shown in the **Debug an Existing Plug-in** dialog box.

At this point you can alter the plug-in code, build it, re-attach the debugger to the PluginRegistration.exe process, and click **Start Execution** to continue with your debugging session. While performing these operations, you do not need to close the **Debug an Existing Plug-in** form.

You do not need to re-deploy the plug-in to the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server until after you have fixed the code problem. This debugging scenario works even if you have an optimized version of the plug-in on the server and a debug version of the plug-in on the computer where you are debugging.

<a name="replay"></a>

## Replay plug-in execution

 Replaying plug-in execution does not require a connection to a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server and organization. The advantage of this method is that you can obtain the plug-in execution profile from a customer and debug the plug-in remotely. A restriction of the replay feature is that you cannot change the sequence of calls your plug-in code makes in the debugger while you are debugging.

 The replay feature provides the plug-in with a snapshot of the call data and event execution context from the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server. You are getting the same events, GUIDs, and so on from calls to the Organization service but no data is being modified on the server as you debug the plug-in. During the debugging procedure in the previous section, the plug-in actually connects to the server and makes calls in real time.

*Replay plug-in execution*

1. Launch [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] and attach the debugger to the PluginRegistration.exe process.  
1. Click **REPLAY PLUG-IN EXECUTION**.
1. Enter the log and plug-in assembly locations in the dialog box.
1. Click **Start Execution**.
1. Debug the plug-in as you would normally.

<a name="run"></a>

## Run the plug-in profiler standalone

 The profiler can be executed from a Command Prompt window independent of the Plug-in Registration tool. This is useful to obtain the plug-in profile log from a customer's [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server to debug a failed plug-in. A developer can then use that log to replay the plug-in's execution in the Plug-in Registration tool and debug the plug-in using[!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].

### Procedure: Run the plug-in profiler from a command prompt

1. Open a Command Prompt window and set the working directory to the folder where you downloaded the Plug-in registration tool `PluginRegistration.exe`.
1. Type the command: `PluginProfiler.Debugger.exe /?`.  
1. Review the supported parameter list and re-run the PluginProfiler.Debugger.exe program with the appropriate parameters.  

### See also

[Developer Tools](developer-tools.md)<br />
[Solution Tools for Team Development](solution-tools-team-development.md)<br />
[Plug-in Development](plugin-development.md)<br />
[Register and Deploy Plug-ins](register-deploy-plugins.md)<br />
[Debug a Plug-in](debug-plugin.md)<br />
