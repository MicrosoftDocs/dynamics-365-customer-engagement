---
title: "Register and use a custom workflow activity assembly (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "Learn about registering and using a custom workflow activity assembly"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 2dd2fe35-f681-4548-9b2b-5ad7c8470b8d
caps.latest.revision: 50
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Register and use a custom workflow activity assembly

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

After you compile your custom workflow activity to create an assembly, you have to register the assembly with [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement. Your custom activity then appears in the process form of [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] or [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] (on-premises) depending on which deployment you registered the custom workflow activity with.

<a name="enable_disable"></a>

## Enable or disable custom code

[!INCLUDE[cc_sdk_onpremises_note](../../includes/cc-sdk-onpremises-note.md)]
 You can use [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] to enable or disable custom workflow activities and plug-in execution for an on-premises server as described here. Alternatively, you can use the Deployment web service. For more information, see [Deployment Entities and Deployment Configuration Settings](https://msdn.microsoft.com/en-us/library/gg328063.aspx) to learn how to set the <xref:Microsoft.Xrm.Sdk.Deployment.CustomCodeSettings>.<xref:Microsoft.Xrm.Sdk.Deployment.CustomCodeSettings.AllowExternalCode> property.  

### To enable custom code

1. Open a [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] command window.
2. Add the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] PowerShell snap-in:
    ```powershell
    Add-PSSnapin Microsoft.Crm.PowerShell
    ```
3. Retrieve the current setting:
    ```powershell
    $setting = get-crmsetting customcodesettings
    ```
4. Modify the current setting:
    ```powershell
    $setting.AllowExternalCode="True"
    set-crmsetting $setting
    ```
5. Verify the setting:
    ```powershell
    get-crmsetting customcodesettings
    ```

### To disable custom code

1. Open a [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] command window.
2. Add the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] PowerShell snap-in:

    ```powershell
    Add-PSSnapin Microsoft.Crm.PowerShell
    ```

3. Retrieve the current setting:

    ```powershell
    $setting = get-crmsetting customcodesettings
    ```

4. Modify the current setting:

    ```powershell
    $setting.AllowExternalCode=0
    set-crmsetting $setting
    ```
5. Verify the setting:
    ```powershell
    get-crmsetting customcodesettings
    ```

<a name="register"></a>

## Register a custom workflow activity

 Custom workflow activity assemblies are registered using the Plug-in Registration tool. The tool provides a graphical user interface and supports registering assemblies that contain plug-ins or custom workflow activities. When registering an assembly that contains custom workflow activities with [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)], you must register the assembly in the sandbox (partial trust).

 For more information about how to register and deploy a custom activity assembly by using the tool, see [Specify the Name and Group Name for a Custom Workflow Activity](create-custom-workflow-activity.md#NameandGroupName).

> [!NOTE]
> [!INCLUDE[proc-download-plugin-registration-tool](../../includes/proc-download-plugin-registration-tool.md)] The `PluginRegistration.exe` can be added to the [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] **Tools** menu as an external tool to speed up the development process.

<a name="use"></a>

## Use a custom workflow activity in a process

After you have registered your custom workflow activity assembly, you can use it in the process designer in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].

To use your custom workflow activity in a process:

1. Sign in to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].
2. [!INCLUDE[proc_settings_processes](../../includes/proc-settings-processes.md)].
3. Create or open an existing process.
4. In the process designer, click or tap **Add Step**. Your custom workflow activity name will appear in the drop-down list.

### See also

 [Custom workflow activities (workflow assemblies)](../custom-workflow-activities-workflow-assemblies.md)<br />
 [Debug a custom workflow activity](debug-custom-workflow-activity.md)<br />
 [Register and Deploy Plug-Ins](../register-deploy-plugins.md)
