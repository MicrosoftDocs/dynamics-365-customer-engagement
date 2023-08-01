---
title: Define settings for parent and child cases (Dynamics 365 Customer Service)
description: Learn to define settings for parent and child cases in Dynamics 365 Customer Service.
ms.date: 04/27/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: bap-template
searchScope:
- D365-App-customerservicehub
- D365-Entity-incident
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Define parent and child case settings

In Dynamics 365 Customer Service, you can track multiple issues for a customer, or track the same issue that's affecting multiple customers, using parent and child cases. For example, you could track a case where work needs to be done by other departments. The primary case or issue is called the **Parent** case. Any related cases are called **Child** cases. Before your service team can start using this feature, you need to go to **Service Management** and set up a few rules about how information is inherited. 

## Prerequisites

[!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
[!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
## Set parent and child case attributes

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
     
     1. In the site map, select **Case Settings** in **Customer Support**. The **Case Settings** page appears.
     
     1. Select **Manage** for **Parent child case settings**.

   ### [Customer Service Hub](#tab/customerservicehub)
   
     - In the **Service Management** site map, select **Case Settings** in **Parent Child Case Settings**.  
  
2. In the **Case Settings** dialog, enter the following details:

    a. In **Select the attributes**, select the case attribute that the child case will inherit from the parent case.  

      You can view **Available** and **Selected** attributes in two lists; use the arrows **>**, **<**, **>>**, and **<<** to move the attributes from one list to another. 
  
    b. In **Specify closure preference**, select a case closure setting that defines how parent and child cases are closed. Select one of the case closure options for parent and child cases:  
  
   - **Close all child cases when parent case is closed**: As soon as the parent case is closed, all the child cases are also closed.
   - **Don't allow parent case closure until all child cases are closed**: The parent case can’t be closed until all the child cases are closed.

    c. In **Maximum number of child cases**, specify a number that denotes the number of child cases a parent case can have.

      > [!Note]
      > We recommend that you specify a smaller value for **Maximum number of child cases** to avoid performance issues when cases are resolved or merged.

3. Select **Save**.

### Set parent and child case attributes (Customer Service app)

1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_logo_settings](../includes/proc-logo-settings.md)]  
  
3. Choose **Settings** > **Service Management**.

4. Select **Parent and Child case settings**.  
  
5. In the **Case Settings** dialog box, select the attributes that the child case will be inherit from the parent case.  
  
6. Using the Parent and Child case settings, specify the information that will be inherited from a parent case to the child case. You can also select a case closure setting that defines how parent and child cases are closed. Select one of the case closure preference for parent and child cases:  
  
   - **Close all child cases when parent case is closed**: The parent case can’t be closed until all the child cases are closed.  
  
    > [!NOTE]
    >  If you choose **None**, parent and child cases are closed independently of each other. This is the default setting.  
  
7. When you’re done, select **OK**.  
  
### See also

[Create and manage parent and child cases](customer-service-hub-user-guide-create-and-manage-parent-and-child-cases.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
