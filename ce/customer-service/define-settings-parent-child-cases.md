---
title: Define settings for parent and child cases (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Learn to define settings for parent and child cases in Dynamics 365 for Customer Service
keywords: Parent child cases; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shellyha
ms.date: 09/15/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: c919d10e-8881-4ba9-a609-40b11b555648
ms.custom: dyn365-customerservice
---

# Define settings for parent and child cases

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)],  you can track multiple issues for a customer, or track the same issue that's affecting multiple customers, using parent and child cases. For example, you could track a case where work needs to be done by other departments. The primary case or issue is called the parent case. Any related cases are called child cases. Before your service team can start using this feature, you'll need to go into the settings area and set up a few rules about how information will be inherited.  
  
## Set parent and child case attributes  
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2.  Go to **Service Management** > **Case Settings**.

3.  In the **Case Settings** dialog box, specify the information that will be inherited from a parent case to the child case. You can also select a case closure setting that defines how parent and child cases are closed. Select one of the case closure preference for parent and child cases:  
  
    - You can view **Available** and **Selected** attributes in the form of two lists. Using the arrows **>**, **<**, **>>**, and **<<**, you can move the attributes from one list to another. 
    
      > [!TIP]
      > To select multiple attributes, press **Shift** and select the required attributes.
  
    - **Close all child cases when parent case is closed**: The parent case can’t be closed until all the child cases are closed.  
  
    - **Don’t allow parent case closure until all child cases are closed**: The parent case can’t be closed until all the child cases are closed.  
  
    > [!NOTE]
    >  If you choose **None**, parent and child cases are closed independently of each other. This is the default setting.  
  
5.  When you’re done, select **Save**.  
  
### See also

[Create and manage parent and child cases (Customer Service Hub)](customer-service-hub-user-guide-case-sla.md#create-and-manage-parent-and-child-cases)</br>

  
