---
title: Define settings for parent and child cases (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Learn to define settings for parent and child cases in Dynamics 365 for Customer Service
keywords: Parent child cases; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 09/15/2017
ms.topic: article
ms.service: crm-online
ms.assetid: c919d10e-8881-4ba9-a609-40b11b555648
---

# Define settings for parent and child cases (Customer Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)],  you can track multiple issues for a customer, or track the same issue that's affecting multiple customers, using parent and child cases. For example, you could track a case where work needs to be done by other departments. The primary case or issue is called the parent case. Any related cases are called child cases. Before your service team can start using this feature, you'll need to go into the settings area and set up a few rules about how information will be inherited.  
  
> [!IMPORTANT]
> This feature was introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)].
  
## Set parent and child case attributes  
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2.  [!INCLUDE[proc_logo_settings](../includes/proc-logo-settings.md)]  
  
3. [!INCLUDE[proc_settings_service_mgmt](../includes/proc-settings-service-mgmt.md)]  
    
4.  Click **Parent and Child case settings**.  
  
5.  In the **Case Settings** dialog box, select the attributes that the child case will be inherit from the parent case.  
  
6.  Using the Parent and Child case settings, specify the information that will be inherited from a parent case to the child case. You can also select a case closure setting that defines how parent and child cases are closed. Select one of the case closure preference for parent and child cases:  
  
    - **Close all child cases when parent case is closed**: The parent case can’t be closed until all the child cases are closed.  
  
    - **Don’t allow parent case closure until all child cases are closed**: The parent case can’t be closed until all the child cases are closed.  
  
    > [!NOTE]
    >  If you don’t make a selection, parent and child cases are closed independently of each other. This is the default setting.  
  
7.  When you’re done, click **OK**.  
  
### See also  
[Get started with service management](../customer-service/service-manager-guide.md)</br>
[Create and manage parent and child cases (Customer Service Hub)](../customer-service/user-guide-customer-service-hub.md)</br>
[Create and manage parent and child cases (Customer Service)](../customer-service/user-guide-customer-service.md) 
  
