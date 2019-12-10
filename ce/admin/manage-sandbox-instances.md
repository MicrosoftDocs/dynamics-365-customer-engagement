---
title: "Manage Sandbox instances | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to:
ms.assetid: cc85ee44-cbbd-4b0d-ae00-84cc0673527b
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
manager: kvivek
search.audienceType:
  - admin
search.app:
  - D365CE
  - Powerplatform
---
# Manage Sandbox instances

[!INCLUDE[applies-to](../includes/cc_applies_to_ce.md)]

A Sandbox instance is any non-production instance of Common Data Service. Isolated from production, a Sandbox instance is the place to safely develop and test application changes with low risk.  
  
> [!NOTE]
> - With [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)], we no longer require a minimum purchase amount to receive a free Sandbox instance. If you've purchased a subscription and have not received a free Sandbox instance, you will be provided one when you purchase full Dynamics 365 Enterprise licenses. There is a limit of one free Sandbox instance per tenant. You can also purchase additional Sandbox instances. For more information, see [Pricing and licensing](https://go.microsoft.com/fwlink/p/?LinkID=321102).  
> - Check out [Switch an instance](switch-instance.md) for information on how to switch an instance to or from Sandbox and for licensing considerations.
> - Consider using the less privileged service admin role instead of the global admin role. See [Use the service admin role to manage your tenant](use-service-admin-role-manage-tenant.md).
  
<a name="BKMK_View"></a>   

## View your Sandbox instances  
 You manage your Sandbox instances from the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)].  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  
  
2. [!INCLUDE[proc_office365_choose_admin_crm](../includes/proc-office365-choose-admin-crm.md)]  
  
3. Choose the **Instances** tab.  
  
   On the **Manage your Dynamics 365 instances** page, you’ll see a list of all your instances.  
  
<a name="BKMK_Reset"></a>   

## Reset a Sandbox instance  
 You can reset a Sandbox instance to delete and re-provision it. Consider a reset when you want to:  
  
- Change to a different version of model-driven apps in Dynamics 365.  
  
- Create a new project  
  
- Free up storage space  
  
- Remove an instance containing Personally Identifiable Information (PII) data  
  
> [!NOTE]
> You can only reset Sandbox instances.

 **An example scenario**

 Thomas is looking at the storage consumed by the various Contoso instances and is getting concerned that they’ll run out of space in one of their Production instances.  He’d like to free up some space so he can give the Production instance some additional storage.  He’s also been notified that the Legal department has set a retention policy on the use of production data in the test environment.

 After contacting Isaac, Thomas resets the Sales department’s complete Sandbox instance. The instance is re-provisioned to factory settings and ready for future use as a Sandbox instance for a future project.

### To reset an instance

1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]

2. [!INCLUDE[proc_office365_choose_admin_crm](../includes/proc-office365-choose-admin-crm.md)]

3. Choose the **Instances** tab.

4. Select a Sandbox instance, and then click **Reset**.

5. On the **reset instance** page, adjust the instance settings as needed and then click **Reset**.

   > [!WARNING]
   >  The Sandbox instance will be deleted and reset to factory settings. You will not be able to recover any deleted data.  
  
6. Click **yes** in the confirmation dialog box.  
  
<a name="BKMK_AdminMode"></a>   

## Administration mode  
 When you place a Sandbox instance in administration mode only users with System Administrator or System Customizer security roles will be able to sign in to that instance. Administration mode is useful when you want to make operational changes and not have regular users affect your work, and not have your work affect regular users.  
  
> [!NOTE]
> - You can only place Sandbox instances in administration mode.
> - Processes that use code, such as plug-ins or custom workflow assemblies, continue to be processed by the version 8.2 platform when administration mode is enabled and background operations are disabled.
  
 On the **admin settings** page, you can set the following.  
  
|Setting|Description|  
|-------------|-----------------|  
|Enable administration mode|Select to enable administration mode for the selected Sandbox instance. Only System Administrators or System Customizers will be able to sign in to the selected Sandbox instance.|  
|Disable background operations|Select to disable all asynchronous operations (see [Asynchronous service architecture](../developer/asynchronous-service-architecture.md)) such as workflows and synchronization with Exchange. Emails will not be sent and server-side synchronization for appointments, contacts, and tasks are disabled. **Note:**  Administration mode must be enabled to disable background operations.|  
|Custom message for end users|Enter a message that will be displayed to all users when they attempt to sign in.|  
  
### Set administration mode  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  
  
2. [!INCLUDE[proc_office365_choose_admin_crm](../includes/proc-office365-choose-admin-crm.md)]  
  
3. Choose the **Instances** tab.  
  
4. Select a Sandbox instance, and then click **Admin**.  
  
5. Select **Enable administration mode** to enable it, and then click **Save**.  
  
