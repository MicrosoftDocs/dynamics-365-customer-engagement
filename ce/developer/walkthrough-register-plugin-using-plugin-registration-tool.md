---
title: "Walkthrough: Register a plug-in using the plug-in registration tool (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This article tells how to register a plug-in by using the Plug-in Registration tool that is provided in the SDK."
ms.custom: ""
ms.date: 01/19/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c0adf742-e0b7-4699-8972-afe0638af4e4
caps.latest.revision: 48
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Walkthrough: Register a plug-in using the plug-in registration tool

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This walkthrough demonstrates how to register a plug-in by using the Plug-in Registration tool that is provided in the SDK. The plug-in to register is the FollowupPlugin from the [Sample: Basic Plug-in](sample-create-basic-plugin.md) topic.  
  
 The plug-in is to be registered on the `account` entity, <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> message, on a post-event, and in the sandbox. The plug-in can be registered on any [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement deployment where your user account has the System Customizer or System Administrator role.  
  
 The following prerequisites must be completed before starting this walkthrough:  
  
-   Get the PluginRegistration.exe tool. [!INCLUDE[proc-download-plugin-registration-tool](../includes/proc-download-plugin-registration-tool.md)] 
  
-   Obtain a system user account on a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server.  
  
-   Your user account must have the System Customizer or System Administrator role. See [How Role-Based Security Can Be Used to Control Access to Entities In Dynamics 365](security-dev/how-role-based-security-control-access-entities.md).  
  
### Connect to the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Server  
  
1.  Run the Plug-in Registration tool.  
  
2.  Click **CREATE NEW CONNECTION**.  
  
3.  In the **Login** dialog, select the deployment type radio button corresponding to the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server you intend to register plug-ins with. The **On-premises** radio button includes an IFD deployment, the **Online** button is for the [!INCLUDE[pn_Windows_Live](../includes/pn-windows-live.md)] provider of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], and the **Office 365** button is for the [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] provider of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
    |||  
    |-|-|  
    |![Login dialog for an online deployment](media/crm-v6s-pr-login-online.PNG "Login dialog for an online deployment")<br />Login window for an online deployment|![Login window for an on&#45;premises deployment](media/crm-v6s-pr-login-onprem.png "Login window for an on-premises deployment")<br />Login window for an on-premises deployment|  
  
4.  If you check **Always display list of available orgs**, you are presented with a list of organizations that you belong to after you click **Login**. This enables you to choose the organization that you want to register the plug-in with. Otherwise, your default organization is used.  
  
5.  Enter the indicated information about the server and login account, and then click **Login**.  
  
 You should see a collapsed list of registered plug-in or custom workflow activity assemblies and service endpoints. The activity feeds and Microsoft.Crm.ObjectModel assemblies are required for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to function properly so the tool prevents you from altering them. Selecting an item in the list results in the **Properties** and **Details** tab panes displaying information about that list item.  
  
 ![The application's main window](media/crm-v6s-pr-main-window.PNG "The application's main window")  
The application’s main window  
  
### Register a plug-in assembly  
  
1.  Select an organization tab to make it active.  
  
2.  In the toolbar of the tab, click **Register** and then **Register New Assembly**.  
  
3.  In the **Register New Assembly** dialog box, click the ellipses [**…**] button to the right of the **Step#1** field.  
  
4.  In the **Open** dialog box, navigate to the location of the compiled SamplePlugin.dll assembly. You will find this assembly in the [Sample directory]/bin/Debug folder once you have run the sample [Work with Plug-ins](https://code.msdn.microsoft.com/Sample-Create-a-basic-plug-64d86ade). Select the assembly, and then click **Open**.  
  
5.  In the **Step#2** section, expand the **SamplePlugins** assembly to view all plug-ins in that assembly. Select (check) only the **Microsoft.Crm.Sdk.Samples.FollowupPlugin** plug-in.  
  
6.  In the **Step#3** section, select the **Sandbox** option.  
  
7.  In the **Step#4** section, select the **Database** option.  
  
 ![Dialog to register an assembly](media/crm-v6s-pr-assembly-registration.png "Dialog to register an assembly")  
Dialog to register an assembly  
  
8.  Click **Register Selected Plugins**. You can close any open dialog boxes.  
  
 ![A registered plug&#45;in shown in the tree view](media/crm-v6s-pr-registered-plugin.PNG "A registered plug-in shown in the tree view")  
A registered plug-in shown in the tree view  
  
    > [!TIP]
    >  Do you see an error in the **Log** area and the log contains the following message?  
    >   
    >  `<Message>Action failed for assembly 'SamplePlugins, Version=0.0.0.0, Culture=neutral, PublicKeyToken=829f574d80e89132': Deployment/Scalegroup does not allow running external code.</Message>`  
    >   
    >  If so, you must enable custom code on the server and try again. For more information see [Enable or Disable Custom Code Execution](register-deploy-plugins.md#bkmk_enablecode).  
  
 The SamplePlugins.dll assembly and FollowupPlugin plug-in are now registered and deployed to the server. If you used the tool to register a custom workflow activity assembly, the next section on registering a step does not apply.  
  
### Register a plug-in step for an event  
  
1.  In the **Registered Plug-ins & Custom Workflow Activities** tree view, expand the **(Assembly) SamplePlugins** node and select a registered plug-in.  
  
2.  Navigate to the **Register** menu in the toolbar, and then click **Register New Step**.  
  
    > [!NOTE]
    >  Plug-ins are registered to execute when an event is processed in the event execution pipeline. Each event has a stage name and number to indicate its location in the pipeline either before or after the core platform operation. A *step* refers to the SDK message processing step entity that is used to configure when and how the plug-in is to be executed.  
  
3.  Complete the **Register New Step** dialog box as shown in the following figure.  
  
 ![Dialog to register a new step](media/crm-v6s-pr-register-step.png "Dialog to register a new step")  
Dialog to register a new step  
  
4.  Click **Register New Step**.  
  
5.  Expand the **(Assembly) SamplePlugins** node and sub-nodes to see the plug-in and step nodes you created. You can now close the tool, but you may want to keep it open until after you test the plug-in and unregister the assembly.  
  
    > [!NOTE]
    >  To unregister the step, plug-in, or assembly, select its node in the tree, and then click **Unregister** in the tool bar.  To modify an assembly or step registration, double-click the assembly or step node in the tree view. Alternately, you can select the node and click **Update** in the tool bar.  
  
 The plug-in is now registered to execute in the sandbox, for an account create event, and after the core operation executes. You registered the plug-in to run asynchronously since the creation of the follow-up task activity is not time critical. After an account is created, the plug-in will execute the next time the asynchronous service processes its queue.  
  
## Test the plug-in  
 After you register the plug-in you can optionally test its execution by using the following procedure.  
  
1.  Open the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application for the same organization that you registered the plug-in assembly under.  
  
2.  Move to the workplace, select **Accounts**, and then click **New**.  
  
3.  In the **Account Name** box, type an account name, for example, `Adventure Works Cycle`, and then click **Save & Close**.  
  
4.  Double-click the form name in the **Accounts** grid to open the form.  
  
5.  Click **Activities** to display a list of related activities for the account. You should see the activity named “Send email to the new customer“ that the plug-in created.  
  
6.  If you registered the plug-in to run asynchronously, and did not select the **Delete AsyncOperation if StatusCode = Successful** option on the **Register New Step** form, there will be a new system job named “FollowupPlugin: Create of account”. To view the related system job, click **Settings**, and then click **System Jobs**. Double-click the system job previously mentioned.  
  
 You can now unregister the step, plug-in, and assembly if you want. You may also want to delete the system job and account that you created.  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Walkthrough: Configure Assembly Security for an Offline Plug-in](walkthrough-configure-assembly-security-offline-plugin.md)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Event Execution Pipeline](event-execution-pipeline.md)   
 [Plug-in Isolation, Trust, and Statistics](plugin-isolation-trusts-statistics.md)   
 [Supported Messages and Entities for Plug-ins](supported-messages-entities-plugin.md)
