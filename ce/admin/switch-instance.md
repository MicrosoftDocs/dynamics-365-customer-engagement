---
title: "Switch an instance | MicrosoftDocs"
ms.custom: 
ms.date: 02/27/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
ms.assetid: 8a559829-8656-41f7-baab-8dee87084c8a
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Switch an instance

Switching an instance (environment) is now done in the [Power Platform admin center](https://admin.powerplatform.microsoft.com/). See [Change the environment type](https://docs.microsoft.com/power-platform/admin/switch-environment).

<!--
[!INCLUDE[applies-to](../includes/cc_applies_to_ce.md)]

You may decide that your customization work developed and tested on a Sandbox instance is now ready to go live. If you’ve placed your Sandbox instance in administration mode, only users with System Administrator or System Customizer security roles are able to sign in to that instance. Once you switch the instance type to Production, all your users can access your organization. When you configure or edit an instance, you can switch the instance from:  
  
-   Production to Sandbox  
  
-   Sandbox to Production  
  
Switching an instance does not change the number of your purchased licenses. Review the **License considerations** section for how switching can impact license allocation.  
  
<a name="BKMK_Switch"></a>   
## Switch an instance  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  
  
2. [!INCLUDE[proc_office365_choose_admin_crm](../includes/proc-office365-choose-admin-crm.md)]  
  
3. Choose the **Instances** tab.  
  
4. Select the instance that you want, and then click **Edit**. If this is a new instance, click **Configure**.  
  
5. Under **Instance type**, choose the instance type and then click **Next**.  
  
6. Review the settings and then click **Save**.  
  
<a name="BKMK_Licenses"></a>   
## License considerations  
 Review the following table to see how switching an instance type is impacted by your licenses.  
  
|Scenario|Result|Notes|  
|--------------|------------|-----------|  
|Switch a Production instance to Sandbox. You have unused Sandbox licenses.|A Sandbox license is used.|Sandbox instances have special features such as Reset and Administration modes. See [Manage Sandbox instances](../admin/manage-sandbox-instances.md).|  
|Switch a Production instance to Sandbox. You do not have any unused Sandbox licenses. You have unused Production licenses.|A Production license is used.|Sandbox instances have special features such as Reset and Administration modes. See [Manage Sandbox instances](../admin/manage-sandbox-instances.md).|  
|Switch a Production instance to Sandbox. You do not have any unused Sandbox or Production licenses.|The Production instance is not changed. You need to purchase a Sandbox instance.|Sandbox instances have special features such as Reset and Administration modes. See [Manage Sandbox instances](../admin/manage-sandbox-instances.md).|  
|Switch a Sandbox instance to Production. You have unused Production licenses.|A Production license is used. A Sandbox instance becomes available.||  
|Switch a Sandbox instance to Production. You do not have any unused Production licenses.|You will need to purchase a Production license.|See [Add an instance to your subscription](../admin/add-instance-subscription.md).|  
  
-->