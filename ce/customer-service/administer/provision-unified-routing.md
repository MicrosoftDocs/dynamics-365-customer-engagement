---
title: Manage unified routing in Customer Service
description: Learn how to enable unified routing in Customer Service.
ms.date: 09/05/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Manage unified routing for Customer Service

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!NOTE]
> Case information is applicable only to Customer Service.

Perform the steps mentioned in this topic to enable unified routing in Customer Service. By default, unified routing isn't enabled if Customer Service only is installed.

## Prerequisites

- Make sure that the user who enables the setting has the following:
  - Administrator role. Learn more in [Assign admin roles in the Microsoft Office 365 admin center](/microsoft-365/admin/add-users/assign-admin-roles).
  - Customer Service Representative or CSR Manager for setting up the unified routing configuration.
  - Dynamics 365 System Administrator role on the root business unit for your organization. Learn more in[Assign security roles to a user in Power Platform](/power-platform/admin/assign-security-roles) and [Create or edit business units](/power-platform/admin/create-edit-business-units).
  - Read-Write access in the Client Access License (CAL) Information. Learn more in [Create a Read-Write user account in Power Platform](/power-platform/admin/create-users#create-a-read-write-user-account). 
- Specific licensing requirements apply when you use unified routing in Dynamics 365 Customer Service and Dynamics 365 Contact Center. Learn more in [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

## Enable unified routing for Customer Service only

1. In the site map of Copilot Service admin center, select **Routing**. The **Routing** page appears.
   
1. In **Manage unified routing**, select **Manage**.

1. On the **Manage unified routing** page, turn on the toggle to **Yes** for **Unified routing**.

1. Select **Save**. A message that unified routing is being enabled appears.

If the enablement fails, go to [Dynamics 365 Customer Service and Dynamics 365 Contact Center troubleshooting](/troubleshoot/dynamics-365/customer-service/welcome-customer-service) or contact Microsoft Support to help resolve the issue.

### Enable unified routing in Customer Service with omnichannel application

When the omnichannel capabilities are available but not deployed, in the **Service Configuration Settings** page, the following message appears:

  "Some required services need to be installed before unified routing can be turned on. Please contact Microsoft Support."

When Omnichannel for Customer Service doesn't have the required solutions, the following message appears:

  "Before unified routing can be turned on, Omnichannel needs to be updated. Please contact Microsoft Support."


### Next steps

![Next step.](../media/right-arrow.png) [Set up the user as a bookable resource](users-user-profiles.md)  
![Home.](../media/home-button.png) [Process for setting up unified routing](set-up-routing-process.md)  

### Related information

[Provide consent to access data](../implement/data-access-consent.md)  
[Set up record routing](set-up-record-routing.md)  
[Enable channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels)  
