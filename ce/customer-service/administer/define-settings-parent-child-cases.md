---
title: Define settings for parent and child cases
description: Learn to define settings for parent and child cases in Dynamics 365 Customer Service.
ms.date: 06/21/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.collection:
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

You can track multiple issues for a customer or the same issue that's affecting multiple customers, using parent and child cases. For example, you could track a case where work needs to be done by other departments. The primary case or issue is called the **Parent** case. Any related cases are called **Child** cases.

## Prerequisites

[!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
[!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../../includes/proc-dont-have-correct-permissions.md)]  
  
## Set parent and child case attributes

1. In the site map of Customer Service admin center, select **Case Settings** in **Customer support**. The **Case Settings** page appears.
     
1. Select **Manage** for **Parent child case settings**.

1. In the **Case Settings** dialog, enter the following details:

    a. **Select the case attributes**: Select the mandatory case attributes whose values the child case will inherit. **Case Title** and **Customer** are mandatory attributes.

      You can view **Available** and **Selected** attributes in two lists; use the arrows **>**, **<**, **>>**, and **<<** to move the attributes from one list to another. 
  
    b. **Specify closure preference**: Select a case closure setting that defines how parent and child cases are closed. Select one of the case closure options for parent and child cases:  
  
     - **Close all child cases when parent case is closed**: As soon as the parent case is closed, all the child cases are also closed.
     - **Don't allow parent case closure until all child cases are closed**: The parent case can’t be closed until all the child cases are closed.

    c. **Maximum number of child cases**: Specify a number that denotes the number of child cases a parent case can have.

      > [!Note]
      > We recommend that you specify a smaller value for **Maximum number of child cases** to avoid performance issues when cases are resolved or merged.

1. Select **Save**.
   
### Related information

[Create and manage parent and child cases](../use/customer-service-hub-user-guide-create-and-manage-parent-and-child-cases.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
